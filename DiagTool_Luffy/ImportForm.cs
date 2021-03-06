﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DiagTool_Luffy
{
    public partial class ImportForm : Form
    {
        public ImportForm()
        {
            InitializeComponent();
        }

        /*Run before display*/
        private void ImportWindowLoad(object sender, EventArgs e)
        {
            LoadDllPathnameTextBox();
        }

        private void LoadDllPathnameTextBox()
        {
             DllPathnameTextBox.Text = Global.SecurityAccessDllPathname;
        }

        private void DllSelectButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog OpenFileDialog = new OpenFileDialog();
            OpenFileDialog.Filter = "Dll Files (*.dll)|*.dll|All files (*.*)|*.*";
            OpenFileDialog.RestoreDirectory = true;
            OpenFileDialog.FilterIndex = 1;
            if (OpenFileDialog.ShowDialog() == DialogResult.OK)
            {
                DllPathnameTextBox.Text = OpenFileDialog.FileName;
            }
            else
            {
                DllPathnameTextBox.Text = "";
            }
        }

        private void YesButton_Click(object sender, EventArgs e)
        {
            Global.SecurityAccessDllPathname = DllPathnameTextBox.Text;
            this.Close();
        }

        private void ConcelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /*Redefine FormClosing action*/
        private void ImportFormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            e.Cancel = true;
        }
    }
}
