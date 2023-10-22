using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using ProjectProtectedPapyrus.Properties;

namespace ProjectProtectedPapyrus
{
    public partial class Login : Form
    {

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
       (
           int nLeftRect,     // x-coordinate of upper-left corner
           int nTopRect,      // y-coordinate of upper-left corner
           int nRightRect,    // x-coordinate of lower-right corner
           int nBottomRect,   // y-coordinate of lower-right corner
           int nWidthEllipse, // width of ellipse
           int nHeightEllipse // height of ellipse
       );

        public Login()
        {
            InitializeComponent();
        }

        private void siticoneRoundedButton1_Click(object sender, EventArgs e)
        {
            if(text1.Text == "Papyrus")
            {
                this.Hide();
                var Dashboard = new Menu();
                Dashboard.Show();
            }
            else
            {
                siticoneRoundedButton2.Visible = true;
            }
        }

        private void siticoneLabel1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
          

        }


        int mov, movX, movY;

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            mov = 1;
            movX = e.X;
            movY = e.Y;
        }

        private void siticoneMaterialRadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
            siticoneMaterialRadioButton1.Checked = false;
        }

        private void siticoneRoundedTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mov == 1)
            {
                this.SetDesktopLocation(MousePosition.X - movX, MousePosition.Y - movY);
            }
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            mov = 0;
        }
    }
}
