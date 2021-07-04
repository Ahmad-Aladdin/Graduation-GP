using System;
using System.Drawing;
using System.Windows.Forms;
using System.Speech.Recognition;
using System.Speech.Synthesis;
using System.IO;

namespace RECO.Forms
{
    public partial class Recognizer : Form
    {
        SpeechRecognitionEngine engine = new SpeechRecognitionEngine(new System.Globalization.CultureInfo("en-us"));
        SpeechRecognitionEngine engine2 = new SpeechRecognitionEngine(new System.Globalization.CultureInfo("en-us"));
        SpeechSynthesizer reco = new SpeechSynthesizer();

        public int count = 0;
        public string[] images = null;
        public string id;
        public string path;

        public Recognizer(string repopath)
        {
            InitializeComponent();
			path = repopath;
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
            engine2.SetInputToDefaultAudioDevice();
            engine2.LoadGrammarAsync(new Grammar(new GrammarBuilder(new Choices("wake up"))));
            engine2.SpeechRecognized += new EventHandler<SpeechRecognizedEventArgs>(engine2_SpeechRecognized);
        }

		public string[] get_keywords(string path)
		{
			string[] dirs = Directory.GetDirectories(path);
			int length = dirs.Length;
			string[] keywords = new string[length + 3];

			for (int i = 0; i < length; i++)
			{
				FileInfo f = new FileInfo(dirs[i]);
				keywords[i] = f.Name;
			}

			keywords[length] = "pause";
			keywords[length + 1] = "next";
			keywords[length + 2] = "exit";

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

		public void engine2_SpeechRecognized(object ob, SpeechRecognizedEventArgs e)
		{
			if (e.Result.Confidence > 0.9)
			{
				engine2.RecognizeAsyncCancel();
				reco.SpeakAsync("yes");
				engine.RecognizeAsync(RecognizeMode.Multiple);
			}

		}
		public void Default_SpeechRecognized(object ob, SpeechRecognizedEventArgs e)
		{
			if (e.Result.Text == "pause" && e.Result.Confidence > 0.9)
			{
				reco.SpeakAsync("if you need me just ask");
				engine.RecognizeAsyncCancel();
				engine2.RecognizeAsync(RecognizeMode.Multiple);
			}

			else if (e.Result.Text == "next" && e.Result.Confidence > 0.9)
			{
				if (id != null)
				{
					count++;
					if (count >= images.Length)
						count = count - 1;
					show(id, count);
				}
			}

			else if (e.Result.Text == "exit" && e.Result.Confidence > 0.9)
				this.Close();

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
