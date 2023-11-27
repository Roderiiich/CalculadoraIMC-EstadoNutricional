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
    public partial class fmrDatosGuardados : Form
    {
        public fmrDatosGuardados()
        {
            InitializeComponent();
        }

        private void btnOkBorrado_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void fmrDatosGuardados_Load(object sender, EventArgs e)
        {

        }
    }
}
