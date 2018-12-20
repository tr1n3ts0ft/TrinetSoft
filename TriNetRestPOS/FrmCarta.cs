// Decompiled with JetBrains decompiler
// Type: TriNetRestPOS.FrmCarta
// Assembly: TriNetRestPOS, Version=5.2.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 43377352-E952-4AC1-9BA6-CCBE4AE5F575
// Assembly location: C:\log\TriNetRestPOS.exe

using APP_Utilities;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using TR1_BusinessEntity;
using TR1_BusinessLogic;

namespace TriNetRestPOS
{
  [DesignerGenerated]
  public class FrmCarta : Form
  {
    private IContainer components;
    public bool _SoloBusqueda;
    private int intOperacionDetalle;

    public FrmCarta()
    {
      this.Load += new EventHandler(this.FrmCarta_Load);
      this.KeyDown += new KeyEventHandler(this.FrmCarta_KeyDown);
      this._SoloBusqueda = false;
      this.intOperacionDetalle = 0;
      this.InitializeComponent();
    }

    [DebuggerNonUserCode]
    protected override void Dispose(bool disposing)
    {
      try
      {
        if (!disposing || this.components == null)
          return;
        this.components.Dispose();
      }
      finally
      {
        base.Dispose(disposing);
      }
    }

    [DebuggerStepThrough]
    private void InitializeComponent()
    {
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (FrmCarta));
      this.TabControl_Data = new TabControlEx();
      this.TabPage_Listado = new TabPage();
      this.Panel_ButtonsActions = new Panel();
      this.btnTecladoBuscar = new Button();
      this.btnListo = new Button();
      this.Label_Description = new Label();
      this.Panel_ButtonsTools = new Panel();
      this.btnIrPrimero = new Button();
      this.btnSalir = new Button();
      this.btnIrAnterior = new Button();
      this.btnEliminar = new Button();
      this.btnIrSiguiente = new Button();
      this.btnEditar = new Button();
      this.btnIrUltimo = new Button();
      this.btnNuevo = new Button();
      this.txtBuscar = new TextBox();
      this.dgvCarta = new DataGridView();
      this.TabPage_Detail = new TabPage();
      this.btnAgregarSalon = new Button();
      this.btnEliminarSalon = new Button();
      this.txtSalonId = new TextBox();
      this.txtSalonNombre = new TextBox();
      this.btnBuscarSalon = new Button();
      this.Label14 = new Label();
      this.Label15 = new Label();
      this.dgvSalon = new DataGridView();
      this.Label10 = new Label();
      this.Label11 = new Label();
      this.Label12 = new Label();
      this.Label13 = new Label();
      this.chbActivo = new CheckBox();
      this.Label_IsActive = new Label();
      this.btnAtras = new Button();
      this.btnGuardar = new Button();
      this.btnTecladoNombreCorto = new Button();
      this.txtNombreCorto = new TextBox();
      this.Label_DesShort = new Label();
      this.btnTecladoNombre = new Button();
      this.Label_Des = new Label();
      this.txtNombre = new TextBox();
      this.Label_Id = new Label();
      this.txtCartaId = new TextBox();
      this.TabPage_Productos = new TabPage();
      this.btnGuardar2 = new Button();
      this.btnAgregarItem = new Button();
      this.txtProductId = new TextBox();
      this.btnAtrasItem = new Button();
      this.Label1 = new Label();
      this.Label3 = new Label();
      this.txtProductoNombre = new TextBox();
      this.txtNombreCartaL = new TextBox();
      this.btnEliminarItem = new Button();
      this.btnModificarItem = new Button();
      this.gbPrecios = new GroupBox();
      this.Label2 = new Label();
      this.Label9 = new Label();
      this.txtPrecioSocio = new NumericTextBox.NumericTextBox();
      this.Label8 = new Label();
      this.Label4 = new Label();
      this.Label7 = new Label();
      this.txtPrecioColaborador = new NumericTextBox.NumericTextBox();
      this.txtPrecioPublico = new NumericTextBox.NumericTextBox();
      this.Label6 = new Label();
      this.dgvCartaDetalle = new DataGridView();
      this.Label5 = new Label();
      this.btnBuscarProducto = new Button();
      this.Label_Product = new Label();
      this.ToolStripStatusLabel_Operation = new ToolStripStatusLabel();
      this.StatusStrip_Properties = new StatusStrip();
      this.Tssl_Record = new ToolStripStatusLabel();
      ((Control) this.TabControl_Data).SuspendLayout();
      this.TabPage_Listado.SuspendLayout();
      this.Panel_ButtonsActions.SuspendLayout();
      this.Panel_ButtonsTools.SuspendLayout();
      ((ISupportInitialize) this.dgvCarta).BeginInit();
      this.TabPage_Detail.SuspendLayout();
      ((ISupportInitialize) this.dgvSalon).BeginInit();
      this.TabPage_Productos.SuspendLayout();
      this.gbPrecios.SuspendLayout();
      ((ISupportInitialize) this.dgvCartaDetalle).BeginInit();
      this.StatusStrip_Properties.SuspendLayout();
      this.SuspendLayout();
      ((Control) this.TabControl_Data).Controls.Add((Control) this.TabPage_Listado);
      ((Control) this.TabControl_Data).Controls.Add((Control) this.TabPage_Detail);
      ((Control) this.TabControl_Data).Controls.Add((Control) this.TabPage_Productos);
      ((Control) this.TabControl_Data).Dock = DockStyle.Fill;
      ((Control) this.TabControl_Data).Font = new Font("Trebuchet MS", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      ((Control) this.TabControl_Data).Location = new Point(0, 0);
      ((Control) this.TabControl_Data).Margin = new Padding(4, 5, 4, 5);
      ((Control) this.TabControl_Data).Name = "TabControl_Data";
      ((TabControl) this.TabControl_Data).SelectedIndex = 0;
      ((Control) this.TabControl_Data).Size = new Size(637, 677);
      ((Control) this.TabControl_Data).TabIndex = 165;
      this.TabPage_Listado.Controls.Add((Control) this.Panel_ButtonsActions);
      this.TabPage_Listado.Controls.Add((Control) this.Label_Description);
      this.TabPage_Listado.Controls.Add((Control) this.Panel_ButtonsTools);
      this.TabPage_Listado.Controls.Add((Control) this.txtBuscar);
      this.TabPage_Listado.Controls.Add((Control) this.dgvCarta);
      this.TabPage_Listado.Font = new Font("Verdana", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.TabPage_Listado.Location = new Point(4, 29);
      this.TabPage_Listado.Margin = new Padding(4, 5, 4, 5);
      this.TabPage_Listado.Name = "TabPage_Listado";
      this.TabPage_Listado.Padding = new Padding(4, 5, 4, 5);
      this.TabPage_Listado.Size = new Size(629, 644);
      this.TabPage_Listado.TabIndex = 0;
      this.TabPage_Listado.Text = "Listado";
      this.TabPage_Listado.UseVisualStyleBackColor = true;
      this.Panel_ButtonsActions.Controls.Add((Control) this.btnTecladoBuscar);
      this.Panel_ButtonsActions.Controls.Add((Control) this.btnListo);
      this.Panel_ButtonsActions.Location = new Point(381, 0);
      this.Panel_ButtonsActions.Margin = new Padding(4, 5, 4, 5);
      this.Panel_ButtonsActions.Name = "Panel_ButtonsActions";
      this.Panel_ButtonsActions.Size = new Size(167, 62);
      this.Panel_ButtonsActions.TabIndex = 162;
      this.btnTecladoBuscar.Font = new Font("Trebuchet MS", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.btnTecladoBuscar.ForeColor = Color.MediumBlue;
      this.btnTecladoBuscar.Image = (Image) componentResourceManager.GetObject("btnTecladoBuscar.Image");
      this.btnTecladoBuscar.ImageAlign = ContentAlignment.BottomCenter;
      this.btnTecladoBuscar.Location = new Point(1, 1);
      this.btnTecladoBuscar.Margin = new Padding(4, 5, 4, 5);
      this.btnTecladoBuscar.Name = "btnTecladoBuscar";
      this.btnTecladoBuscar.Size = new Size(83, 60);
      this.btnTecladoBuscar.TabIndex = 2;
      this.btnTecladoBuscar.TextAlign = ContentAlignment.TopCenter;
      this.btnTecladoBuscar.UseVisualStyleBackColor = true;
      this.btnListo.Font = new Font("Trebuchet MS", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.btnListo.ForeColor = Color.MediumBlue;
      this.btnListo.Image = (Image) TriNetRestPOS.My.Resources.Resources.i_Ready;
      this.btnListo.Location = new Point(83, 1);
      this.btnListo.Margin = new Padding(4, 5, 4, 5);
      this.btnListo.Name = "btnListo";
      this.btnListo.Size = new Size(83, 60);
      this.btnListo.TabIndex = 3;
      this.btnListo.Text = "&Listo";
      this.btnListo.TextImageRelation = TextImageRelation.TextAboveImage;
      this.btnListo.UseVisualStyleBackColor = true;
      this.btnListo.Visible = false;
      this.Label_Description.AutoSize = true;
      this.Label_Description.Font = new Font("Trebuchet MS", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Label_Description.ForeColor = Color.MediumBlue;
      this.Label_Description.Location = new Point(8, 5);
      this.Label_Description.Margin = new Padding(4, 0, 4, 0);
      this.Label_Description.Name = "Label_Description";
      this.Label_Description.Size = new Size(75, 20);
      this.Label_Description.TabIndex = 147;
      this.Label_Description.Text = "Nombre :";
      this.Panel_ButtonsTools.Controls.Add((Control) this.btnIrPrimero);
      this.Panel_ButtonsTools.Controls.Add((Control) this.btnSalir);
      this.Panel_ButtonsTools.Controls.Add((Control) this.btnIrAnterior);
      this.Panel_ButtonsTools.Controls.Add((Control) this.btnEliminar);
      this.Panel_ButtonsTools.Controls.Add((Control) this.btnIrSiguiente);
      this.Panel_ButtonsTools.Controls.Add((Control) this.btnEditar);
      this.Panel_ButtonsTools.Controls.Add((Control) this.btnIrUltimo);
      this.Panel_ButtonsTools.Controls.Add((Control) this.btnNuevo);
      this.Panel_ButtonsTools.Location = new Point(546, 0);
      this.Panel_ButtonsTools.Margin = new Padding(0);
      this.Panel_ButtonsTools.Name = "Panel_ButtonsTools";
      this.Panel_ButtonsTools.Size = new Size(85, 644);
      this.Panel_ButtonsTools.TabIndex = 146;
      this.btnIrPrimero.Font = new Font("Trebuchet MS", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.btnIrPrimero.Image = (Image) TriNetRestPOS.My.Resources.Resources.Fast_back;
      this.btnIrPrimero.Location = new Point(1, 326);
      this.btnIrPrimero.Margin = new Padding(4, 5, 4, 5);
      this.btnIrPrimero.Name = "btnIrPrimero";
      this.btnIrPrimero.RightToLeft = RightToLeft.Yes;
      this.btnIrPrimero.Size = new Size(83, 60);
      this.btnIrPrimero.TabIndex = 8;
      this.btnIrPrimero.UseVisualStyleBackColor = true;
      this.btnSalir.Font = new Font("Trebuchet MS", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.btnSalir.ForeColor = Color.MediumBlue;
      this.btnSalir.Image = (Image) TriNetRestPOS.My.Resources.Resources.i_Close;
      this.btnSalir.Location = new Point(1, 1);
      this.btnSalir.Margin = new Padding(4, 5, 4, 5);
      this.btnSalir.Name = "btnSalir";
      this.btnSalir.Size = new Size(83, 60);
      this.btnSalir.TabIndex = 4;
      this.btnSalir.Text = "&Salir";
      this.btnSalir.TextImageRelation = TextImageRelation.TextAboveImage;
      this.btnSalir.UseVisualStyleBackColor = true;
      this.btnIrAnterior.Font = new Font("Trebuchet MS", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.btnIrAnterior.Image = (Image) TriNetRestPOS.My.Resources.Resources.go_back;
      this.btnIrAnterior.Location = new Point(1, 385);
      this.btnIrAnterior.Margin = new Padding(4, 5, 4, 5);
      this.btnIrAnterior.Name = "btnIrAnterior";
      this.btnIrAnterior.RightToLeft = RightToLeft.Yes;
      this.btnIrAnterior.Size = new Size(83, 60);
      this.btnIrAnterior.TabIndex = 9;
      this.btnIrAnterior.UseVisualStyleBackColor = true;
      this.btnEliminar.Font = new Font("Trebuchet MS", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.btnEliminar.ForeColor = Color.MediumBlue;
      this.btnEliminar.Image = (Image) TriNetRestPOS.My.Resources.Resources.Eliminar;
      this.btnEliminar.Location = new Point(1, 199);
      this.btnEliminar.Margin = new Padding(4, 5, 4, 5);
      this.btnEliminar.Name = "btnEliminar";
      this.btnEliminar.RightToLeft = RightToLeft.Yes;
      this.btnEliminar.Size = new Size(83, 60);
      this.btnEliminar.TabIndex = 7;
      this.btnEliminar.Text = "&Eliminar";
      this.btnEliminar.TextImageRelation = TextImageRelation.TextAboveImage;
      this.btnEliminar.UseVisualStyleBackColor = true;
      this.btnIrSiguiente.Font = new Font("Trebuchet MS", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.btnIrSiguiente.Image = (Image) TriNetRestPOS.My.Resources.Resources.go_forward;
      this.btnIrSiguiente.Location = new Point(1, 444);
      this.btnIrSiguiente.Margin = new Padding(4, 5, 4, 5);
      this.btnIrSiguiente.Name = "btnIrSiguiente";
      this.btnIrSiguiente.RightToLeft = RightToLeft.Yes;
      this.btnIrSiguiente.Size = new Size(83, 60);
      this.btnIrSiguiente.TabIndex = 10;
      this.btnIrSiguiente.UseVisualStyleBackColor = true;
      this.btnEditar.Font = new Font("Trebuchet MS", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.btnEditar.ForeColor = Color.MediumBlue;
      this.btnEditar.Image = (Image) TriNetRestPOS.My.Resources.Resources.Actualizar;
      this.btnEditar.Location = new Point(1, 140);
      this.btnEditar.Margin = new Padding(4, 5, 4, 5);
      this.btnEditar.Name = "btnEditar";
      this.btnEditar.Size = new Size(83, 60);
      this.btnEditar.TabIndex = 6;
      this.btnEditar.Text = "&Editar";
      this.btnEditar.TextImageRelation = TextImageRelation.TextAboveImage;
      this.btnEditar.UseVisualStyleBackColor = true;
      this.btnIrUltimo.Font = new Font("Trebuchet MS", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.btnIrUltimo.Image = (Image) TriNetRestPOS.My.Resources.Resources.fast_forward;
      this.btnIrUltimo.Location = new Point(1, 503);
      this.btnIrUltimo.Margin = new Padding(4, 5, 4, 5);
      this.btnIrUltimo.Name = "btnIrUltimo";
      this.btnIrUltimo.RightToLeft = RightToLeft.Yes;
      this.btnIrUltimo.Size = new Size(83, 60);
      this.btnIrUltimo.TabIndex = 11;
      this.btnIrUltimo.UseVisualStyleBackColor = true;
      this.btnNuevo.Font = new Font("Trebuchet MS", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.btnNuevo.ForeColor = Color.MediumBlue;
      this.btnNuevo.Image = (Image) TriNetRestPOS.My.Resources.Resources.i_News;
      this.btnNuevo.Location = new Point(1, 81);
      this.btnNuevo.Margin = new Padding(4, 5, 4, 5);
      this.btnNuevo.Name = "btnNuevo";
      this.btnNuevo.Size = new Size(83, 60);
      this.btnNuevo.TabIndex = 5;
      this.btnNuevo.Text = "&Nuevo";
      this.btnNuevo.TextImageRelation = TextImageRelation.TextAboveImage;
      this.btnNuevo.UseVisualStyleBackColor = true;
      this.txtBuscar.Font = new Font("Trebuchet MS", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.txtBuscar.Location = new Point(12, 30);
      this.txtBuscar.Margin = new Padding(4, 5, 4, 5);
      this.txtBuscar.MaxLength = 35;
      this.txtBuscar.Name = "txtBuscar";
      this.txtBuscar.Size = new Size(362, 25);
      this.txtBuscar.TabIndex = 0;
      this.dgvCarta.BorderStyle = BorderStyle.Fixed3D;
      this.dgvCarta.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dgvCarta.Location = new Point(1, 62);
      this.dgvCarta.Margin = new Padding(4, 5, 4, 5);
      this.dgvCarta.MultiSelect = false;
      this.dgvCarta.Name = "dgvCarta";
      this.dgvCarta.ScrollBars = ScrollBars.None;
      this.dgvCarta.Size = new Size(545, 581);
      this.dgvCarta.TabIndex = 1;
      this.TabPage_Detail.Controls.Add((Control) this.btnAgregarSalon);
      this.TabPage_Detail.Controls.Add((Control) this.btnEliminarSalon);
      this.TabPage_Detail.Controls.Add((Control) this.txtSalonId);
      this.TabPage_Detail.Controls.Add((Control) this.txtSalonNombre);
      this.TabPage_Detail.Controls.Add((Control) this.btnBuscarSalon);
      this.TabPage_Detail.Controls.Add((Control) this.Label14);
      this.TabPage_Detail.Controls.Add((Control) this.Label15);
      this.TabPage_Detail.Controls.Add((Control) this.dgvSalon);
      this.TabPage_Detail.Controls.Add((Control) this.Label10);
      this.TabPage_Detail.Controls.Add((Control) this.Label11);
      this.TabPage_Detail.Controls.Add((Control) this.Label12);
      this.TabPage_Detail.Controls.Add((Control) this.Label13);
      this.TabPage_Detail.Controls.Add((Control) this.chbActivo);
      this.TabPage_Detail.Controls.Add((Control) this.Label_IsActive);
      this.TabPage_Detail.Controls.Add((Control) this.btnAtras);
      this.TabPage_Detail.Controls.Add((Control) this.btnGuardar);
      this.TabPage_Detail.Controls.Add((Control) this.btnTecladoNombreCorto);
      this.TabPage_Detail.Controls.Add((Control) this.txtNombreCorto);
      this.TabPage_Detail.Controls.Add((Control) this.Label_DesShort);
      this.TabPage_Detail.Controls.Add((Control) this.btnTecladoNombre);
      this.TabPage_Detail.Controls.Add((Control) this.Label_Des);
      this.TabPage_Detail.Controls.Add((Control) this.txtNombre);
      this.TabPage_Detail.Controls.Add((Control) this.Label_Id);
      this.TabPage_Detail.Controls.Add((Control) this.txtCartaId);
      this.TabPage_Detail.Location = new Point(4, 29);
      this.TabPage_Detail.Margin = new Padding(4, 5, 4, 5);
      this.TabPage_Detail.Name = "TabPage_Detail";
      this.TabPage_Detail.Padding = new Padding(4, 5, 4, 5);
      this.TabPage_Detail.Size = new Size(629, 644);
      this.TabPage_Detail.TabIndex = 1;
      this.TabPage_Detail.Text = "Mantenimiento";
      this.TabPage_Detail.UseVisualStyleBackColor = true;
      this.btnAgregarSalon.ForeColor = Color.MediumBlue;
      this.btnAgregarSalon.Image = (Image) TriNetRestPOS.My.Resources.Resources.IsObservated_True;
      this.btnAgregarSalon.Location = new Point(361, 262);
      this.btnAgregarSalon.Margin = new Padding(4, 5, 4, 5);
      this.btnAgregarSalon.Name = "btnAgregarSalon";
      this.btnAgregarSalon.Size = new Size(98, 35);
      this.btnAgregarSalon.TabIndex = 307;
      this.btnAgregarSalon.Text = "Agregar";
      this.btnAgregarSalon.TextImageRelation = TextImageRelation.ImageBeforeText;
      this.btnAgregarSalon.UseVisualStyleBackColor = true;
      this.btnEliminarSalon.ForeColor = Color.MediumBlue;
      this.btnEliminarSalon.Image = (Image) TriNetRestPOS.My.Resources.Resources.IsObservated_False;
      this.btnEliminarSalon.Location = new Point(459, 262);
      this.btnEliminarSalon.Margin = new Padding(4, 5, 4, 5);
      this.btnEliminarSalon.Name = "btnEliminarSalon";
      this.btnEliminarSalon.Size = new Size(100, 35);
      this.btnEliminarSalon.TabIndex = 308;
      this.btnEliminarSalon.Text = "Eliminar";
      this.btnEliminarSalon.TextImageRelation = TextImageRelation.ImageBeforeText;
      this.btnEliminarSalon.UseVisualStyleBackColor = true;
      this.txtSalonId.BackColor = Color.FromArgb((int) byte.MaxValue, 240, 144);
      this.txtSalonId.Location = new Point(566, 233);
      this.txtSalonId.MaxLength = 50;
      this.txtSalonId.Name = "txtSalonId";
      this.txtSalonId.ReadOnly = true;
      this.txtSalonId.Size = new Size(15, 25);
      this.txtSalonId.TabIndex = 306;
      this.txtSalonId.Visible = false;
      this.txtSalonNombre.BackColor = Color.FromArgb((int) byte.MaxValue, 240, 144);
      this.txtSalonNombre.Font = new Font("Trebuchet MS", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.txtSalonNombre.Location = new Point(171, 233);
      this.txtSalonNombre.Margin = new Padding(4, 5, 4, 5);
      this.txtSalonNombre.Name = "txtSalonNombre";
      this.txtSalonNombre.ReadOnly = true;
      this.txtSalonNombre.Size = new Size(297, 25);
      this.txtSalonNombre.TabIndex = 171;
      this.btnBuscarSalon.Font = new Font("Trebuchet MS", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.btnBuscarSalon.Image = (Image) TriNetRestPOS.My.Resources.Resources.Table;
      this.btnBuscarSalon.Location = new Point(476, 199);
      this.btnBuscarSalon.Margin = new Padding(4, 5, 4, 5);
      this.btnBuscarSalon.Name = "btnBuscarSalon";
      this.btnBuscarSalon.Size = new Size(83, 60);
      this.btnBuscarSalon.TabIndex = 172;
      this.btnBuscarSalon.UseVisualStyleBackColor = true;
      this.Label14.AutoSize = true;
      this.Label14.Font = new Font("Trebuchet MS", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Label14.ForeColor = Color.MediumBlue;
      this.Label14.Location = new Point(146, 236);
      this.Label14.Margin = new Padding(4, 0, 4, 0);
      this.Label14.Name = "Label14";
      this.Label14.Size = new Size(15, 20);
      this.Label14.TabIndex = 170;
      this.Label14.Text = ":";
      this.Label15.AutoSize = true;
      this.Label15.Font = new Font("Trebuchet MS", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Label15.ForeColor = Color.MediumBlue;
      this.Label15.Location = new Point(35, 236);
      this.Label15.Margin = new Padding(4, 0, 4, 0);
      this.Label15.Name = "Label15";
      this.Label15.Size = new Size(106, 20);
      this.Label15.TabIndex = 169;
      this.Label15.Text = "Agregar Salón";
      this.dgvSalon.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dgvSalon.Location = new Point(38, 300);
      this.dgvSalon.Name = "dgvSalon";
      this.dgvSalon.Size = new Size(521, 265);
      this.dgvSalon.TabIndex = 168;
      this.Label10.AutoSize = true;
      this.Label10.Font = new Font("Trebuchet MS", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Label10.ForeColor = Color.MediumBlue;
      this.Label10.Location = new Point(146, 195);
      this.Label10.Margin = new Padding(4, 0, 4, 0);
      this.Label10.Name = "Label10";
      this.Label10.Size = new Size(15, 20);
      this.Label10.TabIndex = 167;
      this.Label10.Text = ":";
      this.Label11.AutoSize = true;
      this.Label11.Font = new Font("Trebuchet MS", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Label11.ForeColor = Color.MediumBlue;
      this.Label11.Location = new Point(145, 132);
      this.Label11.Margin = new Padding(4, 0, 4, 0);
      this.Label11.Name = "Label11";
      this.Label11.Size = new Size(15, 20);
      this.Label11.TabIndex = 166;
      this.Label11.Text = ":";
      this.Label12.AutoSize = true;
      this.Label12.Font = new Font("Trebuchet MS", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Label12.ForeColor = Color.MediumBlue;
      this.Label12.Location = new Point(145, 67);
      this.Label12.Margin = new Padding(4, 0, 4, 0);
      this.Label12.Name = "Label12";
      this.Label12.Size = new Size(15, 20);
      this.Label12.TabIndex = 165;
      this.Label12.Text = ":";
      this.Label13.AutoSize = true;
      this.Label13.Font = new Font("Trebuchet MS", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Label13.ForeColor = Color.MediumBlue;
      this.Label13.Location = new Point(145, 32);
      this.Label13.Margin = new Padding(4, 0, 4, 0);
      this.Label13.Name = "Label13";
      this.Label13.Size = new Size(15, 20);
      this.Label13.TabIndex = 164;
      this.Label13.Text = ":";
      this.chbActivo.AutoSize = true;
      this.chbActivo.Font = new Font("Trebuchet MS", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.chbActivo.Location = new Point(171, 199);
      this.chbActivo.Margin = new Padding(4, 5, 4, 5);
      this.chbActivo.Name = "chbActivo";
      this.chbActivo.Size = new Size(15, 14);
      this.chbActivo.TabIndex = 5;
      this.chbActivo.UseVisualStyleBackColor = true;
      this.Label_IsActive.AutoSize = true;
      this.Label_IsActive.Font = new Font("Trebuchet MS", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Label_IsActive.ForeColor = Color.MediumBlue;
      this.Label_IsActive.Location = new Point(35, 195);
      this.Label_IsActive.Margin = new Padding(4, 0, 4, 0);
      this.Label_IsActive.Name = "Label_IsActive";
      this.Label_IsActive.Size = new Size(54, 20);
      this.Label_IsActive.TabIndex = 163;
      this.Label_IsActive.Text = "Activo";
      this.btnAtras.Font = new Font("Trebuchet MS", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.btnAtras.ForeColor = Color.MediumBlue;
      this.btnAtras.Image = (Image) TriNetRestPOS.My.Resources.Resources.i_Close;
      this.btnAtras.Location = new Point(459, 574);
      this.btnAtras.Margin = new Padding(4, 5, 4, 5);
      this.btnAtras.Name = "btnAtras";
      this.btnAtras.Size = new Size(100, 60);
      this.btnAtras.TabIndex = 7;
      this.btnAtras.Text = "Atrás";
      this.btnAtras.TextImageRelation = TextImageRelation.TextAboveImage;
      this.btnAtras.UseVisualStyleBackColor = true;
      this.btnGuardar.Font = new Font("Trebuchet MS", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.btnGuardar.ForeColor = Color.MediumBlue;
      this.btnGuardar.Image = (Image) TriNetRestPOS.My.Resources.Resources.i_Ready;
      this.btnGuardar.Location = new Point(351, 574);
      this.btnGuardar.Margin = new Padding(4, 5, 4, 5);
      this.btnGuardar.Name = "btnGuardar";
      this.btnGuardar.Size = new Size(100, 60);
      this.btnGuardar.TabIndex = 6;
      this.btnGuardar.Text = "Grabar";
      this.btnGuardar.TextImageRelation = TextImageRelation.TextAboveImage;
      this.btnGuardar.UseVisualStyleBackColor = true;
      this.btnTecladoNombreCorto.Font = new Font("Trebuchet MS", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.btnTecladoNombreCorto.ForeColor = Color.MediumBlue;
      this.btnTecladoNombreCorto.Image = (Image) componentResourceManager.GetObject("btnTecladoNombreCorto.Image");
      this.btnTecladoNombreCorto.ImageAlign = ContentAlignment.BottomCenter;
      this.btnTecladoNombreCorto.Location = new Point(476, 122);
      this.btnTecladoNombreCorto.Margin = new Padding(4, 5, 4, 5);
      this.btnTecladoNombreCorto.Name = "btnTecladoNombreCorto";
      this.btnTecladoNombreCorto.Size = new Size(83, 60);
      this.btnTecladoNombreCorto.TabIndex = 4;
      this.btnTecladoNombreCorto.TextAlign = ContentAlignment.TopCenter;
      this.btnTecladoNombreCorto.UseVisualStyleBackColor = true;
      this.txtNombreCorto.Font = new Font("Trebuchet MS", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.txtNombreCorto.Location = new Point(38, 157);
      this.txtNombreCorto.Margin = new Padding(4, 5, 4, 5);
      this.txtNombreCorto.MaxLength = 30;
      this.txtNombreCorto.Name = "txtNombreCorto";
      this.txtNombreCorto.Size = new Size(430, 25);
      this.txtNombreCorto.TabIndex = 3;
      this.Label_DesShort.AutoSize = true;
      this.Label_DesShort.Font = new Font("Trebuchet MS", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Label_DesShort.ForeColor = Color.MediumBlue;
      this.Label_DesShort.Location = new Point(34, 132);
      this.Label_DesShort.Margin = new Padding(4, 0, 4, 0);
      this.Label_DesShort.Name = "Label_DesShort";
      this.Label_DesShort.Size = new Size(106, 20);
      this.Label_DesShort.TabIndex = 155;
      this.Label_DesShort.Text = "Nombre Corto";
      this.btnTecladoNombre.Font = new Font("Trebuchet MS", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.btnTecladoNombre.ForeColor = Color.MediumBlue;
      this.btnTecladoNombre.Image = (Image) componentResourceManager.GetObject("btnTecladoNombre.Image");
      this.btnTecladoNombre.ImageAlign = ContentAlignment.BottomCenter;
      this.btnTecladoNombre.Location = new Point(476, 57);
      this.btnTecladoNombre.Margin = new Padding(4, 5, 4, 5);
      this.btnTecladoNombre.Name = "btnTecladoNombre";
      this.btnTecladoNombre.Size = new Size(83, 60);
      this.btnTecladoNombre.TabIndex = 2;
      this.btnTecladoNombre.TextAlign = ContentAlignment.TopCenter;
      this.btnTecladoNombre.UseVisualStyleBackColor = true;
      this.Label_Des.AutoSize = true;
      this.Label_Des.Font = new Font("Trebuchet MS", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Label_Des.ForeColor = Color.MediumBlue;
      this.Label_Des.Location = new Point(34, 67);
      this.Label_Des.Margin = new Padding(4, 0, 4, 0);
      this.Label_Des.Name = "Label_Des";
      this.Label_Des.Size = new Size(64, 20);
      this.Label_Des.TabIndex = 151;
      this.Label_Des.Text = "Nombre";
      this.txtNombre.Font = new Font("Trebuchet MS", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.txtNombre.Location = new Point(38, 92);
      this.txtNombre.Margin = new Padding(4, 5, 4, 5);
      this.txtNombre.MaxLength = 50;
      this.txtNombre.Name = "txtNombre";
      this.txtNombre.Size = new Size(430, 25);
      this.txtNombre.TabIndex = 1;
      this.Label_Id.AutoSize = true;
      this.Label_Id.Font = new Font("Trebuchet MS", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Label_Id.ForeColor = Color.MediumBlue;
      this.Label_Id.Location = new Point(34, 32);
      this.Label_Id.Margin = new Padding(4, 0, 4, 0);
      this.Label_Id.Name = "Label_Id";
      this.Label_Id.Size = new Size(55, 20);
      this.Label_Id.TabIndex = 149;
      this.Label_Id.Text = "Código";
      this.txtCartaId.BackColor = Color.FromArgb((int) byte.MaxValue, 240, 144);
      this.txtCartaId.Font = new Font("Trebuchet MS", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.txtCartaId.Location = new Point(171, 27);
      this.txtCartaId.Margin = new Padding(4, 5, 4, 5);
      this.txtCartaId.Name = "txtCartaId";
      this.txtCartaId.ReadOnly = true;
      this.txtCartaId.Size = new Size(226, 25);
      this.txtCartaId.TabIndex = 0;
      this.TabPage_Productos.Controls.Add((Control) this.btnGuardar2);
      this.TabPage_Productos.Controls.Add((Control) this.btnAgregarItem);
      this.TabPage_Productos.Controls.Add((Control) this.txtProductId);
      this.TabPage_Productos.Controls.Add((Control) this.btnAtrasItem);
      this.TabPage_Productos.Controls.Add((Control) this.Label1);
      this.TabPage_Productos.Controls.Add((Control) this.Label3);
      this.TabPage_Productos.Controls.Add((Control) this.txtProductoNombre);
      this.TabPage_Productos.Controls.Add((Control) this.txtNombreCartaL);
      this.TabPage_Productos.Controls.Add((Control) this.btnEliminarItem);
      this.TabPage_Productos.Controls.Add((Control) this.btnModificarItem);
      this.TabPage_Productos.Controls.Add((Control) this.gbPrecios);
      this.TabPage_Productos.Controls.Add((Control) this.dgvCartaDetalle);
      this.TabPage_Productos.Controls.Add((Control) this.Label5);
      this.TabPage_Productos.Controls.Add((Control) this.btnBuscarProducto);
      this.TabPage_Productos.Controls.Add((Control) this.Label_Product);
      this.TabPage_Productos.Location = new Point(4, 29);
      this.TabPage_Productos.Margin = new Padding(4, 5, 4, 5);
      this.TabPage_Productos.Name = "TabPage_Productos";
      this.TabPage_Productos.Padding = new Padding(4, 5, 4, 5);
      this.TabPage_Productos.Size = new Size(629, 644);
      this.TabPage_Productos.TabIndex = 2;
      this.TabPage_Productos.Text = "Detalle";
      this.TabPage_Productos.UseVisualStyleBackColor = true;
      this.btnGuardar2.ForeColor = Color.MediumBlue;
      this.btnGuardar2.Image = (Image) TriNetRestPOS.My.Resources.Resources.i_Ready;
      this.btnGuardar2.Location = new Point(425, 10);
      this.btnGuardar2.Margin = new Padding(4, 5, 4, 5);
      this.btnGuardar2.Name = "btnGuardar2";
      this.btnGuardar2.Size = new Size(110, 35);
      this.btnGuardar2.TabIndex = 7;
      this.btnGuardar2.Text = "Guardar";
      this.btnGuardar2.TextImageRelation = TextImageRelation.ImageBeforeText;
      this.btnGuardar2.UseVisualStyleBackColor = true;
      this.btnGuardar2.Visible = false;
      this.btnAgregarItem.ForeColor = Color.MediumBlue;
      this.btnAgregarItem.Image = (Image) TriNetRestPOS.My.Resources.Resources.IsObservated_True;
      this.btnAgregarItem.Location = new Point(320, 154);
      this.btnAgregarItem.Margin = new Padding(4, 5, 4, 5);
      this.btnAgregarItem.Name = "btnAgregarItem";
      this.btnAgregarItem.Size = new Size(98, 35);
      this.btnAgregarItem.TabIndex = 4;
      this.btnAgregarItem.Text = "Agregar";
      this.btnAgregarItem.TextImageRelation = TextImageRelation.ImageBeforeText;
      this.btnAgregarItem.UseVisualStyleBackColor = true;
      this.txtProductId.BackColor = Color.FromArgb((int) byte.MaxValue, 240, 144);
      this.txtProductId.Location = new Point(14, 158);
      this.txtProductId.MaxLength = 50;
      this.txtProductId.Name = "txtProductId";
      this.txtProductId.ReadOnly = true;
      this.txtProductId.Size = new Size(15, 25);
      this.txtProductId.TabIndex = 305;
      this.txtProductId.Visible = false;
      this.btnAtrasItem.ForeColor = Color.MediumBlue;
      this.btnAtrasItem.Image = (Image) TriNetRestPOS.My.Resources.Resources.i_Close;
      this.btnAtrasItem.Location = new Point(535, 10);
      this.btnAtrasItem.Margin = new Padding(4, 5, 4, 5);
      this.btnAtrasItem.Name = "btnAtrasItem";
      this.btnAtrasItem.Size = new Size(90, 35);
      this.btnAtrasItem.TabIndex = 8;
      this.btnAtrasItem.Text = "Atrás";
      this.btnAtrasItem.TextImageRelation = TextImageRelation.ImageBeforeText;
      this.btnAtrasItem.UseVisualStyleBackColor = true;
      this.Label1.AutoSize = true;
      this.Label1.Font = new Font("Trebuchet MS", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Label1.ForeColor = Color.MediumBlue;
      this.Label1.Location = new Point(92, 23);
      this.Label1.Margin = new Padding(4, 0, 4, 0);
      this.Label1.Name = "Label1";
      this.Label1.Size = new Size(15, 20);
      this.Label1.TabIndex = 303;
      this.Label1.Text = ":";
      this.Label3.AutoSize = true;
      this.Label3.Font = new Font("Trebuchet MS", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Label3.ForeColor = Color.MediumBlue;
      this.Label3.Location = new Point(92, 61);
      this.Label3.Margin = new Padding(4, 0, 4, 0);
      this.Label3.Name = "Label3";
      this.Label3.Size = new Size(15, 20);
      this.Label3.TabIndex = 302;
      this.Label3.Text = ":";
      this.txtProductoNombre.BackColor = Color.FromArgb((int) byte.MaxValue, 240, 144);
      this.txtProductoNombre.Font = new Font("Trebuchet MS", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.txtProductoNombre.Location = new Point(115, 58);
      this.txtProductoNombre.Margin = new Padding(4, 5, 4, 5);
      this.txtProductoNombre.Name = "txtProductoNombre";
      this.txtProductoNombre.ReadOnly = true;
      this.txtProductoNombre.Size = new Size(411, 25);
      this.txtProductoNombre.TabIndex = 1;
      this.txtNombreCartaL.BackColor = Color.FromArgb((int) byte.MaxValue, 240, 144);
      this.txtNombreCartaL.Font = new Font("Trebuchet MS", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.txtNombreCartaL.Location = new Point(115, 20);
      this.txtNombreCartaL.Margin = new Padding(4, 5, 4, 5);
      this.txtNombreCartaL.Name = "txtNombreCartaL";
      this.txtNombreCartaL.ReadOnly = true;
      this.txtNombreCartaL.Size = new Size(305, 25);
      this.txtNombreCartaL.TabIndex = 0;
      this.btnEliminarItem.ForeColor = Color.MediumBlue;
      this.btnEliminarItem.Image = (Image) TriNetRestPOS.My.Resources.Resources.IsObservated_False;
      this.btnEliminarItem.Location = new Point(518, 154);
      this.btnEliminarItem.Margin = new Padding(4, 5, 4, 5);
      this.btnEliminarItem.Name = "btnEliminarItem";
      this.btnEliminarItem.Size = new Size(100, 35);
      this.btnEliminarItem.TabIndex = 6;
      this.btnEliminarItem.Text = "Eliminar";
      this.btnEliminarItem.TextImageRelation = TextImageRelation.ImageBeforeText;
      this.btnEliminarItem.UseVisualStyleBackColor = true;
      this.btnModificarItem.ForeColor = Color.MediumBlue;
      this.btnModificarItem.Image = (Image) TriNetRestPOS.My.Resources.Resources.Actualizar;
      this.btnModificarItem.Location = new Point(418, 154);
      this.btnModificarItem.Margin = new Padding(4, 5, 4, 5);
      this.btnModificarItem.Name = "btnModificarItem";
      this.btnModificarItem.Size = new Size(100, 35);
      this.btnModificarItem.TabIndex = 5;
      this.btnModificarItem.Text = "Editar";
      this.btnModificarItem.TextImageRelation = TextImageRelation.ImageBeforeText;
      this.btnModificarItem.UseVisualStyleBackColor = true;
      this.gbPrecios.Controls.Add((Control) this.Label2);
      this.gbPrecios.Controls.Add((Control) this.Label9);
      this.gbPrecios.Controls.Add((Control) this.txtPrecioSocio);
      this.gbPrecios.Controls.Add((Control) this.Label8);
      this.gbPrecios.Controls.Add((Control) this.Label4);
      this.gbPrecios.Controls.Add((Control) this.Label7);
      this.gbPrecios.Controls.Add((Control) this.txtPrecioColaborador);
      this.gbPrecios.Controls.Add((Control) this.txtPrecioPublico);
      this.gbPrecios.Controls.Add((Control) this.Label6);
      this.gbPrecios.ForeColor = Color.Red;
      this.gbPrecios.Location = new Point(14, 91);
      this.gbPrecios.Name = "gbPrecios";
      this.gbPrecios.Size = new Size(603, 61);
      this.gbPrecios.TabIndex = 3;
      this.gbPrecios.TabStop = false;
      this.gbPrecios.Text = "Precios";
      this.Label2.AutoSize = true;
      this.Label2.Font = new Font("Trebuchet MS", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Label2.ForeColor = Color.MediumBlue;
      this.Label2.Location = new Point(6, 26);
      this.Label2.Margin = new Padding(4, 0, 4, 0);
      this.Label2.Name = "Label2";
      this.Label2.Size = new Size(45, 20);
      this.Label2.TabIndex = 282;
      this.Label2.Text = "Socio";
      this.Label9.AutoSize = true;
      this.Label9.Font = new Font("Trebuchet MS", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Label9.ForeColor = Color.MediumBlue;
      this.Label9.Location = new Point(468, 26);
      this.Label9.Margin = new Padding(4, 0, 4, 0);
      this.Label9.Name = "Label9";
      this.Label9.Size = new Size(15, 20);
      this.Label9.TabIndex = 296;
      this.Label9.Text = ":";
      this.txtPrecioSocio.set_AllowSpace(false);
      ((TextBoxBase) this.txtPrecioSocio).BackColor = SystemColors.Window;
      ((Control) this.txtPrecioSocio).Font = new Font("Trebuchet MS", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      ((TextBoxBase) this.txtPrecioSocio).ForeColor = Color.Black;
      ((Control) this.txtPrecioSocio).Location = new Point(72, 23);
      ((Control) this.txtPrecioSocio).Name = "txtPrecioSocio";
      ((Control) this.txtPrecioSocio).Size = new Size(100, 25);
      ((Control) this.txtPrecioSocio).TabIndex = 0;
      ((TextBox) this.txtPrecioSocio).Text = "0.00";
      ((TextBox) this.txtPrecioSocio).TextAlign = HorizontalAlignment.Right;
      this.Label8.AutoSize = true;
      this.Label8.Font = new Font("Trebuchet MS", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Label8.ForeColor = Color.MediumBlue;
      this.Label8.Location = new Point(276, 26);
      this.Label8.Margin = new Padding(4, 0, 4, 0);
      this.Label8.Name = "Label8";
      this.Label8.Size = new Size(15, 20);
      this.Label8.TabIndex = 295;
      this.Label8.Text = ":";
      this.Label4.AutoSize = true;
      this.Label4.Font = new Font("Trebuchet MS", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Label4.ForeColor = Color.MediumBlue;
      this.Label4.Location = new Point(185, 26);
      this.Label4.Margin = new Padding(4, 0, 4, 0);
      this.Label4.Name = "Label4";
      this.Label4.Size = new Size(92, 20);
      this.Label4.TabIndex = 290;
      this.Label4.Text = "Colaborador";
      this.Label7.AutoSize = true;
      this.Label7.Font = new Font("Trebuchet MS", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Label7.ForeColor = Color.MediumBlue;
      this.Label7.Location = new Point(50, 26);
      this.Label7.Margin = new Padding(4, 0, 4, 0);
      this.Label7.Name = "Label7";
      this.Label7.Size = new Size(15, 20);
      this.Label7.TabIndex = 294;
      this.Label7.Text = ":";
      this.txtPrecioColaborador.set_AllowSpace(false);
      ((TextBoxBase) this.txtPrecioColaborador).BackColor = SystemColors.Window;
      ((Control) this.txtPrecioColaborador).Font = new Font("Trebuchet MS", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      ((TextBoxBase) this.txtPrecioColaborador).ForeColor = Color.Black;
      ((Control) this.txtPrecioColaborador).Location = new Point(298, 23);
      ((Control) this.txtPrecioColaborador).Name = "txtPrecioColaborador";
      ((Control) this.txtPrecioColaborador).Size = new Size(100, 25);
      ((Control) this.txtPrecioColaborador).TabIndex = 1;
      ((TextBox) this.txtPrecioColaborador).Text = "0.00";
      ((TextBox) this.txtPrecioColaborador).TextAlign = HorizontalAlignment.Right;
      this.txtPrecioPublico.set_AllowSpace(false);
      ((TextBoxBase) this.txtPrecioPublico).BackColor = SystemColors.Window;
      ((Control) this.txtPrecioPublico).Font = new Font("Trebuchet MS", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      ((TextBoxBase) this.txtPrecioPublico).ForeColor = Color.Black;
      ((Control) this.txtPrecioPublico).Location = new Point(490, 23);
      ((Control) this.txtPrecioPublico).Name = "txtPrecioPublico";
      ((Control) this.txtPrecioPublico).Size = new Size(100, 25);
      ((Control) this.txtPrecioPublico).TabIndex = 2;
      ((TextBox) this.txtPrecioPublico).Text = "0.00";
      ((TextBox) this.txtPrecioPublico).TextAlign = HorizontalAlignment.Right;
      this.Label6.AutoSize = true;
      this.Label6.Font = new Font("Trebuchet MS", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Label6.ForeColor = Color.MediumBlue;
      this.Label6.Location = new Point(409, 26);
      this.Label6.Margin = new Padding(4, 0, 4, 0);
      this.Label6.Name = "Label6";
      this.Label6.Size = new Size(60, 20);
      this.Label6.TabIndex = 292;
      this.Label6.Text = "Público";
      this.dgvCartaDetalle.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dgvCartaDetalle.Dock = DockStyle.Bottom;
      this.dgvCartaDetalle.Location = new Point(4, 192);
      this.dgvCartaDetalle.Name = "dgvCartaDetalle";
      this.dgvCartaDetalle.Size = new Size(621, 447);
      this.dgvCartaDetalle.TabIndex = 9;
      this.Label5.AutoSize = true;
      this.Label5.Font = new Font("Trebuchet MS", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Label5.ForeColor = Color.MediumBlue;
      this.Label5.Location = new Point(20, 23);
      this.Label5.Margin = new Padding(4, 0, 4, 0);
      this.Label5.Name = "Label5";
      this.Label5.Size = new Size(46, 20);
      this.Label5.TabIndex = 286;
      this.Label5.Text = "Carta";
      this.btnBuscarProducto.Font = new Font("Trebuchet MS", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.btnBuscarProducto.Image = (Image) TriNetRestPOS.My.Resources.Resources.food;
      this.btnBuscarProducto.Location = new Point(534, 48);
      this.btnBuscarProducto.Margin = new Padding(4, 5, 4, 5);
      this.btnBuscarProducto.Name = "btnBuscarProducto";
      this.btnBuscarProducto.Size = new Size(83, 35);
      this.btnBuscarProducto.TabIndex = 2;
      this.btnBuscarProducto.UseVisualStyleBackColor = true;
      this.Label_Product.AutoSize = true;
      this.Label_Product.Font = new Font("Trebuchet MS", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Label_Product.ForeColor = Color.MediumBlue;
      this.Label_Product.Location = new Point(20, 61);
      this.Label_Product.Margin = new Padding(4, 0, 4, 0);
      this.Label_Product.Name = "Label_Product";
      this.Label_Product.Size = new Size(72, 20);
      this.Label_Product.TabIndex = 276;
      this.Label_Product.Text = "Producto";
      this.ToolStripStatusLabel_Operation.Font = new Font("Trebuchet MS", 11.25f, FontStyle.Bold);
      this.ToolStripStatusLabel_Operation.ForeColor = Color.MediumBlue;
      this.ToolStripStatusLabel_Operation.Name = "ToolStripStatusLabel_Operation";
      this.ToolStripStatusLabel_Operation.Size = new Size(27, 20);
      this.ToolStripStatusLabel_Operation.Text = "...";
      this.StatusStrip_Properties.BackColor = Color.Transparent;
      this.StatusStrip_Properties.Font = new Font("Trebuchet MS", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.StatusStrip_Properties.Items.AddRange(new ToolStripItem[2]
      {
        (ToolStripItem) this.ToolStripStatusLabel_Operation,
        (ToolStripItem) this.Tssl_Record
      });
      this.StatusStrip_Properties.Location = new Point(0, 677);
      this.StatusStrip_Properties.Name = "StatusStrip_Properties";
      this.StatusStrip_Properties.Padding = new Padding(2, 0, 21, 0);
      this.StatusStrip_Properties.Size = new Size(637, 25);
      this.StatusStrip_Properties.TabIndex = 166;
      this.StatusStrip_Properties.Text = "StatusStrip1";
      this.Tssl_Record.Font = new Font("Trebuchet MS", 11.25f, FontStyle.Bold);
      this.Tssl_Record.ForeColor = Color.MediumBlue;
      this.Tssl_Record.Name = "Tssl_Record";
      this.Tssl_Record.Size = new Size(587, 20);
      this.Tssl_Record.Spring = true;
      this.Tssl_Record.Text = "N° Record";
      this.Tssl_Record.TextAlign = ContentAlignment.MiddleRight;
      this.AutoScaleDimensions = new SizeF(9f, 20f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.BackColor = SystemColors.Window;
      this.ClientSize = new Size(637, 702);
      this.ControlBox = false;
      this.Controls.Add((Control) this.TabControl_Data);
      this.Controls.Add((Control) this.StatusStrip_Properties);
      this.Font = new Font("Trebuchet MS", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.FormBorderStyle = FormBorderStyle.FixedDialog;
      this.Margin = new Padding(4, 5, 4, 5);
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = nameof (FrmCarta);
      this.ShowIcon = false;
      this.ShowInTaskbar = false;
      this.StartPosition = FormStartPosition.CenterScreen;
      this.Text = "Carta";
      ((Control) this.TabControl_Data).ResumeLayout(false);
      this.TabPage_Listado.ResumeLayout(false);
      this.TabPage_Listado.PerformLayout();
      this.Panel_ButtonsActions.ResumeLayout(false);
      this.Panel_ButtonsTools.ResumeLayout(false);
      ((ISupportInitialize) this.dgvCarta).EndInit();
      this.TabPage_Detail.ResumeLayout(false);
      this.TabPage_Detail.PerformLayout();
      ((ISupportInitialize) this.dgvSalon).EndInit();
      this.TabPage_Productos.ResumeLayout(false);
      this.TabPage_Productos.PerformLayout();
      this.gbPrecios.ResumeLayout(false);
      this.gbPrecios.PerformLayout();
      ((ISupportInitialize) this.dgvCartaDetalle).EndInit();
      this.StatusStrip_Properties.ResumeLayout(false);
      this.StatusStrip_Properties.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();
    }

    internal virtual TabPage TabPage_Listado { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Panel Panel_ButtonsActions { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Button btnTecladoBuscar
    {
      get
      {
        return this._btnTecladoBuscar;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.btnTecladoBuscar_Click);
        Button btnTecladoBuscar1 = this._btnTecladoBuscar;
        if (btnTecladoBuscar1 != null)
          btnTecladoBuscar1.Click -= eventHandler;
        this._btnTecladoBuscar = value;
        Button btnTecladoBuscar2 = this._btnTecladoBuscar;
        if (btnTecladoBuscar2 == null)
          return;
        btnTecladoBuscar2.Click += eventHandler;
      }
    }

    internal virtual Button btnListo
    {
      get
      {
        return this._btnListo;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.btnListo_Click);
        Button btnListo1 = this._btnListo;
        if (btnListo1 != null)
          btnListo1.Click -= eventHandler;
        this._btnListo = value;
        Button btnListo2 = this._btnListo;
        if (btnListo2 == null)
          return;
        btnListo2.Click += eventHandler;
      }
    }

    internal virtual Label Label_Description { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Panel Panel_ButtonsTools { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Button btnIrPrimero
    {
      get
      {
        return this._btnIrPrimero;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.btnIrPrimero_Click);
        Button btnIrPrimero1 = this._btnIrPrimero;
        if (btnIrPrimero1 != null)
          btnIrPrimero1.Click -= eventHandler;
        this._btnIrPrimero = value;
        Button btnIrPrimero2 = this._btnIrPrimero;
        if (btnIrPrimero2 == null)
          return;
        btnIrPrimero2.Click += eventHandler;
      }
    }

    internal virtual Button btnSalir
    {
      get
      {
        return this._btnSalir;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.btnSalir_Click);
        Button btnSalir1 = this._btnSalir;
        if (btnSalir1 != null)
          btnSalir1.Click -= eventHandler;
        this._btnSalir = value;
        Button btnSalir2 = this._btnSalir;
        if (btnSalir2 == null)
          return;
        btnSalir2.Click += eventHandler;
      }
    }

    internal virtual Button btnIrAnterior
    {
      get
      {
        return this._btnIrAnterior;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.btnIrAnterior_Click);
        Button btnIrAnterior1 = this._btnIrAnterior;
        if (btnIrAnterior1 != null)
          btnIrAnterior1.Click -= eventHandler;
        this._btnIrAnterior = value;
        Button btnIrAnterior2 = this._btnIrAnterior;
        if (btnIrAnterior2 == null)
          return;
        btnIrAnterior2.Click += eventHandler;
      }
    }

    internal virtual Button btnEliminar
    {
      get
      {
        return this._btnEliminar;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.btnEliminar_Click);
        Button btnEliminar1 = this._btnEliminar;
        if (btnEliminar1 != null)
          btnEliminar1.Click -= eventHandler;
        this._btnEliminar = value;
        Button btnEliminar2 = this._btnEliminar;
        if (btnEliminar2 == null)
          return;
        btnEliminar2.Click += eventHandler;
      }
    }

    internal virtual Button btnIrSiguiente
    {
      get
      {
        return this._btnIrSiguiente;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.btnIrSiguiente_Click);
        Button btnIrSiguiente1 = this._btnIrSiguiente;
        if (btnIrSiguiente1 != null)
          btnIrSiguiente1.Click -= eventHandler;
        this._btnIrSiguiente = value;
        Button btnIrSiguiente2 = this._btnIrSiguiente;
        if (btnIrSiguiente2 == null)
          return;
        btnIrSiguiente2.Click += eventHandler;
      }
    }

    internal virtual Button btnEditar
    {
      get
      {
        return this._btnEditar;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.btnEditar_Click);
        Button btnEditar1 = this._btnEditar;
        if (btnEditar1 != null)
          btnEditar1.Click -= eventHandler;
        this._btnEditar = value;
        Button btnEditar2 = this._btnEditar;
        if (btnEditar2 == null)
          return;
        btnEditar2.Click += eventHandler;
      }
    }

    internal virtual Button btnIrUltimo
    {
      get
      {
        return this._btnIrUltimo;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.btnIrUltimo_Click);
        Button btnIrUltimo1 = this._btnIrUltimo;
        if (btnIrUltimo1 != null)
          btnIrUltimo1.Click -= eventHandler;
        this._btnIrUltimo = value;
        Button btnIrUltimo2 = this._btnIrUltimo;
        if (btnIrUltimo2 == null)
          return;
        btnIrUltimo2.Click += eventHandler;
      }
    }

    internal virtual Button btnNuevo
    {
      get
      {
        return this._btnNuevo;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.btnNuevo_Click);
        Button btnNuevo1 = this._btnNuevo;
        if (btnNuevo1 != null)
          btnNuevo1.Click -= eventHandler;
        this._btnNuevo = value;
        Button btnNuevo2 = this._btnNuevo;
        if (btnNuevo2 == null)
          return;
        btnNuevo2.Click += eventHandler;
      }
    }

    internal virtual TextBox txtBuscar
    {
      get
      {
        return this._txtBuscar;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.txtBuscar_TextChanged);
        TextBox txtBuscar1 = this._txtBuscar;
        if (txtBuscar1 != null)
          txtBuscar1.TextChanged -= eventHandler;
        this._txtBuscar = value;
        TextBox txtBuscar2 = this._txtBuscar;
        if (txtBuscar2 == null)
          return;
        txtBuscar2.TextChanged += eventHandler;
      }
    }

    internal virtual DataGridView dgvCarta
    {
      get
      {
        return this._dgvCarta;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        DataGridViewCellEventHandler cellEventHandler1 = new DataGridViewCellEventHandler(this.dgvCarta_CellClick);
        DataGridViewCellEventHandler cellEventHandler2 = new DataGridViewCellEventHandler(this.dgvCarta_CellDoubleClick);
        DataGridView dgvCarta1 = this._dgvCarta;
        if (dgvCarta1 != null)
        {
          dgvCarta1.CellClick -= cellEventHandler1;
          dgvCarta1.CellDoubleClick -= cellEventHandler2;
        }
        this._dgvCarta = value;
        DataGridView dgvCarta2 = this._dgvCarta;
        if (dgvCarta2 == null)
          return;
        dgvCarta2.CellClick += cellEventHandler1;
        dgvCarta2.CellDoubleClick += cellEventHandler2;
      }
    }

    internal virtual TabPage TabPage_Detail { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual CheckBox chbActivo { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Label Label_IsActive { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Button btnAtras
    {
      get
      {
        return this._btnAtras;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.btnAtras_Click);
        Button btnAtras1 = this._btnAtras;
        if (btnAtras1 != null)
          btnAtras1.Click -= eventHandler;
        this._btnAtras = value;
        Button btnAtras2 = this._btnAtras;
        if (btnAtras2 == null)
          return;
        btnAtras2.Click += eventHandler;
      }
    }

    internal virtual Button btnGuardar
    {
      get
      {
        return this._btnGuardar;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.btnGuardar_Click);
        Button btnGuardar1 = this._btnGuardar;
        if (btnGuardar1 != null)
          btnGuardar1.Click -= eventHandler;
        this._btnGuardar = value;
        Button btnGuardar2 = this._btnGuardar;
        if (btnGuardar2 == null)
          return;
        btnGuardar2.Click += eventHandler;
      }
    }

    internal virtual Button btnTecladoNombreCorto
    {
      get
      {
        return this._btnTecladoNombreCorto;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.btnTecladoNombreCorto_Click);
        Button tecladoNombreCorto1 = this._btnTecladoNombreCorto;
        if (tecladoNombreCorto1 != null)
          tecladoNombreCorto1.Click -= eventHandler;
        this._btnTecladoNombreCorto = value;
        Button tecladoNombreCorto2 = this._btnTecladoNombreCorto;
        if (tecladoNombreCorto2 == null)
          return;
        tecladoNombreCorto2.Click += eventHandler;
      }
    }

    internal virtual TextBox txtNombreCorto { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Label Label_DesShort { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Button btnTecladoNombre
    {
      get
      {
        return this._btnTecladoNombre;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.btnTecladoNombre_Click);
        Button btnTecladoNombre1 = this._btnTecladoNombre;
        if (btnTecladoNombre1 != null)
          btnTecladoNombre1.Click -= eventHandler;
        this._btnTecladoNombre = value;
        Button btnTecladoNombre2 = this._btnTecladoNombre;
        if (btnTecladoNombre2 == null)
          return;
        btnTecladoNombre2.Click += eventHandler;
      }
    }

    internal virtual Label Label_Des { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual TextBox txtNombre
    {
      get
      {
        return this._txtNombre;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.txtNombre_TextChanged);
        TextBox txtNombre1 = this._txtNombre;
        if (txtNombre1 != null)
          txtNombre1.TextChanged -= eventHandler;
        this._txtNombre = value;
        TextBox txtNombre2 = this._txtNombre;
        if (txtNombre2 == null)
          return;
        txtNombre2.TextChanged += eventHandler;
      }
    }

    internal virtual Label Label_Id { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual TextBox txtCartaId { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual TabPage TabPage_Productos { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual ToolStripStatusLabel ToolStripStatusLabel_Operation { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual StatusStrip StatusStrip_Properties { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual ToolStripStatusLabel Tssl_Record { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Button btnAgregarItem
    {
      get
      {
        return this._btnAgregarItem;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.btnAgregarItem_Click);
        Button btnAgregarItem1 = this._btnAgregarItem;
        if (btnAgregarItem1 != null)
          btnAgregarItem1.Click -= eventHandler;
        this._btnAgregarItem = value;
        Button btnAgregarItem2 = this._btnAgregarItem;
        if (btnAgregarItem2 == null)
          return;
        btnAgregarItem2.Click += eventHandler;
      }
    }

    internal virtual Button btnBuscarProducto
    {
      get
      {
        return this._btnBuscarProducto;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.btnBuscarProducto_Click);
        Button btnBuscarProducto1 = this._btnBuscarProducto;
        if (btnBuscarProducto1 != null)
          btnBuscarProducto1.Click -= eventHandler;
        this._btnBuscarProducto = value;
        Button btnBuscarProducto2 = this._btnBuscarProducto;
        if (btnBuscarProducto2 == null)
          return;
        btnBuscarProducto2.Click += eventHandler;
      }
    }

    internal virtual Label Label_Product { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Label Label2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Label Label5 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual DataGridView dgvCartaDetalle
    {
      get
      {
        return this._dgvCartaDetalle;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        DataGridViewCellEventHandler cellEventHandler = new DataGridViewCellEventHandler(this.dgvCartaDetalle_CellDoubleClick);
        DataGridView dgvCartaDetalle1 = this._dgvCartaDetalle;
        if (dgvCartaDetalle1 != null)
          dgvCartaDetalle1.CellDoubleClick -= cellEventHandler;
        this._dgvCartaDetalle = value;
        DataGridView dgvCartaDetalle2 = this._dgvCartaDetalle;
        if (dgvCartaDetalle2 == null)
          return;
        dgvCartaDetalle2.CellDoubleClick += cellEventHandler;
      }
    }

    internal virtual NumericTextBox.NumericTextBox txtPrecioSocio { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual NumericTextBox.NumericTextBox txtPrecioPublico { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Label Label6 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual NumericTextBox.NumericTextBox txtPrecioColaborador { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Label Label4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual GroupBox gbPrecios { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Label Label9 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Label Label8 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Label Label7 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Button btnEliminarItem
    {
      get
      {
        return this._btnEliminarItem;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.btnEliminarItem_Click);
        Button btnEliminarItem1 = this._btnEliminarItem;
        if (btnEliminarItem1 != null)
          btnEliminarItem1.Click -= eventHandler;
        this._btnEliminarItem = value;
        Button btnEliminarItem2 = this._btnEliminarItem;
        if (btnEliminarItem2 == null)
          return;
        btnEliminarItem2.Click += eventHandler;
      }
    }

    internal virtual Button btnModificarItem
    {
      get
      {
        return this._btnModificarItem;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.btnModificarItem_Click);
        Button btnModificarItem1 = this._btnModificarItem;
        if (btnModificarItem1 != null)
          btnModificarItem1.Click -= eventHandler;
        this._btnModificarItem = value;
        Button btnModificarItem2 = this._btnModificarItem;
        if (btnModificarItem2 == null)
          return;
        btnModificarItem2.Click += eventHandler;
      }
    }

    internal virtual TextBox txtNombreCartaL { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual TextBox txtProductoNombre { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Label Label1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Label Label3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Label Label10 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Label Label11 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Label Label12 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Label Label13 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Button btnAtrasItem
    {
      get
      {
        return this._btnAtrasItem;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.btnAtrasItem_Click);
        Button btnAtrasItem1 = this._btnAtrasItem;
        if (btnAtrasItem1 != null)
          btnAtrasItem1.Click -= eventHandler;
        this._btnAtrasItem = value;
        Button btnAtrasItem2 = this._btnAtrasItem;
        if (btnAtrasItem2 == null)
          return;
        btnAtrasItem2.Click += eventHandler;
      }
    }

    internal virtual TabControlEx TabControl_Data { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual TextBox txtProductId { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Button btnGuardar2
    {
      get
      {
        return this._btnGuardar2;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.btnGuardar2_Click);
        Button btnGuardar2_1 = this._btnGuardar2;
        if (btnGuardar2_1 != null)
          btnGuardar2_1.Click -= eventHandler;
        this._btnGuardar2 = value;
        Button btnGuardar2_2 = this._btnGuardar2;
        if (btnGuardar2_2 == null)
          return;
        btnGuardar2_2.Click += eventHandler;
      }
    }

    internal virtual DataGridView dgvSalon { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Label Label14 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Label Label15 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual TextBox txtSalonNombre { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Button btnBuscarSalon
    {
      get
      {
        return this._btnBuscarSalon;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.btnBuscarSalon_Click);
        Button btnBuscarSalon1 = this._btnBuscarSalon;
        if (btnBuscarSalon1 != null)
          btnBuscarSalon1.Click -= eventHandler;
        this._btnBuscarSalon = value;
        Button btnBuscarSalon2 = this._btnBuscarSalon;
        if (btnBuscarSalon2 == null)
          return;
        btnBuscarSalon2.Click += eventHandler;
      }
    }

    internal virtual TextBox txtSalonId { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Button btnAgregarSalon
    {
      get
      {
        return this._btnAgregarSalon;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.btnAgregarSalon_Click);
        Button btnAgregarSalon1 = this._btnAgregarSalon;
        if (btnAgregarSalon1 != null)
          btnAgregarSalon1.Click -= eventHandler;
        this._btnAgregarSalon = value;
        Button btnAgregarSalon2 = this._btnAgregarSalon;
        if (btnAgregarSalon2 == null)
          return;
        btnAgregarSalon2.Click += eventHandler;
      }
    }

    internal virtual Button btnEliminarSalon
    {
      get
      {
        return this._btnEliminarSalon;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.btnEliminarSalon_Click);
        Button btnEliminarSalon1 = this._btnEliminarSalon;
        if (btnEliminarSalon1 != null)
          btnEliminarSalon1.Click -= eventHandler;
        this._btnEliminarSalon = value;
        Button btnEliminarSalon2 = this._btnEliminarSalon;
        if (btnEliminarSalon2 == null)
          return;
        btnEliminarSalon2.Click += eventHandler;
      }
    }

    private void FrmCarta_Load(object sender, EventArgs e)
    {
      this.btnListo.Visible = this._SoloBusqueda;
      this.SetearGrid();
      this.SetearGridProducto();
      this.SetearGridSalon();
      this.CargarCartas();
      this.FirstTab((short) 0, "Listado de Cartas", true);
      this.txtBuscar.Select();
      this.txtBuscar.Focus();
    }

    private void FrmCarta_KeyDown(object sender, KeyEventArgs e)
    {
      if (!e.KeyValue.Equals(27))
        return;
      this.Close();
    }

    private void dgvCarta_CellClick(object sender, DataGridViewCellEventArgs e)
    {
      ModGeneralFunctions.GridContarRegistros(this.dgvCarta, this.Tssl_Record);
    }

    private void dgvCarta_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
    {
      if (this._SoloBusqueda)
        this.btnListo_Click((object) null, (EventArgs) null);
      else
        this.btnEditar_Click((object) null, (EventArgs) null);
    }

    private void txtBuscar_TextChanged(object sender, EventArgs e)
    {
      this.CargarCartas();
    }

    private void btnTecladoBuscar_Click(object sender, EventArgs e)
    {
      TextBox txtBuscar;
      string text = (txtBuscar = this.txtBuscar).Text;
      ModGeneralFunctions.TextKeyBoard("Ingrese Nombre", ref text);
      txtBuscar.Text = text;
      if (!ModGeneralVar.g_bol_IsReady)
        return;
      this.txtBuscar.Text = ModGeneralVar.g_str_InputValue;
    }

    private void btnListo_Click(object sender, EventArgs e)
    {
      if (!ModGeneralFunctions.DataGrid_Validated(this.dgvCarta))
        return;
      this.SelectITem();
      ModGeneralVar.g_bol_IsReady = true;
      this.Close();
    }

    private void btnSalir_Click(object sender, EventArgs e)
    {
      this.Close();
    }

    private void btnNuevo_Click(object sender, EventArgs e)
    {
      this.SetOperation(StructApp.RECORD_CREATE);
      this.FirstTab((short) 1, StructApp.RECORD_CREATE, true);
    }

    private void btnEditar_Click(object sender, EventArgs e)
    {
      if (!ModGeneralFunctions.DataGrid_Validated(this.dgvCarta))
        return;
      this.SetOperation(StructApp.RECORD_EDIT);
      this.FirstTab((short) 1, StructApp.RECORD_EDIT, false);
    }

    private void btnEliminar_Click(object sender, EventArgs e)
    {
      if (!ModGeneralFunctions.DataGrid_Validated(this.dgvCarta))
        return;
      this.SetOperation(StructApp.RECORD_DELETE);
    }

    private void btnIrPrimero_Click(object sender, EventArgs e)
    {
      ModGeneralFunctions.GridIrPrimeraFila(this.dgvCarta);
    }

    private void btnIrAnterior_Click(object sender, EventArgs e)
    {
      ModGeneralFunctions.GridIrAnteriorFila(this.dgvCarta);
    }

    private void btnIrSiguiente_Click(object sender, EventArgs e)
    {
      ModGeneralFunctions.GridIrSiguienteFila(this.dgvCarta);
    }

    private void btnIrUltimo_Click(object sender, EventArgs e)
    {
      ModGeneralFunctions.GridIrUltimaFila(this.dgvCarta);
    }

    private void btnTecladoNombre_Click(object sender, EventArgs e)
    {
      TextBox txtNombre;
      string text = (txtNombre = this.txtNombre).Text;
      ModGeneralFunctions.TextKeyBoard("Ingrese Nombre", ref text);
      txtNombre.Text = text;
      if (!ModGeneralVar.g_bol_IsReady)
        return;
      this.txtNombre.Text = ModGeneralVar.g_str_InputValue;
      this.txtNombreCorto.Focus();
    }

    private void txtNombre_TextChanged(object sender, EventArgs e)
    {
      this.txtNombreCorto.Text = this.txtNombre.Text;
      this.txtNombreCartaL.Text = this.txtNombre.Text;
    }

    private void btnTecladoNombreCorto_Click(object sender, EventArgs e)
    {
      TextBox txtNombreCorto;
      string text = (txtNombreCorto = this.txtNombreCorto).Text;
      ModGeneralFunctions.TextKeyBoard("Ingrese Nombre Corto", ref text);
      txtNombreCorto.Text = text;
      if (!ModGeneralVar.g_bol_IsReady)
        return;
      this.txtNombreCorto.Text = ModGeneralVar.g_str_InputValue;
      this.chbActivo.Focus();
    }

    private void btnGuardar_Click(object sender, EventArgs e)
    {
      this.MakeOperation(this.ToolStripStatusLabel_Operation.Text);
    }

    private void btnAtras_Click(object sender, EventArgs e)
    {
      this.FirstTab((short) 0, "Listado de Cartas", true);
    }

    private void btnBuscarProducto_Click(object sender, EventArgs e)
    {
      FrmProductos frmProductos = new FrmProductos();
      frmProductos._nameForm = "Productos";
      frmProductos._OnlySearch = true;
      int num = (int) frmProductos.ShowDialog();
      frmProductos.Dispose();
      if (!ModGeneralVar.g_bol_IsReady)
        return;
      this.txtProductId.Text = ModGeneralVar.g_Str_RecordID;
      this.txtProductoNombre.Text = ModGeneralVar.g_Str_RecordDes;
      ((Control) this.txtPrecioSocio).Focus();
    }

    private void btnAgregarItem_Click(object sender, EventArgs e)
    {
      if (this.intOperacionDetalle == 1 | this.intOperacionDetalle == 0)
        this.EjecutarOperacionDetalle(StructApp.RECORD_CREATE);
      else if (this.intOperacionDetalle == 2)
        this.EjecutarOperacionDetalle(StructApp.RECORD_EDIT);
      this.SetearOperacionDetalle(StructApp.RECORD_CREATE);
    }

    private void btnModificarItem_Click(object sender, EventArgs e)
    {
      if (!ModGeneralFunctions.DataGrid_Validated(this.dgvCartaDetalle))
        return;
      this.SetearOperacionDetalle(StructApp.RECORD_EDIT);
    }

    private void btnEliminarItem_Click(object sender, EventArgs e)
    {
      if (!ModGeneralFunctions.DataGrid_Validated(this.dgvCartaDetalle))
        return;
      this.SetearOperacionDetalle(StructApp.RECORD_DELETE);
    }

    private void btnAtrasItem_Click(object sender, EventArgs e)
    {
      this.FirstTab((short) 1, this.ToolStripStatusLabel_Operation.Text, false);
    }

    private void SetearGrid()
    {
      ModGeneralFunctions.SetUpDataGridViewBasic(this.dgvCarta);
      this.dgvCarta.Columns.Add("CartaId", "Código");
      ModGeneralFunctions.SetUp_TextBoxColumn((DataGridViewTextBoxColumn) this.dgvCarta.Columns[0], "CartaId", (short) 50, "", false, DataGridViewContentAlignment.MiddleLeft, true);
      this.dgvCarta.Columns.Add("Nombre", "Nombre");
      ModGeneralFunctions.SetUp_TextBoxColumn((DataGridViewTextBoxColumn) this.dgvCarta.Columns[1], "Nombre", (short) 273, "", true, DataGridViewContentAlignment.MiddleLeft, true);
      this.dgvCarta.Columns.Add("NombreCorto", "Nombre Corto");
      ModGeneralFunctions.SetUp_TextBoxColumn((DataGridViewTextBoxColumn) this.dgvCarta.Columns[2], "NombreCorto", (short) 180, "", true, DataGridViewContentAlignment.MiddleLeft, true);
      this.dgvCarta.Columns.Add((DataGridViewColumn) new DataGridViewCheckBoxColumn());
      ModGeneralFunctions.SetUp_CheckBoxColumn((DataGridViewCheckBoxColumn) this.dgvCarta.Columns[3], "Activo", "Activo", (short) 60, "", true);
      this.dgvCarta.Columns.Add("", "");
      ModGeneralFunctions.SetUp_TextBoxColumn((DataGridViewTextBoxColumn) this.dgvCarta.Columns[4], "", (short) 15, "", true, DataGridViewContentAlignment.MiddleLeft, true);
      this.dgvCarta.ScrollBars = ScrollBars.Vertical;
    }

    private void SetearGridProducto()
    {
      ModGeneralFunctions.SetUpDataGridViewBasic(this.dgvCartaDetalle);
      this.dgvCartaDetalle.Columns.Add("ProductoId", "Código");
      ModGeneralFunctions.SetUp_TextBoxColumn((DataGridViewTextBoxColumn) this.dgvCartaDetalle.Columns[0], "ProductoId", (short) 50, "", false, DataGridViewContentAlignment.MiddleLeft, true);
      this.dgvCartaDetalle.Columns.Add("ProductoNombre", "Producto");
      ModGeneralFunctions.SetUp_TextBoxColumn((DataGridViewTextBoxColumn) this.dgvCartaDetalle.Columns[1], "ProductoNombre", (short) 300, "", true, DataGridViewContentAlignment.MiddleLeft, true);
      this.dgvCartaDetalle.Columns.Add("Precio1", "Socio");
      ModGeneralFunctions.SetUp_TextBoxColumn((DataGridViewTextBoxColumn) this.dgvCartaDetalle.Columns[2], "Precio1", (short) 97, "0.00", true, DataGridViewContentAlignment.MiddleRight, true);
      this.dgvCartaDetalle.Columns.Add("Precio2", "Colaborador");
      ModGeneralFunctions.SetUp_TextBoxColumn((DataGridViewTextBoxColumn) this.dgvCartaDetalle.Columns[3], "Precio2", (short) 97, "0.00", true, DataGridViewContentAlignment.MiddleRight, true);
      this.dgvCartaDetalle.Columns.Add("Precio3", "Público");
      ModGeneralFunctions.SetUp_TextBoxColumn((DataGridViewTextBoxColumn) this.dgvCartaDetalle.Columns[4], "Precio3", (short) 97, "0.00", true, DataGridViewContentAlignment.MiddleRight, true);
      this.dgvCartaDetalle.Columns.Add("", "");
      ModGeneralFunctions.SetUp_TextBoxColumn((DataGridViewTextBoxColumn) this.dgvCartaDetalle.Columns[5], "", (short) 15, "", true, DataGridViewContentAlignment.MiddleLeft, true);
      this.dgvCartaDetalle.ScrollBars = ScrollBars.Vertical;
    }

    private void SetearGridSalon()
    {
      ModGeneralFunctions.SetUpDataGridViewBasic(this.dgvSalon);
      this.dgvSalon.Columns.Add("SalonId", "Código");
      ModGeneralFunctions.SetUp_TextBoxColumn((DataGridViewTextBoxColumn) this.dgvSalon.Columns[0], "SalonId", (short) 50, "", false, DataGridViewContentAlignment.MiddleLeft, true);
      this.dgvSalon.Columns.Add("SalonNombre", "Salón");
      ModGeneralFunctions.SetUp_TextBoxColumn((DataGridViewTextBoxColumn) this.dgvSalon.Columns[1], "SalonNombre", (short) 490, "", true, DataGridViewContentAlignment.MiddleLeft, true);
      this.dgvSalon.Columns.Add("", "");
      ModGeneralFunctions.SetUp_TextBoxColumn((DataGridViewTextBoxColumn) this.dgvSalon.Columns[2], "", (short) 15, "", true, DataGridViewContentAlignment.MiddleLeft, true);
      this.dgvSalon.ScrollBars = ScrollBars.Vertical;
    }

    private void CargarCartas()
    {
      this.dgvCarta.DataSource = (object) new BL_TR1_CARTA().Listar(this.txtBuscar.Text);
      this.Information_Quantity_Of_Records();
    }

    private void CargarDetalleCarta(int pintCartaId)
    {
      this.LlenarDetalleCarta(new BL_TR1_CARTA_PRODUCTO().Listar(ModGeneralVar.g_BE_TR1_VARIABLES_B.get_EstabliId(), pintCartaId));
      this.ContarRegistrosDetalle();
    }

    private void CargarDetalleCartaSalon(int pintCartaId)
    {
      this.LlenarDetalleCartaSalon(new BL_TR1_CARTA_PRODUCTO().ListarCartaSalon(ModGeneralVar.g_BE_TR1_VARIABLES_B.get_EstabliId(), pintCartaId));
    }

    private void LlenarDetalleCarta(List<BE_TR1_CARTA_PRODUCTO> oListaCARTA_PRODUCTO)
    {
      this.dgvCartaDetalle.DataSource = (object) null;
      this.dgvCartaDetalle.DataSource = (object) oListaCARTA_PRODUCTO;
      this.dgvCartaDetalle.Refresh();
    }

    private void LlenarDetalleCartaSalon(List<BE_TR1_CARTA_SALON> oListaCARTA_SALON)
    {
      this.dgvSalon.DataSource = (object) null;
      this.dgvSalon.DataSource = (object) oListaCARTA_SALON;
      this.dgvSalon.Refresh();
    }

    private void LimpiarDetalleCarta()
    {
      this.dgvCartaDetalle.DataSource = (object) null;
      this.dgvCartaDetalle.Refresh();
    }

    private void LimpiarDetalleCartaSalon()
    {
      this.dgvSalon.DataSource = (object) null;
      this.dgvSalon.Refresh();
    }

    private void Information_Quantity_Of_Records()
    {
      if (!ModGeneralFunctions.DataGrid_Validated(this.dgvCarta))
        return;
      this.Tssl_Record.Text = "Actual: " + Conversions.ToString(checked (this.dgvCarta.CurrentRow.Index + 1)) + " /  Total de Registros: " + Conversions.ToString(this.dgvCarta.RowCount);
    }

    private void ContarRegistrosDetalle()
    {
      if (!ModGeneralFunctions.DataGrid_Validated(this.dgvCartaDetalle))
        return;
      this.Tssl_Record.Text = "Actual: " + Conversions.ToString(checked (this.dgvCartaDetalle.CurrentRow.Index + 1)) + " /  Total de Registros: " + Conversions.ToString(this.dgvCartaDetalle.RowCount);
    }

    private void FirstTab(short _Index, string _Text, bool bolNuevo)
    {
      this.ToolStripStatusLabel_Operation.Text = _Text;
      ((TabControl) this.TabControl_Data).SelectedIndex = (int) _Index;
      if (_Index == (short) 0)
      {
        TabControlEx tabControlData1 = this.TabControl_Data;
        TabPage tabPage = this.TabPage_Detail;
        ref TabPage local1 = ref tabPage;
        tabControlData1.DisablePage(ref local1);
        this.TabPage_Detail = tabPage;
        TabControlEx tabControlData2 = this.TabControl_Data;
        tabPage = this.TabPage_Productos;
        ref TabPage local2 = ref tabPage;
        tabControlData2.DisablePage(ref local2);
        this.TabPage_Productos = tabPage;
        this.TabPage_Listado.Enabled = true;
        this.Information_Quantity_Of_Records();
        this.txtBuscar.Focus();
      }
      else
      {
        TabControlEx tabControlData1 = this.TabControl_Data;
        TabPage tabPageListado = this.TabPage_Listado;
        ref TabPage local1 = ref tabPageListado;
        tabControlData1.DisablePage(ref local1);
        this.TabPage_Listado = tabPageListado;
        this.TabPage_Detail.Enabled = true;
        if (bolNuevo)
        {
          TabControlEx tabControlData2 = this.TabControl_Data;
          TabPage tabPageProductos = this.TabPage_Productos;
          ref TabPage local2 = ref tabPageProductos;
          tabControlData2.DisablePage(ref local2);
          this.TabPage_Productos = tabPageProductos;
        }
        else
          this.TabPage_Productos.Enabled = true;
        this.ContarRegistrosDetalle();
        this.txtNombre.Focus();
      }
    }

    private void SetOperation(string _Operation)
    {
      this.ToolStripStatusLabel_Operation.Text = _Operation;
      if (_Operation.Equals(StructApp.RECORD_CREATE))
      {
        this.txtCartaId.Text = "";
        this.txtNombre.Text = this.txtBuscar.Text.Trim();
        this.txtNombreCorto.Text = this.txtBuscar.Text.Trim();
        this.chbActivo.Checked = true;
        this.LimpiarDetalleCartaSalon();
        this.LimpiarDetalleCarta();
        this.txtNombre.Focus();
      }
      else if (_Operation.Equals(StructApp.RECORD_EDIT))
      {
        this.txtCartaId.Text = Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateIndexGet(this.dgvCarta.DataSource, new object[1]
        {
          (object) this.dgvCarta.CurrentRow.Index
        }, (string[]) null), (System.Type) null, "CartaId", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
        this.txtNombre.Text = Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateIndexGet(this.dgvCarta.DataSource, new object[1]
        {
          (object) this.dgvCarta.CurrentRow.Index
        }, (string[]) null), (System.Type) null, "Nombre", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
        this.txtNombreCorto.Text = Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateIndexGet(this.dgvCarta.DataSource, new object[1]
        {
          (object) this.dgvCarta.CurrentRow.Index
        }, (string[]) null), (System.Type) null, "NombreCorto", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
        this.chbActivo.Checked = (Conversions.ToBoolean(NewLateBinding.LateGet(NewLateBinding.LateIndexGet(this.dgvCarta.DataSource, new object[1]
        {
          (object) this.dgvCarta.CurrentRow.Index
        }, (string[]) null), (System.Type) null, "Activo", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null)) ? 1 : 0) != 0;
        this.CargarDetalleCarta(ModGeneralFunctions.CadenaToInteger(this.txtCartaId.Text));
        this.CargarDetalleCartaSalon(ModGeneralFunctions.CadenaToInteger(this.txtCartaId.Text));
        this.txtNombre.Focus();
      }
      else
      {
        if (!_Operation.Equals(StructApp.RECORD_DELETE))
          return;
        this.txtCartaId.Text = Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateIndexGet(this.dgvCarta.DataSource, new object[1]
        {
          (object) this.dgvCarta.CurrentRow.Index
        }, (string[]) null), (System.Type) null, "CartaId", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
        this.txtNombre.Text = Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateIndexGet(this.dgvCarta.DataSource, new object[1]
        {
          (object) this.dgvCarta.CurrentRow.Index
        }, (string[]) null), (System.Type) null, "Nombre", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
        this.MakeOperation(this.ToolStripStatusLabel_Operation.Text);
      }
    }

    private void MakeOperation(string _Operation)
    {
      BL_TR1_CARTA blTr1Carta1 = new BL_TR1_CARTA();
      string str = "";
      List<BE_TR1_CARTA_PRODUCTO> tr1CartaProductoList;
      BE_TR1_CARTA beTr1Carta1;
      BL_TR1_CARTA blTr1Carta2;
      if (_Operation.Equals(StructApp.RECORD_CREATE))
      {
        if (!this.Valid_Data())
          return;
        if (ModGeneralFunctions.MessageMakeAction("¿Seguro de Guardar los Datos?", false))
        {
          BE_TR1_CARTA beTr1Carta2 = new BE_TR1_CARTA();
          beTr1Carta2.set_LocalId(ModGeneralVar.g_BE_TR1_VARIABLES_B.get_EstabliId());
          beTr1Carta2.set_CartaId(ModGeneralFunctions.CadenaToInteger(this.txtCartaId.Text));
          beTr1Carta2.set_Nombre(this.txtNombre.Text.Trim());
          beTr1Carta2.set_NombreCorto(this.txtNombreCorto.Text.Trim());
          beTr1Carta2.set_Activo(this.chbActivo.Checked);
          beTr1Carta2.set_UsuarioCrea(ModGeneralVar.g_BE_USERS.get_UserId());
          tr1CartaProductoList = (List<BE_TR1_CARTA_PRODUCTO>) this.dgvCartaDetalle.DataSource;
          List<BE_TR1_CARTA_SALON> dataSource = (List<BE_TR1_CARTA_SALON>) this.dgvSalon.DataSource;
          string p_Mensaje = blTr1Carta1.Insertar(ref beTr1Carta2, dataSource);
          if (p_Mensaje.Equals(StructApp.RESULT_OK))
          {
            this.txtCartaId.Text = "";
            this.CargarCartas();
            this.Ubicate_Record(Conversions.ToString(beTr1Carta2.get_CartaId()));
            this.Information_Quantity_Of_Records();
            ModGeneralFunctions.MessageOk("¡Registro Creado!");
            this.FirstTab((short) 0, "Listado de Cartas", true);
          }
          else
            ModGeneralFunctions.MessageError_Large(p_Mensaje, true);
          beTr1Carta1 = (BE_TR1_CARTA) null;
          blTr1Carta2 = (BL_TR1_CARTA) null;
        }
      }
      else if (_Operation.Equals(StructApp.RECORD_EDIT))
      {
        if (!this.Valid_Data())
          return;
        if (ModGeneralFunctions.MessageMakeAction("¿Seguro de Editar los Datos?", false))
        {
          BE_TR1_CARTA beTr1Carta2 = new BE_TR1_CARTA();
          beTr1Carta2.set_LocalId(ModGeneralVar.g_BE_TR1_VARIABLES_B.get_EstabliId());
          beTr1Carta2.set_CartaId(ModGeneralFunctions.CadenaToInteger(this.txtCartaId.Text));
          beTr1Carta2.set_Nombre(this.txtNombre.Text.Trim());
          beTr1Carta2.set_NombreCorto(this.txtNombreCorto.Text.Trim());
          beTr1Carta2.set_Activo(this.chbActivo.Checked);
          beTr1Carta2.set_UsuarioMod(ModGeneralVar.g_BE_USERS.get_UserId());
          tr1CartaProductoList = (List<BE_TR1_CARTA_PRODUCTO>) this.dgvCartaDetalle.DataSource;
          List<BE_TR1_CARTA_SALON> dataSource = (List<BE_TR1_CARTA_SALON>) this.dgvSalon.DataSource;
          string p_Mensaje = blTr1Carta1.Modificar(ref beTr1Carta2, dataSource);
          if (p_Mensaje.Equals(StructApp.RESULT_OK))
          {
            this.txtCartaId.Text = "";
            this.CargarCartas();
            this.Ubicate_Record(Conversions.ToString(beTr1Carta2.get_CartaId()));
            this.Information_Quantity_Of_Records();
            ModGeneralFunctions.MessageOk("¡Registro Editado!");
            this.FirstTab((short) 0, "Listado de Cartas", true);
          }
          else
            ModGeneralFunctions.MessageError_Large(p_Mensaje, true);
          beTr1Carta1 = (BE_TR1_CARTA) null;
          blTr1Carta2 = (BL_TR1_CARTA) null;
        }
      }
      else if (_Operation.Equals(StructApp.RECORD_DELETE))
      {
        if (ModGeneralFunctions.MessageMakeAction("¿Seguro de Eliminar la Carta: " + this.txtNombre.Text + "?", false))
        {
          BE_TR1_CARTA beTr1Carta2 = new BE_TR1_CARTA();
          beTr1Carta2.set_LocalId(ModGeneralVar.g_BE_TR1_VARIABLES_B.get_EstabliId());
          beTr1Carta2.set_CartaId(Conversions.ToInteger(this.txtCartaId.Text.Trim()));
          beTr1Carta2.set_Nombre(this.txtNombre.Text);
          string p_Mensaje = blTr1Carta1.Eliminar(beTr1Carta2.get_LocalId(), beTr1Carta2.get_CartaId());
          if (p_Mensaje.Equals(StructApp.RESULT_OK))
          {
            short index = checked ((short) this.dgvCarta.CurrentRow.Index);
            this.CargarCartas();
            if (this.dgvCarta.Rows.Count > 1 & index > (short) 0)
              this.dgvCarta.CurrentCell = this.dgvCarta[1, checked ((int) index - 1)];
            this.Information_Quantity_Of_Records();
            ModGeneralFunctions.MessageOk("¡Registro Eliminado!");
          }
          else
            ModGeneralFunctions.MessageError_Large(p_Mensaje, true);
          this.FirstTab((short) 0, "Listado de Cartas", true);
        }
      }
      else if (_Operation.Equals(StructApp.RECORD_SEARCH))
      {
        this.CargarCartas();
        this.Information_Quantity_Of_Records();
        this.FirstTab((short) 0, "Listado de Cartas", true);
      }
      beTr1Carta1 = (BE_TR1_CARTA) null;
      tr1CartaProductoList = (List<BE_TR1_CARTA_PRODUCTO>) null;
      blTr1Carta2 = (BL_TR1_CARTA) null;
      str = (string) null;
    }

    private void SelectITem()
    {
      try
      {
        ModGeneralVar.g_Str_RecordID = Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateIndexGet(this.dgvCarta.DataSource, new object[1]
        {
          (object) this.dgvCarta.CurrentRow.Index
        }, (string[]) null), (System.Type) null, "ContactId", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
        ModGeneralVar.g_Str_RecordDes = Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateIndexGet(this.dgvCarta.DataSource, new object[1]
        {
          (object) this.dgvCarta.CurrentRow.Index
        }, (string[]) null), (System.Type) null, "ContactName", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
    }

    private void Ubicate_Record(string _ItemToUbicate)
    {
      int num = checked (this.dgvCarta.Rows.Count - 1);
      int index = 0;
      while (index <= num)
      {
        if (Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateIndexGet(this.dgvCarta.DataSource, new object[1]
        {
          (object) index
        }, (string[]) null), (System.Type) null, "CartaId", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null)).Equals(_ItemToUbicate))
        {
          this.dgvCarta.CurrentCell = this.dgvCarta[1, index];
          break;
        }
        checked { ++index; }
      }
    }

    private void UbicarItemDetalle(string _ItemToUbicate)
    {
      int num = checked (this.dgvCartaDetalle.Rows.Count - 1);
      int index = 0;
      while (index <= num)
      {
        if (Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateIndexGet(this.dgvCartaDetalle.DataSource, new object[1]
        {
          (object) index
        }, (string[]) null), (System.Type) null, "ProductoId", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null)).Equals(_ItemToUbicate))
        {
          try
          {
            this.dgvCartaDetalle.CurrentCell = this.dgvCartaDetalle[1, index];
            break;
          }
          catch (Exception ex)
          {
            ProjectData.SetProjectError(ex);
            ProjectData.ClearProjectError();
            break;
          }
        }
        else
          checked { ++index; }
      }
    }

    private void UbicarItemDetalleSalon(string _ItemToUbicate)
    {
      int num = checked (this.dgvSalon.Rows.Count - 1);
      int index = 0;
      while (index <= num)
      {
        if (Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateIndexGet(this.dgvSalon.DataSource, new object[1]
        {
          (object) index
        }, (string[]) null), (System.Type) null, "SalonId", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null)).Equals(_ItemToUbicate))
        {
          try
          {
            this.dgvSalon.CurrentCell = this.dgvSalon[1, index];
            break;
          }
          catch (Exception ex)
          {
            ProjectData.SetProjectError(ex);
            ProjectData.ClearProjectError();
            break;
          }
        }
        else
          checked { ++index; }
      }
    }

    private bool Valid_Data()
    {
      if (this.txtNombre.Text.Trim().Equals(""))
      {
        ModGeneralFunctions.MessageOk("¡Ingrese Nombre!");
        this.txtNombre.Focus();
        return false;
      }
      if (!this.txtNombreCorto.Text.Trim().Equals(""))
        return true;
      ModGeneralFunctions.MessageOk("¡Ingrese Nombre Corto!");
      this.txtNombreCorto.Focus();
      return false;
    }

    private bool ValidarItemDetalle()
    {
      if (this.txtProductId.Text.Trim().Equals(""))
      {
        ModGeneralFunctions.MessageOk("¡Seleccione Producto!");
        this.btnBuscarProducto.Focus();
        return false;
      }
      if (this.txtProductoNombre.Text.Trim().Equals(""))
      {
        ModGeneralFunctions.MessageOk("¡Seleccione Producto!");
        this.btnBuscarProducto.Focus();
        return false;
      }
      if (Operators.ConditionalCompareObjectEqual(ModGeneralFunctions.ObtenerAPPCONFIG("PERMITIR_PRECIO_CERO_AL_PRODUCTO"), (object) false, false))
      {
        if (ModGeneralFunctions.CadenaToDouble(((TextBox) this.txtPrecioSocio).Text) == 0.0)
        {
          ModGeneralFunctions.MessageOk("¡Ingrese Precio de Socio!");
          this.btnBuscarProducto.Focus();
          return false;
        }
        if (ModGeneralFunctions.CadenaToDouble(((TextBox) this.txtPrecioColaborador).Text) == 0.0)
        {
          ModGeneralFunctions.MessageOk("¡Ingrese Precio de Colaborador!");
          ((Control) this.txtPrecioColaborador).Focus();
          return false;
        }
        if (ModGeneralFunctions.CadenaToDouble(((TextBox) this.txtPrecioPublico).Text) == 0.0)
        {
          ModGeneralFunctions.MessageOk("¡Ingrese Precio de Público!");
          ((Control) this.txtPrecioPublico).Focus();
          return false;
        }
      }
      return true;
    }

    private bool ValidarItemDetalleSalon()
    {
      if (this.txtSalonId.Text.Trim().Equals(""))
      {
        ModGeneralFunctions.MessageOk("¡Seleccione Salón!");
        this.btnBuscarSalon.Focus();
        return false;
      }
      if (!this.txtSalonNombre.Text.Trim().Equals(""))
        return true;
      ModGeneralFunctions.MessageOk("¡Seleccione Salón!");
      this.btnBuscarSalon.Focus();
      return false;
    }

    private void SetearOperacionDetalle(string _Operation)
    {
      if (_Operation.Equals(StructApp.RECORD_CREATE))
      {
        this.intOperacionDetalle = 1;
        this.txtProductId.Text = "";
        this.txtProductoNombre.Text = "";
        ((TextBox) this.txtPrecioSocio).Text = "0.00";
        ((TextBox) this.txtPrecioColaborador).Text = "0.00";
        ((TextBox) this.txtPrecioPublico).Text = "0.00";
        this.btnBuscarProducto.Focus();
      }
      else if (_Operation.Equals(StructApp.RECORD_EDIT))
      {
        this.intOperacionDetalle = 2;
        this.txtProductId.Text = Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateIndexGet(this.dgvCartaDetalle.DataSource, new object[1]
        {
          (object) this.dgvCartaDetalle.CurrentRow.Index
        }, (string[]) null), (System.Type) null, "ProductoId", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
        this.txtProductoNombre.Text = Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateIndexGet(this.dgvCartaDetalle.DataSource, new object[1]
        {
          (object) this.dgvCartaDetalle.CurrentRow.Index
        }, (string[]) null), (System.Type) null, "ProductoNombre", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
        ((TextBox) this.txtPrecioSocio).Text = Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateIndexGet(this.dgvCartaDetalle.DataSource, new object[1]
        {
          (object) this.dgvCartaDetalle.CurrentRow.Index
        }, (string[]) null), (System.Type) null, "Precio1", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
        ((TextBox) this.txtPrecioColaborador).Text = Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateIndexGet(this.dgvCartaDetalle.DataSource, new object[1]
        {
          (object) this.dgvCartaDetalle.CurrentRow.Index
        }, (string[]) null), (System.Type) null, "Precio2", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
        ((TextBox) this.txtPrecioPublico).Text = Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateIndexGet(this.dgvCartaDetalle.DataSource, new object[1]
        {
          (object) this.dgvCartaDetalle.CurrentRow.Index
        }, (string[]) null), (System.Type) null, "Precio3", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
        ((Control) this.txtPrecioSocio).Focus();
      }
      else
      {
        if (!_Operation.Equals(StructApp.RECORD_DELETE))
          return;
        this.txtProductId.Text = Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateIndexGet(this.dgvCartaDetalle.DataSource, new object[1]
        {
          (object) this.dgvCartaDetalle.CurrentRow.Index
        }, (string[]) null), (System.Type) null, "ProductoId", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
        this.txtProductoNombre.Text = Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateIndexGet(this.dgvCartaDetalle.DataSource, new object[1]
        {
          (object) this.dgvCartaDetalle.CurrentRow.Index
        }, (string[]) null), (System.Type) null, "ProductoNombre", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
        if (ModGeneralFunctions.MessageMakeAction("¿Seguro de eliminar: " + this.txtProductoNombre.Text + "?", false))
          this.EjecutarOperacionDetalle(StructApp.RECORD_DELETE);
      }
    }

    private void EjecutarOperacionDetalle(string _Operation)
    {
      BL_TR1_CARTA_PRODUCTO tr1CartaProducto1 = new BL_TR1_CARTA_PRODUCTO();
      string str = "";
      if (_Operation.Equals(StructApp.RECORD_CREATE))
      {
        if (!this.ValidarItemDetalle())
          return;
        BE_TR1_CARTA_PRODUCTO tr1CartaProducto2 = new BE_TR1_CARTA_PRODUCTO();
        tr1CartaProducto2.set_LocalId(ModGeneralVar.g_BE_TR1_VARIABLES_B.get_EstabliId());
        tr1CartaProducto2.set_CartaId(ModGeneralFunctions.CadenaToInteger(this.txtCartaId.Text));
        tr1CartaProducto2.set_ProductoId(this.txtProductId.Text.Trim());
        tr1CartaProducto2.set_ProductoNombre(this.txtProductoNombre.Text.Trim());
        tr1CartaProducto2.set_Precio1(ModGeneralFunctions.CadenaToDouble(((TextBox) this.txtPrecioSocio).Text));
        tr1CartaProducto2.set_Precio2(ModGeneralFunctions.CadenaToDouble(((TextBox) this.txtPrecioColaborador).Text));
        tr1CartaProducto2.set_Precio3(ModGeneralFunctions.CadenaToDouble(((TextBox) this.txtPrecioPublico).Text));
        tr1CartaProducto2.set_UsuarioCrea(ModGeneralVar.g_BE_USERS.get_UserId());
        string p_Mensaje = tr1CartaProducto1.Insertar(tr1CartaProducto2);
        if (p_Mensaje.Equals(StructApp.RESULT_OK))
        {
          this.CargarDetalleCarta(ModGeneralFunctions.CadenaToInteger(this.txtCartaId.Text));
          this.UbicarItemDetalle(tr1CartaProducto2.get_ProductoId());
        }
        else
          ModGeneralFunctions.MessageOk(p_Mensaje);
      }
      else if (_Operation.Equals(StructApp.RECORD_EDIT))
      {
        if (!this.ValidarItemDetalle())
          return;
        BE_TR1_CARTA_PRODUCTO tr1CartaProducto2 = new BE_TR1_CARTA_PRODUCTO();
        tr1CartaProducto2.set_LocalId(ModGeneralVar.g_BE_TR1_VARIABLES_B.get_EstabliId());
        tr1CartaProducto2.set_CartaId(ModGeneralFunctions.CadenaToInteger(this.txtCartaId.Text));
        tr1CartaProducto2.set_ProductoId(this.txtProductId.Text.Trim());
        tr1CartaProducto2.set_ProductoNombre(this.txtProductoNombre.Text.Trim());
        tr1CartaProducto2.set_Precio1(ModGeneralFunctions.CadenaToDouble(((TextBox) this.txtPrecioSocio).Text));
        tr1CartaProducto2.set_Precio2(ModGeneralFunctions.CadenaToDouble(((TextBox) this.txtPrecioColaborador).Text));
        tr1CartaProducto2.set_Precio3(ModGeneralFunctions.CadenaToDouble(((TextBox) this.txtPrecioPublico).Text));
        tr1CartaProducto2.set_UsuarioMod(ModGeneralVar.g_BE_USERS.get_UserId());
        string p_Mensaje = tr1CartaProducto1.Modificar(tr1CartaProducto2);
        if (p_Mensaje.Equals(StructApp.RESULT_OK))
        {
          this.CargarDetalleCarta(ModGeneralFunctions.CadenaToInteger(this.txtCartaId.Text));
          this.UbicarItemDetalle(tr1CartaProducto2.get_ProductoId());
        }
        else
          ModGeneralFunctions.MessageOk(p_Mensaje);
      }
      else if (_Operation.Equals(StructApp.RECORD_DELETE))
      {
        string p_Mensaje = tr1CartaProducto1.Eliminar(ModGeneralFunctions.CadenaToInteger(this.txtCartaId.Text), this.txtProductId.Text);
        if (p_Mensaje.Equals(StructApp.RESULT_OK))
        {
          this.CargarDetalleCarta(ModGeneralFunctions.CadenaToInteger(this.txtCartaId.Text));
          this.SetearOperacionDetalle(StructApp.RECORD_CREATE);
        }
        else
          ModGeneralFunctions.MessageOk(p_Mensaje);
      }
      BE_TR1_CARTA_PRODUCTO tr1CartaProducto3 = (BE_TR1_CARTA_PRODUCTO) null;
      tr1CartaProducto3 = (BE_TR1_CARTA_PRODUCTO) null;
      str = (string) null;
    }

    private void SetearOperacionDetalleSalon(string _Operation)
    {
      if (_Operation.Equals(StructApp.RECORD_CREATE))
      {
        this.txtSalonId.Text = "";
        this.txtSalonNombre.Text = "";
        this.btnBuscarSalon.Focus();
      }
      else
      {
        if (!_Operation.Equals(StructApp.RECORD_DELETE))
          return;
        this.EjecutarOperacionDetalleSalon(StructApp.RECORD_DELETE);
      }
    }

    private void EjecutarOperacionDetalleSalon(string _Operation)
    {
      if (_Operation.Equals(StructApp.RECORD_CREATE))
      {
        if (!this.ValidarItemDetalleSalon())
          return;
        BE_TR1_CARTA_SALON beTr1CartaSalon = new BE_TR1_CARTA_SALON();
        beTr1CartaSalon.set_LocalId(ModGeneralVar.g_BE_TR1_VARIABLES_B.get_EstabliId());
        beTr1CartaSalon.set_CartaId(ModGeneralFunctions.CadenaToInteger(this.txtCartaId.Text));
        beTr1CartaSalon.set_SalonId(ModGeneralFunctions.CadenaToInteger(this.txtSalonId.Text));
        beTr1CartaSalon.set_SalonNombre(this.txtSalonNombre.Text.Trim());
        List<BE_TR1_CARTA_SALON> oListaCARTA_SALON = (List<BE_TR1_CARTA_SALON>) this.dgvSalon.DataSource ?? new List<BE_TR1_CARTA_SALON>();
        oListaCARTA_SALON.Add(beTr1CartaSalon);
        this.LlenarDetalleCartaSalon(oListaCARTA_SALON);
        this.UbicarItemDetalleSalon(Conversions.ToString(beTr1CartaSalon.get_SalonId()));
      }
      else if (_Operation.Equals(StructApp.RECORD_DELETE))
      {
        List<BE_TR1_CARTA_SALON> dataSource = (List<BE_TR1_CARTA_SALON>) this.dgvSalon.DataSource;
        dataSource.RemoveAt(this.dgvSalon.CurrentRow.Index);
        this.LlenarDetalleCartaSalon(dataSource);
      }
    }

    private void dgvCartaDetalle_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
    {
      if (!ModGeneralFunctions.DataGrid_Validated(this.dgvCartaDetalle))
        return;
      this.SetearOperacionDetalle(StructApp.RECORD_EDIT);
    }

    private void btnGuardar2_Click(object sender, EventArgs e)
    {
      this.MakeOperation(this.ToolStripStatusLabel_Operation.Text);
    }

    private void btnBuscarSalon_Click(object sender, EventArgs e)
    {
      FrmHall frmHall = new FrmHall();
      frmHall._OnlySearch = true;
      int num = (int) frmHall.ShowDialog();
      frmHall.Dispose();
      if (!ModGeneralVar.g_bol_IsReady)
        return;
      this.txtSalonId.Text = ModGeneralVar.g_Str_RecordID;
      this.txtSalonNombre.Text = ModGeneralVar.g_Str_RecordDes;
    }

    private void btnAgregarSalon_Click(object sender, EventArgs e)
    {
      this.EjecutarOperacionDetalleSalon(StructApp.RECORD_CREATE);
      this.SetearOperacionDetalleSalon(StructApp.RECORD_CREATE);
    }

    private void btnEliminarSalon_Click(object sender, EventArgs e)
    {
      if (!ModGeneralFunctions.DataGrid_Validated(this.dgvSalon))
        return;
      this.SetearOperacionDetalleSalon(StructApp.RECORD_DELETE);
    }
  }
}
