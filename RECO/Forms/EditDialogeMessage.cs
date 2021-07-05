using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RECO.Forms
{
    public partial class EditDialogeMessage : Form
    {
        public static string PassingTxt;
        public EditDialogeMessage()
        {
            InitializeComponent();
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void RenameRepoTxtBox_Click(object sender, EventArgs e)
        {

        }

       

        //private void EditBtn_Click(object sender, EventArgs e)
        //{

        //}

        //private void InputTextField_TextChanged(object sender, EventArgs e)
        //{
        //    PassingTxt = RenameRepoTxtBox.Text;
        //}


    }
}
