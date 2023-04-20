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
    public partial class FrmOgretmen : Form
    {
        string _numara;
        public FrmOgretmen(string _num)
        {
            InitializeComponent();
           _numara = _num;
        }

        private void FrmOgretmen_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'nTierNoteRecordingSystemDBDataSet.Students' table. You can move, or remove it, as needed.
            this.studentsTableAdapter.Fill(this.nTierNoteRecordingSystemDBDataSet.Students);

        }
    }
}
