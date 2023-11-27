using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraIMC
{
    public partial class frmBorrado : Form
    {
        public frmBorrado()
        {
            InitializeComponent();
        }

        private void btnOkBorrado_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
