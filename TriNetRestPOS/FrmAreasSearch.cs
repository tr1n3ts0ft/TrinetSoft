// Decompiled with JetBrains decompiler
// Type: TriNetRestPOS.FrmAreasSearch
// Assembly: TriNetRestPOS, Version=5.2.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 43377352-E952-4AC1-9BA6-CCBE4AE5F575
// Assembly location: C:\log\TriNetRestPOS.exe

using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using TR2_BusinessEntity;
using TR2_BusinessLogic;

namespace TriNetRestPOS
{
  [DesignerGenerated]
  public class FrmAreasSearch : Form
  {
    private IContainer components;
    private string str_DEscription;

    public FrmAreasSearch()
    {
      this.Load += new EventHandler(this.FrmAreasSearch_Load);
      this.str_DEscription = "";
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
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (FrmAreasSearch));
      this.Button_Selection = new Button();
      this.StatusStrip1 = new StatusStrip();
      this.ToolStripStatusLabel_RecordsText = new ToolStripStatusLabel();
      this.Button_GoOutD = new Button();
      this.dgrvData = new DataGridView();
      this.Label_Description = new Label();
      this.TextBox_Criterio = new TextBox();
      this.Panel_ButtonsLocation = new Panel();
      this.Button_First = new Button();
      this.Button_Back = new Button();
      this.Button_Forward = new Button();
      this.Button_Last = new Button();
      this.StatusStrip1.SuspendLayout();
      ((ISupportInitialize) this.dgrvData).BeginInit();
      this.Panel_ButtonsLocation.SuspendLayout();
      this.SuspendLayout();
      this.Button_Selection.Font = new Font("Verdana", 7f, FontStyle.Bold);
      this.Button_Selection.ForeColor = Color.MediumBlue;
      this.Button_Selection.Image = (Image) TriNetRestPOS.My.Resources.Resources.Ready;
      this.Button_Selection.ImageAlign = ContentAlignment.BottomCenter;
      this.Button_Selection.Location = new Point(392, 154);
      this.Button_Selection.Name = "Button_Selection";
      this.Button_Selection.Size = new Size(55, 46);
      this.Button_Selection.TabIndex = 161;
      this.Button_Selection.Text = "&Listo";
      this.Button_Selection.TextAlign = ContentAlignment.TopCenter;
      this.Button_Selection.UseVisualStyleBackColor = true;
      this.StatusStrip1.BackColor = SystemColors.ControlLightLight;
      this.StatusStrip1.Items.AddRange(new ToolStripItem[1]
      {
        (ToolStripItem) this.ToolStripStatusLabel_RecordsText
      });
      this.StatusStrip1.Location = new Point(0, 459);
      this.StatusStrip1.Name = "StatusStrip1";
      this.StatusStrip1.Size = new Size(448, 22);
      this.StatusStrip1.TabIndex = 160;
      this.StatusStrip1.Text = "StatusStrip1";
      this.ToolStripStatusLabel_RecordsText.Font = new Font("Verdana", 6.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.ToolStripStatusLabel_RecordsText.ForeColor = Color.MediumBlue;
      this.ToolStripStatusLabel_RecordsText.Name = "ToolStripStatusLabel_RecordsText";
      this.ToolStripStatusLabel_RecordsText.Size = new Size(90, 17);
      this.ToolStripStatusLabel_RecordsText.Text = "Listado De Áreas";
      this.Button_GoOutD.Font = new Font("Verdana", 7f, FontStyle.Bold);
      this.Button_GoOutD.ForeColor = Color.MediumBlue;
      this.Button_GoOutD.Image = (Image) componentResourceManager.GetObject("Button_GoOutD.Image");
      this.Button_GoOutD.ImageAlign = ContentAlignment.BottomCenter;
      this.Button_GoOutD.Location = new Point(392, 3);
      this.Button_GoOutD.Name = "Button_GoOutD";
      this.Button_GoOutD.Size = new Size(55, 46);
      this.Button_GoOutD.TabIndex = 159;
      this.Button_GoOutD.Text = "&Cerrar";
      this.Button_GoOutD.TextAlign = ContentAlignment.TopCenter;
      this.Button_GoOutD.UseVisualStyleBackColor = true;
      this.dgrvData.BorderStyle = BorderStyle.Fixed3D;
      this.dgrvData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dgrvData.Location = new Point(5, 53);
      this.dgrvData.MultiSelect = false;
      this.dgrvData.Name = "dgrvData";
      this.dgrvData.ScrollBars = ScrollBars.None;
      this.dgrvData.Size = new Size(385, 390);
      this.dgrvData.TabIndex = 156;
      this.Label_Description.AutoSize = true;
      this.Label_Description.Font = new Font("Verdana", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Label_Description.ForeColor = Color.MediumBlue;
      this.Label_Description.Location = new Point(2, 10);
      this.Label_Description.Name = "Label_Description";
      this.Label_Description.Size = new Size(91, 16);
      this.Label_Description.TabIndex = 158;
      this.Label_Description.Text = "Buscar por:";
      this.TextBox_Criterio.Font = new Font("Verdana", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.TextBox_Criterio.Location = new Point(5, 29);
      this.TextBox_Criterio.Name = "TextBox_Criterio";
      this.TextBox_Criterio.Size = new Size((int) byte.MaxValue, 21);
      this.TextBox_Criterio.TabIndex = 155;
      this.Panel_ButtonsLocation.Controls.Add((Control) this.Button_First);
      this.Panel_ButtonsLocation.Controls.Add((Control) this.Button_Back);
      this.Panel_ButtonsLocation.Controls.Add((Control) this.Button_Forward);
      this.Panel_ButtonsLocation.Controls.Add((Control) this.Button_Last);
      this.Panel_ButtonsLocation.Location = new Point(392, 199);
      this.Panel_ButtonsLocation.Name = "Panel_ButtonsLocation";
      this.Panel_ButtonsLocation.Size = new Size(57, 187);
      this.Panel_ButtonsLocation.TabIndex = 157;
      this.Button_First.Font = new Font("Verdana", 18f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Button_First.Image = (Image) TriNetRestPOS.My.Resources.Resources.Fast_back;
      this.Button_First.Location = new Point(1, 1);
      this.Button_First.Name = "Button_First";
      this.Button_First.RightToLeft = RightToLeft.Yes;
      this.Button_First.Size = new Size(55, 46);
      this.Button_First.TabIndex = 8;
      this.Button_First.UseVisualStyleBackColor = true;
      this.Button_Back.Font = new Font("Verdana", 18f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Button_Back.Image = (Image) TriNetRestPOS.My.Resources.Resources.go_back;
      this.Button_Back.Location = new Point(1, 47);
      this.Button_Back.Name = "Button_Back";
      this.Button_Back.RightToLeft = RightToLeft.Yes;
      this.Button_Back.Size = new Size(55, 46);
      this.Button_Back.TabIndex = 9;
      this.Button_Back.UseVisualStyleBackColor = true;
      this.Button_Forward.Font = new Font("Verdana", 18f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Button_Forward.Image = (Image) TriNetRestPOS.My.Resources.Resources.go_forward;
      this.Button_Forward.Location = new Point(1, 93);
      this.Button_Forward.Name = "Button_Forward";
      this.Button_Forward.RightToLeft = RightToLeft.Yes;
      this.Button_Forward.Size = new Size(55, 46);
      this.Button_Forward.TabIndex = 10;
      this.Button_Forward.UseVisualStyleBackColor = true;
      this.Button_Last.Font = new Font("Verdana", 18f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Button_Last.Image = (Image) TriNetRestPOS.My.Resources.Resources.fast_forward;
      this.Button_Last.Location = new Point(1, 139);
      this.Button_Last.Name = "Button_Last";
      this.Button_Last.RightToLeft = RightToLeft.Yes;
      this.Button_Last.Size = new Size(55, 46);
      this.Button_Last.TabIndex = 11;
      this.Button_Last.UseVisualStyleBackColor = true;
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.BackColor = SystemColors.ActiveCaptionText;
      this.ClientSize = new Size(448, 481);
      this.ControlBox = false;
      this.Controls.Add((Control) this.Button_Selection);
      this.Controls.Add((Control) this.StatusStrip1);
      this.Controls.Add((Control) this.Button_GoOutD);
      this.Controls.Add((Control) this.dgrvData);
      this.Controls.Add((Control) this.Label_Description);
      this.Controls.Add((Control) this.TextBox_Criterio);
      this.Controls.Add((Control) this.Panel_ButtonsLocation);
      this.FormBorderStyle = FormBorderStyle.FixedDialog;
      this.Name = nameof (FrmAreasSearch);
      this.StartPosition = FormStartPosition.CenterParent;
      this.Text = "Áreas";
      this.StatusStrip1.ResumeLayout(false);
      this.StatusStrip1.PerformLayout();
      ((ISupportInitialize) this.dgrvData).EndInit();
      this.Panel_ButtonsLocation.ResumeLayout(false);
      this.ResumeLayout(false);
      this.PerformLayout();
    }

    internal virtual Button Button_Selection
    {
      get
      {
        return this._Button_Selection;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Button_Selection_Click);
        Button buttonSelection1 = this._Button_Selection;
        if (buttonSelection1 != null)
          buttonSelection1.Click -= eventHandler;
        this._Button_Selection = value;
        Button buttonSelection2 = this._Button_Selection;
        if (buttonSelection2 == null)
          return;
        buttonSelection2.Click += eventHandler;
      }
    }

    internal virtual StatusStrip StatusStrip1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual ToolStripStatusLabel ToolStripStatusLabel_RecordsText { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Button Button_GoOutD
    {
      get
      {
        return this._Button_GoOutD;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Button_GoOutD_Click);
        Button buttonGoOutD1 = this._Button_GoOutD;
        if (buttonGoOutD1 != null)
          buttonGoOutD1.Click -= eventHandler;
        this._Button_GoOutD = value;
        Button buttonGoOutD2 = this._Button_GoOutD;
        if (buttonGoOutD2 == null)
          return;
        buttonGoOutD2.Click += eventHandler;
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

    internal virtual Label Label_Description { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

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

    private void FrmAreasSearch_Load(object sender, EventArgs e)
    {
      this.SetUpDataGridView();
      this.LoadData();
    }

    private void SetUpDataGridView()
    {
      ModGeneralFunctions.SetUpDataGridViewBasicTR2(this.dgrvData);
      this.dgrvData.Columns.Add("AreaId", "Cod");
      ModGeneralFunctions.SetUp_TextBoxColumn((DataGridViewTextBoxColumn) this.dgrvData.Columns[0], "AreaId", (short) 55, "", true, DataGridViewContentAlignment.MiddleLeft, true);
      this.dgrvData.Columns.Add("AreaDes", "Descripción");
      ModGeneralFunctions.SetUp_TextBoxColumn((DataGridViewTextBoxColumn) this.dgrvData.Columns[1], "AreaDes", (short) 313, "", true, DataGridViewContentAlignment.MiddleLeft, true);
    }

    private void LoadData()
    {
      BL_TR2_AREA blTr2Area = new BL_TR2_AREA();
      List<BE_TR2_AREAS> beTr2AreasList = new List<BE_TR2_AREAS>();
      this.dgrvData.DataSource = (object) blTr2Area.SearchByDesSubArea(this.str_DEscription);
      this.dgrvData.ScrollBars = ScrollBars.None;
      beTr2AreasList = (List<BE_TR2_AREAS>) null;
    }

    private void Button_GoOutD_Click(object sender, EventArgs e)
    {
      this.Close();
    }

    private void TextBox_Criterio_TextChanged(object sender, EventArgs e)
    {
      this.str_DEscription = this.TextBox_Criterio.Text;
      this.LoadData();
    }

    private void Button_Selection_Click(object sender, EventArgs e)
    {
      if (!this.DataGRV_Validated())
        return;
      this.SelectITem();
      ModGeneralVar.g_bol_IsReady = true;
      this.Close();
    }

    public bool DataGRV_Validated()
    {
      return this.dgrvData.Rows.Count > 0;
    }

    private void SelectITem()
    {
      ModGeneralVar.g_Str_RecordID = Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateIndexGet(this.dgrvData.DataSource, new object[1]
      {
        (object) this.dgrvData.CurrentRow.Index
      }, (string[]) null), (System.Type) null, "AreaID", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      ModGeneralVar.g_Str_RecordDes = Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateIndexGet(this.dgrvData.DataSource, new object[1]
      {
        (object) this.dgrvData.CurrentRow.Index
      }, (string[]) null), (System.Type) null, "AreaDes", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
    }

    private void Button_First_Click(object sender, EventArgs e)
    {
      if (!this.DataGRV_Validated() || this.dgrvData.Rows.Count <= 0)
        return;
      this.dgrvData.CurrentCell = this.dgrvData[0, 0];
      this.Information_Quantity_Of_Records();
      this.SelectITem();
    }

    private void Button_Back_Click(object sender, EventArgs e)
    {
      if (!this.DataGRV_Validated())
        return;
      short num = checked ((short) (this.dgrvData.CurrentRow.Index - 1));
      if (this.dgrvData.Rows.Count > 0 & num > (short) -1)
      {
        this.dgrvData.CurrentCell = this.dgrvData[1, (int) num];
        this.Information_Quantity_Of_Records();
        this.SelectITem();
      }
    }

    private void Button_Forward_Click(object sender, EventArgs e)
    {
      if (!this.DataGRV_Validated())
        return;
      short index = checked ((short) this.dgrvData.CurrentRow.Index);
      if (this.dgrvData.Rows.Count > 0 & (int) index < checked (this.dgrvData.Rows.Count - 1))
      {
        this.dgrvData.CurrentCell = this.dgrvData[1, checked ((int) index + 1)];
        this.Information_Quantity_Of_Records();
        this.SelectITem();
      }
    }

    private void Button_Last_Click(object sender, EventArgs e)
    {
      if (!this.DataGRV_Validated() || this.dgrvData.Rows.Count <= 0)
        return;
      this.dgrvData.CurrentCell = this.dgrvData[1, checked (this.dgrvData.Rows.Count - 1)];
      this.Information_Quantity_Of_Records();
      this.SelectITem();
    }

    private void Information_Quantity_Of_Records()
    {
      if (!this.DataGRV_Validated())
        return;
      this.ToolStripStatusLabel_RecordsText.Text = "Actual: " + Conversions.ToString(checked (this.dgrvData.CurrentRow.Index + 1)) + " /  Total de Registros: " + Conversions.ToString(this.dgrvData.RowCount);
    }

    private void dgrvData_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
    {
      this.Button_Selection_Click(RuntimeHelpers.GetObjectValue(sender), (EventArgs) null);
    }
  }
}
