// Decompiled with JetBrains decompiler
// Type: TriNetRestPOS.FrmCargos
// Assembly: TriNetRestPOS, Version=5.2.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 43377352-E952-4AC1-9BA6-CCBE4AE5F575
// Assembly location: C:\log\TriNetRestPOS.exe

using APP_Utilities;
using Microsoft.VisualBasic.CompilerServices;
using System;
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
  public class FrmCargos : Form
  {
    private IContainer components;
    public bool bolSoloLectura;

    public FrmCargos()
    {
      this.Load += new EventHandler(this.FrmCargos_Load);
      this.KeyDown += new KeyEventHandler(this.FrmCargos_KeyDown);
      this.bolSoloLectura = false;
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
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (FrmCargos));
      this.sstDetalle = new StatusStrip();
      this.tssOperacion = new ToolStripStatusLabel();
      this.tssContador = new ToolStripStatusLabel();
      this.tcPrincipal = new TabControlEx();
      this.tpgListado = new TabPage();
      this.pnlOpciones1 = new Panel();
      this.btnBuscarTeclado = new Button();
      this.btnSalir = new Button();
      this.btnListo = new Button();
      this.Label_Description = new Label();
      this.txtBuscarNombre = new TextBox();
      this.pnlOpciones2 = new Panel();
      this.btnEliminar = new Button();
      this.btnPrimero = new Button();
      this.btnAnterior = new Button();
      this.btnEditar = new Button();
      this.btnSiguiente = new Button();
      this.btnUltimo = new Button();
      this.btnNuevo = new Button();
      this.dgvLista = new DataGridView();
      this.tpgDetalle = new TabPage();
      this.chbEsActivo = new CheckBox();
      this.Label_IsActive = new Label();
      this.btnAtras = new Button();
      this.btnGuardar = new Button();
      this.btnNombreCortoTeclado = new Button();
      this.txtNombreCorto = new TextBox();
      this.Label_DesShort = new Label();
      this.btnNombreTeclado = new Button();
      this.Label_Des = new Label();
      this.txtNombre = new TextBox();
      this.Label_Id = new Label();
      this.txtCargoId = new TextBox();
      this.sstDetalle.SuspendLayout();
      ((Control) this.tcPrincipal).SuspendLayout();
      this.tpgListado.SuspendLayout();
      this.pnlOpciones1.SuspendLayout();
      this.pnlOpciones2.SuspendLayout();
      ((ISupportInitialize) this.dgvLista).BeginInit();
      this.tpgDetalle.SuspendLayout();
      this.SuspendLayout();
      this.sstDetalle.BackColor = Color.Transparent;
      this.sstDetalle.Font = new Font("Trebuchet MS", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.sstDetalle.Items.AddRange(new ToolStripItem[2]
      {
        (ToolStripItem) this.tssOperacion,
        (ToolStripItem) this.tssContador
      });
      this.sstDetalle.Location = new Point(0, 552);
      this.sstDetalle.Name = "sstDetalle";
      this.sstDetalle.Size = new Size(530, 22);
      this.sstDetalle.TabIndex = 165;
      this.tssOperacion.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.tssOperacion.ForeColor = Color.Black;
      this.tssOperacion.Name = "tssOperacion";
      this.tssOperacion.Size = new Size(71, 17);
      this.tssOperacion.Text = "Operacion";
      this.tssContador.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.tssContador.ForeColor = Color.Black;
      this.tssContador.Name = "tssContador";
      this.tssContador.Size = new Size(444, 17);
      this.tssContador.Spring = true;
      this.tssContador.Text = "Contador";
      this.tssContador.TextAlign = ContentAlignment.MiddleRight;
      ((Control) this.tcPrincipal).Controls.Add((Control) this.tpgListado);
      ((Control) this.tcPrincipal).Controls.Add((Control) this.tpgDetalle);
      ((Control) this.tcPrincipal).Dock = DockStyle.Top;
      ((Control) this.tcPrincipal).Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      ((Control) this.tcPrincipal).Location = new Point(0, 0);
      ((Control) this.tcPrincipal).Name = "tcPrincipal";
      ((TabControl) this.tcPrincipal).SelectedIndex = 0;
      ((Control) this.tcPrincipal).Size = new Size(530, 552);
      ((Control) this.tcPrincipal).TabIndex = 166;
      this.tpgListado.Controls.Add((Control) this.pnlOpciones1);
      this.tpgListado.Controls.Add((Control) this.Label_Description);
      this.tpgListado.Controls.Add((Control) this.txtBuscarNombre);
      this.tpgListado.Controls.Add((Control) this.pnlOpciones2);
      this.tpgListado.Controls.Add((Control) this.dgvLista);
      this.tpgListado.Font = new Font("Verdana", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.tpgListado.Location = new Point(4, 27);
      this.tpgListado.Name = "tpgListado";
      this.tpgListado.Padding = new Padding(3);
      this.tpgListado.Size = new Size(522, 521);
      this.tpgListado.TabIndex = 0;
      this.tpgListado.Text = "Listado";
      this.tpgListado.UseVisualStyleBackColor = true;
      this.pnlOpciones1.Controls.Add((Control) this.btnBuscarTeclado);
      this.pnlOpciones1.Controls.Add((Control) this.btnSalir);
      this.pnlOpciones1.Controls.Add((Control) this.btnListo);
      this.pnlOpciones1.Location = new Point(275, 3);
      this.pnlOpciones1.Name = "pnlOpciones1";
      this.pnlOpciones1.Size = new Size(251, 67);
      this.pnlOpciones1.TabIndex = 162;
      this.btnBuscarTeclado.BackgroundImage = (Image) TriNetRestPOS.My.Resources.Resources.teclado_icon;
      this.btnBuscarTeclado.FlatStyle = FlatStyle.Flat;
      this.btnBuscarTeclado.Font = new Font("Trebuchet MS", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.btnBuscarTeclado.ForeColor = Color.WhiteSmoke;
      this.btnBuscarTeclado.ImageAlign = ContentAlignment.BottomCenter;
      this.btnBuscarTeclado.Location = new Point(0, 31);
      this.btnBuscarTeclado.Name = "btnBuscarTeclado";
      this.btnBuscarTeclado.Size = new Size(45, 27);
      this.btnBuscarTeclado.TabIndex = 148;
      this.btnBuscarTeclado.TextAlign = ContentAlignment.TopCenter;
      this.btnBuscarTeclado.UseVisualStyleBackColor = true;
      this.btnSalir.BackgroundImage = (Image) TriNetRestPOS.My.Resources.Resources.boton_rojo;
      this.btnSalir.FlatStyle = FlatStyle.Flat;
      this.btnSalir.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.btnSalir.ForeColor = Color.WhiteSmoke;
      this.btnSalir.Image = (Image) TriNetRestPOS.My.Resources.Resources.salir;
      this.btnSalir.ImageAlign = ContentAlignment.TopCenter;
      this.btnSalir.Location = new Point(169, 3);
      this.btnSalir.Name = "btnSalir";
      this.btnSalir.Padding = new Padding(0, 5, 0, 5);
      this.btnSalir.Size = new Size(74, 58);
      this.btnSalir.TabIndex = 161;
      this.btnSalir.Text = "Salir";
      this.btnSalir.TextAlign = ContentAlignment.BottomCenter;
      this.btnSalir.UseVisualStyleBackColor = true;
      this.btnListo.BackgroundImage = (Image) TriNetRestPOS.My.Resources.Resources.boton_guardar;
      this.btnListo.FlatStyle = FlatStyle.Flat;
      this.btnListo.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.btnListo.ForeColor = Color.WhiteSmoke;
      this.btnListo.Image = (Image) TriNetRestPOS.My.Resources.Resources.check_OK;
      this.btnListo.ImageAlign = ContentAlignment.TopCenter;
      this.btnListo.Location = new Point(93, 3);
      this.btnListo.Name = "btnListo";
      this.btnListo.Padding = new Padding(0, 5, 0, 5);
      this.btnListo.Size = new Size(74, 58);
      this.btnListo.TabIndex = 160;
      this.btnListo.Text = "Listo";
      this.btnListo.TextAlign = ContentAlignment.BottomCenter;
      this.btnListo.UseVisualStyleBackColor = true;
      this.btnListo.Visible = false;
      this.Label_Description.AutoSize = true;
      this.Label_Description.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Label_Description.ForeColor = Color.FromArgb(150, 150, 150);
      this.Label_Description.Location = new Point(6, 13);
      this.Label_Description.Name = "Label_Description";
      this.Label_Description.Size = new Size(63, 16);
      this.Label_Description.TabIndex = 147;
      this.Label_Description.Text = "Nombre :";
      this.txtBuscarNombre.BorderStyle = BorderStyle.FixedSingle;
      this.txtBuscarNombre.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.txtBuscarNombre.Location = new Point(18, 34);
      this.txtBuscarNombre.MaxLength = 35;
      this.txtBuscarNombre.Multiline = true;
      this.txtBuscarNombre.Name = "txtBuscarNombre";
      this.txtBuscarNombre.Size = new Size(260, 27);
      this.txtBuscarNombre.TabIndex = 0;
      this.pnlOpciones2.Controls.Add((Control) this.btnEliminar);
      this.pnlOpciones2.Controls.Add((Control) this.btnPrimero);
      this.pnlOpciones2.Controls.Add((Control) this.btnAnterior);
      this.pnlOpciones2.Controls.Add((Control) this.btnEditar);
      this.pnlOpciones2.Controls.Add((Control) this.btnSiguiente);
      this.pnlOpciones2.Controls.Add((Control) this.btnUltimo);
      this.pnlOpciones2.Controls.Add((Control) this.btnNuevo);
      this.pnlOpciones2.Location = new Point(441, 71);
      this.pnlOpciones2.Name = "pnlOpciones2";
      this.pnlOpciones2.Size = new Size(86, 449);
      this.pnlOpciones2.TabIndex = 124;
      this.btnEliminar.BackgroundImage = (Image) TriNetRestPOS.My.Resources.Resources.boton_cuadrado_rojo;
      this.btnEliminar.FlatStyle = FlatStyle.Flat;
      this.btnEliminar.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.btnEliminar.ForeColor = Color.WhiteSmoke;
      this.btnEliminar.Image = (Image) TriNetRestPOS.My.Resources.Resources.eliminar_icono;
      this.btnEliminar.ImageAlign = ContentAlignment.TopCenter;
      this.btnEliminar.Location = new Point(6, 129);
      this.btnEliminar.Name = "btnEliminar";
      this.btnEliminar.Padding = new Padding(0, 5, 0, 5);
      this.btnEliminar.RightToLeft = RightToLeft.Yes;
      this.btnEliminar.Size = new Size(69, 65);
      this.btnEliminar.TabIndex = 148;
      this.btnEliminar.Text = "Eliminar";
      this.btnEliminar.TextAlign = ContentAlignment.BottomCenter;
      this.btnEliminar.UseVisualStyleBackColor = true;
      this.btnPrimero.BackgroundImage = (Image) componentResourceManager.GetObject("btnPrimero.BackgroundImage");
      this.btnPrimero.FlatStyle = FlatStyle.Flat;
      this.btnPrimero.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.btnPrimero.ForeColor = Color.WhiteSmoke;
      this.btnPrimero.Image = (Image) TriNetRestPOS.My.Resources.Resources.flecha_inicio;
      this.btnPrimero.Location = new Point(6, 193);
      this.btnPrimero.Name = "btnPrimero";
      this.btnPrimero.RightToLeft = RightToLeft.Yes;
      this.btnPrimero.Size = new Size(69, 65);
      this.btnPrimero.TabIndex = 32;
      this.btnPrimero.UseVisualStyleBackColor = true;
      this.btnAnterior.BackgroundImage = (Image) componentResourceManager.GetObject("btnAnterior.BackgroundImage");
      this.btnAnterior.FlatStyle = FlatStyle.Flat;
      this.btnAnterior.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.btnAnterior.ForeColor = Color.WhiteSmoke;
      this.btnAnterior.Image = (Image) TriNetRestPOS.My.Resources.Resources.flecha_arriba;
      this.btnAnterior.Location = new Point(6, 257);
      this.btnAnterior.Name = "btnAnterior";
      this.btnAnterior.RightToLeft = RightToLeft.Yes;
      this.btnAnterior.Size = new Size(69, 65);
      this.btnAnterior.TabIndex = 33;
      this.btnAnterior.UseVisualStyleBackColor = true;
      this.btnEditar.BackgroundImage = (Image) componentResourceManager.GetObject("btnEditar.BackgroundImage");
      this.btnEditar.FlatStyle = FlatStyle.Flat;
      this.btnEditar.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.btnEditar.ForeColor = Color.WhiteSmoke;
      this.btnEditar.Image = (Image) TriNetRestPOS.My.Resources.Resources.icono_editar;
      this.btnEditar.ImageAlign = ContentAlignment.TopCenter;
      this.btnEditar.Location = new Point(6, 65);
      this.btnEditar.Name = "btnEditar";
      this.btnEditar.Padding = new Padding(0, 5, 0, 5);
      this.btnEditar.Size = new Size(69, 65);
      this.btnEditar.TabIndex = 147;
      this.btnEditar.Text = "&Editar";
      this.btnEditar.TextAlign = ContentAlignment.BottomCenter;
      this.btnEditar.UseVisualStyleBackColor = true;
      this.btnSiguiente.BackgroundImage = (Image) componentResourceManager.GetObject("btnSiguiente.BackgroundImage");
      this.btnSiguiente.FlatStyle = FlatStyle.Flat;
      this.btnSiguiente.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.btnSiguiente.ForeColor = Color.WhiteSmoke;
      this.btnSiguiente.Image = (Image) TriNetRestPOS.My.Resources.Resources.flecha_abajo;
      this.btnSiguiente.Location = new Point(6, 321);
      this.btnSiguiente.Name = "btnSiguiente";
      this.btnSiguiente.RightToLeft = RightToLeft.Yes;
      this.btnSiguiente.Size = new Size(69, 65);
      this.btnSiguiente.TabIndex = 34;
      this.btnSiguiente.UseVisualStyleBackColor = true;
      this.btnUltimo.BackgroundImage = (Image) componentResourceManager.GetObject("btnUltimo.BackgroundImage");
      this.btnUltimo.FlatStyle = FlatStyle.Flat;
      this.btnUltimo.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.btnUltimo.ForeColor = Color.WhiteSmoke;
      this.btnUltimo.Image = (Image) TriNetRestPOS.My.Resources.Resources.flecha_final;
      this.btnUltimo.Location = new Point(6, 385);
      this.btnUltimo.Name = "btnUltimo";
      this.btnUltimo.RightToLeft = RightToLeft.Yes;
      this.btnUltimo.Size = new Size(69, 65);
      this.btnUltimo.TabIndex = 35;
      this.btnUltimo.UseVisualStyleBackColor = true;
      this.btnNuevo.BackgroundImage = (Image) componentResourceManager.GetObject("btnNuevo.BackgroundImage");
      this.btnNuevo.FlatStyle = FlatStyle.Flat;
      this.btnNuevo.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.btnNuevo.ForeColor = Color.WhiteSmoke;
      this.btnNuevo.Image = (Image) TriNetRestPOS.My.Resources.Resources.icono_nuevo;
      this.btnNuevo.ImageAlign = ContentAlignment.TopCenter;
      this.btnNuevo.Location = new Point(6, 1);
      this.btnNuevo.Name = "btnNuevo";
      this.btnNuevo.Padding = new Padding(0, 5, 0, 5);
      this.btnNuevo.Size = new Size(69, 65);
      this.btnNuevo.TabIndex = 146;
      this.btnNuevo.Text = "&Nuevo";
      this.btnNuevo.TextAlign = ContentAlignment.BottomCenter;
      this.btnNuevo.UseVisualStyleBackColor = true;
      this.dgvLista.BorderStyle = BorderStyle.Fixed3D;
      this.dgvLista.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dgvLista.Location = new Point(3, 71);
      this.dgvLista.MultiSelect = false;
      this.dgvLista.Name = "dgvLista";
      this.dgvLista.ScrollBars = ScrollBars.None;
      this.dgvLista.Size = new Size(437, 449);
      this.dgvLista.TabIndex = 1;
      this.tpgDetalle.Controls.Add((Control) this.chbEsActivo);
      this.tpgDetalle.Controls.Add((Control) this.Label_IsActive);
      this.tpgDetalle.Controls.Add((Control) this.btnAtras);
      this.tpgDetalle.Controls.Add((Control) this.btnGuardar);
      this.tpgDetalle.Controls.Add((Control) this.btnNombreCortoTeclado);
      this.tpgDetalle.Controls.Add((Control) this.txtNombreCorto);
      this.tpgDetalle.Controls.Add((Control) this.Label_DesShort);
      this.tpgDetalle.Controls.Add((Control) this.btnNombreTeclado);
      this.tpgDetalle.Controls.Add((Control) this.Label_Des);
      this.tpgDetalle.Controls.Add((Control) this.txtNombre);
      this.tpgDetalle.Controls.Add((Control) this.Label_Id);
      this.tpgDetalle.Controls.Add((Control) this.txtCargoId);
      this.tpgDetalle.Location = new Point(4, 27);
      this.tpgDetalle.Name = "tpgDetalle";
      this.tpgDetalle.Padding = new Padding(3);
      this.tpgDetalle.Size = new Size(522, 521);
      this.tpgDetalle.TabIndex = 1;
      this.tpgDetalle.Text = "Mantenimiento";
      this.tpgDetalle.UseVisualStyleBackColor = true;
      this.chbEsActivo.AutoSize = true;
      this.chbEsActivo.FlatStyle = FlatStyle.Flat;
      this.chbEsActivo.Font = new Font("Trebuchet MS", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.chbEsActivo.Location = new Point(103, 315);
      this.chbEsActivo.Name = "chbEsActivo";
      this.chbEsActivo.Size = new Size(12, 11);
      this.chbEsActivo.TabIndex = 7;
      this.chbEsActivo.UseVisualStyleBackColor = true;
      this.Label_IsActive.AutoSize = true;
      this.Label_IsActive.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Label_IsActive.ForeColor = Color.FromArgb(150, 150, 150);
      this.Label_IsActive.Location = new Point(31, 313);
      this.Label_IsActive.Name = "Label_IsActive";
      this.Label_IsActive.Size = new Size(48, 16);
      this.Label_IsActive.TabIndex = 163;
      this.Label_IsActive.Text = "Activo:";
      this.btnAtras.BackgroundImage = (Image) TriNetRestPOS.My.Resources.Resources.BotonRojo;
      this.btnAtras.FlatStyle = FlatStyle.Flat;
      this.btnAtras.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.btnAtras.ForeColor = Color.WhiteSmoke;
      this.btnAtras.Image = (Image) TriNetRestPOS.My.Resources.Resources.salir;
      this.btnAtras.ImageAlign = ContentAlignment.TopCenter;
      this.btnAtras.Location = new Point(322, 418);
      this.btnAtras.Name = "btnAtras";
      this.btnAtras.Padding = new Padding(0, 5, 0, 5);
      this.btnAtras.Size = new Size(114, 60);
      this.btnAtras.TabIndex = 9;
      this.btnAtras.Text = "&Atrás";
      this.btnAtras.TextAlign = ContentAlignment.BottomCenter;
      this.btnAtras.UseVisualStyleBackColor = true;
      this.btnGuardar.BackgroundImage = (Image) TriNetRestPOS.My.Resources.Resources.BotonVerde;
      this.btnGuardar.FlatStyle = FlatStyle.Flat;
      this.btnGuardar.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.btnGuardar.ForeColor = Color.WhiteSmoke;
      this.btnGuardar.Image = (Image) TriNetRestPOS.My.Resources.Resources.check_OK;
      this.btnGuardar.ImageAlign = ContentAlignment.TopCenter;
      this.btnGuardar.Location = new Point(201, 418);
      this.btnGuardar.Name = "btnGuardar";
      this.btnGuardar.Padding = new Padding(0, 5, 0, 5);
      this.btnGuardar.Size = new Size(119, 60);
      this.btnGuardar.TabIndex = 8;
      this.btnGuardar.Text = "&Grabar";
      this.btnGuardar.TextAlign = ContentAlignment.BottomCenter;
      this.btnGuardar.UseVisualStyleBackColor = true;
      this.btnNombreCortoTeclado.BackgroundImage = (Image) componentResourceManager.GetObject("btnNombreCortoTeclado.BackgroundImage");
      this.btnNombreCortoTeclado.FlatStyle = FlatStyle.Flat;
      this.btnNombreCortoTeclado.Font = new Font("Trebuchet MS", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.btnNombreCortoTeclado.ForeColor = Color.WhiteSmoke;
      this.btnNombreCortoTeclado.ImageAlign = ContentAlignment.BottomCenter;
      this.btnNombreCortoTeclado.Location = new Point(395, 241);
      this.btnNombreCortoTeclado.Name = "btnNombreCortoTeclado";
      this.btnNombreCortoTeclado.Size = new Size(45, 27);
      this.btnNombreCortoTeclado.TabIndex = 4;
      this.btnNombreCortoTeclado.TextAlign = ContentAlignment.TopCenter;
      this.btnNombreCortoTeclado.UseVisualStyleBackColor = true;
      this.txtNombreCorto.Font = new Font("Trebuchet MS", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.txtNombreCorto.Location = new Point(34, 242);
      this.txtNombreCorto.MaxLength = 50;
      this.txtNombreCorto.Name = "txtNombreCorto";
      this.txtNombreCorto.Size = new Size(352, 25);
      this.txtNombreCorto.TabIndex = 3;
      this.Label_DesShort.AutoSize = true;
      this.Label_DesShort.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Label_DesShort.ForeColor = Color.FromArgb(150, 150, 150);
      this.Label_DesShort.Location = new Point(30, 216);
      this.Label_DesShort.Name = "Label_DesShort";
      this.Label_DesShort.Size = new Size(118, 16);
      this.Label_DesShort.TabIndex = 155;
      this.Label_DesShort.Text = "Descripción Corta:";
      this.btnNombreTeclado.BackgroundImage = (Image) componentResourceManager.GetObject("btnNombreTeclado.BackgroundImage");
      this.btnNombreTeclado.FlatStyle = FlatStyle.Flat;
      this.btnNombreTeclado.Font = new Font("Trebuchet MS", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.btnNombreTeclado.ForeColor = Color.WhiteSmoke;
      this.btnNombreTeclado.ImageAlign = ContentAlignment.BottomCenter;
      this.btnNombreTeclado.Location = new Point(395, 130);
      this.btnNombreTeclado.Name = "btnNombreTeclado";
      this.btnNombreTeclado.Size = new Size(45, 27);
      this.btnNombreTeclado.TabIndex = 2;
      this.btnNombreTeclado.TextAlign = ContentAlignment.TopCenter;
      this.btnNombreTeclado.UseVisualStyleBackColor = true;
      this.Label_Des.AutoSize = true;
      this.Label_Des.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Label_Des.ForeColor = Color.FromArgb(150, 150, 150);
      this.Label_Des.Location = new Point(30, 104);
      this.Label_Des.Name = "Label_Des";
      this.Label_Des.Size = new Size(83, 16);
      this.Label_Des.TabIndex = 151;
      this.Label_Des.Text = "Descripción:";
      this.txtNombre.Font = new Font("Trebuchet MS", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.txtNombre.Location = new Point(33, 131);
      this.txtNombre.MaxLength = 150;
      this.txtNombre.Multiline = true;
      this.txtNombre.Name = "txtNombre";
      this.txtNombre.Size = new Size(352, 54);
      this.txtNombre.TabIndex = 1;
      this.Label_Id.AutoSize = true;
      this.Label_Id.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Label_Id.ForeColor = Color.FromArgb(150, 150, 150);
      this.Label_Id.Location = new Point(30, 35);
      this.Label_Id.Name = "Label_Id";
      this.Label_Id.Size = new Size(55, 16);
      this.Label_Id.TabIndex = 149;
      this.Label_Id.Text = "Código:";
      this.txtCargoId.BackColor = Color.LightGray;
      this.txtCargoId.BorderStyle = BorderStyle.FixedSingle;
      this.txtCargoId.Enabled = false;
      this.txtCargoId.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.txtCargoId.Location = new Point(33, 58);
      this.txtCargoId.Name = "txtCargoId";
      this.txtCargoId.ReadOnly = true;
      this.txtCargoId.Size = new Size(186, 22);
      this.txtCargoId.TabIndex = 0;
      this.AutoScaleDimensions = new SizeF(9f, 20f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.BackColor = SystemColors.Window;
      this.ClientSize = new Size(530, 574);
      this.ControlBox = false;
      this.Controls.Add((Control) this.tcPrincipal);
      this.Controls.Add((Control) this.sstDetalle);
      this.Font = new Font("Trebuchet MS", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.KeyPreview = true;
      this.Margin = new Padding(4, 5, 4, 5);
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = nameof (FrmCargos);
      this.ShowIcon = false;
      this.ShowInTaskbar = false;
      this.StartPosition = FormStartPosition.CenterParent;
      this.Text = "Cargos";
      this.sstDetalle.ResumeLayout(false);
      this.sstDetalle.PerformLayout();
      ((Control) this.tcPrincipal).ResumeLayout(false);
      this.tpgListado.ResumeLayout(false);
      this.tpgListado.PerformLayout();
      this.pnlOpciones1.ResumeLayout(false);
      this.pnlOpciones2.ResumeLayout(false);
      ((ISupportInitialize) this.dgvLista).EndInit();
      this.tpgDetalle.ResumeLayout(false);
      this.tpgDetalle.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();
    }

    internal virtual StatusStrip sstDetalle { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual ToolStripStatusLabel tssOperacion { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual ToolStripStatusLabel tssContador { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual TabControlEx tcPrincipal { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual TabPage tpgListado { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Panel pnlOpciones1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Button btnBuscarTeclado
    {
      get
      {
        return this._btnBuscarTeclado;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.btnBuscarTeclado_Click);
        Button btnBuscarTeclado1 = this._btnBuscarTeclado;
        if (btnBuscarTeclado1 != null)
          btnBuscarTeclado1.Click -= eventHandler;
        this._btnBuscarTeclado = value;
        Button btnBuscarTeclado2 = this._btnBuscarTeclado;
        if (btnBuscarTeclado2 == null)
          return;
        btnBuscarTeclado2.Click += eventHandler;
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

    internal virtual TextBox txtBuscarNombre
    {
      get
      {
        return this._txtBuscarNombre;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.txtBuscarNombre_TextChanged);
        TextBox txtBuscarNombre1 = this._txtBuscarNombre;
        if (txtBuscarNombre1 != null)
          txtBuscarNombre1.TextChanged -= eventHandler;
        this._txtBuscarNombre = value;
        TextBox txtBuscarNombre2 = this._txtBuscarNombre;
        if (txtBuscarNombre2 == null)
          return;
        txtBuscarNombre2.TextChanged += eventHandler;
      }
    }

    internal virtual Panel pnlOpciones2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

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

    internal virtual Button btnPrimero
    {
      get
      {
        return this._btnPrimero;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.btnPrimero_Click);
        Button btnPrimero1 = this._btnPrimero;
        if (btnPrimero1 != null)
          btnPrimero1.Click -= eventHandler;
        this._btnPrimero = value;
        Button btnPrimero2 = this._btnPrimero;
        if (btnPrimero2 == null)
          return;
        btnPrimero2.Click += eventHandler;
      }
    }

    internal virtual Button btnAnterior
    {
      get
      {
        return this._btnAnterior;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.btnAnterior_Click);
        Button btnAnterior1 = this._btnAnterior;
        if (btnAnterior1 != null)
          btnAnterior1.Click -= eventHandler;
        this._btnAnterior = value;
        Button btnAnterior2 = this._btnAnterior;
        if (btnAnterior2 == null)
          return;
        btnAnterior2.Click += eventHandler;
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

    internal virtual Button btnSiguiente
    {
      get
      {
        return this._btnSiguiente;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.btnSiguiente_Click);
        Button btnSiguiente1 = this._btnSiguiente;
        if (btnSiguiente1 != null)
          btnSiguiente1.Click -= eventHandler;
        this._btnSiguiente = value;
        Button btnSiguiente2 = this._btnSiguiente;
        if (btnSiguiente2 == null)
          return;
        btnSiguiente2.Click += eventHandler;
      }
    }

    internal virtual Button btnUltimo
    {
      get
      {
        return this._btnUltimo;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.btnUltimo_Click);
        Button btnUltimo1 = this._btnUltimo;
        if (btnUltimo1 != null)
          btnUltimo1.Click -= eventHandler;
        this._btnUltimo = value;
        Button btnUltimo2 = this._btnUltimo;
        if (btnUltimo2 == null)
          return;
        btnUltimo2.Click += eventHandler;
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

    internal virtual DataGridView dgvLista
    {
      get
      {
        return this._dgvLista;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        DataGridViewCellEventHandler cellEventHandler1 = new DataGridViewCellEventHandler(this.dgvLista_CellClick);
        DataGridViewCellEventHandler cellEventHandler2 = new DataGridViewCellEventHandler(this.dgvLista_CellDoubleClick);
        KeyEventHandler keyEventHandler = new KeyEventHandler(this.dgvLista_KeyUp);
        DataGridView dgvLista1 = this._dgvLista;
        if (dgvLista1 != null)
        {
          dgvLista1.CellClick -= cellEventHandler1;
          dgvLista1.CellDoubleClick -= cellEventHandler2;
          dgvLista1.KeyUp -= keyEventHandler;
        }
        this._dgvLista = value;
        DataGridView dgvLista2 = this._dgvLista;
        if (dgvLista2 == null)
          return;
        dgvLista2.CellClick += cellEventHandler1;
        dgvLista2.CellDoubleClick += cellEventHandler2;
        dgvLista2.KeyUp += keyEventHandler;
      }
    }

    internal virtual TabPage tpgDetalle { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual CheckBox chbEsActivo { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

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

    internal virtual Button btnNombreCortoTeclado
    {
      get
      {
        return this._btnNombreCortoTeclado;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.btnNombreCortoTeclado_Click);
        Button nombreCortoTeclado1 = this._btnNombreCortoTeclado;
        if (nombreCortoTeclado1 != null)
          nombreCortoTeclado1.Click -= eventHandler;
        this._btnNombreCortoTeclado = value;
        Button nombreCortoTeclado2 = this._btnNombreCortoTeclado;
        if (nombreCortoTeclado2 == null)
          return;
        nombreCortoTeclado2.Click += eventHandler;
      }
    }

    internal virtual TextBox txtNombreCorto { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Label Label_DesShort { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Button btnNombreTeclado
    {
      get
      {
        return this._btnNombreTeclado;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.btnNombreTeclado_Click);
        Button btnNombreTeclado1 = this._btnNombreTeclado;
        if (btnNombreTeclado1 != null)
          btnNombreTeclado1.Click -= eventHandler;
        this._btnNombreTeclado = value;
        Button btnNombreTeclado2 = this._btnNombreTeclado;
        if (btnNombreTeclado2 == null)
          return;
        btnNombreTeclado2.Click += eventHandler;
      }
    }

    internal virtual Label Label_Des { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual TextBox txtNombre { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Label Label_Id { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual TextBox txtCargoId { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    private void FrmCargos_Load(object sender, EventArgs e)
    {
      this.btnListo.Visible = this.bolSoloLectura;
      this.SetearGrid();
      this.CargarCargos();
      ModGeneralFunctions.GridContarRegistros(this.dgvLista, this.tssContador);
      this.txtBuscarNombre.Focus();
    }

    private void FrmCargos_KeyDown(object sender, KeyEventArgs e)
    {
      if (!e.KeyValue.Equals(27))
        return;
      if (((TabControl) this.tcPrincipal).SelectedIndex == 0)
        this.btnSalir_Click((object) null, (EventArgs) null);
      else if (((TabControl) this.tcPrincipal).SelectedIndex == 1)
        this.btnAtras_Click((object) null, (EventArgs) null);
    }

    private void txtBuscarNombre_TextChanged(object sender, EventArgs e)
    {
      this.CargarCargos();
    }

    private void btnBuscarTeclado_Click(object sender, EventArgs e)
    {
      TextBox txtBuscarNombre;
      string text = (txtBuscarNombre = this.txtBuscarNombre).Text;
      ModGeneralFunctions.TextKeyBoard("Ingrese Nombre", ref text);
      txtBuscarNombre.Text = text;
      if (!ModGeneralVar.g_bol_IsReady)
        return;
      this.txtBuscarNombre.Text = ModGeneralVar.g_str_InputValue;
      this.CargarCargos();
    }

    private void btnListo_Click(object sender, EventArgs e)
    {
      if (!ModGeneralFunctions.DataGrid_Validated(this.dgvLista))
        return;
      this.SeleccionarItem();
      ModGeneralVar.g_bol_IsReady = true;
      this.Close();
    }

    private void btnSalir_Click(object sender, EventArgs e)
    {
      ModGeneralVar.g_bol_IsReady = false;
      this.Close();
    }

    private void btnNuevo_Click(object sender, EventArgs e)
    {
      this.SetearOperacion(StructApp.RECORD_CREATE);
    }

    private void btnEditar_Click(object sender, EventArgs e)
    {
      if (!ModGeneralFunctions.DataGrid_Validated(this.dgvLista))
        return;
      this.SetearOperacion(StructApp.RECORD_EDIT);
    }

    private void btnEliminar_Click(object sender, EventArgs e)
    {
      if (!ModGeneralFunctions.DataGrid_Validated(this.dgvLista))
        return;
      this.SetearOperacion(StructApp.RECORD_DELETE);
    }

    private void btnPrimero_Click(object sender, EventArgs e)
    {
      ModGeneralFunctions.GridIrPrimeraFila(this.dgvLista);
      ModGeneralFunctions.GridContarRegistros(this.dgvLista, this.tssContador);
    }

    private void btnAnterior_Click(object sender, EventArgs e)
    {
      ModGeneralFunctions.GridIrAnteriorFila(this.dgvLista);
      ModGeneralFunctions.GridContarRegistros(this.dgvLista, this.tssContador);
    }

    private void btnSiguiente_Click(object sender, EventArgs e)
    {
      ModGeneralFunctions.GridIrSiguienteFila(this.dgvLista);
      ModGeneralFunctions.GridContarRegistros(this.dgvLista, this.tssContador);
    }

    private void btnUltimo_Click(object sender, EventArgs e)
    {
      ModGeneralFunctions.GridIrUltimaFila(this.dgvLista);
      ModGeneralFunctions.GridContarRegistros(this.dgvLista, this.tssContador);
    }

    private void dgvLista_CellClick(object sender, DataGridViewCellEventArgs e)
    {
      ModGeneralFunctions.GridContarRegistros(this.dgvLista, this.tssContador);
    }

    private void dgvLista_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
    {
      if (this.bolSoloLectura)
        this.btnListo_Click((object) null, (EventArgs) null);
      else
        this.btnEditar_Click((object) null, (EventArgs) null);
    }

    private void dgvLista_KeyUp(object sender, KeyEventArgs e)
    {
      ModGeneralFunctions.GridContarRegistros(this.dgvLista, this.tssContador);
    }

    private void btnNombreTeclado_Click(object sender, EventArgs e)
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

    private void btnNombreCortoTeclado_Click(object sender, EventArgs e)
    {
      TextBox txtNombreCorto;
      string text = (txtNombreCorto = this.txtNombreCorto).Text;
      ModGeneralFunctions.TextKeyBoard("Ingrese Nombre Corto", ref text);
      txtNombreCorto.Text = text;
      if (!ModGeneralVar.g_bol_IsReady)
        return;
      this.txtNombreCorto.Text = ModGeneralVar.g_str_InputValue;
      this.chbEsActivo.Focus();
    }

    private void btnGuardar_Click(object sender, EventArgs e)
    {
      this.EjecutarOperacion(this.tssOperacion.Text);
    }

    private void btnAtras_Click(object sender, EventArgs e)
    {
      this.MoverTab((short) 0, "Listado de Cargos");
    }

    private void SetearGrid()
    {
      ModGeneralFunctions.SetUpDataGridViewBasicNuevo(this.dgvLista);
      this.dgvLista.Columns.Add("Nombre", "Nombre");
      ModGeneralFunctions.SetUp_TextBoxColumn1((DataGridViewTextBoxColumn) this.dgvLista.Columns[0], "Nombre", (short) 230, "", true, DataGridViewContentAlignment.MiddleLeft, true);
      this.dgvLista.Columns.Add("NombreCorto", "Nombre Corto");
      ModGeneralFunctions.SetUp_TextBoxColumn1((DataGridViewTextBoxColumn) this.dgvLista.Columns[1], "NombreCorto", (short) 130, "", true, DataGridViewContentAlignment.MiddleLeft, true);
      this.dgvLista.Columns.Add((DataGridViewColumn) new DataGridViewCheckBoxColumn());
      ModGeneralFunctions.SetUp_CheckBoxColumn1((DataGridViewCheckBoxColumn) this.dgvLista.Columns[2], "Activo", "EsActivo", (short) 60, "", true);
      this.dgvLista.ScrollBars = ScrollBars.Vertical;
    }

    private void CargarCargos()
    {
      this.dgvLista.DataSource = (object) new BL_TR1_CARGOS().ListarTodoxNombre(ModGeneralVar.g_BE_TR1_VARIABLES_B.get_EstabliId(), this.txtBuscarNombre.Text.Trim());
    }

    private void SeleccionarItem()
    {
      ModGeneralVar.g_Str_RecordID = Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateIndexGet(this.dgvLista.DataSource, new object[1]
      {
        (object) this.dgvLista.CurrentRow.Index
      }, (string[]) null), (System.Type) null, "CargoId", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      ModGeneralVar.g_Str_RecordDes = Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateIndexGet(this.dgvLista.DataSource, new object[1]
      {
        (object) this.dgvLista.CurrentRow.Index
      }, (string[]) null), (System.Type) null, "Nombre", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
    }

    private void SetearOperacion(string pstrOperacion)
    {
      this.tssOperacion.Text = pstrOperacion;
      if (pstrOperacion.Equals(StructApp.RECORD_CREATE))
      {
        this.txtCargoId.Text = "";
        this.txtNombre.Text = "";
        this.txtNombreCorto.Text = "";
        this.chbEsActivo.Checked = true;
        this.txtNombre.Focus();
        this.MoverTab((short) 1, pstrOperacion);
      }
      else if (pstrOperacion.Equals(StructApp.RECORD_EDIT))
      {
        this.txtCargoId.Text = Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateIndexGet(this.dgvLista.DataSource, new object[1]
        {
          (object) this.dgvLista.CurrentRow.Index
        }, (string[]) null), (System.Type) null, "CargoId", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
        this.txtNombre.Text = Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateIndexGet(this.dgvLista.DataSource, new object[1]
        {
          (object) this.dgvLista.CurrentRow.Index
        }, (string[]) null), (System.Type) null, "Nombre", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
        this.txtNombreCorto.Text = Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateIndexGet(this.dgvLista.DataSource, new object[1]
        {
          (object) this.dgvLista.CurrentRow.Index
        }, (string[]) null), (System.Type) null, "NombreCorto", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
        this.chbEsActivo.Checked = (Conversions.ToBoolean(NewLateBinding.LateGet(NewLateBinding.LateIndexGet(this.dgvLista.DataSource, new object[1]
        {
          (object) this.dgvLista.CurrentRow.Index
        }, (string[]) null), (System.Type) null, "EsActivo", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null)) ? 1 : 0) != 0;
        this.txtNombre.Focus();
        this.MoverTab((short) 1, pstrOperacion);
      }
      else
      {
        if (!pstrOperacion.Equals(StructApp.RECORD_DELETE))
          return;
        this.txtCargoId.Text = Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateIndexGet(this.dgvLista.DataSource, new object[1]
        {
          (object) this.dgvLista.CurrentRow.Index
        }, (string[]) null), (System.Type) null, "CargoId", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
        this.txtNombre.Text = Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateIndexGet(this.dgvLista.DataSource, new object[1]
        {
          (object) this.dgvLista.CurrentRow.Index
        }, (string[]) null), (System.Type) null, "Nombre", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
        this.EjecutarOperacion(pstrOperacion);
      }
    }

    private void EjecutarOperacion(string pstrOperacion)
    {
      BL_TR1_CARGOS blTr1Cargos = new BL_TR1_CARGOS();
      string str = "";
      BE_TR1_CARGOS beTr1Cargos1;
      if (pstrOperacion.Equals(StructApp.RECORD_CREATE))
      {
        if (!this.ValidarDatos())
          return;
        if (ModGeneralFunctions.MessageMakeAction("¿Seguro de Guardar Cargo?", false))
        {
          beTr1Cargos1 = new BE_TR1_CARGOS();
          beTr1Cargos1.set_EstabliId(ModGeneralVar.g_BE_TR1_VARIABLES_B.get_EstabliId());
          beTr1Cargos1.set_Nombre(this.txtNombre.Text);
          beTr1Cargos1.set_NombreCorto(this.txtNombreCorto.Text);
          beTr1Cargos1.set_EsActivo(this.chbEsActivo.Checked);
          beTr1Cargos1.set_UsuCre(ModGeneralVar.g_BE_USERS.get_UserId());
          string p_Mensaje = blTr1Cargos.Insertar(ref beTr1Cargos1);
          if (p_Mensaje.Equals(StructApp.RESULT_OK))
          {
            this.CargarCargos();
            this.UbicarFila(Conversions.ToString(beTr1Cargos1.get_CargoId()));
            ModGeneralFunctions.GridContarRegistros(this.dgvLista, this.tssContador);
            this.MoverTab((short) 0, "Listado de Cargos");
            ModGeneralFunctions.MessageOk("¡Registro Creado!");
          }
          else
            ModGeneralFunctions.MessageError_Large(p_Mensaje, true);
        }
      }
      else if (pstrOperacion.Equals(StructApp.RECORD_EDIT))
      {
        if (!this.ValidarDatos())
          return;
        if (ModGeneralFunctions.MessageMakeAction("¿Seguro de Editar Cargo?", false))
        {
          BE_TR1_CARGOS beTr1Cargos2 = new BE_TR1_CARGOS();
          beTr1Cargos2.set_EstabliId(ModGeneralVar.g_BE_TR1_VARIABLES_B.get_EstabliId());
          beTr1Cargos2.set_CargoId(ModGeneralFunctions.CadenaToInteger(this.txtCargoId.Text));
          beTr1Cargos2.set_Nombre(this.txtNombre.Text);
          beTr1Cargos2.set_NombreCorto(this.txtNombreCorto.Text);
          beTr1Cargos2.set_EsActivo(this.chbEsActivo.Checked);
          beTr1Cargos2.set_UsuMod(ModGeneralVar.g_BE_USERS.get_UserId());
          string p_Mensaje = blTr1Cargos.Editar(beTr1Cargos2);
          if (p_Mensaje.Equals(StructApp.RESULT_OK))
          {
            this.CargarCargos();
            this.UbicarFila(Conversions.ToString(beTr1Cargos2.get_CargoId()));
            ModGeneralFunctions.GridContarRegistros(this.dgvLista, this.tssContador);
            this.MoverTab((short) 0, "Listado de Cargos");
            ModGeneralFunctions.MessageOk("¡Registro Editado!");
          }
          else
            ModGeneralFunctions.MessageError_Large(p_Mensaje, true);
        }
      }
      else if (pstrOperacion.Equals(StructApp.RECORD_DELETE) && ModGeneralFunctions.MessageMakeAction("¿Seguro de Eliminar: " + this.txtNombre.Text + "?", false))
      {
        string p_Mensaje = blTr1Cargos.Eliminar(ModGeneralVar.g_BE_TR1_VARIABLES_B.get_EstabliId(), Conversions.ToInteger(this.txtCargoId.Text));
        if (p_Mensaje.Equals(StructApp.RESULT_OK))
        {
          short index = checked ((short) this.dgvLista.CurrentRow.Index);
          this.CargarCargos();
          ModGeneralFunctions.GridContarRegistros(this.dgvLista, this.tssContador);
          this.MoverTab((short) 0, "Listado de Cargos");
          ModGeneralFunctions.MessageOk("¡Registro Eliminado!");
        }
        else
          ModGeneralFunctions.MessageError_Large(p_Mensaje, true);
      }
      beTr1Cargos1 = (BE_TR1_CARGOS) null;
      str = (string) null;
    }

    private void MoverTab(short pintIndice, string pstrTexto)
    {
      this.tssOperacion.Text = pstrTexto;
      ((TabControl) this.tcPrincipal).SelectedIndex = (int) pintIndice;
      if (pintIndice == (short) 0)
      {
        TabControlEx tcPrincipal = this.tcPrincipal;
        TabPage tpgDetalle = this.tpgDetalle;
        ref TabPage local = ref tpgDetalle;
        tcPrincipal.DisablePage(ref local);
        this.tpgDetalle = tpgDetalle;
        this.tpgListado.Enabled = true;
        this.txtBuscarNombre.Focus();
      }
      else
      {
        TabControlEx tcPrincipal = this.tcPrincipal;
        TabPage tpgListado = this.tpgListado;
        ref TabPage local = ref tpgListado;
        tcPrincipal.DisablePage(ref local);
        this.tpgListado = tpgListado;
        this.tpgDetalle.Enabled = true;
        this.txtNombre.Focus();
      }
    }

    private void UbicarFila(string pstrIdEncontrar)
    {
      string str = "";
      int num = checked (this.dgvLista.Rows.Count - 1);
      int index = 0;
      while (index <= num)
      {
        if (Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateIndexGet(this.dgvLista.DataSource, new object[1]
        {
          (object) index
        }, (string[]) null), (System.Type) null, "CargoId", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null)).Equals(pstrIdEncontrar))
        {
          this.dgvLista.CurrentCell = this.dgvLista[1, index];
          return;
        }
        checked { ++index; }
      }
      str = (string) null;
    }

    private bool ValidarDatos()
    {
      if (this.txtNombre.Text.Trim().Equals(""))
      {
        ModGeneralFunctions.MessageOk("¡Ingresar Nombre!");
        this.txtNombre.Focus();
        return false;
      }
      if (!this.txtNombreCorto.Text.Trim().Equals(""))
        return true;
      ModGeneralFunctions.MessageOk("¡Ingresar Nombre Corto!");
      this.txtNombreCorto.Focus();
      return false;
    }
  }
}
