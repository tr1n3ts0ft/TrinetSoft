// Decompiled with JetBrains decompiler
// Type: TriNetRestPOS.FrmAnticipeConsume
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
  public class FrmAnticipeConsume : Form
  {
    private IContainer components;
    private List<BE_TR1_ANTICIPE_CONSUME> oLIstBE_TR1_ANTICIPE_CONSUME;
    private BL_TR1_ANTICIPE_CONSUME oBL_TR1_ANTICIPE_CONSUME;
    private BE_TR1_ANTICIPE_CONSUME oBE_TR1_ANTICIPE_CONSUME;
    private DateTime dtp_InitialDate;
    private DateTime dtp_FinalDate;
    private string str_ClientId;
    private int int_EstabliId;
    private string str_ReportSubTitle;
    private bool bol_IsAll;
    private string str_DocumentId;

    public FrmAnticipeConsume()
    {
      this.Load += new EventHandler(this.FrmAnticipeConsume_Load);
      this.KeyDown += new KeyEventHandler(this.FrmAnticipeConsume_KeyDown);
      this.InitializeComponent();
    }

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
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (FrmAnticipeConsume));
      this.HeaderPanelBusqueda = new HeaderPanel();
      this.GroupBox1 = new GroupBox();
      this.TextBox_DocumentId = new TextBox();
      this.RadioButton_NroDoc = new RadioButton();
      this.RadioButton_AllDoc = new RadioButton();
      this.Label_Loading = new Label();
      this.SpinningProgress_Report = new CircularProgress.SpinningProgress.SpinningProgress();
      this.TextBox_CompanyDes = new TextBox();
      this.Button_Company_Search = new Button();
      this.Label_Company = new Label();
      this.CheckBox_CompanyDes = new CheckBox();
      this.TextBox_ClientId = new TextBox();
      this.TextBox_EstabliId = new TextBox();
      this.TextBox_EstabliDes = new TextBox();
      this.Button_Local_Search = new Button();
      this.Label_Turno = new Label();
      this.Label1 = new Label();
      this.ComboBox_Date = new ComboBox();
      this.DateTimePicker_FinalDate = new DateTimePicker();
      this.Label_InitialDate = new Label();
      this.Label_FinalDate = new Label();
      this.DateTimePicker_InitialDate = new DateTimePicker();
      this.ProgressBar_Report = new ProgressBar();
      this.Button_Print_Products = new Button();
      this.BackgroundWorker_Report = new BackgroundWorker();
      ((Control) this.HeaderPanelBusqueda).SuspendLayout();
      this.GroupBox1.SuspendLayout();
      this.SuspendLayout();
      this.HeaderPanelBusqueda.set_BorderColor(SystemColors.ActiveCaption);
      this.HeaderPanelBusqueda.set_BorderStyle((BorderStyles) 1);
      this.HeaderPanelBusqueda.set_CaptionBeginColor(Color.FromArgb(240, 190, 70));
      this.HeaderPanelBusqueda.set_CaptionEndColor(Color.Moccasin);
      this.HeaderPanelBusqueda.set_CaptionGradientDirection(LinearGradientMode.Vertical);
      this.HeaderPanelBusqueda.set_CaptionHeight(26);
      this.HeaderPanelBusqueda.set_CaptionPosition((CaptionPositions) 0);
      this.HeaderPanelBusqueda.set_CaptionText("Opciones de Búsqueda");
      this.HeaderPanelBusqueda.set_CaptionVisible(true);
      ((Control) this.HeaderPanelBusqueda).Controls.Add((Control) this.GroupBox1);
      ((Control) this.HeaderPanelBusqueda).Controls.Add((Control) this.Label_Loading);
      ((Control) this.HeaderPanelBusqueda).Controls.Add((Control) this.SpinningProgress_Report);
      ((Control) this.HeaderPanelBusqueda).Controls.Add((Control) this.TextBox_CompanyDes);
      ((Control) this.HeaderPanelBusqueda).Controls.Add((Control) this.Button_Company_Search);
      ((Control) this.HeaderPanelBusqueda).Controls.Add((Control) this.Label_Company);
      ((Control) this.HeaderPanelBusqueda).Controls.Add((Control) this.CheckBox_CompanyDes);
      ((Control) this.HeaderPanelBusqueda).Controls.Add((Control) this.TextBox_ClientId);
      ((Control) this.HeaderPanelBusqueda).Controls.Add((Control) this.TextBox_EstabliId);
      ((Control) this.HeaderPanelBusqueda).Controls.Add((Control) this.TextBox_EstabliDes);
      ((Control) this.HeaderPanelBusqueda).Controls.Add((Control) this.Button_Local_Search);
      ((Control) this.HeaderPanelBusqueda).Controls.Add((Control) this.Label_Turno);
      ((Control) this.HeaderPanelBusqueda).Controls.Add((Control) this.Label1);
      ((Control) this.HeaderPanelBusqueda).Controls.Add((Control) this.ComboBox_Date);
      ((Control) this.HeaderPanelBusqueda).Controls.Add((Control) this.DateTimePicker_FinalDate);
      ((Control) this.HeaderPanelBusqueda).Controls.Add((Control) this.Label_InitialDate);
      ((Control) this.HeaderPanelBusqueda).Controls.Add((Control) this.Label_FinalDate);
      ((Control) this.HeaderPanelBusqueda).Controls.Add((Control) this.DateTimePicker_InitialDate);
      ((Control) this.HeaderPanelBusqueda).Controls.Add((Control) this.ProgressBar_Report);
      ((Control) this.HeaderPanelBusqueda).Controls.Add((Control) this.Button_Print_Products);
      this.HeaderPanelBusqueda.set_Font(new Font("Trebuchet MS", 9.75f, FontStyle.Bold));
      this.HeaderPanelBusqueda.set_GradientDirection(LinearGradientMode.Vertical);
      this.HeaderPanelBusqueda.set_GradientEnd(SystemColors.Window);
      this.HeaderPanelBusqueda.set_GradientStart(SystemColors.Window);
      ((Control) this.HeaderPanelBusqueda).Location = new Point(0, 1);
      ((Control) this.HeaderPanelBusqueda).Name = "HeaderPanelBusqueda";
      this.HeaderPanelBusqueda.set_PanelIcon((Icon) null);
      this.HeaderPanelBusqueda.set_PanelIconVisible(false);
      ((Control) this.HeaderPanelBusqueda).Size = new Size(260, 365);
      ((Control) this.HeaderPanelBusqueda).TabIndex = 195;
      this.HeaderPanelBusqueda.set_TextAntialias(true);
      this.GroupBox1.Controls.Add((Control) this.TextBox_DocumentId);
      this.GroupBox1.Controls.Add((Control) this.RadioButton_NroDoc);
      this.GroupBox1.Controls.Add((Control) this.RadioButton_AllDoc);
      this.GroupBox1.Font = new Font("Trebuchet MS", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.GroupBox1.ForeColor = Color.Red;
      this.GroupBox1.Location = new Point(6, 195);
      this.GroupBox1.Name = "GroupBox1";
      this.GroupBox1.Size = new Size(242, 76);
      this.GroupBox1.TabIndex = 512;
      this.GroupBox1.TabStop = false;
      this.GroupBox1.Text = "Por Documento";
      this.TextBox_DocumentId.BackColor = Color.White;
      this.TextBox_DocumentId.Font = new Font("Trebuchet MS", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.TextBox_DocumentId.Location = new Point(76, 45);
      this.TextBox_DocumentId.MaxLength = 15;
      this.TextBox_DocumentId.Name = "TextBox_DocumentId";
      this.TextBox_DocumentId.Size = new Size(158, 20);
      this.TextBox_DocumentId.TabIndex = 511;
      this.RadioButton_NroDoc.AutoSize = true;
      this.RadioButton_NroDoc.ForeColor = Color.MediumBlue;
      this.RadioButton_NroDoc.Location = new Point(6, 44);
      this.RadioButton_NroDoc.Name = "RadioButton_NroDoc";
      this.RadioButton_NroDoc.Size = new Size(75, 22);
      this.RadioButton_NroDoc.TabIndex = 1;
      this.RadioButton_NroDoc.Text = "Nro Doc.";
      this.RadioButton_NroDoc.UseVisualStyleBackColor = true;
      this.RadioButton_AllDoc.AutoSize = true;
      this.RadioButton_AllDoc.Checked = true;
      this.RadioButton_AllDoc.ForeColor = Color.MediumBlue;
      this.RadioButton_AllDoc.Location = new Point(6, 20);
      this.RadioButton_AllDoc.Name = "RadioButton_AllDoc";
      this.RadioButton_AllDoc.Size = new Size(59, 22);
      this.RadioButton_AllDoc.TabIndex = 0;
      this.RadioButton_AllDoc.TabStop = true;
      this.RadioButton_AllDoc.Text = "Todos";
      this.RadioButton_AllDoc.UseVisualStyleBackColor = true;
      this.Label_Loading.AutoSize = true;
      this.Label_Loading.Font = new Font("Trebuchet MS", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Label_Loading.ForeColor = Color.Red;
      this.Label_Loading.Location = new Point(98, 162);
      this.Label_Loading.Name = "Label_Loading";
      this.Label_Loading.Size = new Size(71, 18);
      this.Label_Loading.TabIndex = 432;
      this.Label_Loading.Text = "Cargando...";
      this.Label_Loading.Visible = false;
      this.SpinningProgress_Report.set_ActiveSegmentColour(Color.FromArgb((int) byte.MaxValue, 128, 0));
      ((Control) this.SpinningProgress_Report).BackColor = Color.Transparent;
      this.SpinningProgress_Report.set_BehindTransistionSegmentIsActive(false);
      ((Control) this.SpinningProgress_Report).Location = new Point(100, 89);
      ((Control) this.SpinningProgress_Report).Margin = new Padding(5, 8, 5, 8);
      ((Control) this.SpinningProgress_Report).Name = "SpinningProgress_Report";
      ((Control) this.SpinningProgress_Report).RightToLeft = RightToLeft.Yes;
      ((Control) this.SpinningProgress_Report).Size = new Size(65, 72);
      ((Control) this.SpinningProgress_Report).TabIndex = 431;
      this.SpinningProgress_Report.set_TransistionSegment(11);
      this.SpinningProgress_Report.set_TransistionSegmentColour(Color.FromArgb((int) byte.MaxValue, 224, 192));
      ((Control) this.SpinningProgress_Report).Visible = false;
      this.TextBox_CompanyDes.BackColor = Color.WhiteSmoke;
      this.TextBox_CompanyDes.Font = new Font("Trebuchet MS", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.TextBox_CompanyDes.Location = new Point(8, 141);
      this.TextBox_CompanyDes.Multiline = true;
      this.TextBox_CompanyDes.Name = "TextBox_CompanyDes";
      this.TextBox_CompanyDes.ReadOnly = true;
      this.TextBox_CompanyDes.Size = new Size(208, 46);
      this.TextBox_CompanyDes.TabIndex = 509;
      this.Button_Company_Search.Image = (Image) TriNetRestPOS.My.Resources.Resources.Buscar_Small;
      this.Button_Company_Search.Location = new Point(219, 140);
      this.Button_Company_Search.Name = "Button_Company_Search";
      this.Button_Company_Search.Size = new Size(29, 21);
      this.Button_Company_Search.TabIndex = 507;
      this.Button_Company_Search.UseVisualStyleBackColor = true;
      this.Label_Company.AutoSize = true;
      this.Label_Company.Font = new Font("Trebuchet MS", 9f, FontStyle.Bold);
      this.Label_Company.ForeColor = Color.MediumBlue;
      this.Label_Company.Location = new Point(7, 124);
      this.Label_Company.Name = "Label_Company";
      this.Label_Company.Size = new Size(53, 18);
      this.Label_Company.TabIndex = 508;
      this.Label_Company.Text = "Cliente:";
      this.CheckBox_CompanyDes.AutoSize = true;
      this.CheckBox_CompanyDes.Checked = true;
      this.CheckBox_CompanyDes.CheckState = CheckState.Checked;
      this.CheckBox_CompanyDes.Font = new Font("Trebuchet MS", 6.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.CheckBox_CompanyDes.ForeColor = Color.FromArgb(192, 0, 0);
      this.CheckBox_CompanyDes.Location = new Point(170, 125);
      this.CheckBox_CompanyDes.Name = "CheckBox_CompanyDes";
      this.CheckBox_CompanyDes.Size = new Size(54, 19);
      this.CheckBox_CompanyDes.TabIndex = 506;
      this.CheckBox_CompanyDes.Text = "Todos";
      this.CheckBox_CompanyDes.UseVisualStyleBackColor = true;
      this.TextBox_ClientId.BackColor = Color.White;
      this.TextBox_ClientId.Font = new Font("Verdana", 6f, FontStyle.Bold);
      this.TextBox_ClientId.Location = new Point(199, 75);
      this.TextBox_ClientId.MaxLength = 6;
      this.TextBox_ClientId.Multiline = true;
      this.TextBox_ClientId.Name = "TextBox_ClientId";
      this.TextBox_ClientId.Size = new Size(17, 10);
      this.TextBox_ClientId.TabIndex = 505;
      this.TextBox_ClientId.Visible = false;
      this.TextBox_EstabliId.BackColor = Color.White;
      this.TextBox_EstabliId.Font = new Font("Verdana", 6f, FontStyle.Bold);
      this.TextBox_EstabliId.Location = new Point(31, 60);
      this.TextBox_EstabliId.MaxLength = 6;
      this.TextBox_EstabliId.Multiline = true;
      this.TextBox_EstabliId.Name = "TextBox_EstabliId";
      this.TextBox_EstabliId.Size = new Size(17, 10);
      this.TextBox_EstabliId.TabIndex = 504;
      this.TextBox_EstabliId.Visible = false;
      this.TextBox_EstabliDes.BackColor = Color.WhiteSmoke;
      this.TextBox_EstabliDes.Font = new Font("Trebuchet MS", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.TextBox_EstabliDes.Location = new Point(8, 91);
      this.TextBox_EstabliDes.MaxLength = 10;
      this.TextBox_EstabliDes.Multiline = true;
      this.TextBox_EstabliDes.Name = "TextBox_EstabliDes";
      this.TextBox_EstabliDes.ReadOnly = true;
      this.TextBox_EstabliDes.Size = new Size(208, 18);
      this.TextBox_EstabliDes.TabIndex = 503;
      this.Button_Local_Search.Image = (Image) TriNetRestPOS.My.Resources.Resources.Buscar_Small;
      this.Button_Local_Search.Location = new Point(219, 89);
      this.Button_Local_Search.Name = "Button_Local_Search";
      this.Button_Local_Search.Size = new Size(29, 21);
      this.Button_Local_Search.TabIndex = 501;
      this.Button_Local_Search.UseVisualStyleBackColor = true;
      this.Label_Turno.AutoSize = true;
      this.Label_Turno.Font = new Font("Trebuchet MS", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Label_Turno.ForeColor = Color.MediumBlue;
      this.Label_Turno.Location = new Point(7, 73);
      this.Label_Turno.Name = "Label_Turno";
      this.Label_Turno.Size = new Size(42, 18);
      this.Label_Turno.TabIndex = 502;
      this.Label_Turno.Text = "Local:";
      this.Label1.AutoSize = true;
      this.Label1.Font = new Font("Trebuchet MS", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Label1.ForeColor = Color.MediumBlue;
      this.Label1.Location = new Point(7, 12);
      this.Label1.Name = "Label1";
      this.Label1.Size = new Size(45, 18);
      this.Label1.TabIndex = 496;
      this.Label1.Text = "Fecha:";
      this.ComboBox_Date.DropDownStyle = ComboBoxStyle.DropDownList;
      this.ComboBox_Date.Font = new Font("Trebuchet MS", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.ComboBox_Date.FormattingEnabled = true;
      this.ComboBox_Date.Items.AddRange(new object[3]
      {
        (object) "Hoy",
        (object) "Ayer",
        (object) "Rango"
      });
      this.ComboBox_Date.Location = new Point(53, 8);
      this.ComboBox_Date.Name = "ComboBox_Date";
      this.ComboBox_Date.Size = new Size(192, 24);
      this.ComboBox_Date.TabIndex = 494;
      this.DateTimePicker_FinalDate.CalendarFont = new Font("Trebuchet MS", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.DateTimePicker_FinalDate.Enabled = false;
      this.DateTimePicker_FinalDate.Font = new Font("Trebuchet MS", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.DateTimePicker_FinalDate.Format = DateTimePickerFormat.Short;
      this.DateTimePicker_FinalDate.Location = new Point(152, 49);
      this.DateTimePicker_FinalDate.Name = "DateTimePicker_FinalDate";
      this.DateTimePicker_FinalDate.Size = new Size(93, 21);
      this.DateTimePicker_FinalDate.TabIndex = 493;
      this.Label_InitialDate.AutoSize = true;
      this.Label_InitialDate.Font = new Font("Trebuchet MS", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Label_InitialDate.ForeColor = Color.FromArgb(192, 0, 0);
      this.Label_InitialDate.Location = new Point(53, 32);
      this.Label_InitialDate.Name = "Label_InitialDate";
      this.Label_InitialDate.Size = new Size(57, 16);
      this.Label_InitialDate.TabIndex = 491;
      this.Label_InitialDate.Text = "F. Inicial:";
      this.Label_FinalDate.AutoSize = true;
      this.Label_FinalDate.Font = new Font("Trebuchet MS", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Label_FinalDate.ForeColor = Color.FromArgb(192, 0, 0);
      this.Label_FinalDate.Location = new Point(149, 32);
      this.Label_FinalDate.Name = "Label_FinalDate";
      this.Label_FinalDate.Size = new Size(50, 16);
      this.Label_FinalDate.TabIndex = 492;
      this.Label_FinalDate.Text = "F. Final:";
      this.DateTimePicker_InitialDate.Enabled = false;
      this.DateTimePicker_InitialDate.Font = new Font("Trebuchet MS", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.DateTimePicker_InitialDate.Format = DateTimePickerFormat.Short;
      this.DateTimePicker_InitialDate.Location = new Point(53, 49);
      this.DateTimePicker_InitialDate.Name = "DateTimePicker_InitialDate";
      this.DateTimePicker_InitialDate.Size = new Size(93, 21);
      this.DateTimePicker_InitialDate.TabIndex = 490;
      this.ProgressBar_Report.Location = new Point(8, 34);
      this.ProgressBar_Report.Name = "ProgressBar_Report";
      this.ProgressBar_Report.Size = new Size(22, 13);
      this.ProgressBar_Report.TabIndex = 430;
      this.ProgressBar_Report.Visible = false;
      this.Button_Print_Products.BackColor = Color.PapayaWhip;
      this.Button_Print_Products.Font = new Font("Trebuchet MS", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Button_Print_Products.ForeColor = Color.MediumBlue;
      this.Button_Print_Products.Image = (Image) TriNetRestPOS.My.Resources.Resources.print_printer_s;
      this.Button_Print_Products.Location = new Point(5, 277);
      this.Button_Print_Products.Name = "Button_Print_Products";
      this.Button_Print_Products.Size = new Size(243, 53);
      this.Button_Print_Products.TabIndex = 430;
      this.Button_Print_Products.Text = "Mostrar";
      this.Button_Print_Products.TextAlign = ContentAlignment.MiddleRight;
      this.Button_Print_Products.TextImageRelation = TextImageRelation.ImageBeforeText;
      this.Button_Print_Products.UseVisualStyleBackColor = false;
      this.BackgroundWorker_Report.WorkerReportsProgress = true;
      this.BackgroundWorker_Report.WorkerSupportsCancellation = true;
      this.AutoScaleDimensions = new SizeF(7f, 16f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.BackColor = Color.White;
      this.ClientSize = new Size(260, 365);
      this.Controls.Add((Control) this.HeaderPanelBusqueda);
      this.Font = new Font("Trebuchet MS", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.FormBorderStyle = FormBorderStyle.FixedDialog;
      this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
      this.KeyPreview = true;
      this.Margin = new Padding(3, 4, 3, 4);
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = nameof (FrmAnticipeConsume);
      this.StartPosition = FormStartPosition.CenterScreen;
      this.Text = "Consumos por Anticipo";
      ((Control) this.HeaderPanelBusqueda).ResumeLayout(false);
      ((Control) this.HeaderPanelBusqueda).PerformLayout();
      this.GroupBox1.ResumeLayout(false);
      this.GroupBox1.PerformLayout();
      this.ResumeLayout(false);
    }

    internal virtual HeaderPanel HeaderPanelBusqueda { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

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

    internal virtual CheckBox CheckBox_CompanyDes
    {
      get
      {
        return this._CheckBox_CompanyDes;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.CheckBox_CompanyDes_CheckedChanged);
        CheckBox checkBoxCompanyDes1 = this._CheckBox_CompanyDes;
        if (checkBoxCompanyDes1 != null)
          checkBoxCompanyDes1.CheckedChanged -= eventHandler;
        this._CheckBox_CompanyDes = value;
        CheckBox checkBoxCompanyDes2 = this._CheckBox_CompanyDes;
        if (checkBoxCompanyDes2 == null)
          return;
        checkBoxCompanyDes2.CheckedChanged += eventHandler;
      }
    }

    internal virtual TextBox TextBox_ClientId { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual TextBox TextBox_EstabliId { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual TextBox TextBox_EstabliDes { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Button Button_Local_Search
    {
      get
      {
        return this._Button_Local_Search;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Button_Local_Search_Click);
        Button buttonLocalSearch1 = this._Button_Local_Search;
        if (buttonLocalSearch1 != null)
          buttonLocalSearch1.Click -= eventHandler;
        this._Button_Local_Search = value;
        Button buttonLocalSearch2 = this._Button_Local_Search;
        if (buttonLocalSearch2 == null)
          return;
        buttonLocalSearch2.Click += eventHandler;
      }
    }

    internal virtual Label Label_Turno { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Label Label1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual ComboBox ComboBox_Date
    {
      get
      {
        return this._ComboBox_Date;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.ComboBox_Date_SelectedIndexChanged);
        ComboBox comboBoxDate1 = this._ComboBox_Date;
        if (comboBoxDate1 != null)
          comboBoxDate1.SelectedIndexChanged -= eventHandler;
        this._ComboBox_Date = value;
        ComboBox comboBoxDate2 = this._ComboBox_Date;
        if (comboBoxDate2 == null)
          return;
        comboBoxDate2.SelectedIndexChanged += eventHandler;
      }
    }

    internal virtual DateTimePicker DateTimePicker_FinalDate { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Label Label_InitialDate { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Label Label_FinalDate { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual DateTimePicker DateTimePicker_InitialDate { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual ProgressBar ProgressBar_Report { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Button Button_Print_Products
    {
      get
      {
        return this._Button_Print_Products;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Button_Print_Products_Click);
        Button buttonPrintProducts1 = this._Button_Print_Products;
        if (buttonPrintProducts1 != null)
          buttonPrintProducts1.Click -= eventHandler;
        this._Button_Print_Products = value;
        Button buttonPrintProducts2 = this._Button_Print_Products;
        if (buttonPrintProducts2 == null)
          return;
        buttonPrintProducts2.Click += eventHandler;
      }
    }

    internal virtual CircularProgress.SpinningProgress.SpinningProgress SpinningProgress_Report { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Label Label_Loading { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual TextBox TextBox_DocumentId { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual GroupBox GroupBox1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual RadioButton RadioButton_NroDoc
    {
      get
      {
        return this._RadioButton_NroDoc;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.RadioButton_NroDoc_CheckedChanged);
        RadioButton radioButtonNroDoc1 = this._RadioButton_NroDoc;
        if (radioButtonNroDoc1 != null)
          radioButtonNroDoc1.CheckedChanged -= eventHandler;
        this._RadioButton_NroDoc = value;
        RadioButton radioButtonNroDoc2 = this._RadioButton_NroDoc;
        if (radioButtonNroDoc2 == null)
          return;
        radioButtonNroDoc2.CheckedChanged += eventHandler;
      }
    }

    internal virtual RadioButton RadioButton_AllDoc
    {
      get
      {
        return this._RadioButton_AllDoc;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.RadioButton_AllDoc_CheckedChanged);
        RadioButton radioButtonAllDoc1 = this._RadioButton_AllDoc;
        if (radioButtonAllDoc1 != null)
          radioButtonAllDoc1.CheckedChanged -= eventHandler;
        this._RadioButton_AllDoc = value;
        RadioButton radioButtonAllDoc2 = this._RadioButton_AllDoc;
        if (radioButtonAllDoc2 == null)
          return;
        radioButtonAllDoc2.CheckedChanged += eventHandler;
      }
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

    private void FrmAnticipeConsume_Load(object sender, EventArgs e)
    {
      this.LoadEstabliDefault();
      this.CargarFechas();
      this.ComboBox_Date.Text = "Hoy";
      this.ComboBox_Date.SelectedIndex = 0;
    }

    private void FrmAnticipeConsume_KeyDown(object sender, KeyEventArgs e)
    {
      if (!e.KeyValue.Equals(27))
        return;
      this.Close();
    }

    private void Button_Local_Search_Click(object sender, EventArgs e)
    {
      FrmLocal frmLocal = new FrmLocal();
      int num = (int) frmLocal.ShowDialog();
      frmLocal.Dispose();
      if (!ModGeneralVar.g_bol_IsReady || Strings.Len(ModGeneralVar.g_Str_RecordID.Length) <= 0)
        return;
      this.TextBox_EstabliId.Text = ModGeneralVar.g_Str_RecordID;
      this.TextBox_EstabliDes.Text = ModGeneralVar.g_Str_RecordDes;
    }

    private void Button_Company_Search_Click(object sender, EventArgs e)
    {
      ModGeneralVar.g_Str_RecordID = "";
      FrmSearchClient frmSearchClient = new FrmSearchClient();
      frmSearchClient._OnlySearch = true;
      int num = (int) frmSearchClient.ShowDialog();
      frmSearchClient.Dispose();
      if (!ModGeneralVar.g_bol_IsReady || Strings.Len(ModGeneralVar.g_Str_RecordID.Length) <= 0)
        return;
      this.CheckBox_CompanyDes.Checked = false;
      this.TextBox_ClientId.Text = ModGeneralVar.g_Str_RecordID;
      this.TextBox_CompanyDes.Text = ModGeneralVar.g_Str_RecordDes;
    }

    private void ComboBox_Date_SelectedIndexChanged(object sender, EventArgs e)
    {
      if (this.ComboBox_Date.SelectedIndex == 2)
      {
        this.DateTimePicker_InitialDate.Enabled = true;
        this.DateTimePicker_FinalDate.Enabled = true;
      }
      else
      {
        this.DateTimePicker_InitialDate.Enabled = false;
        this.DateTimePicker_FinalDate.Enabled = false;
      }
    }

    private void CheckBox_CompanyDes_CheckedChanged(object sender, EventArgs e)
    {
      this.TextBox_CompanyDes.Text = "";
      this.TextBox_ClientId.Text = "";
    }

    private void Button_Print_Products_Click(object sender, EventArgs e)
    {
      this.Get_Parameters();
      this.SubTitleReport();
      this.Label_Loading.Visible = true;
      ((Control) this.SpinningProgress_Report).Visible = true;
      this.BackgroundWorker_Report.RunWorkerAsync();
    }

    private void BackgroundWorker_Report_DoWork(object sender, DoWorkEventArgs e)
    {
      this.oLIstBE_TR1_ANTICIPE_CONSUME = new List<BE_TR1_ANTICIPE_CONSUME>();
      this.oBL_TR1_ANTICIPE_CONSUME = new BL_TR1_ANTICIPE_CONSUME();
      this.oBE_TR1_ANTICIPE_CONSUME = new BE_TR1_ANTICIPE_CONSUME();
      this.oBE_TR1_ANTICIPE_CONSUME.set_EstabliId(this.int_EstabliId);
      this.oBE_TR1_ANTICIPE_CONSUME.set_DateInitial(this.dtp_InitialDate);
      this.oBE_TR1_ANTICIPE_CONSUME.set_DateFinal(this.dtp_FinalDate);
      this.oBE_TR1_ANTICIPE_CONSUME.set_ClientId(this.str_ClientId);
      this.oBE_TR1_ANTICIPE_CONSUME.set_DocumentIdAnticipe(this.str_DocumentId);
      this.BackgroundWorker_Report.ReportProgress(50);
      Thread.Sleep(500);
      this.oLIstBE_TR1_ANTICIPE_CONSUME = this.oBL_TR1_ANTICIPE_CONSUME.List_AnticipeConsume(this.oBE_TR1_ANTICIPE_CONSUME);
      this.oBL_TR1_ANTICIPE_CONSUME = (BL_TR1_ANTICIPE_CONSUME) null;
      this.oBE_TR1_ANTICIPE_CONSUME = (BE_TR1_ANTICIPE_CONSUME) null;
      this.BackgroundWorker_Report.ReportProgress(100);
      e.Result = (object) this.oLIstBE_TR1_ANTICIPE_CONSUME;
    }

    private void BackgroundWorker_Report_ProgressChanged(object sender, ProgressChangedEventArgs e)
    {
      this.ProgressBar_Report.Value = e.ProgressPercentage;
    }

    private void BackgroundWorker_Report_RunWorkerCompleted(
      object sender,
      RunWorkerCompletedEventArgs e)
    {
      if (this.oLIstBE_TR1_ANTICIPE_CONSUME.Count == 0)
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
        ModGeneralFunctions.SetUp_Report_Initial(ref p_ReportDocument, "TR1_REPORT\\rpt_AnticipeConsume.rpt", "Consumos por Anticipo ", this.str_ReportSubTitle, "");
        p_ReportDocument.Database.Tables[0].SetDataSource(RuntimeHelpers.GetObjectValue(e.Result));
        ModGeneralFunctions.SetUp_Report_Final(ref p_ReportDocument, false, "Consumos por Anticipo");
      }
    }

    private void RadioButton_AllDoc_CheckedChanged(object sender, EventArgs e)
    {
      this.TextBox_DocumentId.Enabled = false;
      ModGeneralFunctions.UnActiveColorTextbox(this.TextBox_DocumentId);
    }

    private void RadioButton_NroDoc_CheckedChanged(object sender, EventArgs e)
    {
      this.TextBox_DocumentId.Enabled = true;
      ModGeneralFunctions.ActiveColorTextbox(this.TextBox_DocumentId);
    }

    private void CargarFechas()
    {
      this.DateTimePicker_InitialDate.Value = ModGeneralFunctions.ObtenerPrimerDiaMesActual();
      this.DateTimePicker_FinalDate.Value = DateAndTime.Now;
    }

    private void LoadEstabliDefault()
    {
      BL_TR1_ESTABLI blTr1Establi = new BL_TR1_ESTABLI();
      BE_TR1_ESTABLI beTr1Establi1 = new BE_TR1_ESTABLI();
      BE_TR1_ESTABLI beTr1Establi2 = blTr1Establi.ListbyId(ModGeneralVar.g_BE_TR1_VARIABLES_B.get_EstabliId());
      this.TextBox_EstabliId.Text = Conversions.ToString(beTr1Establi2.get_EstabliId());
      this.TextBox_EstabliDes.Text = beTr1Establi2.get_EstabliDes();
    }

    private void Get_Parameters()
    {
      if (this.ComboBox_Date.SelectedIndex == 2)
      {
        this.dtp_InitialDate = this.DateTimePicker_InitialDate.Value;
        this.dtp_FinalDate = this.DateTimePicker_FinalDate.Value;
      }
      else if (this.ComboBox_Date.SelectedIndex == 0)
      {
        this.dtp_InitialDate = DateAndTime.Today;
        this.dtp_FinalDate = DateAndTime.Today;
      }
      else if (this.ComboBox_Date.SelectedIndex == 1)
      {
        this.dtp_InitialDate = DateAndTime.Today.AddDays(-1.0);
        this.dtp_FinalDate = DateAndTime.Today.AddDays(-1.0);
      }
      this.str_ClientId = this.TextBox_ClientId.Text.Trim();
      this.int_EstabliId = checked ((int) Math.Round(Conversion.Val(this.TextBox_EstabliId.Text)));
      if (this.RadioButton_AllDoc.Checked)
      {
        this.bol_IsAll = true;
        this.str_DocumentId = "";
      }
      else
      {
        this.bol_IsAll = false;
        this.str_DocumentId = this.TextBox_DocumentId.Text;
      }
    }

    private void SubTitleReport()
    {
      this.str_ReportSubTitle = "";
      this.str_ReportSubTitle = "Local: " + this.TextBox_EstabliDes.Text;
      if (this.ComboBox_Date.SelectedIndex == 2)
        this.str_ReportSubTitle = this.str_ReportSubTitle + " | Del: " + Conversions.ToString(this.dtp_InitialDate.Date) + " - Al -" + Conversions.ToString(this.dtp_FinalDate.Date);
      else if (this.ComboBox_Date.SelectedIndex == 0)
        this.str_ReportSubTitle = this.str_ReportSubTitle + "| Hoy: " + Conversions.ToString(this.dtp_InitialDate.Date);
      else if (this.ComboBox_Date.SelectedIndex == 1)
        this.str_ReportSubTitle = this.str_ReportSubTitle + " | Ayer: " + Conversions.ToString(this.dtp_InitialDate.Date);
      if (this.CheckBox_CompanyDes.Checked)
        this.str_ReportSubTitle += " | Cliente: <<Todos>>";
      else
        this.str_ReportSubTitle = this.str_ReportSubTitle + " | Cliente: " + this.TextBox_CompanyDes.Text;
    }
  }
}
