namespace App
{
    partial class FrmProducto
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
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.flpOpciones = new System.Windows.Forms.FlowLayoutPanel();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.numValor = new System.Windows.Forms.NumericUpDown();
            this.tlpPrincipal.SuspendLayout();
            this.flpOpciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numValor)).BeginInit();
            this.SuspendLayout();
            // 
            // tlpPrincipal
            // 
            this.tlpPrincipal.ColumnCount = 2;
            this.tlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpPrincipal.Controls.Add(this.txtNotas, 1, 2);
            this.tlpPrincipal.Controls.Add(this.lblNotas, 0, 2);
            this.tlpPrincipal.Controls.Add(this.lblValor, 0, 1);
            this.tlpPrincipal.Controls.Add(this.lblNombre, 0, 0);
            this.tlpPrincipal.Controls.Add(this.txtNombre, 1, 0);
            this.tlpPrincipal.Controls.Add(this.flpOpciones, 1, 3);
            this.tlpPrincipal.Controls.Add(this.numValor, 1, 1);
            this.tlpPrincipal.Location = new System.Drawing.Point(12, 12);
            this.tlpPrincipal.Name = "tlpPrincipal";
            this.tlpPrincipal.RowCount = 4;
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpPrincipal.Size = new System.Drawing.Size(310, 167);
            this.tlpPrincipal.TabIndex = 1;
            // 
            // txtNotas
            // 
            this.txtNotas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtNotas.Location = new System.Drawing.Point(123, 63);
            this.txtNotas.MaxLength = 200;
            this.txtNotas.Multiline = true;
            this.txtNotas.Name = "txtNotas";
            this.txtNotas.Size = new System.Drawing.Size(184, 64);
            this.txtNotas.TabIndex = 3;
            // 
            // lblNotas
            // 
            this.lblNotas.AutoSize = true;
            this.lblNotas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblNotas.Location = new System.Drawing.Point(3, 60);
            this.lblNotas.Name = "lblNotas";
            this.lblNotas.Size = new System.Drawing.Size(114, 70);
            this.lblNotas.TabIndex = 4;
            this.lblNotas.Text = "Notas";
            this.lblNotas.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblValor.Location = new System.Drawing.Point(3, 30);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(114, 30);
            this.lblValor.TabIndex = 2;
            this.lblValor.Text = "Valor unitario";
            this.lblValor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblNombre.Location = new System.Drawing.Point(3, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(114, 30);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre descriptivo";
            this.lblNombre.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtNombre
            // 
            this.txtNombre.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtNombre.Location = new System.Drawing.Point(123, 3);
            this.txtNombre.MaxLength = 70;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(184, 20);
            this.txtNombre.TabIndex = 1;
            // 
            // flpOpciones
            // 
            this.flpOpciones.Controls.Add(this.btnAgregar);
            this.flpOpciones.Controls.Add(this.btnCancelar);
            this.flpOpciones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpOpciones.Location = new System.Drawing.Point(123, 133);
            this.flpOpciones.Name = "flpOpciones";
            this.flpOpciones.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.flpOpciones.Size = new System.Drawing.Size(184, 33);
            this.flpOpciones.TabIndex = 9;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(106, 3);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 4;
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
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // numValor
            // 
            this.numValor.DecimalPlaces = 2;
            this.numValor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numValor.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numValor.Location = new System.Drawing.Point(123, 33);
            this.numValor.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.numValor.Name = "numValor";
            this.numValor.Size = new System.Drawing.Size(184, 20);
            this.numValor.TabIndex = 2;
            this.numValor.ThousandsSeparator = true;
            // 
            // FrmProducto
            // 
            this.AcceptButton = this.btnAgregar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancelar;
            this.ClientSize = new System.Drawing.Size(334, 191);
            this.Controls.Add(this.tlpPrincipal);
            this.MaximizeBox = false;
            this.Name = "FrmProducto";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Agregar producto";
            this.tlpPrincipal.ResumeLayout(false);
            this.tlpPrincipal.PerformLayout();
            this.flpOpciones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numValor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpPrincipal;
        private System.Windows.Forms.TextBox txtNotas;
        private System.Windows.Forms.Label lblNotas;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.FlowLayoutPanel flpOpciones;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.NumericUpDown numValor;
    }
}