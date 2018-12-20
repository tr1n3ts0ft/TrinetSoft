// Decompiled with JetBrains decompiler
// Type: TriNetRestPOS.FrmArqueoIGV
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
  public class FrmArqueoIGV : Form
  {
    private IContainer components;
    private DataTable oLista;
    private string str_ReportSubTitle;
    private DateTime dat_FechaInicial;
    private DateTime dat_FechaFinal;
    private int int_LocalId;

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
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (FrmArqueoIGV));
      this.BackgroundWorker_Report = new BackgroundWorker();
      this.SpinningProgress_Report = new CircularProgress.SpinningProgress.SpinningProgress();
      this.ProgressBar_Report = new ProgressBar();
      this.Label_Loading = new Label();
      this.txtHoraFinal = new MaskedTextBox();
      this.txtHoraInicial = new MaskedTextBox();
      this.DateTimePicker_FinalDate = new DateTimePicker();
      this.Label_FinalDate = new Label();
      this.DateTimePicker_InitialDate = new DateTimePicker();
      this.Label_InitialDate = new Label();
      this.HeaderPanel2 = new HeaderPanel();
      this.cmb_Local = new ComboBox();
      this.Label_Turno = new Label();
      this.Button_Mostrar = new Button();
      ((Control) this.HeaderPanel2).SuspendLayout();
      this.SuspendLayout();
      this.BackgroundWorker_Report.WorkerReportsProgress = true;
      this.BackgroundWorker_Report.WorkerSupportsCancellation = true;
      this.SpinningProgress_Report.set_ActiveSegmentColour(Color.FromArgb((int) byte.MaxValue, 128, 0));
      ((Control) this.SpinningProgress_Report).BackColor = Color.Transparent;
      this.SpinningProgress_Report.set_BehindTransistionSegmentIsActive(false);
      ((Control) this.SpinningProgress_Report).Font = new Font("Trebuchet MS", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      ((Control) this.SpinningProgress_Report).Location = new Point((int) sbyte.MaxValue, 47);
      ((Control) this.SpinningProgress_Report).Margin = new Padding(4, 5, 4, 5);
      ((Control) this.SpinningProgress_Report).Name = "SpinningProgress_Report";
      ((Control) this.SpinningProgress_Report).Size = new Size(101, 102);
      ((Control) this.SpinningProgress_Report).TabIndex = 415;
      this.SpinningProgress_Report.set_TransistionSegment(9);
      this.SpinningProgress_Report.set_TransistionSegmentColour(Color.FromArgb((int) byte.MaxValue, 224, 192));
      ((Control) this.SpinningProgress_Report).Visible = false;
      this.ProgressBar_Report.Location = new Point(-270, 135);
      this.ProgressBar_Report.Name = "ProgressBar_Report";
      this.ProgressBar_Report.Size = new Size(16, 19);
      this.ProgressBar_Report.TabIndex = 417;
      this.ProgressBar_Report.Visible = false;
      this.Label_Loading.AutoSize = true;
      this.Label_Loading.BackColor = Color.White;
      this.Label_Loading.Font = new Font("Trebuchet MS", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Label_Loading.ForeColor = Color.Red;
      this.Label_Loading.Location = new Point(133, 156);
      this.Label_Loading.Name = "Label_Loading";
      this.Label_Loading.Size = new Size(92, 20);
      this.Label_Loading.TabIndex = 416;
      this.Label_Loading.Text = "Cargando...";
      this.Label_Loading.Visible = false;
      this.txtHoraFinal.Font = new Font("Trebuchet MS", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.txtHoraFinal.Location = new Point(250, 46);
      this.txtHoraFinal.Mask = "00:00";
      this.txtHoraFinal.Name = "txtHoraFinal";
      this.txtHoraFinal.Size = new Size(55, 25);
      this.txtHoraFinal.TabIndex = 427;
      this.txtHoraFinal.Text = "2359";
      this.txtHoraFinal.TextAlign = HorizontalAlignment.Center;
      this.txtHoraInicial.Font = new Font("Trebuchet MS", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.txtHoraInicial.Location = new Point(250, 13);
      this.txtHoraInicial.Mask = "00:00";
      this.txtHoraInicial.Name = "txtHoraInicial";
      this.txtHoraInicial.Size = new Size(55, 25);
      this.txtHoraInicial.TabIndex = 426;
      this.txtHoraInicial.Text = "0001";
      this.txtHoraInicial.TextAlign = HorizontalAlignment.Center;
      this.DateTimePicker_FinalDate.Font = new Font("Trebuchet MS", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.DateTimePicker_FinalDate.Format = DateTimePickerFormat.Short;
      this.DateTimePicker_FinalDate.Location = new Point(124, 47);
      this.DateTimePicker_FinalDate.Name = "DateTimePicker_FinalDate";
      this.DateTimePicker_FinalDate.Size = new Size(120, 25);
      this.DateTimePicker_FinalDate.TabIndex = 423;
      this.Label_FinalDate.AutoSize = true;
      this.Label_FinalDate.BackColor = Color.White;
      this.Label_FinalDate.Font = new Font("Trebuchet MS", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Label_FinalDate.ForeColor = Color.FromArgb(192, 0, 0);
      this.Label_FinalDate.Location = new Point(15, 49);
      this.Label_FinalDate.Name = "Label_FinalDate";
      this.Label_FinalDate.Size = new Size(97, 20);
      this.Label_FinalDate.TabIndex = 425;
      this.Label_FinalDate.Text = "Fecha Final:";
      this.DateTimePicker_InitialDate.Font = new Font("Trebuchet MS", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.DateTimePicker_InitialDate.Format = DateTimePickerFormat.Short;
      this.DateTimePicker_InitialDate.Location = new Point(124, 13);
      this.DateTimePicker_InitialDate.Name = "DateTimePicker_InitialDate";
      this.DateTimePicker_InitialDate.Size = new Size(120, 25);
      this.DateTimePicker_InitialDate.TabIndex = 422;
      this.Label_InitialDate.AutoSize = true;
      this.Label_InitialDate.BackColor = Color.White;
      this.Label_InitialDate.Font = new Font("Trebuchet MS", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Label_InitialDate.ForeColor = Color.FromArgb(192, 0, 0);
      this.Label_InitialDate.Location = new Point(8, 15);
      this.Label_InitialDate.Name = "Label_InitialDate";
      this.Label_InitialDate.Size = new Size(104, 20);
      this.Label_InitialDate.TabIndex = 424;
      this.Label_InitialDate.Text = "Fecha Inicial:";
      this.HeaderPanel2.set_BorderColor(SystemColors.ActiveCaption);
      this.HeaderPanel2.set_BorderStyle((BorderStyles) 1);
      this.HeaderPanel2.set_CaptionBeginColor(Color.FromArgb(240, 190, 70));
      this.HeaderPanel2.set_CaptionEndColor(Color.Moccasin);
      this.HeaderPanel2.set_CaptionGradientDirection(LinearGradientMode.Vertical);
      this.HeaderPanel2.set_CaptionHeight(26);
      this.HeaderPanel2.set_CaptionPosition((CaptionPositions) 0);
      this.HeaderPanel2.set_CaptionText("Opciones de Búsqueda");
      this.HeaderPanel2.set_CaptionVisible(true);
      ((Control) this.HeaderPanel2).Controls.Add((Control) this.Label_Loading);
      ((Control) this.HeaderPanel2).Controls.Add((Control) this.SpinningProgress_Report);
      ((Control) this.HeaderPanel2).Controls.Add((Control) this.cmb_Local);
      ((Control) this.HeaderPanel2).Controls.Add((Control) this.Label_Turno);
      ((Control) this.HeaderPanel2).Controls.Add((Control) this.Button_Mostrar);
      ((Control) this.HeaderPanel2).Controls.Add((Control) this.txtHoraFinal);
      ((Control) this.HeaderPanel2).Controls.Add((Control) this.txtHoraInicial);
      ((Control) this.HeaderPanel2).Controls.Add((Control) this.DateTimePicker_FinalDate);
      ((Control) this.HeaderPanel2).Controls.Add((Control) this.Label_InitialDate);
      ((Control) this.HeaderPanel2).Controls.Add((Control) this.Label_FinalDate);
      ((Control) this.HeaderPanel2).Controls.Add((Control) this.DateTimePicker_InitialDate);
      this.HeaderPanel2.set_Font(new Font("Trebuchet MS", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0));
      this.HeaderPanel2.set_GradientDirection(LinearGradientMode.Vertical);
      this.HeaderPanel2.set_GradientEnd(SystemColors.Window);
      this.HeaderPanel2.set_GradientStart(SystemColors.Window);
      ((Control) this.HeaderPanel2).Location = new Point(2, 2);
      ((Control) this.HeaderPanel2).Name = "HeaderPanel2";
      this.HeaderPanel2.set_PanelIcon((Icon) componentResourceManager.GetObject("HeaderPanel2.PanelIcon"));
      this.HeaderPanel2.set_PanelIconVisible(true);
      ((Control) this.HeaderPanel2).RightToLeft = RightToLeft.No;
      ((Control) this.HeaderPanel2).Size = new Size(330, 249);
      ((Control) this.HeaderPanel2).TabIndex = 428;
      this.HeaderPanel2.set_TextAntialias(true);
      this.cmb_Local.DropDownStyle = ComboBoxStyle.DropDownList;
      this.cmb_Local.Font = new Font("Trebuchet MS", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.cmb_Local.FormattingEnabled = true;
      this.cmb_Local.Location = new Point(119, 93);
      this.cmb_Local.Name = "cmb_Local";
      this.cmb_Local.Size = new Size(186, 26);
      this.cmb_Local.TabIndex = 484;
      this.Label_Turno.AutoSize = true;
      this.Label_Turno.BackColor = Color.White;
      this.Label_Turno.Font = new Font("Trebuchet MS", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Label_Turno.ForeColor = Color.MediumBlue;
      this.Label_Turno.Location = new Point(55, 93);
      this.Label_Turno.Name = "Label_Turno";
      this.Label_Turno.Size = new Size(57, 22);
      this.Label_Turno.TabIndex = 483;
      this.Label_Turno.Text = "Local:";
      this.Button_Mostrar.BackColor = Color.PapayaWhip;
      this.Button_Mostrar.Font = new Font("Trebuchet MS", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Button_Mostrar.ForeColor = Color.MediumBlue;
      this.Button_Mostrar.Image = (Image) TriNetRestPOS.My.Resources.Resources.print_printer_s;
      this.Button_Mostrar.ImageAlign = ContentAlignment.MiddleRight;
      this.Button_Mostrar.Location = new Point(53, 157);
      this.Button_Mostrar.Name = "Button_Mostrar";
      this.Button_Mostrar.Size = new Size(237, 52);
      this.Button_Mostrar.TabIndex = 407;
      this.Button_Mostrar.Text = "Mostrar";
      this.Button_Mostrar.TextImageRelation = TextImageRelation.ImageBeforeText;
      this.Button_Mostrar.UseVisualStyleBackColor = false;
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.BackColor = Color.WhiteSmoke;
      this.ClientSize = new Size(336, 254);
      this.Controls.Add((Control) this.HeaderPanel2);
      this.Controls.Add((Control) this.ProgressBar_Report);
      this.FormBorderStyle = FormBorderStyle.FixedDialog;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = nameof (FrmArqueoIGV);
      this.StartPosition = FormStartPosition.CenterScreen;
      this.Text = nameof (FrmArqueoIGV);
      ((Control) this.HeaderPanel2).ResumeLayout(false);
      ((Control) this.HeaderPanel2).PerformLayout();
      this.ResumeLayout(false);
    }

    internal virtual BackgroundWorker BackgroundWorker_Report
    {
      get
      {
        return this._BackgroundWorker_Report;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        DoWorkEventHandler workEventHandler = new DoWorkEventHandler(this.BackgroundWorker_Report_DoWork);
        ProgressChangedEventHandler changedEventHandler = new ProgressChangedEventHandler(this.BackgroundWorker_Report_ProgressChanged);
        RunWorkerCompletedEventHandler completedEventHandler = new RunWorkerCompletedEventHandler(this.BackgroundWorker_Report_RunWorkerCompleted);
        BackgroundWorker backgroundWorkerReport1 = this._BackgroundWorker_Report;
        if (backgroundWorkerReport1 != null)
        {
          backgroundWorkerReport1.DoWork -= workEventHandler;
          backgroundWorkerReport1.ProgressChanged -= changedEventHandler;
          backgroundWorkerReport1.RunWorkerCompleted -= completedEventHandler;
        }
        this._BackgroundWorker_Report = value;
        BackgroundWorker backgroundWorkerReport2 = this._BackgroundWorker_Report;
        if (backgroundWorkerReport2 == null)
          return;
        backgroundWorkerReport2.DoWork += workEventHandler;
        backgroundWorkerReport2.ProgressChanged += changedEventHandler;
        backgroundWorkerReport2.RunWorkerCompleted += completedEventHandler;
      }
    }

    internal virtual CircularProgress.SpinningProgress.SpinningProgress SpinningProgress_Report { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual ProgressBar ProgressBar_Report { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Label Label_Loading { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual MaskedTextBox txtHoraFinal { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual MaskedTextBox txtHoraInicial { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual DateTimePicker DateTimePicker_FinalDate { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Label Label_FinalDate { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual DateTimePicker DateTimePicker_InitialDate { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Label Label_InitialDate { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual HeaderPanel HeaderPanel2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Button Button_Mostrar
    {
      get
      {
        return this._Button_Mostrar;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Button_Mostrar_Click);
        Button buttonMostrar1 = this._Button_Mostrar;
        if (buttonMostrar1 != null)
          buttonMostrar1.Click -= eventHandler;
        this._Button_Mostrar = value;
        Button buttonMostrar2 = this._Button_Mostrar;
        if (buttonMostrar2 == null)
          return;
        buttonMostrar2.Click += eventHandler;
      }
    }

    internal virtual ComboBox cmb_Local { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Label Label_Turno { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    public FrmArqueoIGV()
    {
      this.Load += new EventHandler(this.FrmArqueoIGV_Load);
      this.InitializeComponent();
    }

    private void Cargar_Local()
    {
      BL_TR1_ESTABLI blTr1Establi = new BL_TR1_ESTABLI();
      List<BE_TR1_ESTABLI> beTr1EstabliList = new List<BE_TR1_ESTABLI>();
      this.cmb_Local.DataSource = (object) blTr1Establi.List();
      this.cmb_Local.DisplayMember = "EstabliDes";
      this.cmb_Local.ValueMember = "EstabliId";
    }

    private void LoadDate()
    {
      this.DateTimePicker_InitialDate.Value = ModGeneralFunctions.ObtenerPrimerDiaMesActual();
      this.DateTimePicker_FinalDate.Value = DateAndTime.Now;
      this.txtHoraInicial.Text = Conversions.ToString(ModGeneralFunctions.ObtenerAPPCONFIG("STR_HORAINICIAL"));
      this.txtHoraFinal.Text = Conversions.ToString(ModGeneralFunctions.ObtenerAPPCONFIG("STR_HORAFINAL"));
    }

    private void CargarParametros()
    {
      this.int_LocalId = checked ((int) Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.cmb_Local.SelectedValue))));
      this.dat_FechaInicial = ModGeneralFunctions.ObtenerFechayHora(this.DateTimePicker_InitialDate.Value, this.txtHoraInicial.Text, true);
      this.dat_FechaFinal = ModGeneralFunctions.ObtenerFechayHora(this.DateTimePicker_FinalDate.Value, this.txtHoraFinal.Text, false);
    }

    private void MostrarSubTitulo()
    {
      this.str_ReportSubTitle = "";
      this.str_ReportSubTitle = "Local: " + this.cmb_Local.Text + " / ";
      this.str_ReportSubTitle = this.str_ReportSubTitle + " - Del " + Conversions.ToString(this.dat_FechaInicial) + " al " + Conversions.ToString(this.dat_FechaFinal);
    }

    private void BackgroundWorker_Report_DoWork(object sender, DoWorkEventArgs e)
    {
      this.BackgroundWorker_Report.ReportProgress(50);
      Thread.Sleep(500);
      try
      {
        this.oLista = new BL_TR1_DOCUMENTS().DiferenciaImpuestoVentaxCosto(this.int_LocalId, this.dat_FechaInicial, this.dat_FechaFinal);
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
      finally
      {
        this.BackgroundWorker_Report.ReportProgress(100);
        e.Result = (object) this.oLista;
      }
    }

    private void BackgroundWorker_Report_ProgressChanged(object sender, ProgressChangedEventArgs e)
    {
      this.ProgressBar_Report.Value = e.ProgressPercentage;
    }

    private void BackgroundWorker_Report_RunWorkerCompleted(
      object sender,
      RunWorkerCompletedEventArgs e)
    {
      if (this.oLista.Rows.Count == 0)
      {
        ((Control) this.SpinningProgress_Report).Visible = false;
        this.Label_Loading.Visible = false;
        ModGeneralFunctions.MessageRestrictive("¡No Exite Datos para Mostrar en el Reporte!");
      }
      else
      {
        ((Control) this.SpinningProgress_Report).Visible = false;
        this.Label_Loading.Visible = false;
        ReportDocument p_ReportDocument = new ReportDocument();
        ModGeneralFunctions.SetUp_Report_Initial(ref p_ReportDocument, "TR1_REPORT\\rptNuevoDifImpVentaxCosto.rpt", "Arqueo de IGV", this.str_ReportSubTitle, "");
        p_ReportDocument.Database.Tables[0].SetDataSource(this.oLista);
        ModGeneralFunctions.SetUp_Report_Final(ref p_ReportDocument, false, "Arqueo de IGV");
      }
    }

    private void Button_Mostrar_Click(object sender, EventArgs e)
    {
      this.CargarParametros();
      this.MostrarSubTitulo();
      this.Label_Loading.Visible = true;
      ((Control) this.SpinningProgress_Report).Visible = true;
      this.BackgroundWorker_Report.RunWorkerAsync();
    }

    private void FrmArqueoIGV_Load(object sender, EventArgs e)
    {
      this.Cargar_Local();
      this.LoadDate();
    }
  }
}
