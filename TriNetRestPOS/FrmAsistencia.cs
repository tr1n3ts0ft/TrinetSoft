// Decompiled with JetBrains decompiler
// Type: TriNetRestPOS.FrmAsistencia
// Assembly: TriNetRestPOS, Version=5.2.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 43377352-E952-4AC1-9BA6-CCBE4AE5F575
// Assembly location: C:\log\TriNetRestPOS.exe

using CrystalDecisions.CrystalReports.Engine;
using KIS.Controls;
using KIS.Controls.Windows;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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
  public class FrmAsistencia : Form
  {
    private IContainer components;
    private DateTime dat_FechaInicial;
    private DateTime dat_FechaFinal;
    private List<BE_TR1_REPORTS> oListaAsistencias;
    private BL_TR1_REPORTS oBL_TR1_REPORTS;
    private string str_ReportSubTitle;
    private int int_ColaboradorId;

    public FrmAsistencia()
    {
      this.Load += new EventHandler(this.FrmAsistencia_Load);
      this.oListaAsistencias = new List<BE_TR1_REPORTS>();
      this.oBL_TR1_REPORTS = new BL_TR1_REPORTS();
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
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (FrmAsistencia));
      this.BackgroundWorker_Report = new BackgroundWorker();
      this.HeaderPanel_DonwloadOption = new HeaderPanel();
      this.SpinningProgress_Report = new CircularProgress.SpinningProgress.SpinningProgress();
      this.Label_Loading = new Label();
      this.TextBox_CompanyId = new TextBox();
      this.TextBox_CompanyDes = new TextBox();
      this.Button_Company_Search = new Button();
      this.Label_Company = new Label();
      this.CheckBox_CompanyDes = new CheckBox();
      this.ComboBox_Mes = new ComboBox();
      this.Label1 = new Label();
      this.ComboBox_Anio = new ComboBox();
      this.Label_Anio = new Label();
      this.ProgressBar_Report = new ProgressBar();
      this.Button_Print = new Button();
      ((Control) this.HeaderPanel_DonwloadOption).SuspendLayout();
      this.SuspendLayout();
      this.BackgroundWorker_Report.WorkerReportsProgress = true;
      this.BackgroundWorker_Report.WorkerSupportsCancellation = true;
      this.HeaderPanel_DonwloadOption.set_BorderColor(SystemColors.ActiveCaption);
      this.HeaderPanel_DonwloadOption.set_BorderStyle((BorderStyles) 1);
      this.HeaderPanel_DonwloadOption.set_CaptionBeginColor(Color.FromArgb(240, 190, 70));
      this.HeaderPanel_DonwloadOption.set_CaptionEndColor(Color.Moccasin);
      this.HeaderPanel_DonwloadOption.set_CaptionGradientDirection(LinearGradientMode.Vertical);
      this.HeaderPanel_DonwloadOption.set_CaptionHeight(26);
      this.HeaderPanel_DonwloadOption.set_CaptionPosition((CaptionPositions) 0);
      this.HeaderPanel_DonwloadOption.set_CaptionText("OPCONES DE BÚSQUEDA");
      this.HeaderPanel_DonwloadOption.set_CaptionVisible(true);
      ((Control) this.HeaderPanel_DonwloadOption).Controls.Add((Control) this.SpinningProgress_Report);
      ((Control) this.HeaderPanel_DonwloadOption).Controls.Add((Control) this.Label_Loading);
      ((Control) this.HeaderPanel_DonwloadOption).Controls.Add((Control) this.TextBox_CompanyId);
      ((Control) this.HeaderPanel_DonwloadOption).Controls.Add((Control) this.TextBox_CompanyDes);
      ((Control) this.HeaderPanel_DonwloadOption).Controls.Add((Control) this.Button_Company_Search);
      ((Control) this.HeaderPanel_DonwloadOption).Controls.Add((Control) this.Label_Company);
      ((Control) this.HeaderPanel_DonwloadOption).Controls.Add((Control) this.CheckBox_CompanyDes);
      ((Control) this.HeaderPanel_DonwloadOption).Controls.Add((Control) this.ComboBox_Mes);
      ((Control) this.HeaderPanel_DonwloadOption).Controls.Add((Control) this.Label1);
      ((Control) this.HeaderPanel_DonwloadOption).Controls.Add((Control) this.ComboBox_Anio);
      ((Control) this.HeaderPanel_DonwloadOption).Controls.Add((Control) this.Label_Anio);
      ((Control) this.HeaderPanel_DonwloadOption).Controls.Add((Control) this.ProgressBar_Report);
      ((Control) this.HeaderPanel_DonwloadOption).Controls.Add((Control) this.Button_Print);
      this.HeaderPanel_DonwloadOption.set_Font(new Font("Trebuchet MS", 9.75f, FontStyle.Bold));
      this.HeaderPanel_DonwloadOption.set_GradientDirection(LinearGradientMode.Vertical);
      this.HeaderPanel_DonwloadOption.set_GradientEnd(SystemColors.Window);
      this.HeaderPanel_DonwloadOption.set_GradientStart(SystemColors.Window);
      ((Control) this.HeaderPanel_DonwloadOption).Location = new Point(2, 1);
      ((Control) this.HeaderPanel_DonwloadOption).Name = "HeaderPanel_DonwloadOption";
      this.HeaderPanel_DonwloadOption.set_PanelIcon((Icon) null);
      this.HeaderPanel_DonwloadOption.set_PanelIconVisible(false);
      ((Control) this.HeaderPanel_DonwloadOption).Size = new Size(452, 270);
      ((Control) this.HeaderPanel_DonwloadOption).TabIndex = 192;
      this.HeaderPanel_DonwloadOption.set_TextAntialias(true);
      this.SpinningProgress_Report.set_ActiveSegmentColour(Color.FromArgb((int) byte.MaxValue, 128, 0));
      ((Control) this.SpinningProgress_Report).BackColor = Color.Transparent;
      ((Control) this.SpinningProgress_Report).Location = new Point(191, 38);
      ((Control) this.SpinningProgress_Report).Margin = new Padding(4, 6, 4, 6);
      ((Control) this.SpinningProgress_Report).Name = "SpinningProgress_Report";
      ((Control) this.SpinningProgress_Report).RightToLeft = RightToLeft.Yes;
      ((Control) this.SpinningProgress_Report).Size = new Size(90, 83);
      ((Control) this.SpinningProgress_Report).TabIndex = 458;
      this.SpinningProgress_Report.set_TransistionSegment(6);
      this.SpinningProgress_Report.set_TransistionSegmentColour(Color.FromArgb((int) byte.MaxValue, 224, 192));
      ((Control) this.SpinningProgress_Report).Visible = false;
      this.Label_Loading.AutoSize = true;
      this.Label_Loading.Font = new Font("Trebuchet MS", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Label_Loading.ForeColor = Color.Red;
      this.Label_Loading.Location = new Point(189, (int) sbyte.MaxValue);
      this.Label_Loading.Name = "Label_Loading";
      this.Label_Loading.Size = new Size(92, 20);
      this.Label_Loading.TabIndex = 459;
      this.Label_Loading.Text = "Cargando...";
      this.Label_Loading.Visible = false;
      this.TextBox_CompanyId.BackColor = Color.White;
      this.TextBox_CompanyId.Font = new Font("Verdana", 6f, FontStyle.Bold);
      this.TextBox_CompanyId.Location = new Point(358, 153);
      this.TextBox_CompanyId.MaxLength = 10;
      this.TextBox_CompanyId.Multiline = true;
      this.TextBox_CompanyId.Name = "TextBox_CompanyId";
      this.TextBox_CompanyId.Size = new Size(29, 19);
      this.TextBox_CompanyId.TabIndex = 469;
      this.TextBox_CompanyId.Visible = false;
      this.TextBox_CompanyDes.BackColor = Color.FromArgb((int) byte.MaxValue, 240, 140);
      this.TextBox_CompanyDes.Enabled = false;
      this.TextBox_CompanyDes.Font = new Font("Verdana", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.TextBox_CompanyDes.Location = new Point(123, 118);
      this.TextBox_CompanyDes.Multiline = true;
      this.TextBox_CompanyDes.Name = "TextBox_CompanyDes";
      this.TextBox_CompanyDes.ReadOnly = true;
      this.TextBox_CompanyDes.Size = new Size(229, 54);
      this.TextBox_CompanyDes.TabIndex = 468;
      this.Button_Company_Search.Image = (Image) TriNetRestPOS.My.Resources.Resources.Buscar_Small;
      this.Button_Company_Search.Location = new Point(357, 118);
      this.Button_Company_Search.Name = "Button_Company_Search";
      this.Button_Company_Search.Size = new Size(48, 29);
      this.Button_Company_Search.TabIndex = 466;
      this.Button_Company_Search.UseVisualStyleBackColor = true;
      this.Label_Company.AutoSize = true;
      this.Label_Company.Font = new Font("Trebuchet MS", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Label_Company.ForeColor = Color.MediumBlue;
      this.Label_Company.Location = new Point(3, 117);
      this.Label_Company.Name = "Label_Company";
      this.Label_Company.Size = new Size(110, 22);
      this.Label_Company.TabIndex = 467;
      this.Label_Company.Text = "Colaborador:";
      this.CheckBox_CompanyDes.AutoSize = true;
      this.CheckBox_CompanyDes.Checked = true;
      this.CheckBox_CompanyDes.CheckState = CheckState.Checked;
      this.CheckBox_CompanyDes.Font = new Font("Trebuchet MS", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.CheckBox_CompanyDes.ForeColor = Color.FromArgb(192, 0, 0);
      this.CheckBox_CompanyDes.Location = new Point(288, 99);
      this.CheckBox_CompanyDes.Name = "CheckBox_CompanyDes";
      this.CheckBox_CompanyDes.Size = new Size(63, 22);
      this.CheckBox_CompanyDes.TabIndex = 465;
      this.CheckBox_CompanyDes.Text = "Todos";
      this.CheckBox_CompanyDes.UseVisualStyleBackColor = true;
      this.ComboBox_Mes.DropDownStyle = ComboBoxStyle.DropDownList;
      this.ComboBox_Mes.Font = new Font("Trebuchet MS", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.ComboBox_Mes.FormattingEnabled = true;
      this.ComboBox_Mes.Items.AddRange(new object[3]
      {
        (object) "Hoy",
        (object) "Ayer",
        (object) "Rango"
      });
      this.ComboBox_Mes.Location = new Point(123, 62);
      this.ComboBox_Mes.Name = "ComboBox_Mes";
      this.ComboBox_Mes.Size = new Size(229, 30);
      this.ComboBox_Mes.TabIndex = 464;
      this.Label1.AutoSize = true;
      this.Label1.Font = new Font("Trebuchet MS", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Label1.ForeColor = Color.MediumBlue;
      this.Label1.Location = new Point(69, 65);
      this.Label1.Name = "Label1";
      this.Label1.Size = new Size(44, 22);
      this.Label1.TabIndex = 463;
      this.Label1.Text = "Mes:";
      this.ComboBox_Anio.DropDownStyle = ComboBoxStyle.DropDownList;
      this.ComboBox_Anio.Font = new Font("Trebuchet MS", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.ComboBox_Anio.FormattingEnabled = true;
      this.ComboBox_Anio.Items.AddRange(new object[3]
      {
        (object) "Hoy",
        (object) "Ayer",
        (object) "Rango"
      });
      this.ComboBox_Anio.Location = new Point(123, 15);
      this.ComboBox_Anio.Name = "ComboBox_Anio";
      this.ComboBox_Anio.Size = new Size(229, 30);
      this.ComboBox_Anio.TabIndex = 462;
      this.Label_Anio.AutoSize = true;
      this.Label_Anio.Font = new Font("Trebuchet MS", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Label_Anio.ForeColor = Color.MediumBlue;
      this.Label_Anio.Location = new Point(67, 18);
      this.Label_Anio.Name = "Label_Anio";
      this.Label_Anio.Size = new Size(46, 22);
      this.Label_Anio.TabIndex = 461;
      this.Label_Anio.Text = "Año:";
      this.ProgressBar_Report.Location = new Point(42, 191);
      this.ProgressBar_Report.Name = "ProgressBar_Report";
      this.ProgressBar_Report.Size = new Size(22, 10);
      this.ProgressBar_Report.TabIndex = 460;
      this.ProgressBar_Report.Visible = false;
      this.Button_Print.BackColor = Color.PapayaWhip;
      this.Button_Print.Font = new Font("Trebuchet MS", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Button_Print.ForeColor = Color.MediumBlue;
      this.Button_Print.Image = (Image) TriNetRestPOS.My.Resources.Resources.print_printer_s;
      this.Button_Print.Location = new Point(123, 178);
      this.Button_Print.Name = "Button_Print";
      this.Button_Print.Size = new Size(229, 56);
      this.Button_Print.TabIndex = 419;
      this.Button_Print.Text = "Mostrar";
      this.Button_Print.TextAlign = ContentAlignment.MiddleRight;
      this.Button_Print.TextImageRelation = TextImageRelation.ImageBeforeText;
      this.Button_Print.UseVisualStyleBackColor = false;
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.ClientSize = new Size(453, 271);
      this.Controls.Add((Control) this.HeaderPanel_DonwloadOption);
      this.FormBorderStyle = FormBorderStyle.FixedDialog;
      this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = nameof (FrmAsistencia);
      this.StartPosition = FormStartPosition.CenterScreen;
      this.Text = "Asistencia";
      ((Control) this.HeaderPanel_DonwloadOption).ResumeLayout(false);
      ((Control) this.HeaderPanel_DonwloadOption).PerformLayout();
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

    internal virtual HeaderPanel HeaderPanel_DonwloadOption { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual CircularProgress.SpinningProgress.SpinningProgress SpinningProgress_Report { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual ComboBox ComboBox_Mes { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Label Label1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual ComboBox ComboBox_Anio { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Label Label_Anio { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual ProgressBar ProgressBar_Report { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Label Label_Loading { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Button Button_Print
    {
      get
      {
        return this._Button_Print;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Button_Print_Click);
        Button buttonPrint1 = this._Button_Print;
        if (buttonPrint1 != null)
          buttonPrint1.Click -= eventHandler;
        this._Button_Print = value;
        Button buttonPrint2 = this._Button_Print;
        if (buttonPrint2 == null)
          return;
        buttonPrint2.Click += eventHandler;
      }
    }

    internal virtual TextBox TextBox_CompanyId { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual TextBox TextBox_CompanyDes { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Button Button_Company_Search
    {
      get
      {
        return this._Button_Company_Search;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Button_Company_Search_Click);
        Button buttonCompanySearch1 = this._Button_Company_Search;
        if (buttonCompanySearch1 != null)
          buttonCompanySearch1.Click -= eventHandler;
        this._Button_Company_Search = value;
        Button buttonCompanySearch2 = this._Button_Company_Search;
        if (buttonCompanySearch2 == null)
          return;
        buttonCompanySearch2.Click += eventHandler;
      }
    }

    internal virtual Label Label_Company { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual CheckBox CheckBox_CompanyDes { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    private void CargarCombos()
    {
      BL_TR1_ASISTENCIA blTr1Asistencia = new BL_TR1_ASISTENCIA();
      List<BE_TR1_ASISTENCIA> beTr1AsistenciaList1 = new List<BE_TR1_ASISTENCIA>();
      List<BE_TR1_ASISTENCIA> beTr1AsistenciaList2 = new List<BE_TR1_ASISTENCIA>();
      this.ComboBox_Anio.DataSource = (object) blTr1Asistencia.ObtenerAniosAsistencia();
      this.ComboBox_Anio.DisplayMember = "Anio";
      this.ComboBox_Anio.ValueMember = "Anio";
      this.ComboBox_Mes.DataSource = (object) blTr1Asistencia.ObtenerMesAsistencia();
      this.ComboBox_Mes.DisplayMember = "Mes";
      this.ComboBox_Mes.ValueMember = "MesId";
      beTr1AsistenciaList1 = (List<BE_TR1_ASISTENCIA>) null;
      beTr1AsistenciaList2 = (List<BE_TR1_ASISTENCIA>) null;
    }

    private void Select_Values()
    {
      this.str_ReportSubTitle = !this.CheckBox_CompanyDes.Checked ? "Colaborador : " + this.TextBox_CompanyDes.Text : "Colaborador : Todos";
      this.str_ReportSubTitle = this.str_ReportSubTitle + " Año : " + this.ComboBox_Anio.Text + " Mes : " + this.ComboBox_Mes.Text;
    }

    private void CargarReporte()
    {
      try
      {
        this.Select_Values();
        this.int_ColaboradorId = 0;
        this.dat_FechaInicial = Convert.ToDateTime(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object) "01/", this.ComboBox_Mes.SelectedValue), (object) "/"), (object) this.ComboBox_Anio.Text));
        this.dat_FechaFinal = ModGeneralFunctions.ObtenerUltimoDiaMesFecha(this.dat_FechaInicial);
        this.Label_Loading.Visible = true;
        ((Control) this.SpinningProgress_Report).Visible = true;
        this.BackgroundWorker_Report.RunWorkerAsync();
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
    }

    private void BackgroundWorker_Report_DoWork(object sender, DoWorkEventArgs e)
    {
      try
      {
        this.oListaAsistencias = new List<BE_TR1_REPORTS>();
        this.BackgroundWorker_Report.ReportProgress(50);
        Thread.Sleep(100);
        this.oListaAsistencias = this.oBL_TR1_REPORTS.ReporteAsistencia(this.dat_FechaInicial, this.dat_FechaFinal, this.int_ColaboradorId);
        this.BackgroundWorker_Report.ReportProgress(100);
        e.Result = (object) this.oListaAsistencias;
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ModGeneralFunctions.MessageError(ex.Message, true);
        ProjectData.ClearProjectError();
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
      if (this.oListaAsistencias.Count == 0)
      {
        ((Control) this.SpinningProgress_Report).Visible = false;
        this.Label_Loading.Visible = false;
        ModGeneralFunctions.MessageOk("¡No Exite Datos para Mostrar en el Reporte!");
      }
      else
      {
        ((Control) this.SpinningProgress_Report).Visible = false;
        this.Label_Loading.Visible = false;
        ReportDocument p_ReportDocument = new ReportDocument();
        ModGeneralFunctions.SetUp_Report_Initial(ref p_ReportDocument, "TR1_REPORT\\rptListadoAsistencia.rpt", "Listado de Asistencias", this.str_ReportSubTitle, "");
        p_ReportDocument.Database.Tables[0].SetDataSource(RuntimeHelpers.GetObjectValue(e.Result));
        ModGeneralFunctions.SetUp_Report_Final(ref p_ReportDocument, false, "Listado de Asistencias");
      }
    }

    private void Button_Company_Search_Click(object sender, EventArgs e)
    {
    }

    private void FrmAsistencia_Load(object sender, EventArgs e)
    {
      this.CargarCombos();
    }

    private void Button_Print_Click(object sender, EventArgs e)
    {
      this.CargarReporte();
    }
  }
}
