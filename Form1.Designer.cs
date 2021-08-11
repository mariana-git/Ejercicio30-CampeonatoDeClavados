
namespace Ejercicio30_CampeonatoDeClavados
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtPunt1 = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtPunt2 = new System.Windows.Forms.TextBox();
            this.txtPunt3 = new System.Windows.Forms.TextBox();
            this.txtPunt4 = new System.Windows.Forms.TextBox();
            this.txtPunt5 = new System.Windows.Forms.TextBox();
            this.lblParticipante = new System.Windows.Forms.Label();
            this.gbDatos = new System.Windows.Forms.GroupBox();
            this.lstvwPosiciones = new System.Windows.Forms.ListView();
            this.label4 = new System.Windows.Forms.Label();
            this.gbDatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Kristen ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(27, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(310, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "CAMPEONATO DE CLAVADOS ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(46, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cantidad de Clavadistas:";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(200, 97);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(37, 23);
            this.txtCantidad.TabIndex = 1;
            this.txtCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCantidad_KeyPress);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(247, 96);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 2;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(213, 122);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 10;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(27, 488);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 11;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(270, 488);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 12;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "Nombre :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 71);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 15);
            this.label8.TabIndex = 13;
            this.label8.Text = "Puntuaciones :";
            // 
            // txtPunt1
            // 
            this.txtPunt1.Location = new System.Drawing.Point(104, 68);
            this.txtPunt1.Name = "txtPunt1";
            this.txtPunt1.Size = new System.Drawing.Size(29, 23);
            this.txtPunt1.TabIndex = 5;
            this.txtPunt1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPunt1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPunt1_KeyPress);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(104, 39);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(169, 23);
            this.txtNombre.TabIndex = 4;
            this.txtNombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
            // 
            // txtPunt2
            // 
            this.txtPunt2.Location = new System.Drawing.Point(139, 68);
            this.txtPunt2.Name = "txtPunt2";
            this.txtPunt2.Size = new System.Drawing.Size(29, 23);
            this.txtPunt2.TabIndex = 6;
            this.txtPunt2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPunt2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPunt2_KeyPress);
            // 
            // txtPunt3
            // 
            this.txtPunt3.Location = new System.Drawing.Point(174, 68);
            this.txtPunt3.Name = "txtPunt3";
            this.txtPunt3.Size = new System.Drawing.Size(29, 23);
            this.txtPunt3.TabIndex = 7;
            this.txtPunt3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPunt3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPunt3_KeyPress);
            // 
            // txtPunt4
            // 
            this.txtPunt4.Location = new System.Drawing.Point(209, 68);
            this.txtPunt4.Name = "txtPunt4";
            this.txtPunt4.Size = new System.Drawing.Size(29, 23);
            this.txtPunt4.TabIndex = 8;
            this.txtPunt4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPunt4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPunt4_KeyPress);
            // 
            // txtPunt5
            // 
            this.txtPunt5.Location = new System.Drawing.Point(244, 68);
            this.txtPunt5.Name = "txtPunt5";
            this.txtPunt5.Size = new System.Drawing.Size(29, 23);
            this.txtPunt5.TabIndex = 9;
            this.txtPunt5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPunt5.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPunt5_KeyPress);
            // 
            // lblParticipante
            // 
            this.lblParticipante.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblParticipante.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblParticipante.Location = new System.Drawing.Point(104, 19);
            this.lblParticipante.Name = "lblParticipante";
            this.lblParticipante.Size = new System.Drawing.Size(169, 17);
            this.lblParticipante.TabIndex = 20;
            this.lblParticipante.Text = "Participante";
            this.lblParticipante.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gbDatos
            // 
            this.gbDatos.Controls.Add(this.lstvwPosiciones);
            this.gbDatos.Controls.Add(this.label4);
            this.gbDatos.Controls.Add(this.lblParticipante);
            this.gbDatos.Controls.Add(this.label3);
            this.gbDatos.Controls.Add(this.txtPunt5);
            this.gbDatos.Controls.Add(this.btnAgregar);
            this.gbDatos.Controls.Add(this.label8);
            this.gbDatos.Controls.Add(this.txtPunt4);
            this.gbDatos.Controls.Add(this.txtPunt1);
            this.gbDatos.Controls.Add(this.txtPunt3);
            this.gbDatos.Controls.Add(this.txtNombre);
            this.gbDatos.Controls.Add(this.txtPunt2);
            this.gbDatos.Location = new System.Drawing.Point(27, 146);
            this.gbDatos.Name = "gbDatos";
            this.gbDatos.Size = new System.Drawing.Size(318, 336);
            this.gbDatos.TabIndex = 3;
            this.gbDatos.TabStop = false;
            // 
            // lstvwPosiciones
            // 
            this.lstvwPosiciones.HideSelection = false;
            this.lstvwPosiciones.Location = new System.Drawing.Point(6, 188);
            this.lstvwPosiciones.Name = "lstvwPosiciones";
            this.lstvwPosiciones.Size = new System.Drawing.Size(304, 128);
            this.lstvwPosiciones.TabIndex = 21;
            this.lstvwPosiciones.UseCompatibleStateImageBehavior = false;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label4.Location = new System.Drawing.Point(12, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(298, 25);
            this.label4.TabIndex = 13;
            this.label4.Text = "TABLA DE POSICIONES";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(376, 543);
            this.Controls.Add(this.gbDatos);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Tabla de Posiciones";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbDatos.ResumeLayout(false);
            this.gbDatos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtPunt1;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtPunt2;
        private System.Windows.Forms.TextBox txtPunt3;
        private System.Windows.Forms.TextBox txtPunt4;
        private System.Windows.Forms.TextBox txtPunt5;
        private System.Windows.Forms.Label lblParticipante;
        private System.Windows.Forms.GroupBox gbDatos;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListView lstvwPosiciones;
    }
}

