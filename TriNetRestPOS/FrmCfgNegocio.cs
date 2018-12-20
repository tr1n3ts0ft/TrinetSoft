// Decompiled with JetBrains decompiler
// Type: TriNetRestPOS.FrmCfgNegocio
// Assembly: TriNetRestPOS, Version=5.2.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 43377352-E952-4AC1-9BA6-CCBE4AE5F575
// Assembly location: C:\log\TriNetRestPOS.exe

using KIS.Controls;
using KIS.Controls.Windows;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.DirectoryServices;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using TR1_BusinessEntity;
using TR1_BusinessLogic;

namespace TriNetRestPOS
{
  [DesignerGenerated]
  public class FrmCfgNegocio : Form
  {
    private IContainer components;
    public bool bol_DBCleaned;
    private Control _Control;

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
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (FrmCfgNegocio));
      this.Label_SocialReason = new Label();
      this.TextBox_SocialReason = new TextBox();
      this.Label_CommercialReason = new Label();
      this.TextBox_CommercialReason = new TextBox();
      this.Label_Address = new Label();
      this.TextBox_Address = new TextBox();
      this.Label_Email = new Label();
      this.Label_PhoneNumber = new Label();
      this.TextBox_PhoneNumber = new TextBox();
      this.Label_WebPage = new Label();
      this.Label_TributaryId = new Label();
      this.TextBox_TributaryId = new TextBox();
      this.Label_Yes = new Label();
      this.CheckBox_Tax3 = new CheckBox();
      this.CheckBox_Tax2 = new CheckBox();
      this.CheckBox_Tax1 = new CheckBox();
      this.Label_Value = new Label();
      this.Label_Description = new Label();
      this.NumericTexBox_Tax3 = new NumericTextBox.NumericTextBox();
      this.NumericTexBox_Tax2 = new NumericTextBox.NumericTextBox();
      this.NumericTexBox_Tax1 = new NumericTextBox.NumericTextBox();
      this.TextBox_Tax3 = new TextBox();
      this.Label_Tax3 = new Label();
      this.Label_Tax1 = new Label();
      this.TextBox_Tax1 = new TextBox();
      this.TextBox_Tax2 = new TextBox();
      this.Label_Tax2 = new Label();
      this.Button_GoOut = new Button();
      this.Button_Save = new Button();
      this.Button_PathBackUp = new Button();
      this.TextBox_PathBackup = new TextBox();
      this.Label_WithStore = new Label();
      this.CheckBox_WithStore = new CheckBox();
      this.DirectorySearcher_Path = new DirectorySearcher();
      this.FolderBrowserDialog1 = new FolderBrowserDialog();
      this.OpenFileDialog_SearchPath = new OpenFileDialog();
      this.FolderBrowserDialog_SearchPath = new FolderBrowserDialog();
      this.CheckBox_UnloadDirect = new CheckBox();
      this.Label_UnloadDirects = new Label();
      this.HeaderPanel1 = new HeaderPanel();
      this.Label30 = new Label();
      this.Label29 = new Label();
      this.Label28 = new Label();
      this.Label27 = new Label();
      this.Label26 = new Label();
      this.Label25 = new Label();
      this.Label24 = new Label();
      this.TextBox_Email = new MaskedTextBox();
      this.TextBox_WebPage = new MaskedTextBox();
      this.HeaderPanel_DonwloadOption = new HeaderPanel();
      this.HeaderPanel3 = new HeaderPanel();
      this.tcRuta = new TabControl();
      this.TabPage1 = new TabPage();
      this.TabPage2 = new TabPage();
      this.txtRutaFotoCliente = new TextBox();
      this.btnFotoCliente = new Button();
      this.tbcVariables = new TabControl();
      this.tpgPrincipal = new TabPage();
      this.CheckBox_IsVendedorTransfMesa = new CheckBox();
      this.CheckBox_SubGroupOrder = new CheckBox();
      this.CheckBox_IsNotVendedorTransfMesa = new CheckBox();
      this.Label14 = new Label();
      this.Label31 = new Label();
      this.Label9 = new Label();
      this.CheckBox_IsPreguntarComanda = new CheckBox();
      this.CheckBox_NotSubGroupOrder = new CheckBox();
      this.CheckBox_IsNotPreguntarComanda = new CheckBox();
      this.Label3 = new Label();
      this.Label23 = new Label();
      this.CheckBox_IsNotPrintCentral = new CheckBox();
      this.ComboBox_NroSubmesas = new ComboBox();
      this.CheckBox_IsPrintCentral = new CheckBox();
      this.Label21 = new Label();
      this.Label4 = new Label();
      this.CheckBox_NroSubmesas = new CheckBox();
      this.CheckBox_NotPrintProducts = new CheckBox();
      this.CheckBox_NotNroSubmesas = new CheckBox();
      this.CheckBox_PrintProducts = new CheckBox();
      this.Label22 = new Label();
      this.Label5 = new Label();
      this.CheckBox_ShowTax = new CheckBox();
      this.CheckBox_NotShowOpcPrebill = new CheckBox();
      this.CheckBox_NotShowTax = new CheckBox();
      this.CheckBox_ShowOpcPrebill = new CheckBox();
      this.Label20 = new Label();
      this.Label7 = new Label();
      this.TextBox_DivCtaNum = new NumericTextBox.NumericTextBox();
      this.CheckBox_NotIsDiscountClients = new CheckBox();
      this.TextBox_PersonNum = new NumericTextBox.NumericTextBox();
      this.CheckBox_IsDiscountClients = new CheckBox();
      this.TextBox_AmountUsePoints = new NumericTextBox.NumericTextBox();
      this.Label8 = new Label();
      this.Label18 = new Label();
      this.CheckBox_NotIsUsePoints = new CheckBox();
      this.Label19 = new Label();
      this.CheckBox_IsUsePoints = new CheckBox();
      this.CheckBox_IsDivCtaNum = new CheckBox();
      this.Label10 = new Label();
      this.CheckBox_IsNotDivCtaNum = new CheckBox();
      this.Label11 = new Label();
      this.Label17 = new Label();
      this.ComboBox_MonthExpiredPoints = new ComboBox();
      this.CheckBox_IsPersonNum = new CheckBox();
      this.Label12 = new Label();
      this.CheckBox_IsNotPersonNum = new CheckBox();
      this.CheckBox_NotShowOffer = new CheckBox();
      this.Label16 = new Label();
      this.CheckBox_ShowOffer = new CheckBox();
      this.CheckBox_IsPayThenCommnand = new CheckBox();
      this.Label13 = new Label();
      this.CheckBox_IsNotPayThenCommnand = new CheckBox();
      this.CheckBox_IsNotPrintPrecountSend = new CheckBox();
      this.Label15 = new Label();
      this.CheckBox_IsPrintPrecountSend = new CheckBox();
      this.CheckBox_IsDeleteItemNotSend = new CheckBox();
      this.CheckBox_IsNotDeleteItemNotSend = new CheckBox();
      this.tpgSegundo = new TabPage();
      this.CheckBox_DescuentoProgramado = new CheckBox();
      this.CheckBox_NoDescuentoProgramado = new CheckBox();
      this.Label36 = new Label();
      this.CheckBox_PermisoAdminReimpPrecuenta = new CheckBox();
      this.CheckBox_NoPermisoAdminReimpPrecuenta = new CheckBox();
      this.Label35 = new Label();
      this.CheckBox_PermisoAdminReimpComanda = new CheckBox();
      this.CheckBox_NoPermisoAdminReimpComanda = new CheckBox();
      this.Label34 = new Label();
      this.CheckBox_IsSalirTomadoralEnviar = new CheckBox();
      this.CheckBox_NotIsSalirTomadoralEnviar = new CheckBox();
      this.Label32 = new Label();
      this.CheckBox_IsExigeEnvioComanda = new CheckBox();
      this.CheckBox_NotIsExigeEnvioComanda = new CheckBox();
      this.Label33 = new Label();
      this.tgpTercero = new TabPage();
      this.Button_SaveImpuesto = new Button();
      this.GroupBox_Price3 = new GroupBox();
      this.CheckBox_Tax3_03 = new CheckBox();
      this.CheckBox_Tax2_03 = new CheckBox();
      this.CheckBox_Tax1_03 = new CheckBox();
      this.GroupBox_Price2 = new GroupBox();
      this.CheckBox_Tax3_02 = new CheckBox();
      this.CheckBox_Tax2_02 = new CheckBox();
      this.CheckBox_Tax1_02 = new CheckBox();
      this.GroupBox_Price1 = new GroupBox();
      this.CheckBox_Tax3_01 = new CheckBox();
      this.CheckBox_Tax2_01 = new CheckBox();
      this.CheckBox_Tax1_01 = new CheckBox();
      this.HeaderPanel4 = new HeaderPanel();
      this.Button_TNS = new Button();
      this.TextBox_MessageCommand = new TextBox();
      this.Label6 = new Label();
      this.TextBox_CommandTwo = new TextBox();
      this.TextBox_CommandOne = new TextBox();
      this.Label2 = new Label();
      this.Label1 = new Label();
      this.HeaderPanel2 = new HeaderPanel();
      this.btnConfigurarCorreo = new Button();
      ((Control) this.HeaderPanel1).SuspendLayout();
      ((Control) this.HeaderPanel_DonwloadOption).SuspendLayout();
      ((Control) this.HeaderPanel3).SuspendLayout();
      this.tcRuta.SuspendLayout();
      this.TabPage1.SuspendLayout();
      this.TabPage2.SuspendLayout();
      this.tbcVariables.SuspendLayout();
      this.tpgPrincipal.SuspendLayout();
      this.tpgSegundo.SuspendLayout();
      this.tgpTercero.SuspendLayout();
      this.GroupBox_Price3.SuspendLayout();
      this.GroupBox_Price2.SuspendLayout();
      this.GroupBox_Price1.SuspendLayout();
      ((Control) this.HeaderPanel4).SuspendLayout();
      ((Control) this.HeaderPanel2).SuspendLayout();
      this.SuspendLayout();
      this.Label_SocialReason.AutoSize = true;
      this.Label_SocialReason.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Label_SocialReason.ForeColor = Color.FromArgb(150, 150, 150);
      this.Label_SocialReason.Location = new Point(3, 40);
      this.Label_SocialReason.Name = "Label_SocialReason";
      this.Label_SocialReason.Size = new Size(88, 16);
      this.Label_SocialReason.TabIndex = 141;
      this.Label_SocialReason.Tag = (object) "Res_SocialReason";
      this.Label_SocialReason.Text = "Razón Social";
      this.TextBox_SocialReason.BackColor = Color.LightGray;
      this.TextBox_SocialReason.BorderStyle = BorderStyle.FixedSingle;
      this.TextBox_SocialReason.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.TextBox_SocialReason.ForeColor = Color.FromArgb(150, 150, 150);
      this.TextBox_SocialReason.Location = new Point(143, 33);
      this.TextBox_SocialReason.MaxLength = 150;
      this.TextBox_SocialReason.Multiline = true;
      this.TextBox_SocialReason.Name = "TextBox_SocialReason";
      this.TextBox_SocialReason.ReadOnly = true;
      this.TextBox_SocialReason.ScrollBars = ScrollBars.Vertical;
      this.TextBox_SocialReason.Size = new Size(305, 45);
      this.TextBox_SocialReason.TabIndex = 1;
      this.Label_CommercialReason.AutoSize = true;
      this.Label_CommercialReason.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Label_CommercialReason.ForeColor = Color.FromArgb(150, 150, 150);
      this.Label_CommercialReason.Location = new Point(3, 84);
      this.Label_CommercialReason.Name = "Label_CommercialReason";
      this.Label_CommercialReason.Size = new Size(111, 16);
      this.Label_CommercialReason.TabIndex = 143;
      this.Label_CommercialReason.Tag = (object) "Res_CommercialReasons";
      this.Label_CommercialReason.Text = "Razón Comercial";
      this.TextBox_CommercialReason.BorderStyle = BorderStyle.FixedSingle;
      this.TextBox_CommercialReason.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.TextBox_CommercialReason.ForeColor = Color.FromArgb(150, 150, 150);
      this.TextBox_CommercialReason.Location = new Point(143, 81);
      this.TextBox_CommercialReason.MaxLength = 150;
      this.TextBox_CommercialReason.Multiline = true;
      this.TextBox_CommercialReason.Name = "TextBox_CommercialReason";
      this.TextBox_CommercialReason.ScrollBars = ScrollBars.Vertical;
      this.TextBox_CommercialReason.Size = new Size(305, 45);
      this.TextBox_CommercialReason.TabIndex = 2;
      this.Label_Address.AutoSize = true;
      this.Label_Address.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Label_Address.ForeColor = Color.FromArgb(150, 150, 150);
      this.Label_Address.Location = new Point(3, 132);
      this.Label_Address.Name = "Label_Address";
      this.Label_Address.Size = new Size(65, 16);
      this.Label_Address.TabIndex = 145;
      this.Label_Address.Tag = (object) "Res_Address_";
      this.Label_Address.Text = "Dirección";
      this.TextBox_Address.BorderStyle = BorderStyle.FixedSingle;
      this.TextBox_Address.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.TextBox_Address.ForeColor = Color.FromArgb(150, 150, 150);
      this.TextBox_Address.Location = new Point(143, 129);
      this.TextBox_Address.MaxLength = 100;
      this.TextBox_Address.Multiline = true;
      this.TextBox_Address.Name = "TextBox_Address";
      this.TextBox_Address.ScrollBars = ScrollBars.Vertical;
      this.TextBox_Address.Size = new Size(305, 45);
      this.TextBox_Address.TabIndex = 4;
      this.Label_Email.AutoSize = true;
      this.Label_Email.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Label_Email.ForeColor = Color.FromArgb(150, 150, 150);
      this.Label_Email.Location = new Point(3, 208);
      this.Label_Email.Name = "Label_Email";
      this.Label_Email.Size = new Size(49, 16);
      this.Label_Email.TabIndex = 147;
      this.Label_Email.Tag = (object) "Res_Email_";
      this.Label_Email.Text = "Correo";
      this.Label_PhoneNumber.AutoSize = true;
      this.Label_PhoneNumber.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Label_PhoneNumber.ForeColor = Color.FromArgb(150, 150, 150);
      this.Label_PhoneNumber.Location = new Point(3, 180);
      this.Label_PhoneNumber.Name = "Label_PhoneNumber";
      this.Label_PhoneNumber.Size = new Size(62, 16);
      this.Label_PhoneNumber.TabIndex = 149;
      this.Label_PhoneNumber.Tag = (object) "Res_Phone_";
      this.Label_PhoneNumber.Text = "Teléfono";
      this.TextBox_PhoneNumber.BorderStyle = BorderStyle.FixedSingle;
      this.TextBox_PhoneNumber.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.TextBox_PhoneNumber.ForeColor = Color.FromArgb(150, 150, 150);
      this.TextBox_PhoneNumber.Location = new Point(143, 177);
      this.TextBox_PhoneNumber.MaxLength = 20;
      this.TextBox_PhoneNumber.Multiline = true;
      this.TextBox_PhoneNumber.Name = "TextBox_PhoneNumber";
      this.TextBox_PhoneNumber.Size = new Size(305, 20);
      this.TextBox_PhoneNumber.TabIndex = 6;
      this.Label_WebPage.AutoSize = true;
      this.Label_WebPage.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Label_WebPage.ForeColor = Color.FromArgb(150, 150, 150);
      this.Label_WebPage.Location = new Point(3, 236);
      this.Label_WebPage.Name = "Label_WebPage";
      this.Label_WebPage.Size = new Size(63, 16);
      this.Label_WebPage.TabIndex = 151;
      this.Label_WebPage.Tag = (object) "Res_WebSite";
      this.Label_WebPage.Text = "Web Site";
      this.Label_TributaryId.AutoSize = true;
      this.Label_TributaryId.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Label_TributaryId.ForeColor = Color.FromArgb(150, 150, 150);
      this.Label_TributaryId.Location = new Point(3, 8);
      this.Label_TributaryId.Name = "Label_TributaryId";
      this.Label_TributaryId.Size = new Size(96, 16);
      this.Label_TributaryId.TabIndex = 157;
      this.Label_TributaryId.Tag = (object) "Res_TaxCode";
      this.Label_TributaryId.Text = "Cod. Tributario";
      this.TextBox_TributaryId.BackColor = Color.LightGray;
      this.TextBox_TributaryId.BorderStyle = BorderStyle.FixedSingle;
      this.TextBox_TributaryId.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.TextBox_TributaryId.ForeColor = Color.FromArgb(150, 150, 150);
      this.TextBox_TributaryId.Location = new Point(143, 5);
      this.TextBox_TributaryId.MaxLength = 20;
      this.TextBox_TributaryId.Multiline = true;
      this.TextBox_TributaryId.Name = "TextBox_TributaryId";
      this.TextBox_TributaryId.ReadOnly = true;
      this.TextBox_TributaryId.Size = new Size(305, 20);
      this.TextBox_TributaryId.TabIndex = 3;
      this.TextBox_TributaryId.TextAlign = HorizontalAlignment.Center;
      this.Label_Yes.AutoSize = true;
      this.Label_Yes.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Label_Yes.ForeColor = Color.FromArgb(209, 102, 61);
      this.Label_Yes.Location = new Point(418, 2);
      this.Label_Yes.Name = "Label_Yes";
      this.Label_Yes.Size = new Size(27, 16);
      this.Label_Yes.TabIndex = 167;
      this.Label_Yes.Text = "Sí?";
      this.CheckBox_Tax3.Appearance = Appearance.Button;
      this.CheckBox_Tax3.AutoSize = true;
      this.CheckBox_Tax3.FlatAppearance.CheckedBackColor = Color.NavajoWhite;
      this.CheckBox_Tax3.FlatAppearance.MouseDownBackColor = Color.NavajoWhite;
      this.CheckBox_Tax3.FlatStyle = FlatStyle.Flat;
      this.CheckBox_Tax3.Font = new Font("Trebuchet MS", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.CheckBox_Tax3.Image = (Image) componentResourceManager.GetObject("CheckBox_Tax3.Image");
      this.CheckBox_Tax3.Location = new Point(410, 78);
      this.CheckBox_Tax3.Name = "CheckBox_Tax3";
      this.CheckBox_Tax3.Size = new Size(39, 33);
      this.CheckBox_Tax3.TabIndex = 8;
      this.CheckBox_Tax3.Text = "    ";
      this.CheckBox_Tax3.UseVisualStyleBackColor = true;
      this.CheckBox_Tax2.Appearance = Appearance.Button;
      this.CheckBox_Tax2.AutoSize = true;
      this.CheckBox_Tax2.FlatAppearance.CheckedBackColor = Color.NavajoWhite;
      this.CheckBox_Tax2.FlatAppearance.MouseDownBackColor = Color.NavajoWhite;
      this.CheckBox_Tax2.FlatStyle = FlatStyle.Flat;
      this.CheckBox_Tax2.Font = new Font("Trebuchet MS", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.CheckBox_Tax2.Image = (Image) componentResourceManager.GetObject("CheckBox_Tax2.Image");
      this.CheckBox_Tax2.Location = new Point(410, 49);
      this.CheckBox_Tax2.Name = "CheckBox_Tax2";
      this.CheckBox_Tax2.Size = new Size(39, 33);
      this.CheckBox_Tax2.TabIndex = 5;
      this.CheckBox_Tax2.Text = "    ";
      this.CheckBox_Tax2.UseVisualStyleBackColor = true;
      this.CheckBox_Tax1.Appearance = Appearance.Button;
      this.CheckBox_Tax1.AutoSize = true;
      this.CheckBox_Tax1.FlatAppearance.CheckedBackColor = Color.NavajoWhite;
      this.CheckBox_Tax1.FlatAppearance.MouseDownBackColor = Color.NavajoWhite;
      this.CheckBox_Tax1.FlatStyle = FlatStyle.Flat;
      this.CheckBox_Tax1.Font = new Font("Trebuchet MS", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.CheckBox_Tax1.Image = (Image) componentResourceManager.GetObject("CheckBox_Tax1.Image");
      this.CheckBox_Tax1.Location = new Point(410, 19);
      this.CheckBox_Tax1.Name = "CheckBox_Tax1";
      this.CheckBox_Tax1.Size = new Size(39, 33);
      this.CheckBox_Tax1.TabIndex = 2;
      this.CheckBox_Tax1.Text = "    ";
      this.CheckBox_Tax1.UseVisualStyleBackColor = true;
      this.Label_Value.AutoSize = true;
      this.Label_Value.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Label_Value.ForeColor = Color.FromArgb(209, 102, 61);
      this.Label_Value.Location = new Point(285, 2);
      this.Label_Value.Name = "Label_Value";
      this.Label_Value.Size = new Size(55, 16);
      this.Label_Value.TabIndex = 163;
      this.Label_Value.Text = "Valor %";
      this.Label_Description.AutoSize = true;
      this.Label_Description.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Label_Description.ForeColor = Color.FromArgb(209, 102, 61);
      this.Label_Description.Location = new Point(108, 2);
      this.Label_Description.Name = "Label_Description";
      this.Label_Description.Size = new Size(80, 16);
      this.Label_Description.TabIndex = 162;
      this.Label_Description.Text = "Descripción";
      this.NumericTexBox_Tax3.set_AllowSpace(false);
      ((TextBoxBase) this.NumericTexBox_Tax3).BackColor = Color.White;
      ((TextBoxBase) this.NumericTexBox_Tax3).BorderStyle = BorderStyle.FixedSingle;
      ((Control) this.NumericTexBox_Tax3).Font = new Font("Trebuchet MS", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      ((TextBoxBase) this.NumericTexBox_Tax3).ForeColor = Color.Red;
      ((Control) this.NumericTexBox_Tax3).Location = new Point(289, 82);
      ((TextBox) this.NumericTexBox_Tax3).Multiline = true;
      ((Control) this.NumericTexBox_Tax3).Name = "NumericTexBox_Tax3";
      ((Control) this.NumericTexBox_Tax3).Size = new Size(110, 25);
      ((Control) this.NumericTexBox_Tax3).TabIndex = 7;
      ((TextBox) this.NumericTexBox_Tax3).TextAlign = HorizontalAlignment.Right;
      this.NumericTexBox_Tax2.set_AllowSpace(false);
      ((TextBoxBase) this.NumericTexBox_Tax2).BackColor = Color.White;
      ((TextBoxBase) this.NumericTexBox_Tax2).BorderStyle = BorderStyle.FixedSingle;
      ((Control) this.NumericTexBox_Tax2).Font = new Font("Trebuchet MS", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      ((TextBoxBase) this.NumericTexBox_Tax2).ForeColor = Color.Red;
      ((Control) this.NumericTexBox_Tax2).Location = new Point(289, 53);
      ((TextBox) this.NumericTexBox_Tax2).Multiline = true;
      ((Control) this.NumericTexBox_Tax2).Name = "NumericTexBox_Tax2";
      ((Control) this.NumericTexBox_Tax2).Size = new Size(110, 25);
      ((Control) this.NumericTexBox_Tax2).TabIndex = 4;
      ((TextBox) this.NumericTexBox_Tax2).TextAlign = HorizontalAlignment.Right;
      this.NumericTexBox_Tax1.set_AllowSpace(false);
      ((TextBoxBase) this.NumericTexBox_Tax1).BackColor = Color.White;
      ((TextBoxBase) this.NumericTexBox_Tax1).BorderStyle = BorderStyle.FixedSingle;
      ((Control) this.NumericTexBox_Tax1).Font = new Font("Trebuchet MS", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      ((TextBoxBase) this.NumericTexBox_Tax1).ForeColor = Color.Red;
      ((Control) this.NumericTexBox_Tax1).Location = new Point(289, 24);
      ((TextBox) this.NumericTexBox_Tax1).Multiline = true;
      ((Control) this.NumericTexBox_Tax1).Name = "NumericTexBox_Tax1";
      ((Control) this.NumericTexBox_Tax1).Size = new Size(110, 25);
      ((Control) this.NumericTexBox_Tax1).TabIndex = 1;
      ((TextBox) this.NumericTexBox_Tax1).TextAlign = HorizontalAlignment.Right;
      this.TextBox_Tax3.BorderStyle = BorderStyle.FixedSingle;
      this.TextBox_Tax3.Font = new Font("Trebuchet MS", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.TextBox_Tax3.ForeColor = Color.Red;
      this.TextBox_Tax3.Location = new Point(109, 82);
      this.TextBox_Tax3.Multiline = true;
      this.TextBox_Tax3.Name = "TextBox_Tax3";
      this.TextBox_Tax3.Size = new Size(170, 25);
      this.TextBox_Tax3.TabIndex = 6;
      this.Label_Tax3.AutoSize = true;
      this.Label_Tax3.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Label_Tax3.ForeColor = Color.FromArgb(150, 150, 150);
      this.Label_Tax3.Location = new Point(3, 85);
      this.Label_Tax3.Name = "Label_Tax3";
      this.Label_Tax3.Size = new Size(58, 16);
      this.Label_Tax3.TabIndex = 157;
      this.Label_Tax3.Text = "Cargo 3:";
      this.Label_Tax1.AutoSize = true;
      this.Label_Tax1.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Label_Tax1.ForeColor = Color.FromArgb(150, 150, 150);
      this.Label_Tax1.Location = new Point(3, 27);
      this.Label_Tax1.Name = "Label_Tax1";
      this.Label_Tax1.Size = new Size(58, 16);
      this.Label_Tax1.TabIndex = 141;
      this.Label_Tax1.Text = "Cargo 1:";
      this.TextBox_Tax1.BorderStyle = BorderStyle.FixedSingle;
      this.TextBox_Tax1.Font = new Font("Trebuchet MS", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.TextBox_Tax1.ForeColor = Color.Red;
      this.TextBox_Tax1.Location = new Point(109, 24);
      this.TextBox_Tax1.Multiline = true;
      this.TextBox_Tax1.Name = "TextBox_Tax1";
      this.TextBox_Tax1.Size = new Size(170, 25);
      this.TextBox_Tax1.TabIndex = 0;
      this.TextBox_Tax2.BorderStyle = BorderStyle.FixedSingle;
      this.TextBox_Tax2.Font = new Font("Trebuchet MS", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.TextBox_Tax2.ForeColor = Color.Red;
      this.TextBox_Tax2.Location = new Point(109, 53);
      this.TextBox_Tax2.Multiline = true;
      this.TextBox_Tax2.Name = "TextBox_Tax2";
      this.TextBox_Tax2.Size = new Size(170, 25);
      this.TextBox_Tax2.TabIndex = 3;
      this.Label_Tax2.AutoSize = true;
      this.Label_Tax2.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Label_Tax2.ForeColor = Color.FromArgb(150, 150, 150);
      this.Label_Tax2.Location = new Point(3, 56);
      this.Label_Tax2.Name = "Label_Tax2";
      this.Label_Tax2.Size = new Size(58, 16);
      this.Label_Tax2.TabIndex = 143;
      this.Label_Tax2.Text = "Cargo 2:";
      this.Button_GoOut.BackgroundImage = (Image) TriNetRestPOS.My.Resources.Resources.BotonRojo;
      this.Button_GoOut.FlatStyle = FlatStyle.Flat;
      this.Button_GoOut.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Button_GoOut.ForeColor = Color.WhiteSmoke;
      this.Button_GoOut.Image = (Image) TriNetRestPOS.My.Resources.Resources.salir;
      this.Button_GoOut.ImageAlign = ContentAlignment.TopCenter;
      this.Button_GoOut.Location = new Point(884, 655);
      this.Button_GoOut.Name = "Button_GoOut";
      this.Button_GoOut.Padding = new Padding(0, 5, 0, 5);
      this.Button_GoOut.Size = new Size(114, 60);
      this.Button_GoOut.TabIndex = 2;
      this.Button_GoOut.Text = "Salir";
      this.Button_GoOut.TextAlign = ContentAlignment.BottomCenter;
      this.Button_GoOut.UseVisualStyleBackColor = true;
      this.Button_Save.BackgroundImage = (Image) TriNetRestPOS.My.Resources.Resources.BotonVerde;
      this.Button_Save.FlatStyle = FlatStyle.Flat;
      this.Button_Save.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Button_Save.ForeColor = Color.WhiteSmoke;
      this.Button_Save.Image = (Image) TriNetRestPOS.My.Resources.Resources.check_OK;
      this.Button_Save.ImageAlign = ContentAlignment.TopCenter;
      this.Button_Save.Location = new Point(762, 655);
      this.Button_Save.Name = "Button_Save";
      this.Button_Save.Padding = new Padding(0, 5, 0, 5);
      this.Button_Save.Size = new Size(119, 60);
      this.Button_Save.TabIndex = 1;
      this.Button_Save.Text = "Guardar";
      this.Button_Save.TextAlign = ContentAlignment.BottomCenter;
      this.Button_Save.UseVisualStyleBackColor = true;
      this.Button_PathBackUp.BackgroundImage = (Image) TriNetRestPOS.My.Resources.Resources.ruta_boton;
      this.Button_PathBackUp.FlatStyle = FlatStyle.Flat;
      this.Button_PathBackUp.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Button_PathBackUp.Location = new Point(463, 2);
      this.Button_PathBackUp.Name = "Button_PathBackUp";
      this.Button_PathBackUp.Size = new Size(62, 52);
      this.Button_PathBackUp.TabIndex = 2;
      this.Button_PathBackUp.Text = "Ruta";
      this.Button_PathBackUp.UseVisualStyleBackColor = true;
      this.TextBox_PathBackup.BorderStyle = BorderStyle.FixedSingle;
      this.TextBox_PathBackup.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.TextBox_PathBackup.ForeColor = Color.FromArgb(209, 102, 61);
      this.TextBox_PathBackup.Location = new Point(4, 3);
      this.TextBox_PathBackup.MaxLength = 200;
      this.TextBox_PathBackup.Multiline = true;
      this.TextBox_PathBackup.Name = "TextBox_PathBackup";
      this.TextBox_PathBackup.ScrollBars = ScrollBars.Vertical;
      this.TextBox_PathBackup.Size = new Size(458, 45);
      this.TextBox_PathBackup.TabIndex = 1;
      this.Label_WithStore.AutoSize = true;
      this.Label_WithStore.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Label_WithStore.ForeColor = Color.FromArgb(209, 102, 61);
      this.Label_WithStore.Location = new Point(7, 13);
      this.Label_WithStore.Name = "Label_WithStore";
      this.Label_WithStore.Size = new Size(139, 16);
      this.Label_WithStore.TabIndex = 167;
      this.Label_WithStore.Text = "Con TriNetRestStore?";
      this.CheckBox_WithStore.Appearance = Appearance.Button;
      this.CheckBox_WithStore.AutoSize = true;
      this.CheckBox_WithStore.FlatAppearance.CheckedBackColor = Color.NavajoWhite;
      this.CheckBox_WithStore.FlatAppearance.MouseDownBackColor = Color.NavajoWhite;
      this.CheckBox_WithStore.FlatStyle = FlatStyle.Flat;
      this.CheckBox_WithStore.Font = new Font("Trebuchet MS", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.CheckBox_WithStore.Image = (Image) componentResourceManager.GetObject("CheckBox_WithStore.Image");
      this.CheckBox_WithStore.Location = new Point(189, 8);
      this.CheckBox_WithStore.Name = "CheckBox_WithStore";
      this.CheckBox_WithStore.Size = new Size(39, 33);
      this.CheckBox_WithStore.TabIndex = 1;
      this.CheckBox_WithStore.Text = "    ";
      this.CheckBox_WithStore.UseVisualStyleBackColor = true;
      this.DirectorySearcher_Path.ClientTimeout = TimeSpan.Parse("-00:00:01");
      this.DirectorySearcher_Path.ServerPageTimeLimit = TimeSpan.Parse("-00:00:01");
      this.DirectorySearcher_Path.ServerTimeLimit = TimeSpan.Parse("-00:00:01");
      this.OpenFileDialog_SearchPath.FileName = "OpenFileDialog1";
      this.CheckBox_UnloadDirect.Appearance = Appearance.Button;
      this.CheckBox_UnloadDirect.AutoSize = true;
      this.CheckBox_UnloadDirect.FlatAppearance.CheckedBackColor = Color.NavajoWhite;
      this.CheckBox_UnloadDirect.FlatAppearance.MouseDownBackColor = Color.NavajoWhite;
      this.CheckBox_UnloadDirect.FlatStyle = FlatStyle.Flat;
      this.CheckBox_UnloadDirect.Font = new Font("Trebuchet MS", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.CheckBox_UnloadDirect.Image = (Image) componentResourceManager.GetObject("CheckBox_UnloadDirect.Image");
      this.CheckBox_UnloadDirect.Location = new Point(411, 8);
      this.CheckBox_UnloadDirect.Name = "CheckBox_UnloadDirect";
      this.CheckBox_UnloadDirect.Size = new Size(39, 33);
      this.CheckBox_UnloadDirect.TabIndex = 2;
      this.CheckBox_UnloadDirect.Text = "    ";
      this.CheckBox_UnloadDirect.UseVisualStyleBackColor = true;
      this.Label_UnloadDirects.AutoSize = true;
      this.Label_UnloadDirects.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Label_UnloadDirects.ForeColor = Color.FromArgb(150, 150, 150);
      this.Label_UnloadDirects.Location = new Point((int) byte.MaxValue, 3);
      this.Label_UnloadDirects.Name = "Label_UnloadDirects";
      this.Label_UnloadDirects.Size = new Size(128, 32);
      this.Label_UnloadDirects.TabIndex = 169;
      this.Label_UnloadDirects.Text = "Descargar Directos \r\nOnline?";
      this.HeaderPanel1.set_BorderColor(SystemColors.ActiveCaption);
      this.HeaderPanel1.set_BorderStyle((BorderStyles) 1);
      this.HeaderPanel1.set_CaptionBeginColor(Color.FromArgb(209, 102, 61));
      this.HeaderPanel1.set_CaptionEndColor(Color.FromArgb(209, 102, 61));
      this.HeaderPanel1.set_CaptionGradientDirection(LinearGradientMode.Vertical);
      this.HeaderPanel1.set_CaptionHeight(26);
      this.HeaderPanel1.set_CaptionPosition((CaptionPositions) 0);
      this.HeaderPanel1.set_CaptionText("Atributos del Negocio");
      this.HeaderPanel1.set_CaptionVisible(true);
      ((Control) this.HeaderPanel1).Controls.Add((Control) this.Label30);
      ((Control) this.HeaderPanel1).Controls.Add((Control) this.Label29);
      ((Control) this.HeaderPanel1).Controls.Add((Control) this.Label28);
      ((Control) this.HeaderPanel1).Controls.Add((Control) this.Label27);
      ((Control) this.HeaderPanel1).Controls.Add((Control) this.Label26);
      ((Control) this.HeaderPanel1).Controls.Add((Control) this.Label25);
      ((Control) this.HeaderPanel1).Controls.Add((Control) this.Label24);
      ((Control) this.HeaderPanel1).Controls.Add((Control) this.TextBox_Email);
      ((Control) this.HeaderPanel1).Controls.Add((Control) this.TextBox_WebPage);
      ((Control) this.HeaderPanel1).Controls.Add((Control) this.Label_Email);
      ((Control) this.HeaderPanel1).Controls.Add((Control) this.Label_SocialReason);
      ((Control) this.HeaderPanel1).Controls.Add((Control) this.TextBox_TributaryId);
      ((Control) this.HeaderPanel1).Controls.Add((Control) this.Label_CommercialReason);
      ((Control) this.HeaderPanel1).Controls.Add((Control) this.TextBox_Address);
      ((Control) this.HeaderPanel1).Controls.Add((Control) this.TextBox_PhoneNumber);
      ((Control) this.HeaderPanel1).Controls.Add((Control) this.Label_TributaryId);
      ((Control) this.HeaderPanel1).Controls.Add((Control) this.Label_WebPage);
      ((Control) this.HeaderPanel1).Controls.Add((Control) this.TextBox_CommercialReason);
      ((Control) this.HeaderPanel1).Controls.Add((Control) this.TextBox_SocialReason);
      ((Control) this.HeaderPanel1).Controls.Add((Control) this.Label_Address);
      ((Control) this.HeaderPanel1).Controls.Add((Control) this.Label_PhoneNumber);
      this.HeaderPanel1.set_Font(new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0));
      ((Control) this.HeaderPanel1).ForeColor = Color.WhiteSmoke;
      this.HeaderPanel1.set_GradientDirection(LinearGradientMode.Vertical);
      this.HeaderPanel1.set_GradientEnd(SystemColors.Window);
      this.HeaderPanel1.set_GradientStart(SystemColors.Window);
      ((Control) this.HeaderPanel1).Location = new Point(0, 0);
      ((Control) this.HeaderPanel1).Name = "HeaderPanel1";
      this.HeaderPanel1.set_PanelIcon((Icon) null);
      this.HeaderPanel1.set_PanelIconVisible(false);
      ((Control) this.HeaderPanel1).Size = new Size(460, 290);
      ((Control) this.HeaderPanel1).TabIndex = 188;
      this.HeaderPanel1.set_TextAntialias(true);
      this.Label30.AutoSize = true;
      this.Label30.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Label30.ForeColor = Color.FromArgb(150, 150, 150);
      this.Label30.Location = new Point(125, 8);
      this.Label30.Name = "Label30";
      this.Label30.Size = new Size(11, 16);
      this.Label30.TabIndex = 166;
      this.Label30.Tag = (object) "";
      this.Label30.Text = ":";
      this.Label29.AutoSize = true;
      this.Label29.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Label29.ForeColor = Color.FromArgb(150, 150, 150);
      this.Label29.Location = new Point(125, 40);
      this.Label29.Name = "Label29";
      this.Label29.Size = new Size(11, 16);
      this.Label29.TabIndex = 165;
      this.Label29.Tag = (object) "";
      this.Label29.Text = ":";
      this.Label28.AutoSize = true;
      this.Label28.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Label28.ForeColor = Color.FromArgb(150, 150, 150);
      this.Label28.Location = new Point(125, 236);
      this.Label28.Name = "Label28";
      this.Label28.Size = new Size(11, 16);
      this.Label28.TabIndex = 164;
      this.Label28.Tag = (object) "";
      this.Label28.Text = ":";
      this.Label27.AutoSize = true;
      this.Label27.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Label27.ForeColor = Color.FromArgb(150, 150, 150);
      this.Label27.Location = new Point(125, 208);
      this.Label27.Name = "Label27";
      this.Label27.Size = new Size(11, 16);
      this.Label27.TabIndex = 163;
      this.Label27.Tag = (object) "";
      this.Label27.Text = ":";
      this.Label26.AutoSize = true;
      this.Label26.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Label26.ForeColor = Color.FromArgb(150, 150, 150);
      this.Label26.Location = new Point(125, 180);
      this.Label26.Name = "Label26";
      this.Label26.Size = new Size(11, 16);
      this.Label26.TabIndex = 162;
      this.Label26.Tag = (object) "";
      this.Label26.Text = ":";
      this.Label25.AutoSize = true;
      this.Label25.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Label25.ForeColor = Color.FromArgb(150, 150, 150);
      this.Label25.Location = new Point(125, 132);
      this.Label25.Name = "Label25";
      this.Label25.Size = new Size(11, 16);
      this.Label25.TabIndex = 161;
      this.Label25.Tag = (object) "";
      this.Label25.Text = ":";
      this.Label24.AutoSize = true;
      this.Label24.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Label24.ForeColor = Color.FromArgb(150, 150, 150);
      this.Label24.Location = new Point(125, 84);
      this.Label24.Name = "Label24";
      this.Label24.Size = new Size(11, 16);
      this.Label24.TabIndex = 160;
      this.Label24.Tag = (object) "";
      this.Label24.Text = ":";
      this.TextBox_Email.BorderStyle = BorderStyle.FixedSingle;
      this.TextBox_Email.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.TextBox_Email.ForeColor = Color.FromArgb(150, 150, 150);
      this.TextBox_Email.Location = new Point(143, 205);
      this.TextBox_Email.Name = "TextBox_Email";
      this.TextBox_Email.Size = new Size(305, 22);
      this.TextBox_Email.TabIndex = 159;
      this.TextBox_WebPage.BorderStyle = BorderStyle.FixedSingle;
      this.TextBox_WebPage.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.TextBox_WebPage.ForeColor = Color.FromArgb(150, 150, 150);
      this.TextBox_WebPage.Location = new Point(143, 233);
      this.TextBox_WebPage.Name = "TextBox_WebPage";
      this.TextBox_WebPage.Size = new Size(305, 22);
      this.TextBox_WebPage.TabIndex = 158;
      this.HeaderPanel_DonwloadOption.set_BorderColor(SystemColors.ActiveCaption);
      this.HeaderPanel_DonwloadOption.set_BorderStyle((BorderStyles) 1);
      this.HeaderPanel_DonwloadOption.set_CaptionBeginColor(Color.FromArgb(209, 102, 61));
      this.HeaderPanel_DonwloadOption.set_CaptionEndColor(Color.FromArgb(209, 102, 61));
      this.HeaderPanel_DonwloadOption.set_CaptionGradientDirection(LinearGradientMode.Vertical);
      this.HeaderPanel_DonwloadOption.set_CaptionHeight(26);
      this.HeaderPanel_DonwloadOption.set_CaptionPosition((CaptionPositions) 0);
      this.HeaderPanel_DonwloadOption.set_CaptionText("Opciones de Descarga");
      this.HeaderPanel_DonwloadOption.set_CaptionVisible(true);
      ((Control) this.HeaderPanel_DonwloadOption).Controls.Add((Control) this.CheckBox_UnloadDirect);
      ((Control) this.HeaderPanel_DonwloadOption).Controls.Add((Control) this.Label_UnloadDirects);
      ((Control) this.HeaderPanel_DonwloadOption).Controls.Add((Control) this.Label_WithStore);
      ((Control) this.HeaderPanel_DonwloadOption).Controls.Add((Control) this.CheckBox_WithStore);
      this.HeaderPanel_DonwloadOption.set_Font(new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0));
      ((Control) this.HeaderPanel_DonwloadOption).ForeColor = Color.WhiteSmoke;
      this.HeaderPanel_DonwloadOption.set_GradientDirection(LinearGradientMode.Vertical);
      this.HeaderPanel_DonwloadOption.set_GradientEnd(SystemColors.Window);
      this.HeaderPanel_DonwloadOption.set_GradientStart(SystemColors.Window);
      ((Control) this.HeaderPanel_DonwloadOption).Location = new Point(0, 428);
      ((Control) this.HeaderPanel_DonwloadOption).Name = "HeaderPanel_DonwloadOption";
      this.HeaderPanel_DonwloadOption.set_PanelIcon((Icon) null);
      this.HeaderPanel_DonwloadOption.set_PanelIconVisible(false);
      ((Control) this.HeaderPanel_DonwloadOption).Size = new Size(459, 75);
      ((Control) this.HeaderPanel_DonwloadOption).TabIndex = 189;
      this.HeaderPanel_DonwloadOption.set_TextAntialias(true);
      this.HeaderPanel3.set_BorderColor(SystemColors.ActiveCaption);
      this.HeaderPanel3.set_BorderStyle((BorderStyles) 1);
      this.HeaderPanel3.set_CaptionBeginColor(Color.FromArgb(209, 102, 61));
      this.HeaderPanel3.set_CaptionEndColor(Color.FromArgb(209, 102, 61));
      this.HeaderPanel3.set_CaptionGradientDirection(LinearGradientMode.Vertical);
      this.HeaderPanel3.set_CaptionHeight(26);
      this.HeaderPanel3.set_CaptionPosition((CaptionPositions) 0);
      this.HeaderPanel3.set_CaptionText("Atributos del Sistema");
      this.HeaderPanel3.set_CaptionVisible(true);
      ((Control) this.HeaderPanel3).Controls.Add((Control) this.tcRuta);
      ((Control) this.HeaderPanel3).Controls.Add((Control) this.tbcVariables);
      this.HeaderPanel3.set_Font(new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0));
      ((Control) this.HeaderPanel3).ForeColor = Color.WhiteSmoke;
      this.HeaderPanel3.set_GradientDirection(LinearGradientMode.Vertical);
      this.HeaderPanel3.set_GradientEnd(SystemColors.Window);
      this.HeaderPanel3.set_GradientStart(SystemColors.Window);
      ((Control) this.HeaderPanel3).Location = new Point(458, 0);
      ((Control) this.HeaderPanel3).Name = "HeaderPanel3";
      this.HeaderPanel3.set_PanelIcon((Icon) null);
      this.HeaderPanel3.set_PanelIconVisible(false);
      ((Control) this.HeaderPanel3).Size = new Size(552, 653);
      ((Control) this.HeaderPanel3).TabIndex = 190;
      this.HeaderPanel3.set_TextAntialias(true);
      this.tcRuta.Controls.Add((Control) this.TabPage1);
      this.tcRuta.Controls.Add((Control) this.TabPage2);
      this.tcRuta.Location = new Point(0, 3);
      this.tcRuta.Name = "tcRuta";
      this.tcRuta.SelectedIndex = 0;
      this.tcRuta.Size = new Size(548, 84);
      this.tcRuta.TabIndex = 482;
      this.TabPage1.Controls.Add((Control) this.TextBox_PathBackup);
      this.TabPage1.Controls.Add((Control) this.Button_PathBackUp);
      this.TabPage1.Location = new Point(4, 25);
      this.TabPage1.Name = "TabPage1";
      this.TabPage1.Padding = new Padding(3);
      this.TabPage1.Size = new Size(540, 55);
      this.TabPage1.TabIndex = 0;
      this.TabPage1.Text = "Backup";
      this.TabPage1.UseVisualStyleBackColor = true;
      this.TabPage2.Controls.Add((Control) this.txtRutaFotoCliente);
      this.TabPage2.Controls.Add((Control) this.btnFotoCliente);
      this.TabPage2.Location = new Point(4, 25);
      this.TabPage2.Name = "TabPage2";
      this.TabPage2.Padding = new Padding(3);
      this.TabPage2.Size = new Size(540, 55);
      this.TabPage2.TabIndex = 1;
      this.TabPage2.Text = "Fotos de Clientes";
      this.TabPage2.UseVisualStyleBackColor = true;
      this.txtRutaFotoCliente.BorderStyle = BorderStyle.FixedSingle;
      this.txtRutaFotoCliente.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.txtRutaFotoCliente.ForeColor = Color.FromArgb(209, 102, 61);
      this.txtRutaFotoCliente.Location = new Point(4, 3);
      this.txtRutaFotoCliente.MaxLength = 200;
      this.txtRutaFotoCliente.Multiline = true;
      this.txtRutaFotoCliente.Name = "txtRutaFotoCliente";
      this.txtRutaFotoCliente.ScrollBars = ScrollBars.Vertical;
      this.txtRutaFotoCliente.Size = new Size(458, 45);
      this.txtRutaFotoCliente.TabIndex = 3;
      this.btnFotoCliente.BackgroundImage = (Image) TriNetRestPOS.My.Resources.Resources.ruta_boton;
      this.btnFotoCliente.FlatStyle = FlatStyle.Flat;
      this.btnFotoCliente.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.btnFotoCliente.Location = new Point(463, 2);
      this.btnFotoCliente.Name = "btnFotoCliente";
      this.btnFotoCliente.Size = new Size(62, 52);
      this.btnFotoCliente.TabIndex = 4;
      this.btnFotoCliente.Text = "Ruta";
      this.btnFotoCliente.UseVisualStyleBackColor = true;
      this.tbcVariables.Controls.Add((Control) this.tpgPrincipal);
      this.tbcVariables.Controls.Add((Control) this.tpgSegundo);
      this.tbcVariables.Controls.Add((Control) this.tgpTercero);
      this.tbcVariables.Dock = DockStyle.Bottom;
      this.tbcVariables.Location = new Point(0, 85);
      this.tbcVariables.Name = "tbcVariables";
      this.tbcVariables.SelectedIndex = 0;
      this.tbcVariables.Size = new Size(550, 540);
      this.tbcVariables.TabIndex = 481;
      this.tpgPrincipal.BackColor = Color.White;
      this.tpgPrincipal.Controls.Add((Control) this.CheckBox_IsVendedorTransfMesa);
      this.tpgPrincipal.Controls.Add((Control) this.CheckBox_SubGroupOrder);
      this.tpgPrincipal.Controls.Add((Control) this.CheckBox_IsNotVendedorTransfMesa);
      this.tpgPrincipal.Controls.Add((Control) this.Label14);
      this.tpgPrincipal.Controls.Add((Control) this.Label31);
      this.tpgPrincipal.Controls.Add((Control) this.Label9);
      this.tpgPrincipal.Controls.Add((Control) this.CheckBox_IsPreguntarComanda);
      this.tpgPrincipal.Controls.Add((Control) this.CheckBox_NotSubGroupOrder);
      this.tpgPrincipal.Controls.Add((Control) this.CheckBox_IsNotPreguntarComanda);
      this.tpgPrincipal.Controls.Add((Control) this.Label3);
      this.tpgPrincipal.Controls.Add((Control) this.Label23);
      this.tpgPrincipal.Controls.Add((Control) this.CheckBox_IsNotPrintCentral);
      this.tpgPrincipal.Controls.Add((Control) this.ComboBox_NroSubmesas);
      this.tpgPrincipal.Controls.Add((Control) this.CheckBox_IsPrintCentral);
      this.tpgPrincipal.Controls.Add((Control) this.Label21);
      this.tpgPrincipal.Controls.Add((Control) this.Label4);
      this.tpgPrincipal.Controls.Add((Control) this.CheckBox_NroSubmesas);
      this.tpgPrincipal.Controls.Add((Control) this.CheckBox_NotPrintProducts);
      this.tpgPrincipal.Controls.Add((Control) this.CheckBox_NotNroSubmesas);
      this.tpgPrincipal.Controls.Add((Control) this.CheckBox_PrintProducts);
      this.tpgPrincipal.Controls.Add((Control) this.Label22);
      this.tpgPrincipal.Controls.Add((Control) this.Label5);
      this.tpgPrincipal.Controls.Add((Control) this.CheckBox_ShowTax);
      this.tpgPrincipal.Controls.Add((Control) this.CheckBox_NotShowOpcPrebill);
      this.tpgPrincipal.Controls.Add((Control) this.CheckBox_NotShowTax);
      this.tpgPrincipal.Controls.Add((Control) this.CheckBox_ShowOpcPrebill);
      this.tpgPrincipal.Controls.Add((Control) this.Label20);
      this.tpgPrincipal.Controls.Add((Control) this.Label7);
      this.tpgPrincipal.Controls.Add((Control) this.TextBox_DivCtaNum);
      this.tpgPrincipal.Controls.Add((Control) this.CheckBox_NotIsDiscountClients);
      this.tpgPrincipal.Controls.Add((Control) this.TextBox_PersonNum);
      this.tpgPrincipal.Controls.Add((Control) this.CheckBox_IsDiscountClients);
      this.tpgPrincipal.Controls.Add((Control) this.TextBox_AmountUsePoints);
      this.tpgPrincipal.Controls.Add((Control) this.Label8);
      this.tpgPrincipal.Controls.Add((Control) this.Label18);
      this.tpgPrincipal.Controls.Add((Control) this.CheckBox_NotIsUsePoints);
      this.tpgPrincipal.Controls.Add((Control) this.Label19);
      this.tpgPrincipal.Controls.Add((Control) this.CheckBox_IsUsePoints);
      this.tpgPrincipal.Controls.Add((Control) this.CheckBox_IsDivCtaNum);
      this.tpgPrincipal.Controls.Add((Control) this.Label10);
      this.tpgPrincipal.Controls.Add((Control) this.CheckBox_IsNotDivCtaNum);
      this.tpgPrincipal.Controls.Add((Control) this.Label11);
      this.tpgPrincipal.Controls.Add((Control) this.Label17);
      this.tpgPrincipal.Controls.Add((Control) this.ComboBox_MonthExpiredPoints);
      this.tpgPrincipal.Controls.Add((Control) this.CheckBox_IsPersonNum);
      this.tpgPrincipal.Controls.Add((Control) this.Label12);
      this.tpgPrincipal.Controls.Add((Control) this.CheckBox_IsNotPersonNum);
      this.tpgPrincipal.Controls.Add((Control) this.CheckBox_NotShowOffer);
      this.tpgPrincipal.Controls.Add((Control) this.Label16);
      this.tpgPrincipal.Controls.Add((Control) this.CheckBox_ShowOffer);
      this.tpgPrincipal.Controls.Add((Control) this.CheckBox_IsPayThenCommnand);
      this.tpgPrincipal.Controls.Add((Control) this.Label13);
      this.tpgPrincipal.Controls.Add((Control) this.CheckBox_IsNotPayThenCommnand);
      this.tpgPrincipal.Controls.Add((Control) this.CheckBox_IsNotPrintPrecountSend);
      this.tpgPrincipal.Controls.Add((Control) this.Label15);
      this.tpgPrincipal.Controls.Add((Control) this.CheckBox_IsPrintPrecountSend);
      this.tpgPrincipal.Controls.Add((Control) this.CheckBox_IsDeleteItemNotSend);
      this.tpgPrincipal.Controls.Add((Control) this.CheckBox_IsNotDeleteItemNotSend);
      this.tpgPrincipal.Location = new Point(4, 25);
      this.tpgPrincipal.Name = "tpgPrincipal";
      this.tpgPrincipal.Padding = new Padding(3);
      this.tpgPrincipal.Size = new Size(542, 511);
      this.tpgPrincipal.TabIndex = 0;
      this.tpgPrincipal.Text = "Principal";
      this.tpgPrincipal.UseVisualStyleBackColor = true;
      this.CheckBox_IsVendedorTransfMesa.Appearance = Appearance.Button;
      this.CheckBox_IsVendedorTransfMesa.AutoSize = true;
      this.CheckBox_IsVendedorTransfMesa.FlatAppearance.CheckedBackColor = Color.NavajoWhite;
      this.CheckBox_IsVendedorTransfMesa.FlatAppearance.MouseDownBackColor = Color.NavajoWhite;
      this.CheckBox_IsVendedorTransfMesa.FlatStyle = FlatStyle.Flat;
      this.CheckBox_IsVendedorTransfMesa.Font = new Font("Trebuchet MS", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.CheckBox_IsVendedorTransfMesa.Image = (Image) componentResourceManager.GetObject("CheckBox_IsVendedorTransfMesa.Image");
      this.CheckBox_IsVendedorTransfMesa.Location = new Point(6, 466);
      this.CheckBox_IsVendedorTransfMesa.Name = "CheckBox_IsVendedorTransfMesa";
      this.CheckBox_IsVendedorTransfMesa.Size = new Size(39, 33);
      this.CheckBox_IsVendedorTransfMesa.TabIndex = 480;
      this.CheckBox_IsVendedorTransfMesa.Text = "    ";
      this.CheckBox_IsVendedorTransfMesa.UseVisualStyleBackColor = true;
      this.CheckBox_SubGroupOrder.Appearance = Appearance.Button;
      this.CheckBox_SubGroupOrder.AutoSize = true;
      this.CheckBox_SubGroupOrder.FlatAppearance.CheckedBackColor = Color.NavajoWhite;
      this.CheckBox_SubGroupOrder.FlatAppearance.MouseDownBackColor = Color.NavajoWhite;
      this.CheckBox_SubGroupOrder.FlatStyle = FlatStyle.Flat;
      this.CheckBox_SubGroupOrder.Font = new Font("Trebuchet MS", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.CheckBox_SubGroupOrder.Image = (Image) componentResourceManager.GetObject("CheckBox_SubGroupOrder.Image");
      this.CheckBox_SubGroupOrder.Location = new Point(6, 2);
      this.CheckBox_SubGroupOrder.Name = "CheckBox_SubGroupOrder";
      this.CheckBox_SubGroupOrder.Size = new Size(39, 33);
      this.CheckBox_SubGroupOrder.TabIndex = 212;
      this.CheckBox_SubGroupOrder.Text = "    ";
      this.CheckBox_SubGroupOrder.UseVisualStyleBackColor = true;
      this.CheckBox_IsNotVendedorTransfMesa.Appearance = Appearance.Button;
      this.CheckBox_IsNotVendedorTransfMesa.AutoSize = true;
      this.CheckBox_IsNotVendedorTransfMesa.FlatAppearance.CheckedBackColor = Color.NavajoWhite;
      this.CheckBox_IsNotVendedorTransfMesa.FlatAppearance.MouseDownBackColor = Color.NavajoWhite;
      this.CheckBox_IsNotVendedorTransfMesa.FlatStyle = FlatStyle.Flat;
      this.CheckBox_IsNotVendedorTransfMesa.Font = new Font("Trebuchet MS", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.CheckBox_IsNotVendedorTransfMesa.Image = (Image) componentResourceManager.GetObject("CheckBox_IsNotVendedorTransfMesa.Image");
      this.CheckBox_IsNotVendedorTransfMesa.Location = new Point(44, 466);
      this.CheckBox_IsNotVendedorTransfMesa.Name = "CheckBox_IsNotVendedorTransfMesa";
      this.CheckBox_IsNotVendedorTransfMesa.Size = new Size(39, 33);
      this.CheckBox_IsNotVendedorTransfMesa.TabIndex = 479;
      this.CheckBox_IsNotVendedorTransfMesa.Text = "    ";
      this.CheckBox_IsNotVendedorTransfMesa.UseVisualStyleBackColor = true;
      this.Label14.AutoSize = true;
      this.Label14.BackColor = Color.Transparent;
      this.Label14.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Label14.ForeColor = Color.FromArgb(150, 150, 150);
      this.Label14.Location = new Point(86, 270);
      this.Label14.Name = "Label14";
      this.Label14.Size = new Size(290, 16);
      this.Label14.TabIndex = 450;
      this.Label14.Text = "¿Exigir Usuario al Eliminar Producto Sin Enviar?";
      this.Label31.AutoSize = true;
      this.Label31.BackColor = Color.Transparent;
      this.Label31.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Label31.ForeColor = Color.FromArgb(150, 150, 150);
      this.Label31.Location = new Point(86, 473);
      this.Label31.Name = "Label31";
      this.Label31.Size = new Size(267, 16);
      this.Label31.TabIndex = 478;
      this.Label31.Text = "¿Vendedor realiza Transferencia de Mesa?";
      this.Label9.AutoSize = true;
      this.Label9.BackColor = Color.Transparent;
      this.Label9.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Label9.ForeColor = Color.FromArgb(150, 150, 150);
      this.Label9.Location = new Point(86, 9);
      this.Label9.Name = "Label9";
      this.Label9.Size = new Size(250, 16);
      this.Label9.TabIndex = 210;
      this.Label9.Text = "¿Ordenar SubGrupos Por Nro de Orden?";
      this.CheckBox_IsPreguntarComanda.Appearance = Appearance.Button;
      this.CheckBox_IsPreguntarComanda.AutoSize = true;
      this.CheckBox_IsPreguntarComanda.FlatAppearance.CheckedBackColor = Color.NavajoWhite;
      this.CheckBox_IsPreguntarComanda.FlatAppearance.MouseDownBackColor = Color.NavajoWhite;
      this.CheckBox_IsPreguntarComanda.FlatStyle = FlatStyle.Flat;
      this.CheckBox_IsPreguntarComanda.Font = new Font("Trebuchet MS", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.CheckBox_IsPreguntarComanda.Image = (Image) componentResourceManager.GetObject("CheckBox_IsPreguntarComanda.Image");
      this.CheckBox_IsPreguntarComanda.Location = new Point(6, 350);
      this.CheckBox_IsPreguntarComanda.Name = "CheckBox_IsPreguntarComanda";
      this.CheckBox_IsPreguntarComanda.Size = new Size(39, 33);
      this.CheckBox_IsPreguntarComanda.TabIndex = 477;
      this.CheckBox_IsPreguntarComanda.Text = "    ";
      this.CheckBox_IsPreguntarComanda.UseVisualStyleBackColor = true;
      this.CheckBox_NotSubGroupOrder.Appearance = Appearance.Button;
      this.CheckBox_NotSubGroupOrder.AutoSize = true;
      this.CheckBox_NotSubGroupOrder.FlatAppearance.CheckedBackColor = Color.NavajoWhite;
      this.CheckBox_NotSubGroupOrder.FlatAppearance.MouseDownBackColor = Color.NavajoWhite;
      this.CheckBox_NotSubGroupOrder.FlatStyle = FlatStyle.Flat;
      this.CheckBox_NotSubGroupOrder.Font = new Font("Trebuchet MS", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.CheckBox_NotSubGroupOrder.Image = (Image) componentResourceManager.GetObject("CheckBox_NotSubGroupOrder.Image");
      this.CheckBox_NotSubGroupOrder.Location = new Point(44, 2);
      this.CheckBox_NotSubGroupOrder.Name = "CheckBox_NotSubGroupOrder";
      this.CheckBox_NotSubGroupOrder.Size = new Size(39, 33);
      this.CheckBox_NotSubGroupOrder.TabIndex = 211;
      this.CheckBox_NotSubGroupOrder.Text = "    ";
      this.CheckBox_NotSubGroupOrder.UseVisualStyleBackColor = true;
      this.CheckBox_IsNotPreguntarComanda.Appearance = Appearance.Button;
      this.CheckBox_IsNotPreguntarComanda.AutoSize = true;
      this.CheckBox_IsNotPreguntarComanda.FlatAppearance.CheckedBackColor = Color.NavajoWhite;
      this.CheckBox_IsNotPreguntarComanda.FlatAppearance.MouseDownBackColor = Color.NavajoWhite;
      this.CheckBox_IsNotPreguntarComanda.FlatStyle = FlatStyle.Flat;
      this.CheckBox_IsNotPreguntarComanda.Font = new Font("Trebuchet MS", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.CheckBox_IsNotPreguntarComanda.Image = (Image) componentResourceManager.GetObject("CheckBox_IsNotPreguntarComanda.Image");
      this.CheckBox_IsNotPreguntarComanda.Location = new Point(44, 350);
      this.CheckBox_IsNotPreguntarComanda.Name = "CheckBox_IsNotPreguntarComanda";
      this.CheckBox_IsNotPreguntarComanda.Size = new Size(39, 33);
      this.CheckBox_IsNotPreguntarComanda.TabIndex = 476;
      this.CheckBox_IsNotPreguntarComanda.Text = "    ";
      this.CheckBox_IsNotPreguntarComanda.UseVisualStyleBackColor = true;
      this.Label3.AutoSize = true;
      this.Label3.BackColor = Color.Transparent;
      this.Label3.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Label3.ForeColor = Color.FromArgb(150, 150, 150);
      this.Label3.Location = new Point(86, 38);
      this.Label3.Name = "Label3";
      this.Label3.Size = new Size(257, 16);
      this.Label3.TabIndex = 217;
      this.Label3.Text = "¿Impresión de Documentos Centralizada?";
      this.Label23.AutoSize = true;
      this.Label23.BackColor = Color.Transparent;
      this.Label23.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Label23.ForeColor = Color.FromArgb(150, 150, 150);
      this.Label23.Location = new Point(86, 357);
      this.Label23.Name = "Label23";
      this.Label23.Size = new Size(238, 16);
      this.Label23.TabIndex = 475;
      this.Label23.Text = "¿Elegir Impresora al Enviar Comanda?";
      this.CheckBox_IsNotPrintCentral.Appearance = Appearance.Button;
      this.CheckBox_IsNotPrintCentral.AutoSize = true;
      this.CheckBox_IsNotPrintCentral.FlatAppearance.CheckedBackColor = Color.NavajoWhite;
      this.CheckBox_IsNotPrintCentral.FlatAppearance.MouseDownBackColor = Color.NavajoWhite;
      this.CheckBox_IsNotPrintCentral.FlatStyle = FlatStyle.Flat;
      this.CheckBox_IsNotPrintCentral.Font = new Font("Trebuchet MS", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.CheckBox_IsNotPrintCentral.Image = (Image) componentResourceManager.GetObject("CheckBox_IsNotPrintCentral.Image");
      this.CheckBox_IsNotPrintCentral.Location = new Point(44, 31);
      this.CheckBox_IsNotPrintCentral.Name = "CheckBox_IsNotPrintCentral";
      this.CheckBox_IsNotPrintCentral.Size = new Size(39, 33);
      this.CheckBox_IsNotPrintCentral.TabIndex = 218;
      this.CheckBox_IsNotPrintCentral.Text = "    ";
      this.CheckBox_IsNotPrintCentral.UseVisualStyleBackColor = true;
      this.ComboBox_NroSubmesas.DropDownStyle = ComboBoxStyle.DropDownList;
      this.ComboBox_NroSubmesas.ForeColor = Color.Red;
      this.ComboBox_NroSubmesas.FormattingEnabled = true;
      this.ComboBox_NroSubmesas.Location = new Point(251, 441);
      this.ComboBox_NroSubmesas.MaxDropDownItems = 11;
      this.ComboBox_NroSubmesas.Name = "ComboBox_NroSubmesas";
      this.ComboBox_NroSubmesas.Size = new Size(45, 24);
      this.ComboBox_NroSubmesas.TabIndex = 474;
      this.CheckBox_IsPrintCentral.Appearance = Appearance.Button;
      this.CheckBox_IsPrintCentral.AutoSize = true;
      this.CheckBox_IsPrintCentral.FlatAppearance.CheckedBackColor = Color.NavajoWhite;
      this.CheckBox_IsPrintCentral.FlatAppearance.MouseDownBackColor = Color.NavajoWhite;
      this.CheckBox_IsPrintCentral.FlatStyle = FlatStyle.Flat;
      this.CheckBox_IsPrintCentral.Font = new Font("Trebuchet MS", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.CheckBox_IsPrintCentral.Image = (Image) componentResourceManager.GetObject("CheckBox_IsPrintCentral.Image");
      this.CheckBox_IsPrintCentral.Location = new Point(6, 31);
      this.CheckBox_IsPrintCentral.Name = "CheckBox_IsPrintCentral";
      this.CheckBox_IsPrintCentral.Size = new Size(39, 33);
      this.CheckBox_IsPrintCentral.TabIndex = 219;
      this.CheckBox_IsPrintCentral.Text = "    ";
      this.CheckBox_IsPrintCentral.UseVisualStyleBackColor = true;
      this.Label21.AutoSize = true;
      this.Label21.BackColor = Color.Transparent;
      this.Label21.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Label21.ForeColor = Color.FromArgb(150, 150, 150);
      this.Label21.Location = new Point(302, 444);
      this.Label21.Name = "Label21";
      this.Label21.Size = new Size(152, 16);
      this.Label21.TabIndex = 473;
      this.Label21.Text = "en División de Cuentas?";
      this.Label4.AutoSize = true;
      this.Label4.BackColor = Color.Transparent;
      this.Label4.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Label4.ForeColor = Color.FromArgb(150, 150, 150);
      this.Label4.Location = new Point(86, 67);
      this.Label4.Name = "Label4";
      this.Label4.Size = new Size(250, 16);
      this.Label4.TabIndex = 220;
      this.Label4.Text = "¿Imprimir Productos al Enviar Comanda?";
      this.CheckBox_NroSubmesas.Appearance = Appearance.Button;
      this.CheckBox_NroSubmesas.AutoSize = true;
      this.CheckBox_NroSubmesas.FlatAppearance.CheckedBackColor = Color.NavajoWhite;
      this.CheckBox_NroSubmesas.FlatAppearance.MouseDownBackColor = Color.NavajoWhite;
      this.CheckBox_NroSubmesas.FlatStyle = FlatStyle.Flat;
      this.CheckBox_NroSubmesas.Font = new Font("Trebuchet MS", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.CheckBox_NroSubmesas.Image = (Image) componentResourceManager.GetObject("CheckBox_NroSubmesas.Image");
      this.CheckBox_NroSubmesas.Location = new Point(6, 437);
      this.CheckBox_NroSubmesas.Name = "CheckBox_NroSubmesas";
      this.CheckBox_NroSubmesas.Size = new Size(39, 33);
      this.CheckBox_NroSubmesas.TabIndex = 472;
      this.CheckBox_NroSubmesas.Text = "    ";
      this.CheckBox_NroSubmesas.UseVisualStyleBackColor = true;
      this.CheckBox_NotPrintProducts.Appearance = Appearance.Button;
      this.CheckBox_NotPrintProducts.AutoSize = true;
      this.CheckBox_NotPrintProducts.FlatAppearance.CheckedBackColor = Color.NavajoWhite;
      this.CheckBox_NotPrintProducts.FlatAppearance.MouseDownBackColor = Color.NavajoWhite;
      this.CheckBox_NotPrintProducts.FlatStyle = FlatStyle.Flat;
      this.CheckBox_NotPrintProducts.Font = new Font("Trebuchet MS", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.CheckBox_NotPrintProducts.Image = (Image) componentResourceManager.GetObject("CheckBox_NotPrintProducts.Image");
      this.CheckBox_NotPrintProducts.Location = new Point(44, 60);
      this.CheckBox_NotPrintProducts.Name = "CheckBox_NotPrintProducts";
      this.CheckBox_NotPrintProducts.Size = new Size(39, 33);
      this.CheckBox_NotPrintProducts.TabIndex = 221;
      this.CheckBox_NotPrintProducts.Text = "    ";
      this.CheckBox_NotPrintProducts.UseVisualStyleBackColor = true;
      this.CheckBox_NotNroSubmesas.Appearance = Appearance.Button;
      this.CheckBox_NotNroSubmesas.AutoSize = true;
      this.CheckBox_NotNroSubmesas.FlatAppearance.CheckedBackColor = Color.NavajoWhite;
      this.CheckBox_NotNroSubmesas.FlatAppearance.MouseDownBackColor = Color.NavajoWhite;
      this.CheckBox_NotNroSubmesas.FlatStyle = FlatStyle.Flat;
      this.CheckBox_NotNroSubmesas.Font = new Font("Trebuchet MS", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.CheckBox_NotNroSubmesas.Image = (Image) componentResourceManager.GetObject("CheckBox_NotNroSubmesas.Image");
      this.CheckBox_NotNroSubmesas.Location = new Point(44, 437);
      this.CheckBox_NotNroSubmesas.Name = "CheckBox_NotNroSubmesas";
      this.CheckBox_NotNroSubmesas.Size = new Size(39, 33);
      this.CheckBox_NotNroSubmesas.TabIndex = 471;
      this.CheckBox_NotNroSubmesas.Text = "    ";
      this.CheckBox_NotNroSubmesas.UseVisualStyleBackColor = true;
      this.CheckBox_PrintProducts.Appearance = Appearance.Button;
      this.CheckBox_PrintProducts.AutoSize = true;
      this.CheckBox_PrintProducts.FlatAppearance.CheckedBackColor = Color.NavajoWhite;
      this.CheckBox_PrintProducts.FlatAppearance.MouseDownBackColor = Color.NavajoWhite;
      this.CheckBox_PrintProducts.FlatStyle = FlatStyle.Flat;
      this.CheckBox_PrintProducts.Font = new Font("Trebuchet MS", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.CheckBox_PrintProducts.Image = (Image) componentResourceManager.GetObject("CheckBox_PrintProducts.Image");
      this.CheckBox_PrintProducts.Location = new Point(6, 60);
      this.CheckBox_PrintProducts.Name = "CheckBox_PrintProducts";
      this.CheckBox_PrintProducts.Size = new Size(39, 33);
      this.CheckBox_PrintProducts.TabIndex = 222;
      this.CheckBox_PrintProducts.Text = "    ";
      this.CheckBox_PrintProducts.UseVisualStyleBackColor = true;
      this.Label22.AutoSize = true;
      this.Label22.BackColor = Color.Transparent;
      this.Label22.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Label22.ForeColor = Color.FromArgb(150, 150, 150);
      this.Label22.Location = new Point(86, 444);
      this.Label22.Name = "Label22";
      this.Label22.Size = new Size(144, 16);
      this.Label22.TabIndex = 470;
      this.Label22.Text = "¿Limitar Nº Sub-Mesas";
      this.Label5.AutoSize = true;
      this.Label5.BackColor = Color.Transparent;
      this.Label5.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Label5.ForeColor = Color.FromArgb(150, 150, 150);
      this.Label5.Location = new Point(86, 96);
      this.Label5.Name = "Label5";
      this.Label5.Size = new Size(211, 16);
      this.Label5.TabIndex = 223;
      this.Label5.Text = "¿Mostrar Opciones de Precuenta?";
      this.CheckBox_ShowTax.Appearance = Appearance.Button;
      this.CheckBox_ShowTax.AutoSize = true;
      this.CheckBox_ShowTax.FlatAppearance.CheckedBackColor = Color.NavajoWhite;
      this.CheckBox_ShowTax.FlatAppearance.MouseDownBackColor = Color.NavajoWhite;
      this.CheckBox_ShowTax.FlatStyle = FlatStyle.Flat;
      this.CheckBox_ShowTax.Font = new Font("Trebuchet MS", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.CheckBox_ShowTax.Image = (Image) componentResourceManager.GetObject("CheckBox_ShowTax.Image");
      this.CheckBox_ShowTax.Location = new Point(6, 321);
      this.CheckBox_ShowTax.Name = "CheckBox_ShowTax";
      this.CheckBox_ShowTax.Size = new Size(39, 33);
      this.CheckBox_ShowTax.TabIndex = 469;
      this.CheckBox_ShowTax.Text = "    ";
      this.CheckBox_ShowTax.UseVisualStyleBackColor = true;
      this.CheckBox_NotShowOpcPrebill.Appearance = Appearance.Button;
      this.CheckBox_NotShowOpcPrebill.AutoSize = true;
      this.CheckBox_NotShowOpcPrebill.FlatAppearance.CheckedBackColor = Color.NavajoWhite;
      this.CheckBox_NotShowOpcPrebill.FlatAppearance.MouseDownBackColor = Color.NavajoWhite;
      this.CheckBox_NotShowOpcPrebill.FlatStyle = FlatStyle.Flat;
      this.CheckBox_NotShowOpcPrebill.Font = new Font("Trebuchet MS", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.CheckBox_NotShowOpcPrebill.Image = (Image) componentResourceManager.GetObject("CheckBox_NotShowOpcPrebill.Image");
      this.CheckBox_NotShowOpcPrebill.Location = new Point(44, 89);
      this.CheckBox_NotShowOpcPrebill.Name = "CheckBox_NotShowOpcPrebill";
      this.CheckBox_NotShowOpcPrebill.Size = new Size(39, 33);
      this.CheckBox_NotShowOpcPrebill.TabIndex = 224;
      this.CheckBox_NotShowOpcPrebill.Text = "    ";
      this.CheckBox_NotShowOpcPrebill.UseVisualStyleBackColor = true;
      this.CheckBox_NotShowTax.Appearance = Appearance.Button;
      this.CheckBox_NotShowTax.AutoSize = true;
      this.CheckBox_NotShowTax.FlatAppearance.CheckedBackColor = Color.NavajoWhite;
      this.CheckBox_NotShowTax.FlatAppearance.MouseDownBackColor = Color.NavajoWhite;
      this.CheckBox_NotShowTax.FlatStyle = FlatStyle.Flat;
      this.CheckBox_NotShowTax.Font = new Font("Trebuchet MS", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.CheckBox_NotShowTax.Image = (Image) componentResourceManager.GetObject("CheckBox_NotShowTax.Image");
      this.CheckBox_NotShowTax.Location = new Point(44, 321);
      this.CheckBox_NotShowTax.Name = "CheckBox_NotShowTax";
      this.CheckBox_NotShowTax.Size = new Size(39, 33);
      this.CheckBox_NotShowTax.TabIndex = 468;
      this.CheckBox_NotShowTax.Text = "    ";
      this.CheckBox_NotShowTax.UseVisualStyleBackColor = true;
      this.CheckBox_ShowOpcPrebill.Appearance = Appearance.Button;
      this.CheckBox_ShowOpcPrebill.AutoSize = true;
      this.CheckBox_ShowOpcPrebill.FlatAppearance.CheckedBackColor = Color.NavajoWhite;
      this.CheckBox_ShowOpcPrebill.FlatAppearance.MouseDownBackColor = Color.NavajoWhite;
      this.CheckBox_ShowOpcPrebill.FlatStyle = FlatStyle.Flat;
      this.CheckBox_ShowOpcPrebill.Font = new Font("Trebuchet MS", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.CheckBox_ShowOpcPrebill.Image = (Image) componentResourceManager.GetObject("CheckBox_ShowOpcPrebill.Image");
      this.CheckBox_ShowOpcPrebill.Location = new Point(6, 89);
      this.CheckBox_ShowOpcPrebill.Name = "CheckBox_ShowOpcPrebill";
      this.CheckBox_ShowOpcPrebill.Size = new Size(39, 33);
      this.CheckBox_ShowOpcPrebill.TabIndex = 225;
      this.CheckBox_ShowOpcPrebill.Text = "    ";
      this.CheckBox_ShowOpcPrebill.UseVisualStyleBackColor = true;
      this.Label20.AutoSize = true;
      this.Label20.BackColor = Color.Transparent;
      this.Label20.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Label20.ForeColor = Color.FromArgb(150, 150, 150);
      this.Label20.Location = new Point(86, 328);
      this.Label20.Name = "Label20";
      this.Label20.Size = new Size(280, 16);
      this.Label20.TabIndex = 467;
      this.Label20.Text = "¿Mostrar Impuestos en Impresión de Boletas?";
      this.Label7.AutoSize = true;
      this.Label7.BackColor = Color.Transparent;
      this.Label7.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Label7.ForeColor = Color.FromArgb(150, 150, 150);
      this.Label7.Location = new Point(86, 125);
      this.Label7.Name = "Label7";
      this.Label7.Size = new Size(194, 16);
      this.Label7.TabIndex = 228;
      this.Label7.Text = "¿Aplicar % Dscto. por Clientes?";
      this.TextBox_DivCtaNum.set_AllowSpace(false);
      ((TextBoxBase) this.TextBox_DivCtaNum).BackColor = Color.White;
      ((TextBoxBase) this.TextBox_DivCtaNum).BorderStyle = BorderStyle.FixedSingle;
      ((Control) this.TextBox_DivCtaNum).Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      ((TextBoxBase) this.TextBox_DivCtaNum).ForeColor = Color.FromArgb(209, 102, 61);
      ((Control) this.TextBox_DivCtaNum).Location = new Point(251, 413);
      ((TextBoxBase) this.TextBox_DivCtaNum).MaxLength = 2;
      ((TextBox) this.TextBox_DivCtaNum).Multiline = true;
      ((Control) this.TextBox_DivCtaNum).Name = "TextBox_DivCtaNum";
      ((Control) this.TextBox_DivCtaNum).Size = new Size(45, 25);
      ((Control) this.TextBox_DivCtaNum).TabIndex = 466;
      ((TextBox) this.TextBox_DivCtaNum).Text = "0";
      ((TextBox) this.TextBox_DivCtaNum).TextAlign = HorizontalAlignment.Center;
      this.CheckBox_NotIsDiscountClients.Appearance = Appearance.Button;
      this.CheckBox_NotIsDiscountClients.AutoSize = true;
      this.CheckBox_NotIsDiscountClients.FlatAppearance.CheckedBackColor = Color.NavajoWhite;
      this.CheckBox_NotIsDiscountClients.FlatAppearance.MouseDownBackColor = Color.NavajoWhite;
      this.CheckBox_NotIsDiscountClients.FlatStyle = FlatStyle.Flat;
      this.CheckBox_NotIsDiscountClients.Font = new Font("Trebuchet MS", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.CheckBox_NotIsDiscountClients.Image = (Image) componentResourceManager.GetObject("CheckBox_NotIsDiscountClients.Image");
      this.CheckBox_NotIsDiscountClients.Location = new Point(44, 118);
      this.CheckBox_NotIsDiscountClients.Name = "CheckBox_NotIsDiscountClients";
      this.CheckBox_NotIsDiscountClients.Size = new Size(39, 33);
      this.CheckBox_NotIsDiscountClients.TabIndex = 229;
      this.CheckBox_NotIsDiscountClients.Text = "    ";
      this.CheckBox_NotIsDiscountClients.UseVisualStyleBackColor = true;
      this.TextBox_PersonNum.set_AllowSpace(false);
      ((TextBoxBase) this.TextBox_PersonNum).BackColor = Color.White;
      ((TextBoxBase) this.TextBox_PersonNum).BorderStyle = BorderStyle.FixedSingle;
      ((Control) this.TextBox_PersonNum).Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      ((TextBoxBase) this.TextBox_PersonNum).ForeColor = Color.FromArgb(209, 102, 61);
      ((Control) this.TextBox_PersonNum).Location = new Point(251, 383);
      ((TextBoxBase) this.TextBox_PersonNum).MaxLength = 2;
      ((TextBox) this.TextBox_PersonNum).Multiline = true;
      ((Control) this.TextBox_PersonNum).Name = "TextBox_PersonNum";
      ((Control) this.TextBox_PersonNum).Size = new Size(45, 25);
      ((Control) this.TextBox_PersonNum).TabIndex = 465;
      ((TextBox) this.TextBox_PersonNum).Text = "0";
      ((TextBox) this.TextBox_PersonNum).TextAlign = HorizontalAlignment.Center;
      this.CheckBox_IsDiscountClients.Appearance = Appearance.Button;
      this.CheckBox_IsDiscountClients.AutoSize = true;
      this.CheckBox_IsDiscountClients.FlatAppearance.CheckedBackColor = Color.NavajoWhite;
      this.CheckBox_IsDiscountClients.FlatAppearance.MouseDownBackColor = Color.NavajoWhite;
      this.CheckBox_IsDiscountClients.FlatStyle = FlatStyle.Flat;
      this.CheckBox_IsDiscountClients.Font = new Font("Trebuchet MS", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.CheckBox_IsDiscountClients.Image = (Image) componentResourceManager.GetObject("CheckBox_IsDiscountClients.Image");
      this.CheckBox_IsDiscountClients.Location = new Point(6, 118);
      this.CheckBox_IsDiscountClients.Name = "CheckBox_IsDiscountClients";
      this.CheckBox_IsDiscountClients.Size = new Size(39, 33);
      this.CheckBox_IsDiscountClients.TabIndex = 230;
      this.CheckBox_IsDiscountClients.Text = "    ";
      this.CheckBox_IsDiscountClients.UseVisualStyleBackColor = true;
      this.TextBox_AmountUsePoints.set_AllowSpace(false);
      ((TextBoxBase) this.TextBox_AmountUsePoints).BackColor = Color.White;
      ((TextBoxBase) this.TextBox_AmountUsePoints).BorderStyle = BorderStyle.FixedSingle;
      ((Control) this.TextBox_AmountUsePoints).Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      ((TextBoxBase) this.TextBox_AmountUsePoints).ForeColor = Color.FromArgb(209, 102, 61);
      ((Control) this.TextBox_AmountUsePoints).Location = new Point(406, 153);
      ((TextBox) this.TextBox_AmountUsePoints).Multiline = true;
      ((Control) this.TextBox_AmountUsePoints).Name = "TextBox_AmountUsePoints";
      ((Control) this.TextBox_AmountUsePoints).Size = new Size(130, 25);
      ((Control) this.TextBox_AmountUsePoints).TabIndex = 464;
      ((TextBox) this.TextBox_AmountUsePoints).Text = "0.00";
      ((TextBox) this.TextBox_AmountUsePoints).TextAlign = HorizontalAlignment.Right;
      this.Label8.AutoSize = true;
      this.Label8.BackColor = Color.Transparent;
      this.Label8.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Label8.ForeColor = Color.FromArgb(150, 150, 150);
      this.Label8.Location = new Point(86, 154);
      this.Label8.Name = "Label8";
      this.Label8.Size = new Size(275, 16);
      this.Label8.TabIndex = 231;
      this.Label8.Text = "¿Acumular Puntos por Clientes? Por Cada S/.";
      this.Label18.AutoSize = true;
      this.Label18.BackColor = Color.Transparent;
      this.Label18.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Label18.ForeColor = Color.FromArgb(150, 150, 150);
      this.Label18.Location = new Point(302, 415);
      this.Label18.Name = "Label18";
      this.Label18.Size = new Size(152, 16);
      this.Label18.TabIndex = 463;
      this.Label18.Text = "en División de Cuentas?";
      this.CheckBox_NotIsUsePoints.Appearance = Appearance.Button;
      this.CheckBox_NotIsUsePoints.AutoSize = true;
      this.CheckBox_NotIsUsePoints.FlatAppearance.CheckedBackColor = Color.NavajoWhite;
      this.CheckBox_NotIsUsePoints.FlatAppearance.MouseDownBackColor = Color.NavajoWhite;
      this.CheckBox_NotIsUsePoints.FlatStyle = FlatStyle.Flat;
      this.CheckBox_NotIsUsePoints.Font = new Font("Trebuchet MS", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.CheckBox_NotIsUsePoints.Image = (Image) componentResourceManager.GetObject("CheckBox_NotIsUsePoints.Image");
      this.CheckBox_NotIsUsePoints.Location = new Point(44, 147);
      this.CheckBox_NotIsUsePoints.Name = "CheckBox_NotIsUsePoints";
      this.CheckBox_NotIsUsePoints.Size = new Size(39, 33);
      this.CheckBox_NotIsUsePoints.TabIndex = 232;
      this.CheckBox_NotIsUsePoints.Text = "    ";
      this.CheckBox_NotIsUsePoints.UseVisualStyleBackColor = true;
      this.Label19.AutoSize = true;
      this.Label19.BackColor = Color.Transparent;
      this.Label19.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Label19.ForeColor = Color.FromArgb(150, 150, 150);
      this.Label19.Location = new Point(303, 386);
      this.Label19.Name = "Label19";
      this.Label19.Size = new Size(84, 16);
      this.Label19.TabIndex = 462;
      this.Label19.Text = "en Pedidos?";
      this.CheckBox_IsUsePoints.Appearance = Appearance.Button;
      this.CheckBox_IsUsePoints.AutoSize = true;
      this.CheckBox_IsUsePoints.FlatAppearance.CheckedBackColor = Color.NavajoWhite;
      this.CheckBox_IsUsePoints.FlatAppearance.MouseDownBackColor = Color.NavajoWhite;
      this.CheckBox_IsUsePoints.FlatStyle = FlatStyle.Flat;
      this.CheckBox_IsUsePoints.Font = new Font("Trebuchet MS", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.CheckBox_IsUsePoints.Image = (Image) componentResourceManager.GetObject("CheckBox_IsUsePoints.Image");
      this.CheckBox_IsUsePoints.Location = new Point(6, 147);
      this.CheckBox_IsUsePoints.Name = "CheckBox_IsUsePoints";
      this.CheckBox_IsUsePoints.Size = new Size(39, 33);
      this.CheckBox_IsUsePoints.TabIndex = 233;
      this.CheckBox_IsUsePoints.Text = "    ";
      this.CheckBox_IsUsePoints.UseVisualStyleBackColor = true;
      this.CheckBox_IsDivCtaNum.Appearance = Appearance.Button;
      this.CheckBox_IsDivCtaNum.AutoSize = true;
      this.CheckBox_IsDivCtaNum.FlatAppearance.CheckedBackColor = Color.NavajoWhite;
      this.CheckBox_IsDivCtaNum.FlatAppearance.MouseDownBackColor = Color.NavajoWhite;
      this.CheckBox_IsDivCtaNum.FlatStyle = FlatStyle.Flat;
      this.CheckBox_IsDivCtaNum.Font = new Font("Trebuchet MS", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.CheckBox_IsDivCtaNum.Image = (Image) componentResourceManager.GetObject("CheckBox_IsDivCtaNum.Image");
      this.CheckBox_IsDivCtaNum.Location = new Point(6, 408);
      this.CheckBox_IsDivCtaNum.Name = "CheckBox_IsDivCtaNum";
      this.CheckBox_IsDivCtaNum.Size = new Size(39, 33);
      this.CheckBox_IsDivCtaNum.TabIndex = 461;
      this.CheckBox_IsDivCtaNum.Text = "    ";
      this.CheckBox_IsDivCtaNum.UseVisualStyleBackColor = true;
      this.Label10.AutoSize = true;
      this.Label10.BackColor = Color.Transparent;
      this.Label10.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Label10.ForeColor = Color.FromArgb(150, 150, 150);
      this.Label10.Location = new Point(92, 183);
      this.Label10.Name = "Label10";
      this.Label10.Size = new Size(71, 16);
      this.Label10.TabIndex = 441;
      this.Label10.Text = "Expiran en";
      this.CheckBox_IsNotDivCtaNum.Appearance = Appearance.Button;
      this.CheckBox_IsNotDivCtaNum.AutoSize = true;
      this.CheckBox_IsNotDivCtaNum.FlatAppearance.CheckedBackColor = Color.NavajoWhite;
      this.CheckBox_IsNotDivCtaNum.FlatAppearance.MouseDownBackColor = Color.NavajoWhite;
      this.CheckBox_IsNotDivCtaNum.FlatStyle = FlatStyle.Flat;
      this.CheckBox_IsNotDivCtaNum.Font = new Font("Trebuchet MS", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.CheckBox_IsNotDivCtaNum.Image = (Image) componentResourceManager.GetObject("CheckBox_IsNotDivCtaNum.Image");
      this.CheckBox_IsNotDivCtaNum.Location = new Point(44, 408);
      this.CheckBox_IsNotDivCtaNum.Name = "CheckBox_IsNotDivCtaNum";
      this.CheckBox_IsNotDivCtaNum.Size = new Size(39, 33);
      this.CheckBox_IsNotDivCtaNum.TabIndex = 460;
      this.CheckBox_IsNotDivCtaNum.Text = "    ";
      this.CheckBox_IsNotDivCtaNum.UseVisualStyleBackColor = true;
      this.Label11.AutoSize = true;
      this.Label11.BackColor = Color.Transparent;
      this.Label11.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Label11.ForeColor = Color.FromArgb(150, 150, 150);
      this.Label11.Location = new Point(256, 183);
      this.Label11.Name = "Label11";
      this.Label11.Size = new Size(60, 16);
      this.Label11.TabIndex = 442;
      this.Label11.Text = "Mese(s).";
      this.Label17.AutoSize = true;
      this.Label17.BackColor = Color.Transparent;
      this.Label17.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Label17.ForeColor = Color.FromArgb(150, 150, 150);
      this.Label17.Location = new Point(86, 415);
      this.Label17.Name = "Label17";
      this.Label17.Size = new Size(124, 16);
      this.Label17.TabIndex = 459;
      this.Label17.Text = "¿Limitar Nº Cuentas";
      this.ComboBox_MonthExpiredPoints.DropDownStyle = ComboBoxStyle.DropDownList;
      this.ComboBox_MonthExpiredPoints.ForeColor = Color.Red;
      this.ComboBox_MonthExpiredPoints.FormattingEnabled = true;
      this.ComboBox_MonthExpiredPoints.Location = new Point(180, 180);
      this.ComboBox_MonthExpiredPoints.MaxDropDownItems = 11;
      this.ComboBox_MonthExpiredPoints.Name = "ComboBox_MonthExpiredPoints";
      this.ComboBox_MonthExpiredPoints.Size = new Size(70, 24);
      this.ComboBox_MonthExpiredPoints.TabIndex = 443;
      this.CheckBox_IsPersonNum.Appearance = Appearance.Button;
      this.CheckBox_IsPersonNum.AutoSize = true;
      this.CheckBox_IsPersonNum.FlatAppearance.CheckedBackColor = Color.NavajoWhite;
      this.CheckBox_IsPersonNum.FlatAppearance.MouseDownBackColor = Color.NavajoWhite;
      this.CheckBox_IsPersonNum.FlatStyle = FlatStyle.Flat;
      this.CheckBox_IsPersonNum.Font = new Font("Trebuchet MS", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.CheckBox_IsPersonNum.Image = (Image) componentResourceManager.GetObject("CheckBox_IsPersonNum.Image");
      this.CheckBox_IsPersonNum.Location = new Point(6, 379);
      this.CheckBox_IsPersonNum.Name = "CheckBox_IsPersonNum";
      this.CheckBox_IsPersonNum.Size = new Size(39, 33);
      this.CheckBox_IsPersonNum.TabIndex = 458;
      this.CheckBox_IsPersonNum.Text = "    ";
      this.CheckBox_IsPersonNum.UseVisualStyleBackColor = true;
      this.Label12.AutoSize = true;
      this.Label12.BackColor = Color.Transparent;
      this.Label12.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Label12.ForeColor = Color.FromArgb(150, 150, 150);
      this.Label12.Location = new Point(86, 212);
      this.Label12.Name = "Label12";
      this.Label12.Size = new Size(328, 16);
      this.Label12.TabIndex = 444;
      this.Label12.Text = "¿Mostrar Promociones en Impresión de Documentos?";
      this.CheckBox_IsNotPersonNum.Appearance = Appearance.Button;
      this.CheckBox_IsNotPersonNum.AutoSize = true;
      this.CheckBox_IsNotPersonNum.FlatAppearance.CheckedBackColor = Color.NavajoWhite;
      this.CheckBox_IsNotPersonNum.FlatAppearance.MouseDownBackColor = Color.NavajoWhite;
      this.CheckBox_IsNotPersonNum.FlatStyle = FlatStyle.Flat;
      this.CheckBox_IsNotPersonNum.Font = new Font("Trebuchet MS", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.CheckBox_IsNotPersonNum.Image = (Image) componentResourceManager.GetObject("CheckBox_IsNotPersonNum.Image");
      this.CheckBox_IsNotPersonNum.Location = new Point(44, 379);
      this.CheckBox_IsNotPersonNum.Name = "CheckBox_IsNotPersonNum";
      this.CheckBox_IsNotPersonNum.Size = new Size(39, 33);
      this.CheckBox_IsNotPersonNum.TabIndex = 457;
      this.CheckBox_IsNotPersonNum.Text = "    ";
      this.CheckBox_IsNotPersonNum.UseVisualStyleBackColor = true;
      this.CheckBox_NotShowOffer.Appearance = Appearance.Button;
      this.CheckBox_NotShowOffer.AutoSize = true;
      this.CheckBox_NotShowOffer.FlatAppearance.CheckedBackColor = Color.NavajoWhite;
      this.CheckBox_NotShowOffer.FlatAppearance.MouseDownBackColor = Color.NavajoWhite;
      this.CheckBox_NotShowOffer.FlatStyle = FlatStyle.Flat;
      this.CheckBox_NotShowOffer.Font = new Font("Trebuchet MS", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.CheckBox_NotShowOffer.Image = (Image) componentResourceManager.GetObject("CheckBox_NotShowOffer.Image");
      this.CheckBox_NotShowOffer.Location = new Point(44, 205);
      this.CheckBox_NotShowOffer.Name = "CheckBox_NotShowOffer";
      this.CheckBox_NotShowOffer.Size = new Size(39, 33);
      this.CheckBox_NotShowOffer.TabIndex = 445;
      this.CheckBox_NotShowOffer.Text = "    ";
      this.CheckBox_NotShowOffer.UseVisualStyleBackColor = true;
      this.Label16.AutoSize = true;
      this.Label16.BackColor = Color.Transparent;
      this.Label16.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Label16.ForeColor = Color.FromArgb(150, 150, 150);
      this.Label16.Location = new Point(86, 386);
      this.Label16.Name = "Label16";
      this.Label16.Size = new Size(133, 16);
      this.Label16.TabIndex = 456;
      this.Label16.Text = "¿Limitar Nº Personas";
      this.CheckBox_ShowOffer.Appearance = Appearance.Button;
      this.CheckBox_ShowOffer.AutoSize = true;
      this.CheckBox_ShowOffer.FlatAppearance.CheckedBackColor = Color.NavajoWhite;
      this.CheckBox_ShowOffer.FlatAppearance.MouseDownBackColor = Color.NavajoWhite;
      this.CheckBox_ShowOffer.FlatStyle = FlatStyle.Flat;
      this.CheckBox_ShowOffer.Font = new Font("Trebuchet MS", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.CheckBox_ShowOffer.Image = (Image) componentResourceManager.GetObject("CheckBox_ShowOffer.Image");
      this.CheckBox_ShowOffer.Location = new Point(6, 205);
      this.CheckBox_ShowOffer.Name = "CheckBox_ShowOffer";
      this.CheckBox_ShowOffer.Size = new Size(39, 33);
      this.CheckBox_ShowOffer.TabIndex = 446;
      this.CheckBox_ShowOffer.Text = "    ";
      this.CheckBox_ShowOffer.UseVisualStyleBackColor = true;
      this.CheckBox_IsPayThenCommnand.Appearance = Appearance.Button;
      this.CheckBox_IsPayThenCommnand.AutoSize = true;
      this.CheckBox_IsPayThenCommnand.FlatAppearance.CheckedBackColor = Color.NavajoWhite;
      this.CheckBox_IsPayThenCommnand.FlatAppearance.MouseDownBackColor = Color.NavajoWhite;
      this.CheckBox_IsPayThenCommnand.FlatStyle = FlatStyle.Flat;
      this.CheckBox_IsPayThenCommnand.Font = new Font("Trebuchet MS", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.CheckBox_IsPayThenCommnand.Image = (Image) componentResourceManager.GetObject("CheckBox_IsPayThenCommnand.Image");
      this.CheckBox_IsPayThenCommnand.Location = new Point(6, 292);
      this.CheckBox_IsPayThenCommnand.Name = "CheckBox_IsPayThenCommnand";
      this.CheckBox_IsPayThenCommnand.Size = new Size(39, 33);
      this.CheckBox_IsPayThenCommnand.TabIndex = 455;
      this.CheckBox_IsPayThenCommnand.Text = "    ";
      this.CheckBox_IsPayThenCommnand.UseVisualStyleBackColor = true;
      this.Label13.AutoSize = true;
      this.Label13.BackColor = Color.Transparent;
      this.Label13.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Label13.ForeColor = Color.FromArgb(150, 150, 150);
      this.Label13.Location = new Point(86, 241);
      this.Label13.Name = "Label13";
      this.Label13.Size = new Size(305, 16);
      this.Label13.TabIndex = 447;
      this.Label13.Text = "¿Imprimir Precuenta sólo de Productos Enviados?";
      this.CheckBox_IsNotPayThenCommnand.Appearance = Appearance.Button;
      this.CheckBox_IsNotPayThenCommnand.AutoSize = true;
      this.CheckBox_IsNotPayThenCommnand.FlatAppearance.CheckedBackColor = Color.NavajoWhite;
      this.CheckBox_IsNotPayThenCommnand.FlatAppearance.MouseDownBackColor = Color.NavajoWhite;
      this.CheckBox_IsNotPayThenCommnand.FlatStyle = FlatStyle.Flat;
      this.CheckBox_IsNotPayThenCommnand.Font = new Font("Trebuchet MS", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.CheckBox_IsNotPayThenCommnand.Image = (Image) componentResourceManager.GetObject("CheckBox_IsNotPayThenCommnand.Image");
      this.CheckBox_IsNotPayThenCommnand.Location = new Point(44, 292);
      this.CheckBox_IsNotPayThenCommnand.Name = "CheckBox_IsNotPayThenCommnand";
      this.CheckBox_IsNotPayThenCommnand.Size = new Size(39, 33);
      this.CheckBox_IsNotPayThenCommnand.TabIndex = 454;
      this.CheckBox_IsNotPayThenCommnand.Text = "    ";
      this.CheckBox_IsNotPayThenCommnand.UseVisualStyleBackColor = true;
      this.CheckBox_IsNotPrintPrecountSend.Appearance = Appearance.Button;
      this.CheckBox_IsNotPrintPrecountSend.AutoSize = true;
      this.CheckBox_IsNotPrintPrecountSend.FlatAppearance.CheckedBackColor = Color.NavajoWhite;
      this.CheckBox_IsNotPrintPrecountSend.FlatAppearance.MouseDownBackColor = Color.NavajoWhite;
      this.CheckBox_IsNotPrintPrecountSend.FlatStyle = FlatStyle.Flat;
      this.CheckBox_IsNotPrintPrecountSend.Font = new Font("Trebuchet MS", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.CheckBox_IsNotPrintPrecountSend.Image = (Image) componentResourceManager.GetObject("CheckBox_IsNotPrintPrecountSend.Image");
      this.CheckBox_IsNotPrintPrecountSend.Location = new Point(44, 234);
      this.CheckBox_IsNotPrintPrecountSend.Name = "CheckBox_IsNotPrintPrecountSend";
      this.CheckBox_IsNotPrintPrecountSend.Size = new Size(39, 33);
      this.CheckBox_IsNotPrintPrecountSend.TabIndex = 448;
      this.CheckBox_IsNotPrintPrecountSend.Text = "    ";
      this.CheckBox_IsNotPrintPrecountSend.UseVisualStyleBackColor = true;
      this.Label15.AutoSize = true;
      this.Label15.BackColor = Color.Transparent;
      this.Label15.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Label15.ForeColor = Color.FromArgb(150, 150, 150);
      this.Label15.Location = new Point(86, 299);
      this.Label15.Name = "Label15";
      this.Label15.Size = new Size(304, 16);
      this.Label15.TabIndex = 453;
      this.Label15.Text = "¿Primero Pagar Cuenta y luego Enviar Comanda?";
      this.CheckBox_IsPrintPrecountSend.Appearance = Appearance.Button;
      this.CheckBox_IsPrintPrecountSend.AutoSize = true;
      this.CheckBox_IsPrintPrecountSend.FlatAppearance.CheckedBackColor = Color.NavajoWhite;
      this.CheckBox_IsPrintPrecountSend.FlatAppearance.MouseDownBackColor = Color.NavajoWhite;
      this.CheckBox_IsPrintPrecountSend.FlatStyle = FlatStyle.Flat;
      this.CheckBox_IsPrintPrecountSend.Font = new Font("Trebuchet MS", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.CheckBox_IsPrintPrecountSend.Image = (Image) componentResourceManager.GetObject("CheckBox_IsPrintPrecountSend.Image");
      this.CheckBox_IsPrintPrecountSend.Location = new Point(6, 234);
      this.CheckBox_IsPrintPrecountSend.Name = "CheckBox_IsPrintPrecountSend";
      this.CheckBox_IsPrintPrecountSend.Size = new Size(39, 33);
      this.CheckBox_IsPrintPrecountSend.TabIndex = 449;
      this.CheckBox_IsPrintPrecountSend.Text = "    ";
      this.CheckBox_IsPrintPrecountSend.UseVisualStyleBackColor = true;
      this.CheckBox_IsDeleteItemNotSend.Appearance = Appearance.Button;
      this.CheckBox_IsDeleteItemNotSend.AutoSize = true;
      this.CheckBox_IsDeleteItemNotSend.FlatAppearance.CheckedBackColor = Color.NavajoWhite;
      this.CheckBox_IsDeleteItemNotSend.FlatAppearance.MouseDownBackColor = Color.NavajoWhite;
      this.CheckBox_IsDeleteItemNotSend.FlatStyle = FlatStyle.Flat;
      this.CheckBox_IsDeleteItemNotSend.Font = new Font("Trebuchet MS", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.CheckBox_IsDeleteItemNotSend.Image = (Image) componentResourceManager.GetObject("CheckBox_IsDeleteItemNotSend.Image");
      this.CheckBox_IsDeleteItemNotSend.Location = new Point(6, 263);
      this.CheckBox_IsDeleteItemNotSend.Name = "CheckBox_IsDeleteItemNotSend";
      this.CheckBox_IsDeleteItemNotSend.Size = new Size(39, 33);
      this.CheckBox_IsDeleteItemNotSend.TabIndex = 452;
      this.CheckBox_IsDeleteItemNotSend.Text = "    ";
      this.CheckBox_IsDeleteItemNotSend.UseVisualStyleBackColor = true;
      this.CheckBox_IsNotDeleteItemNotSend.Appearance = Appearance.Button;
      this.CheckBox_IsNotDeleteItemNotSend.AutoSize = true;
      this.CheckBox_IsNotDeleteItemNotSend.FlatAppearance.CheckedBackColor = Color.NavajoWhite;
      this.CheckBox_IsNotDeleteItemNotSend.FlatAppearance.MouseDownBackColor = Color.NavajoWhite;
      this.CheckBox_IsNotDeleteItemNotSend.FlatStyle = FlatStyle.Flat;
      this.CheckBox_IsNotDeleteItemNotSend.Font = new Font("Trebuchet MS", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.CheckBox_IsNotDeleteItemNotSend.Image = (Image) componentResourceManager.GetObject("CheckBox_IsNotDeleteItemNotSend.Image");
      this.CheckBox_IsNotDeleteItemNotSend.Location = new Point(44, 263);
      this.CheckBox_IsNotDeleteItemNotSend.Name = "CheckBox_IsNotDeleteItemNotSend";
      this.CheckBox_IsNotDeleteItemNotSend.Size = new Size(39, 33);
      this.CheckBox_IsNotDeleteItemNotSend.TabIndex = 451;
      this.CheckBox_IsNotDeleteItemNotSend.Text = "    ";
      this.CheckBox_IsNotDeleteItemNotSend.UseVisualStyleBackColor = true;
      this.tpgSegundo.BackColor = Color.White;
      this.tpgSegundo.Controls.Add((Control) this.CheckBox_DescuentoProgramado);
      this.tpgSegundo.Controls.Add((Control) this.CheckBox_NoDescuentoProgramado);
      this.tpgSegundo.Controls.Add((Control) this.Label36);
      this.tpgSegundo.Controls.Add((Control) this.CheckBox_PermisoAdminReimpPrecuenta);
      this.tpgSegundo.Controls.Add((Control) this.CheckBox_NoPermisoAdminReimpPrecuenta);
      this.tpgSegundo.Controls.Add((Control) this.Label35);
      this.tpgSegundo.Controls.Add((Control) this.CheckBox_PermisoAdminReimpComanda);
      this.tpgSegundo.Controls.Add((Control) this.CheckBox_NoPermisoAdminReimpComanda);
      this.tpgSegundo.Controls.Add((Control) this.Label34);
      this.tpgSegundo.Controls.Add((Control) this.CheckBox_IsSalirTomadoralEnviar);
      this.tpgSegundo.Controls.Add((Control) this.CheckBox_NotIsSalirTomadoralEnviar);
      this.tpgSegundo.Controls.Add((Control) this.Label32);
      this.tpgSegundo.Controls.Add((Control) this.CheckBox_IsExigeEnvioComanda);
      this.tpgSegundo.Controls.Add((Control) this.CheckBox_NotIsExigeEnvioComanda);
      this.tpgSegundo.Controls.Add((Control) this.Label33);
      this.tpgSegundo.Location = new Point(4, 25);
      this.tpgSegundo.Name = "tpgSegundo";
      this.tpgSegundo.Padding = new Padding(3);
      this.tpgSegundo.Size = new Size(542, 511);
      this.tpgSegundo.TabIndex = 1;
      this.tpgSegundo.Text = "Mas Opciones";
      this.tpgSegundo.UseVisualStyleBackColor = true;
      this.CheckBox_DescuentoProgramado.Appearance = Appearance.Button;
      this.CheckBox_DescuentoProgramado.AutoSize = true;
      this.CheckBox_DescuentoProgramado.FlatAppearance.CheckedBackColor = Color.NavajoWhite;
      this.CheckBox_DescuentoProgramado.FlatAppearance.MouseDownBackColor = Color.NavajoWhite;
      this.CheckBox_DescuentoProgramado.FlatStyle = FlatStyle.Flat;
      this.CheckBox_DescuentoProgramado.Font = new Font("Trebuchet MS", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.CheckBox_DescuentoProgramado.Image = (Image) componentResourceManager.GetObject("CheckBox_DescuentoProgramado.Image");
      this.CheckBox_DescuentoProgramado.Location = new Point(6, 35);
      this.CheckBox_DescuentoProgramado.Name = "CheckBox_DescuentoProgramado";
      this.CheckBox_DescuentoProgramado.Size = new Size(39, 33);
      this.CheckBox_DescuentoProgramado.TabIndex = 492;
      this.CheckBox_DescuentoProgramado.Text = "    ";
      this.CheckBox_DescuentoProgramado.UseVisualStyleBackColor = true;
      this.CheckBox_NoDescuentoProgramado.Appearance = Appearance.Button;
      this.CheckBox_NoDescuentoProgramado.AutoSize = true;
      this.CheckBox_NoDescuentoProgramado.FlatAppearance.CheckedBackColor = Color.NavajoWhite;
      this.CheckBox_NoDescuentoProgramado.FlatAppearance.MouseDownBackColor = Color.NavajoWhite;
      this.CheckBox_NoDescuentoProgramado.FlatStyle = FlatStyle.Flat;
      this.CheckBox_NoDescuentoProgramado.Font = new Font("Trebuchet MS", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.CheckBox_NoDescuentoProgramado.Image = (Image) componentResourceManager.GetObject("CheckBox_NoDescuentoProgramado.Image");
      this.CheckBox_NoDescuentoProgramado.Location = new Point(44, 35);
      this.CheckBox_NoDescuentoProgramado.Name = "CheckBox_NoDescuentoProgramado";
      this.CheckBox_NoDescuentoProgramado.Size = new Size(39, 33);
      this.CheckBox_NoDescuentoProgramado.TabIndex = 491;
      this.CheckBox_NoDescuentoProgramado.Text = "    ";
      this.CheckBox_NoDescuentoProgramado.UseVisualStyleBackColor = true;
      this.Label36.AutoSize = true;
      this.Label36.BackColor = Color.Transparent;
      this.Label36.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Label36.ForeColor = Color.FromArgb(150, 150, 150);
      this.Label36.Location = new Point(86, 44);
      this.Label36.Name = "Label36";
      this.Label36.Size = new Size(308, 16);
      this.Label36.TabIndex = 490;
      this.Label36.Text = "¿Activar Descuentos/Promociones Programadas?";
      this.CheckBox_PermisoAdminReimpPrecuenta.Appearance = Appearance.Button;
      this.CheckBox_PermisoAdminReimpPrecuenta.AutoSize = true;
      this.CheckBox_PermisoAdminReimpPrecuenta.FlatAppearance.CheckedBackColor = Color.NavajoWhite;
      this.CheckBox_PermisoAdminReimpPrecuenta.FlatAppearance.MouseDownBackColor = Color.NavajoWhite;
      this.CheckBox_PermisoAdminReimpPrecuenta.FlatStyle = FlatStyle.Flat;
      this.CheckBox_PermisoAdminReimpPrecuenta.Font = new Font("Trebuchet MS", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.CheckBox_PermisoAdminReimpPrecuenta.Image = (Image) componentResourceManager.GetObject("CheckBox_PermisoAdminReimpPrecuenta.Image");
      this.CheckBox_PermisoAdminReimpPrecuenta.Location = new Point(6, 122);
      this.CheckBox_PermisoAdminReimpPrecuenta.Name = "CheckBox_PermisoAdminReimpPrecuenta";
      this.CheckBox_PermisoAdminReimpPrecuenta.Size = new Size(39, 33);
      this.CheckBox_PermisoAdminReimpPrecuenta.TabIndex = 489;
      this.CheckBox_PermisoAdminReimpPrecuenta.Text = "    ";
      this.CheckBox_PermisoAdminReimpPrecuenta.UseVisualStyleBackColor = true;
      this.CheckBox_NoPermisoAdminReimpPrecuenta.Appearance = Appearance.Button;
      this.CheckBox_NoPermisoAdminReimpPrecuenta.AutoSize = true;
      this.CheckBox_NoPermisoAdminReimpPrecuenta.FlatAppearance.CheckedBackColor = Color.NavajoWhite;
      this.CheckBox_NoPermisoAdminReimpPrecuenta.FlatAppearance.MouseDownBackColor = Color.NavajoWhite;
      this.CheckBox_NoPermisoAdminReimpPrecuenta.FlatStyle = FlatStyle.Flat;
      this.CheckBox_NoPermisoAdminReimpPrecuenta.Font = new Font("Trebuchet MS", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.CheckBox_NoPermisoAdminReimpPrecuenta.Image = (Image) componentResourceManager.GetObject("CheckBox_NoPermisoAdminReimpPrecuenta.Image");
      this.CheckBox_NoPermisoAdminReimpPrecuenta.Location = new Point(44, 122);
      this.CheckBox_NoPermisoAdminReimpPrecuenta.Name = "CheckBox_NoPermisoAdminReimpPrecuenta";
      this.CheckBox_NoPermisoAdminReimpPrecuenta.Size = new Size(39, 33);
      this.CheckBox_NoPermisoAdminReimpPrecuenta.TabIndex = 488;
      this.CheckBox_NoPermisoAdminReimpPrecuenta.Text = "    ";
      this.CheckBox_NoPermisoAdminReimpPrecuenta.UseVisualStyleBackColor = true;
      this.Label35.AutoSize = true;
      this.Label35.BackColor = Color.Transparent;
      this.Label35.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Label35.ForeColor = Color.FromArgb(150, 150, 150);
      this.Label35.Location = new Point(86, 131);
      this.Label35.Name = "Label35";
      this.Label35.Size = new Size(376, 16);
      this.Label35.TabIndex = 487;
      this.Label35.Text = "¿Exigir Permiso de Administrador para ReImprimir Precuenta?";
      this.CheckBox_PermisoAdminReimpComanda.Appearance = Appearance.Button;
      this.CheckBox_PermisoAdminReimpComanda.AutoSize = true;
      this.CheckBox_PermisoAdminReimpComanda.FlatAppearance.CheckedBackColor = Color.NavajoWhite;
      this.CheckBox_PermisoAdminReimpComanda.FlatAppearance.MouseDownBackColor = Color.NavajoWhite;
      this.CheckBox_PermisoAdminReimpComanda.FlatStyle = FlatStyle.Flat;
      this.CheckBox_PermisoAdminReimpComanda.Font = new Font("Trebuchet MS", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.CheckBox_PermisoAdminReimpComanda.Image = (Image) componentResourceManager.GetObject("CheckBox_PermisoAdminReimpComanda.Image");
      this.CheckBox_PermisoAdminReimpComanda.Location = new Point(6, 93);
      this.CheckBox_PermisoAdminReimpComanda.Name = "CheckBox_PermisoAdminReimpComanda";
      this.CheckBox_PermisoAdminReimpComanda.Size = new Size(39, 33);
      this.CheckBox_PermisoAdminReimpComanda.TabIndex = 486;
      this.CheckBox_PermisoAdminReimpComanda.Text = "    ";
      this.CheckBox_PermisoAdminReimpComanda.UseVisualStyleBackColor = true;
      this.CheckBox_NoPermisoAdminReimpComanda.Appearance = Appearance.Button;
      this.CheckBox_NoPermisoAdminReimpComanda.AutoSize = true;
      this.CheckBox_NoPermisoAdminReimpComanda.FlatAppearance.CheckedBackColor = Color.NavajoWhite;
      this.CheckBox_NoPermisoAdminReimpComanda.FlatAppearance.MouseDownBackColor = Color.NavajoWhite;
      this.CheckBox_NoPermisoAdminReimpComanda.FlatStyle = FlatStyle.Flat;
      this.CheckBox_NoPermisoAdminReimpComanda.Font = new Font("Trebuchet MS", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.CheckBox_NoPermisoAdminReimpComanda.Image = (Image) componentResourceManager.GetObject("CheckBox_NoPermisoAdminReimpComanda.Image");
      this.CheckBox_NoPermisoAdminReimpComanda.Location = new Point(44, 93);
      this.CheckBox_NoPermisoAdminReimpComanda.Name = "CheckBox_NoPermisoAdminReimpComanda";
      this.CheckBox_NoPermisoAdminReimpComanda.Size = new Size(39, 33);
      this.CheckBox_NoPermisoAdminReimpComanda.TabIndex = 485;
      this.CheckBox_NoPermisoAdminReimpComanda.Text = "    ";
      this.CheckBox_NoPermisoAdminReimpComanda.UseVisualStyleBackColor = true;
      this.Label34.AutoSize = true;
      this.Label34.BackColor = Color.Transparent;
      this.Label34.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Label34.ForeColor = Color.FromArgb(150, 150, 150);
      this.Label34.Location = new Point(86, 102);
      this.Label34.Name = "Label34";
      this.Label34.Size = new Size(374, 16);
      this.Label34.TabIndex = 484;
      this.Label34.Text = "¿Exigir Permiso de Administrador para ReImprimir Comanda?";
      this.CheckBox_IsSalirTomadoralEnviar.Appearance = Appearance.Button;
      this.CheckBox_IsSalirTomadoralEnviar.AutoSize = true;
      this.CheckBox_IsSalirTomadoralEnviar.FlatAppearance.CheckedBackColor = Color.NavajoWhite;
      this.CheckBox_IsSalirTomadoralEnviar.FlatAppearance.MouseDownBackColor = Color.NavajoWhite;
      this.CheckBox_IsSalirTomadoralEnviar.FlatStyle = FlatStyle.Flat;
      this.CheckBox_IsSalirTomadoralEnviar.Font = new Font("Trebuchet MS", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.CheckBox_IsSalirTomadoralEnviar.Image = (Image) componentResourceManager.GetObject("CheckBox_IsSalirTomadoralEnviar.Image");
      this.CheckBox_IsSalirTomadoralEnviar.Location = new Point(6, 64);
      this.CheckBox_IsSalirTomadoralEnviar.Name = "CheckBox_IsSalirTomadoralEnviar";
      this.CheckBox_IsSalirTomadoralEnviar.Size = new Size(39, 33);
      this.CheckBox_IsSalirTomadoralEnviar.TabIndex = 483;
      this.CheckBox_IsSalirTomadoralEnviar.Text = "    ";
      this.CheckBox_IsSalirTomadoralEnviar.UseVisualStyleBackColor = true;
      this.CheckBox_NotIsSalirTomadoralEnviar.Appearance = Appearance.Button;
      this.CheckBox_NotIsSalirTomadoralEnviar.AutoSize = true;
      this.CheckBox_NotIsSalirTomadoralEnviar.FlatAppearance.CheckedBackColor = Color.NavajoWhite;
      this.CheckBox_NotIsSalirTomadoralEnviar.FlatAppearance.MouseDownBackColor = Color.NavajoWhite;
      this.CheckBox_NotIsSalirTomadoralEnviar.FlatStyle = FlatStyle.Flat;
      this.CheckBox_NotIsSalirTomadoralEnviar.Font = new Font("Trebuchet MS", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.CheckBox_NotIsSalirTomadoralEnviar.Image = (Image) componentResourceManager.GetObject("CheckBox_NotIsSalirTomadoralEnviar.Image");
      this.CheckBox_NotIsSalirTomadoralEnviar.Location = new Point(44, 64);
      this.CheckBox_NotIsSalirTomadoralEnviar.Name = "CheckBox_NotIsSalirTomadoralEnviar";
      this.CheckBox_NotIsSalirTomadoralEnviar.Size = new Size(39, 33);
      this.CheckBox_NotIsSalirTomadoralEnviar.TabIndex = 482;
      this.CheckBox_NotIsSalirTomadoralEnviar.Text = "    ";
      this.CheckBox_NotIsSalirTomadoralEnviar.UseVisualStyleBackColor = true;
      this.Label32.AutoSize = true;
      this.Label32.BackColor = Color.Transparent;
      this.Label32.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Label32.ForeColor = Color.FromArgb(150, 150, 150);
      this.Label32.Location = new Point(86, 73);
      this.Label32.Name = "Label32";
      this.Label32.Size = new Size(317, 16);
      this.Label32.TabIndex = 481;
      this.Label32.Text = "¿Salir de Tomador de Pedidos al Enviar Comanda?";
      this.CheckBox_IsExigeEnvioComanda.Appearance = Appearance.Button;
      this.CheckBox_IsExigeEnvioComanda.AutoSize = true;
      this.CheckBox_IsExigeEnvioComanda.FlatAppearance.CheckedBackColor = Color.NavajoWhite;
      this.CheckBox_IsExigeEnvioComanda.FlatAppearance.MouseDownBackColor = Color.NavajoWhite;
      this.CheckBox_IsExigeEnvioComanda.FlatStyle = FlatStyle.Flat;
      this.CheckBox_IsExigeEnvioComanda.Font = new Font("Trebuchet MS", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.CheckBox_IsExigeEnvioComanda.Image = (Image) componentResourceManager.GetObject("CheckBox_IsExigeEnvioComanda.Image");
      this.CheckBox_IsExigeEnvioComanda.Location = new Point(6, 6);
      this.CheckBox_IsExigeEnvioComanda.Name = "CheckBox_IsExigeEnvioComanda";
      this.CheckBox_IsExigeEnvioComanda.Size = new Size(39, 33);
      this.CheckBox_IsExigeEnvioComanda.TabIndex = 480;
      this.CheckBox_IsExigeEnvioComanda.Text = "    ";
      this.CheckBox_IsExigeEnvioComanda.UseVisualStyleBackColor = true;
      this.CheckBox_NotIsExigeEnvioComanda.Appearance = Appearance.Button;
      this.CheckBox_NotIsExigeEnvioComanda.AutoSize = true;
      this.CheckBox_NotIsExigeEnvioComanda.FlatAppearance.CheckedBackColor = Color.NavajoWhite;
      this.CheckBox_NotIsExigeEnvioComanda.FlatAppearance.MouseDownBackColor = Color.NavajoWhite;
      this.CheckBox_NotIsExigeEnvioComanda.FlatStyle = FlatStyle.Flat;
      this.CheckBox_NotIsExigeEnvioComanda.Font = new Font("Trebuchet MS", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.CheckBox_NotIsExigeEnvioComanda.Image = (Image) componentResourceManager.GetObject("CheckBox_NotIsExigeEnvioComanda.Image");
      this.CheckBox_NotIsExigeEnvioComanda.Location = new Point(44, 6);
      this.CheckBox_NotIsExigeEnvioComanda.Name = "CheckBox_NotIsExigeEnvioComanda";
      this.CheckBox_NotIsExigeEnvioComanda.Size = new Size(39, 33);
      this.CheckBox_NotIsExigeEnvioComanda.TabIndex = 479;
      this.CheckBox_NotIsExigeEnvioComanda.Text = "    ";
      this.CheckBox_NotIsExigeEnvioComanda.UseVisualStyleBackColor = true;
      this.Label33.AutoSize = true;
      this.Label33.BackColor = Color.Transparent;
      this.Label33.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Label33.ForeColor = Color.FromArgb(150, 150, 150);
      this.Label33.Location = new Point(86, 15);
      this.Label33.Name = "Label33";
      this.Label33.Size = new Size(198, 16);
      this.Label33.TabIndex = 478;
      this.Label33.Text = "¿Exigir que se Envie Comanda?";
      this.tgpTercero.Controls.Add((Control) this.Button_SaveImpuesto);
      this.tgpTercero.Controls.Add((Control) this.GroupBox_Price3);
      this.tgpTercero.Controls.Add((Control) this.GroupBox_Price2);
      this.tgpTercero.Controls.Add((Control) this.GroupBox_Price1);
      this.tgpTercero.Location = new Point(4, 25);
      this.tgpTercero.Name = "tgpTercero";
      this.tgpTercero.Size = new Size(542, 511);
      this.tgpTercero.TabIndex = 2;
      this.tgpTercero.Text = "Tipo Pedido";
      this.tgpTercero.UseVisualStyleBackColor = true;
      this.Button_SaveImpuesto.BackgroundImage = (Image) TriNetRestPOS.My.Resources.Resources.BotonVerde;
      this.Button_SaveImpuesto.FlatStyle = FlatStyle.Flat;
      this.Button_SaveImpuesto.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Button_SaveImpuesto.ForeColor = Color.WhiteSmoke;
      this.Button_SaveImpuesto.Image = (Image) TriNetRestPOS.My.Resources.Resources.check_OK;
      this.Button_SaveImpuesto.ImageAlign = ContentAlignment.TopCenter;
      this.Button_SaveImpuesto.Location = new Point(250, 213);
      this.Button_SaveImpuesto.Name = "Button_SaveImpuesto";
      this.Button_SaveImpuesto.Padding = new Padding(0, 5, 0, 5);
      this.Button_SaveImpuesto.Size = new Size(121, 60);
      this.Button_SaveImpuesto.TabIndex = 303;
      this.Button_SaveImpuesto.Text = "Guardar Imp";
      this.Button_SaveImpuesto.TextAlign = ContentAlignment.BottomCenter;
      this.Button_SaveImpuesto.UseVisualStyleBackColor = true;
      this.GroupBox_Price3.Controls.Add((Control) this.CheckBox_Tax3_03);
      this.GroupBox_Price3.Controls.Add((Control) this.CheckBox_Tax2_03);
      this.GroupBox_Price3.Controls.Add((Control) this.CheckBox_Tax1_03);
      this.GroupBox_Price3.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.GroupBox_Price3.ForeColor = Color.FromArgb(209, 102, 61);
      this.GroupBox_Price3.Location = new Point(15, 150);
      this.GroupBox_Price3.Name = "GroupBox_Price3";
      this.GroupBox_Price3.Size = new Size(220, 130);
      this.GroupBox_Price3.TabIndex = 301;
      this.GroupBox_Price3.TabStop = false;
      this.GroupBox_Price3.Text = "Precio";
      this.CheckBox_Tax3_03.AutoSize = true;
      this.CheckBox_Tax3_03.FlatStyle = FlatStyle.Flat;
      this.CheckBox_Tax3_03.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.CheckBox_Tax3_03.ForeColor = Color.FromArgb(150, 150, 150);
      this.CheckBox_Tax3_03.Location = new Point(7, 90);
      this.CheckBox_Tax3_03.Name = "CheckBox_Tax3_03";
      this.CheckBox_Tax3_03.Size = new Size(54, 20);
      this.CheckBox_Tax3_03.TabIndex = 5;
      this.CheckBox_Tax3_03.Text = "Tax3";
      this.CheckBox_Tax3_03.UseVisualStyleBackColor = true;
      this.CheckBox_Tax2_03.AutoSize = true;
      this.CheckBox_Tax2_03.FlatStyle = FlatStyle.Flat;
      this.CheckBox_Tax2_03.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.CheckBox_Tax2_03.ForeColor = Color.FromArgb(150, 150, 150);
      this.CheckBox_Tax2_03.Location = new Point(7, 63);
      this.CheckBox_Tax2_03.Name = "CheckBox_Tax2_03";
      this.CheckBox_Tax2_03.Size = new Size(54, 20);
      this.CheckBox_Tax2_03.TabIndex = 4;
      this.CheckBox_Tax2_03.Text = "Tax2";
      this.CheckBox_Tax2_03.UseVisualStyleBackColor = true;
      this.CheckBox_Tax1_03.AutoSize = true;
      this.CheckBox_Tax1_03.FlatStyle = FlatStyle.Flat;
      this.CheckBox_Tax1_03.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.CheckBox_Tax1_03.ForeColor = Color.FromArgb(150, 150, 150);
      this.CheckBox_Tax1_03.Location = new Point(7, 36);
      this.CheckBox_Tax1_03.Name = "CheckBox_Tax1_03";
      this.CheckBox_Tax1_03.Size = new Size(54, 20);
      this.CheckBox_Tax1_03.TabIndex = 3;
      this.CheckBox_Tax1_03.Text = "Tax1";
      this.CheckBox_Tax1_03.UseVisualStyleBackColor = true;
      this.GroupBox_Price2.Controls.Add((Control) this.CheckBox_Tax3_02);
      this.GroupBox_Price2.Controls.Add((Control) this.CheckBox_Tax2_02);
      this.GroupBox_Price2.Controls.Add((Control) this.CheckBox_Tax1_02);
      this.GroupBox_Price2.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.GroupBox_Price2.ForeColor = Color.FromArgb(209, 102, 61);
      this.GroupBox_Price2.Location = new Point(250, 17);
      this.GroupBox_Price2.Name = "GroupBox_Price2";
      this.GroupBox_Price2.Size = new Size(220, 125);
      this.GroupBox_Price2.TabIndex = 201;
      this.GroupBox_Price2.TabStop = false;
      this.GroupBox_Price2.Text = "Precio";
      this.CheckBox_Tax3_02.AutoSize = true;
      this.CheckBox_Tax3_02.FlatStyle = FlatStyle.Flat;
      this.CheckBox_Tax3_02.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.CheckBox_Tax3_02.ForeColor = Color.FromArgb(150, 150, 150);
      this.CheckBox_Tax3_02.Location = new Point(6, 82);
      this.CheckBox_Tax3_02.Name = "CheckBox_Tax3_02";
      this.CheckBox_Tax3_02.Size = new Size(54, 20);
      this.CheckBox_Tax3_02.TabIndex = 5;
      this.CheckBox_Tax3_02.Text = "Tax3";
      this.CheckBox_Tax3_02.UseVisualStyleBackColor = true;
      this.CheckBox_Tax2_02.AutoSize = true;
      this.CheckBox_Tax2_02.FlatStyle = FlatStyle.Flat;
      this.CheckBox_Tax2_02.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.CheckBox_Tax2_02.ForeColor = Color.FromArgb(150, 150, 150);
      this.CheckBox_Tax2_02.Location = new Point(6, 54);
      this.CheckBox_Tax2_02.Name = "CheckBox_Tax2_02";
      this.CheckBox_Tax2_02.Size = new Size(54, 20);
      this.CheckBox_Tax2_02.TabIndex = 4;
      this.CheckBox_Tax2_02.Text = "Tax2";
      this.CheckBox_Tax2_02.UseVisualStyleBackColor = true;
      this.CheckBox_Tax1_02.AutoSize = true;
      this.CheckBox_Tax1_02.FlatStyle = FlatStyle.Flat;
      this.CheckBox_Tax1_02.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.CheckBox_Tax1_02.ForeColor = Color.FromArgb(150, 150, 150);
      this.CheckBox_Tax1_02.Location = new Point(6, 26);
      this.CheckBox_Tax1_02.Name = "CheckBox_Tax1_02";
      this.CheckBox_Tax1_02.Size = new Size(54, 20);
      this.CheckBox_Tax1_02.TabIndex = 3;
      this.CheckBox_Tax1_02.Text = "Tax1";
      this.CheckBox_Tax1_02.UseVisualStyleBackColor = true;
      this.GroupBox_Price1.Controls.Add((Control) this.CheckBox_Tax3_01);
      this.GroupBox_Price1.Controls.Add((Control) this.CheckBox_Tax2_01);
      this.GroupBox_Price1.Controls.Add((Control) this.CheckBox_Tax1_01);
      this.GroupBox_Price1.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.GroupBox_Price1.ForeColor = Color.FromArgb(209, 102, 61);
      this.GroupBox_Price1.Location = new Point(15, 15);
      this.GroupBox_Price1.Name = "GroupBox_Price1";
      this.GroupBox_Price1.Size = new Size(220, 129);
      this.GroupBox_Price1.TabIndex = 101;
      this.GroupBox_Price1.TabStop = false;
      this.GroupBox_Price1.Text = "Precio";
      this.CheckBox_Tax3_01.AutoSize = true;
      this.CheckBox_Tax3_01.FlatStyle = FlatStyle.Flat;
      this.CheckBox_Tax3_01.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.CheckBox_Tax3_01.ForeColor = Color.FromArgb(150, 150, 150);
      this.CheckBox_Tax3_01.Location = new Point(9, 84);
      this.CheckBox_Tax3_01.Name = "CheckBox_Tax3_01";
      this.CheckBox_Tax3_01.Size = new Size(54, 20);
      this.CheckBox_Tax3_01.TabIndex = 5;
      this.CheckBox_Tax3_01.Text = "Tax3";
      this.CheckBox_Tax3_01.UseVisualStyleBackColor = true;
      this.CheckBox_Tax2_01.AutoSize = true;
      this.CheckBox_Tax2_01.FlatStyle = FlatStyle.Flat;
      this.CheckBox_Tax2_01.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.CheckBox_Tax2_01.ForeColor = Color.FromArgb(150, 150, 150);
      this.CheckBox_Tax2_01.Location = new Point(9, 56);
      this.CheckBox_Tax2_01.Name = "CheckBox_Tax2_01";
      this.CheckBox_Tax2_01.Size = new Size(54, 20);
      this.CheckBox_Tax2_01.TabIndex = 4;
      this.CheckBox_Tax2_01.Text = "Tax2";
      this.CheckBox_Tax2_01.UseVisualStyleBackColor = true;
      this.CheckBox_Tax1_01.AutoSize = true;
      this.CheckBox_Tax1_01.FlatStyle = FlatStyle.Flat;
      this.CheckBox_Tax1_01.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.CheckBox_Tax1_01.ForeColor = Color.FromArgb(150, 150, 150);
      this.CheckBox_Tax1_01.Location = new Point(9, 28);
      this.CheckBox_Tax1_01.Name = "CheckBox_Tax1_01";
      this.CheckBox_Tax1_01.Size = new Size(54, 20);
      this.CheckBox_Tax1_01.TabIndex = 3;
      this.CheckBox_Tax1_01.Text = "Tax1";
      this.CheckBox_Tax1_01.UseVisualStyleBackColor = true;
      this.HeaderPanel4.set_BorderColor(SystemColors.ActiveCaption);
      this.HeaderPanel4.set_BorderStyle((BorderStyles) 1);
      this.HeaderPanel4.set_CaptionBeginColor(Color.FromArgb(209, 102, 61));
      this.HeaderPanel4.set_CaptionEndColor(Color.FromArgb(209, 102, 61));
      this.HeaderPanel4.set_CaptionGradientDirection(LinearGradientMode.Vertical);
      this.HeaderPanel4.set_CaptionHeight(26);
      this.HeaderPanel4.set_CaptionPosition((CaptionPositions) 0);
      this.HeaderPanel4.set_CaptionText("Cargos");
      this.HeaderPanel4.set_CaptionVisible(true);
      ((Control) this.HeaderPanel4).Controls.Add((Control) this.Label_Yes);
      ((Control) this.HeaderPanel4).Controls.Add((Control) this.Label_Description);
      ((Control) this.HeaderPanel4).Controls.Add((Control) this.CheckBox_Tax3);
      ((Control) this.HeaderPanel4).Controls.Add((Control) this.Label_Tax2);
      ((Control) this.HeaderPanel4).Controls.Add((Control) this.CheckBox_Tax2);
      ((Control) this.HeaderPanel4).Controls.Add((Control) this.TextBox_Tax2);
      ((Control) this.HeaderPanel4).Controls.Add((Control) this.CheckBox_Tax1);
      ((Control) this.HeaderPanel4).Controls.Add((Control) this.TextBox_Tax1);
      ((Control) this.HeaderPanel4).Controls.Add((Control) this.Label_Value);
      ((Control) this.HeaderPanel4).Controls.Add((Control) this.Label_Tax1);
      ((Control) this.HeaderPanel4).Controls.Add((Control) this.Label_Tax3);
      ((Control) this.HeaderPanel4).Controls.Add((Control) this.NumericTexBox_Tax3);
      ((Control) this.HeaderPanel4).Controls.Add((Control) this.TextBox_Tax3);
      ((Control) this.HeaderPanel4).Controls.Add((Control) this.NumericTexBox_Tax2);
      ((Control) this.HeaderPanel4).Controls.Add((Control) this.NumericTexBox_Tax1);
      this.HeaderPanel4.set_Font(new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0));
      ((Control) this.HeaderPanel4).ForeColor = Color.WhiteSmoke;
      this.HeaderPanel4.set_GradientDirection(LinearGradientMode.Vertical);
      this.HeaderPanel4.set_GradientEnd(SystemColors.Window);
      this.HeaderPanel4.set_GradientStart(SystemColors.Window);
      ((Control) this.HeaderPanel4).Location = new Point(0, 289);
      ((Control) this.HeaderPanel4).Name = "HeaderPanel4";
      this.HeaderPanel4.set_PanelIcon((Icon) null);
      this.HeaderPanel4.set_PanelIconVisible(false);
      ((Control) this.HeaderPanel4).Size = new Size(460, 140);
      ((Control) this.HeaderPanel4).TabIndex = 191;
      this.HeaderPanel4.set_TextAntialias(true);
      this.Button_TNS.BackgroundImage = (Image) componentResourceManager.GetObject("Button_TNS.BackgroundImage");
      this.Button_TNS.FlatStyle = FlatStyle.Flat;
      this.Button_TNS.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Button_TNS.ForeColor = Color.WhiteSmoke;
      this.Button_TNS.Image = (Image) TriNetRestPOS.My.Resources.Resources.check_OK;
      this.Button_TNS.ImageAlign = ContentAlignment.TopCenter;
      this.Button_TNS.Location = new Point(464, 653);
      this.Button_TNS.Name = "Button_TNS";
      this.Button_TNS.Padding = new Padding(0, 5, 0, 5);
      this.Button_TNS.Size = new Size(102, 66);
      this.Button_TNS.TabIndex = 192;
      this.Button_TNS.Text = "TNS";
      this.Button_TNS.TextAlign = ContentAlignment.BottomCenter;
      this.Button_TNS.UseVisualStyleBackColor = true;
      this.TextBox_MessageCommand.BorderStyle = BorderStyle.FixedSingle;
      this.TextBox_MessageCommand.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.TextBox_MessageCommand.ForeColor = Color.FromArgb(150, 150, 150);
      this.TextBox_MessageCommand.Location = new Point(8, 92);
      this.TextBox_MessageCommand.MaxLength = 200;
      this.TextBox_MessageCommand.Multiline = true;
      this.TextBox_MessageCommand.Name = "TextBox_MessageCommand";
      this.TextBox_MessageCommand.ScrollBars = ScrollBars.Vertical;
      this.TextBox_MessageCommand.Size = new Size(440, 50);
      this.TextBox_MessageCommand.TabIndex = 227;
      this.Label6.AutoSize = true;
      this.Label6.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Label6.ForeColor = Color.FromArgb(150, 150, 150);
      this.Label6.Location = new Point(3, 69);
      this.Label6.Name = "Label6";
      this.Label6.Size = new Size(143, 16);
      this.Label6.TabIndex = 226;
      this.Label6.Text = "Mensaje en Comanda:";
      this.TextBox_CommandTwo.BorderStyle = BorderStyle.FixedSingle;
      this.TextBox_CommandTwo.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.TextBox_CommandTwo.ForeColor = Color.FromArgb(150, 150, 150);
      this.TextBox_CommandTwo.Location = new Point(143, 37);
      this.TextBox_CommandTwo.MaxLength = 30;
      this.TextBox_CommandTwo.Multiline = true;
      this.TextBox_CommandTwo.Name = "TextBox_CommandTwo";
      this.TextBox_CommandTwo.Size = new Size(305, 20);
      this.TextBox_CommandTwo.TabIndex = 216;
      this.TextBox_CommandOne.BorderStyle = BorderStyle.FixedSingle;
      this.TextBox_CommandOne.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.TextBox_CommandOne.ForeColor = Color.FromArgb(150, 150, 150);
      this.TextBox_CommandOne.Location = new Point(143, 7);
      this.TextBox_CommandOne.MaxLength = 30;
      this.TextBox_CommandOne.Multiline = true;
      this.TextBox_CommandOne.Name = "TextBox_CommandOne";
      this.TextBox_CommandOne.Size = new Size(305, 20);
      this.TextBox_CommandOne.TabIndex = 215;
      this.Label2.AutoSize = true;
      this.Label2.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Label2.ForeColor = Color.FromArgb(150, 150, 150);
      this.Label2.Location = new Point(3, 10);
      this.Label2.Name = "Label2";
      this.Label2.Size = new Size(117, 16);
      this.Label2.TabIndex = 214;
      this.Label2.Text = "Texto Comanda 1:";
      this.Label1.AutoSize = true;
      this.Label1.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Label1.ForeColor = Color.FromArgb(150, 150, 150);
      this.Label1.Location = new Point(3, 40);
      this.Label1.Name = "Label1";
      this.Label1.Size = new Size(117, 16);
      this.Label1.TabIndex = 213;
      this.Label1.Text = "Texto Comanda 2:";
      this.HeaderPanel2.set_BorderColor(SystemColors.ActiveCaption);
      this.HeaderPanel2.set_BorderStyle((BorderStyles) 1);
      this.HeaderPanel2.set_CaptionBeginColor(Color.FromArgb(209, 102, 61));
      this.HeaderPanel2.set_CaptionEndColor(Color.FromArgb(209, 102, 61));
      this.HeaderPanel2.set_CaptionGradientDirection(LinearGradientMode.Vertical);
      this.HeaderPanel2.set_CaptionHeight(26);
      this.HeaderPanel2.set_CaptionPosition((CaptionPositions) 0);
      this.HeaderPanel2.set_CaptionText("Opciones de Impresión");
      this.HeaderPanel2.set_CaptionVisible(true);
      ((Control) this.HeaderPanel2).Controls.Add((Control) this.TextBox_MessageCommand);
      ((Control) this.HeaderPanel2).Controls.Add((Control) this.Label1);
      ((Control) this.HeaderPanel2).Controls.Add((Control) this.Label2);
      ((Control) this.HeaderPanel2).Controls.Add((Control) this.TextBox_CommandOne);
      ((Control) this.HeaderPanel2).Controls.Add((Control) this.TextBox_CommandTwo);
      ((Control) this.HeaderPanel2).Controls.Add((Control) this.Label6);
      this.HeaderPanel2.set_Font(new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0));
      ((Control) this.HeaderPanel2).ForeColor = Color.WhiteSmoke;
      this.HeaderPanel2.set_GradientDirection(LinearGradientMode.Vertical);
      this.HeaderPanel2.set_GradientEnd(SystemColors.Window);
      this.HeaderPanel2.set_GradientStart(SystemColors.Window);
      ((Control) this.HeaderPanel2).Location = new Point(0, 502);
      ((Control) this.HeaderPanel2).Name = "HeaderPanel2";
      this.HeaderPanel2.set_PanelIcon((Icon) null);
      this.HeaderPanel2.set_PanelIconVisible(false);
      ((Control) this.HeaderPanel2).Size = new Size(460, 177);
      ((Control) this.HeaderPanel2).TabIndex = 194;
      this.HeaderPanel2.set_TextAntialias(true);
      this.btnConfigurarCorreo.BackgroundImage = (Image) componentResourceManager.GetObject("btnConfigurarCorreo.BackgroundImage");
      this.btnConfigurarCorreo.FlatStyle = FlatStyle.Flat;
      this.btnConfigurarCorreo.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.btnConfigurarCorreo.ForeColor = Color.WhiteSmoke;
      this.btnConfigurarCorreo.Image = (Image) TriNetRestPOS.My.Resources.Resources.icono_correo;
      this.btnConfigurarCorreo.ImageAlign = ContentAlignment.TopCenter;
      this.btnConfigurarCorreo.Location = new Point(569, 653);
      this.btnConfigurarCorreo.Name = "btnConfigurarCorreo";
      this.btnConfigurarCorreo.Padding = new Padding(0, 5, 0, 5);
      this.btnConfigurarCorreo.Size = new Size(102, 66);
      this.btnConfigurarCorreo.TabIndex = 195;
      this.btnConfigurarCorreo.Text = "Conf Correo";
      this.btnConfigurarCorreo.TextAlign = ContentAlignment.BottomCenter;
      this.btnConfigurarCorreo.UseVisualStyleBackColor = true;
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.BackColor = Color.White;
      this.ClientSize = new Size(1010, 718);
      this.Controls.Add((Control) this.btnConfigurarCorreo);
      this.Controls.Add((Control) this.HeaderPanel2);
      this.Controls.Add((Control) this.Button_GoOut);
      this.Controls.Add((Control) this.Button_Save);
      this.Controls.Add((Control) this.Button_TNS);
      this.Controls.Add((Control) this.HeaderPanel4);
      this.Controls.Add((Control) this.HeaderPanel3);
      this.Controls.Add((Control) this.HeaderPanel_DonwloadOption);
      this.Controls.Add((Control) this.HeaderPanel1);
      this.FormBorderStyle = FormBorderStyle.FixedDialog;
      this.KeyPreview = true;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = nameof (FrmCfgNegocio);
      this.ShowIcon = false;
      this.ShowInTaskbar = false;
      this.StartPosition = FormStartPosition.CenterParent;
      this.Text = "Configuración del Negocio";
      ((Control) this.HeaderPanel1).ResumeLayout(false);
      ((Control) this.HeaderPanel1).PerformLayout();
      ((Control) this.HeaderPanel_DonwloadOption).ResumeLayout(false);
      ((Control) this.HeaderPanel_DonwloadOption).PerformLayout();
      ((Control) this.HeaderPanel3).ResumeLayout(false);
      this.tcRuta.ResumeLayout(false);
      this.TabPage1.ResumeLayout(false);
      this.TabPage1.PerformLayout();
      this.TabPage2.ResumeLayout(false);
      this.TabPage2.PerformLayout();
      this.tbcVariables.ResumeLayout(false);
      this.tpgPrincipal.ResumeLayout(false);
      this.tpgPrincipal.PerformLayout();
      this.tpgSegundo.ResumeLayout(false);
      this.tpgSegundo.PerformLayout();
      this.tgpTercero.ResumeLayout(false);
      this.GroupBox_Price3.ResumeLayout(false);
      this.GroupBox_Price3.PerformLayout();
      this.GroupBox_Price2.ResumeLayout(false);
      this.GroupBox_Price2.PerformLayout();
      this.GroupBox_Price1.ResumeLayout(false);
      this.GroupBox_Price1.PerformLayout();
      ((Control) this.HeaderPanel4).ResumeLayout(false);
      ((Control) this.HeaderPanel4).PerformLayout();
      ((Control) this.HeaderPanel2).ResumeLayout(false);
      ((Control) this.HeaderPanel2).PerformLayout();
      this.ResumeLayout(false);
    }

    internal virtual Label Label_SocialReason { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual TextBox TextBox_SocialReason
    {
      get
      {
        return this._TextBox_SocialReason;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        KeyPressEventHandler pressEventHandler = new KeyPressEventHandler(this.Control_KeyPress);
        TextBox textBoxSocialReason1 = this._TextBox_SocialReason;
        if (textBoxSocialReason1 != null)
          textBoxSocialReason1.KeyPress -= pressEventHandler;
        this._TextBox_SocialReason = value;
        TextBox textBoxSocialReason2 = this._TextBox_SocialReason;
        if (textBoxSocialReason2 == null)
          return;
        textBoxSocialReason2.KeyPress += pressEventHandler;
      }
    }

    internal virtual Label Label_CommercialReason { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual TextBox TextBox_CommercialReason
    {
      get
      {
        return this._TextBox_CommercialReason;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        KeyPressEventHandler pressEventHandler = new KeyPressEventHandler(this.Control_KeyPress);
        TextBox commercialReason1 = this._TextBox_CommercialReason;
        if (commercialReason1 != null)
          commercialReason1.KeyPress -= pressEventHandler;
        this._TextBox_CommercialReason = value;
        TextBox commercialReason2 = this._TextBox_CommercialReason;
        if (commercialReason2 == null)
          return;
        commercialReason2.KeyPress += pressEventHandler;
      }
    }

    internal virtual Label Label_Address { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual TextBox TextBox_Address
    {
      get
      {
        return this._TextBox_Address;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        KeyPressEventHandler pressEventHandler = new KeyPressEventHandler(this.Control_KeyPress);
        TextBox textBoxAddress1 = this._TextBox_Address;
        if (textBoxAddress1 != null)
          textBoxAddress1.KeyPress -= pressEventHandler;
        this._TextBox_Address = value;
        TextBox textBoxAddress2 = this._TextBox_Address;
        if (textBoxAddress2 == null)
          return;
        textBoxAddress2.KeyPress += pressEventHandler;
      }
    }

    internal virtual Label Label_Email { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Label Label_PhoneNumber { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual TextBox TextBox_PhoneNumber
    {
      get
      {
        return this._TextBox_PhoneNumber;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        KeyPressEventHandler pressEventHandler = new KeyPressEventHandler(this.Control_KeyPress);
        TextBox textBoxPhoneNumber1 = this._TextBox_PhoneNumber;
        if (textBoxPhoneNumber1 != null)
          textBoxPhoneNumber1.KeyPress -= pressEventHandler;
        this._TextBox_PhoneNumber = value;
        TextBox textBoxPhoneNumber2 = this._TextBox_PhoneNumber;
        if (textBoxPhoneNumber2 == null)
          return;
        textBoxPhoneNumber2.KeyPress += pressEventHandler;
      }
    }

    internal virtual Label Label_WebPage { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Label Label_TributaryId { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual TextBox TextBox_TributaryId
    {
      get
      {
        return this._TextBox_TributaryId;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        KeyPressEventHandler pressEventHandler = new KeyPressEventHandler(this.Control_KeyPress);
        TextBox textBoxTributaryId1 = this._TextBox_TributaryId;
        if (textBoxTributaryId1 != null)
          textBoxTributaryId1.KeyPress -= pressEventHandler;
        this._TextBox_TributaryId = value;
        TextBox textBoxTributaryId2 = this._TextBox_TributaryId;
        if (textBoxTributaryId2 == null)
          return;
        textBoxTributaryId2.KeyPress += pressEventHandler;
      }
    }

    internal virtual TextBox TextBox_Tax3
    {
      get
      {
        return this._TextBox_Tax3;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        KeyPressEventHandler pressEventHandler = new KeyPressEventHandler(this.Control_KeyPress);
        TextBox textBoxTax3_1 = this._TextBox_Tax3;
        if (textBoxTax3_1 != null)
          textBoxTax3_1.KeyPress -= pressEventHandler;
        this._TextBox_Tax3 = value;
        TextBox textBoxTax3_2 = this._TextBox_Tax3;
        if (textBoxTax3_2 == null)
          return;
        textBoxTax3_2.KeyPress += pressEventHandler;
      }
    }

    internal virtual Label Label_Tax3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Label Label_Tax1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual TextBox TextBox_Tax1
    {
      get
      {
        return this._TextBox_Tax1;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        KeyPressEventHandler pressEventHandler = new KeyPressEventHandler(this.Control_KeyPress);
        TextBox textBoxTax1_1 = this._TextBox_Tax1;
        if (textBoxTax1_1 != null)
          textBoxTax1_1.KeyPress -= pressEventHandler;
        this._TextBox_Tax1 = value;
        TextBox textBoxTax1_2 = this._TextBox_Tax1;
        if (textBoxTax1_2 == null)
          return;
        textBoxTax1_2.KeyPress += pressEventHandler;
      }
    }

    internal virtual TextBox TextBox_Tax2
    {
      get
      {
        return this._TextBox_Tax2;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        KeyPressEventHandler pressEventHandler = new KeyPressEventHandler(this.Control_KeyPress);
        TextBox textBoxTax2_1 = this._TextBox_Tax2;
        if (textBoxTax2_1 != null)
          textBoxTax2_1.KeyPress -= pressEventHandler;
        this._TextBox_Tax2 = value;
        TextBox textBoxTax2_2 = this._TextBox_Tax2;
        if (textBoxTax2_2 == null)
          return;
        textBoxTax2_2.KeyPress += pressEventHandler;
      }
    }

    internal virtual Label Label_Tax2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual NumericTextBox.NumericTextBox NumericTexBox_Tax3
    {
      get
      {
        return this._NumericTexBox_Tax3;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        KeyPressEventHandler pressEventHandler = new KeyPressEventHandler(this.Control_KeyPress);
        NumericTextBox.NumericTextBox numericTexBoxTax3_1 = this._NumericTexBox_Tax3;
        if (numericTexBoxTax3_1 != null)
          ((Control) numericTexBoxTax3_1).KeyPress -= pressEventHandler;
        this._NumericTexBox_Tax3 = value;
        NumericTextBox.NumericTextBox numericTexBoxTax3_2 = this._NumericTexBox_Tax3;
        if (numericTexBoxTax3_2 == null)
          return;
        ((Control) numericTexBoxTax3_2).KeyPress += pressEventHandler;
      }
    }

    internal virtual NumericTextBox.NumericTextBox NumericTexBox_Tax2
    {
      get
      {
        return this._NumericTexBox_Tax2;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        KeyPressEventHandler pressEventHandler = new KeyPressEventHandler(this.Control_KeyPress);
        NumericTextBox.NumericTextBox numericTexBoxTax2_1 = this._NumericTexBox_Tax2;
        if (numericTexBoxTax2_1 != null)
          ((Control) numericTexBoxTax2_1).KeyPress -= pressEventHandler;
        this._NumericTexBox_Tax2 = value;
        NumericTextBox.NumericTextBox numericTexBoxTax2_2 = this._NumericTexBox_Tax2;
        if (numericTexBoxTax2_2 == null)
          return;
        ((Control) numericTexBoxTax2_2).KeyPress += pressEventHandler;
      }
    }

    internal virtual NumericTextBox.NumericTextBox NumericTexBox_Tax1
    {
      get
      {
        return this._NumericTexBox_Tax1;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        KeyPressEventHandler pressEventHandler = new KeyPressEventHandler(this.Control_KeyPress);
        NumericTextBox.NumericTextBox numericTexBoxTax1_1 = this._NumericTexBox_Tax1;
        if (numericTexBoxTax1_1 != null)
          ((Control) numericTexBoxTax1_1).KeyPress -= pressEventHandler;
        this._NumericTexBox_Tax1 = value;
        NumericTextBox.NumericTextBox numericTexBoxTax1_2 = this._NumericTexBox_Tax1;
        if (numericTexBoxTax1_2 == null)
          return;
        ((Control) numericTexBoxTax1_2).KeyPress += pressEventHandler;
      }
    }

    internal virtual Label Label_Value { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Label Label_Description { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual CheckBox CheckBox_Tax3
    {
      get
      {
        return this._CheckBox_Tax3;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        KeyPressEventHandler pressEventHandler = new KeyPressEventHandler(this.Control_KeyPress);
        EventHandler eventHandler = new EventHandler(this.CheckBox_Tax3_CheckedChanged);
        CheckBox checkBoxTax3_1 = this._CheckBox_Tax3;
        if (checkBoxTax3_1 != null)
        {
          checkBoxTax3_1.KeyPress -= pressEventHandler;
          checkBoxTax3_1.CheckedChanged -= eventHandler;
        }
        this._CheckBox_Tax3 = value;
        CheckBox checkBoxTax3_2 = this._CheckBox_Tax3;
        if (checkBoxTax3_2 == null)
          return;
        checkBoxTax3_2.KeyPress += pressEventHandler;
        checkBoxTax3_2.CheckedChanged += eventHandler;
      }
    }

    internal virtual CheckBox CheckBox_Tax2
    {
      get
      {
        return this._CheckBox_Tax2;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        KeyPressEventHandler pressEventHandler = new KeyPressEventHandler(this.Control_KeyPress);
        EventHandler eventHandler = new EventHandler(this.CheckBox_Tax2_CheckedChanged);
        CheckBox checkBoxTax2_1 = this._CheckBox_Tax2;
        if (checkBoxTax2_1 != null)
        {
          checkBoxTax2_1.KeyPress -= pressEventHandler;
          checkBoxTax2_1.CheckedChanged -= eventHandler;
        }
        this._CheckBox_Tax2 = value;
        CheckBox checkBoxTax2_2 = this._CheckBox_Tax2;
        if (checkBoxTax2_2 == null)
          return;
        checkBoxTax2_2.KeyPress += pressEventHandler;
        checkBoxTax2_2.CheckedChanged += eventHandler;
      }
    }

    internal virtual CheckBox CheckBox_Tax1
    {
      get
      {
        return this._CheckBox_Tax1;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        KeyPressEventHandler pressEventHandler = new KeyPressEventHandler(this.Control_KeyPress);
        EventHandler eventHandler = new EventHandler(this.CheckBox_Tax1_CheckedChanged);
        CheckBox checkBoxTax1_1 = this._CheckBox_Tax1;
        if (checkBoxTax1_1 != null)
        {
          checkBoxTax1_1.KeyPress -= pressEventHandler;
          checkBoxTax1_1.CheckedChanged -= eventHandler;
        }
        this._CheckBox_Tax1 = value;
        CheckBox checkBoxTax1_2 = this._CheckBox_Tax1;
        if (checkBoxTax1_2 == null)
          return;
        checkBoxTax1_2.KeyPress += pressEventHandler;
        checkBoxTax1_2.CheckedChanged += eventHandler;
      }
    }

    internal virtual Label Label_Yes { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

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

    internal virtual Button Button_Save
    {
      get
      {
        return this._Button_Save;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Button_Save_Click);
        Button buttonSave1 = this._Button_Save;
        if (buttonSave1 != null)
          buttonSave1.Click -= eventHandler;
        this._Button_Save = value;
        Button buttonSave2 = this._Button_Save;
        if (buttonSave2 == null)
          return;
        buttonSave2.Click += eventHandler;
      }
    }

    internal virtual TextBox TextBox_PathBackup
    {
      get
      {
        return this._TextBox_PathBackup;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        KeyPressEventHandler pressEventHandler = new KeyPressEventHandler(this.Control_KeyPress);
        TextBox textBoxPathBackup1 = this._TextBox_PathBackup;
        if (textBoxPathBackup1 != null)
          textBoxPathBackup1.KeyPress -= pressEventHandler;
        this._TextBox_PathBackup = value;
        TextBox textBoxPathBackup2 = this._TextBox_PathBackup;
        if (textBoxPathBackup2 == null)
          return;
        textBoxPathBackup2.KeyPress += pressEventHandler;
      }
    }

    internal virtual Button Button_PathBackUp
    {
      get
      {
        return this._Button_PathBackUp;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Button_PathBackUp_Click);
        Button buttonPathBackUp1 = this._Button_PathBackUp;
        if (buttonPathBackUp1 != null)
          buttonPathBackUp1.Click -= eventHandler;
        this._Button_PathBackUp = value;
        Button buttonPathBackUp2 = this._Button_PathBackUp;
        if (buttonPathBackUp2 == null)
          return;
        buttonPathBackUp2.Click += eventHandler;
      }
    }

    internal virtual DirectorySearcher DirectorySearcher_Path { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual FolderBrowserDialog FolderBrowserDialog1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual OpenFileDialog OpenFileDialog_SearchPath { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual FolderBrowserDialog FolderBrowserDialog_SearchPath { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Label Label_WithStore { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual CheckBox CheckBox_WithStore
    {
      get
      {
        return this._CheckBox_WithStore;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler1 = new EventHandler(this.CheckBox_WithStore_CheckedChanged);
        EventHandler eventHandler2 = new EventHandler(this.CheckBox_WithStore_CheckStateChanged);
        KeyPressEventHandler pressEventHandler = new KeyPressEventHandler(this.Control_KeyPress);
        CheckBox checkBoxWithStore1 = this._CheckBox_WithStore;
        if (checkBoxWithStore1 != null)
        {
          checkBoxWithStore1.CheckedChanged -= eventHandler1;
          checkBoxWithStore1.CheckStateChanged -= eventHandler2;
          checkBoxWithStore1.KeyPress -= pressEventHandler;
        }
        this._CheckBox_WithStore = value;
        CheckBox checkBoxWithStore2 = this._CheckBox_WithStore;
        if (checkBoxWithStore2 == null)
          return;
        checkBoxWithStore2.CheckedChanged += eventHandler1;
        checkBoxWithStore2.CheckStateChanged += eventHandler2;
        checkBoxWithStore2.KeyPress += pressEventHandler;
      }
    }

    internal virtual CheckBox CheckBox_UnloadDirect
    {
      get
      {
        return this._CheckBox_UnloadDirect;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        KeyPressEventHandler pressEventHandler = new KeyPressEventHandler(this.Control_KeyPress);
        EventHandler eventHandler = new EventHandler(this.CheckBox_UnloadDirect_CheckedChanged);
        CheckBox checkBoxUnloadDirect1 = this._CheckBox_UnloadDirect;
        if (checkBoxUnloadDirect1 != null)
        {
          checkBoxUnloadDirect1.KeyPress -= pressEventHandler;
          checkBoxUnloadDirect1.CheckedChanged -= eventHandler;
        }
        this._CheckBox_UnloadDirect = value;
        CheckBox checkBoxUnloadDirect2 = this._CheckBox_UnloadDirect;
        if (checkBoxUnloadDirect2 == null)
          return;
        checkBoxUnloadDirect2.KeyPress += pressEventHandler;
        checkBoxUnloadDirect2.CheckedChanged += eventHandler;
      }
    }

    internal virtual Label Label_UnloadDirects { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual HeaderPanel HeaderPanel1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual HeaderPanel HeaderPanel_DonwloadOption { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual HeaderPanel HeaderPanel3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual HeaderPanel HeaderPanel4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Button Button_TNS
    {
      get
      {
        return this._Button_TNS;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Button_TNS_Click);
        Button buttonTns1 = this._Button_TNS;
        if (buttonTns1 != null)
          buttonTns1.Click -= eventHandler;
        this._Button_TNS = value;
        Button buttonTns2 = this._Button_TNS;
        if (buttonTns2 == null)
          return;
        buttonTns2.Click += eventHandler;
      }
    }

    internal virtual CheckBox CheckBox_SubGroupOrder
    {
      get
      {
        return this._CheckBox_SubGroupOrder;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.CheckBox_SubGroupOrder_CheckedChanged);
        CheckBox boxSubGroupOrder1 = this._CheckBox_SubGroupOrder;
        if (boxSubGroupOrder1 != null)
          boxSubGroupOrder1.CheckedChanged -= eventHandler;
        this._CheckBox_SubGroupOrder = value;
        CheckBox boxSubGroupOrder2 = this._CheckBox_SubGroupOrder;
        if (boxSubGroupOrder2 == null)
          return;
        boxSubGroupOrder2.CheckedChanged += eventHandler;
      }
    }

    internal virtual CheckBox CheckBox_NotSubGroupOrder
    {
      get
      {
        return this._CheckBox_NotSubGroupOrder;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.CheckBox_NotSubGroupOrder_CheckedChanged);
        CheckBox notSubGroupOrder1 = this._CheckBox_NotSubGroupOrder;
        if (notSubGroupOrder1 != null)
          notSubGroupOrder1.CheckedChanged -= eventHandler;
        this._CheckBox_NotSubGroupOrder = value;
        CheckBox notSubGroupOrder2 = this._CheckBox_NotSubGroupOrder;
        if (notSubGroupOrder2 == null)
          return;
        notSubGroupOrder2.CheckedChanged += eventHandler;
      }
    }

    internal virtual Label Label9 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual TextBox TextBox_CommandTwo { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual TextBox TextBox_CommandOne { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Label Label2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Label Label1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual CheckBox CheckBox_IsPrintCentral
    {
      get
      {
        return this._CheckBox_IsPrintCentral;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.CheckBox_IsPrintCentral_CheckedChanged);
        CheckBox boxIsPrintCentral1 = this._CheckBox_IsPrintCentral;
        if (boxIsPrintCentral1 != null)
          boxIsPrintCentral1.CheckedChanged -= eventHandler;
        this._CheckBox_IsPrintCentral = value;
        CheckBox boxIsPrintCentral2 = this._CheckBox_IsPrintCentral;
        if (boxIsPrintCentral2 == null)
          return;
        boxIsPrintCentral2.CheckedChanged += eventHandler;
      }
    }

    internal virtual CheckBox CheckBox_IsNotPrintCentral
    {
      get
      {
        return this._CheckBox_IsNotPrintCentral;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.CheckBox_IsNotPrintCentral_CheckedChanged);
        CheckBox isNotPrintCentral1 = this._CheckBox_IsNotPrintCentral;
        if (isNotPrintCentral1 != null)
          isNotPrintCentral1.CheckedChanged -= eventHandler;
        this._CheckBox_IsNotPrintCentral = value;
        CheckBox isNotPrintCentral2 = this._CheckBox_IsNotPrintCentral;
        if (isNotPrintCentral2 == null)
          return;
        isNotPrintCentral2.CheckedChanged += eventHandler;
      }
    }

    internal virtual Label Label3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual MaskedTextBox TextBox_WebPage { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual MaskedTextBox TextBox_Email { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Label Label4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual CheckBox CheckBox_PrintProducts
    {
      get
      {
        return this._CheckBox_PrintProducts;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.CheckBox_PrintProducts_CheckedChanged);
        CheckBox boxPrintProducts1 = this._CheckBox_PrintProducts;
        if (boxPrintProducts1 != null)
          boxPrintProducts1.CheckedChanged -= eventHandler;
        this._CheckBox_PrintProducts = value;
        CheckBox boxPrintProducts2 = this._CheckBox_PrintProducts;
        if (boxPrintProducts2 == null)
          return;
        boxPrintProducts2.CheckedChanged += eventHandler;
      }
    }

    internal virtual CheckBox CheckBox_NotPrintProducts
    {
      get
      {
        return this._CheckBox_NotPrintProducts;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.CheckBox_NotPrintProducts_CheckedChanged);
        CheckBox notPrintProducts1 = this._CheckBox_NotPrintProducts;
        if (notPrintProducts1 != null)
          notPrintProducts1.CheckedChanged -= eventHandler;
        this._CheckBox_NotPrintProducts = value;
        CheckBox notPrintProducts2 = this._CheckBox_NotPrintProducts;
        if (notPrintProducts2 == null)
          return;
        notPrintProducts2.CheckedChanged += eventHandler;
      }
    }

    internal virtual CheckBox CheckBox_ShowOpcPrebill
    {
      get
      {
        return this._CheckBox_ShowOpcPrebill;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.CheckBox_ShowOpcPrebill_CheckedChanged);
        CheckBox boxShowOpcPrebill1 = this._CheckBox_ShowOpcPrebill;
        if (boxShowOpcPrebill1 != null)
          boxShowOpcPrebill1.CheckedChanged -= eventHandler;
        this._CheckBox_ShowOpcPrebill = value;
        CheckBox boxShowOpcPrebill2 = this._CheckBox_ShowOpcPrebill;
        if (boxShowOpcPrebill2 == null)
          return;
        boxShowOpcPrebill2.CheckedChanged += eventHandler;
      }
    }

    internal virtual CheckBox CheckBox_NotShowOpcPrebill
    {
      get
      {
        return this._CheckBox_NotShowOpcPrebill;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.CheckBox_NotShowOpcPrebill_CheckedChanged);
        CheckBox notShowOpcPrebill1 = this._CheckBox_NotShowOpcPrebill;
        if (notShowOpcPrebill1 != null)
          notShowOpcPrebill1.CheckedChanged -= eventHandler;
        this._CheckBox_NotShowOpcPrebill = value;
        CheckBox notShowOpcPrebill2 = this._CheckBox_NotShowOpcPrebill;
        if (notShowOpcPrebill2 == null)
          return;
        notShowOpcPrebill2.CheckedChanged += eventHandler;
      }
    }

    internal virtual Label Label5 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual TextBox TextBox_MessageCommand { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Label Label6 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual CheckBox CheckBox_IsUsePoints
    {
      get
      {
        return this._CheckBox_IsUsePoints;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.CheckBox_IsUsePoints_CheckedChanged);
        CheckBox checkBoxIsUsePoints1 = this._CheckBox_IsUsePoints;
        if (checkBoxIsUsePoints1 != null)
          checkBoxIsUsePoints1.CheckedChanged -= eventHandler;
        this._CheckBox_IsUsePoints = value;
        CheckBox checkBoxIsUsePoints2 = this._CheckBox_IsUsePoints;
        if (checkBoxIsUsePoints2 == null)
          return;
        checkBoxIsUsePoints2.CheckedChanged += eventHandler;
      }
    }

    internal virtual CheckBox CheckBox_NotIsUsePoints
    {
      get
      {
        return this._CheckBox_NotIsUsePoints;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.CheckBox_NotIsUsePoints_CheckedChanged);
        CheckBox boxNotIsUsePoints1 = this._CheckBox_NotIsUsePoints;
        if (boxNotIsUsePoints1 != null)
          boxNotIsUsePoints1.CheckedChanged -= eventHandler;
        this._CheckBox_NotIsUsePoints = value;
        CheckBox boxNotIsUsePoints2 = this._CheckBox_NotIsUsePoints;
        if (boxNotIsUsePoints2 == null)
          return;
        boxNotIsUsePoints2.CheckedChanged += eventHandler;
      }
    }

    internal virtual Label Label8 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual CheckBox CheckBox_IsDiscountClients
    {
      get
      {
        return this._CheckBox_IsDiscountClients;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.CheckBox_IsDiscountClients_CheckedChanged);
        CheckBox isDiscountClients1 = this._CheckBox_IsDiscountClients;
        if (isDiscountClients1 != null)
          isDiscountClients1.CheckedChanged -= eventHandler;
        this._CheckBox_IsDiscountClients = value;
        CheckBox isDiscountClients2 = this._CheckBox_IsDiscountClients;
        if (isDiscountClients2 == null)
          return;
        isDiscountClients2.CheckedChanged += eventHandler;
      }
    }

    internal virtual CheckBox CheckBox_NotIsDiscountClients
    {
      get
      {
        return this._CheckBox_NotIsDiscountClients;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.CheckBox_NotIsDiscountClients_CheckedChanged);
        CheckBox isDiscountClients1 = this._CheckBox_NotIsDiscountClients;
        if (isDiscountClients1 != null)
          isDiscountClients1.CheckedChanged -= eventHandler;
        this._CheckBox_NotIsDiscountClients = value;
        CheckBox isDiscountClients2 = this._CheckBox_NotIsDiscountClients;
        if (isDiscountClients2 == null)
          return;
        isDiscountClients2.CheckedChanged += eventHandler;
      }
    }

    internal virtual Label Label7 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Label Label10 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Label Label11 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual ComboBox ComboBox_MonthExpiredPoints { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual CheckBox CheckBox_ShowOffer
    {
      get
      {
        return this._CheckBox_ShowOffer;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.CheckBox_ShowOffer_CheckedChanged);
        CheckBox checkBoxShowOffer1 = this._CheckBox_ShowOffer;
        if (checkBoxShowOffer1 != null)
          checkBoxShowOffer1.CheckedChanged -= eventHandler;
        this._CheckBox_ShowOffer = value;
        CheckBox checkBoxShowOffer2 = this._CheckBox_ShowOffer;
        if (checkBoxShowOffer2 == null)
          return;
        checkBoxShowOffer2.CheckedChanged += eventHandler;
      }
    }

    internal virtual CheckBox CheckBox_NotShowOffer
    {
      get
      {
        return this._CheckBox_NotShowOffer;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.CheckBox_NotShowOffer_CheckedChanged);
        CheckBox checkBoxNotShowOffer1 = this._CheckBox_NotShowOffer;
        if (checkBoxNotShowOffer1 != null)
          checkBoxNotShowOffer1.CheckedChanged -= eventHandler;
        this._CheckBox_NotShowOffer = value;
        CheckBox checkBoxNotShowOffer2 = this._CheckBox_NotShowOffer;
        if (checkBoxNotShowOffer2 == null)
          return;
        checkBoxNotShowOffer2.CheckedChanged += eventHandler;
      }
    }

    internal virtual Label Label12 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual HeaderPanel HeaderPanel2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual CheckBox CheckBox_IsDeleteItemNotSend
    {
      get
      {
        return this._CheckBox_IsDeleteItemNotSend;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.CheckBox_IsDeleteItemNotSend_CheckedChanged);
        CheckBox deleteItemNotSend1 = this._CheckBox_IsDeleteItemNotSend;
        if (deleteItemNotSend1 != null)
          deleteItemNotSend1.CheckedChanged -= eventHandler;
        this._CheckBox_IsDeleteItemNotSend = value;
        CheckBox deleteItemNotSend2 = this._CheckBox_IsDeleteItemNotSend;
        if (deleteItemNotSend2 == null)
          return;
        deleteItemNotSend2.CheckedChanged += eventHandler;
      }
    }

    internal virtual CheckBox CheckBox_IsNotDeleteItemNotSend
    {
      get
      {
        return this._CheckBox_IsNotDeleteItemNotSend;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.CheckBox_IsNotDeleteItemNotSend_CheckedChanged);
        CheckBox deleteItemNotSend1 = this._CheckBox_IsNotDeleteItemNotSend;
        if (deleteItemNotSend1 != null)
          deleteItemNotSend1.CheckedChanged -= eventHandler;
        this._CheckBox_IsNotDeleteItemNotSend = value;
        CheckBox deleteItemNotSend2 = this._CheckBox_IsNotDeleteItemNotSend;
        if (deleteItemNotSend2 == null)
          return;
        deleteItemNotSend2.CheckedChanged += eventHandler;
      }
    }

    internal virtual Label Label14 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual CheckBox CheckBox_IsPrintPrecountSend
    {
      get
      {
        return this._CheckBox_IsPrintPrecountSend;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.CheckBox_IsPrintPrecountSend_CheckedChanged);
        CheckBox printPrecountSend1 = this._CheckBox_IsPrintPrecountSend;
        if (printPrecountSend1 != null)
          printPrecountSend1.CheckedChanged -= eventHandler;
        this._CheckBox_IsPrintPrecountSend = value;
        CheckBox printPrecountSend2 = this._CheckBox_IsPrintPrecountSend;
        if (printPrecountSend2 == null)
          return;
        printPrecountSend2.CheckedChanged += eventHandler;
      }
    }

    internal virtual CheckBox CheckBox_IsNotPrintPrecountSend
    {
      get
      {
        return this._CheckBox_IsNotPrintPrecountSend;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.CheckBox_IsNotPrintPrecountSend_CheckedChanged);
        CheckBox printPrecountSend1 = this._CheckBox_IsNotPrintPrecountSend;
        if (printPrecountSend1 != null)
          printPrecountSend1.CheckedChanged -= eventHandler;
        this._CheckBox_IsNotPrintPrecountSend = value;
        CheckBox printPrecountSend2 = this._CheckBox_IsNotPrintPrecountSend;
        if (printPrecountSend2 == null)
          return;
        printPrecountSend2.CheckedChanged += eventHandler;
      }
    }

    internal virtual Label Label13 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual CheckBox CheckBox_IsPayThenCommnand
    {
      get
      {
        return this._CheckBox_IsPayThenCommnand;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.CheckBox_IsPayThenCommnand_CheckedChanged);
        CheckBox isPayThenCommnand1 = this._CheckBox_IsPayThenCommnand;
        if (isPayThenCommnand1 != null)
          isPayThenCommnand1.CheckedChanged -= eventHandler;
        this._CheckBox_IsPayThenCommnand = value;
        CheckBox isPayThenCommnand2 = this._CheckBox_IsPayThenCommnand;
        if (isPayThenCommnand2 == null)
          return;
        isPayThenCommnand2.CheckedChanged += eventHandler;
      }
    }

    internal virtual CheckBox CheckBox_IsNotPayThenCommnand
    {
      get
      {
        return this._CheckBox_IsNotPayThenCommnand;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.CheckBox_IsNotPayThenCommnand_CheckedChanged);
        CheckBox notPayThenCommnand1 = this._CheckBox_IsNotPayThenCommnand;
        if (notPayThenCommnand1 != null)
          notPayThenCommnand1.CheckedChanged -= eventHandler;
        this._CheckBox_IsNotPayThenCommnand = value;
        CheckBox notPayThenCommnand2 = this._CheckBox_IsNotPayThenCommnand;
        if (notPayThenCommnand2 == null)
          return;
        notPayThenCommnand2.CheckedChanged += eventHandler;
      }
    }

    internal virtual Label Label15 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual CheckBox CheckBox_IsDivCtaNum
    {
      get
      {
        return this._CheckBox_IsDivCtaNum;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.CheckBox_IsDivCtaNum_CheckedChanged);
        CheckBox checkBoxIsDivCtaNum1 = this._CheckBox_IsDivCtaNum;
        if (checkBoxIsDivCtaNum1 != null)
          checkBoxIsDivCtaNum1.CheckedChanged -= eventHandler;
        this._CheckBox_IsDivCtaNum = value;
        CheckBox checkBoxIsDivCtaNum2 = this._CheckBox_IsDivCtaNum;
        if (checkBoxIsDivCtaNum2 == null)
          return;
        checkBoxIsDivCtaNum2.CheckedChanged += eventHandler;
      }
    }

    internal virtual CheckBox CheckBox_IsNotDivCtaNum
    {
      get
      {
        return this._CheckBox_IsNotDivCtaNum;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.CheckBox_IsNotDivCtaNum_CheckedChanged);
        CheckBox boxIsNotDivCtaNum1 = this._CheckBox_IsNotDivCtaNum;
        if (boxIsNotDivCtaNum1 != null)
          boxIsNotDivCtaNum1.CheckedChanged -= eventHandler;
        this._CheckBox_IsNotDivCtaNum = value;
        CheckBox boxIsNotDivCtaNum2 = this._CheckBox_IsNotDivCtaNum;
        if (boxIsNotDivCtaNum2 == null)
          return;
        boxIsNotDivCtaNum2.CheckedChanged += eventHandler;
      }
    }

    internal virtual Label Label17 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual CheckBox CheckBox_IsPersonNum
    {
      get
      {
        return this._CheckBox_IsPersonNum;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.CheckBox_IsPersonNum_CheckedChanged);
        CheckBox checkBoxIsPersonNum1 = this._CheckBox_IsPersonNum;
        if (checkBoxIsPersonNum1 != null)
          checkBoxIsPersonNum1.CheckedChanged -= eventHandler;
        this._CheckBox_IsPersonNum = value;
        CheckBox checkBoxIsPersonNum2 = this._CheckBox_IsPersonNum;
        if (checkBoxIsPersonNum2 == null)
          return;
        checkBoxIsPersonNum2.CheckedChanged += eventHandler;
      }
    }

    internal virtual CheckBox CheckBox_IsNotPersonNum
    {
      get
      {
        return this._CheckBox_IsNotPersonNum;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.CheckBox_IsNotPersonNum_CheckedChanged);
        CheckBox boxIsNotPersonNum1 = this._CheckBox_IsNotPersonNum;
        if (boxIsNotPersonNum1 != null)
          boxIsNotPersonNum1.CheckedChanged -= eventHandler;
        this._CheckBox_IsNotPersonNum = value;
        CheckBox boxIsNotPersonNum2 = this._CheckBox_IsNotPersonNum;
        if (boxIsNotPersonNum2 == null)
          return;
        boxIsNotPersonNum2.CheckedChanged += eventHandler;
      }
    }

    internal virtual Label Label16 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Label Label18 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Label Label19 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual NumericTextBox.NumericTextBox TextBox_AmountUsePoints { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual NumericTextBox.NumericTextBox TextBox_PersonNum { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual NumericTextBox.NumericTextBox TextBox_DivCtaNum { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual CheckBox CheckBox_ShowTax
    {
      get
      {
        return this._CheckBox_ShowTax;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.CheckBox_ShowTax_CheckedChanged);
        CheckBox checkBoxShowTax1 = this._CheckBox_ShowTax;
        if (checkBoxShowTax1 != null)
          checkBoxShowTax1.CheckedChanged -= eventHandler;
        this._CheckBox_ShowTax = value;
        CheckBox checkBoxShowTax2 = this._CheckBox_ShowTax;
        if (checkBoxShowTax2 == null)
          return;
        checkBoxShowTax2.CheckedChanged += eventHandler;
      }
    }

    internal virtual CheckBox CheckBox_NotShowTax
    {
      get
      {
        return this._CheckBox_NotShowTax;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.CheckBox_NotShowTax_CheckedChanged);
        CheckBox checkBoxNotShowTax1 = this._CheckBox_NotShowTax;
        if (checkBoxNotShowTax1 != null)
          checkBoxNotShowTax1.CheckedChanged -= eventHandler;
        this._CheckBox_NotShowTax = value;
        CheckBox checkBoxNotShowTax2 = this._CheckBox_NotShowTax;
        if (checkBoxNotShowTax2 == null)
          return;
        checkBoxNotShowTax2.CheckedChanged += eventHandler;
      }
    }

    internal virtual Label Label20 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Label Label21 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual CheckBox CheckBox_NroSubmesas
    {
      get
      {
        return this._CheckBox_NroSubmesas;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.CheckBox_NroSubmesas_CheckedChanged);
        CheckBox checkBoxNroSubmesas1 = this._CheckBox_NroSubmesas;
        if (checkBoxNroSubmesas1 != null)
          checkBoxNroSubmesas1.CheckedChanged -= eventHandler;
        this._CheckBox_NroSubmesas = value;
        CheckBox checkBoxNroSubmesas2 = this._CheckBox_NroSubmesas;
        if (checkBoxNroSubmesas2 == null)
          return;
        checkBoxNroSubmesas2.CheckedChanged += eventHandler;
      }
    }

    internal virtual CheckBox CheckBox_NotNroSubmesas
    {
      get
      {
        return this._CheckBox_NotNroSubmesas;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.CheckBox_NotNroSubmesas_CheckedChanged);
        CheckBox boxNotNroSubmesas1 = this._CheckBox_NotNroSubmesas;
        if (boxNotNroSubmesas1 != null)
          boxNotNroSubmesas1.CheckedChanged -= eventHandler;
        this._CheckBox_NotNroSubmesas = value;
        CheckBox boxNotNroSubmesas2 = this._CheckBox_NotNroSubmesas;
        if (boxNotNroSubmesas2 == null)
          return;
        boxNotNroSubmesas2.CheckedChanged += eventHandler;
      }
    }

    internal virtual Label Label22 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual ComboBox ComboBox_NroSubmesas { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual CheckBox CheckBox_IsNotPreguntarComanda
    {
      get
      {
        return this._CheckBox_IsNotPreguntarComanda;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.CheckBox_IsNotPreguntarComanda_CheckedChanged);
        CheckBox preguntarComanda1 = this._CheckBox_IsNotPreguntarComanda;
        if (preguntarComanda1 != null)
          preguntarComanda1.CheckedChanged -= eventHandler;
        this._CheckBox_IsNotPreguntarComanda = value;
        CheckBox preguntarComanda2 = this._CheckBox_IsNotPreguntarComanda;
        if (preguntarComanda2 == null)
          return;
        preguntarComanda2.CheckedChanged += eventHandler;
      }
    }

    internal virtual Label Label23 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual CheckBox CheckBox_IsPreguntarComanda
    {
      get
      {
        return this._CheckBox_IsPreguntarComanda;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.CheckBox_IsPreguntarComanda_CheckedChanged);
        CheckBox preguntarComanda1 = this._CheckBox_IsPreguntarComanda;
        if (preguntarComanda1 != null)
          preguntarComanda1.CheckedChanged -= eventHandler;
        this._CheckBox_IsPreguntarComanda = value;
        CheckBox preguntarComanda2 = this._CheckBox_IsPreguntarComanda;
        if (preguntarComanda2 == null)
          return;
        preguntarComanda2.CheckedChanged += eventHandler;
      }
    }

    internal virtual Label Label30 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Label Label29 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Label Label28 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Label Label27 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Label Label26 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Label Label25 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Label Label24 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual CheckBox CheckBox_IsVendedorTransfMesa
    {
      get
      {
        return this._CheckBox_IsVendedorTransfMesa;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.CheckBox_IsVendedorTransfMesa_CheckedChanged);
        CheckBox vendedorTransfMesa1 = this._CheckBox_IsVendedorTransfMesa;
        if (vendedorTransfMesa1 != null)
          vendedorTransfMesa1.CheckedChanged -= eventHandler;
        this._CheckBox_IsVendedorTransfMesa = value;
        CheckBox vendedorTransfMesa2 = this._CheckBox_IsVendedorTransfMesa;
        if (vendedorTransfMesa2 == null)
          return;
        vendedorTransfMesa2.CheckedChanged += eventHandler;
      }
    }

    internal virtual CheckBox CheckBox_IsNotVendedorTransfMesa
    {
      get
      {
        return this._CheckBox_IsNotVendedorTransfMesa;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.CheckBox_IsNotVendedorTransfMesa_CheckedChanged);
        CheckBox vendedorTransfMesa1 = this._CheckBox_IsNotVendedorTransfMesa;
        if (vendedorTransfMesa1 != null)
          vendedorTransfMesa1.CheckedChanged -= eventHandler;
        this._CheckBox_IsNotVendedorTransfMesa = value;
        CheckBox vendedorTransfMesa2 = this._CheckBox_IsNotVendedorTransfMesa;
        if (vendedorTransfMesa2 == null)
          return;
        vendedorTransfMesa2.CheckedChanged += eventHandler;
      }
    }

    internal virtual Label Label31 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual TabControl tbcVariables { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual TabPage tpgPrincipal { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual TabPage tpgSegundo { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual CheckBox CheckBox_IsSalirTomadoralEnviar
    {
      get
      {
        return this._CheckBox_IsSalirTomadoralEnviar;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.CheckBox_IsSalirTomadoralEnviar_CheckedChanged);
        CheckBox salirTomadoralEnviar1 = this._CheckBox_IsSalirTomadoralEnviar;
        if (salirTomadoralEnviar1 != null)
          salirTomadoralEnviar1.CheckedChanged -= eventHandler;
        this._CheckBox_IsSalirTomadoralEnviar = value;
        CheckBox salirTomadoralEnviar2 = this._CheckBox_IsSalirTomadoralEnviar;
        if (salirTomadoralEnviar2 == null)
          return;
        salirTomadoralEnviar2.CheckedChanged += eventHandler;
      }
    }

    internal virtual CheckBox CheckBox_NotIsSalirTomadoralEnviar
    {
      get
      {
        return this._CheckBox_NotIsSalirTomadoralEnviar;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.CheckBox_NotIsSalirTomadoralEnviar_CheckedChanged);
        CheckBox salirTomadoralEnviar1 = this._CheckBox_NotIsSalirTomadoralEnviar;
        if (salirTomadoralEnviar1 != null)
          salirTomadoralEnviar1.CheckedChanged -= eventHandler;
        this._CheckBox_NotIsSalirTomadoralEnviar = value;
        CheckBox salirTomadoralEnviar2 = this._CheckBox_NotIsSalirTomadoralEnviar;
        if (salirTomadoralEnviar2 == null)
          return;
        salirTomadoralEnviar2.CheckedChanged += eventHandler;
      }
    }

    internal virtual Label Label32 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual CheckBox CheckBox_IsExigeEnvioComanda
    {
      get
      {
        return this._CheckBox_IsExigeEnvioComanda;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.CheckBox_IsExigeEnvioComanda_CheckedChanged);
        CheckBox exigeEnvioComanda1 = this._CheckBox_IsExigeEnvioComanda;
        if (exigeEnvioComanda1 != null)
          exigeEnvioComanda1.CheckedChanged -= eventHandler;
        this._CheckBox_IsExigeEnvioComanda = value;
        CheckBox exigeEnvioComanda2 = this._CheckBox_IsExigeEnvioComanda;
        if (exigeEnvioComanda2 == null)
          return;
        exigeEnvioComanda2.CheckedChanged += eventHandler;
      }
    }

    internal virtual CheckBox CheckBox_NotIsExigeEnvioComanda
    {
      get
      {
        return this._CheckBox_NotIsExigeEnvioComanda;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.CheckBox_NotIsExigeEnvioComanda_CheckedChanged);
        CheckBox exigeEnvioComanda1 = this._CheckBox_NotIsExigeEnvioComanda;
        if (exigeEnvioComanda1 != null)
          exigeEnvioComanda1.CheckedChanged -= eventHandler;
        this._CheckBox_NotIsExigeEnvioComanda = value;
        CheckBox exigeEnvioComanda2 = this._CheckBox_NotIsExigeEnvioComanda;
        if (exigeEnvioComanda2 == null)
          return;
        exigeEnvioComanda2.CheckedChanged += eventHandler;
      }
    }

    internal virtual Label Label33 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual CheckBox CheckBox_PermisoAdminReimpComanda
    {
      get
      {
        return this._CheckBox_PermisoAdminReimpComanda;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.CheckBox_PermisoAdminReimpComanda_CheckedChanged);
        CheckBox adminReimpComanda1 = this._CheckBox_PermisoAdminReimpComanda;
        if (adminReimpComanda1 != null)
          adminReimpComanda1.CheckedChanged -= eventHandler;
        this._CheckBox_PermisoAdminReimpComanda = value;
        CheckBox adminReimpComanda2 = this._CheckBox_PermisoAdminReimpComanda;
        if (adminReimpComanda2 == null)
          return;
        adminReimpComanda2.CheckedChanged += eventHandler;
      }
    }

    internal virtual CheckBox CheckBox_NoPermisoAdminReimpComanda
    {
      get
      {
        return this._CheckBox_NoPermisoAdminReimpComanda;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.CheckBox_NoPermisoAdminReimpComanda_CheckedChanged);
        CheckBox adminReimpComanda1 = this._CheckBox_NoPermisoAdminReimpComanda;
        if (adminReimpComanda1 != null)
          adminReimpComanda1.CheckedChanged -= eventHandler;
        this._CheckBox_NoPermisoAdminReimpComanda = value;
        CheckBox adminReimpComanda2 = this._CheckBox_NoPermisoAdminReimpComanda;
        if (adminReimpComanda2 == null)
          return;
        adminReimpComanda2.CheckedChanged += eventHandler;
      }
    }

    internal virtual Label Label34 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual CheckBox CheckBox_PermisoAdminReimpPrecuenta
    {
      get
      {
        return this._CheckBox_PermisoAdminReimpPrecuenta;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.CheckBox_PermisoAdminReimpPrecuenta_CheckedChanged);
        CheckBox adminReimpPrecuenta1 = this._CheckBox_PermisoAdminReimpPrecuenta;
        if (adminReimpPrecuenta1 != null)
          adminReimpPrecuenta1.CheckedChanged -= eventHandler;
        this._CheckBox_PermisoAdminReimpPrecuenta = value;
        CheckBox adminReimpPrecuenta2 = this._CheckBox_PermisoAdminReimpPrecuenta;
        if (adminReimpPrecuenta2 == null)
          return;
        adminReimpPrecuenta2.CheckedChanged += eventHandler;
      }
    }

    internal virtual CheckBox CheckBox_NoPermisoAdminReimpPrecuenta
    {
      get
      {
        return this._CheckBox_NoPermisoAdminReimpPrecuenta;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.CheckBox_NoPermisoAdminReimpPrecuenta_CheckedChanged);
        CheckBox adminReimpPrecuenta1 = this._CheckBox_NoPermisoAdminReimpPrecuenta;
        if (adminReimpPrecuenta1 != null)
          adminReimpPrecuenta1.CheckedChanged -= eventHandler;
        this._CheckBox_NoPermisoAdminReimpPrecuenta = value;
        CheckBox adminReimpPrecuenta2 = this._CheckBox_NoPermisoAdminReimpPrecuenta;
        if (adminReimpPrecuenta2 == null)
          return;
        adminReimpPrecuenta2.CheckedChanged += eventHandler;
      }
    }

    internal virtual Label Label35 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual CheckBox CheckBox_DescuentoProgramado
    {
      get
      {
        return this._CheckBox_DescuentoProgramado;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.CheckBox_DescuentoProgramado_CheckedChanged);
        CheckBox descuentoProgramado1 = this._CheckBox_DescuentoProgramado;
        if (descuentoProgramado1 != null)
          descuentoProgramado1.CheckedChanged -= eventHandler;
        this._CheckBox_DescuentoProgramado = value;
        CheckBox descuentoProgramado2 = this._CheckBox_DescuentoProgramado;
        if (descuentoProgramado2 == null)
          return;
        descuentoProgramado2.CheckedChanged += eventHandler;
      }
    }

    internal virtual CheckBox CheckBox_NoDescuentoProgramado
    {
      get
      {
        return this._CheckBox_NoDescuentoProgramado;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.CheckBox_NoDescuentoProgramado_CheckedChanged);
        CheckBox descuentoProgramado1 = this._CheckBox_NoDescuentoProgramado;
        if (descuentoProgramado1 != null)
          descuentoProgramado1.CheckedChanged -= eventHandler;
        this._CheckBox_NoDescuentoProgramado = value;
        CheckBox descuentoProgramado2 = this._CheckBox_NoDescuentoProgramado;
        if (descuentoProgramado2 == null)
          return;
        descuentoProgramado2.CheckedChanged += eventHandler;
      }
    }

    internal virtual Label Label36 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual TabControl tcRuta { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual TabPage TabPage1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual TabPage TabPage2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual TextBox txtRutaFotoCliente { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Button btnFotoCliente
    {
      get
      {
        return this._btnFotoCliente;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.btnFotoCliente_Click);
        Button btnFotoCliente1 = this._btnFotoCliente;
        if (btnFotoCliente1 != null)
          btnFotoCliente1.Click -= eventHandler;
        this._btnFotoCliente = value;
        Button btnFotoCliente2 = this._btnFotoCliente;
        if (btnFotoCliente2 == null)
          return;
        btnFotoCliente2.Click += eventHandler;
      }
    }

    internal virtual Button btnConfigurarCorreo
    {
      get
      {
        return this._btnConfigurarCorreo;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.btnConfigurarCorreo_Click);
        Button configurarCorreo1 = this._btnConfigurarCorreo;
        if (configurarCorreo1 != null)
          configurarCorreo1.Click -= eventHandler;
        this._btnConfigurarCorreo = value;
        Button configurarCorreo2 = this._btnConfigurarCorreo;
        if (configurarCorreo2 == null)
          return;
        configurarCorreo2.Click += eventHandler;
      }
    }

    internal virtual TabPage tgpTercero { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual GroupBox GroupBox_Price1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual CheckBox CheckBox_Tax3_01 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual CheckBox CheckBox_Tax2_01 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual CheckBox CheckBox_Tax1_01 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual GroupBox GroupBox_Price2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual CheckBox CheckBox_Tax3_02 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual CheckBox CheckBox_Tax2_02 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual CheckBox CheckBox_Tax1_02 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual GroupBox GroupBox_Price3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual CheckBox CheckBox_Tax3_03 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual CheckBox CheckBox_Tax2_03 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual CheckBox CheckBox_Tax1_03 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Button Button_SaveImpuesto
    {
      get
      {
        return this._Button_SaveImpuesto;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Button_SaveImpuesto_Click);
        Button buttonSaveImpuesto1 = this._Button_SaveImpuesto;
        if (buttonSaveImpuesto1 != null)
          buttonSaveImpuesto1.Click -= eventHandler;
        this._Button_SaveImpuesto = value;
        Button buttonSaveImpuesto2 = this._Button_SaveImpuesto;
        if (buttonSaveImpuesto2 == null)
          return;
        buttonSaveImpuesto2.Click += eventHandler;
      }
    }

    public FrmCfgNegocio()
    {
      this.Load += new EventHandler(this.FrmBusinessCfg_Load);
      this.KeyDown += new KeyEventHandler(this.FrmBusinessCfg_KeyDown);
      this.InitializeComponent();
      this.bol_DBCleaned = true;
    }

    private void FrmBusinessCfg_Load(object sender, EventArgs e)
    {
      this.VerificarModulo();
      this.Resource(ModGeneralFunctions.Get_Language((object) this));
      this.ComboBox_MonthExpiredPoints.Items.Add((object) "N/E");
      int num1 = 1;
      do
      {
        this.ComboBox_MonthExpiredPoints.Items.Add((object) num1);
        checked { ++num1; }
      }
      while (num1 <= 120);
      int num2 = 2;
      do
      {
        this.ComboBox_NroSubmesas.Items.Add((object) num2);
        checked { ++num2; }
      }
      while (num2 <= 20);
      this.TextBox_SocialReason.Text = ModGeneralVar.g_BE_TR1_VARIABLES_B.get_SocialReason();
      this.TextBox_CommercialReason.Text = ModGeneralVar.g_BE_TR1_VARIABLES_B.get_CommercialReason();
      this.TextBox_TributaryId.Text = ModGeneralVar.g_BE_TR1_VARIABLES_B.get_TributaryId();
      this.TextBox_PhoneNumber.Text = ModGeneralVar.g_BE_TR1_VARIABLES_B.get_PhoneNumber();
      this.TextBox_Address.Text = ModGeneralVar.g_BE_TR1_VARIABLES_B.get_Address();
      this.TextBox_Email.Text = ModGeneralVar.g_BE_TR1_VARIABLES_B.get_Email();
      this.TextBox_WebPage.Text = ModGeneralVar.g_BE_TR1_VARIABLES_B.get_WebPage();
      this.TextBox_Tax1.Text = ModGeneralVar.g_BE_TR1_VARIABLES_B.get_VarTax1();
      this.TextBox_Tax2.Text = ModGeneralVar.g_BE_TR1_VARIABLES_B.get_VarTax2();
      this.TextBox_Tax3.Text = ModGeneralVar.g_BE_TR1_VARIABLES_B.get_VarTax3();
      ((TextBox) this.NumericTexBox_Tax1).Text = ModGeneralFunctions.FormatMoney(ModGeneralVar.g_BE_TR1_VARIABLES_B.get_Tax1());
      ((TextBox) this.NumericTexBox_Tax2).Text = ModGeneralFunctions.FormatMoney(ModGeneralVar.g_BE_TR1_VARIABLES_B.get_Tax2());
      ((TextBox) this.NumericTexBox_Tax3).Text = ModGeneralFunctions.FormatMoney(ModGeneralVar.g_BE_TR1_VARIABLES_B.get_Tax3());
      this.CheckBox_Tax1.Checked = ModGeneralVar.g_BE_TR1_VARIABLES_B.get_HasTax1();
      this.CheckBox_Tax2.Checked = ModGeneralVar.g_BE_TR1_VARIABLES_B.get_HasTax2();
      this.CheckBox_Tax3.Checked = ModGeneralVar.g_BE_TR1_VARIABLES_B.get_HasTax3();
      this.TextBox_PathBackup.Text = ModGeneralVar.g_BE_TR1_VARIABLES_B.get_PathBackUp();
      this.TextBox_CommandOne.Text = ModGeneralVar.g_BE_TR1_VARIABLES_B.get_CommandTextOne();
      this.TextBox_CommandTwo.Text = ModGeneralVar.g_BE_TR1_VARIABLES_B.get_CommandTextTwo();
      this.CheckBox_WithStore.Checked = ModGeneralVar.g_BE_TR1_VARIABLES_B.get_WithStore();
      this.CheckBox_UnloadDirect.Checked = ModGeneralVar.g_BE_TR1_VARIABLES_B.get_Unload_ProductDirect();
      this.CheckBox_PrintProducts.Checked = ModGeneralVar.g_BE_TR1_VARIABLES_B.get_PrintOption();
      this.CheckBox_ShowOpcPrebill.Checked = ModGeneralVar.g_BE_TR1_VARIABLES_B.get_ShowOpcPrebill();
      this.CheckBox_IsDiscountClients.Checked = ModGeneralVar.g_BE_TR1_VARIABLES_B.get_IsDiscountClients();
      this.CheckBox_IsUsePoints.Checked = ModGeneralVar.g_BE_TR1_VARIABLES_B.get_IsUsePoints();
      ((TextBox) this.TextBox_AmountUsePoints).Text = Strings.FormatNumber((object) ModGeneralVar.g_BE_TR1_VARIABLES_B.get_AmountUsePoints(), 2, TriState.UseDefault, TriState.UseDefault, TriState.UseDefault);
      this.TextBox_MessageCommand.Text = ModGeneralVar.g_BE_TR1_VARIABLES_B.get_MessageCommand();
      this.ComboBox_MonthExpiredPoints.SelectedIndex = ModGeneralVar.g_BE_TR1_VARIABLES_B.get_MonthExpiredPoints();
      this.CheckBox_ShowOffer.Checked = ModGeneralVar.g_BE_TR1_VARIABLES_B.get_ShowOffer();
      this.CheckBox_IsPrintPrecountSend.Checked = ModGeneralVar.g_BE_TR1_VARIABLES_B.get_IsPrintPrecountSend();
      this.CheckBox_IsDeleteItemNotSend.Checked = ModGeneralVar.g_BE_TR1_VARIABLES_B.get_IsDeleteItemNotSend();
      this.CheckBox_IsPayThenCommnand.Checked = ModGeneralVar.g_BE_TR1_VARIABLES_B.get_IsPayThenCommnand();
      ((TextBox) this.TextBox_PersonNum).Text = Conversions.ToString(ModGeneralVar.g_BE_TR1_VARIABLES_B.get_PersonNum());
      ((TextBox) this.TextBox_DivCtaNum).Text = Conversions.ToString(ModGeneralVar.g_BE_TR1_VARIABLES_B.get_DivCtaNum());
      this.CheckBox_IsPersonNum.Checked = ModGeneralVar.g_BE_TR1_VARIABLES_B.get_IsPersonNum();
      this.CheckBox_IsDivCtaNum.Checked = ModGeneralVar.g_BE_TR1_VARIABLES_B.get_IsDivCtaNum();
      this.CheckBox_ShowTax.Checked = ModGeneralVar.g_BE_TR1_VARIABLES_B.get_ShowTax();
      this.ComboBox_NroSubmesas.Text = Conversions.ToString(ModGeneralVar.g_BE_TR1_VARIABLES_B.get_NroSubmesas());
      this.CheckBox_IsPreguntarComanda.Checked = ModGeneralVar.g_BE_TR1_VARIABLES_B.get_IsPreguntarComanda();
      this.CheckBox_IsVendedorTransfMesa.Checked = ModGeneralVar.g_BE_TR1_VARIABLES_B.get_IsVendedorTransfMesa();
      this.CheckBox_IsExigeEnvioComanda.Checked = ModGeneralVar.g_BE_TR1_VARIABLES_B.get_IsExigeEnvioComanda();
      this.CheckBox_IsSalirTomadoralEnviar.Checked = ModGeneralVar.g_BE_TR1_VARIABLES_B.get_IsSalirTomadoralEnviar();
      this.CheckBox_PermisoAdminReimpComanda.Checked = ModGeneralVar.g_BE_TR1_VARIABLES_B.get_PermisoAdmReImpComanda();
      this.CheckBox_PermisoAdminReimpPrecuenta.Checked = ModGeneralVar.g_BE_TR1_VARIABLES_B.get_PermisoAdminReImpPrecuenta();
      this.CheckBox_DescuentoProgramado.Checked = ModGeneralVar.g_BE_TR1_VARIABLES_B.get_DescuentoProgramado();
      this.txtRutaFotoCliente.Text = ModGeneralVar.g_BE_TR1_VARIABLES_B.get_RutaFotoCliente();
      if (ModGeneralVar.g_BE_TR1_VARIABLES_B.get_SubGroupOrderNum())
        this.CheckBox_SubGroupOrder.Checked = true;
      else
        this.CheckBox_NotSubGroupOrder.Checked = true;
      if (ModGeneralVar.g_BE_TR1_VARIABLES_B.get_IsPrintCentral())
        this.CheckBox_IsPrintCentral.Checked = true;
      else
        this.CheckBox_IsNotPrintCentral.Checked = true;
      if (ModGeneralVar.g_BE_TR1_VARIABLES_B.get_PrintOption())
        this.CheckBox_PrintProducts.Checked = true;
      else
        this.CheckBox_NotPrintProducts.Checked = true;
      if (ModGeneralVar.g_BE_TR1_VARIABLES_B.get_ShowOpcPrebill())
        this.CheckBox_ShowOpcPrebill.Checked = true;
      else
        this.CheckBox_NotShowOpcPrebill.Checked = true;
      if (ModGeneralVar.g_BE_TR1_VARIABLES_B.get_IsDiscountClients())
        this.CheckBox_IsDiscountClients.Checked = true;
      else
        this.CheckBox_NotIsDiscountClients.Checked = true;
      if (ModGeneralVar.g_BE_TR1_VARIABLES_B.get_IsUsePoints())
        this.CheckBox_IsUsePoints.Checked = true;
      else
        this.CheckBox_NotIsUsePoints.Checked = true;
      if (ModGeneralVar.g_BE_TR1_VARIABLES_B.get_ShowOffer())
        this.CheckBox_ShowOffer.Checked = true;
      else
        this.CheckBox_NotShowOffer.Checked = true;
      if (ModGeneralVar.g_BE_TR1_VARIABLES_B.get_IsPrintPrecountSend())
        this.CheckBox_IsPrintPrecountSend.Checked = true;
      else
        this.CheckBox_IsNotPrintPrecountSend.Checked = true;
      if (ModGeneralVar.g_BE_TR1_VARIABLES_B.get_IsDeleteItemNotSend())
        this.CheckBox_IsDeleteItemNotSend.Checked = true;
      else
        this.CheckBox_IsNotDeleteItemNotSend.Checked = true;
      if (ModGeneralVar.g_BE_TR1_VARIABLES_B.get_IsPayThenCommnand())
        this.CheckBox_IsPayThenCommnand.Checked = true;
      else
        this.CheckBox_IsNotPayThenCommnand.Checked = true;
      if (ModGeneralVar.g_BE_TR1_VARIABLES_B.get_IsPersonNum())
        this.CheckBox_IsPersonNum.Checked = true;
      else
        this.CheckBox_IsNotPersonNum.Checked = true;
      if (ModGeneralVar.g_BE_TR1_VARIABLES_B.get_IsDivCtaNum())
        this.CheckBox_IsDivCtaNum.Checked = true;
      else
        this.CheckBox_IsNotDivCtaNum.Checked = true;
      if (ModGeneralVar.g_BE_TR1_VARIABLES_B.get_ShowTax())
        this.CheckBox_ShowTax.Checked = true;
      else
        this.CheckBox_NotShowTax.Checked = true;
      if (ModGeneralVar.g_BE_TR1_VARIABLES_B.get_IsNroSubmesas())
        this.CheckBox_NroSubmesas.Checked = true;
      else
        this.CheckBox_NotNroSubmesas.Checked = true;
      if (ModGeneralVar.g_BE_TR1_VARIABLES_B.get_IsPreguntarComanda())
        this.CheckBox_IsPreguntarComanda.Checked = true;
      else
        this.CheckBox_IsNotPreguntarComanda.Checked = true;
      if (ModGeneralVar.g_BE_TR1_VARIABLES_B.get_IsVendedorTransfMesa())
        this.CheckBox_IsVendedorTransfMesa.Checked = true;
      else
        this.CheckBox_IsNotVendedorTransfMesa.Checked = true;
      if (ModGeneralVar.g_BE_TR1_VARIABLES_B.get_IsExigeEnvioComanda())
        this.CheckBox_IsExigeEnvioComanda.Checked = true;
      else
        this.CheckBox_NotIsExigeEnvioComanda.Checked = true;
      if (ModGeneralVar.g_BE_TR1_VARIABLES_B.get_IsSalirTomadoralEnviar())
        this.CheckBox_IsSalirTomadoralEnviar.Checked = true;
      else
        this.CheckBox_NotIsSalirTomadoralEnviar.Checked = true;
      if (ModGeneralVar.g_BE_TR1_VARIABLES_B.get_PermisoAdmReImpComanda())
        this.CheckBox_PermisoAdminReimpComanda.Checked = true;
      else
        this.CheckBox_NoPermisoAdminReimpComanda.Checked = true;
      if (ModGeneralVar.g_BE_TR1_VARIABLES_B.get_PermisoAdminReImpPrecuenta())
        this.CheckBox_PermisoAdminReimpPrecuenta.Checked = true;
      else
        this.CheckBox_NoPermisoAdminReimpPrecuenta.Checked = true;
      if (ModGeneralVar.g_BE_TR1_VARIABLES_B.get_DescuentoProgramado())
        this.CheckBox_DescuentoProgramado.Checked = true;
      else
        this.CheckBox_NoDescuentoProgramado.Checked = true;
      this.GroupBox_Price1.Text += " Local";
      this.GroupBox_Price2.Text += " Delivery";
      this.GroupBox_Price3.Text += " Ventanilla";
      BE_TR1_VARIABLES_IMPUESTO_TIPOPEDIDO impuestoTipopedido1 = new BE_TR1_VARIABLES_IMPUESTO_TIPOPEDIDO();
      BE_TR1_VARIABLES_IMPUESTO_TIPOPEDIDO impuestoTipopedido2 = new BL_TR1_VARIABLE_IMPUESTO_TIPOPEDIDO().ListaDatos(ModGeneralVar.g_BE_TR1_VARIABLES_B.get_EstabliId(), ModGeneralVar.g_BE_TR1_VARIABLES_B.get_EmpresaId());
      if (impuestoTipopedido2 == null)
        return;
      this.CheckBox_Tax1_01.Text = ModGeneralVar.g_BE_TR1_VARIABLES_B.get_VarTax1();
      this.CheckBox_Tax2_01.Text = ModGeneralVar.g_BE_TR1_VARIABLES_B.get_VarTax2();
      this.CheckBox_Tax3_01.Text = ModGeneralVar.g_BE_TR1_VARIABLES_B.get_VarTax3();
      this.CheckBox_Tax1_01.Checked = impuestoTipopedido2.get_LocalTax1();
      this.CheckBox_Tax2_01.Checked = impuestoTipopedido2.get_LocalTax2();
      this.CheckBox_Tax3_01.Checked = impuestoTipopedido2.get_LocalTax3();
      this.CheckBox_Tax1_02.Text = ModGeneralVar.g_BE_TR1_VARIABLES_B.get_VarTax1();
      this.CheckBox_Tax2_02.Text = ModGeneralVar.g_BE_TR1_VARIABLES_B.get_VarTax2();
      this.CheckBox_Tax3_02.Text = ModGeneralVar.g_BE_TR1_VARIABLES_B.get_VarTax3();
      this.CheckBox_Tax1_02.Checked = impuestoTipopedido2.get_DeliveryTax1();
      this.CheckBox_Tax2_02.Checked = impuestoTipopedido2.get_DeliveryTax2();
      this.CheckBox_Tax3_02.Checked = impuestoTipopedido2.get_DeliveryTax3();
      this.CheckBox_Tax1_03.Text = ModGeneralVar.g_BE_TR1_VARIABLES_B.get_VarTax1();
      this.CheckBox_Tax2_03.Text = ModGeneralVar.g_BE_TR1_VARIABLES_B.get_VarTax2();
      this.CheckBox_Tax3_03.Text = ModGeneralVar.g_BE_TR1_VARIABLES_B.get_VarTax3();
      this.CheckBox_Tax1_03.Checked = impuestoTipopedido2.get_VentanillaTax1();
      this.CheckBox_Tax2_03.Checked = impuestoTipopedido2.get_VentanillaTax2();
      this.CheckBox_Tax3_03.Checked = impuestoTipopedido2.get_VentanillaTax3();
    }

    private void FrmBusinessCfg_KeyDown(object sender, KeyEventArgs e)
    {
      if (!e.KeyValue.Equals(27))
        return;
      this.bol_DBCleaned = false;
      this.Close();
    }

    private void Resource(ResourceManager Rm)
    {
      this.Text = Rm.GetString("Res_SystemConfiguration");
      this.Button_PathBackUp.Text = Rm.GetString("Res_Path");
      this.Label_Tax1.Text = Rm.GetString("Res_Charge") + " 1 :";
      this.Label_Tax2.Text = Rm.GetString("Res_Charge") + " 2 :";
      this.Label_Tax3.Text = Rm.GetString("Res_Charge") + " 3 :";
      this.Label_Description.Text = Rm.GetString("Res_Description");
      this.Label_Value.Text = Rm.GetString("Res_Value") + " %";
      this.Label_Yes.Text = Rm.GetString("Res_Yes") + " ?";
      this.Button_Save.Text = Rm.GetString("Res_Save");
      this.Button_GoOut.Text = Rm.GetString("Res_Exit");
      this.HeaderPanel_DonwloadOption.set_CaptionText(Rm.GetString("Res_DownloadOpt"));
    }

    private void Button_Save_Click(object sender, EventArgs e)
    {
      if (this.CheckBox_IsPrintCentral.Checked)
        ModGeneralFunctions.MessageOk_Large("¡Impresión Centralizada - Actualice las Series de Documentos!", false);
      if (this.CheckBox_IsUsePoints.Checked & Conversion.Val(((TextBox) this.TextBox_AmountUsePoints).Text) == 0.0)
      {
        ModGeneralFunctions.MessageOk_Large("¡El Monto para Aplicar Puntos debe ser mayor a Cero!", false);
        ((Control) this.TextBox_AmountUsePoints).Focus();
      }
      else if (this.CheckBox_IsDivCtaNum.Checked & ModGeneralFunctions.CadenaToDouble(((TextBox) this.TextBox_DivCtaNum).Text.Trim()) <= 1.0)
      {
        ModGeneralFunctions.MessageOk_Large("¡No se puede Dividir Cta. entre " + ((TextBox) this.TextBox_DivCtaNum).Text.Trim() + " Cuentas!", false);
        ((Control) this.TextBox_DivCtaNum).Focus();
      }
      else
      {
        if (!ModGeneralFunctions.MessageMakeAction("¿Desea Guardar la Configuración?", false))
          return;
        BE_TR1_VARIABLES_B gBeTr1VariablesB = ModGeneralVar.g_BE_TR1_VARIABLES_B;
        gBeTr1VariablesB.set_EstabliId(ModGeneralVar.g_BE_TR1_VARIABLES_B.get_EstabliId());
        gBeTr1VariablesB.set_EmpresaId(ModGeneralVar.g_BE_TR1_VARIABLES_B.get_EmpresaId());
        gBeTr1VariablesB.set_SocialReason(this.TextBox_SocialReason.Text);
        gBeTr1VariablesB.set_CommercialReason(this.TextBox_CommercialReason.Text);
        gBeTr1VariablesB.set_TributaryId(this.TextBox_TributaryId.Text);
        gBeTr1VariablesB.set_PhoneNumber(this.TextBox_PhoneNumber.Text);
        gBeTr1VariablesB.set_Address(this.TextBox_Address.Text);
        gBeTr1VariablesB.set_Email(this.TextBox_Email.Text);
        gBeTr1VariablesB.set_WebPage(this.TextBox_WebPage.Text);
        gBeTr1VariablesB.set_VarTax1(this.TextBox_Tax1.Text);
        gBeTr1VariablesB.set_VarTax2(this.TextBox_Tax2.Text);
        gBeTr1VariablesB.set_VarTax3(this.TextBox_Tax3.Text);
        gBeTr1VariablesB.set_Tax1(Conversions.ToDouble(((TextBox) this.NumericTexBox_Tax1).Text));
        gBeTr1VariablesB.set_Tax2(Conversions.ToDouble(((TextBox) this.NumericTexBox_Tax2).Text));
        gBeTr1VariablesB.set_Tax3(Conversions.ToDouble(((TextBox) this.NumericTexBox_Tax3).Text));
        gBeTr1VariablesB.set_HasTax1(this.CheckBox_Tax1.Checked);
        gBeTr1VariablesB.set_HasTax2(this.CheckBox_Tax2.Checked);
        gBeTr1VariablesB.set_HasTax3(this.CheckBox_Tax3.Checked);
        gBeTr1VariablesB.set_PathBackUp(this.TextBox_PathBackup.Text);
        gBeTr1VariablesB.set_WithStore(this.CheckBox_WithStore.Checked);
        gBeTr1VariablesB.set_Unload_ProductDirect(this.CheckBox_UnloadDirect.Checked);
        gBeTr1VariablesB.set_SubGroupOrderNum(this.CheckBox_SubGroupOrder.Checked);
        gBeTr1VariablesB.set_CommandTextOne(this.TextBox_CommandOne.Text);
        gBeTr1VariablesB.set_CommandTextTwo(this.TextBox_CommandTwo.Text);
        gBeTr1VariablesB.set_IsPrintCentral(this.CheckBox_IsPrintCentral.Checked);
        gBeTr1VariablesB.set_PrintOption(this.CheckBox_PrintProducts.Checked);
        gBeTr1VariablesB.set_ShowOpcPrebill(this.CheckBox_ShowOpcPrebill.Checked);
        gBeTr1VariablesB.set_IsDiscountClients(this.CheckBox_IsDiscountClients.Checked);
        gBeTr1VariablesB.set_IsUsePoints(this.CheckBox_IsUsePoints.Checked);
        gBeTr1VariablesB.set_AmountUsePoints(Conversions.ToDouble(((TextBox) this.TextBox_AmountUsePoints).Text));
        gBeTr1VariablesB.set_MessageCommand(this.TextBox_MessageCommand.Text);
        gBeTr1VariablesB.set_MonthExpiredPoints(this.ComboBox_MonthExpiredPoints.SelectedIndex);
        gBeTr1VariablesB.set_ShowOffer(this.CheckBox_ShowOffer.Checked);
        gBeTr1VariablesB.set_IsPrintPrecountSend(this.CheckBox_IsPrintPrecountSend.Checked);
        gBeTr1VariablesB.set_IsDeleteItemNotSend(this.CheckBox_IsDeleteItemNotSend.Checked);
        gBeTr1VariablesB.set_IsPayThenCommnand(this.CheckBox_IsPayThenCommnand.Checked);
        gBeTr1VariablesB.set_PersonNum(ModGeneralFunctions.CadenaToInteger(((TextBox) this.TextBox_PersonNum).Text.Trim()));
        gBeTr1VariablesB.set_DivCtaNum(Conversions.ToInteger(((TextBox) this.TextBox_DivCtaNum).Text.Trim()));
        gBeTr1VariablesB.set_IsPersonNum(this.CheckBox_IsPersonNum.Checked);
        gBeTr1VariablesB.set_IsDivCtaNum(this.CheckBox_IsDivCtaNum.Checked);
        gBeTr1VariablesB.set_ShowTax(this.CheckBox_ShowTax.Checked);
        gBeTr1VariablesB.set_IsNroSubmesas(this.CheckBox_NroSubmesas.Checked);
        gBeTr1VariablesB.set_NroSubmesas(ModGeneralFunctions.CadenaToInteger(this.ComboBox_NroSubmesas.Text));
        gBeTr1VariablesB.set_IsPreguntarComanda(this.CheckBox_IsPreguntarComanda.Checked);
        gBeTr1VariablesB.set_IsVendedorTransfMesa(this.CheckBox_IsVendedorTransfMesa.Checked);
        gBeTr1VariablesB.set_IsExigeEnvioComanda(this.CheckBox_IsExigeEnvioComanda.Checked);
        gBeTr1VariablesB.set_IsSalirTomadoralEnviar(this.CheckBox_IsSalirTomadoralEnviar.Checked);
        gBeTr1VariablesB.set_PermisoAdmReImpComanda(this.CheckBox_PermisoAdminReimpComanda.Checked);
        gBeTr1VariablesB.set_PermisoAdminReImpPrecuenta(this.CheckBox_PermisoAdminReimpPrecuenta.Checked);
        gBeTr1VariablesB.set_DescuentoProgramado(this.CheckBox_DescuentoProgramado.Checked);
        gBeTr1VariablesB.set_RutaFotoCliente(this.txtRutaFotoCliente.Text.Trim());
        if (!this.CheckBox_Tax2.Checked)
          gBeTr1VariablesB.set_Tax2(0.0);
        if (!this.CheckBox_Tax3.Checked)
          gBeTr1VariablesB.set_Tax3(0.0);
        if (this.CheckBox_WithStore.Checked)
        {
          this.Label_UnloadDirects.Enabled = false;
          this.CheckBox_UnloadDirect.Enabled = false;
        }
        else
        {
          this.Label_UnloadDirects.Enabled = true;
          this.CheckBox_UnloadDirect.Enabled = true;
        }
        string p_Mensaje = new BL_TR1_CONFIGURATION().Edit_CfgBusiness(gBeTr1VariablesB);
        if (p_Mensaje.Equals(StructApp.RESULT_OK))
        {
          ModGeneralVar.g_BE_TR1_VARIABLES_B = gBeTr1VariablesB;
          ModGeneralVar.g_BE_ORDER_OPTIONS.set_WithStore(gBeTr1VariablesB.get_WithStore());
          ModGeneralVar.g_BE_ORDER_OPTIONS.set_DownloadOnline(gBeTr1VariablesB.get_Unload_ProductDirect());
          ModGeneralFunctions.MessageOk("¡Conf. Negocio Actualizadas!");
          this.Close();
        }
        else
          ModGeneralFunctions.MessageError_Large(p_Mensaje, true);
      }
    }

    private void Button_PathBackUp_Click(object sender, EventArgs e)
    {
      this.FolderBrowserDialog_SearchPath.SelectedPath = ModGeneralVar.g_BE_TR1_VARIABLES_B.get_PathBackUp();
      if (this.FolderBrowserDialog_SearchPath.ShowDialog() != DialogResult.OK)
        return;
      this.TextBox_PathBackup.Text = this.FolderBrowserDialog_SearchPath.SelectedPath;
    }

    private void CheckBox_WithStore_CheckedChanged(object sender, EventArgs e)
    {
      if (this.CheckBox_WithStore.Checked)
        this.CheckBox_WithStore.Image = (Image) TriNetRestPOS.My.Resources.Resources.check_1;
      else
        this.CheckBox_WithStore.Image = (Image) TriNetRestPOS.My.Resources.Resources.check_4;
    }

    private void CheckBox_WithStore_CheckStateChanged(object sender, EventArgs e)
    {
      if (this.CheckBox_WithStore.Checked)
      {
        this.Label_UnloadDirects.Enabled = true;
        this.CheckBox_UnloadDirect.Enabled = true;
        this.CheckBox_UnloadDirect.Checked = false;
      }
      else
      {
        this.Label_UnloadDirects.Enabled = false;
        this.CheckBox_UnloadDirect.Enabled = false;
        this.CheckBox_UnloadDirect.Checked = false;
      }
    }

    private void Control_KeyPress(object sender, KeyPressEventArgs e)
    {
      if (!ModGeneralFunctions.Question_Made_Enter(e))
        return;
      e.Handled = true;
      SendKeys.Send("{TAB}");
    }

    private void Button_GoOut_Click(object sender, EventArgs e)
    {
      this.bol_DBCleaned = false;
      this.Close();
    }

    private void Button_TNS_Click(object sender, EventArgs e)
    {
      BL_TR1_CONFIGURATION tr1Configuration = new BL_TR1_CONFIGURATION();
      string str = "";
      ModGeneralFunctions.TextKeyBoard_Password("Ingrese su Contraseña", ref str);
      if (ModGeneralVar.g_bol_IsReady & Strings.Len(ModGeneralVar.g_str_InputValue) > 0 && ModGeneralFunctions.ValidarContrasenia(ModGeneralVar.g_str_InputValue))
      {
        FrmTNS frmTns = new FrmTNS();
        int num = (int) frmTns.ShowDialog();
        this.bol_DBCleaned = frmTns.bol_DBCleaned;
        frmTns.Dispose();
        if (!ModGeneralVar.g_bol_IsClose)
          this.Close();
      }
    }

    private void CheckBox_SubGroupOrder_CheckedChanged(object sender, EventArgs e)
    {
      if (this.CheckBox_SubGroupOrder.Checked)
        this.CheckBox_NotSubGroupOrder.CheckState = CheckState.Unchecked;
      else
        this.CheckBox_NotSubGroupOrder.CheckState = CheckState.Checked;
    }

    private void CheckBox_NotSubGroupOrder_CheckedChanged(object sender, EventArgs e)
    {
      if (this.CheckBox_NotSubGroupOrder.Checked)
        this.CheckBox_SubGroupOrder.CheckState = CheckState.Unchecked;
      else
        this.CheckBox_SubGroupOrder.CheckState = CheckState.Checked;
    }

    private void CheckBox_IsPrintCentral_CheckedChanged(object sender, EventArgs e)
    {
      if (this.CheckBox_IsPrintCentral.Checked)
        this.CheckBox_IsNotPrintCentral.CheckState = CheckState.Unchecked;
      else
        this.CheckBox_IsNotPrintCentral.CheckState = CheckState.Checked;
    }

    private void CheckBox_IsNotPrintCentral_CheckedChanged(object sender, EventArgs e)
    {
      if (this.CheckBox_IsNotPrintCentral.Checked)
        this.CheckBox_IsPrintCentral.CheckState = CheckState.Unchecked;
      else
        this.CheckBox_IsPrintCentral.CheckState = CheckState.Checked;
    }

    private void CheckBox_PrintProducts_CheckedChanged(object sender, EventArgs e)
    {
      if (this.CheckBox_PrintProducts.Checked)
        this.CheckBox_NotPrintProducts.CheckState = CheckState.Unchecked;
      else
        this.CheckBox_NotPrintProducts.CheckState = CheckState.Checked;
    }

    private void CheckBox_NotPrintProducts_CheckedChanged(object sender, EventArgs e)
    {
      if (this.CheckBox_NotPrintProducts.Checked)
        this.CheckBox_PrintProducts.CheckState = CheckState.Unchecked;
      else
        this.CheckBox_PrintProducts.CheckState = CheckState.Checked;
    }

    private void CheckBox_ShowOpcPrebill_CheckedChanged(object sender, EventArgs e)
    {
      if (this.CheckBox_ShowOpcPrebill.Checked)
        this.CheckBox_NotShowOpcPrebill.CheckState = CheckState.Unchecked;
      else
        this.CheckBox_NotShowOpcPrebill.CheckState = CheckState.Checked;
    }

    private void CheckBox_NotShowOpcPrebill_CheckedChanged(object sender, EventArgs e)
    {
      if (this.CheckBox_NotShowOpcPrebill.Checked)
        this.CheckBox_ShowOpcPrebill.CheckState = CheckState.Unchecked;
      else
        this.CheckBox_ShowOpcPrebill.CheckState = CheckState.Checked;
    }

    private void CheckBox_UnloadDirect_CheckedChanged(object sender, EventArgs e)
    {
      if (this.CheckBox_UnloadDirect.Checked)
        this.CheckBox_UnloadDirect.Image = (Image) TriNetRestPOS.My.Resources.Resources.check_1;
      else
        this.CheckBox_UnloadDirect.Image = (Image) TriNetRestPOS.My.Resources.Resources.check_4;
    }

    private void CheckBox_Tax1_CheckedChanged(object sender, EventArgs e)
    {
      if (this.CheckBox_Tax1.Checked)
      {
        this.CheckBox_Tax1.Image = (Image) TriNetRestPOS.My.Resources.Resources.check_1;
        this.CheckBox_Tax1_01.Checked = true;
        this.CheckBox_Tax1_02.Checked = true;
        this.CheckBox_Tax1_03.Checked = true;
      }
      else
      {
        this.CheckBox_Tax1.Image = (Image) TriNetRestPOS.My.Resources.Resources.check_4;
        this.CheckBox_Tax1_01.Checked = false;
        this.CheckBox_Tax1_02.Checked = false;
        this.CheckBox_Tax1_03.Checked = false;
      }
    }

    private void CheckBox_Tax2_CheckedChanged(object sender, EventArgs e)
    {
      if (this.CheckBox_Tax2.Checked)
      {
        this.CheckBox_Tax2.Image = (Image) TriNetRestPOS.My.Resources.Resources.check_1;
        this.CheckBox_Tax2_01.Checked = true;
        this.CheckBox_Tax2_02.Checked = true;
        this.CheckBox_Tax2_03.Checked = true;
      }
      else
      {
        this.CheckBox_Tax2.Image = (Image) TriNetRestPOS.My.Resources.Resources.check_4;
        this.CheckBox_Tax2_01.Checked = false;
        this.CheckBox_Tax2_02.Checked = false;
        this.CheckBox_Tax2_03.Checked = false;
      }
    }

    private void CheckBox_Tax3_CheckedChanged(object sender, EventArgs e)
    {
      if (this.CheckBox_Tax3.Checked)
      {
        this.CheckBox_Tax3.Image = (Image) TriNetRestPOS.My.Resources.Resources.check_1;
        this.CheckBox_Tax3_01.Checked = true;
        this.CheckBox_Tax3_02.Checked = true;
        this.CheckBox_Tax3_03.Checked = true;
      }
      else
      {
        this.CheckBox_Tax3.Image = (Image) TriNetRestPOS.My.Resources.Resources.check_4;
        this.CheckBox_Tax3_01.Checked = false;
        this.CheckBox_Tax3_02.Checked = false;
        this.CheckBox_Tax3_03.Checked = false;
      }
    }

    private void CheckBox_IsDiscountClients_CheckedChanged(object sender, EventArgs e)
    {
      if (this.CheckBox_IsDiscountClients.Checked)
        this.CheckBox_NotIsDiscountClients.CheckState = CheckState.Unchecked;
      else
        this.CheckBox_NotIsDiscountClients.CheckState = CheckState.Checked;
    }

    private void CheckBox_NotIsDiscountClients_CheckedChanged(object sender, EventArgs e)
    {
      if (this.CheckBox_NotIsDiscountClients.Checked)
        this.CheckBox_IsDiscountClients.CheckState = CheckState.Unchecked;
      else
        this.CheckBox_IsDiscountClients.CheckState = CheckState.Checked;
    }

    private void CheckBox_IsUsePoints_CheckedChanged(object sender, EventArgs e)
    {
      if (this.CheckBox_IsUsePoints.Checked)
      {
        this.CheckBox_NotIsUsePoints.CheckState = CheckState.Unchecked;
        ((Control) this.TextBox_AmountUsePoints).Enabled = true;
        this.ComboBox_MonthExpiredPoints.Enabled = true;
        this.CheckBox_ShowOffer.Enabled = true;
        this.CheckBox_NotShowOffer.Enabled = true;
      }
      else
      {
        this.CheckBox_NotIsUsePoints.CheckState = CheckState.Checked;
        ((Control) this.TextBox_AmountUsePoints).Enabled = false;
        this.ComboBox_MonthExpiredPoints.Enabled = false;
        this.CheckBox_ShowOffer.Enabled = false;
        this.CheckBox_NotShowOffer.Enabled = false;
      }
    }

    private void CheckBox_NotIsUsePoints_CheckedChanged(object sender, EventArgs e)
    {
      if (this.CheckBox_NotIsUsePoints.Checked)
      {
        this.CheckBox_IsUsePoints.CheckState = CheckState.Unchecked;
        ((Control) this.TextBox_AmountUsePoints).Enabled = false;
        this.ComboBox_MonthExpiredPoints.Enabled = false;
        this.CheckBox_ShowOffer.Enabled = false;
        this.CheckBox_NotShowOffer.Enabled = false;
      }
      else
      {
        this.CheckBox_IsUsePoints.CheckState = CheckState.Checked;
        ((Control) this.TextBox_AmountUsePoints).Enabled = true;
        this.ComboBox_MonthExpiredPoints.Enabled = true;
        this.CheckBox_ShowOffer.Enabled = true;
        this.CheckBox_NotShowOffer.Enabled = true;
      }
    }

    private void CheckBox_ShowOffer_CheckedChanged(object sender, EventArgs e)
    {
      if (this.CheckBox_ShowOffer.Checked)
        this.CheckBox_NotShowOffer.CheckState = CheckState.Unchecked;
      else
        this.CheckBox_NotShowOffer.CheckState = CheckState.Checked;
    }

    private void CheckBox_NotShowOffer_CheckedChanged(object sender, EventArgs e)
    {
      if (this.CheckBox_NotShowOffer.Checked)
        this.CheckBox_ShowOffer.CheckState = CheckState.Unchecked;
      else
        this.CheckBox_ShowOffer.CheckState = CheckState.Checked;
    }

    private void CheckBox_IsPrintPrecountSend_CheckedChanged(object sender, EventArgs e)
    {
      if (this.CheckBox_IsPrintPrecountSend.Checked)
        this.CheckBox_IsNotPrintPrecountSend.CheckState = CheckState.Unchecked;
      else
        this.CheckBox_IsNotPrintPrecountSend.CheckState = CheckState.Checked;
    }

    private void CheckBox_IsNotPrintPrecountSend_CheckedChanged(object sender, EventArgs e)
    {
      if (this.CheckBox_IsNotPrintPrecountSend.Checked)
        this.CheckBox_IsPrintPrecountSend.CheckState = CheckState.Unchecked;
      else
        this.CheckBox_IsPrintPrecountSend.CheckState = CheckState.Checked;
    }

    private void CheckBox_IsDeleteItemNotSend_CheckedChanged(object sender, EventArgs e)
    {
      if (this.CheckBox_IsDeleteItemNotSend.Checked)
        this.CheckBox_IsNotDeleteItemNotSend.CheckState = CheckState.Unchecked;
      else
        this.CheckBox_IsNotDeleteItemNotSend.CheckState = CheckState.Checked;
    }

    private void CheckBox_IsNotDeleteItemNotSend_CheckedChanged(object sender, EventArgs e)
    {
      if (this.CheckBox_IsNotDeleteItemNotSend.Checked)
        this.CheckBox_IsDeleteItemNotSend.CheckState = CheckState.Unchecked;
      else
        this.CheckBox_IsDeleteItemNotSend.CheckState = CheckState.Checked;
    }

    private void CheckBox_IsPayThenCommnand_CheckedChanged(object sender, EventArgs e)
    {
      if (this.CheckBox_IsPayThenCommnand.Checked)
        this.CheckBox_IsNotPayThenCommnand.CheckState = CheckState.Unchecked;
      else
        this.CheckBox_IsNotPayThenCommnand.CheckState = CheckState.Checked;
    }

    private void CheckBox_IsNotPayThenCommnand_CheckedChanged(object sender, EventArgs e)
    {
      if (this.CheckBox_IsNotPayThenCommnand.Checked)
        this.CheckBox_IsPayThenCommnand.CheckState = CheckState.Unchecked;
      else
        this.CheckBox_IsPayThenCommnand.CheckState = CheckState.Checked;
    }

    private void CheckBox_IsPersonNum_CheckedChanged(object sender, EventArgs e)
    {
      if (this.CheckBox_IsPersonNum.Checked)
        this.CheckBox_IsNotPersonNum.CheckState = CheckState.Unchecked;
      else
        this.CheckBox_IsNotPersonNum.CheckState = CheckState.Checked;
    }

    private void CheckBox_IsNotPersonNum_CheckedChanged(object sender, EventArgs e)
    {
      if (this.CheckBox_IsNotPersonNum.Checked)
        this.CheckBox_IsPersonNum.CheckState = CheckState.Unchecked;
      else
        this.CheckBox_IsPersonNum.CheckState = CheckState.Checked;
    }

    private void CheckBox_IsDivCtaNum_CheckedChanged(object sender, EventArgs e)
    {
      if (this.CheckBox_IsDivCtaNum.Checked)
        this.CheckBox_IsNotDivCtaNum.CheckState = CheckState.Unchecked;
      else
        this.CheckBox_IsNotDivCtaNum.CheckState = CheckState.Checked;
    }

    private void CheckBox_IsNotDivCtaNum_CheckedChanged(object sender, EventArgs e)
    {
      if (this.CheckBox_IsNotDivCtaNum.Checked)
        this.CheckBox_IsDivCtaNum.CheckState = CheckState.Unchecked;
      else
        this.CheckBox_IsDivCtaNum.CheckState = CheckState.Checked;
    }

    private void CheckBox_ShowTax_CheckedChanged(object sender, EventArgs e)
    {
      if (this.CheckBox_ShowTax.Checked)
        this.CheckBox_NotShowTax.CheckState = CheckState.Unchecked;
      else
        this.CheckBox_NotShowTax.CheckState = CheckState.Checked;
    }

    private void CheckBox_NotShowTax_CheckedChanged(object sender, EventArgs e)
    {
      if (this.CheckBox_NotShowTax.Checked)
        this.CheckBox_ShowTax.CheckState = CheckState.Unchecked;
      else
        this.CheckBox_ShowTax.CheckState = CheckState.Checked;
    }

    private void CheckBox_NroSubmesas_CheckedChanged(object sender, EventArgs e)
    {
      if (this.CheckBox_NroSubmesas.Checked)
        this.CheckBox_NotNroSubmesas.CheckState = CheckState.Unchecked;
      else
        this.CheckBox_NotNroSubmesas.CheckState = CheckState.Checked;
    }

    private void CheckBox_NotNroSubmesas_CheckedChanged(object sender, EventArgs e)
    {
      if (this.CheckBox_NotNroSubmesas.Checked)
        this.CheckBox_NroSubmesas.CheckState = CheckState.Unchecked;
      else
        this.CheckBox_NroSubmesas.CheckState = CheckState.Checked;
    }

    private void CheckBox_IsPreguntarComanda_CheckedChanged(object sender, EventArgs e)
    {
      if (this.CheckBox_IsPreguntarComanda.Checked)
        this.CheckBox_IsNotPreguntarComanda.CheckState = CheckState.Unchecked;
      else
        this.CheckBox_IsNotPreguntarComanda.CheckState = CheckState.Checked;
    }

    private void CheckBox_IsNotPreguntarComanda_CheckedChanged(object sender, EventArgs e)
    {
      if (this.CheckBox_IsNotPreguntarComanda.Checked)
        this.CheckBox_IsPreguntarComanda.CheckState = CheckState.Unchecked;
      else
        this.CheckBox_IsPreguntarComanda.CheckState = CheckState.Checked;
    }

    private void CheckBox_IsVendedorTransfMesa_CheckedChanged(object sender, EventArgs e)
    {
      if (this.CheckBox_IsVendedorTransfMesa.Checked)
        this.CheckBox_IsNotVendedorTransfMesa.CheckState = CheckState.Unchecked;
      else
        this.CheckBox_IsNotVendedorTransfMesa.CheckState = CheckState.Checked;
    }

    private void CheckBox_IsNotVendedorTransfMesa_CheckedChanged(object sender, EventArgs e)
    {
      if (this.CheckBox_IsNotVendedorTransfMesa.Checked)
        this.CheckBox_IsVendedorTransfMesa.CheckState = CheckState.Unchecked;
      else
        this.CheckBox_IsVendedorTransfMesa.CheckState = CheckState.Checked;
    }

    private void CheckBox_IsExigeEnvioComanda_CheckedChanged(object sender, EventArgs e)
    {
      if (this.CheckBox_IsExigeEnvioComanda.Checked)
        this.CheckBox_NotIsExigeEnvioComanda.CheckState = CheckState.Unchecked;
      else
        this.CheckBox_NotIsExigeEnvioComanda.CheckState = CheckState.Checked;
    }

    private void CheckBox_NotIsExigeEnvioComanda_CheckedChanged(object sender, EventArgs e)
    {
      if (this.CheckBox_NotIsExigeEnvioComanda.Checked)
        this.CheckBox_IsExigeEnvioComanda.CheckState = CheckState.Unchecked;
      else
        this.CheckBox_IsExigeEnvioComanda.CheckState = CheckState.Checked;
    }

    private void CheckBox_IsSalirTomadoralEnviar_CheckedChanged(object sender, EventArgs e)
    {
      if (this.CheckBox_IsSalirTomadoralEnviar.Checked)
        this.CheckBox_NotIsSalirTomadoralEnviar.CheckState = CheckState.Unchecked;
      else
        this.CheckBox_NotIsSalirTomadoralEnviar.CheckState = CheckState.Checked;
    }

    private void CheckBox_NotIsSalirTomadoralEnviar_CheckedChanged(object sender, EventArgs e)
    {
      if (this.CheckBox_NotIsSalirTomadoralEnviar.Checked)
        this.CheckBox_IsSalirTomadoralEnviar.CheckState = CheckState.Unchecked;
      else
        this.CheckBox_IsSalirTomadoralEnviar.CheckState = CheckState.Checked;
    }

    private void CheckBox_PermisoAdminReimpComanda_CheckedChanged(object sender, EventArgs e)
    {
      if (this.CheckBox_PermisoAdminReimpComanda.Checked)
        this.CheckBox_NoPermisoAdminReimpComanda.CheckState = CheckState.Unchecked;
      else
        this.CheckBox_NoPermisoAdminReimpComanda.CheckState = CheckState.Checked;
    }

    private void CheckBox_NoPermisoAdminReimpComanda_CheckedChanged(object sender, EventArgs e)
    {
      if (this.CheckBox_NoPermisoAdminReimpComanda.Checked)
        this.CheckBox_PermisoAdminReimpComanda.CheckState = CheckState.Unchecked;
      else
        this.CheckBox_PermisoAdminReimpComanda.CheckState = CheckState.Checked;
    }

    private void CheckBox_PermisoAdminReimpPrecuenta_CheckedChanged(object sender, EventArgs e)
    {
      if (this.CheckBox_PermisoAdminReimpPrecuenta.Checked)
        this.CheckBox_NoPermisoAdminReimpPrecuenta.CheckState = CheckState.Unchecked;
      else
        this.CheckBox_NoPermisoAdminReimpPrecuenta.CheckState = CheckState.Checked;
    }

    private void CheckBox_NoPermisoAdminReimpPrecuenta_CheckedChanged(object sender, EventArgs e)
    {
      if (this.CheckBox_NoPermisoAdminReimpPrecuenta.Checked)
        this.CheckBox_PermisoAdminReimpPrecuenta.CheckState = CheckState.Unchecked;
      else
        this.CheckBox_PermisoAdminReimpPrecuenta.CheckState = CheckState.Checked;
    }

    private void CheckBox_DescuentoProgramado_CheckedChanged(object sender, EventArgs e)
    {
      if (this.CheckBox_DescuentoProgramado.Checked)
        this.CheckBox_NoDescuentoProgramado.CheckState = CheckState.Unchecked;
      else
        this.CheckBox_NoDescuentoProgramado.CheckState = CheckState.Checked;
    }

    private void CheckBox_NoDescuentoProgramado_CheckedChanged(object sender, EventArgs e)
    {
      if (this.CheckBox_NoDescuentoProgramado.Checked)
        this.CheckBox_DescuentoProgramado.CheckState = CheckState.Unchecked;
      else
        this.CheckBox_DescuentoProgramado.CheckState = CheckState.Checked;
    }

    private void btnFotoCliente_Click(object sender, EventArgs e)
    {
      this.FolderBrowserDialog_SearchPath.SelectedPath = ModGeneralVar.g_BE_TR1_VARIABLES_B.get_RutaFotoCliente();
      if (this.FolderBrowserDialog_SearchPath.ShowDialog() != DialogResult.OK)
        return;
      this.txtRutaFotoCliente.Text = this.FolderBrowserDialog_SearchPath.SelectedPath;
    }

    private void VerificarModulo()
    {
      if (!ModGeneralFunctions.ObtenerAPPCONFIG("MODULO").Equals((object) "POS"))
        return;
      this.CheckBox_IsPersonNum.Visible = false;
      this.CheckBox_IsNotPersonNum.Visible = false;
      this.Label16.Visible = false;
      ((Control) this.TextBox_PersonNum).Visible = false;
      this.Label19.Visible = false;
      this.CheckBox_IsDivCtaNum.Visible = false;
      this.CheckBox_IsNotDivCtaNum.Visible = false;
      this.Label17.Visible = false;
      ((Control) this.TextBox_DivCtaNum).Visible = false;
      this.Label18.Visible = false;
      this.CheckBox_NroSubmesas.Visible = false;
      this.CheckBox_NotNroSubmesas.Visible = false;
      this.Label22.Visible = false;
      this.ComboBox_NroSubmesas.Visible = false;
      this.Label21.Visible = false;
      this.CheckBox_IsVendedorTransfMesa.Visible = false;
      this.CheckBox_IsNotVendedorTransfMesa.Visible = false;
      this.Label31.Visible = false;
      this.CheckBox_IsSalirTomadoralEnviar.Visible = false;
      this.CheckBox_NotIsSalirTomadoralEnviar.Visible = false;
      this.Label32.Visible = false;
      this.CheckBox_PermisoAdminReimpComanda.Visible = false;
      this.CheckBox_NoPermisoAdminReimpComanda.Visible = false;
      this.Label34.Visible = false;
      this.CheckBox_PermisoAdminReimpPrecuenta.Visible = false;
      this.CheckBox_NoPermisoAdminReimpPrecuenta.Visible = false;
      this.Label35.Visible = false;
    }

    private void btnConfigurarCorreo_Click(object sender, EventArgs e)
    {
      int num = (int) new FrmAppConfig().ShowDialog();
    }

    private void Button_SaveImpuesto_Click(object sender, EventArgs e)
    {
      if (!ModGeneralFunctions.MessageMakeAction("¿Desea Guardar la Configuración de Impuesto?", false))
        return;
      BE_TR1_VARIABLES_IMPUESTO_TIPOPEDIDO impuestoTipopedido = new BE_TR1_VARIABLES_IMPUESTO_TIPOPEDIDO();
      impuestoTipopedido.set_EstabliId(ModGeneralVar.g_BE_TR1_VARIABLES_B.get_EstabliId());
      impuestoTipopedido.set_EmpresaId(ModGeneralVar.g_BE_TR1_VARIABLES_B.get_EmpresaId());
      impuestoTipopedido.set_LocalTax1(this.CheckBox_Tax1_01.Checked);
      impuestoTipopedido.set_LocalTax2(this.CheckBox_Tax2_01.Checked);
      impuestoTipopedido.set_LocalTax3(this.CheckBox_Tax3_01.Checked);
      impuestoTipopedido.set_DeliveryTax1(this.CheckBox_Tax1_02.Checked);
      impuestoTipopedido.set_DeliveryTax2(this.CheckBox_Tax2_02.Checked);
      impuestoTipopedido.set_DeliveryTax3(this.CheckBox_Tax3_02.Checked);
      impuestoTipopedido.set_VentanillaTax1(this.CheckBox_Tax1_03.Checked);
      impuestoTipopedido.set_VentanillaTax2(this.CheckBox_Tax2_03.Checked);
      impuestoTipopedido.set_VentanillaTax3(this.CheckBox_Tax3_03.Checked);
      string p_Mensaje = new BL_TR1_VARIABLE_IMPUESTO_TIPOPEDIDO().InsertarImpuestoTipoPedido(impuestoTipopedido);
      if (p_Mensaje.Equals(StructApp.RESULT_OK))
      {
        ModGeneralFunctions.MessageOk("¡Conf. Impuesto Actualizadas!");
        this.Close();
      }
      else
        ModGeneralFunctions.MessageError_Large(p_Mensaje, true);
    }
  }
}
