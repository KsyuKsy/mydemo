using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApp1
{
    public partial class Play : Form
    {
      
        int i = 45;
        int j = 5;
        int[] c = new int[4];
        int[] c1 = new int[4];
        int[] dan = new int[20];
        int sum = 0;
        int sum1 = 0;
        int t = 0;
        Random rnd = new Random();
        string[] texts = new string[2000];
        int value;
        
        public Play()
        {
           
            InitializeComponent();
            timer2.Enabled = true;

            random1();
            random2();

        }

        public void random3(int value)
        {
            link1:
            value = rnd.Next(1, 16);
            for (int i=0;i<dan.Length;i++)
            {
                if (value == dan[i])
                    goto link1;
            }
            dan[sum] = value;
            


        }
        public void random1()
        {
            link1:
            value = rnd.Next(1, 16);
            for (int i = 0; i < dan.Length; i++)
            {
                if (value == dan[i])
                    goto link1;
            }
            dan[sum1]=value;
            string k = value.ToString();
            texts = File.ReadAllLines("ответы.txt", Encoding.Default);
            label1.Text = texts[(value - 1) * 6 + 1];

        }
        public void random2() {
            i = 45;
            label2.Text = "45";
            int j = 0;
            while (j != 4)
            {
                int r = rnd.Next(1, 5);
                if (c[0] == 0)
                {
                    c[0] = r;
                    j = j + 1;
                    btn1.Text = texts[(value - 1) * 6 + 1 + r];
                }
                else
                  if ((r != c[0]) & (c[1] == 0))
                {
                    c[1] = r;
                    j = j + 1;
                    btn2.Text = texts[(value - 1) * 6 + 1 + r];
                }
                else
                    if ((r != c[0]) & (r != c[1]) & (c[2] == 0))
                {
                    c[2] = r;
                    j = j + 1;
                    btn3.Text = texts[(value - 1) * 6 + 1 + r];
                }
                else

                        if ((r != c[0]) & (r != c[1]) & (r != c[2]) & (c[3] == 0))
                {
                    c[3] = r;
                    j = j + 1;
                    btn4.Text = texts[(value - 1) * 6 + 1 + r];

                }

            }
            c1[0] = c[0];
            c1[1] = c[1];
            c1[2] = c[2];
            c1[3] = c[3];
            c[0] = 0;
            c[1] = 0;
            c[2] = 0;
            c[3] = 0;

        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            i--;
            label2.Text = i.ToString();
            if(i==-1)
            {
               
                timer1.Enabled = false;
                
                DialogResult result = MessageBox.Show(
               "К сожалению,вы проиграли.",
               "Сообщение",
               MessageBoxButtons.OK,
               MessageBoxIcon.Information,
               MessageBoxDefaultButton.Button1);
                if (DialogResult.OK == result)
                    Hide();
                Form1 form1 = new Form1();
                form1.label1.Visible = false;
                form1.button1.Visible = true;
                form1.button2.Visible = true;
                form1.ShowDialog();
                
            }
            
            if (sum1 == 15)
            {
                timer1.Enabled = false;
                DialogResult result = MessageBox.Show(
               "Поздравляем!Вы победили!",
               "Сообщение",
               MessageBoxButtons.OK,
               MessageBoxIcon.Information,
               MessageBoxDefaultButton.Button1);
                if (DialogResult.OK == result)
                    Hide();
                Form1 form1 = new Form1();
                form1.label1.Visible = false;
                form1.button1.Visible = true;
                form1.button2.Visible = true;
                form1.ShowDialog();
                Close(); ;

            }
            if ((t==1) & (i==0))
            {
                t = 0;
                btn1.BackColor = Color.BlueViolet;
                btn2.BackColor = Color.BlueViolet;
                btn3.BackColor = Color.BlueViolet;
                btn4.BackColor = Color.BlueViolet;
                btn1.Enabled = true;
                btn2.Enabled = true;
                btn3.Enabled = true;
                btn4.Enabled = true;
                random1();
                random2();

            }
            
        }
        public void otchet ()
        {
            label2.Text ="3";
            i = 3;
        }
        private void btn1_MouseClick(object sender, MouseEventArgs e)
        {
            if (c1[0] == 1)
            {
                btn1.Enabled = false;
                btn2.Enabled = false;
                btn3.Enabled = false;
                btn4.Enabled = false;
                btn1.BackColor = Color.Lime;
                btn1.Text = "Правильно!";
                c1[0] = 0;
                sum1++;
                sum++;
             
                label4.Text = sum1.ToString();
                i = 4;
                t = 1;
                
            }
            else
            {
                btn1.Enabled = false;
                btn2.Enabled = false;
                btn3.Enabled = false;
                btn4.Enabled = false;
                timer1.Enabled = false;
                btn1.BackColor = Color.Red;
                btn1.Text = "Не правильно!";

              DialogResult result=MessageBox.Show(
                "К сожалению,вы проиграли.",
                "Сообщение",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information,
                MessageBoxDefaultButton.Button1);
                if (DialogResult.OK == result)
                    Hide();
                    Form1 form1 = new Form1();
                form1.label1.Visible = false;
                form1.button1.Visible = true;
                form1.button2.Visible = true;
                form1.ShowDialog();
                    Close(); ;

            }
        }

        private void btn2_MouseClick(object sender, MouseEventArgs e)
        {
            if (c1[1] == 1)
            {    
                btn1.Enabled = false;
                btn2.Enabled = false;
                btn3.Enabled = false;
                btn4.Enabled = false;
                btn2.BackColor = Color.Lime;
                btn2.Text = "Правильно!";
                c1[1] = 0;
                sum1++;
                label4.Text = sum1.ToString();
                i = 4;
                t = 1;


            }
            else
            {
                btn1.Enabled = false;
                btn2.Enabled = false;
                btn3.Enabled = false;
                btn4.Enabled = false;
                timer1.Enabled = false;
                btn2.BackColor = Color.Red;
                btn2.Text = "Не правильно!";
                DialogResult result = MessageBox.Show(
                "К сожалению,вы проиграли.",
                "Сообщение",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information,
                MessageBoxDefaultButton.Button1);
                if (DialogResult.OK == result)
                Hide();
                Form1 form1 = new Form1();
                form1.label1.Visible = false;
                form1.button1.Visible = true;
                form1.button2.Visible = true;
                form1.ShowDialog();
                Close();

            }
        }

        private void btn3_MouseClick(object sender, MouseEventArgs e)
        {
            if (c1[2] == 1)
            {
                btn1.Enabled = false;
                btn2.Enabled = false;
                btn3.Enabled = false;
                btn4.Enabled = false;
                btn3.BackColor = Color.Lime;
                btn3.Text = "Правильно!";
                c1[2] = 0;
                sum1++;
                label4.Text = sum1.ToString();
                i = 4;
            
                t = 1;

            }
            else
            {
                btn1.Enabled = false;
                btn2.Enabled = false;
                btn3.Enabled = false;
                btn4.Enabled = false;
                timer1.Enabled = false;
                btn3.BackColor = Color.Red;
                btn3.Text = "Не правильно!";
                DialogResult result = MessageBox.Show(
                "К сожалению,вы проиграли.",
                "Сообщение",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information,
                MessageBoxDefaultButton.Button1);
                if (DialogResult.OK == result)
                    Hide();
                Form1 form1 = new Form1();
                form1.label1.Visible = false;
                form1.button1.Visible = true;
                form1.button2.Visible = true;
                form1.ShowDialog();
                Close(); ;
            }
        }

        private void btn4_MouseClick(object sender, MouseEventArgs e)
        {
            if (c1[3] == 1)
            {
                btn1.Enabled = false;
                btn2.Enabled = false;
                btn3.Enabled = false;
                btn4.Enabled = false;
                btn4.BackColor = Color.Lime;
                btn4.Text = "Правильно!";
                c1[3] = 0;
                sum1++;
                label4.Text = sum1.ToString();
                i = 4;
                t = 1;
            }  
            else
            {
                btn1.Enabled = false;
                btn2.Enabled = false;
                btn3.Enabled = false;
                btn4.Enabled = false;
                btn4.BackColor = Color.Red;
                btn4.Text = "Не правильно!";
                timer1.Enabled = false;
                DialogResult result = MessageBox.Show(
                "К сожалению,вы проиграли.",
                "Сообщение",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information,
                MessageBoxDefaultButton.Button1);
                if (DialogResult.OK == result)
                    Hide();
                Form1 form1 = new Form1();
                form1.label1.Visible = false;
                form1.button1.Visible = true;
                form1.button2.Visible = true;
                form1.ShowDialog();
                Close(); ;
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            j--;
            label3.Text = j.ToString();
            if (label3.Text == 0.ToString())
            {
                timer2.Enabled = false;
                timer1.Enabled = true;
                label3.Visible = false;
                label2.Visible = true;
                label1.Visible = true;
                btn1.Visible = true;
                btn2.Visible = true;
                btn3.Visible = true;
                btn4.Visible = true;
            }

        }
    }
}
