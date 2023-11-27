using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp3;

namespace CalculadoraIMC
{
    public partial class frmInicioSesion : Form
    {
        public frmInicioSesion()
        {
            InitializeComponent();
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            
            if(txtNombre.Text!=""&&mtxtRut.Text!="") 
                    
           {

                if (rbtnFemenino.Checked == true)
                {

                    Form1 frm = new Form1();
                    frm.lbUsuario.Text = txtNombre.Text;
                    frm.ShowDialog();
                    this.Close();

                }
                else
                {
                    frmMasculino frmasculino = new frmMasculino();
                    frmasculino.lbUsuario.Text=txtNombre.Text;
                    frmasculino.ShowDialog();
                    this.Close();
                }
            }
            else
            { 
                frmCamposrequeridos frm = new frmCamposrequeridos();
                frm.ShowDialog();
            }
           
            
        }

        private void frmInicioSesion_Load(object sender, EventArgs e)
        {

        }
    }
}
