using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;

namespace Firebase
{
    public partial class Form1 : Form
    {

        //Setup firebase

        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "htTdphhpXtoScsobYg7V0J0bzHYcvR2qkBUhaMjG",
            BasePath = "https://fir-tuto-e40b0.firebaseio.com/"

        };
        IFirebaseClient client = null;

        public Form1()
        {
            InitializeComponent();

        }

        //Retrieve data from firebase
        private async void retrieveData()
        {
            while (true)
            {
                FirebaseResponse get = await client.GetTaskAsync("Data/Sensor/");
                Data obj = get.ResultAs<Data>();
                System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"D:\Embedded\Main_Code\Firebase\src\alarm.wav");

                //Set the received value on gui
                tmp_label.Text = obj.Temperature;
                hmd_label.Text = obj.Humidity;
                aq_label.Text = obj.Air_quality;
                rm_label.Text = obj.Rain;
                String warning = obj.Warning;

                //If fire detected open warning message and play the alarm
                if (warning.Equals("Fire"))
                {
                   
                    player.Play();
                    DialogResult dresult = MessageBox.Show("Fire detected at forest!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    if(dresult == DialogResult.OK)
                    {
                        var data = new Data
                        {
                            Temperature = tmp_label.Text,
                            Humidity = hmd_label.Text,
                            Air_quality = aq_label.Text,
                            Rain = rm_label.Text,
                            Warning = "Normal"
                        };
                        FirebaseResponse response = await client.UpdateTaskAsync("Data/Sensor", data);

                        Data obje = get.ResultAs<Data>();
                       
                        player.Stop();
                        
                    }
                    else
                    {
                        player.Play();
                    }
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            while (true)
            {
                //Connect to firebase
                client = new FireSharp.FirebaseClient(config);
                if(client != null)
                {
                    break;
                }
            }
            retrieveData();
        }
    }
}


