using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace datagrid_ve_vucud_kitle_indeksi
{
    public partial class Form1 : Form
    {
        string[] isimler = new string[] { "ali","veli","ahmet","ayşe","fatma" };
        string[] soyisimler = new string[] { "çelik","çomak","kale","çatı","çakal" };
        Random salla = new Random();
        int sayac = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int boy, kilo, vki;
            for (int i = 0; i < 5; i++)
            {
                dataGridView1.Rows.Add();

                kilo = salla.Next(50, 120);
                boy = salla.Next(1200,5000);

                boy = boy / 100;
                vki = kilo / (boy * boy);

                dataGridView1.Rows[sayac].Cells[0].Value = isimler[salla.Next(0, isimler.Length)];
                dataGridView1.Rows[sayac].Cells[1].Value = soyisimler[salla.Next(0, soyisimler.Length)];
                dataGridView1.Rows[sayac].Cells[2].Value = salla.Next(100, 220);
                dataGridView1.Rows[sayac].Cells[3].Value = kilo;
                dataGridView1.Rows[sayac].Cells[4].Value = boy;
                dataGridView1.Rows[sayac].Cells[5].Value = vki;

                if (vki<=18)
                {
                    dataGridView1.Rows[sayac].Cells[5].Value = "zayıf";
                }
                else if (vki > 18 && vki <= 24)
                {
                     dataGridView1.Rows[sayac].Cells[5].Value = "normal";
                }
                else if (vki > 24 && vki <= 29)
                {
                     dataGridView1.Rows[sayac].Cells[5].Value = "fazla kilolu";
                }
                else
                {
                    dataGridView1.Rows[sayac].Cells[5].Value = "obez";
                }
                sayac++;
            }

        }
    }
}
