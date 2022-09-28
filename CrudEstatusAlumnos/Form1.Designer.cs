using System;

namespace CrudEstatusAlumnos
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.lbNombre = new System.Windows.Forms.Label();
            this.lbClave = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtClave = new System.Windows.Forms.TextBox();
            this.btnGuardarAgregar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.dgvEstatus = new System.Windows.Forms.DataGridView();
            this.btnGuardarActualizar = new System.Windows.Forms.Button();
            this.btnSaveEliminar = new System.Windows.Forms.Button();
            this.cbxClave = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstatus)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAgregar.Location = new System.Drawing.Point(474, 44);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 24);
            this.btnAgregar.TabIndex = 1;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnActualizar.Location = new System.Drawing.Point(555, 44);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(75, 24);
            this.btnActualizar.TabIndex = 2;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = false;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnEliminar.Location = new System.Drawing.Point(639, 44);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 24);
            this.btnEliminar.TabIndex = 3;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // lbNombre
            // 
            this.lbNombre.AutoSize = true;
            this.lbNombre.Location = new System.Drawing.Point(120, 341);
            this.lbNombre.Name = "lbNombre";
            this.lbNombre.Size = new System.Drawing.Size(56, 16);
            this.lbNombre.TabIndex = 5;
            this.lbNombre.Text = "Nombre";
            // 
            // lbClave
            // 
            this.lbClave.AutoSize = true;
            this.lbClave.Location = new System.Drawing.Point(120, 374);
            this.lbClave.Name = "lbClave";
            this.lbClave.Size = new System.Drawing.Size(42, 16);
            this.lbClave.TabIndex = 6;
            this.lbClave.Text = "Clave";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(182, 341);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(180, 22);
            this.txtNombre.TabIndex = 7;
            // 
            // txtClave
            // 
            this.txtClave.Location = new System.Drawing.Point(182, 374);
            this.txtClave.Name = "txtClave";
            this.txtClave.Size = new System.Drawing.Size(180, 22);
            this.txtClave.TabIndex = 8;
            // 
            // btnGuardarAgregar
            // 
            this.btnGuardarAgregar.Location = new System.Drawing.Point(393, 355);
            this.btnGuardarAgregar.Name = "btnGuardarAgregar";
            this.btnGuardarAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardarAgregar.TabIndex = 10;
            this.btnGuardarAgregar.Text = "Guardar";
            this.btnGuardarAgregar.UseVisualStyleBackColor = true;
            this.btnGuardarAgregar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(639, 355);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 11;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // dgvEstatus
            // 
            this.dgvEstatus.AllowUserToOrderColumns = true;
            this.dgvEstatus.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEstatus.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvEstatus.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvEstatus.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvEstatus.Location = new System.Drawing.Point(122, 75);
            this.dgvEstatus.Name = "dgvEstatus";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEstatus.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvEstatus.RowHeadersWidth = 51;
            this.dgvEstatus.RowTemplate.Height = 24;
            this.dgvEstatus.Size = new System.Drawing.Size(593, 244);
            this.dgvEstatus.TabIndex = 12;
            // 
            // btnGuardarActualizar
            // 
            this.btnGuardarActualizar.Location = new System.Drawing.Point(474, 355);
            this.btnGuardarActualizar.Name = "btnGuardarActualizar";
            this.btnGuardarActualizar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardarActualizar.TabIndex = 13;
            this.btnGuardarActualizar.Text = "Guardar";
            this.btnGuardarActualizar.UseVisualStyleBackColor = true;
            this.btnGuardarActualizar.Click += new System.EventHandler(this.btnGuardarActualizar_Click);
            // 
            // btnSaveEliminar
            // 
            this.btnSaveEliminar.BackColor = System.Drawing.Color.Red;
            this.btnSaveEliminar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSaveEliminar.Location = new System.Drawing.Point(555, 355);
            this.btnSaveEliminar.Name = "btnSaveEliminar";
            this.btnSaveEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnSaveEliminar.TabIndex = 14;
            this.btnSaveEliminar.Text = "Eliminar";
            this.btnSaveEliminar.UseVisualStyleBackColor = false;
            this.btnSaveEliminar.Click += new System.EventHandler(this.btnSaveEliminar_Click);
            // 
            // cbxClave
            // 
            this.cbxClave.FormattingEnabled = true;
            this.cbxClave.Location = new System.Drawing.Point(122, 44);
            this.cbxClave.Name = "cbxClave";
            this.cbxClave.Size = new System.Drawing.Size(121, 24);
            this.cbxClave.TabIndex = 15;
            this.cbxClave.Text = "Clave";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 459);
            this.Controls.Add(this.cbxClave);
            this.Controls.Add(this.btnSaveEliminar);
            this.Controls.Add(this.btnGuardarActualizar);
            this.Controls.Add(this.dgvEstatus);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardarAgregar);
            this.Controls.Add(this.txtClave);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lbClave);
            this.Controls.Add(this.lbNombre);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnAgregar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstatus)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label lbNombre;
        private System.Windows.Forms.Label lbClave;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtClave;
        private System.Windows.Forms.Button btnGuardarAgregar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.DataGridView dgvEstatus;
        private System.Windows.Forms.Button btnGuardarActualizar;
        private System.Windows.Forms.Button btnSaveEliminar;
        private System.Windows.Forms.ComboBox cbxClave;
    }
}

