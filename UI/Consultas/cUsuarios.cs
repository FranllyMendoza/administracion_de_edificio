using administracion_de_edificio.BLL;
using administracion_de_edificio.Entidades;
using administracion_de_edificio.UI.Registros;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace administracion_de_edificio.UI.Consultas
{
    public partial class cUsuarios : Form
    {
        public cUsuarios()
        {
            InitializeComponent();
        }
        private void Limpiar()
        {
            Buscar_textBox.Clear();
            dataGridView1.DataSource = null;
        }

        private void Buscar_button_Click(object sender, EventArgs e)
        {
            var lista = new List<Usuario>();

            if (Buscar_textBox.Text == string.Empty)
            {
                lista = UsuariosBLL.GetList(r => true);
            }


            dataGridView1.DataSource = null;
            dataGridView1.DataSource = lista;
        }

        private void Nuevo_button_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void Seleccionar_button_Click(object sender, EventArgs e)
        {
             string id;

            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Seleccionar una Fila", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            id = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            var usuario = new rUsuario();
            usuario.RecibirUsuarios(Convert.ToInt32(id));
            usuario.Show();
            Close();
        }
    }
}
