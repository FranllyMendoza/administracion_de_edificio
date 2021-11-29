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
using System.Drawing.Printing;

namespace administracion_de_edificio.UI.Registros
{
    public partial class rfacturas : Form
    {
        public rfacturas()
        {
            InitializeComponent();
        }
        private void Limpiar()
        {
            ID_numericUpDown.Value = 0;
            Nombre_textBox.Clear();
            Monto_textBox.Clear();
            Fecha_dateTimePicker.Value = DateTime.Now;
        } 

        private void llenacampo(Facturar facturar)
        {
            ID_numericUpDown.Value = facturar.IdFactura;
            Nombre_textBox.Text = facturar.Nombre;
            Monto_textBox.Text = facturar.Monto;
            Fecha_dateTimePicker.Value = facturar.Fecha_pago;

        }

        private Facturar llenaclase()
        {
            Facturar facturar = new Facturar();

            facturar.IdFactura = (int)ID_numericUpDown.Value;
            facturar.Nombre = Nombre_textBox.Text;
            facturar.Monto = Monto_textBox.Text;
            facturar.Fecha_pago = Fecha_dateTimePicker.Value;

            return facturar;

        }

        private bool validar()
        {
            bool paso = true;

            if (string.IsNullOrWhiteSpace(Nombre_textBox.Text))
            {
                errorProvider.SetError(Nombre_textBox, "Este campo no puede estar vacio");
                Nombre_textBox.Focus();
                paso = false;
            }
            if (string.IsNullOrWhiteSpace(Monto_textBox.Text))
            {
                errorProvider.SetError(Monto_textBox, "Este campo no puede estar vacio");
                Monto_textBox.Focus();
                paso = false;
            }

            return paso;
        }
        public void RecibirFactura(int id)
        {
            Facturar factura = FacturaBLL.Buscar(id);

            llenacampo(factura);
        }

        private void Imprimir_button_Click(object sender, EventArgs e)
        {
            Facturar facturar;

            if (!validar())
                return;

            facturar = llenaclase();

            var paso = FacturaBLL.Guardar(facturar);

            // parte de impresión
            printDocument1 = new PrintDocument();
            PrinterSettings ps = new PrinterSettings();
            printDocument1.PrinterSettings = ps;
            printDocument1.PrintPage += imprimir;
            printDocument1.Print();


            if (paso)
            {
                Limpiar();
                MessageBox.Show("Transacción Exitosa!!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Transacción Fallida!!", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);


       
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

            if (FacturaBLL.Eliminar(id))
                MessageBox.Show("Transacción Exitosa!!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                errorProvider.SetError(ID_numericUpDown, "Id no existente");
        }

        private void Buscar_button_Click(object sender, EventArgs e)
        {
            errorProvider.Clear();
            cFactura factura = new cFactura();
            factura.Show();
            Close();
        }
        //funcion para la imprecion

        private void imprimir(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Facturar facturar = new Facturar();
            Font font = new Font("Calibri",11);
            int ancho = 300;
            int y = 20;
            e.Graphics.DrawString("-- Factura de pago --", font, Brushes.Black, new RectangleF(0, y += 20, ancho, 20));
            e.Graphics.DrawString("-- Id de Factura: "+ID_numericUpDown.Value, font, Brushes.Black, new RectangleF(0, y += 20, ancho, 20));
            e.Graphics.DrawString("-- Fecha pago: "+Fecha_dateTimePicker.Text, font, Brushes.Black, new RectangleF(0, y += 20, ancho, 20));
            e.Graphics.DrawString("-- Nombre: "+Nombre_textBox.Text, font, Brushes.Black, new RectangleF(0, y += 20, ancho, 20));
            e.Graphics.DrawString("-- Pago por Alquiler --", font, Brushes.Black, new RectangleF(0, y += 30, ancho, 20));
            e.Graphics.DrawString("-- Monto Total: "+Monto_textBox.Text, font, Brushes.Black, new RectangleF(0, y += 20, ancho, 20));
            e.Graphics.DrawString("-- Gracias por Pagar --", font, Brushes.Black, new RectangleF(0, y += 40, ancho, 20));

        }


    }
}
