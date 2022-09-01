using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace köstebek_oyunu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random rnd = new Random();
        int say = 0;
        private void Form1_Load(object sender, EventArgs e)
        {
            
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int a = rnd.Next(1, 17);
            
            foreach (Button item in Controls)
            {
                
                if (a.ToString() == item.Text  )
                {
                    if (button17.BackColor == Color.White)
                    {
                        item.BackgroundImage = null;
                        button17.ForeColor = Color.Black;
                        button18.ForeColor = Color.Black;
                    }
                    if (button18.BackColor == Color.Red)
                    {
                       
                        item.BackgroundImage = null;
                        button18.BackColor = Color.White;
                    }
                    item.BackgroundImage = Image.FromFile("D:\\Visaul Studio\\köstebek oyunu\\kostebek.jpg");
                    item.BackColor = Color.Red;
                    item.ForeColor = Color.Red;
                }
                else
                {
                    item.BackColor = Color.White;
                    item.ForeColor = Color.White;
                    item.BackgroundImage = null;
                }
            }
        }

        private void Button_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn.BackColor == Color.Red)
            {
                say++;
                button18.Text = say.ToString();
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            button19.Visible = false;
        }
    }
}
