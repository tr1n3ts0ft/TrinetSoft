// Decompiled with JetBrains decompiler
// Type: TriNetRestPOS.FrmAcercaDe
// Assembly: TriNetRestPOS, Version=5.2.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 43377352-E952-4AC1-9BA6-CCBE4AE5F575
// Assembly location: C:\log\TriNetRestPOS.exe

using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using TriNetRestPOS.My;

namespace TriNetRestPOS
{
  [DesignerGenerated]
  public sealed class FrmAcercaDe : Form
  {
    private IContainer components;

    public FrmAcercaDe()
    {
      this.Load += new EventHandler(this.FrmAbout_Load);
      this.KeyDown += new KeyEventHandler(this.FrmAcercaDe_KeyDown);
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

    internal virtual PictureBox LogoPictureBox
    {
      get
      {
        return this._LogoPictureBox;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.LogoPictureBox_Click);
        PictureBox logoPictureBox1 = this._LogoPictureBox;
        if (logoPictureBox1 != null)
          logoPictureBox1.Click -= eventHandler;
        this._LogoPictureBox = value;
        PictureBox logoPictureBox2 = this._LogoPictureBox;
        if (logoPictureBox2 == null)
          return;
        logoPictureBox2.Click += eventHandler;
      }
    }

    internal virtual Label LabelVersion { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Label LabelCompanyName { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [DebuggerStepThrough]
    private void InitializeComponent()
    {
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (FrmAcercaDe));
      this.LogoPictureBox = new PictureBox();
      this.LabelProductName = new Label();
      this.LabelVersion = new Label();
      this.LabelCopyright = new Label();
      this.LabelCompanyName = new Label();
      this.Label1 = new Label();
      this.Label2 = new Label();
      this.Label3 = new Label();
      this.Label4 = new Label();
      this.Label5 = new Label();
      this.Label6 = new Label();
      this.Label7 = new Label();
      this.Label8 = new Label();
      this.Label9 = new Label();
      this.Label13 = new Label();
      this.Label14 = new Label();
      this.lnkTerminosyCondiciones = new LinkLabel();
      this.lnkPoliticasPrivacidad = new LinkLabel();
      this.Label15 = new Label();
      this.lnkPaginaWeb = new LinkLabel();
      this.lnkEmail = new LinkLabel();
      this.lnkDireccion = new LinkLabel();
      this.Label10 = new Label();
      this.Label11 = new Label();
      this.Label12 = new Label();
      this.lblTrinetpos = new Label();
      this.lblTrinetspa = new Label();
      this.lblTrinetstore = new Label();
      this.lblLicenciado = new Label();
      this.PictureBox1 = new PictureBox();
      this.pbTrinetpos = new Button();
      this.pbTrinetspa = new Button();
      this.pbTrinetstore = new Button();
      ((ISupportInitialize) this.LogoPictureBox).BeginInit();
      ((ISupportInitialize) this.PictureBox1).BeginInit();
      this.SuspendLayout();
      this.LogoPictureBox.Cursor = Cursors.Hand;
      this.LogoPictureBox.Image = (Image) TriNetRestPOS.My.Resources.Resources.trinetrest_symbol;
      this.LogoPictureBox.Location = new Point(12, 14);
      this.LogoPictureBox.Margin = new Padding(0);
      this.LogoPictureBox.Name = "LogoPictureBox";
      this.LogoPictureBox.Size = new Size(154, 125);
      this.LogoPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
      this.LogoPictureBox.TabIndex = 0;
      this.LogoPictureBox.TabStop = false;
      this.LabelProductName.Cursor = Cursors.Hand;
      this.LabelProductName.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.LabelProductName.ForeColor = Color.FromArgb(150, 150, 150);
      this.LabelProductName.Location = new Point(12, 185);
      this.LabelProductName.Margin = new Padding(0);
      this.LabelProductName.Name = "LabelProductName";
      this.LabelProductName.Size = new Size(148, 25);
      this.LabelProductName.TabIndex = 0;
      this.LabelProductName.Text = "TriNetRestPOS";
      this.LabelProductName.TextAlign = ContentAlignment.MiddleCenter;
      this.LabelVersion.AutoSize = true;
      this.LabelVersion.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.LabelVersion.ForeColor = Color.FromArgb(150, 150, 150);
      this.LabelVersion.Location = new Point(192, 12);
      this.LabelVersion.Margin = new Padding(0);
      this.LabelVersion.Name = "LabelVersion";
      this.LabelVersion.Size = new Size(55, 15);
      this.LabelVersion.TabIndex = 0;
      this.LabelVersion.Text = "Versión";
      this.LabelVersion.TextAlign = ContentAlignment.MiddleLeft;
      this.LabelCopyright.AutoSize = true;
      this.LabelCopyright.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.LabelCopyright.ForeColor = Color.FromArgb(150, 150, 150);
      this.LabelCopyright.Location = new Point(192, 47);
      this.LabelCopyright.Margin = new Padding(0);
      this.LabelCopyright.Name = "LabelCopyright";
      this.LabelCopyright.Size = new Size(101, 15);
      this.LabelCopyright.TabIndex = 1;
      this.LabelCopyright.Text = "Copyright © 2015";
      this.LabelCopyright.TextAlign = ContentAlignment.MiddleLeft;
      this.LabelCompanyName.AutoSize = true;
      this.LabelCompanyName.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.LabelCompanyName.ForeColor = Color.FromArgb(150, 150, 150);
      this.LabelCompanyName.Location = new Point(297, 47);
      this.LabelCompanyName.Margin = new Padding(0);
      this.LabelCompanyName.Name = "LabelCompanyName";
      this.LabelCompanyName.Size = new Size(96, 15);
      this.LabelCompanyName.TabIndex = 0;
      this.LabelCompanyName.Text = "TriNetSoft S.A.C.";
      this.LabelCompanyName.TextAlign = ContentAlignment.MiddleLeft;
      this.Label1.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Label1.ForeColor = Color.FromArgb(150, 150, 150);
      this.Label1.Location = new Point(192, 77);
      this.Label1.Margin = new Padding(0);
      this.Label1.Name = "Label1";
      this.Label1.Size = new Size(374, 105);
      this.Label1.TabIndex = 157;
      this.Label1.Text = "Nosotros amamos crear software que ayude a las personas y empresas a crecer y evolucionar en este mundo que va cada vez más de la mano con las nuevas tecnologías.\r\n\r\nJNT, JCV, EPT, PMC, JPG, LNE.";
      this.Label2.AutoSize = true;
      this.Label2.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Label2.ForeColor = Color.FromArgb(150, 150, 150);
      this.Label2.Location = new Point(195, 313);
      this.Label2.Margin = new Padding(0);
      this.Label2.Name = "Label2";
      this.Label2.Size = new Size(36, 15);
      this.Label2.TabIndex = 158;
      this.Label2.Text = "Móvil";
      this.Label2.TextAlign = ContentAlignment.MiddleLeft;
      this.Label3.AutoSize = true;
      this.Label3.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Label3.ForeColor = Color.FromArgb(150, 150, 150);
      this.Label3.Location = new Point(195, 331);
      this.Label3.Margin = new Padding(0);
      this.Label3.Name = "Label3";
      this.Label3.Size = new Size(43, 15);
      this.Label3.TabIndex = 159;
      this.Label3.Text = "E-mail";
      this.Label3.TextAlign = ContentAlignment.MiddleLeft;
      this.Label4.AutoSize = true;
      this.Label4.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Label4.ForeColor = Color.FromArgb(150, 150, 150);
      this.Label4.Location = new Point(195, 349);
      this.Label4.Margin = new Padding(0);
      this.Label4.Name = "Label4";
      this.Label4.Size = new Size(59, 15);
      this.Label4.TabIndex = 160;
      this.Label4.Text = "Dirección";
      this.Label4.TextAlign = ContentAlignment.MiddleLeft;
      this.Label5.AutoSize = true;
      this.Label5.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Label5.ForeColor = Color.FromArgb(150, 150, 150);
      this.Label5.Location = new Point(251, 349);
      this.Label5.Margin = new Padding(0);
      this.Label5.Name = "Label5";
      this.Label5.Size = new Size(10, 15);
      this.Label5.TabIndex = 163;
      this.Label5.Text = ":";
      this.Label5.TextAlign = ContentAlignment.MiddleLeft;
      this.Label6.AutoSize = true;
      this.Label6.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Label6.ForeColor = Color.FromArgb(150, 150, 150);
      this.Label6.Location = new Point(251, 331);
      this.Label6.Margin = new Padding(0);
      this.Label6.Name = "Label6";
      this.Label6.Size = new Size(10, 15);
      this.Label6.TabIndex = 162;
      this.Label6.Text = ":";
      this.Label6.TextAlign = ContentAlignment.MiddleLeft;
      this.Label7.AutoSize = true;
      this.Label7.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Label7.ForeColor = Color.FromArgb(150, 150, 150);
      this.Label7.Location = new Point(251, 313);
      this.Label7.Margin = new Padding(0);
      this.Label7.Name = "Label7";
      this.Label7.Size = new Size(10, 15);
      this.Label7.TabIndex = 161;
      this.Label7.Text = ":";
      this.Label7.TextAlign = ContentAlignment.MiddleLeft;
      this.Label8.AutoSize = true;
      this.Label8.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Label8.ForeColor = Color.FromArgb(150, 150, 150);
      this.Label8.Location = new Point(251, 367);
      this.Label8.Margin = new Padding(0);
      this.Label8.Name = "Label8";
      this.Label8.Size = new Size(10, 15);
      this.Label8.TabIndex = 166;
      this.Label8.Text = ":";
      this.Label8.TextAlign = ContentAlignment.MiddleLeft;
      this.Label9.AutoSize = true;
      this.Label9.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Label9.ForeColor = Color.FromArgb(150, 150, 150);
      this.Label9.Location = new Point(195, 367);
      this.Label9.Margin = new Padding(0);
      this.Label9.Name = "Label9";
      this.Label9.Size = new Size(60, 15);
      this.Label9.TabIndex = 165;
      this.Label9.Text = "Pág. Web";
      this.Label9.TextAlign = ContentAlignment.MiddleLeft;
      this.Label13.AutoSize = true;
      this.Label13.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Label13.ForeColor = Color.FromArgb(150, 150, 150);
      this.Label13.Location = new Point(261, 313);
      this.Label13.Margin = new Padding(0);
      this.Label13.Name = "Label13";
      this.Label13.Size = new Size(98, 15);
      this.Label13.TabIndex = 167;
      this.Label13.Text = "(01)986 644 510";
      this.Label13.TextAlign = ContentAlignment.MiddleLeft;
      this.Label14.AutoSize = true;
      this.Label14.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Label14.ForeColor = Color.FromArgb(150, 150, 150);
      this.Label14.Location = new Point(192, 192);
      this.Label14.Margin = new Padding(0);
      this.Label14.Name = "Label14";
      this.Label14.Size = new Size(351, 15);
      this.Label14.TabIndex = 171;
      this.Label14.Text = "TriNetRestPOS ® es una marca registrada por TriNetSoft S.A.C.";
      this.Label14.TextAlign = ContentAlignment.MiddleLeft;
      this.lnkTerminosyCondiciones.AutoSize = true;
      this.lnkTerminosyCondiciones.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.lnkTerminosyCondiciones.ForeColor = Color.FromArgb(209, 102, 61);
      this.lnkTerminosyCondiciones.LinkColor = Color.FromArgb(209, 102, 61);
      this.lnkTerminosyCondiciones.Location = new Point(1, 314);
      this.lnkTerminosyCondiciones.Name = "lnkTerminosyCondiciones";
      this.lnkTerminosyCondiciones.Size = new Size(180, 15);
      this.lnkTerminosyCondiciones.TabIndex = 174;
      this.lnkTerminosyCondiciones.TabStop = true;
      this.lnkTerminosyCondiciones.Text = "Términos y Condiciones de Uso";
      this.lnkPoliticasPrivacidad.AutoSize = true;
      this.lnkPoliticasPrivacidad.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.lnkPoliticasPrivacidad.ForeColor = Color.FromArgb(209, 102, 61);
      this.lnkPoliticasPrivacidad.LinkColor = Color.FromArgb(209, 102, 61);
      this.lnkPoliticasPrivacidad.Location = new Point(27, 334);
      this.lnkPoliticasPrivacidad.Name = "lnkPoliticasPrivacidad";
      this.lnkPoliticasPrivacidad.Size = new Size(130, 15);
      this.lnkPoliticasPrivacidad.TabIndex = 175;
      this.lnkPoliticasPrivacidad.TabStop = true;
      this.lnkPoliticasPrivacidad.Text = "Políticas de Privacidad";
      this.Label15.AutoSize = true;
      this.Label15.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Label15.ForeColor = Color.FromArgb(150, 150, 150);
      this.Label15.Location = new Point(192, 207);
      this.Label15.Margin = new Padding(0);
      this.Label15.Name = "Label15";
      this.Label15.Size = new Size(318, 15);
      this.Label15.TabIndex = 176;
      this.Label15.Text = "Indecopi - Nro. partida registral: 00276-2008 - Asiento: 01";
      this.Label15.TextAlign = ContentAlignment.MiddleLeft;
      this.lnkPaginaWeb.AutoSize = true;
      this.lnkPaginaWeb.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.lnkPaginaWeb.ForeColor = Color.FromArgb(150, 150, 150);
      this.lnkPaginaWeb.LinkColor = Color.FromArgb(64, 64, 64);
      this.lnkPaginaWeb.Location = new Point(261, 368);
      this.lnkPaginaWeb.Name = "lnkPaginaWeb";
      this.lnkPaginaWeb.Size = new Size(110, 15);
      this.lnkPaginaWeb.TabIndex = 177;
      this.lnkPaginaWeb.TabStop = true;
      this.lnkPaginaWeb.Text = "www.trinetsoft.com";
      this.lnkEmail.AutoSize = true;
      this.lnkEmail.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.lnkEmail.ForeColor = Color.FromArgb(150, 150, 150);
      this.lnkEmail.LinkColor = Color.FromArgb(64, 64, 64);
      this.lnkEmail.Location = new Point(261, 331);
      this.lnkEmail.Name = "lnkEmail";
      this.lnkEmail.Size = new Size(133, 15);
      this.lnkEmail.TabIndex = 178;
      this.lnkEmail.TabStop = true;
      this.lnkEmail.Text = "soporte@trinetsoft.com";
      this.lnkDireccion.AutoSize = true;
      this.lnkDireccion.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.lnkDireccion.ForeColor = Color.FromArgb(150, 150, 150);
      this.lnkDireccion.LinkColor = Color.FromArgb(64, 64, 64);
      this.lnkDireccion.Location = new Point(261, 349);
      this.lnkDireccion.Name = "lnkDireccion";
      this.lnkDireccion.Size = new Size(164, 15);
      this.lnkDireccion.TabIndex = 179;
      this.lnkDireccion.TabStop = true;
      this.lnkDireccion.Text = "Ca. Tintoreto 231 - San Borja";
      this.Label10.AutoSize = true;
      this.Label10.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Label10.ForeColor = Color.FromArgb(150, 150, 150);
      this.Label10.Location = new Point(261, 295);
      this.Label10.Margin = new Padding(0);
      this.Label10.Name = "Label10";
      this.Label10.Size = new Size(166, 15);
      this.Label10.TabIndex = 182;
      this.Label10.Text = "(01)226-6015 / (01)226-6000";
      this.Label10.TextAlign = ContentAlignment.MiddleLeft;
      this.Label11.AutoSize = true;
      this.Label11.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Label11.ForeColor = Color.FromArgb(150, 150, 150);
      this.Label11.Location = new Point(251, 295);
      this.Label11.Margin = new Padding(0);
      this.Label11.Name = "Label11";
      this.Label11.Size = new Size(10, 15);
      this.Label11.TabIndex = 181;
      this.Label11.Text = ":";
      this.Label11.TextAlign = ContentAlignment.MiddleLeft;
      this.Label12.AutoSize = true;
      this.Label12.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Label12.ForeColor = Color.FromArgb(150, 150, 150);
      this.Label12.Location = new Point(195, 295);
      this.Label12.Margin = new Padding(0);
      this.Label12.Name = "Label12";
      this.Label12.Size = new Size(55, 15);
      this.Label12.TabIndex = 180;
      this.Label12.Text = "Teléfono";
      this.Label12.TextAlign = ContentAlignment.MiddleLeft;
      this.lblTrinetpos.AutoSize = true;
      this.lblTrinetpos.Cursor = Cursors.Hand;
      this.lblTrinetpos.Font = new Font("Microsoft Sans Serif", 6.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.lblTrinetpos.ForeColor = Color.FromArgb(64, 64, 64);
      this.lblTrinetpos.Location = new Point(11, 287);
      this.lblTrinetpos.Margin = new Padding(0);
      this.lblTrinetpos.Name = "lblTrinetpos";
      this.lblTrinetpos.Size = new Size(49, 12);
      this.lblTrinetpos.TabIndex = 186;
      this.lblTrinetpos.Text = "TriNetPOS";
      this.lblTrinetpos.TextAlign = ContentAlignment.MiddleLeft;
      this.lblTrinetspa.AutoSize = true;
      this.lblTrinetspa.Cursor = Cursors.Hand;
      this.lblTrinetspa.Font = new Font("Microsoft Sans Serif", 6.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.lblTrinetspa.ForeColor = Color.FromArgb(64, 64, 64);
      this.lblTrinetspa.Location = new Point(71, 287);
      this.lblTrinetspa.Margin = new Padding(0);
      this.lblTrinetspa.Name = "lblTrinetspa";
      this.lblTrinetspa.Size = new Size(46, 12);
      this.lblTrinetspa.TabIndex = 187;
      this.lblTrinetspa.Text = "TriNetSpa";
      this.lblTrinetspa.TextAlign = ContentAlignment.MiddleLeft;
      this.lblTrinetstore.AutoSize = true;
      this.lblTrinetstore.Cursor = Cursors.Hand;
      this.lblTrinetstore.Font = new Font("Microsoft Sans Serif", 6.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.lblTrinetstore.ForeColor = Color.FromArgb(64, 64, 64);
      this.lblTrinetstore.Location = new Point(128, 287);
      this.lblTrinetstore.Margin = new Padding(0);
      this.lblTrinetstore.Name = "lblTrinetstore";
      this.lblTrinetstore.Size = new Size(52, 12);
      this.lblTrinetstore.TabIndex = 188;
      this.lblTrinetstore.Text = "TriNetStore";
      this.lblTrinetstore.TextAlign = ContentAlignment.MiddleLeft;
      this.lblLicenciado.AutoSize = true;
      this.lblLicenciado.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.lblLicenciado.ForeColor = Color.FromArgb(150, 150, 150);
      this.lblLicenciado.Location = new Point(192, 242);
      this.lblLicenciado.Margin = new Padding(0);
      this.lblLicenciado.Name = "lblLicenciado";
      this.lblLicenciado.Size = new Size(235, 15);
      this.lblLicenciado.TabIndex = 189;
      this.lblLicenciado.Text = "Licenciado para : DON DEL CHEFF S.A.C.";
      this.lblLicenciado.TextAlign = ContentAlignment.MiddleLeft;
      this.PictureBox1.Cursor = Cursors.Hand;
      this.PictureBox1.Image = (Image) TriNetRestPOS.My.Resources.Resources.trinetrest_logo;
      this.PictureBox1.Location = new Point(12, 144);
      this.PictureBox1.Margin = new Padding(0);
      this.PictureBox1.Name = "PictureBox1";
      this.PictureBox1.Size = new Size(154, 37);
      this.PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
      this.PictureBox1.TabIndex = 190;
      this.PictureBox1.TabStop = false;
      this.pbTrinetpos.BackgroundImage = (Image) TriNetRestPOS.My.Resources.Resources.blue_tab;
      this.pbTrinetpos.FlatStyle = FlatStyle.Flat;
      this.pbTrinetpos.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.pbTrinetpos.ForeColor = Color.WhiteSmoke;
      this.pbTrinetpos.Image = (Image) TriNetRestPOS.My.Resources.Resources.POS_ICON;
      this.pbTrinetpos.ImageAlign = ContentAlignment.TopCenter;
      this.pbTrinetpos.Location = new Point(4, 222);
      this.pbTrinetpos.Name = "pbTrinetpos";
      this.pbTrinetpos.Padding = new Padding(0, 5, 0, 5);
      this.pbTrinetpos.Size = new Size(59, 61);
      this.pbTrinetpos.TabIndex = 191;
      this.pbTrinetpos.TextAlign = ContentAlignment.BottomCenter;
      this.pbTrinetpos.UseVisualStyleBackColor = true;
      this.pbTrinetspa.BackgroundImage = (Image) TriNetRestPOS.My.Resources.Resources.blue_tab;
      this.pbTrinetspa.FlatStyle = FlatStyle.Flat;
      this.pbTrinetspa.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.pbTrinetspa.ForeColor = Color.WhiteSmoke;
      this.pbTrinetspa.Image = (Image) TriNetRestPOS.My.Resources.Resources.SPA_ICON;
      this.pbTrinetspa.ImageAlign = ContentAlignment.TopCenter;
      this.pbTrinetspa.Location = new Point(64, 222);
      this.pbTrinetspa.Name = "pbTrinetspa";
      this.pbTrinetspa.Padding = new Padding(0, 5, 0, 5);
      this.pbTrinetspa.Size = new Size(59, 61);
      this.pbTrinetspa.TabIndex = 192;
      this.pbTrinetspa.TextAlign = ContentAlignment.BottomCenter;
      this.pbTrinetspa.UseVisualStyleBackColor = true;
      this.pbTrinetstore.BackgroundImage = (Image) TriNetRestPOS.My.Resources.Resources.blue_tab;
      this.pbTrinetstore.FlatStyle = FlatStyle.Flat;
      this.pbTrinetstore.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.pbTrinetstore.ForeColor = Color.WhiteSmoke;
      this.pbTrinetstore.Image = (Image) TriNetRestPOS.My.Resources.Resources.HOTEL_ICON;
      this.pbTrinetstore.ImageAlign = ContentAlignment.TopCenter;
      this.pbTrinetstore.Location = new Point(124, 223);
      this.pbTrinetstore.Name = "pbTrinetstore";
      this.pbTrinetstore.Padding = new Padding(0, 5, 0, 5);
      this.pbTrinetstore.Size = new Size(59, 61);
      this.pbTrinetstore.TabIndex = 193;
      this.pbTrinetstore.TextAlign = ContentAlignment.BottomCenter;
      this.pbTrinetstore.UseVisualStyleBackColor = true;
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.BackColor = Color.White;
      this.ClientSize = new Size(573, 392);
      this.Controls.Add((Control) this.pbTrinetstore);
      this.Controls.Add((Control) this.pbTrinetspa);
      this.Controls.Add((Control) this.pbTrinetpos);
      this.Controls.Add((Control) this.PictureBox1);
      this.Controls.Add((Control) this.lblLicenciado);
      this.Controls.Add((Control) this.lblTrinetstore);
      this.Controls.Add((Control) this.lblTrinetspa);
      this.Controls.Add((Control) this.lblTrinetpos);
      this.Controls.Add((Control) this.Label10);
      this.Controls.Add((Control) this.Label11);
      this.Controls.Add((Control) this.Label12);
      this.Controls.Add((Control) this.lnkDireccion);
      this.Controls.Add((Control) this.lnkEmail);
      this.Controls.Add((Control) this.lnkPaginaWeb);
      this.Controls.Add((Control) this.Label15);
      this.Controls.Add((Control) this.lnkPoliticasPrivacidad);
      this.Controls.Add((Control) this.lnkTerminosyCondiciones);
      this.Controls.Add((Control) this.Label14);
      this.Controls.Add((Control) this.Label13);
      this.Controls.Add((Control) this.Label8);
      this.Controls.Add((Control) this.Label9);
      this.Controls.Add((Control) this.Label5);
      this.Controls.Add((Control) this.Label6);
      this.Controls.Add((Control) this.Label7);
      this.Controls.Add((Control) this.Label4);
      this.Controls.Add((Control) this.Label3);
      this.Controls.Add((Control) this.Label2);
      this.Controls.Add((Control) this.Label1);
      this.Controls.Add((Control) this.LogoPictureBox);
      this.Controls.Add((Control) this.LabelProductName);
      this.Controls.Add((Control) this.LabelVersion);
      this.Controls.Add((Control) this.LabelCopyright);
      this.Controls.Add((Control) this.LabelCompanyName);
      this.FormBorderStyle = FormBorderStyle.FixedDialog;
      this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
      this.KeyPreview = true;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = nameof (FrmAcercaDe);
      this.StartPosition = FormStartPosition.CenterScreen;
      this.Text = "Acerca de TrinetRest";
      this.TransparencyKey = Color.White;
      ((ISupportInitialize) this.LogoPictureBox).EndInit();
      ((ISupportInitialize) this.PictureBox1).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();
    }

    internal virtual Label LabelProductName
    {
      get
      {
        return this._LabelProductName;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.LabelProductName_Click);
        Label labelProductName1 = this._LabelProductName;
        if (labelProductName1 != null)
          labelProductName1.Click -= eventHandler;
        this._LabelProductName = value;
        Label labelProductName2 = this._LabelProductName;
        if (labelProductName2 == null)
          return;
        labelProductName2.Click += eventHandler;
      }
    }

    internal virtual Label LabelCopyright { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Label Label1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Label Label2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Label Label3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Label Label4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Label Label5 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Label Label6 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Label Label7 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Label Label8 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Label Label9 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Label Label13 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Label Label14 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual LinkLabel lnkTerminosyCondiciones
    {
      get
      {
        return this._lnkTerminosyCondiciones;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        LinkLabelLinkClickedEventHandler clickedEventHandler = new LinkLabelLinkClickedEventHandler(this.lnkTerminosyCondiciones_LinkClicked);
        LinkLabel terminosyCondiciones1 = this._lnkTerminosyCondiciones;
        if (terminosyCondiciones1 != null)
          terminosyCondiciones1.LinkClicked -= clickedEventHandler;
        this._lnkTerminosyCondiciones = value;
        LinkLabel terminosyCondiciones2 = this._lnkTerminosyCondiciones;
        if (terminosyCondiciones2 == null)
          return;
        terminosyCondiciones2.LinkClicked += clickedEventHandler;
      }
    }

    internal virtual LinkLabel lnkPoliticasPrivacidad
    {
      get
      {
        return this._lnkPoliticasPrivacidad;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        LinkLabelLinkClickedEventHandler clickedEventHandler = new LinkLabelLinkClickedEventHandler(this.lnkPoliticasPrivacidad_LinkClicked);
        LinkLabel politicasPrivacidad1 = this._lnkPoliticasPrivacidad;
        if (politicasPrivacidad1 != null)
          politicasPrivacidad1.LinkClicked -= clickedEventHandler;
        this._lnkPoliticasPrivacidad = value;
        LinkLabel politicasPrivacidad2 = this._lnkPoliticasPrivacidad;
        if (politicasPrivacidad2 == null)
          return;
        politicasPrivacidad2.LinkClicked += clickedEventHandler;
      }
    }

    internal virtual Label Label15 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual LinkLabel lnkPaginaWeb
    {
      get
      {
        return this._lnkPaginaWeb;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        LinkLabelLinkClickedEventHandler clickedEventHandler = new LinkLabelLinkClickedEventHandler(this.lnkPaginaWeb_LinkClicked);
        LinkLabel lnkPaginaWeb1 = this._lnkPaginaWeb;
        if (lnkPaginaWeb1 != null)
          lnkPaginaWeb1.LinkClicked -= clickedEventHandler;
        this._lnkPaginaWeb = value;
        LinkLabel lnkPaginaWeb2 = this._lnkPaginaWeb;
        if (lnkPaginaWeb2 == null)
          return;
        lnkPaginaWeb2.LinkClicked += clickedEventHandler;
      }
    }

    internal virtual LinkLabel lnkEmail
    {
      get
      {
        return this._lnkEmail;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        LinkLabelLinkClickedEventHandler clickedEventHandler = new LinkLabelLinkClickedEventHandler(this.lnkEmail_LinkClicked);
        LinkLabel lnkEmail1 = this._lnkEmail;
        if (lnkEmail1 != null)
          lnkEmail1.LinkClicked -= clickedEventHandler;
        this._lnkEmail = value;
        LinkLabel lnkEmail2 = this._lnkEmail;
        if (lnkEmail2 == null)
          return;
        lnkEmail2.LinkClicked += clickedEventHandler;
      }
    }

    internal virtual LinkLabel lnkDireccion
    {
      get
      {
        return this._lnkDireccion;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        LinkLabelLinkClickedEventHandler clickedEventHandler = new LinkLabelLinkClickedEventHandler(this.lnkDireccion_LinkClicked);
        LinkLabel lnkDireccion1 = this._lnkDireccion;
        if (lnkDireccion1 != null)
          lnkDireccion1.LinkClicked -= clickedEventHandler;
        this._lnkDireccion = value;
        LinkLabel lnkDireccion2 = this._lnkDireccion;
        if (lnkDireccion2 == null)
          return;
        lnkDireccion2.LinkClicked += clickedEventHandler;
      }
    }

    internal virtual Label Label10 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Label Label11 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Label Label12 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Label lblTrinetpos
    {
      get
      {
        return this._lblTrinetpos;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.lblTrinetpos_Click);
        Label lblTrinetpos1 = this._lblTrinetpos;
        if (lblTrinetpos1 != null)
          lblTrinetpos1.Click -= eventHandler;
        this._lblTrinetpos = value;
        Label lblTrinetpos2 = this._lblTrinetpos;
        if (lblTrinetpos2 == null)
          return;
        lblTrinetpos2.Click += eventHandler;
      }
    }

    internal virtual Label lblTrinetspa
    {
      get
      {
        return this._lblTrinetspa;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.lblTrinetspa_Click);
        Label lblTrinetspa1 = this._lblTrinetspa;
        if (lblTrinetspa1 != null)
          lblTrinetspa1.Click -= eventHandler;
        this._lblTrinetspa = value;
        Label lblTrinetspa2 = this._lblTrinetspa;
        if (lblTrinetspa2 == null)
          return;
        lblTrinetspa2.Click += eventHandler;
      }
    }

    internal virtual Label lblTrinetstore
    {
      get
      {
        return this._lblTrinetstore;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.lblTrinetstore_Click);
        Label lblTrinetstore1 = this._lblTrinetstore;
        if (lblTrinetstore1 != null)
          lblTrinetstore1.Click -= eventHandler;
        this._lblTrinetstore = value;
        Label lblTrinetstore2 = this._lblTrinetstore;
        if (lblTrinetstore2 == null)
          return;
        lblTrinetstore2.Click += eventHandler;
      }
    }

    internal virtual Label lblLicenciado { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual PictureBox PictureBox1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Button pbTrinetpos
    {
      get
      {
        return this._pbTrinetpos;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.pbTrinetpos1_Click);
        Button pbTrinetpos1 = this._pbTrinetpos;
        if (pbTrinetpos1 != null)
          pbTrinetpos1.Click -= eventHandler;
        this._pbTrinetpos = value;
        Button pbTrinetpos2 = this._pbTrinetpos;
        if (pbTrinetpos2 == null)
          return;
        pbTrinetpos2.Click += eventHandler;
      }
    }

    internal virtual Button pbTrinetspa
    {
      get
      {
        return this._pbTrinetspa;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.pbTrinetspa1_Click);
        Button pbTrinetspa1 = this._pbTrinetspa;
        if (pbTrinetspa1 != null)
          pbTrinetspa1.Click -= eventHandler;
        this._pbTrinetspa = value;
        Button pbTrinetspa2 = this._pbTrinetspa;
        if (pbTrinetspa2 == null)
          return;
        pbTrinetspa2.Click += eventHandler;
      }
    }

