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
    public partial class rUsuario : Form
    {
        public rUsuario()
        {
            InitializeComponent();
        }

        private void Limpiar()
        {
            ID_numericUpDown.Value = 0;
            Nombre_textBox.Clear();
            Cedula_maskedTextBox.Clear();
            Telefono_maskedTextBox.Clear();
            correo_textBox.Clear();
            Clave_textBox.Clear();
            Fecha_dateTimePicker.Value = DateTime.Now;
        }
        private void llenacampo(Usuario usuario)
        {
            ID_numericUpDown.Value = usuario.usuarioId;
            Nombre_textBox.Text = usuario.Nombre;
            Cedula_maskedTextBox.Text = usuario.Cedula;
            Telefono_maskedTextBox.Text = usuario.Telefono;
            correo_textBox.Text = usuario.Correo;
            Clave_textBox.Text = usuario.Clave;
            Fecha_dateTimePicker.Value = usuario.Fecha;
        }

        private Usuario llenaClase()
        {
            Usuario usuario = new Usuario();
            usuario.usuarioId = (int)ID_numericUpDown.Value;
            usuario.Nombre = Nombre_textBox.Text;
            usuario.Cedula = Cedula_maskedTextBox.Text;
            usuario.Telefono = Telefono_maskedTextBox.Text;
            usuario.Correo = correo_textBox.Text;
            usuario.Clave = Clave_textBox.Text;
            usuario.Fecha = Fecha_dateTimePicker.Value;

            return usuario;
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
            if (string.IsNullOrWhiteSpace(correo_textBox.Text))
            {
                errorProvider.SetError(correo_textBox, "Este campo no puede estar vacío");
                correo_textBox.Focus();
                paso = false;
            }
            if (string.IsNullOrWhiteSpace(Clave_textBox.Text))
            {
                errorProvider.SetError(Clave_textBox, "Este campo no puede estar vacío");
                Clave_textBox.Focus();
                paso = false;
            }

            return paso;
        }

        public void RecibirUsuarios(int id)
        {
            Usuario usuario = UsuariosBLL.Buscar(id);

            llenacampo(usuario);
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

            if (UsuariosBLL.Eliminar(id))
                MessageBox.Show("Transacción Exitosa!!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                errorProvider.SetError(ID_numericUpDown, "Id no existente");

        }



        private void Guardar_button_Click(object sender, EventArgs e)
        {
            Usuario usuario;

            if (!Validar())
                return;

            usuario = llenaClase();

            var paso = UsuariosBLL.Guardar(usuario);

            if (paso)
            {
                Limpiar();
                MessageBox.Show("Transacción Exitosa!!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Transacción Fallida!!", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            errorProvider.Clear();
            cUsuarios usuarios = new cUsuarios();
            usuarios.Show();
            Close();

        }
    }   
}
