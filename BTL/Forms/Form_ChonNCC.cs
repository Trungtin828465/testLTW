﻿using BLL;
using DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DONGHO.Forms
{
    public partial class Form_ChonNCC : Form
    {
        public Form_ChonNCC()
        {
            InitializeComponent();
            LoadComboBoxData();
        }

       
        private void button1_Click(object sender, EventArgs e)
        {
            
            Form_NCC frm = new Form_NCC();

           
            frm.FormClosed += Frm_FormClosed;

            frm.ShowDialog();
        }

        private void Frm_FormClosed(object sender, FormClosedEventArgs e)
        {
          
            LoadComboBoxData();
        }

       

        private void button9_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private int selectedSupplierID;

        public void LoadComboBoxData()
        {
            cboNCC.DataSource = SupplierBL.GetInstance.GetDanhSachNhaCungCap();
            cboNCC.ValueMember = "SupplierID";
            cboNCC.DisplayMember = "ContactName";
        }

        private void btnChon_Click(object sender, EventArgs e)
        {
            if (cboNCC.SelectedValue != null)
            {
                selectedSupplierID = Convert.ToInt32(cboNCC.SelectedValue);
                MessageBox.Show($"SupplierID được chọn: {selectedSupplierID}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                SupplierProductDL.SelectedSupplierID = selectedSupplierID;
                this.Close();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn nhà cung cấp!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void cboNCC_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }
    }
}
