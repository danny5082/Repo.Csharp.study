using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp006
{
    public partial class CopyMainForm : Form
    {
        private string sourceFile;
        private string destFile;
        public CopyMainForm()
        {
            InitializeComponent();
        }

        private void btnSrcFile_Click(object sender, EventArgs e)
        {
            using(OpenFileDialog ofd = new OpenFileDialog())
            {
                if(ofd.ShowDialog() == DialogResult.OK)
                {
                    sourceFile = ofd.FileName;
                    lblSrcPath.Text = sourceFile;
                }
            }
        }

        private void btnDstFile_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                if (sfd.ShowDialog() == DialogResult.OK){
                    destFile = sfd.FileName;
                    File.Copy(sourceFile, destFile, true);
                    lblDstPath.Text = "파일 복사 완료\n " + destFile;
                }
            }
        }
    }
}
