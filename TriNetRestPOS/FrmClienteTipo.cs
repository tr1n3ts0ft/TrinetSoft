// Decompiled with JetBrains decompiler
// Type: TriNetRestPOS.FrmClienteTipo
// Assembly: TriNetRestPOS, Version=5.2.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 43377352-E952-4AC1-9BA6-CCBE4AE5F575
// Assembly location: C:\log\TriNetRestPOS.exe

using APP_Utilities;
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
  public class FrmClienteTipo : Form
  {
    private IContainer components;
    public bool _OnlySearch;

    public FrmClienteTipo()
    {
      this.Load += new EventHandler(this.FrmClienteTipo_Load);
      this.KeyDown += new KeyEventHandler(this.FrmClienteTipo_KeyDown);
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
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (FrmClienteTipo));
      this.CheckBox_IsActive = new CheckBox();
      this.Label_IsActive = new Label();
      this.Button_Save = new Button();
      this.Button_KBoard_DesShort = new Button();
      this.TabControl_Data = new TabControlEx();
      this.TabPage_Listado = new TabPage();
      this.Panel_ButtonsActions = new Panel();
      this.Button_KBoardCriterio = new Button();
      this.Button_Ready = new Button();
      this.Label_Description = new Label();
      this.Panel_ButtonsTools = new Panel();
      this.Button_First = new Button();
      this.Button_GoOut = new Button();
      this.Button_Back = new Button();
      this.Button_Delete = new Button();
      this.Button_Forward = new Button();
      this.Button_Update = new Button();
      this.Button_Last = new Button();
      this.Button_New = new Button();
      this.TextBox_Criterio = new TextBox();
      this.dgrvData = new DataGridView();
      this.TabPage_Detail = new TabPage();
      this.Button_CloseTab = new Button();
      this.TextBox_DesShort = new TextBox();
      this.Label_DesShort = new Label();
      this.Button_KBoard_Des = new Button();
      this.Label_Des = new Label();
      this.TextBox_Des = new TextBox();
      this.Label_Id = new Label();
      this.TextBox_Id = new TextBox();
      this.ToolStripStatusLabel_Operation = new ToolStripStatusLabel();
      this.StatusStrip_Properties = new StatusStrip();
      this.Tssl_Record = new ToolStripStatusLabel();
      ((Control) this.TabControl_Data).SuspendLayout();
      this.TabPage_Listado.SuspendLayout();
      this.Panel_ButtonsActions.SuspendLayout();
      this.Panel_ButtonsTools.SuspendLayout();
      ((ISupportInitialize) this.dgrvData).BeginInit();
      this.TabPage_Detail.SuspendLayout();
      this.StatusStrip_Properties.SuspendLayout();
      this.SuspendLayout();
      this.CheckBox_IsActive.AutoSize = true;
      this.CheckBox_IsActive.FlatStyle = FlatStyle.Flat;
      this.CheckBox_IsActive.Font = new Font("Trebuchet MS", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.CheckBox_IsActive.Location = new Point(147, 329);
      this.CheckBox_IsActive.Name = "CheckBox_IsActive";
      this.CheckBox_IsActive.Size = new Size(12, 11);
      this.CheckBox_IsActive.TabIndex = 7;
      this.CheckBox_IsActive.UseVisualStyleBackColor = true;
      this.Label_IsActive.AutoSize = true;
      this.Label_IsActive.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Label_IsActive.ForeColor = Color.FromArgb(150, 150, 150);
      this.Label_IsActive.Location = new Point(28, 324);
      this.Label_IsActive.Name = "Label_IsActive";
      this.Label_IsActive.Size = new Size(55, 16);
      this.Label_IsActive.TabIndex = 163;
      this.Label_IsActive.Text = "Activo:";
      this.Button_Save.BackgroundImage = (Image) TriNetRestPOS.My.Resources.Resources.BotonVerde;
      this.Button_Save.FlatStyle = FlatStyle.Flat;
      this.Button_Save.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Button_Save.ForeColor = Color.WhiteSmoke;
      this.Button_Save.Image = (Image) TriNetRestPOS.My.Resources.Resources.check_OK;
      this.Button_Save.ImageAlign = ContentAlignment.TopCenter;
      this.Button_Save.Location = new Point(186, 398);
      this.Button_Save.Name = "Button_Save";
      this.Button_Save.Padding = new Padding(0, 5, 0, 5);
      this.Button_Save.Size = new Size(119, 60);
      this.Button_Save.TabIndex = 8;
      this.Button_Save.Text = "Grabar";
      this.Button_Save.TextAlign = ContentAlignment.BottomCenter;
      this.Button_Save.UseVisualStyleBackColor = true;
      this.Button_KBoard_DesShort.BackgroundImage = (Image) TriNetRestPOS.My.Resources.Resources.teclado_icon;
      this.Button_KBoard_DesShort.FlatStyle = FlatStyle.Flat;
      this.Button_KBoard_DesShort.Font = new Font("Trebuchet MS", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Button_KBoard_DesShort.ForeColor = Color.WhiteSmoke;
      this.Button_KBoard_DesShort.ImageAlign = ContentAlignment.BottomCenter;
      this.Button_KBoard_DesShort.Location = new Point(326, 249);
      this.Button_KBoard_DesShort.Name = "Button_KBoard_DesShort";
      this.Button_KBoard_DesShort.Size = new Size(45, 27);
      this.Button_KBoard_DesShort.TabIndex = 4;
      this.Button_KBoard_DesShort.TextAlign = ContentAlignment.TopCenter;
      this.Button_KBoard_DesShort.UseVisualStyleBackColor = true;
      ((Control) this.TabControl_Data).Controls.Add((Control) this.TabPage_Listado);
      ((Control) this.TabControl_Data).Controls.Add((Control) this.TabPage_Detail);
      ((Control) this.TabControl_Data).Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      ((Control) this.TabControl_Data).Location = new Point(-2, 0);
      ((Control) this.TabControl_Data).Name = "TabControl_Data";
      ((TabControl) this.TabControl_Data).SelectedIndex = 0;
      ((Control) this.TabControl_Data).Size = new Size(457, 548);
      ((Control) this.TabControl_Data).TabIndex = 165;
      this.TabPage_Listado.Controls.Add((Control) this.Panel_ButtonsActions);
      this.TabPage_Listado.Controls.Add((Control) this.Label_Description);
      this.TabPage_Listado.Controls.Add((Control) this.Panel_ButtonsTools);
      this.TabPage_Listado.Controls.Add((Control) this.TextBox_Criterio);
      this.TabPage_Listado.Controls.Add((Control) this.dgrvData);
      this.TabPage_Listado.Font = new Font("Trebuchet MS", 11.25f, FontStyle.Bold);
      this.TabPage_Listado.Location = new Point(4, 25);
      this.TabPage_Listado.Name = "TabPage_Listado";
      this.TabPage_Listado.Padding = new Padding(3);
      this.TabPage_Listado.Size = new Size(449, 519);
      this.TabPage_Listado.TabIndex = 0;
      this.TabPage_Listado.Text = "Listado";
      this.TabPage_Listado.UseVisualStyleBackColor = true;
      this.Panel_ButtonsActions.Controls.Add((Control) this.Button_KBoardCriterio);
      this.Panel_ButtonsActions.Controls.Add((Control) this.Button_Ready);
      this.Panel_ButtonsActions.Location = new Point(196, 0);
      this.Panel_ButtonsActions.Name = "Panel_ButtonsActions";
      this.Panel_ButtonsActions.Size = new Size(166, 63);
      this.Panel_ButtonsActions.TabIndex = 162;
      this.Button_KBoardCriterio.BackgroundImage = (Image) TriNetRestPOS.My.Resources.Resources.teclado_icon;
      this.Button_KBoardCriterio.FlatStyle = FlatStyle.Flat;
      this.Button_KBoardCriterio.Font = new Font("Trebuchet MS", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Button_KBoardCriterio.ForeColor = Color.WhiteSmoke;
      this.Button_KBoardCriterio.ImageAlign = ContentAlignment.BottomCenter;
      this.Button_KBoardCriterio.Location = new Point(0, 32);
      this.Button_KBoardCriterio.Name = "Button_KBoardCriterio";
      this.Button_KBoardCriterio.Size = new Size(45, 27);
      this.Button_KBoardCriterio.TabIndex = 148;
      this.Button_KBoardCriterio.TextAlign = ContentAlignment.TopCenter;
      this.Button_KBoardCriterio.UseVisualStyleBackColor = true;
      this.Button_Ready.BackgroundImage = (Image) TriNetRestPOS.My.Resources.Resources.boton_guardar;
      this.Button_Ready.FlatStyle = FlatStyle.Flat;
      this.Button_Ready.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Button_Ready.ForeColor = Color.WhiteSmoke;
      this.Button_Ready.Image = (Image) TriNetRestPOS.My.Resources.Resources.check_OK;
      this.Button_Ready.ImageAlign = ContentAlignment.TopCenter;
      this.Button_Ready.Location = new Point(83, 3);
      this.Button_Ready.Name = "Button_Ready";
      this.Button_Ready.Padding = new Padding(0, 5, 0, 5);
      this.Button_Ready.Size = new Size(74, 57);
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
      this.Label_Description.Size = new Size(83, 16);
      this.Label_Description.TabIndex = 147;
      this.Label_Description.Text = "Descripción:";
      this.Panel_ButtonsTools.Controls.Add((Control) this.Button_First);
      this.Panel_ButtonsTools.Controls.Add((Control) this.Button_GoOut);
      this.Panel_ButtonsTools.Controls.Add((Control) this.Button_Back);
      this.Panel_ButtonsTools.Controls.Add((Control) this.Button_Delete);
      this.Panel_ButtonsTools.Controls.Add((Control) this.Button_Forward);
      this.Panel_ButtonsTools.Controls.Add((Control) this.Button_Update);
      this.Panel_ButtonsTools.Controls.Add((Control) this.Button_Last);
      this.Panel_ButtonsTools.Controls.Add((Control) this.Button_New);
      this.Panel_ButtonsTools.Location = new Point(362, 2);
      this.Panel_ButtonsTools.Name = "Panel_ButtonsTools";
      this.Panel_ButtonsTools.Size = new Size(87, 513);
      this.Panel_ButtonsTools.TabIndex = 146;
      this.Button_First.BackgroundImage = (Image) componentResourceManager.GetObject("Button_First.BackgroundImage");
      this.Button_First.FlatStyle = FlatStyle.Flat;
      this.Button_First.Font = new Font("Verdana", 18f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Button_First.ForeColor = Color.WhiteSmoke;
      this.Button_First.Image = (Image) TriNetRestPOS.My.Resources.Resources.flecha_inicio;
      this.Button_First.Location = new Point(8, 252);
      this.Button_First.Name = "Button_First";
      this.Button_First.RightToLeft = RightToLeft.Yes;
      this.Button_First.Size = new Size(69, 65);
      this.Button_First.TabIndex = 32;
      this.Button_First.UseVisualStyleBackColor = true;
      this.Button_GoOut.BackgroundImage = (Image) TriNetRestPOS.My.Resources.Resources.boton_rojo;
      this.Button_GoOut.FlatStyle = FlatStyle.Flat;
      this.Button_GoOut.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Button_GoOut.ForeColor = Color.WhiteSmoke;
      this.Button_GoOut.Image = (Image) TriNetRestPOS.My.Resources.Resources.salir;
      this.Button_GoOut.ImageAlign = ContentAlignment.TopCenter;
      this.Button_GoOut.Location = new Point(2, 1);
      this.Button_GoOut.Name = "Button_GoOut";
      this.Button_GoOut.Padding = new Padding(0, 5, 0, 5);
      this.Button_GoOut.Size = new Size(74, 57);
      this.Button_GoOut.TabIndex = 161;
      this.Button_GoOut.Text = "Salir";
      this.Button_GoOut.TextAlign = ContentAlignment.BottomCenter;
      this.Button_GoOut.UseVisualStyleBackColor = true;
      this.Button_Back.BackgroundImage = (Image) componentResourceManager.GetObject("Button_Back.BackgroundImage");
      this.Button_Back.FlatStyle = FlatStyle.Flat;
      this.Button_Back.Font = new Font("Verdana", 18f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Button_Back.ForeColor = Color.WhiteSmoke;
      this.Button_Back.Image = (Image) TriNetRestPOS.My.Resources.Resources.flecha_arriba;
      this.Button_Back.Location = new Point(8, 316);
      this.Button_Back.Name = "Button_Back";
      this.Button_Back.RightToLeft = RightToLeft.Yes;
      this.Button_Back.Size = new Size(69, 65);
      this.Button_Back.TabIndex = 33;
      this.Button_Back.UseVisualStyleBackColor = true;
      this.Button_Delete.BackgroundImage = (Image) TriNetRestPOS.My.Resources.Resources.boton_cuadrado_rojo;
      this.Button_Delete.FlatStyle = FlatStyle.Flat;
      this.Button_Delete.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Button_Delete.ForeColor = Color.WhiteSmoke;
      this.Button_Delete.Image = (Image) TriNetRestPOS.My.Resources.Resources.eliminar_icono;
      this.Button_Delete.ImageAlign = ContentAlignment.TopCenter;
      this.Button_Delete.Location = new Point(8, 188);
      this.Button_Delete.Name = "Button_Delete";
      this.Button_Delete.Padding = new Padding(0, 5, 0, 5);
      this.Button_Delete.RightToLeft = RightToLeft.Yes;
      this.Button_Delete.Size = new Size(69, 65);
      this.Button_Delete.TabIndex = 148;
      this.Button_Delete.Text = "Eliminar";
      this.Button_Delete.TextAlign = ContentAlignment.BottomCenter;
      this.Button_Delete.UseVisualStyleBackColor = true;
      this.Button_Forward.BackgroundImage = (Image) componentResourceManager.GetObject("Button_Forward.BackgroundImage");
      this.Button_Forward.FlatStyle = FlatStyle.Flat;
      this.Button_Forward.Font = new Font("Verdana", 18f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Button_Forward.ForeColor = Color.WhiteSmoke;
      this.Button_Forward.Image = (Image) TriNetRestPOS.My.Resources.Resources.flecha_abajo;
      this.Button_Forward.Location = new Point(8, 380);
      this.Button_Forward.Name = "Button_Forward";
      this.Button_Forward.RightToLeft = RightToLeft.Yes;
      this.Button_Forward.Size = new Size(69, 65);
      this.Button_Forward.TabIndex = 34;
      this.Button_Forward.UseVisualStyleBackColor = true;
      this.Button_Update.BackgroundImage = (Image) componentResourceManager.GetObject("Button_Update.BackgroundImage");
      this.Button_Update.FlatStyle = FlatStyle.Flat;
      this.Button_Update.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Button_Update.ForeColor = Color.WhiteSmoke;
      this.Button_Update.Image = (Image) TriNetRestPOS.My.Resources.Resources.icono_editar;
      this.Button_Update.ImageAlign = ContentAlignment.TopCenter;
      this.Button_Update.Location = new Point(8, 124);
      this.Button_Update.Name = "Button_Update";
      this.Button_Update.Padding = new Padding(0, 5, 0, 5);
      this.Button_Update.Size = new Size(69, 65);
      this.Button_Update.TabIndex = 147;
      this.Button_Update.Text = "Editar";
      this.Button_Update.TextAlign = ContentAlignment.BottomCenter;
      this.Button_Update.UseVisualStyleBackColor = true;
      this.Button_Last.BackgroundImage = (Image) componentResourceManager.GetObject("Button_Last.BackgroundImage");
      this.Button_Last.FlatStyle = FlatStyle.Flat;
      this.Button_Last.Font = new Font("Verdana", 18f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Button_Last.ForeColor = Color.WhiteSmoke;
      this.Button_Last.Image = (Image) TriNetRestPOS.My.Resources.Resources.flecha_final;
      this.Button_Last.Location = new Point(9, 444);
      this.Button_Last.Name = "Button_Last";
      this.Button_Last.RightToLeft = RightToLeft.Yes;
      this.Button_Last.Size = new Size(69, 65);
      this.Button_Last.TabIndex = 35;
      this.Button_Last.UseVisualStyleBackColor = true;
      this.Button_New.BackgroundImage = (Image) TriNetRestPOS.My.Resources.Resources.boton_nuevo;
      this.Button_New.FlatStyle = FlatStyle.Flat;
      this.Button_New.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Button_New.ForeColor = Color.WhiteSmoke;
      this.Button_New.Image = (Image) TriNetRestPOS.My.Resources.Resources.icono_nuevo;
      this.Button_New.ImageAlign = ContentAlignment.TopCenter;
      this.Button_New.Location = new Point(8, 60);
      this.Button_New.Name = "Button_New";
      this.Button_New.Padding = new Padding(0, 5, 0, 5);
      this.Button_New.Size = new Size(69, 65);
      this.Button_New.TabIndex = 146;
      this.Button_New.Text = "Nuevo";
      this.Button_New.TextAlign = ContentAlignment.BottomCenter;
      this.Button_New.UseVisualStyleBackColor = true;
      this.TextBox_Criterio.BorderStyle = BorderStyle.FixedSingle;
      this.TextBox_Criterio.Font = new Font("Trebuchet MS", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.TextBox_Criterio.Location = new Point(4, 34);
      this.TextBox_Criterio.MaxLength = 35;
      this.TextBox_Criterio.Multiline = true;
      this.TextBox_Criterio.Name = "TextBox_Criterio";
      this.TextBox_Criterio.Size = new Size(187, 24);
      this.TextBox_Criterio.TabIndex = 0;
      this.dgrvData.BorderStyle = BorderStyle.Fixed3D;
      this.dgrvData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dgrvData.Location = new Point(0, 63);
      this.dgrvData.MultiSelect = false;
      this.dgrvData.Name = "dgrvData";
      this.dgrvData.ScrollBars = ScrollBars.None;
      this.dgrvData.Size = new Size(362, 453);
      this.dgrvData.TabIndex = 1;
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
      this.TabPage_Detail.Font = new Font("Trebuchet MS", 11.25f, FontStyle.Bold);
      this.TabPage_Detail.Location = new Point(4, 25);
      this.TabPage_Detail.Name = "TabPage_Detail";
      this.TabPage_Detail.Padding = new Padding(3);
      this.TabPage_Detail.Size = new Size(449, 519);
      this.TabPage_Detail.TabIndex = 1;
      this.TabPage_Detail.Text = "Mantenimiento";
      this.TabPage_Detail.UseVisualStyleBackColor = true;
      this.Button_CloseTab.BackgroundImage = (Image) TriNetRestPOS.My.Resources.Resources.BotonRojo;
      this.Button_CloseTab.FlatStyle = FlatStyle.Flat;
      this.Button_CloseTab.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Button_CloseTab.ForeColor = Color.WhiteSmoke;
      this.Button_CloseTab.Image = (Image) TriNetRestPOS.My.Resources.Resources.salir;
      this.Button_CloseTab.ImageAlign = ContentAlignment.TopCenter;
      this.Button_CloseTab.Location = new Point(309, 398);
      this.Button_CloseTab.Name = "Button_CloseTab";
      this.Button_CloseTab.Padding = new Padding(0, 5, 0, 5);
      this.Button_CloseTab.Size = new Size(114, 60);
      this.Button_CloseTab.TabIndex = 9;
      this.Button_CloseTab.Text = "Atrás";
      this.Button_CloseTab.TextAlign = ContentAlignment.BottomCenter;
      this.Button_CloseTab.UseVisualStyleBackColor = true;
      this.TextBox_DesShort.BorderStyle = BorderStyle.FixedSingle;
      this.TextBox_DesShort.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.TextBox_DesShort.Location = new Point(32, 250);
      this.TextBox_DesShort.MaxLength = 50;
      this.TextBox_DesShort.Multiline = true;
      this.TextBox_DesShort.Name = "TextBox_DesShort";
      this.TextBox_DesShort.Size = new Size(288, 26);
      this.TextBox_DesShort.TabIndex = 3;
      this.Label_DesShort.AutoSize = true;
      this.Label_DesShort.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Label_DesShort.ForeColor = Color.FromArgb(150, 150, 150);
      this.Label_DesShort.Location = new Point(28, 215);
      this.Label_DesShort.Name = "Label_DesShort";
      this.Label_DesShort.Size = new Size(136, 16);
      this.Label_DesShort.TabIndex = 155;
      this.Label_DesShort.Text = "Descripción Corta:";
      this.Button_KBoard_Des.BackgroundImage = (Image) TriNetRestPOS.My.Resources.Resources.teclado_icon;
      this.Button_KBoard_Des.FlatStyle = FlatStyle.Flat;
      this.Button_KBoard_Des.Font = new Font("Trebuchet MS", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Button_KBoard_Des.ForeColor = Color.WhiteSmoke;
      this.Button_KBoard_Des.ImageAlign = ContentAlignment.BottomCenter;
      this.Button_KBoard_Des.Location = new Point(326, 126);
      this.Button_KBoard_Des.Name = "Button_KBoard_Des";
      this.Button_KBoard_Des.Size = new Size(45, 27);
      this.Button_KBoard_Des.TabIndex = 2;
      this.Button_KBoard_Des.TextAlign = ContentAlignment.TopCenter;
      this.Button_KBoard_Des.UseVisualStyleBackColor = true;
      this.Label_Des.AutoSize = true;
      this.Label_Des.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Label_Des.ForeColor = Color.FromArgb(150, 150, 150);
      this.Label_Des.Location = new Point(28, 95);
      this.Label_Des.Name = "Label_Des";
      this.Label_Des.Size = new Size(95, 16);
      this.Label_Des.TabIndex = 151;
      this.Label_Des.Text = "Descripción:";
      this.TextBox_Des.BorderStyle = BorderStyle.FixedSingle;
      this.TextBox_Des.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.TextBox_Des.Location = new Point(32, 126);
      this.TextBox_Des.MaxLength = 100;
      this.TextBox_Des.Multiline = true;
      this.TextBox_Des.Name = "TextBox_Des";
      this.TextBox_Des.Size = new Size(288, 60);
      this.TextBox_Des.TabIndex = 1;
      this.Label_Id.AutoSize = true;
      this.Label_Id.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Label_Id.ForeColor = Color.FromArgb(150, 150, 150);
      this.Label_Id.Location = new Point(28, 53);
      this.Label_Id.Name = "Label_Id";
      this.Label_Id.Size = new Size(62, 16);
      this.Label_Id.TabIndex = 149;
      this.Label_Id.Text = "Código:";
      this.TextBox_Id.BackColor = Color.LightGray;
      this.TextBox_Id.BorderStyle = BorderStyle.FixedSingle;
      this.TextBox_Id.Enabled = false;
      this.TextBox_Id.Font = new Font("Trebuchet MS", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.TextBox_Id.Location = new Point(134, 54);
      this.TextBox_Id.Name = "TextBox_Id";
      this.TextBox_Id.ReadOnly = true;
      this.TextBox_Id.Size = new Size(100, 25);
      this.TextBox_Id.TabIndex = 148;
      this.TextBox_Id.TextAlign = HorizontalAlignment.Center;
      this.ToolStripStatusLabel_Operation.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.ToolStripStatusLabel_Operation.ForeColor = Color.Black;
      this.ToolStripStatusLabel_Operation.Name = "ToolStripStatusLabel_Operation";
      this.ToolStripStatusLabel_Operation.Size = new Size(17, 17);
      this.ToolStripStatusLabel_Operation.Text = "...";
      this.StatusStrip_Properties.BackColor = Color.Transparent;
      this.StatusStrip_Properties.Font = new Font("Trebuchet MS", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.StatusStrip_Properties.Items.AddRange(new ToolStripItem[2]
      {
        (ToolStripItem) this.ToolStripStatusLabel_Operation,
        (ToolStripItem) this.Tssl_Record
      });
      this.StatusStrip_Properties.Location = new Point(0, 547);
      this.StatusStrip_Properties.Name = "StatusStrip_Properties";
      this.StatusStrip_Properties.Size = new Size(453, 22);
      this.StatusStrip_Properties.TabIndex = 166;
      this.StatusStrip_Properties.Text = "StatusStrip1";
      this.Tssl_Record.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Tssl_Record.ForeColor = Color.Black;
      this.Tssl_Record.Name = "Tssl_Record";
      this.Tssl_Record.Size = new Size(421, 17);
      this.Tssl_Record.Spring = true;
      this.Tssl_Record.TextAlign = ContentAlignment.MiddleRight;
      this.AutoScaleDimensions = new SizeF(9f, 20f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.BackColor = SystemColors.Window;
      this.ClientSize = new Size(453, 569);
      this.ControlBox = false;
      this.Controls.Add((Control) this.TabControl_Data);
      this.Controls.Add((Control) this.StatusStrip_Properties);
      this.Font = new Font("Trebuchet MS", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.FormBorderStyle = FormBorderStyle.FixedDialog;
      this.KeyPreview = true;
      this.Margin = new Padding(4, 5, 4, 5);
      this.Name = nameof (FrmClienteTipo);
      this.ShowIcon = false;
      this.ShowInTaskbar = false;
      this.StartPosition = FormStartPosition.CenterScreen;
      this.Text = "Tipos de Cliente";
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

    internal virtual CheckBox CheckBox_IsActive { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Label Label_IsActive { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

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

    internal virtual Button Button_KBoard_DesShort { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

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

    internal virtual DataGridView dgrvData
    {
      get
      {
        return this._dgrvData;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        DataGridViewCellEventHandler cellEventHandler = new DataGridViewCellEventHandler(this.dgrvData_CellDoubleClick);
        DataGridView dgrvData1 = this._dgrvData;
        if (dgrvData1 != null)
          dgrvData1.CellDoubleClick -= cellEventHandler;
        this._dgrvData = value;
        DataGridView dgrvData2 = this._dgrvData;
        if (dgrvData2 == null)
          return;
        dgrvData2.CellDoubleClick += cellEventHandler;
      }
    }

    internal virtual TabPage TabPage_Detail { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

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

    internal virtual TextBox TextBox_DesShort { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Label Label_DesShort { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Button Button_KBoard_Des { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Label Label_Des { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual TextBox TextBox_Des { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Label Label_Id { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual TextBox TextBox_Id { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual ToolStripStatusLabel ToolStripStatusLabel_Operation { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual StatusStrip StatusStrip_Properties { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual ToolStripStatusLabel Tssl_Record { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    private void Button_GoOut_Click(object sender, EventArgs e)
    {
      ModGeneralVar.g_bol_IsReady = false;
      this.Close();
    }

    private void FrmClienteTipo_Load(object sender, EventArgs e)
    {
      this.SetUpDataGridView();
      this.Button_Ready.Visible = this._OnlySearch;
      this.FirstTab((short) 0, "");
      this.CargarTipos();
      this.TextBox_Criterio.Focus();
    }

    private void FrmClienteTipo_KeyDown(object sender, KeyEventArgs e)
    {
      if (!e.KeyValue.Equals(27))
        return;
      if (((TabControl) this.TabControl_Data).SelectedIndex == 0)
        this.Button_GoOut_Click((object) null, (EventArgs) null);
      else
        this.Button_CloseTab_Click((object) null, (EventArgs) null);
    }

    private void Button_Ready_Click(object sender, EventArgs e)
    {
      if (!this.DataGRV_Validated())
        return;
      this.SelectItem();
      ModGeneralVar.g_bol_IsReady = true;
      this.Close();
    }

    private void Button_New_Click(object sender, EventArgs e)
    {
      this.SetOperation(StructApp.RECORD_CREATE);
      this.FirstTab((short) 1, "Crear Registro");
    }

    private void Button_Save_Click(object sender, EventArgs e)
    {
      this.MakeOperation(this.ToolStripStatusLabel_Operation.Text);
    }

    private void Button_First_Click(object sender, EventArgs e)
    {
      if (this.dgrvData.Rows.Count <= 0)
        return;
      this.dgrvData.CurrentCell = this.dgrvData[1, 0];
      this.SelectItem();
      this.Information_Quantity_Of_Records();
    }

    private void Button_Last_Click(object sender, EventArgs e)
    {
      if (this.dgrvData.Rows.Count <= 0)
        return;
      this.dgrvData.CurrentCell = this.dgrvData[1, checked (this.dgrvData.Rows.Count - 1)];
      this.SelectItem();
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
        this.SelectItem();
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
        this.SelectItem();
        this.Information_Quantity_Of_Records();
      }
    }

    private void Button_Update_Click(object sender, EventArgs e)
    {
      if (!this.DataGRV_Validated())
        return;
      this.SetOperation(StructApp.RECORD_EDIT);
    }

    private void TextBox_Criterio_TextChanged(object sender, EventArgs e)
    {
      this.CargarTipos();
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

    private void Button_CloseTab_Click(object sender, EventArgs e)
    {
      this.FirstTab((short) 0, "Listado de U.Medida");
    }

    private void dgrvData_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
    {
      if (!this.DataGRV_Validated())
        return;
      if (this._OnlySearch)
      {
        this.SelectItem();
        ModGeneralVar.g_bol_IsReady = true;
        this.Close();
      }
      else
        this.Button_Update_Click((object) null, (EventArgs) null);
    }

    private void Button_Delete_Click(object sender, EventArgs e)
    {
      if (!this.DataGRV_Validated())
        return;
      this.SetOperation(StructApp.RECORD_DELETE);
    }

    private void SetUpDataGridView()
    {
      ModGeneralFunctions.SetUpDataGridViewBasicNuevo(this.dgrvData);
      this.dgrvData.Columns.Add("TipoClienteId", "Código");
      ModGeneralFunctions.SetUp_TextBoxColumn1((DataGridViewTextBoxColumn) this.dgrvData.Columns[0], "TipoClienteId", (short) 65, "", false, DataGridViewContentAlignment.MiddleLeft, true);
      this.dgrvData.Columns.Add("Nombre", "Nombre");
      ModGeneralFunctions.SetUp_TextBoxColumn1((DataGridViewTextBoxColumn) this.dgrvData.Columns[1], "Nombre", (short) 275, "", true, DataGridViewContentAlignment.MiddleLeft, true);
      this.dgrvData.Columns.Add((DataGridViewColumn) new DataGridViewCheckBoxColumn());
      ModGeneralFunctions.SetUp_CheckBoxColumn1((DataGridViewCheckBoxColumn) this.dgrvData.Columns[2], "Activo", "Activo", (short) 70, "", true);
    }

    private void SetOperation(string _Operation)
    {
      this.ToolStripStatusLabel_Operation.Text = _Operation;
      if (Operators.CompareString(_Operation, StructApp.RECORD_CREATE, false) == 0)
      {
        this.TextBox_Id.Text = "";
        this.TextBox_Des.Text = "";
        this.TextBox_DesShort.Text = "";
        this.CheckBox_IsActive.CheckState = CheckState.Checked;
        this.FirstTab((short) 1, "Crear Registro");
        this.TextBox_Des.Focus();
      }
      else if (Operators.CompareString(_Operation, StructApp.RECORD_EDIT, false) == 0)
      {
        this.TextBox_Id.Text = Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateIndexGet(this.dgrvData.DataSource, new object[1]
        {
          (object) this.dgrvData.CurrentRow.Index
        }, (string[]) null), (System.Type) null, "TipoClienteId", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
        this.TextBox_Des.Text = Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateIndexGet(this.dgrvData.DataSource, new object[1]
        {
          (object) this.dgrvData.CurrentRow.Index
        }, (string[]) null), (System.Type) null, "Nombre", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
        this.TextBox_DesShort.Text = Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateIndexGet(this.dgrvData.DataSource, new object[1]
        {
          (object) this.dgrvData.CurrentRow.Index
        }, (string[]) null), (System.Type) null, "NombreCorto", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
        this.CheckBox_IsActive.Checked = (Conversions.ToBoolean(NewLateBinding.LateGet(NewLateBinding.LateIndexGet(this.dgrvData.DataSource, new object[1]
        {
          (object) this.dgrvData.CurrentRow.Index
        }, (string[]) null), (System.Type) null, "Activo", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null)) ? 1 : 0) != 0;
        this.FirstTab((short) 1, "Editar Registro");
        this.TextBox_Des.Focus();
      }
      else
      {
        if (Operators.CompareString(_Operation, StructApp.RECORD_DELETE, false) != 0)
          return;
        this.TextBox_Id.Text = Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateIndexGet(this.dgrvData.DataSource, new object[1]
        {
          (object) this.dgrvData.CurrentRow.Index
        }, (string[]) null), (System.Type) null, "TipoClienteId", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
        this.TextBox_Des.Text = Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateIndexGet(this.dgrvData.DataSource, new object[1]
        {
          (object) this.dgrvData.CurrentRow.Index
        }, (string[]) null), (System.Type) null, "Nombre", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
        this.MakeOperation(this.ToolStripStatusLabel_Operation.Text);
      }
    }

    private void FirstTab(short _Index, string _Text)
    {
      this.ToolStripStatusLabel_Operation.Text = _Text;
      ((TabControl) this.TabControl_Data).SelectedIndex = (int) _Index;
      if (_Index == (short) 0)
      {
        this.ToolStripStatusLabel_Operation.Text = "Listado de Tipos de Cliente";
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

    private void MakeOperation(string _Operation)
    {
      BL_TR1_CLIENTE_TIPO blTr1ClienteTipo = new BL_TR1_CLIENTE_TIPO();
      string str1 = "";
      if (Operators.CompareString(_Operation, StructApp.RECORD_CREATE, false) == 0)
      {
        if (!this.ValidateData() || !ModGeneralFunctions.MessageMakeAction("¿Seguro de Grabar los Datos?", false))
          return;
        BE_TR1_CLIENTE_TIPO beTr1ClienteTipo = new BE_TR1_CLIENTE_TIPO();
        beTr1ClienteTipo.set_LocalId(ModGeneralVar.g_BE_TR1_VARIABLES_B.get_EstabliId());
        beTr1ClienteTipo.set_Nombre(this.TextBox_Des.Text);
        beTr1ClienteTipo.set_NombreCorto(this.TextBox_DesShort.Text);
        beTr1ClienteTipo.set_Activo(this.CheckBox_IsActive.Checked);
        beTr1ClienteTipo.set_UsuCrea(ModGeneralVar.g_BE_USERS.get_UserId());
        str1 = blTr1ClienteTipo.Insertar(ref beTr1ClienteTipo);
        this.CargarTipos();
        this.Ubicate_Record(beTr1ClienteTipo.get_TipoClienteId());
        this.Information_Quantity_Of_Records();
        ModGeneralFunctions.MessageOk("[Registro Creado]");
        this.FirstTab((short) 0, "Listado de U.Medida");
      }
      else if (Operators.CompareString(_Operation, StructApp.RECORD_EDIT, false) == 0)
      {
        if (!this.ValidateData() || !ModGeneralFunctions.MessageMakeAction("¿Esta Seguro de Editar el Registro?", false))
          return;
        BE_TR1_CLIENTE_TIPO beTr1ClienteTipo = new BE_TR1_CLIENTE_TIPO();
        beTr1ClienteTipo.set_LocalId(ModGeneralVar.g_BE_TR1_VARIABLES_B.get_EstabliId());
        beTr1ClienteTipo.set_TipoClienteId(Conversions.ToInteger(this.TextBox_Id.Text));
        beTr1ClienteTipo.set_Nombre(this.TextBox_Des.Text);
        beTr1ClienteTipo.set_NombreCorto(this.TextBox_DesShort.Text);
        beTr1ClienteTipo.set_Activo(this.CheckBox_IsActive.Checked);
        beTr1ClienteTipo.set_UsuModi(ModGeneralVar.g_BE_USERS.get_UserId());
        string str2 = blTr1ClienteTipo.Editar(beTr1ClienteTipo);
        if (Operators.CompareString(str2, StructApp.RESULT_OK, false) == 0)
        {
          short index = checked ((short) this.dgrvData.CurrentRow.Index);
          this.CargarTipos();
          this.Ubicate_Record(beTr1ClienteTipo.get_TipoClienteId());
          ModGeneralFunctions.MessageOk("[Registro Editado]");
        }
        else
          ModGeneralFunctions.MessageError_Large(str2, true);
        this.FirstTab((short) 0, "Listado de U.Medida");
      }
      else if (Operators.CompareString(_Operation, StructApp.RECORD_DELETE, false) == 0)
      {
        if (!ModGeneralFunctions.MessageMakeAction("¿Seguro de Eliminar la U. Medida: -" + this.TextBox_Des.Text + "- ?", false))
          return;
        string str2 = blTr1ClienteTipo.Eliminar(Conversions.ToInteger(this.TextBox_Id.Text), ModGeneralVar.g_BE_TR1_VARIABLES_B.get_EstabliId());
        if (Operators.CompareString(str2, StructApp.RESULT_OK, false) == 0)
        {
          short index = checked ((short) this.dgrvData.CurrentRow.Index);
          this.CargarTipos();
          if (this.dgrvData.Rows.Count > 1 & index > (short) 0)
            this.dgrvData.CurrentCell = this.dgrvData[1, checked ((int) index - 1)];
          this.Information_Quantity_Of_Records();
          ModGeneralFunctions.MessageOk("[Registro Eliminado]");
        }
        else
          ModGeneralFunctions.MessageError_Large(str2, true);
        this.FirstTab((short) 0, "");
      }
      else
      {
        if (Operators.CompareString(_Operation, StructApp.RECORD_SEARCH, false) != 0)
          return;
        this.CargarTipos();
        this.Information_Quantity_Of_Records();
      }
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
        }, (string[]) null), (System.Type) null, "TipoClienteId", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null)) == _ItemToUbicate)
        {
          this.dgrvData.CurrentCell = this.dgrvData[1, index];
          break;
        }
        checked { ++index; }
      }
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

    private void CargarTipos()
    {
      this.dgrvData.DataSource = (object) new BL_TR1_CLIENTE_TIPO().ListarTodo(ModGeneralVar.g_BE_TR1_VARIABLES_B.get_EstabliId(), this.TextBox_Criterio.Text.Trim());
    }

    private void SelectItem()
    {
      ModGeneralVar.g_Str_RecordID = Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateIndexGet(this.dgrvData.DataSource, new object[1]
      {
        (object) this.dgrvData.CurrentRow.Index
      }, (string[]) null), (System.Type) null, "TipoClienteId", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      ModGeneralVar.g_Str_RecordDes = Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateIndexGet(this.dgrvData.DataSource, new object[1]
      {
        (object) this.dgrvData.CurrentRow.Index
      }, (string[]) null), (System.Type) null, "Nombre", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
    }

    private bool ValidateData()
    {
      if (Operators.CompareString(this.TextBox_Des.Text, "", false) != 0)
        return true;
      ModGeneralFunctions.MessageOk("¡Ingrese un Nombre!");
      this.TextBox_Des.Focus();
      return false;
    }
  }
}
