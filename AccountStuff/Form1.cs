using System;
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
            //this.Hide();
            //this.ShowInTaskbar = false;
            SpeechRecognitionEngine _recognizer = new SpeechRecognitionEngine();
            _recognizer.LoadGrammar(new Grammar(new GrammarBuilder("i love tsm")) { Name = "testGrammar" });

            _recognizer.SpeechRecognized += sr_SpeechRecognized;
            _recognizer.SetInputToDefaultAudioDevice();
            _recognizer.RecognizeAsync(RecognizeMode.Multiple);
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

            }
            //textBox1.Text = RandomPassword.Generate();
            
        }
    }
}
