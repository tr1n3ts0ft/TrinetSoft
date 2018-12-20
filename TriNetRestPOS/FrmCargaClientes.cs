// Decompiled with JetBrains decompiler
// Type: TriNetRestPOS.FrmCargaClientes
// Assembly: TriNetRestPOS, Version=5.2.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 43377352-E952-4AC1-9BA6-CCBE4AE5F575
// Assembly location: C:\log\TriNetRestPOS.exe

using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using TR1_BusinessEntity;
using TR1_BusinessLogic;

namespace TriNetRestPOS
{
  [DesignerGenerated]
  public class FrmCargaClientes : Form
  {
    private IContainer components;

    public FrmCargaClientes()
    {
      this.Load += new EventHandler(this.FrmCargaClientes_Load);
      this.KeyDown += new KeyEventHandler(this.FrmCargaClientes_KeyDown);
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
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (FrmCargaClientes));
      this.Label1 = new Label();
      this.txtRuta = new TextBox();
      this.btnRuta = new Button();
      this.dgvExcelData = new DataGridView();
      this.lblTotalRegistros = new Label();
      this.btnGuardar = new Button();
      this.Label2 = new Label();
      this.btnLimpiar = new Button();
      this.ComboBox_DocumentType = new ComboBox();
      this.ComboBox_TPersonL = new ComboBox();
      this.cboTipoCliente = new ComboBox();
      this.cboDepartamentos = new ComboBox();
      this.Label3 = new Label();
      this.lblCargaron = new Label();
      this.Label5 = new Label();
      this.lblFallaron = new Label();
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
      this.lblTotalRegistros.Location = new Point(228, 632);
      this.lblTotalRegistros.Name = "lblTotalRegistros";
      this.lblTotalRegistros.Size = new Size(18, 20);
      this.lblTotalRegistros.TabIndex = 4;
      this.lblTotalRegistros.Text = "0";
      this.btnGuardar.ForeColor = Color.MediumBlue;
      this.btnGuardar.Image = (Image) TriNetRestPOS.My.Resources.Resources.i_Ready;
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
      this.Label2.Location = new Point(84, 632);
      this.Label2.Name = "Label2";
      this.Label2.Size = new Size(129, 20);
      this.Label2.TabIndex = 6;
      this.Label2.Text = "N° de Registros :";
      this.btnLimpiar.ForeColor = Color.MediumBlue;
      this.btnLimpiar.Image = (Image) TriNetRestPOS.My.Resources.Resources.Eraser;
      this.btnLimpiar.Location = new Point(750, 625);
      this.btnLimpiar.Name = "btnLimpiar";
      this.btnLimpiar.Size = new Size(110, 35);
      this.btnLimpiar.TabIndex = 7;
      this.btnLimpiar.Text = "Limpiar";
      this.btnLimpiar.TextImageRelation = TextImageRelation.ImageBeforeText;
      this.btnLimpiar.UseVisualStyleBackColor = true;
      this.ComboBox_DocumentType.DropDownStyle = ComboBoxStyle.DropDownList;
      this.ComboBox_DocumentType.Enabled = false;
      this.ComboBox_DocumentType.FormattingEnabled = true;
      this.ComboBox_DocumentType.Location = new Point(658, 629);
      this.ComboBox_DocumentType.Name = "ComboBox_DocumentType";
      this.ComboBox_DocumentType.Size = new Size(20, 28);
      this.ComboBox_DocumentType.TabIndex = 215;
      this.ComboBox_DocumentType.Visible = false;
      this.ComboBox_TPersonL.DropDownStyle = ComboBoxStyle.DropDownList;
      this.ComboBox_TPersonL.FormattingEnabled = true;
      this.ComboBox_TPersonL.Location = new Point(681, 629);
      this.ComboBox_TPersonL.Name = "ComboBox_TPersonL";
      this.ComboBox_TPersonL.Size = new Size(20, 28);
      this.ComboBox_TPersonL.TabIndex = 214;
      this.ComboBox_TPersonL.Visible = false;
      this.cboTipoCliente.DropDownStyle = ComboBoxStyle.DropDownList;
      this.cboTipoCliente.FormattingEnabled = true;
      this.cboTipoCliente.Location = new Point(727, 629);
      this.cboTipoCliente.Name = "cboTipoCliente";
      this.cboTipoCliente.Size = new Size(20, 28);
      this.cboTipoCliente.TabIndex = 217;
      this.cboTipoCliente.Visible = false;
      this.cboDepartamentos.DropDownStyle = ComboBoxStyle.DropDownList;
      this.cboDepartamentos.FormattingEnabled = true;
      this.cboDepartamentos.Location = new Point(704, 629);
      this.cboDepartamentos.Name = "cboDepartamentos";
      this.cboDepartamentos.Size = new Size(20, 28);
      this.cboDepartamentos.TabIndex = 216;
      this.cboDepartamentos.Visible = false;
      this.Label3.AutoSize = true;
      this.Label3.ForeColor = Color.Green;
      this.Label3.Location = new Point(315, 632);
      this.Label3.Name = "Label3";
      this.Label3.Size = new Size(82, 20);
      this.Label3.TabIndex = 219;
      this.Label3.Text = "Cargaron :";
      this.lblCargaron.AutoSize = true;
      this.lblCargaron.ForeColor = Color.Green;
      this.lblCargaron.Location = new Point(417, 633);
      this.lblCargaron.Name = "lblCargaron";
      this.lblCargaron.Size = new Size(18, 20);
      this.lblCargaron.TabIndex = 218;
      this.lblCargaron.Text = "0";
      this.Label5.AutoSize = true;
      this.Label5.ForeColor = Color.Red;
      this.Label5.Location = new Point(495, 632);
      this.Label5.Name = "Label5";
      this.Label5.Size = new Size(76, 20);
      this.Label5.TabIndex = 221;
      this.Label5.Text = "Fallaron :";
      this.lblFallaron.AutoSize = true;
      this.lblFallaron.ForeColor = Color.Red;
      this.lblFallaron.Location = new Point(597, 633);
      this.lblFallaron.Name = "lblFallaron";
      this.lblFallaron.Size = new Size(18, 20);
      this.lblFallaron.TabIndex = 220;
      this.lblFallaron.Text = "0";
      this.AutoScaleDimensions = new SizeF(9f, 20f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.BackColor = SystemColors.Window;
      this.ClientSize = new Size(1018, 662);
      this.Controls.Add((Control) this.Label5);
      this.Controls.Add((Control) this.lblFallaron);
      this.Controls.Add((Control) this.Label3);
      this.Controls.Add((Control) this.lblCargaron);
      this.Controls.Add((Control) this.cboTipoCliente);
      this.Controls.Add((Control) this.cboDepartamentos);
      this.Controls.Add((Control) this.ComboBox_DocumentType);
      this.Controls.Add((Control) this.ComboBox_TPersonL);
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
      this.Name = nameof (FrmCargaClientes);
      this.StartPosition = FormStartPosition.CenterScreen;
      this.Text = "Carga de Clientes";
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

    internal virtual ComboBox ComboBox_DocumentType { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual ComboBox ComboBox_TPersonL { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual ComboBox cboTipoCliente { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual ComboBox cboDepartamentos { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Label Label3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Label lblCargaron { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Label Label5 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Label lblFallaron { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    private void FrmCargaClientes_Load(object sender, EventArgs e)
    {
      this.SetearGrid();
      if (!this.LoadTypeDocumentClient())
        ModGeneralFunctions.MessageOk("¡Error al Cargar Tipos de Documentos!");
      else if (!this.LoadTypeClient())
        ModGeneralFunctions.MessageOk("¡Error al Cargar Tipos de Persona!");
      else if (!this.CargarTipoCliente())
      {
        ModGeneralFunctions.MessageOk("¡Error al Cargar Tipos de Cliente!");
      }
      else
      {
        if (this.LoadDepartamentos())
          return;
        ModGeneralFunctions.MessageOk("¡Error al Cargar Departamentos!");
      }
    }

    private void FrmCargaClientes_KeyDown(object sender, KeyEventArgs e)
    {
      if (!e.KeyValue.Equals(27))
        return;
      this.Close();
    }

    private void btnRuta_Click(object sender, EventArgs e)
    {
      OpenFileDialog openFileDialog = new OpenFileDialog();
      openFileDialog.Filter = "Excel 93-2003 files (*.xls)|*.xls|Excel 2007-2010 files (*.xlsx)|*.xlsx|All files (*.*)|*.*";
      if (openFileDialog.ShowDialog() != DialogResult.OK)
        return;
      this.txtRuta.Text = openFileDialog.FileName;
      if (!string.IsNullOrEmpty(this.txtRuta.Text))
      {
        this.Cursor = Cursors.WaitCursor;
        this.Limpiar();
        try
        {
          DataSet dataFromExcel = new ExcelHandler().GetDataFromExcel(this.txtRuta.Text.Trim(), 1);
          if (dataFromExcel != null)
          {
            this.dgvExcelData.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dgvExcelData.EditMode = DataGridViewEditMode.EditProgrammatically;
            this.dgvExcelData.DataSource = (object) dataFromExcel.Tables[0];
            this.dgvExcelData.AutoResizeColumns();
            this.dgvExcelData.Columns[0].DefaultCellStyle.Font = new Font("Trebuchet MS", 8f, FontStyle.Regular);
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

    private bool LoadTypeClient()
    {
      BL_TR1_MASTERTABLE blTr1Mastertable = new BL_TR1_MASTERTABLE();
      BECollec_TR1_MASTERTABLE collecTr1Mastertable1 = new BECollec_TR1_MASTERTABLE();
      BECollec_TR1_MASTERTABLE collecTr1Mastertable2 = blTr1Mastertable.ListTypeClient();
      if (collecTr1Mastertable2 == null || ((CollectionBase) collecTr1Mastertable2).Count == 0)
        return false;
      collecTr1Mastertable2.Insert(0, new BE_TR1_MASTERTABLE("0", "«Seleccione»"));
      this.ComboBox_TPersonL.DisplayMember = "MasterTDesShort";
      this.ComboBox_TPersonL.ValueMember = "MasterTId";
      this.ComboBox_TPersonL.DataSource = (object) collecTr1Mastertable2;
      this.ComboBox_TPersonL.SelectedIndex = 1;
      return true;
    }

    private bool LoadTypeDocumentClient()
    {
      BL_TR1_MASTERTABLE blTr1Mastertable = new BL_TR1_MASTERTABLE();
      BECollec_TR1_MASTERTABLE collecTr1Mastertable1 = new BECollec_TR1_MASTERTABLE();
      BECollec_TR1_MASTERTABLE collecTr1Mastertable2 = blTr1Mastertable.List("TYPEDOCCLIENT");
      if (collecTr1Mastertable2 == null || ((CollectionBase) collecTr1Mastertable2).Count == 0)
        return false;
      collecTr1Mastertable2.Insert(0, new BE_TR1_MASTERTABLE("0", "«Seleccione»"));
      this.ComboBox_DocumentType.DisplayMember = "MasterTDesShort";
      this.ComboBox_DocumentType.ValueMember = "MasterTId";
      this.ComboBox_DocumentType.DataSource = (object) collecTr1Mastertable2;
      return true;
    }

    private bool LoadDepartamentos()
    {
      BL_TR_UBIGEO blTrUbigeo = new BL_TR_UBIGEO();
      List<BE_TR_UBIGEO> beTrUbigeoList1 = new List<BE_TR_UBIGEO>();
      List<BE_TR_UBIGEO> beTrUbigeoList2 = blTrUbigeo.ListarDepartamentos();
      if (beTrUbigeoList2 == null || beTrUbigeoList2.Count == 0)
        return false;
      beTrUbigeoList2.Insert(0, new BE_TR_UBIGEO("", "", "«Seleccione»"));
      this.cboDepartamentos.ValueMember = "CODDPTO";
      this.cboDepartamentos.DisplayMember = "NOMBRE";
      this.cboDepartamentos.DataSource = (object) beTrUbigeoList2;
      this.cboDepartamentos.SelectedValue = (object) "15";
      return true;
    }

    private bool CargarTipoCliente()
    {
      BL_TR1_CLIENTE_TIPO blTr1ClienteTipo = new BL_TR1_CLIENTE_TIPO();
      List<BE_TR1_CLIENTE_TIPO> beTr1ClienteTipoList1 = new List<BE_TR1_CLIENTE_TIPO>();
      List<BE_TR1_CLIENTE_TIPO> beTr1ClienteTipoList2 = blTr1ClienteTipo.ListarActivos();
      if (beTr1ClienteTipoList2 == null || beTr1ClienteTipoList2.Count == 0)
        return false;
      beTr1ClienteTipoList2.Insert(0, new BE_TR1_CLIENTE_TIPO(0, "«Seleccione»"));
      this.cboTipoCliente.ValueMember = "TipoClienteId";
      this.cboTipoCliente.DisplayMember = "Nombre";
      this.cboTipoCliente.DataSource = (object) beTr1ClienteTipoList2;
      this.cboTipoCliente.SelectedIndex = 0;
      return true;
    }

    private void Limpiar()
    {
      this.dgvExcelData.DataSource = (object) null;
      this.dgvExcelData.Refresh();
      this.lblTotalRegistros.Text = "0";
      this.lblCargaron.Text = "0";
      this.lblFallaron.Text = "0";
    }

    private void btnLimpiar_Click(object sender, EventArgs e)
    {
      this.txtRuta.Text = "";
      this.Limpiar();
    }

    private void btnGuardar_Click(object sender, EventArgs e)
    {
      if (!ModGeneralFunctions.MessageMakeAction("¿Desea Cargar los [" + this.lblTotalRegistros.Text + "] Clientes?", false))
        return;
      this.Cursor = Cursors.WaitCursor;
      this.lblCargaron.Text = "0";
      this.lblFallaron.Text = "0";
      BL_TR1_CLIENTS blTr1Clients = new BL_TR1_CLIENTS();
      BL_TR1_CONTACTS blTr1Contacts = new BL_TR1_CONTACTS();
      string str1 = "";
      int num1 = 0;
      int num2 = 0;
      int num3 = checked (this.dgvExcelData.RowCount - 1);
      int index = 0;
      BE_TR1_CONTACTS beTr1Contacts;
      BE_TR1_CLIENTS beTr1Clients1;
      while (index <= num3)
      {
        this.dgvExcelData.CurrentCell = this.dgvExcelData[1, index];
        BE_TR1_CLIENTS beTr1Clients2 = new BE_TR1_CLIENTS();
        beTr1Clients2.set_EstabliId(ModGeneralVar.g_BE_TR1_VARIABLES_B.get_EstabliId());
        beTr1Clients2.set_ClientId("");
        beTr1Clients2.set_ClientCompany(ModGeneralFunctions.CadenaIfDBNULL(RuntimeHelpers.GetObjectValue(this.dgvExcelData.Rows[index].Cells["RAZÓN SOCIAL / NOMBRE"].Value)));
        beTr1Clients2.set_ClientIdentity(ModGeneralFunctions.CadenaIfDBNULL(RuntimeHelpers.GetObjectValue(this.dgvExcelData.Rows[index].Cells["Nº DOCUMENTO"].Value)));
        beTr1Clients2.set_ClientAddress(ModGeneralFunctions.CadenaIfDBNULL(RuntimeHelpers.GetObjectValue(this.dgvExcelData.Rows[index].Cells["DIRECCIÓN"].Value)));
        beTr1Clients2.set_Phone(ModGeneralFunctions.CadenaIfDBNULL(RuntimeHelpers.GetObjectValue(this.dgvExcelData.Rows[index].Cells["TELEFONO1"].Value)));
        beTr1Clients2.set_Codigo(ModGeneralFunctions.CadenaIfDBNULL(RuntimeHelpers.GetObjectValue(this.dgvExcelData.Rows[index].Cells["COD BARRAS"].Value)));
        beTr1Clients2.set_DeliveryAddress(beTr1Clients2.get_ClientAddress());
        beTr1Clients2.set_ClientDes(beTr1Clients2.get_ClientCompany());
        beTr1Clients2.set_PerDiscount(0);
        beTr1Clients2.set_IsActive(true);
        beTr1Clients2.set_ExoneradoImp1(false);
        beTr1Clients2.set_UserId(ModGeneralVar.g_BE_USERS.get_UserId());
        beTr1Clients2.set_Foto("");
        beTr1Clients2.set_Tratamiento(ModGeneralFunctions.CadenaIfDBNULL(RuntimeHelpers.GetObjectValue(this.dgvExcelData.Rows[index].Cells["TRATA"].Value)));
        beTr1Clients2.set_Sexo(ModGeneralFunctions.CadenaIfDBNULL(RuntimeHelpers.GetObjectValue(this.dgvExcelData.Rows[index].Cells["SEXO"].Value)));
        beTr1Clients2.set_FechaNacimiento(ModGeneralFunctions.FechaIfDBNULL(RuntimeHelpers.GetObjectValue(this.dgvExcelData.Rows[index].Cells["F NACIMIENTO"].Value)));
        beTr1Clients2.set_EstadoCivil(ModGeneralFunctions.CadenaIfDBNULL(RuntimeHelpers.GetObjectValue(this.dgvExcelData.Rows[index].Cells["ESTADO CIVIL"].Value)));
        beTr1Clients2.set_Hijos(ModGeneralFunctions.CadenaIfDBNULL(RuntimeHelpers.GetObjectValue(this.dgvExcelData.Rows[index].Cells["HIJOS"].Value)));
        beTr1Clients2.set_Telefono2(ModGeneralFunctions.CadenaIfDBNULL(RuntimeHelpers.GetObjectValue(this.dgvExcelData.Rows[index].Cells["TELEFONO2"].Value)));
        beTr1Clients2.set_Empresa(ModGeneralFunctions.CadenaIfDBNULL(RuntimeHelpers.GetObjectValue(this.dgvExcelData.Rows[index].Cells["EMPRESA"].Value)));
        beTr1Clients2.set_EmailPersonal(ModGeneralFunctions.CadenaIfDBNULL(RuntimeHelpers.GetObjectValue(this.dgvExcelData.Rows[index].Cells["EMAIL PERSONAL"].Value)));
        beTr1Clients2.set_EmailTrabajo(ModGeneralFunctions.CadenaIfDBNULL(RuntimeHelpers.GetObjectValue(this.dgvExcelData.Rows[index].Cells["EMAIL TRABAJO"].Value)));
        beTr1Clients2.set_Cargo(ModGeneralFunctions.CadenaIfDBNULL(RuntimeHelpers.GetObjectValue(this.dgvExcelData.Rows[index].Cells["CARGO"].Value)));
        this.ComboBox_TPersonL.Text = ModGeneralFunctions.CadenaIfDBNULL(RuntimeHelpers.GetObjectValue(this.dgvExcelData.Rows[index].Cells["TIPO"].Value));
        beTr1Clients2.set_ClientType(this.ComboBox_TPersonL.SelectedValue.ToString());
        this.ComboBox_DocumentType.Text = ModGeneralFunctions.CadenaIfDBNULL(RuntimeHelpers.GetObjectValue(this.dgvExcelData.Rows[index].Cells["DOCUMENTO"].Value));
        beTr1Clients2.set_DocumentType(Conversions.ToInteger(this.ComboBox_DocumentType.SelectedValue));
        this.cboDepartamentos.Text = ModGeneralFunctions.CadenaIfDBNULL(RuntimeHelpers.GetObjectValue(this.dgvExcelData.Rows[index].Cells["UBIGEO"].Value));
        beTr1Clients2.set_CodUbigeo(Conversions.ToString(this.cboDepartamentos.SelectedValue));
        BE_TR1_CLIENTS beTr1Clients3;
        string str2 = (beTr1Clients3 = beTr1Clients2).get_CodUbigeo() + "0000";
        beTr1Clients3.set_CodUbigeo(str2);
        this.cboTipoCliente.Text = ModGeneralFunctions.CadenaIfDBNULL(RuntimeHelpers.GetObjectValue(this.dgvExcelData.Rows[index].Cells["TIPO CLIENTE"].Value));
        beTr1Clients2.set_TipoClienteId(Conversions.ToInteger(this.cboTipoCliente.SelectedValue));
        string str3;
        if (blTr1Clients.VerifyRUCExist(ref beTr1Clients2))
        {
          str3 = (uint) Microsoft.VisualBasic.CompilerServices.Operators.CompareString(beTr1Clients2.get_ClientType(), "3", false) <= 0U ? "N° de DNI existente" : "N° de RUC existente";
        }
        else
        {
          beTr1Clients2.set_ClientCompany(beTr1Clients2.get_ClientDes());
          str3 = StructApp.RESULT_OK;
        }
        if (str3.Equals(StructApp.RESULT_OK))
        {
          str3 = blTr1Clients.Add(ref beTr1Clients2);
          if (str3.Equals(StructApp.RESULT_OK) & !beTr1Clients2.get_ClientCompany().Trim().Equals(""))
          {
            beTr1Contacts = new BE_TR1_CONTACTS();
            beTr1Contacts.set_EstabliId(ModGeneralVar.g_BE_TR1_VARIABLES_B.get_EstabliId());
            beTr1Contacts.set_ClientId(beTr1Clients2.get_ClientId());
            beTr1Contacts.set_ContactName(beTr1Clients2.get_ClientCompany().Trim());
            beTr1Contacts.set_ContactLastName("");
            beTr1Contacts.set_DocumentNum(beTr1Clients2.get_ClientIdentity().Trim());
            beTr1Contacts.set_ChargeId(1);
            beTr1Contacts.set_PhoneC(beTr1Clients2.get_Phone().Trim());
            beTr1Contacts.set_DateBirthday(beTr1Clients2.get_FechaNacimiento());
            beTr1Contacts.set_IsActive(true);
            beTr1Contacts.set_UserS(ModGeneralVar.g_BE_USERS.get_UserId());
            str3 = blTr1Contacts.Add(ref beTr1Contacts);
            beTr1Contacts = (BE_TR1_CONTACTS) null;
          }
        }
        this.dgvExcelData.Rows[index].Cells["ESTADO"].Value = (object) str3;
        if (str3.Equals(StructApp.RESULT_OK))
          checked { ++num1; }
        else
          checked { ++num2; }
        beTr1Clients1 = (BE_TR1_CLIENTS) null;
        checked { ++index; }
      }
      this.dgvExcelData.AutoResizeColumns();
      this.dgvExcelData.Refresh();
      this.lblCargaron.Text = Conversions.ToString(num1);
      this.lblFallaron.Text = Conversions.ToString(num2);
      this.Cursor = Cursors.Default;
      beTr1Clients1 = (BE_TR1_CLIENTS) null;
      beTr1Contacts = (BE_TR1_CONTACTS) null;
      str1 = (string) null;
    }
  }
}
