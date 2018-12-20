// Decompiled with JetBrains decompiler
// Type: TriNetRestPOS.FrmChangePrice
// Assembly: TriNetRestPOS, Version=5.2.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 43377352-E952-4AC1-9BA6-CCBE4AE5F575
// Assembly location: C:\log\TriNetRestPOS.exe

using KIS.Controls;
using KIS.Controls.Windows;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace TriNetRestPOS
{
  [DesignerGenerated]
  public class FrmChangePrice : Form
  {
    private IContainer components;
    public double dbl_NewPrice;
    private Control _control;
    public string str_Observation;
    private string Res_ObservationInput;

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
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (FrmChangePrice));
      this.TextBox_OfficialPrice = new NumericTextBox.NumericTextBox();
      this.TextBox_AmountPay = new NumericTextBox.NumericTextBox();
      this.Label_AmountPay = new Label();
      this.Label_AmountSale = new Label();
      this.Button_GoOut = new Button();
      this.Button_Accept = new Button();
      this.Button_PercentMore = new Button();
      this.Button_PercentLess = new Button();
      this.Label_Percentage = new Label();
      this.TextBox_Percent = new NumericTextBox.NumericTextBox();
      this.Button_SetPrice = new Button();
      this.TextBox_Quantity = new NumericTextBox.NumericTextBox();
      this.Label_Quantity = new Label();
      this.Label_NewPrice = new Label();
      this.TextBox_NewPrice = new NumericTextBox.NumericTextBox();
      this.HeaderPanel_Precio = new HeaderPanel();
      this.Label3 = new Label();
      this.Label2 = new Label();
      this.HeaderPanel_Pedido = new HeaderPanel();
      this.TextBox_Observation = new TextBox();
      this.Label4 = new Label();
      this.Button_Observation = new Button();
      this.Label1 = new Label();
      this.TextBox_ProductDes = new TextBox();
      this.Label_ClientDes = new Label();
      this.Label5 = new Label();
      ((Control) this.HeaderPanel_Precio).SuspendLayout();
      ((Control) this.HeaderPanel_Pedido).SuspendLayout();
      this.SuspendLayout();
      this.TextBox_OfficialPrice.set_AllowSpace(false);
      ((TextBoxBase) this.TextBox_OfficialPrice).BackColor = Color.LightGray;
      ((TextBoxBase) this.TextBox_OfficialPrice).BorderStyle = BorderStyle.FixedSingle;
      ((Control) this.TextBox_OfficialPrice).Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      ((TextBoxBase) this.TextBox_OfficialPrice).ForeColor = Color.FromArgb(0, 0, 0, 4);
      ((Control) this.TextBox_OfficialPrice).Location = new Point(194, 151);
      ((TextBox) this.TextBox_OfficialPrice).Multiline = true;
      ((Control) this.TextBox_OfficialPrice).Name = "TextBox_OfficialPrice";
      ((TextBoxBase) this.TextBox_OfficialPrice).ReadOnly = true;
      ((Control) this.TextBox_OfficialPrice).Size = new Size(153, 31);
      ((Control) this.TextBox_OfficialPrice).TabIndex = 1;
      ((TextBox) this.TextBox_OfficialPrice).Text = "0.00";
      ((TextBox) this.TextBox_OfficialPrice).TextAlign = HorizontalAlignment.Right;
      this.TextBox_AmountPay.set_AllowSpace(false);
      ((TextBoxBase) this.TextBox_AmountPay).BackColor = Color.White;
      ((TextBoxBase) this.TextBox_AmountPay).BorderStyle = BorderStyle.FixedSingle;
      ((Control) this.TextBox_AmountPay).Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      ((TextBoxBase) this.TextBox_AmountPay).ForeColor = Color.FromArgb(209, 102, 61);
      ((Control) this.TextBox_AmountPay).Location = new Point(194, 443);
      ((TextBox) this.TextBox_AmountPay).Multiline = true;
      ((Control) this.TextBox_AmountPay).Name = "TextBox_AmountPay";
      ((TextBoxBase) this.TextBox_AmountPay).ReadOnly = true;
      ((Control) this.TextBox_AmountPay).Size = new Size(153, 31);
      ((Control) this.TextBox_AmountPay).TabIndex = 8;
      ((TextBox) this.TextBox_AmountPay).Text = "0.00";
      ((TextBox) this.TextBox_AmountPay).TextAlign = HorizontalAlignment.Right;
      this.Label_AmountPay.AutoSize = true;
      this.Label_AmountPay.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Label_AmountPay.ForeColor = Color.FromArgb(209, 102, 61);
      this.Label_AmountPay.Location = new Point(12, 450);
      this.Label_AmountPay.Name = "Label_AmountPay";
      this.Label_AmountPay.Size = new Size(139, 20);
      this.Label_AmountPay.TabIndex = 197;
      this.Label_AmountPay.Tag = (object) "Res_TotalPay";
      this.Label_AmountPay.Text = "TOTAL A PAGAR:";
      this.Label_AmountSale.AutoSize = true;
      this.Label_AmountSale.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Label_AmountSale.ForeColor = Color.FromArgb(150, 150, 150);
      this.Label_AmountSale.Location = new Point(11, 156);
      this.Label_AmountSale.Name = "Label_AmountSale";
      this.Label_AmountSale.Size = new Size(96, 18);
      this.Label_AmountSale.TabIndex = 198;
      this.Label_AmountSale.Tag = (object) "Res_PriceSale";
      this.Label_AmountSale.Text = "Precio Venta:";
      this.Button_GoOut.BackgroundImage = (Image) TriNetRestPOS.My.Resources.Resources.atras;
      this.Button_GoOut.FlatStyle = FlatStyle.Flat;
      this.Button_GoOut.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Button_GoOut.ForeColor = Color.WhiteSmoke;
      this.Button_GoOut.Image = (Image) TriNetRestPOS.My.Resources.Resources.salir;
      this.Button_GoOut.ImageAlign = ContentAlignment.TopCenter;
      this.Button_GoOut.Location = new Point(448, 429);
      this.Button_GoOut.Name = "Button_GoOut";
      this.Button_GoOut.Padding = new Padding(0, 5, 0, 5);
      this.Button_GoOut.Size = new Size(84, 66);
      this.Button_GoOut.TabIndex = 10;
      this.Button_GoOut.Tag = (object) "Res_Back";
      this.Button_GoOut.Text = "Atrás";
      this.Button_GoOut.TextAlign = ContentAlignment.BottomCenter;
      this.Button_GoOut.UseVisualStyleBackColor = true;
      this.Button_Accept.BackgroundImage = (Image) TriNetRestPOS.My.Resources.Resources.guardar;
      this.Button_Accept.FlatStyle = FlatStyle.Flat;
      this.Button_Accept.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Button_Accept.ForeColor = Color.WhiteSmoke;
      this.Button_Accept.Image = (Image) TriNetRestPOS.My.Resources.Resources.check_OK;
      this.Button_Accept.ImageAlign = ContentAlignment.TopCenter;
      this.Button_Accept.Location = new Point(362, 429);
      this.Button_Accept.Name = "Button_Accept";
      this.Button_Accept.Padding = new Padding(0, 5, 0, 5);
      this.Button_Accept.Size = new Size(84, 66);
      this.Button_Accept.TabIndex = 9;
      this.Button_Accept.Tag = (object) "Res_Ok";
      this.Button_Accept.Text = "OK";
      this.Button_Accept.TextAlign = ContentAlignment.BottomCenter;
      this.Button_Accept.UseVisualStyleBackColor = true;
      this.Button_PercentMore.BackgroundImage = (Image) componentResourceManager.GetObject("Button_PercentMore.BackgroundImage");
      this.Button_PercentMore.FlatStyle = FlatStyle.Flat;
      this.Button_PercentMore.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Button_PercentMore.ForeColor = Color.WhiteSmoke;
      this.Button_PercentMore.Image = (Image) TriNetRestPOS.My.Resources.Resources.icono_1;
      this.Button_PercentMore.ImageAlign = ContentAlignment.TopCenter;
      this.Button_PercentMore.Location = new Point(450, 4);
      this.Button_PercentMore.Name = "Button_PercentMore";
      this.Button_PercentMore.Padding = new Padding(0, 5, 0, 5);
      this.Button_PercentMore.Size = new Size(84, 66);
      this.Button_PercentMore.TabIndex = 4;
      this.Button_PercentMore.Tag = (object) "c";
      this.Button_PercentMore.Text = "Por %";
      this.Button_PercentMore.TextAlign = ContentAlignment.BottomCenter;
      this.Button_PercentMore.UseVisualStyleBackColor = true;
      this.Button_PercentLess.BackgroundImage = (Image) componentResourceManager.GetObject("Button_PercentLess.BackgroundImage");
      this.Button_PercentLess.FlatStyle = FlatStyle.Flat;
      this.Button_PercentLess.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Button_PercentLess.ForeColor = Color.WhiteSmoke;
      this.Button_PercentLess.Image = (Image) TriNetRestPOS.My.Resources.Resources.icono_;
      this.Button_PercentLess.ImageAlign = ContentAlignment.TopCenter;
      this.Button_PercentLess.Location = new Point(364, 4);
      this.Button_PercentLess.Name = "Button_PercentLess";
      this.Button_PercentLess.Padding = new Padding(0, 5, 0, 5);
      this.Button_PercentLess.Size = new Size(84, 66);
      this.Button_PercentLess.TabIndex = 3;
      this.Button_PercentLess.Tag = (object) "c";
      this.Button_PercentLess.Text = "Por %";
      this.Button_PercentLess.TextAlign = ContentAlignment.BottomCenter;
      this.Button_PercentLess.UseVisualStyleBackColor = true;
      this.Label_Percentage.AutoSize = true;
      this.Label_Percentage.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Label_Percentage.ForeColor = Color.FromArgb(150, 150, 150);
      this.Label_Percentage.Location = new Point(13, 23);
      this.Label_Percentage.Name = "Label_Percentage";
      this.Label_Percentage.Size = new Size(83, 18);
      this.Label_Percentage.TabIndex = 204;
      this.Label_Percentage.Tag = (object) "Res_Percentage";
      this.Label_Percentage.Text = "Porcentaje:";
      this.TextBox_Percent.set_AllowSpace(false);
      ((TextBoxBase) this.TextBox_Percent).BackColor = Color.LightGray;
      ((TextBoxBase) this.TextBox_Percent).BorderStyle = BorderStyle.FixedSingle;
      ((Control) this.TextBox_Percent).Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      ((TextBoxBase) this.TextBox_Percent).ForeColor = Color.Black;
      ((Control) this.TextBox_Percent).Location = new Point(193, 18);
      ((TextBox) this.TextBox_Percent).Multiline = true;
      ((Control) this.TextBox_Percent).Name = "TextBox_Percent";
      ((TextBoxBase) this.TextBox_Percent).ReadOnly = true;
      ((Control) this.TextBox_Percent).Size = new Size(153, 31);
      ((Control) this.TextBox_Percent).TabIndex = 2;
      ((TextBox) this.TextBox_Percent).Text = "0.00";
      ((TextBox) this.TextBox_Percent).TextAlign = HorizontalAlignment.Right;
      this.Button_SetPrice.BackgroundImage = (Image) componentResourceManager.GetObject("Button_SetPrice.BackgroundImage");
      this.Button_SetPrice.FlatStyle = FlatStyle.Flat;
      this.Button_SetPrice.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Button_SetPrice.ForeColor = Color.WhiteSmoke;
      this.Button_SetPrice.Image = (Image) TriNetRestPOS.My.Resources.Resources.teclado_nueral;
      this.Button_SetPrice.ImageAlign = ContentAlignment.TopCenter;
      this.Button_SetPrice.Location = new Point(364, 70);
      this.Button_SetPrice.Name = "Button_SetPrice";
      this.Button_SetPrice.Size = new Size(84, 66);
      this.Button_SetPrice.TabIndex = 6;
      this.Button_SetPrice.Tag = (object) "c";
      this.Button_SetPrice.Text = "x Monto";
      this.Button_SetPrice.TextAlign = ContentAlignment.BottomCenter;
      this.Button_SetPrice.UseVisualStyleBackColor = true;
      this.TextBox_Quantity.set_AllowSpace(false);
      ((TextBoxBase) this.TextBox_Quantity).BackColor = Color.LightGray;
      ((TextBoxBase) this.TextBox_Quantity).BorderStyle = BorderStyle.FixedSingle;
      ((Control) this.TextBox_Quantity).Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      ((TextBoxBase) this.TextBox_Quantity).ForeColor = Color.Black;
      ((Control) this.TextBox_Quantity).Location = new Point(193, 137);
      ((TextBox) this.TextBox_Quantity).Multiline = true;
      ((Control) this.TextBox_Quantity).Name = "TextBox_Quantity";
      ((TextBoxBase) this.TextBox_Quantity).ReadOnly = true;
      ((Control) this.TextBox_Quantity).Size = new Size(153, 31);
      ((Control) this.TextBox_Quantity).TabIndex = 7;
      ((TextBox) this.TextBox_Quantity).Text = "0.00";
      ((TextBox) this.TextBox_Quantity).TextAlign = HorizontalAlignment.Right;
      this.Label_Quantity.AutoSize = true;
      this.Label_Quantity.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Label_Quantity.ForeColor = Color.FromArgb(150, 150, 150);
      this.Label_Quantity.Location = new Point(13, 142);
      this.Label_Quantity.Name = "Label_Quantity";
      this.Label_Quantity.Size = new Size(70, 18);
      this.Label_Quantity.TabIndex = 202;
      this.Label_Quantity.Tag = (object) "Res_Quantity";
      this.Label_Quantity.Text = "Cantidad:";
      this.Label_NewPrice.AutoSize = true;
      this.Label_NewPrice.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Label_NewPrice.ForeColor = Color.FromArgb(150, 150, 150);
      this.Label_NewPrice.Location = new Point(13, 86);
      this.Label_NewPrice.Name = "Label_NewPrice";
      this.Label_NewPrice.Size = new Size(102, 18);
      this.Label_NewPrice.TabIndex = 200;
      this.Label_NewPrice.Tag = (object) "Res_NewPrice";
      this.Label_NewPrice.Text = "Nuevo Precio:";
      this.TextBox_NewPrice.set_AllowSpace(false);
      ((TextBoxBase) this.TextBox_NewPrice).BackColor = Color.LightGray;
      ((TextBoxBase) this.TextBox_NewPrice).BorderStyle = BorderStyle.FixedSingle;
      ((Control) this.TextBox_NewPrice).Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      ((TextBoxBase) this.TextBox_NewPrice).ForeColor = Color.Black;
      ((Control) this.TextBox_NewPrice).Location = new Point(193, 81);
      ((TextBox) this.TextBox_NewPrice).Multiline = true;
      ((Control) this.TextBox_NewPrice).Name = "TextBox_NewPrice";
      ((TextBoxBase) this.TextBox_NewPrice).ReadOnly = true;
      ((Control) this.TextBox_NewPrice).Size = new Size(153, 31);
      ((Control) this.TextBox_NewPrice).TabIndex = 5;
      ((TextBox) this.TextBox_NewPrice).Text = "0.00";
      ((TextBox) this.TextBox_NewPrice).TextAlign = HorizontalAlignment.Right;
      this.HeaderPanel_Precio.set_BorderColor(SystemColors.ActiveCaption);
      this.HeaderPanel_Precio.set_BorderStyle((BorderStyles) 1);
      this.HeaderPanel_Precio.set_CaptionBeginColor(Color.FromArgb(209, 102, 61));
      this.HeaderPanel_Precio.set_CaptionEndColor(Color.FromArgb(209, 102, 61));
      this.HeaderPanel_Precio.set_CaptionGradientDirection(LinearGradientMode.Vertical);
      this.HeaderPanel_Precio.set_CaptionHeight(26);
      this.HeaderPanel_Precio.set_CaptionPosition((CaptionPositions) 0);
      this.HeaderPanel_Precio.set_CaptionText("Se Aplicará el Nuevo Precio:");
      this.HeaderPanel_Precio.set_CaptionVisible(true);
      ((Control) this.HeaderPanel_Precio).Controls.Add((Control) this.Label3);
      ((Control) this.HeaderPanel_Precio).Controls.Add((Control) this.Label2);
      ((Control) this.HeaderPanel_Precio).Controls.Add((Control) this.Button_PercentMore);
      ((Control) this.HeaderPanel_Precio).Controls.Add((Control) this.Button_PercentLess);
      ((Control) this.HeaderPanel_Precio).Controls.Add((Control) this.Label_Percentage);
      ((Control) this.HeaderPanel_Precio).Controls.Add((Control) this.TextBox_NewPrice);
      ((Control) this.HeaderPanel_Precio).Controls.Add((Control) this.TextBox_Percent);
      ((Control) this.HeaderPanel_Precio).Controls.Add((Control) this.Label_NewPrice);
      ((Control) this.HeaderPanel_Precio).Controls.Add((Control) this.Button_SetPrice);
      ((Control) this.HeaderPanel_Precio).Controls.Add((Control) this.Label_Quantity);
      ((Control) this.HeaderPanel_Precio).Controls.Add((Control) this.TextBox_Quantity);
      this.HeaderPanel_Precio.set_Font(new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0));
      ((Control) this.HeaderPanel_Precio).ForeColor = Color.WhiteSmoke;
      this.HeaderPanel_Precio.set_GradientDirection(LinearGradientMode.Vertical);
      this.HeaderPanel_Precio.set_GradientEnd(SystemColors.Window);
      this.HeaderPanel_Precio.set_GradientStart(SystemColors.Window);
      ((Control) this.HeaderPanel_Precio).Location = new Point(0, 218);
      ((Control) this.HeaderPanel_Precio).Name = "HeaderPanel_Precio";
      this.HeaderPanel_Precio.set_PanelIcon((Icon) null);
      this.HeaderPanel_Precio.set_PanelIconVisible(false);
      ((Control) this.HeaderPanel_Precio).Size = new Size(545, 210);
      ((Control) this.HeaderPanel_Precio).TabIndex = 209;
      this.HeaderPanel_Precio.set_TextAntialias(true);
      this.Label3.AutoSize = true;
      this.Label3.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Label3.ForeColor = Color.FromArgb(150, 150, 150);
      this.Label3.Location = new Point(160, 23);
      this.Label3.Name = "Label3";
      this.Label3.Size = new Size(21, 18);
      this.Label3.TabIndex = 209;
      this.Label3.Tag = (object) "Res_NewPrice";
      this.Label3.Text = "%";
      this.Label2.AutoSize = true;
      this.Label2.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Label2.ForeColor = Color.FromArgb(150, 150, 150);
      this.Label2.Location = new Point(160, 86);
      this.Label2.Name = "Label2";
      this.Label2.Size = new Size(26, 18);
      this.Label2.TabIndex = 208;
      this.Label2.Tag = (object) "Res_NewPrice";
      this.Label2.Text = "S/.";
      this.HeaderPanel_Pedido.set_BorderColor(SystemColors.ActiveCaption);
      this.HeaderPanel_Pedido.set_BorderStyle((BorderStyles) 1);
      this.HeaderPanel_Pedido.set_CaptionBeginColor(Color.FromArgb(209, 102, 61));
      this.HeaderPanel_Pedido.set_CaptionEndColor(Color.FromArgb(209, 102, 61));
      this.HeaderPanel_Pedido.set_CaptionGradientDirection(LinearGradientMode.Vertical);
      this.HeaderPanel_Pedido.set_CaptionHeight(26);
      this.HeaderPanel_Pedido.set_CaptionPosition((CaptionPositions) 0);
      this.HeaderPanel_Pedido.set_CaptionText("Datos del Producto");
      this.HeaderPanel_Pedido.set_CaptionVisible(true);
      ((Control) this.HeaderPanel_Pedido).Controls.Add((Control) this.TextBox_Observation);
      ((Control) this.HeaderPanel_Pedido).Controls.Add((Control) this.Label4);
      ((Control) this.HeaderPanel_Pedido).Controls.Add((Control) this.Button_Observation);
      ((Control) this.HeaderPanel_Pedido).Controls.Add((Control) this.Label1);
      ((Control) this.HeaderPanel_Pedido).Controls.Add((Control) this.TextBox_OfficialPrice);
      ((Control) this.HeaderPanel_Pedido).Controls.Add((Control) this.TextBox_ProductDes);
      ((Control) this.HeaderPanel_Pedido).Controls.Add((Control) this.Label_ClientDes);
      ((Control) this.HeaderPanel_Pedido).Controls.Add((Control) this.Label_AmountSale);
      this.HeaderPanel_Pedido.set_Font(new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0));
      ((Control) this.HeaderPanel_Pedido).ForeColor = Color.WhiteSmoke;
      this.HeaderPanel_Pedido.set_GradientDirection(LinearGradientMode.Vertical);
      this.HeaderPanel_Pedido.set_GradientEnd(SystemColors.Window);
      this.HeaderPanel_Pedido.set_GradientStart(SystemColors.Window);
      ((Control) this.HeaderPanel_Pedido).Location = new Point(-1, 0);
      ((Control) this.HeaderPanel_Pedido).Name = "HeaderPanel_Pedido";
      this.HeaderPanel_Pedido.set_PanelIcon((Icon) null);
      this.HeaderPanel_Pedido.set_PanelIconVisible(false);
      ((Control) this.HeaderPanel_Pedido).Size = new Size(546, 217);
      ((Control) this.HeaderPanel_Pedido).TabIndex = 210;
      this.HeaderPanel_Pedido.set_TextAntialias(true);
      this.TextBox_Observation.BackColor = Color.LightGray;
      this.TextBox_Observation.BorderStyle = BorderStyle.FixedSingle;
      this.TextBox_Observation.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.TextBox_Observation.ForeColor = Color.Black;
      this.TextBox_Observation.Location = new Point(13, 89);
      this.TextBox_Observation.Multiline = true;
      this.TextBox_Observation.Name = "TextBox_Observation";
      this.TextBox_Observation.ReadOnly = true;
      this.TextBox_Observation.Size = new Size(428, 41);
      this.TextBox_Observation.TabIndex = 209;
      this.Label4.AutoSize = true;
      this.Label4.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Label4.ForeColor = Color.FromArgb(209, 102, 61);
      this.Label4.Location = new Point(12, 62);
      this.Label4.Name = "Label4";
      this.Label4.Size = new Size(96, 18);
      this.Label4.TabIndex = 211;
      this.Label4.Text = "Observación:";
      this.Button_Observation.BackgroundImage = (Image) TriNetRestPOS.My.Resources.Resources.observar;
      this.Button_Observation.FlatStyle = FlatStyle.Flat;
      this.Button_Observation.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Button_Observation.ForeColor = Color.WhiteSmoke;
      this.Button_Observation.Image = (Image) TriNetRestPOS.My.Resources.Resources.buscar_oc_icono;
      this.Button_Observation.ImageAlign = ContentAlignment.TopCenter;
      this.Button_Observation.Location = new Point(448, 74);
      this.Button_Observation.Name = "Button_Observation";
      this.Button_Observation.Padding = new Padding(0, 5, 0, 5);
      this.Button_Observation.Size = new Size(84, 66);
      this.Button_Observation.TabIndex = 210;
      this.Button_Observation.Text = "Observa";
      this.Button_Observation.TextAlign = ContentAlignment.BottomCenter;
      this.Button_Observation.UseVisualStyleBackColor = true;
      this.Label1.AutoSize = true;
      this.Label1.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Label1.ForeColor = Color.FromArgb(150, 150, 150);
      this.Label1.Location = new Point(161, 156);
      this.Label1.Name = "Label1";
      this.Label1.Size = new Size(26, 18);
      this.Label1.TabIndex = 207;
      this.Label1.Tag = (object) "Res_NewPrice";
      this.Label1.Text = "S/.";
      this.TextBox_ProductDes.BackColor = Color.LightGray;
      this.TextBox_ProductDes.BorderStyle = BorderStyle.FixedSingle;
      this.TextBox_ProductDes.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.TextBox_ProductDes.ForeColor = Color.Black;
      this.TextBox_ProductDes.Location = new Point(106, 11);
      this.TextBox_ProductDes.Multiline = true;
      this.TextBox_ProductDes.Name = "TextBox_ProductDes";
      this.TextBox_ProductDes.ReadOnly = true;
      this.TextBox_ProductDes.Size = new Size(427, 41);
      this.TextBox_ProductDes.TabIndex = 0;
      this.Label_ClientDes.AutoSize = true;
      this.Label_ClientDes.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Label_ClientDes.ForeColor = Color.FromArgb(209, 102, 61);
      this.Label_ClientDes.Location = new Point(11, 14);
      this.Label_ClientDes.Name = "Label_ClientDes";
      this.Label_ClientDes.Size = new Size(73, 18);
      this.Label_ClientDes.TabIndex = 204;
      this.Label_ClientDes.Text = "Producto:";
      this.Label5.AutoSize = true;
      this.Label5.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Label5.ForeColor = Color.FromArgb(209, 102, 61);
      this.Label5.Location = new Point(161, 450);
      this.Label5.Name = "Label5";
      this.Label5.Size = new Size(28, 20);
      this.Label5.TabIndex = 211;
      this.Label5.Tag = (object) "Res_NewPrice";
      this.Label5.Text = "S/.";
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.BackColor = Color.White;
      this.ClientSize = new Size(544, 495);
      this.ControlBox = false;
      this.Controls.Add((Control) this.Label5);
      this.Controls.Add((Control) this.HeaderPanel_Pedido);
      this.Controls.Add((Control) this.Button_GoOut);
      this.Controls.Add((Control) this.HeaderPanel_Precio);
      this.Controls.Add((Control) this.Label_AmountPay);
      this.Controls.Add((Control) this.Button_Accept);
      this.Controls.Add((Control) this.TextBox_AmountPay);
      this.FormBorderStyle = FormBorderStyle.FixedDialog;
      this.KeyPreview = true;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = nameof (FrmChangePrice);
      this.ShowIcon = false;
      this.ShowInTaskbar = false;
      this.StartPosition = FormStartPosition.CenterParent;
      this.Tag = (object) "Res_ChangePrice";
      this.Text = "Cambiar Precio del Item";
      ((Control) this.HeaderPanel_Precio).ResumeLayout(false);
      ((Control) this.HeaderPanel_Precio).PerformLayout();
      ((Control) this.HeaderPanel_Pedido).ResumeLayout(false);
      ((Control) this.HeaderPanel_Pedido).PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();
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

    internal virtual Button Button_Accept
    {
      get
      {
        return this._Button_Accept;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Button_Accept_Click);
        Button buttonAccept1 = this._Button_Accept;
        if (buttonAccept1 != null)
          buttonAccept1.Click -= eventHandler;
        this._Button_Accept = value;
        Button buttonAccept2 = this._Button_Accept;
        if (buttonAccept2 == null)
          return;
        buttonAccept2.Click += eventHandler;
      }
    }

    internal virtual NumericTextBox.NumericTextBox TextBox_OfficialPrice { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual NumericTextBox.NumericTextBox TextBox_AmountPay { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Label Label_AmountPay { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Label Label_AmountSale { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Button Button_SetPrice
    {
      get
      {
        return this._Button_SetPrice;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Button_ForAmount_Click);
        Button buttonSetPrice1 = this._Button_SetPrice;
        if (buttonSetPrice1 != null)
          buttonSetPrice1.Click -= eventHandler;
        this._Button_SetPrice = value;
        Button buttonSetPrice2 = this._Button_SetPrice;
        if (buttonSetPrice2 == null)
          return;
        buttonSetPrice2.Click += eventHandler;
      }
    }

    internal virtual Label Label_NewPrice { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual NumericTextBox.NumericTextBox TextBox_NewPrice { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual NumericTextBox.NumericTextBox TextBox_Quantity { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Label Label_Quantity { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Button Button_PercentLess
    {
      get
      {
        return this._Button_PercentLess;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Button_PercentLess_Click);
        Button buttonPercentLess1 = this._Button_PercentLess;
        if (buttonPercentLess1 != null)
          buttonPercentLess1.Click -= eventHandler;
        this._Button_PercentLess = value;
        Button buttonPercentLess2 = this._Button_PercentLess;
        if (buttonPercentLess2 == null)
          return;
        buttonPercentLess2.Click += eventHandler;
      }
    }

    internal virtual Label Label_Percentage { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual NumericTextBox.NumericTextBox TextBox_Percent { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Button Button_PercentMore
    {
      get
      {
        return this._Button_PercentMore;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Button_PercentMore_Click);
        Button buttonPercentMore1 = this._Button_PercentMore;
        if (buttonPercentMore1 != null)
          buttonPercentMore1.Click -= eventHandler;
        this._Button_PercentMore = value;
        Button buttonPercentMore2 = this._Button_PercentMore;
        if (buttonPercentMore2 == null)
          return;
        buttonPercentMore2.Click += eventHandler;
      }
    }

    internal virtual HeaderPanel HeaderPanel_Precio { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual HeaderPanel HeaderPanel_Pedido { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual TextBox TextBox_ProductDes { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Label Label_ClientDes { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Label Label1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Label Label2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Label Label5 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Label Label3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual TextBox TextBox_Observation { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Label Label4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Button Button_Observation
    {
      get
      {
        return this._Button_Observation;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Button_Observation_Click);
        Button buttonObservation1 = this._Button_Observation;
        if (buttonObservation1 != null)
          buttonObservation1.Click -= eventHandler;
        this._Button_Observation = value;
        Button buttonObservation2 = this._Button_Observation;
        if (buttonObservation2 == null)
          return;
        buttonObservation2.Click += eventHandler;
      }
    }

    public FrmChangePrice(string pstrProductDes, double pdblOfficialPrice, double pdblQuantity)
    {
      this.Load += new EventHandler(this.FrmChangePrice_Load);
      this.KeyDown += new KeyEventHandler(this.FrmChangePrice_KeyDown);
      this.InitializeComponent();
      this.TextBox_ProductDes.Text = pstrProductDes;
      ((TextBox) this.TextBox_Quantity).Text = ModGeneralFunctions.CadenaToDoubleFormateado(Conversions.ToString(pdblQuantity), 2);
      ((TextBox) this.TextBox_OfficialPrice).Text = ModGeneralFunctions.CadenaToDoubleFormateado(Conversions.ToString(pdblOfficialPrice), 2);
      ((TextBox) this.TextBox_AmountPay).Text = ModGeneralFunctions.CadenaToDoubleFormateado(Conversions.ToString(pdblOfficialPrice), 2);
      ((TextBox) this.TextBox_NewPrice).Text = ModGeneralFunctions.CadenaToDoubleFormateado(Conversions.ToString(pdblOfficialPrice), 2);
    }

    private void FrmChangePrice_Load(object sender, EventArgs e)
    {
      this.Resource(ModGeneralFunctions.Get_Language((object) this));
      this.Button_SetPrice.Focus();
      if (!Conversions.ToBoolean(ModGeneralFunctions.ObtenerAPPCONFIG("ACTIVAR_CONFIGURACION_ECUADOR")))
        return;
      this.Label1.Text = "$";
      this.Label2.Text = "$";
      this.Label5.Text = "$";
    }

    private void Resource(ResourceManager Rm)
    {
      this.Res_ObservationInput = Rm.GetString("Res_ObservationInput");
    }

    private void Button_GoOut_Click(object sender, EventArgs e)
    {
      ModGeneralVar.g_bol_IsReady = false;
      this.Close();
    }

    private void Button_ForAmount_Click(object sender, EventArgs e)
    {
      ModGeneralFunctions.NumberKeyBoard("INGRESE NUEVO PRECIO", true);
      if (!ModGeneralVar.g_bol_IsReady)
        return;
      ((TextBox) this.TextBox_NewPrice).Text = ModGeneralVar.g_str_InputValue;
      this.Calculate_NewValues();
    }

    private void Calculate_NewValues()
    {
      ModGeneralFunctions.CadenaToDouble(((TextBox) this.TextBox_NewPrice).Text);
      double productoPrecioMax = ModGeneralFunctions.CadenaToDouble(((TextBox) this.TextBox_NewPrice).Text);
      if (ModGeneralVar.g_BE_TR1_VARIABLES_B.get_ProductoPrecioMax() < ModGeneralFunctions.CadenaToDouble(Conversions.ToString(productoPrecioMax)))
      {
        productoPrecioMax = ModGeneralVar.g_BE_TR1_VARIABLES_B.get_ProductoPrecioMax();
        ((TextBox) this.TextBox_NewPrice).Text = ModGeneralFunctions.FormatMoney(productoPrecioMax);
        ModGeneralFunctions.MessageOk("¡El Nuevo Precio Mayor a: " + Conversions.ToString(productoPrecioMax) + "!");
      }
      if (productoPrecioMax < 0.0)
      {
        ((TextBox) this.TextBox_NewPrice).Text = ModGeneralFunctions.FormatMoney(0.0);
        ModGeneralFunctions.MessageOk_Large("¡El nuevo Precio no puede ser Menor o Igual a Cero (0)!", false);
      }
      else
      {
        double num = Conversions.ToDouble(Operators.DivideObject((object) (ModGeneralFunctions.CadenaToDouble(((TextBox) this.TextBox_NewPrice).Text) * 100.0), ModGeneralFunctions.SiEsCero(ModGeneralFunctions.CadenaToDouble(((TextBox) this.TextBox_OfficialPrice).Text), 1.0)));
        ((TextBox) this.TextBox_AmountPay).Text = ModGeneralFunctions.FormatMoney(ModGeneralFunctions.CadenaToDouble(((TextBox) this.TextBox_Quantity).Text) * ModGeneralFunctions.CadenaToDouble(((TextBox) this.TextBox_NewPrice).Text));
        if (Operators.CompareString(((TextBox) this.TextBox_AmountPay).Text, ((TextBox) this.TextBox_OfficialPrice).Text, false) > 0)
          num -= 100.0;
        if (Operators.CompareString(((TextBox) this.TextBox_AmountPay).Text, ((TextBox) this.TextBox_OfficialPrice).Text, false) < 0)
          num = (100.0 - num) * -1.0;
        ((TextBox) this.TextBox_Percent).Text = ModGeneralFunctions.CadenaToDoubleFormateado(Conversions.ToString(num), 2);
        ((TextBox) this.TextBox_NewPrice).Text = ModGeneralFunctions.FormatMoney(Conversions.ToDouble(((TextBox) this.TextBox_NewPrice).Text));
      }
    }

    private void Button_Accept_Click(object sender, EventArgs e)
    {
      if (ModGeneralFunctions.CadenaToDouble(((TextBox) this.TextBox_NewPrice).Text) < 0.0)
      {
        ModGeneralFunctions.MessageOk_Large("¡El Monto del Nuevo Precio no puede ser menor o igual a Cero (0)!", false);
      }
      else
      {
        ModGeneralVar.g_bol_IsReady = true;
        this.str_Observation = this.TextBox_Observation.Text;
        this.dbl_NewPrice = Conversions.ToDouble(((TextBox) this.TextBox_NewPrice).Text);
        this.Close();
      }
    }

    private void Button_PercentMore_Click(object sender, EventArgs e)
    {
      ModGeneralFunctions.NumberKeyBoard("INGRESE PORCENTAJE +", true);
      if (!ModGeneralVar.g_bol_IsReady)
        return;
      double num = Conversions.ToDouble(((TextBox) this.TextBox_OfficialPrice).Text);
      ((TextBox) this.TextBox_NewPrice).Text = Conversions.ToString(num + Math.Round(num * (Convert.ToDouble(ModGeneralVar.g_str_InputValue) / 100.0), 2, MidpointRounding.AwayFromZero));
      this.Calculate_NewValues();
    }

    private void Button_PercentLess_Click(object sender, EventArgs e)
    {
      ModGeneralFunctions.NumberKeyBoard("INGRESE PORCENTAJE -", true);
      if (!ModGeneralVar.g_bol_IsReady)
        return;
      double num = Conversions.ToDouble(((TextBox) this.TextBox_OfficialPrice).Text);
      if (Conversion.Val(ModGeneralVar.g_str_InputValue) > 100.0)
      {
        ModGeneralFunctions.MessageOk_Large("¡El Monto del Nuevo Precio no puede ser menor o igual a Cero (0)!", false);
      }
      else
      {
        ((TextBox) this.TextBox_NewPrice).Text = Conversions.ToString(num - Math.Round(num * (Convert.ToDouble(ModGeneralVar.g_str_InputValue) / 100.0), 2, MidpointRounding.AwayFromZero));
        this.Calculate_NewValues();
      }
    }

    private void FrmChangePrice_KeyDown(object sender, KeyEventArgs e)
    {
      if (!e.KeyValue.Equals(27))
        return;
      ModGeneralVar.g_bol_IsReady = false;
      this.Close();
    }

    private void Button_Observation_Click(object sender, EventArgs e)
    {
      this.str_Observation = this.TextBox_Observation.Text;
      FrmSelectProperties selectProperties = new FrmSelectProperties();
      selectProperties.bol_IsDelete = true;
      selectProperties.bol_IsDeleteOrder = true;
      selectProperties.strObservation = this.str_Observation;
      ModGeneralVar.g_bol_IsReady = false;
      int num = (int) selectProperties.ShowDialog();
      this.str_Observation = selectProperties.strObservation;
      selectProperties.Dispose();
      this.TextBox_Observation.Text = this.str_Observation;
      if (ModGeneralVar.g_bol_IsReady || !this.str_Observation.Trim().Equals(""))
        return;
      ModGeneralFunctions.MessageOk1(this.Res_ObservationInput);
    }
  }
}
