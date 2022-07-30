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
using BUS_QLKS;
using DTO_QLKS;
namespace Doancsn
{
    public partial class GUI_User : Form
    {
        BUS_KhachSan bus = new BUS_KhachSan();
        private IconButton currentBtn;
        private Panel leftborderBtn;
        private Form currentChilForm;
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(IntPtr hWnd, int wMsg, int wParam, int lParam);
        public GUI_User()
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
        }
        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(72, 61, 139);
                currentBtn.ForeColor = Color.White;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.White;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;

            }
        }
        private void ActivateButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableButton();
                //button
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(37, 36, 81);
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
                
            }
        }
        private void Reset()
        {
            DisableButton();
            leftborderBtn.Visible = false;
        }

        private void panelTitle_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Maximized;
            else
                WindowState = FormWindowState.Normal;
        }

        private void btnExits_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        

        private void btnKS1_Click(object sender, EventArgs e)
        {

        }

        private void btnAccountUser_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            GUI_DoiMatKhau dmk = new GUI_DoiMatKhau();
            dmk.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color2);
            this.Hide();
            GUI_DangNhap dn = new GUI_DangNhap();
            dn.Show();
        }
        void CreateButtonHotel(int row, int col)
        {
            int indexTop = 50;
            for (int i = 0; i < row; i++)
            {
                int indexLeft = 50;
                for (int j = 0; j < col; j++)
                {
                    //create new button
                    FontAwesome.Sharp.IconButton btn = new FontAwesome.Sharp.IconButton();
                    //RJButton btn = new RJButton();
                    btn.Name = string.Format("bt01", i, j);
                    btn.Tag = string.Format("[{0},{1}]", i, j);
                    btn.Text = string.Format("KS{0}{1}", i, j + 1);
                    btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
                    btn.Size = new Size(285, 142);
                    btn.Top = indexTop;
                    btn.Left = indexLeft;

                    indexLeft += 300;
                    btn.IconChar = FontAwesome.Sharp.IconChar.Hotel;
                    btn.IconColor = Color.White;
                    btn.TextImageRelation = TextImageRelation.ImageBeforeText;
                    btn.IconSize = 60;
                    btn.FlatAppearance.BorderSize = 0;
                    btn.FlatStyle = FlatStyle.Flat;
                    btn.BackColor = Color.FromArgb(154, 205, 50);
                    btn.ForeColor = Color.White;

                    //events click
                    btn.Click += (sender1, args) =>
                    {

                        GUI_UserPhong dv = new GUI_UserPhong();
                        dv.Show();
                        this.Hide();
                       
                    };


                    //panel
                    panelKS.Controls.Add(btn);
                }
                indexTop += 200;
            }
        }

        private void GUI_NguoiDung_Load(object sender, EventArgs e)
        {
            CreateButtonHotel(3,3);
        }

        private void cboArea_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            lblKhuVuc.Text = cboArea.Texts;
        }

        private void picboxHome_Click(object sender, EventArgs e)
        {
            Reset();
        }

        
    }
}
