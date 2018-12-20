// Decompiled with JetBrains decompiler
// Type: TriNetRestPOS.FrmAgentDelivery
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
  public class FrmAgentDelivery : Form
  {
    private IContainer components;
    public string _nameForm;
    public bool _OnlySearch;
    private string str_Result;
    private bool _IsValidate;
    private string Res_Code;
    private string Res_Description;
    private string Res_DescriptionS;
    private string Res_Active;
    private string Res_Observation;
    private string Res_MsgSave;

    public FrmAgentDelivery()
    {
      this.Load += new EventHandler(this.FrmAgentDelivery_Load);
      this.Activated += new EventHandler(this.FrmAgentDelivery_Activated);
      this._nameForm = "";
      this._OnlySearch = false;
      this.str_Result = "";
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
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (FrmAgentDelivery));
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
      this.Button_KBoard_Observation = new Button();
      this.Button_KBoard_DesShort = new Button();
      this.Button_KBoard_Des = new Button();
      this.TextBox_Observation = new TextBox();
      this.Label_Observation = new Label();
      this.TextBox_AgentDesShort = new TextBox();
      this.Label_DesShort = new Label();
      this.CheckBox_IsActive = new CheckBox();
      this.Label_IsActive = new Label();
      this.Button_CloseTab = new Button();
      this.Button_Save = new Button();
      this.Label_Des = new Label();
      this.TextBox_AgentDes = new TextBox();
      this.Label_Id = new Label();
      this.TextBox_Id = new TextBox();
      this.ToolStripStatusLabel_OperationText = new ToolStripStatusLabel();
      this.ToolStripStatusLabel_RecordsNumber = new ToolStripStatusLabel();
      this.ToolStripStatusLabel_RecordsText = new ToolStripStatusLabel();
      this.StatusStrip_Properties = new StatusStrip();
      this.ToolStripStatusLabel_Operation = new ToolStripStatusLabel();
      this.Tssl_Record = new ToolStripStatusLabel();
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
      ((Control) this.TabControl_Data).Location = new Point(1, 2);
      ((Control) this.TabControl_Data).Name = "TabControl_Data";
      ((TabControl) this.TabControl_Data).SelectedIndex = 0;
      ((Control) this.TabControl_Data).Size = new Size(536, 550);
      ((Control) this.TabControl_Data).TabIndex = 2;
      this.TabPage_Listado.Controls.Add((Control) this.Panel_ButtonsActions);
      this.TabPage_Listado.Controls.Add((Control) this.Label_Description);
      this.TabPage_Listado.Controls.Add((Control) this.TextBox_Criterio);
      this.TabPage_Listado.Controls.Add((Control) this.Panel_ButtonsLocation);
      this.TabPage_Listado.Controls.Add((Control) this.dgrvData);
      this.TabPage_Listado.Font = new Font("Verdana", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.TabPage_Listado.Location = new Point(4, 25);
      this.TabPage_Listado.Name = "TabPage_Listado";
      this.TabPage_Listado.Padding = new Padding(3);
      this.TabPage_Listado.Size = new Size(528, 521);
      this.TabPage_Listado.TabIndex = 0;
      this.TabPage_Listado.Text = "Listado";
      this.TabPage_Listado.UseVisualStyleBackColor = true;
      this.Panel_ButtonsActions.Controls.Add((Control) this.Button_KBoardCriterio);
      this.Panel_ButtonsActions.Controls.Add((Control) this.Button_GoOut);
      this.Panel_ButtonsActions.Controls.Add((Control) this.Button_Ready);
      this.Panel_ButtonsActions.Location = new Point(277, 2);
      this.Panel_ButtonsActions.Name = "Panel_ButtonsActions";
      this.Panel_ButtonsActions.Size = new Size(248, 63);
      this.Panel_ButtonsActions.TabIndex = 162;
      this.Button_KBoardCriterio.BackgroundImage = (Image) TriNetRestPOS.My.Resources.Resources.teclado_icon;
      this.Button_KBoardCriterio.FlatStyle = FlatStyle.Flat;
      this.Button_KBoardCriterio.Font = new Font("Trebuchet MS", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Button_KBoardCriterio.ForeColor = Color.WhiteSmoke;
      this.Button_KBoardCriterio.ImageAlign = ContentAlignment.BottomCenter;
      this.Button_KBoardCriterio.Location = new Point(0, 34);
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
      this.Button_GoOut.Location = new Point(94, 3);
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
      this.Button_Ready.Location = new Point(169, 3);
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
      this.Label_Description.Location = new Point(2, 19);
      this.Label_Description.Name = "Label_Description";
      this.Label_Description.Size = new Size(80, 16);
      this.Label_Description.TabIndex = 147;
      this.Label_Description.Text = "Descripción";
      this.TextBox_Criterio.BorderStyle = BorderStyle.FixedSingle;
      this.TextBox_Criterio.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.TextBox_Criterio.Location = new Point(3, 41);
      this.TextBox_Criterio.MaxLength = 50;
      this.TextBox_Criterio.Multiline = true;
      this.TextBox_Criterio.Name = "TextBox_Criterio";
      this.TextBox_Criterio.Size = new Size(268, 23);
      this.TextBox_Criterio.TabIndex = 0;
      this.Panel_ButtonsLocation.Controls.Add((Control) this.Button_Delete);
      this.Panel_ButtonsLocation.Controls.Add((Control) this.Button_First);
      this.Panel_ButtonsLocation.Controls.Add((Control) this.Button_Back);
      this.Panel_ButtonsLocation.Controls.Add((Control) this.Button_Update);
      this.Panel_ButtonsLocation.Controls.Add((Control) this.Button_Forward);
      this.Panel_ButtonsLocation.Controls.Add((Control) this.Button_Last);
      this.Panel_ButtonsLocation.Controls.Add((Control) this.Button_New);
      this.Panel_ButtonsLocation.Location = new Point(440, 66);
      this.Panel_ButtonsLocation.Name = "Panel_ButtonsLocation";
      this.Panel_ButtonsLocation.Size = new Size(86, 451);
      this.Panel_ButtonsLocation.TabIndex = 124;
      this.Button_Delete.BackgroundImage = (Image) TriNetRestPOS.My.Resources.Resources.boton_cuadrado_rojo;
      this.Button_Delete.FlatStyle = FlatStyle.Flat;
      this.Button_Delete.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Button_Delete.ForeColor = Color.WhiteSmoke;
      this.Button_Delete.Image = (Image) TriNetRestPOS.My.Resources.Resources.eliminar_icono;
      this.Button_Delete.ImageAlign = ContentAlignment.TopCenter;
      this.Button_Delete.Location = new Point(8, 128);
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
      this.Button_First.Location = new Point(8, 192);
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
      this.Button_Back.Location = new Point(8, 256);
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
      this.Button_Update.Location = new Point(8, 64);
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
      this.Button_Forward.Location = new Point(8, 320);
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
      this.Button_Last.Location = new Point(8, 384);
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
      this.Button_New.Location = new Point(8, 0);
      this.Button_New.Name = "Button_New";
      this.Button_New.Padding = new Padding(0, 5, 0, 5);
      this.Button_New.Size = new Size(69, 65);
      this.Button_New.TabIndex = 146;
      this.Button_New.Text = "&Nuevo";
      this.Button_New.TextAlign = ContentAlignment.BottomCenter;
      this.Button_New.UseVisualStyleBackColor = true;
      this.dgrvData.BorderStyle = BorderStyle.Fixed3D;
      this.dgrvData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dgrvData.Location = new Point(3, 67);
      this.dgrvData.MultiSelect = false;
      this.dgrvData.Name = "dgrvData";
      this.dgrvData.ScrollBars = ScrollBars.None;
      this.dgrvData.ShowRowErrors = false;
      this.dgrvData.Size = new Size(438, 450);
      this.dgrvData.StandardTab = true;
      this.dgrvData.TabIndex = 1;
      this.TabPage_Detail.Controls.Add((Control) this.Button_KBoard_Observation);
      this.TabPage_Detail.Controls.Add((Control) this.Button_KBoard_DesShort);
      this.TabPage_Detail.Controls.Add((Control) this.Button_KBoard_Des);
      this.TabPage_Detail.Controls.Add((Control) this.TextBox_Observation);
      this.TabPage_Detail.Controls.Add((Control) this.Label_Observation);
      this.TabPage_Detail.Controls.Add((Control) this.TextBox_AgentDesShort);
      this.TabPage_Detail.Controls.Add((Control) this.Label_DesShort);
      this.TabPage_Detail.Controls.Add((Control) this.CheckBox_IsActive);
      this.TabPage_Detail.Controls.Add((Control) this.Label_IsActive);
      this.TabPage_Detail.Controls.Add((Control) this.Button_CloseTab);
      this.TabPage_Detail.Controls.Add((Control) this.Button_Save);
      this.TabPage_Detail.Controls.Add((Control) this.Label_Des);
      this.TabPage_Detail.Controls.Add((Control) this.TextBox_AgentDes);
      this.TabPage_Detail.Controls.Add((Control) this.Label_Id);
      this.TabPage_Detail.Controls.Add((Control) this.TextBox_Id);
      this.TabPage_Detail.Location = new Point(4, 25);
      this.TabPage_Detail.Name = "TabPage_Detail";
      this.TabPage_Detail.Padding = new Padding(3);
      this.TabPage_Detail.Size = new Size(528, 521);
      this.TabPage_Detail.TabIndex = 1;
      this.TabPage_Detail.Text = "Mantenimiento";
      this.TabPage_Detail.UseVisualStyleBackColor = true;
      this.Button_KBoard_Observation.BackgroundImage = (Image) TriNetRestPOS.My.Resources.Resources.teclado_icon;
      this.Button_KBoard_Observation.FlatStyle = FlatStyle.Flat;
      this.Button_KBoard_Observation.Font = new Font("Trebuchet MS", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Button_KBoard_Observation.ForeColor = Color.WhiteSmoke;
      this.Button_KBoard_Observation.ImageAlign = ContentAlignment.BottomCenter;
      this.Button_KBoard_Observation.Location = new Point(420, 280);
      this.Button_KBoard_Observation.Name = "Button_KBoard_Observation";
      this.Button_KBoard_Observation.Size = new Size(45, 27);
      this.Button_KBoard_Observation.TabIndex = 6;
      this.Button_KBoard_Observation.TextAlign = ContentAlignment.TopCenter;
      this.Button_KBoard_Observation.UseVisualStyleBackColor = true;
      this.Button_KBoard_DesShort.BackgroundImage = (Image) TriNetRestPOS.My.Resources.Resources.teclado_icon;
      this.Button_KBoard_DesShort.FlatStyle = FlatStyle.Flat;
      this.Button_KBoard_DesShort.Font = new Font("Trebuchet MS", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Button_KBoard_DesShort.ForeColor = Color.WhiteSmoke;
      this.Button_KBoard_DesShort.ImageAlign = ContentAlignment.BottomCenter;
      this.Button_KBoard_DesShort.Location = new Point(420, 189);
      this.Button_KBoard_DesShort.Name = "Button_KBoard_DesShort";
      this.Button_KBoard_DesShort.Size = new Size(45, 27);
      this.Button_KBoard_DesShort.TabIndex = 4;
      this.Button_KBoard_DesShort.TextAlign = ContentAlignment.TopCenter;
      this.Button_KBoard_DesShort.UseVisualStyleBackColor = true;
      this.Button_KBoard_Des.BackgroundImage = (Image) TriNetRestPOS.My.Resources.Resources.teclado_icon;
      this.Button_KBoard_Des.FlatStyle = FlatStyle.Flat;
      this.Button_KBoard_Des.Font = new Font("Trebuchet MS", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Button_KBoard_Des.ForeColor = Color.WhiteSmoke;
      this.Button_KBoard_Des.ImageAlign = ContentAlignment.BottomCenter;
      this.Button_KBoard_Des.Location = new Point(420, 110);
      this.Button_KBoard_Des.Name = "Button_KBoard_Des";
      this.Button_KBoard_Des.Size = new Size(45, 27);
      this.Button_KBoard_Des.TabIndex = 2;
      this.Button_KBoard_Des.TextAlign = ContentAlignment.TopCenter;
      this.Button_KBoard_Des.UseVisualStyleBackColor = true;
      this.TextBox_Observation.BorderStyle = BorderStyle.FixedSingle;
      this.TextBox_Observation.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.TextBox_Observation.Location = new Point(19, 280);
      this.TextBox_Observation.MaxLength = 50;
      this.TextBox_Observation.Multiline = true;
      this.TextBox_Observation.Name = "TextBox_Observation";
      this.TextBox_Observation.Size = new Size(395, 81);
      this.TextBox_Observation.TabIndex = 5;
      this.Label_Observation.AutoSize = true;
      this.Label_Observation.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Label_Observation.ForeColor = Color.FromArgb(150, 150, 150);
      this.Label_Observation.Location = new Point(16, 252);
      this.Label_Observation.Name = "Label_Observation";
      this.Label_Observation.Size = new Size(85, 16);
      this.Label_Observation.TabIndex = 167;
      this.Label_Observation.Text = "Observación";
      this.TextBox_AgentDesShort.BorderStyle = BorderStyle.FixedSingle;
      this.TextBox_AgentDesShort.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.TextBox_AgentDesShort.Location = new Point(19, 192);
      this.TextBox_AgentDesShort.MaxLength = 30;
      this.TextBox_AgentDesShort.Multiline = true;
      this.TextBox_AgentDesShort.Name = "TextBox_AgentDesShort";
      this.TextBox_AgentDesShort.Size = new Size(395, 24);
      this.TextBox_AgentDesShort.TabIndex = 3;
      this.Label_DesShort.AutoSize = true;
      this.Label_DesShort.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Label_DesShort.ForeColor = Color.FromArgb(150, 150, 150);
      this.Label_DesShort.Location = new Point(16, 166);
      this.Label_DesShort.Name = "Label_DesShort";
      this.Label_DesShort.Size = new Size(115, 16);
      this.Label_DesShort.TabIndex = 165;
      this.Label_DesShort.Text = "Descripción Corta";
      this.CheckBox_IsActive.AutoSize = true;
      this.CheckBox_IsActive.FlatStyle = FlatStyle.Flat;
      this.CheckBox_IsActive.Font = new Font("Trebuchet MS", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.CheckBox_IsActive.Location = new Point(93, 401);
      this.CheckBox_IsActive.Name = "CheckBox_IsActive";
      this.CheckBox_IsActive.Size = new Size(12, 11);
      this.CheckBox_IsActive.TabIndex = 7;
      this.CheckBox_IsActive.UseVisualStyleBackColor = true;
      this.Label_IsActive.AutoSize = true;
      this.Label_IsActive.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Label_IsActive.ForeColor = Color.FromArgb(150, 150, 150);
      this.Label_IsActive.Location = new Point(21, 396);
      this.Label_IsActive.Name = "Label_IsActive";
      this.Label_IsActive.Size = new Size(48, 16);
      this.Label_IsActive.TabIndex = 163;
      this.Label_IsActive.Text = "Activo:";
      this.Button_CloseTab.BackgroundImage = (Image) TriNetRestPOS.My.Resources.Resources.BotonRojo;
      this.Button_CloseTab.FlatStyle = FlatStyle.Flat;
      this.Button_CloseTab.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Button_CloseTab.ForeColor = Color.WhiteSmoke;
      this.Button_CloseTab.Image = (Image) TriNetRestPOS.My.Resources.Resources.salir;
      this.Button_CloseTab.ImageAlign = ContentAlignment.TopCenter;
      this.Button_CloseTab.Location = new Point(357, 401);
      this.Button_CloseTab.Name = "Button_CloseTab";
      this.Button_CloseTab.Padding = new Padding(0, 5, 0, 5);
      this.Button_CloseTab.Size = new Size(114, 60);
      this.Button_CloseTab.TabIndex = 159;
      this.Button_CloseTab.Text = "Salir";
      this.Button_CloseTab.TextAlign = ContentAlignment.BottomCenter;
      this.Button_CloseTab.UseVisualStyleBackColor = true;
      this.Button_Save.BackgroundImage = (Image) TriNetRestPOS.My.Resources.Resources.BotonVerde;
      this.Button_Save.FlatStyle = FlatStyle.Flat;
      this.Button_Save.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Button_Save.ForeColor = Color.WhiteSmoke;
      this.Button_Save.Image = (Image) TriNetRestPOS.My.Resources.Resources.check_OK;
      this.Button_Save.ImageAlign = ContentAlignment.TopCenter;
      this.Button_Save.Location = new Point(237, 401);
      this.Button_Save.Name = "Button_Save";
      this.Button_Save.Padding = new Padding(0, 5, 0, 5);
      this.Button_Save.Size = new Size(119, 60);
      this.Button_Save.TabIndex = 8;
      this.Button_Save.Text = "Grabar";
      this.Button_Save.TextAlign = ContentAlignment.BottomCenter;
      this.Button_Save.UseVisualStyleBackColor = true;
      this.Label_Des.AutoSize = true;
      this.Label_Des.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Label_Des.ForeColor = Color.FromArgb(150, 150, 150);
      this.Label_Des.Location = new Point(16, 85);
      this.Label_Des.Name = "Label_Des";
      this.Label_Des.Size = new Size(83, 16);
      this.Label_Des.TabIndex = 151;
      this.Label_Des.Text = "Descripción:";
      this.TextBox_AgentDes.BorderStyle = BorderStyle.FixedSingle;
      this.TextBox_AgentDes.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.TextBox_AgentDes.Location = new Point(19, 113);
      this.TextBox_AgentDes.MaxLength = 50;
      this.TextBox_AgentDes.Multiline = true;
      this.TextBox_AgentDes.Name = "TextBox_AgentDes";
      this.TextBox_AgentDes.Size = new Size(395, 24);
      this.TextBox_AgentDes.TabIndex = 1;
      this.Label_Id.AutoSize = true;
      this.Label_Id.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Label_Id.ForeColor = Color.FromArgb(150, 150, 150);
      this.Label_Id.Location = new Point(16, 18);
      this.Label_Id.Name = "Label_Id";
      this.Label_Id.Size = new Size(55, 16);
      this.Label_Id.TabIndex = 149;
      this.Label_Id.Text = "Código:";
      this.TextBox_Id.AutoCompleteSource = AutoCompleteSource.FileSystem;
      this.TextBox_Id.BackColor = Color.LightGray;
      this.TextBox_Id.BorderStyle = BorderStyle.FixedSingle;
      this.TextBox_Id.Font = new Font("Trebuchet MS", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.TextBox_Id.Location = new Point(19, 44);
      this.TextBox_Id.Multiline = true;
      this.TextBox_Id.Name = "TextBox_Id";
      this.TextBox_Id.ReadOnly = true;
      this.TextBox_Id.Size = new Size(186, 24);
      this.TextBox_Id.TabIndex = 148;
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
      this.ToolStripStatusLabel_RecordsNumber.Size = new Size(40, 20);
      this.ToolStripStatusLabel_RecordsNumber.Text = "456";
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
      this.StatusStrip_Properties.Location = new Point(0, 548);
      this.StatusStrip_Properties.Name = "StatusStrip_Properties";
      this.StatusStrip_Properties.Size = new Size(537, 25);
      this.StatusStrip_Properties.TabIndex = 3;
      this.StatusStrip_Properties.Text = "StatusStrip1";
      this.ToolStripStatusLabel_Operation.Font = new Font("Trebuchet MS", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.ToolStripStatusLabel_Operation.ForeColor = Color.Black;
      this.ToolStripStatusLabel_Operation.Name = "ToolStripStatusLabel_Operation";
      this.ToolStripStatusLabel_Operation.Size = new Size(27, 20);
      this.ToolStripStatusLabel_Operation.Text = "...";
      this.Tssl_Record.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Tssl_Record.ForeColor = Color.Black;
      this.Tssl_Record.Name = "Tssl_Record";
      this.Tssl_Record.Size = new Size(495, 20);
      this.Tssl_Record.Spring = true;
      this.Tssl_Record.Text = "N° Record";
      this.Tssl_Record.TextAlign = ContentAlignment.MiddleRight;
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.BackColor = SystemColors.Window;
      this.ClientSize = new Size(537, 573);
      this.ControlBox = false;
      this.Controls.Add((Control) this.StatusStrip_Properties);
      this.Controls.Add((Control) this.TabControl_Data);
      this.FormBorderStyle = FormBorderStyle.FixedDialog;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = nameof (FrmAgentDelivery);
      this.ShowIcon = false;
      this.ShowInTaskbar = false;
      this.StartPosition = FormStartPosition.CenterParent;
      this.Text = "Agente Delivery";
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

    internal virtual Panel Panel_ButtonsLocation { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

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

    internal virtual DataGridView dgrvData
    {
      get
      {
        return this._dgrvData;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        DataGridViewCellEventHandler cellEventHandler = new DataGridViewCellEventHandler(this.dgrvData_CellDoubleClick);
        KeyEventHandler keyEventHandler1 = new KeyEventHandler(this.dgrvData_KeyDown);
        KeyEventHandler keyEventHandler2 = new KeyEventHandler(this.dgrvData_KeyUp);
        MouseEventHandler mouseEventHandler = new MouseEventHandler(this.dgrvData_MouseClick);
        DataGridView dgrvData1 = this._dgrvData;
        if (dgrvData1 != null)
        {
          dgrvData1.CellDoubleClick -= cellEventHandler;
          dgrvData1.KeyDown -= keyEventHandler1;
          dgrvData1.KeyUp -= keyEventHandler2;
          dgrvData1.MouseClick -= mouseEventHandler;
        }
        this._dgrvData = value;
        DataGridView dgrvData2 = this._dgrvData;
        if (dgrvData2 == null)
          return;
        dgrvData2.CellDoubleClick += cellEventHandler;
        dgrvData2.KeyDown += keyEventHandler1;
        dgrvData2.KeyUp += keyEventHandler2;
        dgrvData2.MouseClick += mouseEventHandler;
      }
    }

    internal virtual TabPage TabPage_Detail { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual TextBox TextBox_AgentDesShort
    {
      get
      {
        return this._TextBox_AgentDesShort;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        KeyPressEventHandler pressEventHandler = new KeyPressEventHandler(this.Control_KeyPress);
        TextBox boxAgentDesShort1 = this._TextBox_AgentDesShort;
        if (boxAgentDesShort1 != null)
          boxAgentDesShort1.KeyPress -= pressEventHandler;
        this._TextBox_AgentDesShort = value;
        TextBox boxAgentDesShort2 = this._TextBox_AgentDesShort;
        if (boxAgentDesShort2 == null)
          return;
        boxAgentDesShort2.KeyPress += pressEventHandler;
      }
    }

    internal virtual Label Label_DesShort { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual CheckBox CheckBox_IsActive
    {
      get
      {
        return this._CheckBox_IsActive;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        KeyPressEventHandler pressEventHandler = new KeyPressEventHandler(this.Control_KeyPress);
        CheckBox checkBoxIsActive1 = this._CheckBox_IsActive;
        if (checkBoxIsActive1 != null)
          checkBoxIsActive1.KeyPress -= pressEventHandler;
        this._CheckBox_IsActive = value;
        CheckBox checkBoxIsActive2 = this._CheckBox_IsActive;
        if (checkBoxIsActive2 == null)
          return;
        checkBoxIsActive2.KeyPress += pressEventHandler;
      }
    }

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

    internal virtual Label Label_Des { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual TextBox TextBox_AgentDes
    {
      get
      {
        return this._TextBox_AgentDes;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        KeyPressEventHandler pressEventHandler = new KeyPressEventHandler(this.Control_KeyPress);
        TextBox textBoxAgentDes1 = this._TextBox_AgentDes;
        if (textBoxAgentDes1 != null)
          textBoxAgentDes1.KeyPress -= pressEventHandler;
        this._TextBox_AgentDes = value;
        TextBox textBoxAgentDes2 = this._TextBox_AgentDes;
        if (textBoxAgentDes2 == null)
          return;
        textBoxAgentDes2.KeyPress += pressEventHandler;
      }
    }

    internal virtual Label Label_Id { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual TextBox TextBox_Id { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual TextBox TextBox_Observation
    {
      get
      {
        return this._TextBox_Observation;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        KeyPressEventHandler pressEventHandler = new KeyPressEventHandler(this.Control_KeyPress);
        TextBox textBoxObservation1 = this._TextBox_Observation;
        if (textBoxObservation1 != null)
          textBoxObservation1.KeyPress -= pressEventHandler;
        this._TextBox_Observation = value;
        TextBox textBoxObservation2 = this._TextBox_Observation;
        if (textBoxObservation2 == null)
          return;
        textBoxObservation2.KeyPress += pressEventHandler;
      }
    }

    internal virtual Label Label_Observation { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual ToolStripStatusLabel ToolStripStatusLabel_OperationText { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual ToolStripStatusLabel ToolStripStatusLabel_RecordsNumber { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual ToolStripStatusLabel ToolStripStatusLabel_RecordsText { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

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

    internal virtual Button Button_KBoard_Observation
    {
      get
      {
        return this._Button_KBoard_Observation;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Button_KBoard_Observation_Click);
        Button kboardObservation1 = this._Button_KBoard_Observation;
        if (kboardObservation1 != null)
          kboardObservation1.Click -= eventHandler;
        this._Button_KBoard_Observation = value;
        Button kboardObservation2 = this._Button_KBoard_Observation;
        if (kboardObservation2 == null)
          return;
        kboardObservation2.Click += eventHandler;
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

    internal virtual StatusStrip StatusStrip_Properties { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual ToolStripStatusLabel ToolStripStatusLabel_Operation { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual ToolStripStatusLabel Tssl_Record { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    private void FrmAgentDelivery_Load(object sender, EventArgs e)
    {
      this.Resource(ModGeneralFunctions.Get_Language((object) this));
      this.SetUpDataGridView();
      this.LoadData();
      this.Button_Ready.Visible = this._OnlySearch;
    }

    private void Resource(ResourceManager Rm)
    {
      this.TabPage_Listado.Text = Rm.GetString("Res_List");
      this.TabPage_Detail.Text = Rm.GetString("Res_Maintenance");
      this.Label_Description.Text = Rm.GetString("Res_Description") + ":";
      this.Button_GoOut.Text = Rm.GetString("Res_Back");
      this.Button_Ready.Text = Rm.GetString("Res_Ready");
      this.Button_New.Text = Rm.GetString("Res_New");
      this.Button_Update.Text = Rm.GetString("Res_Edit");
      this.Button_Delete.Text = Rm.GetString("Res_Delete");
      this.Button_Save.Text = Rm.GetString("Res_Save");
      this.Button_CloseTab.Text = Rm.GetString("Res_Exit");
      this.Res_Code = Rm.GetString("Res_Code");
      this.Res_Description = Rm.GetString("Res_Description");
      this.Res_DescriptionS = Rm.GetString("Res_DescriptionS");
      this.Res_Observation = Rm.GetString("Res_Observation");
      this.Res_Active = Rm.GetString("Res_Active");
      this.Res_MsgSave = Rm.GetString("Res_MsgSave");
      this.Label_Id.Text = this.Res_Code + ":";
      this.Label_Des.Text = this.Res_Description + ":";
      this.Label_DesShort.Text = this.Res_DescriptionS + ":";
      this.Label_Observation.Text = this.Res_Observation + ":";
      this.Label_IsActive.Text = this.Res_Active + ":";
      ModGeneralVar.g_Res_Description = Rm.GetString("Res_InputDescription");
      this.Button_KBoardCriterio.Text = Rm.GetString("Res_Keyboard");
      this.Button_KBoard_Des.Text = Rm.GetString("Res_Keyboard");
      this.Button_KBoard_DesShort.Text = Rm.GetString("Res_Keyboard");
      this.Button_KBoard_Observation.Text = Rm.GetString("Res_Keyboard");
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

    private void SetUpDataGridView()
    {
      ModGeneralFunctions.SetUpDataGridViewBasicNuevo(this.dgrvData);
      this.dgrvData.Columns.Add("AgentId", this.Res_Code);
      ModGeneralFunctions.SetUp_TextBoxColumn1((DataGridViewTextBoxColumn) this.dgrvData.Columns[0], "AgentId", (short) 60, "", true, DataGridViewContentAlignment.MiddleCenter, true);
      this.dgrvData.Columns.Add("AgentDes", this.Res_Description);
      ModGeneralFunctions.SetUp_TextBoxColumn1((DataGridViewTextBoxColumn) this.dgrvData.Columns[1], "AgentDes", (short) 150, "", true, DataGridViewContentAlignment.MiddleLeft, true);
      this.dgrvData.Columns.Add("AgentDesShort", this.Res_DescriptionS);
      ModGeneralFunctions.SetUp_TextBoxColumn1((DataGridViewTextBoxColumn) this.dgrvData.Columns[2], "AgentDesShort", (short) 130, "", false, DataGridViewContentAlignment.MiddleLeft, true);
      this.dgrvData.Columns.Add("Observation", this.Res_Observation);
      ModGeneralFunctions.SetUp_TextBoxColumn1((DataGridViewTextBoxColumn) this.dgrvData.Columns[3], this.Res_Observation, (short) 150, "", true, DataGridViewContentAlignment.MiddleLeft, true);
      this.dgrvData.Columns.Add((DataGridViewColumn) new DataGridViewCheckBoxColumn());
      ModGeneralFunctions.SetUp_CheckBoxColumn1((DataGridViewCheckBoxColumn) this.dgrvData.Columns[4], this.Res_Active, "IsActive", (short) 60, "", true);
    }

    private void LoadData()
    {
      BL_TR1_AGENT_DELIVERY tr1AgentDelivery = new BL_TR1_AGENT_DELIVERY();
      List<BE_TR1_AGENT_DELIVERY> tr1AgentDeliveryList = new List<BE_TR1_AGENT_DELIVERY>();
      this.dgrvData.DataSource = (object) tr1AgentDelivery.ListBasic();
      this.ToolStripStatusLabel_RecordsNumber.Text = Conversions.ToString(this.dgrvData.RowCount);
      this.Information_Quantity_Of_Records();
      this.FirstTab((short) 0, "Listado de Agentes Delivery");
    }

    private void Button_GoOut_Click(object sender, EventArgs e)
    {
      ModGeneralVar.g_bol_IsReady = false;
      this.Close();
    }

    private void Button_Ready_Click(object sender, EventArgs e)
    {
      if (!ModGeneralFunctions.Order_HeadValidated(this.dgrvData))
        return;
      this.SelectITem();
      ModGeneralVar.g_bol_IsReady = true;
      this.Close();
    }

    private void SelectITem()
    {
      ModGeneralVar.g_Str_RecordID = Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateIndexGet(this.dgrvData.DataSource, new object[1]
      {
        (object) this.dgrvData.CurrentRow.Index
      }, (string[]) null), (System.Type) null, "AgentId", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      ModGeneralVar.g_Str_RecordDes = Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateIndexGet(this.dgrvData.DataSource, new object[1]
      {
        (object) this.dgrvData.CurrentRow.Index
      }, (string[]) null), (System.Type) null, "AgentDes", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      ModGeneralVar.g_BE_TR1_AGENTDELIVERY = new BE_TR1_AGENT_DELIVERY();
      ModGeneralVar.g_BE_TR1_AGENTDELIVERY.set_AgentId(Conversions.ToInteger(ModGeneralVar.g_Str_RecordID));
      ModGeneralVar.g_BE_TR1_AGENTDELIVERY.set_AgentDes(ModGeneralVar.g_Str_RecordDes);
      ModGeneralVar.g_AgentDeliveryId = Conversions.ToInteger(ModGeneralVar.g_Str_RecordID);
      this.Information_Quantity_Of_Records();
    }

    private void dgrvData_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
    {
      if (this._OnlySearch)
        this.Button_Ready_Click(RuntimeHelpers.GetObjectValue(sender), (EventArgs) null);
      else if (this.DataGV_Validated())
        this.SetOperation(StructApp.RECORD_EDIT);
    }

    private void SetOperation(string _Operation)
    {
      this.ToolStripStatusLabel_OperationText.Text = _Operation;
      if (Operators.CompareString(_Operation, StructApp.RECORD_CREATE, false) == 0)
      {
        this.TextBox_Id.Text = "";
        this.TextBox_AgentDes.Text = "";
        this.TextBox_AgentDesShort.Text = "";
        this.TextBox_Observation.Text = "";
        this.CheckBox_IsActive.Checked = true;
        ((TabControl) this.TabControl_Data).SelectedIndex = 1;
        this.TextBox_AgentDes.Focus();
      }
      else if (Operators.CompareString(_Operation, StructApp.RECORD_EDIT, false) == 0)
      {
        this.TextBox_Id.ReadOnly = true;
        this.TextBox_Id.Text = Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateIndexGet(this.dgrvData.DataSource, new object[1]
        {
          (object) this.dgrvData.CurrentRow.Index
        }, (string[]) null), (System.Type) null, "AgentId", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
        this.TextBox_AgentDes.Text = Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateIndexGet(this.dgrvData.DataSource, new object[1]
        {
          (object) this.dgrvData.CurrentRow.Index
        }, (string[]) null), (System.Type) null, "AgentDes", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
        this.TextBox_AgentDesShort.Text = Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateIndexGet(this.dgrvData.DataSource, new object[1]
        {
          (object) this.dgrvData.CurrentRow.Index
        }, (string[]) null), (System.Type) null, "AgentDesShort", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
        this.TextBox_Observation.Text = Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateIndexGet(this.dgrvData.DataSource, new object[1]
        {
          (object) this.dgrvData.CurrentRow.Index
        }, (string[]) null), (System.Type) null, "Observation", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
        this.CheckBox_IsActive.Checked = (Conversions.ToBoolean(NewLateBinding.LateGet(NewLateBinding.LateIndexGet(this.dgrvData.DataSource, new object[1]
        {
          (object) this.dgrvData.CurrentRow.Index
        }, (string[]) null), (System.Type) null, "IsActive", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null)) ? 1 : 0) != 0;
        ((TabControl) this.TabControl_Data).SelectedIndex = 1;
        this.TextBox_AgentDes.Focus();
      }
      else
      {
        if (Operators.CompareString(_Operation, StructApp.RECORD_DELETE, false) != 0)
          return;
        this.TextBox_Id.ReadOnly = true;
        this.TextBox_Id.Text = Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateIndexGet(this.dgrvData.DataSource, new object[1]
        {
          (object) this.dgrvData.CurrentRow.Index
        }, (string[]) null), (System.Type) null, "AgentId", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
        this.TextBox_AgentDes.Text = Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateIndexGet(this.dgrvData.DataSource, new object[1]
        {
          (object) this.dgrvData.CurrentRow.Index
        }, (string[]) null), (System.Type) null, "AgentDes", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
        this.MakeOperation(this.ToolStripStatusLabel_OperationText.Text);
      }
    }

    private void MakeOperation(string _Operation)
    {
      BL_TR1_AGENT_DELIVERY tr1AgentDelivery1 = new BL_TR1_AGENT_DELIVERY();
      BE_TR1_AGENT_DELIVERY tr1AgentDelivery2;
      if (Operators.CompareString(_Operation, StructApp.RECORD_CREATE, false) == 0)
      {
        if (!ModGeneralFunctions.MessageMakeAction(this.Res_MsgSave, false))
          return;
        this.ValidateData();
        if (this._IsValidate)
          return;
        BE_TR1_AGENT_DELIVERY tr1AgentDelivery3 = new BE_TR1_AGENT_DELIVERY();
        tr1AgentDelivery3.set_AgentId(0);
        tr1AgentDelivery3.set_AgentDes(this.TextBox_AgentDes.Text);
        tr1AgentDelivery3.set_AgentDesShort(this.TextBox_AgentDesShort.Text);
        tr1AgentDelivery3.set_Observation(this.TextBox_Observation.Text);
        tr1AgentDelivery3.set_IsActive(this.CheckBox_IsActive.Checked);
        tr1AgentDelivery3.set_EstabliId(ModGeneralVar.g_BE_TR1_VARIABLES_B.get_EstabliId());
        this.str_Result = tr1AgentDelivery1.Add(ref tr1AgentDelivery3);
        if (Operators.CompareString(this.str_Result, StructApp.RESULT_OK, false) == 0)
        {
          this.LoadData();
          this.Ubicate_Record(Conversions.ToString(tr1AgentDelivery3.get_AgentId()));
          ModGeneralFunctions.MessageOk("[Registro Creado]");
          this.dgrvData.Focus();
        }
        else
          ModGeneralFunctions.MessageError_Large(this.str_Result, true);
        tr1AgentDelivery2 = (BE_TR1_AGENT_DELIVERY) null;
        this.FirstTab((short) 0, "Listado de Productos");
      }
      else if (Operators.CompareString(_Operation, StructApp.RECORD_EDIT, false) == 0)
      {
        if (!ModGeneralFunctions.MessageMakeAction(this.Res_MsgSave, false))
          return;
        this.ValidateData();
        if (this._IsValidate)
          return;
        BE_TR1_AGENT_DELIVERY tr1AgentDelivery3 = new BE_TR1_AGENT_DELIVERY();
        tr1AgentDelivery3.set_AgentId(Conversions.ToInteger(this.TextBox_Id.Text));
        tr1AgentDelivery3.set_AgentDes(this.TextBox_AgentDes.Text);
        tr1AgentDelivery3.set_AgentDesShort(this.TextBox_AgentDesShort.Text);
        tr1AgentDelivery3.set_Observation(this.TextBox_Observation.Text);
        tr1AgentDelivery3.set_IsActive(this.CheckBox_IsActive.Checked);
        tr1AgentDelivery3.set_EstabliId(ModGeneralVar.g_BE_TR1_VARIABLES_B.get_EstabliId());
        this.str_Result = tr1AgentDelivery1.Edit(ref tr1AgentDelivery3);
        if (Operators.CompareString(this.str_Result, StructApp.RESULT_OK, false) == 0)
        {
          this.LoadData();
          this.Ubicate_Record(Conversions.ToString(tr1AgentDelivery3.get_AgentId()));
          ModGeneralFunctions.MessageOk("[Registro Editado]");
        }
        else
          ModGeneralFunctions.MessageError_Large(this.str_Result, true);
        tr1AgentDelivery2 = (BE_TR1_AGENT_DELIVERY) null;
        this.FirstTab((short) 0, "Listado de Productos");
      }
      else
      {
        if (Operators.CompareString(_Operation, StructApp.RECORD_DELETE, false) != 0 || !ModGeneralFunctions.MessageMakeAction("¿Seguro de Eliminar el Agente: -" + this.TextBox_AgentDes.Text + "- ?", false))
          return;
        this.str_Result = tr1AgentDelivery1.Delete(this.TextBox_Id.Text);
        if (Operators.CompareString(this.str_Result, StructApp.RESULT_OK, false) == 0)
        {
          short index = checked ((short) this.dgrvData.CurrentRow.Index);
          this.LoadData();
          if (this.dgrvData.Rows.Count > 1 & index > (short) 0)
            this.dgrvData.CurrentCell = this.dgrvData[0, checked ((int) index - 1)];
          ModGeneralFunctions.MessageOk("[Registro Eliminado]");
        }
        else
          ModGeneralFunctions.MessageError_Large(this.str_Result, true);
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
        }, (string[]) null), (System.Type) null, "AgentId", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null)).Equals(_ItemToUbicate))
        {
          this.dgrvData.CurrentCell = this.dgrvData[0, index];
          break;
        }
        checked { ++index; }
      }
    }

    private void Button_New_Click(object sender, EventArgs e)
    {
      this.SetOperation(StructApp.RECORD_CREATE);
      this.FirstTab((short) 1, "Crear Registro");
    }

    private void Button_Save_Click(object sender, EventArgs e)
    {
      this.MakeOperation(this.ToolStripStatusLabel_OperationText.Text);
    }

    private void Button_CloseTab_Click(object sender, EventArgs e)
    {
      this.FirstTab((short) 0, "Listado de Agentes Delivery");
    }

    private void Button_Update_Click(object sender, EventArgs e)
    {
      if (!this.DataGV_Validated())
        return;
      this.SetOperation(StructApp.RECORD_EDIT);
      this.FirstTab((short) 1, "Editar Registro");
    }

    private void TextBox_Criterio_TextChanged(object sender, EventArgs e)
    {
      BL_TR1_AGENT_DELIVERY tr1AgentDelivery = new BL_TR1_AGENT_DELIVERY();
      List<BE_TR1_AGENT_DELIVERY> tr1AgentDeliveryList = new List<BE_TR1_AGENT_DELIVERY>();
      this.dgrvData.DataSource = (object) tr1AgentDelivery.ListBasicbyDes(this.TextBox_Criterio.Text);
      this.Information_Quantity_Of_Records();
    }

    private void Button_First_Click(object sender, EventArgs e)
    {
      if (this.dgrvData.Rows.Count <= 0)
        return;
      this.dgrvData.CurrentCell = this.dgrvData[0, 0];
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

    private void Button_Last_Click(object sender, EventArgs e)
    {
      if (this.dgrvData.Rows.Count <= 0)
        return;
      this.dgrvData.CurrentCell = this.dgrvData[1, checked (this.dgrvData.Rows.Count - 1)];
      this.SelectITem();
    }

    private void Button_KBoardCriterio_Click(object sender, EventArgs e)
    {
      string str = "";
      ModGeneralFunctions.TextKeyBoard("Ingrese Descripción", ref str);
      if (!ModGeneralVar.g_bol_IsReady)
        return;
      this.TextBox_Criterio.Text = ModGeneralVar.g_str_InputValue;
    }

    private void ValidateData()
    {
      this._IsValidate = false;
      if (Operators.CompareString(this.TextBox_AgentDes.Text, "", false) != 0)
        return;
      ModGeneralFunctions.MessageOk(ModGeneralVar.g_Res_Description);
      this._IsValidate = true;
      this.TextBox_AgentDes.Focus();
    }

    private void Button_KBoard_Des_Click(object sender, EventArgs e)
    {
      TextBox textBoxAgentDes;
      string text = (textBoxAgentDes = this.TextBox_AgentDes).Text;
      ModGeneralFunctions.TextKeyBoard("Ingrese La Descripción", ref text);
      textBoxAgentDes.Text = text;
      if (Strings.Len(ModGeneralVar.g_str_InputValue) > 0)
        this.TextBox_AgentDes.Text = ModGeneralVar.g_str_InputValue;
      this.TextBox_AgentDesShort.Focus();
    }

    private void Button_KBoard_DesShort_Click(object sender, EventArgs e)
    {
      TextBox boxAgentDesShort;
      string text = (boxAgentDesShort = this.TextBox_AgentDesShort).Text;
      ModGeneralFunctions.TextKeyBoard("Ingrese La Descripción Corta", ref text);
      boxAgentDesShort.Text = text;
      if (Strings.Len(ModGeneralVar.g_str_InputValue) > 0)
        this.TextBox_AgentDesShort.Text = ModGeneralVar.g_str_InputValue;
      this.TextBox_Observation.Focus();
    }

    private void Button_KBoard_Observation_Click(object sender, EventArgs e)
    {
      TextBox textBoxObservation;
      string text = (textBoxObservation = this.TextBox_Observation).Text;
      ModGeneralFunctions.TextKeyBoard("Ingrese Observación", ref text);
      textBoxObservation.Text = text;
      if (Strings.Len(ModGeneralVar.g_str_InputValue) > 0)
        this.TextBox_Observation.Text = ModGeneralVar.g_str_InputValue;
      this.CheckBox_IsActive.Focus();
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
      if (ModGeneralFunctions.Question_Made_Enter_FromKeyEvent(e))
      {
        if (this._OnlySearch)
        {
          this.SelectITem();
          ModGeneralVar.g_bol_IsReady = true;
          this.Close();
        }
        else if (this.DataGV_Validated())
          this.SetOperation(StructApp.RECORD_EDIT);
      }
      this.Information_Quantity_Of_Records();
    }

    private void TextBox_Criterio_KeyPress(object sender, KeyPressEventArgs e)
    {
      if (!ModGeneralFunctions.Question_Made_Enter(e))
        return;
      if (this.dgrvData.Rows.Count == 0)
      {
        ModGeneralFunctions.MessageRestrictive("No existe(n) " + this._nameForm + " (s)");
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

    private void FrmAgentDelivery_Activated(object sender, EventArgs e)
    {
      this.TextBox_Criterio.Focus();
    }

    public bool DataGV_Validated()
    {
      return this.dgrvData.Rows.Count > 0;
    }

    private void Button_Delete_Click(object sender, EventArgs e)
    {
      if (!this.DataGV_Validated())
        return;
      this.SetOperation(StructApp.RECORD_DELETE);
    }

    private void dgrvData_KeyUp(object sender, KeyEventArgs e)
    {
      this.Information_Quantity_Of_Records();
    }

    private void dgrvData_MouseClick(object sender, MouseEventArgs e)
    {
      this.Information_Quantity_Of_Records();
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
  }
}
