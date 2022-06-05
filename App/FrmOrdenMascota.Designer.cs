namespace App
{
    partial class FrmOrdenMascota
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
            this.dgvMascotas = new System.Windows.Forms.DataGridView();
            this.IdMascota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreMascota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PropietarioMascota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AnimalMascota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RazaMascota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PesoMascota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColorMascota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NotasMascotas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.flpOpciones = new System.Windows.Forms.FlowLayoutPanel();
            this.btnSeleccionar = new System.Windows.Forms.Button();
            this.btnDeseleccionar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.tlpPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMascotas)).BeginInit();
            this.flpOpciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpPrincipal
            // 
            this.tlpPrincipal.ColumnCount = 1;
            this.tlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpPrincipal.Controls.Add(this.dgvMascotas, 0, 0);
            this.tlpPrincipal.Controls.Add(this.flpOpciones, 0, 1);
            this.tlpPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpPrincipal.Location = new System.Drawing.Point(0, 0);
            this.tlpPrincipal.Name = "tlpPrincipal";
            this.tlpPrincipal.Padding = new System.Windows.Forms.Padding(10);
            this.tlpPrincipal.RowCount = 2;
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlpPrincipal.Size = new System.Drawing.Size(984, 261);
            this.tlpPrincipal.TabIndex = 2;
            // 
            // dgvMascotas
            // 
            this.dgvMascotas.AllowUserToAddRows = false;
            this.dgvMascotas.AllowUserToDeleteRows = false;
            this.dgvMascotas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMascotas.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvMascotas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMascotas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdMascota,
            this.NombreMascota,
            this.PropietarioMascota,
            this.AnimalMascota,
            this.RazaMascota,
            this.PesoMascota,
            this.ColorMascota,
            this.NotasMascotas});
            this.dgvMascotas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMascotas.Location = new System.Drawing.Point(13, 13);
            this.dgvMascotas.MultiSelect = false;
            this.dgvMascotas.Name = "dgvMascotas";
            this.dgvMascotas.ReadOnly = true;
            this.dgvMascotas.RowHeadersVisible = false;
            this.dgvMascotas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMascotas.Size = new System.Drawing.Size(958, 195);
            this.dgvMascotas.TabIndex = 5;
            this.dgvMascotas.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.btnSeleccionar_Click);
            // 
            // IdMascota
            // 
            this.IdMascota.FillWeight = 30F;
            this.IdMascota.HeaderText = "Id";
            this.IdMascota.Name = "IdMascota";
            this.IdMascota.ReadOnly = true;
            // 
            // NombreMascota
            // 
            this.NombreMascota.HeaderText = "Nombre o apodo";
            this.NombreMascota.Name = "NombreMascota";
            this.NombreMascota.ReadOnly = true;
            // 
            // PropietarioMascota
            // 
            this.PropietarioMascota.FillWeight = 80F;
            this.PropietarioMascota.HeaderText = "Id del Propietario";
            this.PropietarioMascota.Name = "PropietarioMascota";
            this.PropietarioMascota.ReadOnly = true;
            // 
            // AnimalMascota
            // 
            this.AnimalMascota.FillWeight = 80F;
            this.AnimalMascota.HeaderText = "Animal";
            this.AnimalMascota.Name = "AnimalMascota";
            this.AnimalMascota.ReadOnly = true;
            // 
            // RazaMascota
            // 
            this.RazaMascota.HeaderText = "Raza";
            this.RazaMascota.Name = "RazaMascota";
            this.RazaMascota.ReadOnly = true;
            // 
            // PesoMascota
            // 
            this.PesoMascota.FillWeight = 70F;
            this.PesoMascota.HeaderText = "Peso (en kg)";
            this.PesoMascota.Name = "PesoMascota";
            this.PesoMascota.ReadOnly = true;
            // 
            // ColorMascota
            // 
            this.ColorMascota.HeaderText = "Color o patrones distintivos";
            this.ColorMascota.Name = "ColorMascota";
            this.ColorMascota.ReadOnly = true;
            // 
            // NotasMascotas
            // 
            this.NotasMascotas.HeaderText = "Observaciones";
            this.NotasMascotas.Name = "NotasMascotas";
            this.NotasMascotas.ReadOnly = true;
            // 
            // flpOpciones
            // 
            this.flpOpciones.Controls.Add(this.btnSeleccionar);
            this.flpOpciones.Controls.Add(this.btnDeseleccionar);
            this.flpOpciones.Controls.Add(this.btnCancelar);
            this.flpOpciones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpOpciones.Location = new System.Drawing.Point(13, 214);
            this.flpOpciones.Name = "flpOpciones";
            this.flpOpciones.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.flpOpciones.Size = new System.Drawing.Size(958, 34);
            this.flpOpciones.TabIndex = 6;
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.Location = new System.Drawing.Point(880, 3);
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.Size = new System.Drawing.Size(75, 23);
            this.btnSeleccionar.TabIndex = 1;
            this.btnSeleccionar.Text = "Seleccionar";
            this.btnSeleccionar.UseVisualStyleBackColor = true;
            this.btnSeleccionar.Click += new System.EventHandler(this.btnSeleccionar_Click);
            // 
            // btnDeseleccionar
            // 
            this.btnDeseleccionar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnDeseleccionar.Location = new System.Drawing.Point(784, 3);
            this.btnDeseleccionar.Name = "btnDeseleccionar";
            this.btnDeseleccionar.Size = new System.Drawing.Size(90, 23);
            this.btnDeseleccionar.TabIndex = 2;
            this.btnDeseleccionar.Text = "Deseleccionar";
            this.btnDeseleccionar.UseVisualStyleBackColor = true;
            this.btnDeseleccionar.Click += new System.EventHandler(this.btnDeseleccionar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Location = new System.Drawing.Point(703, 3);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 0;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // FrmOrdenMascota
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 261);
            this.Controls.Add(this.tlpPrincipal);
            this.MaximizeBox = false;
            this.Name = "FrmOrdenMascota";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Seleccionar mascota";
            this.tlpPrincipal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMascotas)).EndInit();
            this.flpOpciones.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpPrincipal;
        private System.Windows.Forms.DataGridView dgvMascotas;
        private System.Windows.Forms.FlowLayoutPanel flpOpciones;
        private System.Windows.Forms.Button btnSeleccionar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdMascota;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreMascota;
        private System.Windows.Forms.DataGridViewTextBoxColumn PropietarioMascota;
        private System.Windows.Forms.DataGridViewTextBoxColumn AnimalMascota;
        private System.Windows.Forms.DataGridViewTextBoxColumn RazaMascota;
        private System.Windows.Forms.DataGridViewTextBoxColumn PesoMascota;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColorMascota;
        private System.Windows.Forms.DataGridViewTextBoxColumn NotasMascotas;
        private System.Windows.Forms.Button btnDeseleccionar;
    }
}