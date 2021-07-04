using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using IBM.Cloud.SDK.Core.Authentication.Iam;
using IBM.Watson.SpeechToText.v1;
using System.IO;
using NReco.VideoConverter;
using System.Speech.Recognition;
using System.Runtime.InteropServices;


namespace RECO.Forms
{
    public partial class RunTime : Form
    {
        [DllImport("wininet.dll")]
        private extern static bool InternetGetConnectedState(out int conn, int val);

        string inputFile;
        string outputFile;
        string[] words;
        string[] times;
        string path = "..\\..\\keywords";
        double file_duration;
        List<string> keywords = new List<string>();
        public string[] images = null;
        string key = "WSVpFk8B-93eyzeLKnWOC2KecAaJgt31_XUJDSL9YHtZ";
        string url = "https://api.eu-gb.speech-to-text.watson.cloud.ibm.com/instances/11c655f6-7de0-4e5c-ab58-25d398983460";
        SpeechRecognitionEngine sr = new SpeechRecognitionEngine();

        public RunTime()
        {
            InitializeComponent();
            get_keywords(path);
        }

        private void RunTime_Load(object sender, EventArgs e)
        {
            pictureBox1.Dock = DockStyle.Fill;
            sr.SetInputToDefaultAudioDevice();
            sr.LoadGrammarAsync(new Grammar(new GrammarBuilder(new Choices("Browse", "Play", "Exit"))));
            sr.SpeechRecognized += new EventHandler<SpeechRecognizedEventArgs>(Sr_SpeechRecogized);
            sr.RecognizeAsync(RecognizeMode.Multiple);
        }
        public void get_keywords(string path)
        {
            string[] dirs = Directory.GetDirectories(path);
            int length = dirs.Length;
            for (int i = 0; i < length; i++)
            {
                FileInfo f = new FileInfo(dirs[i]);
                keywords.Add(f.Name.ToLower());
                keywords.Add(f.Name.ToUpper());
            }
        }

        private void Sr_SpeechRecogized(object sender, SpeechRecognizedEventArgs e)
        {
            string speechSaid = e.Result.Text;
            if (speechSaid == "Browse" && e.Result.Confidence > 0.90)
            {
                label3.Visible = false;
                OpenFileDialog op1 = new OpenFileDialog();
                if (op1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    if (op1.FileName != null)
                    {
                        inputFile = op1.FileName;
                        outputFile = inputFile.Substring(0, inputFile.IndexOf("."));
                    }
                }

                if (inputFile != null)
                {
                    string temp = Path.GetExtension(inputFile);
                    if (temp != ".mp3" && temp != ".mp4")
                    {
                        label6.Visible = true;
                        return;
                    }

                    pictureBox1.Visible = false;

                    if (temp == ".mp4")
                    {
                        convert_file();
                        outputFile = outputFile + ".mp3";
                    }


                    else if (temp == ".mp3")
                    {
                        outputFile = inputFile;
                    }

                    label6.Visible = false;
                    int Out;
                    if (InternetGetConnectedState(out Out, 0) == true)
                    {
                        pictureBox2.Visible = true;
                        transcribe();
                        save_to_txt();
                        pictureBox2.Visible = false;
                        label4.Visible = true;
                    }

                    else
                    {
                        label7.Visible = true;
                    }


                }




            }

            else if (speechSaid == "Play" && e.Result.Confidence > 0.90)
            {
                if (inputFile != null)
                {
                    label4.Visible = false;
                    pictureBox1.Visible = true;
                    file_reading();
                    axWindowsMediaPlayer1.URL = inputFile;
                    axWindowsMediaPlayer1.Ctlcontrols.play();
                    axWindowsMediaPlayer1.PlayStateChange += new AxWMPLib._WMPOCXEvents_PlayStateChangeEventHandler(axWindowsMediaPlayer1_PlayStateChange);
                }

            }

            else if (speechSaid == "Exit" && e.Result.Confidence > 0.90)
            {
                this.Close();
            }
        }

        public void transcribe()
        {
            string fileName = "..\\..\\response.txt";
            IamAuthenticator authenticator = new IamAuthenticator(apikey: key);
            SpeechToTextService speechtotext = new SpeechToTextService(authenticator);
            speechtotext.SetServiceUrl(url);


            var result = speechtotext.Recognize(
            audio: new MemoryStream(File.ReadAllBytes(outputFile)),
            contentType: "audio/mp3",
            keywords: keywords,
            keywordsThreshold: 0.5f
            );


            var response = result.Response;
            File.WriteAllText(fileName, response);
        }


        public void save_to_txt()
        {
            string[] text = File.ReadAllLines("..\\..\\response.txt");
            string fileName = "..\\..\\output.txt";
            string a, b, c;
            a = "\"normalized_text\": ";
            b = "\"start_time\": ";
            c = "\"end_time\": ";
            string key = "", start = "", end = "";
            List<string> keys = new List<string>();
            List<string> start_times = new List<string>();
            List<string> end_times = new List<string>();
            foreach (string line in text)
            {
                string l = line.Trim();
                if (l.StartsWith(a))
                {
                    key = l.Substring(a.Length + 1);
                    key = key.Substring(0, key.Length - 1);
                    keys.Add(key);
                }

                if (l.StartsWith(b))
                {
                    start = l.Substring(b.Length);
                    start = start.Substring(0, start.Length - 1);
                    start_times.Add(start);
                }

                if (l.StartsWith(c))
                {
                    end = l.Substring(c.Length);
                    end = end.Substring(0, end.Length - 1);
                    end_times.Add(end);
                }

            }

            if (keys != null && start_times != null && end_times != null)
            {
                if (File.Exists(fileName))
                {
                    File.Delete(fileName);
                }
                int i;
                for (i = 0; i < keys.Count; i++)
                {
                    File.AppendAllText(fileName, keys[i] + "\t" + start_times[i] + "\t" + end_times[i] + "\n");
                }
            }
        }

        public void file_reading()
        {
            string[] lines = File.ReadAllLines("..\\..\\output.txt");
            int length = lines.Length;
            words = new string[length];
            times = new string[length];

            for (int i = 0; i < lines.Length; i++)
            {
                string[] items = lines[i].Split('\t');
                words[i] = items[0];
                times[i] = items[1];
            }
        }



        private void convert_file()
        {
            var convertVideo = new FFMpegConverter();
            convertVideo.ConvertMedia(inputFile, outputFile + ".mp3", "mp3");
        }

        private void axWindowsMediaPlayer1_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
            bool flag = true;
            while (flag)
            {
                double value = get();

                if (value == file_duration)
                {
                    flag = false;
                }

                for (int i = 0; i < times.Length; i++)
                {
                    if (value.ToString() == times[i])
                    {
                        show(words[i]);
                    }
                }
            }
        }

        public void show(string id)
        {
            if (keywords.Contains(id))
            {
                images = Directory.GetFiles(path + "\\" + id);
                if (images != null && images.Length > 0)
                {
                    pictureBox1.Image = new Bitmap(images[0]);
                }
            }

        }
        private double get()
        {
            return Math.Round(axWindowsMediaPlayer1.Ctlcontrols.currentPosition, 2);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
