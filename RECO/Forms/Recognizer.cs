using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Recognition;
using System.IO;

namespace RECO.Forms
{
    public partial class Recognizer : Form
    {
        SpeechRecognitionEngine engine = new SpeechRecognitionEngine(new System.Globalization.CultureInfo("en-us"));


        public int count = 0;
        public string[] images = null;
        public string id;
        public string path;

        public Recognizer(string repopath)
        {
            InitializeComponent();
            path = repopath;
        }

        public string[] get_keywords(string path)
        {
            string[] dirs = Directory.GetDirectories(path);
            int length = dirs.Length;
            string[] keywords = new string[length + 1];

            for (int i = 0; i < length; i++)
            {
                FileInfo f = new FileInfo(dirs[i]);
                keywords[i] = f.Name;
            }

            keywords[length] = "next";

            return keywords;
        }

        public void show(string id, int i)
        {
            images = Directory.GetFiles(path + "\\" + id);
            if (images != null && images.Length > 0)
            {
                pictureBox1.Dock = DockStyle.Fill;
                pictureBox1.Hide();
                Random r = new Random();
                int rndmember = WinAPI.arr[r.Next(0, WinAPI.arr.Length)];
                pictureBox1.Image = new Bitmap(images[i]);
                WinAPI.AnimateWindow(pictureBox1.Handle, 900, rndmember);
            }
        }

        private void Recognizer_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
            string[] keywords = get_keywords(path);
            engine.SetInputToDefaultAudioDevice();
            engine.LoadGrammarAsync(new Grammar(new GrammarBuilder(new Choices(keywords))));
            engine.SpeechRecognized += new EventHandler<SpeechRecognizedEventArgs>(Default_SpeechRecognized);
            engine.RecognizeAsync(RecognizeMode.Multiple);
        }

        public void Default_SpeechRecognized(object ob, SpeechRecognizedEventArgs e)
        {


            if (e.Result.Text == "next" && e.Result.Confidence > 0.9)
            {
                if (id != null)
                {
                    count++;
                    if (count >= images.Length)
                    {
                        count = count - 1;
                    }

                    show(id, count);
                }
            }


            else
            {
                if (e.Result.Confidence > 0.9)
                {
                    id = e.Result.Text;
                    count = 0;
                    show(id, count);
                }
            }
        }


    }
}
