// Decompiled with JetBrains decompiler
// Type: TriNetRestPOS.FrmAccountContable
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
  public class FrmAccountContable : Form
  {
    private IContainer components;
    private BE_TR_ACCOUNT_CONT oBE_ACCOUNT_CONT;
    private BL_TR_ACCOUNT_CONT oBL_ACCOUNT_CONT;
    private bool bol_IsAccountId1;
    private bool bol_IsAccountId2;
    private bool bol_IsAccountId3;
    private bool bol_IsAccountId4;
    private string str_IsAccountId1;
    private string str_IsAccountId2;
    private string str_IsAccountId3;
    private string str_IsAccountId4;
    private string str_AccountIndex;

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
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (FrmAccountContable));
      this.TabControl_Data = new TabControlEx();
      this.TabPage_Listado = new TabPage();
      this.TextBox_SAccount4 = new TextBox();
      this.TextBox_SAccount3 = new TextBox();
      this.TextBox_SAccount2 = new TextBox();
      this.TextBox_SAccount1 = new TextBox();
      this.Button_KBoardCriterio = new Button();
      this.Panel_ButtonsActions = new Panel();
      this.Button_GoOut = new Button();
      this.Label_Description = new Label();
      this.Panel_ButtonsTools = new Panel();
      this.Button_Back = new Button();
      this.Button_Ready = new Button();
      this.Button_Delete = new Button();
      this.Button_Forward = new Button();
      this.Button_Update = new Button();
      this.Button_New = new Button();
      this.TextBox_Criterio = new TextBox();
      this.dgrvData = new DataGridView();
      this.TabPage_Detail = new TabPage();
      this.Button_Account4 = new Button();
      this.Button_Account3 = new Button();
      this.Button_Account2 = new Button();
      this.Button_Account1 = new Button();
      this.Button_NAccount4 = new Button();
      this.Button_NAccount2 = new Button();
      this.Button_NAccount3 = new Button();
      this.Button_NAccount1 = new Button();
      this.TextBox_Account4 = new TextBox();
      this.TextBox_Account3 = new TextBox();
      this.TextBox_Account2 = new TextBox();
      this.TextBox_Account1 = new TextBox();
      this.Label4 = new Label();
      this.Label3 = new Label();
      this.Label2 = new Label();
      this.Label1 = new Label();
      this.Label_Des = new Label();
      this.TextBox_Des = new TextBox();
      this.Label_Id = new Label();
      this.TextBox_Id = new TextBox();
      this.Button_CloseTab = new Button();
      this.Button_Save = new Button();
      this.Button_KBoard_Des = new Button();
      ((Control) this.TabControl_Data).SuspendLayout();
      this.TabPage_Listado.SuspendLayout();
      this.Panel_ButtonsActions.SuspendLayout();
      this.Panel_ButtonsTools.SuspendLayout();
      ((ISupportInitialize) this.dgrvData).BeginInit();
      this.TabPage_Detail.SuspendLayout();
      this.SuspendLayout();
      ((Control) this.TabControl_Data).Controls.Add((Control) this.TabPage_Listado);
      ((Control) this.TabControl_Data).Controls.Add((Control) this.TabPage_Detail);
      ((Control) this.TabControl_Data).Font = new Font("Verdana", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      ((Control) this.TabControl_Data).Location = new Point(-1, -1);
      ((Control) this.TabControl_Data).Name = "TabControl_Data";
      ((TabControl) this.TabControl_Data).SelectedIndex = 0;
      ((Control) this.TabControl_Data).Size = new Size(522, 524);
      ((Control) this.TabControl_Data).TabIndex = 2;
      this.TabPage_Listado.Controls.Add((Control) this.TextBox_SAccount4);
      this.TabPage_Listado.Controls.Add((Control) this.TextBox_SAccount3);
      this.TabPage_Listado.Controls.Add((Control) this.TextBox_SAccount2);
      this.TabPage_Listado.Controls.Add((Control) this.TextBox_SAccount1);
      this.TabPage_Listado.Controls.Add((Control) this.Button_KBoardCriterio);
      this.TabPage_Listado.Controls.Add((Control) this.Panel_ButtonsActions);
      this.TabPage_Listado.Controls.Add((Control) this.Label_Description);
      this.TabPage_Listado.Controls.Add((Control) this.Panel_ButtonsTools);
      this.TabPage_Listado.Controls.Add((Control) this.TextBox_Criterio);
      this.TabPage_Listado.Controls.Add((Control) this.dgrvData);
      this.TabPage_Listado.Font = new Font("Verdana", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.TabPage_Listado.Location = new Point(4, 23);
      this.TabPage_Listado.Name = "TabPage_Listado";
      this.TabPage_Listado.Padding = new Padding(3);
      this.TabPage_Listado.Size = new Size(514, 497);
      this.TabPage_Listado.TabIndex = 0;
      this.TabPage_Listado.Text = "Listado";
      this.TabPage_Listado.UseVisualStyleBackColor = true;
      this.TextBox_SAccount4.BackColor = Color.White;
      this.TextBox_SAccount4.Location = new Point(219, 6);
      this.TextBox_SAccount4.Name = "TextBox_SAccount4";
      this.TextBox_SAccount4.Size = new Size(18, 23);
      this.TextBox_SAccount4.TabIndex = 205;
      this.TextBox_SAccount4.TextAlign = HorizontalAlignment.Center;
      this.TextBox_SAccount3.BackColor = Color.White;
      this.TextBox_SAccount3.Location = new Point(196, 6);
      this.TextBox_SAccount3.Name = "TextBox_SAccount3";
      this.TextBox_SAccount3.Size = new Size(18, 23);
      this.TextBox_SAccount3.TabIndex = 204;
      this.TextBox_SAccount3.TextAlign = HorizontalAlignment.Center;
      this.TextBox_SAccount2.BackColor = Color.White;
      this.TextBox_SAccount2.Location = new Point(173, 6);
      this.TextBox_SAccount2.Name = "TextBox_SAccount2";
      this.TextBox_SAccount2.Size = new Size(18, 23);
      this.TextBox_SAccount2.TabIndex = 203;
      this.TextBox_SAccount2.TextAlign = HorizontalAlignment.Center;
      this.TextBox_SAccount1.BackColor = Color.White;
      this.TextBox_SAccount1.Location = new Point(150, 6);
      this.TextBox_SAccount1.Name = "TextBox_SAccount1";
      this.TextBox_SAccount1.Size = new Size(18, 23);
      this.TextBox_SAccount1.TabIndex = 198;
      this.TextBox_SAccount1.TextAlign = HorizontalAlignment.Center;
      this.Button_KBoardCriterio.Font = new Font("Verdana", 8.25f, FontStyle.Bold);
      this.Button_KBoardCriterio.ForeColor = Color.MediumBlue;
      this.Button_KBoardCriterio.Image = (Image) componentResourceManager.GetObject("Button_KBoardCriterio.Image");
      this.Button_KBoardCriterio.Location = new Point(311, 3);
      this.Button_KBoardCriterio.Name = "Button_KBoardCriterio";
      this.Button_KBoardCriterio.Size = new Size(77, 57);
      this.Button_KBoardCriterio.TabIndex = 1;
      this.Button_KBoardCriterio.Text = "&Teclado";
      this.Button_KBoardCriterio.TextImageRelation = TextImageRelation.TextAboveImage;
      this.Button_KBoardCriterio.UseVisualStyleBackColor = true;
      this.Panel_ButtonsActions.Controls.Add((Control) this.Button_GoOut);
      this.Panel_ButtonsActions.Location = new Point(431, 2);
      this.Panel_ButtonsActions.Name = "Panel_ButtonsActions";
      this.Panel_ButtonsActions.Size = new Size(85, 63);
      this.Panel_ButtonsActions.TabIndex = 2;
      this.Button_GoOut.Font = new Font("Verdana", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Button_GoOut.ForeColor = Color.MediumBlue;
      this.Button_GoOut.Image = (Image) TriNetRestPOS.My.Resources.Resources.i_Close;
      this.Button_GoOut.Location = new Point(0, 0);
      this.Button_GoOut.Name = "Button_GoOut";
      this.Button_GoOut.Size = new Size(83, 60);
      this.Button_GoOut.TabIndex = 161;
      this.Button_GoOut.Text = "&Atrás";
      this.Button_GoOut.TextImageRelation = TextImageRelation.TextAboveImage;
      this.Button_GoOut.UseVisualStyleBackColor = true;
      this.Label_Description.AutoSize = true;
      this.Label_Description.Font = new Font("Trebuchet MS", 9.75f, FontStyle.Bold);
      this.Label_Description.ForeColor = Color.MediumBlue;
      this.Label_Description.Location = new Point(2, 15);
      this.Label_Description.Name = "Label_Description";
      this.Label_Description.Size = new Size(85, 18);
      this.Label_Description.TabIndex = 147;
      this.Label_Description.Text = "Descripción:";
      this.Panel_ButtonsTools.Controls.Add((Control) this.Button_Back);
      this.Panel_ButtonsTools.Controls.Add((Control) this.Button_Ready);
      this.Panel_ButtonsTools.Controls.Add((Control) this.Button_Delete);
      this.Panel_ButtonsTools.Controls.Add((Control) this.Button_Forward);
      this.Panel_ButtonsTools.Controls.Add((Control) this.Button_Update);
      this.Panel_ButtonsTools.Controls.Add((Control) this.Button_New);
      this.Panel_ButtonsTools.Location = new Point(431, 132);
      this.Panel_ButtonsTools.Name = "Panel_ButtonsTools";
      this.Panel_ButtonsTools.Size = new Size(87, 358);
      this.Panel_ButtonsTools.TabIndex = 146;
      this.Button_Back.Font = new Font("Verdana", 18f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Button_Back.Image = (Image) TriNetRestPOS.My.Resources.Resources.go_back;
      this.Button_Back.Location = new Point(1, 237);
      this.Button_Back.Name = "Button_Back";
      this.Button_Back.RightToLeft = RightToLeft.Yes;
      this.Button_Back.Size = new Size(83, 60);
      this.Button_Back.TabIndex = 33;
      this.Button_Back.UseVisualStyleBackColor = true;
      this.Button_Ready.Font = new Font("Verdana", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Button_Ready.ForeColor = Color.MediumBlue;
      this.Button_Ready.Image = (Image) TriNetRestPOS.My.Resources.Resources.i_Ready;
      this.Button_Ready.Location = new Point(1, 1);
      this.Button_Ready.Name = "Button_Ready";
      this.Button_Ready.Size = new Size(83, 60);
      this.Button_Ready.TabIndex = 3;
      this.Button_Ready.Text = "&Listo";
      this.Button_Ready.TextImageRelation = TextImageRelation.TextAboveImage;
      this.Button_Ready.UseVisualStyleBackColor = true;
      this.Button_Ready.Visible = false;
      this.Button_Delete.Font = new Font("Verdana", 8.25f, FontStyle.Bold);
      this.Button_Delete.ForeColor = Color.MediumBlue;
      this.Button_Delete.Image = (Image) TriNetRestPOS.My.Resources.Resources.Eliminar;
      this.Button_Delete.Location = new Point(1, 178);
      this.Button_Delete.Name = "Button_Delete";
      this.Button_Delete.RightToLeft = RightToLeft.Yes;
      this.Button_Delete.Size = new Size(83, 60);
      this.Button_Delete.TabIndex = 148;
      this.Button_Delete.Text = "&Eliminar";
      this.Button_Delete.TextImageRelation = TextImageRelation.TextAboveImage;
      this.Button_Delete.UseVisualStyleBackColor = true;
      this.Button_Forward.Font = new Font("Verdana", 18f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Button_Forward.Image = (Image) TriNetRestPOS.My.Resources.Resources.go_forward;
      this.Button_Forward.Location = new Point(1, 297);
      this.Button_Forward.Name = "Button_Forward";
      this.Button_Forward.RightToLeft = RightToLeft.Yes;
      this.Button_Forward.Size = new Size(83, 60);
      this.Button_Forward.TabIndex = 34;
      this.Button_Forward.UseVisualStyleBackColor = true;
      this.Button_Update.Font = new Font("Verdana", 8.25f, FontStyle.Bold);
      this.Button_Update.ForeColor = Color.MediumBlue;
      this.Button_Update.Image = (Image) TriNetRestPOS.My.Resources.Resources.Actualizar;
      this.Button_Update.Location = new Point(1, 119);
      this.Button_Update.Name = "Button_Update";
      this.Button_Update.Size = new Size(83, 60);
      this.Button_Update.TabIndex = 147;
      this.Button_Update.Text = "&Editar";
      this.Button_Update.TextImageRelation = TextImageRelation.TextAboveImage;
      this.Button_Update.UseVisualStyleBackColor = true;
      this.Button_New.Font = new Font("Verdana", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Button_New.ForeColor = Color.MediumBlue;
      this.Button_New.Image = (Image) TriNetRestPOS.My.Resources.Resources.i_News;
      this.Button_New.ImageAlign = ContentAlignment.BottomCenter;
      this.Button_New.Location = new Point(1, 60);
      this.Button_New.Name = "Button_New";
      this.Button_New.Size = new Size(83, 60);
      this.Button_New.TabIndex = 146;
      this.Button_New.Text = "&Nuevo";
      this.Button_New.TextImageRelation = TextImageRelation.TextAboveImage;
      this.Button_New.UseVisualStyleBackColor = true;
      this.TextBox_Criterio.Location = new Point(3, 33);
      this.TextBox_Criterio.MaxLength = 50;
      this.TextBox_Criterio.Name = "TextBox_Criterio";
      this.TextBox_Criterio.Size = new Size(299, 23);
      this.TextBox_Criterio.TabIndex = 0;
      this.dgrvData.BorderStyle = BorderStyle.Fixed3D;
      this.dgrvData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dgrvData.Location = new Point(3, 66);
      this.dgrvData.MultiSelect = false;
      this.dgrvData.Name = "dgrvData";
      this.dgrvData.ScrollBars = ScrollBars.None;
      this.dgrvData.Size = new Size(425, 424);
      this.dgrvData.TabIndex = 1;
      this.TabPage_Detail.Controls.Add((Control) this.Button_Account4);
      this.TabPage_Detail.Controls.Add((Control) this.Button_Account3);
      this.TabPage_Detail.Controls.Add((Control) this.Button_Account2);
      this.TabPage_Detail.Controls.Add((Control) this.Button_Account1);
      this.TabPage_Detail.Controls.Add((Control) this.Button_NAccount4);
      this.TabPage_Detail.Controls.Add((Control) this.Button_NAccount2);
      this.TabPage_Detail.Controls.Add((Control) this.Button_NAccount3);
      this.TabPage_Detail.Controls.Add((Control) this.Button_NAccount1);
      this.TabPage_Detail.Controls.Add((Control) this.TextBox_Account4);
      this.TabPage_Detail.Controls.Add((Control) this.TextBox_Account3);
      this.TabPage_Detail.Controls.Add((Control) this.TextBox_Account2);
      this.TabPage_Detail.Controls.Add((Control) this.TextBox_Account1);
      this.TabPage_Detail.Controls.Add((Control) this.Label4);
      this.TabPage_Detail.Controls.Add((Control) this.Label3);
      this.TabPage_Detail.Controls.Add((Control) this.Label2);
      this.TabPage_Detail.Controls.Add((Control) this.Label1);
      this.TabPage_Detail.Controls.Add((Control) this.Label_Des);
      this.TabPage_Detail.Controls.Add((Control) this.TextBox_Des);
      this.TabPage_Detail.Controls.Add((Control) this.Label_Id);
      this.TabPage_Detail.Controls.Add((Control) this.TextBox_Id);
      this.TabPage_Detail.Controls.Add((Control) this.Button_CloseTab);
      this.TabPage_Detail.Controls.Add((Control) this.Button_Save);
      this.TabPage_Detail.Controls.Add((Control) this.Button_KBoard_Des);
      this.TabPage_Detail.Location = new Point(4, 23);
      this.TabPage_Detail.Name = "TabPage_Detail";
      this.TabPage_Detail.Padding = new Padding(3);
      this.TabPage_Detail.Size = new Size(514, 497);
      this.TabPage_Detail.TabIndex = 1;
      this.TabPage_Detail.Text = "Mantenimiento";
      this.TabPage_Detail.UseVisualStyleBackColor = true;
      this.Button_Account4.Font = new Font("Verdana", 8.25f, FontStyle.Bold);
      this.Button_Account4.ForeColor = Color.MediumBlue;
      this.Button_Account4.Image = (Image) TriNetRestPOS.My.Resources.Resources.Search_G;
      this.Button_Account4.Location = new Point(351, 226);
      this.Button_Account4.Name = "Button_Account4";
      this.Button_Account4.Size = new Size(83, 60);
      this.Button_Account4.TabIndex = 197;
      this.Button_Account4.Text = "&Buscar";
      this.Button_Account4.TextImageRelation = TextImageRelation.TextAboveImage;
      this.Button_Account4.UseVisualStyleBackColor = true;
      this.Button_Account3.Font = new Font("Verdana", 8.25f, FontStyle.Bold);
      this.Button_Account3.ForeColor = Color.MediumBlue;
      this.Button_Account3.Image = (Image) TriNetRestPOS.My.Resources.Resources.Search_G;
      this.Button_Account3.Location = new Point(351, 162);
      this.Button_Account3.Name = "Button_Account3";
      this.Button_Account3.Size = new Size(83, 60);
      this.Button_Account3.TabIndex = 196;
      this.Button_Account3.Text = "&Buscar";
      this.Button_Account3.TextImageRelation = TextImageRelation.TextAboveImage;
      this.Button_Account3.UseVisualStyleBackColor = true;
      this.Button_Account2.Font = new Font("Verdana", 8.25f, FontStyle.Bold);
      this.Button_Account2.ForeColor = Color.MediumBlue;
      this.Button_Account2.Image = (Image) TriNetRestPOS.My.Resources.Resources.Search_G;
      this.Button_Account2.Location = new Point(351, 98);
      this.Button_Account2.Name = "Button_Account2";
      this.Button_Account2.Size = new Size(83, 60);
      this.Button_Account2.TabIndex = 195;
      this.Button_Account2.Text = "&Buscar";
      this.Button_Account2.TextImageRelation = TextImageRelation.TextAboveImage;
      this.Button_Account2.UseVisualStyleBackColor = true;
      this.Button_Account1.Font = new Font("Verdana", 8.25f, FontStyle.Bold);
      this.Button_Account1.ForeColor = Color.MediumBlue;
      this.Button_Account1.Image = (Image) TriNetRestPOS.My.Resources.Resources.Search_G;
      this.Button_Account1.Location = new Point(351, 35);
      this.Button_Account1.Name = "Button_Account1";
      this.Button_Account1.Size = new Size(83, 60);
      this.Button_Account1.TabIndex = 194;
      this.Button_Account1.Text = "&Buscar";
      this.Button_Account1.TextImageRelation = TextImageRelation.TextAboveImage;
      this.Button_Account1.UseVisualStyleBackColor = true;
      this.Button_NAccount4.Font = new Font("Verdana", 8.25f, FontStyle.Bold);
      this.Button_NAccount4.ForeColor = Color.MediumBlue;
      this.Button_NAccount4.Image = (Image) TriNetRestPOS.My.Resources.Resources.KeyBoard;
      this.Button_NAccount4.Location = new Point(262, 226);
      this.Button_NAccount4.Name = "Button_NAccount4";
      this.Button_NAccount4.Size = new Size(72, 60);
      this.Button_NAccount4.TabIndex = 193;
      this.Button_NAccount4.Text = "&Teclado";
      this.Button_NAccount4.TextImageRelation = TextImageRelation.TextAboveImage;
      this.Button_NAccount4.UseVisualStyleBackColor = true;
      this.Button_NAccount2.Font = new Font("Verdana", 8.25f, FontStyle.Bold);
      this.Button_NAccount2.ForeColor = Color.MediumBlue;
      this.Button_NAccount2.Image = (Image) TriNetRestPOS.My.Resources.Resources.KeyBoard;
      this.Button_NAccount2.Location = new Point(262, 98);
      this.Button_NAccount2.Name = "Button_NAccount2";
      this.Button_NAccount2.Size = new Size(72, 60);
      this.Button_NAccount2.TabIndex = 192;
      this.Button_NAccount2.Text = "&Teclado";
      this.Button_NAccount2.TextImageRelation = TextImageRelation.TextAboveImage;
      this.Button_NAccount2.UseVisualStyleBackColor = true;
      this.Button_NAccount3.Font = new Font("Verdana", 8.25f, FontStyle.Bold);
      this.Button_NAccount3.ForeColor = Color.MediumBlue;
      this.Button_NAccount3.Image = (Image) TriNetRestPOS.My.Resources.Resources.KeyBoard;
      this.Button_NAccount3.Location = new Point(262, 162);
      this.Button_NAccount3.Name = "Button_NAccount3";
      this.Button_NAccount3.Size = new Size(72, 60);
      this.Button_NAccount3.TabIndex = 191;
      this.Button_NAccount3.Text = "&Teclado";
      this.Button_NAccount3.TextImageRelation = TextImageRelation.TextAboveImage;
      this.Button_NAccount3.UseVisualStyleBackColor = true;
      this.Button_NAccount1.Font = new Font("Verdana", 8.25f, FontStyle.Bold);
      this.Button_NAccount1.ForeColor = Color.MediumBlue;
      this.Button_NAccount1.Image = (Image) TriNetRestPOS.My.Resources.Resources.KeyBoard;
      this.Button_NAccount1.Location = new Point(262, 35);
      this.Button_NAccount1.Name = "Button_NAccount1";
      this.Button_NAccount1.Size = new Size(72, 60);
      this.Button_NAccount1.TabIndex = 190;
      this.Button_NAccount1.Text = "&Teclado";
      this.Button_NAccount1.TextImageRelation = TextImageRelation.TextAboveImage;
      this.Button_NAccount1.UseVisualStyleBackColor = true;
      this.TextBox_Account4.BackColor = Color.White;
      this.TextBox_Account4.Location = new Point(164, 245);
      this.TextBox_Account4.Name = "TextBox_Account4";
      this.TextBox_Account4.Size = new Size(82, 22);
      this.TextBox_Account4.TabIndex = 189;
      this.TextBox_Account4.TextAlign = HorizontalAlignment.Center;
      this.TextBox_Account3.BackColor = Color.White;
      this.TextBox_Account3.Location = new Point(164, 184);
      this.TextBox_Account3.Name = "TextBox_Account3";
      this.TextBox_Account3.Size = new Size(82, 22);
      this.TextBox_Account3.TabIndex = 188;
      this.TextBox_Account3.TextAlign = HorizontalAlignment.Center;
      this.TextBox_Account2.BackColor = Color.White;
      this.TextBox_Account2.Location = new Point(164, 119);
      this.TextBox_Account2.Name = "TextBox_Account2";
      this.TextBox_Account2.Size = new Size(82, 22);
      this.TextBox_Account2.TabIndex = 187;
      this.TextBox_Account2.TextAlign = HorizontalAlignment.Center;
      this.TextBox_Account1.BackColor = Color.White;
      this.TextBox_Account1.Location = new Point(164, 57);
      this.TextBox_Account1.Name = "TextBox_Account1";
      this.TextBox_Account1.Size = new Size(82, 22);
      this.TextBox_Account1.TabIndex = 186;
      this.TextBox_Account1.TextAlign = HorizontalAlignment.Center;
      this.Label4.AutoSize = true;
      this.Label4.Font = new Font("Trebuchet MS", 12f, FontStyle.Bold);
      this.Label4.ForeColor = Color.MediumBlue;
      this.Label4.Location = new Point(20, 245);
      this.Label4.Name = "Label4";
      this.Label4.Size = new Size(129, 22);
      this.Label4.TabIndex = 185;
      this.Label4.Text = "Nº De Cuenta 4:";
      this.Label3.AutoSize = true;
      this.Label3.Font = new Font("Trebuchet MS", 12f, FontStyle.Bold);
      this.Label3.ForeColor = Color.MediumBlue;
      this.Label3.Location = new Point(20, 184);
      this.Label3.Name = "Label3";
      this.Label3.Size = new Size(129, 22);
      this.Label3.TabIndex = 184;
      this.Label3.Text = "Nº De Cuenta 3:";
      this.Label2.AutoSize = true;
      this.Label2.Font = new Font("Trebuchet MS", 12f, FontStyle.Bold);
      this.Label2.ForeColor = Color.MediumBlue;
      this.Label2.Location = new Point(20, 119);
      this.Label2.Name = "Label2";
      this.Label2.Size = new Size(129, 22);
      this.Label2.TabIndex = 183;
      this.Label2.Text = "Nº De Cuenta 2:";
      this.Label1.AutoSize = true;
      this.Label1.Font = new Font("Trebuchet MS", 12f, FontStyle.Bold);
      this.Label1.ForeColor = Color.MediumBlue;
      this.Label1.Location = new Point(20, 57);
      this.Label1.Name = "Label1";
      this.Label1.Size = new Size(129, 22);
      this.Label1.TabIndex = 182;
      this.Label1.Text = "Nº De Cuenta 1:";
      this.Label_Des.AutoSize = true;
      this.Label_Des.Font = new Font("Trebuchet MS", 12f, FontStyle.Bold);
      this.Label_Des.ForeColor = Color.MediumBlue;
      this.Label_Des.Location = new Point(20, 293);
      this.Label_Des.Name = "Label_Des";
      this.Label_Des.Size = new Size(105, 22);
      this.Label_Des.TabIndex = 151;
      this.Label_Des.Text = "Descripción:";
      this.TextBox_Des.Location = new Point(24, 318);
      this.TextBox_Des.MaxLength = 50;
      this.TextBox_Des.Multiline = true;
      this.TextBox_Des.Name = "TextBox_Des";
      this.TextBox_Des.Size = new Size(310, 78);
      this.TextBox_Des.TabIndex = 1;
      this.Label_Id.AutoSize = true;
      this.Label_Id.Font = new Font("Trebuchet MS", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Label_Id.ForeColor = Color.MediumBlue;
      this.Label_Id.Location = new Point(20, 16);
      this.Label_Id.Name = "Label_Id";
      this.Label_Id.Size = new Size(69, 22);
      this.Label_Id.TabIndex = 149;
      this.Label_Id.Text = "Código:";
      this.TextBox_Id.BackColor = Color.FromArgb((int) byte.MaxValue, 240, 144);
      this.TextBox_Id.Location = new Point(164, 13);
      this.TextBox_Id.Name = "TextBox_Id";
      this.TextBox_Id.ReadOnly = true;
      this.TextBox_Id.Size = new Size(82, 22);
      this.TextBox_Id.TabIndex = 148;
      this.Button_CloseTab.Font = new Font("Verdana", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Button_CloseTab.ForeColor = Color.MediumBlue;
      this.Button_CloseTab.Image = (Image) TriNetRestPOS.My.Resources.Resources.i_Close;
      this.Button_CloseTab.Location = new Point(351, 431);
      this.Button_CloseTab.Name = "Button_CloseTab";
      this.Button_CloseTab.Size = new Size(121, 60);
      this.Button_CloseTab.TabIndex = 159;
      this.Button_CloseTab.Text = "Salir";
      this.Button_CloseTab.TextImageRelation = TextImageRelation.TextAboveImage;
      this.Button_CloseTab.UseVisualStyleBackColor = true;
      this.Button_Save.Font = new Font("Verdana", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Button_Save.ForeColor = Color.MediumBlue;
      this.Button_Save.Image = (Image) TriNetRestPOS.My.Resources.Resources.i_Ready;
      this.Button_Save.Location = new Point(224, 431);
      this.Button_Save.Name = "Button_Save";
      this.Button_Save.Size = new Size(121, 60);
      this.Button_Save.TabIndex = 10;
      this.Button_Save.Text = "Grabar";
      this.Button_Save.TextImageRelation = TextImageRelation.TextAboveImage;
      this.Button_Save.UseVisualStyleBackColor = true;
      this.Button_KBoard_Des.Font = new Font("Verdana", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Button_KBoard_Des.ForeColor = Color.MediumBlue;
      this.Button_KBoard_Des.Image = (Image) componentResourceManager.GetObject("Button_KBoard_Des.Image");
      this.Button_KBoard_Des.ImageAlign = ContentAlignment.BottomCenter;
      this.Button_KBoard_Des.Location = new Point(351, 318);
      this.Button_KBoard_Des.Name = "Button_KBoard_Des";
      this.Button_KBoard_Des.Size = new Size(83, 59);
      this.Button_KBoard_Des.TabIndex = 2;
      this.Button_KBoard_Des.TextAlign = ContentAlignment.TopCenter;
      this.Button_KBoard_Des.UseVisualStyleBackColor = true;
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.BackColor = Color.White;
      this.ClientSize = new Size(517, 522);
      this.Controls.Add((Control) this.TabControl_Data);
      this.Name = nameof (FrmAccountContable);
      this.StartPosition = FormStartPosition.CenterParent;
      this.Text = "[Cuentas Contables]";
      ((Control) this.TabControl_Data).ResumeLayout(false);
      this.TabPage_Listado.ResumeLayout(false);
      this.TabPage_Listado.PerformLayout();
      this.Panel_ButtonsActions.ResumeLayout(false);
      this.Panel_ButtonsTools.ResumeLayout(false);
      ((ISupportInitialize) this.dgrvData).EndInit();
      this.TabPage_Detail.ResumeLayout(false);
      this.TabPage_Detail.PerformLayout();
      this.ResumeLayout(false);
    }

    internal virtual TabControlEx TabControl_Data { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual TabPage TabPage_Listado { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Panel Panel_ButtonsActions { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Button Button_KBoardCriterio { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Button Button_GoOut { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Button Button_Ready { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Label Label_Description { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Panel Panel_ButtonsTools { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Button Button_Back { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Button Button_Delete { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Button Button_Forward { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Button Button_Update { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Button Button_New { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual TextBox TextBox_Criterio { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual DataGridView dgrvData
    {
      get
      {
        return this._dgrvData;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        DataGridViewCellEventHandler cellEventHandler = new DataGridViewCellEventHandler(this.dgrvData_CellClick);
        DataGridView dgrvData1 = this._dgrvData;
        if (dgrvData1 != null)
          dgrvData1.CellClick -= cellEventHandler;
        this._dgrvData = value;
        DataGridView dgrvData2 = this._dgrvData;
        if (dgrvData2 == null)
          return;
        dgrvData2.CellClick += cellEventHandler;
      }
    }

    internal virtual TabPage TabPage_Detail { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual TextBox TextBox_Account4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual TextBox TextBox_Account3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual TextBox TextBox_Account2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual TextBox TextBox_Account1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Label Label4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Label Label3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Label Label2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Label Label1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Label Label_Des { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual TextBox TextBox_Des { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Label Label_Id { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual TextBox TextBox_Id { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Button Button_CloseTab { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Button Button_Save { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

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

    internal virtual Button Button_NAccount4
    {
      get
      {
        return this._Button_NAccount4;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Button_NAccount4_Click);
        Button buttonNaccount4_1 = this._Button_NAccount4;
        if (buttonNaccount4_1 != null)
          buttonNaccount4_1.Click -= eventHandler;
        this._Button_NAccount4 = value;
        Button buttonNaccount4_2 = this._Button_NAccount4;
        if (buttonNaccount4_2 == null)
          return;
        buttonNaccount4_2.Click += eventHandler;
      }
    }

    internal virtual Button Button_NAccount2
    {
      get
      {
        return this._Button_NAccount2;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Button_NAccount2_Click);
        Button buttonNaccount2_1 = this._Button_NAccount2;
        if (buttonNaccount2_1 != null)
          buttonNaccount2_1.Click -= eventHandler;
        this._Button_NAccount2 = value;
        Button buttonNaccount2_2 = this._Button_NAccount2;
        if (buttonNaccount2_2 == null)
          return;
        buttonNaccount2_2.Click += eventHandler;
      }
    }

    internal virtual Button Button_NAccount3
    {
      get
      {
        return this._Button_NAccount3;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Button_NAccount3_Click);
        Button buttonNaccount3_1 = this._Button_NAccount3;
        if (buttonNaccount3_1 != null)
          buttonNaccount3_1.Click -= eventHandler;
        this._Button_NAccount3 = value;
        Button buttonNaccount3_2 = this._Button_NAccount3;
        if (buttonNaccount3_2 == null)
          return;
        buttonNaccount3_2.Click += eventHandler;
      }
    }

    internal virtual Button Button_NAccount1
    {
      get
      {
        return this._Button_NAccount1;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Button_NAccount1_Click);
        Button buttonNaccount1_1 = this._Button_NAccount1;
        if (buttonNaccount1_1 != null)
          buttonNaccount1_1.Click -= eventHandler;
        this._Button_NAccount1 = value;
        Button buttonNaccount1_2 = this._Button_NAccount1;
        if (buttonNaccount1_2 == null)
          return;
        buttonNaccount1_2.Click += eventHandler;
      }
    }

    internal virtual Button Button_Account4
    {
      get
      {
        return this._Button_Account4;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Button_Account4_Click);
        Button buttonAccount4_1 = this._Button_Account4;
        if (buttonAccount4_1 != null)
          buttonAccount4_1.Click -= eventHandler;
        this._Button_Account4 = value;
        Button buttonAccount4_2 = this._Button_Account4;
        if (buttonAccount4_2 == null)
          return;
        buttonAccount4_2.Click += eventHandler;
      }
    }

    internal virtual Button Button_Account3
    {
      get
      {
        return this._Button_Account3;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Button_Account3_Click);
        Button buttonAccount3_1 = this._Button_Account3;
        if (buttonAccount3_1 != null)
          buttonAccount3_1.Click -= eventHandler;
        this._Button_Account3 = value;
        Button buttonAccount3_2 = this._Button_Account3;
        if (buttonAccount3_2 == null)
          return;
        buttonAccount3_2.Click += eventHandler;
      }
    }

    internal virtual Button Button_Account2
    {
      get
      {
        return this._Button_Account2;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Button_Account2_Click);
        Button buttonAccount2_1 = this._Button_Account2;
        if (buttonAccount2_1 != null)
          buttonAccount2_1.Click -= eventHandler;
        this._Button_Account2 = value;
        Button buttonAccount2_2 = this._Button_Account2;
        if (buttonAccount2_2 == null)
          return;
        buttonAccount2_2.Click += eventHandler;
      }
    }

    internal virtual Button Button_Account1
    {
      get
      {
        return this._Button_Account1;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Button_Account1_Click);
        Button buttonAccount1_1 = this._Button_Account1;
        if (buttonAccount1_1 != null)
          buttonAccount1_1.Click -= eventHandler;
        this._Button_Account1 = value;
        Button buttonAccount1_2 = this._Button_Account1;
        if (buttonAccount1_2 == null)
          return;
        buttonAccount1_2.Click += eventHandler;
      }
    }

    internal virtual TextBox TextBox_SAccount1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual TextBox TextBox_SAccount4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual TextBox TextBox_SAccount3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual TextBox TextBox_SAccount2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    public FrmAccountContable()
    {
      this.Load += new EventHandler(this.FrmAccountContable_Load);
      this.bol_IsAccountId1 = false;
      this.bol_IsAccountId2 = false;
      this.bol_IsAccountId3 = false;
      this.bol_IsAccountId4 = false;
      this.str_IsAccountId1 = "";
      this.str_IsAccountId2 = "";
      this.str_IsAccountId3 = "";
      this.str_IsAccountId4 = "";
      this.oBL_ACCOUNT_CONT = new BL_TR_ACCOUNT_CONT();
      this.InitializeComponent();
    }

    private void Button_Account1_Click(object sender, EventArgs e)
    {
      FrmSearchOrderDetail searchOrderDetail = new FrmSearchOrderDetail();
      this.oBE_ACCOUNT_CONT = new BE_TR_ACCOUNT_CONT();
      searchOrderDetail.bol_IsAccountCont = true;
      searchOrderDetail._IsAccountId1 = true;
      searchOrderDetail._oBE_ACCOUNT_CONT = this.oBE_ACCOUNT_CONT;
      int num = (int) searchOrderDetail.ShowDialog();
      if (!ModGeneralVar.g_bol_IsReady)
        return;
      this.TextBox_Account1.Text = ModGeneralVar.g_Str_RecordID;
    }

    private void Button_Account2_Click(object sender, EventArgs e)
    {
      if (Operators.CompareString(this.TextBox_Account1.Text, "", false) == 0)
      {
        ModGeneralFunctions.MessageOk("Ingrese un Nº de Cuenta Contable 1");
      }
      else
      {
        FrmSearchOrderDetail searchOrderDetail = new FrmSearchOrderDetail();
        this.oBE_ACCOUNT_CONT = new BE_TR_ACCOUNT_CONT();
        this.oBE_ACCOUNT_CONT.set_AccountContId1(this.TextBox_Account1.Text);
        this.oBE_ACCOUNT_CONT.set_AccountContId2("");
        this.oBE_ACCOUNT_CONT.set_AccountContId3("");
        this.oBE_ACCOUNT_CONT.set_AccountContId4("");
        searchOrderDetail.bol_IsAccountCont = true;
        searchOrderDetail._IsAccountId2 = true;
        searchOrderDetail._oBE_ACCOUNT_CONT = this.oBE_ACCOUNT_CONT;
        int num = (int) searchOrderDetail.ShowDialog();
        if (!ModGeneralVar.g_bol_IsReady)
          return;
        this.TextBox_Account2.Text = ModGeneralVar.g_Str_RecordID;
      }
    }

    private void Button_Account3_Click(object sender, EventArgs e)
    {
      if (Operators.CompareString(this.TextBox_Account2.Text, "", false) == 0)
      {
        ModGeneralFunctions.MessageOk("Ingrese un Nº de Cuenta Contable 2");
      }
      else
      {
        FrmSearchOrderDetail searchOrderDetail = new FrmSearchOrderDetail();
        this.oBE_ACCOUNT_CONT = new BE_TR_ACCOUNT_CONT();
        this.oBE_ACCOUNT_CONT.set_AccountContId1(this.TextBox_Account1.Text);
        this.oBE_ACCOUNT_CONT.set_AccountContId2(this.TextBox_Account2.Text);
        this.oBE_ACCOUNT_CONT.set_AccountContId3("");
        this.oBE_ACCOUNT_CONT.set_AccountContId4("");
        searchOrderDetail.bol_IsAccountCont = true;
        searchOrderDetail._IsAccountId3 = true;
        searchOrderDetail._oBE_ACCOUNT_CONT = this.oBE_ACCOUNT_CONT;
        int num = (int) searchOrderDetail.ShowDialog();
        if (!ModGeneralVar.g_bol_IsReady)
          return;
        this.TextBox_Account3.Text = ModGeneralVar.g_Str_RecordID;
      }
    }

    private void Button_Account4_Click(object sender, EventArgs e)
    {
      if (Operators.CompareString(this.TextBox_Account3.Text, "", false) == 0)
      {
        ModGeneralFunctions.MessageOk("Ingrese un Nº de Cuenta Contable 3");
      }
      else
      {
        FrmSearchOrderDetail searchOrderDetail = new FrmSearchOrderDetail();
        this.oBE_ACCOUNT_CONT = new BE_TR_ACCOUNT_CONT();
        this.oBE_ACCOUNT_CONT.set_AccountContId1(this.TextBox_Account1.Text);
        this.oBE_ACCOUNT_CONT.set_AccountContId2(this.TextBox_Account2.Text);
        this.oBE_ACCOUNT_CONT.set_AccountContId3(this.TextBox_Account3.Text);
        this.oBE_ACCOUNT_CONT.set_AccountContId4("");
        searchOrderDetail.bol_IsAccountCont = true;
        searchOrderDetail._IsAccountId4 = true;
        searchOrderDetail._oBE_ACCOUNT_CONT = this.oBE_ACCOUNT_CONT;
        int num = (int) searchOrderDetail.ShowDialog();
        if (!ModGeneralVar.g_bol_IsReady)
          ;
      }
    }

    private void Button_NAccount1_Click(object sender, EventArgs e)
    {
      ModGeneralFunctions.NumberKeyBoard("", false);
      if (Strings.Len(ModGeneralVar.g_str_InputValue) <= 0)
        return;
      this.TextBox_Account1.Text = ModGeneralVar.g_str_InputValue;
    }

    private void Button_NAccount2_Click(object sender, EventArgs e)
    {
      if (Operators.CompareString(this.TextBox_Account1.Text, "", false) == 0)
      {
        ModGeneralFunctions.MessageOk("Ingrese un Nº de Cuenta Contable 1");
      }
      else
      {
        ModGeneralFunctions.NumberKeyBoard("", false);
        if (Strings.Len(ModGeneralVar.g_str_InputValue) > 0)
          this.TextBox_Account2.Text = ModGeneralVar.g_str_InputValue;
      }
    }

    private void Button_NAccount3_Click(object sender, EventArgs e)
    {
      if (Operators.CompareString(this.TextBox_Account2.Text, "", false) == 0)
      {
        ModGeneralFunctions.MessageOk("Ingrese un Nº de Cuenta Contable 2");
      }
      else
      {
        ModGeneralFunctions.NumberKeyBoard("", false);
        if (Strings.Len(ModGeneralVar.g_str_InputValue) > 0)
          this.TextBox_Account3.Text = ModGeneralVar.g_str_InputValue;
      }
    }

    private void Button_NAccount4_Click(object sender, EventArgs e)
    {
      if (Operators.CompareString(this.TextBox_Account3.Text, "", false) == 0)
      {
        ModGeneralFunctions.MessageOk("Ingrese un Nº de Cuenta Contable 3");
      }
      else
      {
        ModGeneralFunctions.NumberKeyBoard("", false);
        if (Strings.Len(ModGeneralVar.g_str_InputValue) > 0)
          this.TextBox_Account4.Text = ModGeneralVar.g_str_InputValue;
      }
    }

    private void Button_KBoard_Des_Click(object sender, EventArgs e)
    {
      TextBox textBoxDes;
      string text = (textBoxDes = this.TextBox_Des).Text;
      ModGeneralFunctions.TextKeyBoard("Ingrese Descripción", ref text);
      textBoxDes.Text = text;
      if (!ModGeneralVar.g_bol_IsReady)
        return;
      this.TextBox_Des.Text = ModGeneralVar.g_str_InputValue;
    }

    private void FrmAccountContable_Load(object sender, EventArgs e)
    {
      this.SetUpDataGridViewAccountCont();
      this.bol_IsAccountId1 = true;
      this.LoadData();
    }

    private void LoadData()
    {
      this.dgrvData.DataSource = (object) this.oBL_ACCOUNT_CONT.List(this.bol_IsAccountId1, this.bol_IsAccountId2, this.bol_IsAccountId3, this.bol_IsAccountId4, this.str_IsAccountId1, this.str_IsAccountId2, this.str_IsAccountId3, this.str_IsAccountId4);
    }

    private void SetUpDataGridViewAccountCont()
    {
      ModGeneralFunctions.SetUpDataGridViewBasic(this.dgrvData);
      this.dgrvData.Columns.Add("AccountContId1", "Nº Cuenta");
      ModGeneralFunctions.SetUp_TextBoxColumn((DataGridViewTextBoxColumn) this.dgrvData.Columns[0], "AccountContId1", (short) 50, "", true, DataGridViewContentAlignment.MiddleLeft, true);
      this.dgrvData.Columns.Add("AccountContDesc", "Descipción");
      ModGeneralFunctions.SetUp_TextBoxColumn((DataGridViewTextBoxColumn) this.dgrvData.Columns[1], "AccountContDesc", (short) 358, "", true, DataGridViewContentAlignment.MiddleLeft, true);
    }

    private void dgrvData_CellClick(object sender, DataGridViewCellEventArgs e)
    {
      this.str_AccountIndex = Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateIndexGet(this.dgrvData.DataSource, new object[1]
      {
        (object) this.dgrvData.CurrentRow.Index
      }, (string[]) null), (System.Type) null, "AccountContId1", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
    }
  }
}
