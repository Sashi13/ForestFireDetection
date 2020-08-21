//Relative libraries
#include <ESP8266WiFi.h>
#include <FirebaseArduino.h>
#include <SoftwareSerial.h>
//Define serial communication
SoftwareSerial esp(D3, D2);// RX, TX

//Setup firebase and wifi 
#define FIREBASE_HOST "fir-tuto-e40b0.firebaseio.com"
#define FIREBASE_AUTH "htTdphhpXtoScsobYg7V0J0bzHYcvR2qkBUhaMjG"
#define WIFI_SSID "test"
#define WIFI_PASSWORD "abcd1234"


void setup() {
  Serial.begin(9600);
  esp.begin(9600);
  pinMode(D3, INPUT);
  pinMode(D2, OUTPUT); 
  pinMode(LED_BUILTIN, OUTPUT);
  // connect to wifi.
  WiFi.begin(WIFI_SSID, WIFI_PASSWORD);
  Serial.print("connecting");
  while (WiFi.status() != WL_CONNECTED) {
    Serial.print(".");
    delay(500);
  }
  Serial.println();
  Serial.print("connected: ");
  Serial.println(WiFi.localIP());

  Firebase.begin(FIREBASE_HOST, FIREBASE_AUTH);
}

void loop(){
  //Check for any available data in serial
  if (esp.available() > 0) {
    String rx = esp.readStringUntil('\n');
    Serial.println("Data received");
    float temp = (getValue(rx, ',', 0)).toFloat();
    float humd = (getValue(rx, ',', 1)).toFloat();
    String air = getValue(rx, ',', 2);
    String rain = getValue(rx, ',', 3);
    String warning = getValue(rx, ',', 4);

    Serial.println(air);
    Serial.println(rain);
    Serial.println(warning);

    //Push data to firebase
    Firebase.setFloat("Data/Sensor/Temperature", temp);
    Firebase.setFloat("Data/Sensor/Humidity", humd);
    Firebase.setString("Data/Sensor/Air_quality", air);
    Firebase.setString("Data/Sensor/Rain", rain);
    Firebase.setString("Data/Sensor/Warning", warning);
    digitalWrite(LED_BUILTIN,LOW);
    delay(50);
    digitalWrite(LED_BUILTIN,HIGH);
    // handle error
    if (Firebase.failed()) {
      Serial.print("setting /number failed:");
      Serial.println(Firebase.error());
      return;
    }
  }
}

//Split string received from serial
String getValue(String data, char separator, int index) {
  int found = 0;
  int strIndex[] = {0, -1};
  int maxIndex = data.length() - 1;

  for (int i = 0; i <= maxIndex && found <= index; i++) {
    if (data.charAt(i) == separator || i == maxIndex) {
      //Serial.println("Working");
      found++;
      strIndex[0] = strIndex[1] + 1;
      strIndex[1] = (i == maxIndex) ? i + 1 : i;
    }
  }
  return found > index ? data.substring(strIndex[0], strIndex[1]) : "";
}
