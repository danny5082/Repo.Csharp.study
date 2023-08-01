﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp004
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox2.Items.Add("서울특별시");
            comboBox2.Items.Add("인천광역시");
            comboBox2.Items.Add("대전광역시");
            comboBox2.Items.Add("대구광역시");
            comboBox2.Items.Add("부산광역시");
            comboBox2.Items.Add("광주광역시");
            comboBox2.Items.Add("울산공역시");
            comboBox2.Items.Add("경기도");
            comboBox2.Items.Add("충청도");
            comboBox2.Items.Add("강원도");
            comboBox2.Items.Add("경상도");
            comboBox2.Items.Add("전라도");
            comboBox2.Items.Add("제주도");
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(comboBox1.Text + textBox1.Text + "님은 " + comboBox2.Text + "에 거주하십니다");
        }
    }
}
