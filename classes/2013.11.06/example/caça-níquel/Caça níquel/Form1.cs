using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Caça_níquel
{
    public partial class Form1 : Form
    {
        Random num = new Random(10);
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int x1, x2, x3;
            x1 = num.Next(10);
            x2 = num.Next(10);
            x3 = num.Next(10);
            if (x1 == 0)
            {
                pictureBox1.Image = Image.FromFile("1.jpg");
            }

            else
                if (x1 == 1)
                {
                    pictureBox1.Image = Image.FromFile("2.jpg");
                }
                else
                       if (x1 == 2)
            {
                pictureBox1.Image = Image.FromFile("3.jpg");
            }

            else
                if (x1 == 3)
                {
                    pictureBox1.Image = Image.FromFile("4.jpg");
                }
                else
                       if (x1 == 4)
            {
                pictureBox1.Image = Image.FromFile("5.jpg");
            }

            else
                if (x1 == 5)
                {
                    pictureBox1.Image = Image.FromFile("6.jpg");
                }
                else
                       if (x1 == 6)
            {
                pictureBox1.Image = Image.FromFile("7.jpg");
            }

            else
                if (x1 == 7)
                {
                    pictureBox1.Image = Image.FromFile("8.jpg");
                }
                else
                       if (x1 == 8)
            {
                pictureBox1.Image = Image.FromFile("9.jpg");
            }

            else
                if (x1 == 9)
                {
                    pictureBox1.Image = Image.FromFile("10.jpg");
                }
                else
                    if (x1 == 10)
                    {
                        pictureBox1.Image = Image.FromFile("11.jpg");
                    }






              if (x2 == 0)
            {
                pictureBox2.Image = Image.FromFile("1.jpg");
            }

            else
                if (x2 == 1)
                {
                    pictureBox2.Image = Image.FromFile("2.jpg");
                }
                else
                      if (x2 == 2)
            {
                pictureBox2.Image = Image.FromFile("3.jpg");
            }

            else
                if (x2 == 3)
                {
                    pictureBox2.Image = Image.FromFile("4.jpg");
                }
                else
                    
              if (x2 == 4)
            {
                pictureBox2.Image = Image.FromFile("5.jpg");
            }

            else
                if (x2 == 5)
                {
                    pictureBox2.Image = Image.FromFile("6.jpg");
                }
                else
                      if (x2 == 6)
            {
                pictureBox2.Image = Image.FromFile("7.jpg");
            }

            else
                if (x2 == 7)
                {
                    pictureBox2.Image = Image.FromFile("8.jpg");
                }
                else
                    
              if (x2 == 8)
            {
                pictureBox2.Image = Image.FromFile("9.jpg");
            }

            else
                if (x2 == 9)
                {
                    pictureBox2.Image = Image.FromFile("10.jpg");
                }
                else
                      if (x2 == 10)
            {
                pictureBox2.Image = Image.FromFile("11.jpg");
            }





              if (x3 == 0)
              {
                  pictureBox3.Image = Image.FromFile("1.jpg");
              }

              else
                  if (x3 == 1)
                  {
                      pictureBox3.Image = Image.FromFile("2.jpg");
                  }
                  else
                      if (x3 == 2)
                      {
                          pictureBox3.Image = Image.FromFile("3.jpg");
                      }

                      else
                          if (x3 == 3)
                          {
                              pictureBox3.Image = Image.FromFile("4.jpg");
                          }
                          else

                              if (x3 == 4)
                              {
                                  pictureBox3.Image = Image.FromFile("5.jpg");
                              }

                              else
                                  if (x3 == 5)
                                  {
                                      pictureBox3.Image = Image.FromFile("6.jpg");
                                  }
                                  else
                                      if (x3 == 6)
                                      {
                                          pictureBox3.Image = Image.FromFile("7.jpg");
                                      }

                                      else
                                          if (x3 == 7)
                                          {
                                              pictureBox3.Image = Image.FromFile("8.jpg");
                                          }
                                          else

                                              if (x3 == 8)
                                              {
                                                  pictureBox3.Image = Image.FromFile("9.jpg");
                                              }

                                              else
                                                  if (x3 == 9)
                                                  {
                                                      pictureBox3.Image = Image.FromFile("10.jpg");
                                                  }
                                                  else
                                                      if (x3 == 10)
                                                      {
                                                          pictureBox3.Image = Image.FromFile("11.jpg");
                                                      }



              if (x1 == x2 && x2 == x3)
              {
                  timer1.Enabled = false;
                  label1.Text = "ABANDONOU!";
                  pictureBox4.Visible = true;
              }
        }
    }
}
