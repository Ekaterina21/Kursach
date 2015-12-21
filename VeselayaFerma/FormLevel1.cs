using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;


namespace VeselayaFerma
{
    
    public partial class FormLevel1 : Form
    {
        double tmp = 0;
        double ang = 360;
        int r = 280;
        int r1 = 150;
        private Random rnd = new Random();
        private readonly Timer tmrShow;
        public FormLevel1()
        {
            InitializeComponent();
            timer2.Enabled = true;
            timer4.Enabled = true;
            timer6.Enabled = true;
            timer7.Enabled = true;
        }
               

        private void Chicken_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = imageList1.Images[0];
            spr.Start();
           
        }
                 

       
        private void FormLevel1_Load(object sender, EventArgs e)
        {
            Timer x = new Timer();
            x.Interval = 100;
            x.Start();
            x.Tick += new EventHandler(x_Tick);
           
        }

        private void x_Tick(object sender, EventArgs e)
        {
            pictureBox1.Location = new Point(Convert.ToInt32(r * Math.Cos(ang) + 250), Convert.ToInt32(r1 * Math.Sin(ang) + 337));
            ang -= 0.005;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        int i = 0;
        private void spr_Tick(object sender, EventArgs e)
        {
            i = i + 1;

            if (imageList1.Images.Count <= i)
                i = 0;

            pictureBox1.Image = imageList1.Images[i];
            pictureBox1.Update();
            
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

            Bitmap image1 = new Bitmap("D:/Курсач/VeselayaFerma/trava.png");
            
            pictureBox4.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox4.BorderStyle = BorderStyle.Fixed3D;
            pictureBox4.Image = image1;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
             // создаем новый таймер
            tmrShow.Interval = 5000; // ставим интервал выполнения единственного события, через 5 секунд

            
            
            //Bitmap image1 = new Bitmap("D:/Курсач/Курсовая/Image/egg.png");
            tmrShow.Enabled = true;// включаем таймер
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Sklad level1 = new Sklad();
            level1.ShowDialog();
        }

        private void pictureBox5_MouseClick(object sender, MouseEventArgs e)
        {
          
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            pictureBox5.Visible = true;
            pictureBox5.Refresh();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {

            Bitmap image1 = new Bitmap("D:/Курсач/VeselayaFerma/egg.png");

            pictureBox6.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox6.BorderStyle = BorderStyle.Fixed3D;
            pictureBox6.Image = image1;
            timer2.Enabled = false;
            
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            if (pictureBox6.Enabled == true)
            {
                Bitmap image2 = new Bitmap("D:/Курсач/VeselayaFerma/egg.png");

                pictureBox7.SizeMode = PictureBoxSizeMode.AutoSize;
                pictureBox7.BorderStyle = BorderStyle.Fixed3D;
                pictureBox7.Image = image2;
            }
            pictureBox6.Image = null;
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            timer5.Enabled = true;
            pictureBox8.Image = null;
            timer3.Enabled = true;
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            if (pictureBox9.Enabled == true)
            {
                Bitmap image2 = new Bitmap("D:/Курсач/VeselayaFerma/egg.png");

                pictureBox10.SizeMode = PictureBoxSizeMode.AutoSize;
                pictureBox10.BorderStyle = BorderStyle.Fixed3D;
                pictureBox10.Image = image2;
            }
            pictureBox9.Image = null;


        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            Bitmap image1 = new Bitmap("D:/Курсач/VeselayaFerma/egg.png");

            pictureBox9.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox9.BorderStyle = BorderStyle.Fixed3D;
            pictureBox9.Image = image1;
            timer4.Enabled = false;
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            tmp += 1;
            pictureBox7.Image = null;
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            tmp += 1;
            pictureBox10.Image = null;
        }

        private void timer5_Tick(object sender, EventArgs e)
        {
            timer5.Enabled = false;
            label2.Text = (Convert.ToDouble(label2.Text) + tmp*10).ToString();
            Bitmap image1 = new Bitmap("D:/Курсач/VeselayaFerma/gaz.png");
            pictureBox8.Image = image1;
            tmp = 0;
        }

        private void pictureBox5_Click_1(object sender, EventArgs e)
        {
            Bitmap image1 = new Bitmap("D:/Курсач/VeselayaFerma/trava.png");

            pictureBox5.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox5.BorderStyle = BorderStyle.Fixed3D;
            pictureBox5.Image = image1;
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            Bitmap image1 = new Bitmap("D:/Курсач/VeselayaFerma/trava.png");

            pictureBox11.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox11.BorderStyle = BorderStyle.Fixed3D;
            pictureBox11.Image = image1;
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            Bitmap image1 = new Bitmap("D:/Курсач/VeselayaFerma/trava.png");

            pictureBox13.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox13.BorderStyle = BorderStyle.Fixed3D;
            pictureBox13.Image = image1;
        }

        private void timer6_Tick(object sender, EventArgs e)
        {
            Bitmap image1 = new Bitmap("D:/Курсач/VeselayaFerma/egg.png");

            pictureBox14.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox14.BorderStyle = BorderStyle.Fixed3D;
            pictureBox14.Image = image1;
            timer6.Enabled = false;

        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            Bitmap image1 = new Bitmap("D:/Курсач/VeselayaFerma/trava.png");

            pictureBox12.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox12.BorderStyle = BorderStyle.Fixed3D;
            pictureBox12.Image = image1;
        }

        private void timer7_Tick(object sender, EventArgs e)
        {
            Bitmap image1 = new Bitmap("D:/Курсач/VeselayaFerma/egg.png");

            pictureBox15.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox15.BorderStyle = BorderStyle.Fixed3D;
            pictureBox15.Image = image1;
            timer7.Enabled = false;
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            if (pictureBox15.Enabled == true)
            {
                Bitmap image2 = new Bitmap("D:/Курсач/VeselayaFerma/egg.png");

                pictureBox16.SizeMode = PictureBoxSizeMode.AutoSize;
                pictureBox16.BorderStyle = BorderStyle.Fixed3D;
                pictureBox16.Image = image2;
            }
            pictureBox15.Image = null;
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            if (pictureBox14.Enabled == true)
            {
                Bitmap image2 = new Bitmap("D:/Курсач/VeselayaFerma/egg.png");

                pictureBox17.SizeMode = PictureBoxSizeMode.AutoSize;
                pictureBox17.BorderStyle = BorderStyle.Fixed3D;
                pictureBox17.Image = image2;
            }
            pictureBox14.Image = null;
        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {
            tmp += 1;
            pictureBox16.Image = null;
        }

        private void pictureBox17_Click(object sender, EventArgs e)
        {
            tmp += 1;
            pictureBox17.Image = null;
        }
        

      
      

       
    }
}