    internal virtual Button pbTrinetstore
    {
      get
      {
        return this._pbTrinetstore;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.pbTrinetstore1_Click);
        Button pbTrinetstore1 = this._pbTrinetstore;
        if (pbTrinetstore1 != null)
          pbTrinetstore1.Click -= eventHandler;
        this._pbTrinetstore = value;
        Button pbTrinetstore2 = this._pbTrinetstore;
        if (pbTrinetstore2 == null)
          return;
        pbTrinetstore2.Click += eventHandler;
      }
    }

    private void FrmAbout_Load(object sender, EventArgs e)
    {
      this.Text += string.Format(" ", (uint) Operators.CompareString(MyProject.Application.Info.Title, "", false) <= 0U ? (object) Path.GetFileNameWithoutExtension(MyProject.Application.Info.AssemblyName) : (object) MyProject.Application.Info.Title);
      this.LabelProductName.Text = MyProject.Application.Info.ProductName;
      this.LabelVersion.Text = "Versión " + MyProject.Application.Info.Version.ToString();
      this.LabelCopyright.Text = MyProject.Application.Info.Copyright + " " + Conversions.ToString(DateAndTime.Now.Year);
      this.LabelCompanyName.Text = MyProject.Application.Info.CompanyName;
      this.lblLicenciado.Text = "Licenciado para : " + ModGeneralVar.g_BE_TR1_VARIABLES_B.get_CommercialReason();
    }

