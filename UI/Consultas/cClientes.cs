﻿using administracion_de_edificio.BLL;
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
    public partial class cClientes : Form
    {
        public cClientes()
        {
            InitializeComponent();
        }
        private void Limpiar()
        {
            Busqueda_textBox.Clear();
            dataGridView1.DataSource = null;
        }

        private void Nuevobutton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void Buscar_button_Click(object sender, EventArgs e)
        {
            var lista = new List<Clientes>();

            if (Busqueda_textBox.Text == string.Empty)
            {
                lista = ClientesBLL.GetList(r => true);
            }


            dataGridView1.DataSource = null;
            dataGridView1.DataSource = lista;
        }

        private void Seleccionarbutton_Click_1(object sender, EventArgs e)
        {
            string id;

            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Seleccionar una Fila", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            id = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            var Clientes = new rClientes();
            Clientes.RecibirClientes(Convert.ToInt32(id));
            Clientes.Show();
            Close();
        }
    }
}
