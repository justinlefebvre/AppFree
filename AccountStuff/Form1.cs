﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech;
using System.Speech.Recognition;
using System.Speech.Synthesis;
using System.Threading;
using System.IO;

namespace AccountStuff
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FileOpener fo = new FileOpener();
            this.Hide();
            this.ShowInTaskbar = false;
            SpeechRecognitionEngine _recognizer = new SpeechRecognitionEngine();
            _recognizer.LoadGrammar(new Grammar(new GrammarBuilder("shrek")) { Name = "testGrammar" });

            _recognizer.SpeechRecognized += sr_SpeechRecognized;
            _recognizer.SetInputToDefaultAudioDevice();
            _recognizer.RecognizeAsync(RecognizeMode.Single);

            if (!File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\" + "Encryption.bin"))
            {
                File.AppendAllText(@"temp.txt", null);
                fo.EncryptFile("temp.txt", Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\" + "Encryption.bin");
                File.Delete("temp.txt");
            }
        }

        private void sr_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            this.Show();
            this.ShowInTaskbar = true;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "DieYou!((^")
            {
                this.Hide();
                var form2 = new AccountsForm();
                form2.FormClosed += (s, args) => this.Close();
                form2.Show();
            }
            //textBox1.Text = RandomPassword.Generate();
            
        }
    }
}
