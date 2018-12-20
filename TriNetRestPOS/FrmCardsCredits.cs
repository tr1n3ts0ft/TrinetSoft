// Decompiled with JetBrains decompiler
// Type: TriNetRestPOS.FrmCardsCredits
// Assembly: TriNetRestPOS, Version=5.2.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 43377352-E952-4AC1-9BA6-CCBE4AE5F575
// Assembly location: C:\log\TriNetRestPOS.exe

using CrystalDecisions.CrystalReports.Engine;
using KIS.Controls;
using KIS.Controls.Windows;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
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
  public class FrmCardsCredits : Form
  {
    private IContainer components;
    private string str_SubTitle;
    private BL_TR1_DOCUMENTS oBL_DOCUMENTS;
    private BE_TR1_DOCUMENTS oBE_DOCUMENTS;
    private List<BE_TR1_DOCUMENTS> oListDocumentsCReditsCards;

    [DebuggerNonUserCode]
    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    [DebuggerStepThrough]
    private void InitializeComponent()
    {
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (FrmCardsCredits));
      this.Button_Print = new Button();
      this.DateTimePicker_FinalDate = new DateTimePicker();
      this.Label_FinalDate = new Label();
      this.Label_InitialDate = new Label();
      this.DateTimePicker_InitialDate = new DateTimePicker();
      this.TextBox_EstabliDes = new TextBox();
      this.TextBox_EstabliId = new TextBox();
      this.Button_Establi_Search = new Button();
      this.CheckBox_LocalAll = new CheckBox();
      this.Label_Local = new Label();
      this.Label_Loading = new Label();
      this.SpinningProgress_Report = new CircularProgress.SpinningProgress.SpinningProgress();
      this.BackgroundWorker_Report = new BackgroundWorker();
      this.ProgressBar_Report = new ProgressBar();
      this.HeaderPanel2 = new HeaderPanel();
      this.GroupBox1 = new GroupBox();
      this.SpinningProgress2 = new CircularProgress.SpinningProgress.SpinningProgress();
      ((Control) this.HeaderPanel2).SuspendLayout();
      this.GroupBox1.SuspendLayout();
      this.SuspendLayout();
      this.Button_Print.BackColor = Color.PapayaWhip;
      this.Button_Print.Font = new Font("Trebuchet MS", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Button_Print.ForeColor = Color.MediumBlue;
      this.Button_Print.Image = (Image) TriNetRestPOS.My.Resources.Resources.print_printer_s;
      this.Button_Print.Location = new Point(5, 131);
      this.Button_Print.Name = "Button_Print";
      this.Button_Print.Size = new Size(231, 53);
      this.Button_Print.TabIndex = 1;
      this.Button_Print.Text = "Mostrar";
      this.Button_Print.TextAlign = ContentAlignment.MiddleRight;
      this.Button_Print.TextImageRelation = TextImageRelation.ImageBeforeText;
      this.Button_Print.UseVisualStyleBackColor = false;
      this.DateTimePicker_FinalDate.Font = new Font("Verdana", 6.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.DateTimePicker_FinalDate.Format = DateTimePickerFormat.Short;
      this.DateTimePicker_FinalDate.Location = new Point(122, 41);
      this.DateTimePicker_FinalDate.Name = "DateTimePicker_FinalDate";
      this.DateTimePicker_FinalDate.Size = new Size(96, 18);
      this.DateTimePicker_FinalDate.TabIndex = 420;
      this.Label_FinalDate.AutoSize = true;
      this.Label_FinalDate.Font = new Font("Trebuchet MS", 9f, FontStyle.Bold);
      this.Label_FinalDate.ForeColor = Color.MediumBlue;
      this.Label_FinalDate.Location = new Point(119, 22);
      this.Label_FinalDate.Name = "Label_FinalDate";
      this.Label_FinalDate.Size = new Size(55, 18);
      this.Label_FinalDate.TabIndex = 422;
      this.Label_FinalDate.Text = "F. Final:";
      this.Label_InitialDate.AutoSize = true;
      this.Label_InitialDate.Font = new Font("Trebuchet MS", 9f, FontStyle.Bold);
      this.Label_InitialDate.ForeColor = Color.MediumBlue;
      this.Label_InitialDate.Location = new Point(6, 22);
      this.Label_InitialDate.Name = "Label_InitialDate";
      this.Label_InitialDate.Size = new Size(61, 18);
      this.Label_InitialDate.TabIndex = 421;
      this.Label_InitialDate.Text = "F. Inicial:";
      this.DateTimePicker_InitialDate.Font = new Font("Verdana", 6.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.DateTimePicker_InitialDate.Format = DateTimePickerFormat.Short;
      this.DateTimePicker_InitialDate.Location = new Point(8, 41);
      this.DateTimePicker_InitialDate.Name = "DateTimePicker_InitialDate";
      this.DateTimePicker_InitialDate.Size = new Size(96, 18);
      this.DateTimePicker_InitialDate.TabIndex = 419;
      this.TextBox_EstabliDes.BackColor = Color.FromArgb((int) byte.MaxValue, 240, 140);
      this.TextBox_EstabliDes.Font = new Font("Verdana", 6.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.TextBox_EstabliDes.Location = new Point(7, 101);
      this.TextBox_EstabliDes.Name = "TextBox_EstabliDes";
      this.TextBox_EstabliDes.ReadOnly = true;
      this.TextBox_EstabliDes.Size = new Size(196, 18);
      this.TextBox_EstabliDes.TabIndex = 415;
      this.TextBox_EstabliId.BackColor = Color.White;
      this.TextBox_EstabliId.Font = new Font("Verdana", 6f, FontStyle.Bold);
      this.TextBox_EstabliId.Location = new Point(86, 79);
      this.TextBox_EstabliId.MaxLength = 6;
      this.TextBox_EstabliId.Multiline = true;
      this.TextBox_EstabliId.Name = "TextBox_EstabliId";
      this.TextBox_EstabliId.Size = new Size(10, 19);
      this.TextBox_EstabliId.TabIndex = 414;
      this.TextBox_EstabliId.Visible = false;
      this.Button_Establi_Search.Image = (Image) TriNetRestPOS.My.Resources.Resources.Buscar_Small;
      this.Button_Establi_Search.Location = new Point(204, 99);
      this.Button_Establi_Search.Name = "Button_Establi_Search";
      this.Button_Establi_Search.Size = new Size(29, 21);
      this.Button_Establi_Search.TabIndex = 413;
      this.Button_Establi_Search.UseVisualStyleBackColor = true;
      this.CheckBox_LocalAll.AutoSize = true;
      this.CheckBox_LocalAll.Font = new Font("Trebuchet MS", 6.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.CheckBox_LocalAll.ForeColor = Color.Red;
      this.CheckBox_LocalAll.Location = new Point(158, 83);
      this.CheckBox_LocalAll.Name = "CheckBox_LocalAll";
      this.CheckBox_LocalAll.Size = new Size(54, 19);
      this.CheckBox_LocalAll.TabIndex = 425;
      this.CheckBox_LocalAll.Text = "Todos";
      this.CheckBox_LocalAll.UseVisualStyleBackColor = true;
      this.CheckBox_LocalAll.Visible = false;
      this.Label_Local.AutoSize = true;
      this.Label_Local.Font = new Font("Trebuchet MS", 9f, FontStyle.Bold);
      this.Label_Local.ForeColor = Color.MediumBlue;
      this.Label_Local.Location = new Point(5, 83);
      this.Label_Local.Name = "Label_Local";
      this.Label_Local.Size = new Size(42, 18);
      this.Label_Local.TabIndex = 416;
      this.Label_Local.Text = "Local:";
      this.Label_Loading.AutoSize = true;
      this.Label_Loading.Font = new Font("Trebuchet MS", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Label_Loading.ForeColor = Color.Red;
      this.Label_Loading.Location = new Point(87, 84);
      this.Label_Loading.Name = "Label_Loading";
      this.Label_Loading.Size = new Size(71, 18);
      this.Label_Loading.TabIndex = 429;
      this.Label_Loading.Text = "Cargando...";
      this.Label_Loading.Visible = false;
      this.SpinningProgress_Report.set_ActiveSegmentColour(Color.FromArgb((int) byte.MaxValue, 128, 0));
      ((Control) this.SpinningProgress_Report).BackColor = Color.Transparent;
      this.SpinningProgress_Report.set_BehindTransistionSegmentIsActive(false);
      ((Control) this.SpinningProgress_Report).Location = new Point(89, 23);
      ((Control) this.SpinningProgress_Report).Margin = new Padding(4, 6, 4, 6);
      ((Control) this.SpinningProgress_Report).Name = "SpinningProgress_Report";
      ((Control) this.SpinningProgress_Report).RightToLeft = RightToLeft.Yes;
      ((Control) this.SpinningProgress_Report).Size = new Size(61, 61);
      ((Control) this.SpinningProgress_Report).TabIndex = 428;
      this.SpinningProgress_Report.set_TransistionSegment(6);
      this.SpinningProgress_Report.set_TransistionSegmentColour(Color.FromArgb((int) byte.MaxValue, 224, 192));
      ((Control) this.SpinningProgress_Report).Visible = false;
      this.BackgroundWorker_Report.WorkerReportsProgress = true;
      this.BackgroundWorker_Report.WorkerSupportsCancellation = true;
      this.ProgressBar_Report.Location = new Point(102, 83);
      this.ProgressBar_Report.Name = "ProgressBar_Report";
      this.ProgressBar_Report.Size = new Size(22, 10);
      this.ProgressBar_Report.TabIndex = 430;
      this.ProgressBar_Report.Visible = false;
      this.HeaderPanel2.set_BorderColor(SystemColors.ActiveCaption);
      this.HeaderPanel2.set_BorderStyle((BorderStyles) 1);
      this.HeaderPanel2.set_CaptionBeginColor(Color.FromArgb(240, 190, 70));
      this.HeaderPanel2.set_CaptionEndColor(Color.Moccasin);
      this.HeaderPanel2.set_CaptionGradientDirection(LinearGradientMode.Vertical);
      this.HeaderPanel2.set_CaptionHeight(26);
      this.HeaderPanel2.set_CaptionPosition((CaptionPositions) 0);
      this.HeaderPanel2.set_CaptionText("Opciones de Búsqueda");
      this.HeaderPanel2.set_CaptionVisible(true);
      ((Control) this.HeaderPanel2).Controls.Add((Control) this.SpinningProgress_Report);
      ((Control) this.HeaderPanel2).Controls.Add((Control) this.Label_Loading);
      ((Control) this.HeaderPanel2).Controls.Add((Control) this.GroupBox1);
      ((Control) this.HeaderPanel2).Controls.Add((Control) this.SpinningProgress2);
      ((Control) this.HeaderPanel2).Controls.Add((Control) this.ProgressBar_Report);
      ((Control) this.HeaderPanel2).Controls.Add((Control) this.Button_Establi_Search);
      ((Control) this.HeaderPanel2).Controls.Add((Control) this.Button_Print);
      ((Control) this.HeaderPanel2).Controls.Add((Control) this.TextBox_EstabliId);
      ((Control) this.HeaderPanel2).Controls.Add((Control) this.TextBox_EstabliDes);
      ((Control) this.HeaderPanel2).Controls.Add((Control) this.Label_Local);
      ((Control) this.HeaderPanel2).Controls.Add((Control) this.CheckBox_LocalAll);
      this.HeaderPanel2.set_Font(new Font("Trebuchet MS", 9.75f, FontStyle.Bold));
      this.HeaderPanel2.set_GradientDirection(LinearGradientMode.Vertical);
      this.HeaderPanel2.set_GradientEnd(SystemColors.Window);
      this.HeaderPanel2.set_GradientStart(SystemColors.Window);
      ((Control) this.HeaderPanel2).Location = new Point(0, 0);
      ((Control) this.HeaderPanel2).Name = "HeaderPanel2";
      this.HeaderPanel2.set_PanelIcon((Icon) componentResourceManager.GetObject("HeaderPanel2.PanelIcon"));
      this.HeaderPanel2.set_PanelIconVisible(true);
      ((Control) this.HeaderPanel2).RightToLeft = RightToLeft.No;
      ((Control) this.HeaderPanel2).Size = new Size(242, 216);
      ((Control) this.HeaderPanel2).TabIndex = 431;
      this.HeaderPanel2.set_TextAntialias(true);
      this.GroupBox1.Controls.Add((Control) this.DateTimePicker_FinalDate);
      this.GroupBox1.Controls.Add((Control) this.DateTimePicker_InitialDate);
      this.GroupBox1.Controls.Add((Control) this.Label_FinalDate);
      this.GroupBox1.Controls.Add((Control) this.Label_InitialDate);
      this.GroupBox1.ForeColor = Color.Red;
      this.GroupBox1.Location = new Point(5, 3);
      this.GroupBox1.Name = "GroupBox1";
      this.GroupBox1.Size = new Size(226, 69);
      this.GroupBox1.TabIndex = 432;
      this.GroupBox1.TabStop = false;
      this.GroupBox1.Text = "Fechas";
      this.SpinningProgress2.set_ActiveSegmentColour(Color.FromArgb((int) byte.MaxValue, 128, 0));
      ((Control) this.SpinningProgress2).BackColor = Color.Transparent;
      this.SpinningProgress2.set_BehindTransistionSegmentIsActive(false);
      ((Control) this.SpinningProgress2).Location = new Point(7, 431);
      ((Control) this.SpinningProgress2).Margin = new Padding(36, 69, 36, 69);
      ((Control) this.SpinningProgress2).Name = "SpinningProgress2";
      ((Control) this.SpinningProgress2).RightToLeft = RightToLeft.Yes;
      ((Control) this.SpinningProgress2).Size = new Size(100, 100);
      ((Control) this.SpinningProgress2).TabIndex = 470;
      this.SpinningProgress2.set_TransistionSegment(5);
      this.SpinningProgress2.set_TransistionSegmentColour(Color.FromArgb((int) byte.MaxValue, 224, 192));
      ((Control) this.SpinningProgress2).Visible = false;
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.BackColor = Color.White;
      this.ClientSize = new Size(241, 217);
      this.Controls.Add((Control) this.HeaderPanel2);
      this.FormBorderStyle = FormBorderStyle.FixedDialog;
      this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
      this.KeyPreview = true;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = nameof (FrmCardsCredits);
      this.StartPosition = FormStartPosition.CenterScreen;
      this.Text = "[Ventas Tarjetas de Crédito]";
      ((Control) this.HeaderPanel2).ResumeLayout(false);
      ((Control) this.HeaderPanel2).PerformLayout();
      this.GroupBox1.ResumeLayout(false);
      this.GroupBox1.PerformLayout();
      this.ResumeLayout(false);
    }

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

    internal virtual DateTimePicker DateTimePicker_FinalDate { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Label Label_FinalDate { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Label Label_InitialDate { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual DateTimePicker DateTimePicker_InitialDate { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual TextBox TextBox_EstabliDes { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

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

    internal virtual CheckBox CheckBox_LocalAll
    {
      get
      {
        return this._CheckBox_LocalAll;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.CheckBox_LocalAll_CheckedChanged);
        CheckBox checkBoxLocalAll1 = this._CheckBox_LocalAll;
        if (checkBoxLocalAll1 != null)
          checkBoxLocalAll1.CheckedChanged -= eventHandler;
        this._CheckBox_LocalAll = value;
        CheckBox checkBoxLocalAll2 = this._CheckBox_LocalAll;
        if (checkBoxLocalAll2 == null)
          return;
        checkBoxLocalAll2.CheckedChanged += eventHandler;
      }
    }

    internal virtual Label Label_Local { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Label Label_Loading { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual CircularProgress.SpinningProgress.SpinningProgress SpinningProgress_Report { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

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

    internal virtual HeaderPanel HeaderPanel2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual CircularProgress.SpinningProgress.SpinningProgress SpinningProgress2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual GroupBox GroupBox1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    public FrmCardsCredits()
    {
      this.Load += new EventHandler(this.FrmCardsCredits_Load);
      this.InitializeComponent();
      this.oBL_DOCUMENTS = new BL_TR1_DOCUMENTS();
      this.oBE_DOCUMENTS = new BE_TR1_DOCUMENTS();
      this.oListDocumentsCReditsCards = new List<BE_TR1_DOCUMENTS>();
    }

    private void Button_Establi_Search_Click(object sender, EventArgs e)
    {
      try
      {
        FrmLocal frmLocal = new FrmLocal();
        int num = (int) frmLocal.ShowDialog();
        frmLocal.Dispose();
        if (!ModGeneralVar.g_bol_IsReady || Strings.Len(ModGeneralVar.g_Str_RecordID.Length) <= 0)
          return;
        this.TextBox_EstabliId.Text = ModGeneralVar.g_Str_RecordID;
        this.TextBox_EstabliDes.Text = ModGeneralVar.g_Str_RecordDes;
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
    }

    private void FrmCardsCredits_Load(object sender, EventArgs e)
    {
      this.LoadEstabliDefault();
      this.Set_Date();
    }

    private void LoadEstabliDefault()
    {
      BL_TR1_ESTABLI blTr1Establi = new BL_TR1_ESTABLI();
      BE_TR1_ESTABLI beTr1Establi1 = new BE_TR1_ESTABLI();
      BE_TR1_ESTABLI beTr1Establi2 = blTr1Establi.ListbyId(ModGeneralVar.g_BE_TR1_VARIABLES_B.get_EstabliId());
      this.TextBox_EstabliId.Text = Conversions.ToString(beTr1Establi2.get_EstabliId());
      this.TextBox_EstabliDes.Text = beTr1Establi2.get_EstabliDes();
    }

    private void Set_Date()
    {
      this.DateTimePicker_InitialDate.Text = Conversions.ToString(ModGeneralFunctions.ObtenerPrimerDiaMesActual());
      this.DateTimePicker_FinalDate.Text = Conversions.ToString(DateAndTime.Today);
    }

    private void CheckBox_LocalAll_CheckedChanged(object sender, EventArgs e)
    {
      try
      {
        if (this.CheckBox_LocalAll.Checked)
        {
          this.TextBox_EstabliId.Text = "";
          this.TextBox_EstabliDes.Enabled = false;
          this.TextBox_EstabliDes.Text = "";
          this.Button_Establi_Search.Enabled = false;
        }
        else
        {
          this.TextBox_EstabliDes.Enabled = true;
          this.Button_Establi_Search.Enabled = true;
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
    }

    private void Button_Print_Click(object sender, EventArgs e)
    {
      this.Report_Print();
    }

    private void Report_Print()
    {
      ReportDocument reportDocument = new ReportDocument();
      if (!this.validate_Data())
        return;
      this.Select_Values();
      this.oBE_DOCUMENTS.set_EstabliId(checked ((int) Math.Round(Conversion.Val(this.TextBox_EstabliId.Text))));
      this.oBE_DOCUMENTS.set_InitialDate(this.DateTimePicker_InitialDate.Value);
      this.oBE_DOCUMENTS.set_FinalDate(this.DateTimePicker_FinalDate.Value);
      this.Label_Loading.Visible = true;
      ((Control) this.SpinningProgress_Report).Visible = true;
      this.BackgroundWorker_Report.RunWorkerAsync();
    }

    private void BackgroundWorker_Report_DoWork(object sender, DoWorkEventArgs e)
    {
      this.BackgroundWorker_Report.ReportProgress(50);
      Thread.Sleep(1000);
      try
      {
        this.oListDocumentsCReditsCards = this.oBL_DOCUMENTS.Documents_CreditCards(this.oBE_DOCUMENTS);
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
      finally
      {
        this.BackgroundWorker_Report.ReportProgress(100);
        e.Result = (object) this.oListDocumentsCReditsCards;
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
      if (this.oListDocumentsCReditsCards.Count == 0)
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
        ModGeneralFunctions.SetUp_Report_Initial(ref p_ReportDocument, "TR1_REPORT\\rpt_CreditsCards.rpt", "Ranking de Ventas por Tarjetas de Crédito", this.str_SubTitle, "");
        p_ReportDocument.Database.Tables[0].SetDataSource((IEnumerable) this.oListDocumentsCReditsCards);
        ModGeneralFunctions.SetUp_Report_Final(ref p_ReportDocument, false, "Ranking de Ventas por Tarjetas de Crédito");
      }
    }

    private bool validate_Data()
    {
      if (Operators.CompareString(this.TextBox_EstabliId.Text, "", false) != 0)
        return true;
      ModGeneralFunctions.MessageRestrictive("Ingrese un Local");
      return false;
    }

    private void Select_Values()
    {
      this.str_SubTitle = "Agrupado por Local: " + this.TextBox_EstabliDes.Text;
      this.str_SubTitle = this.str_SubTitle + " - Fecha Desde " + Conversions.ToString(this.DateTimePicker_InitialDate.Value) + " Hasta " + Conversions.ToString(this.DateTimePicker_FinalDate.Value);
    }
  }
}
