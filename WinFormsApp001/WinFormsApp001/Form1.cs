using System.Diagnostics;

namespace WinFormsApp001
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello wolrd dong yong~~!!");
            Trace.WriteLine(string.Format($"{System.DateTime.Now}"));
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("C#�� ���� ���Ű��� ȯ���մϴ�.");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "���봩���� ���� �ߴµ�!!!";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void btn_finifh_Click(object sender, EventArgs e)
        {
            MessageBox.Show("�����մϴ�"); 
            this.Dispose();
        }
    }
}