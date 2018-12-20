// Decompiled with JetBrains decompiler
// Type: TriNetRestPOS.FrmCargaProductos
// Assembly: TriNetRestPOS, Version=5.2.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 43377352-E952-4AC1-9BA6-CCBE4AE5F575
// Assembly location: C:\log\TriNetRestPOS.exe

using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using TR1_BusinessEntity;
using TR1_BusinessLogic;
using TR2_BusinessLogic;

namespace TriNetRestPOS
{
  [DesignerGenerated]
  public class FrmCargaProductos : Form
  {
    private IContainer components;

    public FrmCargaProductos()
    {
      this.Load += new EventHandler(this.FrmCargaProductos_Load);
      this.KeyDown += new KeyEventHandler(this.FrmCargaProductos_KeyDown);
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
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (FrmCargaProductos));
      this.Label1 = new Label();
      this.txtRuta = new TextBox();
      this.btnRuta = new Button();
      this.dgvExcelData = new DataGridView();
      this.lblTotalRegistros = new Label();
      this.btnGuardar = new Button();
      this.Label2 = new Label();
      this.btnLimpiar = new Button();
      this.Label3 = new Label();
      this.lblCargaron = new Label();
      this.Label5 = new Label();
      this.lblFallaron = new Label();
      this.chbCopiarAlmacen = new CheckBox();
      ((ISupportInitialize) this.dgvExcelData).BeginInit();
      this.SuspendLayout();
      this.Label1.AutoSize = true;
      this.Label1.ForeColor = Color.MediumBlue;
      this.Label1.Location = new Point(5, 9);
      this.Label1.Name = "Label1";
      this.Label1.Size = new Size(160, 20);
      this.Label1.TabIndex = 0;
      this.Label1.Text = "Seleccionar Archivo :";
      this.txtRuta.Location = new Point(170, 6);
      this.txtRuta.Name = "txtRuta";
      this.txtRuta.Size = new Size(790, 25);
      this.txtRuta.TabIndex = 1;
      this.btnRuta.Location = new Point(961, 5);
      this.btnRuta.Name = "btnRuta";
      this.btnRuta.Size = new Size(50, 27);
      this.btnRuta.TabIndex = 2;
      this.btnRuta.Text = "...";
      this.btnRuta.UseVisualStyleBackColor = true;
      this.dgvExcelData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dgvExcelData.Location = new Point(0, 37);
      this.dgvExcelData.Name = "dgvExcelData";
      this.dgvExcelData.Size = new Size(1018, 586);
      this.dgvExcelData.TabIndex = 3;
      this.lblTotalRegistros.AutoSize = true;
      this.lblTotalRegistros.ForeColor = Color.MediumBlue;
      this.lblTotalRegistros.Location = new Point(154, 632);
      this.lblTotalRegistros.Name = "lblTotalRegistros";
      this.lblTotalRegistros.Size = new Size(18, 20);
      this.lblTotalRegistros.TabIndex = 4;
      this.lblTotalRegistros.Text = "0";
      this.btnGuardar.ForeColor = Color.MediumBlue;
      this.btnGuardar.ImageAlign = ContentAlignment.MiddleRight;
      this.btnGuardar.Location = new Point(866, 625);
      this.btnGuardar.Name = "btnGuardar";
      this.btnGuardar.Size = new Size(150, 35);
      this.btnGuardar.TabIndex = 5;
      this.btnGuardar.Text = "Guardar";
      this.btnGuardar.TextImageRelation = TextImageRelation.ImageBeforeText;
      this.btnGuardar.UseVisualStyleBackColor = true;
      this.Label2.AutoSize = true;
      this.Label2.ForeColor = Color.MediumBlue;
      this.Label2.Location = new Point(10, 632);
      this.Label2.Name = "Label2";
      this.Label2.Size = new Size(129, 20);
      this.Label2.TabIndex = 6;
      this.Label2.Text = "N° de Registros :";
      this.btnLimpiar.ForeColor = Color.MediumBlue;
      this.btnLimpiar.Location = new Point(750, 625);
      this.btnLimpiar.Name = "btnLimpiar";
      this.btnLimpiar.Size = new Size(110, 35);
      this.btnLimpiar.TabIndex = 7;
      this.btnLimpiar.Text = "Limpiar";
      this.btnLimpiar.TextImageRelation = TextImageRelation.ImageBeforeText;
      this.btnLimpiar.UseVisualStyleBackColor = true;
      this.Label3.AutoSize = true;
      this.Label3.ForeColor = Color.Green;
      this.Label3.Location = new Point(241, 632);
      this.Label3.Name = "Label3";
      this.Label3.Size = new Size(82, 20);
      this.Label3.TabIndex = 219;
      this.Label3.Text = "Cargaron :";
      this.lblCargaron.AutoSize = true;
      this.lblCargaron.ForeColor = Color.Green;
      this.lblCargaron.Location = new Point(343, 633);
      this.lblCargaron.Name = "lblCargaron";
      this.lblCargaron.Size = new Size(18, 20);
      this.lblCargaron.TabIndex = 218;
      this.lblCargaron.Text = "0";
      this.Label5.AutoSize = true;
      this.Label5.ForeColor = Color.Red;
      this.Label5.Location = new Point(421, 632);
      this.Label5.Name = "Label5";
      this.Label5.Size = new Size(76, 20);
      this.Label5.TabIndex = 221;
      this.Label5.Text = "Fallaron :";
      this.lblFallaron.AutoSize = true;
      this.lblFallaron.ForeColor = Color.Red;
      this.lblFallaron.Location = new Point(523, 633);
      this.lblFallaron.Name = "lblFallaron";
      this.lblFallaron.Size = new Size(18, 20);
      this.lblFallaron.TabIndex = 220;
      this.lblFallaron.Text = "0";
      this.chbCopiarAlmacen.AutoSize = true;
      this.chbCopiarAlmacen.Checked = true;
      this.chbCopiarAlmacen.CheckState = CheckState.Checked;
      this.chbCopiarAlmacen.Location = new Point(593, 631);
      this.chbCopiarAlmacen.Name = "chbCopiarAlmacen";
      this.chbCopiarAlmacen.Size = new Size(151, 24);
      this.chbCopiarAlmacen.TabIndex = 222;
      this.chbCopiarAlmacen.Text = "Copiar a Almacén";
      this.chbCopiarAlmacen.UseVisualStyleBackColor = true;
      this.AutoScaleDimensions = new SizeF(9f, 20f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.BackColor = SystemColors.Window;
      this.ClientSize = new Size(1018, 662);
      this.Controls.Add((Control) this.chbCopiarAlmacen);
      this.Controls.Add((Control) this.Label5);
      this.Controls.Add((Control) this.lblFallaron);
      this.Controls.Add((Control) this.Label3);
      this.Controls.Add((Control) this.lblCargaron);
      this.Controls.Add((Control) this.btnLimpiar);
      this.Controls.Add((Control) this.Label2);
      this.Controls.Add((Control) this.btnGuardar);
      this.Controls.Add((Control) this.lblTotalRegistros);
      this.Controls.Add((Control) this.dgvExcelData);
      this.Controls.Add((Control) this.btnRuta);
      this.Controls.Add((Control) this.txtRuta);
      this.Controls.Add((Control) this.Label1);
      this.Font = new Font("Trebuchet MS", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.FormBorderStyle = FormBorderStyle.FixedDialog;
      this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
      this.Margin = new Padding(4, 5, 4, 5);
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = nameof (FrmCargaProductos);
      this.StartPosition = FormStartPosition.CenterScreen;
      this.Text = "Carga de Productos";
      ((ISupportInitialize) this.dgvExcelData).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();
    }

    internal virtual Label Label1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual TextBox txtRuta { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Button btnRuta
    {
      get
      {
        return this._btnRuta;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.btnRuta_Click);
        Button btnRuta1 = this._btnRuta;
        if (btnRuta1 != null)
          btnRuta1.Click -= eventHandler;
        this._btnRuta = value;
        Button btnRuta2 = this._btnRuta;
        if (btnRuta2 == null)
          return;
        btnRuta2.Click += eventHandler;
      }
    }

    internal virtual DataGridView dgvExcelData { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Label lblTotalRegistros { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Button btnGuardar
    {
      get
      {
        return this._btnGuardar;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.btnGuardar_Click);
        Button btnGuardar1 = this._btnGuardar;
        if (btnGuardar1 != null)
          btnGuardar1.Click -= eventHandler;
        this._btnGuardar = value;
        Button btnGuardar2 = this._btnGuardar;
        if (btnGuardar2 == null)
          return;
        btnGuardar2.Click += eventHandler;
      }
    }

    internal virtual Label Label2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Button btnLimpiar
    {
      get
      {
        return this._btnLimpiar;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.btnLimpiar_Click);
        Button btnLimpiar1 = this._btnLimpiar;
        if (btnLimpiar1 != null)
          btnLimpiar1.Click -= eventHandler;
        this._btnLimpiar = value;
        Button btnLimpiar2 = this._btnLimpiar;
        if (btnLimpiar2 == null)
          return;
        btnLimpiar2.Click += eventHandler;
      }
    }

    internal virtual Label Label3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Label lblCargaron { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Label Label5 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Label lblFallaron { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual CheckBox chbCopiarAlmacen { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    private void FrmCargaProductos_Load(object sender, EventArgs e)
    {
      this.SetearGrid();
      new BL_TR2_PRODUCTS().EliminarTMPCargaDetalleExcel();
    }

    private void FrmCargaProductos_KeyDown(object sender, KeyEventArgs e)
    {
      if (!e.KeyValue.Equals(27))
        return;
      this.Close();
    }

    private void btnRuta_Click(object sender, EventArgs e)
    {
      OpenFileDialog openFileDialog = new OpenFileDialog();
      openFileDialog.Filter = "Excel 93-2003 files (*.xls)|*.xls";
      if (openFileDialog.ShowDialog() != DialogResult.OK)
        return;
      this.txtRuta.Text = openFileDialog.FileName;
      if (!string.IsNullOrEmpty(this.txtRuta.Text))
      {
        this.Cursor = Cursors.WaitCursor;
        this.Limpiar();
        try
        {
          DataSet dataFromExcel1 = new ExcelHandler().GetDataFromExcel1(this.txtRuta.Text.Trim(), 2);
          if (dataFromExcel1 != null)
          {
            this.dgvExcelData.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dgvExcelData.EditMode = DataGridViewEditMode.EditProgrammatically;
            this.dgvExcelData.DataSource = (object) dataFromExcel1.Tables[0];
            this.dgvExcelData.AutoResizeColumns();
            this.dgvExcelData.Columns[0].DefaultCellStyle.Font = new Font("Trebuchet MS", 8f, FontStyle.Regular);
            this.dgvExcelData.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dgvExcelData.Columns[8].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dgvExcelData.Columns[9].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            this.dgvExcelData.Columns[10].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            this.dgvExcelData.Columns[14].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            this.dgvExcelData.Columns[15].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            this.lblTotalRegistros.Text = Conversions.ToString(this.dgvExcelData.RowCount);
            this.lblCargaron.Text = "0";
            this.lblFallaron.Text = "0";
          }
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          ProjectData.ClearProjectError();
        }
        finally
        {
        }
        this.Cursor = Cursors.Default;
      }
    }

    private void SetearGrid()
    {
      ModGeneralFunctions.SetearGriView(this.dgvExcelData);
    }

    private void Limpiar()
    {
      try
      {
        this.dgvExcelData.DataSource = (object) null;
        this.dgvExcelData.Refresh();
        this.lblTotalRegistros.Text = "0";
        this.lblCargaron.Text = "0";
        this.lblFallaron.Text = "0";
        new BL_TR2_PRODUCTS().EliminarTMPCargaDetalleExcel();
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
    }

    private void btnLimpiar_Click(object sender, EventArgs e)
    {
      this.txtRuta.Text = "";
      this.Limpiar();
    }

    private void btnGuardar_Click(object sender, EventArgs e)
    {
      try
      {
        if (!ModGeneralFunctions.MessageMakeAction("¿Desea Cargar los [" + this.lblTotalRegistros.Text + "] Productos?", false))
          return;
        this.Cursor = Cursors.WaitCursor;
        this.lblCargaron.Text = "0";
        this.lblFallaron.Text = "0";
        BL_TR_PARAMETRO blTrParametro = new BL_TR_PARAMETRO();
        string str1 = "";
        BL_TR1_PRODUCTS blTr1Products = new BL_TR1_PRODUCTS();
        string str2 = "";
        BL_TR1_GROUPS blTr1Groups = new BL_TR1_GROUPS();
        BL_TR1_SUBGROUPS blTr1Subgroups = new BL_TR1_SUBGROUPS();
        BL_TR1_AREA blTr1Area = new BL_TR1_AREA();
        int num1 = 0;
        int num2 = 0;
        int num3 = 0;
        int num4 = checked (this.dgvExcelData.RowCount - 1);
        int index = 0;
        BE_TR1_PRODUCTS beTr1Products;
        while (index <= num4)
        {
          this.dgvExcelData.CurrentCell = this.dgvExcelData[1, index];
          beTr1Products = new BE_TR1_PRODUCTS();
          beTr1Products.set_EstabliId(ModGeneralVar.g_BE_TR1_VARIABLES_B.get_EstabliId());
          beTr1Products.set_ProductId("");
          if (Strings.Len(ModGeneralFunctions.CadenaIfDBNULL(RuntimeHelpers.GetObjectValue(this.dgvExcelData.Rows[index].Cells["GRUPO"].Value)).Trim()) != 0)
          {
            List<BE_TR1_GROUPS> beTr1GroupsList = blTr1Groups.SearchByDesExacto(Conversions.ToString(this.dgvExcelData.Rows[index].Cells["GRUPO"].Value));
            if (beTr1GroupsList != null && beTr1GroupsList.Count > 0)
            {
              beTr1Products.set_GroupId(beTr1GroupsList[0].get_GroupId());
            }
            else
            {
              BE_TR1_GROUPS beTr1Groups = new BE_TR1_GROUPS();
              beTr1Groups.set_EstabliId(ModGeneralVar.g_BE_TR1_VARIABLES_B.get_EstabliId());
              beTr1Groups.set_GroupDes(Conversions.ToString(this.dgvExcelData.Rows[index].Cells["GRUPO"].Value));
              beTr1Groups.set_GroupDesShort(beTr1Groups.get_GroupDes());
              beTr1Groups.set_OrderButton(1);
              beTr1Groups.set_IsActive(true);
              beTr1Groups.set_UserId(ModGeneralVar.g_BE_USERS.get_UserId());
              str2 = blTr1Groups.Add(ref beTr1Groups);
              if (str2.Equals(StructApp.RESULT_OK))
                beTr1Products.set_GroupId(beTr1Groups.get_GroupId());
              else
                beTr1Products.set_GroupId(1);
            }
            List<BE_TR1_SUBGROUPS> beTr1SubgroupsList = blTr1Subgroups.ListBasicbyDesExacto(Conversions.ToString(this.dgvExcelData.Rows[index].Cells["SUBGRUPO"].Value));
            if (beTr1SubgroupsList != null && beTr1SubgroupsList.Count > 0)
            {
              beTr1Products.set_SubGroupId(beTr1SubgroupsList[0].get_SubGroupId());
            }
            else
            {
              BE_TR1_SUBGROUPS beTr1Subgroups = new BE_TR1_SUBGROUPS();
              beTr1Subgroups.set_EstabliId(ModGeneralVar.g_BE_TR1_VARIABLES_B.get_EstabliId());
              beTr1Subgroups.set_SubGroupId(0);
              beTr1Subgroups.set_GroupId(beTr1Products.get_GroupId());
              beTr1Subgroups.set_SubGroupDes(Conversions.ToString(this.dgvExcelData.Rows[index].Cells["SUBGRUPO"].Value));
              beTr1Subgroups.set_SubGroupDesShort(beTr1Subgroups.get_SubGroupDes());
              beTr1Subgroups.set_IsActive(true);
              beTr1Subgroups.set_ForPda(true);
              beTr1Subgroups.set_UserIdS(ModGeneralVar.g_BE_USERS.get_UserId());
              beTr1Subgroups.set_NumOrder(1);
              str2 = blTr1Subgroups.Add(ref beTr1Subgroups, (List<BE_TR1_PROPERTIES>) null, (List<BE_TR1_PRODUCTS>) null, (List<BE_TR1_AREA>) null);
              if (str2.Equals(StructApp.RESULT_OK))
                beTr1Products.set_SubGroupId(beTr1Subgroups.get_SubGroupId());
              else
                beTr1Products.set_SubGroupId(1);
            }
            beTr1Products.set_ProductDes(ModGeneralFunctions.CadenaIfDBNULL(RuntimeHelpers.GetObjectValue(this.dgvExcelData.Rows[index].Cells["NOMBRE"].Value)));
            beTr1Products.set_ProductDesShort(beTr1Products.get_ProductDes());
            beTr1Products.set_PriceSale01(ModGeneralFunctions.CadenaToDouble(Conversions.ToString(this.dgvExcelData.Rows[index].Cells["P_VENTA"].Value)));
            beTr1Products.set_PriceSale02(beTr1Products.get_PriceSale01());
            beTr1Products.set_PriceSale03(beTr1Products.get_PriceSale01());
            beTr1Products.set_Tax1_01(true);
            beTr1Products.set_Tax2_01(false);
            beTr1Products.set_Tax3_01(false);
            beTr1Products.set_Tax1_02(true);
            beTr1Products.set_Tax2_02(false);
            beTr1Products.set_Tax3_02(false);
            beTr1Products.set_Tax1_03(true);
            beTr1Products.set_Tax2_03(false);
            beTr1Products.set_Tax3_03(false);
            beTr1Products.set_IsActive(true);
            beTr1Products.set_UserId(ModGeneralVar.g_BE_USERS.get_UserId());
            beTr1Products.set_ProductIdStore("");
            beTr1Products.set_ProductDesStore(beTr1Products.get_ProductDes());
            beTr1Products.set_TypeDownload("01");
            beTr1Products.set_PrintOption(true);
            beTr1Products.set_AreaId("");
            beTr1Products.set_AreaDesS("");
            beTr1Products.set_IsCombo(false);
            beTr1Products.set_IsRetornable(true);
            beTr1Products.set_IsProgram(false);
            beTr1Products.set_UnitIncoming(14);
            beTr1Products.set_IsFlexible(false);
            beTr1Products.set_NroSerie(ModGeneralFunctions.CadenaIfDBNULL(RuntimeHelpers.GetObjectValue(this.dgvExcelData.Rows[index].Cells["COD_BARRAS"].Value)));
            beTr1Products.set_RutaImagen("");
            beTr1Products.set_ImporteComision(0.0);
            string str3 = ModGeneralFunctions.CadenaIfDBNULL(RuntimeHelpers.GetObjectValue(this.dgvExcelData.Rows[index].Cells["MARCA"].Value));
            BE_TR_PARAMETRO beTrParametro = new BE_TR_PARAMETRO(1, str3, true);
            if (!str3.Equals(""))
              beTrParametro.set_ParametroId(blTrParametro.ObtenerIdxNombre(1, str3));
            if (beTrParametro.get_ParametroId() == 0 & !str3.Equals(""))
              blTrParametro.Insertar(ref beTrParametro);
            beTr1Products.set_MarcaId(beTrParametro.get_ParametroId());
            string str4 = ModGeneralFunctions.CadenaIfDBNULL(RuntimeHelpers.GetObjectValue(this.dgvExcelData.Rows[index].Cells["MODELO"].Value));
            beTrParametro = new BE_TR_PARAMETRO(2, str4, true);
            if (!str4.Equals(""))
              beTrParametro.set_ParametroId(blTrParametro.ObtenerIdxNombre(2, str4));
            if (beTrParametro.get_ParametroId() == 0 & !str4.Equals(""))
              blTrParametro.Insertar(ref beTrParametro);
            beTr1Products.set_ModeloId(beTrParametro.get_ParametroId());
            string str5 = ModGeneralFunctions.CadenaIfDBNULL(RuntimeHelpers.GetObjectValue(this.dgvExcelData.Rows[index].Cells["COLOR"].Value));
            beTrParametro = new BE_TR_PARAMETRO(3, str5, true);
            if (!str5.Equals(""))
              beTrParametro.set_ParametroId(blTrParametro.ObtenerIdxNombre(3, str5));
            if (beTrParametro.get_ParametroId() == 0 & !str5.Equals(""))
              blTrParametro.Insertar(ref beTrParametro);
            beTr1Products.set_ColorId(beTrParametro.get_ParametroId());
            string str6 = ModGeneralFunctions.CadenaIfDBNULL(RuntimeHelpers.GetObjectValue(this.dgvExcelData.Rows[index].Cells["TACO"].Value));
            beTrParametro = new BE_TR_PARAMETRO(4, str6, true);
            if (!str6.Equals(""))
              beTrParametro.set_ParametroId(blTrParametro.ObtenerIdxNombre(4, str6));
            if (beTrParametro.get_ParametroId() == 0 & !str6.Equals(""))
              blTrParametro.Insertar(ref beTrParametro);
            beTr1Products.set_TacoId(beTrParametro.get_ParametroId());
            string str7 = ModGeneralFunctions.CadenaIfDBNULL(RuntimeHelpers.GetObjectValue(this.dgvExcelData.Rows[index].Cells["TALLA"].Value));
            beTrParametro = new BE_TR_PARAMETRO(5, str7, true);
            if (!str7.Equals(""))
              beTrParametro.set_ParametroId(blTrParametro.ObtenerIdxNombre(5, str7));
            if (beTrParametro.get_ParametroId() == 0 & !str7.Equals(""))
              blTrParametro.Insertar(ref beTrParametro);
            beTr1Products.set_TallaId(beTrParametro.get_ParametroId());
            str2 = !blTr1Products.VerifyDesExist(beTr1Products, ref str2) ? StructApp.RESULT_OK : "Producto existente";
            if (str2.Equals(StructApp.RESULT_OK))
            {
              beTr1Products.set_NroSerie2(ModGeneralFunctions.CadenaIfDBNULL(RuntimeHelpers.GetObjectValue(this.dgvExcelData.Rows[index].Cells["COD"].Value)));
              List<BE_TR1_AREA> beTr1AreaList = new List<BE_TR1_AREA>();
              BE_TR1_AREA beTr1Area = new BE_TR1_AREA();
              beTr1Area.set_AreaId(0);
              beTr1Area.set_AreaDes(ModGeneralFunctions.CadenaIfDBNULL(RuntimeHelpers.GetObjectValue(this.dgvExcelData.Rows[index].Cells["AREA1"].Value)));
              beTr1Area.set_AreaDesShort(beTr1Area.get_AreaDes());
              if (!beTr1Area.get_AreaDes().Equals(""))
              {
                if (blTr1Area.VerifyDesExist(ref beTr1Area))
                {
                  beTr1AreaList.Add(beTr1Area);
                  beTr1Area = (BE_TR1_AREA) null;
                }
                else
                {
                  beTr1Area.set_EstabliId(ModGeneralVar.g_BE_TR1_VARIABLES_B.get_EstabliId());
                  beTr1Area.set_AreaDes(beTr1Area.get_AreaDes());
                  beTr1Area.set_AreaDesShort(beTr1Area.get_AreaDes());
                  beTr1Area.set_IsActive(true);
                  beTr1Area.set_UserId(ModGeneralVar.g_BE_USERS.get_UserId());
                  beTr1Area.set_PrintNumComma(1);
                  beTr1Area.set_AreaId(blTr1Area.Add(ref beTr1Area));
                  beTr1AreaList.Add(beTr1Area);
                  beTr1Area = (BE_TR1_AREA) null;
                }
              }
              beTr1Products.set_AreaId(ModGeneralFunctions.CadenaIfDBNULL(RuntimeHelpers.GetObjectValue(this.dgvExcelData.Rows[index].Cells["AREA2"].Value)));
              str2 = blTr1Products.Add(ref beTr1Products, beTr1AreaList, (BECollec_TR1_PRODUCTS) null, (List<BE_TR1_PRODUCTS_PROGRAM>) null, (BECollec_TR1_PRODUCTS) null, this.chbCopiarAlmacen.Checked);
            }
            this.dgvExcelData.Rows[index].Cells["ESTADO"].Value = (object) str2;
            if (str2.Equals(StructApp.RESULT_OK))
              checked { ++num1; }
            else
              checked { ++num2; }
            double num5 = ModGeneralFunctions.CadenaToDouble(ModGeneralFunctions.CadenaIfDBNULL(RuntimeHelpers.GetObjectValue(this.dgvExcelData.Rows[index].Cells["CANTIDAD"].Value)));
            if (num5 > 0.0)
            {
              double num6 = ModGeneralFunctions.CadenaToDouble(ModGeneralFunctions.CadenaIfDBNULL(RuntimeHelpers.GetObjectValue(this.dgvExcelData.Rows[index].Cells["PRECIO"].Value)));
              string Left = ModGeneralFunctions.CadenaIfDBNULL(RuntimeHelpers.GetObjectValue(this.dgvExcelData.Rows[index].Cells["AFECTO_IGV"].Value));
              bool flag = Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Left, "1", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Left, "0", false) == 0 && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Left, "1", false) == 0;
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(new BL_TR2_PRODUCTS().InsertarTMPCargaDetalleExcel(beTr1Products.get_ProductDes(), num5, num6, flag), "OK", false) == 0)
                checked { ++num3; }
            }
            beTr1Products = (BE_TR1_PRODUCTS) null;
            checked { ++index; }
          }
          else
            break;
        }
        this.dgvExcelData.AutoResizeColumns();
        this.dgvExcelData.Refresh();
        this.lblCargaron.Text = Conversions.ToString(num1);
        this.lblFallaron.Text = Conversions.ToString(num2);
        this.Cursor = Cursors.Default;
        str1 = (string) null;
        beTr1Products = (BE_TR1_PRODUCTS) null;
        if (num3 > 0)
          ModGeneralFunctions.MessageSuccessful("Se grabaron " + Conversions.ToString(num3) + " registros en la tabla temporal para el detalle de documento");
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
    }
  }
}
