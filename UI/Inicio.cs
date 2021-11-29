using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using administracion_de_edificio.UI.Registros;
using administracion_de_edificio.UI.Consultas;

namespace administracion_de_edificio.UI
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();

            this.Rusuarios.Click += new EventHandler(this.Rusuario_ItemClicked);
            this.Rclientes.Click += new EventHandler(this.Rclientes_ItemClicked);
            this.RFacturas.Click += new EventHandler(this.RFacturas_ItemClicked);
            this.Cclientes.Click += new EventHandler(this.Cclientes_ItemClicked);
            this.CFactura.Click += new EventHandler(this.CFactura_ItemClicked);
            this.Cusuarios.Click += new EventHandler(this.Cusuarios_ItemClicked);
        }

        // consulatas 
        private void Cusuarios_ItemClicked(object sender, EventArgs e)
        {
            cUsuarios usuario = new cUsuarios();
            usuario.MdiParent = this;
            usuario.Show();
        }

        private void CFactura_ItemClicked(object sender, EventArgs e)
        {
            cFactura factura = new cFactura();
            factura.MdiParent = this;
            factura.Show();
        }

        private void Cclientes_ItemClicked(object sender, EventArgs e)
        {
            cClientes clientes = new cClientes();
            clientes.MdiParent = this;
            clientes.Show();
            
        }
        // Registros 
        private void RFacturas_ItemClicked(object sender, EventArgs e)
        {
            rfacturas factura = new rfacturas();
            factura.MdiParent = this;
            factura.Show();

        }

        public void Rusuario_ItemClicked(object sender, EventArgs e)
        {
            rUsuario usuario = new rUsuario();
            usuario.MdiParent = this;
            usuario.Show();

        }

        public void Rclientes_ItemClicked(object sender, EventArgs e)
        {
            rClientes clientes = new rClientes();
            clientes.MdiParent = this;
            clientes.Show();
        }

       
    }
}
