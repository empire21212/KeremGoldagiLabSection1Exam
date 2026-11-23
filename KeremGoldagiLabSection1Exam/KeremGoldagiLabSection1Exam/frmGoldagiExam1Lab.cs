using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace KeremGoldagiLabSection1Exam
{
    public partial class frmGoldagiExam1Lab : Form
    {
        public frmGoldagiExam1Lab()
        {
            InitializeComponent();
        }
        private void frmGoldagiExam1Lab_Load(object sender, EventArgs e)
        {
        }

        private void btnA_Click(object sender, EventArgs e)
        {
            txtPreviewText.Text += "A";
        }

        private void btnB_Click(object sender, EventArgs e)
        {
            txtPreviewText.Text += "B";
        }
        private void btnC_Click(object sender, EventArgs e)
        {
            txtPreviewText.Text += "C";
        }

        private void btnD_Click(object sender, EventArgs e)
        {
            txtPreviewText.Text += "D";
        }
        private void btnE_Click(object sender, EventArgs e)
        {
            txtPreviewText.Text += "E";
        }

        private void btnF_Click(object sender, EventArgs e)
        {
            txtPreviewText.Text += "F";
        }
        private void btnG_Click(object sender, EventArgs e)
        {
            txtPreviewText.Text += "G";
        }

        private void btnH_Click(object sender, EventArgs e)
        {
            txtPreviewText.Text += "H";
        }

        private void btnI_Click(object sender, EventArgs e)
        {
            txtPreviewText.Text += "I";
        }

        private void btnJ_Click(object sender, EventArgs e)
        {
            txtPreviewText.Text += "J";
        }
        private void btnK_Click(object sender, EventArgs e)
        {
            txtPreviewText.Text += "K";
        }

        private void btnL_Click(object sender, EventArgs e)
        {
            txtPreviewText.Text += "L";
        }
        private void btnM_Click(object sender, EventArgs e)
        {
            txtPreviewText.Text += "M";
        }

        private void btnN_Click(object sender, EventArgs e)
        {
            txtPreviewText.Text += "N";
        }
        private void btnO_Click(object sender, EventArgs e)
        {
            txtPreviewText.Text += "O";
        }

        private void btnP_Click(object sender, EventArgs e)
        {
            txtPreviewText.Text += "P";
        }
        private void btnQ_Click(object sender, EventArgs e)
        {
            txtPreviewText.Text += "Q";
        }

        private void btnR_Click(object sender, EventArgs e)
        {
            txtPreviewText.Text += "R";
        }
        private void btnS_Click(object sender, EventArgs e)
        {
            txtPreviewText.Text += "S";
        }

        private void btnT_Click(object sender, EventArgs e)
        {
            txtPreviewText.Text += "T";
        }
        private void btnU_Click(object sender, EventArgs e)
        {
            txtPreviewText.Text += "U";
        }

        private void btnV_Click(object sender, EventArgs e)
        {
            txtPreviewText.Text += "V";
        }
        private void btnW_Click(object sender, EventArgs e)
        {
            txtPreviewText.Text += "W";
        }

        private void btnX_Click(object sender, EventArgs e)
        {
            txtPreviewText.Text += "X";
        }
        private void btnY_Click(object sender, EventArgs e)
        {
            txtPreviewText.Text += "Y";
        }

        private void btnZ_Click(object sender, EventArgs e)
        {
            txtPreviewText.Text += "Z";
        }

        private void btnNum1_Click(object sender, EventArgs e)
        {
            txtPreviewText.Text += "1";
        }
        private void btnNum2_Click(object sender, EventArgs e)
        {
            txtPreviewText.Text += "2";
        }

        private void btnNum3_Click(object sender, EventArgs e)
        {
            txtPreviewText.Text += "3";
        }
        private void btnNum4_Click(object sender, EventArgs e)
        {
            txtPreviewText.Text += "4";
        }

        private void btnNum5_Click(object sender, EventArgs e)
        {
            txtPreviewText.Text += "5";
        }
        private void btnNum6_Click(object sender, EventArgs e)
        {
            txtPreviewText.Text += "6";
        }

        private void btnNum7_Click(object sender, EventArgs e)
        {
            txtPreviewText.Text += "7";
        }
        private void btnNum8_Click(object sender, EventArgs e)
        {
            txtPreviewText.Text += "8";
        }

        private void btnNum9_Click(object sender, EventArgs e)
        {
            txtPreviewText.Text += "9";
        }
        private void btnNum0_Click(object sender, EventArgs e)
        {
            txtPreviewText.Text += "0";
        }

        private void btnBlankSpace_Click(object sender, EventArgs e)
        {
            txtPreviewText.Text += " ";
        }
        private void btnDot_Click(object sender, EventArgs e)
        {
            txtPreviewText.Text += ".";
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            lblDisplayText.Text = txtPreviewText.Text;
            txtPreviewText.Text = "";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtPreviewText.Text = "";
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
