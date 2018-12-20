// Decompiled with JetBrains decompiler
// Type: TriNetRestPOS.FrmClienteDetallado
// Assembly: TriNetRestPOS, Version=5.2.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 43377352-E952-4AC1-9BA6-CCBE4AE5F575
// Assembly location: C:\log\TriNetRestPOS.exe

using CrystalDecisions.CrystalReports.Engine;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using TR1_BusinessEntity;
using TR1_BusinessLogic;

namespace TriNetRestPOS
{
  [DesignerGenerated]
  public class FrmClienteDetallado : Form
  {
    private IContainer components;
    private DataTable oListaClientes;
    private string strClientId;
    private int intTipoClienteId;
    private string strSexo;
    private string strEstadoCivil;
    private string strHijos;
    private string strEmpresa;
    private string strCargo;
    private string strMes;

    public FrmClienteDetallado()
    {
      this.Load += new EventHandler(this.FrmClienteDetallado_Load);
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
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (FrmClienteDetallado));
      this.pgbProgreso = new ProgressBar();
      this.lblProgreso = new Label();
      this.spgProgreso = new CircularProgress.SpinningProgress.SpinningProgress();
      this.txtClienteId = new TextBox();
      this.btnBuscarCliente = new Button();
      this.txtClienteNombre = new TextBox();
      this.Label3 = new Label();
      this.btnImprimir = new Button();
      this.Label1 = new Label();
      this.chbTodosClientes = new CheckBox();
      this.cboTipoCliente = new ComboBox();
      this.Label2 = new Label();
      this.Label4 = new Label();
      this.Label5 = new Label();
      this.Label6 = new Label();
      this.Label7 = new Label();
      this.Label8 = new Label();
      this.Label9 = new Label();
      this.Label10 = new Label();
      this.Label11 = new Label();
      this.Label12 = new Label();
      this.Label13 = new Label();
      this.Label14 = new Label();
      this.cboSexo = new ComboBox();
      this.cboEstadoCivil = new ComboBox();
      this.cboHijos = new ComboBox();
      this.txtEmpresa = new TextBox();
      this.txtCargo = new TextBox();
      this.Label16 = new Label();
      this.Label15 = new Label();
      this.cboMeses = new ComboBox();
      this.bgwProgreso = new BackgroundWorker();
      this.SuspendLayout();
      this.pgbProgreso.Location = new Point(387, 389);
      this.pgbProgreso.Name = "pgbProgreso";
      this.pgbProgreso.Size = new Size(22, 13);
      this.pgbProgreso.TabIndex = 464;
      this.pgbProgreso.Visible = false;
      this.lblProgreso.AutoSize = true;
      this.lblProgreso.BackColor = Color.Transparent;
      this.lblProgreso.Font = new Font("Trebuchet MS", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.lblProgreso.ForeColor = Color.Red;
      this.lblProgreso.Location = new Point(155, 328);
      this.lblProgreso.Name = "lblProgreso";
      this.lblProgreso.Size = new Size(92, 20);
      this.lblProgreso.TabIndex = 463;
      this.lblProgreso.Text = "Cargando...";
      this.lblProgreso.Visible = false;
      this.spgProgreso.set_ActiveSegmentColour(Color.FromArgb((int) byte.MaxValue, 128, 0));
      ((Control) this.spgProgreso).BackColor = Color.Transparent;
      this.spgProgreso.set_BehindTransistionSegmentIsActive(false);
      ((Control) this.spgProgreso).Location = new Point(256, 313);
      ((Control) this.spgProgreso).Margin = new Padding(6, 8, 6, 8);
      ((Control) this.spgProgreso).Name = "spgProgreso";
      ((Control) this.spgProgreso).RightToLeft = RightToLeft.Yes;
      ((Control) this.spgProgreso).Size = new Size(34, 35);
      ((Control) this.spgProgreso).TabIndex = 462;
      this.spgProgreso.set_TransistionSegment(11);
      this.spgProgreso.set_TransistionSegmentColour(Color.FromArgb((int) byte.MaxValue, 224, 192));
      ((Control) this.spgProgreso).Visible = false;
      this.txtClienteId.AutoCompleteSource = AutoCompleteSource.FileSystem;
      this.txtClienteId.BackColor = Color.FromArgb((int) byte.MaxValue, 240, 140);
      this.txtClienteId.Font = new Font("Trebuchet MS", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.txtClienteId.Location = new Point(94, 9);
      this.txtClienteId.Name = "txtClienteId";
      this.txtClienteId.ReadOnly = true;
      this.txtClienteId.Size = new Size(20, 25);
      this.txtClienteId.TabIndex = 0;
      this.txtClienteId.TabStop = false;
      this.txtClienteId.TextAlign = HorizontalAlignment.Center;
      this.txtClienteId.Visible = false;
      this.btnBuscarCliente.Image = (Image) TriNetRestPOS.My.Resources.Resources.Buscar_Small;
      this.btnBuscarCliente.Location = new Point(387, 35);
      this.btnBuscarCliente.Name = "btnBuscarCliente";
      this.btnBuscarCliente.Size = new Size(35, 25);
      this.btnBuscarCliente.TabIndex = 2;
      this.btnBuscarCliente.UseVisualStyleBackColor = true;
      this.txtClienteNombre.AutoCompleteSource = AutoCompleteSource.FileSystem;
      this.txtClienteNombre.BackColor = Color.FromArgb((int) byte.MaxValue, 240, 140);
      this.txtClienteNombre.Font = new Font("Trebuchet MS", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.txtClienteNombre.Location = new Point(15, 35);
      this.txtClienteNombre.Name = "txtClienteNombre";
      this.txtClienteNombre.ReadOnly = true;
      this.txtClienteNombre.Size = new Size(370, 25);
      this.txtClienteNombre.TabIndex = 1;
      this.txtClienteNombre.TabStop = false;
      this.txtClienteNombre.Text = "«Todos»";
      this.txtClienteNombre.TextAlign = HorizontalAlignment.Center;
      this.Label3.AutoSize = true;
      this.Label3.Font = new Font("Trebuchet MS", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Label3.ForeColor = Color.MediumBlue;
      this.Label3.Location = new Point(76, 12);
      this.Label3.Name = "Label3";
      this.Label3.Size = new Size(15, 20);
      this.Label3.TabIndex = 459;
      this.Label3.Text = ":";
      this.btnImprimir.Font = new Font("Trebuchet MS", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.btnImprimir.ForeColor = Color.MediumBlue;
      this.btnImprimir.Image = (Image) TriNetRestPOS.My.Resources.Resources.print_printer_s;
      this.btnImprimir.ImageAlign = ContentAlignment.MiddleLeft;
      this.btnImprimir.Location = new Point(109, 351);
      this.btnImprimir.Name = "btnImprimir";
      this.btnImprimir.RightToLeft = RightToLeft.Yes;
      this.btnImprimir.Size = new Size(236, 53);
      this.btnImprimir.TabIndex = 457;
      this.btnImprimir.Text = "&Mostrar";
      this.btnImprimir.TextImageRelation = TextImageRelation.TextBeforeImage;
      this.btnImprimir.UseVisualStyleBackColor = true;
      this.Label1.AutoSize = true;
      this.Label1.Font = new Font("Trebuchet MS", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Label1.ForeColor = Color.MediumBlue;
      this.Label1.Location = new Point(11, 12);
      this.Label1.Name = "Label1";
      this.Label1.Size = new Size(59, 20);
      this.Label1.TabIndex = 458;
      this.Label1.Text = "Cliente";
      this.chbTodosClientes.AutoSize = true;
      this.chbTodosClientes.ForeColor = Color.DarkRed;
      this.chbTodosClientes.Location = new Point(324, 12);
      this.chbTodosClientes.Name = "chbTodosClientes";
      this.chbTodosClientes.Size = new Size(68, 24);
      this.chbTodosClientes.TabIndex = 3;
      this.chbTodosClientes.Text = "Todos";
      this.chbTodosClientes.UseVisualStyleBackColor = true;
      this.cboTipoCliente.DropDownStyle = ComboBoxStyle.DropDownList;
      this.cboTipoCliente.FormattingEnabled = true;
      this.cboTipoCliente.Location = new Point(102, 66);
      this.cboTipoCliente.Name = "cboTipoCliente";
      this.cboTipoCliente.Size = new Size(320, 28);
      this.cboTipoCliente.TabIndex = 4;
      this.Label2.AutoSize = true;
      this.Label2.Font = new Font("Trebuchet MS", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Label2.ForeColor = Color.MediumBlue;
      this.Label2.Location = new Point(76, 69);
      this.Label2.Name = "Label2";
      this.Label2.Size = new Size(15, 20);
      this.Label2.TabIndex = 467;
      this.Label2.Text = ":";
      this.Label4.AutoSize = true;
      this.Label4.Font = new Font("Trebuchet MS", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Label4.ForeColor = Color.MediumBlue;
      this.Label4.Location = new Point(11, 69);
      this.Label4.Name = "Label4";
      this.Label4.Size = new Size(39, 20);
      this.Label4.TabIndex = 466;
      this.Label4.Text = "Tipo";
      this.Label5.AutoSize = true;
      this.Label5.Font = new Font("Trebuchet MS", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Label5.ForeColor = Color.MediumBlue;
      this.Label5.Location = new Point(76, 103);
      this.Label5.Name = "Label5";
      this.Label5.Size = new Size(15, 20);
      this.Label5.TabIndex = 469;
      this.Label5.Text = ":";
      this.Label6.AutoSize = true;
      this.Label6.Font = new Font("Trebuchet MS", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Label6.ForeColor = Color.MediumBlue;
      this.Label6.Location = new Point(11, 103);
      this.Label6.Name = "Label6";
      this.Label6.Size = new Size(42, 20);
      this.Label6.TabIndex = 468;
      this.Label6.Text = "Sexo";
      this.Label7.AutoSize = true;
      this.Label7.Font = new Font("Trebuchet MS", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Label7.ForeColor = Color.MediumBlue;
      this.Label7.Location = new Point(76, 137);
      this.Label7.Name = "Label7";
      this.Label7.Size = new Size(15, 20);
      this.Label7.TabIndex = 471;
      this.Label7.Text = ":";
      this.Label8.AutoSize = true;
      this.Label8.Font = new Font("Trebuchet MS", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Label8.ForeColor = Color.MediumBlue;
      this.Label8.Location = new Point(11, 137);
      this.Label8.Name = "Label8";
      this.Label8.Size = new Size(71, 20);
      this.Label8.TabIndex = 470;
      this.Label8.Text = "Est. Civil";
      this.Label9.AutoSize = true;
      this.Label9.Font = new Font("Trebuchet MS", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Label9.ForeColor = Color.MediumBlue;
      this.Label9.Location = new Point(76, 171);
      this.Label9.Name = "Label9";
      this.Label9.Size = new Size(15, 20);
      this.Label9.TabIndex = 473;
      this.Label9.Text = ":";
      this.Label10.AutoSize = true;
      this.Label10.Font = new Font("Trebuchet MS", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Label10.ForeColor = Color.MediumBlue;
      this.Label10.Location = new Point(11, 171);
      this.Label10.Name = "Label10";
      this.Label10.Size = new Size(43, 20);
      this.Label10.TabIndex = 472;
      this.Label10.Text = "Hijos";
      this.Label11.AutoSize = true;
      this.Label11.Font = new Font("Trebuchet MS", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Label11.ForeColor = Color.MediumBlue;
      this.Label11.Location = new Point(76, 206);
      this.Label11.Name = "Label11";
      this.Label11.Size = new Size(15, 20);
      this.Label11.TabIndex = 475;
      this.Label11.Text = ":";
      this.Label12.AutoSize = true;
      this.Label12.Font = new Font("Trebuchet MS", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Label12.ForeColor = Color.MediumBlue;
      this.Label12.Location = new Point(11, 206);
      this.Label12.Name = "Label12";
      this.Label12.Size = new Size(69, 20);
      this.Label12.TabIndex = 474;
      this.Label12.Text = "Empresa";
      this.Label13.AutoSize = true;
      this.Label13.Font = new Font("Trebuchet MS", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Label13.ForeColor = Color.MediumBlue;
      this.Label13.Location = new Point(76, 241);
      this.Label13.Name = "Label13";
      this.Label13.Size = new Size(15, 20);
      this.Label13.TabIndex = 477;
      this.Label13.Text = ":";
      this.Label14.AutoSize = true;
      this.Label14.Font = new Font("Trebuchet MS", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Label14.ForeColor = Color.MediumBlue;
      this.Label14.Location = new Point(11, 241);
      this.Label14.Name = "Label14";
      this.Label14.Size = new Size(48, 20);
      this.Label14.TabIndex = 476;
      this.Label14.Text = "Cargo";
      this.cboSexo.DropDownStyle = ComboBoxStyle.DropDownList;
      this.cboSexo.FormattingEnabled = true;
      this.cboSexo.Items.AddRange(new object[3]
      {
        (object) "«Todos»",
        (object) "Masculino",
        (object) "Femenino"
      });
      this.cboSexo.Location = new Point(102, 100);
      this.cboSexo.Name = "cboSexo";
      this.cboSexo.Size = new Size(320, 28);
      this.cboSexo.TabIndex = 5;
      this.cboEstadoCivil.DropDownStyle = ComboBoxStyle.DropDownList;
      this.cboEstadoCivil.FormattingEnabled = true;
      this.cboEstadoCivil.Items.AddRange(new object[7]
      {
        (object) "«Todos»",
        (object) "Soltero(a)",
        (object) "Casado(a)",
        (object) "Viudo(a)",
        (object) "Divorciado(a)",
        (object) "Separado(a)",
        (object) "Conviviente"
      });
      this.cboEstadoCivil.Location = new Point(102, 134);
      this.cboEstadoCivil.Name = "cboEstadoCivil";
      this.cboEstadoCivil.Size = new Size(320, 28);
      this.cboEstadoCivil.TabIndex = 6;
      this.cboHijos.DropDownStyle = ComboBoxStyle.DropDownList;
      this.cboHijos.FormattingEnabled = true;
      this.cboHijos.Items.AddRange(new object[3]
      {
        (object) "«Todos»",
        (object) "Si",
        (object) "No"
      });
      this.cboHijos.Location = new Point(102, 168);
      this.cboHijos.Name = "cboHijos";
      this.cboHijos.Size = new Size(320, 28);
      this.cboHijos.TabIndex = 7;
      this.txtEmpresa.Location = new Point(102, 203);
      this.txtEmpresa.Name = "txtEmpresa";
      this.txtEmpresa.Size = new Size(319, 25);
      this.txtEmpresa.TabIndex = 8;
      this.txtCargo.Location = new Point(102, 238);
      this.txtCargo.Name = "txtCargo";
      this.txtCargo.Size = new Size(319, 25);
      this.txtCargo.TabIndex = 9;
      this.Label16.AutoSize = true;
      this.Label16.Font = new Font("Trebuchet MS", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Label16.ForeColor = Color.MediumBlue;
      this.Label16.Location = new Point(11, 277);
      this.Label16.Name = "Label16";
      this.Label16.Size = new Size(93, 40);
      this.Label16.TabIndex = 478;
      this.Label16.Text = "Mes\r\nCumpleaños";
      this.Label15.AutoSize = true;
      this.Label15.Font = new Font("Trebuchet MS", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Label15.ForeColor = Color.MediumBlue;
      this.Label15.Location = new Point(76, 277);
      this.Label15.Name = "Label15";
      this.Label15.Size = new Size(15, 20);
      this.Label15.TabIndex = 479;
      this.Label15.Text = ":";
      this.cboMeses.DropDownStyle = ComboBoxStyle.DropDownList;
      this.cboMeses.FormattingEnabled = true;
      this.cboMeses.Items.AddRange(new object[13]
      {
        (object) "«Todos»",
        (object) "Enero",
        (object) "Febrero",
        (object) "Marzo",
        (object) "Abril",
        (object) "Mayo",
        (object) "Junio",
        (object) "Julio",
        (object) "Agosto",
        (object) "Septiembre",
        (object) "Octubre",
        (object) "Noviembre",
        (object) "Diciembre"
      });
      this.cboMeses.Location = new Point(102, 274);
      this.cboMeses.Name = "cboMeses";
      this.cboMeses.Size = new Size(320, 28);
      this.cboMeses.TabIndex = 10;
      this.bgwProgreso.WorkerReportsProgress = true;
      this.bgwProgreso.WorkerSupportsCancellation = true;
      this.AutoScaleDimensions = new SizeF(9f, 20f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.BackColor = SystemColors.Window;
      this.ClientSize = new Size(439, 412);
      this.Controls.Add((Control) this.cboMeses);
      this.Controls.Add((Control) this.txtCargo);
      this.Controls.Add((Control) this.txtEmpresa);
      this.Controls.Add((Control) this.cboHijos);
      this.Controls.Add((Control) this.cboEstadoCivil);
      this.Controls.Add((Control) this.cboSexo);
      this.Controls.Add((Control) this.Label15);
      this.Controls.Add((Control) this.Label16);
      this.Controls.Add((Control) this.Label13);
      this.Controls.Add((Control) this.Label14);
      this.Controls.Add((Control) this.Label11);
      this.Controls.Add((Control) this.Label12);
      this.Controls.Add((Control) this.Label9);
      this.Controls.Add((Control) this.Label10);
      this.Controls.Add((Control) this.Label7);
      this.Controls.Add((Control) this.Label8);
      this.Controls.Add((Control) this.Label5);
      this.Controls.Add((Control) this.Label6);
      this.Controls.Add((Control) this.Label2);
      this.Controls.Add((Control) this.Label4);
      this.Controls.Add((Control) this.cboTipoCliente);
      this.Controls.Add((Control) this.pgbProgreso);
      this.Controls.Add((Control) this.lblProgreso);
      this.Controls.Add((Control) this.spgProgreso);
      this.Controls.Add((Control) this.txtClienteId);
      this.Controls.Add((Control) this.btnBuscarCliente);
      this.Controls.Add((Control) this.txtClienteNombre);
      this.Controls.Add((Control) this.Label3);
      this.Controls.Add((Control) this.btnImprimir);
      this.Controls.Add((Control) this.Label1);
      this.Controls.Add((Control) this.chbTodosClientes);
      this.Font = new Font("Trebuchet MS", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
      this.KeyPreview = true;
      this.Margin = new Padding(4, 5, 4, 5);
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = nameof (FrmClienteDetallado);
      this.StartPosition = FormStartPosition.CenterScreen;
      this.Text = "Clientes a Detalle";
      this.ResumeLayout(false);
      this.PerformLayout();
    }

    internal virtual ProgressBar pgbProgreso { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Label lblProgreso { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual CircularProgress.SpinningProgress.SpinningProgress spgProgreso { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual TextBox txtClienteId { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Button btnBuscarCliente
    {
      get
      {
        return this._btnBuscarCliente;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.btnBuscarCliente_Click);
        Button btnBuscarCliente1 = this._btnBuscarCliente;
        if (btnBuscarCliente1 != null)
          btnBuscarCliente1.Click -= eventHandler;
        this._btnBuscarCliente = value;
        Button btnBuscarCliente2 = this._btnBuscarCliente;
        if (btnBuscarCliente2 == null)
          return;
        btnBuscarCliente2.Click += eventHandler;
      }
    }

    internal virtual TextBox txtClienteNombre { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Label Label3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Button btnImprimir
    {
      get
      {
        return this._btnImprimir;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.btnImprimir_Click);
        Button btnImprimir1 = this._btnImprimir;
        if (btnImprimir1 != null)
          btnImprimir1.Click -= eventHandler;
        this._btnImprimir = value;
        Button btnImprimir2 = this._btnImprimir;
        if (btnImprimir2 == null)
          return;
        btnImprimir2.Click += eventHandler;
      }
    }

    internal virtual Label Label1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual CheckBox chbTodosClientes
    {
      get
      {
        return this._chbTodosClientes;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.chbTodosClientes_CheckedChanged);
        CheckBox chbTodosClientes1 = this._chbTodosClientes;
        if (chbTodosClientes1 != null)
          chbTodosClientes1.CheckedChanged -= eventHandler;
        this._chbTodosClientes = value;
        CheckBox chbTodosClientes2 = this._chbTodosClientes;
        if (chbTodosClientes2 == null)
          return;
        chbTodosClientes2.CheckedChanged += eventHandler;
      }
    }

    internal virtual ComboBox cboTipoCliente { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Label Label2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Label Label4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Label Label5 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Label Label6 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Label Label7 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Label Label8 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Label Label9 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Label Label10 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Label Label11 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Label Label12 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Label Label13 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Label Label14 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual ComboBox cboSexo { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual ComboBox cboEstadoCivil { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual ComboBox cboHijos { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual TextBox txtEmpresa { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual TextBox txtCargo { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Label Label16 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Label Label15 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual ComboBox cboMeses { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual BackgroundWorker bgwProgreso
    {
      get
      {
        return this._bgwProgreso;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        DoWorkEventHandler workEventHandler = new DoWorkEventHandler(this.bgwProgreso_DoWork);
        ProgressChangedEventHandler changedEventHandler = new ProgressChangedEventHandler(this.bgwProgreso_ProgressChanged);
        RunWorkerCompletedEventHandler completedEventHandler = new RunWorkerCompletedEventHandler(this.bgwProgreso_RunWorkerCompleted);
        BackgroundWorker bgwProgreso1 = this._bgwProgreso;
        if (bgwProgreso1 != null)
        {
          bgwProgreso1.DoWork -= workEventHandler;
          bgwProgreso1.ProgressChanged -= changedEventHandler;
          bgwProgreso1.RunWorkerCompleted -= completedEventHandler;
        }
        this._bgwProgreso = value;
        BackgroundWorker bgwProgreso2 = this._bgwProgreso;
        if (bgwProgreso2 == null)
          return;
        bgwProgreso2.DoWork += workEventHandler;
        bgwProgreso2.ProgressChanged += changedEventHandler;
        bgwProgreso2.RunWorkerCompleted += completedEventHandler;
      }
    }

    private void FrmClienteDetallado_Load(object sender, EventArgs e)
    {
      this.CargarTipoCliente();
      this.cboSexo.SelectedIndex = 0;
      this.cboEstadoCivil.SelectedIndex = 0;
      this.cboHijos.SelectedIndex = 0;
      this.cboMeses.SelectedIndex = 0;
    }

    private void CargarTipoCliente()
    {
      BL_TR1_CLIENTE_TIPO blTr1ClienteTipo = new BL_TR1_CLIENTE_TIPO();
      List<BE_TR1_CLIENTE_TIPO> beTr1ClienteTipoList1 = new List<BE_TR1_CLIENTE_TIPO>();
      List<BE_TR1_CLIENTE_TIPO> beTr1ClienteTipoList2 = blTr1ClienteTipo.ListarActivos();
      if (beTr1ClienteTipoList2 == null || beTr1ClienteTipoList2.Count == 0)
        return;
      beTr1ClienteTipoList2.Insert(0, new BE_TR1_CLIENTE_TIPO(0, "«Todos»"));
      this.cboTipoCliente.ValueMember = "TipoClienteId";
      this.cboTipoCliente.DisplayMember = "Nombre";
      this.cboTipoCliente.DataSource = (object) beTr1ClienteTipoList2;
      this.cboTipoCliente.SelectedIndex = 0;
      beTr1ClienteTipoList1 = (List<BE_TR1_CLIENTE_TIPO>) null;
    }

    private void btnBuscarCliente_Click(object sender, EventArgs e)
    {
      FrmSearchClient frmSearchClient = new FrmSearchClient();
      frmSearchClient._OnlySearch = true;
      int num = (int) frmSearchClient.ShowDialog();
      frmSearchClient.Dispose();
      if (ModGeneralVar.g_bol_IsReady)
      {
        this.txtClienteId.Text = ModGeneralVar.g_Str_RecordID;
        this.txtClienteNombre.Text = ModGeneralVar.g_Str_RecordDes;
        this.chbTodosClientes.Checked = false;
      }
      else
        this.chbTodosClientes.Checked = true;
    }

    private void chbTodosClientes_CheckedChanged(object sender, EventArgs e)
    {
      if (!this.chbTodosClientes.Checked)
        return;
      this.txtClienteId.Text = "";
      this.txtClienteNombre.Text = "«Todos»";
    }

    private void btnImprimir_Click(object sender, EventArgs e)
    {
      this.strClientId = this.txtClienteId.Text.Trim();
      this.intTipoClienteId = Conversions.ToInteger(this.cboTipoCliente.SelectedValue);
      this.strSexo = Conversions.ToString(Interaction.IIf(this.cboSexo.SelectedIndex == 0, (object) "", (object) this.cboSexo.Text));
      this.strEstadoCivil = Conversions.ToString(Interaction.IIf(this.cboEstadoCivil.SelectedIndex == 0, (object) "", (object) this.cboEstadoCivil.Text));
      this.strHijos = Conversions.ToString(Interaction.IIf(this.cboHijos.SelectedIndex == 0, (object) "", (object) this.cboHijos.Text));
      this.strEmpresa = this.txtEmpresa.Text.Trim();
      this.strCargo = this.txtCargo.Text.Trim();
      this.strMes = Conversions.ToString(Interaction.IIf(this.cboMeses.SelectedIndex == 0, (object) "", (object) this.cboMeses.Text));
      this.lblProgreso.Visible = true;
      ((Control) this.spgProgreso).Visible = true;
      this.bgwProgreso.RunWorkerAsync();
    }

    private void bgwProgreso_DoWork(object sender, DoWorkEventArgs e)
    {
      this.bgwProgreso.ReportProgress(50);
      Thread.Sleep(500);
      this.oListaClientes = new BL_TR1_CLIENTS().ListaClientesaDetalle(this.strClientId, this.intTipoClienteId, this.strSexo, this.strEstadoCivil, this.strHijos, this.strEmpresa, this.strCargo, this.strMes);
      this.bgwProgreso.ReportProgress(100);
      e.Result = (object) this.oListaClientes;
    }

    private void bgwProgreso_ProgressChanged(object sender, ProgressChangedEventArgs e)
    {
      this.pgbProgreso.Value = e.ProgressPercentage;
    }

    private void bgwProgreso_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
    {
      if (this.oListaClientes == null)
      {
        ((Control) this.spgProgreso).Visible = false;
        this.lblProgreso.Visible = false;
        ModGeneralFunctions.MessageRestrictive("¡No Exite Datos para Mostrar en el Reporte!");
      }
      else if (this.oListaClientes.Rows.Count == 0)
      {
        ((Control) this.spgProgreso).Visible = false;
        this.lblProgreso.Visible = false;
        ModGeneralFunctions.MessageRestrictive("¡No Exite Datos para Mostrar en el Reporte!");
      }
      else
      {
        ((Control) this.spgProgreso).Visible = false;
        this.lblProgreso.Visible = false;
        ReportDocument p_ReportDocument = new ReportDocument();
        ModGeneralFunctions.SetUp_Report_Initial(ref p_ReportDocument, "TR1_REPORT\\rptClienteaDetalle.rpt", "REPORTE DE CLIENTES", "Detallado", "");
        p_ReportDocument.Database.Tables[0].SetDataSource(this.oListaClientes);
        ModGeneralFunctions.SetUp_Report_Final(ref p_ReportDocument, false, "[Reporte de Clientes]");
      }
    }
  }
}
