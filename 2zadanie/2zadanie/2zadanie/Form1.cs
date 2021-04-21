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
        int[] Mas = new int[11];
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            Random rand = new Random();
            for (int i = 0; i < 11; i++)
            {
                Mas[i] = rand.Next(0, 10);
                listBox1.Items.Add("Mas [" + i.ToString() + "] =" + Mas[i].ToString());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            listBox2.Items.Clear();
            int Min = Mas[0], temp = 0, count = 0;
            for (int i = 0; i < 11; i++)
            {
                if (Mas[i] > Min)
                {
                    Min = Mas[i];
                    count = i;
                }

            }
            temp = Mas[0];
            Mas[0] = Min;
            Mas[count] = temp;
            for (int i = 0; i < 11; i++)
            {
                listBox2.Items.Add("Mas [" + Convert.ToString(i) + "] =" + Mas[i].ToString());
            }
        }
    }
}
