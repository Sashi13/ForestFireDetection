#include <dht.h>
#include <SoftwareSerial.h>
SoftwareSerial ArduinoNano(2, 3);

#define DHTPIN A2
#define MQ135PIN A1
#define MQ9PIN A3
#define RAINPIN A0
#define FLAMEPIN 4
#define piezoPin 5
#define ledPin 6
dht dhtSensor;

float temp = 0, humd = 0;
int mq135_air_quality = 0, rain_range = 0, flame_reading = 0,  mq9_air_quality = 0;
String air_quality, flammable_gas, rain_status, fire_status, warning;
void setup() {
  Serial.begin(9600);
  ArduinoNano.begin(9600);
  pinMode(DHTPIN, INPUT);
  pinMode(MQ135PIN, INPUT);
  pinMode(MQ9PIN, INPUT);
  pinMode(RAINPIN, INPUT);
  pinMode(FLAMEPIN, INPUT);
  pinMode(piezoPin, OUTPUT);
  pinMode(ledPin, OUTPUT);
}

void loop() {
  checkDHT();
  checkAir();
  checkRain();
  checkFlame();
  checkFire();
  transmitData();
}

void checkDHT() {
  dhtSensor.read11(DHTPIN);
  temp = dhtSensor.temperature;
  humd = dhtSensor.humidity;
  Serial.print("Current humidity = ");
  Serial.println(dhtSensor.humidity);
  Serial.print("temperature = ");
  Serial.println(dhtSensor.temperature);
}

void checkAir() {
  mq135_air_quality = analogRead(MQ135PIN);
  mq9_air_quality = analogRead(MQ9PIN);
  Serial.print("MQ135 Air quality: ");
  Serial.println(mq135_air_quality);
  if (mq135_air_quality > 650) {
    air_quality = "Smoke";
  }
  else {
    air_quality = "Clean";
  }
  Serial.print("MQ9 Air quality: ");
  if (mq9_air_quality > 250) {
    flammable_gas = "Detected";
  }
  Serial.println(mq9_air_quality);
}

void checkRain() {
  int rain_reading = analogRead(RAINPIN);
  rain_range =  map(rain_reading, 0, 1023, 0, 3);
  // 0 = Raining
  // 1 = Drizzle
  // 2 = Dry
  // 3 = Very d ry
  if (rain_range == 0) {
    rain_status = "Raining";
  }
  else if (rain_range == 1) {
    rain_status = "Drizzle";
  }
  else if (rain_range == 2) {
    rain_status = "Dry";
  }
  else {
    rain_status = "Very dry";
  }
  Serial.print("Rain level: ");
  Serial.println(rain_range);
}

void checkFlame() {
  flame_reading = digitalRead(FLAMEPIN);
  Serial.print("Fire state:");
  if (flame_reading == LOW) {
    fire_status = "Flame Detected!";
    Serial.println(fire_status);
  }
  else {
    fire_status = "Normal";
    Serial.println(fire_status);
  }
}

void checkFire() {
  if (flame_reading == LOW && air_quality.equals("Smoke") && flammable_gas.equals("Detected") && temp > 38.0 && humd < 50.0) {
    warning = "Fire";
    Alarm();
  }
  else {
    warning = "Normal";
    delay(2000);
  }
  Serial.println(warning);
}

void Alarm() {
  for (int i = 0 ; i < 10; i++) {
    tone(piezoPin, 800);
    digitalWrite(ledPin, HIGH);
    delay(200);
    tone(piezoPin, 400);
    digitalWrite(ledPin, LOW);
    delay(200);
  }
  noTone(piezoPin);
}

void transmitData() {
  String tx = String(temp) + "," + String(humd) + "," + air_quality + "," + rain_status + "," + warning + "\n";
  ArduinoNano.print(tx);
  Serial.println("Data sent");
}
