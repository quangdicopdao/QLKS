﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO_QLKS;
using BUS_QLKS;
using System.Runtime.InteropServices;

namespace Doancsn
{
    public partial class GUI_SuaKS : Form
    {
        string dt1, dt2, dt3, dt4, dt5;

        public GUI_SuaKS(string d1, string d2, string d3, string d4, string d5)
        {
            InitializeComponent();
            dt1 = d1;
            dt2 = d2;
            dt3 = d3;
            dt4 = d4;
            dt5 = d5;
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panelThem_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        BUS_KhachSan bus = new BUS_KhachSan();
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtMaks.Texts != "" && txtTenks.Texts != "" && txtDiaChi.Texts != "" && txtSoPhong.Texts != "" && cboMakv.Texts != "")
            {


                DTO_KhachSan dt = new DTO_KhachSan(txtMaks.Texts, txtTenks.Texts, txtDiaChi.Texts, Convert.ToInt32(txtSoPhong.Texts), cboMakv.Texts); ;
                if (bus.suaKhachSan(dt))
                {
                    MessageBox.Show("Sửa thành công");
                }
                else
                {
                    MessageBox.Show("Sửa ko thành công");
                }
            }
            else
            {
                MessageBox.Show("Xin hãy nhập đầy đủ");
            }
        }

        private void GUI_SuaKS_Load(object sender, EventArgs e)
        {
            //
            txtMaks.Texts = dt1;
            txtTenks.Texts = dt2;
            txtDiaChi.Texts = dt3;
            txtSoPhong.Texts = dt4;
            cboMakv.Texts = dt5;
        }

     


    }
}