    private void OKButton_Click(object sender, EventArgs e)
    {
      this.Close();
    }

    private void FrmAcercaDe_KeyDown(object sender, KeyEventArgs e)
    {
      if (!e.KeyValue.Equals(27))
        return;
      this.Close();
    }

    private void LogoPictureBox_Click(object sender, EventArgs e)
    {
      Process.Start("http://trinetsoft.com/TriNetRest.html");
    }

    private void LabelProductName_Click(object sender, EventArgs e)
    {
      Process.Start("http://trinetsoft.com/TriNetRest.html");
    }

    private void lnkPaginaWeb_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
      Process.Start("http://www.trinetsoft.com");
    }

    private void lnkTerminosyCondiciones_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
      Process.Start("http://www.trinetsoft.com");
    }

    private void lnkPoliticasPrivacidad_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
      Process.Start("http://www.trinetsoft.com");
    }

    private void lnkEmail_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
      Process.Start("mailto:soporte@trinetsoft.com");
    }

    private void lnkDireccion_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
      Process.Start("http://www.trinetsoft.com/contactenos.html");
    }

    private void pbTrinetpos_Click(object sender, EventArgs e)
    {
      Process.Start("http://trinetsoft.com/TriNetPos.html");
    }

    private void pbTrinetspa_Click(object sender, EventArgs e)
    {
      Process.Start("http://trinetsoft.com/TriNetSpa.html");
    }

    private void pbTrinetstore_Click(object sender, EventArgs e)
    {
      Process.Start("http://trinetsoft.com/TriNetStore.html");
    }

    private void lblTrinetpos_Click(object sender, EventArgs e)
    {
      Process.Start("http://trinetsoft.com/TriNetPos.html");
    }

    private void lblTrinetspa_Click(object sender, EventArgs e)
    {
      Process.Start("http://trinetsoft.com/TriNetSpa.html");
    }

    private void lblTrinetstore_Click(object sender, EventArgs e)
    {
      Process.Start("http://trinetsoft.com/TriNetStore.html");
    }

    private void pbLogo_Click(object sender, EventArgs e)
    {
      Process.Start("http://www.trinetsoft.com");
    }

    private void pbTrinetpos1_Click(object sender, EventArgs e)
    {
      Process.Start("http://trinetsoft.com/TriNetPos.html");
    }

    private void pbTrinetspa1_Click(object sender, EventArgs e)
    {
      Process.Start("http://trinetsoft.com/TriNetSpa.html");
    }

    private void pbTrinetstore1_Click(object sender, EventArgs e)
    {
      Process.Start("http://trinetsoft.com/TriNetStore.html");
    }
  }
}
