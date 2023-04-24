using Project.BLL.DesignPatterns.SingletonPattern;
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

        string _num;
        public FrmOgrenciDetay(string numara)
        {
            InitializeComponent();
            _db = DBTool.DbInstance;
            _num = numara;
            _sRep = new StudentRepository();

        }

        private void FrmOgrenciDetay_Load(object sender, EventArgs e)
        {
            Student s = _db.Students.FirstOrDefault(x => x.Number == _num);

            if (s != null)
            {
                lblAdSoyad.Text = s.FirstName + " " + s.LastName;
                lblNumara.Text = s.Number;
                lblSınav1.Text = s.Test1.ToString();
                lblSınav2.Text = s.Test2.ToString();
                lblSınav3.Text = s.Test3.ToString();
                lblDurum.Text = s.Case.ToString();

              s.Average=  (s.Test1 + s.Test2 + s.Test3) / 3;
                lblOrt.Text= s.Average.ToString();

            }



        }
    }
}
