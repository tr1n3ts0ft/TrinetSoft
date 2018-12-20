// Decompiled with JetBrains decompiler
// Type: TriNetRestPOS.FrmAnticipePay
// Assembly: TriNetRestPOS, Version=5.2.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 43377352-E952-4AC1-9BA6-CCBE4AE5F575
// Assembly location: C:\log\TriNetRestPOS.exe

using CrystalDecisions.CrystalReports.Engine;
using KIS.Controls;
using KIS.Controls.Windows;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using MyXPButton;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using TR1_BusinessEntity;
using TR1_BusinessLogic;

namespace TriNetRestPOS
{
  [DesignerGenerated]
  public class FrmAnticipePay : Form
  {
    private IContainer components;
    public double dblTotalVenta;
    public string strClientId;
    public string strClientDes;
    public string strClientIdentity;
    public BE_TR1_ORDERS obeORDER;
    public List<BE_TR1_ORDERDETAILS> oListaORDERDETAILS;
    private BL_TR1_ORDERS oblORDERS;
    private List<BE_TR1_DOCUMENTS_ANTICIPE> oListaDOCUMENTS_ANTICIPE;
    private string strDocumentCode;
    public bool bolImpuesto2;

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
      DataGridViewCellStyle gridViewCellStyle1 = new DataGridViewCellStyle();
      DataGridViewCellStyle gridViewCellStyle2 = new DataGridViewCellStyle();
      this.Button_PendingDocuments = new MyXPButton.MyXPButton();
      this.dgrvDocumentAnticipe = new DataGridView();
      this.Panel_Documents = new Panel();
      this.Button_GoOut = new Button();
      this.btnDocumentsPaylessB = new Button();
      this.btnDocumentsPaylessN = new Button();
      this.HeaderPanel1 = new HeaderPanel();
      this.TextBox_ClientIdentity = new TextBox();
      this.TextBox_ClientDes = new TextBox();
      this.TextBox_ClientId = new TextBox();
      this.Label_Name = new Label();
      this.HeaderPanel2 = new HeaderPanel();
      this.MyXPButton_Canje = new MyXPButton.MyXPButton();
      this.Button_CreateTicket = new MyXPButton.MyXPButton();
      this.LblTotal_BillSoles = new Label();
      this.lblPendingMoney = new Label();
      this.Button_CreateInvoice = new MyXPButton.MyXPButton();
      this.LblTotal_PaidSoles = new Label();
      this.MyXPButton16 = new MyXPButton.MyXPButton();
      this.MyXPButton15 = new MyXPButton.MyXPButton();
      this.MyXPButton14 = new MyXPButton.MyXPButton();
      ((ISupportInitialize) this.dgrvDocumentAnticipe).BeginInit();
      this.Panel_Documents.SuspendLayout();
      ((Control) this.HeaderPanel1).SuspendLayout();
      ((Control) this.HeaderPanel2).SuspendLayout();
      this.SuspendLayout();
      this.Button_PendingDocuments.set_AdjustImageLocation(new Point(0, 0));
      this.Button_PendingDocuments.set_BtnShape((emunType.BtnShape) 0);
      this.Button_PendingDocuments.set_BtnStyle((emunType.XPStyle) 2);
      ((Control) this.Button_PendingDocuments).Font = new Font("Trebuchet MS", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      ((Control) this.Button_PendingDocuments).ForeColor = Color.MediumBlue;
      ((Control) this.Button_PendingDocuments).Location = new Point(2, 54);
      ((Control) this.Button_PendingDocuments).Name = "Button_PendingDocuments";
      ((Control) this.Button_PendingDocuments).Size = new Size(569, 27);
      ((Control) this.Button_PendingDocuments).TabIndex = 131;
      ((ButtonBase) this.Button_PendingDocuments).Text = "Documentos por Anticipo";
      ((ButtonBase) this.Button_PendingDocuments).UseVisualStyleBackColor = true;
      this.dgrvDocumentAnticipe.BackgroundColor = Color.White;
      gridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
      gridViewCellStyle1.BackColor = Color.FromArgb(192, 192, (int) byte.MaxValue);
      gridViewCellStyle1.Font = new Font("Trebuchet MS", 9.75f, FontStyle.Bold);
      gridViewCellStyle1.ForeColor = SystemColors.WindowText;
      gridViewCellStyle1.NullValue = (object) "johan";
      gridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
      gridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
      gridViewCellStyle1.WrapMode = DataGridViewTriState.True;
      this.dgrvDocumentAnticipe.ColumnHeadersDefaultCellStyle = gridViewCellStyle1;
      this.dgrvDocumentAnticipe.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dgrvDocumentAnticipe.Location = new Point(3, 80);
      this.dgrvDocumentAnticipe.Name = "dgrvDocumentAnticipe";
      this.dgrvDocumentAnticipe.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
      gridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
      gridViewCellStyle2.BackColor = SystemColors.Control;
      gridViewCellStyle2.Font = new Font("Trebuchet MS", 9.75f, FontStyle.Bold);
      gridViewCellStyle2.ForeColor = SystemColors.WindowText;
      gridViewCellStyle2.NullValue = (object) "sdds";
      gridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
      gridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
      gridViewCellStyle2.WrapMode = DataGridViewTriState.True;
      this.dgrvDocumentAnticipe.RowHeadersDefaultCellStyle = gridViewCellStyle2;
      this.dgrvDocumentAnticipe.RowHeadersWidth = 10;
      this.dgrvDocumentAnticipe.ScrollBars = ScrollBars.None;
      this.dgrvDocumentAnticipe.Size = new Size(568, 180);
      this.dgrvDocumentAnticipe.TabIndex = 130;
      this.Panel_Documents.Controls.Add((Control) this.Button_GoOut);
      this.Panel_Documents.Controls.Add((Control) this.btnDocumentsPaylessB);
      this.Panel_Documents.Controls.Add((Control) this.btnDocumentsPaylessN);
      this.Panel_Documents.Location = new Point(574, 3);
      this.Panel_Documents.Name = "Panel_Documents";
      this.Panel_Documents.Size = new Size(76, 256);
      this.Panel_Documents.TabIndex = 132;
      this.Button_GoOut.Font = new Font("Trebuchet MS", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Button_GoOut.ForeColor = Color.MediumBlue;
      this.Button_GoOut.Image = (Image) TriNetRestPOS.My.Resources.Resources.i_Close;
      this.Button_GoOut.Location = new Point(3, 2);
      this.Button_GoOut.Name = "Button_GoOut";
      this.Button_GoOut.Size = new Size(70, 54);
      this.Button_GoOut.TabIndex = 163;
      this.Button_GoOut.Tag = (object) "Res_Back";
      this.Button_GoOut.Text = "&Salir";
      this.Button_GoOut.TextImageRelation = TextImageRelation.TextAboveImage;
      this.Button_GoOut.UseVisualStyleBackColor = true;
      this.btnDocumentsPaylessB.Font = new Font("Verdana", 18f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.btnDocumentsPaylessB.Image = (Image) TriNetRestPOS.My.Resources.Resources.go_back;
      this.btnDocumentsPaylessB.Location = new Point(3, 109);
      this.btnDocumentsPaylessB.Name = "btnDocumentsPaylessB";
      this.btnDocumentsPaylessB.RightToLeft = RightToLeft.Yes;
      this.btnDocumentsPaylessB.Size = new Size(70, 54);
      this.btnDocumentsPaylessB.TabIndex = 33;
      this.btnDocumentsPaylessB.Tag = (object) "t";
      this.btnDocumentsPaylessB.UseVisualStyleBackColor = true;
      this.btnDocumentsPaylessN.Font = new Font("Verdana", 18f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.btnDocumentsPaylessN.Image = (Image) TriNetRestPOS.My.Resources.Resources.go_forward;
      this.btnDocumentsPaylessN.Location = new Point(3, 164);
      this.btnDocumentsPaylessN.Name = "btnDocumentsPaylessN";
      this.btnDocumentsPaylessN.RightToLeft = RightToLeft.Yes;
      this.btnDocumentsPaylessN.Size = new Size(70, 54);
      this.btnDocumentsPaylessN.TabIndex = 34;
      this.btnDocumentsPaylessN.Tag = (object) "t";
      this.btnDocumentsPaylessN.UseVisualStyleBackColor = true;
      ((Control) this.HeaderPanel1).BackColor = Color.WhiteSmoke;
      this.HeaderPanel1.set_BorderColor(SystemColors.ActiveCaption);
      this.HeaderPanel1.set_BorderStyle((BorderStyles) 0);
      this.HeaderPanel1.set_CaptionBeginColor(Color.FromArgb(240, 190, 70));
      this.HeaderPanel1.set_CaptionEndColor(Color.FromArgb((int) byte.MaxValue, 224, 192));
      this.HeaderPanel1.set_CaptionGradientDirection(LinearGradientMode.Vertical);
      this.HeaderPanel1.set_CaptionHeight(26);
      this.HeaderPanel1.set_CaptionPosition((CaptionPositions) 0);
      this.HeaderPanel1.set_CaptionText("Aplicar Anticipo");
      this.HeaderPanel1.set_CaptionVisible(true);
      ((Control) this.HeaderPanel1).Controls.Add((Control) this.TextBox_ClientIdentity);
      ((Control) this.HeaderPanel1).Controls.Add((Control) this.TextBox_ClientDes);
      ((Control) this.HeaderPanel1).Controls.Add((Control) this.TextBox_ClientId);
      ((Control) this.HeaderPanel1).Controls.Add((Control) this.Button_PendingDocuments);
      ((Control) this.HeaderPanel1).Controls.Add((Control) this.dgrvDocumentAnticipe);
      ((Control) this.HeaderPanel1).Controls.Add((Control) this.Panel_Documents);
      ((Control) this.HeaderPanel1).Controls.Add((Control) this.Label_Name);
      this.HeaderPanel1.set_Font(new Font("Trebuchet MS", 9.75f, FontStyle.Bold));
      this.HeaderPanel1.set_GradientDirection(LinearGradientMode.Vertical);
      this.HeaderPanel1.set_GradientEnd(SystemColors.Window);
      this.HeaderPanel1.set_GradientStart(Color.WhiteSmoke);
      ((Control) this.HeaderPanel1).Location = new Point(0, 0);
      ((Control) this.HeaderPanel1).Name = "HeaderPanel1";
      this.HeaderPanel1.set_PanelIcon((Icon) null);
      this.HeaderPanel1.set_PanelIconVisible(false);
      ((Control) this.HeaderPanel1).Size = new Size(652, 287);
      ((Control) this.HeaderPanel1).TabIndex = 214;
      this.HeaderPanel1.set_TextAntialias(true);
      this.TextBox_ClientIdentity.BackColor = Color.FromArgb((int) byte.MaxValue, 240, 140);
      this.TextBox_ClientIdentity.Font = new Font("Trebuchet MS", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.TextBox_ClientIdentity.Location = new Point(461, 15);
      this.TextBox_ClientIdentity.MaxLength = 11;
      this.TextBox_ClientIdentity.Name = "TextBox_ClientIdentity";
      this.TextBox_ClientIdentity.ReadOnly = true;
      this.TextBox_ClientIdentity.Size = new Size(110, 25);
      this.TextBox_ClientIdentity.TabIndex = 1009;
      this.TextBox_ClientDes.BackColor = Color.FromArgb((int) byte.MaxValue, 240, 140);
      this.TextBox_ClientDes.Font = new Font("Trebuchet MS", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.TextBox_ClientDes.Location = new Point(77, 15);
      this.TextBox_ClientDes.Name = "TextBox_ClientDes";
      this.TextBox_ClientDes.ReadOnly = true;
      this.TextBox_ClientDes.Size = new Size(385, 25);
      this.TextBox_ClientDes.TabIndex = 1008;
      this.TextBox_ClientId.BackColor = Color.FromArgb((int) byte.MaxValue, 240, 140);
      this.TextBox_ClientId.Font = new Font("Tahoma", 12.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.TextBox_ClientId.Location = new Point(68, 18);
      this.TextBox_ClientId.Name = "TextBox_ClientId";
      this.TextBox_ClientId.ReadOnly = true;
      this.TextBox_ClientId.Size = new Size(4, 28);
      this.TextBox_ClientId.TabIndex = 221;
      this.TextBox_ClientId.TextAlign = HorizontalAlignment.Center;
      this.TextBox_ClientId.Visible = false;
      this.Label_Name.AutoSize = true;
      this.Label_Name.Font = new Font("Trebuchet MS", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Label_Name.ForeColor = Color.MediumBlue;
      this.Label_Name.Location = new Point(8, 18);
      this.Label_Name.Name = "Label_Name";
      this.Label_Name.Size = new Size(65, 20);
      this.Label_Name.TabIndex = 184;
      this.Label_Name.Text = "Cliente:";
      ((Control) this.HeaderPanel2).BackColor = Color.Transparent;
      this.HeaderPanel2.set_BorderColor(SystemColors.ActiveCaption);
      this.HeaderPanel2.set_BorderStyle((BorderStyles) 0);
      this.HeaderPanel2.set_CaptionBeginColor(Color.FromArgb(240, 190, 70));
      this.HeaderPanel2.set_CaptionEndColor(Color.FromArgb((int) byte.MaxValue, 224, 192));
      this.HeaderPanel2.set_CaptionGradientDirection(LinearGradientMode.Vertical);
      this.HeaderPanel2.set_CaptionHeight(26);
      this.HeaderPanel2.set_CaptionPosition((CaptionPositions) 0);
      this.HeaderPanel2.set_CaptionText("Resumen de Pago");
      this.HeaderPanel2.set_CaptionVisible(true);
      ((Control) this.HeaderPanel2).Controls.Add((Control) this.MyXPButton_Canje);
      ((Control) this.HeaderPanel2).Controls.Add((Control) this.Button_CreateTicket);
      ((Control) this.HeaderPanel2).Controls.Add((Control) this.LblTotal_BillSoles);
      ((Control) this.HeaderPanel2).Controls.Add((Control) this.lblPendingMoney);
      ((Control) this.HeaderPanel2).Controls.Add((Control) this.Button_CreateInvoice);
      ((Control) this.HeaderPanel2).Controls.Add((Control) this.LblTotal_PaidSoles);
      ((Control) this.HeaderPanel2).Controls.Add((Control) this.MyXPButton16);
      ((Control) this.HeaderPanel2).Controls.Add((Control) this.MyXPButton15);
      ((Control) this.HeaderPanel2).Controls.Add((Control) this.MyXPButton14);
      this.HeaderPanel2.set_Font(new Font("Trebuchet MS", 9.75f, FontStyle.Bold));
      this.HeaderPanel2.set_GradientDirection(LinearGradientMode.Vertical);
      this.HeaderPanel2.set_GradientEnd(SystemColors.Window);
      this.HeaderPanel2.set_GradientStart(Color.WhiteSmoke);
      ((Control) this.HeaderPanel2).Location = new Point(2, 287);
      ((Control) this.HeaderPanel2).Name = "HeaderPanel2";
      this.HeaderPanel2.set_PanelIcon((Icon) null);
      this.HeaderPanel2.set_PanelIconVisible(false);
      ((Control) this.HeaderPanel2).Size = new Size(650, 158);
      ((Control) this.HeaderPanel2).TabIndex = 215;
      this.HeaderPanel2.set_TextAntialias(true);
      this.MyXPButton_Canje.set_AdjustImageLocation(new Point(0, 0));
      this.MyXPButton_Canje.set_BtnShape((emunType.BtnShape) 0);
      this.MyXPButton_Canje.set_BtnStyle((emunType.XPStyle) 1);
      ((Control) this.MyXPButton_Canje).Font = new Font("Trebuchet MS", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      ((Control) this.MyXPButton_Canje).ForeColor = Color.MediumBlue;
      ((Control) this.MyXPButton_Canje).Location = new Point(440, 68);
      ((Control) this.MyXPButton_Canje).Name = "MyXPButton_Canje";
      ((Control) this.MyXPButton_Canje).Size = new Size(99, 57);
      ((Control) this.MyXPButton_Canje).TabIndex = 221;
      ((ButtonBase) this.MyXPButton_Canje).Text = "CANJE";
      ((ButtonBase) this.MyXPButton_Canje).UseVisualStyleBackColor = true;
      this.Button_CreateTicket.set_AdjustImageLocation(new Point(0, 0));
      this.Button_CreateTicket.set_BtnShape((emunType.BtnShape) 0);
      this.Button_CreateTicket.set_BtnStyle((emunType.XPStyle) 1);
      ((Control) this.Button_CreateTicket).Font = new Font("Trebuchet MS", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      ((Control) this.Button_CreateTicket).ForeColor = Color.MediumBlue;
      ((Control) this.Button_CreateTicket).Location = new Point(495, 8);
      ((Control) this.Button_CreateTicket).Name = "Button_CreateTicket";
      ((Control) this.Button_CreateTicket).Size = new Size(99, 57);
      ((Control) this.Button_CreateTicket).TabIndex = 219;
      ((ButtonBase) this.Button_CreateTicket).Text = "BOLETA";
      ((ButtonBase) this.Button_CreateTicket).UseVisualStyleBackColor = true;
      this.LblTotal_BillSoles.Font = new Font("Trebuchet MS", 18f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.LblTotal_BillSoles.ForeColor = Color.Orange;
      this.LblTotal_BillSoles.Location = new Point(196, 21);
      this.LblTotal_BillSoles.Name = "LblTotal_BillSoles";
      this.LblTotal_BillSoles.Size = new Size(139, 25);
      this.LblTotal_BillSoles.TabIndex = 139;
      this.LblTotal_BillSoles.TextAlign = ContentAlignment.MiddleRight;
      this.lblPendingMoney.Font = new Font("Trebuchet MS", 18f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.lblPendingMoney.ForeColor = Color.Red;
      this.lblPendingMoney.Location = new Point(196, 89);
      this.lblPendingMoney.Name = "lblPendingMoney";
      this.lblPendingMoney.Size = new Size(139, 25);
      this.lblPendingMoney.TabIndex = 140;
      this.lblPendingMoney.TextAlign = ContentAlignment.MiddleRight;
      this.Button_CreateInvoice.set_AdjustImageLocation(new Point(0, 0));
      this.Button_CreateInvoice.set_BtnShape((emunType.BtnShape) 0);
      this.Button_CreateInvoice.set_BtnStyle((emunType.XPStyle) 1);
      ((Control) this.Button_CreateInvoice).Font = new Font("Trebuchet MS", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      ((Control) this.Button_CreateInvoice).ForeColor = Color.MediumBlue;
      ((Control) this.Button_CreateInvoice).Location = new Point(385, 8);
      ((Control) this.Button_CreateInvoice).Name = "Button_CreateInvoice";
      ((Control) this.Button_CreateInvoice).Size = new Size(99, 57);
      ((Control) this.Button_CreateInvoice).TabIndex = 220;
      ((ButtonBase) this.Button_CreateInvoice).Text = "FACTURA";
      ((ButtonBase) this.Button_CreateInvoice).UseVisualStyleBackColor = true;
      this.LblTotal_PaidSoles.Font = new Font("Trebuchet MS", 18f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.LblTotal_PaidSoles.ForeColor = Color.FromArgb(0, 192, 0);
      this.LblTotal_PaidSoles.Location = new Point(196, 55);
      this.LblTotal_PaidSoles.Name = "LblTotal_PaidSoles";
      this.LblTotal_PaidSoles.Size = new Size(139, 25);
      this.LblTotal_PaidSoles.TabIndex = 138;
      this.LblTotal_PaidSoles.TextAlign = ContentAlignment.MiddleRight;
      this.MyXPButton16.set_AdjustImageLocation(new Point(0, 0));
      this.MyXPButton16.set_BtnShape((emunType.BtnShape) 0);
      this.MyXPButton16.set_BtnStyle((emunType.XPStyle) 2);
      ((Control) this.MyXPButton16).Font = new Font("Trebuchet MS", 12.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      ((Control) this.MyXPButton16).ForeColor = Color.FromArgb(0, 0, 192);
      ((Control) this.MyXPButton16).Location = new Point(30, 50);
      ((Control) this.MyXPButton16).Name = "MyXPButton16";
      ((Control) this.MyXPButton16).Size = new Size(161, 32);
      ((Control) this.MyXPButton16).TabIndex = 137;
      ((ButtonBase) this.MyXPButton16).Text = "Monto x Anticipo";
      ((ButtonBase) this.MyXPButton16).UseVisualStyleBackColor = true;
      this.MyXPButton15.set_AdjustImageLocation(new Point(0, 0));
      this.MyXPButton15.set_BtnShape((emunType.BtnShape) 0);
      this.MyXPButton15.set_BtnStyle((emunType.XPStyle) 2);
      ((Control) this.MyXPButton15).Font = new Font("Trebuchet MS", 12.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      ((Control) this.MyXPButton15).ForeColor = Color.FromArgb(0, 0, 192);
      ((Control) this.MyXPButton15).Location = new Point(30, 84);
      ((Control) this.MyXPButton15).Name = "MyXPButton15";
      ((Control) this.MyXPButton15).Size = new Size(161, 32);
      ((Control) this.MyXPButton15).TabIndex = 136;
      ((ButtonBase) this.MyXPButton15).Text = "Monto x Pagar";
      ((ButtonBase) this.MyXPButton15).UseVisualStyleBackColor = true;
      this.MyXPButton14.set_AdjustImageLocation(new Point(0, 0));
      this.MyXPButton14.set_BtnShape((emunType.BtnShape) 0);
      this.MyXPButton14.set_BtnStyle((emunType.XPStyle) 2);
      ((Control) this.MyXPButton14).Font = new Font("Trebuchet MS", 12.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      ((Control) this.MyXPButton14).ForeColor = Color.FromArgb(0, 0, 192);
      ((Control) this.MyXPButton14).Location = new Point(30, 16);
      ((Control) this.MyXPButton14).Name = "MyXPButton14";
      ((Control) this.MyXPButton14).Size = new Size(161, 32);
      ((Control) this.MyXPButton14).TabIndex = 135;
      ((ButtonBase) this.MyXPButton14).Text = "Monto Venta";
      ((ButtonBase) this.MyXPButton14).UseVisualStyleBackColor = true;
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.BackColor = Color.WhiteSmoke;
      this.ClientSize = new Size(651, 447);
      this.ControlBox = false;
      this.Controls.Add((Control) this.HeaderPanel2);
      this.Controls.Add((Control) this.HeaderPanel1);
      this.FormBorderStyle = FormBorderStyle.FixedDialog;
      this.KeyPreview = true;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = nameof (FrmAnticipePay);
      this.ShowIcon = false;
      this.ShowInTaskbar = false;
      this.StartPosition = FormStartPosition.CenterScreen;
      this.Text = "Pago de Anticipo";
      ((ISupportInitialize) this.dgrvDocumentAnticipe).EndInit();
      this.Panel_Documents.ResumeLayout(false);
      ((Control) this.HeaderPanel1).ResumeLayout(false);
      ((Control) this.HeaderPanel1).PerformLayout();
      ((Control) this.HeaderPanel2).ResumeLayout(false);
      this.ResumeLayout(false);
    }

    internal virtual MyXPButton.MyXPButton Button_PendingDocuments { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual DataGridView dgrvDocumentAnticipe
    {
      get
      {
        return this._dgrvDocumentAnticipe;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        DataGridViewCellMouseEventHandler mouseEventHandler = new DataGridViewCellMouseEventHandler(this.dgrvDocumentAnticipe_CellMouseClick);
        DataGridViewCellFormattingEventHandler formattingEventHandler = new DataGridViewCellFormattingEventHandler(this.dgrvDocumentAnticipe_CellFormatting);
        DataGridView documentAnticipe1 = this._dgrvDocumentAnticipe;
        if (documentAnticipe1 != null)
        {
          documentAnticipe1.CellMouseClick -= mouseEventHandler;
          documentAnticipe1.CellFormatting -= formattingEventHandler;
        }
        this._dgrvDocumentAnticipe = value;
        DataGridView documentAnticipe2 = this._dgrvDocumentAnticipe;
        if (documentAnticipe2 == null)
          return;
        documentAnticipe2.CellMouseClick += mouseEventHandler;
        documentAnticipe2.CellFormatting += formattingEventHandler;
      }
    }

    internal virtual Panel Panel_Documents { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Button Button_GoOut
    {
      get
      {
        return this._Button_GoOut;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Button_GoOut_Click);
        Button buttonGoOut1 = this._Button_GoOut;
        if (buttonGoOut1 != null)
          buttonGoOut1.Click -= eventHandler;
        this._Button_GoOut = value;
        Button buttonGoOut2 = this._Button_GoOut;
        if (buttonGoOut2 == null)
          return;
        buttonGoOut2.Click += eventHandler;
      }
    }

    internal virtual Button btnDocumentsPaylessB
    {
      get
      {
        return this._btnDocumentsPaylessB;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.btnDocumentsPaylessB_Click);
        Button documentsPaylessB1 = this._btnDocumentsPaylessB;
        if (documentsPaylessB1 != null)
          documentsPaylessB1.Click -= eventHandler;
        this._btnDocumentsPaylessB = value;
        Button documentsPaylessB2 = this._btnDocumentsPaylessB;
        if (documentsPaylessB2 == null)
          return;
        documentsPaylessB2.Click += eventHandler;
      }
    }

    internal virtual Button btnDocumentsPaylessN
    {
      get
      {
        return this._btnDocumentsPaylessN;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.btnDocumentsPaylessN_Click);
        Button documentsPaylessN1 = this._btnDocumentsPaylessN;
        if (documentsPaylessN1 != null)
          documentsPaylessN1.Click -= eventHandler;
        this._btnDocumentsPaylessN = value;
        Button documentsPaylessN2 = this._btnDocumentsPaylessN;
        if (documentsPaylessN2 == null)
          return;
        documentsPaylessN2.Click += eventHandler;
      }
    }

    internal virtual HeaderPanel HeaderPanel1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Label Label_Name { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual HeaderPanel HeaderPanel2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Label LblTotal_BillSoles { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Label lblPendingMoney { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Label LblTotal_PaidSoles { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual MyXPButton.MyXPButton MyXPButton16 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual MyXPButton.MyXPButton MyXPButton15 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual MyXPButton.MyXPButton MyXPButton14 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual MyXPButton.MyXPButton Button_CreateInvoice
    {
      get
      {
        return this._Button_CreateInvoice;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Button_CreateInvoice_Click);
        MyXPButton.MyXPButton buttonCreateInvoice1 = this._Button_CreateInvoice;
        if (buttonCreateInvoice1 != null)
          ((Control) buttonCreateInvoice1).Click -= eventHandler;
        this._Button_CreateInvoice = value;
        MyXPButton.MyXPButton buttonCreateInvoice2 = this._Button_CreateInvoice;
        if (buttonCreateInvoice2 == null)
          return;
        ((Control) buttonCreateInvoice2).Click += eventHandler;
      }
    }

    internal virtual MyXPButton.MyXPButton Button_CreateTicket
    {
      get
      {
        return this._Button_CreateTicket;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Button_CreateTicket_Click);
        MyXPButton.MyXPButton buttonCreateTicket1 = this._Button_CreateTicket;
        if (buttonCreateTicket1 != null)
          ((Control) buttonCreateTicket1).Click -= eventHandler;
        this._Button_CreateTicket = value;
        MyXPButton.MyXPButton buttonCreateTicket2 = this._Button_CreateTicket;
        if (buttonCreateTicket2 == null)
          return;
        ((Control) buttonCreateTicket2).Click += eventHandler;
      }
    }

    internal virtual TextBox TextBox_ClientId { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual TextBox TextBox_ClientIdentity { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual TextBox TextBox_ClientDes { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual MyXPButton.MyXPButton MyXPButton_Canje
    {
      get
      {
        return this._MyXPButton_Canje;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.MyXPButton_Canje_Click);
        MyXPButton.MyXPButton xpButtonCanje1 = this._MyXPButton_Canje;
        if (xpButtonCanje1 != null)
          ((Control) xpButtonCanje1).Click -= eventHandler;
        this._MyXPButton_Canje = value;
        MyXPButton.MyXPButton xpButtonCanje2 = this._MyXPButton_Canje;
        if (xpButtonCanje2 == null)
          return;
        ((Control) xpButtonCanje2).Click += eventHandler;
      }
    }

    private void FrmAnticipePay_Load(object sender, EventArgs e)
    {
      this.TextBox_ClientId.Text = this.strClientId;
      this.TextBox_ClientDes.Text = this.strClientDes;
      this.TextBox_ClientIdentity.Text = this.strClientIdentity;
      this.LblTotal_BillSoles.Text = ModGeneralFunctions.CadenaToDoubleFormateado(Conversions.ToString(this.dblTotalVenta), 2);
      this.LblTotal_PaidSoles.Text = ModGeneralFunctions.CadenaToDoubleFormateado(Conversions.ToString(0), 2);
      this.lblPendingMoney.Text = ModGeneralFunctions.CadenaToDoubleFormateado(Conversions.ToString(this.dblTotalVenta), 2);
      this.strDocumentCode = "";
      this.SetUpDataGridView();
      this.LoadDocumentAnticipe(this.strClientId);
    }

    private void Button_GoOut_Click(object sender, EventArgs e)
    {
      this.Close();
    }

    private void dgrvDocumentAnticipe_CellMouseClick(
      object sender,
      DataGridViewCellMouseEventArgs e)
    {
      if (ModGeneralFunctions.DataGrid_Validated(this.dgrvDocumentAnticipe))
      {
        double num = Conversions.ToDouble(NewLateBinding.LateGet(NewLateBinding.LateIndexGet(this.dgrvDocumentAnticipe.DataSource, new object[1]
        {
          (object) checked ((short) this.dgrvDocumentAnticipe.CurrentRow.Index)
        }, (string[]) null), (System.Type) null, "PriceTax2", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
        if (this.bolImpuesto2)
        {
          if (num == 0.0)
          {
            ModGeneralFunctions.MessageOk1("No puede elegir ese documento porque no tiene impuesto " + ModGeneralVar.g_BE_TR1_VARIABLES_B.get_VarTax2());
            return;
          }
        }
        else if (num > 0.0)
        {
          ModGeneralFunctions.MessageOk1("No puede elegir ese documento porque tiene impuesto " + ModGeneralVar.g_BE_TR1_VARIABLES_B.get_VarTax2());
          return;
        }
        this.CalculatePay();
      }
    }

    private void Button_CreateInvoice_Click(object sender, EventArgs e)
    {
      if (!this.ValidData())
        return;
      try
      {
        if (!ModGeneralFunctions.MessageMakeAction("¿Generar [Factura]?", false))
          return;
        BE_TR1_DOCUMENTS pbeDOCUMENTS = new BE_TR1_DOCUMENTS();
        if (ModGeneralVar.g_BE_TR1_CFGVARIABLES.get_ShowPorConsumo() && ModGeneralFunctions.MessageMakeAction("¿ Por Consumo ?", false))
          pbeDOCUMENTS.set_IsByConsumption(true);
        this.CodigoSeleccionado();
        pbeDOCUMENTS.set_EstabliId(ModGeneralVar.g_BE_TR1_VARIABLES_B.get_EstabliId());
        pbeDOCUMENTS.set_EmpresaId(ModGeneralVar.g_BE_TR1_VARIABLES_B.get_EmpresaId());
        pbeDOCUMENTS.set_BoxId(ModGeneralVar.g_BE_TR1_CFGVARIABLES.get_BoxId());
        pbeDOCUMENTS.set_TurnId(ModGeneralVar.g_BE_TR1_TURNS.get_TurnId());
        pbeDOCUMENTS.set_OrderId(this.obeORDER.get_OrderId());
        pbeDOCUMENTS.set_DocumentState(ModGeneralVar.g_BusinessCode.get_DOCU_PAYLESS());
        if (ModGeneralVar.g_BE_TR1_CFGVARIABLES.get_IsPrinterMatricial())
          pbeDOCUMENTS.set_DocumentType(ModGeneralVar.g_GeneralCode.get_Docu_Factura());
        else
          pbeDOCUMENTS.set_DocumentType(ModGeneralVar.g_GeneralCode.get_Docu_Invoice());
        pbeDOCUMENTS.set_ClientId(this.TextBox_ClientId.Text.Trim());
        pbeDOCUMENTS.set_NumeroSerie(ModGeneralFunctions.ObtenerNumeroSerie(pbeDOCUMENTS.get_DocumentType(), pbeDOCUMENTS.get_ClientId()));
        pbeDOCUMENTS.set_AmountDis(this.obeORDER.get_DiscountMount());
        BE_TR1_BILL_HEAD beTr1BillHead = new BE_TR1_BILL_HEAD();
        if (this.oblORDERS.ObtenerDocumento(ModGeneralVar.g_BE_TR1_VARIABLES_B.get_EstabliId(), Conversions.ToInteger(this.strDocumentCode), true).get_PriceTax2() > 0.0)
        {
          pbeDOCUMENTS.set_AmountNetAnticipe(ModGeneralFunctions.CadenaToDouble(this.LblTotal_PaidSoles.Text) / (1.0 + ModGeneralVar.g_BE_TR1_VARIABLES_B.get_Tax1() / 100.0 + ModGeneralVar.g_BE_TR1_VARIABLES_B.get_Tax2() / 100.0));
          pbeDOCUMENTS.set_AmountTaxAnticipe(pbeDOCUMENTS.get_AmountNetAnticipe() * (ModGeneralVar.g_BE_TR1_VARIABLES_B.get_Tax1() / 100.0));
          pbeDOCUMENTS.set_AmountTax2Anticipe(pbeDOCUMENTS.get_AmountNetAnticipe() * (ModGeneralVar.g_BE_TR1_VARIABLES_B.get_Tax2() / 100.0));
        }
        else
        {
          pbeDOCUMENTS.set_AmountNetAnticipe(ModGeneralFunctions.CadenaToDouble(this.LblTotal_PaidSoles.Text) / (1.0 + ModGeneralVar.g_BE_TR1_VARIABLES_B.get_Tax1() / 100.0));
          pbeDOCUMENTS.set_AmountTaxAnticipe(pbeDOCUMENTS.get_AmountNetAnticipe() * (ModGeneralVar.g_BE_TR1_VARIABLES_B.get_Tax1() / 100.0));
          pbeDOCUMENTS.set_AmountTax2Anticipe(0.0);
        }
        beTr1BillHead = (BE_TR1_BILL_HEAD) null;
        pbeDOCUMENTS.set_AmountSale(ModGeneralFunctions.CadenaToDouble(this.lblPendingMoney.Text));
        pbeDOCUMENTS.set_TypeChange(ModGeneralVar.g_BE_TR1_TURNS.get_TyChanSale());
        pbeDOCUMENTS.set_UserId(ModGeneralVar.g_BE_USERS.get_UserId());
        pbeDOCUMENTS.set_MonedaId(ModGeneralVar.g_str_MonedaId);
        pbeDOCUMENTS.set_DocumentIdAnticipe(this.strDocumentCode);
        string p_Mensaje = "";
        int pintDocumentCode = 0;
        if (ModGeneralVar.g_BE_TR1_CFGVARIABLES.get_IsFirstPay() & !ModGeneralVar.g_Str_OrderTypeID.Equals(ModGeneralVar.g_Str_OrderTypeDelivery))
        {
          if (ModGeneralFunctions.CadenaToDouble(this.lblPendingMoney.Text) > 0.0)
          {
            if (ModGeneralVar.g_BE_TR1_CFGVARIABLES.get_ShowPay())
            {
              if (ModGeneralFunctions.MessageMakeAction("¿Pagar Atencion [" + this.obeORDER.get_OrderId() + "]?", false) && ModGeneralFunctions.PagarxProducto(pbeDOCUMENTS, this.oListaORDERDETAILS))
              {
                this.CrearDocumentoAnticipo(pbeDOCUMENTS);
                p_Mensaje = StructApp.RESULT_OK;
              }
            }
            else if (ModGeneralFunctions.PagarxProducto(pbeDOCUMENTS, this.oListaORDERDETAILS))
            {
              this.CrearDocumentoAnticipo(pbeDOCUMENTS);
              p_Mensaje = StructApp.RESULT_OK;
            }
          }
          else
          {
            pbeDOCUMENTS.set_DocumentState(ModGeneralVar.g_BusinessCode.get_DOCU_PROCESSED());
            p_Mensaje = ModGeneralFunctions.CrearDocumentoxProducto(ref pbeDOCUMENTS, this.oListaORDERDETAILS, ref pintDocumentCode, false, (BE_TR1_DOCUMENTS) null, (BECollec_TR1_DOCUMENTS_PAID) null);
            this.CrearDocumentoAnticipo(pbeDOCUMENTS);
            this.PayDocument(pbeDOCUMENTS.get_DocumentCode(), pbeDOCUMENTS.get_DocumentId(), pbeDOCUMENTS.get_DocumentType());
          }
        }
        else
        {
          p_Mensaje = ModGeneralFunctions.CrearDocumentoxProducto(ref pbeDOCUMENTS, this.oListaORDERDETAILS, ref pintDocumentCode, false, (BE_TR1_DOCUMENTS) null, (BECollec_TR1_DOCUMENTS_PAID) null);
          if (!ModGeneralVar.g_Str_OrderTypeID.Equals(ModGeneralVar.g_Str_OrderTypeDelivery))
          {
            if (ModGeneralFunctions.CadenaToDouble(this.lblPendingMoney.Text) > 0.0)
            {
              if (ModGeneralVar.g_BE_TR1_CFGVARIABLES.get_ShowPay())
              {
                if (ModGeneralFunctions.MessageMakeAction("¿Pagar Atención [" + this.obeORDER.get_OrderId() + "]?", false) && ModGeneralFunctions.PagarxDocumento(pintDocumentCode, false, false))
                {
                  this.CrearDocumentoAnticipo(pbeDOCUMENTS);
                  p_Mensaje = StructApp.RESULT_OK;
                }
              }
              else if (ModGeneralFunctions.PagarxDocumento(pintDocumentCode, false, false))
              {
                this.CrearDocumentoAnticipo(pbeDOCUMENTS);
                p_Mensaje = StructApp.RESULT_OK;
              }
            }
            else
            {
              this.CrearDocumentoAnticipo(pbeDOCUMENTS);
              this.PayDocument(pbeDOCUMENTS.get_DocumentCode(), pbeDOCUMENTS.get_DocumentId(), pbeDOCUMENTS.get_DocumentType());
              p_Mensaje = StructApp.RESULT_OK;
            }
          }
        }
        if (p_Mensaje.Equals(StructApp.RESULT_OK))
        {
          if (Operators.ConditionalCompareObjectEqual(ModGeneralFunctions.ObtenerAPPCONFIG("ACTIVA_ENVIO_DATOS_AUTOMATICO"), (object) true, false))
            new FrmSegundoPlano(ModGeneralVar.g_BE_TR1_VARIABLES_B.get_EstabliId(), pbeDOCUMENTS.get_DocumentCode())
            {
              strOrderId = pbeDOCUMENTS.get_OrderId(),
              intTipoEnvio = (short) 2
            }.Show();
          ModGeneralVar.g_Str_OrderID = "";
          ModGeneralVar.g_Str_SubTableDes = "";
          this.Close();
        }
        else if (!p_Mensaje.Equals(""))
          ModGeneralFunctions.MessageError_Large(p_Mensaje, true);
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
    }

    private void Button_CreateTicket_Click(object sender, EventArgs e)
    {
      if (!this.ValidData())
        return;
      try
      {
        if (!ModGeneralFunctions.MessageMakeAction("Generar [" + ModGeneralVar.get_Docu_BoletaOrTicket() + "]?", false))
          return;
        BE_TR1_DOCUMENTS pbeDOCUMENTS = new BE_TR1_DOCUMENTS();
        if (ModGeneralVar.g_BE_TR1_CFGVARIABLES.get_ShowPorConsumo() && ModGeneralFunctions.MessageMakeAction("¿ Por Consumo ?", false))
          pbeDOCUMENTS.set_IsByConsumption(true);
        this.CodigoSeleccionado();
        pbeDOCUMENTS.set_EstabliId(ModGeneralVar.g_BE_TR1_VARIABLES_B.get_EstabliId());
        pbeDOCUMENTS.set_EmpresaId(ModGeneralVar.g_BE_TR1_VARIABLES_B.get_EmpresaId());
        pbeDOCUMENTS.set_BoxId(ModGeneralVar.g_BE_TR1_CFGVARIABLES.get_BoxId());
        pbeDOCUMENTS.set_TurnId(ModGeneralVar.g_BE_TR1_TURNS.get_TurnId());
        pbeDOCUMENTS.set_OrderId(this.obeORDER.get_OrderId());
        if (ModGeneralVar.g_BE_TR1_CFGVARIABLES.get_IsPrinterMatricial())
          pbeDOCUMENTS.set_DocumentType(ModGeneralVar.g_GeneralCode.get_Docu_Boleta());
        else
          pbeDOCUMENTS.set_DocumentType(ModGeneralVar.g_GeneralCode.get_Docu_Ticket());
        pbeDOCUMENTS.set_ClientId(this.TextBox_ClientId.Text.Trim());
        pbeDOCUMENTS.set_NumeroSerie(ModGeneralFunctions.ObtenerNumeroSerie(pbeDOCUMENTS.get_DocumentType(), pbeDOCUMENTS.get_ClientId()));
        pbeDOCUMENTS.set_DocumentState(ModGeneralVar.g_BusinessCode.get_DOCU_PAYLESS());
        pbeDOCUMENTS.set_AmountDis(this.obeORDER.get_DiscountMount());
        BE_TR1_BILL_HEAD beTr1BillHead = new BE_TR1_BILL_HEAD();
        if (this.oblORDERS.ObtenerDocumento(ModGeneralVar.g_BE_TR1_VARIABLES_B.get_EstabliId(), Conversions.ToInteger(this.strDocumentCode), true).get_PriceTax2() > 0.0)
        {
          pbeDOCUMENTS.set_AmountNetAnticipe(ModGeneralFunctions.CadenaToDouble(this.LblTotal_PaidSoles.Text) / (1.0 + ModGeneralVar.g_BE_TR1_VARIABLES_B.get_Tax1() / 100.0 + ModGeneralVar.g_BE_TR1_VARIABLES_B.get_Tax2() / 100.0));
          pbeDOCUMENTS.set_AmountTaxAnticipe(pbeDOCUMENTS.get_AmountNetAnticipe() * (ModGeneralVar.g_BE_TR1_VARIABLES_B.get_Tax1() / 100.0));
          pbeDOCUMENTS.set_AmountTax2Anticipe(pbeDOCUMENTS.get_AmountNetAnticipe() * (ModGeneralVar.g_BE_TR1_VARIABLES_B.get_Tax2() / 100.0));
        }
        else
        {
          pbeDOCUMENTS.set_AmountNetAnticipe(ModGeneralFunctions.CadenaToDouble(this.LblTotal_PaidSoles.Text) / (1.0 + ModGeneralVar.g_BE_TR1_VARIABLES_B.get_Tax1() / 100.0));
          pbeDOCUMENTS.set_AmountTaxAnticipe(pbeDOCUMENTS.get_AmountNetAnticipe() * (ModGeneralVar.g_BE_TR1_VARIABLES_B.get_Tax1() / 100.0));
          pbeDOCUMENTS.set_AmountTax2Anticipe(0.0);
        }
        beTr1BillHead = (BE_TR1_BILL_HEAD) null;
        pbeDOCUMENTS.set_AmountSale(ModGeneralFunctions.CadenaToDouble(this.lblPendingMoney.Text));
        pbeDOCUMENTS.set_TypeChange(ModGeneralVar.g_BE_TR1_TURNS.get_TyChanSale());
        pbeDOCUMENTS.set_UserId(ModGeneralVar.g_BE_USERS.get_UserId());
        pbeDOCUMENTS.set_MonedaId(ModGeneralVar.g_str_MonedaId);
        pbeDOCUMENTS.set_DocumentIdAnticipe(this.strDocumentCode);
        string p_Mensaje = "";
        int pintDocumentCode = 0;
        if (ModGeneralVar.g_BE_TR1_CFGVARIABLES.get_IsFirstPay() & !ModGeneralVar.g_Str_OrderTypeID.Equals(ModGeneralVar.g_Str_OrderTypeDelivery))
        {
          if (ModGeneralFunctions.CadenaToDouble(this.lblPendingMoney.Text) > 0.0)
          {
            if (ModGeneralVar.g_BE_TR1_CFGVARIABLES.get_ShowPay())
            {
              if (ModGeneralFunctions.MessageMakeAction("¿Pagar Atencion [" + this.obeORDER.get_OrderId() + "]?", false) && ModGeneralFunctions.PagarxProducto(pbeDOCUMENTS, this.oListaORDERDETAILS))
              {
                this.CrearDocumentoAnticipo(pbeDOCUMENTS);
                p_Mensaje = StructApp.RESULT_OK;
              }
            }
            else if (ModGeneralFunctions.PagarxProducto(pbeDOCUMENTS, this.oListaORDERDETAILS))
            {
              this.CrearDocumentoAnticipo(pbeDOCUMENTS);
              p_Mensaje = StructApp.RESULT_OK;
            }
          }
          else
          {
            p_Mensaje = ModGeneralFunctions.CrearDocumentoxProducto(ref pbeDOCUMENTS, this.oListaORDERDETAILS, ref pintDocumentCode, false, (BE_TR1_DOCUMENTS) null, (BECollec_TR1_DOCUMENTS_PAID) null);
            this.CrearDocumentoAnticipo(pbeDOCUMENTS);
            this.PayDocument(pbeDOCUMENTS.get_DocumentCode(), pbeDOCUMENTS.get_DocumentId(), pbeDOCUMENTS.get_DocumentType());
          }
        }
        else
        {
          p_Mensaje = ModGeneralFunctions.CrearDocumentoxProducto(ref pbeDOCUMENTS, this.oListaORDERDETAILS, ref pintDocumentCode, false, (BE_TR1_DOCUMENTS) null, (BECollec_TR1_DOCUMENTS_PAID) null);
          if (!ModGeneralVar.g_Str_OrderTypeID.Equals(ModGeneralVar.g_Str_OrderTypeDelivery))
          {
            if (ModGeneralFunctions.CadenaToDouble(this.lblPendingMoney.Text) > 0.0)
            {
              if (ModGeneralVar.g_BE_TR1_CFGVARIABLES.get_ShowPay())
              {
                if (ModGeneralFunctions.MessageMakeAction("¿Pagar Atención [" + this.obeORDER.get_OrderId() + "]?", false) && ModGeneralFunctions.PagarxDocumento(pintDocumentCode, false, false))
                {
                  this.CrearDocumentoAnticipo(pbeDOCUMENTS);
                  p_Mensaje = StructApp.RESULT_OK;
                }
              }
              else if (ModGeneralFunctions.PagarxDocumento(pintDocumentCode, false, false))
              {
                this.CrearDocumentoAnticipo(pbeDOCUMENTS);
                p_Mensaje = StructApp.RESULT_OK;
              }
            }
            else
            {
              this.CrearDocumentoAnticipo(pbeDOCUMENTS);
              this.PayDocument(pbeDOCUMENTS.get_DocumentCode(), pbeDOCUMENTS.get_DocumentId(), pbeDOCUMENTS.get_DocumentType());
              p_Mensaje = StructApp.RESULT_OK;
            }
          }
        }
        if (p_Mensaje.Equals(StructApp.RESULT_OK))
        {
          if (Operators.ConditionalCompareObjectEqual(ModGeneralFunctions.ObtenerAPPCONFIG("ACTIVA_ENVIO_DATOS_AUTOMATICO"), (object) true, false))
            new FrmSegundoPlano(ModGeneralVar.g_BE_TR1_VARIABLES_B.get_EstabliId(), pbeDOCUMENTS.get_DocumentCode())
            {
              strOrderId = pbeDOCUMENTS.get_OrderId(),
              intTipoEnvio = (short) 2
            }.Show();
          ModGeneralVar.g_Str_OrderID = "";
          ModGeneralVar.g_Str_SubTableDes = "";
          this.Close();
        }
        else if (!p_Mensaje.Equals(""))
          ModGeneralFunctions.MessageError_Large(p_Mensaje, true);
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
    }

    private void btnDocumentsPaylessB_Click(object sender, EventArgs e)
    {
      try
      {
        if (!ModGeneralFunctions.Order_HeadValidated(this.dgrvDocumentAnticipe))
          return;
        short num = checked ((short) (this.dgrvDocumentAnticipe.CurrentRow.Index - 1));
        if (this.dgrvDocumentAnticipe.Rows.Count > 0 & num > (short) -1)
          this.dgrvDocumentAnticipe.CurrentCell = this.dgrvDocumentAnticipe[1, (int) num];
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
    }

    private void btnDocumentsPaylessN_Click(object sender, EventArgs e)
    {
      try
      {
        if (!ModGeneralFunctions.Order_HeadValidated(this.dgrvDocumentAnticipe))
          return;
        short index = checked ((short) this.dgrvDocumentAnticipe.CurrentRow.Index);
        if (this.dgrvDocumentAnticipe.Rows.Count > 0 & (int) index < checked (this.dgrvDocumentAnticipe.Rows.Count - 1))
          this.dgrvDocumentAnticipe.CurrentCell = this.dgrvDocumentAnticipe[1, checked ((int) index + 1)];
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
    }

    private void MyXPButton_Canje_Click(object sender, EventArgs e)
    {
      if (!this.ValidData())
        return;
      if (ModGeneralVar.g_BE_TR1_CFGVARIABLES.get_ShowUserDocuIntern())
      {
        string _UserId = "";
        if (!ModGeneralFunctions.Validate_Permission(ref _UserId, true, false, "Autorizar Generación Canje", false))
        {
          if (ModGeneralVar.g_bol_IsClose)
            return;
          ModGeneralFunctions.MessageOk("¡No Tiene Permiso Válido!");
          return;
        }
      }
      if (ModGeneralVar.g_BE_TR1_CFGVARIABLES.get_ConfirmarDocumento() && !ModGeneralFunctions.MessageMakeAction("¿Generar [Canje]?", false))
        return;
      string Expression = this.TextBox_ClientId.Text;
      if (Strings.Len(Expression) == 0)
      {
        if (!ModGeneralFunctions.Show_SearchClient())
          return;
        Expression = ModGeneralVar.g_Str_RecordID;
      }
      BE_TR1_DOCUMENTS pbeDOCUMENTS = new BE_TR1_DOCUMENTS();
      pbeDOCUMENTS.set_EstabliId(ModGeneralVar.g_BE_TR1_VARIABLES_B.get_EstabliId());
      pbeDOCUMENTS.set_EmpresaId(ModGeneralVar.g_BE_TR1_VARIABLES_B.get_EmpresaId());
      pbeDOCUMENTS.set_BoxId(ModGeneralVar.g_BE_TR1_CFGVARIABLES.get_BoxId());
      pbeDOCUMENTS.set_TurnId(ModGeneralVar.g_BE_TR1_TURNS.get_TurnId());
      pbeDOCUMENTS.set_OrderId(this.obeORDER.get_OrderId());
      pbeDOCUMENTS.set_DocumentType(ModGeneralVar.g_GeneralCode.get_Docu_Intern());
      pbeDOCUMENTS.set_ClientId(Expression);
      pbeDOCUMENTS.set_NumeroSerie(ModGeneralFunctions.ObtenerNumeroSerie(pbeDOCUMENTS.get_DocumentType(), pbeDOCUMENTS.get_ClientId()));
      pbeDOCUMENTS.set_DocumentState(ModGeneralVar.g_BusinessCode.get_DOCU_PAYLESS());
      pbeDOCUMENTS.set_Observation("Canje");
      BE_TR1_BILL_HEAD beTr1BillHead = new BE_TR1_BILL_HEAD();
      if (this.oblORDERS.ObtenerDocumento(ModGeneralVar.g_BE_TR1_VARIABLES_B.get_EstabliId(), Conversions.ToInteger(this.strDocumentCode), true).get_PriceTax2() > 0.0)
      {
        pbeDOCUMENTS.set_AmountNetAnticipe(ModGeneralFunctions.CadenaToDouble(this.LblTotal_PaidSoles.Text) / (1.0 + ModGeneralVar.g_BE_TR1_VARIABLES_B.get_Tax1() / 100.0 + ModGeneralVar.g_BE_TR1_VARIABLES_B.get_Tax2() / 100.0));
        pbeDOCUMENTS.set_AmountTaxAnticipe(pbeDOCUMENTS.get_AmountNetAnticipe() * (ModGeneralVar.g_BE_TR1_VARIABLES_B.get_Tax1() / 100.0));
        pbeDOCUMENTS.set_AmountTax2Anticipe(pbeDOCUMENTS.get_AmountNetAnticipe() * (ModGeneralVar.g_BE_TR1_VARIABLES_B.get_Tax2() / 100.0));
      }
      else
      {
        pbeDOCUMENTS.set_AmountNetAnticipe(ModGeneralFunctions.CadenaToDouble(this.LblTotal_PaidSoles.Text) / (1.0 + ModGeneralVar.g_BE_TR1_VARIABLES_B.get_Tax1() / 100.0));
        pbeDOCUMENTS.set_AmountTaxAnticipe(pbeDOCUMENTS.get_AmountNetAnticipe() * (ModGeneralVar.g_BE_TR1_VARIABLES_B.get_Tax1() / 100.0));
        pbeDOCUMENTS.set_AmountTax2Anticipe(0.0);
      }
      beTr1BillHead = (BE_TR1_BILL_HEAD) null;
      pbeDOCUMENTS.set_AmountSale(ModGeneralFunctions.CadenaToDouble(this.lblPendingMoney.Text));
      pbeDOCUMENTS.set_TypeChange(ModGeneralVar.g_BE_TR1_TURNS.get_TyChanSale());
      pbeDOCUMENTS.set_UserId(ModGeneralVar.g_BE_USERS.get_UserId());
      pbeDOCUMENTS.set_MonedaId(ModGeneralVar.g_str_MonedaId);
      string str = "";
      BE_TR1_ORDERS beTr1Orders = new BE_TR1_ORDERS();
      List<BE_TR1_ORDERS> beTr1OrdersList = new List<BE_TR1_ORDERS>();
      ReportDocument reportDocument = new ReportDocument();
      BE_TR1_PRINTERS beTr1Printers = new BE_TR1_PRINTERS();
      this.oblORDERS.o_BE_TR1_VARIABLES_B = (__Null) ModGeneralVar.g_BE_TR1_VARIABLES_B;
      string p_Mensaje1 = !ModGeneralVar.g_BE_TR1_CFGVARIABLES.get_IsPrinterMatricial() ? this.oblORDERS.CrearDocumento(pbeDOCUMENTS, this.oListaORDERDETAILS, ModGeneralVar.g_BusinessCode.get_ORDER_FACTURADO(), ModGeneralVar.g_BE_ORDER_OPTIONS, ModGeneralVar.g_BusinessCode.get_TABLE_LISTA(), ModGeneralVar.g_BusinessCode.get_TABLE_OCUPADA(), ModGeneralVar.g_BE_TR1_VARIABLES_B, Conversions.ToBoolean(ModGeneralFunctions.ObtenerAPPCONFIG("ACTIVAR_GRABAR_FACTURA_ELECTRONICA"))) : this.oblORDERS.CrearDocumentoMatricial(pbeDOCUMENTS, this.oListaORDERDETAILS, ModGeneralVar.g_BusinessCode.get_ORDER_FACTURADO(), ModGeneralVar.g_BE_ORDER_OPTIONS, ModGeneralVar.g_BusinessCode.get_TABLE_LISTA(), ModGeneralVar.g_BusinessCode.get_TABLE_OCUPADA(), (BE_TR1_VARIABLES_B) null, false);
      if (!p_Mensaje1.Equals(StructApp.RESULT_OK))
      {
        ModGeneralFunctions.MessageError_Large(p_Mensaje1, true);
      }
      else
      {
        BL_TR1_DOCUMENTS_ANTICIPE documentsAnticipe = new BL_TR1_DOCUMENTS_ANTICIPE();
        if (this.oListaDOCUMENTS_ANTICIPE.Count > 0)
          this.oListaDOCUMENTS_ANTICIPE[0].set_UserId(ModGeneralVar.g_BE_USERS.get_UserId());
        string p_Mensaje2 = documentsAnticipe.Edit(ref this.oListaDOCUMENTS_ANTICIPE);
        if (p_Mensaje2.Equals(StructApp.RESULT_OK))
        {
          string p_Mensaje3 = this.SaveAnticipeConsume(pbeDOCUMENTS);
          if (p_Mensaje3.Equals(StructApp.RESULT_OK))
          {
            if (Operators.ConditionalCompareObjectEqual(ModGeneralFunctions.ObtenerAPPCONFIG("ACTIVA_ENVIO_DATOS_AUTOMATICO"), (object) true, false))
              new FrmSegundoPlano(ModGeneralVar.g_BE_TR1_VARIABLES_B.get_EstabliId(), pbeDOCUMENTS.get_DocumentCode())
              {
                strOrderId = pbeDOCUMENTS.get_OrderId(),
                intTipoEnvio = (short) 2
              }.Show();
            string resultOk = StructApp.RESULT_OK;
            this.Close();
            if (ModGeneralFunctions.CadenaToDouble(this.lblPendingMoney.Text) > 0.0)
            {
              if (ModGeneralVar.g_BE_TR1_CFGVARIABLES.get_IsFirstPay())
              {
                if (ModGeneralVar.g_BE_TR1_CFGVARIABLES.get_ShowPay())
                {
                  if (!ModGeneralFunctions.MessageMakeAction("¿Pagar Documento [" + pbeDOCUMENTS.get_DocumentId() + "]?", false) || !ModGeneralFunctions.PagarxDocumento(pbeDOCUMENTS.get_DocumentCode(), false, false))
                    ;
                }
                else if (!ModGeneralFunctions.PagarxDocumento(pbeDOCUMENTS.get_DocumentCode(), false, false))
                  ;
                if (!resultOk.Equals(StructApp.RESULT_OK))
                {
                  ModGeneralFunctions.MessageError_Large(resultOk, true);
                  return;
                }
              }
              else if (ModGeneralVar.g_BE_TR1_CFGVARIABLES.get_ShowPay())
              {
                if (ModGeneralFunctions.MessageMakeAction("¿Pagar Documento [" + pbeDOCUMENTS.get_DocumentId() + "]?", false))
                  ModGeneralFunctions.PagarxDocumento(pbeDOCUMENTS.get_DocumentCode(), false, false);
              }
              else
                ModGeneralFunctions.PagarxDocumento(pbeDOCUMENTS.get_DocumentCode(), false, false);
            }
            else
            {
              this.PayDocument(pbeDOCUMENTS.get_DocumentCode(), pbeDOCUMENTS.get_DocumentId(), pbeDOCUMENTS.get_DocumentType());
              if (ModGeneralVar.g_BE_TR1_CFGVARIABLES.get_IsPrinterMatricial())
                str = StructApp.RESULT_OK;
              else if (!resultOk.Equals(StructApp.RESULT_OK))
              {
                ModGeneralFunctions.MessageError_Large(resultOk, true);
                return;
              }
            }
            ModGeneralVar.g_Str_OrderID = "";
            ModGeneralVar.g_Str_SubTableDes = "";
            this.Close();
          }
          else
            ModGeneralFunctions.MessageError_Large(p_Mensaje3, true);
        }
        else
          ModGeneralFunctions.MessageError_Large(p_Mensaje2, true);
      }
    }

    private void FrmAnticipePay_KeyDown(object sender, KeyEventArgs e)
    {
      if (!e.KeyValue.Equals(27))
        return;
      this.Close();
    }

    private void dgrvDocumentAnticipe_CellFormatting(
      object sender,
      DataGridViewCellFormattingEventArgs e)
    {
      if (e.ColumnIndex != 6)
        return;
      if (Conversions.ToBoolean(NewLateBinding.LateGet(NewLateBinding.LateIndexGet(this.dgrvDocumentAnticipe.DataSource, new object[1]
      {
        (object) e.RowIndex
      }, (string[]) null), (System.Type) null, "IsApply", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null)))
        e.Value = (object) TriNetRestPOS.My.Resources.Resources.IsPrinted_True;
      else
        e.Value = (object) TriNetRestPOS.My.Resources.Resources.IsPrinted_False;
    }

    public FrmAnticipePay()
    {
      this.Load += new EventHandler(this.FrmAnticipePay_Load);
      this.KeyDown += new KeyEventHandler(this.FrmAnticipePay_KeyDown);
      this.oListaORDERDETAILS = new List<BE_TR1_ORDERDETAILS>();
      this.oblORDERS = new BL_TR1_ORDERS();
      this.bolImpuesto2 = false;
      this.InitializeComponent();
    }

    private void SetUpDataGridView()
    {
      ModGeneralFunctions.SetUpDataGridViewBasic(this.dgrvDocumentAnticipe);
      this.dgrvDocumentAnticipe.Columns.Add("DocumentTypeDes", "T");
      ModGeneralFunctions.SetUp_TextBoxColumn((DataGridViewTextBoxColumn) this.dgrvDocumentAnticipe.Columns[0], "DocumentTypeDes", (short) 28, "", true, DataGridViewContentAlignment.MiddleLeft, true);
      this.dgrvDocumentAnticipe.Columns.Add("DocumentId", "Nº Documento");
      ModGeneralFunctions.SetUp_TextBoxColumn((DataGridViewTextBoxColumn) this.dgrvDocumentAnticipe.Columns[1], "DocumentId", (short) 110, "", true, DataGridViewContentAlignment.MiddleLeft, true);
      this.dgrvDocumentAnticipe.Columns.Add("Glose", "Concepto");
      ModGeneralFunctions.SetUp_TextBoxColumn((DataGridViewTextBoxColumn) this.dgrvDocumentAnticipe.Columns[2], "Glose", (short) 140, "", true, DataGridViewContentAlignment.MiddleLeft, true);
      this.dgrvDocumentAnticipe.Columns.Add("Moneda", "Moneda");
      ModGeneralFunctions.SetUp_TextBoxColumn((DataGridViewTextBoxColumn) this.dgrvDocumentAnticipe.Columns[3], "Moneda", (short) 50, "", true, DataGridViewContentAlignment.MiddleLeft, true);
      this.dgrvDocumentAnticipe.Columns.Add("AmountTotal", "M. Total");
      ModGeneralFunctions.SetUp_TextBoxColumn((DataGridViewTextBoxColumn) this.dgrvDocumentAnticipe.Columns[4], "AmountTotal", (short) 90, "0.00", true, DataGridViewContentAlignment.MiddleRight, true);
      this.dgrvDocumentAnticipe.Columns.Add("AmountNewSald", "Saldo");
      ModGeneralFunctions.SetUp_TextBoxColumn((DataGridViewTextBoxColumn) this.dgrvDocumentAnticipe.Columns[5], "AmountNewSald", (short) 80, "0.00", true, DataGridViewContentAlignment.MiddleRight, true);
      this.dgrvDocumentAnticipe.Columns.Add((DataGridViewColumn) new DataGridViewImageColumn());
      ModGeneralFunctions.SetUp_ImageColumn((DataGridViewImageColumn) this.dgrvDocumentAnticipe.Columns[6], "Aplicar", (short) 60, "", TriNetRestPOS.My.Resources.Resources.IsPrinted_False, true);
    }

    private void LoadDocumentAnticipe(string pstrClientId)
    {
      try
      {
        this.oListaDOCUMENTS_ANTICIPE = new List<BE_TR1_DOCUMENTS_ANTICIPE>();
        this.oListaDOCUMENTS_ANTICIPE = new BL_TR1_DOCUMENTS_ANTICIPE().List_ByClient(ModGeneralVar.g_BE_TR1_VARIABLES_B.get_EstabliId(), pstrClientId);
        if (this.oListaDOCUMENTS_ANTICIPE.Count > 0)
        {
          this.dgrvDocumentAnticipe.DataSource = (object) this.oListaDOCUMENTS_ANTICIPE;
        }
        else
        {
          ModGeneralFunctions.MessageOk("¡No hay Documentos x Anticipo!");
          this.Close();
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
    }

    private void CodigoSeleccionado()
    {
      int num1 = checked (this.dgrvDocumentAnticipe.Rows.Count - 1);
      int num2 = 0;
      while (num2 <= num1)
      {
        if (Conversions.ToBoolean(NewLateBinding.LateGet(NewLateBinding.LateIndexGet(this.dgrvDocumentAnticipe.DataSource, new object[1]
        {
          (object) num2
        }, (string[]) null), (System.Type) null, "IsApply", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null)))
          this.strDocumentCode = NewLateBinding.LateGet(NewLateBinding.LateIndexGet(this.dgrvDocumentAnticipe.DataSource, new object[1]
          {
            (object) num2
          }, (string[]) null), (System.Type) null, "DocumentCode", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null).ToString();
        checked { ++num2; }
      }
    }

    private void CalculatePay()
    {
      try
      {
        double num1 = ModGeneralFunctions.CadenaToDouble(this.LblTotal_PaidSoles.Text);
        double num2 = 0.0;
        short index = checked ((short) this.dgrvDocumentAnticipe.CurrentRow.Index);
        double amountSald = this.oListaDOCUMENTS_ANTICIPE[(int) index].get_AmountSald();
        double amountNewSald = this.oListaDOCUMENTS_ANTICIPE[(int) index].get_AmountNewSald();
        string monedaId = this.oListaDOCUMENTS_ANTICIPE[(int) index].get_MonedaId();
        double num3;
        if (this.oListaDOCUMENTS_ANTICIPE[(int) index].get_IsApply())
        {
          num2 = ModGeneralFunctions.CadenaToDouble(this.LblTotal_BillSoles.Text);
          this.oListaDOCUMENTS_ANTICIPE[(int) index].set_IsApply(false);
          if (Operators.CompareString(monedaId, "02", false) == 0 & Operators.CompareString(ModGeneralVar.g_str_MonedaId, "01", false) == 0)
          {
            amountNewSald *= ModGeneralVar.g_BE_TR1_TURNS.get_TyChanBuy();
            amountSald *= ModGeneralVar.g_BE_TR1_TURNS.get_TyChanBuy();
          }
          if (Operators.CompareString(monedaId, "01", false) == 0 & Operators.CompareString(ModGeneralVar.g_str_MonedaId, "02", false) == 0)
          {
            amountNewSald = Conversions.ToDouble(Operators.DivideObject((object) amountNewSald, ModGeneralFunctions.SiEsCero(ModGeneralVar.g_BE_TR1_TURNS.get_TyChanBuy(), 1.0)));
            amountSald = Conversions.ToDouble(Operators.DivideObject((object) amountSald, ModGeneralFunctions.SiEsCero(ModGeneralVar.g_BE_TR1_TURNS.get_TyChanBuy(), 1.0)));
          }
          num3 = num1 - (amountSald - amountNewSald);
          if (Operators.CompareString(monedaId, "02", false) == 0 & Operators.CompareString(ModGeneralVar.g_str_MonedaId, "01", false) == 0)
            amountSald = Conversions.ToDouble(Operators.DivideObject((object) amountSald, ModGeneralFunctions.SiEsCero(ModGeneralVar.g_BE_TR1_TURNS.get_TyChanBuy(), 1.0)));
          if (Operators.CompareString(monedaId, "01", false) == 0 & Operators.CompareString(ModGeneralVar.g_str_MonedaId, "02", false) == 0)
            amountSald *= ModGeneralVar.g_BE_TR1_TURNS.get_TyChanBuy();
          this.oListaDOCUMENTS_ANTICIPE[(int) index].set_AmountNewSald(amountSald);
        }
        else
        {
          if (Operators.CompareString(monedaId, "01", false) == 0 & Operators.CompareString(ModGeneralVar.g_str_MonedaId, "02", false) == 0)
            amountNewSald = Conversions.ToDouble(Operators.DivideObject((object) amountNewSald, ModGeneralFunctions.SiEsCero(ModGeneralVar.g_BE_TR1_TURNS.get_TyChanBuy(), 1.0)));
          if (Operators.CompareString(monedaId, "02", false) == 0 & Operators.CompareString(ModGeneralVar.g_str_MonedaId, "01", false) == 0)
            amountNewSald *= ModGeneralVar.g_BE_TR1_TURNS.get_TyChanBuy();
          double num4 = ModGeneralFunctions.CadenaToDouble(this.LblTotal_BillSoles.Text) - num1;
          this.oListaDOCUMENTS_ANTICIPE[(int) index].set_IsApply(true);
          if (amountNewSald > num4)
          {
            num3 = num1 + num4;
            if (Operators.CompareString(monedaId, "02", false) == 0 & Operators.CompareString(ModGeneralVar.g_str_MonedaId, "01", false) == 0)
              num4 = Conversions.ToDouble(Operators.DivideObject((object) num4, ModGeneralFunctions.SiEsCero(ModGeneralVar.g_BE_TR1_TURNS.get_TyChanBuy(), 1.0)));
            if (Operators.CompareString(monedaId, "01", false) == 0 & Operators.CompareString(ModGeneralVar.g_str_MonedaId, "02", false) == 0)
              num4 *= ModGeneralVar.g_BE_TR1_TURNS.get_TyChanBuy();
            BE_TR1_DOCUMENTS_ANTICIPE documentsAnticipe;
            double num5 = (documentsAnticipe = this.oListaDOCUMENTS_ANTICIPE[(int) index]).get_AmountNewSald() - num4;
            documentsAnticipe.set_AmountNewSald(num5);
          }
          else
          {
            num3 = num1 + amountNewSald;
            if (Operators.CompareString(monedaId, "01", false) == 0 & Operators.CompareString(ModGeneralVar.g_str_MonedaId, "02", false) == 0)
              amountNewSald *= ModGeneralVar.g_BE_TR1_TURNS.get_TyChanBuy();
            if (Operators.CompareString(monedaId, "02", false) == 0 & Operators.CompareString(ModGeneralVar.g_str_MonedaId, "01", false) == 0)
              amountNewSald = Conversions.ToDouble(Operators.DivideObject((object) amountNewSald, ModGeneralFunctions.SiEsCero(ModGeneralVar.g_BE_TR1_TURNS.get_TyChanBuy(), 1.0)));
            BE_TR1_DOCUMENTS_ANTICIPE documentsAnticipe;
            double num5 = (documentsAnticipe = this.oListaDOCUMENTS_ANTICIPE[(int) index]).get_AmountNewSald() - amountNewSald;
            documentsAnticipe.set_AmountNewSald(num5);
          }
        }
        this.LblTotal_PaidSoles.Text = ModGeneralFunctions.CadenaToDoubleFormateado(Conversions.ToString(num3), 2);
        this.lblPendingMoney.Text = ModGeneralFunctions.CadenaToDoubleFormateado(Conversions.ToString(this.dblTotalVenta - num3), 2);
        this.dgrvDocumentAnticipe.DataSource = (object) this.oListaDOCUMENTS_ANTICIPE;
        this.dgrvDocumentAnticipe.Refresh();
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
    }

    private string SaveAnticipeConsume(BE_TR1_DOCUMENTS pbeDOCUMENTS)
    {
      string str;
      try
      {
        BL_TR1_ANTICIPE_CONSUME tr1AnticipeConsume1 = new BL_TR1_ANTICIPE_CONSUME();
        List<BE_TR1_ANTICIPE_CONSUME> tr1AnticipeConsumeList = new List<BE_TR1_ANTICIPE_CONSUME>();
        int num = checked (this.oListaDOCUMENTS_ANTICIPE.Count - 1);
        int index = 0;
        while (index <= num)
        {
          if (this.oListaDOCUMENTS_ANTICIPE[index].get_AmountNewSald() != this.oListaDOCUMENTS_ANTICIPE[index].get_AmountSald())
          {
            BE_TR1_ANTICIPE_CONSUME tr1AnticipeConsume2 = new BE_TR1_ANTICIPE_CONSUME();
            double amountSald = this.oListaDOCUMENTS_ANTICIPE[index].get_AmountSald();
            double amountNewSald = this.oListaDOCUMENTS_ANTICIPE[index].get_AmountNewSald();
            tr1AnticipeConsume2.set_EstabliId(ModGeneralVar.g_BE_TR1_VARIABLES_B.get_EstabliId());
            tr1AnticipeConsume2.set_EmpresaId(ModGeneralVar.g_BE_TR1_VARIABLES_B.get_EmpresaId());
            tr1AnticipeConsume2.set_BoxId(Conversions.ToString(ModGeneralVar.g_BE_TR1_CFGVARIABLES.get_BoxId()));
            tr1AnticipeConsume2.set_TurnId(ModGeneralVar.g_BE_TR1_TURNS.get_TurnId());
            tr1AnticipeConsume2.set_DocumentCode(pbeDOCUMENTS.get_DocumentCode());
            tr1AnticipeConsume2.set_DocumentCodeAnticipe(this.oListaDOCUMENTS_ANTICIPE[index].get_DocumentCode());
            tr1AnticipeConsume2.set_DocumentId(pbeDOCUMENTS.get_DocumentId());
            tr1AnticipeConsume2.set_DocumentType(pbeDOCUMENTS.get_DocumentType());
            tr1AnticipeConsume2.set_OrderId(this.obeORDER.get_OrderId());
            tr1AnticipeConsume2.set_ClientId(this.TextBox_ClientId.Text.Trim());
            tr1AnticipeConsume2.set_AmountTotal(ModGeneralFunctions.CadenaToDouble(this.LblTotal_BillSoles.Text));
            tr1AnticipeConsume2.set_AmountNetAnticipe((amountSald - amountNewSald) / (1.0 + (ModGeneralVar.g_BE_TR1_VARIABLES_B.get_Tax1() + ModGeneralVar.g_BE_TR1_VARIABLES_B.get_Tax2() + ModGeneralVar.g_BE_TR1_VARIABLES_B.get_Tax3()) / 100.0));
            tr1AnticipeConsume2.set_AmountTaxAnticipe(tr1AnticipeConsume2.get_AmountNetAnticipe() * ((ModGeneralVar.g_BE_TR1_VARIABLES_B.get_Tax1() + ModGeneralVar.g_BE_TR1_VARIABLES_B.get_Tax2() + ModGeneralVar.g_BE_TR1_VARIABLES_B.get_Tax3()) / 100.0));
            tr1AnticipeConsume2.set_DocumentIdAnticipe(this.oListaDOCUMENTS_ANTICIPE[index].get_DocumentId());
            tr1AnticipeConsume2.set_DocumentTypeAnticipe(this.oListaDOCUMENTS_ANTICIPE[index].get_DocumentType());
            tr1AnticipeConsume2.set_UserId(ModGeneralVar.g_BE_USERS.get_UserId());
            tr1AnticipeConsumeList.Add(tr1AnticipeConsume2);
          }
          checked { ++index; }
        }
        str = tr1AnticipeConsume1.Add(ref tr1AnticipeConsumeList);
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        str = ex.Message;
        ProjectData.ClearProjectError();
      }
      return str;
    }

    private void PayDocument(int pstrDocumentCode, string pstrDocumentId, string pstrDocumentType)
    {
      BE_TR1_DOCUMENTS beTr1Documents = new BE_TR1_DOCUMENTS();
      beTr1Documents.set_EstabliId(ModGeneralVar.g_BE_TR1_VARIABLES_B.get_EstabliId());
      beTr1Documents.set_EmpresaId(ModGeneralVar.g_BE_TR1_VARIABLES_B.get_EmpresaId());
      beTr1Documents.set_DocumentCode(pstrDocumentCode);
      beTr1Documents.set_DocumentId(pstrDocumentId);
      beTr1Documents.set_DocumentType(pstrDocumentType);
      beTr1Documents.set_AmountCashPaidIN(0.0);
      beTr1Documents.set_AmountCardPaidIN(0.0);
      beTr1Documents.set_AmountReturn(0.0);
      beTr1Documents.set_AmountTip(0.0);
      beTr1Documents.set_DocumentState(ModGeneralVar.g_BusinessCode.get_DOCU_PROCESSED());
      beTr1Documents.set_TurnId(ModGeneralVar.g_BE_TR1_TURNS.get_TurnId());
      beTr1Documents.set_BoxId(ModGeneralVar.g_BE_TR1_BOXES.get_BoxId());
      beTr1Documents.set_UserId(ModGeneralVar.g_BE_USERS.get_UserId());
      beTr1Documents.set_PayDate(DateTime.Now);
      string str1 = "";
      string str2 = "";
      string str3 = "";
      ref string local1 = ref str2;
      string str4 = "";
      ref string local2 = ref str4;
      ModGeneralFunctions.MasterTable_FindRecordId("MasterTable='TYPEMONEY' and MasterTDes = 'DOLARES'", ref local1, ref local2);
      ref string local3 = ref str1;
      string str5 = "";
      ref string local4 = ref str5;
      ModGeneralFunctions.MasterTable_FindRecordId("MasterTable='TYPEMONEY' and MasterTDes = 'SOLES'", ref local3, ref local4);
      ref string local5 = ref str3;
      string str6 = "";
      ref string local6 = ref str6;
      ModGeneralFunctions.MasterTable_FindRecordId("MasterTable='TYPEPAYMENT' and MasterTDes = 'CASH'", ref local5, ref local6);
      BECollec_TR1_DOCUMENTS_PAID tr1DocumentsPaid1 = new BECollec_TR1_DOCUMENTS_PAID();
      short num = 0;
      BE_TR1_DOCUMENTS_PAID tr1DocumentsPaid2 = new BE_TR1_DOCUMENTS_PAID();
      tr1DocumentsPaid2.set_EstabliId(ModGeneralVar.g_BE_TR1_VARIABLES_B.get_EstabliId());
      tr1DocumentsPaid2.set_EmpresaId(ModGeneralVar.g_BE_TR1_VARIABLES_B.get_EmpresaId());
      tr1DocumentsPaid2.set_DocumentCode(pstrDocumentCode);
      tr1DocumentsPaid2.set_DocumentId(pstrDocumentId);
      tr1DocumentsPaid2.set_DocumentType(pstrDocumentType);
      tr1DocumentsPaid2.set_PayId(Conversions.ToString((int) num));
      tr1DocumentsPaid2.set_TurnId(ModGeneralVar.g_BE_TR1_TURNS.get_TurnId());
      tr1DocumentsPaid2.set_UserId(ModGeneralVar.g_BE_USERS.get_UserId());
      tr1DocumentsPaid2.set_TypeChange(0.0);
      tr1DocumentsPaid2.set_TypeChangeBuy(0.0);
      tr1DocumentsPaid2.set_PayAmount(0.0);
      tr1DocumentsPaid2.set_IconId(str1);
      tr1DocumentsPaid2.set_MoneyReturned(0.0);
      tr1DocumentsPaid2.set_PayTip(0.0);
      tr1DocumentsPaid2.set_TypePayment(str3);
      tr1DocumentsPaid2.set_CardId("");
      tr1DocumentsPaid2.set_BankId("");
      tr1DocumentsPaid2.set_CardNumber("");
      tr1DocumentsPaid2.set_DateSaved(DateTime.Now);
      tr1DocumentsPaid2.set_UserId(ModGeneralVar.g_BE_USERS.get_UserId());
      tr1DocumentsPaid2.set_DateExpire(DateTime.MinValue);
      tr1DocumentsPaid1.Add(tr1DocumentsPaid2);
      string str7 = new BL_TR1_ORDERS().DOCUMENT_PAY(beTr1Documents, tr1DocumentsPaid1, false, true);
      if (str7.Equals(StructApp.RESULT_OK))
        return;
      ModGeneralFunctions.MessageError_Large("¡Error al pagar - " + str7 + "!", true);
    }

    private bool ValidData()
    {
      if (ModGeneralFunctions.CadenaToDouble(this.LblTotal_PaidSoles.Text) > 0.0)
        return true;
      ModGeneralFunctions.MessageOk("¡Debe Aplicar un Documento!");
      return false;
    }

    private string CrearDocumentoAnticipo(BE_TR1_DOCUMENTS pbeDOCUMENTS)
    {
      BL_TR1_DOCUMENTS_ANTICIPE documentsAnticipe = new BL_TR1_DOCUMENTS_ANTICIPE();
      if (this.oListaDOCUMENTS_ANTICIPE.Count > 0)
        this.oListaDOCUMENTS_ANTICIPE[0].set_UserId(ModGeneralVar.g_BE_USERS.get_UserId());
      string str = documentsAnticipe.Edit(ref this.oListaDOCUMENTS_ANTICIPE);
      if (str.Equals(StructApp.RESULT_OK))
        str = this.SaveAnticipeConsume(pbeDOCUMENTS);
      return str;
    }
  }
}
