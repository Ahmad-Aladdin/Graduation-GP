using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Linq;
using System.Diagnostics;
using ePOSOne.btnProduct;
using System.Threading.Tasks;
namespace RECO.Forms
{
    public partial class Repositories : Form
    {
        // private Panel Panel { get; set; }
        string _PATH;
        //   private Button DeleteButton
        Label addReposmsg { get; set; } = new Label();
        private RoundedButton EditButton { get; set; }
        private Label NothingIn { get; set; }
        private bool Frender { get; set; } = false;
        public Repositories(string? Path = null)
        {
            InitializeComponent();
            if (Path is null)
            {
                viewRepos();
            }
            else
            {
                viewRepos(Path.ToString()+@"\");
            }
            // Method to show all repos and its actions
        }
        private void NoRepoLabel(object senderLbl)
        {
            if (!Frender)
            {
                NothingIn = (Label)senderLbl;
                NothingIn.FlatStyle = FlatStyle.Flat;
                //NothingIn.BackColor = Color.FromArgb(237, 168, 116);  
                NothingIn.Text = "There Is Nothing To Show ";
                NothingIn.Font = new Font("arial", 12);
                NothingIn.Width = 350;
                NothingIn.ForeColor = Color.FromArgb(175, 240, 210);
                NothingIn.TextAlign = ContentAlignment.MiddleCenter;
                // NothingIn.Location = new Point(200,100);
                NothingIn.Size = new Size(300, 250);
                NothingIn.Dock = DockStyle.Top;
                NothingIn.Margin = new Padding(245, 30, 0, 0);
            }
        }
        private void PictureSetter(PictureBox senderBtn,string Source)
        {
            senderBtn.Location = new Point(70, 45);
            //Label label = new Label();
            //label.Text = "X";
            //label.ForeColor = Color.White;
            //label.AutoSize = true;
            //label.BackColor = Color.Transparent;
            //label.Location = new Point(0, 0);
            RoundedButton button = new();
            button.TextColor = Color.White;
           // button.BackColor = Color.FromArgb(23, 16, 30);
            button.TextAlign = ContentAlignment.MiddleCenter;
            button.Location = new Point(1,1);
            button.AutoSize = true;
            button.Text = "X";
            button.BackColor = Color.Transparent;
            button.FlatStyle = FlatStyle.Flat;
            button.OnHoverBorderColor = Color.FromArgb(183, 0, 6);
            button.OnHoverTextColor = Color.White;
            button.Size = new Size(30,30);
            button.FlatAppearance.BorderSize = 0;
            button.ButtonColor = Color.FromArgb(43, 49, 91);
            button.BorderColor = Color.FromArgb(43, 49, 91);
            button.OnHoverButtonColor = Color.FromArgb(183, 0, 6);
            senderBtn.Controls.Add(button);
            // Panel.Size = new Size(180, 100);
            senderBtn.Margin = new Padding(25);
            senderBtn.SizeMode = PictureBoxSizeMode.StretchImage;
            senderBtn.Image  = Image.FromFile(Source);
            senderBtn.Name = Source;
            senderBtn.Dock = DockStyle.Top;
            senderBtn.Size = new Size(180, 100);
            senderBtn.Click += delegate{
                string path = Environment.GetFolderPath(
                    Environment.SpecialFolder.ProgramFiles);
                var psi = new ProcessStartInfo( "rundll32.exe",
                    String.Format( "\"{0}{1}\", ImageView_Fullscreen {2}",
                  Environment.Is64BitOperatingSystem ?  path.Replace(" (x86)", "") : path,
                  @"\Windows Photo Viewer\PhotoViewer.dll",
                  Source));
                psi.UseShellExecute = false;      
               Process.Start(psi);
            };
            button.Click += delegate {
                  (button.Parent as PictureBox).Image.Dispose();
                  (button.Parent as PictureBox).Dispose();
                    Task.Delay(200);
                File.Delete(Source);
            };
        }
        private void buttonBrowse(RoundedButton senderBtn,string Source)
        {
            if (!Frender)
            {
                senderBtn.FlatStyle = FlatStyle.Flat;
                //senderBtn.BackColor = Color.FromArgb(237, 168, 116);
                senderBtn.BorderColor = Color.Yellow;
                senderBtn.ButtonColor = Color.FromArgb(35, 155, 214);
                senderBtn.OnHoverBorderColor = Color.FromArgb(85, 0, 46);
                senderBtn.TextColor = Color.FromArgb(85, 0, 46);
                senderBtn.ForeColor = Color.Red;
                senderBtn.FlatAppearance.BorderSize = 0;
                senderBtn.Text = "Browse";
                senderBtn.Font = new Font("arial", 8);
                senderBtn.TextAlign = ContentAlignment.MiddleCenter;
                senderBtn.Dock = DockStyle.Bottom;
                senderBtn.Location = new Point(70, 45);
            }
           else
            {
                senderBtn.FlatStyle = FlatStyle.Flat;
                //senderBtn.BackColor = Color.FromArgb(237, 168, 116);
                senderBtn.BorderColor = Color.Yellow;
                senderBtn.ButtonColor = Color.FromArgb(35, 155, 214);
                senderBtn.OnHoverBorderColor = Color.FromArgb(85, 0, 46);
                senderBtn.TextColor = Color.FromArgb(85, 0, 46);
                senderBtn.ForeColor = Color.Red;
                senderBtn.FlatAppearance.BorderSize = 0;
                senderBtn.Text = "Browse";
                senderBtn.Font = new Font("arial", 8);
                senderBtn.TextAlign = ContentAlignment.MiddleCenter;
                senderBtn.Dock = DockStyle.Right;
                senderBtn.Location = new Point(70, 45);
                senderBtn.Size = new Size(47, 35);
            }
            senderBtn.Click += delegate { 
            using var x = new OpenFileDialog();
               // x.InitialDirectory = @"C:\";
               // x.Filter = "Photos files (*.png,*.jpg,*.jpeg)|*.png|*.jpg|*.jpeg";
                x.Multiselect = true;
                x.ShowDialog();
                for (int i = 0; i < x.FileNames.Count(); i++)
                {
                    File.Copy(x.FileNames[i], Source + "/" + x.SafeFileNames[i]);
                }
            };
        }

        private void buttonRec(RoundedButton RecButton)
        {
            if (!Frender)
            {
                RecButton.FlatStyle = FlatStyle.Flat;
                // DeleteButton.BackColor = Color.FromArgb(21, 168, 194);
               // RecButton.ButtonColor = Color.FromArgb(21, 168, 194);
                //RecButton.OnHoverBorderColor = Color.Red;
                RecButton.OnHoverButtonColor = Color.Red;    
                RecButton.TextColor = Color.White;
               // RecButton.BorderColor = Color.Green;
                RecButton.ButtonColor = Color.MediumPurple;
                RecButton.ForeColor = Color.Red;
                RecButton.FlatAppearance.BorderSize = 0;
                //RecButton.BackColor = Color.Transparent;
                RecButton.FlatStyle = FlatStyle.Flat;
                RecButton.Text = "";
                RecButton.BringToFront(); 
                RecButton.Font = new Font("arial", 8);
                RecButton.TextAlign = ContentAlignment.MiddleCenter;
                RecButton.Location = new Point(1, 1);
                RecButton.Size = new Size(25, 25);
                //  RecButton.Dock = DockStyle.;
            }
        }

        private void buttonDelete(RoundedButton DeleteButton)
        {
            if (!Frender)
            {
                DeleteButton.FlatStyle = FlatStyle.Flat;
                // DeleteButton.BackColor = Color.FromArgb(21, 168, 194);
                DeleteButton.ButtonColor = Color.FromArgb(21, 168, 194);
                DeleteButton.OnHoverBorderColor = Color.FromArgb(85, 0, 46);
                DeleteButton.TextColor = Color.FromArgb(85, 0, 46);
                DeleteButton.BorderColor = Color.Yellow;
                DeleteButton.ForeColor = Color.Red;
                DeleteButton.FlatAppearance.BorderSize = 0;
                DeleteButton.Text = "Delete";
                DeleteButton.Font = new Font("arial", 8);
                DeleteButton.TextAlign = ContentAlignment.MiddleCenter;
                DeleteButton.Location = new Point(70, 45);
                DeleteButton.Dock = DockStyle.Bottom;
            }
            else
            {
                DeleteButton.FlatStyle = FlatStyle.Flat;
                // DeleteButton.BackColor = Color.FromArgb(21, 168, 194);
                DeleteButton.ButtonColor = Color.FromArgb(21, 168, 194);
                DeleteButton.OnHoverBorderColor = Color.FromArgb(85, 0, 46);
                DeleteButton.TextColor = Color.FromArgb(85, 0, 46);
                DeleteButton.BorderColor = Color.Yellow;
                DeleteButton.ForeColor = Color.Red;
                DeleteButton.FlatAppearance.BorderSize = 0;
                DeleteButton.Text = "Delete";
                DeleteButton.Font = new Font("arial", 8);
                DeleteButton.TextAlign = ContentAlignment.MiddleCenter;
                DeleteButton.Location = new Point(70, 45);
                DeleteButton.Size = new Size(42, 35);
                DeleteButton.Dock = DockStyle.Right;
            }
        }
        void Delete(RoundedButton DeleteButton,string allDirpath, Panel panel)
        {
            DeleteButton.Click += delegate // delete button action
            {
                DeleteDialogeMessage delete = new DeleteDialogeMessage();
                delete.Show();
                Done done = new Done();
                delete.Yes.Click += delegate
                {
                    if (Frender)
                    {
                        DirectoryInfo x = new DirectoryInfo(allDirpath);
                        while (x.GetFiles().Length > 0)
                        {
                            foreach (PictureBox item in flowLayoutPanel2.Controls)
                            {
                                item.Image = null;
                            }
                            if (flowLayoutPanel2.Controls.Count > 0)
                            {
                                try
                                {
                                    flowLayoutPanel2.Controls.RemoveAt(flowLayoutPanel2.Controls.Count - 1);
                                }
                                catch
                                {
                                }
                            }
                            //        flowLayoutPanel2.Controls.Clear();
                            Task.Delay(200);
                            foreach (var item in x.GetFiles())
                            {
                                try
                                {
                                    File.Delete(item.FullName);
                                    // MessageBox.Show($"You have {x.GetFiles().Length } left to be deleted");
                                }
                                catch
                                {
                                }
                            }
                        }
                    }
                    else
                    {
                        DirectoryInfo x = new DirectoryInfo(allDirpath);
                        foreach (var item in x.GetDirectories())
                        {
                            foreach (var file in item.GetFiles())
                            {
                                try
                                {
                                    File.Delete(file.FullName);
                                }
                                catch
                                {
                                }
                            }
                            try
                            {
                                Directory.Delete(item.FullName);
                            }
                            catch
                            {
                            }
                        }
                    }
                    if (Directory.Exists(allDirpath))
                    {
                        Directory.Delete(allDirpath);
                    }
                    foreach (Control item in panel.Controls)
                    {
                        item.Dispose();
                    }
                    panel.Dispose();
                    delete.Dispose();
                    delete.Close();
                    done.Show();
                    NoRepoLabel(addReposmsg);
                    if (flowLayoutPanel1.Controls.Count is 1)
                        addReposmsg.Visible = true;
                    else addReposmsg.Visible = false;
                    if (Frender)
                    {
                        addReposmsg.Visible = false;
                    }
                };
            };
        }
        private void buttonEdit(object senderBtn)
        {
            if (!Frender) 
            {
                EditButton = (RoundedButton)senderBtn;
                // EditButton.FlatStyle = FlatStyle.Flat;
                EditButton.FlatStyle = FlatStyle.Flat;
                // EditButton.ButtonColor = Color.FromArgb ()
                EditButton.ButtonColor = Color.FromArgb(33, 213, 217);
                EditButton.OnHoverBorderColor = Color.FromArgb(85, 0, 46);
                EditButton.ForeColor = Color.Red;
                // EditButton.BorderColor = Color.FromArgb(44, 43, 97);
                EditButton.Text = "Edit";
                EditButton.TextColor = Color.FromArgb(85, 0, 46);
                EditButton.Font = new Font("arial", 8);
                EditButton.FlatAppearance.BorderSize = 0;
                EditButton.TextAlign = ContentAlignment.MiddleCenter;
                EditButton.Location = new Point(70, 45);
                EditButton.Dock = DockStyle.Bottom;
                EditButton.BorderColor = Color.Yellow;
                EditButton.Size = new Size(20, 20);
            }
            else
            {
                EditButton = (RoundedButton)senderBtn;
                // EditButton.FlatStyle = FlatStyle.Flat;
                EditButton.FlatStyle = FlatStyle.Flat;
                // EditButton.ButtonColor = Color.FromArgb ()
                EditButton.ButtonColor = Color.FromArgb(33, 213, 217);
                EditButton.OnHoverBorderColor = Color.FromArgb(85, 0, 46);
                EditButton.ForeColor = Color.Red;
                // EditButton.BorderColor = Color.FromArgb(44, 43, 97);
                EditButton.Text = "Edit";
                EditButton.FlatAppearance.BorderSize = 0;
                EditButton.TextColor = Color.FromArgb(85, 0, 46);
                EditButton.Font = new Font("arial", 8);
                EditButton.TextAlign = ContentAlignment.MiddleCenter;
                EditButton.Location = new Point(70, 45);
                EditButton.Dock = DockStyle.Right;
                EditButton.Size = new Size(42, 35);
                EditButton.BorderColor = Color.Yellow;
            }    
        }
        private void PanelView(Panel senderPnl, Label label,string allDirpath)
        {
            if (!Frender)
            {
                senderPnl.BackColor = Color.FromArgb(44, 43, 97);
                senderPnl.ForeColor = Color.White;
                senderPnl.Margin = new Padding(12);
                senderPnl.BorderStyle = BorderStyle.Fixed3D;
                senderPnl.Location = new Point(56, 90);
                senderPnl.Size = new Size(180, 100);
                label.BorderStyle = BorderStyle.None;
                label.Font = new Font("Comic Sans MS", 12, FontStyle.Bold);
                label.ForeColor = Color.White;
                label.Size = new Size(50, 40);
                label.TextAlign = ContentAlignment.MiddleCenter;
                label.Margin = new Padding(7);
                label.Location = new Point(30, 10);
                label.Dock = DockStyle.Top;
            }
            else
            {
                senderPnl.BackColor = Color.FromArgb(44, 43, 97);
                senderPnl.ForeColor = Color.White;
                senderPnl.Margin = new Padding(7);
                senderPnl.BorderStyle = BorderStyle.Fixed3D;
                senderPnl.Location = new Point(56, 90);
                senderPnl.Size = new Size(255, 40);
                label.BorderStyle = BorderStyle.None;
                label.Font = new Font("Comic Sans MS", 12, FontStyle.Bold);
                label.ForeColor = Color.White;
               // label.Dock = DockStyle.Left;
                label.TextAlign = ContentAlignment.MiddleLeft;
                label.Margin = new Padding(5);
                label.Size = new Size(50, 35);
                label.Location = new Point(30, 10);
                label.Dock = DockStyle.Fill;
            }
            label.Click += delegate
            {
                foreach (PictureBox item in flowLayoutPanel2.Controls)
                {
                    item.Image.Dispose();
                    item.Dispose();
                    flowLayoutPanel2.Controls.Clear();
                }
                //  KeyWords keyWords = new KeyWords(allDirpath);
                if (Frender)
                {
                    DirectoryInfo DirectoryInfo = new DirectoryInfo($@"{allDirpath}"); // get all info
                    foreach (FileInfo item in DirectoryInfo.GetFiles())
                    {
                        if (Path.GetExtension(item.FullName).ToLower() is ".jpg" or ".png")
                        {
                            PictureBox PictureBox = new();
                            PictureSetter(PictureBox, item.FullName);
                            flowLayoutPanel2.Controls.Add(PictureBox);
                        }
                    }
                    return;
                }
                else
                {
                    Frender = true;
                    viewRepos(allDirpath);
                }
            };


        }
         //this label handle empty "All repos folder"
        public string CheckName(string content,string path)
        {
            string compare = "default";
            DirectoryInfo di = new DirectoryInfo(path); // get all info
            // Get a reference to each directory in that directory
            DirectoryInfo[] dirArr = di.GetDirectories();
            foreach (DirectoryInfo dri in dirArr)
            {
                if (dri.Name == content)
                {
                    compare = content;
                }
            }
            return compare;
        }



            public void viewRepos(string path = @"D:\AllRepos\")
        {
            if (Frender)
            {
                 flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(23, 16, 30);
                flowLayoutPanel1.Width = 290;
                flowLayoutPanel1.Height += 100;
                flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left))));
                flowLayoutPanel2.Visible = true;
                foreach (PictureBox item in flowLayoutPanel2.Controls)
                {
                    item.Image.Dispose();
                    item.Dispose();
                }
            }
            flowLayoutPanel1.Controls.Clear();

