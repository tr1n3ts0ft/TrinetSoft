// Decompiled with JetBrains decompiler
// Type: TriNetRestPOS.FrmCierreZxFechas
// Assembly: TriNetRestPOS, Version=5.2.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 43377352-E952-4AC1-9BA6-CCBE4AE5F575
// Assembly location: C:\log\TriNetRestPOS.exe

using CrystalDecisions.CrystalReports.Engine;
using KIS.Controls;
using KIS.Controls.Windows;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using TR1_BusinessEntity;
using TR1_BusinessLogic;

namespace TriNetRestPOS
{
  [DesignerGenerated]
  public class FrmCierreZxFechas : Form
  {
    private static int RepPagos = 1;
    private static int RepCajas = 2;
    private static int Ticket = 3;
    private IContainer components;
    private BL_TR1_TURN_GENERAL oblTURN_GENERAL;
    private BE_TR1_TURN_GENERAL obeTURN_GENERAL;
    private string strResultado;
    private int intOpcion;
    private DataTable odtVENTAS;
    private DataTable odtTARJETAS;

    public FrmCierreZxFechas()
    {
      this.Load += new EventHandler(this.FrmCierreZxFechas_Load);
      this.KeyDown += new KeyEventHandler(this.FrmCierreZxFechas_KeyDown);
      this.intOpcion = 0;
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
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (FrmCierreZxFechas));
      this.btnSalir = new Button();
      this.btnImprimirTicket = new Button();
      this.HeaderPanel_Security = new HeaderPanel();
      this.txtHoraInicial = new MaskedTextBox();
      this.txtHoraFinal = new MaskedTextBox();
      this.Label15 = new Label();
      this.Label14 = new Label();
      this.Label_InitialDate = new Label();
      this.dtpFechaInicial = new DateTimePicker();
      this.Label_FinalDate = new Label();
      this.dtpFechaFinal = new DateTimePicker();
      this.Label7 = new Label();
      this.Label6 = new Label();
      this.cboLocal = new ComboBox();
      this.cboCaja = new ComboBox();
      this.Label2 = new Label();
      this.Label_Box = new Label();
      this.lblcargando = new Label();
      this.spgCargando = new CircularProgress.SpinningProgress.SpinningProgress();
      this.pgbReporte = new ProgressBar();
      this.bgwReporte = new BackgroundWorker();
      this.btnReportePago = new Button();
      this.btnReporteCaja = new Button();
      ((Control) this.HeaderPanel_Security).SuspendLayout();
      this.SuspendLayout();
      this.btnSalir.Font = new Font("Trebuchet MS", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.btnSalir.ForeColor = Color.MediumBlue;
      this.btnSalir.Image = (Image) TriNetRestPOS.My.Resources.Resources.i_Close;
      this.btnSalir.Location = new Point(501, 153);
      this.btnSalir.Name = "btnSalir";
      this.btnSalir.Size = new Size(90, 60);
      this.btnSalir.TabIndex = 4;
      this.btnSalir.Text = "&Salir";
      this.btnSalir.TextImageRelation = TextImageRelation.TextAboveImage;
      this.btnSalir.UseVisualStyleBackColor = true;
      this.btnImprimirTicket.Font = new Font("Trebuchet MS", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.btnImprimirTicket.ForeColor = Color.MediumBlue;
      this.btnImprimirTicket.Image = (Image) TriNetRestPOS.My.Resources.Resources.print_printer_s;
      this.btnImprimirTicket.Location = new Point(268, 153);
      this.btnImprimirTicket.Name = "btnImprimirTicket";
      this.btnImprimirTicket.Size = new Size(130, 60);
      this.btnImprimirTicket.TabIndex = 3;
      this.btnImprimirTicket.Text = "&Ticket";
      this.btnImprimirTicket.TextImageRelation = TextImageRelation.TextAboveImage;
      this.btnImprimirTicket.UseVisualStyleBackColor = true;
      this.HeaderPanel_Security.set_BorderColor(SystemColors.ActiveCaption);
      this.HeaderPanel_Security.set_BorderStyle((BorderStyles) 1);
      this.HeaderPanel_Security.set_CaptionBeginColor(Color.FromArgb(240, 190, 70));
      this.HeaderPanel_Security.set_CaptionEndColor(Color.Moccasin);
      this.HeaderPanel_Security.set_CaptionGradientDirection(LinearGradientMode.Vertical);
      this.HeaderPanel_Security.set_CaptionHeight(26);
      this.HeaderPanel_Security.set_CaptionPosition((CaptionPositions) 0);
      this.HeaderPanel_Security.set_CaptionText("Criterios de Búsqueda");
      this.HeaderPanel_Security.set_CaptionVisible(true);
      ((Control) this.HeaderPanel_Security).Controls.Add((Control) this.txtHoraInicial);
      ((Control) this.HeaderPanel_Security).Controls.Add((Control) this.txtHoraFinal);
      ((Control) this.HeaderPanel_Security).Controls.Add((Control) this.Label15);
      ((Control) this.HeaderPanel_Security).Controls.Add((Control) this.Label14);
      ((Control) this.HeaderPanel_Security).Controls.Add((Control) this.Label_InitialDate);
      ((Control) this.HeaderPanel_Security).Controls.Add((Control) this.dtpFechaInicial);
      ((Control) this.HeaderPanel_Security).Controls.Add((Control) this.Label_FinalDate);
      ((Control) this.HeaderPanel_Security).Controls.Add((Control) this.dtpFechaFinal);
      ((Control) this.HeaderPanel_Security).Controls.Add((Control) this.Label7);
      ((Control) this.HeaderPanel_Security).Controls.Add((Control) this.Label6);
      ((Control) this.HeaderPanel_Security).Controls.Add((Control) this.cboLocal);
      ((Control) this.HeaderPanel_Security).Controls.Add((Control) this.cboCaja);
      ((Control) this.HeaderPanel_Security).Controls.Add((Control) this.Label2);
      ((Control) this.HeaderPanel_Security).Controls.Add((Control) this.Label_Box);
      ((Control) this.HeaderPanel_Security).Dock = DockStyle.Top;
      this.HeaderPanel_Security.set_Font(new Font("Trebuchet MS", 9.75f, FontStyle.Bold));
      this.HeaderPanel_Security.set_GradientDirection(LinearGradientMode.Vertical);
      this.HeaderPanel_Security.set_GradientEnd(SystemColors.Window);
      this.HeaderPanel_Security.set_GradientStart(SystemColors.Window);
      ((Control) this.HeaderPanel_Security).Location = new Point(0, 0);
      ((Control) this.HeaderPanel_Security).Name = "HeaderPanel_Security";
      this.HeaderPanel_Security.set_PanelIcon((Icon) null);
      this.HeaderPanel_Security.set_PanelIconVisible(false);
      ((Control) this.HeaderPanel_Security).Size = new Size(594, 150);
      ((Control) this.HeaderPanel_Security).TabIndex = 0;
      this.HeaderPanel_Security.set_TextAntialias(true);
      this.txtHoraInicial.Font = new Font("Trebuchet MS", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.txtHoraInicial.Location = new Point(246, 11);
      this.txtHoraInicial.Margin = new Padding(4, 5, 4, 5);
      this.txtHoraInicial.Mask = "00:00";
      this.txtHoraInicial.Name = "txtHoraInicial";
      this.txtHoraInicial.Size = new Size(50, 25);
      this.txtHoraInicial.TabIndex = 446;
      this.txtHoraInicial.Text = "0000";
      this.txtHoraFinal.Font = new Font("Trebuchet MS", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.txtHoraFinal.Location = new Point(528, 11);
      this.txtHoraFinal.Margin = new Padding(4, 5, 4, 5);
      this.txtHoraFinal.Mask = "00:00";
      this.txtHoraFinal.Name = "txtHoraFinal";
      this.txtHoraFinal.Size = new Size(50, 25);
      this.txtHoraFinal.TabIndex = 447;
      this.txtHoraFinal.Text = "2359";
      this.Label15.AutoSize = true;
      this.Label15.Font = new Font("Trebuchet MS", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Label15.ForeColor = Color.MediumBlue;
      this.Label15.Location = new Point(390, 13);
      this.Label15.Name = "Label15";
      this.Label15.Size = new Size(15, 20);
      this.Label15.TabIndex = 282;
      this.Label15.Text = ":";
      this.Label14.AutoSize = true;
      this.Label14.Font = new Font("Trebuchet MS", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Label14.ForeColor = Color.MediumBlue;
      this.Label14.Location = new Point(106, 13);
      this.Label14.Name = "Label14";
      this.Label14.Size = new Size(15, 20);
      this.Label14.TabIndex = 281;
      this.Label14.Text = ":";
      this.Label_InitialDate.AutoSize = true;
      this.Label_InitialDate.Font = new Font("Trebuchet MS", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Label_InitialDate.ForeColor = Color.MediumBlue;
      this.Label_InitialDate.Location = new Point(10, 13);
      this.Label_InitialDate.Name = "Label_InitialDate";
      this.Label_InitialDate.Size = new Size(98, 20);
      this.Label_InitialDate.TabIndex = 279;
      this.Label_InitialDate.Text = "Fecha Inicial";
      this.dtpFechaInicial.Font = new Font("Trebuchet MS", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.dtpFechaInicial.Format = DateTimePickerFormat.Short;
      this.dtpFechaInicial.Location = new Point(124, 11);
      this.dtpFechaInicial.Name = "dtpFechaInicial";
      this.dtpFechaInicial.Size = new Size(122, 25);
      this.dtpFechaInicial.TabIndex = 1;
      this.Label_FinalDate.AutoSize = true;
      this.Label_FinalDate.Font = new Font("Trebuchet MS", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Label_FinalDate.ForeColor = Color.MediumBlue;
      this.Label_FinalDate.Location = new Point(302, 13);
      this.Label_FinalDate.Name = "Label_FinalDate";
      this.Label_FinalDate.Size = new Size(91, 20);
      this.Label_FinalDate.TabIndex = 280;
      this.Label_FinalDate.Text = "Fecha Final";
      this.dtpFechaFinal.Font = new Font("Trebuchet MS", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.dtpFechaFinal.Format = DateTimePickerFormat.Short;
      this.dtpFechaFinal.Location = new Point(406, 11);
      this.dtpFechaFinal.Name = "dtpFechaFinal";
      this.dtpFechaFinal.Size = new Size(122, 25);
      this.dtpFechaFinal.TabIndex = 2;
      this.Label7.AutoSize = true;
      this.Label7.Font = new Font("Trebuchet MS", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Label7.ForeColor = Color.MediumBlue;
      this.Label7.Location = new Point(106, 87);
      this.Label7.Name = "Label7";
      this.Label7.Size = new Size(15, 20);
      this.Label7.TabIndex = 445;
      this.Label7.Text = ":";
      this.Label6.AutoSize = true;
      this.Label6.Font = new Font("Trebuchet MS", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Label6.ForeColor = Color.MediumBlue;
      this.Label6.Location = new Point(106, 49);
      this.Label6.Name = "Label6";
      this.Label6.Size = new Size(15, 20);
      this.Label6.TabIndex = 444;
      this.Label6.Text = ":";
      this.cboLocal.BackColor = Color.FromArgb((int) byte.MaxValue, 240, 140);
      this.cboLocal.DropDownStyle = ComboBoxStyle.DropDownList;
      this.cboLocal.Font = new Font("Trebuchet MS", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.cboLocal.FormattingEnabled = true;
      this.cboLocal.Items.AddRange(new object[4]
      {
        (object) "<Seleccione>",
        (object) "3",
        (object) "5",
        (object) "10"
      });
      this.cboLocal.Location = new Point(124, 46);
      this.cboLocal.Name = "cboLocal";
      this.cboLocal.Size = new Size(454, 28);
      this.cboLocal.TabIndex = 3;
      this.cboCaja.BackColor = Color.FromArgb((int) byte.MaxValue, 240, 140);
      this.cboCaja.DropDownStyle = ComboBoxStyle.DropDownList;
      this.cboCaja.Font = new Font("Trebuchet MS", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.cboCaja.FormattingEnabled = true;
      this.cboCaja.Items.AddRange(new object[4]
      {
        (object) "<Seleccione>",
        (object) "3",
        (object) "5",
        (object) "10"
      });
      this.cboCaja.Location = new Point(124, 84);
      this.cboCaja.Name = "cboCaja";
      this.cboCaja.Size = new Size(454, 28);
      this.cboCaja.TabIndex = 4;
      this.Label2.AutoSize = true;
      this.Label2.Font = new Font("Trebuchet MS", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Label2.ForeColor = Color.MediumBlue;
      this.Label2.Location = new Point(10, 49);
      this.Label2.Name = "Label2";
      this.Label2.Size = new Size(45, 20);
      this.Label2.TabIndex = 420;
      this.Label2.Text = "Local";
      this.Label_Box.AutoSize = true;
      this.Label_Box.Font = new Font("Trebuchet MS", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Label_Box.ForeColor = Color.MediumBlue;
      this.Label_Box.Location = new Point(10, 87);
      this.Label_Box.Name = "Label_Box";
      this.Label_Box.Size = new Size(40, 20);
      this.Label_Box.TabIndex = 383;
      this.Label_Box.Text = "Caja";
      this.lblcargando.AutoSize = true;
      this.lblcargando.Font = new Font("Trebuchet MS", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.lblcargando.ForeColor = Color.Red;
      this.lblcargando.Location = new Point(407, 192);
      this.lblcargando.Name = "lblcargando";
      this.lblcargando.Size = new Size(92, 20);
      this.lblcargando.TabIndex = 431;
      this.lblcargando.Text = "Cargando...";
      this.lblcargando.Visible = false;
      this.spgCargando.set_ActiveSegmentColour(Color.FromArgb((int) byte.MaxValue, 128, 0));
      ((Control) this.spgCargando).BackColor = Color.Transparent;
      ((Control) this.spgCargando).Font = new Font("Trebuchet MS", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      ((Control) this.spgCargando).Location = new Point(411, 153);
      ((Control) this.spgCargando).Margin = new Padding(4, 5, 4, 5);
      ((Control) this.spgCargando).Name = "spgCargando";
      ((Control) this.spgCargando).Size = new Size(35, 35);
      ((Control) this.spgCargando).TabIndex = 430;
      this.spgCargando.set_TransistionSegment(2);
      this.spgCargando.set_TransistionSegmentColour(Color.FromArgb((int) byte.MaxValue, 224, 192));
      ((Control) this.spgCargando).Visible = false;
      this.pgbReporte.Location = new Point(12, 153);
      this.pgbReporte.Name = "pgbReporte";
      this.pgbReporte.Size = new Size(22, 13);
      this.pgbReporte.TabIndex = 419;
      this.pgbReporte.Visible = false;
      this.bgwReporte.WorkerReportsProgress = true;
      this.bgwReporte.WorkerSupportsCancellation = true;
      this.btnReportePago.Font = new Font("Trebuchet MS", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.btnReportePago.ForeColor = Color.MediumBlue;
      this.btnReportePago.Image = (Image) TriNetRestPOS.My.Resources.Resources.print_printer_s;
      this.btnReportePago.Location = new Point(4, 153);
      this.btnReportePago.Name = "btnReportePago";
      this.btnReportePago.Size = new Size(130, 60);
      this.btnReportePago.TabIndex = 1;
      this.btnReportePago.Text = "&Rep. por Pago";
      this.btnReportePago.TextImageRelation = TextImageRelation.TextAboveImage;
      this.btnReportePago.UseVisualStyleBackColor = true;
      this.btnReporteCaja.Font = new Font("Trebuchet MS", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.btnReporteCaja.ForeColor = Color.MediumBlue;
      this.btnReporteCaja.Image = (Image) TriNetRestPOS.My.Resources.Resources.print_printer_s;
      this.btnReporteCaja.Location = new Point(136, 153);
      this.btnReporteCaja.Name = "btnReporteCaja";
      this.btnReporteCaja.Size = new Size(130, 60);
      this.btnReporteCaja.TabIndex = 2;
      this.btnReporteCaja.Text = "&Rep. por Caja";
      this.btnReporteCaja.TextImageRelation = TextImageRelation.TextAboveImage;
      this.btnReporteCaja.UseVisualStyleBackColor = true;
      this.AutoScaleDimensions = new SizeF(9f, 20f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.BackColor = SystemColors.Window;
      this.ClientSize = new Size(594, 217);
      this.Controls.Add((Control) this.btnReporteCaja);
      this.Controls.Add((Control) this.btnReportePago);
      this.Controls.Add((Control) this.btnSalir);
      this.Controls.Add((Control) this.lblcargando);
      this.Controls.Add((Control) this.btnImprimirTicket);
      this.Controls.Add((Control) this.HeaderPanel_Security);
      this.Controls.Add((Control) this.pgbReporte);
      this.Controls.Add((Control) this.spgCargando);
      this.Font = new Font("Trebuchet MS", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.FormBorderStyle = FormBorderStyle.FixedDialog;
      this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
      this.KeyPreview = true;
      this.Margin = new Padding(4, 5, 4, 5);
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = nameof (FrmCierreZxFechas);
      this.StartPosition = FormStartPosition.CenterScreen;
      this.Text = "Cierre Z por Fechas";
      ((Control) this.HeaderPanel_Security).ResumeLayout(false);
      ((Control) this.HeaderPanel_Security).PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();
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

    internal virtual Button btnImprimirTicket
    {
      get
      {
        return this._btnImprimirTicket;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.btnImprimir_Click);
        Button btnImprimirTicket1 = this._btnImprimirTicket;
        if (btnImprimirTicket1 != null)
          btnImprimirTicket1.Click -= eventHandler;
        this._btnImprimirTicket = value;
        Button btnImprimirTicket2 = this._btnImprimirTicket;
        if (btnImprimirTicket2 == null)
          return;
        btnImprimirTicket2.Click += eventHandler;
      }
    }

    internal virtual HeaderPanel HeaderPanel_Security { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Label lblcargando
    {
      get
      {
        return this._lblcargando;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.lblcargando_Click);
        Label lblcargando1 = this._lblcargando;
        if (lblcargando1 != null)
          lblcargando1.Click -= eventHandler;
        this._lblcargando = value;
        Label lblcargando2 = this._lblcargando;
        if (lblcargando2 == null)
          return;
        lblcargando2.Click += eventHandler;
      }
    }

    internal virtual CircularProgress.SpinningProgress.SpinningProgress spgCargando
    {
      get
      {
        return this._spgCargando;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.spgCargando_Load);
        CircularProgress.SpinningProgress.SpinningProgress spgCargando1 = this._spgCargando;
        if (spgCargando1 != null)
          ((UserControl) spgCargando1).Load -= eventHandler;
        this._spgCargando = value;
        CircularProgress.SpinningProgress.SpinningProgress spgCargando2 = this._spgCargando;
        if (spgCargando2 == null)
          return;
        ((UserControl) spgCargando2).Load += eventHandler;
      }
    }

    internal virtual Label Label7 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Label Label6 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Label Label15 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Label Label14 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Label Label_InitialDate { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual DateTimePicker dtpFechaInicial { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Label Label_FinalDate { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual DateTimePicker dtpFechaFinal { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual ComboBox cboLocal { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual ProgressBar pgbReporte { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual ComboBox cboCaja { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Label Label2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Label Label_Box { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual BackgroundWorker bgwReporte
    {
      get
      {
        return this._bgwReporte;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        DoWorkEventHandler workEventHandler = new DoWorkEventHandler(this.bgwReporte_DoWork);
        ProgressChangedEventHandler changedEventHandler = new ProgressChangedEventHandler(this.bgwReporte_ProgressChanged);
        RunWorkerCompletedEventHandler completedEventHandler = new RunWorkerCompletedEventHandler(this.bgwReporte_RunWorkerCompleted);
        BackgroundWorker bgwReporte1 = this._bgwReporte;
        if (bgwReporte1 != null)
        {
          bgwReporte1.DoWork -= workEventHandler;
          bgwReporte1.ProgressChanged -= changedEventHandler;
          bgwReporte1.RunWorkerCompleted -= completedEventHandler;
        }
        this._bgwReporte = value;
        BackgroundWorker bgwReporte2 = this._bgwReporte;
        if (bgwReporte2 == null)
          return;
        bgwReporte2.DoWork += workEventHandler;
        bgwReporte2.ProgressChanged += changedEventHandler;
        bgwReporte2.RunWorkerCompleted += completedEventHandler;
      }
    }

    internal virtual MaskedTextBox txtHoraInicial { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual MaskedTextBox txtHoraFinal { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Button btnReportePago
    {
      get
      {
        return this._btnReportePago;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.btnImprimirReporte_Click);
        Button btnReportePago1 = this._btnReportePago;
        if (btnReportePago1 != null)
          btnReportePago1.Click -= eventHandler;
        this._btnReportePago = value;
        Button btnReportePago2 = this._btnReportePago;
        if (btnReportePago2 == null)
          return;
        btnReportePago2.Click += eventHandler;
      }
    }

    internal virtual Button btnReporteCaja
    {
      get
      {
        return this._btnReporteCaja;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.btnReporteCaja_Click);
        Button btnReporteCaja1 = this._btnReporteCaja;
        if (btnReporteCaja1 != null)
          btnReporteCaja1.Click -= eventHandler;
        this._btnReporteCaja = value;
        Button btnReporteCaja2 = this._btnReporteCaja;
        if (btnReporteCaja2 == null)
          return;
        btnReporteCaja2.Click += eventHandler;
      }
    }

    private void FrmCierreZxFechas_Load(object sender, EventArgs e)
    {
      this.CargarFecha();
      if (!this.CargarLocales())
        ModGeneralFunctions.MessageOk("¡Error al Cargar Locales!");
      else if (!this.CargarCajas())
        ModGeneralFunctions.MessageOk("¡Error al Cargar Cajas!");
      else if (Conversions.ToBoolean(ModGeneralFunctions.ObtenerAPPCONFIG("MOSTRAR_CIERRELOCAL")))
        this.Text = "Cierre de Local";
      else
        this.Text = "Cierre Z por Fechas";
    }

    private void FrmCierreZxFechas_KeyDown(object sender, KeyEventArgs e)
    {
      if (!e.KeyValue.Equals(27))
        return;
      this.Close();
    }

    private void CargarFecha()
    {
      this.dtpFechaInicial.Value = ModGeneralFunctions.ObtenerPrimerDiaMesActual();
      this.dtpFechaFinal.Value = DateAndTime.Now;
      this.txtHoraInicial.Text = Conversions.ToString(ModGeneralFunctions.ObtenerAPPCONFIG("STR_HORAINICIAL"));
      this.txtHoraFinal.Text = Conversions.ToString(ModGeneralFunctions.ObtenerAPPCONFIG("STR_HORAFINAL"));
    }

    private bool CargarLocales()
    {
      BL_TR1_ESTABLI blTr1Establi = new BL_TR1_ESTABLI();
      List<BE_TR1_ESTABLI> beTr1EstabliList1 = new List<BE_TR1_ESTABLI>();
      List<BE_TR1_ESTABLI> beTr1EstabliList2 = blTr1Establi.List();
      if (beTr1EstabliList2 == null || beTr1EstabliList2.Count == 0)
        return false;
      beTr1EstabliList2.Insert(0, new BE_TR1_ESTABLI(Conversions.ToInteger("0"), "«Todos»"));
      this.cboLocal.ValueMember = "EstabliId";
      this.cboLocal.DisplayMember = "EstabliDes";
      this.cboLocal.DataSource = (object) beTr1EstabliList2;
      this.cboLocal.SelectedIndex = 1;
      beTr1EstabliList1 = (List<BE_TR1_ESTABLI>) null;
      return true;
    }

    private bool CargarCajas()
    {
      BL_TR1_BOXES blTr1Boxes = new BL_TR1_BOXES();
      List<BE_TR1_BOXES> beTr1BoxesList1 = new List<BE_TR1_BOXES>();
      List<BE_TR1_BOXES> beTr1BoxesList2 = blTr1Boxes.ListBasic(Conversions.ToInteger(this.cboLocal.SelectedValue));
      if (beTr1BoxesList2 == null || beTr1BoxesList2.Count == 0)
        return false;
      beTr1BoxesList2.Insert(0, new BE_TR1_BOXES(Conversions.ToInteger("0"), "«Todas»"));
      this.cboCaja.ValueMember = "BoxId";
      this.cboCaja.DisplayMember = "BoxDes";
      this.cboCaja.DataSource = (object) beTr1BoxesList2;
      return true;
    }

    private void ImprimirReporte()
    {
      if (!this.ValidarDatos())
        return;
      ReportDocument reportDocument = new ReportDocument();
      this.obeTURN_GENERAL = new BE_TR1_TURN_GENERAL();
      this.obeTURN_GENERAL.set_DateInitial(ModGeneralFunctions.ObtenerFechayHora(this.dtpFechaInicial.Value, this.txtHoraInicial.Text, true));
      this.obeTURN_GENERAL.set_DateFinal(ModGeneralFunctions.ObtenerFechayHora(this.dtpFechaFinal.Value, this.txtHoraFinal.Text, false));
      this.obeTURN_GENERAL.set_EstabliId(Conversions.ToInteger(this.cboLocal.SelectedValue));
      this.obeTURN_GENERAL.set_BoxId(Conversions.ToInteger(this.cboCaja.SelectedValue));
      this.obeTURN_GENERAL.set_BoxDes(this.cboCaja.Text);
      this.obeTURN_GENERAL.set_UserClose(ModGeneralVar.g_BE_USERS.get_UserId());
      this.lblcargando.Visible = true;
      ((Control) this.spgCargando).Visible = true;
      this.bgwReporte.RunWorkerAsync();
    }

    private bool ValidarDatos()
    {
      return true;
    }

    private string ObtenerSubTitulo()
    {
      string str1 = "";
      string str2 = this.cboLocal.SelectedIndex != 0 ? str1 + "Local: " + this.cboLocal.Text : str1 + "Todos los Locales";
      return (this.cboCaja.SelectedIndex != 0 ? str2 + " - Caja: " + this.cboCaja.Text : str2 + " - Todas las Cajas") + " - del " + Conversions.ToString(ModGeneralFunctions.ObtenerFechayHora(this.dtpFechaInicial.Value, this.txtHoraInicial.Text, true)) + " al " + Conversions.ToString(ModGeneralFunctions.ObtenerFechayHora(this.dtpFechaFinal.Value, this.txtHoraFinal.Text, false));
    }

    private void btnImprimir_Click(object sender, EventArgs e)
    {
      this.intOpcion = FrmCierreZxFechas.Ticket;
      this.ImprimirReporte();
    }

    private void btnSalir_Click(object sender, EventArgs e)
    {
      this.Close();
    }

    private void bgwReporte_DoWork(object sender, DoWorkEventArgs e)
    {
      this.bgwReporte.ReportProgress(50);
      Thread.Sleep(500);
      this.oblTURN_GENERAL = new BL_TR1_TURN_GENERAL();
      int intOpcion = this.intOpcion;
      if (intOpcion == FrmCierreZxFechas.Ticket)
      {
        string[] strArray = new string[3];
        strArray.SetValue((object) ModGeneralFunctions.ObtenerAPPCONFIG("TYPEMONEYDESSHORT_IN").ToString(), 0);
        strArray.SetValue((object) ModGeneralFunctions.ObtenerAPPCONFIG("TYPEMONEYDESSHORT_IE").ToString(), 1);
        this.strResultado = this.oblTURN_GENERAL.ImprimirZetaxFechas(this.obeTURN_GENERAL, ModGeneralVar.g_BE_TR1_CFGVARIABLES, ModGeneralVar.g_BE_TR1_VARIABLES_B, strArray, ModGeneralVar.g_BusinessCode.get_DOCU_PROCESSED(), ModGeneralVar.g_BusinessCode.get_DOCU_ANNULLED(), ModGeneralVar.g_GeneralCode);
        strArray[2] = (string) null;
      }
      else if (intOpcion == FrmCierreZxFechas.RepPagos)
      {
        this.odtVENTAS = this.oblTURN_GENERAL.ListarxVentasxPagos(this.obeTURN_GENERAL.get_EstabliId(), this.obeTURN_GENERAL.get_BoxId(), this.obeTURN_GENERAL.get_DateInitial(), this.obeTURN_GENERAL.get_DateFinal());
        this.odtTARJETAS = new BL_TR1_CREDITCARDS().ListarxVentas(this.obeTURN_GENERAL.get_EstabliId(), this.obeTURN_GENERAL.get_BoxId(), this.obeTURN_GENERAL.get_DateInitial(), this.obeTURN_GENERAL.get_DateFinal());
        this.strResultado = StructApp.RESULT_OK;
      }
      else if (intOpcion == FrmCierreZxFechas.RepCajas)
      {
        this.odtVENTAS = this.oblTURN_GENERAL.ListarxVentasxCajas(this.obeTURN_GENERAL.get_EstabliId(), this.obeTURN_GENERAL.get_BoxId(), this.obeTURN_GENERAL.get_DateInitial(), this.obeTURN_GENERAL.get_DateFinal());
        this.odtTARJETAS = new BL_TR1_CREDITCARDS().ListarxVentas(this.obeTURN_GENERAL.get_EstabliId(), this.obeTURN_GENERAL.get_BoxId(), this.obeTURN_GENERAL.get_DateInitial(), this.obeTURN_GENERAL.get_DateFinal());
        this.strResultado = StructApp.RESULT_OK;
      }
      this.bgwReporte.ReportProgress(100);
      e.Result = (object) this.strResultado;
    }

    private void bgwReporte_ProgressChanged(object sender, ProgressChangedEventArgs e)
    {
      this.pgbReporte.Value = e.ProgressPercentage;
    }

    private void bgwReporte_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
    {
      ((Control) this.spgCargando).Visible = false;
      this.lblcargando.Visible = false;
      if (!this.strResultado.Equals(StructApp.RESULT_OK))
      {
        ModGeneralFunctions.MessageRestrictive("¡No Exite Datos para Mostrar en el Reporte!");
      }
      else
      {
        int intOpcion = this.intOpcion;
        if (intOpcion == FrmCierreZxFechas.RepPagos)
        {
          if (this.odtVENTAS == null)
          {
            ModGeneralFunctions.MessageOk("¡No Exite Datos para Mostrar en el Reporte!");
          }
          else
          {
            ReportDocument p_ReportDocument = new ReportDocument();
            ModGeneralFunctions.SetUp_Report_Initial(ref p_ReportDocument, "TR1_REPORT\\rptVentasResumen.rpt", "Resúmen de Ventas por Pagos", this.ObtenerSubTitulo(), "");
            p_ReportDocument.Database.Tables[0].SetDataSource(this.odtVENTAS);
            p_ReportDocument.Subreports["rptResumenTarjetas.rpt"].SetDataSource(this.odtTARJETAS);
            ModGeneralFunctions.SetUp_Report_Final(ref p_ReportDocument, false, "Resúmen de Ventas por Pagos");
          }
        }
        else if (intOpcion == FrmCierreZxFechas.RepCajas)
        {
          if (this.odtVENTAS == null)
          {
            ModGeneralFunctions.MessageOk("¡No Exite Datos para Mostrar en el Reporte!");
          }
          else
          {
            ReportDocument p_ReportDocument = new ReportDocument();
            ModGeneralFunctions.SetUp_Report_Initial(ref p_ReportDocument, "TR1_REPORT\\rptVentasResumenxCaja.rpt", "Resúmen de Ventas por Cajas", this.ObtenerSubTitulo(), "");
            p_ReportDocument.Database.Tables[0].SetDataSource(this.odtVENTAS);
            p_ReportDocument.Subreports["rptResumenTarjetas.rpt"].SetDataSource(this.odtTARJETAS);
            ModGeneralFunctions.SetUp_Report_Final(ref p_ReportDocument, false, "Resúmen de Ventas por Cajas");
          }
        }
      }
    }

    private void btnImprimirReporte_Click(object sender, EventArgs e)
    {
      this.intOpcion = FrmCierreZxFechas.RepPagos;
      this.ImprimirReporte();
    }

    private void btnReporteCaja_Click(object sender, EventArgs e)
    {
      this.intOpcion = FrmCierreZxFechas.RepCajas;
      this.ImprimirReporte();
    }

    private void lblcargando_Click(object sender, EventArgs e)
    {
    }

    private void spgCargando_Load(object sender, EventArgs e)
    {
    }
  }
}
