﻿
namespace administracion_de_edificio.UI.Consultas
{
    partial class cUsuarios
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
            this.Buscar_textBox = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Nuevo_button = new System.Windows.Forms.Button();
            this.Seleccionar_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Buscar_button
            // 
            this.Buscar_button.Image = global::administracion_de_edificio.Properties.Resources.lupa;
            this.Buscar_button.Location = new System.Drawing.Point(320, 12);
            this.Buscar_button.Name = "Buscar_button";
            this.Buscar_button.Size = new System.Drawing.Size(112, 34);
            this.Buscar_button.TabIndex = 0;
            this.Buscar_button.Text = "Buscar";
            this.Buscar_button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Buscar_button.UseVisualStyleBackColor = true;
            this.Buscar_button.Click += new System.EventHandler(this.Buscar_button_Click);
            // 
            // Buscar_textBox
            // 
            this.Buscar_textBox.Location = new System.Drawing.Point(12, 12);
            this.Buscar_textBox.Name = "Buscar_textBox";
            this.Buscar_textBox.Size = new System.Drawing.Size(286, 31);
            this.Buscar_textBox.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 64);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(966, 616);
            this.dataGridView1.TabIndex = 2;
            // 
            // Nuevo_button
            // 
            this.Nuevo_button.Image = global::administracion_de_edificio.Properties.Resources.nueva_pagina;
            this.Nuevo_button.Location = new System.Drawing.Point(475, 12);
            this.Nuevo_button.Name = "Nuevo_button";
            this.Nuevo_button.Size = new System.Drawing.Size(112, 34);
            this.Nuevo_button.TabIndex = 3;
            this.Nuevo_button.Text = "Nuevo";
            this.Nuevo_button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Nuevo_button.UseVisualStyleBackColor = true;
            this.Nuevo_button.Click += new System.EventHandler(this.Nuevo_button_Click);
            // 
            // Seleccionar_button
            // 
            this.Seleccionar_button.Image = global::administracion_de_edificio.Properties.Resources.seleccione;
            this.Seleccionar_button.Location = new System.Drawing.Point(627, 12);
            this.Seleccionar_button.Name = "Seleccionar_button";
            this.Seleccionar_button.Size = new System.Drawing.Size(126, 34);
            this.Seleccionar_button.TabIndex = 4;
            this.Seleccionar_button.Text = "Seleccionar";
            this.Seleccionar_button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Seleccionar_button.UseVisualStyleBackColor = true;
            this.Seleccionar_button.Click += new System.EventHandler(this.Seleccionar_button_Click);
            // 
            // cUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(990, 692);
            this.Controls.Add(this.Seleccionar_button);
            this.Controls.Add(this.Nuevo_button);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Buscar_textBox);
            this.Controls.Add(this.Buscar_button);
            this.Name = "cUsuarios";
            this.Text = "cUsuarios";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Buscar_button;
        private System.Windows.Forms.TextBox Buscar_textBox;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Nuevo_button;
        private System.Windows.Forms.Button Seleccionar_button;
    }
}