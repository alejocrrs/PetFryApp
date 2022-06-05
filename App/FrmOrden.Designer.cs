namespace App
{
    partial class FrmOrden
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
            this.lblValor = new System.Windows.Forms.Label();
            this.lblCliente = new System.Windows.Forms.Label();
            this.flpOpciones = new System.Windows.Forms.FlowLayoutPanel();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.tlpCliente = new System.Windows.Forms.TableLayoutPanel();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.btnCliente = new System.Windows.Forms.Button();
            this.numValor = new System.Windows.Forms.NumericUpDown();
            this.lblArticulo = new System.Windows.Forms.Label();
            this.lblMascota = new System.Windows.Forms.Label();
            this.tlpMascota = new System.Windows.Forms.TableLayoutPanel();
            this.txtMascota = new System.Windows.Forms.TextBox();
            this.btnMascota = new System.Windows.Forms.Button();
            this.tlpArticulos = new System.Windows.Forms.TableLayoutPanel();
            this.txtArticulo = new System.Windows.Forms.TextBox();
            this.btnArticulo = new System.Windows.Forms.Button();
            this.cboTipo = new System.Windows.Forms.ComboBox();
            this.lblTipo = new System.Windows.Forms.Label();
            this.tlpPrincipal.SuspendLayout();
            this.flpOpciones.SuspendLayout();
            this.tlpCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numValor)).BeginInit();
            this.tlpMascota.SuspendLayout();
            this.tlpArticulos.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpPrincipal
            // 
            this.tlpPrincipal.ColumnCount = 2;
            this.tlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpPrincipal.Controls.Add(this.txtNotas, 1, 5);
            this.tlpPrincipal.Controls.Add(this.lblNotas, 0, 5);
            this.tlpPrincipal.Controls.Add(this.lblValor, 0, 4);
            this.tlpPrincipal.Controls.Add(this.lblCliente, 0, 0);
            this.tlpPrincipal.Controls.Add(this.flpOpciones, 1, 6);
            this.tlpPrincipal.Controls.Add(this.tlpCliente, 1, 0);
            this.tlpPrincipal.Controls.Add(this.numValor, 1, 4);
            this.tlpPrincipal.Controls.Add(this.lblArticulo, 0, 3);
            this.tlpPrincipal.Controls.Add(this.lblMascota, 0, 1);
            this.tlpPrincipal.Controls.Add(this.tlpMascota, 1, 1);
            this.tlpPrincipal.Controls.Add(this.tlpArticulos, 1, 3);
            this.tlpPrincipal.Controls.Add(this.cboTipo, 1, 2);
            this.tlpPrincipal.Controls.Add(this.lblTipo, 0, 2);
            this.tlpPrincipal.Location = new System.Drawing.Point(12, 12);
            this.tlpPrincipal.Name = "tlpPrincipal";
            this.tlpPrincipal.RowCount = 7;
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpPrincipal.Size = new System.Drawing.Size(310, 277);
            this.tlpPrincipal.TabIndex = 2;
            // 
            // txtNotas
            // 
            this.txtNotas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtNotas.Location = new System.Drawing.Point(123, 168);
            this.txtNotas.MaxLength = 25;
            this.txtNotas.Multiline = true;
            this.txtNotas.Name = "txtNotas";
            this.txtNotas.Size = new System.Drawing.Size(184, 64);
            this.txtNotas.TabIndex = 8;
            // 
            // lblNotas
            // 
            this.lblNotas.AutoSize = true;
            this.lblNotas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblNotas.Location = new System.Drawing.Point(3, 165);
            this.lblNotas.Name = "lblNotas";
            this.lblNotas.Size = new System.Drawing.Size(114, 70);
            this.lblNotas.TabIndex = 15;
            this.lblNotas.Text = "Notas";
            this.lblNotas.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblValor.Location = new System.Drawing.Point(3, 135);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(114, 30);
            this.lblValor.TabIndex = 8;
            this.lblValor.Text = "Valor total";
            this.lblValor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCliente.Location = new System.Drawing.Point(3, 0);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(114, 35);
            this.lblCliente.TabIndex = 2;
            this.lblCliente.Text = "Cliente";
            this.lblCliente.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // flpOpciones
            // 
            this.flpOpciones.Controls.Add(this.btnAgregar);
            this.flpOpciones.Controls.Add(this.btnCancelar);
            this.flpOpciones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpOpciones.Location = new System.Drawing.Point(123, 238);
            this.flpOpciones.Name = "flpOpciones";
            this.flpOpciones.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.flpOpciones.Size = new System.Drawing.Size(184, 36);
            this.flpOpciones.TabIndex = 9;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(106, 3);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 10;
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
            this.btnCancelar.TabIndex = 9;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // tlpCliente
            // 
            this.tlpCliente.ColumnCount = 2;
            this.tlpCliente.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpCliente.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpCliente.Controls.Add(this.txtCliente, 0, 0);
            this.tlpCliente.Controls.Add(this.btnCliente, 1, 0);
            this.tlpCliente.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpCliente.Location = new System.Drawing.Point(123, 3);
            this.tlpCliente.Name = "tlpCliente";
            this.tlpCliente.RowCount = 1;
            this.tlpCliente.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpCliente.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tlpCliente.Size = new System.Drawing.Size(184, 29);
            this.tlpCliente.TabIndex = 10;
            // 
            // txtCliente
            // 
            this.txtCliente.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtCliente.Location = new System.Drawing.Point(3, 3);
            this.txtCliente.MaxLength = 11;
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.ReadOnly = true;
            this.txtCliente.Size = new System.Drawing.Size(86, 20);
            this.txtCliente.TabIndex = 1;
            // 
            // btnCliente
            // 
            this.btnCliente.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCliente.Location = new System.Drawing.Point(95, 3);
            this.btnCliente.Name = "btnCliente";
            this.btnCliente.Size = new System.Drawing.Size(86, 23);
            this.btnCliente.TabIndex = 2;
            this.btnCliente.Text = "Seleccionar";
            this.btnCliente.UseVisualStyleBackColor = true;
            this.btnCliente.Click += new System.EventHandler(this.btnCliente_Click);
            // 
            // numValor
            // 
            this.numValor.DecimalPlaces = 2;
            this.numValor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numValor.Enabled = false;
            this.numValor.Location = new System.Drawing.Point(123, 138);
            this.numValor.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.numValor.Name = "numValor";
            this.numValor.ReadOnly = true;
            this.numValor.Size = new System.Drawing.Size(184, 20);
            this.numValor.TabIndex = 7;
            this.numValor.ThousandsSeparator = true;
            // 
            // lblArticulo
            // 
            this.lblArticulo.AutoSize = true;
            this.lblArticulo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblArticulo.Location = new System.Drawing.Point(3, 100);
            this.lblArticulo.Name = "lblArticulo";
            this.lblArticulo.Size = new System.Drawing.Size(114, 35);
            this.lblArticulo.TabIndex = 4;
            this.lblArticulo.Text = "Artículo";
            this.lblArticulo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblMascota
            // 
            this.lblMascota.AutoSize = true;
            this.lblMascota.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMascota.Location = new System.Drawing.Point(3, 35);
            this.lblMascota.Name = "lblMascota";
            this.lblMascota.Size = new System.Drawing.Size(114, 35);
            this.lblMascota.TabIndex = 16;
            this.lblMascota.Text = "Mascota";
            this.lblMascota.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tlpMascota
            // 
            this.tlpMascota.ColumnCount = 2;
            this.tlpMascota.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpMascota.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpMascota.Controls.Add(this.txtMascota, 0, 0);
            this.tlpMascota.Controls.Add(this.btnMascota, 1, 0);
            this.tlpMascota.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMascota.Location = new System.Drawing.Point(123, 38);
            this.tlpMascota.Name = "tlpMascota";
            this.tlpMascota.RowCount = 1;
            this.tlpMascota.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMascota.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tlpMascota.Size = new System.Drawing.Size(184, 29);
            this.tlpMascota.TabIndex = 17;
            // 
            // txtMascota
            // 
            this.txtMascota.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtMascota.Location = new System.Drawing.Point(3, 3);
            this.txtMascota.MaxLength = 11;
            this.txtMascota.Name = "txtMascota";
            this.txtMascota.ReadOnly = true;
            this.txtMascota.Size = new System.Drawing.Size(86, 20);
            this.txtMascota.TabIndex = 3;
            // 
            // btnMascota
            // 
            this.btnMascota.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnMascota.Location = new System.Drawing.Point(95, 3);
            this.btnMascota.Name = "btnMascota";
            this.btnMascota.Size = new System.Drawing.Size(86, 23);
            this.btnMascota.TabIndex = 4;
            this.btnMascota.Text = "Seleccionar";
            this.btnMascota.UseVisualStyleBackColor = true;
            this.btnMascota.Click += new System.EventHandler(this.btnMascota_Click);
            // 
            // tlpArticulos
            // 
            this.tlpArticulos.ColumnCount = 2;
            this.tlpArticulos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpArticulos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpArticulos.Controls.Add(this.txtArticulo, 0, 0);
            this.tlpArticulos.Controls.Add(this.btnArticulo, 1, 0);
            this.tlpArticulos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpArticulos.Location = new System.Drawing.Point(123, 103);
            this.tlpArticulos.Name = "tlpArticulos";
            this.tlpArticulos.RowCount = 1;
            this.tlpArticulos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpArticulos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tlpArticulos.Size = new System.Drawing.Size(184, 29);
            this.tlpArticulos.TabIndex = 18;
            // 
            // txtArticulo
            // 
            this.txtArticulo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtArticulo.Location = new System.Drawing.Point(3, 3);
            this.txtArticulo.MaxLength = 11;
            this.txtArticulo.Name = "txtArticulo";
            this.txtArticulo.ReadOnly = true;
            this.txtArticulo.Size = new System.Drawing.Size(86, 20);
            this.txtArticulo.TabIndex = 7;
            // 
            // btnArticulo
            // 
            this.btnArticulo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnArticulo.Location = new System.Drawing.Point(95, 3);
            this.btnArticulo.Name = "btnArticulo";
            this.btnArticulo.Size = new System.Drawing.Size(86, 23);
            this.btnArticulo.TabIndex = 6;
            this.btnArticulo.Text = "Seleccionar";
            this.btnArticulo.UseVisualStyleBackColor = true;
            this.btnArticulo.Click += new System.EventHandler(this.btnArticulo_Click);
            // 
            // cboTipo
            // 
            this.cboTipo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cboTipo.FormattingEnabled = true;
            this.cboTipo.Items.AddRange(new object[] {
            "Productos",
            "Servicios"});
            this.cboTipo.Location = new System.Drawing.Point(123, 73);
            this.cboTipo.Name = "cboTipo";
            this.cboTipo.Size = new System.Drawing.Size(184, 21);
            this.cboTipo.TabIndex = 19;
            this.cboTipo.SelectedIndexChanged += new System.EventHandler(this.cboTipo_SelectedIndexChanged);
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTipo.Location = new System.Drawing.Point(3, 70);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(114, 30);
            this.lblTipo.TabIndex = 20;
            this.lblTipo.Text = "Tipo";
            this.lblTipo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // FrmOrden
            // 
            this.AcceptButton = this.btnAgregar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancelar;
            this.ClientSize = new System.Drawing.Size(334, 301);
            this.Controls.Add(this.tlpPrincipal);
            this.MaximizeBox = false;
            this.Name = "FrmOrden";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Agregar orden";
            this.tlpPrincipal.ResumeLayout(false);
            this.tlpPrincipal.PerformLayout();
            this.flpOpciones.ResumeLayout(false);
            this.tlpCliente.ResumeLayout(false);
            this.tlpCliente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numValor)).EndInit();
            this.tlpMascota.ResumeLayout(false);
            this.tlpMascota.PerformLayout();
            this.tlpArticulos.ResumeLayout(false);
            this.tlpArticulos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpPrincipal;
        private System.Windows.Forms.TextBox txtNotas;
        private System.Windows.Forms.Label lblNotas;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.Label lblArticulo;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.TableLayoutPanel tlpCliente;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.Button btnCliente;
        private System.Windows.Forms.NumericUpDown numValor;
        private System.Windows.Forms.FlowLayoutPanel flpOpciones;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblMascota;
        private System.Windows.Forms.TableLayoutPanel tlpMascota;
        private System.Windows.Forms.TextBox txtMascota;
        private System.Windows.Forms.Button btnMascota;
        private System.Windows.Forms.TableLayoutPanel tlpArticulos;
        private System.Windows.Forms.Button btnArticulo;
        private System.Windows.Forms.ComboBox cboTipo;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.TextBox txtArticulo;
    }
}