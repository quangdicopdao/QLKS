﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Doancsn
{
    public partial class GUI_UserPhong : Form
    {
        
        public GUI_UserPhong()
        {
            InitializeComponent();
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(IntPtr hWnd, int wMsg, int wParam, int lParam);
        
        void CreateButtonRoom(int row,int col)
        {
            int indexTop = 50;
            for(int i = 0; i < row; i++)
            {
                int indexLeft = 50;
                for( int j = 0; j < col; j++)
                {
                    //create new button
                    FontAwesome.Sharp.IconButton btn = new FontAwesome.Sharp.IconButton();
                    //RJButton btn = new RJButton();
                    btn.Name = string.Format("bt01",i,j);
                    btn.Tag = string.Format("[{0},{1}]",i,j);
                    btn.Text = string.Format("P{0}{1}", i, j+1);
                    btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
                    btn.Size = new Size(285, 142);
                    btn.Top = indexTop;
                    btn.Left = indexLeft;

                    indexLeft += 300;
                    btn.IconChar = FontAwesome.Sharp.IconChar.CircleCheck;
                    btn.IconColor = Color.White;
                    btn.TextImageRelation = TextImageRelation.ImageBeforeText;
                    btn.IconSize = 60;
                    btn.FlatAppearance.BorderSize = 0;
                    btn.FlatStyle = FlatStyle.Flat;
                    btn.BackColor = Color.FromArgb(154,205, 50);
                    btn.ForeColor = Color.White;

                    //events click
                    btn.Click += (sender1, args) =>
                     {
                        
                          GUI_UserThemDV dv = new GUI_UserThemDV(btn.Text);
                                dv.Show();
                         btn.IconChar = FontAwesome.Sharp.IconChar.User;
                         btn.BackColor = Color.DarkGray;
                     };
                    
                   
                    //panel
                    panelCreateRoom.Controls.Add(btn);
                }
                indexTop += 200;
            }
        }

        void CreateButtonRoom2(int row, int col)
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
                    btn.Text = string.Format("P{0}{1}", i, j + 1);
                    btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
                    btn.Size = new Size(285, 142);
                    btn.Top = indexTop;
                    btn.Left = indexLeft;

                    indexLeft += 300;
                    btn.IconChar = FontAwesome.Sharp.IconChar.User;
                    btn.IconColor = Color.White;
                    btn.TextImageRelation = TextImageRelation.ImageBeforeText;
                    btn.IconSize = 60;
                    btn.FlatAppearance.BorderSize = 0;
                    btn.FlatStyle = FlatStyle.Flat;
                    btn.BackColor = Color.FromArgb(112,128,144);
                    btn.ForeColor = Color.White;

                    //events click
                    btn.Click += (sender1, args) =>
                    {

                        GUI_UserThemDV dv = new GUI_UserThemDV(btn.Text);
                        dv.Show();
                        btn.IconChar = FontAwesome.Sharp.IconChar.User;
                        btn.BackColor = Color.DarkGray;
                    };


                    //panel
                    panelCreateRoom.Controls.Add(btn);
                }
                indexTop += 200;
            }
        }
        private void GUI_UserPhong_Load(object sender, EventArgs e)
        {
        }

        private void panelClose_MouseDown(object sender, MouseEventArgs e)
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

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
            GUI_User nd = new GUI_User();
            nd.Show();
        }
        // thay doi label
        void changeLabel()
        {
            if(btnPhongtrong.Checked == true)
            {
                lbTrangThai.Text = btnPhongtrong.Text;
            }
            else if (btnPhongdadat.Checked == true)
            {
                lbTrangThai.Text = btnPhongdadat.Text;
            }
            else if (btnPhongtrong.Checked == true)
            {
                lbTrangThai.Text = btnPhongtrong.Text;
            }
            else if (btnPhongdon.Checked == true)
            {
                lbTrangThai.Text = btnPhongdon.Text;
            }
            else if (btnPhongdoi.Checked == true)
            {
                lbTrangThai.Text = btnPhongdoi.Text;
            }
            else if(btnTatCa.Checked == true)
            {
                lbTrangThai.Text = btnTatCa.Text;
            }
            
        }

        private void btnPhongtrong_CheckedChanged(object sender, EventArgs e)
        {
            CreateButtonRoom(1, 5);
            changeLabel();
        }

        private void btnPhongdadat_CheckedChanged(object sender, EventArgs e)
        {
            CreateButtonRoom2(2, 5);
            changeLabel();
        }

        private void btnTatCa_CheckedChanged(object sender, EventArgs e)
        {
            CreateButtonRoom(5, 5);
            changeLabel();
        }

        private void btnPhongdon_CheckedChanged(object sender, EventArgs e)
        {
            changeLabel();
        }

        private void btnPhongdoi_CheckedChanged(object sender, EventArgs e)
        {
            changeLabel();
        }

        
    }
}
