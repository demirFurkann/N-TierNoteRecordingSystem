using Project.BLL.DesignPatterns.SingletonPattern;
using Project.DAL.Context;
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
    public partial class GirisEkranı : Form
    {
        MyContext _db;
        public GirisEkranı()
        {
            InitializeComponent();
            _db = DBTool.DbInstance;
        }


        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (_db.AppUsers.Any(x => x.UserName == txtUserName.Text && x.Password == txtPassword.Text))
            {
                FrmOgretmenEkrani frod = new FrmOgretmenEkrani(txtPassword.Text);
                frod.ShowDialog();
                
            }
            if (_db.Students.Any(x => x.Number == txtPassword.Text&& x.FirstName== txtUserName.Text))
            {
                FrmOgrenciDetay frd = new FrmOgrenciDetay(txtPassword.Text);


                frd.ShowDialog();
                
            }
         
            


        }
    }
}
