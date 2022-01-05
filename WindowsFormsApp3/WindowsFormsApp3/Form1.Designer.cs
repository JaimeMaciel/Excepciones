
namespace WindowsFormsApp3
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
            this.btnCrear = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTamaño = new System.Windows.Forms.TextBox();
            this.chkQuesoExtra = new System.Windows.Forms.CheckBox();
            this.chkMasaDelgada = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lstIngredientes = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtIngrediente = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnCrear
            // 
            this.btnCrear.Location = new System.Drawing.Point(24, 144);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(75, 23);
            this.btnCrear.TabIndex = 0;
            this.btnCrear.Text = "Crear";
            this.btnCrear.UseVisualStyleBackColor = true;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tamaño";
            // 
            // txtTamaño
            // 
            this.txtTamaño.Location = new System.Drawing.Point(12, 33);
            this.txtTamaño.Name = "txtTamaño";
            this.txtTamaño.Size = new System.Drawing.Size(100, 22);
            this.txtTamaño.TabIndex = 2;
            // 
            // chkQuesoExtra
            // 
            this.chkQuesoExtra.AutoSize = true;
            this.chkQuesoExtra.Location = new System.Drawing.Point(12, 61);
            this.chkQuesoExtra.Name = "chkQuesoExtra";
            this.chkQuesoExtra.Size = new System.Drawing.Size(116, 21);
            this.chkQuesoExtra.TabIndex = 3;
            this.chkQuesoExtra.Text = "Queso Extra?";
            this.chkQuesoExtra.UseVisualStyleBackColor = true;
            // 
            // chkMasaDelgada
            // 
            this.chkMasaDelgada.AutoSize = true;
            this.chkMasaDelgada.Location = new System.Drawing.Point(12, 105);
            this.chkMasaDelgada.Name = "chkMasaDelgada";
            this.chkMasaDelgada.Size = new System.Drawing.Size(127, 21);
            this.chkMasaDelgada.TabIndex = 4;
            this.chkMasaDelgada.Text = "Masa delgada?";
            this.chkMasaDelgada.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(220, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Ingredientes";
            // 
            // lstIngredientes
            // 
            this.lstIngredientes.FormattingEnabled = true;
            this.lstIngredientes.ItemHeight = 16;
            this.lstIngredientes.Location = new System.Drawing.Point(223, 33);
            this.lstIngredientes.Name = "lstIngredientes";
            this.lstIngredientes.Size = new System.Drawing.Size(120, 84);
            this.lstIngredientes.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(374, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Ingredientes";
            // 
            // txtIngrediente
            // 
            this.txtIngrediente.Location = new System.Drawing.Point(360, 52);
            this.txtIngrediente.Name = "txtIngrediente";
            this.txtIngrediente.Size = new System.Drawing.Size(100, 22);
            this.txtIngrediente.TabIndex = 8;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(377, 80);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 9;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(240, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Precio";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(243, 160);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.ReadOnly = true;
            this.txtPrecio.Size = new System.Drawing.Size(100, 22);
            this.txtPrecio.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtIngrediente);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lstIngredientes);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.chkMasaDelgada);
            this.Controls.Add(this.chkQuesoExtra);
            this.Controls.Add(this.txtTamaño);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCrear);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTamaño;
        private System.Windows.Forms.CheckBox chkQuesoExtra;
        private System.Windows.Forms.CheckBox chkMasaDelgada;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lstIngredientes;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtIngrediente;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPrecio;
    }
}

