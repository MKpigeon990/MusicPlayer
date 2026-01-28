using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using NAudio.Wave;

namespace MusicPlayer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        String[] paths, files;
        

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void songList_SelectedIndexChanged(object sender, EventArgs e)
        {
            

            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //THIS IS THE PLAY BUTTON
            music("play");
            
        }

        private void stopButton_Click(object sender, EventArgs e) {
            music("stop");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            ofd.Multiselect = true;
            if (ofd.ShowDialog()==System.Windows.Forms.DialogResult.OK)     // I HAVE TO GUESS THIS CHECK TO MAKE SURE THE RESULT IS AN EXISTING PATH
            {
                files = ofd.SafeFileNames;
                paths = ofd.FileNames;

                for(int i=0; i<files.Length; i++)
                {
                    songList.Items.Add(files[i]); //display songs in box
                }
            }
        }


        public void music(string action)
        {   
            var audioFile = new AudioFileReader(paths[songList.SelectedIndex]);
            var outputDevice = new WaveOutEvent();
            var isPlaying = false;


            if(action == "play")
            {
                outputDevice.Init(audioFile);

                outputDevice.Play();
            }
            
            if(action == "stop")
            {
                Console.WriteLine("attempting to stop");
                outputDevice.Init(audioFile);
            }

        }

    }
}