            _PATH = path+@"\";
            /* ALGORITHM 
             
            1) get all dirs in the path
            2) Check if the path is not empty
            3) Show all folders As "labels", and each label is under "flow layout panel", each panel has 2 buttons , remove button and rename button

            */
            // Make a reference to a directory
            //path
            string[] dirs = System.IO.Directory.GetDirectories(path);// add all dirs in an array to check if it empty or not
            DirectoryInfo di = new DirectoryInfo(path); // get all info

            // Get a reference to each directory in that directory
            DirectoryInfo[] dirArr = di.GetDirectories();
            int i = 0;
            // Display the names of the directories.

            if ((dirs.Length != 0))
            {
                foreach (DirectoryInfo dri in dirArr.OrderBy(_ => _.Name))
                {
                    string allDirpath = path + @"\" + dri.Name;
                    RoundedButton button_x = new RoundedButton(); // remove button
                    RoundedButton button_O = new RoundedButton();
                    Label repoNamelable = new Label(); // """label that holds the repo name
                    Panel panel = new Panel();
                    panel.Text = dri.Name;
                    panel.Tag = i;
                    repoNamelable.Text = dri.Name;
                    panel.Controls.Add(repoNamelable);
                    PanelView(panel, repoNamelable, allDirpath);
                    if (Frender)
                    {
                        RoundedButton Browse = new();
                        buttonBrowse(Browse, allDirpath);
                        panel.Controls.Add(Browse);
                    }
                    // the panel holds dir name button && remove button && rename button
                    RoundedButton repoRename = new(); // the I button , next to remove button
                    //Delete(button_x, allDirpath, panel);
                    //buttonDelete(button_x);
                    buttonEdit(repoRename);



                    repoRename.Click += delegate //rename button
                    {
                        EditDialogeMessage edit = new EditDialogeMessage();
                        edit.Show();
                        int parsedValue;
                        string content;
                        var defualt = repoNamelable.Text;
                        edit.EditBtn.Click += delegate
                        {

                            content = edit.RenameRepoTxtBox.Text;


                            if (String.IsNullOrEmpty(content) || String.IsNullOrWhiteSpace(content)) // if the input is null, handle it
                            {
                                MessageBox.Show("Please, Enter a valid repo name", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);

                            }
                            else if (int.TryParse(content, out parsedValue)) // if it number, handle it
                            {
                                Convert.ToInt64(content);
                                MessageBox.Show("Repo name Cannot be number", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);

                            }

                            else if (content == repoNamelable.Text)
                            {

                                Done done = new Done();
                                done.Show();
                            }

                            else if (content == CheckName(content, path))
                            {
                                MessageBox.Show("Repo name is already exists", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }

                            else
                            {
                                DirectoryInfo di = new DirectoryInfo(allDirpath); // get all info
                                di.Rename(_PATH + content);
                                //Microsoft.VisualBasic.FileIO.FileSystem.RenameDirectory(allDirpath, _PATH + content);
                                allDirpath = _PATH + content;
                              
                                repoNamelable.Text = content;
                                // MessageBox.Show(allDirpath);
                                edit.Dispose();
                               
                            }

                        };



                    };

                    button_O.Click += delegate
                    {
                        string repopath = path + repoNamelable.Text;
                        Recognizer r = new Recognizer(repopath);
                        r.Show();
                    };
                    if (!Frender) { 
                    Delete(button_x, allDirpath, panel);
                    buttonDelete(button_x);
                    buttonEdit(repoRename);
                    buttonRec(button_O);
                    panel.Controls.Add(button_x);
                    panel.Controls.Add(repoNamelable);
                    panel.Controls.Add(repoRename);
                    repoNamelable.Controls.Add(button_O);
                      }
                    else {
                        Delete(button_x, allDirpath, panel);
                        buttonDelete(button_x);
                        buttonEdit(repoRename);
                        buttonRec(button_O);
                        panel.Controls.Add(button_x);
                        panel.Controls.Add(repoNamelable);
                        panel.Controls.Add(repoRename);
                    }
                    flowLayoutPanel1.Controls.Add(panel); // add the panel itself to the flow panel
                    i++;
    }//end foreach
         
            }//end if
             NoRepoLabel(addReposmsg);
                if (flowLayoutPanel1.Controls.Count is 0)   
                flowLayoutPanel1.Controls.Add(addReposmsg);
            else addReposmsg.Visible = false;
        }//end viewropos msg




