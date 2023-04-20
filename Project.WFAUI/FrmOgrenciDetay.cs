﻿using Project.BLL.DesignPatterns.SingletonPattern;
using Project.BLL.Repositories.ConcRep;
using Project.DAL.Context;
using Project.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project.WFAUI
{
    public partial class FrmOgrenciDetay : Form
    {
        MyContext _db;

        StudentRepository _sRep;
        public FrmOgrenciDetay()
        {
            InitializeComponent();
            _db = DBTool.DbInstance;
            _sRep = new StudentRepository();

        }


        public string numara;

        private void FrmOgrenciDetay_Load(object sender, EventArgs e)
        {
           
            lblNumara.Text = numara;

        }
    }
}
