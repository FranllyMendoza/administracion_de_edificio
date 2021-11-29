
namespace administracion_de_edificio.UI.Registros
{
    partial class rfacturas
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
            this.components = new System.ComponentModel.Container();
            this.Imprimir_button = new System.Windows.Forms.Button();
            this.Nuevo_button = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ID_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.Fecha_dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.Nombre_textBox = new System.Windows.Forms.TextBox();
            this.Monto_textBox = new System.Windows.Forms.TextBox();
            this.Buscar_button = new System.Windows.Forms.Button();
            this.Eliminar_button = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            ((System.ComponentModel.ISupportInitialize)(this.ID_numericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // Imprimir_button
            // 
            this.Imprimir_button.Image = global::administracion_de_edificio.Properties.Resources.guardar_el_archivo;
            this.Imprimir_button.Location = new System.Drawing.Point(28, 239);
            this.Imprimir_button.Name = "Imprimir_button";
            this.Imprimir_button.Size = new System.Drawing.Size(137, 49);
            this.Imprimir_button.TabIndex = 0;
            this.Imprimir_button.Text = "imprimir";
            this.Imprimir_button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Imprimir_button.UseVisualStyleBackColor = true;
            this.Imprimir_button.Click += new System.EventHandler(this.Imprimir_button_Click);
            // 
            // Nuevo_button
            // 
            this.Nuevo_button.Image = global::administracion_de_edificio.Properties.Resources.nueva_pagina;
            this.Nuevo_button.Location = new System.Drawing.Point(367, 239);
            this.Nuevo_button.Name = "Nuevo_button";
            this.Nuevo_button.Size = new System.Drawing.Size(137, 49);
            this.Nuevo_button.TabIndex = 1;
            this.Nuevo_button.Text = "Nuevo";
            this.Nuevo_button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Nuevo_button.UseVisualStyleBackColor = true;
            this.Nuevo_button.Click += new System.EventHandler(this.Nuevo_button_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nombre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Monto:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 25);
            this.label4.TabIndex = 5;
            this.label4.Text = "Factura ID:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 25);
            this.label5.TabIndex = 6;
            this.label5.Text = "Fecha:";
            // 
            // ID_numericUpDown
            // 
            this.ID_numericUpDown.Location = new System.Drawing.Point(112, 24);
            this.ID_numericUpDown.Name = "ID_numericUpDown";
            this.ID_numericUpDown.Size = new System.Drawing.Size(124, 31);
            this.ID_numericUpDown.TabIndex = 7;
            // 
            // Fecha_dateTimePicker
            // 
            this.Fecha_dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Fecha_dateTimePicker.Location = new System.Drawing.Point(112, 68);
            this.Fecha_dateTimePicker.Name = "Fecha_dateTimePicker";
            this.Fecha_dateTimePicker.Size = new System.Drawing.Size(354, 31);
            this.Fecha_dateTimePicker.TabIndex = 9;
            // 
            // Nombre_textBox
            // 
            this.Nombre_textBox.Location = new System.Drawing.Point(112, 124);
            this.Nombre_textBox.Name = "Nombre_textBox";
            this.Nombre_textBox.Size = new System.Drawing.Size(354, 31);
            this.Nombre_textBox.TabIndex = 10;
            // 
            // Monto_textBox
            // 
            this.Monto_textBox.Location = new System.Drawing.Point(112, 177);
            this.Monto_textBox.Name = "Monto_textBox";
            this.Monto_textBox.Size = new System.Drawing.Size(354, 31);
            this.Monto_textBox.TabIndex = 11;
            // 
            // Buscar_button
            // 
            this.Buscar_button.Image = global::administracion_de_edificio.Properties.Resources.lupa;
            this.Buscar_button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Buscar_button.Location = new System.Drawing.Point(255, 21);
            this.Buscar_button.Name = "Buscar_button";
            this.Buscar_button.Size = new System.Drawing.Size(112, 34);
            this.Buscar_button.TabIndex = 12;
            this.Buscar_button.Text = "Buscar";
            this.Buscar_button.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Buscar_button.UseVisualStyleBackColor = true;
            this.Buscar_button.Click += new System.EventHandler(this.Buscar_button_Click);
            // 
            // Eliminar_button
            // 
            this.Eliminar_button.Image = global::administracion_de_edificio.Properties.Resources.eliminar;
            this.Eliminar_button.Location = new System.Drawing.Point(200, 239);
            this.Eliminar_button.Name = "Eliminar_button";
            this.Eliminar_button.Size = new System.Drawing.Size(137, 49);
            this.Eliminar_button.TabIndex = 13;
            this.Eliminar_button.Text = "Eliminar";
            this.Eliminar_button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Eliminar_button.UseVisualStyleBackColor = true;
            this.Eliminar_button.Click += new System.EventHandler(this.Eliminar_button_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.imprimir);
            // 
            // rfacturas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 324);
            this.Controls.Add(this.Eliminar_button);
            this.Controls.Add(this.Buscar_button);
            this.Controls.Add(this.Monto_textBox);
            this.Controls.Add(this.Nombre_textBox);
            this.Controls.Add(this.Fecha_dateTimePicker);
            this.Controls.Add(this.ID_numericUpDown);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Nuevo_button);
            this.Controls.Add(this.Imprimir_button);
            this.Name = "rfacturas";
            this.Text = "rfacturas";
            ((System.ComponentModel.ISupportInitialize)(this.ID_numericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Imprimir_button;
        private System.Windows.Forms.Button Nuevo_button;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown ID_numericUpDown;
        private System.Windows.Forms.DateTimePicker Fecha_dateTimePicker;
        private System.Windows.Forms.TextBox Nombre_textBox;
        private System.Windows.Forms.TextBox Monto_textBox;
        private System.Windows.Forms.Button Buscar_button;
        private System.Windows.Forms.Button Eliminar_button;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}