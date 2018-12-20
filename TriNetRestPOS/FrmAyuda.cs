// Decompiled with JetBrains decompiler
// Type: TriNetRestPOS.FrmAyuda
// Assembly: TriNetRestPOS, Version=5.2.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 43377352-E952-4AC1-9BA6-CCBE4AE5F575
// Assembly location: C:\log\TriNetRestPOS.exe

using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using TR1_BusinessEntity;
using TR1_BusinessLogic;
using TriNetRestPOS.My.Resources;

namespace TriNetRestPOS
{
  [DesignerGenerated]
  public class FrmAyuda : Form
  {
    private IContainer components;
    private List<BE_TR1_QUESTION_FILES> lista;

    public FrmAyuda()
    {
      this.Load += new EventHandler(this.FrmAyuda_Load);
      this.KeyDown += new KeyEventHandler(this.FrmAyuda_KeyDown);
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
      this.components = (IContainer) new Container();
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (FrmAyuda));
      this.pnlSuperior = new Panel();
      this.txtId = new TextBox();
      this.txtFiltrar = new TextBox();
      this.Label2 = new Label();
      this.Label1 = new Label();
      this.pnlIzquierda = new Panel();
      this.dgvPreguntas = new DataGridView();
      this.pnlDerecha = new Panel();
      this.pnlInferior = new Panel();
      this.txtRespuesta = new RichTextBox();
      this.ImageList1 = new ImageList(this.components);
      this.pnlImagenes = new Panel();
      this.txtPregunta = new RichTextBox();
      this.pnlSuperior.SuspendLayout();
      this.pnlIzquierda.SuspendLayout();
      ((ISupportInitialize) this.dgvPreguntas).BeginInit();
      this.SuspendLayout();
      this.pnlSuperior.Controls.Add((Control) this.txtId);
      this.pnlSuperior.Controls.Add((Control) this.txtFiltrar);
      this.pnlSuperior.Controls.Add((Control) this.Label2);
      this.pnlSuperior.Controls.Add((Control) this.Label1);
      this.pnlSuperior.Dock = DockStyle.Top;
      this.pnlSuperior.Location = new Point(0, 0);
      this.pnlSuperior.Margin = new Padding(4, 5, 4, 5);
      this.pnlSuperior.Name = "pnlSuperior";
      this.pnlSuperior.Size = new Size(994, 45);
      this.pnlSuperior.TabIndex = 0;
      this.txtId.BackColor = Color.FromArgb((int) byte.MaxValue, 240, 144);
      this.txtId.Enabled = false;
      this.txtId.Font = new Font("Trebuchet MS", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.txtId.Location = new Point(741, 10);
      this.txtId.Name = "txtId";
      this.txtId.ReadOnly = true;
      this.txtId.Size = new Size(186, 25);
      this.txtId.TabIndex = 3;
      this.txtId.Visible = false;
      this.txtFiltrar.Font = new Font("Calibri", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.txtFiltrar.Location = new Point(72, 10);
      this.txtFiltrar.Name = "txtFiltrar";
      this.txtFiltrar.Size = new Size(614, 26);
      this.txtFiltrar.TabIndex = 2;
      this.Label2.AutoSize = true;
      this.Label2.Font = new Font("Calibri", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Label2.ForeColor = Color.MediumBlue;
      this.Label2.Location = new Point(56, 13);
      this.Label2.Name = "Label2";
      this.Label2.Size = new Size(12, 18);
      this.Label2.TabIndex = 1;
      this.Label2.Text = ":";
      this.Label1.AutoSize = true;
      this.Label1.Font = new Font("Calibri", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Label1.ForeColor = Color.MediumBlue;
      this.Label1.Location = new Point(13, 13);
      this.Label1.Name = "Label1";
      this.Label1.Size = new Size(45, 18);
      this.Label1.TabIndex = 0;
      this.Label1.Text = "Filtrar";
      this.pnlIzquierda.Controls.Add((Control) this.dgvPreguntas);
      this.pnlIzquierda.Dock = DockStyle.Left;
      this.pnlIzquierda.Location = new Point(0, 45);
      this.pnlIzquierda.Margin = new Padding(4, 5, 4, 5);
      this.pnlIzquierda.Name = "pnlIzquierda";
      this.pnlIzquierda.Size = new Size(350, 657);
      this.pnlIzquierda.TabIndex = 1;
      this.dgvPreguntas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dgvPreguntas.Dock = DockStyle.Fill;
      this.dgvPreguntas.Location = new Point(0, 0);
      this.dgvPreguntas.Name = "dgvPreguntas";
      this.dgvPreguntas.Size = new Size(350, 657);
      this.dgvPreguntas.TabIndex = 27;
      this.pnlDerecha.Dock = DockStyle.Right;
      this.pnlDerecha.Location = new Point(994, 45);
      this.pnlDerecha.Margin = new Padding(4, 5, 4, 5);
      this.pnlDerecha.Name = "pnlDerecha";
      this.pnlDerecha.Size = new Size(0, 657);
      this.pnlDerecha.TabIndex = 1;
      this.pnlInferior.Dock = DockStyle.Bottom;
      this.pnlInferior.Location = new Point(350, 702);
      this.pnlInferior.Margin = new Padding(4, 5, 4, 5);
      this.pnlInferior.Name = "pnlInferior";
      this.pnlInferior.Size = new Size(644, 0);
      this.pnlInferior.TabIndex = 2;
      this.txtRespuesta.BackColor = Color.MintCream;
      this.txtRespuesta.BorderStyle = BorderStyle.None;
      this.txtRespuesta.Font = new Font("Calibri", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.txtRespuesta.Location = new Point(352, 94);
      this.txtRespuesta.Margin = new Padding(0);
      this.txtRespuesta.Name = "txtRespuesta";
      this.txtRespuesta.ReadOnly = true;
      this.txtRespuesta.ScrollBars = RichTextBoxScrollBars.Vertical;
      this.txtRespuesta.Size = new Size(642, 199);
      this.txtRespuesta.TabIndex = 3;
      this.txtRespuesta.Text = ResSpanish.Res_MsgOk_O;
      this.ImageList1.ImageStream = (ImageListStreamer) componentResourceManager.GetObject("ImageList1.ImageStream");
      this.ImageList1.TransparentColor = Color.Transparent;
      this.ImageList1.Images.SetKeyName(0, "Chrysanthemum.jpg");
      this.ImageList1.Images.SetKeyName(1, "Desert.jpg");
      this.ImageList1.Images.SetKeyName(2, "Lighthouse.jpg");
      this.ImageList1.Images.SetKeyName(3, "Hydrangeas.jpg");
      this.ImageList1.Images.SetKeyName(4, "Koala.jpg");
      this.pnlImagenes.AutoScroll = true;
      this.pnlImagenes.BackColor = Color.MintCream;
      this.pnlImagenes.Location = new Point(351, 293);
      this.pnlImagenes.Margin = new Padding(0);
      this.pnlImagenes.Name = "pnlImagenes";
      this.pnlImagenes.Size = new Size(643, 409);
      this.pnlImagenes.TabIndex = 7;
      this.txtPregunta.BackColor = Color.MintCream;
      this.txtPregunta.BorderStyle = BorderStyle.None;
      this.txtPregunta.Font = new Font("Calibri", 14.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.txtPregunta.ForeColor = Color.MediumBlue;
      this.txtPregunta.Location = new Point(352, 46);
      this.txtPregunta.Margin = new Padding(0);
      this.txtPregunta.Name = "txtPregunta";
      this.txtPregunta.ReadOnly = true;
      this.txtPregunta.ScrollBars = RichTextBoxScrollBars.None;
      this.txtPregunta.Size = new Size(641, 48);
      this.txtPregunta.TabIndex = 8;
      this.txtPregunta.Text = "«Seleccione»";
      this.AutoScaleDimensions = new SizeF(9f, 20f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.BackColor = SystemColors.Window;
      this.ClientSize = new Size(994, 702);
      this.Controls.Add((Control) this.pnlImagenes);
      this.Controls.Add((Control) this.txtPregunta);
      this.Controls.Add((Control) this.pnlInferior);
      this.Controls.Add((Control) this.pnlIzquierda);
      this.Controls.Add((Control) this.pnlDerecha);
      this.Controls.Add((Control) this.pnlSuperior);
      this.Controls.Add((Control) this.txtRespuesta);
      this.Font = new Font("Trebuchet MS", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.FormBorderStyle = FormBorderStyle.FixedDialog;
      this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
      this.KeyPreview = true;
      this.Margin = new Padding(4, 5, 4, 5);
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = nameof (FrmAyuda);
      this.StartPosition = FormStartPosition.CenterScreen;
      this.Text = "Ayuda";
      this.pnlSuperior.ResumeLayout(false);
      this.pnlSuperior.PerformLayout();
      this.pnlIzquierda.ResumeLayout(false);
      ((ISupportInitialize) this.dgvPreguntas).EndInit();
      this.ResumeLayout(false);
    }

    internal virtual Panel pnlSuperior { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Panel pnlIzquierda { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Panel pnlDerecha { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Panel pnlInferior { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual TextBox txtFiltrar
    {
      get
      {
        return this._txtFiltrar;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.txtFiltrar_TextChanged);
        TextBox txtFiltrar1 = this._txtFiltrar;
        if (txtFiltrar1 != null)
          txtFiltrar1.TextChanged -= eventHandler;
        this._txtFiltrar = value;
        TextBox txtFiltrar2 = this._txtFiltrar;
        if (txtFiltrar2 == null)
          return;
        txtFiltrar2.TextChanged += eventHandler;
      }
    }

    internal virtual Label Label2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Label Label1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual DataGridView dgvPreguntas
    {
      get
      {
        return this._dgvPreguntas;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        DataGridViewCellEventHandler cellEventHandler = new DataGridViewCellEventHandler(this.dgvPreguntas_CellClick);
        DataGridView dgvPreguntas1 = this._dgvPreguntas;
        if (dgvPreguntas1 != null)
          dgvPreguntas1.CellClick -= cellEventHandler;
        this._dgvPreguntas = value;
        DataGridView dgvPreguntas2 = this._dgvPreguntas;
        if (dgvPreguntas2 == null)
          return;
        dgvPreguntas2.CellClick += cellEventHandler;
      }
    }

    internal virtual RichTextBox txtRespuesta { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual ImageList ImageList1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Panel pnlImagenes { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual TextBox txtId { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual RichTextBox txtPregunta { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    private void FrmAyuda_Load(object sender, EventArgs e)
    {
      this.SetearGrid();
      this.ListarActivos();
      this.txtFiltrar.Focus();
    }

    private void FrmAyuda_KeyDown(object sender, KeyEventArgs e)
    {
      if (e.KeyValue != 27)
        return;
      this.Close();
    }

    private void txtFiltrar_TextChanged(object sender, EventArgs e)
    {
      this.ListarActivos();
    }

    private void SetearGrid()
    {
      ModGeneralFunctions.SetUpDataGridViewBasic(this.dgvPreguntas);
      this.dgvPreguntas.Columns.Add("QuestionDes", "Pregunta");
      ModGeneralFunctions.SetUp_TextBoxColumn((DataGridViewTextBoxColumn) this.dgvPreguntas.Columns[0], "QuestionDes", (short) 320, "", true, DataGridViewContentAlignment.MiddleLeft, true);
      this.dgvPreguntas.Columns.Add("", "");
      ModGeneralFunctions.SetUp_TextBoxColumn((DataGridViewTextBoxColumn) this.dgvPreguntas.Columns[1], "", (short) 15, "", true, DataGridViewContentAlignment.MiddleLeft, true);
      this.dgvPreguntas.ScrollBars = ScrollBars.Vertical;
    }

    private void ListarActivos()
    {
      this.Cursor = Cursors.WaitCursor;
      this.dgvPreguntas.DataSource = (object) new BL_TR1_QUESTION().ListarTodoActivo(this.txtFiltrar.Text.Trim());
      this.Cursor = Cursors.Default;
    }

    private void dgvPreguntas_CellClick(object sender, DataGridViewCellEventArgs e)
    {
      if (!ModGeneralFunctions.DataGrid_Validated(this.dgvPreguntas))
        return;
      this.SeleccionarPregunta();
    }

    private void SeleccionarPregunta()
    {
      this.Cursor = Cursors.WaitCursor;
      string text = this.txtId.Text;
      string pstrNumero = Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateIndexGet(this.dgvPreguntas.DataSource, new object[1]
      {
        (object) this.dgvPreguntas.CurrentRow.Index
      }, (string[]) null), (System.Type) null, "QuestionId", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      if (!text.Equals(pstrNumero))
      {
        this.txtId.Text = pstrNumero;
        this.txtPregunta.Text = Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateIndexGet(this.dgvPreguntas.DataSource, new object[1]
        {
          (object) this.dgvPreguntas.CurrentRow.Index
        }, (string[]) null), (System.Type) null, "QuestionDes", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
        this.txtRespuesta.Text = Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateIndexGet(this.dgvPreguntas.DataSource, new object[1]
        {
          (object) this.dgvPreguntas.CurrentRow.Index
        }, (string[]) null), (System.Type) null, "QuestionRes", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
        this.limpiarImagenes();
        this.CargarArchivosxPregunta(ModGeneralFunctions.CadenaToInteger(pstrNumero));
      }
      this.Cursor = Cursors.Default;
    }

    private void CargarArchivosxPregunta(int questionId)
    {
      this.lista = new BL_TR1_QUESTION_FILES().ListarxQuestionId(questionId);
      this.llenarImagenes();
    }

    private void limpiarImagenes()
    {
      this.pnlImagenes.Controls.Clear();
      this.pnlImagenes.Refresh();
    }

    private void llenarImagenes()
    {
      string str1 = ModGeneralVar.g_AplicationPath() + "\\helpimg\\";
      int num1 = 621;
      int num2 = 285;
      int x = 0;
      int y = 0;
      int width = checked (num1 - 18);
      int height = checked (num2 - 15);
      Size size = new Size(width, height);
      int num3 = checked (this.lista.Count - 1);
      int index = 0;
      while (index <= num3)
      {
        string str2 = str1 + this.lista[index].get_Nombre();
        if (File.Exists(str2))
        {
          PictureBox pictureBox = new PictureBox();
          pictureBox.Size = size;
          pictureBox.Location = new Point(x, y);
          pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
          pictureBox.Image = Image.FromFile(str2);
          this.pnlImagenes.Controls.Add((Control) pictureBox);
          checked { y += height + 2; }
        }
        checked { ++index; }
      }
    }
  }
}