        private void iconButton1_Click(object sender, EventArgs e)
        {
            // addReposmsg.Dispose(); // if user v
       
            string path = _PATH ; //path
           //  MessageBox.Show((System.IO.Directory.GetDirectories(path).OrderBy(_ =>(_.Length,_)).LastOrDefault()));
            int directoryCount = System.IO.Directory.GetDirectories(path).Length;
            int G = 2;
            string createdName =" ";
            foreach (var item in System.IO.Directory.GetDirectories(path))
            {
                if (!Frender) 
                {
                    if (item == $@"{path} New Repo ({G})")
                    {
                        G++;
                        createdName = $"New Repo ({G})";
                        //      MessageBox.Show($@"{path} {createdName}");
                        if ((System.IO.Directory.GetDirectories(path).OrderBy(_ => (_.Length, _)).LastOrDefault() == $@"{path} {createdName}"))
                        {
                            createdName = $"New Repo ({++G})";
                            break;
                        }
                    }
                    else
                    {
                        createdName = $"New Repo ({G})";
                        //      MessageBox.Show($@"{path} {createdName}");
                        if (System.IO.Directory.GetDirectories($@"{path}").Contains($@"{path} {createdName}"))
                        {
                            G++;
                            if ((System.IO.Directory.GetDirectories(path).OrderBy(_ => (_.Length, _)).LastOrDefault() == $@"{path} {createdName}"))
                            {
                                createdName = $"New Repo ({G})";
                                break;
                            }
                        }
                        else
                        {
                            createdName = $"New Repo ({G})";
                            break;
                        }
                    }
                }
                else
                {
                    if (item == $@"{path} Keyword ({G})")
                    {
                        G++;
                        createdName = $"Keyword ({G})";
                        //      MessageBox.Show($@"{path} {createdName}");
                        if ((System.IO.Directory.GetDirectories(path).OrderBy(_ => (_.Length, _)).LastOrDefault() == $@"{path} {createdName}"))
                        {
                            createdName = $"Keyword ({++G})";
                            break;
                        }
                    }
                    else
                    {
                        createdName = $"Keyword ({G})";
                        //      MessageBox.Show($@"{path} {createdName}");
                        if (System.IO.Directory.GetDirectories($@"{path}").Contains($@"{path} {createdName}"))
                        {
                            G++;
                            if ((System.IO.Directory.GetDirectories(path).OrderBy(_ => (_.Length, _)).LastOrDefault() == $@"{path} {createdName}"))
                            {
                                createdName = $"Keyword ({G})";
                                break;
                            }
                        }
                        else
                        {
                            createdName = $"Keyword ({G})";
                            break;
                        }
                    }
                }
            }
            //  int Number = directoryCount + 1;
       //     MessageBox.Show($@"{path} {createdName}");
       if (!Frender) 
            {
                if (string.IsNullOrWhiteSpace(createdName))
                {
                    createdName = "Repo";
                }
            }
       else
            {
                if (string.IsNullOrWhiteSpace(createdName))
                {
                    createdName = "Keyword";
                }
            }
            
            string dir = @$"{path} {createdName}";
            // If directory does not exist, create it
            if (!Directory.Exists(dir))
            {
                Directory.CreateDirectory(dir);
 
                DirectoryInfo d = new DirectoryInfo(dir);
                RoundedButton button_x = new RoundedButton() ;
                RoundedButton button_O = new RoundedButton();
                Panel panel = new Panel();
                Label repoName = new Label();
                repoName.Text = createdName;
                PanelView(panel, repoName,dir);
        

                if (Frender)
                {
                    RoundedButton Browse = new();
                    buttonBrowse(Browse, dir);
                    panel.Controls.Add(Browse);
                }
                RoundedButton repoRename = new();
                if (!Frender)
                {
                   
                    buttonEdit(repoRename);

                    Delete(button_x, dir, panel);
                    buttonDelete(button_x);
                    buttonRec(button_O);
                    panel.Controls.Add(repoName);
                    panel.Controls.Add(button_x);
                    panel.Controls.Add(repoRename);
                    repoName.Controls.Add(button_O);
                }
                else
                {
                    buttonEdit(repoRename);
                    Delete(button_x, dir, panel);
                    buttonDelete(button_x);
                    buttonRec(button_O);
                    panel.Controls.Add(repoName);
                    panel.Controls.Add(button_x);
                    panel.Controls.Add(repoRename);
                }

                repoRename.Click += delegate //rename button
                {
                    EditDialogeMessage edit = new EditDialogeMessage();
                    edit.Show();
                    int parsedValue;
                    string content;
                    var defualt = repoName.Text;
                    edit.EditBtn.Click += delegate
                    {

                        content = edit.RenameRepoTxtBox.Text;


                        if (String.IsNullOrEmpty(content) || String.IsNullOrWhiteSpace(content)) // if the input is null, handle it
                        {
                            MessageBox.Show("Please, Enter a valid repo name", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }
                        else if (int.TryParse(content, out parsedValue)) // if it number, handle it
                        {
                            Convert.ToInt64(content);
                            MessageBox.Show("Repo name Cannot be number", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }

                        else if (content == repoName.Text)
                        {

                            Done done = new Done();
                            done.Show();
                        }

                        else if (content == CheckName(content,path))
                        {
                            MessageBox.Show("Repo name is already exists", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                        else
                        {
                            Directory.Move(d.FullName, Path.Combine(d.Name, path + content));
                            Done done = new Done();
                            done.Show();
                        }
                    };//end delegete 
                };

                string[] dirs = Directory.GetDirectories(path);
                button_O.Click += delegate
                {
                    if (dirs.Contains(repoName.Text))
                    {
                        string repopath = path + repoName.Text;
                        Recognizer r = new Recognizer(repopath);
                        r.Show();
                    }   
                };
         
                //};//end deleget 
                flowLayoutPanel1.Controls.Add(panel);                // add the panel to the layout panel " The smallest panel => panel, the big one => flow layout panel

              
            }
            if (!flowLayoutPanel1.Controls.Contains(addReposmsg))
            {
                flowLayoutPanel1.Controls.Add(addReposmsg);
            }
            if (flowLayoutPanel1.Controls.Count is 1)
                addReposmsg.Visible = true;
            else addReposmsg.Visible = false;
        }

 

        private void Repositories_FormClosed_1(object sender, FormClosedEventArgs e)
        {
            foreach (PictureBox item in flowLayoutPanel2.Controls)
            {
                item.Image.Dispose();
            }
            Dispose();
        }
    }

}