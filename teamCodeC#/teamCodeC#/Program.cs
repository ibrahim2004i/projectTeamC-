using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Project_Team_C_
{
    public partial class Form1 : Form
    {
        private bool isAnotherFormOpen = false;

        private Size originalSize;    // متغير لتخزين الحجم الأصلي للصورة

        // تعريف المتغيرات التي ستستخدمها لتحديد لون الحواف وعرضها
        private Color borderColor = Color.Blue; // اللون المستخدم للحواف المضيئة
        private int borderWidth = 5; // عرض الحواف المضيئة

        public Form1()
        {
            InitializeComponent();
            this.Paint += MainForm_Paint;

            pictureBox3.MouseEnter += new EventHandler(pictureBox3_MouseEnter);
            pictureBox3.MouseLeave += new EventHandler(pictureBox3_MouseLeave);
            pictureBox3.Click += new EventHandler(pictureBox3_Click);
            pictureBox3.Paint += pictureBox3_Paint;  // ربط حدث الـ Paint بالصورة


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label2.Font = new Font("Arial", 12, FontStyle.Underline);

            originalSize = pictureBox3.Size;


        }
        private void MainForm_Paint(object sender, PaintEventArgs e)
        {
            using (LinearGradientBrush gradientBrush = new LinearGradientBrush(
               this.ClientRectangle,               // المنطقة التي سيتم رسم التدريج عليها
               Color.DarkBlue,                     //( اللون الأول (أعلى التدرج
               Color.LightBlue,                    //( اللون الثاني (أسفل التدرج
               LinearGradientMode.Vertical))       //( اتجاه التدرج (رأسي
            {
                e.Graphics.FillRectangle(gradientBrush, this.ClientRectangle);
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Enter(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {


        }


        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (!isAnotherFormOpen)
            {
                // فتح النموذج فقط إذا لم يكن مفتوحًا
                AnotherForm2 anotherForm = new AnotherForm2();
                anotherForm.Show();

                // تعيين متغير flag ليشير إلى أن النموذج مفتوح الآن
                isAnotherFormOpen = true;

                // عند إغلاق النموذج، إعادة تعيين flag
                anotherForm.FormClosed += (s, args) => isAnotherFormOpen = false;
            }


        }



        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (!isAnotherFormOpen)
            {
                // فتح النموذج فقط إذا لم يكن مفتوحًا
                AnotherForm1 anotherForm = new AnotherForm1();
                anotherForm.Show();

                // تعيين متغير flag ليشير إلى أن النموذج مفتوح الآن
                isAnotherFormOpen = true;

                // عند إغلاق النموذج، إعادة تعيين flag
                anotherForm.FormClosed += (s, args) => isAnotherFormOpen = false;
            }
        }



        private void pictureBox3_Click(object sender, EventArgs e)
        {


            if (!isAnotherFormOpen)
            {
                // فتح النموذج فقط إذا لم يكن مفتوحًا
                AnotherForm anotherForm = new AnotherForm();
                anotherForm.Show();

                // تعيين متغير flag ليشير إلى أن النموذج مفتوح الآن
                isAnotherFormOpen = true;

                // عند إغلاق النموذج، إعادة تعيين flag
                anotherForm.FormClosed += (s, args) => isAnotherFormOpen = false;
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_MouseEnter(object sender, EventArgs e)
        {
            pictureBox3.Size = new Size(originalSize.Width + 10, originalSize.Height + 10);

        }

        private void pictureBox3_MouseLeave(object sender, EventArgs e)
        {
            pictureBox3.Size = originalSize;
        }

        private void pictureBox3_Paint(object sender, PaintEventArgs e)
        {
            if (pictureBox3.ClientRectangle.Contains(pictureBox3.PointToClient(MousePosition)))
            {
                // رسم الحواف المضيئة
                using (Pen pen = new Pen(borderColor, borderWidth))
                {
                    pen.Alignment = PenAlignment.Inset;
                    e.Graphics.DrawRectangle(pen, 0, 0, pictureBox3.Width - 1, pictureBox3.Height - 1);
                }
            }
        }



        private void pictureBox2_MouseEnter(object sender, EventArgs e)
        {
            pictureBox2.Size = new Size(originalSize.Width + 10, originalSize.Height + 10);

        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            pictureBox2.Size = originalSize;

        }

        private void pictureBox2_Paint(object sender, PaintEventArgs e)
        {
            if (pictureBox2.ClientRectangle.Contains(pictureBox2.PointToClient(MousePosition)))
            {
                // رسم الحواف المضيئة
                using (Pen pen = new Pen(borderColor, borderWidth))
                {
                    pen.Alignment = PenAlignment.Inset;
                    e.Graphics.DrawRectangle(pen, 0, 0, pictureBox2.Width - 1, pictureBox2.Height - 1);
                }
            }
        }




        private void pictureBox4_MouseEnter(object sender, EventArgs e)
        {
            pictureBox4.Size = new Size(originalSize.Width + 10, originalSize.Height + 10);

        }

        private void pictureBox4_MouseLeave(object sender, EventArgs e)
        {
            pictureBox4.Size = originalSize;

        }

        private void pictureBox4_Paint(object sender, PaintEventArgs e)
        {
            if (pictureBox4.ClientRectangle.Contains(pictureBox4.PointToClient(MousePosition)))
            {
                // رسم الحواف المضيئة
                using (Pen pen = new Pen(borderColor, borderWidth))
                {
                    pen.Alignment = PenAlignment.Inset;
                    e.Graphics.DrawRectangle(pen, 0, 0, pictureBox4.Width - 1, pictureBox4.Height - 1);
                }
            }
        }
    }
}
