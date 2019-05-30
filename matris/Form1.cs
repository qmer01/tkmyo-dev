using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace matris
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int [,] girdi1 = new int[4, 4];
        int [,] girdi2 = new int[4, 4];
        int[,] sonuc = new int[4, 4];
        Random salla = new Random();

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 4; i++)
            {
                dataGridView1.Rows.Add();
                dataGridView2.Rows.Add();
                dataGridView3.Rows.Add();
                for (int j = 0; j < 4; j++)
                {
                    girdi1[i, j] = salla.Next(0, 5);
                    dataGridView1.Rows[i].Cells[j].Value = girdi1[i, j];
                    girdi2[i, j] = salla.Next(0, 5);
                    dataGridView2.Rows[i].Cells[j].Value = girdi2[i, j];

                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    sonuc[i, j] = girdi1[i, j] + girdi2[i, j];
                    dataGridView3.Rows[i].Cells[j].Value = sonuc[i, j];
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    sonuc[i, j] = girdi1[i, j] - girdi2[i, j];
                    dataGridView3.Rows[i].Cells[j].Value = sonuc[i, j];
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    sonuc[i, j] = girdi1[i, j] * girdi2[i, j];
                    dataGridView3.Rows[i].Cells[j].Value = sonuc[i, j];

                }
            }
        }

        //private void button5_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    sonuc[i, j] = girdi1[i, j] / girdi2[i, j];
                    dataGridView3.Rows[i].Cells[j].Value = sonuc[i, j];

                }
            }
        }
    }
}
