﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Memocabulary
{
    

    public partial class Form1 : Form
    {
        List<WordList> Desteler = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Ista().ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // comboBox1.SelectedIndex
            WordList secilmis = new WordList();
            
            this.Hide();  
          Kelime_Ekle k = new Kelime_Ekle();
            
            k.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Tone singletone = Tone.Instance();
            List<WordList> Desteler = new List<WordList>();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

       
    }
}
