
namespace administracion_de_edificio.UI
{
    partial class Inicio
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.Registros = new System.Windows.Forms.ToolStripMenuItem();
            this.Rusuarios = new System.Windows.Forms.ToolStripMenuItem();
            this.Rclientes = new System.Windows.Forms.ToolStripMenuItem();
            this.Consulta = new System.Windows.Forms.ToolStripMenuItem();
            this.Cusuarios = new System.Windows.Forms.ToolStripMenuItem();
            this.Cclientes = new System.Windows.Forms.ToolStripMenuItem();
            this.CFactura = new System.Windows.Forms.ToolStripMenuItem();
            this.Facturar = new System.Windows.Forms.ToolStripMenuItem();
            this.RFacturas = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Registros,
            this.Consulta,
            this.Facturar,
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1132, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // Registros
            // 
            this.Registros.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Rusuarios,
            this.Rclientes});
            this.Registros.Name = "Registros";
            this.Registros.Size = new System.Drawing.Size(101, 29);
            this.Registros.Text = "Registros";
            // 
            // Rusuarios
            // 
            this.Rusuarios.Name = "Rusuarios";
            this.Rusuarios.Size = new System.Drawing.Size(275, 34);
            this.Rusuarios.Text = "Registro de usuarios";
            // 
            // Rclientes
            // 
            this.Rclientes.Name = "Rclientes";
            this.Rclientes.Size = new System.Drawing.Size(275, 34);
            this.Rclientes.Text = "Registro de clientes ";
            // 
            // Consulta
            // 
            this.Consulta.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Cusuarios,
            this.Cclientes,
            this.CFactura});
            this.Consulta.Name = "Consulta";
            this.Consulta.Size = new System.Drawing.Size(105, 29);
            this.Consulta.Text = "Consultas";
            // 
            // Cusuarios
            // 
            this.Cusuarios.Name = "Cusuarios";
            this.Cusuarios.Size = new System.Drawing.Size(284, 34);
            this.Cusuarios.Text = "Consulta de usuarios ";
            // 
            // Cclientes
            // 
            this.Cclientes.Name = "Cclientes";
            this.Cclientes.Size = new System.Drawing.Size(284, 34);
            this.Cclientes.Text = "Consulta de clientes";
            // 
            // CFactura
            // 
            this.CFactura.Name = "CFactura";
            this.CFactura.Size = new System.Drawing.Size(284, 34);
            this.CFactura.Text = "Consulta de Facturas";
            // 
            // Facturar
            // 
            this.Facturar.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.RFacturas});
            this.Facturar.Name = "Facturar";
            this.Facturar.Size = new System.Drawing.Size(90, 29);
            this.Facturar.Text = "Facturar";
            // 
            // RFacturas
            // 
            this.RFacturas.Name = "RFacturas";
            this.RFacturas.Size = new System.Drawing.Size(271, 34);
            this.RFacturas.Text = "Registro de facturas";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(16, 29);
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1132, 658);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Inicio";
            this.Text = "Inicio";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem Registros;
        private System.Windows.Forms.ToolStripMenuItem Consulta;
        private System.Windows.Forms.ToolStripMenuItem Facturar;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem Rusuarios;
        private System.Windows.Forms.ToolStripMenuItem Rclientes;
        private System.Windows.Forms.ToolStripMenuItem Cusuarios;
        private System.Windows.Forms.ToolStripMenuItem Cclientes;
        private System.Windows.Forms.ToolStripMenuItem CFactura;
        private System.Windows.Forms.ToolStripMenuItem RFacturas;
    }
}