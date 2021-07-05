using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Speech.Recognition;
using System.Speech.Synthesis;
using System.IO;
using System.Media;
using System.Diagnostics;

namespace RECO.Forms
{
    public partial class Listen : Form
    {
        public bool Wake = false;
        public bool search = false;

        formMain Main = new formMain();

        public Listen()
        {
            InitializeComponent();
        }
        SpeechSynthesizer ss = new SpeechSynthesizer();
        SpeechRecognitionEngine sr = new SpeechRecognitionEngine();
        PromptBuilder pb = new PromptBuilder();

        private void btnStart_Click(object sender, EventArgs e)
        {
            ss.SelectVoiceByHints(VoiceGender.Male);
            Choices list = new Choices();
            list.Add(File.ReadAllLines(@"C:\Users\a7med\OneDrive\Desktop\RECO\RECO\commands\commands.txt"));
            Grammar gm = new Grammar(new GrammarBuilder(list));

            if (pictureBox2.Visible == true)
            {
                pictureBox1.Visible = true;
                pictureBox2.Visible = false;
                btnStart.Text = "Stop";

            }
            else if (pictureBox1.Visible == true)
            {
                pictureBox2.Visible = true;
                pictureBox1.Visible = false;
                btnStart.Text = "Start listening";
                sr.RecognizeAsyncStop();
            }
            try
            {
                sr.RequestRecognizerUpdate();
                sr.LoadGrammar(gm);
                sr.SpeechRecognized += Sr_SpeechRecogized;
                sr.SetInputToDefaultAudioDevice();
                sr.RecognizeAsync(RecognizeMode.Multiple);

            }
            catch
            {
                return;
            }
            pb.ClearContent();
            pb.AppendText(richText.Text);
            ss.Speak(pb);
        }
        public void Say(string phrase)
        {
            ss.SpeakAsync(phrase);
            Wake = false;
        }
        private void Sr_SpeechRecogized(object sender, SpeechRecognizedEventArgs e)
        {
            string speechSaid = e.Result.Text;

            if (speechSaid == "hey reco")
            {
                SoundPlayer player = new SoundPlayer(@"C:\Users\a7med\OneDrive\Desktop\RECO\RECO\sounds\google.wav");
                player.Play();
                Wake = true;
            }

            if (speechSaid == "exit")
            {
                ss.Speak("shutting down");
                Application.Exit();
            }

            if (search)
            {
                ss.Speak("here is the result for you");
                Process.Start(@"C:\Program Files\Google\Chrome\Application\chrome.exe", @"https://www.google.com/search?q=" + speechSaid);
                search = false;
            }

            if (Wake == true && search == false)
            {
                switch (speechSaid)
                {
                    case ("search for"):
                        search = true;
                        break;

                    case ("hello"):
                        Say("hi..how can i help you");
                        break;

                    case ("how are you"):
                        Say("im good , how about you");
                        break;

                    case ("google"):
                        Say("opening google");
                        Process.Start(@"C:\Program Files\Google\Chrome\Application\chrome.exe", @"http://www.google.com/");
                        break;

                    case ("open chrome"):
                        Say("opening chrome");
                        Process.Start(@"C:\Program Files\Google\Chrome\Application\chrome.exe");
                        break;

                    case ("close"):
                        Say("closing program");
                        SendKeys.Send("%{f4}");
                        break;

                    case ("open youtube"):
                        Say("opening youtube");
                        Process.Start(@"C:\Program Files\Google\Chrome\Application\chrome.exe", @"http://www.youtube.com/");
                        break;

                    case ("what day we are in"):
                        Say("today is" + DateTime.Now.ToShortDateString());
                        break;

                    case ("what time is it"):
                        Say("it is" + DateTime.Now.ToShortTimeString());
                        break;

                    case ("open notepad"):
                        Say("opening notepad");
                        Process.Start("notepad.exe");
                        break;

                    case ("close tab"):
                        Say("closing tab");
                        SendKeys.Send("^w");
                        break;

                    case ("new tab"):
                        Say("opening new tab");
                        SendKeys.Send("^t");
                        break;

                    case ("scroll down"):
                        SendKeys.Send("{PGDN}");
                        break;

                    case ("scroll up"):
                        SendKeys.Send("{PGUP}");
                        break;

                    case ("last tab"):
                        Say("opening last tab");
                        SendKeys.Send("^+t");
                        break;

                    case ("save"):
                        Say("saving");
                        SendKeys.Send("^s");
                        break;

                    case ("next"):
                        Say("done");
                        SendKeys.Send("^{RIGHT}");
                        break;

                    case ("previous"):
                        Say("done");
                        SendKeys.Send("^{LEFT}");
                        break;

                    case ("go up"):
                        Say("done");
                        SendKeys.Send("{UP}");
                        break;

                    case ("go down"):
                        Say("done");
                        SendKeys.Send("{DOWN}");
                        break;

                    case ("pause"):
                        Say("done");
                        SendKeys.Send("{BREAK}");
                        break;

                    case ("minimize"):
                        Say("minimizing window");
                        Main.WindowState = FormWindowState.Minimized;
                        break;

                    case ("maximize"):
                        Say("maximizing window");
                        Main.WindowState = FormWindowState.Maximized;
                        break;

                    case ("normal"):
                        Say("setting window to normal");
                        this.WindowState = FormWindowState.Normal;
                        break;
                }

            }
            /*  switch (speechSaid)
              {
                  case ("hello"):
                      Say("hi.. how can i help you");
                      break;
              }*/
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pictureBox1.BringToFront();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
