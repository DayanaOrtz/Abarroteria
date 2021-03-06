namespace POS.Forms
{
    partial class VentasPendientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VentasPendientes));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnAgregarVenta = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.txtbuscar = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.chbSelectAll = new System.Windows.Forms.CheckBox();
            this.pbTrash = new System.Windows.Forms.PictureBox();
            this.dgVentasPendientes = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tallaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estiloDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descuentoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subTotalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioTotalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productoIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comboIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.detalleColorIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.detalleTallaIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tallayColorIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accionesDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.isActiveDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.detalleEstiloIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.listaProductosTmpBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbTrash)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgVentasPendientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaProductosTmpBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(799, 25);
            this.toolStrip1.TabIndex = 5;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.dgVentasPendientes, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 25);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.882353F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90.11765F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(799, 416);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 5;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.6612F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 86.3388F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 110F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 105F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 61F));
            this.tableLayoutPanel2.Controls.Add(this.btnAgregarVenta, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.txtbuscar, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.kryptonLabel1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.chbSelectAll, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.pbTrash, 4, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(2, 2);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(795, 37);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // btnAgregarVenta
            // 
            this.btnAgregarVenta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAgregarVenta.Location = new System.Drawing.Point(520, 2);
            this.btnAgregarVenta.Margin = new System.Windows.Forms.Padding(2);
            this.btnAgregarVenta.Name = "btnAgregarVenta";
            this.btnAgregarVenta.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.btnAgregarVenta.Size = new System.Drawing.Size(106, 33);
            this.btnAgregarVenta.TabIndex = 3;
            this.btnAgregarVenta.Values.Text = "Facturar";
            this.btnAgregarVenta.Click += new System.EventHandler(this.btnAgregarVenta_Click);
            // 
            // txtbuscar
            // 
            this.txtbuscar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtbuscar.Location = new System.Drawing.Point(72, 2);
            this.txtbuscar.Margin = new System.Windows.Forms.Padding(2);
            this.txtbuscar.Name = "txtbuscar";
            this.txtbuscar.Size = new System.Drawing.Size(444, 23);
            this.txtbuscar.TabIndex = 2;
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.kryptonLabel1.Location = new System.Drawing.Point(2, 2);
            this.kryptonLabel1.Margin = new System.Windows.Forms.Padding(2);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(66, 20);
            this.kryptonLabel1.TabIndex = 1;
            this.kryptonLabel1.Values.Text = "Buscar";
            // 
            // chbSelectAll
            // 
            this.chbSelectAll.AutoSize = true;
            this.chbSelectAll.Location = new System.Drawing.Point(631, 3);
            this.chbSelectAll.Name = "chbSelectAll";
            this.chbSelectAll.Size = new System.Drawing.Size(92, 17);
            this.chbSelectAll.TabIndex = 4;
            this.chbSelectAll.Text = "Select. Todos";
            this.chbSelectAll.UseVisualStyleBackColor = true;
            this.chbSelectAll.CheckedChanged += new System.EventHandler(this.chbSelectAll_CheckedChanged);
            // 
            // pbTrash
            // 
            this.pbTrash.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbTrash.Image = ((System.Drawing.Image)(resources.GetObject("pbTrash.Image")));
            this.pbTrash.InitialImage = ((System.Drawing.Image)(resources.GetObject("pbTrash.InitialImage")));
            this.pbTrash.Location = new System.Drawing.Point(736, 3);
            this.pbTrash.Name = "pbTrash";
            this.pbTrash.Size = new System.Drawing.Size(56, 31);
            this.pbTrash.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbTrash.TabIndex = 5;
            this.pbTrash.TabStop = false;
            this.pbTrash.Click += new System.EventHandler(this.pbTrash_Click);
            // 
            // dgVentasPendientes
            // 
            this.dgVentasPendientes.AllowUserToAddRows = false;
            this.dgVentasPendientes.AllowUserToDeleteRows = false;
            this.dgVentasPendientes.AutoGenerateColumns = false;
            this.dgVentasPendientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgVentasPendientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgVentasPendientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.colorDataGridViewTextBoxColumn,
            this.tallaDataGridViewTextBoxColumn,
            this.estiloDataGridViewTextBoxColumn,
            this.descripcionDataGridViewTextBoxColumn,
            this.cantidadDataGridViewTextBoxColumn,
            this.precioDataGridViewTextBoxColumn,
            this.descuentoDataGridViewTextBoxColumn,
            this.subTotalDataGridViewTextBoxColumn,
            this.precioTotalDataGridViewTextBoxColumn,
            this.productoIdDataGridViewTextBoxColumn,
            this.comboIdDataGridViewTextBoxColumn,
            this.detalleColorIdDataGridViewTextBoxColumn,
            this.detalleTallaIdDataGridViewTextBoxColumn,
            this.tallayColorIdDataGridViewTextBoxColumn,
            this.accionesDataGridViewCheckBoxColumn,
            this.isActiveDataGridViewCheckBoxColumn,
            this.detalleEstiloIdDataGridViewTextBoxColumn});
            this.dgVentasPendientes.DataSource = this.listaProductosTmpBindingSource;
            this.dgVentasPendientes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgVentasPendientes.Location = new System.Drawing.Point(2, 43);
            this.dgVentasPendientes.Margin = new System.Windows.Forms.Padding(2);
            this.dgVentasPendientes.Name = "dgVentasPendientes";
            this.dgVentasPendientes.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.dgVentasPendientes.ReadOnly = true;
            this.dgVentasPendientes.RowHeadersWidth = 51;
            this.dgVentasPendientes.RowTemplate.Height = 24;
            this.dgVentasPendientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgVentasPendientes.Size = new System.Drawing.Size(795, 371);
            this.dgVentasPendientes.TabIndex = 1;
            this.dgVentasPendientes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgVentasPendientes_CellClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 46;
            // 
            // colorDataGridViewTextBoxColumn
            // 
            this.colorDataGridViewTextBoxColumn.DataPropertyName = "Color";
            this.colorDataGridViewTextBoxColumn.HeaderText = "Color";
            this.colorDataGridViewTextBoxColumn.Name = "colorDataGridViewTextBoxColumn";
            this.colorDataGridViewTextBoxColumn.ReadOnly = true;
            this.colorDataGridViewTextBoxColumn.Width = 65;
            // 
            // tallaDataGridViewTextBoxColumn
            // 
            this.tallaDataGridViewTextBoxColumn.DataPropertyName = "Talla";
            this.tallaDataGridViewTextBoxColumn.HeaderText = "Talla";
            this.tallaDataGridViewTextBoxColumn.Name = "tallaDataGridViewTextBoxColumn";
            this.tallaDataGridViewTextBoxColumn.ReadOnly = true;
            this.tallaDataGridViewTextBoxColumn.Width = 59;
            // 
            // estiloDataGridViewTextBoxColumn
            // 
            this.estiloDataGridViewTextBoxColumn.DataPropertyName = "Estilo";
            this.estiloDataGridViewTextBoxColumn.HeaderText = "Estilo";
            this.estiloDataGridViewTextBoxColumn.Name = "estiloDataGridViewTextBoxColumn";
            this.estiloDataGridViewTextBoxColumn.ReadOnly = true;
            this.estiloDataGridViewTextBoxColumn.Width = 64;
            // 
            // descripcionDataGridViewTextBoxColumn
            // 
            this.descripcionDataGridViewTextBoxColumn.DataPropertyName = "Descripcion";
            this.descripcionDataGridViewTextBoxColumn.HeaderText = "Descripcion";
            this.descripcionDataGridViewTextBoxColumn.Name = "descripcionDataGridViewTextBoxColumn";
            this.descripcionDataGridViewTextBoxColumn.ReadOnly = true;
            this.descripcionDataGridViewTextBoxColumn.Width = 98;
            // 
            // cantidadDataGridViewTextBoxColumn
            // 
            this.cantidadDataGridViewTextBoxColumn.DataPropertyName = "Cantidad";
            this.cantidadDataGridViewTextBoxColumn.HeaderText = "Cantidad";
            this.cantidadDataGridViewTextBoxColumn.Name = "cantidadDataGridViewTextBoxColumn";
            this.cantidadDataGridViewTextBoxColumn.ReadOnly = true;
            this.cantidadDataGridViewTextBoxColumn.Width = 84;
            // 
            // precioDataGridViewTextBoxColumn
            // 
            this.precioDataGridViewTextBoxColumn.DataPropertyName = "Precio";
            this.precioDataGridViewTextBoxColumn.HeaderText = "Precio";
            this.precioDataGridViewTextBoxColumn.Name = "precioDataGridViewTextBoxColumn";
            this.precioDataGridViewTextBoxColumn.ReadOnly = true;
            this.precioDataGridViewTextBoxColumn.Width = 69;
            // 
            // descuentoDataGridViewTextBoxColumn
            // 
            this.descuentoDataGridViewTextBoxColumn.DataPropertyName = "Descuento";
            this.descuentoDataGridViewTextBoxColumn.HeaderText = "Descuento";
            this.descuentoDataGridViewTextBoxColumn.Name = "descuentoDataGridViewTextBoxColumn";
            this.descuentoDataGridViewTextBoxColumn.ReadOnly = true;
            this.descuentoDataGridViewTextBoxColumn.Width = 92;
            // 
            // subTotalDataGridViewTextBoxColumn
            // 
            this.subTotalDataGridViewTextBoxColumn.DataPropertyName = "SubTotal";
            this.subTotalDataGridViewTextBoxColumn.HeaderText = "SubTotal";
            this.subTotalDataGridViewTextBoxColumn.Name = "subTotalDataGridViewTextBoxColumn";
            this.subTotalDataGridViewTextBoxColumn.ReadOnly = true;
            this.subTotalDataGridViewTextBoxColumn.Width = 81;
            // 
            // precioTotalDataGridViewTextBoxColumn
            // 
            this.precioTotalDataGridViewTextBoxColumn.DataPropertyName = "PrecioTotal";
            this.precioTotalDataGridViewTextBoxColumn.HeaderText = "PrecioTotal";
            this.precioTotalDataGridViewTextBoxColumn.Name = "precioTotalDataGridViewTextBoxColumn";
            this.precioTotalDataGridViewTextBoxColumn.ReadOnly = true;
            this.precioTotalDataGridViewTextBoxColumn.Width = 94;
            // 
            // productoIdDataGridViewTextBoxColumn
            // 
            this.productoIdDataGridViewTextBoxColumn.DataPropertyName = "ProductoId";
            this.productoIdDataGridViewTextBoxColumn.HeaderText = "ProductoId";
            this.productoIdDataGridViewTextBoxColumn.Name = "productoIdDataGridViewTextBoxColumn";
            this.productoIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.productoIdDataGridViewTextBoxColumn.Visible = false;
            this.productoIdDataGridViewTextBoxColumn.Width = 95;
            // 
            // comboIdDataGridViewTextBoxColumn
            // 
            this.comboIdDataGridViewTextBoxColumn.DataPropertyName = "ComboId";
            this.comboIdDataGridViewTextBoxColumn.HeaderText = "ComboId";
            this.comboIdDataGridViewTextBoxColumn.Name = "comboIdDataGridViewTextBoxColumn";
            this.comboIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.comboIdDataGridViewTextBoxColumn.Visible = false;
            this.comboIdDataGridViewTextBoxColumn.Width = 86;
            // 
            // detalleColorIdDataGridViewTextBoxColumn
            // 
            this.detalleColorIdDataGridViewTextBoxColumn.DataPropertyName = "DetalleColorId";
            this.detalleColorIdDataGridViewTextBoxColumn.HeaderText = "DetalleColorId";
            this.detalleColorIdDataGridViewTextBoxColumn.Name = "detalleColorIdDataGridViewTextBoxColumn";
            this.detalleColorIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.detalleColorIdDataGridViewTextBoxColumn.Visible = false;
            this.detalleColorIdDataGridViewTextBoxColumn.Width = 111;
            // 
            // detalleTallaIdDataGridViewTextBoxColumn
            // 
            this.detalleTallaIdDataGridViewTextBoxColumn.DataPropertyName = "DetalleTallaId";
            this.detalleTallaIdDataGridViewTextBoxColumn.HeaderText = "DetalleTallaId";
            this.detalleTallaIdDataGridViewTextBoxColumn.Name = "detalleTallaIdDataGridViewTextBoxColumn";
            this.detalleTallaIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.detalleTallaIdDataGridViewTextBoxColumn.Visible = false;
            this.detalleTallaIdDataGridViewTextBoxColumn.Width = 105;
            // 
            // tallayColorIdDataGridViewTextBoxColumn
            // 
            this.tallayColorIdDataGridViewTextBoxColumn.DataPropertyName = "TallayColorId";
            this.tallayColorIdDataGridViewTextBoxColumn.HeaderText = "TallayColorId";
            this.tallayColorIdDataGridViewTextBoxColumn.Name = "tallayColorIdDataGridViewTextBoxColumn";
            this.tallayColorIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.tallayColorIdDataGridViewTextBoxColumn.Visible = false;
            this.tallayColorIdDataGridViewTextBoxColumn.Width = 104;
            // 
            // accionesDataGridViewCheckBoxColumn
            // 
            this.accionesDataGridViewCheckBoxColumn.DataPropertyName = "Acciones";
            this.accionesDataGridViewCheckBoxColumn.HeaderText = "Acciones";
            this.accionesDataGridViewCheckBoxColumn.Name = "accionesDataGridViewCheckBoxColumn";
            this.accionesDataGridViewCheckBoxColumn.ReadOnly = true;
            this.accionesDataGridViewCheckBoxColumn.Width = 65;
            // 
            // isActiveDataGridViewCheckBoxColumn
            // 
            this.isActiveDataGridViewCheckBoxColumn.DataPropertyName = "IsActive";
            this.isActiveDataGridViewCheckBoxColumn.HeaderText = "IsActive";
            this.isActiveDataGridViewCheckBoxColumn.Name = "isActiveDataGridViewCheckBoxColumn";
            this.isActiveDataGridViewCheckBoxColumn.ReadOnly = true;
            this.isActiveDataGridViewCheckBoxColumn.Visible = false;
            this.isActiveDataGridViewCheckBoxColumn.Width = 58;
            // 
            // detalleEstiloIdDataGridViewTextBoxColumn
            // 
            this.detalleEstiloIdDataGridViewTextBoxColumn.DataPropertyName = "DetalleEstiloId";
            this.detalleEstiloIdDataGridViewTextBoxColumn.HeaderText = "DetalleEstiloId";
            this.detalleEstiloIdDataGridViewTextBoxColumn.Name = "detalleEstiloIdDataGridViewTextBoxColumn";
            this.detalleEstiloIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.detalleEstiloIdDataGridViewTextBoxColumn.Visible = false;
            this.detalleEstiloIdDataGridViewTextBoxColumn.Width = 110;
            // 
            // listaProductosTmpBindingSource
            // 
            this.listaProductosTmpBindingSource.DataSource = typeof(CapaDatos.ListasPersonalizadas.VentasAcumuladas.ListaProductosTmp);
            // 
            // VentasPendientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 441);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.toolStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "VentasPendientes";
            this.Text = "Ventas Pendientes";
            this.Load += new System.EventHandler(this.VentasPendientes_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbTrash)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgVentasPendientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaProductosTmpBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnAgregarVenta;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtbuscar;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView dgVentasPendientes;
        private System.Windows.Forms.CheckBox chbSelectAll;
        private System.Windows.Forms.PictureBox pbTrash;
        private System.Windows.Forms.BindingSource listaProductosTmpBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn colorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tallaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn estiloDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descuentoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn subTotalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioTotalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productoIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn comboIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn detalleColorIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn detalleTallaIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tallayColorIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn accionesDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isActiveDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn detalleEstiloIdDataGridViewTextBoxColumn;
    }
}