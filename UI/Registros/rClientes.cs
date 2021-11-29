using administracion_de_edificio.BLL;
using administracion_de_edificio.Entidades;
using administracion_de_edificio.UI.Consultas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace administracion_de_edificio.UI.Registros
{
    public partial class rClientes : Form
    {
        public rClientes()
        {
            InitializeComponent();
        }
        private void Limpiar()
        {
            ID_numericUpDown.Value = 0;
            Nombre_textBox.Clear();
            Cedula_maskedTextBox.Clear();
            Telefono_maskedTextBox.Clear();
            Telefono2_maskedTextBox.Clear();
            correo_textBox.Clear();
            Piso_textBox.Clear();
            Apartamento_textBox.Clear();
            Parqueo_textBox.Clear();
            Referencia_textBox.Clear();
            Telefono_referencia_maskedTextBox.Clear();
            Fecha_dateTimePicker.Value = DateTime.Now;
        }
        private void llenacampo(Clientes clientes)
        {
            ID_numericUpDown.Value = clientes.IDcliente;
            Nombre_textBox.Text = clientes.Nombre;
            Cedula_maskedTextBox.Text = clientes.Cedula;
            Telefono_maskedTextBox.Text = clientes.Telefono;
            Telefono2_maskedTextBox.Text = clientes.Telefono2;
            correo_textBox.Text = clientes.Correo;
            Piso_textBox.Text = clientes.Piso;
            Apartamento_textBox.Text = clientes.Apartamento;
            Parqueo_textBox.Text = clientes.Parqueo;
            Referencia_textBox.Text = clientes.Nombre_referencia;
            Telefono_referencia_maskedTextBox.Text = clientes.Numero_referencia;
            Fecha_dateTimePicker.Value = clientes.Fecha_registro;
        }

        private Clientes llenaClase()
        {
            Clientes clientes = new Clientes();
            clientes.IDcliente = (int)ID_numericUpDown.Value;
            clientes.Nombre = Nombre_textBox.Text;
            clientes.Cedula = Cedula_maskedTextBox.Text;
            clientes.Telefono = Telefono_maskedTextBox.Text;
            clientes.Telefono2 = Telefono2_maskedTextBox.Text;
            clientes.Correo = correo_textBox.Text;
            clientes.Piso = Piso_textBox.Text;
            clientes.Apartamento = Apartamento_textBox.Text;
            clientes.Parqueo = Parqueo_textBox.Text;
            clientes.Nombre_referencia = Referencia_textBox.Text;
            clientes.Numero_referencia = Telefono_referencia_maskedTextBox.Text;
            clientes.Fecha_registro = Fecha_dateTimePicker.Value;

            return clientes;
        }

        private bool Validar()
        {
            bool paso = true;

            if (string.IsNullOrWhiteSpace(Nombre_textBox.Text))
            {
                errorProvider.SetError(Nombre_textBox, "Este campo no puede estar vacío");
                Nombre_textBox.Focus();
                paso = false;
            }
            if (string.IsNullOrWhiteSpace(Cedula_maskedTextBox.Text))
            {
                errorProvider.SetError(Cedula_maskedTextBox, "Este campo no puede estar vacío");
                Cedula_maskedTextBox.Focus();
                paso = false;
            }
            if (string.IsNullOrWhiteSpace(Telefono_maskedTextBox.Text))
            {
                errorProvider.SetError(Telefono_maskedTextBox, "Este campo no puede estar vacío");
                Telefono_maskedTextBox.Focus();
                paso = false;
            }
            if (string.IsNullOrWhiteSpace(Telefono2_maskedTextBox.Text))
            {
                errorProvider.SetError(Telefono2_maskedTextBox, "Este campo no puede estar vacío");
                Telefono2_maskedTextBox.Focus();
                paso = false;
            }
            if (string.IsNullOrWhiteSpace(correo_textBox.Text))
            {
                errorProvider.SetError(correo_textBox, "Este campo no puede estar vacío");
                correo_textBox.Focus();
                paso = false;
            }
            if (string.IsNullOrWhiteSpace(Piso_textBox.Text))
            {
                errorProvider.SetError(Piso_textBox, "Este campo no puede estar vacío");
                Piso_textBox.Focus();
                paso = false;
            }
            if (string.IsNullOrWhiteSpace(Apartamento_textBox.Text))
            {
                errorProvider.SetError(Apartamento_textBox, "Este campo no puede estar vacio");
                Apartamento_textBox.Focus();
                paso = false;
            }
            if (string.IsNullOrWhiteSpace(Referencia_textBox.Text))
            {
                errorProvider.SetError(Referencia_textBox, "Este campo no puede estar vacio");
                Referencia_textBox.Focus();
                paso = false;
            }
            if (string.IsNullOrWhiteSpace(Telefono_referencia_maskedTextBox.Text))
            {
                errorProvider.SetError(Telefono_referencia_maskedTextBox, "Este campo no puede estar vacio");
                Telefono_referencia_maskedTextBox.Focus();
                paso = false;
            }


            return paso;
        }
        public void RecibirClientes(int id)
        {
           Clientes clientes = ClientesBLL.Buscar(id);

            llenacampo(clientes);
        }
        private void Nuevo_button_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void Eliminar_button_Click(object sender, EventArgs e)
        {
            int id;
            int.TryParse(ID_numericUpDown.Text, out id);

            Limpiar();

            if (ClientesBLL.Eliminar(id))
                MessageBox.Show("Transacción Exitosa!!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                errorProvider.SetError(ID_numericUpDown, "Id no existente");
        }

        private void Guardar_button_Click(object sender, EventArgs e)
        {
            Clientes clientes;

            if (!Validar())
                return;

            clientes = llenaClase();

            var paso = ClientesBLL.Guardar(clientes);

            if (paso)
            {
                Limpiar();
                MessageBox.Show("Transacción Exitosa!!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Transacción Fallida!!", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void Buscar_button_Click(object sender, EventArgs e)
        {
            errorProvider.Clear();
            cClientes clientes = new cClientes();
            clientes.Show();
            Close();
        }
    }
}
