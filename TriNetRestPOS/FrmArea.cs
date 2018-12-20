// Decompiled with JetBrains decompiler
// Type: TriNetRestPOS.FrmArea
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
  public class FrmArea : Form
  {
    private IContainer components;
    public string _NameForm;
    private BL_TR1_AREA o_BL_AREA;
    private List<BE_TR1_AREA> o_BEC_AREA;
    private BE_TR1_AREA o_BE_TR1_AREA;
    private string str_Result;
    public string str_Areaable;
    public string str_NameTable;
    public short int_SizeId;
    public bool _OnlySearch;
    private List<BE_TR1_PRINTERS> o_BEC_PRINTERS;
    private List<BE_TR1_PRINTERS> o_BEC_PRINTERS_Delete;
    private BL_TR1_PRINTERS o_BL_TR1_PRINTERS;
    private string Res_Code;
    private string Res_Description;
    private string Res_DescriptionS;
    private string Res_Active;
    private string Res_Observation;
    private string Res_MsgSave;
    private Control _control;
    private string str_PrinterDes;

    public FrmArea()
    {
      this.Load += new EventHandler(this.FrmAreas_Load);
      this.Activated += new EventHandler(this.FrmAreas_Activated);
      this.KeyDown += new KeyEventHandler(this.FrmArea_KeyDown);
      this._NameForm = "";
      this.str_Result = StructApp.RESULT_OK;
      this._OnlySearch = false;
      this.o_BEC_PRINTERS = new List<BE_TR1_PRINTERS>();
      this.o_BEC_PRINTERS_Delete = new List<BE_TR1_PRINTERS>();
      this.o_BL_TR1_PRINTERS = new BL_TR1_PRINTERS();
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
      this.Button_Update = new Button();
      this.Button_Last = new Button();
      this.Button_New = new Button();
      this.TextBox_Criterio = new TextBox();
      this.dgrvData = new DataGridView();
      this.TabPage_Detail = new TabPage();
      this.ComboBox_PrintNumComma = new ComboBox();
      this.Label1 = new Label();
      this.GroupBox_Printers = new GroupBox();
      this.Button_Printer_Forward = new Button();
      this.Button_Printer_Back = new Button();
      this.Button_Delete_Printer = new Button();
      this.Button_SearchPrinters = new Button();
      this.DataGridView_Printers = new DataGridView();
      this.TextBox_PrinterId = new TextBox();
      this.CheckBox_IsActive = new CheckBox();
      this.Label_IsActive = new Label();
      this.TextBox_DesShort = new TextBox();
      this.Label_DesShort = new Label();
      this.Label_Des = new Label();
      this.TextBox_Des = new TextBox();
      this.Label_Id = new Label();
      this.TextBox_Id = new TextBox();
      this.Button_CloseTab = new Button();
      this.Button_Save = new Button();
      this.Button_KBoard_DesShort = new Button();
      this.Button_KBoard_Des = new Button();
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
      this.GroupBox_Printers.SuspendLayout();
      ((ISupportInitialize) this.DataGridView_Printers).BeginInit();
      this.StatusStrip_Properties.SuspendLayout();
      this.SuspendLayout();
      ((Control) this.TabControl_Data).Controls.Add((Control) this.TabPage_Listado);
      ((Control) this.TabControl_Data).Controls.Add((Control) this.TabPage_Detail);
      ((Control) this.TabControl_Data).Font = new Font("Trebuchet MS", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      ((Control) this.TabControl_Data).Location = new Point(2, 3);
      ((Control) this.TabControl_Data).Name = "TabControl_Data";
      ((TabControl) this.TabControl_Data).SelectedIndex = 0;
      ((Control) this.TabControl_Data).Size = new Size(522, 553);
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
      this.TabPage_Listado.Size = new Size(514, 520);
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
      this.Button_KBoardCriterio.BackgroundImage = (Image) TriNetRestPOS.My.Resources.Resources.teclado_icon;
      this.Button_KBoardCriterio.FlatStyle = FlatStyle.Flat;
      this.Button_KBoardCriterio.Font = new Font("Trebuchet MS", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Button_KBoardCriterio.ForeColor = Color.WhiteSmoke;
      this.Button_KBoardCriterio.Location = new Point(3, 33);
      this.Button_KBoardCriterio.Name = "Button_KBoardCriterio";
      this.Button_KBoardCriterio.Size = new Size(45, 27);
      this.Button_KBoardCriterio.TabIndex = 1;
      this.Button_KBoardCriterio.TextImageRelation = TextImageRelation.TextAboveImage;
      this.Button_KBoardCriterio.UseVisualStyleBackColor = true;
      this.Button_GoOut.BackgroundImage = (Image) TriNetRestPOS.My.Resources.Resources.boton_rojo;
      this.Button_GoOut.FlatStyle = FlatStyle.Flat;
      this.Button_GoOut.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Button_GoOut.ForeColor = Color.WhiteSmoke;
      this.Button_GoOut.Image = (Image) TriNetRestPOS.My.Resources.Resources.salir;
      this.Button_GoOut.ImageAlign = ContentAlignment.TopCenter;
      this.Button_GoOut.Location = new Point(169, 4);
      this.Button_GoOut.Name = "Button_GoOut";
      this.Button_GoOut.Padding = new Padding(0, 5, 0, 5);
      this.Button_GoOut.Size = new Size(74, 56);
      this.Button_GoOut.TabIndex = 161;
      this.Button_GoOut.Text = "Salir";
      this.Button_GoOut.TextAlign = ContentAlignment.BottomCenter;
      this.Button_GoOut.UseVisualStyleBackColor = true;
      this.Button_Ready.BackgroundImage = (Image) TriNetRestPOS.My.Resources.Resources.boton_guardar;
      this.Button_Ready.FlatStyle = FlatStyle.Flat;
      this.Button_Ready.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Button_Ready.ForeColor = Color.WhiteSmoke;
      this.Button_Ready.Image = (Image) TriNetRestPOS.My.Resources.Resources.check_OK;
      this.Button_Ready.ImageAlign = ContentAlignment.TopCenter;
      this.Button_Ready.Location = new Point(92, 4);
      this.Button_Ready.Name = "Button_Ready";
      this.Button_Ready.Padding = new Padding(0, 5, 0, 5);
      this.Button_Ready.Size = new Size(74, 56);
      this.Button_Ready.TabIndex = 3;
      this.Button_Ready.Text = "Listo";
      this.Button_Ready.TextAlign = ContentAlignment.BottomCenter;
      this.Button_Ready.UseVisualStyleBackColor = true;
      this.Button_Ready.Visible = false;
      this.Label_Description.AutoSize = true;
      this.Label_Description.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Label_Description.ForeColor = Color.FromArgb(150, 150, 150);
      this.Label_Description.Location = new Point(0, 12);
      this.Label_Description.Name = "Label_Description";
      this.Label_Description.Size = new Size(95, 16);
      this.Label_Description.TabIndex = 147;
      this.Label_Description.Text = "Descripción:";
      this.Panel_ButtonsTools.Controls.Add((Control) this.Button_First);
      this.Panel_ButtonsTools.Controls.Add((Control) this.Button_Back);
      this.Panel_ButtonsTools.Controls.Add((Control) this.Button_Delete);
      this.Panel_ButtonsTools.Controls.Add((Control) this.Button_Forward);
      this.Panel_ButtonsTools.Controls.Add((Control) this.Button_Update);
      this.Panel_ButtonsTools.Controls.Add((Control) this.Button_Last);
      this.Panel_ButtonsTools.Controls.Add((Control) this.Button_New);
      this.Panel_ButtonsTools.Location = new Point(428, 61);
      this.Panel_ButtonsTools.Name = "Panel_ButtonsTools";
      this.Panel_ButtonsTools.Size = new Size(87, 459);
      this.Panel_ButtonsTools.TabIndex = 146;
      this.Button_First.BackgroundImage = (Image) TriNetRestPOS.My.Resources.Resources.boton_nuevo;
      this.Button_First.FlatStyle = FlatStyle.Flat;
      this.Button_First.Font = new Font("Verdana", 18f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Button_First.ForeColor = Color.WhiteSmoke;
      this.Button_First.Image = (Image) TriNetRestPOS.My.Resources.Resources.flecha_inicio;
      this.Button_First.Location = new Point(8, 200);
      this.Button_First.Name = "Button_First";
      this.Button_First.RightToLeft = RightToLeft.Yes;
      this.Button_First.Size = new Size(69, 65);
      this.Button_First.TabIndex = 32;
      this.Button_First.UseVisualStyleBackColor = true;
      this.Button_Back.BackgroundImage = (Image) TriNetRestPOS.My.Resources.Resources.boton_nuevo;
      this.Button_Back.FlatStyle = FlatStyle.Flat;
      this.Button_Back.Font = new Font("Verdana", 18f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Button_Back.ForeColor = Color.WhiteSmoke;
      this.Button_Back.Image = (Image) TriNetRestPOS.My.Resources.Resources.flecha_arriba;
      this.Button_Back.Location = new Point(8, 264);
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
      this.Button_Delete.Location = new Point(8, 133);
      this.Button_Delete.Name = "Button_Delete";
      this.Button_Delete.Padding = new Padding(0, 5, 0, 5);
      this.Button_Delete.RightToLeft = RightToLeft.Yes;
      this.Button_Delete.Size = new Size(69, 65);
      this.Button_Delete.TabIndex = 148;
      this.Button_Delete.Text = "Elimi";
      this.Button_Delete.TextAlign = ContentAlignment.BottomCenter;
      this.Button_Delete.UseVisualStyleBackColor = true;
      this.Button_Forward.BackgroundImage = (Image) TriNetRestPOS.My.Resources.Resources.boton_nuevo;
      this.Button_Forward.FlatStyle = FlatStyle.Flat;
      this.Button_Forward.Font = new Font("Verdana", 18f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Button_Forward.ForeColor = Color.WhiteSmoke;
      this.Button_Forward.Image = (Image) TriNetRestPOS.My.Resources.Resources.flecha_abajo;
      this.Button_Forward.Location = new Point(8, 328);
      this.Button_Forward.Name = "Button_Forward";
      this.Button_Forward.RightToLeft = RightToLeft.Yes;
      this.Button_Forward.Size = new Size(69, 65);
      this.Button_Forward.TabIndex = 34;
      this.Button_Forward.UseVisualStyleBackColor = true;
      this.Button_Update.BackgroundImage = (Image) TriNetRestPOS.My.Resources.Resources.boton_nuevo;
      this.Button_Update.FlatStyle = FlatStyle.Flat;
      this.Button_Update.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Button_Update.ForeColor = Color.WhiteSmoke;
      this.Button_Update.Image = (Image) TriNetRestPOS.My.Resources.Resources.icono_editar;
      this.Button_Update.ImageAlign = ContentAlignment.TopCenter;
      this.Button_Update.Location = new Point(8, 68);
      this.Button_Update.Name = "Button_Update";
      this.Button_Update.Padding = new Padding(0, 5, 0, 5);
      this.Button_Update.Size = new Size(69, 65);
      this.Button_Update.TabIndex = 147;
      this.Button_Update.Text = "Editar";
      this.Button_Update.TextAlign = ContentAlignment.BottomCenter;
      this.Button_Update.UseVisualStyleBackColor = true;
      this.Button_Last.BackgroundImage = (Image) TriNetRestPOS.My.Resources.Resources.boton_nuevo;
      this.Button_Last.FlatStyle = FlatStyle.Flat;
      this.Button_Last.Font = new Font("Verdana", 18f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Button_Last.ForeColor = Color.WhiteSmoke;
      this.Button_Last.Image = (Image) TriNetRestPOS.My.Resources.Resources.flecha_final;
      this.Button_Last.Location = new Point(8, 391);
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
      this.Button_New.Location = new Point(8, 3);
      this.Button_New.Name = "Button_New";
      this.Button_New.Padding = new Padding(0, 5, 0, 5);
      this.Button_New.Size = new Size(69, 65);
      this.Button_New.TabIndex = 146;
      this.Button_New.Text = "Nuevo";
      this.Button_New.TextAlign = ContentAlignment.BottomCenter;
      this.Button_New.UseVisualStyleBackColor = true;
      this.TextBox_Criterio.BorderStyle = BorderStyle.FixedSingle;
      this.TextBox_Criterio.ForeColor = Color.FromArgb(150, 150, 150);
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
      this.dgrvData.Size = new Size(427, 455);
      this.dgrvData.TabIndex = 1;
      this.TabPage_Detail.Controls.Add((Control) this.ComboBox_PrintNumComma);
      this.TabPage_Detail.Controls.Add((Control) this.Label1);
      this.TabPage_Detail.Controls.Add((Control) this.GroupBox_Printers);
      this.TabPage_Detail.Controls.Add((Control) this.TextBox_PrinterId);
      this.TabPage_Detail.Controls.Add((Control) this.CheckBox_IsActive);
      this.TabPage_Detail.Controls.Add((Control) this.Label_IsActive);
      this.TabPage_Detail.Controls.Add((Control) this.TextBox_DesShort);
      this.TabPage_Detail.Controls.Add((Control) this.Label_DesShort);
      this.TabPage_Detail.Controls.Add((Control) this.Label_Des);
      this.TabPage_Detail.Controls.Add((Control) this.TextBox_Des);
      this.TabPage_Detail.Controls.Add((Control) this.Label_Id);
      this.TabPage_Detail.Controls.Add((Control) this.TextBox_Id);
      this.TabPage_Detail.Controls.Add((Control) this.Button_CloseTab);
      this.TabPage_Detail.Controls.Add((Control) this.Button_Save);
      this.TabPage_Detail.Controls.Add((Control) this.Button_KBoard_DesShort);
      this.TabPage_Detail.Controls.Add((Control) this.Button_KBoard_Des);
      this.TabPage_Detail.Location = new Point(4, 29);
      this.TabPage_Detail.Name = "TabPage_Detail";
      this.TabPage_Detail.Padding = new Padding(3);
      this.TabPage_Detail.Size = new Size(514, 520);
      this.TabPage_Detail.TabIndex = 1;
      this.TabPage_Detail.Text = "Mantenimiento";
      this.TabPage_Detail.UseVisualStyleBackColor = true;
      this.ComboBox_PrintNumComma.DropDownStyle = ComboBoxStyle.DropDownList;
      this.ComboBox_PrintNumComma.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.ComboBox_PrintNumComma.ForeColor = Color.FromArgb(150, 150, 150);
      this.ComboBox_PrintNumComma.FormattingEnabled = true;
      this.ComboBox_PrintNumComma.Items.AddRange(new object[10]
      {
        (object) "1",
        (object) "2",
        (object) "3",
        (object) "4",
        (object) "5",
        (object) "6",
        (object) "7",
        (object) "8",
        (object) "9",
        (object) "10"
      });
      this.ComboBox_PrintNumComma.Location = new Point(224, 174);
      this.ComboBox_PrintNumComma.MaxDropDownItems = 9;
      this.ComboBox_PrintNumComma.Name = "ComboBox_PrintNumComma";
      this.ComboBox_PrintNumComma.Size = new Size(121, 24);
      this.ComboBox_PrintNumComma.TabIndex = 438;
      this.Label1.AutoSize = true;
      this.Label1.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Label1.ForeColor = Color.FromArgb(150, 150, 150);
      this.Label1.Location = new Point(24, 177);
      this.Label1.Name = "Label1";
      this.Label1.Size = new Size(188, 16);
      this.Label1.TabIndex = 206;
      this.Label1.Text = "Nº Impresiones Comanda:";
      this.GroupBox_Printers.Controls.Add((Control) this.Button_Printer_Forward);
      this.GroupBox_Printers.Controls.Add((Control) this.Button_Printer_Back);
      this.GroupBox_Printers.Controls.Add((Control) this.Button_Delete_Printer);
      this.GroupBox_Printers.Controls.Add((Control) this.Button_SearchPrinters);
      this.GroupBox_Printers.Controls.Add((Control) this.DataGridView_Printers);
      this.GroupBox_Printers.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.GroupBox_Printers.ForeColor = Color.FromArgb(209, 102, 61);
      this.GroupBox_Printers.Location = new Point(26, 207);
      this.GroupBox_Printers.Name = "GroupBox_Printers";
      this.GroupBox_Printers.Size = new Size(452, 239);
      this.GroupBox_Printers.TabIndex = 182;
      this.GroupBox_Printers.TabStop = false;
      this.GroupBox_Printers.Text = "Impresoras Asignadas";
      this.Button_Printer_Forward.BackgroundImage = (Image) TriNetRestPOS.My.Resources.Resources.boton_cuadrado_plomo3;
      this.Button_Printer_Forward.FlatStyle = FlatStyle.Flat;
      this.Button_Printer_Forward.Font = new Font("Verdana", 18f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Button_Printer_Forward.ForeColor = Color.WhiteSmoke;
      this.Button_Printer_Forward.Image = (Image) TriNetRestPOS.My.Resources.Resources.flecha_abajo;
      this.Button_Printer_Forward.Location = new Point(371, 173);
      this.Button_Printer_Forward.Name = "Button_Printer_Forward";
      this.Button_Printer_Forward.RightToLeft = RightToLeft.Yes;
      this.Button_Printer_Forward.Size = new Size(75, 56);
      this.Button_Printer_Forward.TabIndex = 34;
      this.Button_Printer_Forward.UseVisualStyleBackColor = true;
      this.Button_Printer_Back.BackgroundImage = (Image) TriNetRestPOS.My.Resources.Resources.boton_cuadrado_plomo3;
      this.Button_Printer_Back.FlatStyle = FlatStyle.Flat;
      this.Button_Printer_Back.Font = new Font("Verdana", 18f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Button_Printer_Back.ForeColor = Color.WhiteSmoke;
      this.Button_Printer_Back.Image = (Image) TriNetRestPOS.My.Resources.Resources.flecha_arriba;
      this.Button_Printer_Back.Location = new Point(371, 118);
      this.Button_Printer_Back.Name = "Button_Printer_Back";
      this.Button_Printer_Back.RightToLeft = RightToLeft.Yes;
      this.Button_Printer_Back.Size = new Size(75, 56);
      this.Button_Printer_Back.TabIndex = 33;
      this.Button_Printer_Back.UseVisualStyleBackColor = true;
      this.Button_Delete_Printer.BackgroundImage = (Image) TriNetRestPOS.My.Resources.Resources.boton_cuadrado_rojo3;
      this.Button_Delete_Printer.FlatStyle = FlatStyle.Flat;
      this.Button_Delete_Printer.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Button_Delete_Printer.ForeColor = Color.WhiteSmoke;
      this.Button_Delete_Printer.Image = (Image) TriNetRestPOS.My.Resources.Resources.eliminar_icono;
      this.Button_Delete_Printer.ImageAlign = ContentAlignment.TopCenter;
      this.Button_Delete_Printer.Location = new Point(371, 63);
      this.Button_Delete_Printer.Name = "Button_Delete_Printer";
      this.Button_Delete_Printer.Padding = new Padding(0, 5, 0, 5);
      this.Button_Delete_Printer.RightToLeft = RightToLeft.Yes;
      this.Button_Delete_Printer.Size = new Size(75, 56);
      this.Button_Delete_Printer.TabIndex = 182;
      this.Button_Delete_Printer.Text = "Eliminar";
      this.Button_Delete_Printer.TextAlign = ContentAlignment.BottomCenter;
      this.Button_Delete_Printer.UseVisualStyleBackColor = true;
      this.Button_SearchPrinters.BackgroundImage = (Image) TriNetRestPOS.My.Resources.Resources.boton_cuadrado_plomo3;
      this.Button_SearchPrinters.FlatStyle = FlatStyle.Flat;
      this.Button_SearchPrinters.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Button_SearchPrinters.ForeColor = Color.WhiteSmoke;
      this.Button_SearchPrinters.Image = (Image) TriNetRestPOS.My.Resources.Resources.reenv_oc_icono;
      this.Button_SearchPrinters.ImageAlign = ContentAlignment.TopCenter;
      this.Button_SearchPrinters.Location = new Point(371, 8);
      this.Button_SearchPrinters.Name = "Button_SearchPrinters";
      this.Button_SearchPrinters.Padding = new Padding(0, 5, 0, 5);
      this.Button_SearchPrinters.Size = new Size(75, 56);
      this.Button_SearchPrinters.TabIndex = 8;
      this.Button_SearchPrinters.Text = "Impre";
      this.Button_SearchPrinters.TextAlign = ContentAlignment.BottomCenter;
      this.Button_SearchPrinters.UseVisualStyleBackColor = true;
      this.DataGridView_Printers.BorderStyle = BorderStyle.Fixed3D;
      this.DataGridView_Printers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.DataGridView_Printers.Location = new Point(6, 22);
      this.DataGridView_Printers.MultiSelect = false;
      this.DataGridView_Printers.Name = "DataGridView_Printers";
      this.DataGridView_Printers.ScrollBars = ScrollBars.None;
      this.DataGridView_Printers.Size = new Size(357, 207);
      this.DataGridView_Printers.TabIndex = 126;
      this.TextBox_PrinterId.BackColor = Color.White;
      this.TextBox_PrinterId.Font = new Font("Trebuchet MS", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.TextBox_PrinterId.Location = new Point(330, 114);
      this.TextBox_PrinterId.Name = "TextBox_PrinterId";
      this.TextBox_PrinterId.ReadOnly = true;
      this.TextBox_PrinterId.Size = new Size(43, 25);
      this.TextBox_PrinterId.TabIndex = 181;
      this.TextBox_PrinterId.Visible = false;
      this.CheckBox_IsActive.AutoSize = true;
      this.CheckBox_IsActive.FlatStyle = FlatStyle.Flat;
      this.CheckBox_IsActive.Location = new Point(99, 465);
      this.CheckBox_IsActive.Name = "CheckBox_IsActive";
      this.CheckBox_IsActive.Size = new Size(12, 11);
      this.CheckBox_IsActive.TabIndex = 9;
      this.CheckBox_IsActive.UseVisualStyleBackColor = true;
      this.Label_IsActive.AutoSize = true;
      this.Label_IsActive.Font = new Font("Trebuchet MS", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Label_IsActive.ForeColor = Color.FromArgb(150, 150, 150);
      this.Label_IsActive.Location = new Point(26, 460);
      this.Label_IsActive.Name = "Label_IsActive";
      this.Label_IsActive.Size = new Size(60, 20);
      this.Label_IsActive.TabIndex = 163;
      this.Label_IsActive.Text = "Activo:";
      this.TextBox_DesShort.BorderStyle = BorderStyle.FixedSingle;
      this.TextBox_DesShort.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.TextBox_DesShort.Location = new Point(26, 141);
      this.TextBox_DesShort.MaxLength = 25;
      this.TextBox_DesShort.Name = "TextBox_DesShort";
      this.TextBox_DesShort.Size = new Size(360, 22);
      this.TextBox_DesShort.TabIndex = 3;
      this.Label_DesShort.AutoSize = true;
      this.Label_DesShort.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Label_DesShort.ForeColor = Color.FromArgb(150, 150, 150);
      this.Label_DesShort.Location = new Point(24, 117);
      this.Label_DesShort.Name = "Label_DesShort";
      this.Label_DesShort.Size = new Size(136, 16);
      this.Label_DesShort.TabIndex = 155;
      this.Label_DesShort.Text = "Descripción Corta:";
      this.Label_Des.AutoSize = true;
      this.Label_Des.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Label_Des.ForeColor = Color.FromArgb(150, 150, 150);
      this.Label_Des.Location = new Point(22, 41);
      this.Label_Des.Name = "Label_Des";
      this.Label_Des.Size = new Size(95, 16);
      this.Label_Des.TabIndex = 151;
      this.Label_Des.Text = "Descripción:";
      this.TextBox_Des.BorderStyle = BorderStyle.FixedSingle;
      this.TextBox_Des.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.TextBox_Des.Location = new Point(26, 63);
      this.TextBox_Des.MaxLength = 50;
      this.TextBox_Des.Multiline = true;
      this.TextBox_Des.Name = "TextBox_Des";
      this.TextBox_Des.Size = new Size(360, 46);
      this.TextBox_Des.TabIndex = 1;
      this.Label_Id.AutoSize = true;
      this.Label_Id.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Label_Id.ForeColor = Color.FromArgb(150, 150, 150);
      this.Label_Id.Location = new Point(23, 12);
      this.Label_Id.Name = "Label_Id";
      this.Label_Id.Size = new Size(62, 16);
      this.Label_Id.TabIndex = 149;
      this.Label_Id.Text = "Código:";
      this.TextBox_Id.BackColor = Color.LightGray;
      this.TextBox_Id.BorderStyle = BorderStyle.FixedSingle;
      this.TextBox_Id.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.TextBox_Id.Location = new Point(99, 9);
      this.TextBox_Id.Name = "TextBox_Id";
      this.TextBox_Id.ReadOnly = true;
      this.TextBox_Id.Size = new Size(150, 22);
      this.TextBox_Id.TabIndex = 148;
      this.Button_CloseTab.BackgroundImage = (Image) TriNetRestPOS.My.Resources.Resources.BotonRojo;
      this.Button_CloseTab.FlatStyle = FlatStyle.Flat;
      this.Button_CloseTab.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Button_CloseTab.ForeColor = Color.WhiteSmoke;
      this.Button_CloseTab.Image = (Image) TriNetRestPOS.My.Resources.Resources.salir;
      this.Button_CloseTab.ImageAlign = ContentAlignment.TopCenter;
      this.Button_CloseTab.Location = new Point(372, 449);
      this.Button_CloseTab.Name = "Button_CloseTab";
      this.Button_CloseTab.Padding = new Padding(0, 5, 0, 5);
      this.Button_CloseTab.Size = new Size(114, 60);
      this.Button_CloseTab.TabIndex = 159;
      this.Button_CloseTab.Text = "&Atrás";
      this.Button_CloseTab.TextAlign = ContentAlignment.BottomCenter;
      this.Button_CloseTab.UseVisualStyleBackColor = true;
      this.Button_Save.BackgroundImage = (Image) TriNetRestPOS.My.Resources.Resources.BotonVerde;
      this.Button_Save.FlatStyle = FlatStyle.Flat;
      this.Button_Save.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Button_Save.ForeColor = Color.WhiteSmoke;
      this.Button_Save.Image = (Image) TriNetRestPOS.My.Resources.Resources.check_OK;
      this.Button_Save.ImageAlign = ContentAlignment.TopCenter;
      this.Button_Save.Location = new Point(245, 449);
      this.Button_Save.Name = "Button_Save";
      this.Button_Save.Padding = new Padding(0, 5, 0, 5);
      this.Button_Save.Size = new Size(119, 60);
      this.Button_Save.TabIndex = 10;
      this.Button_Save.Text = "&Grabar";
      this.Button_Save.TextAlign = ContentAlignment.BottomCenter;
      this.Button_Save.UseVisualStyleBackColor = true;
      this.Button_KBoard_DesShort.BackgroundImage = (Image) TriNetRestPOS.My.Resources.Resources.teclado_icon;
      this.Button_KBoard_DesShort.FlatStyle = FlatStyle.Flat;
      this.Button_KBoard_DesShort.Font = new Font("Trebuchet MS", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Button_KBoard_DesShort.ForeColor = Color.WhiteSmoke;
      this.Button_KBoard_DesShort.ImageAlign = ContentAlignment.BottomCenter;
      this.Button_KBoard_DesShort.Location = new Point(392, 139);
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
      this.Button_KBoard_Des.Location = new Point(392, 61);
      this.Button_KBoard_Des.Name = "Button_KBoard_Des";
      this.Button_KBoard_Des.Size = new Size(45, 27);
      this.Button_KBoard_Des.TabIndex = 2;
      this.Button_KBoard_Des.TextAlign = ContentAlignment.TopCenter;
      this.Button_KBoard_Des.UseVisualStyleBackColor = true;
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
      this.StatusStrip_Properties.Location = new Point(0, 555);
      this.StatusStrip_Properties.Name = "StatusStrip_Properties";
      this.StatusStrip_Properties.Size = new Size(524, 22);
      this.StatusStrip_Properties.TabIndex = 2;
      this.StatusStrip_Properties.Text = "StatusStrip1";
      this.ToolStripStatusLabel_Operation.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.ToolStripStatusLabel_Operation.ForeColor = Color.Black;
      this.ToolStripStatusLabel_Operation.LinkColor = Color.Black;
      this.ToolStripStatusLabel_Operation.Name = "ToolStripStatusLabel_Operation";
      this.ToolStripStatusLabel_Operation.Size = new Size(17, 17);
      this.ToolStripStatusLabel_Operation.Text = "...";
      this.Tssl_Record.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Tssl_Record.ForeColor = Color.Black;
      this.Tssl_Record.LinkColor = Color.Black;
      this.Tssl_Record.Name = "Tssl_Record";
      this.Tssl_Record.Size = new Size(458, 17);
      this.Tssl_Record.Spring = true;
      this.Tssl_Record.TextAlign = ContentAlignment.MiddleRight;
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.BackColor = Color.White;
      this.ClientSize = new Size(524, 577);
      this.ControlBox = false;
      this.Controls.Add((Control) this.StatusStrip_Properties);
      this.Controls.Add((Control) this.TabControl_Data);
      this.FormBorderStyle = FormBorderStyle.FixedDialog;
      this.KeyPreview = true;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = nameof (FrmArea);
      this.ShowIcon = false;
      this.ShowInTaskbar = false;
      this.StartPosition = FormStartPosition.CenterParent;
      this.Text = "Areas";
      ((Control) this.TabControl_Data).ResumeLayout(false);
      this.TabPage_Listado.ResumeLayout(false);
      this.TabPage_Listado.PerformLayout();
      this.Panel_ButtonsActions.ResumeLayout(false);
      this.Panel_ButtonsTools.ResumeLayout(false);
      ((ISupportInitialize) this.dgrvData).EndInit();
      this.TabPage_Detail.ResumeLayout(false);
      this.TabPage_Detail.PerformLayout();
      this.GroupBox_Printers.ResumeLayout(false);
      ((ISupportInitialize) this.DataGridView_Printers).EndInit();
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

    internal virtual Label Label_Des { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual TextBox TextBox_Des
    {
      get
      {
        return this._TextBox_Des;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        KeyPressEventHandler pressEventHandler = new KeyPressEventHandler(this.Control_KeyPress);
        TextBox textBoxDes1 = this._TextBox_Des;
        if (textBoxDes1 != null)
          textBoxDes1.KeyPress -= pressEventHandler;
        this._TextBox_Des = value;
        TextBox textBoxDes2 = this._TextBox_Des;
        if (textBoxDes2 == null)
          return;
        textBoxDes2.KeyPress += pressEventHandler;
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

    internal virtual Label Label_DesShort { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

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

    internal virtual TextBox TextBox_DesShort
    {
      get
      {
        return this._TextBox_DesShort;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        KeyPressEventHandler pressEventHandler = new KeyPressEventHandler(this.Control_KeyPress);
        TextBox textBoxDesShort1 = this._TextBox_DesShort;
        if (textBoxDesShort1 != null)
          textBoxDesShort1.KeyPress -= pressEventHandler;
        this._TextBox_DesShort = value;
        TextBox textBoxDesShort2 = this._TextBox_DesShort;
        if (textBoxDesShort2 == null)
          return;
        textBoxDesShort2.KeyPress += pressEventHandler;
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

    internal virtual Label Label_IsActive { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual CheckBox CheckBox_IsActive
    {
      get
      {
        return this._CheckBox_IsActive;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        KeyPressEventHandler pressEventHandler = new KeyPressEventHandler(this.CheckBox_IsActive_KeyPress);
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

    internal virtual GroupBox GroupBox_Printers { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Button Button_Delete_Printer
    {
      get
      {
        return this._Button_Delete_Printer;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Button_Delete_Printer_Click);
        Button buttonDeletePrinter1 = this._Button_Delete_Printer;
        if (buttonDeletePrinter1 != null)
          buttonDeletePrinter1.Click -= eventHandler;
        this._Button_Delete_Printer = value;
        Button buttonDeletePrinter2 = this._Button_Delete_Printer;
        if (buttonDeletePrinter2 == null)
          return;
        buttonDeletePrinter2.Click += eventHandler;
      }
    }

    internal virtual TextBox TextBox_PrinterId { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Button Button_SearchPrinters
    {
      get
      {
        return this._Button_SearchPrinters;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Button_SearchPrinters_Click);
        Button buttonSearchPrinters1 = this._Button_SearchPrinters;
        if (buttonSearchPrinters1 != null)
          buttonSearchPrinters1.Click -= eventHandler;
        this._Button_SearchPrinters = value;
        Button buttonSearchPrinters2 = this._Button_SearchPrinters;
        if (buttonSearchPrinters2 == null)
          return;
        buttonSearchPrinters2.Click += eventHandler;
      }
    }

    internal virtual DataGridView DataGridView_Printers { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Button Button_Printer_Back
    {
      get
      {
        return this._Button_Printer_Back;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Button_Printer_Back_Click);
        Button buttonPrinterBack1 = this._Button_Printer_Back;
        if (buttonPrinterBack1 != null)
          buttonPrinterBack1.Click -= eventHandler;
        this._Button_Printer_Back = value;
        Button buttonPrinterBack2 = this._Button_Printer_Back;
        if (buttonPrinterBack2 == null)
          return;
        buttonPrinterBack2.Click += eventHandler;
      }
    }

    internal virtual Button Button_Printer_Forward
    {
      get
      {
        return this._Button_Printer_Forward;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Button_Printer_Forward_Click);
        Button buttonPrinterForward1 = this._Button_Printer_Forward;
        if (buttonPrinterForward1 != null)
          buttonPrinterForward1.Click -= eventHandler;
        this._Button_Printer_Forward = value;
        Button buttonPrinterForward2 = this._Button_Printer_Forward;
        if (buttonPrinterForward2 == null)
          return;
        buttonPrinterForward2.Click += eventHandler;
      }
    }

    internal virtual StatusStrip StatusStrip_Properties { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual ToolStripStatusLabel ToolStripStatusLabel_Operation { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual ToolStripStatusLabel Tssl_Record { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Label Label1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual ComboBox ComboBox_PrintNumComma { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    private void FrmAreas_Load(object sender, EventArgs e)
    {
      this.Button_Ready.Visible = this._OnlySearch;
      this.Resource(ModGeneralFunctions.Get_Language((object) this));
      this.SetUpDataGridView();
      this.o_BL_AREA = new BL_TR1_AREA();
      this.o_BEC_AREA = new List<BE_TR1_AREA>();
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
      this.Button_Update.Text = Rm.GetString("Res_Edit");
      this.Button_Delete.Text = Rm.GetString("Res_Delete");
      this.Res_Code = Rm.GetString("Res_Code");
      this.Label_Id.Text = this.Res_Code + " :";
      this.Res_Description = Rm.GetString("Res_Description");
      this.Label_Des.Text = this.Res_Description + ":";
      this.Res_DescriptionS = Rm.GetString("Res_DescriptionS");
      this.Label_DesShort.Text = this.Res_DescriptionS + ":";
      this.Res_Observation = Rm.GetString("Res_Observation");
      this.Res_Active = Rm.GetString("Res_Active");
      this.Label_IsActive.Text = this.Res_Active + ":";
      this.Button_Delete_Printer.Text = Rm.GetString("Res_Delete");
      this.Button_Save.Text = Rm.GetString("Res_Save");
      this.Button_CloseTab.Text = Rm.GetString("Res_Back");
      this.GroupBox_Printers.Text = Rm.GetString("Res_PrinterA");
      this.Res_MsgSave = Rm.GetString("Res_MsgSave");
      ModGeneralVar.g_Res_Description = Rm.GetString("Res_InputDescription");
    }

    private void LoadData()
    {
      this.dgrvData.DataSource = !this._OnlySearch ? (object) this.o_BL_AREA.List(ModGeneralVar.g_BE_TR1_VARIABLES_B.get_EstabliId()) : (object) this.o_BL_AREA.ListaxActivos(ModGeneralVar.g_BE_TR1_VARIABLES_B.get_EstabliId(), "");
      this.Information_Quantity_Of_Records();
      this.FirstTab((short) 0, "Listado de Áreas");
    }

    private void LoadDataByDes(string _Des)
    {
      this.o_BEC_AREA = (List<BE_TR1_AREA>) null;
      this.o_BEC_AREA = new List<BE_TR1_AREA>();
      this.dgrvData.DataSource = !this._OnlySearch ? (object) this.o_BL_AREA.SearchByDes(ModGeneralVar.g_BE_TR1_VARIABLES_B.get_EstabliId(), _Des) : (object) this.o_BL_AREA.ListaxActivos(ModGeneralVar.g_BE_TR1_VARIABLES_B.get_EstabliId(), _Des);
      this.Information_Quantity_Of_Records();
      this.FirstTab((short) 0, "Listado de Áreas");
    }

    private void SetUpDataGridView()
    {
      ModGeneralFunctions.SetUpDataGridViewBasicNuevo(this.dgrvData);
      this.dgrvData.Columns.Add("AreaDes", this.Res_Description);
      ModGeneralFunctions.SetUp_TextBoxColumn1((DataGridViewTextBoxColumn) this.dgrvData.Columns[0], "AreaDes", (short) 335, "", true, DataGridViewContentAlignment.MiddleLeft, true);
      this.dgrvData.Columns.Add((DataGridViewColumn) new DataGridViewCheckBoxColumn());
      ModGeneralFunctions.SetUp_CheckBoxColumn1((DataGridViewCheckBoxColumn) this.dgrvData.Columns[1], this.Res_Active, "IsActive", (short) 75, "", true);
      ModGeneralFunctions.SetUpDataGridViewBasicNuevo(this.DataGridView_Printers);
      this.DataGridView_Printers.Columns.Add("PrinterDes", this.Res_Description);
      ModGeneralFunctions.SetUp_TextBoxColumn1((DataGridViewTextBoxColumn) this.DataGridView_Printers.Columns[0], "PrinterDes", (short) 340, "", true, DataGridViewContentAlignment.MiddleLeft, true);
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
        this.TextBox_Des.Text = "";
        this.TextBox_DesShort.Text = "";
        this.TextBox_PrinterId.Text = "";
        this.ComboBox_PrintNumComma.SelectedIndex = 0;
        this.CheckBox_IsActive.CheckState = CheckState.Checked;
        ((TabControl) this.TabControl_Data).SelectedIndex = 1;
        this.TextBox_Des.Focus();
        this.o_BEC_PRINTERS = new List<BE_TR1_PRINTERS>();
        this.o_BEC_PRINTERS_Delete = new List<BE_TR1_PRINTERS>();
        this.DataGridView_Printers.DataSource = (object) null;
      }
      else if (Operators.CompareString(_Operation, StructApp.RECORD_EDIT, false) == 0)
      {
        this.TextBox_Id.Text = Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateIndexGet(this.dgrvData.DataSource, new object[1]
        {
          (object) this.dgrvData.CurrentRow.Index
        }, (string[]) null), (System.Type) null, "AreaId", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
        this.TextBox_Des.Text = Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateIndexGet(this.dgrvData.DataSource, new object[1]
        {
          (object) this.dgrvData.CurrentRow.Index
        }, (string[]) null), (System.Type) null, "AreaDes", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
        this.TextBox_DesShort.Text = Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateIndexGet(this.dgrvData.DataSource, new object[1]
        {
          (object) this.dgrvData.CurrentRow.Index
        }, (string[]) null), (System.Type) null, "AreaDesShort", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
        this.CheckBox_IsActive.Checked = (Conversions.ToBoolean(NewLateBinding.LateGet(NewLateBinding.LateIndexGet(this.dgrvData.DataSource, new object[1]
        {
          (object) this.dgrvData.CurrentRow.Index
        }, (string[]) null), (System.Type) null, "IsActive", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null)) ? 1 : 0) != 0;
        this.ComboBox_PrintNumComma.Text = Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateIndexGet(this.dgrvData.DataSource, new object[1]
        {
          (object) this.dgrvData.CurrentRow.Index
        }, (string[]) null), (System.Type) null, "PrintNumComma", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
        this.FirstTab((short) 1, "Editar Registro");
        this.TextBox_Des.Focus();
        this.o_BEC_PRINTERS = new List<BE_TR1_PRINTERS>();
        this.o_BEC_PRINTERS = this.o_BL_TR1_PRINTERS.ListByArea(this.TextBox_Id.Text);
        this.o_BEC_PRINTERS_Delete = new List<BE_TR1_PRINTERS>();
        this.DataGridView_Printers.DataSource = (object) this.o_BEC_PRINTERS;
      }
      else
      {
        if (Operators.CompareString(_Operation, StructApp.RECORD_DELETE, false) != 0)
          return;
        this.TextBox_Id.Text = Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateIndexGet(this.dgrvData.DataSource, new object[1]
        {
          (object) this.dgrvData.CurrentRow.Index
        }, (string[]) null), (System.Type) null, "AreaId", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
        this.TextBox_Des.Text = Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateIndexGet(this.dgrvData.DataSource, new object[1]
        {
          (object) this.dgrvData.CurrentRow.Index
        }, (string[]) null), (System.Type) null, "AreaDes", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
        this.MakeOperation(this.ToolStripStatusLabel_OperationText.Text);
      }
    }

    private void MakeOperation(string _Operation)
    {
      BL_TR1_AREA blTr1Area = new BL_TR1_AREA();
      if (Operators.CompareString(_Operation, StructApp.RECORD_CREATE, false) == 0)
      {
        if (!this.ValidateData() || !ModGeneralFunctions.MessageMakeAction(this.Res_MsgSave, false) || this.DataGridView_Printers.RowCount == 0 && !ModGeneralFunctions.MessageMakeAction("¡Esta Seguro de Grabar sin Asignar Una Impresora!", false))
          return;
        BE_TR1_AREA beTr1Area = new BE_TR1_AREA();
        beTr1Area.set_EstabliId(ModGeneralVar.g_BE_TR1_VARIABLES_B.get_EstabliId());
        beTr1Area.set_AreaDes(this.TextBox_Des.Text);
        beTr1Area.set_AreaDesShort(this.TextBox_DesShort.Text);
        beTr1Area.set_IsActive(this.CheckBox_IsActive.Checked);
        beTr1Area.set_UserId(ModGeneralVar.g_BE_USERS.get_UserId());
        beTr1Area.set_PrintNumComma(Convert.ToInt32(this.ComboBox_PrintNumComma.Text));
        this.o_BEC_PRINTERS.AddRange((IEnumerable<BE_TR1_PRINTERS>) this.o_BEC_PRINTERS_Delete);
        if (blTr1Area.VerifyDesExist(ref beTr1Area))
        {
          ModGeneralFunctions.MessageOk("¡EL NOMBRE DEL AREA YA EXISTE!");
          this.TextBox_Des.Focus();
        }
        else
        {
          int num1 = this.o_BL_AREA.Add(ref beTr1Area);
          if ((uint) num1 > 0U)
          {
            int num2 = checked (this.o_BEC_PRINTERS.Count - 1);
            int index = 0;
            while (index <= num2)
            {
              this.o_BEC_PRINTERS[index].set_EstabliId(ModGeneralVar.g_BE_TR1_VARIABLES_B.get_EstabliId());
              this.o_BEC_PRINTERS[index].set_AreaId(Conversions.ToString(num1));
              checked { ++index; }
            }
            this.str_Result = this.o_BL_TR1_PRINTERS.AddToAreaPrinter(this.o_BEC_PRINTERS);
            if ((uint) Operators.CompareString(this.str_Result, StructApp.RESULT_OK, false) > 0U)
            {
              ModGeneralFunctions.MessageError_Large(this.str_Result, true);
              return;
            }
            this.LoadData();
            this.Ubicate_Record(beTr1Area.get_AreaId());
            this.Information_Quantity_Of_Records();
            ModGeneralFunctions.MessageOk("[Registro Creado]");
          }
          else
            ModGeneralFunctions.MessageError_Large(this.str_Result, true);
          beTr1Area = (BE_TR1_AREA) null;
          this.FirstTab((short) 0, "Listado de Áreas");
        }
      }
      else if (Operators.CompareString(_Operation, StructApp.RECORD_EDIT, false) == 0)
      {
        if (!this.ValidateData() || !ModGeneralFunctions.MessageMakeAction("¿Esta Seguro de Editar el Registro?", false))
          return;
        BE_TR1_AREA beTr1Area = new BE_TR1_AREA();
        beTr1Area.set_EstabliId(ModGeneralVar.g_BE_TR1_VARIABLES_B.get_EstabliId());
        beTr1Area.set_AreaId(Conversions.ToInteger(this.TextBox_Id.Text));
        beTr1Area.set_AreaDes(this.TextBox_Des.Text);
        beTr1Area.set_AreaDesShort(this.TextBox_DesShort.Text);
        beTr1Area.set_IsActive(this.CheckBox_IsActive.Checked);
        beTr1Area.set_UserId(ModGeneralVar.g_BE_USERS.get_UserId());
        beTr1Area.set_PrintNumComma(Convert.ToInt32(this.ComboBox_PrintNumComma.Text));
        this.o_BEC_PRINTERS.AddRange((IEnumerable<BE_TR1_PRINTERS>) this.o_BEC_PRINTERS_Delete);
        this.str_Result = this.o_BL_TR1_PRINTERS.AddToAreaPrinter(this.o_BEC_PRINTERS);
        if ((uint) Operators.CompareString(this.str_Result, StructApp.RESULT_OK, false) > 0U)
          ModGeneralFunctions.MessageError_Large(this.str_Result, true);
        else if (blTr1Area.VerifyDesExist(ref beTr1Area))
        {
          ModGeneralFunctions.MessageOk("EL NOMBRE DEL AREA YA EXISTE");
          this.TextBox_Des.Focus();
        }
        else
        {
          beTr1Area.set_AreaId(Conversions.ToInteger(this.TextBox_Id.Text));
          this.str_Result = this.o_BL_AREA.Edit(ref beTr1Area);
          if (Operators.CompareString(this.str_Result, StructApp.RESULT_OK, false) == 0)
          {
            short index = checked ((short) this.dgrvData.CurrentRow.Index);
            this.LoadData();
            this.dgrvData.CurrentCell = this.dgrvData[1, (int) index];
            ModGeneralFunctions.MessageOk("[Registro Editado]");
          }
          else
            ModGeneralFunctions.MessageError_Large(this.str_Result, true);
          beTr1Area = (BE_TR1_AREA) null;
          this.FirstTab((short) 0, "Listado de Áreas");
        }
      }
      else if (Operators.CompareString(_Operation, StructApp.RECORD_DELETE, false) == 0)
      {
        if (!ModGeneralFunctions.MessageMakeAction("¿Seguro de Eliminar el Área: -" + this.TextBox_Des.Text + "- ?", false))
          return;
        BE_TR1_AREA beTr1Area = new BE_TR1_AREA();
        beTr1Area.set_EstabliId(ModGeneralVar.g_BE_TR1_VARIABLES_B.get_EstabliId());
        beTr1Area.set_AreaId(Conversions.ToInteger(this.TextBox_Id.Text));
        beTr1Area.set_AreaDes(this.TextBox_Des.Text);
        beTr1Area.set_UserId(ModGeneralVar.g_BE_USERS.get_UserId());
        this.str_Result = this.o_BL_AREA.Delete(beTr1Area);
        if (Operators.CompareString(this.str_Result, StructApp.RESULT_OK, false) == 0)
        {
          short index = checked ((short) this.dgrvData.CurrentRow.Index);
          this.LoadData();
          if (this.dgrvData.Rows.Count > 1 & index > (short) 0)
            this.dgrvData.CurrentCell = this.dgrvData[1, checked ((int) index - 1)];
          ModGeneralFunctions.MessageOk("[Registro Eliminado]");
        }
        else
          ModGeneralFunctions.MessageError_Large(this.str_Result, true);
        this.FirstTab((short) 0, "Listado de Áreas");
      }
      else
      {
        if (Operators.CompareString(_Operation, StructApp.RECORD_SEARCH, false) != 0)
          return;
        this.LoadDataByDes(this.TextBox_Criterio.Text);
        this.FirstTab((short) 0, "Listado de Áreas");
        this.Information_Quantity_Of_Records();
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
      if (this.DataGV_Validated())
      {
        if (Operators.ConditionalCompareObjectEqual(ModGeneralFunctions.ObtenerAPPCONFIG("COPIAR_MAESTROS"), (object) true, false))
          ModGeneralFunctions.MessageOk("No puedes eliminar Areas, solo copiar Maestros");
        else
          this.SetOperation(StructApp.RECORD_DELETE);
      }
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
      if (Operators.ConditionalCompareObjectEqual(ModGeneralFunctions.ObtenerAPPCONFIG("COPIAR_MAESTROS"), (object) true, false))
        ModGeneralFunctions.MessageOk("No puedes grabar Areas, solo copiar Maestros");
      else
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

    private void Button_CloseTab_Click(object sender, EventArgs e)
    {
      this.FirstTab((short) 0, "Listado de Áreas");
    }

    private void Button_Printer_Back_Click(object sender, EventArgs e)
    {
      try
      {
        this.DataGridView_Printers.DataSource = (object) null;
        this.DataGridView_Printers.DataSource = (object) this.o_BEC_PRINTERS;
        this.DataGridView_Printers.Refresh();
        if (this.DataGridView_Printers.Rows.Count <= 0)
          return;
        short num = checked ((short) (this.DataGridView_Printers.SelectedRows[0].Index - 1));
        if (num > (short) -1)
          this.DataGridView_Printers.CurrentCell = this.DataGridView_Printers[0, (int) num];
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
    }

    private void Button_SearchPrinters_Click(object sender, EventArgs e)
    {
      FrmPrinters frmPrinters = new FrmPrinters();
      frmPrinters._OnlySearch = true;
      frmPrinters._OnlyforDocuments = false;
      int num = (int) frmPrinters.ShowDialog();
      frmPrinters.Dispose();
      if (!ModGeneralVar.g_bol_IsReady)
        return;
      if ((uint) Strings.Len(ModGeneralVar.g_Str_RecordID) > 0U)
      {
        this.TextBox_PrinterId.Text = ModGeneralVar.g_Str_RecordID;
        this.str_PrinterDes = ModGeneralVar.g_Str_RecordDes;
      }
      this.AddPrinter();
      this.CheckBox_IsActive.Focus();
    }

    private void Button_Printer_Forward_Click(object sender, EventArgs e)
    {
      try
      {
        this.DataGridView_Printers.DataSource = (object) null;
        this.DataGridView_Printers.DataSource = (object) this.o_BEC_PRINTERS;
        this.DataGridView_Printers.Refresh();
        if (this.DataGridView_Printers.Rows.Count <= 0)
          return;
        short index = checked ((short) this.DataGridView_Printers.SelectedRows[0].Index);
        if ((int) index < checked (this.DataGridView_Printers.Rows.Count - 1))
          this.DataGridView_Printers.CurrentCell = this.DataGridView_Printers[0, checked ((int) index + 1)];
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
    }

    private void AddPrinter()
    {
      if (Strings.Len(this.TextBox_PrinterId.Text) == 0)
      {
        ModGeneralFunctions.MessageOk("¡Seleccione una Impresora!");
      }
      else
      {
        int num = checked (this.o_BEC_PRINTERS.Count - 1);
        int index = 0;
        while (index <= num)
        {
          if ((double) this.o_BEC_PRINTERS[index].get_PrinterId() == Conversions.ToDouble(this.TextBox_PrinterId.Text))
          {
            ModGeneralFunctions.MessageOk("La Impresora ya fue Asignada!!");
            return;
          }
          checked { ++index; }
        }
        BE_TR1_PRINTERS beTr1Printers = new BE_TR1_PRINTERS();
        beTr1Printers.set_EstabliId(ModGeneralVar.g_BE_TR1_VARIABLES_B.get_EstabliId());
        beTr1Printers.set_AreaId(this.TextBox_Id.Text);
        beTr1Printers.set_PrinterId(checked ((int) Math.Round(Conversion.Val(this.TextBox_PrinterId.Text))));
        beTr1Printers.set_PrinterDes(this.str_PrinterDes);
        beTr1Printers.set_UserId(ModGeneralVar.g_BE_USERS.get_UserId());
        beTr1Printers.set_IsAdd(true);
        this.o_BEC_PRINTERS.Add(beTr1Printers);
        this.DataGridView_Printers.DataSource = (object) null;
        this.DataGridView_Printers.DataSource = (object) this.o_BEC_PRINTERS;
      }
    }

    private void Button_Delete_Printer_Click(object sender, EventArgs e)
    {
      try
      {
        if (this.DataGridView_Printers.Rows.Count == 0)
        {
          ModGeneralFunctions.MessageOk("No existen Impresoras Asignadas!!!");
        }
        else
        {
          this.DataGridView_Printers.DataSource = (object) null;
          this.DataGridView_Printers.DataSource = (object) this.o_BEC_PRINTERS;
          this.DataGridView_Printers.Refresh();
          short index = checked ((short) this.DataGridView_Printers.CurrentRow.Index);
          this.DataGridView_Printers.DataSource = (object) null;
          BE_TR1_PRINTERS beTr1Printers1 = new BE_TR1_PRINTERS();
          BE_TR1_PRINTERS beTr1Printers2 = this.o_BEC_PRINTERS[(int) index];
          this.o_BEC_PRINTERS.RemoveAt((int) index);
          beTr1Printers2.set_IsDelete(true);
          this.o_BEC_PRINTERS_Delete.Add(beTr1Printers2);
          this.DataGridView_Printers.DataSource = (object) this.o_BEC_PRINTERS;
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
    }

    private bool ValidateData()
    {
      if (Operators.CompareString(this.TextBox_Des.Text, "", false) == 0)
      {
        ModGeneralFunctions.MessageOk(ModGeneralVar.g_Res_Description);
        this.TextBox_Des.Focus();
        return false;
      }
      if (ModGeneralFunctions.DataGrid_Validated(this.DataGridView_Printers))
        return true;
      ModGeneralFunctions.MessageOk("¡Debe Asignar Impresora!");
      this.Button_SearchPrinters.Focus();
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
  }
}
