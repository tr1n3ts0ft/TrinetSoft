// Decompiled with JetBrains decompiler
// Type: TriNetRestPOS.FrmCambioDocumento
// Assembly: TriNetRestPOS, Version=5.2.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 43377352-E952-4AC1-9BA6-CCBE4AE5F575
// Assembly location: C:\log\TriNetRestPOS.exe

using CrystalDecisions.CrystalReports.Engine;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
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
  public class FrmCambioDocumento : Form
  {
    private IContainer components;
    private DateTime dtp_DateInitial;
    private DateTime dtp_DateFinal;
    private int int_LocalId;
    private string str_ReportSubTitle;
    private List<BE_TR1_CAMBIO_DOCUMENTO> oLista;

    public FrmCambioDocumento()
    {
      this.Load += new EventHandler(this.FrmCambioDocumento_Load);
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
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (FrmCambioDocumento));
      this.BackgroundWorker_Report = new BackgroundWorker();
      this.ProgressBar_Report = new ProgressBar();
      this.Label_Loading = new Label();
      this.SpinningProgress_Report = new CircularProgress.SpinningProgress.SpinningProgress();
      this.Button_Detail_Order = new Button();
      this.Label1 = new Label();
      this.Label3 = new Label();
      this.DateTimePicker_FinalDate = new DateTimePicker();
      this.MaskedTextBox_InitialHour = new MaskedTextBox();
      this.DateTimePicker_InitialDate = new DateTimePicker();
      this.MaskedTextBox_FinalHour = new MaskedTextBox();
      this.TextBox_EstabliDes = new TextBox();
      this.Label_Local = new Label();
      this.TextBox_EstabliId = new TextBox();
      this.Button_Establi_Search = new Button();
      this.Label5 = new Label();
      this.Label6 = new Label();
      this.Label9 = new Label();
      this.SuspendLayout();
      this.BackgroundWorker_Report.WorkerReportsProgress = true;
      this.BackgroundWorker_Report.WorkerSupportsCancellation = true;
      this.ProgressBar_Report.Location = new Point(39, 175);
      this.ProgressBar_Report.Margin = new Padding(4, 5, 4, 5);
      this.ProgressBar_Report.Name = "ProgressBar_Report";
      this.ProgressBar_Report.Size = new Size(33, 20);
      this.ProgressBar_Report.TabIndex = 458;
      this.ProgressBar_Report.Visible = false;
      this.Label_Loading.AutoSize = true;
      this.Label_Loading.Font = new Font("Trebuchet MS", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Label_Loading.ForeColor = Color.Red;
      this.Label_Loading.Location = new Point(181, 146);
      this.Label_Loading.Margin = new Padding(4, 0, 4, 0);
      this.Label_Loading.Name = "Label_Loading";
      this.Label_Loading.Size = new Size(92, 20);
      this.Label_Loading.TabIndex = 457;
      this.Label_Loading.Text = "Cargando...";
      this.Label_Loading.Visible = false;
      this.SpinningProgress_Report.set_ActiveSegmentColour(Color.FromArgb((int) byte.MaxValue, 128, 0));
      ((Control) this.SpinningProgress_Report).BackColor = Color.Transparent;
      this.SpinningProgress_Report.set_BehindTransistionSegmentIsActive(false);
      ((Control) this.SpinningProgress_Report).Font = new Font("Trebuchet MS", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      ((Control) this.SpinningProgress_Report).Location = new Point(174, 47);
      ((Control) this.SpinningProgress_Report).Margin = new Padding(4, 5, 4, 5);
      ((Control) this.SpinningProgress_Report).Name = "SpinningProgress_Report";
      ((Control) this.SpinningProgress_Report).Size = new Size(105, 80);
      ((Control) this.SpinningProgress_Report).TabIndex = 456;
      this.SpinningProgress_Report.set_TransistionSegment(1);
      this.SpinningProgress_Report.set_TransistionSegmentColour(Color.FromArgb((int) byte.MaxValue, 224, 192));
      ((Control) this.SpinningProgress_Report).Visible = false;
      this.Button_Detail_Order.BackColor = Color.PapayaWhip;
      this.Button_Detail_Order.Font = new Font("Trebuchet MS", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Button_Detail_Order.ForeColor = Color.MediumBlue;
      this.Button_Detail_Order.Image = (Image) TriNetRestPOS.My.Resources.Resources.print_printer_s;
      this.Button_Detail_Order.Location = new Point(90, 146);
      this.Button_Detail_Order.Margin = new Padding(4, 5, 4, 5);
      this.Button_Detail_Order.Name = "Button_Detail_Order";
      this.Button_Detail_Order.Size = new Size(270, 60);
      this.Button_Detail_Order.TabIndex = 455;
      this.Button_Detail_Order.Text = "Mostrar";
      this.Button_Detail_Order.TextAlign = ContentAlignment.MiddleRight;
      this.Button_Detail_Order.TextImageRelation = TextImageRelation.ImageBeforeText;
      this.Button_Detail_Order.UseVisualStyleBackColor = false;
      this.Label1.AutoSize = true;
      this.Label1.Font = new Font("Trebuchet MS", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Label1.ForeColor = Color.Firebrick;
      this.Label1.Location = new Point(72, 22);
      this.Label1.Margin = new Padding(4, 0, 4, 0);
      this.Label1.Name = "Label1";
      this.Label1.Size = new Size(98, 20);
      this.Label1.TabIndex = 448;
      this.Label1.Text = "Fecha Inicial";
      this.Label3.AutoSize = true;
      this.Label3.Font = new Font("Trebuchet MS", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Label3.ForeColor = Color.Firebrick;
      this.Label3.Location = new Point(75, 57);
      this.Label3.Margin = new Padding(4, 0, 4, 0);
      this.Label3.Name = "Label3";
      this.Label3.Size = new Size(91, 20);
      this.Label3.TabIndex = 449;
      this.Label3.Text = "Fecha Final";
      this.DateTimePicker_FinalDate.Font = new Font("Trebuchet MS", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.DateTimePicker_FinalDate.Format = DateTimePickerFormat.Short;
      this.DateTimePicker_FinalDate.Location = new Point(185, 55);
      this.DateTimePicker_FinalDate.Margin = new Padding(4, 5, 4, 5);
      this.DateTimePicker_FinalDate.Name = "DateTimePicker_FinalDate";
      this.DateTimePicker_FinalDate.Size = new Size(122, 25);
      this.DateTimePicker_FinalDate.TabIndex = 444;
      this.MaskedTextBox_InitialHour.Font = new Font("Trebuchet MS", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.MaskedTextBox_InitialHour.Location = new Point(310, 20);
      this.MaskedTextBox_InitialHour.Margin = new Padding(4, 5, 4, 5);
      this.MaskedTextBox_InitialHour.Mask = "00:00";
      this.MaskedTextBox_InitialHour.Name = "MaskedTextBox_InitialHour";
      this.MaskedTextBox_InitialHour.Size = new Size(50, 25);
      this.MaskedTextBox_InitialHour.TabIndex = 443;
      this.MaskedTextBox_InitialHour.Text = "0000";
      this.MaskedTextBox_InitialHour.TextAlign = HorizontalAlignment.Center;
      this.DateTimePicker_InitialDate.Font = new Font("Trebuchet MS", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.DateTimePicker_InitialDate.Format = DateTimePickerFormat.Short;
      this.DateTimePicker_InitialDate.Location = new Point(185, 20);
      this.DateTimePicker_InitialDate.Margin = new Padding(4, 5, 4, 5);
      this.DateTimePicker_InitialDate.Name = "DateTimePicker_InitialDate";
      this.DateTimePicker_InitialDate.Size = new Size(122, 25);
      this.DateTimePicker_InitialDate.TabIndex = 442;
      this.MaskedTextBox_FinalHour.Font = new Font("Trebuchet MS", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.MaskedTextBox_FinalHour.Location = new Point(310, 55);
      this.MaskedTextBox_FinalHour.Margin = new Padding(4, 5, 4, 5);
      this.MaskedTextBox_FinalHour.Mask = "00:00";
      this.MaskedTextBox_FinalHour.Name = "MaskedTextBox_FinalHour";
      this.MaskedTextBox_FinalHour.Size = new Size(50, 25);
      this.MaskedTextBox_FinalHour.TabIndex = 445;
      this.MaskedTextBox_FinalHour.Text = "2359";
      this.MaskedTextBox_FinalHour.TextAlign = HorizontalAlignment.Center;
      this.TextBox_EstabliDes.BackColor = Color.FromArgb((int) byte.MaxValue, 240, 140);
      this.TextBox_EstabliDes.Font = new Font("Trebuchet MS", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.TextBox_EstabliDes.Location = new Point(98, 96);
      this.TextBox_EstabliDes.Margin = new Padding(4, 5, 4, 5);
      this.TextBox_EstabliDes.Name = "TextBox_EstabliDes";
      this.TextBox_EstabliDes.ReadOnly = true;
      this.TextBox_EstabliDes.Size = new Size(262, 25);
      this.TextBox_EstabliDes.TabIndex = 446;
      this.Label_Local.AutoSize = true;
      this.Label_Local.Font = new Font("Trebuchet MS", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Label_Local.ForeColor = Color.MediumBlue;
      this.Label_Local.Location = new Point(35, 98);
      this.Label_Local.Margin = new Padding(4, 0, 4, 0);
      this.Label_Local.Name = "Label_Local";
      this.Label_Local.Size = new Size(45, 20);
      this.Label_Local.TabIndex = 450;
      this.Label_Local.Text = "Local";
      this.TextBox_EstabliId.BackColor = Color.White;
      this.TextBox_EstabliId.Font = new Font("Trebuchet MS", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.TextBox_EstabliId.Location = new Point(368, 59);
      this.TextBox_EstabliId.Margin = new Padding(4, 5, 4, 5);
      this.TextBox_EstabliId.MaxLength = 6;
      this.TextBox_EstabliId.Name = "TextBox_EstabliId";
      this.TextBox_EstabliId.Size = new Size(20, 25);
      this.TextBox_EstabliId.TabIndex = 451;
      this.TextBox_EstabliId.Visible = false;
      this.Button_Establi_Search.Font = new Font("Trebuchet MS", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Button_Establi_Search.Image = (Image) TriNetRestPOS.My.Resources.Resources.Buscar_Small;
      this.Button_Establi_Search.Location = new Point(368, 94);
      this.Button_Establi_Search.Margin = new Padding(4, 5, 4, 5);
      this.Button_Establi_Search.Name = "Button_Establi_Search";
      this.Button_Establi_Search.Size = new Size(30, 25);
      this.Button_Establi_Search.TabIndex = 447;
      this.Button_Establi_Search.UseVisualStyleBackColor = true;
      this.Label5.AutoSize = true;
      this.Label5.Font = new Font("Trebuchet MS", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Label5.ForeColor = Color.Firebrick;
      this.Label5.Location = new Point(168, 22);
      this.Label5.Margin = new Padding(4, 0, 4, 0);
      this.Label5.Name = "Label5";
      this.Label5.Size = new Size(15, 20);
      this.Label5.TabIndex = 452;
      this.Label5.Text = ":";
      this.Label6.AutoSize = true;
      this.Label6.Font = new Font("Trebuchet MS", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Label6.ForeColor = Color.Firebrick;
      this.Label6.Location = new Point(168, 57);
      this.Label6.Margin = new Padding(4, 0, 4, 0);
      this.Label6.Name = "Label6";
      this.Label6.Size = new Size(15, 20);
      this.Label6.TabIndex = 453;
      this.Label6.Text = ":";
      this.Label9.AutoSize = true;
      this.Label9.Font = new Font("Trebuchet MS", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Label9.ForeColor = Color.MediumBlue;
      this.Label9.Location = new Point(81, 97);
      this.Label9.Margin = new Padding(4, 0, 4, 0);
      this.Label9.Name = "Label9";
      this.Label9.Size = new Size(15, 20);
      this.Label9.TabIndex = 454;
      this.Label9.Text = ":";
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.BackColor = Color.WhiteSmoke;
      this.ClientSize = new Size(445, 226);
      this.Controls.Add((Control) this.ProgressBar_Report);
      this.Controls.Add((Control) this.Label_Loading);
      this.Controls.Add((Control) this.SpinningProgress_Report);
      this.Controls.Add((Control) this.Button_Detail_Order);
      this.Controls.Add((Control) this.Label1);
      this.Controls.Add((Control) this.Label3);
      this.Controls.Add((Control) this.DateTimePicker_FinalDate);
      this.Controls.Add((Control) this.MaskedTextBox_InitialHour);
      this.Controls.Add((Control) this.DateTimePicker_InitialDate);
      this.Controls.Add((Control) this.MaskedTextBox_FinalHour);
      this.Controls.Add((Control) this.TextBox_EstabliDes);
      this.Controls.Add((Control) this.Label_Local);
      this.Controls.Add((Control) this.TextBox_EstabliId);
      this.Controls.Add((Control) this.Button_Establi_Search);
      this.Controls.Add((Control) this.Label5);
      this.Controls.Add((Control) this.Label6);
      this.Controls.Add((Control) this.Label9);
      this.FormBorderStyle = FormBorderStyle.FixedDialog;
      this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = nameof (FrmCambioDocumento);
      this.StartPosition = FormStartPosition.CenterScreen;
      this.Text = "Cambio de Documento";
      this.ResumeLayout(false);
      this.PerformLayout();
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

    internal virtual ProgressBar ProgressBar_Report { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Label Label_Loading { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual CircularProgress.SpinningProgress.SpinningProgress SpinningProgress_Report { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Button Button_Detail_Order
    {
      get
      {
        return this._Button_Detail_Order;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Button_Detail_Order_Click);
        Button buttonDetailOrder1 = this._Button_Detail_Order;
        if (buttonDetailOrder1 != null)
          buttonDetailOrder1.Click -= eventHandler;
        this._Button_Detail_Order = value;
        Button buttonDetailOrder2 = this._Button_Detail_Order;
        if (buttonDetailOrder2 == null)
          return;
        buttonDetailOrder2.Click += eventHandler;
      }
    }

    internal virtual Label Label1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Label Label3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual DateTimePicker DateTimePicker_FinalDate { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual MaskedTextBox MaskedTextBox_InitialHour { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual DateTimePicker DateTimePicker_InitialDate { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual MaskedTextBox MaskedTextBox_FinalHour { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual TextBox TextBox_EstabliDes { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Label Label_Local { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual TextBox TextBox_EstabliId { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Button Button_Establi_Search
    {
      get
      {
        return this._Button_Establi_Search;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Button_Establi_Search_Click);
        Button buttonEstabliSearch1 = this._Button_Establi_Search;
        if (buttonEstabliSearch1 != null)
          buttonEstabliSearch1.Click -= eventHandler;
        this._Button_Establi_Search = value;
        Button buttonEstabliSearch2 = this._Button_Establi_Search;
        if (buttonEstabliSearch2 == null)
          return;
        buttonEstabliSearch2.Click += eventHandler;
      }
    }

    internal virtual Label Label5 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Label Label6 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Label Label9 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    private void LoadDate()
    {
      this.DateTimePicker_InitialDate.Value = ModGeneralFunctions.ObtenerPrimerDiaMesActual();
      this.DateTimePicker_FinalDate.Value = DateAndTime.Now;
      this.MaskedTextBox_InitialHour.Text = Conversions.ToString(ModGeneralFunctions.ObtenerAPPCONFIG("STR_HORAINICIAL"));
      this.MaskedTextBox_FinalHour.Text = Conversions.ToString(ModGeneralFunctions.ObtenerAPPCONFIG("STR_HORAFINAL"));
    }

    private void Get_Parameter()
    {
      this.dtp_DateInitial = ModGeneralFunctions.ObtenerFechayHora(this.DateTimePicker_InitialDate.Value, this.MaskedTextBox_InitialHour.Text, true);
      this.dtp_DateFinal = ModGeneralFunctions.ObtenerFechayHora(this.DateTimePicker_FinalDate.Value, this.MaskedTextBox_FinalHour.Text, false);
    }

    private void LoadEstabliDefault()
    {
      BL_TR1_ESTABLI blTr1Establi = new BL_TR1_ESTABLI();
      BE_TR1_ESTABLI beTr1Establi1 = new BE_TR1_ESTABLI();
      BE_TR1_ESTABLI beTr1Establi2 = blTr1Establi.ListbyId(ModGeneralVar.g_BE_TR1_VARIABLES_B.get_EstabliId());
      this.TextBox_EstabliId.Text = Conversions.ToString(beTr1Establi2.get_EstabliId());
      this.TextBox_EstabliDes.Text = beTr1Establi2.get_EstabliDes();
    }

    private bool ValidateText()
    {
      bool flag;
      if (Operators.CompareString(this.TextBox_EstabliId.Text, "", false) == 0)
      {
        ModGeneralFunctions.MessageRestrictive("Por Favor Seleccionar Un Local");
        flag = true;
      }
      return flag;
    }

    private void Select_Values()
    {
      this.str_ReportSubTitle = "Agrupado por Local: " + this.TextBox_EstabliDes.Text;
      // ISSUE: variable of a reference type
      string& local;
      // ISSUE: explicit reference operation
      string str = ^(local = ref this.str_ReportSubTitle) + " - del " + Conversions.ToString(ModGeneralFunctions.ObtenerFechayHora(this.dtp_DateInitial, this.MaskedTextBox_InitialHour.Text, true)) + " al " + Conversions.ToString(ModGeneralFunctions.ObtenerFechayHora(this.dtp_DateFinal, this.MaskedTextBox_FinalHour.Text, false));
      local = str;
    }

    private void FrmCambioDocumento_Load(object sender, EventArgs e)
    {
      this.LoadDate();
      this.LoadEstabliDefault();
    }

    private void Button_Establi_Search_Click(object sender, EventArgs e)
    {
      FrmLocal frmLocal = new FrmLocal();
      int num = (int) frmLocal.ShowDialog();
      frmLocal.Dispose();
      if (!ModGeneralVar.g_bol_IsReady || Strings.Len(ModGeneralVar.g_Str_RecordID.Length) <= 0)
        return;
      this.TextBox_EstabliId.Text = ModGeneralVar.g_Str_RecordID;
      this.TextBox_EstabliDes.Text = ModGeneralVar.g_Str_RecordDes;
    }

    private void Button_Detail_Order_Click(object sender, EventArgs e)
    {
      if (this.ValidateText())
        return;
      this.Get_Parameter();
      this.Select_Values();
      this.int_LocalId = ModGeneralFunctions.CadenaToInteger(this.TextBox_EstabliId.Text);
      this.Label_Loading.Visible = true;
      ((Control) this.SpinningProgress_Report).Visible = true;
      this.BackgroundWorker_Report.RunWorkerAsync();
    }

    private void BackgroundWorker_Report_DoWork(object sender, DoWorkEventArgs e)
    {
      this.BackgroundWorker_Report.ReportProgress(50);
      Thread.Sleep(100);
      this.oLista = new BL_TR1_CAMBIO_DOCUMENTO().ListadoCambioDocumento(this.int_LocalId, this.dtp_DateInitial, this.dtp_DateFinal);
      this.BackgroundWorker_Report.ReportProgress(100);
      e.Result = (object) this.oLista;
    }

    private void BackgroundWorker_Report_ProgressChanged(object sender, ProgressChangedEventArgs e)
    {
      this.ProgressBar_Report.Value = e.ProgressPercentage;
    }

    private void BackgroundWorker_Report_RunWorkerCompleted(
      object sender,
      RunWorkerCompletedEventArgs e)
    {
      try
      {
        if (this.oLista.Count == 0)
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
          ModGeneralFunctions.SetUp_Report_Initial_Documents(ref p_ReportDocument, "TR1_REPORT\\rptCambioDocumento.rpt", "Listado de Cambio de Documento", this.str_ReportSubTitle, "");
          p_ReportDocument.Database.Tables[0].SetDataSource((IEnumerable) this.oLista);
          ModGeneralFunctions.SetUp_Report_Final(ref p_ReportDocument, false, "Listado de Cambio de Documento");
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ModGeneralFunctions.MessageRestrictive(ex.Message);
        ProjectData.ClearProjectError();
      }
    }
  }
}
