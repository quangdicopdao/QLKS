using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;

namespace Doancsn
{
    public partial class GUI_TrangChu : Form
    {
        private IconButton currentBtn;
        private Panel leftborderBtn;
        private Form currentChilForm;
        public GUI_TrangChu()
        {
            InitializeComponent();
            leftborderBtn = new Panel();
            leftborderBtn.Size = new Size(7, 60);
            panelMenu.Controls.Add(leftborderBtn);
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }
        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(255, 165, 0);
            public static Color color2 = Color.FromArgb(255, 192, 203);
            public static Color color3 = Color.FromArgb(100, 149, 237);
            public static Color color4 = Color.FromArgb(138, 43, 226);
            public static Color color5 = Color.FromArgb(64, 224, 208);
            public static Color color6 = Color.FromArgb(135, 206, 235);
        }

        private void ActivateButton(object senderBtn, Color color)
        {
            if(senderBtn != null)
            {
                DisableButton();
                //button
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(37,36,81);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;
                //left border button
                leftborderBtn.BackColor = color;
                leftborderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftborderBtn.Visible = true;
                leftborderBtn.BringToFront();
                //icon current child form
                iconCurrentChildForm.IconChar = currentBtn.IconChar;
                iconCurrentChildForm.IconColor = color;
                //label current child form
                lblTitleChildForm.Text = currentBtn.Text;
                lblTitleChildForm.ForeColor = color;
            }
        }

        private void DisableButton()
        {
            if(currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(31,30,68);
                currentBtn.ForeColor = Color.Gainsboro;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.Gainsboro;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;

            }
        }

        private void iconButtonHotel_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            OpenChilForm(new GUI_TimKS());
        }

        private void iconButtonRoom_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color2);
            OpenChilForm(new GUI_TimP());


        }

        private void iconButtonService_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color3);
            OpenChilForm(new GUI_TimDV());

        }

        private void iconButtonCustomer_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color4);
            OpenChilForm(new GUI_TimKH());
        }
        private void iconButtonAccount_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color5);
            OpenChilForm(new GUI_Setting());

        }

        private void iconButtonStaff_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color6);
            OpenChilForm(new GUI_TimNV());

        }
        private void btnHome_Click(object sender, EventArgs e)
        {
            currentChilForm.Close();
            Reset();
        }
        //Drag Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
       
        private void Reset()
        {
            DisableButton();
            leftborderBtn.Visible = false;
            iconCurrentChildForm.IconChar = IconChar.Home;
            iconCurrentChildForm.IconColor = Color.DarkOrchid;
            lblTitleChildForm.Text = "Home";
            lblTitleChildForm.ForeColor = Color.DarkOrchid;
        }

        private void OpenChilForm(Form childform)
        {
            if(currentChilForm != null)
            {
                currentChilForm.Close();
            }
            currentChilForm = childform;
            childform.TopLevel = false;
            childform.FormBorderStyle = FormBorderStyle.None;
            childform.Dock = DockStyle.Fill;
            panelShow.Controls.Add(childform);
            panelShow.Tag = childform;
            childform.BringToFront();
            childform.Show();
        }

        private void iconButtonLogout_Click(object sender, EventArgs e)
        {
            this.Close();
            GUI_DangNhap dn = new GUI_DangNhap();
            dn.Show();
        }

        private void panelTiltleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }


        private void iconButtonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void iconButtonMaximinze_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Maximized;
            else
                WindowState = FormWindowState.Normal;
        }

        private void iconButtonClose_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        
    }
}
