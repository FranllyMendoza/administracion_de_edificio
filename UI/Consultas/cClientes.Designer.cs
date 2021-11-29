
namespace administracion_de_edificio.UI.Consultas
{
    partial class cClientes
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
            this.Buscar_button = new System.Windows.Forms.Button();
            this.Busqueda_textBox = new System.Windows.Forms.TextBox();
            this.Nuevobutton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Seleccionarbutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Buscar_button
            // 
            this.Buscar_button.Image = global::administracion_de_edificio.Properties.Resources.lupa;
            this.Buscar_button.Location = new System.Drawing.Point(446, 13);
            this.Buscar_button.Name = "Buscar_button";
            this.Buscar_button.Size = new System.Drawing.Size(112, 34);
            this.Buscar_button.TabIndex = 0;
            this.Buscar_button.Text = "Buscar";
            this.Buscar_button.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Buscar_button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Buscar_button.UseVisualStyleBackColor = true;
            this.Buscar_button.Click += new System.EventHandler(this.Buscar_button_Click);
            // 
            // Busqueda_textBox
            // 
            this.Busqueda_textBox.Location = new System.Drawing.Point(12, 13);
            this.Busqueda_textBox.Name = "Busqueda_textBox";
            this.Busqueda_textBox.Size = new System.Drawing.Size(428, 31);
            this.Busqueda_textBox.TabIndex = 2;
            // 
            // Nuevobutton
            // 
            this.Nuevobutton.Image = global::administracion_de_edificio.Properties.Resources.nueva_pagina;
            this.Nuevobutton.Location = new System.Drawing.Point(594, 13);
            this.Nuevobutton.Name = "Nuevobutton";
            this.Nuevobutton.Size = new System.Drawing.Size(112, 34);
            this.Nuevobutton.TabIndex = 3;
            this.Nuevobutton.Text = "Nuevo";
            this.Nuevobutton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Nuevobutton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Nuevobutton.UseVisualStyleBackColor = true;
            this.Nuevobutton.Click += new System.EventHandler(this.Nuevobutton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 62);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(1110, 623);
            this.dataGridView1.TabIndex = 4;
            // 
            // Seleccionarbutton
            // 
            this.Seleccionarbutton.Image = global::administracion_de_edificio.Properties.Resources.seleccione;
            this.Seleccionarbutton.Location = new System.Drawing.Point(736, 13);
            this.Seleccionarbutton.Name = "Seleccionarbutton";
            this.Seleccionarbutton.Size = new System.Drawing.Size(126, 34);
            this.Seleccionarbutton.TabIndex = 5;
            this.Seleccionarbutton.Text = "Seleccionar";
            this.Seleccionarbutton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Seleccionarbutton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Seleccionarbutton.UseVisualStyleBackColor = true;
            this.Seleccionarbutton.Click += new System.EventHandler(this.Seleccionarbutton_Click_1);
            // 
            // cClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1134, 697);
            this.Controls.Add(this.Seleccionarbutton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Nuevobutton);
            this.Controls.Add(this.Busqueda_textBox);
            this.Controls.Add(this.Buscar_button);
            this.Name = "cClientes";
            this.Text = "cClientes";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Buscar_button;
        private System.Windows.Forms.TextBox Busqueda_textBox;
        private System.Windows.Forms.Button Nuevobutton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Seleccionarbutton;
    }
}