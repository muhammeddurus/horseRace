using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AtYarisi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int birinciatsolauzaklık, ikinciatsolauzaklık, ucuncuatsolauzaklık,dorduncuatsolauzaklık,besinciatsolauzaklık;

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int derece = Convert.ToInt32(label7.Text);
            derece++;
            label7.Text = derece.ToString();
            int birinciatıngenişliği = pictureBox1.Width;
            int ikinciatıngenişliği = pictureBox2.Width;
            int ucuncuatıngenişliği = pictureBox3.Width;
            int dorduncuatıngenişliği = pictureBox4.Width;
            int beşinciatıngenişliği = pictureBox5.Width;

            int bitişuzaklığı = label4.Left;

            pictureBox1.Left = pictureBox1.Left + rasgele.Next(5, 15);
            pictureBox2.Left += rasgele.Next(5, 15);
            pictureBox3.Left += rasgele.Next(5, 15);
            pictureBox4.Left += rasgele.Next(5, 15);
            pictureBox5.Left += rasgele.Next(5, 15);

            if (pictureBox1.Left > pictureBox2.Left+5 &&pictureBox1.Left>pictureBox3.Left+ 5 && pictureBox1.Left > pictureBox4.Left + 5 && pictureBox1.Left > pictureBox5.Left + 5)
            {
                label6.Text = "1 Numaralı At Yarışı Önde Götürüyor !!";
            }
            if (pictureBox2.Left>pictureBox1.Left+5 && pictureBox2.Left>pictureBox3.Left+5 && pictureBox2.Left > pictureBox4.Left + 5 && pictureBox2.Left > pictureBox5.Left + 5)
            {
                label6.Text = "2 Numaralı At İyi Bir Atakla Öne Geçti !!";
            }
            if (pictureBox3.Left > pictureBox1.Left + 5 && pictureBox3.Left > pictureBox2.Left + 5 && pictureBox3.Left > pictureBox4.Left + 5 && pictureBox3.Left > pictureBox5.Left + 5)
            {
                label6.Text = "3 Numaralı At Rüzgar Gibi Geliyor Ve Liderliği Kaptı !!";
            }
            if (pictureBox4.Left > pictureBox1.Left + 5 && pictureBox4.Left > pictureBox2.Left + 5 && pictureBox4.Left > pictureBox3.Left + 5 && pictureBox4.Left > pictureBox5.Left + 5)
            {
                label6.Text = "4 Numaralı At İnanılmaz Bir Şekilde Öne Geçti !!";
            }
            if (pictureBox5.Left > pictureBox1.Left + 5 && pictureBox5.Left > pictureBox2.Left + 5 && pictureBox5.Left > pictureBox3.Left + 5 && pictureBox5.Left > pictureBox4.Left + 5)
            {
                label6.Text = "5 Numaralı At Deli Taylar Gibi Koşturuyor !!";
            }

            if (birinciatıngenişliği + pictureBox1.Left >= bitişuzaklığı)
            {
                timer1.Enabled = false;
               label6.Text="1 Numaralı At Yarışı Kazandı !";
            }
            if (ikinciatıngenişliği+pictureBox2.Left >=bitişuzaklığı)
            {
                timer1.Enabled = false;
                label6.Text = "2 Numaralı At Yarışı Kazandı !";
            }
            if (ucuncuatıngenişliği+pictureBox3.Left >=bitişuzaklığı)
            {
                timer1.Enabled = false;
                label6.Text = "3 Numaralı At Yarışı Kazandı !";
            }
            if (dorduncuatıngenişliği+pictureBox4.Left >=bitişuzaklığı)
            {
                timer1.Enabled = false;
                label6.Text = "4 Numaralı At Yarışı Kazandı !";
            }
            if (beşinciatıngenişliği+pictureBox5.Left >=bitişuzaklığı)
            {
                timer1.Enabled = false;
                label6.Text = "5 Numaralı At Yarışı Kazandı !";
            }
            
        }

        Random rasgele = new Random();
        private void Form1_Load(object sender, EventArgs e)
        {
            birinciatsolauzaklık = pictureBox1.Left;
            ikinciatsolauzaklık = pictureBox2.Left;
            ucuncuatsolauzaklık = pictureBox3.Left;
            dorduncuatsolauzaklık = pictureBox4.Left;
            besinciatsolauzaklık = pictureBox5.Left;
        }
    }
}
