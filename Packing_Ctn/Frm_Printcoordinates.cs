﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;

namespace Packing_Ctn
{
    public partial class Frm_Printcoordinates : Office2007Form //Form
    {
        public Frm_Printcoordinates(string sPatch)
        {
            InitializeComponent();
            IniFilePath = sPatch;
        }
        string IniFilePath;
        private void Frm_Printcoordinates_Load(object sender, EventArgs e)
        {
         string  LabelX=  OperateIni.IniReadValue("PACK_CTN", "LabelX",  IniFilePath);
          string  LabelY = OperateIni.IniReadValue("PACK_CTN", "LabelY",IniFilePath);
          numerX.Value = Convert.ToDecimal(LabelX);
          numerY.Value = Convert.ToDecimal(LabelY);
        }

        private void imbt_OK_Click(object sender, EventArgs e)
        {
            OperateIni.IniWriteValue("PACK_CTN", "LabelX", numerX.Value.ToString(), IniFilePath);
            OperateIni.IniWriteValue("PACK_CTN", "LabelY", numerY.Value.ToString(), IniFilePath);
            this.DialogResult = DialogResult.OK;
        }

        private void imbt_abort_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
