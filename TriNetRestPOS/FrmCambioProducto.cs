// Decompiled with JetBrains decompiler
// Type: TriNetRestPOS.FrmCambioProducto
// Assembly: TriNetRestPOS, Version=5.2.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 43377352-E952-4AC1-9BA6-CCBE4AE5F575
// Assembly location: C:\log\TriNetRestPOS.exe

using APP_Utilities;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using TR1_BusinessEntity;
using TR1_BusinessLogic;

namespace TriNetRestPOS
{
  [DesignerGenerated]
  public class FrmCambioProducto : Form
  {
    private IContainer components;
    public string _NameForm;
    private BL_TR1_CAMBIO_PRODUCTO o_BL_CAMBIOPRODUCTO;
    private List<BE_TR1_CAMBIO_PRODUCTO> o_BEC_CAMBIOPRODUCTO;
    private BE_TR1_CAMBIO_PRODUCTO o_BE_TR1_CAMBIOPRODUCTO;
    private string str_Result;
    public string str_Areaable;
    public string str_NameTable;
    public short int_SizeId;
    public bool _OnlySearch;
    private string Res_Code;
    private string Res_Description;
    private string Res_DescriptionS;
    private string Res_Active;
    private string Res_Observation;
    private string Res_MsgSave;
    private Control _control;

