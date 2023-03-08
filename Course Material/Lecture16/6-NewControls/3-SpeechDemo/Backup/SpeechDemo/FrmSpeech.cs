using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using SpeechLib;    //need for speech below

namespace SpeechDemo
{
    public partial class FrmSpeech : Form
    {
        public FrmSpeech()
        {
            InitializeComponent();
        }

        private void BtnSpeak_Click(object sender, EventArgs e)
        {
            //Before using the commands below you need to 
            //add a reference to the Microsoft Speech Object Library
            //located in the COM tab

            //create an instance of SpVoice
            SpVoice voice = new SpVoice();

            //this tells the program to speak everything in the textbox
            voice.Speak(TxtSpeech.Text, SpeechVoiceSpeakFlags.SVSFDefault);
        }
    }
}