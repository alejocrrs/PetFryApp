namespace App
{
    partial class FrmMascota
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
            this.tlpPrincipal = new System.Windows.Forms.TableLayoutPanel();
            this.txtNotas = new System.Windows.Forms.TextBox();
            this.lblNotas = new System.Windows.Forms.Label();
            this.txtColor = new System.Windows.Forms.TextBox();
            this.lblColor = new System.Windows.Forms.Label();
            this.lblPeso = new System.Windows.Forms.Label();
            this.txtRaza = new System.Windows.Forms.TextBox();
            this.lblRaza = new System.Windows.Forms.Label();
            this.lblAnimal = new System.Windows.Forms.Label();
            this.lblPropietario = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.flpOpciones = new System.Windows.Forms.FlowLayoutPanel();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.tlpPropietario = new System.Windows.Forms.TableLayoutPanel();
            this.txtPropietario = new System.Windows.Forms.TextBox();
            this.btnPropietario = new System.Windows.Forms.Button();
            this.cboAnimal = new System.Windows.Forms.ComboBox();
            this.numPeso = new System.Windows.Forms.NumericUpDown();
            this.tlpPrincipal.SuspendLayout();
            this.flpOpciones.SuspendLayout();
            this.tlpPropietario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPeso)).BeginInit();
            this.SuspendLayout();
            // 
            // tlpPrincipal
            // 
            this.tlpPrincipal.ColumnCount = 2;
            this.tlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpPrincipal.Controls.Add(this.txtNotas, 1, 6);
            this.tlpPrincipal.Controls.Add(this.lblNotas, 0, 6);
            this.tlpPrincipal.Controls.Add(this.txtColor, 1, 5);
            this.tlpPrincipal.Controls.Add(this.lblColor, 0, 5);
            this.tlpPrincipal.Controls.Add(this.lblPeso, 0, 4);
            this.tlpPrincipal.Controls.Add(this.txtRaza, 1, 3);
            this.tlpPrincipal.Controls.Add(this.lblRaza, 0, 3);
            this.tlpPrincipal.Controls.Add(this.lblAnimal, 0, 2);
            this.tlpPrincipal.Controls.Add(this.lblPropietario, 0, 1);
            this.tlpPrincipal.Controls.Add(this.lblNombre, 0, 0);
            this.tlpPrincipal.Controls.Add(this.txtNombre, 1, 0);
            this.tlpPrincipal.Controls.Add(this.flpOpciones, 1, 7);
            this.tlpPrincipal.Controls.Add(this.tlpPropietario, 1, 1);
            this.tlpPrincipal.Controls.Add(this.cboAnimal, 1, 2);
            this.tlpPrincipal.Controls.Add(this.numPeso, 1, 4);
            this.tlpPrincipal.Location = new System.Drawing.Point(12, 12);
            this.tlpPrincipal.Name = "tlpPrincipal";
            this.tlpPrincipal.RowCount = 8;
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpPrincipal.Size = new System.Drawing.Size(310, 287);
            this.tlpPrincipal.TabIndex = 1;
            // 
            // txtNotas
            // 
            this.txtNotas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtNotas.Location = new System.Drawing.Point(123, 188);
            this.txtNotas.MaxLength = 25;
            this.txtNotas.Multiline = true;
            this.txtNotas.Name = "txtNotas";
            this.txtNotas.Size = new System.Drawing.Size(184, 64);
            this.txtNotas.TabIndex = 7;
            // 
            // lblNotas
            // 
            this.lblNotas.AutoSize = true;
            this.lblNotas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblNotas.Location = new System.Drawing.Point(3, 185);
            this.lblNotas.Name = "lblNotas";
            this.lblNotas.Size = new System.Drawing.Size(114, 70);
            this.lblNotas.TabIndex = 15;
            this.lblNotas.Text = "Notas";
            this.lblNotas.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtColor
            // 
            this.txtColor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtColor.Location = new System.Drawing.Point(123, 158);
            this.txtColor.MaxLength = 25;
            this.txtColor.Name = "txtColor";
            this.txtColor.Size = new System.Drawing.Size(184, 20);
            this.txtColor.TabIndex = 6;
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = true;
            this.lblColor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblColor.Location = new System.Drawing.Point(3, 155);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(114, 30);
            this.lblColor.TabIndex = 13;
            this.lblColor.Text = "Color";
            this.lblColor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblPeso
            // 
            this.lblPeso.AutoSize = true;
            this.lblPeso.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPeso.Location = new System.Drawing.Point(3, 125);
            this.lblPeso.Name = "lblPeso";
            this.lblPeso.Size = new System.Drawing.Size(114, 30);
            this.lblPeso.TabIndex = 8;
            this.lblPeso.Text = "Peso";
            this.lblPeso.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtRaza
            // 
            this.txtRaza.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtRaza.Location = new System.Drawing.Point(123, 98);
            this.txtRaza.MaxLength = 25;
            this.txtRaza.Name = "txtRaza";
            this.txtRaza.Size = new System.Drawing.Size(184, 20);
            this.txtRaza.TabIndex = 4;
            // 
            // lblRaza
            // 
            this.lblRaza.AutoSize = true;
            this.lblRaza.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblRaza.Location = new System.Drawing.Point(3, 95);
            this.lblRaza.Name = "lblRaza";
            this.lblRaza.Size = new System.Drawing.Size(114, 30);
            this.lblRaza.TabIndex = 6;
            this.lblRaza.Text = "Raza";
            this.lblRaza.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblAnimal
            // 
            this.lblAnimal.AutoSize = true;
            this.lblAnimal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblAnimal.Location = new System.Drawing.Point(3, 65);
            this.lblAnimal.Name = "lblAnimal";
            this.lblAnimal.Size = new System.Drawing.Size(114, 30);
            this.lblAnimal.TabIndex = 4;
            this.lblAnimal.Text = "Animal";
            this.lblAnimal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblPropietario
            // 
            this.lblPropietario.AutoSize = true;
            this.lblPropietario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPropietario.Location = new System.Drawing.Point(3, 30);
            this.lblPropietario.Name = "lblPropietario";
            this.lblPropietario.Size = new System.Drawing.Size(114, 35);
            this.lblPropietario.TabIndex = 2;
            this.lblPropietario.Text = "Propietario";
            this.lblPropietario.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblNombre.Location = new System.Drawing.Point(3, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(114, 30);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre";
            this.lblNombre.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtNombre
            // 
            this.txtNombre.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtNombre.Location = new System.Drawing.Point(123, 3);
            this.txtNombre.MaxLength = 15;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(184, 20);
            this.txtNombre.TabIndex = 1;
            // 
            // flpOpciones
            // 
            this.flpOpciones.Controls.Add(this.btnAgregar);
            this.flpOpciones.Controls.Add(this.btnCancelar);
            this.flpOpciones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpOpciones.Location = new System.Drawing.Point(123, 258);
            this.flpOpciones.Name = "flpOpciones";
            this.flpOpciones.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.flpOpciones.Size = new System.Drawing.Size(184, 26);
            this.flpOpciones.TabIndex = 9;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(106, 3);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 9;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Location = new System.Drawing.Point(25, 3);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 8;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // tlpPropietario
            // 
            this.tlpPropietario.ColumnCount = 2;
            this.tlpPropietario.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpPropietario.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpPropietario.Controls.Add(this.txtPropietario, 0, 0);
            this.tlpPropietario.Controls.Add(this.btnPropietario, 1, 0);
            this.tlpPropietario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpPropietario.Location = new System.Drawing.Point(123, 33);
            this.tlpPropietario.Name = "tlpPropietario";
            this.tlpPropietario.RowCount = 1;
            this.tlpPropietario.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpPropietario.Size = new System.Drawing.Size(184, 29);
            this.tlpPropietario.TabIndex = 10;
            // 
            // txtPropietario
            // 
            this.txtPropietario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtPropietario.Location = new System.Drawing.Point(3, 3);
            this.txtPropietario.MaxLength = 11;
            this.txtPropietario.Name = "txtPropietario";
            this.txtPropietario.ReadOnly = true;
            this.txtPropietario.Size = new System.Drawing.Size(86, 20);
            this.txtPropietario.TabIndex = 0;
            // 
            // btnPropietario
            // 
            this.btnPropietario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPropietario.Location = new System.Drawing.Point(95, 3);
            this.btnPropietario.Name = "btnPropietario";
            this.btnPropietario.Size = new System.Drawing.Size(86, 23);
            this.btnPropietario.TabIndex = 2;
            this.btnPropietario.Text = "Seleccionar";
            this.btnPropietario.UseVisualStyleBackColor = true;
            this.btnPropietario.Click += new System.EventHandler(this.btnPropietario_Click);
            // 
            // cboAnimal
            // 
            this.cboAnimal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cboAnimal.FormattingEnabled = true;
            this.cboAnimal.Items.AddRange(new object[] {
            "Perro",
            "Gato"});
            this.cboAnimal.Location = new System.Drawing.Point(123, 68);
            this.cboAnimal.Name = "cboAnimal";
            this.cboAnimal.Size = new System.Drawing.Size(184, 21);
            this.cboAnimal.TabIndex = 3;
            // 
            // numPeso
            // 
            this.numPeso.DecimalPlaces = 2;
            this.numPeso.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numPeso.Location = new System.Drawing.Point(123, 128);
            this.numPeso.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numPeso.Name = "numPeso";
            this.numPeso.Size = new System.Drawing.Size(184, 20);
            this.numPeso.TabIndex = 5;
            this.numPeso.ThousandsSeparator = true;
            // 
            // FrmMascota
            // 
            this.AcceptButton = this.btnAgregar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancelar;
            this.ClientSize = new System.Drawing.Size(334, 311);
            this.Controls.Add(this.tlpPrincipal);
            this.MaximizeBox = false;
            this.Name = "FrmMascota";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Agregar mascota";
            this.tlpPrincipal.ResumeLayout(false);
            this.tlpPrincipal.PerformLayout();
            this.flpOpciones.ResumeLayout(false);
            this.tlpPropietario.ResumeLayout(false);
            this.tlpPropietario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPeso)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpPrincipal;
        private System.Windows.Forms.Label lblPeso;
        private System.Windows.Forms.TextBox txtRaza;
        private System.Windows.Forms.Label lblRaza;
        private System.Windows.Forms.Label lblAnimal;
        private System.Windows.Forms.Label lblPropietario;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.FlowLayoutPanel flpOpciones;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.TableLayoutPanel tlpPropietario;
        private System.Windows.Forms.Button btnPropietario;
        private System.Windows.Forms.TextBox txtPropietario;
        private System.Windows.Forms.ComboBox cboAnimal;
        private System.Windows.Forms.NumericUpDown numPeso;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.TextBox txtColor;
        private System.Windows.Forms.Label lblNotas;
        private System.Windows.Forms.TextBox txtNotas;
    }
}