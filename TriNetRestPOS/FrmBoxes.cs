// Decompiled with JetBrains decompiler
// Type: TriNetRestPOS.FrmBoxes
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
  public class FrmBoxes : Form
  {
    private IContainer components;
    private BL_TR1_BOXES o_BL_TR1_BOXES;
    private List<BE_TR1_BOXES> O_BEC_BOXES;
    private string _OperationDes;
    private bool _IsValidate;
    public bool _OnlySearch;
    public bool _OnlyAdmin;
    public bool _IsNoTake;
    private string Res_MsgSave;
    private string Res_Code;
    private string Res_Description;
    private string str_Result;

    public FrmBoxes()
    {
      this.Load += new EventHandler(this.FrmBoxes_Load);
      this._OnlySearch = false;
      this._OnlyAdmin = false;
      this._IsNoTake = false;
      this.str_Result = StructApp.RESULT_OK;
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
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (FrmBoxes));
      this.Button_CloseTab = new Button();
      this.Button_Save = new Button();
      this.TextBox_Criterio = new TextBox();
      this.TextBox_Key = new TextBox();
      this.Label_DesShort = new Label();
      this.TabControl_Data = new TabControlEx();
      this.TabPage_Listado = new TabPage();
      this.Panel_ButtonsActions = new Panel();
      this.Button_Ready = new Button();
      this.Button_KBoardCriterio = new Button();
      this.Label_Description = new Label();
      this.Panel_ButtonsTools = new Panel();
      this.Button_Configuration = new Button();
      this.Button_First = new Button();
      this.Button_GoOut = new Button();
      this.Button_Back = new Button();
      this.Button_Delete = new Button();
      this.Button_Forward = new Button();
      this.Button_Update = new Button();
      this.Button_Last = new Button();
      this.Button_New = new Button();
      this.dgrvData = new DataGridView();
      this.TabPage_Detail = new TabPage();
      this.TextBox_BoxLinkId = new TextBox();
      this.Button_Box = new Button();
      this.CheckBox_IsTakeOrder = new CheckBox();
      this.TextBox_BoxLinkDes = new TextBox();
      this.Label1 = new Label();
      this.TextBox_Des = new TextBox();
      this.Button_KBoard_Key = new Button();
      this.Button_KBoard_Des = new Button();
      this.Label_Des = new Label();
      this.Label_Id = new Label();
      this.TextBox_Id = new TextBox();
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
      this.Button_CloseTab.Font = new Font("Verdana", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Button_CloseTab.ForeColor = Color.MediumBlue;
      this.Button_CloseTab.Image = (Image) TriNetRestPOS.My.Resources.Resources.i_Close;
      this.Button_CloseTab.Location = new Point(367, 464);
      this.Button_CloseTab.Name = "Button_CloseTab";
      this.Button_CloseTab.Size = new Size(100, 60);
      this.Button_CloseTab.TabIndex = 9;
      this.Button_CloseTab.Text = "Salir";
      this.Button_CloseTab.TextImageRelation = TextImageRelation.TextAboveImage;
      this.Button_CloseTab.UseVisualStyleBackColor = true;
      this.Button_Save.Font = new Font("Verdana", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Button_Save.ForeColor = Color.MediumBlue;
      this.Button_Save.Image = (Image) TriNetRestPOS.My.Resources.Resources.i_Ready;
      this.Button_Save.Location = new Point(265, 464);
      this.Button_Save.Name = "Button_Save";
      this.Button_Save.Size = new Size(100, 60);
      this.Button_Save.TabIndex = 8;
      this.Button_Save.Text = "Grabar";
      this.Button_Save.TextImageRelation = TextImageRelation.TextAboveImage;
      this.Button_Save.UseVisualStyleBackColor = true;
      this.TextBox_Criterio.Location = new Point(6, 34);
      this.TextBox_Criterio.MaxLength = 35;
      this.TextBox_Criterio.Name = "TextBox_Criterio";
      this.TextBox_Criterio.Size = new Size(264, 23);
      this.TextBox_Criterio.TabIndex = 0;
      this.TextBox_Key.Font = new Font("Tahoma", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.TextBox_Key.Location = new Point(56, 239);
      this.TextBox_Key.MaxLength = 50;
      this.TextBox_Key.Name = "TextBox_Key";
      this.TextBox_Key.PasswordChar = '*';
      this.TextBox_Key.ShortcutsEnabled = false;
      this.TextBox_Key.Size = new Size(309, 22);
      this.TextBox_Key.TabIndex = 3;
      this.Label_DesShort.AutoSize = true;
      this.Label_DesShort.Font = new Font("Tahoma", 12f, FontStyle.Bold);
      this.Label_DesShort.ForeColor = Color.MediumBlue;
      this.Label_DesShort.Location = new Point(52, 200);
      this.Label_DesShort.Name = "Label_DesShort";
      this.Label_DesShort.Size = new Size(146, 19);
      this.Label_DesShort.TabIndex = 155;
      this.Label_DesShort.Text = "Clave de Acceso:";
      ((Control) this.TabControl_Data).Controls.Add((Control) this.TabPage_Listado);
      ((Control) this.TabControl_Data).Controls.Add((Control) this.TabPage_Detail);
      ((Control) this.TabControl_Data).Font = new Font("Verdana", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      ((Control) this.TabControl_Data).Location = new Point(0, 1);
      ((Control) this.TabControl_Data).Name = "TabControl_Data";
      ((TabControl) this.TabControl_Data).SelectedIndex = 0;
      ((Control) this.TabControl_Data).Size = new Size(541, 574);
      ((Control) this.TabControl_Data).TabIndex = 166;
      this.TabPage_Listado.Controls.Add((Control) this.Panel_ButtonsActions);
      this.TabPage_Listado.Controls.Add((Control) this.Label_Description);
      this.TabPage_Listado.Controls.Add((Control) this.Panel_ButtonsTools);
      this.TabPage_Listado.Controls.Add((Control) this.TextBox_Criterio);
      this.TabPage_Listado.Controls.Add((Control) this.dgrvData);
      this.TabPage_Listado.Font = new Font("Verdana", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.TabPage_Listado.Location = new Point(4, 23);
      this.TabPage_Listado.Name = "TabPage_Listado";
      this.TabPage_Listado.Padding = new Padding(3);
      this.TabPage_Listado.Size = new Size(533, 547);
      this.TabPage_Listado.TabIndex = 0;
      this.TabPage_Listado.Text = "Listado";
      this.TabPage_Listado.UseVisualStyleBackColor = true;
      this.Panel_ButtonsActions.Controls.Add((Control) this.Button_Ready);
      this.Panel_ButtonsActions.Controls.Add((Control) this.Button_KBoardCriterio);
      this.Panel_ButtonsActions.Location = new Point(276, 3);
      this.Panel_ButtonsActions.Name = "Panel_ButtonsActions";
      this.Panel_ButtonsActions.Size = new Size(169, 61);
      this.Panel_ButtonsActions.TabIndex = 162;
      this.Button_Ready.Font = new Font("Trebuchet MS", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Button_Ready.ForeColor = Color.MediumBlue;
      this.Button_Ready.Image = (Image) TriNetRestPOS.My.Resources.Resources.Ready;
      this.Button_Ready.Location = new Point(84, 1);
      this.Button_Ready.Name = "Button_Ready";
      this.Button_Ready.Size = new Size(83, 60);
      this.Button_Ready.TabIndex = 161;
      this.Button_Ready.Text = "&Listo";
      this.Button_Ready.TextImageRelation = TextImageRelation.TextAboveImage;
      this.Button_Ready.UseVisualStyleBackColor = true;
      this.Button_Ready.Visible = false;
      this.Button_KBoardCriterio.Font = new Font("Trebuchet MS", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Button_KBoardCriterio.ForeColor = Color.MediumBlue;
      this.Button_KBoardCriterio.Image = (Image) componentResourceManager.GetObject("Button_KBoardCriterio.Image");
      this.Button_KBoardCriterio.ImageAlign = ContentAlignment.BottomCenter;
      this.Button_KBoardCriterio.Location = new Point(1, 1);
      this.Button_KBoardCriterio.Name = "Button_KBoardCriterio";
      this.Button_KBoardCriterio.Size = new Size(83, 60);
      this.Button_KBoardCriterio.TabIndex = 148;
      this.Button_KBoardCriterio.TextAlign = ContentAlignment.TopCenter;
      this.Button_KBoardCriterio.UseVisualStyleBackColor = true;
      this.Label_Description.AutoSize = true;
      this.Label_Description.Font = new Font("Tahoma", 12f, FontStyle.Bold);
      this.Label_Description.ForeColor = Color.MediumBlue;
      this.Label_Description.Location = new Point(4, 12);
      this.Label_Description.Name = "Label_Description";
      this.Label_Description.Size = new Size(108, 19);
      this.Label_Description.TabIndex = 147;
      this.Label_Description.Text = "Descripción:";
      this.Panel_ButtonsTools.Controls.Add((Control) this.Button_Configuration);
      this.Panel_ButtonsTools.Controls.Add((Control) this.Button_First);
      this.Panel_ButtonsTools.Controls.Add((Control) this.Button_GoOut);
      this.Panel_ButtonsTools.Controls.Add((Control) this.Button_Back);
      this.Panel_ButtonsTools.Controls.Add((Control) this.Button_Delete);
      this.Panel_ButtonsTools.Controls.Add((Control) this.Button_Forward);
      this.Panel_ButtonsTools.Controls.Add((Control) this.Button_Update);
      this.Panel_ButtonsTools.Controls.Add((Control) this.Button_Last);
      this.Panel_ButtonsTools.Controls.Add((Control) this.Button_New);
      this.Panel_ButtonsTools.Location = new Point(445, 5);
      this.Panel_ButtonsTools.Name = "Panel_ButtonsTools";
      this.Panel_ButtonsTools.Size = new Size(87, 539);
      this.Panel_ButtonsTools.TabIndex = 146;
      this.Button_Configuration.Font = new Font("Trebuchet MS", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Button_Configuration.ForeColor = Color.MediumBlue;
      this.Button_Configuration.Image = (Image) TriNetRestPOS.My.Resources.Resources.Actualizar;
      this.Button_Configuration.Location = new Point(2, 177);
      this.Button_Configuration.Name = "Button_Configuration";
      this.Button_Configuration.Size = new Size(83, 60);
      this.Button_Configuration.TabIndex = 162;
      this.Button_Configuration.Text = "&Conf Ava";
      this.Button_Configuration.TextImageRelation = TextImageRelation.TextAboveImage;
      this.Button_Configuration.UseVisualStyleBackColor = true;
      this.Button_First.Font = new Font("Verdana", 18f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Button_First.Image = (Image) TriNetRestPOS.My.Resources.Resources.Fast_back;
      this.Button_First.Location = new Point(2, 299);
      this.Button_First.Name = "Button_First";
      this.Button_First.RightToLeft = RightToLeft.Yes;
      this.Button_First.Size = new Size(83, 60);
      this.Button_First.TabIndex = 32;
      this.Button_First.UseVisualStyleBackColor = true;
      this.Button_GoOut.Font = new Font("Trebuchet MS", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Button_GoOut.ForeColor = Color.MediumBlue;
      this.Button_GoOut.Image = (Image) TriNetRestPOS.My.Resources.Resources.i_Close;
      this.Button_GoOut.Location = new Point(2, 0);
      this.Button_GoOut.Name = "Button_GoOut";
      this.Button_GoOut.Size = new Size(83, 60);
      this.Button_GoOut.TabIndex = 161;
      this.Button_GoOut.Text = "&Atrás";
      this.Button_GoOut.TextImageRelation = TextImageRelation.TextAboveImage;
      this.Button_GoOut.UseVisualStyleBackColor = true;
      this.Button_Back.Font = new Font("Verdana", 18f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Button_Back.Image = (Image) TriNetRestPOS.My.Resources.Resources.go_back;
      this.Button_Back.Location = new Point(2, 358);
      this.Button_Back.Name = "Button_Back";
      this.Button_Back.RightToLeft = RightToLeft.Yes;
      this.Button_Back.Size = new Size(83, 60);
      this.Button_Back.TabIndex = 33;
      this.Button_Back.UseVisualStyleBackColor = true;
      this.Button_Delete.Font = new Font("Trebuchet MS", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Button_Delete.ForeColor = Color.MediumBlue;
      this.Button_Delete.Image = (Image) TriNetRestPOS.My.Resources.Resources.Eliminar;
      this.Button_Delete.Location = new Point(2, 236);
      this.Button_Delete.Name = "Button_Delete";
      this.Button_Delete.RightToLeft = RightToLeft.Yes;
      this.Button_Delete.Size = new Size(83, 60);
      this.Button_Delete.TabIndex = 148;
      this.Button_Delete.Text = "&Eliminar";
      this.Button_Delete.TextImageRelation = TextImageRelation.TextAboveImage;
      this.Button_Delete.UseVisualStyleBackColor = true;
      this.Button_Forward.Font = new Font("Verdana", 18f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Button_Forward.Image = (Image) TriNetRestPOS.My.Resources.Resources.go_forward;
      this.Button_Forward.Location = new Point(2, 417);
      this.Button_Forward.Name = "Button_Forward";
      this.Button_Forward.RightToLeft = RightToLeft.Yes;
      this.Button_Forward.Size = new Size(83, 60);
      this.Button_Forward.TabIndex = 34;
      this.Button_Forward.UseVisualStyleBackColor = true;
      this.Button_Update.Font = new Font("Trebuchet MS", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Button_Update.ForeColor = Color.MediumBlue;
      this.Button_Update.Image = (Image) TriNetRestPOS.My.Resources.Resources.Actualizar;
      this.Button_Update.Location = new Point(2, 118);
      this.Button_Update.Name = "Button_Update";
      this.Button_Update.Size = new Size(83, 60);
      this.Button_Update.TabIndex = 147;
      this.Button_Update.Text = "&Editar";
      this.Button_Update.TextImageRelation = TextImageRelation.TextAboveImage;
      this.Button_Update.UseVisualStyleBackColor = true;
      this.Button_Last.Font = new Font("Verdana", 18f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Button_Last.Image = (Image) TriNetRestPOS.My.Resources.Resources.fast_forward;
      this.Button_Last.Location = new Point(2, 476);
      this.Button_Last.Name = "Button_Last";
      this.Button_Last.RightToLeft = RightToLeft.Yes;
      this.Button_Last.Size = new Size(83, 60);
      this.Button_Last.TabIndex = 35;
      this.Button_Last.UseVisualStyleBackColor = true;
      this.Button_New.Font = new Font("Trebuchet MS", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Button_New.ForeColor = Color.MediumBlue;
      this.Button_New.Image = (Image) TriNetRestPOS.My.Resources.Resources.i_News;
      this.Button_New.Location = new Point(2, 59);
      this.Button_New.Name = "Button_New";
      this.Button_New.Size = new Size(83, 60);
      this.Button_New.TabIndex = 146;
      this.Button_New.Text = "&Nuevo";
      this.Button_New.TextImageRelation = TextImageRelation.TextAboveImage;
      this.Button_New.UseVisualStyleBackColor = true;
      this.dgrvData.BorderStyle = BorderStyle.Fixed3D;
      this.dgrvData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dgrvData.Location = new Point(3, 64);
      this.dgrvData.MultiSelect = false;
      this.dgrvData.Name = "dgrvData";
      this.dgrvData.ScrollBars = ScrollBars.None;
      this.dgrvData.Size = new Size(441, 479);
      this.dgrvData.TabIndex = 1;
      this.TabPage_Detail.Controls.Add((Control) this.TextBox_BoxLinkId);
      this.TabPage_Detail.Controls.Add((Control) this.Button_Box);
      this.TabPage_Detail.Controls.Add((Control) this.CheckBox_IsTakeOrder);
      this.TabPage_Detail.Controls.Add((Control) this.TextBox_BoxLinkDes);
      this.TabPage_Detail.Controls.Add((Control) this.Label1);
      this.TabPage_Detail.Controls.Add((Control) this.TextBox_Des);
      this.TabPage_Detail.Controls.Add((Control) this.Button_CloseTab);
      this.TabPage_Detail.Controls.Add((Control) this.Button_Save);
      this.TabPage_Detail.Controls.Add((Control) this.Button_KBoard_Key);
      this.TabPage_Detail.Controls.Add((Control) this.TextBox_Key);
      this.TabPage_Detail.Controls.Add((Control) this.Label_DesShort);
      this.TabPage_Detail.Controls.Add((Control) this.Button_KBoard_Des);
      this.TabPage_Detail.Controls.Add((Control) this.Label_Des);
      this.TabPage_Detail.Controls.Add((Control) this.Label_Id);
      this.TabPage_Detail.Controls.Add((Control) this.TextBox_Id);
      this.TabPage_Detail.Location = new Point(4, 23);
      this.TabPage_Detail.Name = "TabPage_Detail";
      this.TabPage_Detail.Padding = new Padding(3);
      this.TabPage_Detail.Size = new Size(533, 547);
      this.TabPage_Detail.TabIndex = 1;
      this.TabPage_Detail.Text = "Mantenimiento";
      this.TabPage_Detail.UseVisualStyleBackColor = true;
      this.TextBox_BoxLinkId.Font = new Font("Tahoma", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.TextBox_BoxLinkId.Location = new Point(473, 394);
      this.TextBox_BoxLinkId.MaxLength = 50;
      this.TextBox_BoxLinkId.Name = "TextBox_BoxLinkId";
      this.TextBox_BoxLinkId.Size = new Size(10, 22);
      this.TextBox_BoxLinkId.TabIndex = 162;
      this.TextBox_BoxLinkId.Visible = false;
      this.Button_Box.Font = new Font("Verdana", 8.25f, FontStyle.Bold);
      this.Button_Box.ForeColor = Color.MediumBlue;
      this.Button_Box.Image = (Image) TriNetRestPOS.My.Resources.Resources.Search_G;
      this.Button_Box.Location = new Point(384, 353);
      this.Button_Box.Name = "Button_Box";
      this.Button_Box.Size = new Size(83, 60);
      this.Button_Box.TabIndex = 7;
      this.Button_Box.Text = "&Caja";
      this.Button_Box.TextImageRelation = TextImageRelation.TextAboveImage;
      this.Button_Box.UseVisualStyleBackColor = true;
      this.CheckBox_IsTakeOrder.AutoSize = true;
      this.CheckBox_IsTakeOrder.Checked = true;
      this.CheckBox_IsTakeOrder.CheckState = CheckState.Checked;
      this.CheckBox_IsTakeOrder.Font = new Font("Tahoma", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.CheckBox_IsTakeOrder.ForeColor = Color.Red;
      this.CheckBox_IsTakeOrder.Location = new Point(56, 306);
      this.CheckBox_IsTakeOrder.Name = "CheckBox_IsTakeOrder";
      this.CheckBox_IsTakeOrder.Size = new Size(195, 23);
      this.CheckBox_IsTakeOrder.TabIndex = 5;
      this.CheckBox_IsTakeOrder.Text = "Tomador de Pedidos";
      this.CheckBox_IsTakeOrder.UseVisualStyleBackColor = true;
      this.TextBox_BoxLinkDes.Font = new Font("Tahoma", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.TextBox_BoxLinkDes.Location = new Point(56, 391);
      this.TextBox_BoxLinkDes.MaxLength = 50;
      this.TextBox_BoxLinkDes.Name = "TextBox_BoxLinkDes";
      this.TextBox_BoxLinkDes.Size = new Size(309, 22);
      this.TextBox_BoxLinkDes.TabIndex = 6;
      this.Label1.AutoSize = true;
      this.Label1.Font = new Font("Tahoma", 12f, FontStyle.Bold);
      this.Label1.ForeColor = Color.MediumBlue;
      this.Label1.Location = new Point(52, 352);
      this.Label1.Name = "Label1";
      this.Label1.Size = new Size(128, 19);
      this.Label1.TabIndex = 159;
      this.Label1.Text = "Caja Principal:";
      this.TextBox_Des.Font = new Font("Tahoma", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.TextBox_Des.Location = new Point(56, 155);
      this.TextBox_Des.MaxLength = 30;
      this.TextBox_Des.Name = "TextBox_Des";
      this.TextBox_Des.Size = new Size(309, 22);
      this.TextBox_Des.TabIndex = 1;
      this.Button_KBoard_Key.Font = new Font("Verdana", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Button_KBoard_Key.ForeColor = Color.MediumBlue;
      this.Button_KBoard_Key.Image = (Image) componentResourceManager.GetObject("Button_KBoard_Key.Image");
      this.Button_KBoard_Key.ImageAlign = ContentAlignment.BottomCenter;
      this.Button_KBoard_Key.Location = new Point(384, 201);
      this.Button_KBoard_Key.Name = "Button_KBoard_Key";
      this.Button_KBoard_Key.Size = new Size(83, 60);
      this.Button_KBoard_Key.TabIndex = 4;
      this.Button_KBoard_Key.TextAlign = ContentAlignment.TopCenter;
      this.Button_KBoard_Key.UseVisualStyleBackColor = true;
      this.Button_KBoard_Des.Font = new Font("Verdana", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Button_KBoard_Des.ForeColor = Color.MediumBlue;
      this.Button_KBoard_Des.Image = (Image) componentResourceManager.GetObject("Button_KBoard_Des.Image");
      this.Button_KBoard_Des.ImageAlign = ContentAlignment.BottomCenter;
      this.Button_KBoard_Des.Location = new Point(384, 117);
      this.Button_KBoard_Des.Name = "Button_KBoard_Des";
      this.Button_KBoard_Des.Size = new Size(83, 60);
      this.Button_KBoard_Des.TabIndex = 2;
      this.Button_KBoard_Des.TextAlign = ContentAlignment.TopCenter;
      this.Button_KBoard_Des.UseVisualStyleBackColor = true;
      this.Label_Des.AutoSize = true;
      this.Label_Des.Font = new Font("Tahoma", 12f, FontStyle.Bold);
      this.Label_Des.ForeColor = Color.MediumBlue;
      this.Label_Des.Location = new Point(52, 116);
      this.Label_Des.Name = "Label_Des";
      this.Label_Des.Size = new Size(79, 19);
      this.Label_Des.TabIndex = 151;
      this.Label_Des.Text = "Nombre:";
      this.Label_Id.AutoSize = true;
      this.Label_Id.Font = new Font("Tahoma", 12f, FontStyle.Bold);
      this.Label_Id.ForeColor = Color.MediumBlue;
      this.Label_Id.Location = new Point(52, 42);
      this.Label_Id.Name = "Label_Id";
      this.Label_Id.Size = new Size(71, 19);
      this.Label_Id.TabIndex = 149;
      this.Label_Id.Text = "Código:";
      this.TextBox_Id.BackColor = Color.FromArgb((int) byte.MaxValue, 240, 144);
      this.TextBox_Id.Enabled = false;
      this.TextBox_Id.Location = new Point(56, 75);
      this.TextBox_Id.Name = "TextBox_Id";
      this.TextBox_Id.ReadOnly = true;
      this.TextBox_Id.Size = new Size(152, 22);
      this.TextBox_Id.TabIndex = 148;
      this.StatusStrip_Properties.BackColor = Color.Transparent;
      this.StatusStrip_Properties.Items.AddRange(new ToolStripItem[2]
      {
        (ToolStripItem) this.ToolStripStatusLabel_Operation,
        (ToolStripItem) this.Tssl_Record
      });
      this.StatusStrip_Properties.Location = new Point(0, 578);
      this.StatusStrip_Properties.Name = "StatusStrip_Properties";
      this.StatusStrip_Properties.Size = new Size(537, 22);
      this.StatusStrip_Properties.TabIndex = 167;
      this.StatusStrip_Properties.Text = "StatusStrip1";
      this.ToolStripStatusLabel_Operation.Font = new Font("Verdana", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.ToolStripStatusLabel_Operation.ForeColor = Color.MediumBlue;
      this.ToolStripStatusLabel_Operation.Name = "ToolStripStatusLabel_Operation";
      this.ToolStripStatusLabel_Operation.Size = new Size(0, 17);
      this.Tssl_Record.Font = new Font("Verdana", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Tssl_Record.ForeColor = Color.MediumBlue;
      this.Tssl_Record.Name = "Tssl_Record";
      this.Tssl_Record.Size = new Size(522, 17);
      this.Tssl_Record.Spring = true;
      this.Tssl_Record.Text = "N° Record";
      this.Tssl_Record.TextAlign = ContentAlignment.MiddleRight;
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.BackColor = Color.White;
      this.ClientSize = new Size(537, 600);
      this.ControlBox = false;
      this.Controls.Add((Control) this.TabControl_Data);
      this.Controls.Add((Control) this.StatusStrip_Properties);
      this.Name = nameof (FrmBoxes);
      this.ShowIcon = false;
      this.ShowInTaskbar = false;
      this.StartPosition = FormStartPosition.CenterParent;
      this.Text = "Cajas";
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

    internal virtual TextBox TextBox_Criterio
    {
      get
      {
        return this._TextBox_Criterio;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.TextBox_Criterio_TextChanged);
        TextBox textBoxCriterio1 = this._TextBox_Criterio;
        if (textBoxCriterio1 != null)
          textBoxCriterio1.TextChanged -= eventHandler;
        this._TextBox_Criterio = value;
        TextBox textBoxCriterio2 = this._TextBox_Criterio;
        if (textBoxCriterio2 == null)
          return;
        textBoxCriterio2.TextChanged += eventHandler;
      }
    }

    internal virtual TextBox TextBox_Key { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Label Label_DesShort { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual TabControlEx TabControl_Data { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual TabPage TabPage_Listado { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

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

    internal virtual Label Label_Description { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Panel Panel_ButtonsTools { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

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

    internal virtual Button Button_Update
    {
      get
      {
        return this._Button_Update;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Button_Update_Click);
        Button buttonUpdate1 = this._Button_Update;
        if (buttonUpdate1 != null)
          buttonUpdate1.Click -= eventHandler;
        this._Button_Update = value;
        Button buttonUpdate2 = this._Button_Update;
        if (buttonUpdate2 == null)
          return;
        buttonUpdate2.Click += eventHandler;
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
        DataGridView dgrvData1 = this._dgrvData;
        if (dgrvData1 != null)
        {
          dgrvData1.CellClick -= cellEventHandler1;
          dgrvData1.CellDoubleClick -= cellEventHandler2;
        }
        this._dgrvData = value;
        DataGridView dgrvData2 = this._dgrvData;
        if (dgrvData2 == null)
          return;
        dgrvData2.CellClick += cellEventHandler1;
        dgrvData2.CellDoubleClick += cellEventHandler2;
      }
    }

    internal virtual TabPage TabPage_Detail { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Button Button_KBoard_Key
    {
      get
      {
        return this._Button_KBoard_Key;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Button_KBoard_Key_Click);
        Button buttonKboardKey1 = this._Button_KBoard_Key;
        if (buttonKboardKey1 != null)
          buttonKboardKey1.Click -= eventHandler;
        this._Button_KBoard_Key = value;
        Button buttonKboardKey2 = this._Button_KBoard_Key;
        if (buttonKboardKey2 == null)
          return;
        buttonKboardKey2.Click += eventHandler;
      }
    }

    internal virtual Button Button_KBoard_Des
    {
      get
      {
        return this._Button_KBoard_Des;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Button_KBoard_Des_Click);
        Button buttonKboardDes1 = this._Button_KBoard_Des;
        if (buttonKboardDes1 != null)
          buttonKboardDes1.Click -= eventHandler;
        this._Button_KBoard_Des = value;
        Button buttonKboardDes2 = this._Button_KBoard_Des;
        if (buttonKboardDes2 == null)
          return;
        buttonKboardDes2.Click += eventHandler;
      }
    }

    internal virtual Label Label_Des { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Label Label_Id { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual TextBox TextBox_Id { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual StatusStrip StatusStrip_Properties { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual ToolStripStatusLabel ToolStripStatusLabel_Operation { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual ToolStripStatusLabel Tssl_Record { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual TextBox TextBox_Des { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual CheckBox CheckBox_IsTakeOrder
    {
      get
      {
        return this._CheckBox_IsTakeOrder;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.CheckBox_IsTakeOrder_CheckedChanged);
        CheckBox checkBoxIsTakeOrder1 = this._CheckBox_IsTakeOrder;
        if (checkBoxIsTakeOrder1 != null)
          checkBoxIsTakeOrder1.CheckedChanged -= eventHandler;
        this._CheckBox_IsTakeOrder = value;
        CheckBox checkBoxIsTakeOrder2 = this._CheckBox_IsTakeOrder;
        if (checkBoxIsTakeOrder2 == null)
          return;
        checkBoxIsTakeOrder2.CheckedChanged += eventHandler;
      }
    }

    internal virtual TextBox TextBox_BoxLinkDes { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Label Label1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Button Button_Box
    {
      get
      {
        return this._Button_Box;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Button_Box_Click);
        Button buttonBox1 = this._Button_Box;
        if (buttonBox1 != null)
          buttonBox1.Click -= eventHandler;
        this._Button_Box = value;
        Button buttonBox2 = this._Button_Box;
        if (buttonBox2 == null)
          return;
        buttonBox2.Click += eventHandler;
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

    internal virtual Button Button_Configuration
    {
      get
      {
        return this._Button_Configuration;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Button_Configuration_Click);
        Button buttonConfiguration1 = this._Button_Configuration;
        if (buttonConfiguration1 != null)
          buttonConfiguration1.Click -= eventHandler;
        this._Button_Configuration = value;
        Button buttonConfiguration2 = this._Button_Configuration;
        if (buttonConfiguration2 == null)
          return;
        buttonConfiguration2.Click += eventHandler;
      }
    }

    internal virtual TextBox TextBox_BoxLinkId { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    private void FrmBoxes_Load(object sender, EventArgs e)
    {
      this.o_BL_TR1_BOXES = new BL_TR1_BOXES();
      this.O_BEC_BOXES = new List<BE_TR1_BOXES>();
      this.Resource(ModGeneralFunctions.Get_Language((object) this));
      this.SetUpDataGridView();
      this.LoadData();
      this.Button_Ready.Visible = this._OnlySearch;
      if (this._OnlySearch)
      {
        this.Button_Delete.Visible = false;
        this.Button_New.Visible = false;
        this.Button_Update.Visible = false;
        this.Button_Configuration.Visible = false;
        ModGeneralVar.g_bol_IsClose = false;
      }
      if (!this._OnlyAdmin)
        return;
      this.Button_Delete.Visible = false;
      this.Button_New.Visible = false;
      this.Button_Update.Visible = true;
      this.Button_Configuration.Visible = false;
      ModGeneralVar.g_bol_IsClose = false;
    }

    private void Resource(ResourceManager Rm)
    {
      this.Button_CloseTab.Text = Rm.GetString("Res_Exit");
      this.Res_MsgSave = Rm.GetString("Res_MsgSave");
      ModGeneralVar.g_Res_Description = Rm.GetString("Res_InputDescription");
      this.Res_Code = Rm.GetString("Res_Code");
      this.Res_Description = Rm.GetString("Res_Description");
      this.Button_KBoardCriterio.Text = Rm.GetString("Res_Keyboard");
      this.Button_KBoard_Des.Text = Rm.GetString("Res_Keyboard");
    }

    private void SetUpDataGridView()
    {
      ModGeneralFunctions.SetUpDataGridViewBasic(this.dgrvData);
      this.dgrvData.Columns.Add("BoxId", "Código");
      ModGeneralFunctions.SetUp_TextBoxColumn((DataGridViewTextBoxColumn) this.dgrvData.Columns[0], "BoxId", (short) 62, "", true, DataGridViewContentAlignment.MiddleCenter, true);
      this.dgrvData.Columns.Add("BoxDes", "Descripción");
      ModGeneralFunctions.SetUp_TextBoxColumn((DataGridViewTextBoxColumn) this.dgrvData.Columns[1], "BoxDes", (short) 279, "", true, DataGridViewContentAlignment.MiddleLeft, true);
      this.dgrvData.Columns.Add((DataGridViewColumn) new DataGridViewCheckBoxColumn());
      ModGeneralFunctions.SetUp_CheckBoxColumn((DataGridViewCheckBoxColumn) this.dgrvData.Columns[2], "T. Pedido", "IsTakeOrder", (short) 85, "", true);
    }

    private void LoadData()
    {
      this.O_BEC_BOXES = new List<BE_TR1_BOXES>();
      this.O_BEC_BOXES = !this._IsNoTake ? this.o_BL_TR1_BOXES.ListByDes(Conversions.ToInteger(ModGeneralFunctions.ObtenerAPPCONFIG("STR_LOCALID")), this.TextBox_Criterio.Text) : this.o_BL_TR1_BOXES.ListByDesNoTake(Conversions.ToInteger(ModGeneralFunctions.ObtenerAPPCONFIG("STR_LOCALID")), this.TextBox_Criterio.Text);
      this.dgrvData.DataSource = (object) this.O_BEC_BOXES;
      this.Tssl_Record.Text = Conversions.ToString(this.O_BEC_BOXES.Count);
      this.FirstTab((short) 0, "Listado de Cajas del Local");
      this.Information_Quantity_Of_Records();
    }

    private void SetOperation(string _Operation)
    {
      this._OperationDes = _Operation;
      if (Operators.CompareString(_Operation, StructApp.RECORD_CREATE, false) == 0)
      {
        this.TextBox_Id.Text = "";
        this.TextBox_Des.Text = "";
        this.TextBox_Key.Text = "";
        this.CheckBox_IsTakeOrder.Checked = false;
        this.TextBox_Des.Focus();
      }
      else if (Operators.CompareString(_Operation, StructApp.RECORD_EDIT, false) == 0)
      {
        this.TextBox_Id.Text = Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateIndexGet(this.dgrvData.DataSource, new object[1]
        {
          (object) this.dgrvData.CurrentRow.Index
        }, (string[]) null), (System.Type) null, "BoxId", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
        this.TextBox_Des.Text = Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateIndexGet(this.dgrvData.DataSource, new object[1]
        {
          (object) this.dgrvData.CurrentRow.Index
        }, (string[]) null), (System.Type) null, "BoxDes", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
        this.TextBox_Key.Text = Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateIndexGet(this.dgrvData.DataSource, new object[1]
        {
          (object) this.dgrvData.CurrentRow.Index
        }, (string[]) null), (System.Type) null, "MachineKey", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
        this.CheckBox_IsTakeOrder.Checked = (Conversions.ToBoolean(NewLateBinding.LateGet(NewLateBinding.LateIndexGet(this.dgrvData.DataSource, new object[1]
        {
          (object) this.dgrvData.CurrentRow.Index
        }, (string[]) null), (System.Type) null, "IsTakeOrder", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null)) ? 1 : 0) != 0;
        if (this.CheckBox_IsTakeOrder.Checked)
        {
          this.TextBox_BoxLinkId.Text = Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateIndexGet(this.dgrvData.DataSource, new object[1]
          {
            (object) this.dgrvData.CurrentRow.Index
          }, (string[]) null), (System.Type) null, "BoxIdPos", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
          this.TextBox_BoxLinkDes.Text = Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateIndexGet(this.dgrvData.DataSource, new object[1]
          {
            (object) this.dgrvData.CurrentRow.Index
          }, (string[]) null), (System.Type) null, "BoxDesPos", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
        }
        this.TextBox_Des.Focus();
      }
      else
      {
        if (Operators.CompareString(_Operation, StructApp.RECORD_DELETE, false) != 0)
          return;
        this.TextBox_Id.Text = Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateIndexGet(this.dgrvData.DataSource, new object[1]
        {
          (object) this.dgrvData.CurrentRow.Index
        }, (string[]) null), (System.Type) null, "BoxId", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
        this.TextBox_Des.Text = Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateIndexGet(this.dgrvData.DataSource, new object[1]
        {
          (object) this.dgrvData.CurrentRow.Index
        }, (string[]) null), (System.Type) null, "BoxDes", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
        this.TextBox_Key.Text = Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateIndexGet(this.dgrvData.DataSource, new object[1]
        {
          (object) this.dgrvData.CurrentRow.Index
        }, (string[]) null), (System.Type) null, "MachineKey", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
        this.MakeOperation(this._OperationDes);
      }
    }

    private void MakeOperation(string _Operation)
    {
      BE_TR1_BOXES beTr1Boxes1;
      if (Operators.CompareString(_Operation, StructApp.RECORD_CREATE, false) == 0)
      {
        if (!this.ValidateData() || !ModGeneralFunctions.MessageMakeAction(this.Res_MsgSave, false))
          return;
        BE_TR1_BOXES beTr1Boxes2 = new BE_TR1_BOXES();
        beTr1Boxes2.set_EstabliId(Conversions.ToInteger(Interaction.IIf(ModGeneralVar.g_BE_TR1_VARIABLES_B == null, RuntimeHelpers.GetObjectValue(ModGeneralFunctions.ObtenerAPPCONFIG("STR_LOCALID")), (object) ModGeneralVar.g_BE_TR1_VARIABLES_B.get_EstabliId())));
        beTr1Boxes2.set_BoxId(checked ((int) Math.Round(Conversion.Val(this.TextBox_Id.Text))));
        beTr1Boxes2.set_BoxDes(this.TextBox_Des.Text);
        beTr1Boxes2.set_MachineKey(this.TextBox_Key.Text);
        beTr1Boxes2.set_IsTakeOrder(this.CheckBox_IsTakeOrder.Checked);
        if (ModGeneralVar.g_BE_USERS == null)
          beTr1Boxes2.set_UserId("TNS");
        else
          beTr1Boxes2.set_UserId(ModGeneralVar.g_BE_USERS.get_UserId());
        if (this.CheckBox_IsTakeOrder.Checked)
          beTr1Boxes2.set_BoxIdPos(checked ((int) Math.Round(Conversion.Val(this.TextBox_BoxLinkId.Text))));
        else
          beTr1Boxes2.set_BoxIdPos(checked ((int) Math.Round(Conversion.Val(this.TextBox_Id.Text))));
        this.str_Result = this.o_BL_TR1_BOXES.Add(ref beTr1Boxes2);
        if (this.str_Result.Equals(StructApp.RESULT_OK))
        {
          this.LoadData();
          this.Ubicate_Record(Conversions.ToString(beTr1Boxes2.get_BoxId()));
          ModGeneralFunctions.MessageOk("[Registro Creado]");
          this.FirstTab((short) 0, "Listado de Cajas del Local");
        }
        else
          ModGeneralFunctions.MessageError_Large(this.str_Result, true);
        beTr1Boxes1 = (BE_TR1_BOXES) null;
      }
      else if (Operators.CompareString(_Operation, StructApp.RECORD_EDIT, false) == 0)
      {
        if (!this.ValidateData() || !ModGeneralFunctions.MessageMakeAction("¿Esta Seguro de Grabar el Registro?", false))
          return;
        BE_TR1_BOXES beTr1Boxes2 = new BE_TR1_BOXES();
        beTr1Boxes2.set_EstabliId(Conversions.ToInteger(Interaction.IIf(ModGeneralVar.g_BE_TR1_VARIABLES_B == null, RuntimeHelpers.GetObjectValue(ModGeneralFunctions.ObtenerAPPCONFIG("STR_LOCALID")), (object) ModGeneralVar.g_BE_TR1_VARIABLES_B.get_EstabliId())));
        beTr1Boxes2.set_BoxId(checked ((int) Math.Round(Conversion.Val(this.TextBox_Id.Text))));
        beTr1Boxes2.set_BoxDes(this.TextBox_Des.Text);
        beTr1Boxes2.set_MachineKey(this.TextBox_Key.Text);
        beTr1Boxes2.set_IsTakeOrder(this.CheckBox_IsTakeOrder.Checked);
        if (ModGeneralVar.g_BE_USERS == null)
          beTr1Boxes2.set_UserId("TNS");
        else
          beTr1Boxes2.set_UserId(ModGeneralVar.g_BE_USERS.get_UserId());
        if (this.CheckBox_IsTakeOrder.Checked)
          beTr1Boxes2.set_BoxIdPos(checked ((int) Math.Round(Conversion.Val(this.TextBox_BoxLinkId.Text))));
        else
          beTr1Boxes2.set_BoxIdPos(checked ((int) Math.Round(Conversion.Val(this.TextBox_Id.Text))));
        this.str_Result = this.o_BL_TR1_BOXES.Edit(beTr1Boxes2);
        if (this.str_Result.Equals(StructApp.RESULT_OK))
        {
          short index = checked ((short) this.dgrvData.CurrentRow.Index);
          this.LoadData();
          if (this.dgrvData.Rows.Count > 0)
            this.dgrvData.CurrentCell = this.dgrvData[0, (int) index];
          ModGeneralFunctions.MessageOk("[Registro Editado]");
          this.FirstTab((short) 0, "Listado de Cajas del Local");
        }
        else
          ModGeneralFunctions.MessageError_Large(this.str_Result, true);
        beTr1Boxes1 = (BE_TR1_BOXES) null;
      }
      else
      {
        if (Operators.CompareString(_Operation, StructApp.RECORD_DELETE, false) != 0 || !ModGeneralFunctions.MessageMakeAction("¿Seguro de Eliminar La Caja: -" + this.TextBox_Des.Text + "-", false))
          return;
        BE_TR1_BOXES beTr1Boxes2 = new BE_TR1_BOXES();
        beTr1Boxes2.set_EstabliId(Conversions.ToInteger(Interaction.IIf(ModGeneralVar.g_BE_TR1_VARIABLES_B == null, RuntimeHelpers.GetObjectValue(ModGeneralFunctions.ObtenerAPPCONFIG("STR_LOCALID")), (object) ModGeneralVar.g_BE_TR1_VARIABLES_B.get_EstabliId())));
        beTr1Boxes2.set_BoxId(checked ((int) Math.Round(Conversion.Val(this.TextBox_Id.Text))));
        beTr1Boxes2.set_BoxDes(this.TextBox_Des.Text);
        beTr1Boxes2.set_MachineKey(this.TextBox_Key.Text);
        if (ModGeneralVar.g_BE_USERS == null)
          beTr1Boxes2.set_UserId("TNS");
        else
          beTr1Boxes2.set_UserId(ModGeneralVar.g_BE_USERS.get_UserId());
        this.str_Result = this.o_BL_TR1_BOXES.Delete(beTr1Boxes2);
        if (Operators.CompareString(this.str_Result, StructApp.RESULT_OK, false) == 0)
        {
          short index = checked ((short) this.dgrvData.CurrentRow.Index);
          this.LoadData();
          if (index > (short) 1)
            this.dgrvData.CurrentCell = this.dgrvData[0, checked ((int) index - 1)];
          ModGeneralFunctions.MessageOk("[Registro Eliminado]");
        }
        else
          ModGeneralFunctions.MessageError_Large(this.str_Result, true);
        this.FirstTab((short) 0, "Listado de Cajas del Local");
      }
    }

    private bool ValidateData()
    {
      if (this.TextBox_Des.Text.Trim().Equals(""))
      {
        ModGeneralFunctions.MessageOk(ModGeneralVar.g_Res_Description);
        this.TextBox_Des.Focus();
        return false;
      }
      if (!this.TextBox_Key.Text.Trim().Equals(""))
        return true;
      ModGeneralFunctions.MessageOk("¡Ingresar Clave de Acceso!");
      this.TextBox_Key.Focus();
      return false;
    }

    private void Ubicate_Record(string _ItemToUbicate)
    {
      int num = checked (this.dgrvData.Rows.Count - 1);
      int index = 0;
      while (index <= num)
      {
        if (Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateIndexGet(this.dgrvData.DataSource, new object[1]
        {
          (object) index
        }, (string[]) null), (System.Type) null, "BoxId", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null)).Equals(_ItemToUbicate))
        {
          this.dgrvData.CurrentCell = this.dgrvData[0, index];
          break;
        }
        checked { ++index; }
      }
    }

    private void Button_GoOut_Click(object sender, EventArgs e)
    {
      this.Close();
    }

    private void Button_New_Click(object sender, EventArgs e)
    {
      this.SetOperation(StructApp.RECORD_CREATE);
      this.FirstTab((short) 1, "Crear Registro");
    }

    private void Button_Update_Click(object sender, EventArgs e)
    {
      if (!this.DataGRV_Validated())
        return;
      this.SetOperation(StructApp.RECORD_EDIT);
      this.FirstTab((short) 1, "Editar Registro");
    }

    private void Button_Save_Click(object sender, EventArgs e)
    {
      this.MakeOperation(this._OperationDes);
    }

    private void Button_CloseTab_Click(object sender, EventArgs e)
    {
      this.FirstTab((short) 0, "Listado de Cajas del Local");
    }

    private void Button_Delete_Click(object sender, EventArgs e)
    {
      if (!this.DataGRV_Validated())
        return;
      this.SetOperation(StructApp.RECORD_DELETE);
    }

    private void Button_First_Click(object sender, EventArgs e)
    {
      if (this.dgrvData.Rows.Count <= 0)
        return;
      this.dgrvData.CurrentCell = this.dgrvData[0, 0];
      this.SelectITem();
    }

    private void Button_Last_Click(object sender, EventArgs e)
    {
      if (this.dgrvData.Rows.Count <= 0)
        return;
      this.dgrvData.CurrentCell = this.dgrvData[1, checked (this.dgrvData.Rows.Count - 1)];
      this.SelectITem();
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
      }
    }

    private void SelectITem()
    {
      try
      {
        ModGeneralVar.g_Str_RecordID = Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateIndexGet(this.dgrvData.DataSource, new object[1]
        {
          (object) this.dgrvData.CurrentRow.Index
        }, (string[]) null), (System.Type) null, "BoxId", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
        ModGeneralVar.g_Str_RecordDes = Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateIndexGet(this.dgrvData.DataSource, new object[1]
        {
          (object) this.dgrvData.CurrentRow.Index
        }, (string[]) null), (System.Type) null, "BoxDes", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
        this.Information_Quantity_Of_Records();
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
    }

    private void Button_KBoard_Des_Click(object sender, EventArgs e)
    {
      TextBox textBoxDes;
      string text = (textBoxDes = this.TextBox_Des).Text;
      ModGeneralFunctions.TextKeyBoard_Password("Ingrese Nombre", ref text);
      textBoxDes.Text = text;
      if (!ModGeneralVar.g_bol_IsReady)
        return;
      if (Strings.Len(ModGeneralVar.g_str_InputValue) > 0)
        this.TextBox_Des.Text = ModGeneralVar.g_str_InputValue;
      this.TextBox_Key.Focus();
    }

    private void Button_KBoard_Key_Click(object sender, EventArgs e)
    {
      TextBox textBoxKey;
      string text = (textBoxKey = this.TextBox_Key).Text;
      ModGeneralFunctions.TextKeyBoard_Password("Ingrese Clave de Acceso", ref text);
      textBoxKey.Text = text;
      if (Strings.Len(ModGeneralVar.g_str_InputValue) > 0)
        this.TextBox_Key.Text = ModGeneralVar.g_str_InputValue;
      this.Button_Save.Focus();
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

    private void dgrvData_CellClick(object sender, DataGridViewCellEventArgs e)
    {
      this.SelectITem();
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
        this.TextBox_Des.Focus();
      }
      else
      {
        TabControlEx tabControlData = this.TabControl_Data;
        TabPage tabPageListado = this.TabPage_Listado;
        ref TabPage local = ref tabPageListado;
        tabControlData.DisablePage(ref local);
        this.TabPage_Listado = tabPageListado;
        this.TabPage_Detail.Enabled = true;
        this.TextBox_Des.Focus();
      }
    }

    private void Button_KBoardCriterio_Click(object sender, EventArgs e)
    {
      string str = "";
      ModGeneralFunctions.TextKeyBoard("Ingrese Descripción", ref str);
      if (!ModGeneralVar.g_bol_IsReady)
        return;
      this.TextBox_Criterio.Text = ModGeneralVar.g_str_InputValue;
    }

    private void TextBox_Criterio_TextChanged(object sender, EventArgs e)
    {
      BL_TR1_BOXES blTr1Boxes = new BL_TR1_BOXES();
      List<BE_TR1_BOXES> beTr1BoxesList = new List<BE_TR1_BOXES>();
      this.dgrvData.DataSource = (object) blTr1Boxes.ListByDes(Conversions.ToInteger(ModGeneralFunctions.ObtenerAPPCONFIG("STR_LOCALID")), this.TextBox_Criterio.Text);
      beTr1BoxesList = (List<BE_TR1_BOXES>) null;
    }

    private void dgrvData_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
    {
      if (!this._OnlySearch)
      {
        if (!this.DataGRV_Validated())
          return;
        this.Button_Update_Click((object) null, (EventArgs) null);
      }
      else if (this.DataGRV_Validated())
      {
        this.SelectITem();
        ModGeneralVar.g_bol_IsReady = true;
        this.Close();
      }
    }

    private void Button_Box_Click(object sender, EventArgs e)
    {
      ModGeneralVar.g_Str_RecordID = "";
      FrmBoxes frmBoxes = new FrmBoxes();
      frmBoxes._OnlySearch = true;
      frmBoxes._IsNoTake = true;
      int num = (int) frmBoxes.ShowDialog();
      frmBoxes.Dispose();
      if (ModGeneralVar.g_Str_RecordID.Equals(""))
        return;
      this.TextBox_BoxLinkDes.Text = ModGeneralVar.g_Str_RecordDes;
      this.TextBox_BoxLinkId.Text = ModGeneralVar.g_Str_RecordID;
    }

    private void Button_Ready_Click(object sender, EventArgs e)
    {
      this.SelectITem();
      ModGeneralVar.g_bol_IsReady = true;
      this.Close();
    }

    private void CheckBox_IsTakeOrder_CheckedChanged(object sender, EventArgs e)
    {
      if (this.CheckBox_IsTakeOrder.Checked)
      {
        this.TextBox_BoxLinkDes.Enabled = true;
        this.TextBox_BoxLinkId.Enabled = true;
        this.Button_Box.Enabled = true;
      }
      else
      {
        this.TextBox_BoxLinkDes.Text = "";
        this.TextBox_BoxLinkDes.Enabled = false;
        this.TextBox_BoxLinkId.Text = "";
        this.TextBox_BoxLinkId.Enabled = false;
        this.Button_Box.Enabled = false;
      }
    }

    private void Button_Configuration_Click(object sender, EventArgs e)
    {
      FrmCfgCaja frmCfgCaja = new FrmCfgCaja();
      frmCfgCaja._IsAdvanced = true;
      frmCfgCaja._MachineId = Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateIndexGet(this.dgrvData.DataSource, new object[1]
      {
        (object) this.dgrvData.CurrentRow.Index
      }, (string[]) null), (System.Type) null, "MachineKey", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      frmCfgCaja._BoxId = Conversions.ToInteger(NewLateBinding.LateGet(NewLateBinding.LateIndexGet(this.dgrvData.DataSource, new object[1]
      {
        (object) this.dgrvData.CurrentRow.Index
      }, (string[]) null), (System.Type) null, "BoxIdPos", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      int num = (int) frmCfgCaja.ShowDialog();
      frmCfgCaja.Dispose();
    }
  }
}
