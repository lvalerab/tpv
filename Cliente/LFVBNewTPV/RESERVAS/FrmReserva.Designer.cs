namespace LFVBNewTPV.RESERVAS
{
    partial class FrmReserva
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cBarraHerramientas1 = new CTCBASE.cBarraHerramientas();
            this.BtnGuardarReserva = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.BtnBuscarPersona = new System.Windows.Forms.ToolStripButton();
            this.BtnBuscarArticulo = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.BtnFacturar = new System.Windows.Forms.ToolStripButton();
            this.BtnImprimir = new System.Windows.Forms.ToolStripButton();
            this.BtnSalir = new System.Windows.Forms.ToolStripButton();
            this.DGLineas = new CTGRIDBASE.GRID.DataGridViewBase();
            this.cIdElem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cIdElemProd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CIdElemCare = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cTextoLire = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cCantidadProd = new CTGRIDBASE.GRID.COLUMNAS.DataGridViewNumericColumn();
            this.cPrecioBrutoLire = new CTGRIDBASE.GRID.COLUMNAS.DataGridViewNumericColumn();
            this.CPorcIvaLire = new CTGRIDBASE.GRID.COLUMNAS.DataGridViewNumericColumn();
            this.cPvpLire = new CTGRIDBASE.GRID.COLUMNAS.DataGridViewNumericColumn();
            this.cTotalLire = new CTGRIDBASE.GRID.COLUMNAS.DataGridViewNumericColumn();
            this.cLabelBase1 = new CTCBASE.cLabelBase();
            this.LblIdentificadorCare = new CTCBASE.cLabelBase();
            this.cLabelBase2 = new CTCBASE.cLabelBase();
            this.LblIdentFactura = new CTCBASE.cLabelBase();
            this.cLabelBase4 = new CTCBASE.cLabelBase();
            this.LblFechaGrabacion = new CTCBASE.cLabelBase();
            this.TBoxPrecioVentaIn = new CTCBASE.cNumericBoxBase();
            this.LblPorIvaIn = new CTCBASE.cLabelBase();
            this.TBoxCantidadIn = new CTCBASE.cNumericBoxBase();
            this.LblPrecioBrutoIn = new CTCBASE.cLabelBase();
            this.TBoxTextoLinIn = new CTCBASE.cTextBoxBase();
            this.TBoxRefProdIn = new CTCBASE.cTextBoxBase();
            this.cLabelBase14 = new CTCBASE.cLabelBase();
            this.cLabelBase13 = new CTCBASE.cLabelBase();
            this.cLabelBase12 = new CTCBASE.cLabelBase();
            this.cLabelBase10 = new CTCBASE.cLabelBase();
            this.cLabelBase9 = new CTCBASE.cLabelBase();
            this.cLabelBase8 = new CTCBASE.cLabelBase();
            this.cLabelBase16 = new CTCBASE.cLabelBase();
            this.TBoxIdProd = new CTCBASE.cNumericBoxBase();
            this.LblTotalDocu = new CTCBASE.cLabelBase();
            this.cLabelBase17 = new CTCBASE.cLabelBase();
            this.LblTotalBruto = new CTCBASE.cLabelBase();
            this.cLabelBase15 = new CTCBASE.cLabelBase();
            this.cLabelBase18 = new CTCBASE.cLabelBase();
            this.LblDireccion2Cliente = new CTCBASE.cLabelBase();
            this.LblDireccionCliente = new CTCBASE.cLabelBase();
            this.LblNifCliente = new CTCBASE.cLabelBase();
            this.LblIdCliente = new CTCBASE.cLabelBase();
            this.cLabelBase3 = new CTCBASE.cLabelBase();
            this.LblNombreCliente = new CTCBASE.cLabelBase();
            this.cLabelBase5 = new CTCBASE.cLabelBase();
            this.cLabelBase6 = new CTCBASE.cLabelBase();
            this.cLabelBase7 = new CTCBASE.cLabelBase();
            this.cLabelBase11 = new CTCBASE.cLabelBase();
            this.CmbCodEsre = new CTCBASE.cComboBoxBase();
            this.cLabelBase19 = new CTCBASE.cLabelBase();
            this.TBoxIdCado = new CTCBASE.cNumericBoxBase();
            this.BtnGuardarLinea = new CTCBASE.cBoton();
            this.cBarraHerramientas1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGLineas)).BeginInit();
            this.SuspendLayout();
            // 
            // cBarraHerramientas1
            // 
            this.cBarraHerramientas1.AutoSize = false;
            this.cBarraHerramientas1.color_final = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.cBarraHerramientas1.color_inicial = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cBarraHerramientas1.Dock = System.Windows.Forms.DockStyle.Right;
            this.cBarraHerramientas1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.cBarraHerramientas1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BtnGuardarReserva,
            this.toolStripSeparator1,
            this.BtnBuscarPersona,
            this.BtnBuscarArticulo,
            this.toolStripSeparator2,
            this.BtnFacturar,
            this.BtnImprimir,
            this.BtnSalir});
            this.cBarraHerramientas1.Location = new System.Drawing.Point(886, 0);
            this.cBarraHerramientas1.Name = "cBarraHerramientas1";
            this.cBarraHerramientas1.Size = new System.Drawing.Size(100, 495);
            this.cBarraHerramientas1.TabIndex = 0;
            this.cBarraHerramientas1.Text = "cBarraHerramientas1";
            // 
            // BtnGuardarReserva
            // 
            this.BtnGuardarReserva.Image = global::LFVBNewTPV.Properties.Resources.disk_blue1;
            this.BtnGuardarReserva.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.BtnGuardarReserva.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnGuardarReserva.Name = "BtnGuardarReserva";
            this.BtnGuardarReserva.Size = new System.Drawing.Size(98, 67);
            this.BtnGuardarReserva.Text = "&Guardar";
            this.BtnGuardarReserva.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnGuardarReserva.Click += new System.EventHandler(this.BtnGuardarReserva_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(98, 6);
            // 
            // BtnBuscarPersona
            // 
            this.BtnBuscarPersona.Image = global::LFVBNewTPV.Properties.Resources.businessman1;
            this.BtnBuscarPersona.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.BtnBuscarPersona.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnBuscarPersona.Name = "BtnBuscarPersona";
            this.BtnBuscarPersona.Size = new System.Drawing.Size(98, 67);
            this.BtnBuscarPersona.Text = "Buscar &Persona";
            this.BtnBuscarPersona.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnBuscarPersona.Click += new System.EventHandler(this.BtnBuscarPersona_Click);
            // 
            // BtnBuscarArticulo
            // 
            this.BtnBuscarArticulo.Image = global::LFVBNewTPV.Properties.Resources.box;
            this.BtnBuscarArticulo.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.BtnBuscarArticulo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnBuscarArticulo.Name = "BtnBuscarArticulo";
            this.BtnBuscarArticulo.Size = new System.Drawing.Size(98, 67);
            this.BtnBuscarArticulo.Text = "Buscar &Articulo";
            this.BtnBuscarArticulo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnBuscarArticulo.Click += new System.EventHandler(this.BtnBuscarArticulo_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(98, 6);
            // 
            // BtnFacturar
            // 
            this.BtnFacturar.Image = global::LFVBNewTPV.Properties.Resources.money21;
            this.BtnFacturar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.BtnFacturar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnFacturar.Name = "BtnFacturar";
            this.BtnFacturar.Size = new System.Drawing.Size(98, 67);
            this.BtnFacturar.Text = "&Facturar";
            this.BtnFacturar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnFacturar.Click += new System.EventHandler(this.BtnFacturar_Click);
            // 
            // BtnImprimir
            // 
            this.BtnImprimir.Image = global::LFVBNewTPV.Properties.Resources.printer2;
            this.BtnImprimir.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.BtnImprimir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnImprimir.Name = "BtnImprimir";
            this.BtnImprimir.Size = new System.Drawing.Size(98, 67);
            this.BtnImprimir.Text = "&Imprimir";
            this.BtnImprimir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnImprimir.Click += new System.EventHandler(this.BtnImprimir_Click);
            // 
            // BtnSalir
            // 
            this.BtnSalir.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.BtnSalir.Image = global::LFVBNewTPV.Properties.Resources.delete2;
            this.BtnSalir.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.BtnSalir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(98, 67);
            this.BtnSalir.Text = "&Salir";
            this.BtnSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // DGLineas
            // 
            this.DGLineas.AllowUserToAddRows = false;
            this.DGLineas.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DGLineas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DGLineas.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.DGLineas.ColorOrdenAscendente = System.Drawing.Color.Empty;
            this.DGLineas.ColorOrdenDescendente = System.Drawing.Color.Empty;
            this.DGLineas.ColumnasFijadasSalto = null;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGLineas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DGLineas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGLineas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cIdElem,
            this.cIdElemProd,
            this.CIdElemCare,
            this.cTextoLire,
            this.cCantidadProd,
            this.cPrecioBrutoLire,
            this.CPorcIvaLire,
            this.cPvpLire,
            this.cTotalLire});
            this.DGLineas.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke;
            this.DGLineas.EnableHeadersVisualStyles = false;
            this.DGLineas.FormularioPadreMdi = null;
            this.DGLineas.Location = new System.Drawing.Point(12, 81);
            this.DGLineas.MostrarMenuContextualDefecto = false;
            this.DGLineas.Name = "DGLineas";
            this.DGLineas.OpcionesMenuContextualUsuario = null;
            this.DGLineas.OrigenDatos = null;
            this.DGLineas.PuedeUsuarioFiltrar = false;
            this.DGLineas.ReadOnly = true;
            this.DGLineas.RowHeadersWidth = 25;
            this.DGLineas.Size = new System.Drawing.Size(529, 254);
            this.DGLineas.TabIndex = 1;
            this.DGLineas.TransaparenciaDialogosGris = ((short)(100));
            // 
            // cIdElem
            // 
            this.cIdElem.DataPropertyName = "ID_ELEM";
            this.cIdElem.HeaderText = "ID";
            this.cIdElem.Name = "cIdElem";
            this.cIdElem.ReadOnly = true;
            this.cIdElem.Visible = false;
            // 
            // cIdElemProd
            // 
            this.cIdElemProd.DataPropertyName = "ID_ELEM_PROD";
            this.cIdElemProd.HeaderText = "ID. Prod";
            this.cIdElemProd.Name = "cIdElemProd";
            this.cIdElemProd.ReadOnly = true;
            this.cIdElemProd.Visible = false;
            // 
            // CIdElemCare
            // 
            this.CIdElemCare.DataPropertyName = "ID_ELEM_CARE";
            this.CIdElemCare.HeaderText = "ID. Care";
            this.CIdElemCare.Name = "CIdElemCare";
            this.CIdElemCare.ReadOnly = true;
            this.CIdElemCare.Visible = false;
            // 
            // cTextoLire
            // 
            this.cTextoLire.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cTextoLire.DataPropertyName = "DESCRIPCION_PROD";
            this.cTextoLire.HeaderText = "Texto";
            this.cTextoLire.Name = "cTextoLire";
            this.cTextoLire.ReadOnly = true;
            // 
            // cCantidadProd
            // 
            this.cCantidadProd.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.cCantidadProd.ColorNegativos = System.Drawing.Color.Empty;
            this.cCantidadProd.ColorPositivos = System.Drawing.Color.Empty;
            this.cCantidadProd.DataPropertyName = "CANTIDAD_PROD";
            this.cCantidadProd.HeaderText = "Cantidad";
            this.cCantidadProd.MarcarNegativos = false;
            this.cCantidadProd.MarcarPositivos = false;
            this.cCantidadProd.Name = "cCantidadProd";
            this.cCantidadProd.ReadOnly = true;
            this.cCantidadProd.Width = 55;
            // 
            // cPrecioBrutoLire
            // 
            this.cPrecioBrutoLire.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.cPrecioBrutoLire.ColorNegativos = System.Drawing.Color.Empty;
            this.cPrecioBrutoLire.ColorPositivos = System.Drawing.Color.Empty;
            this.cPrecioBrutoLire.DataPropertyName = "PVB_LIRE";
            this.cPrecioBrutoLire.HeaderText = "Precio bruto";
            this.cPrecioBrutoLire.MarcarNegativos = false;
            this.cPrecioBrutoLire.MarcarPositivos = false;
            this.cPrecioBrutoLire.Name = "cPrecioBrutoLire";
            this.cPrecioBrutoLire.ReadOnly = true;
            this.cPrecioBrutoLire.Width = 70;
            // 
            // CPorcIvaLire
            // 
            this.CPorcIvaLire.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.CPorcIvaLire.ColorNegativos = System.Drawing.Color.Empty;
            this.CPorcIvaLire.ColorPositivos = System.Drawing.Color.Empty;
            this.CPorcIvaLire.DataPropertyName = "PORC_IVA_LIRE";
            this.CPorcIvaLire.HeaderText = "% IVA";
            this.CPorcIvaLire.MarcarNegativos = false;
            this.CPorcIvaLire.MarcarPositivos = false;
            this.CPorcIvaLire.Name = "CPorcIvaLire";
            this.CPorcIvaLire.ReadOnly = true;
            this.CPorcIvaLire.Width = 41;
            // 
            // cPvpLire
            // 
            this.cPvpLire.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.cPvpLire.ColorNegativos = System.Drawing.Color.Empty;
            this.cPvpLire.ColorPositivos = System.Drawing.Color.Empty;
            this.cPvpLire.DataPropertyName = "PVP_LIRE";
            this.cPvpLire.HeaderText = "PVP";
            this.cPvpLire.MarcarNegativos = false;
            this.cPvpLire.MarcarPositivos = false;
            this.cPvpLire.Name = "cPvpLire";
            this.cPvpLire.ReadOnly = true;
            this.cPvpLire.Width = 34;
            // 
            // cTotalLire
            // 
            this.cTotalLire.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.cTotalLire.ColorNegativos = System.Drawing.Color.Empty;
            this.cTotalLire.ColorPositivos = System.Drawing.Color.Empty;
            this.cTotalLire.DataPropertyName = "TOTAL_LIRE";
            this.cTotalLire.HeaderText = "Total";
            this.cTotalLire.MarcarNegativos = false;
            this.cTotalLire.MarcarPositivos = false;
            this.cTotalLire.Name = "cTotalLire";
            this.cTotalLire.ReadOnly = true;
            this.cTotalLire.Width = 37;
            // 
            // cLabelBase1
            // 
            this.cLabelBase1.BackColor = System.Drawing.Color.Transparent;
            this.cLabelBase1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.cLabelBase1.Location = new System.Drawing.Point(12, 9);
            this.cLabelBase1.Name = "cLabelBase1";
            this.cLabelBase1.Size = new System.Drawing.Size(142, 27);
            this.cLabelBase1.TabIndex = 2;
            this.cLabelBase1.Text = "Identificador";
            // 
            // LblIdentificadorCare
            // 
            this.LblIdentificadorCare.BackColor = System.Drawing.Color.Transparent;
            this.LblIdentificadorCare.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.LblIdentificadorCare.Location = new System.Drawing.Point(12, 36);
            this.LblIdentificadorCare.Name = "LblIdentificadorCare";
            this.LblIdentificadorCare.Size = new System.Drawing.Size(164, 25);
            this.LblIdentificadorCare.TabIndex = 3;
            this.LblIdentificadorCare.Text = "Identificador";
            // 
            // cLabelBase2
            // 
            this.cLabelBase2.BackColor = System.Drawing.Color.Transparent;
            this.cLabelBase2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.cLabelBase2.Location = new System.Drawing.Point(201, 9);
            this.cLabelBase2.Name = "cLabelBase2";
            this.cLabelBase2.Size = new System.Drawing.Size(179, 27);
            this.cLabelBase2.TabIndex = 4;
            this.cLabelBase2.Text = "Nº Doc Factura";
            // 
            // LblIdentFactura
            // 
            this.LblIdentFactura.BackColor = System.Drawing.Color.Transparent;
            this.LblIdentFactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.LblIdentFactura.Location = new System.Drawing.Point(201, 36);
            this.LblIdentFactura.Name = "LblIdentFactura";
            this.LblIdentFactura.Size = new System.Drawing.Size(234, 25);
            this.LblIdentFactura.TabIndex = 5;
            this.LblIdentFactura.Text = "Nº Doc Factura";
            // 
            // cLabelBase4
            // 
            this.cLabelBase4.BackColor = System.Drawing.Color.Transparent;
            this.cLabelBase4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.cLabelBase4.Location = new System.Drawing.Point(458, 9);
            this.cLabelBase4.Name = "cLabelBase4";
            this.cLabelBase4.Size = new System.Drawing.Size(155, 27);
            this.cLabelBase4.TabIndex = 6;
            this.cLabelBase4.Text = "Fecha solicitud";
            // 
            // LblFechaGrabacion
            // 
            this.LblFechaGrabacion.BackColor = System.Drawing.Color.Transparent;
            this.LblFechaGrabacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.LblFechaGrabacion.Location = new System.Drawing.Point(458, 36);
            this.LblFechaGrabacion.Name = "LblFechaGrabacion";
            this.LblFechaGrabacion.Size = new System.Drawing.Size(162, 25);
            this.LblFechaGrabacion.TabIndex = 7;
            this.LblFechaGrabacion.Text = "00/00/0000";
            // 
            // TBoxPrecioVentaIn
            // 
            this.TBoxPrecioVentaIn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TBoxPrecioVentaIn.ColorNegativos = System.Drawing.Color.Empty;
            this.TBoxPrecioVentaIn.ColorPositivos = System.Drawing.Color.Empty;
            this.TBoxPrecioVentaIn.Decimales = ((short)(0));
            this.TBoxPrecioVentaIn.Location = new System.Drawing.Point(718, 365);
            this.TBoxPrecioVentaIn.MarcarNegativos = false;
            this.TBoxPrecioVentaIn.MarcarPositivos = false;
            this.TBoxPrecioVentaIn.Name = "TBoxPrecioVentaIn";
            this.TBoxPrecioVentaIn.PonerValorDefecto = false;
            this.TBoxPrecioVentaIn.Size = new System.Drawing.Size(96, 20);
            this.TBoxPrecioVentaIn.TabIndex = 44;
            this.TBoxPrecioVentaIn.Text = "0";
            this.TBoxPrecioVentaIn.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TBoxPrecioVentaIn.ValorDefecto = 0;
            // 
            // LblPorIvaIn
            // 
            this.LblPorIvaIn.AutoSize = true;
            this.LblPorIvaIn.BackColor = System.Drawing.Color.Transparent;
            this.LblPorIvaIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPorIvaIn.Location = new System.Drawing.Point(651, 365);
            this.LblPorIvaIn.Name = "LblPorIvaIn";
            this.LblPorIvaIn.Size = new System.Drawing.Size(40, 20);
            this.LblPorIvaIn.TabIndex = 43;
            this.LblPorIvaIn.Text = "0.00";
            // 
            // TBoxCantidadIn
            // 
            this.TBoxCantidadIn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TBoxCantidadIn.ColorNegativos = System.Drawing.Color.Empty;
            this.TBoxCantidadIn.ColorPositivos = System.Drawing.Color.Empty;
            this.TBoxCantidadIn.Decimales = ((short)(0));
            this.TBoxCantidadIn.Location = new System.Drawing.Point(551, 368);
            this.TBoxCantidadIn.MarcarNegativos = false;
            this.TBoxCantidadIn.MarcarPositivos = false;
            this.TBoxCantidadIn.Name = "TBoxCantidadIn";
            this.TBoxCantidadIn.PonerValorDefecto = false;
            this.TBoxCantidadIn.Size = new System.Drawing.Size(69, 20);
            this.TBoxCantidadIn.TabIndex = 42;
            this.TBoxCantidadIn.Text = "0";
            this.TBoxCantidadIn.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TBoxCantidadIn.ValorDefecto = 0;
            this.TBoxCantidadIn.Enter += new System.EventHandler(this.TBoxCantidadIn_Enter);
            // 
            // LblPrecioBrutoIn
            // 
            this.LblPrecioBrutoIn.AutoSize = true;
            this.LblPrecioBrutoIn.BackColor = System.Drawing.Color.Transparent;
            this.LblPrecioBrutoIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPrecioBrutoIn.Location = new System.Drawing.Point(485, 368);
            this.LblPrecioBrutoIn.Name = "LblPrecioBrutoIn";
            this.LblPrecioBrutoIn.Size = new System.Drawing.Size(40, 20);
            this.LblPrecioBrutoIn.TabIndex = 41;
            this.LblPrecioBrutoIn.Text = "0.00";
            this.LblPrecioBrutoIn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TBoxTextoLinIn
            // 
            this.TBoxTextoLinIn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TBoxTextoLinIn.Location = new System.Drawing.Point(175, 368);
            this.TBoxTextoLinIn.Name = "TBoxTextoLinIn";
            this.TBoxTextoLinIn.Size = new System.Drawing.Size(237, 20);
            this.TBoxTextoLinIn.TabIndex = 40;
            // 
            // TBoxRefProdIn
            // 
            this.TBoxRefProdIn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TBoxRefProdIn.Location = new System.Drawing.Point(16, 368);
            this.TBoxRefProdIn.Name = "TBoxRefProdIn";
            this.TBoxRefProdIn.Size = new System.Drawing.Size(147, 20);
            this.TBoxRefProdIn.TabIndex = 39;
            this.TBoxRefProdIn.Validating += new System.ComponentModel.CancelEventHandler(this.TBoxRefProdIn_Validating);
            // 
            // cLabelBase14
            // 
            this.cLabelBase14.AutoSize = true;
            this.cLabelBase14.BackColor = System.Drawing.Color.Transparent;
            this.cLabelBase14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cLabelBase14.Location = new System.Drawing.Point(637, 345);
            this.cLabelBase14.Name = "cLabelBase14";
            this.cLabelBase14.Size = new System.Drawing.Size(54, 20);
            this.cLabelBase14.TabIndex = 38;
            this.cLabelBase14.Text = "% IVA";
            // 
            // cLabelBase13
            // 
            this.cLabelBase13.AutoSize = true;
            this.cLabelBase13.BackColor = System.Drawing.Color.Transparent;
            this.cLabelBase13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cLabelBase13.Location = new System.Drawing.Point(547, 345);
            this.cLabelBase13.Name = "cLabelBase13";
            this.cLabelBase13.Size = new System.Drawing.Size(73, 20);
            this.cLabelBase13.TabIndex = 37;
            this.cLabelBase13.Text = "Cantidad";
            // 
            // cLabelBase12
            // 
            this.cLabelBase12.AutoSize = true;
            this.cLabelBase12.BackColor = System.Drawing.Color.Transparent;
            this.cLabelBase12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cLabelBase12.Location = new System.Drawing.Point(429, 345);
            this.cLabelBase12.Name = "cLabelBase12";
            this.cLabelBase12.Size = new System.Drawing.Size(96, 20);
            this.cLabelBase12.TabIndex = 36;
            this.cLabelBase12.Text = "Precio Bruto";
            // 
            // cLabelBase10
            // 
            this.cLabelBase10.AutoSize = true;
            this.cLabelBase10.BackColor = System.Drawing.Color.Transparent;
            this.cLabelBase10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cLabelBase10.Location = new System.Drawing.Point(714, 345);
            this.cLabelBase10.Name = "cLabelBase10";
            this.cLabelBase10.Size = new System.Drawing.Size(100, 20);
            this.cLabelBase10.TabIndex = 35;
            this.cLabelBase10.Text = "Precio Venta";
            // 
            // cLabelBase9
            // 
            this.cLabelBase9.AutoSize = true;
            this.cLabelBase9.BackColor = System.Drawing.Color.Transparent;
            this.cLabelBase9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cLabelBase9.Location = new System.Drawing.Point(173, 345);
            this.cLabelBase9.Name = "cLabelBase9";
            this.cLabelBase9.Size = new System.Drawing.Size(91, 20);
            this.cLabelBase9.TabIndex = 34;
            this.cLabelBase9.Text = "Texto Linea";
            // 
            // cLabelBase8
            // 
            this.cLabelBase8.AutoSize = true;
            this.cLabelBase8.BackColor = System.Drawing.Color.Transparent;
            this.cLabelBase8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cLabelBase8.Location = new System.Drawing.Point(12, 345);
            this.cLabelBase8.Name = "cLabelBase8";
            this.cLabelBase8.Size = new System.Drawing.Size(110, 20);
            this.cLabelBase8.TabIndex = 33;
            this.cLabelBase8.Text = "Código Barras";
            // 
            // cLabelBase16
            // 
            this.cLabelBase16.AutoSize = true;
            this.cLabelBase16.BackColor = System.Drawing.Color.Transparent;
            this.cLabelBase16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cLabelBase16.Location = new System.Drawing.Point(16, 401);
            this.cLabelBase16.Name = "cLabelBase16";
            this.cLabelBase16.Size = new System.Drawing.Size(76, 20);
            this.cLabelBase16.TabIndex = 46;
            this.cLabelBase16.Text = "ID PROD";
            this.cLabelBase16.Visible = false;
            // 
            // TBoxIdProd
            // 
            this.TBoxIdProd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TBoxIdProd.ColorNegativos = System.Drawing.Color.Empty;
            this.TBoxIdProd.ColorPositivos = System.Drawing.Color.Empty;
            this.TBoxIdProd.Decimales = ((short)(0));
            this.TBoxIdProd.Location = new System.Drawing.Point(16, 424);
            this.TBoxIdProd.MarcarNegativos = false;
            this.TBoxIdProd.MarcarPositivos = false;
            this.TBoxIdProd.Name = "TBoxIdProd";
            this.TBoxIdProd.PonerValorDefecto = false;
            this.TBoxIdProd.Size = new System.Drawing.Size(100, 20);
            this.TBoxIdProd.TabIndex = 45;
            this.TBoxIdProd.Text = "0";
            this.TBoxIdProd.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TBoxIdProd.ValorDefecto = 0;
            this.TBoxIdProd.Visible = false;
            // 
            // LblTotalDocu
            // 
            this.LblTotalDocu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.LblTotalDocu.BackColor = System.Drawing.Color.Transparent;
            this.LblTotalDocu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTotalDocu.Location = new System.Drawing.Point(749, 433);
            this.LblTotalDocu.Name = "LblTotalDocu";
            this.LblTotalDocu.Size = new System.Drawing.Size(135, 20);
            this.LblTotalDocu.TabIndex = 50;
            this.LblTotalDocu.Text = "0.00 €";
            this.LblTotalDocu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cLabelBase17
            // 
            this.cLabelBase17.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cLabelBase17.AutoSize = true;
            this.cLabelBase17.BackColor = System.Drawing.Color.Transparent;
            this.cLabelBase17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cLabelBase17.Location = new System.Drawing.Point(564, 433);
            this.cLabelBase17.Name = "cLabelBase17";
            this.cLabelBase17.Size = new System.Drawing.Size(179, 20);
            this.cLabelBase17.TabIndex = 49;
            this.cLabelBase17.Text = "Precio Total Documento";
            // 
            // LblTotalBruto
            // 
            this.LblTotalBruto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.LblTotalBruto.BackColor = System.Drawing.Color.Transparent;
            this.LblTotalBruto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTotalBruto.Location = new System.Drawing.Point(749, 413);
            this.LblTotalBruto.Name = "LblTotalBruto";
            this.LblTotalBruto.Size = new System.Drawing.Size(135, 20);
            this.LblTotalBruto.TabIndex = 48;
            this.LblTotalBruto.Text = "0.00 €";
            this.LblTotalBruto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cLabelBase15
            // 
            this.cLabelBase15.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cLabelBase15.AutoSize = true;
            this.cLabelBase15.BackColor = System.Drawing.Color.Transparent;
            this.cLabelBase15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cLabelBase15.Location = new System.Drawing.Point(564, 413);
            this.cLabelBase15.Name = "cLabelBase15";
            this.cLabelBase15.Size = new System.Drawing.Size(135, 20);
            this.cLabelBase15.TabIndex = 47;
            this.cLabelBase15.Text = "Precio Total Bruto";
            // 
            // cLabelBase18
            // 
            this.cLabelBase18.AutoSize = true;
            this.cLabelBase18.BackColor = System.Drawing.Color.Transparent;
            this.cLabelBase18.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cLabelBase18.Location = new System.Drawing.Point(543, 81);
            this.cLabelBase18.Name = "cLabelBase18";
            this.cLabelBase18.Size = new System.Drawing.Size(148, 24);
            this.cLabelBase18.TabIndex = 60;
            this.cLabelBase18.Text = "Datos del cliente";
            // 
            // LblDireccion2Cliente
            // 
            this.LblDireccion2Cliente.AutoSize = true;
            this.LblDireccion2Cliente.BackColor = System.Drawing.Color.Transparent;
            this.LblDireccion2Cliente.Location = new System.Drawing.Point(544, 266);
            this.LblDireccion2Cliente.Name = "LblDireccion2Cliente";
            this.LblDireccion2Cliente.Size = new System.Drawing.Size(96, 13);
            this.LblDireccion2Cliente.TabIndex = 59;
            this.LblDireccion2Cliente.Text = "Direccion 2 Cliente";
            // 
            // LblDireccionCliente
            // 
            this.LblDireccionCliente.AutoSize = true;
            this.LblDireccionCliente.BackColor = System.Drawing.Color.Transparent;
            this.LblDireccionCliente.Location = new System.Drawing.Point(544, 239);
            this.LblDireccionCliente.Name = "LblDireccionCliente";
            this.LblDireccionCliente.Size = new System.Drawing.Size(87, 13);
            this.LblDireccionCliente.TabIndex = 58;
            this.LblDireccionCliente.Text = "Direccion Cliente";
            // 
            // LblNifCliente
            // 
            this.LblNifCliente.AutoSize = true;
            this.LblNifCliente.BackColor = System.Drawing.Color.Transparent;
            this.LblNifCliente.Location = new System.Drawing.Point(690, 132);
            this.LblNifCliente.Name = "LblNifCliente";
            this.LblNifCliente.Size = new System.Drawing.Size(54, 13);
            this.LblNifCliente.TabIndex = 57;
            this.LblNifCliente.Text = "Id. Cliente";
            // 
            // LblIdCliente
            // 
            this.LblIdCliente.AutoSize = true;
            this.LblIdCliente.BackColor = System.Drawing.Color.Transparent;
            this.LblIdCliente.Location = new System.Drawing.Point(544, 132);
            this.LblIdCliente.Name = "LblIdCliente";
            this.LblIdCliente.Size = new System.Drawing.Size(54, 13);
            this.LblIdCliente.TabIndex = 56;
            this.LblIdCliente.Text = "Id. Cliente";
            // 
            // cLabelBase3
            // 
            this.cLabelBase3.AutoSize = true;
            this.cLabelBase3.BackColor = System.Drawing.Color.Transparent;
            this.cLabelBase3.Location = new System.Drawing.Point(544, 210);
            this.cLabelBase3.Name = "cLabelBase3";
            this.cLabelBase3.Size = new System.Drawing.Size(87, 13);
            this.cLabelBase3.TabIndex = 55;
            this.cLabelBase3.Text = "Dirección Cliente";
            // 
            // LblNombreCliente
            // 
            this.LblNombreCliente.AutoSize = true;
            this.LblNombreCliente.BackColor = System.Drawing.Color.Transparent;
            this.LblNombreCliente.Location = new System.Drawing.Point(544, 181);
            this.LblNombreCliente.Name = "LblNombreCliente";
            this.LblNombreCliente.Size = new System.Drawing.Size(79, 13);
            this.LblNombreCliente.TabIndex = 54;
            this.LblNombreCliente.Text = "Nombre Cliente";
            // 
            // cLabelBase5
            // 
            this.cLabelBase5.AutoSize = true;
            this.cLabelBase5.BackColor = System.Drawing.Color.Transparent;
            this.cLabelBase5.Location = new System.Drawing.Point(543, 157);
            this.cLabelBase5.Name = "cLabelBase5";
            this.cLabelBase5.Size = new System.Drawing.Size(79, 13);
            this.cLabelBase5.TabIndex = 53;
            this.cLabelBase5.Text = "Nombre Cliente";
            // 
            // cLabelBase6
            // 
            this.cLabelBase6.AutoSize = true;
            this.cLabelBase6.BackColor = System.Drawing.Color.Transparent;
            this.cLabelBase6.Location = new System.Drawing.Point(690, 108);
            this.cLabelBase6.Name = "cLabelBase6";
            this.cLabelBase6.Size = new System.Drawing.Size(65, 13);
            this.cLabelBase6.TabIndex = 52;
            this.cLabelBase6.Text = "N.I.F Cliente";
            // 
            // cLabelBase7
            // 
            this.cLabelBase7.AutoSize = true;
            this.cLabelBase7.BackColor = System.Drawing.Color.Transparent;
            this.cLabelBase7.Location = new System.Drawing.Point(544, 108);
            this.cLabelBase7.Name = "cLabelBase7";
            this.cLabelBase7.Size = new System.Drawing.Size(54, 13);
            this.cLabelBase7.TabIndex = 51;
            this.cLabelBase7.Text = "Id. Cliente";
            // 
            // cLabelBase11
            // 
            this.cLabelBase11.BackColor = System.Drawing.Color.Transparent;
            this.cLabelBase11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.cLabelBase11.Location = new System.Drawing.Point(637, 9);
            this.cLabelBase11.Name = "cLabelBase11";
            this.cLabelBase11.Size = new System.Drawing.Size(155, 27);
            this.cLabelBase11.TabIndex = 61;
            this.cLabelBase11.Text = "Estado Solicitud";
            // 
            // CmbCodEsre
            // 
            this.CmbCodEsre.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.CmbCodEsre.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CmbCodEsre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbCodEsre.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CmbCodEsre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.CmbCodEsre.FormattingEnabled = true;
            this.CmbCodEsre.Location = new System.Drawing.Point(641, 33);
            this.CmbCodEsre.Name = "CmbCodEsre";
            this.CmbCodEsre.Size = new System.Drawing.Size(168, 32);
            this.CmbCodEsre.TabIndex = 62;
            // 
            // cLabelBase19
            // 
            this.cLabelBase19.AutoSize = true;
            this.cLabelBase19.BackColor = System.Drawing.Color.Transparent;
            this.cLabelBase19.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cLabelBase19.Location = new System.Drawing.Point(141, 401);
            this.cLabelBase19.Name = "cLabelBase19";
            this.cLabelBase19.Size = new System.Drawing.Size(76, 20);
            this.cLabelBase19.TabIndex = 64;
            this.cLabelBase19.Text = "ID CADO";
            this.cLabelBase19.Visible = false;
            // 
            // TBoxIdCado
            // 
            this.TBoxIdCado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TBoxIdCado.ColorNegativos = System.Drawing.Color.Empty;
            this.TBoxIdCado.ColorPositivos = System.Drawing.Color.Empty;
            this.TBoxIdCado.Decimales = ((short)(0));
            this.TBoxIdCado.Location = new System.Drawing.Point(141, 424);
            this.TBoxIdCado.MarcarNegativos = false;
            this.TBoxIdCado.MarcarPositivos = false;
            this.TBoxIdCado.Name = "TBoxIdCado";
            this.TBoxIdCado.PonerValorDefecto = false;
            this.TBoxIdCado.Size = new System.Drawing.Size(100, 20);
            this.TBoxIdCado.TabIndex = 63;
            this.TBoxIdCado.Text = "0";
            this.TBoxIdCado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TBoxIdCado.ValorDefecto = 0;
            this.TBoxIdCado.Visible = false;
            // 
            // BtnGuardarLinea
            // 
            this.BtnGuardarLinea.BackColor = System.Drawing.Color.Transparent;
            this.BtnGuardarLinea.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnGuardarLinea.Image = global::LFVBNewTPV.Properties.Resources.disk_blue2;
            this.BtnGuardarLinea.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnGuardarLinea.Location = new System.Drawing.Point(820, 355);
            this.BtnGuardarLinea.Name = "BtnGuardarLinea";
            this.BtnGuardarLinea.Size = new System.Drawing.Size(35, 36);
            this.BtnGuardarLinea.TabIndex = 65;
            this.BtnGuardarLinea.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnGuardarLinea.UseVisualStyleBackColor = true;
            this.BtnGuardarLinea.Click += new System.EventHandler(this.BtnGuardarLinea_Click);
            // 
            // FrmReserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(986, 495);
            this.Controls.Add(this.BtnGuardarLinea);
            this.Controls.Add(this.cLabelBase19);
            this.Controls.Add(this.TBoxIdCado);
            this.Controls.Add(this.CmbCodEsre);
            this.Controls.Add(this.cLabelBase11);
            this.Controls.Add(this.cLabelBase18);
            this.Controls.Add(this.LblDireccion2Cliente);
            this.Controls.Add(this.LblDireccionCliente);
            this.Controls.Add(this.LblNifCliente);
            this.Controls.Add(this.LblIdCliente);
            this.Controls.Add(this.cLabelBase3);
            this.Controls.Add(this.LblNombreCliente);
            this.Controls.Add(this.cLabelBase5);
            this.Controls.Add(this.cLabelBase6);
            this.Controls.Add(this.cLabelBase7);
            this.Controls.Add(this.LblTotalDocu);
            this.Controls.Add(this.cLabelBase17);
            this.Controls.Add(this.LblTotalBruto);
            this.Controls.Add(this.cLabelBase15);
            this.Controls.Add(this.cLabelBase16);
            this.Controls.Add(this.TBoxIdProd);
            this.Controls.Add(this.TBoxPrecioVentaIn);
            this.Controls.Add(this.LblPorIvaIn);
            this.Controls.Add(this.TBoxCantidadIn);
            this.Controls.Add(this.LblPrecioBrutoIn);
            this.Controls.Add(this.TBoxTextoLinIn);
            this.Controls.Add(this.TBoxRefProdIn);
            this.Controls.Add(this.cLabelBase14);
            this.Controls.Add(this.cLabelBase13);
            this.Controls.Add(this.cLabelBase12);
            this.Controls.Add(this.cLabelBase10);
            this.Controls.Add(this.cLabelBase9);
            this.Controls.Add(this.cLabelBase8);
            this.Controls.Add(this.LblFechaGrabacion);
            this.Controls.Add(this.cLabelBase4);
            this.Controls.Add(this.LblIdentFactura);
            this.Controls.Add(this.cLabelBase2);
            this.Controls.Add(this.LblIdentificadorCare);
            this.Controls.Add(this.cLabelBase1);
            this.Controls.Add(this.DGLineas);
            this.Controls.Add(this.cBarraHerramientas1);
            this.Name = "FrmReserva";
            this.Text = "Ficha de Reserva";
            this.cBarraHerramientas1.ResumeLayout(false);
            this.cBarraHerramientas1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGLineas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CTCBASE.cBarraHerramientas cBarraHerramientas1;
        private System.Windows.Forms.ToolStripButton BtnGuardarReserva;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton BtnBuscarPersona;
        private System.Windows.Forms.ToolStripButton BtnBuscarArticulo;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton BtnFacturar;
        private System.Windows.Forms.ToolStripButton BtnImprimir;
        private CTGRIDBASE.GRID.DataGridViewBase DGLineas;
        private CTCBASE.cLabelBase cLabelBase1;
        private CTCBASE.cLabelBase LblIdentificadorCare;
        private CTCBASE.cLabelBase cLabelBase2;
        private CTCBASE.cLabelBase LblIdentFactura;
        private CTCBASE.cLabelBase cLabelBase4;
        private CTCBASE.cLabelBase LblFechaGrabacion;
        private CTCBASE.cNumericBoxBase TBoxPrecioVentaIn;
        private CTCBASE.cLabelBase LblPorIvaIn;
        private CTCBASE.cNumericBoxBase TBoxCantidadIn;
        private CTCBASE.cLabelBase LblPrecioBrutoIn;
        private CTCBASE.cTextBoxBase TBoxTextoLinIn;
        private CTCBASE.cTextBoxBase TBoxRefProdIn;
        private CTCBASE.cLabelBase cLabelBase14;
        private CTCBASE.cLabelBase cLabelBase13;
        private CTCBASE.cLabelBase cLabelBase12;
        private CTCBASE.cLabelBase cLabelBase10;
        private CTCBASE.cLabelBase cLabelBase9;
        private CTCBASE.cLabelBase cLabelBase8;
        private CTCBASE.cLabelBase cLabelBase16;
        private CTCBASE.cNumericBoxBase TBoxIdProd;
        private CTCBASE.cLabelBase LblTotalDocu;
        private CTCBASE.cLabelBase cLabelBase17;
        private CTCBASE.cLabelBase LblTotalBruto;
        private CTCBASE.cLabelBase cLabelBase15;
        private CTCBASE.cLabelBase cLabelBase18;
        private CTCBASE.cLabelBase LblDireccion2Cliente;
        private CTCBASE.cLabelBase LblDireccionCliente;
        private CTCBASE.cLabelBase LblNifCliente;
        private CTCBASE.cLabelBase LblIdCliente;
        private CTCBASE.cLabelBase cLabelBase3;
        private CTCBASE.cLabelBase LblNombreCliente;
        private CTCBASE.cLabelBase cLabelBase5;
        private CTCBASE.cLabelBase cLabelBase6;
        private CTCBASE.cLabelBase cLabelBase7;
        private System.Windows.Forms.DataGridViewTextBoxColumn cIdElem;
        private System.Windows.Forms.DataGridViewTextBoxColumn cIdElemProd;
        private System.Windows.Forms.DataGridViewTextBoxColumn CIdElemCare;
        private System.Windows.Forms.DataGridViewTextBoxColumn cTextoLire;
        private CTGRIDBASE.GRID.COLUMNAS.DataGridViewNumericColumn cCantidadProd;
        private CTGRIDBASE.GRID.COLUMNAS.DataGridViewNumericColumn cPrecioBrutoLire;
        private CTGRIDBASE.GRID.COLUMNAS.DataGridViewNumericColumn CPorcIvaLire;
        private CTGRIDBASE.GRID.COLUMNAS.DataGridViewNumericColumn cPvpLire;
        private CTGRIDBASE.GRID.COLUMNAS.DataGridViewNumericColumn cTotalLire;
        private CTCBASE.cLabelBase cLabelBase11;
        private CTCBASE.cComboBoxBase CmbCodEsre;
        private System.Windows.Forms.ToolStripButton BtnSalir;
        private CTCBASE.cLabelBase cLabelBase19;
        private CTCBASE.cNumericBoxBase TBoxIdCado;
        private CTCBASE.cBoton BtnGuardarLinea;
    }
}