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
            if (dgv.SelectedRows.Count > 0)
            {
                _selected = dgv.SelectedRows[0].DataBoundItem as Student;
                txtSınav1.Text = _selected.Test1.ToString();
                txtSınav2.Text = _selected.Test2.ToString();
                txtSınav3.Text = _selected.Test3.ToString();
                mskNum.Text = _selected.Number;
                txtAd.Text = _selected.FirstName;
                txtSoyad.Text = _selected.LastName;
                lblOrt.Text = _selected.Average.ToString();
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
                dgv.DataSource = _sRep.GetAll();
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

        private void btnGuncelle_Click(object sender, EventArgs e)
        {



            if (_selected != null)
            {
                _selected.Test1 = Convert.ToInt32(txtSınav1.Text);
                _selected.Test2 = Convert.ToInt32(txtSınav2.Text);
                _selected.Test3 = Convert.ToInt32(txtSınav3.Text);

                _selected.Average = (_selected.Test1 + _selected.Test2 + _selected.Test3) / 3;
                if (_selected.Average < 45)
                {
                    _selected.Case = false;

                    MessageBox.Show($"{_selected.FirstName} Ortalamanın altında kaldı");
                }
                else
                {
                    _selected.Case = true;
                    MessageBox.Show($"{_selected.FirstName} Başarılı");
                }

                lblOrt.Text = _selected.Average.ToString();



                _sRep.Update(_selected);
                dgv.DataSource = _sRep.GetAll();
                Temizle();
            }

        }
    }
}
