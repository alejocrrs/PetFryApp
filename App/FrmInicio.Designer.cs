namespace App
{
    partial class FrmInicio
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
            this.tlpPrincipal = new System.Windows.Forms.TableLayoutPanel();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.tabMenu = new System.Windows.Forms.TabControl();
            this.pagClientes = new System.Windows.Forms.TabPage();
            this.tlpClientes = new System.Windows.Forms.TableLayoutPanel();
            this.flpClientesOpciones = new System.Windows.Forms.FlowLayoutPanel();
            this.btnClientesEliminar = new System.Windows.Forms.Button();
            this.btnClientesEditar = new System.Windows.Forms.Button();
            this.btnClientesAgregar = new System.Windows.Forms.Button();
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.IdCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DocumentoCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TelefonoCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DireccionCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CorreoCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pagMascotas = new System.Windows.Forms.TabPage();
            this.tlpMascotas = new System.Windows.Forms.TableLayoutPanel();
            this.flpMascotasOpciones = new System.Windows.Forms.FlowLayoutPanel();
            this.btnMascotasEliminar = new System.Windows.Forms.Button();
            this.btnMascotasEditar = new System.Windows.Forms.Button();
            this.btnMascotasAgregar = new System.Windows.Forms.Button();
            this.dgvMascotas = new System.Windows.Forms.DataGridView();
            this.IdMascota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreMascota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PropietarioMascota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AnimalMascota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RazaMascota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PesoMascota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColorMascota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NotasMascota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pagProductos = new System.Windows.Forms.TabPage();
            this.tlpProductos = new System.Windows.Forms.TableLayoutPanel();
            this.flpProductosOpciones = new System.Windows.Forms.FlowLayoutPanel();
            this.btnProductosEliminar = new System.Windows.Forms.Button();
            this.btnProductosEditar = new System.Windows.Forms.Button();
            this.btnProductosAgregar = new System.Windows.Forms.Button();
            this.dgvProductos = new System.Windows.Forms.DataGridView();
            this.IdProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValorProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NotasProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pagServicios = new System.Windows.Forms.TabPage();
            this.tlpServicios = new System.Windows.Forms.TableLayoutPanel();
            this.flpServiciosOpciones = new System.Windows.Forms.FlowLayoutPanel();
            this.btnServiciosEliminar = new System.Windows.Forms.Button();
            this.btnServiciosEditar = new System.Windows.Forms.Button();
            this.btnServiciosAgregar = new System.Windows.Forms.Button();
            this.dgvServicios = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tlpPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.tabMenu.SuspendLayout();
            this.pagClientes.SuspendLayout();
            this.tlpClientes.SuspendLayout();
            this.flpClientesOpciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            this.pagMascotas.SuspendLayout();
            this.tlpMascotas.SuspendLayout();
            this.flpMascotasOpciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMascotas)).BeginInit();
            this.pagProductos.SuspendLayout();
            this.tlpProductos.SuspendLayout();
            this.flpProductosOpciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            this.pagServicios.SuspendLayout();
            this.tlpServicios.SuspendLayout();
            this.flpServiciosOpciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvServicios)).BeginInit();
            this.SuspendLayout();
            // 
            // tlpPrincipal
            // 
            this.tlpPrincipal.ColumnCount = 1;
            this.tlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpPrincipal.Controls.Add(this.picLogo, 0, 0);
            this.tlpPrincipal.Controls.Add(this.tabMenu, 0, 1);
            this.tlpPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpPrincipal.Location = new System.Drawing.Point(0, 0);
            this.tlpPrincipal.Name = "tlpPrincipal";
            this.tlpPrincipal.Padding = new System.Windows.Forms.Padding(10);
            this.tlpPrincipal.RowCount = 2;
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tlpPrincipal.Size = new System.Drawing.Size(984, 661);
            this.tlpPrincipal.TabIndex = 0;
            // 
            // picLogo
            // 
            this.picLogo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picLogo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picLogo.Image = global::App.Properties.Resources.PetFry_Logo;
            this.picLogo.Location = new System.Drawing.Point(13, 13);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(958, 154);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picLogo.TabIndex = 0;
            this.picLogo.TabStop = false;
            // 
            // tabMenu
            // 
            this.tabMenu.Controls.Add(this.pagClientes);
            this.tabMenu.Controls.Add(this.pagMascotas);
            this.tabMenu.Controls.Add(this.pagProductos);
            this.tabMenu.Controls.Add(this.pagServicios);
            this.tabMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabMenu.Location = new System.Drawing.Point(13, 173);
            this.tabMenu.Name = "tabMenu";
            this.tabMenu.SelectedIndex = 0;
            this.tabMenu.Size = new System.Drawing.Size(958, 475);
            this.tabMenu.TabIndex = 1;
            this.tabMenu.SelectedIndexChanged += new System.EventHandler(this.tabMenu_SelectedIndexChanged);
            // 
            // pagClientes
            // 
            this.pagClientes.Controls.Add(this.tlpClientes);
            this.pagClientes.Location = new System.Drawing.Point(4, 22);
            this.pagClientes.Name = "pagClientes";
            this.pagClientes.Padding = new System.Windows.Forms.Padding(3);
            this.pagClientes.Size = new System.Drawing.Size(950, 449);
            this.pagClientes.TabIndex = 0;
            this.pagClientes.Text = "Clientes";
            this.pagClientes.UseVisualStyleBackColor = true;
            // 
            // tlpClientes
            // 
            this.tlpClientes.ColumnCount = 1;
            this.tlpClientes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpClientes.Controls.Add(this.flpClientesOpciones, 0, 0);
            this.tlpClientes.Controls.Add(this.dgvClientes, 0, 1);
            this.tlpClientes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpClientes.Location = new System.Drawing.Point(3, 3);
            this.tlpClientes.Name = "tlpClientes";
            this.tlpClientes.RowCount = 2;
            this.tlpClientes.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlpClientes.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tlpClientes.Size = new System.Drawing.Size(944, 443);
            this.tlpClientes.TabIndex = 0;
            // 
            // flpClientesOpciones
            // 
            this.flpClientesOpciones.Controls.Add(this.btnClientesEliminar);
            this.flpClientesOpciones.Controls.Add(this.btnClientesEditar);
            this.flpClientesOpciones.Controls.Add(this.btnClientesAgregar);
            this.flpClientesOpciones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpClientesOpciones.Location = new System.Drawing.Point(3, 3);
            this.flpClientesOpciones.Name = "flpClientesOpciones";
            this.flpClientesOpciones.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.flpClientesOpciones.Size = new System.Drawing.Size(938, 38);
            this.flpClientesOpciones.TabIndex = 0;
            // 
            // btnClientesEliminar
            // 
            this.btnClientesEliminar.Enabled = false;
            this.btnClientesEliminar.Location = new System.Drawing.Point(860, 3);
            this.btnClientesEliminar.Name = "btnClientesEliminar";
            this.btnClientesEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnClientesEliminar.TabIndex = 2;
            this.btnClientesEliminar.Text = "Eliminar";
            this.btnClientesEliminar.UseVisualStyleBackColor = true;
            this.btnClientesEliminar.Click += new System.EventHandler(this.btnClientesEliminar_Click);
            // 
            // btnClientesEditar
            // 
            this.btnClientesEditar.Enabled = false;
            this.btnClientesEditar.Location = new System.Drawing.Point(779, 3);
            this.btnClientesEditar.Name = "btnClientesEditar";
            this.btnClientesEditar.Size = new System.Drawing.Size(75, 23);
            this.btnClientesEditar.TabIndex = 1;
            this.btnClientesEditar.Text = "Editar";
            this.btnClientesEditar.UseVisualStyleBackColor = true;
            this.btnClientesEditar.Click += new System.EventHandler(this.btnClientesEditar_Click);
            // 
            // btnClientesAgregar
            // 
            this.btnClientesAgregar.Location = new System.Drawing.Point(698, 3);
            this.btnClientesAgregar.Name = "btnClientesAgregar";
            this.btnClientesAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnClientesAgregar.TabIndex = 0;
            this.btnClientesAgregar.Text = "Agregar";
            this.btnClientesAgregar.UseVisualStyleBackColor = true;
            this.btnClientesAgregar.Click += new System.EventHandler(this.btnClientesAgregar_Click);
            // 
            // dgvClientes
            // 
            this.dgvClientes.AllowUserToAddRows = false;
            this.dgvClientes.AllowUserToDeleteRows = false;
            this.dgvClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvClientes.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdCliente,
            this.DocumentoCliente,
            this.NombreCliente,
            this.TelefonoCliente,
            this.DireccionCliente,
            this.CorreoCliente});
            this.dgvClientes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvClientes.Location = new System.Drawing.Point(3, 47);
            this.dgvClientes.MultiSelect = false;
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.ReadOnly = true;
            this.dgvClientes.RowHeadersVisible = false;
            this.dgvClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvClientes.Size = new System.Drawing.Size(938, 393);
            this.dgvClientes.TabIndex = 1;
            this.dgvClientes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvClientes_CellClick);
            this.dgvClientes.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.btnClientesEditar_Click);
            // 
            // IdCliente
            // 
            this.IdCliente.FillWeight = 30F;
            this.IdCliente.HeaderText = "Id";
            this.IdCliente.Name = "IdCliente";
            this.IdCliente.ReadOnly = true;
            // 
            // DocumentoCliente
            // 
            this.DocumentoCliente.FillWeight = 80F;
            this.DocumentoCliente.HeaderText = "Número de documento";
            this.DocumentoCliente.Name = "DocumentoCliente";
            this.DocumentoCliente.ReadOnly = true;
            // 
            // NombreCliente
            // 
            this.NombreCliente.FillWeight = 120F;
            this.NombreCliente.HeaderText = "Nombre completo";
            this.NombreCliente.Name = "NombreCliente";
            this.NombreCliente.ReadOnly = true;
            // 
            // TelefonoCliente
            // 
            this.TelefonoCliente.FillWeight = 80F;
            this.TelefonoCliente.HeaderText = "Número de teléfono";
            this.TelefonoCliente.Name = "TelefonoCliente";
            this.TelefonoCliente.ReadOnly = true;
            // 
            // DireccionCliente
            // 
            this.DireccionCliente.HeaderText = "Dirección de residencia";
            this.DireccionCliente.Name = "DireccionCliente";
            this.DireccionCliente.ReadOnly = true;
            // 
            // CorreoCliente
            // 
            this.CorreoCliente.FillWeight = 80F;
            this.CorreoCliente.HeaderText = "Correo electrónico";
            this.CorreoCliente.Name = "CorreoCliente";
            this.CorreoCliente.ReadOnly = true;
            // 
            // pagMascotas
            // 
            this.pagMascotas.Controls.Add(this.tlpMascotas);
            this.pagMascotas.Location = new System.Drawing.Point(4, 22);
            this.pagMascotas.Name = "pagMascotas";
            this.pagMascotas.Padding = new System.Windows.Forms.Padding(3);
            this.pagMascotas.Size = new System.Drawing.Size(950, 449);
            this.pagMascotas.TabIndex = 1;
            this.pagMascotas.Text = "Mascotas";
            this.pagMascotas.UseVisualStyleBackColor = true;
            // 
            // tlpMascotas
            // 
            this.tlpMascotas.ColumnCount = 1;
            this.tlpMascotas.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMascotas.Controls.Add(this.flpMascotasOpciones, 0, 0);
            this.tlpMascotas.Controls.Add(this.dgvMascotas, 0, 1);
            this.tlpMascotas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMascotas.Location = new System.Drawing.Point(3, 3);
            this.tlpMascotas.Name = "tlpMascotas";
            this.tlpMascotas.RowCount = 2;
            this.tlpMascotas.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlpMascotas.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tlpMascotas.Size = new System.Drawing.Size(944, 443);
            this.tlpMascotas.TabIndex = 0;
            // 
            // flpMascotasOpciones
            // 
            this.flpMascotasOpciones.Controls.Add(this.btnMascotasEliminar);
            this.flpMascotasOpciones.Controls.Add(this.btnMascotasEditar);
            this.flpMascotasOpciones.Controls.Add(this.btnMascotasAgregar);
            this.flpMascotasOpciones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpMascotasOpciones.Location = new System.Drawing.Point(3, 3);
            this.flpMascotasOpciones.Name = "flpMascotasOpciones";
            this.flpMascotasOpciones.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.flpMascotasOpciones.Size = new System.Drawing.Size(938, 38);
            this.flpMascotasOpciones.TabIndex = 0;
            // 
            // btnMascotasEliminar
            // 
            this.btnMascotasEliminar.Enabled = false;
            this.btnMascotasEliminar.Location = new System.Drawing.Point(860, 3);
            this.btnMascotasEliminar.Name = "btnMascotasEliminar";
            this.btnMascotasEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnMascotasEliminar.TabIndex = 2;
            this.btnMascotasEliminar.Text = "Eliminar";
            this.btnMascotasEliminar.UseVisualStyleBackColor = true;
            this.btnMascotasEliminar.Click += new System.EventHandler(this.btnMascotasEliminar_Click);
            // 
            // btnMascotasEditar
            // 
            this.btnMascotasEditar.Enabled = false;
            this.btnMascotasEditar.Location = new System.Drawing.Point(779, 3);
            this.btnMascotasEditar.Name = "btnMascotasEditar";
            this.btnMascotasEditar.Size = new System.Drawing.Size(75, 23);
            this.btnMascotasEditar.TabIndex = 1;
            this.btnMascotasEditar.Text = "Editar";
            this.btnMascotasEditar.UseVisualStyleBackColor = true;
            this.btnMascotasEditar.Click += new System.EventHandler(this.btnMascotasEditar_Click);
            // 
            // btnMascotasAgregar
            // 
            this.btnMascotasAgregar.Location = new System.Drawing.Point(698, 3);
            this.btnMascotasAgregar.Name = "btnMascotasAgregar";
            this.btnMascotasAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnMascotasAgregar.TabIndex = 0;
            this.btnMascotasAgregar.Text = "Agregar";
            this.btnMascotasAgregar.UseVisualStyleBackColor = true;
            this.btnMascotasAgregar.Click += new System.EventHandler(this.btnMascotasAgregar_Click);
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
            this.NotasMascota});
            this.dgvMascotas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMascotas.Location = new System.Drawing.Point(3, 47);
            this.dgvMascotas.MultiSelect = false;
            this.dgvMascotas.Name = "dgvMascotas";
            this.dgvMascotas.ReadOnly = true;
            this.dgvMascotas.RowHeadersVisible = false;
            this.dgvMascotas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMascotas.Size = new System.Drawing.Size(938, 393);
            this.dgvMascotas.TabIndex = 1;
            this.dgvMascotas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMascotas_CellClick);
            this.dgvMascotas.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.btnMascotasEditar_Click);
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
            this.PropietarioMascota.HeaderText = "Id del propietario";
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
            // NotasMascota
            // 
            this.NotasMascota.HeaderText = "Observaciones";
            this.NotasMascota.Name = "NotasMascota";
            this.NotasMascota.ReadOnly = true;
            // 
            // pagProductos
            // 
            this.pagProductos.Controls.Add(this.tlpProductos);
            this.pagProductos.Location = new System.Drawing.Point(4, 22);
            this.pagProductos.Name = "pagProductos";
            this.pagProductos.Padding = new System.Windows.Forms.Padding(3);
            this.pagProductos.Size = new System.Drawing.Size(950, 449);
            this.pagProductos.TabIndex = 2;
            this.pagProductos.Text = "Productos";
            this.pagProductos.UseVisualStyleBackColor = true;
            // 
            // tlpProductos
            // 
            this.tlpProductos.ColumnCount = 1;
            this.tlpProductos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpProductos.Controls.Add(this.flpProductosOpciones, 0, 0);
            this.tlpProductos.Controls.Add(this.dgvProductos, 0, 1);
            this.tlpProductos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpProductos.Location = new System.Drawing.Point(3, 3);
            this.tlpProductos.Name = "tlpProductos";
            this.tlpProductos.RowCount = 2;
            this.tlpProductos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlpProductos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tlpProductos.Size = new System.Drawing.Size(944, 443);
            this.tlpProductos.TabIndex = 0;
            // 
            // flpProductosOpciones
            // 
            this.flpProductosOpciones.Controls.Add(this.btnProductosEliminar);
            this.flpProductosOpciones.Controls.Add(this.btnProductosEditar);
            this.flpProductosOpciones.Controls.Add(this.btnProductosAgregar);
            this.flpProductosOpciones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpProductosOpciones.Location = new System.Drawing.Point(3, 3);
            this.flpProductosOpciones.Name = "flpProductosOpciones";
            this.flpProductosOpciones.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.flpProductosOpciones.Size = new System.Drawing.Size(938, 38);
            this.flpProductosOpciones.TabIndex = 0;
            // 
            // btnProductosEliminar
            // 
            this.btnProductosEliminar.Enabled = false;
            this.btnProductosEliminar.Location = new System.Drawing.Point(860, 3);
            this.btnProductosEliminar.Name = "btnProductosEliminar";
            this.btnProductosEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnProductosEliminar.TabIndex = 2;
            this.btnProductosEliminar.Text = "Eliminar";
            this.btnProductosEliminar.UseVisualStyleBackColor = true;
            this.btnProductosEliminar.Click += new System.EventHandler(this.btnProductoEliminar_Click);
            // 
            // btnProductosEditar
            // 
            this.btnProductosEditar.Enabled = false;
            this.btnProductosEditar.Location = new System.Drawing.Point(779, 3);
            this.btnProductosEditar.Name = "btnProductosEditar";
            this.btnProductosEditar.Size = new System.Drawing.Size(75, 23);
            this.btnProductosEditar.TabIndex = 1;
            this.btnProductosEditar.Text = "Editar";
            this.btnProductosEditar.UseVisualStyleBackColor = true;
            this.btnProductosEditar.Click += new System.EventHandler(this.btnProductosEditar_Click);
            // 
            // btnProductosAgregar
            // 
            this.btnProductosAgregar.Location = new System.Drawing.Point(698, 3);
            this.btnProductosAgregar.Name = "btnProductosAgregar";
            this.btnProductosAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnProductosAgregar.TabIndex = 0;
            this.btnProductosAgregar.Text = "Agregar";
            this.btnProductosAgregar.UseVisualStyleBackColor = true;
            this.btnProductosAgregar.Click += new System.EventHandler(this.btnProductosAgregar_Click);
            // 
            // dgvProductos
            // 
            this.dgvProductos.AllowUserToAddRows = false;
            this.dgvProductos.AllowUserToDeleteRows = false;
            this.dgvProductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProductos.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdProducto,
            this.NombreProducto,
            this.ValorProducto,
            this.NotasProducto});
            this.dgvProductos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvProductos.Location = new System.Drawing.Point(3, 47);
            this.dgvProductos.MultiSelect = false;
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.ReadOnly = true;
            this.dgvProductos.RowHeadersVisible = false;
            this.dgvProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProductos.Size = new System.Drawing.Size(938, 393);
            this.dgvProductos.TabIndex = 1;
            this.dgvProductos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProductos_CellClick);
            this.dgvProductos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.btnProductosEditar_Click);
            // 
            // IdProducto
            // 
            this.IdProducto.FillWeight = 30F;
            this.IdProducto.HeaderText = "Id";
            this.IdProducto.Name = "IdProducto";
            this.IdProducto.ReadOnly = true;
            // 
            // NombreProducto
            // 
            this.NombreProducto.FillWeight = 120F;
            this.NombreProducto.HeaderText = "Nombre descriptivo";
            this.NombreProducto.Name = "NombreProducto";
            this.NombreProducto.ReadOnly = true;
            // 
            // ValorProducto
            // 
            this.ValorProducto.FillWeight = 70F;
            this.ValorProducto.HeaderText = "Valor unitario";
            this.ValorProducto.Name = "ValorProducto";
            this.ValorProducto.ReadOnly = true;
            // 
            // NotasProducto
            // 
            this.NotasProducto.HeaderText = "Observaciones";
            this.NotasProducto.Name = "NotasProducto";
            this.NotasProducto.ReadOnly = true;
            // 
            // pagServicios
            // 
            this.pagServicios.Controls.Add(this.tlpServicios);
            this.pagServicios.Location = new System.Drawing.Point(4, 22);
            this.pagServicios.Name = "pagServicios";
            this.pagServicios.Padding = new System.Windows.Forms.Padding(3);
            this.pagServicios.Size = new System.Drawing.Size(950, 449);
            this.pagServicios.TabIndex = 3;
            this.pagServicios.Text = "Servicios";
            this.pagServicios.UseVisualStyleBackColor = true;
            // 
            // tlpServicios
            // 
            this.tlpServicios.ColumnCount = 1;
            this.tlpServicios.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpServicios.Controls.Add(this.flpServiciosOpciones, 0, 0);
            this.tlpServicios.Controls.Add(this.dgvServicios, 0, 1);
            this.tlpServicios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpServicios.Location = new System.Drawing.Point(3, 3);
            this.tlpServicios.Name = "tlpServicios";
            this.tlpServicios.RowCount = 2;
            this.tlpServicios.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlpServicios.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tlpServicios.Size = new System.Drawing.Size(944, 443);
            this.tlpServicios.TabIndex = 0;
            // 
            // flpServiciosOpciones
            // 
            this.flpServiciosOpciones.Controls.Add(this.btnServiciosEliminar);
            this.flpServiciosOpciones.Controls.Add(this.btnServiciosEditar);
            this.flpServiciosOpciones.Controls.Add(this.btnServiciosAgregar);
            this.flpServiciosOpciones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpServiciosOpciones.Location = new System.Drawing.Point(3, 3);
            this.flpServiciosOpciones.Name = "flpServiciosOpciones";
            this.flpServiciosOpciones.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.flpServiciosOpciones.Size = new System.Drawing.Size(938, 38);
            this.flpServiciosOpciones.TabIndex = 0;
            // 
            // btnServiciosEliminar
            // 
            this.btnServiciosEliminar.Enabled = false;
            this.btnServiciosEliminar.Location = new System.Drawing.Point(860, 3);
            this.btnServiciosEliminar.Name = "btnServiciosEliminar";
            this.btnServiciosEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnServiciosEliminar.TabIndex = 2;
            this.btnServiciosEliminar.Text = "Eliminar";
            this.btnServiciosEliminar.UseVisualStyleBackColor = true;
            this.btnServiciosEliminar.Click += new System.EventHandler(this.btnServiciosEliminar_Click);
            // 
            // btnServiciosEditar
            // 
            this.btnServiciosEditar.Enabled = false;
            this.btnServiciosEditar.Location = new System.Drawing.Point(779, 3);
            this.btnServiciosEditar.Name = "btnServiciosEditar";
            this.btnServiciosEditar.Size = new System.Drawing.Size(75, 23);
            this.btnServiciosEditar.TabIndex = 1;
            this.btnServiciosEditar.Text = "Editar";
            this.btnServiciosEditar.UseVisualStyleBackColor = true;
            this.btnServiciosEditar.Click += new System.EventHandler(this.btnServiciosEditar_Click);
            // 
            // btnServiciosAgregar
            // 
            this.btnServiciosAgregar.Location = new System.Drawing.Point(698, 3);
            this.btnServiciosAgregar.Name = "btnServiciosAgregar";
            this.btnServiciosAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnServiciosAgregar.TabIndex = 0;
            this.btnServiciosAgregar.Text = "Agregar";
            this.btnServiciosAgregar.UseVisualStyleBackColor = true;
            this.btnServiciosAgregar.Click += new System.EventHandler(this.btnServiciosAgregar_Click);
            // 
            // dgvServicios
            // 
            this.dgvServicios.AllowUserToAddRows = false;
            this.dgvServicios.AllowUserToDeleteRows = false;
            this.dgvServicios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvServicios.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvServicios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvServicios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.dgvServicios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvServicios.Location = new System.Drawing.Point(3, 47);
            this.dgvServicios.MultiSelect = false;
            this.dgvServicios.Name = "dgvServicios";
            this.dgvServicios.ReadOnly = true;
            this.dgvServicios.RowHeadersVisible = false;
            this.dgvServicios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvServicios.Size = new System.Drawing.Size(938, 393);
            this.dgvServicios.TabIndex = 1;
            this.dgvServicios.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvServicios_CellClick);
            this.dgvServicios.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.btnServiciosEditar_Click);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.FillWeight = 30F;
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.FillWeight = 120F;
            this.dataGridViewTextBoxColumn2.HeaderText = "Nombre descriptivo";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.FillWeight = 70F;
            this.dataGridViewTextBoxColumn3.HeaderText = "Valor unitario";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Observaciones";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // FrmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 661);
            this.Controls.Add(this.tlpPrincipal);
            this.Name = "FrmInicio";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "PetFryApp";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmInicio_Load);
            this.tlpPrincipal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.tabMenu.ResumeLayout(false);
            this.pagClientes.ResumeLayout(false);
            this.tlpClientes.ResumeLayout(false);
            this.flpClientesOpciones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            this.pagMascotas.ResumeLayout(false);
            this.tlpMascotas.ResumeLayout(false);
            this.flpMascotasOpciones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMascotas)).EndInit();
            this.pagProductos.ResumeLayout(false);
            this.tlpProductos.ResumeLayout(false);
            this.flpProductosOpciones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            this.pagServicios.ResumeLayout(false);
            this.tlpServicios.ResumeLayout(false);
            this.flpServiciosOpciones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvServicios)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpPrincipal;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.TabControl tabMenu;
        private System.Windows.Forms.TabPage pagClientes;
        private System.Windows.Forms.TableLayoutPanel tlpClientes;
        private System.Windows.Forms.FlowLayoutPanel flpClientesOpciones;
        private System.Windows.Forms.Button btnClientesAgregar;
        private System.Windows.Forms.Button btnClientesEditar;
        private System.Windows.Forms.Button btnClientesEliminar;
        private System.Windows.Forms.DataGridView dgvClientes;
        private System.Windows.Forms.TabPage pagMascotas;
        private System.Windows.Forms.TableLayoutPanel tlpMascotas;
        private System.Windows.Forms.FlowLayoutPanel flpMascotasOpciones;
        private System.Windows.Forms.Button btnMascotasEliminar;
        private System.Windows.Forms.Button btnMascotasEditar;
        private System.Windows.Forms.Button btnMascotasAgregar;
        private System.Windows.Forms.DataGridView dgvMascotas;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn DocumentoCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn TelefonoCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn DireccionCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn CorreoCliente;
        private System.Windows.Forms.TabPage pagProductos;
        private System.Windows.Forms.TableLayoutPanel tlpProductos;
        private System.Windows.Forms.FlowLayoutPanel flpProductosOpciones;
        private System.Windows.Forms.Button btnProductosEliminar;
        private System.Windows.Forms.Button btnProductosEditar;
        private System.Windows.Forms.Button btnProductosAgregar;
        private System.Windows.Forms.DataGridView dgvProductos;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdMascota;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreMascota;
        private System.Windows.Forms.DataGridViewTextBoxColumn PropietarioMascota;
        private System.Windows.Forms.DataGridViewTextBoxColumn AnimalMascota;
        private System.Windows.Forms.DataGridViewTextBoxColumn RazaMascota;
        private System.Windows.Forms.DataGridViewTextBoxColumn PesoMascota;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColorMascota;
        private System.Windows.Forms.DataGridViewTextBoxColumn NotasMascota;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValorProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn NotasProducto;
        private System.Windows.Forms.TabPage pagServicios;
        private System.Windows.Forms.TableLayoutPanel tlpServicios;
        private System.Windows.Forms.FlowLayoutPanel flpServiciosOpciones;
        private System.Windows.Forms.Button btnServiciosEliminar;
        private System.Windows.Forms.Button btnServiciosEditar;
        private System.Windows.Forms.Button btnServiciosAgregar;
        private System.Windows.Forms.DataGridView dgvServicios;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    }
}

