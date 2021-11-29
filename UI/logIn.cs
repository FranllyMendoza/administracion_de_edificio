using administracion_de_edificio.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace administracion_de_edificio.UI
{
    public partial class logIn : Form
    {
        public logIn()
        {
            InitializeComponent();
        }

        private void Aceptar_button_Click(object sender, EventArgs e)
        {
            if (UsuariosBLL.ExisteCorreo(Usuario_textBox.Text, Clave_textBox.Text))
            {
                var ventana = new Inicio();
                ventana.Show();
            }
            else
            {
                errorProvider1.SetError(Usuario_textBox, "El usuario o la contraseña ingresadas son erroneos");
                errorProvider1.SetError(Clave_textBox, "El usuario o la contraseña ingresadas son erroneos");
                Clave_textBox.Clear();
            }
        }
    }
}
