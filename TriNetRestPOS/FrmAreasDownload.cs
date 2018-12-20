// Decompiled with JetBrains decompiler
// Type: TriNetRestPOS.FrmAreasDownload
// Assembly: TriNetRestPOS, Version=5.2.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 43377352-E952-4AC1-9BA6-CCBE4AE5F575
// Assembly location: C:\log\TriNetRestPOS.exe

using Microsoft.VisualBasic;
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
  public class FrmAreasDownload : Form
  {
    private IContainer components;
    private string _strProductId;
    private string _strNameForm;
    private List<BE_TR1_AREA> o_ListArea;

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
      this.DataGridView_Areas = new DataGridView();
      this.pnlData = new Panel();
      this.pnlOptions = new Panel();
      this.Button_Ready = new Button();
      this.Button_Area_Forward = new Button();
      this.Button_Area_Back = new Button();
      ((ISupportInitialize) this.DataGridView_Areas).BeginInit();
      this.pnlData.SuspendLayout();
      this.pnlOptions.SuspendLayout();
      this.SuspendLayout();
      this.DataGridView_Areas.BorderStyle = BorderStyle.Fixed3D;
      this.DataGridView_Areas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.DataGridView_Areas.Dock = DockStyle.Fill;
      this.DataGridView_Areas.Location = new Point(0, 0);
      this.DataGridView_Areas.MultiSelect = false;
      this.DataGridView_Areas.Name = "DataGridView_Areas";
      this.DataGridView_Areas.ScrollBars = ScrollBars.None;
      this.DataGridView_Areas.Size = new Size(363, 218);
      this.DataGridView_Areas.TabIndex = (int) sbyte.MaxValue;
      this.pnlData.Controls.Add((Control) this.DataGridView_Areas);
      this.pnlData.Dock = DockStyle.Left;
      this.pnlData.Location = new Point(0, 0);
      this.pnlData.Name = "pnlData";
      this.pnlData.Size = new Size(363, 218);
      this.pnlData.TabIndex = 205;
      this.pnlOptions.Controls.Add((Control) this.Button_Ready);
      this.pnlOptions.Controls.Add((Control) this.Button_Area_Forward);
      this.pnlOptions.Controls.Add((Control) this.Button_Area_Back);
      this.pnlOptions.Dock = DockStyle.Right;
      this.pnlOptions.Location = new Point(363, 0);
      this.pnlOptions.Name = "pnlOptions";
      this.pnlOptions.Size = new Size(81, 218);
      this.pnlOptions.TabIndex = 206;
      this.Button_Ready.Font = new Font("Trebuchet MS", 24f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Button_Ready.ForeColor = Color.MediumBlue;
      this.Button_Ready.Image = (Image) TriNetRestPOS.My.Resources.Resources.i_Ready;
      this.Button_Ready.Location = new Point(1, 1);
      this.Button_Ready.Name = "Button_Ready";
      this.Button_Ready.Size = new Size(79, 98);
      this.Button_Ready.TabIndex = 207;
      this.Button_Ready.Text = "OK";
      this.Button_Ready.TextImageRelation = TextImageRelation.TextAboveImage;
      this.Button_Ready.UseVisualStyleBackColor = true;
      this.Button_Area_Forward.Font = new Font("Verdana", 18f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Button_Area_Forward.Image = (Image) TriNetRestPOS.My.Resources.Resources.go_forward;
      this.Button_Area_Forward.Location = new Point(1, 157);
      this.Button_Area_Forward.Name = "Button_Area_Forward";
      this.Button_Area_Forward.RightToLeft = RightToLeft.Yes;
      this.Button_Area_Forward.Size = new Size(79, 60);
      this.Button_Area_Forward.TabIndex = 206;
      this.Button_Area_Forward.UseVisualStyleBackColor = true;
      this.Button_Area_Back.Font = new Font("Verdana", 18f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Button_Area_Back.Image = (Image) TriNetRestPOS.My.Resources.Resources.go_back;
      this.Button_Area_Back.Location = new Point(1, 98);
      this.Button_Area_Back.Name = "Button_Area_Back";
      this.Button_Area_Back.RightToLeft = RightToLeft.Yes;
      this.Button_Area_Back.Size = new Size(79, 60);
      this.Button_Area_Back.TabIndex = 205;
      this.Button_Area_Back.UseVisualStyleBackColor = true;
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.BackColor = SystemColors.Window;
      this.ClientSize = new Size(444, 218);
      this.Controls.Add((Control) this.pnlOptions);
      this.Controls.Add((Control) this.pnlData);
      this.FormBorderStyle = FormBorderStyle.FixedDialog;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = nameof (FrmAreasDownload);
      this.ShowIcon = false;
      this.ShowInTaskbar = false;
      this.StartPosition = FormStartPosition.CenterParent;
      this.Text = "Áreas de Descarga: ";
      ((ISupportInitialize) this.DataGridView_Areas).EndInit();
      this.pnlData.ResumeLayout(false);
      this.pnlOptions.ResumeLayout(false);
      this.ResumeLayout(false);
    }

    internal virtual DataGridView DataGridView_Areas
    {
      get
      {
        return this._DataGridView_Areas;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.DataGridView_Areas_DoubleClick);
        KeyPressEventHandler pressEventHandler = new KeyPressEventHandler(this.DataGridView_Areas_KeyPress);
        DataGridView dataGridViewAreas1 = this._DataGridView_Areas;
        if (dataGridViewAreas1 != null)
        {
          dataGridViewAreas1.DoubleClick -= eventHandler;
          dataGridViewAreas1.KeyPress -= pressEventHandler;
        }
        this._DataGridView_Areas = value;
        DataGridView dataGridViewAreas2 = this._DataGridView_Areas;
        if (dataGridViewAreas2 == null)
          return;
        dataGridViewAreas2.DoubleClick += eventHandler;
        dataGridViewAreas2.KeyPress += pressEventHandler;
      }
    }

    internal virtual Panel pnlData { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Panel pnlOptions { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

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

    internal virtual Button Button_Area_Forward
    {
      get
      {
        return this._Button_Area_Forward;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Button_Area_Forward_Click);
        Button buttonAreaForward1 = this._Button_Area_Forward;
        if (buttonAreaForward1 != null)
          buttonAreaForward1.Click -= eventHandler;
        this._Button_Area_Forward = value;
        Button buttonAreaForward2 = this._Button_Area_Forward;
        if (buttonAreaForward2 == null)
          return;
        buttonAreaForward2.Click += eventHandler;
      }
    }

    internal virtual Button Button_Area_Back
    {
      get
      {
        return this._Button_Area_Back;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Button_Area_Back_Click);
        Button buttonAreaBack1 = this._Button_Area_Back;
        if (buttonAreaBack1 != null)
          buttonAreaBack1.Click -= eventHandler;
        this._Button_Area_Back = value;
        Button buttonAreaBack2 = this._Button_Area_Back;
        if (buttonAreaBack2 == null)
          return;
        buttonAreaBack2.Click += eventHandler;
      }
    }

    public FrmAreasDownload(string pstrProductId, string pstrNameForm)
    {
      this.Load += new EventHandler(this.FrmAreasDownload_Load);
      this._strProductId = "";
      this._strNameForm = "";
      this.InitializeComponent();
      this._strProductId = pstrProductId;
      this._strNameForm = pstrNameForm;
    }

    private void FrmAreasDownload_Load(object sender, EventArgs e)
    {
      this.Text += Strings.UCase(this._strNameForm);
      this.SetupDataGrid();
      this.LoadData();
    }

    private void SetupDataGrid()
    {
      ModGeneralFunctions.SetUpDataGridViewBasic(this.DataGridView_Areas);
      this.DataGridView_Areas.Columns.Add("AreaIdStore", "Código");
      ModGeneralFunctions.SetUp_TextBoxColumn((DataGridViewTextBoxColumn) this.DataGridView_Areas.Columns[0], "AreaIdStore", (short) 0, "", false, DataGridViewContentAlignment.MiddleLeft, true);
      this.DataGridView_Areas.Columns.Add("AreaDesStore", "Descripción");
      ModGeneralFunctions.SetUp_TextBoxColumn((DataGridViewTextBoxColumn) this.DataGridView_Areas.Columns[1], "AreaDesStore", (short) 350, "", true, DataGridViewContentAlignment.MiddleLeft, true);
    }

    private void Button_Area_Back_Click(object sender, EventArgs e)
    {
      if (this.DataGridView_Areas.Rows.Count <= 0)
        return;
      short num = checked ((short) (this.DataGridView_Areas.CurrentRow.Index - 1));
      if (num > (short) -1)
        this.DataGridView_Areas.CurrentCell = this.DataGridView_Areas[1, (int) num];
    }

    private void LoadData()
    {
      BL_TR1_PRODUCTS blTr1Products = new BL_TR1_PRODUCTS();
      this.o_ListArea = new List<BE_TR1_AREA>();
      this.o_ListArea = blTr1Products.ListAreasDownload(this._strProductId);
      this.DataGridView_Areas.DataSource = (object) this.o_ListArea;
    }

    private void Button_Area_Forward_Click(object sender, EventArgs e)
    {
      if (this.DataGridView_Areas.Rows.Count <= 0)
        return;
      short index = checked ((short) this.DataGridView_Areas.CurrentRow.Index);
      if ((int) index < checked (this.DataGridView_Areas.Rows.Count - 1))
        this.DataGridView_Areas.CurrentCell = this.DataGridView_Areas[1, checked ((int) index + 1)];
    }

    private void Button_Ready_Click(object sender, EventArgs e)
    {
      if (!ModGeneralFunctions.DataGrid_Validated(this.DataGridView_Areas))
        return;
      this.o_ListArea[this.DataGridView_Areas.CurrentRow.Index].get_AreaDesStore();
      BE_TR1_PRODUCTS beTr1Products = new BE_TR1_PRODUCTS();
      BL_TR1_PRODUCTS blTr1Products = new BL_TR1_PRODUCTS();
      beTr1Products.set_AreaId(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateIndexGet(this.DataGridView_Areas.DataSource, new object[1]
      {
        (object) this.DataGridView_Areas.CurrentRow.Index
      }, (string[]) null), (System.Type) null, "AreaIdStore", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null)));
      beTr1Products.set_AreaDesS(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateIndexGet(this.DataGridView_Areas.DataSource, new object[1]
      {
        (object) this.DataGridView_Areas.CurrentRow.Index
      }, (string[]) null), (System.Type) null, "AreaDesStore", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null)));
      beTr1Products.set_PriceCost(Conversions.ToDouble(NewLateBinding.LateGet(NewLateBinding.LateIndexGet(this.DataGridView_Areas.DataSource, new object[1]
      {
        (object) this.DataGridView_Areas.CurrentRow.Index
      }, (string[]) null), (System.Type) null, "ProductPriceCost", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null)));
      beTr1Products.set_ProductId(this._strProductId);
      if (!NewLateBinding.LateGet(ModGeneralFunctions.ObtenerAPPCONFIG("AREAIDSTORE"), (System.Type) null, "Trim", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null).Equals((object) ""))
        beTr1Products.set_AreaId(Conversions.ToString(ModGeneralFunctions.ObtenerAPPCONFIG("AREAIDSTORE")));
      blTr1Products.EditProduct_Download(beTr1Products);
      ModGeneralVar.g_bol_IsReady = true;
      this.Close();
    }

    private void DataGridView_Areas_DoubleClick(object sender, EventArgs e)
    {
      this.Button_Ready_Click(RuntimeHelpers.GetObjectValue(sender), (EventArgs) null);
    }

    private void DataGridView_Areas_KeyPress(object sender, KeyPressEventArgs e)
    {
      if (!ModGeneralFunctions.Question_Made_Enter(e))
        return;
      this.Button_Ready_Click((object) null, (EventArgs) null);
    }
  }
}
