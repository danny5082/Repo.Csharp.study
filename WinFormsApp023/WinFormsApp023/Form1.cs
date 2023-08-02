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

namespace WinFormsApp023
{
    public partial class Form1 : Form
    {
        int R,G,B = 0;
        private void panelcolor()

        {

            panel1.BackColor = Color.FromArgb(R, G, B);

        }
        public Form1()
        {
            InitializeComponent();
        }

        private void trackBarR_Scroll(object sender, EventArgs e)
        {
            R = trackBarR.Value;

            panelcolor();
        }
        
        private void trackBarG_Scroll(object sender, EventArgs e)
        {
            G = trackBarG.Value;

            panelcolor();
        }

        private void trackBarB_Scroll(object sender, EventArgs e)
        {
            B = trackBarB.Value;

            panelcolor();
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            panel1.BackColor = Color.FromArgb(R, G, B);
        }
    }
}