    public FrmCambioProducto()
    {
      this.Load += new EventHandler(this.FrmAreas_Load);
      this.Activated += new EventHandler(this.FrmAreas_Activated);
      this.KeyDown += new KeyEventHandler(this.FrmArea_KeyDown);
      this._NameForm = "";
      this.str_Result = StructApp.RESULT_OK;
      this._OnlySearch = false;
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
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (FrmCambioProducto));
      this.TabControl_Data = new TabControlEx();
      this.TabPage_Listado = new TabPage();
      this.Panel_ButtonsActions = new Panel();
      this.Button_KBoardCriterio = new Button();
      this.Button_GoOut = new Button();
      this.Button_Ready = new Button();
      this.Label_Description = new Label();
      this.Panel_ButtonsTools = new Panel();
      this.Button_First = new Button();
      this.Button_Back = new Button();
      this.Button_Delete = new Button();
      this.Button_Forward = new Button();
      this.Button_Last = new Button();
      this.Button_New = new Button();
      this.TextBox_Criterio = new TextBox();
      this.dgrvData = new DataGridView();
      this.TabPage_Detail = new TabPage();
      this.txt_Cantidad = new NumericTextBox.NumericTextBox();
      this.TextBox_CompanyId = new TextBox();
      this.TextBox_CompanyDes = new TextBox();
      this.Button_Company_Search = new Button();
      this.Label_Company = new Label();
      this.Label2 = new Label();
      this.TextBox_ProductIdDestino = new TextBox();
      this.Button_Product_Search_Destino = new Button();
      this.Label1 = new Label();
      this.TextBox_ProductDesDestino = new TextBox();
      this.TextBox_ProductIdOrigen = new TextBox();
      this.Button_Product_Search = new Button();
      this.Label_Product = new Label();
      this.TextBox_ProductDesOrigen = new TextBox();
      this.Label_Id = new Label();
      this.TextBox_Id = new TextBox();
      this.Button_CloseTab = new Button();
      this.Button_Save = new Button();
      this.ToolStripStatusLabel_OperationText = new ToolStripStatusLabel();
      this.ToolStripStatusLabel_RecordsNumber = new ToolStripStatusLabel();
      this.ToolStripStatusLabel_RecordsText = new ToolStripStatusLabel();
      this.StatusStrip_Properties = new StatusStrip();
      this.ToolStripStatusLabel_Operation = new ToolStripStatusLabel();
      this.Tssl_Record = new ToolStripStatusLabel();
      ((Control) this.TabControl_Data).SuspendLayout();
      this.TabPage_Listado.SuspendLayout();
      this.Panel_ButtonsActions.SuspendLayout();
      this.Panel_ButtonsTools.SuspendLayout();
      ((ISupportInitialize) this.dgrvData).BeginInit();
      this.TabPage_Detail.SuspendLayout();
      this.StatusStrip_Properties.SuspendLayout();
      this.SuspendLayout();
      ((Control) this.TabControl_Data).Controls.Add((Control) this.TabPage_Listado);
      ((Control) this.TabControl_Data).Controls.Add((Control) this.TabPage_Detail);
      ((Control) this.TabControl_Data).Font = new Font("Trebuchet MS", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      ((Control) this.TabControl_Data).Location = new Point(2, 3);
      ((Control) this.TabControl_Data).Name = "TabControl_Data";
      ((TabControl) this.TabControl_Data).SelectedIndex = 0;
      ((Control) this.TabControl_Data).Size = new Size(522, 515);
      ((Control) this.TabControl_Data).TabIndex = 1;
      this.TabPage_Listado.Controls.Add((Control) this.Panel_ButtonsActions);
      this.TabPage_Listado.Controls.Add((Control) this.Label_Description);
      this.TabPage_Listado.Controls.Add((Control) this.Panel_ButtonsTools);
      this.TabPage_Listado.Controls.Add((Control) this.TextBox_Criterio);
      this.TabPage_Listado.Controls.Add((Control) this.dgrvData);
      this.TabPage_Listado.Font = new Font("Verdana", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.TabPage_Listado.Location = new Point(4, 29);
      this.TabPage_Listado.Name = "TabPage_Listado";
      this.TabPage_Listado.Padding = new Padding(3);
      this.TabPage_Listado.Size = new Size(514, 482);
      this.TabPage_Listado.TabIndex = 0;
      this.TabPage_Listado.Text = "Listado";
      this.TabPage_Listado.UseVisualStyleBackColor = true;
      this.Panel_ButtonsActions.Controls.Add((Control) this.Button_KBoardCriterio);
      this.Panel_ButtonsActions.Controls.Add((Control) this.Button_GoOut);
      this.Panel_ButtonsActions.Controls.Add((Control) this.Button_Ready);
      this.Panel_ButtonsActions.Location = new Point(262, -1);
      this.Panel_ButtonsActions.Name = "Panel_ButtonsActions";
      this.Panel_ButtonsActions.Size = new Size(251, 65);
      this.Panel_ButtonsActions.TabIndex = 2;
      this.Button_KBoardCriterio.Font = new Font("Trebuchet MS", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Button_KBoardCriterio.ForeColor = Color.MediumBlue;
      this.Button_KBoardCriterio.Image = (Image) componentResourceManager.GetObject("Button_KBoardCriterio.Image");
      this.Button_KBoardCriterio.Location = new Point(1, 4);
      this.Button_KBoardCriterio.Name = "Button_KBoardCriterio";
      this.Button_KBoardCriterio.Size = new Size(83, 60);
      this.Button_KBoardCriterio.TabIndex = 1;
      this.Button_KBoardCriterio.Text = "&Teclado";
      this.Button_KBoardCriterio.TextImageRelation = TextImageRelation.TextAboveImage;
      this.Button_KBoardCriterio.UseVisualStyleBackColor = true;
      this.Button_GoOut.Font = new Font("Trebuchet MS", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Button_GoOut.ForeColor = Color.MediumBlue;
      this.Button_GoOut.Image = (Image) TriNetRestPOS.My.Resources.Resources.i_Close;
      this.Button_GoOut.Location = new Point(166, 4);
      this.Button_GoOut.Name = "Button_GoOut";
      this.Button_GoOut.Size = new Size(83, 60);
      this.Button_GoOut.TabIndex = 161;
      this.Button_GoOut.Text = "&Salir";
      this.Button_GoOut.TextImageRelation = TextImageRelation.TextAboveImage;
      this.Button_GoOut.UseVisualStyleBackColor = true;
      this.Button_Ready.Font = new Font("Trebuchet MS", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Button_Ready.ForeColor = Color.MediumBlue;
      this.Button_Ready.Image = (Image) TriNetRestPOS.My.Resources.Resources.i_Ready;
      this.Button_Ready.Location = new Point(83, 4);
      this.Button_Ready.Name = "Button_Ready";
      this.Button_Ready.Size = new Size(83, 60);
      this.Button_Ready.TabIndex = 3;
      this.Button_Ready.Text = "&Listo";
      this.Button_Ready.TextImageRelation = TextImageRelation.TextAboveImage;
      this.Button_Ready.UseVisualStyleBackColor = true;
      this.Button_Ready.Visible = false;
      this.Label_Description.AutoSize = true;
      this.Label_Description.Font = new Font("Trebuchet MS", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Label_Description.ForeColor = Color.MediumBlue;
      this.Label_Description.Location = new Point(0, 12);
      this.Label_Description.Name = "Label_Description";
      this.Label_Description.Size = new Size(96, 20);
      this.Label_Description.TabIndex = 147;
      this.Label_Description.Text = "Descripción:";
      this.Panel_ButtonsTools.Controls.Add((Control) this.Button_First);
      this.Panel_ButtonsTools.Controls.Add((Control) this.Button_Back);
      this.Panel_ButtonsTools.Controls.Add((Control) this.Button_Delete);
      this.Panel_ButtonsTools.Controls.Add((Control) this.Button_Forward);
      this.Panel_ButtonsTools.Controls.Add((Control) this.Button_Last);
      this.Panel_ButtonsTools.Controls.Add((Control) this.Button_New);
      this.Panel_ButtonsTools.Location = new Point(428, 61);
      this.Panel_ButtonsTools.Name = "Panel_ButtonsTools";
      this.Panel_ButtonsTools.Size = new Size(87, 419);
      this.Panel_ButtonsTools.TabIndex = 146;
      this.Button_First.Font = new Font("Verdana", 18f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Button_First.Image = (Image) TriNetRestPOS.My.Resources.Resources.Fast_back;
      this.Button_First.Location = new Point(1, 179);
      this.Button_First.Name = "Button_First";
      this.Button_First.RightToLeft = RightToLeft.Yes;
      this.Button_First.Size = new Size(83, 60);
      this.Button_First.TabIndex = 32;
      this.Button_First.UseVisualStyleBackColor = true;
      this.Button_Back.Font = new Font("Verdana", 18f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Button_Back.Image = (Image) TriNetRestPOS.My.Resources.Resources.go_back;
      this.Button_Back.Location = new Point(1, 239);
      this.Button_Back.Name = "Button_Back";
      this.Button_Back.RightToLeft = RightToLeft.Yes;
      this.Button_Back.Size = new Size(83, 60);
      this.Button_Back.TabIndex = 33;
      this.Button_Back.UseVisualStyleBackColor = true;
      this.Button_Delete.Font = new Font("Trebuchet MS", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Button_Delete.ForeColor = Color.MediumBlue;
      this.Button_Delete.Image = (Image) TriNetRestPOS.My.Resources.Resources.Eliminar;
      this.Button_Delete.Location = new Point(1, 61);
      this.Button_Delete.Name = "Button_Delete";
      this.Button_Delete.RightToLeft = RightToLeft.Yes;
      this.Button_Delete.Size = new Size(83, 60);
      this.Button_Delete.TabIndex = 148;
      this.Button_Delete.Text = "&Eliminar";
      this.Button_Delete.TextImageRelation = TextImageRelation.TextAboveImage;
      this.Button_Delete.UseVisualStyleBackColor = true;
      this.Button_Forward.Font = new Font("Verdana", 18f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Button_Forward.Image = (Image) TriNetRestPOS.My.Resources.Resources.go_forward;
      this.Button_Forward.Location = new Point(1, 299);
      this.Button_Forward.Name = "Button_Forward";
      this.Button_Forward.RightToLeft = RightToLeft.Yes;
      this.Button_Forward.Size = new Size(83, 60);
      this.Button_Forward.TabIndex = 34;
      this.Button_Forward.UseVisualStyleBackColor = true;
      this.Button_Last.Font = new Font("Verdana", 18f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Button_Last.Image = (Image) TriNetRestPOS.My.Resources.Resources.fast_forward;
      this.Button_Last.Location = new Point(1, 359);
      this.Button_Last.Name = "Button_Last";
      this.Button_Last.RightToLeft = RightToLeft.Yes;
      this.Button_Last.Size = new Size(83, 60);
      this.Button_Last.TabIndex = 35;
      this.Button_Last.UseVisualStyleBackColor = true;
      this.Button_New.Font = new Font("Trebuchet MS", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Button_New.ForeColor = Color.MediumBlue;
      this.Button_New.Image = (Image) TriNetRestPOS.My.Resources.Resources.i_News;
      this.Button_New.ImageAlign = ContentAlignment.BottomCenter;
      this.Button_New.Location = new Point(1, 2);
      this.Button_New.Name = "Button_New";
      this.Button_New.Size = new Size(83, 60);
      this.Button_New.TabIndex = 146;
      this.Button_New.Text = "&Nuevo";
      this.Button_New.TextImageRelation = TextImageRelation.TextAboveImage;
      this.Button_New.UseVisualStyleBackColor = true;
      this.TextBox_Criterio.Location = new Point(2, 39);
      this.TextBox_Criterio.MaxLength = 50;
      this.TextBox_Criterio.Name = "TextBox_Criterio";
      this.TextBox_Criterio.Size = new Size((int) byte.MaxValue, 23);
      this.TextBox_Criterio.TabIndex = 0;
      this.dgrvData.BorderStyle = BorderStyle.Fixed3D;
      this.dgrvData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dgrvData.Location = new Point(1, 65);
      this.dgrvData.MultiSelect = false;
      this.dgrvData.Name = "dgrvData";
      this.dgrvData.ScrollBars = ScrollBars.None;
      this.dgrvData.Size = new Size(427, 416);
      this.dgrvData.TabIndex = 1;
      this.TabPage_Detail.Controls.Add((Control) this.txt_Cantidad);
      this.TabPage_Detail.Controls.Add((Control) this.TextBox_CompanyId);
      this.TabPage_Detail.Controls.Add((Control) this.TextBox_CompanyDes);
      this.TabPage_Detail.Controls.Add((Control) this.Button_Company_Search);
      this.TabPage_Detail.Controls.Add((Control) this.Label_Company);
      this.TabPage_Detail.Controls.Add((Control) this.Label2);
      this.TabPage_Detail.Controls.Add((Control) this.TextBox_ProductIdDestino);
      this.TabPage_Detail.Controls.Add((Control) this.Button_Product_Search_Destino);
      this.TabPage_Detail.Controls.Add((Control) this.Label1);
      this.TabPage_Detail.Controls.Add((Control) this.TextBox_ProductDesDestino);
      this.TabPage_Detail.Controls.Add((Control) this.TextBox_ProductIdOrigen);
      this.TabPage_Detail.Controls.Add((Control) this.Button_Product_Search);
      this.TabPage_Detail.Controls.Add((Control) this.Label_Product);
      this.TabPage_Detail.Controls.Add((Control) this.TextBox_ProductDesOrigen);
      this.TabPage_Detail.Controls.Add((Control) this.Label_Id);
      this.TabPage_Detail.Controls.Add((Control) this.TextBox_Id);
      this.TabPage_Detail.Controls.Add((Control) this.Button_CloseTab);
      this.TabPage_Detail.Controls.Add((Control) this.Button_Save);
      this.TabPage_Detail.Location = new Point(4, 29);
      this.TabPage_Detail.Name = "TabPage_Detail";
      this.TabPage_Detail.Padding = new Padding(3);
      this.TabPage_Detail.Size = new Size(514, 482);
      this.TabPage_Detail.TabIndex = 1;
      this.TabPage_Detail.Text = "Mantenimiento";
      this.TabPage_Detail.UseVisualStyleBackColor = true;
      this.txt_Cantidad.set_AllowSpace(false);
      ((Control) this.txt_Cantidad).Font = new Font("Arial", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      ((Control) this.txt_Cantidad).Location = new Point(105, 231);
      ((Control) this.txt_Cantidad).Name = "txt_Cantidad";
      ((Control) this.txt_Cantidad).Size = new Size(130, 25);
      ((Control) this.txt_Cantidad).TabIndex = 487;
      ((TextBox) this.txt_Cantidad).TextAlign = HorizontalAlignment.Right;
      this.TextBox_CompanyId.BackColor = Color.WhiteSmoke;
      this.TextBox_CompanyId.Enabled = false;
      this.TextBox_CompanyId.Font = new Font("Trebuchet MS", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.TextBox_CompanyId.ForeColor = Color.Black;
      this.TextBox_CompanyId.Location = new Point(321, 9);
      this.TextBox_CompanyId.Name = "TextBox_CompanyId";
      this.TextBox_CompanyId.ReadOnly = true;
      this.TextBox_CompanyId.Size = new Size(22, 25);
      this.TextBox_CompanyId.TabIndex = 486;
      this.TextBox_CompanyId.Visible = false;
      this.TextBox_CompanyDes.BackColor = Color.WhiteSmoke;
      this.TextBox_CompanyDes.Font = new Font("Trebuchet MS", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.TextBox_CompanyDes.Location = new Point(26, 300);
      this.TextBox_CompanyDes.Multiline = true;
      this.TextBox_CompanyDes.Name = "TextBox_CompanyDes";
      this.TextBox_CompanyDes.ReadOnly = true;
      this.TextBox_CompanyDes.Size = new Size(360, 46);
      this.TextBox_CompanyDes.TabIndex = 485;
      this.Button_Company_Search.Image = (Image) TriNetRestPOS.My.Resources.Resources.Buscar_Small;
      this.Button_Company_Search.Location = new Point(396, 300);
      this.Button_Company_Search.Name = "Button_Company_Search";
      this.Button_Company_Search.Size = new Size(59, 46);
      this.Button_Company_Search.TabIndex = 483;
      this.Button_Company_Search.UseVisualStyleBackColor = true;
      this.Label_Company.AutoSize = true;
      this.Label_Company.Font = new Font("Trebuchet MS", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Label_Company.ForeColor = Color.MediumBlue;
      this.Label_Company.Location = new Point(25, 275);
      this.Label_Company.Name = "Label_Company";
      this.Label_Company.Size = new Size(65, 20);
      this.Label_Company.TabIndex = 484;
      this.Label_Company.Text = "Cliente:";
      this.Label2.AutoSize = true;
      this.Label2.Font = new Font("Trebuchet MS", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Label2.ForeColor = Color.MediumBlue;
      this.Label2.Location = new Point(22, 232);
      this.Label2.Name = "Label2";
      this.Label2.Size = new Size(77, 20);
      this.Label2.TabIndex = 282;
      this.Label2.Text = "Cantidad:";
      this.TextBox_ProductIdDestino.BackColor = Color.WhiteSmoke;
      this.TextBox_ProductIdDestino.Enabled = false;
      this.TextBox_ProductIdDestino.Font = new Font("Trebuchet MS", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.TextBox_ProductIdDestino.ForeColor = Color.Black;
      this.TextBox_ProductIdDestino.Location = new Point(293, 9);
      this.TextBox_ProductIdDestino.Name = "TextBox_ProductIdDestino";
      this.TextBox_ProductIdDestino.ReadOnly = true;
      this.TextBox_ProductIdDestino.Size = new Size(22, 25);
      this.TextBox_ProductIdDestino.TabIndex = 281;
      this.TextBox_ProductIdDestino.Visible = false;
      this.Button_Product_Search_Destino.Font = new Font("Trebuchet MS", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Button_Product_Search_Destino.Image = (Image) TriNetRestPOS.My.Resources.Resources.Buscar_Small;
      this.Button_Product_Search_Destino.Location = new Point(396, 163);
      this.Button_Product_Search_Destino.Name = "Button_Product_Search_Destino";
      this.Button_Product_Search_Destino.Size = new Size(60, 46);
      this.Button_Product_Search_Destino.TabIndex = 279;
      this.Button_Product_Search_Destino.UseVisualStyleBackColor = true;
      this.Label1.AutoSize = true;
      this.Label1.Font = new Font("Trebuchet MS", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Label1.ForeColor = Color.MediumBlue;
      this.Label1.Location = new Point(23, 140);
      this.Label1.Name = "Label1";
      this.Label1.Size = new Size(124, 20);
      this.Label1.TabIndex = 280;
      this.Label1.Text = "Producto Salida:";
      this.TextBox_ProductDesDestino.Font = new Font("Trebuchet MS", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.TextBox_ProductDesDestino.Location = new Point(27, 163);
      this.TextBox_ProductDesDestino.MaxLength = 50;
      this.TextBox_ProductDesDestino.Multiline = true;
      this.TextBox_ProductDesDestino.Name = "TextBox_ProductDesDestino";
      this.TextBox_ProductDesDestino.ReadOnly = true;
      this.TextBox_ProductDesDestino.Size = new Size(360, 46);
      this.TextBox_ProductDesDestino.TabIndex = 278;
      this.TextBox_ProductIdOrigen.BackColor = Color.WhiteSmoke;
      this.TextBox_ProductIdOrigen.Enabled = false;
      this.TextBox_ProductIdOrigen.Font = new Font("Trebuchet MS", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.TextBox_ProductIdOrigen.ForeColor = Color.Black;
      this.TextBox_ProductIdOrigen.Location = new Point(265, 9);
      this.TextBox_ProductIdOrigen.Name = "TextBox_ProductIdOrigen";
      this.TextBox_ProductIdOrigen.ReadOnly = true;
      this.TextBox_ProductIdOrigen.Size = new Size(22, 25);
      this.TextBox_ProductIdOrigen.TabIndex = 277;
      this.TextBox_ProductIdOrigen.Visible = false;
      this.Button_Product_Search.Font = new Font("Trebuchet MS", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Button_Product_Search.Image = (Image) TriNetRestPOS.My.Resources.Resources.Buscar_Small;
      this.Button_Product_Search.Location = new Point(395, 73);
      this.Button_Product_Search.Name = "Button_Product_Search";
      this.Button_Product_Search.Size = new Size(60, 46);
      this.Button_Product_Search.TabIndex = 275;
      this.Button_Product_Search.UseVisualStyleBackColor = true;
      this.Label_Product.AutoSize = true;
      this.Label_Product.Font = new Font("Trebuchet MS", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Label_Product.ForeColor = Color.MediumBlue;
      this.Label_Product.Location = new Point(22, 50);
      this.Label_Product.Name = "Label_Product";
      this.Label_Product.Size = new Size(133, 20);
      this.Label_Product.TabIndex = 276;
      this.Label_Product.Text = "Producto Ingreso:";
      this.TextBox_ProductDesOrigen.Font = new Font("Trebuchet MS", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.TextBox_ProductDesOrigen.Location = new Point(26, 73);
      this.TextBox_ProductDesOrigen.MaxLength = 50;
      this.TextBox_ProductDesOrigen.Multiline = true;
      this.TextBox_ProductDesOrigen.Name = "TextBox_ProductDesOrigen";
      this.TextBox_ProductDesOrigen.ReadOnly = true;
      this.TextBox_ProductDesOrigen.Size = new Size(360, 46);
      this.TextBox_ProductDesOrigen.TabIndex = 1;
      this.Label_Id.AutoSize = true;
      this.Label_Id.Font = new Font("Trebuchet MS", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Label_Id.ForeColor = Color.MediumBlue;
      this.Label_Id.Location = new Point(23, 12);
      this.Label_Id.Name = "Label_Id";
      this.Label_Id.Size = new Size(61, 20);
      this.Label_Id.TabIndex = 149;
      this.Label_Id.Text = "Código:";
      this.TextBox_Id.BackColor = Color.FromArgb((int) byte.MaxValue, 240, 144);
      this.TextBox_Id.Font = new Font("Trebuchet MS", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.TextBox_Id.Location = new Point(99, 9);
      this.TextBox_Id.Name = "TextBox_Id";
      this.TextBox_Id.ReadOnly = true;
      this.TextBox_Id.Size = new Size(150, 25);
      this.TextBox_Id.TabIndex = 148;
      this.Button_CloseTab.Font = new Font("Trebuchet MS", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Button_CloseTab.ForeColor = Color.MediumBlue;
      this.Button_CloseTab.Image = (Image) TriNetRestPOS.My.Resources.Resources.i_Close;
      this.Button_CloseTab.Location = new Point(372, 420);
      this.Button_CloseTab.Name = "Button_CloseTab";
      this.Button_CloseTab.Size = new Size(100, 60);
      this.Button_CloseTab.TabIndex = 159;
      this.Button_CloseTab.Text = "&Atrás";
      this.Button_CloseTab.TextImageRelation = TextImageRelation.TextAboveImage;
      this.Button_CloseTab.UseVisualStyleBackColor = true;
      this.Button_Save.Font = new Font("Trebuchet MS", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Button_Save.ForeColor = Color.MediumBlue;
      this.Button_Save.Image = (Image) TriNetRestPOS.My.Resources.Resources.i_Ready;
      this.Button_Save.Location = new Point(245, 420);
      this.Button_Save.Name = "Button_Save";
      this.Button_Save.Size = new Size(121, 60);
      this.Button_Save.TabIndex = 10;
      this.Button_Save.Text = "&Grabar";
      this.Button_Save.TextImageRelation = TextImageRelation.TextAboveImage;
      this.Button_Save.UseVisualStyleBackColor = true;
      this.ToolStripStatusLabel_OperationText.BackColor = Color.Transparent;
      this.ToolStripStatusLabel_OperationText.ForeColor = Color.MediumBlue;
      this.ToolStripStatusLabel_OperationText.Name = "ToolStripStatusLabel_OperationText";
      this.ToolStripStatusLabel_OperationText.Size = new Size(61, 20);
      this.ToolStripStatusLabel_OperationText.Text = "Listado";
      this.ToolStripStatusLabel_RecordsNumber.Alignment = ToolStripItemAlignment.Right;
      this.ToolStripStatusLabel_RecordsNumber.AutoSize = false;
      this.ToolStripStatusLabel_RecordsNumber.BackColor = Color.Transparent;
      this.ToolStripStatusLabel_RecordsNumber.Font = new Font("Verdana", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.ToolStripStatusLabel_RecordsNumber.ForeColor = SystemColors.ControlText;
      this.ToolStripStatusLabel_RecordsNumber.Name = "ToolStripStatusLabel_RecordsNumber";
      this.ToolStripStatusLabel_RecordsNumber.Size = new Size(50, 20);
      this.ToolStripStatusLabel_RecordsNumber.Text = "1234";
      this.ToolStripStatusLabel_RecordsNumber.TextAlign = ContentAlignment.MiddleRight;
      this.ToolStripStatusLabel_RecordsText.Alignment = ToolStripItemAlignment.Right;
      this.ToolStripStatusLabel_RecordsText.AutoSize = false;
      this.ToolStripStatusLabel_RecordsText.BackColor = Color.Transparent;
      this.ToolStripStatusLabel_RecordsText.Font = new Font("Verdana", 9f, FontStyle.Bold);
      this.ToolStripStatusLabel_RecordsText.ForeColor = Color.MediumBlue;
      this.ToolStripStatusLabel_RecordsText.Name = "ToolStripStatusLabel_RecordsText";
      this.ToolStripStatusLabel_RecordsText.Size = new Size(150, 20);
      this.ToolStripStatusLabel_RecordsText.Text = "Número de Registros:";
      this.ToolStripStatusLabel_RecordsText.TextAlign = ContentAlignment.MiddleLeft;
      this.StatusStrip_Properties.BackColor = Color.Transparent;
      this.StatusStrip_Properties.Font = new Font("Trebuchet MS", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.StatusStrip_Properties.Items.AddRange(new ToolStripItem[2]
      {
        (ToolStripItem) this.ToolStripStatusLabel_Operation,
        (ToolStripItem) this.Tssl_Record
      });
      this.StatusStrip_Properties.Location = new Point(0, 517);
      this.StatusStrip_Properties.Name = "StatusStrip_Properties";
      this.StatusStrip_Properties.Size = new Size(524, 25);
      this.StatusStrip_Properties.TabIndex = 2;
      this.StatusStrip_Properties.Text = "StatusStrip1";
      this.ToolStripStatusLabel_Operation.Font = new Font("Trebuchet MS", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.ToolStripStatusLabel_Operation.ForeColor = Color.MediumBlue;
      this.ToolStripStatusLabel_Operation.Name = "ToolStripStatusLabel_Operation";
      this.ToolStripStatusLabel_Operation.Size = new Size(27, 20);
      this.ToolStripStatusLabel_Operation.Text = "...";
      this.Tssl_Record.Font = new Font("Trebuchet MS", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Tssl_Record.ForeColor = Color.MediumBlue;
      this.Tssl_Record.Name = "Tssl_Record";
      this.Tssl_Record.Size = new Size(482, 20);
      this.Tssl_Record.Spring = true;
      this.Tssl_Record.TextAlign = ContentAlignment.MiddleRight;
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.BackColor = Color.White;
      this.ClientSize = new Size(524, 542);
      this.ControlBox = false;
      this.Controls.Add((Control) this.StatusStrip_Properties);
      this.Controls.Add((Control) this.TabControl_Data);
      this.FormBorderStyle = FormBorderStyle.FixedDialog;
      this.KeyPreview = true;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = nameof (FrmCambioProducto);
      this.ShowIcon = false;
      this.ShowInTaskbar = false;
      this.StartPosition = FormStartPosition.CenterScreen;
      this.Text = "Cambio de Producto";
      ((Control) this.TabControl_Data).ResumeLayout(false);
      this.TabPage_Listado.ResumeLayout(false);
      this.TabPage_Listado.PerformLayout();
      this.Panel_ButtonsActions.ResumeLayout(false);
      this.Panel_ButtonsTools.ResumeLayout(false);
      ((ISupportInitialize) this.dgrvData).EndInit();
      this.TabPage_Detail.ResumeLayout(false);
      this.TabPage_Detail.PerformLayout();
      this.StatusStrip_Properties.ResumeLayout(false);
      this.StatusStrip_Properties.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();
    }

    internal virtual TabControlEx TabControl_Data { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual TabPage TabPage_Listado { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual TabPage TabPage_Detail { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

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

    internal virtual TextBox TextBox_Criterio
    {
      get
      {
        return this._TextBox_Criterio;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.TextBox_Criterio_TextChanged);
        KeyPressEventHandler pressEventHandler = new KeyPressEventHandler(this.TextBox_Criterio_KeyPress);
        TextBox textBoxCriterio1 = this._TextBox_Criterio;
        if (textBoxCriterio1 != null)
        {
          textBoxCriterio1.TextChanged -= eventHandler;
          textBoxCriterio1.KeyPress -= pressEventHandler;
        }
        this._TextBox_Criterio = value;
        TextBox textBoxCriterio2 = this._TextBox_Criterio;
        if (textBoxCriterio2 == null)
          return;
        textBoxCriterio2.TextChanged += eventHandler;
        textBoxCriterio2.KeyPress += pressEventHandler;
      }
    }

    internal virtual Panel Panel_ButtonsTools { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

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

    internal virtual Label Label_Description { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

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

    internal virtual Label Label_Id { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual TextBox TextBox_Id { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual TextBox TextBox_ProductDesOrigen
    {
      get
      {
        return this._TextBox_ProductDesOrigen;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        KeyPressEventHandler pressEventHandler = new KeyPressEventHandler(this.Control_KeyPress);
        TextBox productDesOrigen1 = this._TextBox_ProductDesOrigen;
        if (productDesOrigen1 != null)
          productDesOrigen1.KeyPress -= pressEventHandler;
        this._TextBox_ProductDesOrigen = value;
        TextBox productDesOrigen2 = this._TextBox_ProductDesOrigen;
        if (productDesOrigen2 == null)
          return;
        productDesOrigen2.KeyPress += pressEventHandler;
      }
    }

    internal virtual ToolStripStatusLabel ToolStripStatusLabel_OperationText { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual ToolStripStatusLabel ToolStripStatusLabel_RecordsNumber { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual ToolStripStatusLabel ToolStripStatusLabel_RecordsText { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

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

    internal virtual Button Button_Ready
    {
      get
      {
        return this._Button_Ready;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Button_Ready_Click);
        Button buttonReady1 = this._Button_Ready;
        if (buttonReady1 != null)
          buttonReady1.Click -= eventHandler;
        this._Button_Ready = value;
        Button buttonReady2 = this._Button_Ready;
        if (buttonReady2 == null)
          return;
        buttonReady2.Click += eventHandler;
      }
    }

    internal virtual Panel Panel_ButtonsActions { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual StatusStrip StatusStrip_Properties { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual ToolStripStatusLabel ToolStripStatusLabel_Operation { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual ToolStripStatusLabel Tssl_Record { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Button Button_Product_Search
    {
      get
      {
        return this._Button_Product_Search;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Button_Product_Search_Click);
        Button buttonProductSearch1 = this._Button_Product_Search;
        if (buttonProductSearch1 != null)
          buttonProductSearch1.Click -= eventHandler;
        this._Button_Product_Search = value;
        Button buttonProductSearch2 = this._Button_Product_Search;
        if (buttonProductSearch2 == null)
          return;
        buttonProductSearch2.Click += eventHandler;
      }
    }

    internal virtual Label Label_Product { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual TextBox TextBox_ProductIdOrigen { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual TextBox TextBox_ProductIdDestino { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Button Button_Product_Search_Destino
    {
      get
      {
        return this._Button_Product_Search_Destino;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Button_Product_Search_Destino_Click);
        Button productSearchDestino1 = this._Button_Product_Search_Destino;
        if (productSearchDestino1 != null)
          productSearchDestino1.Click -= eventHandler;
        this._Button_Product_Search_Destino = value;
        Button productSearchDestino2 = this._Button_Product_Search_Destino;
        if (productSearchDestino2 == null)
          return;
        productSearchDestino2.Click += eventHandler;
      }
    }

    internal virtual Label Label1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual TextBox TextBox_ProductDesDestino { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Label Label2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

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

    internal virtual TextBox TextBox_CompanyId { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual NumericTextBox.NumericTextBox txt_Cantidad { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    private void FrmAreas_Load(object sender, EventArgs e)
    {
      this.Button_Ready.Visible = this._OnlySearch;
      this.Resource(ModGeneralFunctions.Get_Language((object) this));
      this.SetUpDataGridView();
      this.o_BL_CAMBIOPRODUCTO = new BL_TR1_CAMBIO_PRODUCTO();
      this.o_BEC_CAMBIOPRODUCTO = new List<BE_TR1_CAMBIO_PRODUCTO>();
      this.LoadData();
      this.TextBox_Criterio.Focus();
    }

    private void Information_Quantity_Of_Records()
    {
      if (!this.DataGRV_Validated())
        this.Tssl_Record.Text = "Actual: 0  /  Total de Registros: " + Conversions.ToString(this.dgrvData.RowCount);
      else
        this.Tssl_Record.Text = "Actual: " + Conversions.ToString(checked (this.dgrvData.CurrentRow.Index + 1)) + " /  Total de Registros: " + Conversions.ToString(this.dgrvData.RowCount);
    }

    public bool DataGRV_Validated()
    {
      return this.dgrvData.Rows.Count > 0;
    }

    private void Resource(ResourceManager Rm)
    {
      this.Text = Rm.GetString("Res_ListMaintenance") + Strings.Mid(this.Name, 4, checked (Strings.Len(this.Name) - 3));
      this.TabPage_Listado.Text = Rm.GetString("Res_List");
      this.TabPage_Detail.Text = Rm.GetString("Res_Maintenance");
      this.Label_Description.Text = Rm.GetString("Res_Description") + ":";
      this.Button_Ready.Text = Rm.GetString("Res_Ready");
      this.Button_GoOut.Text = Rm.GetString("Res_Exit");
      this.Button_New.Text = Rm.GetString("Res_New");
      this.Button_Delete.Text = Rm.GetString("Res_Delete");
      this.Res_Code = Rm.GetString("Res_Code");
      this.Label_Id.Text = this.Res_Code + " :";
      this.Res_Description = Rm.GetString("Res_Description");
      this.Res_DescriptionS = Rm.GetString("Res_DescriptionS");
      this.Res_Observation = Rm.GetString("Res_Observation");
      this.Res_Active = Rm.GetString("Res_Active");
      this.Button_Save.Text = Rm.GetString("Res_Save");
      this.Button_CloseTab.Text = Rm.GetString("Res_Back");
      this.Res_MsgSave = Rm.GetString("Res_MsgSave");
      ModGeneralVar.g_Res_Description = Rm.GetString("Res_InputDescription");
      this.Button_KBoardCriterio.Text = Rm.GetString("Res_Keyboard");
    }

    private void LoadData()
    {
      this.dgrvData.DataSource = (object) null;
      this.dgrvData.DataSource = (object) this.o_BL_CAMBIOPRODUCTO.Lista(ModGeneralVar.g_BE_TR1_VARIABLES_B.get_EstabliId(), this.TextBox_Criterio.Text);
      this.Information_Quantity_Of_Records();
      this.FirstTab((short) 0, "Listado de Cambió Producto");
    }

    private void SetUpDataGridView()
    {
      ModGeneralFunctions.SetUpDataGridViewBasic(this.dgrvData);
      this.dgrvData.Columns.Add("CambioId", "CambioId");
      ModGeneralFunctions.SetUp_TextBoxColumn((DataGridViewTextBoxColumn) this.dgrvData.Columns[0], "CambioId", (short) 10, "", false, DataGridViewContentAlignment.MiddleLeft, true);
      this.dgrvData.Columns.Add("ClientDes", "Cliente");
      ModGeneralFunctions.SetUp_TextBoxColumn((DataGridViewTextBoxColumn) this.dgrvData.Columns[1], "ClientDes", (short) 200, "", true, DataGridViewContentAlignment.MiddleLeft, true);
      this.dgrvData.Columns.Add("FechaReg", "Fecha");
      ModGeneralFunctions.SetUp_TextBoxColumn((DataGridViewTextBoxColumn) this.dgrvData.Columns[2], "FechaReg", (short) 100, "", true, DataGridViewContentAlignment.MiddleLeft, true);
      this.dgrvData.Columns.Add("EstadoDes", "Estado");
      ModGeneralFunctions.SetUp_TextBoxColumn((DataGridViewTextBoxColumn) this.dgrvData.Columns[3], "EstadoDes", (short) 100, "", true, DataGridViewContentAlignment.MiddleLeft, true);
    }

    private void Button_First_Click(object sender, EventArgs e)
    {
      if (this.dgrvData.Rows.Count <= 0)
        return;
      this.dgrvData.CurrentCell = this.dgrvData[1, 0];
      this.SelectITem();
      this.Information_Quantity_Of_Records();
    }

    private void SelectITem()
    {
      try
      {
        ModGeneralVar.g_Str_RecordID = Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateIndexGet(this.dgrvData.DataSource, new object[1]
        {
          (object) this.dgrvData.CurrentRow.Index
        }, (string[]) null), (System.Type) null, "AreaId", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
        ModGeneralVar.g_Str_RecordDes = Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateIndexGet(this.dgrvData.DataSource, new object[1]
        {
          (object) this.dgrvData.CurrentRow.Index
        }, (string[]) null), (System.Type) null, "AreaDes", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
    }

    private void Button_Back_Click(object sender, EventArgs e)
    {
      if (!ModGeneralFunctions.Order_HeadValidated(this.dgrvData))
        return;
      short num = checked ((short) (this.dgrvData.CurrentRow.Index - 1));
      if (this.dgrvData.Rows.Count > 0 & num > (short) -1)
      {
        this.dgrvData.CurrentCell = this.dgrvData[1, (int) num];
        this.SelectITem();
        this.Information_Quantity_Of_Records();
      }
    }

    private void Button_Forward_Click(object sender, EventArgs e)
    {
      if (!ModGeneralFunctions.Order_HeadValidated(this.dgrvData))
        return;
      short index = checked ((short) this.dgrvData.CurrentRow.Index);
      if (this.dgrvData.Rows.Count > 0 & (int) index < checked (this.dgrvData.Rows.Count - 1))
      {
        this.dgrvData.CurrentCell = this.dgrvData[1, checked ((int) index + 1)];
        this.SelectITem();
        this.Information_Quantity_Of_Records();
      }
    }

    private void Button_Last_Click(object sender, EventArgs e)
    {
      if (this.dgrvData.Rows.Count <= 0)
        return;
      this.dgrvData.CurrentCell = this.dgrvData[1, checked (this.dgrvData.Rows.Count - 1)];
      this.SelectITem();
      this.Information_Quantity_Of_Records();
    }

    private void dgrvData_CellClick(object sender, DataGridViewCellEventArgs e)
    {
      if (!this.DataGV_Validated())
        return;
      this.SelectITem();
    }

    private void Button_New_Click(object sender, EventArgs e)
    {
      this.SetOperation(StructApp.RECORD_CREATE);
      this.FirstTab((short) 1, "Crear Registro");
    }

    private void SetOperation(string _Operation)
    {
      this.ToolStripStatusLabel_OperationText.Text = _Operation;
      if (Operators.CompareString(_Operation, StructApp.RECORD_CREATE, false) == 0)
      {
        this.TextBox_Id.Text = "";
        this.TextBox_ProductDesOrigen.Text = "";
        this.TextBox_ProductIdOrigen.Text = "";
        this.TextBox_ProductDesDestino.Text = "";
        this.TextBox_ProductIdDestino.Text = "";
        ((TextBox) this.txt_Cantidad).Text = "0";
        this.TextBox_CompanyDes.Text = "";
        this.TextBox_CompanyId.Text = "";
        ((TabControl) this.TabControl_Data).SelectedIndex = 1;
        this.Button_Product_Search.Focus();
      }
      else
      {
        if (Operators.CompareString(_Operation, StructApp.RECORD_EDIT, false) == 0 || Operators.CompareString(_Operation, StructApp.RECORD_DELETE, false) != 0)
          return;
        this.TextBox_Id.Text = Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateIndexGet(this.dgrvData.DataSource, new object[1]
        {
          (object) this.dgrvData.CurrentRow.Index
        }, (string[]) null), (System.Type) null, "CambioId", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
        this.MakeOperation(this.ToolStripStatusLabel_OperationText.Text);
      }
    }

    private void MakeOperation(string _Operation)
    {
      try
      {
        BL_TR1_CAMBIO_PRODUCTO tr1CambioProducto1 = new BL_TR1_CAMBIO_PRODUCTO();
        int boxIdPos = ModGeneralVar.g_BE_TR1_BOXES.get_BoxIdPos();
        if (Operators.CompareString(_Operation, StructApp.RECORD_CREATE, false) == 0)
        {
          if (!this.ValidateData() || !ModGeneralFunctions.MessageMakeAction("¿Seguro de Registrar el cambio de producto?", false))
            return;
          string userId = ModGeneralVar.g_BE_USERS.get_UserId();
          if (ModGeneralVar.g_BE_TR1_CFGVARIABLES.get_ShowUserChangePrice() && !ModGeneralFunctions.Validate_Permission(ref userId, true, false, "Autorizar Generación Crédito", false))
          {
            if (ModGeneralVar.g_bol_IsClose)
              return;
            ModGeneralFunctions.MessageOk("¡No Tiene Permiso Válido!");
          }
          else
          {
            BE_TR1_CAMBIO_PRODUCTO tr1CambioProducto2 = new BE_TR1_CAMBIO_PRODUCTO();
            tr1CambioProducto2.set_EstabliId(ModGeneralVar.g_BE_TR1_VARIABLES_B.get_EstabliId());
            tr1CambioProducto2.set_CambioId(0);
            tr1CambioProducto2.set_ProductIdOrigen(this.TextBox_ProductIdOrigen.Text);
            tr1CambioProducto2.set_CantidadOrigen(ModGeneralFunctions.CadenaToDouble(((TextBox) this.txt_Cantidad).Text));
            tr1CambioProducto2.set_ProductIdDestino(this.TextBox_ProductIdDestino.Text);
            tr1CambioProducto2.set_CantidadDestino(ModGeneralFunctions.CadenaToDouble(((TextBox) this.txt_Cantidad).Text));
            tr1CambioProducto2.set_ClientId(this.TextBox_CompanyId.Text);
            tr1CambioProducto2.set_Estado(Conversions.ToString(1));
            tr1CambioProducto2.set_UsuReg(ModGeneralVar.g_BE_USERS.get_UserId());
            tr1CambioProducto2.set_UsuAutoriza(userId);
            this.str_Result = this.o_BL_CAMBIOPRODUCTO.Insertar(tr1CambioProducto2, boxIdPos);
            if (Operators.CompareString(this.str_Result, StructApp.RESULT_OK, false) == 0)
            {
              this.LoadData();
              this.Information_Quantity_Of_Records();
              ModGeneralFunctions.MessageOk("[Registro Creado]");
            }
            else
              ModGeneralFunctions.MessageError_Large(this.str_Result, true);
            this.FirstTab((short) 0, "Listado de Cambio de Producto");
          }
        }
        else if (Operators.CompareString(_Operation, StructApp.RECORD_EDIT, false) != 0)
        {
          if (Operators.CompareString(_Operation, StructApp.RECORD_DELETE, false) == 0)
          {
            if (ModGeneralFunctions.MessageMakeAction("¿Seguro de Anular el cambio de producto?", false))
            {
              string userId = ModGeneralVar.g_BE_USERS.get_UserId();
              if (ModGeneralVar.g_BE_TR1_CFGVARIABLES.get_ShowUserChangePrice() && !ModGeneralFunctions.Validate_Permission(ref userId, true, false, "Autorizar Generación Crédito", false))
              {
                if (ModGeneralVar.g_bol_IsClose)
                  return;
                ModGeneralFunctions.MessageOk("¡No Tiene Permiso Válido!");
              }
              else
              {
                BE_TR1_CAMBIO_PRODUCTO tr1CambioProducto2 = new BE_TR1_CAMBIO_PRODUCTO();
                tr1CambioProducto2.set_EstabliId(ModGeneralVar.g_BE_TR1_VARIABLES_B.get_EstabliId());
                tr1CambioProducto2.set_CambioId(Conversions.ToInteger(this.TextBox_Id.Text));
                tr1CambioProducto2.set_UsuAnula(ModGeneralVar.g_BE_USERS.get_UserId());
                this.str_Result = this.o_BL_CAMBIOPRODUCTO.Anular(tr1CambioProducto2);
                if (Operators.CompareString(this.str_Result, StructApp.RESULT_OK, false) == 0)
                {
                  this.LoadData();
                  ModGeneralFunctions.MessageOk("[Registro Anulado]");
                }
                else
                  ModGeneralFunctions.MessageError_Large(this.str_Result, true);
                this.FirstTab((short) 0, "Listado de Cambio de Producto");
              }
            }
          }
          else if (Operators.CompareString(_Operation, StructApp.RECORD_SEARCH, false) == 0)
          {
            this.LoadData();
            this.FirstTab((short) 0, "Listado de Cambio de Producto");
            this.Information_Quantity_Of_Records();
          }
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ModGeneralFunctions.MessageError(ex.Message, true);
        ProjectData.ClearProjectError();
      }
    }

    private void Button_Update_Click(object sender, EventArgs e)
    {
      if (!this.DataGV_Validated())
        return;
      this.SetOperation(StructApp.RECORD_EDIT);
      this.FirstTab((short) 1, "Editar Registro");
    }

    private void Button_Delete_Click(object sender, EventArgs e)
    {
      if (!this.DataGV_Validated())
        return;
      this.SetOperation(StructApp.RECORD_DELETE);
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
        this.TextBox_Criterio.Focus();
      }
      else
      {
        TabControlEx tabControlData = this.TabControl_Data;
        TabPage tabPageListado = this.TabPage_Listado;
        ref TabPage local = ref tabPageListado;
        tabControlData.DisablePage(ref local);
        this.TabPage_Listado = tabPageListado;
        this.TabPage_Detail.Enabled = true;
      }
    }

    private void Button_Save_Click(object sender, EventArgs e)
    {
      this.MakeOperation(this.ToolStripStatusLabel_OperationText.Text);
    }

    private void Button_GoOut_Click(object sender, EventArgs e)
    {
      ModGeneralVar.g_bol_IsReady = false;
      this.Close();
    }

    private void Ubicate_Record(int _ItemToUbicate)
    {
      int num = checked (this.dgrvData.Rows.Count - 1);
      int index = 0;
      while (index <= num)
      {
        if (Conversions.ToInteger(NewLateBinding.LateGet(NewLateBinding.LateIndexGet(this.dgrvData.DataSource, new object[1]
        {
          (object) index
        }, (string[]) null), (System.Type) null, "AreaID", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null)) == _ItemToUbicate)
        {
          this.dgrvData.CurrentCell = this.dgrvData[1, index];
          break;
        }
        checked { ++index; }
      }
    }

    private void Button_KBoardCriterio_Click(object sender, EventArgs e)
    {
      TextBox textBoxCriterio;
      string text = (textBoxCriterio = this.TextBox_Criterio).Text;
      ModGeneralFunctions.TextKeyBoard("Ingrese Descripción", ref text);
      textBoxCriterio.Text = text;
      if (!ModGeneralVar.g_bol_IsReady)
        return;
      this.TextBox_Criterio.Text = ModGeneralVar.g_str_InputValue;
      this.MakeOperation(StructApp.RECORD_SEARCH);
    }

    private void Button_Ready_Click(object sender, EventArgs e)
    {
      if (!ModGeneralFunctions.DataGrid_Validated(this.dgrvData))
        return;
      this.SelectITem();
      ModGeneralVar.g_bol_IsReady = true;
      this.Close();
    }

    private void dgrvData_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
    {
      if (!this.DataGV_Validated())
        return;
      if (this._OnlySearch)
        this.Button_Ready_Click(RuntimeHelpers.GetObjectValue(sender), (EventArgs) null);
      else
        this.SetOperation(StructApp.RECORD_EDIT);
    }

    public bool DataGV_Validated()
    {
      return this.dgrvData.Rows.Count > 0;
    }

    private void Button_CloseTab_Click(object sender, EventArgs e)
    {
      this.FirstTab((short) 0, "Listado de Áreas");
    }

    private bool ValidateData()
    {
      if (Operators.CompareString(this.TextBox_ProductIdOrigen.Text, "", false) == 0)
      {
        ModGeneralFunctions.MessageOk("¡Debe elegir el producto de Origen!");
        this.Button_Product_Search.Focus();
        return false;
      }
      if (Operators.CompareString(this.TextBox_ProductIdDestino.Text, "", false) == 0)
      {
        ModGeneralFunctions.MessageOk("¡Debe elegir el producto de Destino!");
        this.Button_Product_Search_Destino.Focus();
        return false;
      }
      if (ModGeneralFunctions.CadenaToDouble(((TextBox) this.txt_Cantidad).Text) < 1.0)
      {
        ModGeneralFunctions.MessageOk("¡Debe ingresar una cantidad mayor a 0!");
        ((Control) this.txt_Cantidad).Focus();
        return false;
      }
      if (Operators.CompareString(this.TextBox_ProductIdDestino.Text, this.TextBox_ProductIdOrigen.Text, false) != 0)
        return true;
      ModGeneralFunctions.MessageOk("¡No puedes elegir el mismo articulo!");
      this.Button_Product_Search_Destino.Focus();
      return false;
    }

    private void Control_KeyPress(object sender, KeyPressEventArgs e)
    {
      if (!ModGeneralFunctions.Question_Made_Enter(e))
        return;
      e.Handled = true;
      SendKeys.Send("{TAB}");
    }

    private void dgrvData_KeyDown(object sender, KeyEventArgs e)
    {
      if (ModGeneralFunctions.Question_Made_Enter_FromKeyEvent(e) && !this._OnlySearch)
        this.SetOperation(StructApp.RECORD_EDIT);
      this.Information_Quantity_Of_Records();
    }

    private void FrmAreas_Activated(object sender, EventArgs e)
    {
      this.TextBox_Criterio.Focus();
    }

    private void TextBox_Criterio_TextChanged(object sender, EventArgs e)
    {
      this.MakeOperation(StructApp.RECORD_SEARCH);
    }

    private void TextBox_Criterio_KeyPress(object sender, KeyPressEventArgs e)
    {
      if (!ModGeneralFunctions.Question_Made_Enter(e))
        return;
      if (this.dgrvData.Rows.Count == 0)
      {
        ModGeneralFunctions.MessageRestrictive("No existe(n) " + this._NameForm + " (s)");
        this.Button_New.Focus();
      }
      else if (this.TextBox_Criterio.Text.Length == 0)
      {
        e.Handled = true;
        SendKeys.Send("{TAB}");
      }
      else
        this.dgrvData.Focus();
    }

    private void CheckBox_IsActive_KeyPress(object sender, KeyPressEventArgs e)
    {
      if (!ModGeneralFunctions.Question_Made_Enter(e))
        return;
      this.Button_Save.Focus();
    }

    private void dgrvData_KeyUp(object sender, KeyEventArgs e)
    {
      this.Information_Quantity_Of_Records();
    }

    private void dgrvData_MouseClick(object sender, MouseEventArgs e)
    {
      this.Information_Quantity_Of_Records();
    }

    private void FrmArea_KeyDown(object sender, KeyEventArgs e)
    {
      if (!e.KeyValue.Equals(27))
        return;
      if (((TabControl) this.TabControl_Data).SelectedIndex == 0)
        this.Button_GoOut_Click((object) null, (EventArgs) null);
      else if (((TabControl) this.TabControl_Data).SelectedIndex == 1)
        this.Button_CloseTab_Click((object) null, (EventArgs) null);
    }

    private void Button_Product_Search_Click(object sender, EventArgs e)
    {
      int num = (int) new FrmProductos()
      {
        _OnlySearch = true,
        _ByGroup = true,
        _GroupId = Conversions.ToInteger("0"),
        _SubGroupId = Conversions.ToInteger("0"),
        _ProducTDes = this.TextBox_ProductDesOrigen.Text,
        _TypeOrderId = "01"
      }.ShowDialog();
      if (!ModGeneralVar.g_bol_IsReady || Strings.Len(ModGeneralVar.g_Str_RecordID.Length) <= 0)
        return;
      ModGeneralFunctions.ActiveColorTextbox(this.TextBox_ProductDesOrigen);
      this.TextBox_ProductIdOrigen.Text = ModGeneralVar.g_Str_RecordID;
      this.TextBox_ProductDesOrigen.Text = ModGeneralVar.g_Str_RecordDes;
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
      this.TextBox_CompanyId.Text = ModGeneralVar.g_Str_RecordID;
      this.TextBox_CompanyDes.Text = ModGeneralVar.g_Str_RecordDes;
    }

    private void Button_Product_Search_Destino_Click(object sender, EventArgs e)
    {
      int num = (int) new FrmProductos()
      {
        _OnlySearch = true,
        _ByGroup = true,
        _GroupId = Conversions.ToInteger("0"),
        _SubGroupId = Conversions.ToInteger("0"),
        _ProducTDes = this.TextBox_ProductIdDestino.Text,
        _TypeOrderId = "01"
      }.ShowDialog();
      if (!ModGeneralVar.g_bol_IsReady || Strings.Len(ModGeneralVar.g_Str_RecordID.Length) <= 0)
        return;
      ModGeneralFunctions.ActiveColorTextbox(this.TextBox_ProductDesDestino);
      this.TextBox_ProductIdDestino.Text = ModGeneralVar.g_Str_RecordID;
      this.TextBox_ProductDesDestino.Text = ModGeneralVar.g_Str_RecordDes;
    }
  }
}
