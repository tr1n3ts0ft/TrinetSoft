// Decompiled with JetBrains decompiler
// Type: TriNetRestPOS.FrmAnfitriona
// Assembly: TriNetRestPOS, Version=5.2.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 43377352-E952-4AC1-9BA6-CCBE4AE5F575
// Assembly location: C:\log\TriNetRestPOS.exe

using APP_Utilities;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
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
  public class FrmAnfitriona : Form
  {
    private IContainer components;
    private BL_TR1_ANFITRIONA o_BL_ANFITRIONA;
    private string str_Result;
    public bool _OnlySearch;

    public FrmAnfitriona()
    {
      this.Load += new EventHandler(this.FrmAnfitriona_Load);
      this.o_BL_ANFITRIONA = new BL_TR1_ANFITRIONA();
      this.str_Result = StructApp.RESULT_OK;
      this._OnlySearch = false;
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
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (FrmAnfitriona));
      this.TabControl_Data = new TabControlEx();
      this.TabPage_Listado = new TabPage();
      this.Panel_ButtonsActions = new Panel();
      this.Button_KBoardCriterio = new Button();
      this.Button_GoOut = new Button();
      this.Button_Ready = new Button();
      this.Label_Description = new Label();
      this.TextBox_Criterio = new TextBox();
      this.Panel_ButtonsLocation = new Panel();
      this.Button_Delete = new Button();
      this.Button_First = new Button();
      this.Button_Back = new Button();
      this.Button_Update = new Button();
      this.Button_Forward = new Button();
      this.Button_Last = new Button();
      this.Button_New = new Button();
      this.dgrvData = new DataGridView();
      this.TabPage_Detail = new TabPage();
      this.Button_KBoard_CodigoInterno = new Button();
      this.TextBox_CodigoInterno = new TextBox();
      this.Label1 = new Label();
      this.CheckBox_IsActive = new CheckBox();
      this.Label_IsActive = new Label();
      this.Button_CloseTab = new Button();
      this.Button_Save = new Button();
      this.Button_KBoard_DesShort = new Button();
      this.TextBox_DesShort = new TextBox();
      this.Label_DesShort = new Label();
      this.Button_KBoard_Des = new Button();
      this.Label_Des = new Label();
      this.TextBox_Des = new TextBox();
      this.Label_Id = new Label();
      this.TextBox_Id = new TextBox();
      this.StatusStrip_Properties = new StatusStrip();
      this.ToolStripStatusLabel_Operation = new ToolStripStatusLabel();
      this.Tssl_Record = new ToolStripStatusLabel();
      this.ToolStripStatusLabel_OperationText = new ToolStripStatusLabel();
      this.CheckBox_EsMarca = new CheckBox();
      this.Label2 = new Label();
      ((Control) this.TabControl_Data).SuspendLayout();
      this.TabPage_Listado.SuspendLayout();
      this.Panel_ButtonsActions.SuspendLayout();
      this.Panel_ButtonsLocation.SuspendLayout();
      ((ISupportInitialize) this.dgrvData).BeginInit();
      this.TabPage_Detail.SuspendLayout();
      this.StatusStrip_Properties.SuspendLayout();
      this.SuspendLayout();
      ((Control) this.TabControl_Data).Controls.Add((Control) this.TabPage_Listado);
      ((Control) this.TabControl_Data).Controls.Add((Control) this.TabPage_Detail);
      ((Control) this.TabControl_Data).Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      ((Control) this.TabControl_Data).Location = new Point(-1, -1);
      ((Control) this.TabControl_Data).Name = "TabControl_Data";
      ((TabControl) this.TabControl_Data).SelectedIndex = 0;
      ((Control) this.TabControl_Data).Size = new Size(464, 552);
      ((Control) this.TabControl_Data).TabIndex = 1;
      this.TabPage_Listado.Controls.Add((Control) this.Panel_ButtonsActions);
      this.TabPage_Listado.Controls.Add((Control) this.Label_Description);
      this.TabPage_Listado.Controls.Add((Control) this.TextBox_Criterio);
      this.TabPage_Listado.Controls.Add((Control) this.Panel_ButtonsLocation);
      this.TabPage_Listado.Controls.Add((Control) this.dgrvData);
      this.TabPage_Listado.Font = new Font("Verdana", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.TabPage_Listado.Location = new Point(4, 25);
      this.TabPage_Listado.Name = "TabPage_Listado";
      this.TabPage_Listado.Padding = new Padding(3);
      this.TabPage_Listado.Size = new Size(456, 523);
      this.TabPage_Listado.TabIndex = 0;
      this.TabPage_Listado.Text = "Listado";
      this.TabPage_Listado.UseVisualStyleBackColor = true;
      this.Panel_ButtonsActions.Controls.Add((Control) this.Button_KBoardCriterio);
      this.Panel_ButtonsActions.Controls.Add((Control) this.Button_GoOut);
      this.Panel_ButtonsActions.Controls.Add((Control) this.Button_Ready);
      this.Panel_ButtonsActions.Font = new Font("Trebuchet MS", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Panel_ButtonsActions.Location = new Point(198, 0);
      this.Panel_ButtonsActions.Name = "Panel_ButtonsActions";
      this.Panel_ButtonsActions.Size = new Size(260, 64);
      this.Panel_ButtonsActions.TabIndex = 162;
      this.Button_KBoardCriterio.BackgroundImage = (Image) TriNetRestPOS.My.Resources.Resources.teclado_icon;
      this.Button_KBoardCriterio.FlatStyle = FlatStyle.Flat;
      this.Button_KBoardCriterio.Font = new Font("Trebuchet MS", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Button_KBoardCriterio.ForeColor = Color.WhiteSmoke;
      this.Button_KBoardCriterio.ImageAlign = ContentAlignment.BottomCenter;
      this.Button_KBoardCriterio.Location = new Point(3, 33);
      this.Button_KBoardCriterio.Name = "Button_KBoardCriterio";
      this.Button_KBoardCriterio.Size = new Size(45, 27);
      this.Button_KBoardCriterio.TabIndex = 148;
      this.Button_KBoardCriterio.TextAlign = ContentAlignment.TopCenter;
      this.Button_KBoardCriterio.UseVisualStyleBackColor = true;
      this.Button_GoOut.BackgroundImage = (Image) TriNetRestPOS.My.Resources.Resources.boton_rojo;
      this.Button_GoOut.FlatStyle = FlatStyle.Flat;
      this.Button_GoOut.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Button_GoOut.ForeColor = Color.WhiteSmoke;
      this.Button_GoOut.Image = (Image) TriNetRestPOS.My.Resources.Resources.salir;
      this.Button_GoOut.ImageAlign = ContentAlignment.TopCenter;
      this.Button_GoOut.Location = new Point(180, 3);
      this.Button_GoOut.Name = "Button_GoOut";
      this.Button_GoOut.Padding = new Padding(0, 5, 0, 5);
      this.Button_GoOut.Size = new Size(74, 56);
      this.Button_GoOut.TabIndex = 161;
      this.Button_GoOut.Text = "Atrás";
      this.Button_GoOut.TextAlign = ContentAlignment.BottomCenter;
      this.Button_GoOut.UseVisualStyleBackColor = true;
      this.Button_Ready.BackgroundImage = (Image) TriNetRestPOS.My.Resources.Resources.boton_guardar;
      this.Button_Ready.FlatStyle = FlatStyle.Flat;
      this.Button_Ready.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Button_Ready.ForeColor = Color.WhiteSmoke;
      this.Button_Ready.Image = (Image) TriNetRestPOS.My.Resources.Resources.check_OK;
      this.Button_Ready.ImageAlign = ContentAlignment.TopCenter;
      this.Button_Ready.Location = new Point(103, 3);
      this.Button_Ready.Name = "Button_Ready";
      this.Button_Ready.Padding = new Padding(0, 5, 0, 5);
      this.Button_Ready.Size = new Size(74, 56);
      this.Button_Ready.TabIndex = 160;
      this.Button_Ready.Text = "Listo";
      this.Button_Ready.TextAlign = ContentAlignment.BottomCenter;
      this.Button_Ready.UseVisualStyleBackColor = true;
      this.Button_Ready.Visible = false;
      this.Label_Description.AutoSize = true;
      this.Label_Description.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Label_Description.ForeColor = Color.FromArgb(150, 150, 150);
      this.Label_Description.Location = new Point(2, 12);
      this.Label_Description.Name = "Label_Description";
      this.Label_Description.Size = new Size(80, 16);
      this.Label_Description.TabIndex = 147;
      this.Label_Description.Text = "Descripción";
      this.TextBox_Criterio.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.TextBox_Criterio.Location = new Point(3, 36);
      this.TextBox_Criterio.MaxLength = 35;
      this.TextBox_Criterio.Multiline = true;
      this.TextBox_Criterio.Name = "TextBox_Criterio";
      this.TextBox_Criterio.Size = new Size(193, 20);
      this.TextBox_Criterio.TabIndex = 0;
      this.Panel_ButtonsLocation.Controls.Add((Control) this.Button_Delete);
      this.Panel_ButtonsLocation.Controls.Add((Control) this.Button_First);
      this.Panel_ButtonsLocation.Controls.Add((Control) this.Button_Back);
      this.Panel_ButtonsLocation.Controls.Add((Control) this.Button_Update);
      this.Panel_ButtonsLocation.Controls.Add((Control) this.Button_Forward);
      this.Panel_ButtonsLocation.Controls.Add((Control) this.Button_Last);
      this.Panel_ButtonsLocation.Controls.Add((Control) this.Button_New);
      this.Panel_ButtonsLocation.Location = new Point(371, 64);
      this.Panel_ButtonsLocation.Name = "Panel_ButtonsLocation";
      this.Panel_ButtonsLocation.Size = new Size(84, 454);
      this.Panel_ButtonsLocation.TabIndex = 124;
      this.Button_Delete.BackgroundImage = (Image) TriNetRestPOS.My.Resources.Resources.boton_cuadrado_rojo;
      this.Button_Delete.FlatStyle = FlatStyle.Flat;
      this.Button_Delete.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Button_Delete.ForeColor = Color.WhiteSmoke;
      this.Button_Delete.Image = (Image) TriNetRestPOS.My.Resources.Resources.eliminar_icono;
      this.Button_Delete.ImageAlign = ContentAlignment.TopCenter;
      this.Button_Delete.Location = new Point(8, 129);
      this.Button_Delete.Name = "Button_Delete";
      this.Button_Delete.Padding = new Padding(0, 5, 0, 5);
      this.Button_Delete.RightToLeft = RightToLeft.Yes;
      this.Button_Delete.Size = new Size(69, 65);
      this.Button_Delete.TabIndex = 148;
      this.Button_Delete.Text = "Eliminar";
      this.Button_Delete.TextAlign = ContentAlignment.BottomCenter;
      this.Button_Delete.UseVisualStyleBackColor = true;
      this.Button_First.BackgroundImage = (Image) componentResourceManager.GetObject("Button_First.BackgroundImage");
      this.Button_First.FlatStyle = FlatStyle.Flat;
      this.Button_First.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Button_First.ForeColor = Color.WhiteSmoke;
      this.Button_First.Image = (Image) TriNetRestPOS.My.Resources.Resources.flecha_inicio;
      this.Button_First.Location = new Point(8, 193);
      this.Button_First.Name = "Button_First";
      this.Button_First.RightToLeft = RightToLeft.Yes;
      this.Button_First.Size = new Size(69, 65);
      this.Button_First.TabIndex = 32;
      this.Button_First.UseVisualStyleBackColor = true;
      this.Button_Back.BackgroundImage = (Image) componentResourceManager.GetObject("Button_Back.BackgroundImage");
      this.Button_Back.FlatStyle = FlatStyle.Flat;
      this.Button_Back.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Button_Back.ForeColor = Color.WhiteSmoke;
      this.Button_Back.Image = (Image) TriNetRestPOS.My.Resources.Resources.flecha_arriba;
      this.Button_Back.Location = new Point(8, 257);
      this.Button_Back.Name = "Button_Back";
      this.Button_Back.RightToLeft = RightToLeft.Yes;
      this.Button_Back.Size = new Size(69, 65);
      this.Button_Back.TabIndex = 33;
      this.Button_Back.UseVisualStyleBackColor = true;
      this.Button_Update.BackgroundImage = (Image) componentResourceManager.GetObject("Button_Update.BackgroundImage");
      this.Button_Update.FlatStyle = FlatStyle.Flat;
      this.Button_Update.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Button_Update.ForeColor = Color.WhiteSmoke;
      this.Button_Update.Image = (Image) TriNetRestPOS.My.Resources.Resources.icono_editar;
      this.Button_Update.ImageAlign = ContentAlignment.TopCenter;
      this.Button_Update.Location = new Point(8, 65);
      this.Button_Update.Name = "Button_Update";
      this.Button_Update.Padding = new Padding(0, 5, 0, 5);
      this.Button_Update.Size = new Size(69, 65);
      this.Button_Update.TabIndex = 147;
      this.Button_Update.Text = "&Editar";
      this.Button_Update.TextAlign = ContentAlignment.BottomCenter;
      this.Button_Update.UseVisualStyleBackColor = true;
      this.Button_Forward.BackgroundImage = (Image) componentResourceManager.GetObject("Button_Forward.BackgroundImage");
      this.Button_Forward.FlatStyle = FlatStyle.Flat;
      this.Button_Forward.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Button_Forward.ForeColor = Color.WhiteSmoke;
      this.Button_Forward.Image = (Image) TriNetRestPOS.My.Resources.Resources.flecha_abajo;
      this.Button_Forward.Location = new Point(8, 321);
      this.Button_Forward.Name = "Button_Forward";
      this.Button_Forward.RightToLeft = RightToLeft.Yes;
      this.Button_Forward.Size = new Size(69, 65);
      this.Button_Forward.TabIndex = 34;
      this.Button_Forward.UseVisualStyleBackColor = true;
      this.Button_Last.BackgroundImage = (Image) componentResourceManager.GetObject("Button_Last.BackgroundImage");
      this.Button_Last.FlatStyle = FlatStyle.Flat;
      this.Button_Last.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Button_Last.ForeColor = Color.WhiteSmoke;
      this.Button_Last.Image = (Image) TriNetRestPOS.My.Resources.Resources.flecha_final;
      this.Button_Last.Location = new Point(8, 385);
      this.Button_Last.Name = "Button_Last";
      this.Button_Last.RightToLeft = RightToLeft.Yes;
      this.Button_Last.Size = new Size(69, 65);
      this.Button_Last.TabIndex = 35;
      this.Button_Last.UseVisualStyleBackColor = true;
      this.Button_New.BackgroundImage = (Image) componentResourceManager.GetObject("Button_New.BackgroundImage");
      this.Button_New.FlatStyle = FlatStyle.Flat;
      this.Button_New.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Button_New.ForeColor = Color.WhiteSmoke;
      this.Button_New.Image = (Image) TriNetRestPOS.My.Resources.Resources.icono_nuevo;
      this.Button_New.ImageAlign = ContentAlignment.TopCenter;
      this.Button_New.Location = new Point(8, 1);
      this.Button_New.Name = "Button_New";
      this.Button_New.Padding = new Padding(0, 5, 0, 5);
      this.Button_New.Size = new Size(69, 65);
      this.Button_New.TabIndex = 146;
      this.Button_New.Text = "&Nuevo";
      this.Button_New.TextAlign = ContentAlignment.BottomCenter;
      this.Button_New.UseVisualStyleBackColor = true;
      this.dgrvData.BorderStyle = BorderStyle.Fixed3D;
      this.dgrvData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dgrvData.Location = new Point(1, 66);
      this.dgrvData.MultiSelect = false;
      this.dgrvData.Name = "dgrvData";
      this.dgrvData.ScrollBars = ScrollBars.None;
      this.dgrvData.ShowRowErrors = false;
      this.dgrvData.Size = new Size(370, 454);
      this.dgrvData.TabIndex = 1;
      this.TabPage_Detail.Controls.Add((Control) this.CheckBox_EsMarca);
      this.TabPage_Detail.Controls.Add((Control) this.Label2);
      this.TabPage_Detail.Controls.Add((Control) this.Button_KBoard_CodigoInterno);
      this.TabPage_Detail.Controls.Add((Control) this.TextBox_CodigoInterno);
      this.TabPage_Detail.Controls.Add((Control) this.Label1);
      this.TabPage_Detail.Controls.Add((Control) this.CheckBox_IsActive);
      this.TabPage_Detail.Controls.Add((Control) this.Label_IsActive);
      this.TabPage_Detail.Controls.Add((Control) this.Button_CloseTab);
      this.TabPage_Detail.Controls.Add((Control) this.Button_Save);
      this.TabPage_Detail.Controls.Add((Control) this.Button_KBoard_DesShort);
      this.TabPage_Detail.Controls.Add((Control) this.TextBox_DesShort);
      this.TabPage_Detail.Controls.Add((Control) this.Label_DesShort);
      this.TabPage_Detail.Controls.Add((Control) this.Button_KBoard_Des);
      this.TabPage_Detail.Controls.Add((Control) this.Label_Des);
      this.TabPage_Detail.Controls.Add((Control) this.TextBox_Des);
      this.TabPage_Detail.Controls.Add((Control) this.Label_Id);
      this.TabPage_Detail.Controls.Add((Control) this.TextBox_Id);
      this.TabPage_Detail.Location = new Point(4, 25);
      this.TabPage_Detail.Name = "TabPage_Detail";
      this.TabPage_Detail.Padding = new Padding(3);
      this.TabPage_Detail.Size = new Size(456, 523);
      this.TabPage_Detail.TabIndex = 1;
      this.TabPage_Detail.Text = "Mantenimiento";
      this.TabPage_Detail.UseVisualStyleBackColor = true;
      this.Button_KBoard_CodigoInterno.BackgroundImage = (Image) TriNetRestPOS.My.Resources.Resources.teclado_icon;
      this.Button_KBoard_CodigoInterno.FlatStyle = FlatStyle.Flat;
      this.Button_KBoard_CodigoInterno.Font = new Font("Trebuchet MS", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Button_KBoard_CodigoInterno.ForeColor = Color.WhiteSmoke;
      this.Button_KBoard_CodigoInterno.ImageAlign = ContentAlignment.BottomCenter;
      this.Button_KBoard_CodigoInterno.Location = new Point(342, 333);
      this.Button_KBoard_CodigoInterno.Name = "Button_KBoard_CodigoInterno";
      this.Button_KBoard_CodigoInterno.Size = new Size(45, 27);
      this.Button_KBoard_CodigoInterno.TabIndex = 165;
      this.Button_KBoard_CodigoInterno.TextAlign = ContentAlignment.TopCenter;
      this.Button_KBoard_CodigoInterno.UseVisualStyleBackColor = true;
      this.TextBox_CodigoInterno.BorderStyle = BorderStyle.FixedSingle;
      this.TextBox_CodigoInterno.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.TextBox_CodigoInterno.Location = new Point(26, 336);
      this.TextBox_CodigoInterno.MaxLength = 50;
      this.TextBox_CodigoInterno.Multiline = true;
      this.TextBox_CodigoInterno.Name = "TextBox_CodigoInterno";
      this.TextBox_CodigoInterno.Size = new Size(309, 24);
      this.TextBox_CodigoInterno.TabIndex = 164;
      this.Label1.AutoSize = true;
      this.Label1.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Label1.ForeColor = Color.FromArgb(150, 150, 150);
      this.Label1.Location = new Point(23, 305);
      this.Label1.Name = "Label1";
      this.Label1.Size = new Size(95, 16);
      this.Label1.TabIndex = 166;
      this.Label1.Text = "Codigo Interno";
      this.CheckBox_IsActive.AutoSize = true;
      this.CheckBox_IsActive.FlatStyle = FlatStyle.Flat;
      this.CheckBox_IsActive.Font = new Font("Trebuchet MS", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.CheckBox_IsActive.Location = new Point(109, 390);
      this.CheckBox_IsActive.Name = "CheckBox_IsActive";
      this.CheckBox_IsActive.Size = new Size(12, 11);
      this.CheckBox_IsActive.TabIndex = 7;
      this.CheckBox_IsActive.UseVisualStyleBackColor = true;
      this.Label_IsActive.AutoSize = true;
      this.Label_IsActive.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Label_IsActive.ForeColor = Color.FromArgb(150, 150, 150);
      this.Label_IsActive.Location = new Point(23, 385);
      this.Label_IsActive.Name = "Label_IsActive";
      this.Label_IsActive.Size = new Size(45, 16);
      this.Label_IsActive.TabIndex = 163;
      this.Label_IsActive.Text = "Activo";
      this.Button_CloseTab.BackgroundImage = (Image) TriNetRestPOS.My.Resources.Resources.BotonRojo;
      this.Button_CloseTab.FlatStyle = FlatStyle.Flat;
      this.Button_CloseTab.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Button_CloseTab.ForeColor = Color.WhiteSmoke;
      this.Button_CloseTab.Image = (Image) TriNetRestPOS.My.Resources.Resources.salir;
      this.Button_CloseTab.ImageAlign = ContentAlignment.TopCenter;
      this.Button_CloseTab.Location = new Point(333, 438);
      this.Button_CloseTab.Name = "Button_CloseTab";
      this.Button_CloseTab.Padding = new Padding(0, 5, 0, 5);
      this.Button_CloseTab.Size = new Size(114, 60);
      this.Button_CloseTab.TabIndex = 9;
      this.Button_CloseTab.Text = "Atrás";
      this.Button_CloseTab.TextAlign = ContentAlignment.BottomCenter;
      this.Button_CloseTab.UseVisualStyleBackColor = true;
      this.Button_Save.BackgroundImage = (Image) TriNetRestPOS.My.Resources.Resources.BotonVerde;
      this.Button_Save.FlatStyle = FlatStyle.Flat;
      this.Button_Save.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Button_Save.ForeColor = Color.WhiteSmoke;
      this.Button_Save.Image = (Image) TriNetRestPOS.My.Resources.Resources.check_OK;
      this.Button_Save.ImageAlign = ContentAlignment.TopCenter;
      this.Button_Save.Location = new Point(212, 438);
      this.Button_Save.Name = "Button_Save";
      this.Button_Save.Padding = new Padding(0, 5, 0, 5);
      this.Button_Save.Size = new Size(121, 60);
      this.Button_Save.TabIndex = 8;
      this.Button_Save.Text = "Grabar";
      this.Button_Save.TextAlign = ContentAlignment.BottomCenter;
      this.Button_Save.UseVisualStyleBackColor = true;
      this.Button_KBoard_DesShort.BackgroundImage = (Image) TriNetRestPOS.My.Resources.Resources.teclado_icon;
      this.Button_KBoard_DesShort.FlatStyle = FlatStyle.Flat;
      this.Button_KBoard_DesShort.Font = new Font("Trebuchet MS", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Button_KBoard_DesShort.ForeColor = Color.WhiteSmoke;
      this.Button_KBoard_DesShort.ImageAlign = ContentAlignment.BottomCenter;
      this.Button_KBoard_DesShort.Location = new Point(341, 250);
      this.Button_KBoard_DesShort.Name = "Button_KBoard_DesShort";
      this.Button_KBoard_DesShort.Size = new Size(45, 27);
      this.Button_KBoard_DesShort.TabIndex = 4;
      this.Button_KBoard_DesShort.TextAlign = ContentAlignment.TopCenter;
      this.Button_KBoard_DesShort.UseVisualStyleBackColor = true;
      this.TextBox_DesShort.BorderStyle = BorderStyle.FixedSingle;
      this.TextBox_DesShort.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.TextBox_DesShort.Location = new Point(25, 253);
      this.TextBox_DesShort.MaxLength = 50;
      this.TextBox_DesShort.Multiline = true;
      this.TextBox_DesShort.Name = "TextBox_DesShort";
      this.TextBox_DesShort.Size = new Size(309, 24);
      this.TextBox_DesShort.TabIndex = 3;
      this.Label_DesShort.AutoSize = true;
      this.Label_DesShort.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Label_DesShort.ForeColor = Color.FromArgb(150, 150, 150);
      this.Label_DesShort.Location = new Point(22, 222);
      this.Label_DesShort.Name = "Label_DesShort";
      this.Label_DesShort.Size = new Size(115, 16);
      this.Label_DesShort.TabIndex = 155;
      this.Label_DesShort.Text = "Descripción Corta";
      this.Button_KBoard_Des.BackgroundImage = (Image) TriNetRestPOS.My.Resources.Resources.teclado_icon;
      this.Button_KBoard_Des.FlatStyle = FlatStyle.Flat;
      this.Button_KBoard_Des.Font = new Font("Trebuchet MS", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Button_KBoard_Des.ForeColor = Color.WhiteSmoke;
      this.Button_KBoard_Des.ImageAlign = ContentAlignment.BottomCenter;
      this.Button_KBoard_Des.Location = new Point(341, 140);
      this.Button_KBoard_Des.Name = "Button_KBoard_Des";
      this.Button_KBoard_Des.Size = new Size(45, 27);
      this.Button_KBoard_Des.TabIndex = 2;
      this.Button_KBoard_Des.TextAlign = ContentAlignment.TopCenter;
      this.Button_KBoard_Des.UseVisualStyleBackColor = true;
      this.Label_Des.AutoSize = true;
      this.Label_Des.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Label_Des.ForeColor = Color.FromArgb(150, 150, 150);
      this.Label_Des.Location = new Point(22, 109);
      this.Label_Des.Name = "Label_Des";
      this.Label_Des.Size = new Size(80, 16);
      this.Label_Des.TabIndex = 151;
      this.Label_Des.Text = "Descripción";
      this.TextBox_Des.BorderStyle = BorderStyle.FixedSingle;
      this.TextBox_Des.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.TextBox_Des.Location = new Point(25, 140);
      this.TextBox_Des.MaxLength = 50;
      this.TextBox_Des.Multiline = true;
      this.TextBox_Des.Name = "TextBox_Des";
      this.TextBox_Des.Size = new Size(309, 55);
      this.TextBox_Des.TabIndex = 1;
      this.Label_Id.AutoSize = true;
      this.Label_Id.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Label_Id.ForeColor = Color.FromArgb(150, 150, 150);
      this.Label_Id.Location = new Point(22, 30);
      this.Label_Id.Name = "Label_Id";
      this.Label_Id.Size = new Size(52, 16);
      this.Label_Id.TabIndex = 149;
      this.Label_Id.Text = "Código";
      this.TextBox_Id.BackColor = Color.LightGray;
      this.TextBox_Id.BorderStyle = BorderStyle.FixedSingle;
      this.TextBox_Id.Enabled = false;
      this.TextBox_Id.Font = new Font("Trebuchet MS", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.TextBox_Id.Location = new Point(25, 61);
      this.TextBox_Id.Multiline = true;
      this.TextBox_Id.Name = "TextBox_Id";
      this.TextBox_Id.ReadOnly = true;
      this.TextBox_Id.Size = new Size(186, 24);
      this.TextBox_Id.TabIndex = 148;
      this.StatusStrip_Properties.BackColor = Color.Transparent;
      this.StatusStrip_Properties.Font = new Font("Trebuchet MS", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.StatusStrip_Properties.Items.AddRange(new ToolStripItem[3]
      {
        (ToolStripItem) this.ToolStripStatusLabel_Operation,
        (ToolStripItem) this.Tssl_Record,
        (ToolStripItem) this.ToolStripStatusLabel_OperationText
      });
      this.StatusStrip_Properties.Location = new Point(0, 550);
      this.StatusStrip_Properties.Name = "StatusStrip_Properties";
      this.StatusStrip_Properties.Size = new Size(462, 22);
      this.StatusStrip_Properties.TabIndex = 165;
      this.StatusStrip_Properties.Text = "StatusStrip1";
      this.ToolStripStatusLabel_Operation.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.ToolStripStatusLabel_Operation.ForeColor = Color.Black;
      this.ToolStripStatusLabel_Operation.Name = "ToolStripStatusLabel_Operation";
      this.ToolStripStatusLabel_Operation.Size = new Size(0, 17);
      this.Tssl_Record.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Tssl_Record.ForeColor = Color.Black;
      this.Tssl_Record.Name = "Tssl_Record";
      this.Tssl_Record.Size = new Size(447, 17);
      this.Tssl_Record.Spring = true;
      this.Tssl_Record.Text = "N° Record";
      this.Tssl_Record.TextAlign = ContentAlignment.MiddleRight;
      this.ToolStripStatusLabel_OperationText.BackColor = Color.Transparent;
      this.ToolStripStatusLabel_OperationText.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.ToolStripStatusLabel_OperationText.ForeColor = Color.Black;
      this.ToolStripStatusLabel_OperationText.Name = "ToolStripStatusLabel_OperationText";
      this.ToolStripStatusLabel_OperationText.Size = new Size(0, 17);
      this.CheckBox_EsMarca.AutoSize = true;
      this.CheckBox_EsMarca.Checked = true;
      this.CheckBox_EsMarca.CheckState = CheckState.Checked;
      this.CheckBox_EsMarca.FlatStyle = FlatStyle.Flat;
      this.CheckBox_EsMarca.Font = new Font("Trebuchet MS", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.CheckBox_EsMarca.Location = new Point(319, 390);
      this.CheckBox_EsMarca.Name = "CheckBox_EsMarca";
      this.CheckBox_EsMarca.Size = new Size(12, 11);
      this.CheckBox_EsMarca.TabIndex = 167;
      this.CheckBox_EsMarca.UseVisualStyleBackColor = true;
      this.Label2.AutoSize = true;
      this.Label2.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Label2.ForeColor = Color.FromArgb(150, 150, 150);
      this.Label2.Location = new Point(210, 385);
      this.Label2.Name = "Label2";
      this.Label2.Size = new Size(94, 16);
      this.Label2.TabIndex = 168;
      this.Label2.Text = "Usa Marcador";
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.ClientSize = new Size(462, 572);
      this.Controls.Add((Control) this.StatusStrip_Properties);
      this.Controls.Add((Control) this.TabControl_Data);
      this.FormBorderStyle = FormBorderStyle.FixedDialog;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = nameof (FrmAnfitriona);
      this.StartPosition = FormStartPosition.CenterScreen;
      this.Text = "Anfitriona";
      ((Control) this.TabControl_Data).ResumeLayout(false);
      this.TabPage_Listado.ResumeLayout(false);
      this.TabPage_Listado.PerformLayout();
      this.Panel_ButtonsActions.ResumeLayout(false);
      this.Panel_ButtonsLocation.ResumeLayout(false);
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

    internal virtual Label Label_Description { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual TextBox TextBox_Criterio { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Panel Panel_ButtonsLocation { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

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

    internal virtual CheckBox CheckBox_IsActive { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Label Label_IsActive { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

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

    internal virtual Button Button_KBoard_DesShort
    {
      get
      {
        return this._Button_KBoard_DesShort;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Button_KBoard_DesShort_Click);
        Button buttonKboardDesShort1 = this._Button_KBoard_DesShort;
        if (buttonKboardDesShort1 != null)
          buttonKboardDesShort1.Click -= eventHandler;
        this._Button_KBoard_DesShort = value;
        Button buttonKboardDesShort2 = this._Button_KBoard_DesShort;
        if (buttonKboardDesShort2 == null)
          return;
        buttonKboardDesShort2.Click += eventHandler;
      }
    }

    internal virtual TextBox TextBox_DesShort { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Label Label_DesShort { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

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

    internal virtual TextBox TextBox_Des { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Label Label_Id { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual TextBox TextBox_Id { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Button Button_KBoard_CodigoInterno
    {
      get
      {
        return this._Button_KBoard_CodigoInterno;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Button_KBoard_CodigoInterno_Click);
        Button kboardCodigoInterno1 = this._Button_KBoard_CodigoInterno;
        if (kboardCodigoInterno1 != null)
          kboardCodigoInterno1.Click -= eventHandler;
        this._Button_KBoard_CodigoInterno = value;
        Button kboardCodigoInterno2 = this._Button_KBoard_CodigoInterno;
        if (kboardCodigoInterno2 == null)
          return;
        kboardCodigoInterno2.Click += eventHandler;
      }
    }

    internal virtual TextBox TextBox_CodigoInterno { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Label Label1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual StatusStrip StatusStrip_Properties { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual ToolStripStatusLabel ToolStripStatusLabel_Operation { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual ToolStripStatusLabel Tssl_Record { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual ToolStripStatusLabel ToolStripStatusLabel_OperationText { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual CheckBox CheckBox_EsMarca { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Label Label2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    private void SetUpDataGridView()
    {
      ModGeneralFunctions.SetUpDataGridViewBasicNuevo(this.dgrvData);
      this.dgrvData.Columns.Add("AnfitrionaId", "Código");
      ModGeneralFunctions.SetUp_TextBoxColumn1((DataGridViewTextBoxColumn) this.dgrvData.Columns[0], "AnfitrionaId", (short) 70, "", false, DataGridViewContentAlignment.MiddleLeft, true);
      this.dgrvData.Columns.Add("AnfitrionaDes", "Anfitriona");
      ModGeneralFunctions.SetUp_TextBoxColumn1((DataGridViewTextBoxColumn) this.dgrvData.Columns[1], "AnfitrionaDes", (short) 350, "", true, DataGridViewContentAlignment.MiddleLeft, true);
      this.dgrvData.Columns.Add("AnfitrionaDesCorta", "Anfitriona");
      ModGeneralFunctions.SetUp_TextBoxColumn1((DataGridViewTextBoxColumn) this.dgrvData.Columns[2], "AnfitrionaDesCorta", (short) 180, "", false, DataGridViewContentAlignment.MiddleLeft, true);
      this.dgrvData.Columns.Add((DataGridViewColumn) new DataGridViewCheckBoxColumn());
      ModGeneralFunctions.SetUp_CheckBoxColumn1((DataGridViewCheckBoxColumn) this.dgrvData.Columns[3], "Activo", "EsActivo", (short) 60, "", false);
    }

    private void SelectITem()
    {
      ModGeneralVar.g_Str_RecordID = Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateIndexGet(this.dgrvData.DataSource, new object[1]
      {
        (object) this.dgrvData.CurrentRow.Index
      }, (string[]) null), (System.Type) null, "AnfitrionaId", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      ModGeneralVar.g_Str_RecordDes = Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateIndexGet(this.dgrvData.DataSource, new object[1]
      {
        (object) this.dgrvData.CurrentRow.Index
      }, (string[]) null), (System.Type) null, "AnfitrionaDes", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
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
        this.TextBox_Des.Focus();
      }
    }

    public bool DataGV_Validated()
    {
      return this.dgrvData.Rows.Count > 0;
    }

    private void ValidateData()
    {
      if (Operators.CompareString(this.TextBox_Des.Text, "", false) != 0)
        return;
      ModGeneralFunctions.MessageOk1("Ingrese Descripción");
      this.TextBox_Des.Focus();
    }

    private void SetOperation(string _Operation)
    {
      this.ToolStripStatusLabel_OperationText.Text = _Operation;
      if (Operators.CompareString(_Operation, StructApp.RECORD_CREATE, false) == 0)
      {
        this.TextBox_Id.Text = "";
        this.TextBox_Des.Text = "";
        this.TextBox_DesShort.Text = "";
        this.TextBox_CodigoInterno.Text = "";
        this.CheckBox_IsActive.Checked = true;
        ((TabControl) this.TabControl_Data).SelectedIndex = 1;
        this.TextBox_Des.Focus();
      }
      else if (Operators.CompareString(_Operation, StructApp.RECORD_EDIT, false) == 0)
      {
        this.TextBox_Id.Text = Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateIndexGet(this.dgrvData.DataSource, new object[1]
        {
          (object) this.dgrvData.CurrentRow.Index
        }, (string[]) null), (System.Type) null, "AnfitrionaId", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
        this.TextBox_Des.Text = Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateIndexGet(this.dgrvData.DataSource, new object[1]
        {
          (object) this.dgrvData.CurrentRow.Index
        }, (string[]) null), (System.Type) null, "AnfitrionaDes", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
        this.TextBox_DesShort.Text = Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateIndexGet(this.dgrvData.DataSource, new object[1]
        {
          (object) this.dgrvData.CurrentRow.Index
        }, (string[]) null), (System.Type) null, "AnfitrionaDesCorta", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
        this.CheckBox_IsActive.Checked = (Conversions.ToBoolean(NewLateBinding.LateGet(NewLateBinding.LateIndexGet(this.dgrvData.DataSource, new object[1]
        {
          (object) this.dgrvData.CurrentRow.Index
        }, (string[]) null), (System.Type) null, "EsActivo", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null)) ? 1 : 0) != 0;
        this.TextBox_CodigoInterno.Text = Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateIndexGet(this.dgrvData.DataSource, new object[1]
        {
          (object) this.dgrvData.CurrentRow.Index
        }, (string[]) null), (System.Type) null, "CodigoInterno", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
        this.CheckBox_EsMarca.Checked = (Conversions.ToBoolean(NewLateBinding.LateGet(NewLateBinding.LateIndexGet(this.dgrvData.DataSource, new object[1]
        {
          (object) this.dgrvData.CurrentRow.Index
        }, (string[]) null), (System.Type) null, "EsMarca", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null)) ? 1 : 0) != 0;
        ((TabControl) this.TabControl_Data).SelectedIndex = 1;
        this.FirstTab((short) 1, _Operation);
        this.TextBox_Des.Focus();
      }
      else
      {
        if (Operators.CompareString(_Operation, StructApp.RECORD_DELETE, false) != 0)
          return;
        this.TextBox_Id.Text = Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateIndexGet(this.dgrvData.DataSource, new object[1]
        {
          (object) this.dgrvData.CurrentRow.Index
        }, (string[]) null), (System.Type) null, "AnfitrionaId", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
        this.TextBox_Des.Text = Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateIndexGet(this.dgrvData.DataSource, new object[1]
        {
          (object) this.dgrvData.CurrentRow.Index
        }, (string[]) null), (System.Type) null, "AnfitrionaDes", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
        this.MakeOperation(this.ToolStripStatusLabel_OperationText.Text);
      }
    }

    private void MakeOperation(string _Operation)
    {
      BL_TR1_ANFITRIONA blTr1Anfitriona = new BL_TR1_ANFITRIONA();
      BE_TR1_ANFITRIONA beTr1Anfitriona1;
      if (_Operation.Equals(StructApp.RECORD_CREATE))
      {
        this.ValidateData();
        if (!ModGeneralFunctions.MessageMakeAction1("¿Esta Seguro de Grabar el Registro?", false))
          return;
        BE_TR1_ANFITRIONA beTr1Anfitriona2 = new BE_TR1_ANFITRIONA();
        beTr1Anfitriona2.set_LocalId(ModGeneralVar.g_BE_TR1_VARIABLES_B.get_EstabliId());
        beTr1Anfitriona2.set_AnfitrionaDes(this.TextBox_Des.Text);
        beTr1Anfitriona2.set_AnfitrionaDesCorta(this.TextBox_DesShort.Text);
        beTr1Anfitriona2.set_EsActivo((uint) this.CheckBox_IsActive.CheckState > 0U);
        beTr1Anfitriona2.set_CodigoInterno(this.TextBox_CodigoInterno.Text);
        beTr1Anfitriona2.set_EsMarca((uint) this.CheckBox_EsMarca.CheckState > 0U);
        beTr1Anfitriona2.set_UsuReg(ModGeneralVar.g_BE_USERS.get_UserId());
        if (blTr1Anfitriona.VerifyDesExist(beTr1Anfitriona2))
        {
          ModGeneralFunctions.MessageOk1("EL NOMBRE DEL " + beTr1Anfitriona2.get_AnfitrionaDes() + " YA EXISTE");
          this.TextBox_Des.Focus();
        }
        else
        {
          this.str_Result = this.o_BL_ANFITRIONA.Insertar(beTr1Anfitriona2);
          if (this.str_Result.Equals(StructApp.RESULT_OK))
          {
            this.LoadData();
            this.Ubicate_Record(Conversions.ToString(beTr1Anfitriona2.get_AnfitrionaId()));
            ModGeneralFunctions.MessageOk1("[Registro Creado]");
            this.Information_Quantity_Of_Records();
          }
          else
            ModGeneralFunctions.MessageError_Large(this.str_Result, true);
          beTr1Anfitriona1 = (BE_TR1_ANFITRIONA) null;
          this.FirstTab((short) 0, "Listado de Anfitrionas");
        }
      }
      else if (_Operation.Equals(StructApp.RECORD_EDIT))
      {
        this.ValidateData();
        if (!ModGeneralFunctions.MessageMakeAction1("¿Esta Seguro de Editar el Registro?", false))
          return;
        BE_TR1_ANFITRIONA beTr1Anfitriona2 = new BE_TR1_ANFITRIONA();
        beTr1Anfitriona2.set_LocalId(ModGeneralVar.g_BE_TR1_VARIABLES_B.get_EstabliId());
        beTr1Anfitriona2.set_AnfitrionaId(Conversions.ToInteger(this.TextBox_Id.Text));
        beTr1Anfitriona2.set_AnfitrionaDes(this.TextBox_Des.Text);
        beTr1Anfitriona2.set_AnfitrionaDesCorta(this.TextBox_DesShort.Text);
        beTr1Anfitriona2.set_EsActivo((uint) this.CheckBox_IsActive.CheckState > 0U);
        beTr1Anfitriona2.set_CodigoInterno(this.TextBox_CodigoInterno.Text);
        beTr1Anfitriona2.set_EsMarca((uint) this.CheckBox_EsMarca.CheckState > 0U);
        beTr1Anfitriona2.set_UsuMod(ModGeneralVar.g_BE_USERS.get_UserId());
        if (blTr1Anfitriona.VerifyDesExist(beTr1Anfitriona2))
        {
          ModGeneralFunctions.MessageOk1("EL NOMBRE DE LA ANFITRIONA YA EXISTE");
          this.TextBox_Des.Focus();
        }
        else
        {
          this.str_Result = this.o_BL_ANFITRIONA.Editar(beTr1Anfitriona2);
          if (this.str_Result.Equals(StructApp.RESULT_OK))
          {
            short index = checked ((short) this.dgrvData.CurrentRow.Index);
            this.LoadDataByDes(this.TextBox_Criterio.Text);
            if (this.DataGV_Validated())
              this.dgrvData.CurrentCell = this.dgrvData[1, (int) index];
            ModGeneralFunctions.MessageOk1("[Registro Editado]");
            this.Information_Quantity_Of_Records();
          }
          else
            ModGeneralFunctions.MessageError_Large(this.str_Result, true);
          beTr1Anfitriona1 = (BE_TR1_ANFITRIONA) null;
          this.FirstTab((short) 0, "Listado de Anfitrionas");
        }
      }
      else if (_Operation.Equals(StructApp.RECORD_DELETE))
      {
        if (!ModGeneralFunctions.MessageMakeAction_Large("¿Seguro de Eliminar al : -" + this.TextBox_Des.Text + "- ?"))
          return;
        this.str_Result = this.o_BL_ANFITRIONA.Eliminar(ModGeneralVar.g_BE_TR1_VARIABLES_B.get_EstabliId(), this.TextBox_Id.Text);
        if (this.str_Result.Equals(StructApp.RESULT_OK))
        {
          short index = checked ((short) this.dgrvData.CurrentRow.Index);
          this.LoadData();
          if (this.dgrvData.Rows.Count > 1 & index > (short) 1)
            this.dgrvData.CurrentCell = this.dgrvData[1, checked ((int) index - 1)];
          ModGeneralFunctions.MessageOk1("[Registro Eliminado]");
          this.Information_Quantity_Of_Records();
        }
        else
          ModGeneralFunctions.MessageError_Large(this.str_Result, true);
        this.FirstTab((short) 0, "Listado de Anfitrionas");
      }
      else
      {
        if (!_Operation.Equals(StructApp.RECORD_SEARCH))
          return;
        this.LoadDataByDes(this.TextBox_Criterio.Text);
        this.FirstTab((short) 0, "Listado de Anfitrionas");
        this.Information_Quantity_Of_Records();
      }
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
        }, (string[]) null), (System.Type) null, "AnfitrionaId", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null)).Equals(_ItemToUbicate))
        {
          this.dgrvData.CurrentCell = this.dgrvData[1, index];
          break;
        }
        checked { ++index; }
      }
    }

    private void LoadData()
    {
      this.dgrvData.DataSource = (object) this.o_BL_ANFITRIONA.Lista(0);
      this.Information_Quantity_Of_Records();
      this.FirstTab((short) 0, "Listado de Anfitrionas");
    }

    private void LoadDataByDes(string _Des)
    {
      this.dgrvData.DataSource = (object) this.o_BL_ANFITRIONA.ListaporDes(ModGeneralVar.g_BE_TR1_VARIABLES_B.get_EstabliId(), _Des);
      this.FirstTab((short) 0, "Listado de Anfitrionas");
    }

    private void FrmAnfitriona_Load(object sender, EventArgs e)
    {
      this.Button_Ready.Visible = this._OnlySearch;
      this.SetUpDataGridView();
      this.LoadData();
    }

    private void Button_First_Click(object sender, EventArgs e)
    {
      if (this.dgrvData.Rows.Count <= 0)
        return;
      this.dgrvData.CurrentCell = this.dgrvData[1, 0];
      this.SelectITem();
      this.Information_Quantity_Of_Records();
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

    private void dgrvData_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
    {
      if (this._OnlySearch)
      {
        if (!this.DataGV_Validated())
          return;
        this.SelectITem();
        ModGeneralVar.g_bol_IsReady = true;
        this.Close();
      }
      else if (this.DataGV_Validated())
        this.SetOperation(StructApp.RECORD_EDIT);
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
      this.SelectITem();
      ModGeneralVar.g_bol_IsReady = true;
      this.Close();
    }

    private void Button_New_Click(object sender, EventArgs e)
    {
      this.SetOperation(StructApp.RECORD_CREATE);
      this.FirstTab((short) 1, "Crear Registro");
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

    private void Button_CloseTab_Click(object sender, EventArgs e)
    {
      this.FirstTab((short) 0, "Listado de Anfitrionas");
    }

    private void Button_Save_Click(object sender, EventArgs e)
    {
      this.MakeOperation(this.ToolStripStatusLabel_OperationText.Text);
    }

    private void Button_KBoard_CodigoInterno_Click(object sender, EventArgs e)
    {
      TextBox boxCodigoInterno;
      string text = (boxCodigoInterno = this.TextBox_CodigoInterno).Text;
      ModGeneralFunctions.TextKeyBoard("Ingrese Codigo Interno", ref text);
      boxCodigoInterno.Text = text;
      if (Strings.Len(ModGeneralVar.g_str_InputValue) <= 0)
        return;
      this.TextBox_DesShort.Text = ModGeneralVar.g_str_InputValue;
    }

    private void Button_KBoard_DesShort_Click(object sender, EventArgs e)
    {
      TextBox textBoxDesShort;
      string text = (textBoxDesShort = this.TextBox_DesShort).Text;
      ModGeneralFunctions.TextKeyBoard("Ingrese La Descripción Corta", ref text);
      textBoxDesShort.Text = text;
      if (Strings.Len(ModGeneralVar.g_str_InputValue) <= 0)
        return;
      this.TextBox_DesShort.Text = ModGeneralVar.g_str_InputValue;
    }

    private void Button_KBoard_Des_Click(object sender, EventArgs e)
    {
      TextBox textBoxDes;
      string text = (textBoxDes = this.TextBox_Des).Text;
      ModGeneralFunctions.TextKeyBoard("Ingrese Descripción", ref text);
      textBoxDes.Text = text;
      if (Strings.Len(ModGeneralVar.g_str_InputValue) > 0)
        this.TextBox_Des.Text = ModGeneralVar.g_str_InputValue;
      this.TextBox_DesShort.Focus();
    }

    private void Button_GoOut_Click(object sender, EventArgs e)
    {
      ModGeneralVar.g_bol_IsReady = false;
      this.Close();
    }
  }
}
