// Decompiled with JetBrains decompiler
// Type: TriNetRestPOS.FrmAppConfigDet
// Assembly: TriNetRestPOS, Version=5.2.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 43377352-E952-4AC1-9BA6-CCBE4AE5F575
// Assembly location: C:\log\TriNetRestPOS.exe

using APP_Utilities;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
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
  public class FrmAppConfigDet : Form
  {
    private IContainer components;
    private List<BE_TR1_APPCONFIG> oListAPPCONFIG;

    public FrmAppConfigDet()
    {
      this.Load += new EventHandler(this.FrmAppConfigDet_Load);
      this.KeyDown += new KeyEventHandler(this.FrmAppConfigDet_KeyDown);
      this.oListAPPCONFIG = new List<BE_TR1_APPCONFIG>();
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
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (FrmAppConfigDet));
      this.TabControl_Data = new TabControlEx();
      this.TabPage_Listado = new TabPage();
      this.Label6 = new Label();
      this.TextBox_Search = new TextBox();
      this.Panel_ButtonsActions = new Panel();
      this.Button_KBoardCriterio = new Button();
      this.Button_Close = new Button();
      this.Panel_ButtonsTools = new Panel();
      this.Button_Edit = new Button();
      this.Button_First = new Button();
      this.Button_Back = new Button();
      this.Button_Delete = new Button();
      this.Button_Forward = new Button();
      this.Button_Last = new Button();
      this.Button_New = new Button();
      this.dgrvData = new DataGridView();
      this.TabPage_Detail = new TabPage();
      this.Label7 = new Label();
      this.Label8 = new Label();
      this.txtDescripcion = new TextBox();
      this.GroupBox1 = new GroupBox();
      this.btnQuitarItem = new Button();
      this.btnAgregarItem = new Button();
      this.btnNuevoItem = new Button();
      this.Label11 = new Label();
      this.Label12 = new Label();
      this.txtValor = new TextBox();
      this.dgvDetalle = new DataGridView();
      this.Label9 = new Label();
      this.cboCaja = new ComboBox();
      this.txtItemId = new TextBox();
      this.Label1 = new Label();
      this.Label10 = new Label();
      this.Label5 = new Label();
      this.cboTipo = new ComboBox();
      this.Label13 = new Label();
      this.Label14 = new Label();
      this.Label4 = new Label();
      this.Label3 = new Label();
      this.txtId = new TextBox();
      this.Label2 = new Label();
      this.Label_Id = new Label();
      this.txtNombre = new TextBox();
      this.Button_CloseTab = new Button();
      this.Button_Save = new Button();
      this.ToolStripStatusLabel_Operation = new ToolStripStatusLabel();
      this.StatusStrip_Properties = new StatusStrip();
      this.Tssl_Record = new ToolStripStatusLabel();
      this.cboLocal = new ComboBox();
      this.Label15 = new Label();
      this.Label16 = new Label();
      this.cboEmpresa = new ComboBox();
      this.Label17 = new Label();
      this.Label18 = new Label();
      ((Control) this.TabControl_Data).SuspendLayout();
      this.TabPage_Listado.SuspendLayout();
      this.Panel_ButtonsActions.SuspendLayout();
      this.Panel_ButtonsTools.SuspendLayout();
      ((ISupportInitialize) this.dgrvData).BeginInit();
      this.TabPage_Detail.SuspendLayout();
      this.GroupBox1.SuspendLayout();
      ((ISupportInitialize) this.dgvDetalle).BeginInit();
      this.StatusStrip_Properties.SuspendLayout();
      this.SuspendLayout();
      ((Control) this.TabControl_Data).Controls.Add((Control) this.TabPage_Listado);
      ((Control) this.TabControl_Data).Controls.Add((Control) this.TabPage_Detail);
      ((Control) this.TabControl_Data).Font = new Font("Trebuchet MS", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      ((Control) this.TabControl_Data).Location = new Point(-1, 0);
      ((Control) this.TabControl_Data).Name = "TabControl_Data";
      ((TabControl) this.TabControl_Data).SelectedIndex = 0;
      ((Control) this.TabControl_Data).Size = new Size(570, 681);
      ((Control) this.TabControl_Data).TabIndex = 226;
      this.TabPage_Listado.Controls.Add((Control) this.Label6);
      this.TabPage_Listado.Controls.Add((Control) this.TextBox_Search);
      this.TabPage_Listado.Controls.Add((Control) this.Panel_ButtonsActions);
      this.TabPage_Listado.Controls.Add((Control) this.Panel_ButtonsTools);
      this.TabPage_Listado.Controls.Add((Control) this.dgrvData);
      this.TabPage_Listado.Font = new Font("Verdana", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.TabPage_Listado.Location = new Point(4, 29);
      this.TabPage_Listado.Name = "TabPage_Listado";
      this.TabPage_Listado.Padding = new Padding(3);
      this.TabPage_Listado.Size = new Size(562, 648);
      this.TabPage_Listado.TabIndex = 0;
      this.TabPage_Listado.Text = "Listado";
      this.TabPage_Listado.UseVisualStyleBackColor = true;
      this.Label6.AutoSize = true;
      this.Label6.Font = new Font("Trebuchet MS", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Label6.ForeColor = Color.MediumBlue;
      this.Label6.Location = new Point(4, 9);
      this.Label6.Name = "Label6";
      this.Label6.Size = new Size(75, 20);
      this.Label6.TabIndex = 149;
      this.Label6.Text = "Nombre :";
      this.TextBox_Search.Font = new Font("Trebuchet MS", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.TextBox_Search.Location = new Point(8, 32);
      this.TextBox_Search.MaxLength = 50;
      this.TextBox_Search.Name = "TextBox_Search";
      this.TextBox_Search.Size = new Size(380, 25);
      this.TextBox_Search.TabIndex = 0;
      this.Panel_ButtonsActions.Controls.Add((Control) this.Button_KBoardCriterio);
      this.Panel_ButtonsActions.Controls.Add((Control) this.Button_Close);
      this.Panel_ButtonsActions.Location = new Point(396, 0);
      this.Panel_ButtonsActions.Name = "Panel_ButtonsActions";
      this.Panel_ButtonsActions.Size = new Size(167, 62);
      this.Panel_ButtonsActions.TabIndex = 2;
      this.Button_KBoardCriterio.Font = new Font("Trebuchet MS", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Button_KBoardCriterio.ForeColor = Color.MediumBlue;
      this.Button_KBoardCriterio.Image = (Image) componentResourceManager.GetObject("Button_KBoardCriterio.Image");
      this.Button_KBoardCriterio.Location = new Point(1, 1);
      this.Button_KBoardCriterio.Name = "Button_KBoardCriterio";
      this.Button_KBoardCriterio.Size = new Size(83, 60);
      this.Button_KBoardCriterio.TabIndex = 4;
      this.Button_KBoardCriterio.Text = "&Teclado";
      this.Button_KBoardCriterio.TextImageRelation = TextImageRelation.TextAboveImage;
      this.Button_KBoardCriterio.UseVisualStyleBackColor = true;
      this.Button_Close.Font = new Font("Trebuchet MS", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Button_Close.ForeColor = Color.MediumBlue;
      this.Button_Close.Image = (Image) TriNetRestPOS.My.Resources.Resources.i_Close;
      this.Button_Close.Location = new Point(83, 1);
      this.Button_Close.Name = "Button_Close";
      this.Button_Close.Size = new Size(83, 60);
      this.Button_Close.TabIndex = 2;
      this.Button_Close.Text = "&Salir";
      this.Button_Close.TextImageRelation = TextImageRelation.TextAboveImage;
      this.Button_Close.UseVisualStyleBackColor = true;
      this.Panel_ButtonsTools.Controls.Add((Control) this.Button_Edit);
      this.Panel_ButtonsTools.Controls.Add((Control) this.Button_First);
      this.Panel_ButtonsTools.Controls.Add((Control) this.Button_Back);
      this.Panel_ButtonsTools.Controls.Add((Control) this.Button_Delete);
      this.Panel_ButtonsTools.Controls.Add((Control) this.Button_Forward);
      this.Panel_ButtonsTools.Controls.Add((Control) this.Button_Last);
      this.Panel_ButtonsTools.Controls.Add((Control) this.Button_New);
      this.Panel_ButtonsTools.Location = new Point(478, 63);
      this.Panel_ButtonsTools.Name = "Panel_ButtonsTools";
      this.Panel_ButtonsTools.Size = new Size(85, 584);
      this.Panel_ButtonsTools.TabIndex = 146;
      this.Button_Edit.Font = new Font("Trebuchet MS", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Button_Edit.ForeColor = Color.MediumBlue;
      this.Button_Edit.Image = (Image) TriNetRestPOS.My.Resources.Resources.Actualizar;
      this.Button_Edit.Location = new Point(1, 82);
      this.Button_Edit.Name = "Button_Edit";
      this.Button_Edit.RightToLeft = RightToLeft.Yes;
      this.Button_Edit.Size = new Size(83, 60);
      this.Button_Edit.TabIndex = 14;
      this.Button_Edit.Text = "E&ditar";
      this.Button_Edit.TextImageRelation = TextImageRelation.TextAboveImage;
      this.Button_Edit.UseVisualStyleBackColor = true;
      this.Button_First.Font = new Font("Verdana", 18f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Button_First.Image = (Image) TriNetRestPOS.My.Resources.Resources.Fast_back;
      this.Button_First.Location = new Point(1, 257);
      this.Button_First.Name = "Button_First";
      this.Button_First.RightToLeft = RightToLeft.Yes;
      this.Button_First.Size = new Size(83, 60);
      this.Button_First.TabIndex = 10;
      this.Button_First.UseVisualStyleBackColor = true;
      this.Button_Back.Font = new Font("Verdana", 18f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Button_Back.Image = (Image) TriNetRestPOS.My.Resources.Resources.go_back;
      this.Button_Back.Location = new Point(1, 316);
      this.Button_Back.Name = "Button_Back";
      this.Button_Back.RightToLeft = RightToLeft.Yes;
      this.Button_Back.Size = new Size(83, 60);
      this.Button_Back.TabIndex = 11;
      this.Button_Back.UseVisualStyleBackColor = true;
      this.Button_Delete.Font = new Font("Trebuchet MS", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Button_Delete.ForeColor = Color.MediumBlue;
      this.Button_Delete.Image = (Image) TriNetRestPOS.My.Resources.Resources.Eliminar;
      this.Button_Delete.Location = new Point(1, 141);
      this.Button_Delete.Name = "Button_Delete";
      this.Button_Delete.RightToLeft = RightToLeft.Yes;
      this.Button_Delete.Size = new Size(83, 60);
      this.Button_Delete.TabIndex = 8;
      this.Button_Delete.Text = "&Eliminar";
      this.Button_Delete.TextImageRelation = TextImageRelation.TextAboveImage;
      this.Button_Delete.UseVisualStyleBackColor = true;
      this.Button_Forward.Font = new Font("Verdana", 18f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Button_Forward.Image = (Image) TriNetRestPOS.My.Resources.Resources.go_forward;
      this.Button_Forward.Location = new Point(1, 375);
      this.Button_Forward.Name = "Button_Forward";
      this.Button_Forward.RightToLeft = RightToLeft.Yes;
      this.Button_Forward.Size = new Size(83, 60);
      this.Button_Forward.TabIndex = 12;
      this.Button_Forward.UseVisualStyleBackColor = true;
      this.Button_Last.Font = new Font("Verdana", 18f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Button_Last.Image = (Image) TriNetRestPOS.My.Resources.Resources.fast_forward;
      this.Button_Last.Location = new Point(1, 434);
      this.Button_Last.Name = "Button_Last";
      this.Button_Last.RightToLeft = RightToLeft.Yes;
      this.Button_Last.Size = new Size(83, 60);
      this.Button_Last.TabIndex = 13;
      this.Button_Last.UseVisualStyleBackColor = true;
      this.Button_New.Font = new Font("Trebuchet MS", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Button_New.ForeColor = Color.MediumBlue;
      this.Button_New.Image = (Image) TriNetRestPOS.My.Resources.Resources.i_News;
      this.Button_New.ImageAlign = ContentAlignment.BottomCenter;
      this.Button_New.Location = new Point(1, 23);
      this.Button_New.Name = "Button_New";
      this.Button_New.Size = new Size(83, 60);
      this.Button_New.TabIndex = 6;
      this.Button_New.Text = "&Nuevo";
      this.Button_New.TextImageRelation = TextImageRelation.TextAboveImage;
      this.Button_New.UseVisualStyleBackColor = true;
      this.dgrvData.BorderStyle = BorderStyle.Fixed3D;
      this.dgrvData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dgrvData.Location = new Point(0, 63);
      this.dgrvData.MultiSelect = false;
      this.dgrvData.Name = "dgrvData";
      this.dgrvData.ScrollBars = ScrollBars.None;
      this.dgrvData.Size = new Size(477, 585);
      this.dgrvData.TabIndex = 1;
      this.TabPage_Detail.Controls.Add((Control) this.Label7);
      this.TabPage_Detail.Controls.Add((Control) this.Label8);
      this.TabPage_Detail.Controls.Add((Control) this.txtDescripcion);
      this.TabPage_Detail.Controls.Add((Control) this.GroupBox1);
      this.TabPage_Detail.Controls.Add((Control) this.cboTipo);
      this.TabPage_Detail.Controls.Add((Control) this.Label13);
      this.TabPage_Detail.Controls.Add((Control) this.Label14);
      this.TabPage_Detail.Controls.Add((Control) this.Label4);
      this.TabPage_Detail.Controls.Add((Control) this.Label3);
      this.TabPage_Detail.Controls.Add((Control) this.txtId);
      this.TabPage_Detail.Controls.Add((Control) this.Label2);
      this.TabPage_Detail.Controls.Add((Control) this.Label_Id);
      this.TabPage_Detail.Controls.Add((Control) this.txtNombre);
      this.TabPage_Detail.Controls.Add((Control) this.Button_CloseTab);
      this.TabPage_Detail.Controls.Add((Control) this.Button_Save);
      this.TabPage_Detail.Location = new Point(4, 29);
      this.TabPage_Detail.Name = "TabPage_Detail";
      this.TabPage_Detail.Padding = new Padding(3);
      this.TabPage_Detail.Size = new Size(562, 648);
      this.TabPage_Detail.TabIndex = 1;
      this.TabPage_Detail.Text = "Mantenimiento";
      this.TabPage_Detail.UseVisualStyleBackColor = true;
      this.Label7.AutoSize = true;
      this.Label7.Font = new Font("Trebuchet MS", 11.25f, FontStyle.Bold);
      this.Label7.ForeColor = Color.MediumBlue;
      this.Label7.Location = new Point(79, 84);
      this.Label7.Name = "Label7";
      this.Label7.Size = new Size(15, 20);
      this.Label7.TabIndex = 269;
      this.Label7.Text = ":";
      this.Label8.AutoSize = true;
      this.Label8.Font = new Font("Trebuchet MS", 11.25f, FontStyle.Bold);
      this.Label8.ForeColor = Color.MediumBlue;
      this.Label8.Location = new Point(16, 84);
      this.Label8.Name = "Label8";
      this.Label8.Size = new Size(67, 20);
      this.Label8.TabIndex = 268;
      this.Label8.Text = "Descrip.";
      this.txtDescripcion.BackColor = SystemColors.Window;
      this.txtDescripcion.CausesValidation = false;
      this.txtDescripcion.Location = new Point(100, 81);
      this.txtDescripcion.MaxLength = 200;
      this.txtDescripcion.Multiline = true;
      this.txtDescripcion.Name = "txtDescripcion";
      this.txtDescripcion.Size = new Size(435, 46);
      this.txtDescripcion.TabIndex = 3;
      this.txtDescripcion.TabStop = false;
      this.GroupBox1.Controls.Add((Control) this.cboEmpresa);
      this.GroupBox1.Controls.Add((Control) this.Label17);
      this.GroupBox1.Controls.Add((Control) this.Label18);
      this.GroupBox1.Controls.Add((Control) this.cboLocal);
      this.GroupBox1.Controls.Add((Control) this.Label15);
      this.GroupBox1.Controls.Add((Control) this.Label16);
      this.GroupBox1.Controls.Add((Control) this.btnQuitarItem);
      this.GroupBox1.Controls.Add((Control) this.btnAgregarItem);
      this.GroupBox1.Controls.Add((Control) this.btnNuevoItem);
      this.GroupBox1.Controls.Add((Control) this.Label11);
      this.GroupBox1.Controls.Add((Control) this.Label12);
      this.GroupBox1.Controls.Add((Control) this.txtValor);
      this.GroupBox1.Controls.Add((Control) this.dgvDetalle);
      this.GroupBox1.Controls.Add((Control) this.Label9);
      this.GroupBox1.Controls.Add((Control) this.cboCaja);
      this.GroupBox1.Controls.Add((Control) this.txtItemId);
      this.GroupBox1.Controls.Add((Control) this.Label1);
      this.GroupBox1.Controls.Add((Control) this.Label10);
      this.GroupBox1.Controls.Add((Control) this.Label5);
      this.GroupBox1.ForeColor = Color.Red;
      this.GroupBox1.Location = new Point(6, 133);
      this.GroupBox1.Name = "GroupBox1";
      this.GroupBox1.Size = new Size(550, 440);
      this.GroupBox1.TabIndex = 4;
      this.GroupBox1.TabStop = false;
      this.GroupBox1.Text = "Detalle";
      this.btnQuitarItem.Image = (Image) TriNetRestPOS.My.Resources.Resources.i_LessS;
      this.btnQuitarItem.Location = new Point(495, 116);
      this.btnQuitarItem.Name = "btnQuitarItem";
      this.btnQuitarItem.Size = new Size(35, 32);
      this.btnQuitarItem.TabIndex = 12;
      this.btnQuitarItem.UseVisualStyleBackColor = true;
      this.btnAgregarItem.Image = (Image) TriNetRestPOS.My.Resources.Resources.i_MoreS;
      this.btnAgregarItem.Location = new Point(461, 116);
      this.btnAgregarItem.Name = "btnAgregarItem";
      this.btnAgregarItem.Size = new Size(35, 32);
      this.btnAgregarItem.TabIndex = 11;
      this.btnAgregarItem.UseVisualStyleBackColor = true;
      this.btnNuevoItem.Image = (Image) TriNetRestPOS.My.Resources.Resources.i_NewsS;
      this.btnNuevoItem.Location = new Point(427, 116);
      this.btnNuevoItem.Name = "btnNuevoItem";
      this.btnNuevoItem.Size = new Size(35, 32);
      this.btnNuevoItem.TabIndex = 10;
      this.btnNuevoItem.UseVisualStyleBackColor = true;
      this.Label11.AutoSize = true;
      this.Label11.Font = new Font("Trebuchet MS", 11.25f, FontStyle.Bold);
      this.Label11.ForeColor = Color.MediumBlue;
      this.Label11.Location = new Point(73, 123);
      this.Label11.Name = "Label11";
      this.Label11.Size = new Size(15, 20);
      this.Label11.TabIndex = 276;
      this.Label11.Text = ":";
      this.Label12.AutoSize = true;
      this.Label12.Font = new Font("Trebuchet MS", 11.25f, FontStyle.Bold);
      this.Label12.ForeColor = Color.MediumBlue;
      this.Label12.Location = new Point(10, 123);
      this.Label12.Name = "Label12";
      this.Label12.Size = new Size(44, 20);
      this.Label12.TabIndex = 275;
      this.Label12.Text = "Valor";
      this.txtValor.BackColor = SystemColors.Window;
      this.txtValor.CausesValidation = false;
      this.txtValor.Location = new Point(94, 120);
      this.txtValor.MaxLength = 200;
      this.txtValor.Name = "txtValor";
      this.txtValor.Size = new Size(329, 25);
      this.txtValor.TabIndex = 9;
      this.txtValor.TabStop = false;
      this.dgvDetalle.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dgvDetalle.Location = new Point(4, 150);
      this.dgvDetalle.Name = "dgvDetalle";
      this.dgvDetalle.Size = new Size(543, 285);
      this.dgvDetalle.TabIndex = 13;
      this.Label9.AutoSize = true;
      this.Label9.Font = new Font("Trebuchet MS", 11.25f, FontStyle.Bold);
      this.Label9.ForeColor = Color.MediumBlue;
      this.Label9.Location = new Point(408, 89);
      this.Label9.Name = "Label9";
      this.Label9.Size = new Size(15, 20);
      this.Label9.TabIndex = 272;
      this.Label9.Text = ":";
      this.cboCaja.DropDownStyle = ComboBoxStyle.DropDownList;
      this.cboCaja.FormattingEnabled = true;
      this.cboCaja.Location = new Point(94, 86);
      this.cboCaja.Name = "cboCaja";
      this.cboCaja.Size = new Size(261, 28);
      this.cboCaja.TabIndex = 7;
      this.txtItemId.BackColor = Color.FromArgb((int) byte.MaxValue, 240, 144);
      this.txtItemId.Location = new Point(429, 86);
      this.txtItemId.MaxLength = 50;
      this.txtItemId.Name = "txtItemId";
      this.txtItemId.ReadOnly = true;
      this.txtItemId.Size = new Size(100, 25);
      this.txtItemId.TabIndex = 8;
      this.txtItemId.TabStop = false;
      this.txtItemId.TextAlign = HorizontalAlignment.Center;
      this.Label1.AutoSize = true;
      this.Label1.Font = new Font("Trebuchet MS", 11.25f, FontStyle.Bold);
      this.Label1.ForeColor = Color.MediumBlue;
      this.Label1.Location = new Point(73, 89);
      this.Label1.Name = "Label1";
      this.Label1.Size = new Size(15, 20);
      this.Label1.TabIndex = 267;
      this.Label1.Text = ":";
      this.Label10.AutoSize = true;
      this.Label10.Font = new Font("Trebuchet MS", 11.25f, FontStyle.Bold);
      this.Label10.ForeColor = Color.MediumBlue;
      this.Label10.Location = new Point(361, 89);
      this.Label10.Name = "Label10";
      this.Label10.Size = new Size(41, 20);
      this.Label10.TabIndex = 271;
      this.Label10.Text = "Item";
      this.Label5.AutoSize = true;
      this.Label5.Font = new Font("Trebuchet MS", 11.25f, FontStyle.Bold);
      this.Label5.ForeColor = Color.MediumBlue;
      this.Label5.Location = new Point(10, 89);
      this.Label5.Name = "Label5";
      this.Label5.Size = new Size(40, 20);
      this.Label5.TabIndex = 266;
      this.Label5.Text = "Caja";
      this.cboTipo.DropDownStyle = ComboBoxStyle.DropDownList;
      this.cboTipo.FormattingEnabled = true;
      this.cboTipo.Items.AddRange(new object[6]
      {
        (object) "«Seleccione»",
        (object) "String",
        (object) "Boolean",
        (object) "Integer",
        (object) "Float",
        (object) "Datetime"
      });
      this.cboTipo.Location = new Point(332, 14);
      this.cboTipo.Name = "cboTipo";
      this.cboTipo.Size = new Size(203, 28);
      this.cboTipo.TabIndex = 1;
      this.Label13.AutoSize = true;
      this.Label13.Font = new Font("Trebuchet MS", 11.25f, FontStyle.Bold);
      this.Label13.ForeColor = Color.MediumBlue;
      this.Label13.Location = new Point(311, 17);
      this.Label13.Name = "Label13";
      this.Label13.Size = new Size(15, 20);
      this.Label13.TabIndex = 264;
      this.Label13.Text = ":";
      this.Label14.AutoSize = true;
      this.Label14.Font = new Font("Trebuchet MS", 11.25f, FontStyle.Bold);
      this.Label14.ForeColor = Color.MediumBlue;
      this.Label14.Location = new Point(266, 17);
      this.Label14.Name = "Label14";
      this.Label14.Size = new Size(39, 20);
      this.Label14.TabIndex = 263;
      this.Label14.Text = "Tipo";
      this.Label4.AutoSize = true;
      this.Label4.Font = new Font("Trebuchet MS", 11.25f, FontStyle.Bold);
      this.Label4.ForeColor = Color.MediumBlue;
      this.Label4.Location = new Point(79, 52);
      this.Label4.Name = "Label4";
      this.Label4.Size = new Size(15, 20);
      this.Label4.TabIndex = 243;
      this.Label4.Text = ":";
      this.Label3.AutoSize = true;
      this.Label3.Font = new Font("Trebuchet MS", 11.25f, FontStyle.Bold);
      this.Label3.ForeColor = Color.MediumBlue;
      this.Label3.Location = new Point(79, 17);
      this.Label3.Name = "Label3";
      this.Label3.Size = new Size(15, 20);
      this.Label3.TabIndex = 242;
      this.Label3.Text = ":";
      this.txtId.BackColor = Color.FromArgb((int) byte.MaxValue, 240, 144);
      this.txtId.Location = new Point(100, 14);
      this.txtId.MaxLength = 50;
      this.txtId.Name = "txtId";
      this.txtId.ReadOnly = true;
      this.txtId.Size = new Size(150, 25);
      this.txtId.TabIndex = 0;
      this.txtId.TabStop = false;
      this.txtId.TextAlign = HorizontalAlignment.Center;
      this.Label2.AutoSize = true;
      this.Label2.Font = new Font("Trebuchet MS", 11.25f, FontStyle.Bold);
      this.Label2.ForeColor = Color.MediumBlue;
      this.Label2.Location = new Point(16, 17);
      this.Label2.Name = "Label2";
      this.Label2.Size = new Size(55, 20);
      this.Label2.TabIndex = 217;
      this.Label2.Text = "Código";
      this.Label_Id.AutoSize = true;
      this.Label_Id.Font = new Font("Trebuchet MS", 11.25f, FontStyle.Bold);
      this.Label_Id.ForeColor = Color.MediumBlue;
      this.Label_Id.Location = new Point(16, 52);
      this.Label_Id.Name = "Label_Id";
      this.Label_Id.Size = new Size(64, 20);
      this.Label_Id.TabIndex = 206;
      this.Label_Id.Text = "Nombre";
      this.txtNombre.BackColor = SystemColors.Window;
      this.txtNombre.CausesValidation = false;
      this.txtNombre.Location = new Point(100, 49);
      this.txtNombre.MaxLength = 200;
      this.txtNombre.Name = "txtNombre";
      this.txtNombre.Size = new Size(435, 25);
      this.txtNombre.TabIndex = 2;
      this.txtNombre.TabStop = false;
      this.Button_CloseTab.Font = new Font("Trebuchet MS", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Button_CloseTab.ForeColor = Color.MediumBlue;
      this.Button_CloseTab.Image = (Image) TriNetRestPOS.My.Resources.Resources.i_Close;
      this.Button_CloseTab.Location = new Point(455, 579);
      this.Button_CloseTab.Name = "Button_CloseTab";
      this.Button_CloseTab.Size = new Size(100, 60);
      this.Button_CloseTab.TabIndex = 15;
      this.Button_CloseTab.Text = "&Salir";
      this.Button_CloseTab.TextImageRelation = TextImageRelation.TextAboveImage;
      this.Button_CloseTab.UseVisualStyleBackColor = true;
      this.Button_Save.Font = new Font("Trebuchet MS", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Button_Save.ForeColor = Color.MediumBlue;
      this.Button_Save.Image = (Image) TriNetRestPOS.My.Resources.Resources.i_Ready;
      this.Button_Save.Location = new Point(349, 579);
      this.Button_Save.Name = "Button_Save";
      this.Button_Save.Size = new Size(100, 60);
      this.Button_Save.TabIndex = 14;
      this.Button_Save.Text = "&Grabar";
      this.Button_Save.TextImageRelation = TextImageRelation.TextAboveImage;
      this.Button_Save.UseVisualStyleBackColor = true;
      this.ToolStripStatusLabel_Operation.Font = new Font("Trebuchet MS", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.ToolStripStatusLabel_Operation.ForeColor = Color.MediumBlue;
      this.ToolStripStatusLabel_Operation.Name = "ToolStripStatusLabel_Operation";
      this.ToolStripStatusLabel_Operation.Size = new Size(0, 20);
      this.StatusStrip_Properties.BackColor = Color.White;
      this.StatusStrip_Properties.Font = new Font("Trebuchet MS", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.StatusStrip_Properties.Items.AddRange(new ToolStripItem[2]
      {
        (ToolStripItem) this.ToolStripStatusLabel_Operation,
        (ToolStripItem) this.Tssl_Record
      });
      this.StatusStrip_Properties.Location = new Point(0, 677);
      this.StatusStrip_Properties.Name = "StatusStrip_Properties";
      this.StatusStrip_Properties.Size = new Size(568, 25);
      this.StatusStrip_Properties.TabIndex = 227;
      this.StatusStrip_Properties.Text = "StatusStrip1";
      this.Tssl_Record.Font = new Font("Trebuchet MS", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Tssl_Record.ForeColor = Color.MediumBlue;
      this.Tssl_Record.Name = "Tssl_Record";
      this.Tssl_Record.Size = new Size(553, 20);
      this.Tssl_Record.Spring = true;
      this.Tssl_Record.Text = "N° Record";
      this.Tssl_Record.TextAlign = ContentAlignment.MiddleRight;
      this.cboLocal.DropDownStyle = ComboBoxStyle.DropDownList;
      this.cboLocal.FormattingEnabled = true;
      this.cboLocal.Location = new Point(94, 20);
      this.cboLocal.Name = "cboLocal";
      this.cboLocal.Size = new Size(436, 28);
      this.cboLocal.TabIndex = 5;
      this.Label15.AutoSize = true;
      this.Label15.Font = new Font("Trebuchet MS", 11.25f, FontStyle.Bold);
      this.Label15.ForeColor = Color.MediumBlue;
      this.Label15.Location = new Point(73, 23);
      this.Label15.Name = "Label15";
      this.Label15.Size = new Size(15, 20);
      this.Label15.TabIndex = 279;
      this.Label15.Text = ":";
      this.Label16.AutoSize = true;
      this.Label16.Font = new Font("Trebuchet MS", 11.25f, FontStyle.Bold);
      this.Label16.ForeColor = Color.MediumBlue;
      this.Label16.Location = new Point(10, 23);
      this.Label16.Name = "Label16";
      this.Label16.Size = new Size(45, 20);
      this.Label16.TabIndex = 278;
      this.Label16.Text = "Local";
      this.cboEmpresa.DropDownStyle = ComboBoxStyle.DropDownList;
      this.cboEmpresa.FormattingEnabled = true;
      this.cboEmpresa.Location = new Point(94, 53);
      this.cboEmpresa.Name = "cboEmpresa";
      this.cboEmpresa.Size = new Size(436, 28);
      this.cboEmpresa.TabIndex = 6;
      this.Label17.AutoSize = true;
      this.Label17.Font = new Font("Trebuchet MS", 11.25f, FontStyle.Bold);
      this.Label17.ForeColor = Color.MediumBlue;
      this.Label17.Location = new Point(73, 56);
      this.Label17.Name = "Label17";
      this.Label17.Size = new Size(15, 20);
      this.Label17.TabIndex = 282;
      this.Label17.Text = ":";
      this.Label18.AutoSize = true;
      this.Label18.Font = new Font("Trebuchet MS", 11.25f, FontStyle.Bold);
      this.Label18.ForeColor = Color.MediumBlue;
      this.Label18.Location = new Point(10, 56);
      this.Label18.Name = "Label18";
      this.Label18.Size = new Size(69, 20);
      this.Label18.TabIndex = 281;
      this.Label18.Text = "Empresa";
      this.AutoScaleDimensions = new SizeF(9f, 20f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.BackColor = SystemColors.Window;
      this.ClientSize = new Size(568, 702);
      this.Controls.Add((Control) this.TabControl_Data);
      this.Controls.Add((Control) this.StatusStrip_Properties);
      this.Font = new Font("Trebuchet MS", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.FormBorderStyle = FormBorderStyle.FixedDialog;
      this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
      this.KeyPreview = true;
      this.Margin = new Padding(4, 5, 4, 5);
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = nameof (FrmAppConfigDet);
      this.StartPosition = FormStartPosition.CenterScreen;
      this.Text = "Configuración de Variables";
      ((Control) this.TabControl_Data).ResumeLayout(false);
      this.TabPage_Listado.ResumeLayout(false);
      this.TabPage_Listado.PerformLayout();
      this.Panel_ButtonsActions.ResumeLayout(false);
      this.Panel_ButtonsTools.ResumeLayout(false);
      ((ISupportInitialize) this.dgrvData).EndInit();
      this.TabPage_Detail.ResumeLayout(false);
      this.TabPage_Detail.PerformLayout();
      this.GroupBox1.ResumeLayout(false);
      this.GroupBox1.PerformLayout();
      ((ISupportInitialize) this.dgvDetalle).EndInit();
      this.StatusStrip_Properties.ResumeLayout(false);
      this.StatusStrip_Properties.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();
    }

    internal virtual TabControlEx TabControl_Data { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual TabPage TabPage_Listado { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Label Label6 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual TextBox TextBox_Search
    {
      get
      {
        return this._TextBox_Search;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.TextBox_Search_TextChanged);
        TextBox textBoxSearch1 = this._TextBox_Search;
        if (textBoxSearch1 != null)
          textBoxSearch1.TextChanged -= eventHandler;
        this._TextBox_Search = value;
        TextBox textBoxSearch2 = this._TextBox_Search;
        if (textBoxSearch2 == null)
          return;
        textBoxSearch2.TextChanged += eventHandler;
      }
    }

    internal virtual Panel Panel_ButtonsActions { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Button Button_KBoardCriterio
    {
      get
      {
        return this._Button_KBoardCriterio;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Button_KBoardCriterio_Click);
        Button buttonKboardCriterio1 = this._Button_KBoardCriterio;
        if (buttonKboardCriterio1 != null)
          buttonKboardCriterio1.Click -= eventHandler;
        this._Button_KBoardCriterio = value;
        Button buttonKboardCriterio2 = this._Button_KBoardCriterio;
        if (buttonKboardCriterio2 == null)
          return;
        buttonKboardCriterio2.Click += eventHandler;
      }
    }

    internal virtual Button Button_Close
    {
      get
      {
        return this._Button_Close;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Button_Close_Click);
        Button buttonClose1 = this._Button_Close;
        if (buttonClose1 != null)
          buttonClose1.Click -= eventHandler;
        this._Button_Close = value;
        Button buttonClose2 = this._Button_Close;
        if (buttonClose2 == null)
          return;
        buttonClose2.Click += eventHandler;
      }
    }

    internal virtual Panel Panel_ButtonsTools { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Button Button_Edit
    {
      get
      {
        return this._Button_Edit;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Button_Edit_Click);
        Button buttonEdit1 = this._Button_Edit;
        if (buttonEdit1 != null)
          buttonEdit1.Click -= eventHandler;
        this._Button_Edit = value;
        Button buttonEdit2 = this._Button_Edit;
        if (buttonEdit2 == null)
          return;
        buttonEdit2.Click += eventHandler;
      }
    }

    internal virtual Button Button_First
    {
      get
      {
        return this._Button_First;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Button_First_Click);
        Button buttonFirst1 = this._Button_First;
        if (buttonFirst1 != null)
          buttonFirst1.Click -= eventHandler;
        this._Button_First = value;
        Button buttonFirst2 = this._Button_First;
        if (buttonFirst2 == null)
          return;
        buttonFirst2.Click += eventHandler;
      }
    }

    internal virtual Button Button_Back
    {
      get
      {
        return this._Button_Back;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Button_Back_Click);
        Button buttonBack1 = this._Button_Back;
        if (buttonBack1 != null)
          buttonBack1.Click -= eventHandler;
        this._Button_Back = value;
        Button buttonBack2 = this._Button_Back;
        if (buttonBack2 == null)
          return;
        buttonBack2.Click += eventHandler;
      }
    }

    internal virtual Button Button_Delete
    {
      get
      {
        return this._Button_Delete;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Button_Delete_Click);
        Button buttonDelete1 = this._Button_Delete;
        if (buttonDelete1 != null)
          buttonDelete1.Click -= eventHandler;
        this._Button_Delete = value;
        Button buttonDelete2 = this._Button_Delete;
        if (buttonDelete2 == null)
          return;
        buttonDelete2.Click += eventHandler;
      }
    }

    internal virtual Button Button_Forward
    {
      get
      {
        return this._Button_Forward;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Button_Forward_Click);
        Button buttonForward1 = this._Button_Forward;
        if (buttonForward1 != null)
          buttonForward1.Click -= eventHandler;
        this._Button_Forward = value;
        Button buttonForward2 = this._Button_Forward;
        if (buttonForward2 == null)
          return;
        buttonForward2.Click += eventHandler;
      }
    }

    internal virtual Button Button_Last
    {
      get
      {
        return this._Button_Last;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Button_Last_Click);
        Button buttonLast1 = this._Button_Last;
        if (buttonLast1 != null)
          buttonLast1.Click -= eventHandler;
        this._Button_Last = value;
        Button buttonLast2 = this._Button_Last;
        if (buttonLast2 == null)
          return;
        buttonLast2.Click += eventHandler;
      }
    }

    internal virtual Button Button_New
    {
      get
      {
        return this._Button_New;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Button_New_Click);
        Button buttonNew1 = this._Button_New;
        if (buttonNew1 != null)
          buttonNew1.Click -= eventHandler;
        this._Button_New = value;
        Button buttonNew2 = this._Button_New;
        if (buttonNew2 == null)
          return;
        buttonNew2.Click += eventHandler;
      }
    }

    internal virtual DataGridView dgrvData
    {
      get
      {
        return this._dgrvData;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        DataGridViewCellEventHandler cellEventHandler1 = new DataGridViewCellEventHandler(this.dgrvData_CellClick);
        DataGridViewCellEventHandler cellEventHandler2 = new DataGridViewCellEventHandler(this.dgrvData_CellDoubleClick);
        KeyEventHandler keyEventHandler1 = new KeyEventHandler(this.dgrvData_KeyDown);
        KeyEventHandler keyEventHandler2 = new KeyEventHandler(this.dgrvData_KeyUp);
        MouseEventHandler mouseEventHandler = new MouseEventHandler(this.dgrvData_MouseClick);
        DataGridView dgrvData1 = this._dgrvData;
        if (dgrvData1 != null)
        {
          dgrvData1.CellClick -= cellEventHandler1;
          dgrvData1.CellDoubleClick -= cellEventHandler2;
          dgrvData1.KeyDown -= keyEventHandler1;
          dgrvData1.KeyUp -= keyEventHandler2;
          dgrvData1.MouseClick -= mouseEventHandler;
        }
        this._dgrvData = value;
        DataGridView dgrvData2 = this._dgrvData;
        if (dgrvData2 == null)
          return;
        dgrvData2.CellClick += cellEventHandler1;
        dgrvData2.CellDoubleClick += cellEventHandler2;
        dgrvData2.KeyDown += keyEventHandler1;
        dgrvData2.KeyUp += keyEventHandler2;
        dgrvData2.MouseClick += mouseEventHandler;
      }
    }

    internal virtual TabPage TabPage_Detail { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Label Label4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Label Label3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual TextBox txtId { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Label Label2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Label Label_Id { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual TextBox txtNombre { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Button Button_CloseTab
    {
      get
      {
        return this._Button_CloseTab;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Button_CloseTab_Click);
        Button buttonCloseTab1 = this._Button_CloseTab;
        if (buttonCloseTab1 != null)
          buttonCloseTab1.Click -= eventHandler;
        this._Button_CloseTab = value;
        Button buttonCloseTab2 = this._Button_CloseTab;
        if (buttonCloseTab2 == null)
          return;
        buttonCloseTab2.Click += eventHandler;
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

    internal virtual ToolStripStatusLabel ToolStripStatusLabel_Operation { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual StatusStrip StatusStrip_Properties { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual ToolStripStatusLabel Tssl_Record { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual ComboBox cboTipo { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Label Label13 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Label Label14 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual GroupBox GroupBox1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual ComboBox cboCaja { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Label Label1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Label Label5 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Label Label7 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Label Label8 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual TextBox txtDescripcion { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Label Label9 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual TextBox txtItemId { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Label Label10 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Button btnNuevoItem
    {
      get
      {
        return this._btnNuevoItem;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.btnNuevoItem_Click);
        Button btnNuevoItem1 = this._btnNuevoItem;
        if (btnNuevoItem1 != null)
          btnNuevoItem1.Click -= eventHandler;
        this._btnNuevoItem = value;
        Button btnNuevoItem2 = this._btnNuevoItem;
        if (btnNuevoItem2 == null)
          return;
        btnNuevoItem2.Click += eventHandler;
      }
    }

    internal virtual Label Label11 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Label Label12 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual TextBox txtValor { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual DataGridView dgvDetalle
    {
      get
      {
        return this._dgvDetalle;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        DataGridViewCellEventHandler cellEventHandler = new DataGridViewCellEventHandler(this.dgvDetalle_CellDoubleClick);
        DataGridView dgvDetalle1 = this._dgvDetalle;
        if (dgvDetalle1 != null)
          dgvDetalle1.CellDoubleClick -= cellEventHandler;
        this._dgvDetalle = value;
        DataGridView dgvDetalle2 = this._dgvDetalle;
        if (dgvDetalle2 == null)
          return;
        dgvDetalle2.CellDoubleClick += cellEventHandler;
      }
    }

    internal virtual Button btnAgregarItem
    {
      get
      {
        return this._btnAgregarItem;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.btnAgregarItem_Click);
        Button btnAgregarItem1 = this._btnAgregarItem;
        if (btnAgregarItem1 != null)
          btnAgregarItem1.Click -= eventHandler;
        this._btnAgregarItem = value;
        Button btnAgregarItem2 = this._btnAgregarItem;
        if (btnAgregarItem2 == null)
          return;
        btnAgregarItem2.Click += eventHandler;
      }
    }

    internal virtual Button btnQuitarItem
    {
      get
      {
        return this._btnQuitarItem;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.btnQuitarItem_Click);
        Button btnQuitarItem1 = this._btnQuitarItem;
        if (btnQuitarItem1 != null)
          btnQuitarItem1.Click -= eventHandler;
        this._btnQuitarItem = value;
        Button btnQuitarItem2 = this._btnQuitarItem;
        if (btnQuitarItem2 == null)
          return;
        btnQuitarItem2.Click += eventHandler;
      }
    }

    internal virtual ComboBox cboLocal
    {
      get
      {
        return this._cboLocal;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.cboLocal_SelectedIndexChanged);
        ComboBox cboLocal1 = this._cboLocal;
        if (cboLocal1 != null)
          cboLocal1.SelectedIndexChanged -= eventHandler;
        this._cboLocal = value;
        ComboBox cboLocal2 = this._cboLocal;
        if (cboLocal2 == null)
          return;
        cboLocal2.SelectedIndexChanged += eventHandler;
      }
    }

    internal virtual Label Label15 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Label Label16 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual ComboBox cboEmpresa { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Label Label17 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Label Label18 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    private void FrmAppConfigDet_Load(object sender, EventArgs e)
    {
      this.setearGrid();
      this.setearGridDetalle();
      this.cargarLocales();
      this.cargarCajas();
      this.cargarAppConfig();
      this.FirstTab((short) 0, "Listado de Configuraciones");
      this.TextBox_Search.Focus();
    }

    private void FrmAppConfigDet_KeyDown(object sender, KeyEventArgs e)
    {
      if (!e.KeyValue.Equals(27))
        return;
      this.Close();
    }

    private void TextBox_Search_TextChanged(object sender, EventArgs e)
    {
      this.cargarAppConfig();
    }

    private void Button_KBoardCriterio_Click(object sender, EventArgs e)
    {
      TextBox textBoxSearch;
      string text = (textBoxSearch = this.TextBox_Search).Text;
      ModGeneralFunctions.TextKeyBoard("Ingrese Descripción", ref text);
      textBoxSearch.Text = text;
      if (!ModGeneralVar.g_bol_IsReady)
        return;
      this.TextBox_Search.Text = ModGeneralVar.g_str_InputValue;
    }

    private void Button_Close_Click(object sender, EventArgs e)
    {
      this.Close();
    }

    private void Button_New_Click(object sender, EventArgs e)
    {
      this.SetOperation(StructApp.RECORD_CREATE);
      this.SetOperationDetails(StructApp.RECORD_CREATE);
      this.FirstTab((short) 1, StructApp.RECORD_CREATE);
    }

    private void Button_Edit_Click(object sender, EventArgs e)
    {
      if (!ModGeneralFunctions.DataGrid_Validated(this.dgrvData))
        return;
      this.SetOperation(StructApp.RECORD_EDIT);
      this.SetOperationDetails(StructApp.RECORD_CREATE);
      this.FirstTab((short) 1, StructApp.RECORD_EDIT);
    }

    private void Button_Delete_Click(object sender, EventArgs e)
    {
      if (!this.DataGV_Validated())
        return;
      this.SetOperation(StructApp.RECORD_DELETE);
    }

    private void Button_First_Click(object sender, EventArgs e)
    {
      if (!this.DataGV_Validated())
        return;
      this.dgrvData.CurrentCell = this.dgrvData[1, 0];
      this.SelectITem();
      this.Information_Quantity_Of_Records();
    }

    private void Button_Back_Click(object sender, EventArgs e)
    {
      if (!this.DataGV_Validated())
        return;
      short num = checked ((short) (this.dgrvData.CurrentRow.Index - 1));
      if (num > (short) -1)
      {
        this.dgrvData.CurrentCell = this.dgrvData[1, (int) num];
        this.SelectITem();
        this.Information_Quantity_Of_Records();
      }
    }

    private void Button_Forward_Click(object sender, EventArgs e)
    {
      if (!this.DataGV_Validated())
        return;
      short index = checked ((short) this.dgrvData.CurrentRow.Index);
      if ((int) index < checked (this.dgrvData.Rows.Count - 1))
      {
        this.dgrvData.CurrentCell = this.dgrvData[1, checked ((int) index + 1)];
        this.SelectITem();
        this.Information_Quantity_Of_Records();
      }
    }

    private void Button_Last_Click(object sender, EventArgs e)
    {
      if (!this.DataGV_Validated())
        return;
      this.dgrvData.CurrentCell = this.dgrvData[1, checked (this.dgrvData.Rows.Count - 1)];
      this.SelectITem();
      this.Information_Quantity_Of_Records();
    }

    private void dgrvData_CellClick(object sender, DataGridViewCellEventArgs e)
    {
      this.SelectITem();
    }

    private void dgrvData_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
    {
      if (!ModGeneralFunctions.DataGrid_Validated(this.dgrvData))
        return;
      this.SetOperation(StructApp.RECORD_EDIT);
      this.FirstTab((short) 1, StructApp.RECORD_EDIT);
    }

    private void dgrvData_KeyDown(object sender, KeyEventArgs e)
    {
      this.Information_Quantity_Of_Records();
    }

    private void dgrvData_KeyUp(object sender, KeyEventArgs e)
    {
      this.Information_Quantity_Of_Records();
    }

    private void dgrvData_MouseClick(object sender, MouseEventArgs e)
    {
      this.Information_Quantity_Of_Records();
    }

    private void dgvDetalle_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
    {
      if (!ModGeneralFunctions.DataGrid_Validated(this.dgvDetalle))
        return;
      this.SetOperationDetails(StructApp.RECORD_EDIT);
    }

    private void btnNuevoItem_Click(object sender, EventArgs e)
    {
      this.SetOperationDetails(StructApp.RECORD_CREATE);
    }

    private void btnAgregarItem_Click(object sender, EventArgs e)
    {
      if (ModGeneralFunctions.CadenaToInteger(this.txtItemId.Text) == 0)
        this.MakeOperationDetails(StructApp.RECORD_CREATE);
      else
        this.MakeOperationDetails(StructApp.RECORD_EDIT);
    }

    private void btnQuitarItem_Click(object sender, EventArgs e)
    {
      this.SetOperationDetails(StructApp.RECORD_DELETE);
    }

    private void cboLocal_SelectedIndexChanged(object sender, EventArgs e)
    {
      this.cargarEmpresas();
    }

    private void Button_Save_Click(object sender, EventArgs e)
    {
      this.MakeOperation(this.ToolStripStatusLabel_Operation.Text);
    }

    private void Button_CloseTab_Click(object sender, EventArgs e)
    {
      this.FirstTab((short) 0, "Listado de Promociones");
    }

    private void setearGrid()
    {
      ModGeneralFunctions.SetUpDataGridViewBasic(this.dgrvData);
      this.dgrvData.Columns.Add("Id", "Id");
      ModGeneralFunctions.SetUp_TextBoxColumn((DataGridViewTextBoxColumn) this.dgrvData.Columns[0], "Id", (short) 40, "", true, DataGridViewContentAlignment.MiddleCenter, true);
      this.dgrvData.Columns.Add("Nombre", "Nombre");
      ModGeneralFunctions.SetUp_TextBoxColumn((DataGridViewTextBoxColumn) this.dgrvData.Columns[1], "Nombre", (short) 320, "", true, DataGridViewContentAlignment.MiddleLeft, true);
      this.dgrvData.Columns.Add("Tipo", "Tipo");
      ModGeneralFunctions.SetUp_TextBoxColumn((DataGridViewTextBoxColumn) this.dgrvData.Columns[2], "Tipo", (short) 83, "", true, DataGridViewContentAlignment.MiddleCenter, true);
      this.dgrvData.Columns.Add("", "");
      ModGeneralFunctions.SetUp_TextBoxColumn((DataGridViewTextBoxColumn) this.dgrvData.Columns[3], "", (short) 18, "", true, DataGridViewContentAlignment.MiddleLeft, true);
      this.dgrvData.ScrollBars = ScrollBars.Vertical;
    }

    private void setearGridDetalle()
    {
      ModGeneralFunctions.SetUpDataGridViewBasic(this.dgvDetalle);
      this.dgvDetalle.Columns.Add("ItemId", "ItemId");
      ModGeneralFunctions.SetUp_TextBoxColumn((DataGridViewTextBoxColumn) this.dgvDetalle.Columns[0], "ItemId", (short) 50, "", false, DataGridViewContentAlignment.MiddleLeft, true);
      this.dgvDetalle.Columns.Add("EstabliId", "L");
      ModGeneralFunctions.SetUp_TextBoxColumn((DataGridViewTextBoxColumn) this.dgvDetalle.Columns[1], "EstabliId", (short) 18, "", true, DataGridViewContentAlignment.MiddleCenter, true);
      this.dgvDetalle.Columns.Add("EmpresaId", "E");
      ModGeneralFunctions.SetUp_TextBoxColumn((DataGridViewTextBoxColumn) this.dgvDetalle.Columns[2], "EmpresaId", (short) 18, "", true, DataGridViewContentAlignment.MiddleCenter, true);
      this.dgvDetalle.Columns.Add("BoxDes", "Caja");
      ModGeneralFunctions.SetUp_TextBoxColumn((DataGridViewTextBoxColumn) this.dgvDetalle.Columns[3], "BoxDes", (short) 180, "", true, DataGridViewContentAlignment.MiddleLeft, true);
      this.dgvDetalle.Columns.Add("Valor", "Valor");
      ModGeneralFunctions.SetUp_TextBoxColumn((DataGridViewTextBoxColumn) this.dgvDetalle.Columns[4], "Valor", (short) 296, "", true, DataGridViewContentAlignment.MiddleLeft, true);
      this.dgvDetalle.Columns.Add("", "");
      ModGeneralFunctions.SetUp_TextBoxColumn((DataGridViewTextBoxColumn) this.dgvDetalle.Columns[5], "", (short) 18, "", true, DataGridViewContentAlignment.MiddleLeft, true);
      this.dgvDetalle.ScrollBars = ScrollBars.Vertical;
    }

    private void cargarAppConfig()
    {
      this.dgrvData.DataSource = (object) new BL_TR1_APPCONFIG().ListarTodo(this.TextBox_Search.Text.Trim());
      this.Information_Quantity_Of_Records();
    }

    private void cargarAppConfigDetalle(int id)
    {
      this.dgvDetalle.DataSource = (object) new BL_TR1_APPCONFIG().ListarDetallexId(id);
    }

    private bool cargarLocales()
    {
      BL_TR1_ESTABLI blTr1Establi = new BL_TR1_ESTABLI();
      List<BE_TR1_ESTABLI> beTr1EstabliList1 = new List<BE_TR1_ESTABLI>();
      List<BE_TR1_ESTABLI> beTr1EstabliList2 = blTr1Establi.List();
      if (beTr1EstabliList2 == null || beTr1EstabliList2.Count == 0)
        return false;
      beTr1EstabliList2.Insert(0, new BE_TR1_ESTABLI(Conversions.ToInteger("0"), "«Seleccione»"));
      this.cboLocal.ValueMember = "EstabliId";
      this.cboLocal.DisplayMember = "EstabliDes";
      this.cboLocal.DataSource = (object) beTr1EstabliList2;
      this.cboLocal.SelectedIndex = 1;
      beTr1EstabliList1 = (List<BE_TR1_ESTABLI>) null;
      return true;
    }

    private bool cargarEmpresas()
    {
      BL_TR1_CONFIGURATION tr1Configuration = new BL_TR1_CONFIGURATION();
      List<BE_TR1_VARIABLES_B> beTr1VariablesBList1 = new List<BE_TR1_VARIABLES_B>();
      List<BE_TR1_VARIABLES_B> beTr1VariablesBList2 = tr1Configuration.ListarEmpresas(Conversions.ToInteger(this.cboLocal.SelectedValue));
      if (beTr1VariablesBList2 == null || beTr1VariablesBList2.Count == 0)
        return false;
      beTr1VariablesBList2.Insert(0, new BE_TR1_VARIABLES_B(Conversions.ToInteger("0"), "«Seleccione»"));
      this.cboEmpresa.ValueMember = "EmpresaId";
      this.cboEmpresa.DisplayMember = "SocialReason";
      this.cboEmpresa.DataSource = (object) beTr1VariablesBList2;
      this.cboEmpresa.SelectedIndex = 0;
      beTr1VariablesBList1 = (List<BE_TR1_VARIABLES_B>) null;
      return true;
    }

    private void cargarCajas()
    {
      BL_TR1_BOXES blTr1Boxes = new BL_TR1_BOXES();
      BE_TR1_BOXES beTr1Boxes = new BE_TR1_BOXES();
      List<BE_TR1_BOXES> beTr1BoxesList = new List<BE_TR1_BOXES>();
      beTr1Boxes.set_BoxId(0);
      beTr1Boxes.set_BoxDes("«Todos»");
      beTr1BoxesList.Add(beTr1Boxes);
      beTr1BoxesList.AddRange((IEnumerable<BE_TR1_BOXES>) blTr1Boxes.ListByDes(ModGeneralVar.g_BE_TR1_VARIABLES_B.get_EstabliId(), ""));
      this.cboCaja.DataSource = (object) beTr1BoxesList;
      this.cboCaja.DisplayMember = "BoxDes";
      this.cboCaja.ValueMember = "BoxId";
    }

    private void FirstTab(short _Index, string _Text)
    {
      this.ToolStripStatusLabel_Operation.Text = _Text;
      ((TabControl) this.TabControl_Data).SelectedIndex = (int) _Index;
      if (_Index == (short) 0)
      {
        TabControlEx tabControlData = this.TabControl_Data;
        TabPage tabPageDetail = this.TabPage_Detail;
        ref TabPage local = ref tabPageDetail;
        tabControlData.DisablePage(ref local);
        this.TabPage_Detail = tabPageDetail;
        this.TabPage_Listado.Enabled = true;
        this.TextBox_Search.Focus();
      }
      else
      {
        TabControlEx tabControlData = this.TabControl_Data;
        TabPage tabPageListado = this.TabPage_Listado;
        ref TabPage local = ref tabPageListado;
        tabControlData.DisablePage(ref local);
        this.TabPage_Listado = tabPageListado;
        this.TabPage_Detail.Enabled = true;
        this.txtNombre.Focus();
      }
    }

    private bool DataGV_Validated()
    {
      return this.dgrvData.Rows.Count > 0;
    }

    private void SetOperation(string _Operation)
    {
      this.ToolStripStatusLabel_Operation.Text = _Operation;
      if (Operators.CompareString(_Operation, StructApp.RECORD_CREATE, false) == 0)
      {
        this.txtId.Text = "";
        this.txtNombre.Text = "";
        this.txtNombre.ReadOnly = false;
        this.txtNombre.BackColor = Color.White;
        this.cboTipo.SelectedIndex = 0;
        this.txtDescripcion.Text = "";
        this.dgvDetalle.DataSource = (object) null;
        this.dgvDetalle.Refresh();
        this.txtNombre.Focus();
      }
      else if (Operators.CompareString(_Operation, StructApp.RECORD_EDIT, false) == 0)
      {
        this.txtId.Text = Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateIndexGet(this.dgrvData.DataSource, new object[1]
        {
          (object) this.dgrvData.CurrentRow.Index
        }, (string[]) null), (System.Type) null, "Id", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
        this.txtNombre.Text = Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateIndexGet(this.dgrvData.DataSource, new object[1]
        {
          (object) this.dgrvData.CurrentRow.Index
        }, (string[]) null), (System.Type) null, "Nombre", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
        this.txtNombre.ReadOnly = true;
        this.txtNombre.BackColor = ModGeneralVar.g_TextBox_BackColor_Strong;
        this.cboTipo.Text = Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateIndexGet(this.dgrvData.DataSource, new object[1]
        {
          (object) this.dgrvData.CurrentRow.Index
        }, (string[]) null), (System.Type) null, "Tipo", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
        this.txtDescripcion.Text = Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateIndexGet(this.dgrvData.DataSource, new object[1]
        {
          (object) this.dgrvData.CurrentRow.Index
        }, (string[]) null), (System.Type) null, "Descripcion", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
        this.cargarAppConfigDetalle(ModGeneralFunctions.CadenaToInteger(this.txtId.Text));
        this.txtNombre.Focus();
      }
      else
      {
        if (Operators.CompareString(_Operation, StructApp.RECORD_DELETE, false) != 0)
          return;
        this.txtId.Text = Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateIndexGet(this.dgrvData.DataSource, new object[1]
        {
          (object) this.dgrvData.CurrentRow.Index
        }, (string[]) null), (System.Type) null, "Id", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
        this.txtNombre.Text = Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateIndexGet(this.dgrvData.DataSource, new object[1]
        {
          (object) this.dgrvData.CurrentRow.Index
        }, (string[]) null), (System.Type) null, "Nombre", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
        this.MakeOperation(this.ToolStripStatusLabel_Operation.Text);
      }
    }

    private void SetOperationDetails(string _Operation)
    {
      if (Operators.CompareString(_Operation, StructApp.RECORD_CREATE, false) == 0)
      {
        this.txtItemId.Text = "";
        this.cboCaja.SelectedIndex = 0;
        this.txtValor.Text = "";
        this.cboCaja.Focus();
      }
      else if (Operators.CompareString(_Operation, StructApp.RECORD_EDIT, false) == 0)
      {
        this.txtItemId.Text = Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateIndexGet(this.dgvDetalle.DataSource, new object[1]
        {
          (object) this.dgvDetalle.CurrentRow.Index
        }, (string[]) null), (System.Type) null, "ItemId", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
        this.cboLocal.SelectedValue = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(NewLateBinding.LateIndexGet(this.dgvDetalle.DataSource, new object[1]
        {
          (object) this.dgvDetalle.CurrentRow.Index
        }, (string[]) null), (System.Type) null, "EstabliId", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
        this.cboEmpresa.SelectedValue = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(NewLateBinding.LateIndexGet(this.dgvDetalle.DataSource, new object[1]
        {
          (object) this.dgvDetalle.CurrentRow.Index
        }, (string[]) null), (System.Type) null, "EmpresaId", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
        this.cboCaja.SelectedValue = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(NewLateBinding.LateIndexGet(this.dgvDetalle.DataSource, new object[1]
        {
          (object) this.dgvDetalle.CurrentRow.Index
        }, (string[]) null), (System.Type) null, "BoxId", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
        this.txtValor.Text = Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateIndexGet(this.dgvDetalle.DataSource, new object[1]
        {
          (object) this.dgvDetalle.CurrentRow.Index
        }, (string[]) null), (System.Type) null, "Valor", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
        this.cboCaja.Focus();
      }
      else
      {
        if (Operators.CompareString(_Operation, StructApp.RECORD_DELETE, false) != 0)
          return;
        this.txtItemId.Text = Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateIndexGet(this.dgvDetalle.DataSource, new object[1]
        {
          (object) this.dgvDetalle.CurrentRow.Index
        }, (string[]) null), (System.Type) null, "ItemId", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
        this.cboLocal.SelectedValue = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(NewLateBinding.LateIndexGet(this.dgvDetalle.DataSource, new object[1]
        {
          (object) this.dgvDetalle.CurrentRow.Index
        }, (string[]) null), (System.Type) null, "EstabliId", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
        this.cboEmpresa.SelectedValue = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(NewLateBinding.LateIndexGet(this.dgvDetalle.DataSource, new object[1]
        {
          (object) this.dgvDetalle.CurrentRow.Index
        }, (string[]) null), (System.Type) null, "EmpresaId", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
        this.MakeOperationDetails(this.ToolStripStatusLabel_Operation.Text);
      }
    }

    private void MakeOperation(string _Operation)
    {
      BL_TR1_APPCONFIG blTr1Appconfig1 = new BL_TR1_APPCONFIG();
      BL_TR1_APPCONFIG blTr1Appconfig2;
      BE_TR1_APPCONFIG beTr1Appconfig1;
      if (Operators.CompareString(_Operation, StructApp.RECORD_CREATE, false) == 0)
      {
        if (!this.validarDatos() || !ModGeneralFunctions.MessageMakeAction("¿Seguro de Guardar?", false))
          return;
        BE_TR1_APPCONFIG beTr1Appconfig2 = new BE_TR1_APPCONFIG();
        beTr1Appconfig2.set_EstabliId(ModGeneralVar.g_BE_TR1_VARIABLES_B.get_EstabliId());
        beTr1Appconfig2.set_EmpresaId(ModGeneralVar.g_BE_TR1_VARIABLES_B.get_EmpresaId());
        beTr1Appconfig2.set_Id(0);
        beTr1Appconfig2.set_Nombre(this.txtNombre.Text.Trim());
        beTr1Appconfig2.set_Tipo(this.cboTipo.Text.Trim());
        beTr1Appconfig2.set_Descripcion(this.txtDescripcion.Text.Trim());
        beTr1Appconfig2.set_UsuCreacion(ModGeneralVar.g_BE_USERS.get_UserId());
        string p_Mensaje = blTr1Appconfig1.Insertar(ref beTr1Appconfig2);
        if (p_Mensaje.Equals(StructApp.RESULT_OK))
        {
          this.txtId.Text = "";
          this.cargarAppConfig();
          this.ubicarRegistro(Conversions.ToString(beTr1Appconfig2.get_Id()));
          this.Information_Quantity_Of_Records();
          ModGeneralFunctions.MessageOk("¡Registro Creado!");
          this.FirstTab((short) 0, "Listado de Configuraciones");
        }
        else
          ModGeneralFunctions.MessageError_Large(p_Mensaje, true);
        beTr1Appconfig2 = (BE_TR1_APPCONFIG) null;
        blTr1Appconfig2 = (BL_TR1_APPCONFIG) null;
      }
      else if (Operators.CompareString(_Operation, StructApp.RECORD_EDIT, false) == 0)
      {
        if (!this.validarDatos() || !ModGeneralFunctions.MessageMakeAction("¿Seguro de Editar?", false))
          return;
        BE_TR1_APPCONFIG beTr1Appconfig2 = new BE_TR1_APPCONFIG();
        beTr1Appconfig2.set_EstabliId(ModGeneralVar.g_BE_TR1_VARIABLES_B.get_EstabliId());
        beTr1Appconfig2.set_EmpresaId(ModGeneralVar.g_BE_TR1_VARIABLES_B.get_EmpresaId());
        beTr1Appconfig2.set_Id(ModGeneralFunctions.CadenaToInteger(this.txtId.Text));
        beTr1Appconfig2.set_Nombre(this.txtNombre.Text.Trim());
        beTr1Appconfig2.set_Tipo(this.cboTipo.Text.Trim());
        beTr1Appconfig2.set_Descripcion(this.txtDescripcion.Text.Trim());
        beTr1Appconfig2.set_UsuModifica(ModGeneralVar.g_BE_USERS.get_UserId());
        string p_Mensaje = blTr1Appconfig1.Editar(beTr1Appconfig2);
        if (p_Mensaje.Equals(StructApp.RESULT_OK))
        {
          this.txtId.Text = "";
          this.cargarAppConfig();
          this.ubicarRegistro(Conversions.ToString(beTr1Appconfig2.get_Id()));
          this.Information_Quantity_Of_Records();
          ModGeneralFunctions.MessageOk("¡Registro Editado!");
          this.FirstTab((short) 0, "Listado de Configuraciones");
        }
        else
          ModGeneralFunctions.MessageError_Large(p_Mensaje, true);
        beTr1Appconfig1 = (BE_TR1_APPCONFIG) null;
        blTr1Appconfig2 = (BL_TR1_APPCONFIG) null;
      }
      else if (Operators.CompareString(_Operation, StructApp.RECORD_DELETE, false) == 0)
      {
        if (!ModGeneralFunctions.MessageMakeAction("¿Seguro de Eliminar?", false))
          return;
        beTr1Appconfig1 = new BE_TR1_APPCONFIG();
        string p_Mensaje = blTr1Appconfig1.Eliminar(ModGeneralVar.g_BE_TR1_VARIABLES_B.get_EstabliId(), ModGeneralVar.g_BE_TR1_VARIABLES_B.get_EmpresaId(), ModGeneralFunctions.CadenaToInteger(this.txtId.Text));
        if (p_Mensaje.Equals(StructApp.RESULT_OK))
        {
          short index = checked ((short) this.dgrvData.CurrentRow.Index);
          this.txtId.Text = "";
          this.cargarAppConfig();
          if (this.dgrvData.Rows.Count > 1 & index > (short) 0)
            this.dgrvData.CurrentCell = this.dgrvData[1, checked ((int) index - 1)];
          this.Information_Quantity_Of_Records();
          ModGeneralFunctions.MessageOk("¡Registro Eliminado!");
        }
        else
          ModGeneralFunctions.MessageError_Large(p_Mensaje, true);
        this.FirstTab((short) 0, "Listado de Configuraciones");
      }
      else
      {
        if (Operators.CompareString(_Operation, StructApp.RECORD_SEARCH, false) != 0)
          return;
        this.cargarAppConfig();
        this.Information_Quantity_Of_Records();
        this.FirstTab((short) 0, "Listado de Configuraciones");
      }
    }

    private void MakeOperationDetails(string _Operation)
    {
      BL_TR1_APPCONFIG blTr1Appconfig1 = new BL_TR1_APPCONFIG();
      BL_TR1_APPCONFIG blTr1Appconfig2;
      BE_TR1_APPCONFIG beTr1Appconfig1;
      if (Operators.CompareString(_Operation, StructApp.RECORD_CREATE, false) == 0)
      {
        if (!this.validarDatosDetalle())
          return;
        BE_TR1_APPCONFIG beTr1Appconfig2 = new BE_TR1_APPCONFIG();
        beTr1Appconfig2.set_EstabliId(Conversions.ToInteger(this.cboLocal.SelectedValue));
        beTr1Appconfig2.set_EmpresaId(Conversions.ToInteger(this.cboEmpresa.SelectedValue));
        beTr1Appconfig2.set_BoxId(Conversions.ToInteger(this.cboCaja.SelectedValue));
        beTr1Appconfig2.set_Id(ModGeneralFunctions.CadenaToInteger(this.txtId.Text));
        beTr1Appconfig2.set_ItemId(ModGeneralFunctions.CadenaToInteger(this.txtItemId.Text));
        beTr1Appconfig2.set_Valor(this.txtValor.Text.Trim());
        beTr1Appconfig2.set_UsuCreacion(ModGeneralVar.g_BE_USERS.get_UserId());
        string p_Mensaje = blTr1Appconfig1.InsertarItem(ref beTr1Appconfig2);
        if (p_Mensaje.Equals(StructApp.RESULT_OK))
        {
          this.cargarAppConfigDetalle(ModGeneralFunctions.CadenaToInteger(this.txtId.Text));
          this.SetOperationDetails(StructApp.RECORD_CREATE);
        }
        else
          ModGeneralFunctions.MessageError_Large(p_Mensaje, true);
        beTr1Appconfig2 = (BE_TR1_APPCONFIG) null;
        blTr1Appconfig2 = (BL_TR1_APPCONFIG) null;
      }
      else if (Operators.CompareString(_Operation, StructApp.RECORD_EDIT, false) == 0)
      {
        if (!this.validarDatosDetalle())
          return;
        BE_TR1_APPCONFIG beTr1Appconfig2 = new BE_TR1_APPCONFIG();
        beTr1Appconfig2.set_EstabliId(Conversions.ToInteger(this.cboLocal.SelectedValue));
        beTr1Appconfig2.set_EmpresaId(Conversions.ToInteger(this.cboEmpresa.SelectedValue));
        beTr1Appconfig2.set_BoxId(Conversions.ToInteger(this.cboCaja.SelectedValue));
        beTr1Appconfig2.set_Id(ModGeneralFunctions.CadenaToInteger(this.txtId.Text));
        beTr1Appconfig2.set_ItemId(ModGeneralFunctions.CadenaToInteger(this.txtItemId.Text));
        beTr1Appconfig2.set_Valor(this.txtValor.Text.Trim());
        beTr1Appconfig2.set_UsuModifica(ModGeneralVar.g_BE_USERS.get_UserId());
        string p_Mensaje = blTr1Appconfig1.EditarItem(beTr1Appconfig2);
        if (p_Mensaje.Equals(StructApp.RESULT_OK))
        {
          this.cargarAppConfigDetalle(ModGeneralFunctions.CadenaToInteger(this.txtId.Text));
          this.SetOperationDetails(StructApp.RECORD_CREATE);
        }
        else
          ModGeneralFunctions.MessageError_Large(p_Mensaje, true);
        beTr1Appconfig1 = (BE_TR1_APPCONFIG) null;
        blTr1Appconfig2 = (BL_TR1_APPCONFIG) null;
      }
      else
      {
        if (Operators.CompareString(_Operation, StructApp.RECORD_DELETE, false) != 0 || !ModGeneralFunctions.MessageMakeAction("¿Seguro de Eliminar Item?", false))
          return;
        beTr1Appconfig1 = new BE_TR1_APPCONFIG();
        string p_Mensaje = blTr1Appconfig1.EliminarItem(Conversions.ToInteger(this.cboLocal.SelectedValue), Conversions.ToInteger(this.cboEmpresa.SelectedValue), ModGeneralFunctions.CadenaToInteger(this.txtItemId.Text));
        if (p_Mensaje.Equals(StructApp.RESULT_OK))
        {
          this.cargarAppConfigDetalle(ModGeneralFunctions.CadenaToInteger(this.txtId.Text));
          this.SetOperationDetails(StructApp.RECORD_CREATE);
        }
        else
          ModGeneralFunctions.MessageError_Large(p_Mensaje, true);
      }
    }

    private void Information_Quantity_Of_Records()
    {
      if (!this.DataGV_Validated())
        this.Tssl_Record.Text = "Actual: 0 /  Total de Registros: 0";
      else
        this.Tssl_Record.Text = "Actual: " + Conversions.ToString(checked (this.dgrvData.CurrentRow.Index + 1)) + " /  Total de Registros: " + Conversions.ToString(this.dgrvData.RowCount);
    }

    private bool validarDatos()
    {
      if (this.cboTipo.SelectedIndex == 0)
      {
        ModGeneralFunctions.MessageOk("¡Seleccione un Tipo!");
        this.cboTipo.Focus();
        return false;
      }
      if (!this.txtNombre.Text.Trim().Equals(""))
        return true;
      ModGeneralFunctions.MessageOk("¡Ingrese una Descripción!");
      this.txtNombre.Focus();
      return false;
    }

    private bool validarDatosDetalle()
    {
      if (this.cboLocal.SelectedIndex == 0)
      {
        ModGeneralFunctions.MessageOk("¡Seleccione un Local!");
        this.cboLocal.Focus();
        return false;
      }
      if (this.cboEmpresa.SelectedIndex == 0)
      {
        ModGeneralFunctions.MessageOk("¡Seleccione una Empresa!");
        this.cboEmpresa.Focus();
        return false;
      }
      if (this.txtId.Text.Trim().Equals(""))
      {
        ModGeneralFunctions.MessageOk("¡Primero debe guardar la Configuración!");
        this.Button_Save.Focus();
        return false;
      }
      if (!this.txtValor.Text.Trim().Equals(""))
        return true;
      ModGeneralFunctions.MessageOk("¡Ingrese un Valor!");
      this.txtValor.Focus();
      return false;
    }

    private void ubicarRegistro(string _ItemToUbicate)
    {
      int num = checked (this.dgrvData.Rows.Count - 1);
      int index = 0;
      while (index <= num)
      {
        if (Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateIndexGet(this.dgrvData.DataSource, new object[1]
        {
          (object) index
        }, (string[]) null), (System.Type) null, "Id", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null)).Equals(_ItemToUbicate))
        {
          this.dgrvData.CurrentCell = this.dgrvData[1, index];
          break;
        }
        checked { ++index; }
      }
    }

    private void SelectITem()
    {
      try
      {
        ModGeneralVar.g_Str_RecordID = Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateIndexGet(this.dgrvData.DataSource, new object[1]
        {
          (object) this.dgrvData.CurrentRow.Index
        }, (string[]) null), (System.Type) null, "ContactId", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
        ModGeneralVar.g_Str_RecordDes = Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateIndexGet(this.dgrvData.DataSource, new object[1]
        {
          (object) this.dgrvData.CurrentRow.Index
        }, (string[]) null), (System.Type) null, "ContactName", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
        ModGeneralVar.g_Str_RecordValue = Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateIndexGet(this.dgrvData.DataSource, new object[1]
        {
          (object) this.dgrvData.CurrentRow.Index
        }, (string[]) null), (System.Type) null, "ClientId", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
    }
  }
}
