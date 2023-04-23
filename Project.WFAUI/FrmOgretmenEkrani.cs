using Project.BLL.Repositories.ConcRep;
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
    public partial class FrmOgretmenEkrani : Form
    {
        string _num;
        public FrmOgretmenEkrani(string num)
        {
            InitializeComponent();
            _sRep = new StudentRepository();
            _num = num;
        }
        StudentRepository _sRep;

        private void FrmOgretmenEkrani_Load(object sender, EventArgs e)
        {
            dgv.DataSource = _sRep.GetAll();
        }

        Student _selected;
        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv.SelectedRows.Count >0)
            {
                _selected = dgv.SelectedRows[0].DataBoundItem as Student;
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                Student s = new Student();
                s.Number = mskNum.Text;
                s.FirstName = txtAd.Text;
                s.LastName = txtSoyad.Text;
                _sRep.Add(s);
                dgv.DataSource= _sRep.GetAll();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        void Temizle()
        {

            for (int i = 0; i < Controls.Count; i++)
            {
                if (Controls[i] is GroupBox)
                {
                    GroupBox grb = Controls[i] as GroupBox;
                    for (int j = 0; j < grb.Controls.Count; j++)
                    {
                        if (grb.Controls[j] is TextBox)
                        {
                            grb.Controls[j].Text = string.Empty;
                        }
                    }
                }
            }
            
            
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (_selected!= null)
            {
                _selected.Test1 = txtSınav1.Text;
                _selected.Test2 = txtSınav2.Text;
                _selected.Test3 = txtSınav3.Text;
                _sRep.Update(_selected);
                dgv.DataSource = _sRep.GetAll();
                Temizle();
            }
        }
    }
}
