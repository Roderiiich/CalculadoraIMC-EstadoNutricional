using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraIMC
{
    public partial class frmMasculino : Form
    {
        private object dataTable;
        public frmMasculino()
        {
            InitializeComponent();
        }
        private void frmMasculino_Load(object sender, EventArgs e)
        {
            if (!File.Exists("NutriLife2.txt"))
            {
                StreamWriter archivo = new StreamWriter("NutriLife2.txt");
                archivo.Close();
            }

            else
            {
                StreamReader archivo = new StreamReader("NutriLife2.txt");
                while (!archivo.EndOfStream)
                {
                    string Rut = archivo.ReadLine();
                    string Nombres = archivo.ReadLine();
                    string Apellidos = archivo.ReadLine();
                    string Edad = archivo.ReadLine();
                    string IMC = archivo.ReadLine();
                    string Estado = archivo.ReadLine();
                    dt_Registros.Rows.Add(Rut, Nombres, Apellidos, Edad, IMC, Estado);
                }
                archivo.Close();
            }
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                float IMC, altura, peso, edad;
                string nombre, apellido, estado, rut;

                IMC = 0;
                altura = float.Parse(txtAltura.Text);
                peso = float.Parse(txtPeso.Text);
                edad = int.Parse(txtEdad.Text);
                rut = txtRut.Text;
                nombre = txtNombres.Text;
                apellido = txtApellidos.Text;
                estado = txtEstado.Text;

                if (edad <= 99 && edad >= 19)
                {

                    IMC = peso / (altura * altura);



                    txtIMC.Text = IMC.ToString("N2");
                    frmMuestraIMC formu = new frmMuestraIMC();
                    formu.txtResultadoIMC.Text = txtIMC.Text;
                    formu.lblEstNutri.Text = txtEstado.Text;
                    formu.Show();

                    // ADULTOS

                    if (cbAdultos.Checked == true)

                    {

                        if (IMC < 15)
                        {
                            txtEstado.Text = "Desnutrición muy severa";
                            formu.lblEstNutri.Text = txtEstado.Text;

                        }

                        if (IMC >= 15 && IMC <= 15.9)
                        {
                            txtEstado.Text = "Desnutrición severa";
                            formu.lblEstNutri.Text = txtEstado.Text;

                        }

                        if (IMC >= 16 && IMC <= 16.9)
                        {
                            txtEstado.Text = "Desnutrición moderada";
                            formu.lblEstNutri.Text = txtEstado.Text;

                        }

                        if (IMC >= 17 && IMC <= 18.4)
                        {
                            txtEstado.Text = "Desnutrición leve";
                            formu.lblEstNutri.Text = txtEstado.Text;
                        }

                        if (IMC >= 18.5 && IMC <= 24.9)
                        {
                            txtEstado.Text = "Normal";
                            formu.lblEstNutri.Text = txtEstado.Text;
                        }

                        if (IMC >= 25 && IMC <= 29.9)
                        {
                            txtEstado.Text = "Sobrepeso";
                            formu.lblEstNutri.Text = txtEstado.Text;
                        }

                        if (IMC >= 30 && IMC <= 34.9)
                        {
                            txtEstado.Text = "Obesidad grado 1";
                            formu.lblEstNutri.Text = txtEstado.Text;
                        }


                        if (IMC >= 35 && IMC <= 39.9)
                        {
                            txtEstado.Text = "Obesidad grado 2";
                            formu.lblEstNutri.Text = txtEstado.Text;
                        }


                        if (IMC >= 40 && IMC <= 49.9)
                        {
                            txtEstado.Text = "Obesidad grado 3";
                            formu.lblEstNutri.Text = txtEstado.Text;
                        }

                        if (IMC >= 50)
                        {
                            txtEstado.Text = "Obesidad grado 4";
                            formu.lblEstNutri.Text = txtEstado.Text;
                        }
                    }

                    //ADULTO MAYOR

                    if (cbMayor.Checked == true)
                    {

                        if (IMC <= 23)
                        {
                            txtEstado.Text = "Enflaquecido";
                            formu.lblEstNutri.Text = txtEstado.Text;
                        }

                        if (IMC >= 23.1 && IMC <= 27.9)
                        {
                            txtEstado.Text = "Normal";
                            formu.lblEstNutri.Text = txtEstado.Text;
                        }

                        if (IMC >= 28 && IMC <= 31.9)
                        {
                            txtEstado.Text = "Sobrepeso";
                            formu.lblEstNutri.Text = txtEstado.Text;
                        }

                        if (IMC >= 32)
                        {
                            txtEstado.Text = "Obesidad";
                            formu.lblEstNutri.Text = txtEstado.Text;
                        }



                    }
                }


                else
                {
                    frmErrorEdad frm = new frmErrorEdad();
                    frm.Show();
                }
            }


            catch
            {
                frmCamposrequeridos fmr = new frmCamposrequeridos();
                fmr.ShowDialog();
            }

        }
        private void GuardarDatos()
        {


            StreamWriter Guardararchivo = new StreamWriter("NutriLife2.txt", true);
            Guardararchivo.WriteLine(txtRut.Text);
            Guardararchivo.WriteLine(txtNombres.Text);
            Guardararchivo.WriteLine(txtApellidos.Text);
            Guardararchivo.WriteLine(txtEdad.Text);
            Guardararchivo.WriteLine(txtIMC.Text);
            Guardararchivo.WriteLine(txtEstado.Text);

            Guardararchivo.Close();


        }
        private void GrabarBorrado()
        {
            if (dt_Registros.SelectedRows.Count > 0)
            {

                DataGridViewRow filaSeleccionada = dt_Registros.SelectedRows[0];


                dt_Registros.Rows.Remove(filaSeleccionada);


                GuardarCambios();
            }



        }




        private void btnGuardarDatos_Click(object sender, EventArgs e)
        {

            if (txtAltura.Text != "" || txtApellidos.Text != "" || txtNombres.Text != "" || txtRut.Text != "" || txtEdad.Text != "")
            {
                GuardarDatos();

                dt_Registros.Rows.Add(txtRut.Text, txtNombres.Text, txtApellidos.Text, txtEdad.Text, txtIMC.Text, txtEstado.Text);


                frmGuardado fmr = new frmGuardado();
                fmr.ShowDialog();
            }
            else
            {
                frmCamposrequeridos fmr = new frmCamposrequeridos();
                fmr.ShowDialog();
            }

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNombres.Clear();
            txtApellidos.Clear();
            txtRut.Clear();
            txtEdad.Clear();
            txtAltura.Clear();
            txtPeso.Clear();
            txtIMC.Clear();
            txtEstado.Clear();
            cbAdultos.Checked = false;
            cbMayor.Checked = false;
            cbMayor.Enabled = true;
            cbAdultos.Enabled = true;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbAdultos_CheckedChanged(object sender, EventArgs e)
        {
            if (cbAdultos.Checked == true)
            {
                cbMayor.Enabled = false;
            }
            else
            {
                cbMayor.Enabled = true;
            }

        }

        private void cbMayor_CheckedChanged(object sender, EventArgs e)
        {

            if (cbMayor.Checked == true)
            {
                cbAdultos.Enabled = false;
            }
            else
            {
                cbAdultos.Enabled = true;
            }
        }

        private void btnGuardarCambios_Click(object sender, EventArgs e)
        {
            GuardarCambios();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            dt_Registros.Rows.Remove(dt_Registros.CurrentRow);
            frmBorrado frm = new frmBorrado();
            frm.ShowDialog();
            GrabarBorrado();
        }

        private void txtEditar_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            dt_Registros.CurrentCell.Value = txtEditar.Text;
            GrabarBorrado();
        }
        private void GuardarCambios()
        {

            try
            {
                using (StreamWriter archivo = new StreamWriter("NutriLife2.txt"))
                {

                    for (int f = 0; f < dt_Registros.Rows.Count; f++)
                    {

                        if (dt_Registros.Rows[f].IsNewRow == false)
                        {

                            for (int c = 0; c < dt_Registros.Columns.Count; c++)
                            {

                                if (dt_Registros.Rows[f].Cells[c].Value != null)
                                {
                                    archivo.WriteLine(dt_Registros.Rows[f].Cells[c].Value.ToString());
                                }
                                else
                                {

                                    archivo.WriteLine("Valor Nulo");
                                }
                            }
                        }
                    }
                }
                fmrDatosGuardados frm = new fmrDatosGuardados();
                frm.ShowDialog();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al guardar cambios: " + ex.Message);

            }
        }
        private void dt_Registros_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dt_Registros_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dt_Registros.CurrentCell != null && dt_Registros.CurrentCell.Selected && dt_Registros.CurrentCell.Value != null)
            {
                txtEditar.Text = dt_Registros.CurrentCell.Value.ToString();
            }
        }
    }
    }

    

