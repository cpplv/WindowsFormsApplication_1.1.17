using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication_1._1._17
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i, x, Num = 0, Sum = 0;
            double Av;
            for (i = 0; i < richTextBox1.Lines.Length; i++)
            {
                try
                {
                    x = int.Parse(richTextBox1.Lines[i]);
                    if (x % 2 == 0)
                    {
                        Num++;
                        Sum += x;
                    }
                }
                catch { };
            }
            
            if (Num == 0)
            {
                label2.Text = "pāra skaitļu nav!";
                label3.Text = "Sum=...";
                label4.Text = "Avg=...";
            }
            else
            {
                Av = Sum / Num;
                label2.Text = "Num=" + Num.ToString();
                label3.Text = "Sum=" + Sum.ToString();
                label4.Text = "Avg=" + Av.ToString();
            }
        }
    }
}