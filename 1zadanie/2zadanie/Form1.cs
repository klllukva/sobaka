using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2zadanie
{
    public partial class Form1 : Form
    {
        int[] Mas = new int[21];
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            Random rand = new Random();
            for (int i = 0; i < 21; i++)
            {
                Mas[i] = rand.Next(0, 20);
                listBox1.Items.Add("Mas [" + i.ToString() + "] =" + Mas[i].ToString());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
            int Max = Mas[0], temp = 0, count = 0;
            for (int i = 0; i < 21; i++)
            {
                if (Mas[i] > Max)
                {
                    Max = Mas[i];
                    count = i;
                }

            }
            temp = Mas[0];
            Mas[0] = Max;
            Mas[count] = temp;
            for (int i = 0; i < 21; i++)
            {
                listBox2.Items.Add("Mas [" + Convert.ToString(i) + "] =" + Mas[i].ToString());
            }
        }
    }
}
