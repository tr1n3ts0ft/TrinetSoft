// Decompiled with JetBrains decompiler
// Type: TriNetRestPOS.FrmCambioPrecioCarta
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
using TR1_BusinessEntity;
using TR1_BusinessLogic;
using TriNetRestPOS.My.Resources;

namespace TriNetRestPOS
{
  [DesignerGenerated]
  public class FrmCambioPrecioCarta : Form
  {
    private IContainer components;
    private string strPedidoId;
    private int intCartaId;
    private List<BE_TR1_ORDERDETAILS> oListaORDERDETAILS;
    private List<BE_TR1_CLIENTS> g_ListaCLIENTS;

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
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (FrmCambioPrecioCarta));
      this.Label3 = new Label();
      this.Label4 = new Label();
      this.txtBuscar = new TextBox();
      this.btnSalir = new Button();
      this.btnAplicar = new Button();
      this.btnBuscar = new Button();
      this.lblTipoCliente = new Label();
      this.Label6 = new Label();
      this.txtClienteNombre = new TextBox();
      this.txtClienteId = new TextBox();
      this.txtTipoClienteId = new TextBox();
      this.btnQuitar = new Button();
      this.SuspendLayout();
      this.Label3.AutoSize = true;
      this.Label3.Location = new Point(77, 12);
      this.Label3.Name = "Label3";
      this.Label3.Size = new Size(15, 20);
      this.Label3.TabIndex = 150;
      this.Label3.Text = ":";
      this.Label4.AutoSize = true;
      this.Label4.Font = new Font("Trebuchet MS", 11.25f, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, (byte) 0);
      this.Label4.ForeColor = Color.Red;
      this.Label4.Location = new Point(7, 12);
      this.Label4.Name = "Label4";
      this.Label4.Size = new Size(56, 20);
      this.Label4.TabIndex = 149;
      this.Label4.Text = "Buscar";
      this.txtBuscar.BackColor = SystemColors.Window;
      this.txtBuscar.Font = new Font("Tahoma", 12.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.txtBuscar.Location = new Point(94, 8);
      this.txtBuscar.MaxLength = 50;
      this.txtBuscar.Name = "txtBuscar";
      this.txtBuscar.Size = new Size(272, 28);
      this.txtBuscar.TabIndex = 0;
      this.txtBuscar.TextAlign = HorizontalAlignment.Center;
      this.btnSalir.Font = new Font("Trebuchet MS", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.btnSalir.ForeColor = Color.MediumBlue;
      this.btnSalir.Image = (Image) TriNetRestPOS.My.Resources.Resources.Close;
      this.btnSalir.Location = new Point(355, 78);
      this.btnSalir.Name = "btnSalir";
      this.btnSalir.Size = new Size(100, 65);
      this.btnSalir.TabIndex = 5;
      this.btnSalir.Tag = (object) ResSpanish.Res_MsgUserT;
      this.btnSalir.Text = "Salir";
      this.btnSalir.TextImageRelation = TextImageRelation.TextAboveImage;
      this.btnSalir.UseVisualStyleBackColor = true;
      this.btnAplicar.Font = new Font("Trebuchet MS", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.btnAplicar.ForeColor = Color.MediumBlue;
      this.btnAplicar.Image = (Image) TriNetRestPOS.My.Resources.Resources.icon_buy;
      this.btnAplicar.Location = new Point(93, 78);
      this.btnAplicar.Name = "btnAplicar";
      this.btnAplicar.Size = new Size(140, 65);
      this.btnAplicar.TabIndex = 3;
      this.btnAplicar.Tag = (object) ResSpanish.Res_MsgUserT;
      this.btnAplicar.Text = "Aplicar Dscto";
      this.btnAplicar.TextImageRelation = TextImageRelation.TextAboveImage;
      this.btnAplicar.UseVisualStyleBackColor = true;
      this.btnBuscar.ForeColor = Color.MediumBlue;
      this.btnBuscar.Image = (Image) TriNetRestPOS.My.Resources.Resources.Buscar_Small;
      this.btnBuscar.Location = new Point(368, 4);
      this.btnBuscar.Margin = new Padding(4, 5, 4, 5);
      this.btnBuscar.Name = "btnBuscar";
      this.btnBuscar.Size = new Size(86, 35);
      this.btnBuscar.TabIndex = 1;
      this.btnBuscar.Text = "Buscar";
      this.btnBuscar.TextImageRelation = TextImageRelation.ImageBeforeText;
      this.btnBuscar.UseVisualStyleBackColor = true;
      this.lblTipoCliente.AutoSize = true;
      this.lblTipoCliente.Location = new Point(7, 47);
      this.lblTipoCliente.Name = "lblTipoCliente";
      this.lblTipoCliente.Size = new Size(59, 20);
      this.lblTipoCliente.TabIndex = 310;
      this.lblTipoCliente.Text = "Cliente";
      this.Label6.AutoSize = true;
      this.Label6.Location = new Point(77, 47);
      this.Label6.Name = "Label6";
      this.Label6.Size = new Size(15, 20);
      this.Label6.TabIndex = 311;
      this.Label6.Text = ":";
      this.txtClienteNombre.BackColor = Color.FromArgb((int) byte.MaxValue, 240, 140);
      this.txtClienteNombre.Location = new Point(94, 44);
      this.txtClienteNombre.MaxLength = 10;
      this.txtClienteNombre.Name = "txtClienteNombre";
      this.txtClienteNombre.ReadOnly = true;
      this.txtClienteNombre.Size = new Size(360, 25);
      this.txtClienteNombre.TabIndex = 2;
      this.txtClienteNombre.TabStop = false;
      this.txtClienteNombre.TextAlign = HorizontalAlignment.Center;
      this.txtClienteId.BackColor = Color.FromArgb((int) byte.MaxValue, 240, 140);
      this.txtClienteId.Location = new Point(11, 98);
      this.txtClienteId.MaxLength = 10;
      this.txtClienteId.Name = "txtClienteId";
      this.txtClienteId.ReadOnly = true;
      this.txtClienteId.Size = new Size(15, 25);
      this.txtClienteId.TabIndex = 315;
      this.txtClienteId.TabStop = false;
      this.txtClienteId.TextAlign = HorizontalAlignment.Center;
      this.txtClienteId.Visible = false;
      this.txtTipoClienteId.BackColor = Color.FromArgb((int) byte.MaxValue, 240, 140);
      this.txtTipoClienteId.Location = new Point(32, 98);
      this.txtTipoClienteId.MaxLength = 10;
      this.txtTipoClienteId.Name = "txtTipoClienteId";
      this.txtTipoClienteId.ReadOnly = true;
      this.txtTipoClienteId.Size = new Size(15, 25);
      this.txtTipoClienteId.TabIndex = 316;
      this.txtTipoClienteId.TabStop = false;
      this.txtTipoClienteId.TextAlign = HorizontalAlignment.Center;
      this.txtTipoClienteId.Visible = false;
      this.btnQuitar.Font = new Font("Trebuchet MS", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.btnQuitar.ForeColor = Color.MediumBlue;
      this.btnQuitar.Image = (Image) TriNetRestPOS.My.Resources.Resources.Eliminar;
      this.btnQuitar.Location = new Point(233, 78);
      this.btnQuitar.Name = "btnQuitar";
      this.btnQuitar.Size = new Size(105, 65);
      this.btnQuitar.TabIndex = 4;
      this.btnQuitar.Tag = (object) ResSpanish.Res_MsgUserT;
      this.btnQuitar.Text = "Quitar Dscto";
      this.btnQuitar.TextImageRelation = TextImageRelation.TextAboveImage;
      this.btnQuitar.UseVisualStyleBackColor = true;
      this.AutoScaleDimensions = new SizeF(9f, 20f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.BackColor = SystemColors.Window;
      this.ClientSize = new Size(464, 152);
      this.Controls.Add((Control) this.btnQuitar);
      this.Controls.Add((Control) this.txtTipoClienteId);
      this.Controls.Add((Control) this.txtClienteId);
      this.Controls.Add((Control) this.txtClienteNombre);
      this.Controls.Add((Control) this.Label6);
      this.Controls.Add((Control) this.lblTipoCliente);
      this.Controls.Add((Control) this.btnBuscar);
      this.Controls.Add((Control) this.btnSalir);
      this.Controls.Add((Control) this.btnAplicar);
      this.Controls.Add((Control) this.txtBuscar);
      this.Controls.Add((Control) this.Label3);
      this.Controls.Add((Control) this.Label4);
      this.Font = new Font("Trebuchet MS", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.ForeColor = Color.MediumBlue;
      this.FormBorderStyle = FormBorderStyle.FixedDialog;
      this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
      this.KeyPreview = true;
      this.Margin = new Padding(4, 5, 4, 5);
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = nameof (FrmCambioPrecioCarta);
      this.StartPosition = FormStartPosition.CenterScreen;
      this.Text = "Cambio de Precio";
      this.ResumeLayout(false);
      this.PerformLayout();
    }

    internal virtual Label Label3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Label Label4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual TextBox txtBuscar
    {
      get
      {
        return this._txtBuscar;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        KeyPressEventHandler pressEventHandler = new KeyPressEventHandler(this.txtBuscar_KeyPress);
        TextBox txtBuscar1 = this._txtBuscar;
        if (txtBuscar1 != null)
          txtBuscar1.KeyPress -= pressEventHandler;
        this._txtBuscar = value;
        TextBox txtBuscar2 = this._txtBuscar;
        if (txtBuscar2 == null)
          return;
        txtBuscar2.KeyPress += pressEventHandler;
      }
    }

    internal virtual Button btnSalir
    {
      get
      {
        return this._btnSalir;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.btnSalir_Click);
        Button btnSalir1 = this._btnSalir;
        if (btnSalir1 != null)
          btnSalir1.Click -= eventHandler;
        this._btnSalir = value;
        Button btnSalir2 = this._btnSalir;
        if (btnSalir2 == null)
          return;
        btnSalir2.Click += eventHandler;
      }
    }

    internal virtual Button btnAplicar
    {
      get
      {
        return this._btnAplicar;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.btnAplicar_Click);
        Button btnAplicar1 = this._btnAplicar;
        if (btnAplicar1 != null)
          btnAplicar1.Click -= eventHandler;
        this._btnAplicar = value;
        Button btnAplicar2 = this._btnAplicar;
        if (btnAplicar2 == null)
          return;
        btnAplicar2.Click += eventHandler;
      }
    }

    internal virtual Button btnBuscar
    {
      get
      {
        return this._btnBuscar;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.btnBuscar_Click);
        Button btnBuscar1 = this._btnBuscar;
        if (btnBuscar1 != null)
          btnBuscar1.Click -= eventHandler;
        this._btnBuscar = value;
        Button btnBuscar2 = this._btnBuscar;
        if (btnBuscar2 == null)
          return;
        btnBuscar2.Click += eventHandler;
      }
    }

    internal virtual Label lblTipoCliente { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Label Label6 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual TextBox txtClienteNombre { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual TextBox txtClienteId { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual TextBox txtTipoClienteId { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Button btnQuitar
    {
      get
      {
        return this._btnQuitar;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.btnQuitar_Click);
        Button btnQuitar1 = this._btnQuitar;
        if (btnQuitar1 != null)
          btnQuitar1.Click -= eventHandler;
        this._btnQuitar = value;
        Button btnQuitar2 = this._btnQuitar;
        if (btnQuitar2 == null)
          return;
        btnQuitar2.Click += eventHandler;
      }
    }

    public FrmCambioPrecioCarta(
      string pstrPedidoId,
      int pintCartaId,
      List<BE_TR1_ORDERDETAILS> pListaORDERDETAILS)
    {
      this.Load += new EventHandler(this.FrmCambioPrecioCarta_Load);
      this.strPedidoId = "";
      this.intCartaId = 0;
      this.InitializeComponent();
      this.strPedidoId = pstrPedidoId;
      this.intCartaId = pintCartaId;
      this.oListaORDERDETAILS = pListaORDERDETAILS;
    }

    private void FrmCambioPrecioCarta_Load(object sender, EventArgs e)
    {
      this.txtBuscar.Focus();
    }

    private void btnBuscar_Click(object sender, EventArgs e)
    {
      this.BuscarCodigoContacto(this.txtBuscar.Text.Trim());
    }

    private void txtBuscar_KeyPress(object sender, KeyPressEventArgs e)
    {
      if (!ModGeneralFunctions.Question_Made_Enter(e))
        return;
      this.BuscarCodigoContacto(this.txtBuscar.Text.Trim());
    }

    private void BuscarCodigoContacto(string pstrCodigo)
    {
      if (pstrCodigo.Trim().Equals(""))
      {
        this.txtClienteId.Text = "";
        this.txtClienteNombre.Text = "";
        this.txtTipoClienteId.Text = "";
        this.lblTipoCliente.Text = "Cliente";
      }
      else
      {
        BL_TR1_CLIENTS blTr1Clients = new BL_TR1_CLIENTS();
        string str = "";
        List<BE_TR1_CLIENTS> beTr1ClientsList1 = (List<BE_TR1_CLIENTS>) null;
        this.Cursor = Cursors.WaitCursor;
        try
        {
          List<BE_TR1_CLIENTS> beTr1ClientsList2 = blTr1Clients.ListarxNombre("", pstrCodigo, "", "");
          if (beTr1ClientsList2 != null)
          {
            if (beTr1ClientsList2.Count == 0)
            {
              beTr1ClientsList2 = blTr1Clients.ListarxNombre("", "", "", pstrCodigo);
              if (beTr1ClientsList2 != null && beTr1ClientsList2.Count > 0)
                str = beTr1ClientsList2[0].get_ClientId();
            }
            else
              str = beTr1ClientsList2[0].get_ClientId();
          }
          if (!str.Trim().Equals(""))
          {
            this.txtClienteId.Text = str;
            this.txtClienteNombre.Text = beTr1ClientsList2[0].get_ClientCompany();
            this.txtTipoClienteId.Text = Conversions.ToString(beTr1ClientsList2[0].get_TipoClienteId());
            this.lblTipoCliente.Text = beTr1ClientsList2[0].get_TipoClienteNombre();
            this.BuscarPorTipoCliente(this.intCartaId, ModGeneralFunctions.CadenaToInteger(this.txtTipoClienteId.Text));
            this.btnAplicar.Focus();
          }
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          ModGeneralFunctions.MessageOk_Large("Error - " + ex.Message, false);
          ProjectData.ClearProjectError();
        }
        beTr1ClientsList1 = (List<BE_TR1_CLIENTS>) null;
        this.Cursor = Cursors.Default;
      }
    }

    private void BuscarPorTipoCliente(int pintCartaId, int pintTipoClienteId)
    {
      int num = checked (this.oListaORDERDETAILS.Count - 1);
      int index = 0;
      while (index <= num)
      {
        this.oListaORDERDETAILS[index].set_PriceSale(this.BuscarPrecio(this.intCartaId, this.oListaORDERDETAILS[index].get_ProductId(), this.oListaORDERDETAILS[index].get_ProductDes(), pintTipoClienteId));
        checked { ++index; }
      }
    }

    public double BuscarPrecio(
      int pintCartaId,
      string pstrProductoId,
      string pstrProductoNombre,
      int pintTipoPrecioId)
    {
      BL_TR1_CARTA_PRODUCTO tr1CartaProducto = new BL_TR1_CARTA_PRODUCTO();
      double num;
      try
      {
        num = tr1CartaProducto.BuscarPrecio(pintCartaId, pstrProductoId, pintTipoPrecioId);
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ModGeneralFunctions.MessageOk("¡Producto: " + pstrProductoNombre + ", Precio Cero!");
        num = 0.0;
        ProjectData.ClearProjectError();
      }
      return num;
    }

    private bool ValidatDatos()
    {
      if (this.strPedidoId.Trim().Equals(""))
      {
        ModGeneralFunctions.MessageOk("¡Parámetros iniciales no válidos!");
        return false;
      }
      if (!this.txtClienteId.Text.Trim().Equals(""))
        return true;
      ModGeneralFunctions.MessageOk("¡Busque un Cliente válido!");
      this.txtBuscar.Focus();
      return false;
    }

    private void btnAplicar_Click(object sender, EventArgs e)
    {
      if (!this.ValidatDatos())
        return;
      if (ModGeneralFunctions.ObtenerAPPCONFIG("CLIENTE").Equals((object) "ACBT"))
      {
        string str = new BL_TR1_CLIENTS().VerificarCuotasDeudoras(this.txtBuscar.Text.Trim());
        if ((uint) Operators.CompareString(str, "OK", false) > 0U)
        {
          ModGeneralFunctions.MessageMistake(str);
          return;
        }
      }
      if (ModGeneralFunctions.MessageMakeAction("¿Seguro de Aplicar el Dscto.?", false))
      {
        string p_Mensaje = "";
        BL_TR1_ORDERDETAILS blTr1Orderdetails = new BL_TR1_ORDERDETAILS();
        int num = checked (this.oListaORDERDETAILS.Count - 1);
        int index = 0;
        while (index <= num)
        {
          p_Mensaje = blTr1Orderdetails.CambiarPrecioxCarta(this.strPedidoId, this.oListaORDERDETAILS[index].get_ItemId(), this.oListaORDERDETAILS[index].get_PriceSale(), this.txtClienteId.Text.Trim());
          checked { ++index; }
        }
        if (p_Mensaje.Equals(StructApp.RESULT_OK))
        {
          FrmReTouchPOS frmReTouchPos = new FrmReTouchPOS();
          string str = "";
          str = new BL_TR1_ORDERS().ModifyClient(this.strPedidoId, this.txtClienteId.Text.Trim(), frmReTouchPos.o_BE_TR1_ORDER.get_OrderFree());
          ModGeneralVar.g_bol_IsReady = true;
          this.Close();
        }
        else
          ModGeneralFunctions.MessageError_Large(p_Mensaje, true);
      }
    }

    private void btnQuitar_Click(object sender, EventArgs e)
    {
      if (!ModGeneralFunctions.MessageMakeAction("¿Seguro de Quitar el Dscto.?", false))
        return;
      this.BuscarPorTipoCliente(this.intCartaId, 3);
      string p_Mensaje = "";
      BL_TR1_ORDERDETAILS blTr1Orderdetails = new BL_TR1_ORDERDETAILS();
      int num = checked (this.oListaORDERDETAILS.Count - 1);
      int index = 0;
      while (index <= num)
      {
        p_Mensaje = blTr1Orderdetails.CambiarPrecioxCarta(this.strPedidoId, this.oListaORDERDETAILS[index].get_ItemId(), this.oListaORDERDETAILS[index].get_PriceSale(), this.txtClienteId.Text.Trim());
        checked { ++index; }
      }
      if (p_Mensaje.Equals(StructApp.RESULT_OK))
      {
        ModGeneralVar.g_bol_IsReady = true;
        this.Close();
      }
      else
        ModGeneralFunctions.MessageError_Large(p_Mensaje, true);
    }

    private void btnSalir_Click(object sender, EventArgs e)
    {
      ModGeneralVar.g_bol_IsReady = false;
      this.Close();
    }
  }
}
