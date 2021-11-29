
namespace administracion_de_edificio.UI.Registros
{
    partial class rUsuario
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ID_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.Nombre_textBox = new System.Windows.Forms.TextBox();
            this.Fecha_dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Telefono_maskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.Clave_textBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Guardar_button = new System.Windows.Forms.Button();
            this.Eliminar_button = new System.Windows.Forms.Button();
            this.Nuevo_button = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.correo_textBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.Cedula_maskedTextBox = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.ID_numericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "ID:";
            // 
            // ID_numericUpDown
            // 
            this.ID_numericUpDown.Location = new System.Drawing.Point(52, 38);
            this.ID_numericUpDown.Name = "ID_numericUpDown";
            this.ID_numericUpDown.Size = new System.Drawing.Size(87, 31);
            this.ID_numericUpDown.TabIndex = 2;
            // 
            // Nombre_textBox
            // 
            this.Nombre_textBox.Location = new System.Drawing.Point(101, 95);
            this.Nombre_textBox.Name = "Nombre_textBox";
            this.Nombre_textBox.Size = new System.Drawing.Size(362, 31);
            this.Nombre_textBox.TabIndex = 3;
            // 
            // Fecha_dateTimePicker
            // 
            this.Fecha_dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Fecha_dateTimePicker.Location = new System.Drawing.Point(312, 38);
            this.Fecha_dateTimePicker.Name = "Fecha_dateTimePicker";
            this.Fecha_dateTimePicker.Size = new System.Drawing.Size(123, 31);
            this.Fecha_dateTimePicker.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(245, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Fecha:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 189);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "Telefono:";
            // 
            // Telefono_maskedTextBox
            // 
            this.Telefono_maskedTextBox.Location = new System.Drawing.Point(101, 186);
            this.Telefono_maskedTextBox.Mask = "000-000-0000";
            this.Telefono_maskedTextBox.Name = "Telefono_maskedTextBox";
            this.Telefono_maskedTextBox.Size = new System.Drawing.Size(362, 31);
            this.Telefono_maskedTextBox.TabIndex = 7;
            // 
            // Clave_textBox
            // 
            this.Clave_textBox.Location = new System.Drawing.Point(101, 278);
            this.Clave_textBox.Name = "Clave_textBox";
            this.Clave_textBox.PasswordChar = '*';
            this.Clave_textBox.Size = new System.Drawing.Size(362, 31);
            this.Clave_textBox.TabIndex = 8;
            this.Clave_textBox.UseSystemPasswordChar = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 281);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 25);
            this.label5.TabIndex = 9;
            this.label5.Text = "Clave:";
            // 
            // Guardar_button
            // 
            this.Guardar_button.Image = global::administracion_de_edificio.Properties.Resources.guardar_el_archivo;
            this.Guardar_button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Guardar_button.Location = new System.Drawing.Point(74, 349);
            this.Guardar_button.Name = "Guardar_button";
            this.Guardar_button.Size = new System.Drawing.Size(112, 47);
            this.Guardar_button.TabIndex = 10;
            this.Guardar_button.Text = "Guardar";
            this.Guardar_button.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Guardar_button.UseVisualStyleBackColor = true;
            this.Guardar_button.Click += new System.EventHandler(this.Guardar_button_Click);
            // 
            // Eliminar_button
            // 
            this.Eliminar_button.Image = global::administracion_de_edificio.Properties.Resources.eliminar;
            this.Eliminar_button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Eliminar_button.Location = new System.Drawing.Point(204, 349);
            this.Eliminar_button.Name = "Eliminar_button";
            this.Eliminar_button.Size = new System.Drawing.Size(112, 47);
            this.Eliminar_button.TabIndex = 11;
            this.Eliminar_button.Text = "Eliminar";
            this.Eliminar_button.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Eliminar_button.UseVisualStyleBackColor = true;
            this.Eliminar_button.Click += new System.EventHandler(this.Eliminar_button_Click);
            // 
            // Nuevo_button
            // 
            this.Nuevo_button.Image = global::administracion_de_edificio.Properties.Resources.nueva_pagina;
            this.Nuevo_button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Nuevo_button.Location = new System.Drawing.Point(338, 349);
            this.Nuevo_button.Name = "Nuevo_button";
            this.Nuevo_button.Size = new System.Drawing.Size(112, 47);
            this.Nuevo_button.TabIndex = 12;
            this.Nuevo_button.Text = "Nuevo";
            this.Nuevo_button.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Nuevo_button.UseVisualStyleBackColor = true;
            this.Nuevo_button.Click += new System.EventHandler(this.Nuevo_button_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 236);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 25);
            this.label6.TabIndex = 14;
            this.label6.Text = "Correo:";
            // 
            // correo_textBox
            // 
            this.correo_textBox.Location = new System.Drawing.Point(101, 233);
            this.correo_textBox.Name = "correo_textBox";
            this.correo_textBox.Size = new System.Drawing.Size(362, 31);
            this.correo_textBox.TabIndex = 13;
            // 
            // button1
            // 
            this.button1.Image = global::administracion_de_edificio.Properties.Resources.lupa;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(145, 35);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 34);
            this.button1.TabIndex = 15;
            this.button1.Text = "buscar";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 146);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 25);
            this.label7.TabIndex = 16;
            this.label7.Text = "Cedula:";
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // Cedula_maskedTextBox
            // 
            this.Cedula_maskedTextBox.Location = new System.Drawing.Point(101, 140);
            this.Cedula_maskedTextBox.Mask = "000-0000000-0";
            this.Cedula_maskedTextBox.Name = "Cedula_maskedTextBox";
            this.Cedula_maskedTextBox.Size = new System.Drawing.Size(362, 31);
            this.Cedula_maskedTextBox.TabIndex = 17;
            // 
            // rUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 432);
            this.Controls.Add(this.Cedula_maskedTextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.correo_textBox);
            this.Controls.Add(this.Nuevo_button);
            this.Controls.Add(this.Eliminar_button);
            this.Controls.Add(this.Guardar_button);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Clave_textBox);
            this.Controls.Add(this.Telefono_maskedTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Fecha_dateTimePicker);
            this.Controls.Add(this.Nombre_textBox);
            this.Controls.Add(this.ID_numericUpDown);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "rUsuario";
            this.Text = "rUsuario";
            ((System.ComponentModel.ISupportInitialize)(this.ID_numericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown ID_numericUpDown;
        private System.Windows.Forms.TextBox Nombre_textBox;
        private System.Windows.Forms.DateTimePicker Fecha_dateTimePicker;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox Telefono_maskedTextBox;
        private System.Windows.Forms.TextBox Clave_textBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Guardar_button;
        private System.Windows.Forms.Button Eliminar_button;
        private System.Windows.Forms.Button Nuevo_button;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox correo_textBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.MaskedTextBox Cedula_maskedTextBox;
    }
}