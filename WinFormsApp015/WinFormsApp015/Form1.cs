using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsApp015
{
    public partial class Form1 : Form
    {
        void ChangeFont()
        {
            if (cboFont.SelectedIndex < 0)
                return;
            FontStyle style = FontStyle.Regular;
            if(chkItalic.Checked )
                style |= FontStyle.Italic;
            if(grpFont.Checked ) 
                style |= FontStyle.Bold;
            txtSampleText.Font = 
                new Font((string)cboFont.SelectedItem , 20 , style);
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var Fonts = FontFamily.Families;
            foreach (FontFamily font in Fonts)
                cboFont.Items.Add(font.Name);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            ChangeFont();
        }

        private void cboFont_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChangeFont();
        }

        private void chkItalic_CheckedChanged(object sender, EventArgs e)
        {
            ChangeFont();
        }

        

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            progressBar1.Value = trackBar1.Value;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form frm = new Form();
            frm.Text = "Modal Form";
            frm.Width = 400;
            frm.Height = 200; 
            frm.BackColor = Color.White;
            frm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form frm = new Form();
            frm.Text = "Modal Form";
            frm.Width = 400;
            frm.Height = 200;
            frm.BackColor = Color.White;
            frm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show(txtSampleText.Text,
                "MessageBox Test",MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
