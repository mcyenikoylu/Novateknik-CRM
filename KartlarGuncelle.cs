using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;




namespace deneme
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class KartlarGuncelle : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Label lblFIsim;
		private System.Windows.Forms.TextBox txtFIsim;
		private System.Windows.Forms.GroupBox gbFirma;
		private System.Windows.Forms.Label lblTel1;
		private System.Windows.Forms.Label lblTel2;
		private System.Windows.Forms.Label lblFax;
		private System.Windows.Forms.Label lblAdres;
		private System.Windows.Forms.Label lblVerDai;
		private System.Windows.Forms.Label lblVerNo;
		private System.Windows.Forms.Label lblWeb;
		private System.Windows.Forms.Label lblFMail;
		private System.Windows.Forms.TextBox txtTel1;
		private System.Windows.Forms.TextBox txtTel2;
		private System.Windows.Forms.TextBox txtFax;
		private System.Windows.Forms.TextBox txtAdres;
		private System.Windows.Forms.TextBox txtVerDai;
		private System.Windows.Forms.TextBox txtVerNo;
		private System.Windows.Forms.TextBox txtWeb;
		private System.Windows.Forms.TextBox txtFMail;
		private System.Windows.Forms.GroupBox gbKisi;
		private System.Windows.Forms.Label lblAd;
		private System.Windows.Forms.Label lblSoyad;
		private System.Windows.Forms.Label lblUnvan;
		private System.Windows.Forms.Label lblDahili;
		private System.Windows.Forms.Label lblCepTel;
		private System.Windows.Forms.Label lblKMail;
		private System.Windows.Forms.TextBox txtAd;
		private System.Windows.Forms.TextBox txtSoyad;
		private System.Windows.Forms.TextBox txtUnvan;
		private System.Windows.Forms.TextBox txtDahili;
		private System.Windows.Forms.TextBox txtCepTel;
		private System.Windows.Forms.TextBox txtKMail;
		private System.Windows.Forms.Button btnKart;
		private System.Windows.Forms.Label lblLevel;
		private System.Windows.Forms.Label lblSemt;
		private System.Windows.Forms.Label lblSehir;
		private System.Windows.Forms.Label lblSektor;
		private System.Windows.Forms.Label lblDep;
		private System.Windows.Forms.TextBox txtSemt;
		private System.Windows.Forms.ComboBox cbSehir;
		private System.Windows.Forms.GroupBox gbAlan;
		private System.Windows.Forms.ComboBox cbSektor;
		private System.Windows.Forms.ComboBox cbLevel;
		private System.Windows.Forms.TextBox txtDep;
		private System.Windows.Forms.Button btnYeni;
		private System.Windows.Forms.Button btnDuzenle;
		private System.Windows.Forms.Button btnSil;
		private System.Windows.Forms.Button btnMusteriK;
		private System.Windows.Forms.Button btnCrm;
		private System.Windows.Forms.Button btnTeklifH;
		private System.Windows.Forms.Button btnSiparisG;
		private System.Windows.Forms.Button btnProjeler;
		private System.Windows.Forms.Button btnBilgiB;
		private System.Windows.Forms.Button btnRapor;
		private System.Windows.Forms.Button btnList;
		private System.Windows.Forms.Button btnTeklif;
		private System.Windows.Forms.Button btnAltCrm;
		private System.Windows.Forms.Button btnSiparis;
		private System.Windows.Forms.Button btnAltProjeler;
		private System.Windows.Forms.Panel pnlKartlar;
		private System.Windows.Forms.Panel pnlList;
		private System.Windows.Forms.Button btnKAra;
		private System.Windows.Forms.Button btnPSG;
		private System.Windows.Forms.Button btnCCTV;
		private System.Windows.Forms.Button btnOEM;
		private System.Windows.Forms.Button btnYazýlým;
		private System.Windows.Forms.Button btnServis;
		private System.Windows.Forms.Button btnLAra;
		private System.Windows.Forms.Button btnGuncelle;
		private System.Data.SqlClient.SqlDataAdapter sqlDataAdapter1;
		private System.Data.SqlClient.SqlCommand sqlSelectCommand1;
		private System.Data.SqlClient.SqlCommand sqlInsertCommand1;
		private System.Data.SqlClient.SqlCommand sqlUpdateCommand1;
		private System.Data.SqlClient.SqlCommand sqlDeleteCommand1;
		private System.Data.SqlClient.SqlConnection sqlConnection1;
		private deneme.ds_musteri ds_musteri1;
		private System.Windows.Forms.Button btnAltAdmin;
		private System.Windows.Forms.Panel pnlAdmin;
		private System.Windows.Forms.Button button7;
		private System.Windows.Forms.Button button8;
		private System.Windows.Forms.Button button9;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Panel pnlTeklif;
		private System.Windows.Forms.Button btnTeklifGoruntule;
		private System.Windows.Forms.Button btnTeklifYeni;
		private System.Windows.Forms.Button btnTeklifPrint;
		private System.Windows.Forms.Panel pnlCrm;
		private System.Windows.Forms.Button button10;
		private System.Windows.Forms.Button button11;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public KartlarGuncelle()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(KartlarGuncelle));
			this.btnMusteriK = new System.Windows.Forms.Button();
			this.btnCrm = new System.Windows.Forms.Button();
			this.btnTeklifH = new System.Windows.Forms.Button();
			this.btnSiparisG = new System.Windows.Forms.Button();
			this.btnProjeler = new System.Windows.Forms.Button();
			this.btnBilgiB = new System.Windows.Forms.Button();
			this.btnList = new System.Windows.Forms.Button();
			this.btnKart = new System.Windows.Forms.Button();
			this.btnAltCrm = new System.Windows.Forms.Button();
			this.btnTeklif = new System.Windows.Forms.Button();
			this.btnSiparis = new System.Windows.Forms.Button();
			this.btnAltProjeler = new System.Windows.Forms.Button();
			this.gbFirma = new System.Windows.Forms.GroupBox();
			this.cbSehir = new System.Windows.Forms.ComboBox();
			this.txtSemt = new System.Windows.Forms.TextBox();
			this.txtFMail = new System.Windows.Forms.TextBox();
			this.txtWeb = new System.Windows.Forms.TextBox();
			this.txtVerNo = new System.Windows.Forms.TextBox();
			this.txtVerDai = new System.Windows.Forms.TextBox();
			this.txtAdres = new System.Windows.Forms.TextBox();
			this.txtFax = new System.Windows.Forms.TextBox();
			this.txtTel2 = new System.Windows.Forms.TextBox();
			this.txtTel1 = new System.Windows.Forms.TextBox();
			this.lblFMail = new System.Windows.Forms.Label();
			this.lblWeb = new System.Windows.Forms.Label();
			this.lblVerNo = new System.Windows.Forms.Label();
			this.lblVerDai = new System.Windows.Forms.Label();
			this.lblAdres = new System.Windows.Forms.Label();
			this.lblFax = new System.Windows.Forms.Label();
			this.lblTel2 = new System.Windows.Forms.Label();
			this.lblTel1 = new System.Windows.Forms.Label();
			this.txtFIsim = new System.Windows.Forms.TextBox();
			this.lblFIsim = new System.Windows.Forms.Label();
			this.lblSemt = new System.Windows.Forms.Label();
			this.lblSehir = new System.Windows.Forms.Label();
			this.gbKisi = new System.Windows.Forms.GroupBox();
			this.txtDep = new System.Windows.Forms.TextBox();
			this.txtKMail = new System.Windows.Forms.TextBox();
			this.txtCepTel = new System.Windows.Forms.TextBox();
			this.txtDahili = new System.Windows.Forms.TextBox();
			this.txtUnvan = new System.Windows.Forms.TextBox();
			this.txtSoyad = new System.Windows.Forms.TextBox();
			this.txtAd = new System.Windows.Forms.TextBox();
			this.lblKMail = new System.Windows.Forms.Label();
			this.lblCepTel = new System.Windows.Forms.Label();
			this.lblDahili = new System.Windows.Forms.Label();
			this.lblUnvan = new System.Windows.Forms.Label();
			this.lblSoyad = new System.Windows.Forms.Label();
			this.lblAd = new System.Windows.Forms.Label();
			this.lblDep = new System.Windows.Forms.Label();
			this.lblLevel = new System.Windows.Forms.Label();
			this.lblSektor = new System.Windows.Forms.Label();
			this.gbAlan = new System.Windows.Forms.GroupBox();
			this.cbLevel = new System.Windows.Forms.ComboBox();
			this.cbSektor = new System.Windows.Forms.ComboBox();
			this.btnYeni = new System.Windows.Forms.Button();
			this.btnDuzenle = new System.Windows.Forms.Button();
			this.btnSil = new System.Windows.Forms.Button();
			this.btnKAra = new System.Windows.Forms.Button();
			this.btnGuncelle = new System.Windows.Forms.Button();
			this.btnRapor = new System.Windows.Forms.Button();
			this.pnlKartlar = new System.Windows.Forms.Panel();
			this.pnlList = new System.Windows.Forms.Panel();
			this.btnLAra = new System.Windows.Forms.Button();
			this.btnServis = new System.Windows.Forms.Button();
			this.btnYazýlým = new System.Windows.Forms.Button();
			this.btnOEM = new System.Windows.Forms.Button();
			this.btnCCTV = new System.Windows.Forms.Button();
			this.btnPSG = new System.Windows.Forms.Button();
			this.sqlDataAdapter1 = new System.Data.SqlClient.SqlDataAdapter();
			this.sqlDeleteCommand1 = new System.Data.SqlClient.SqlCommand();
			this.sqlConnection1 = new System.Data.SqlClient.SqlConnection();
			this.sqlInsertCommand1 = new System.Data.SqlClient.SqlCommand();
			this.sqlSelectCommand1 = new System.Data.SqlClient.SqlCommand();
			this.sqlUpdateCommand1 = new System.Data.SqlClient.SqlCommand();
			this.ds_musteri1 = new deneme.ds_musteri();
			this.btnAltAdmin = new System.Windows.Forms.Button();
			this.pnlAdmin = new System.Windows.Forms.Panel();
			this.button7 = new System.Windows.Forms.Button();
			this.button8 = new System.Windows.Forms.Button();
			this.button9 = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.pnlTeklif = new System.Windows.Forms.Panel();
			this.btnTeklifGoruntule = new System.Windows.Forms.Button();
			this.btnTeklifYeni = new System.Windows.Forms.Button();
			this.btnTeklifPrint = new System.Windows.Forms.Button();
			this.pnlCrm = new System.Windows.Forms.Panel();
			this.button10 = new System.Windows.Forms.Button();
			this.button11 = new System.Windows.Forms.Button();
			this.gbFirma.SuspendLayout();
			this.gbKisi.SuspendLayout();
			this.gbAlan.SuspendLayout();
			this.pnlKartlar.SuspendLayout();
			this.pnlList.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.ds_musteri1)).BeginInit();
			this.pnlAdmin.SuspendLayout();
			this.pnlTeklif.SuspendLayout();
			this.pnlCrm.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnMusteriK
			// 
			this.btnMusteriK.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(162)));
			this.btnMusteriK.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
			this.btnMusteriK.Location = new System.Drawing.Point(48, 176);
			this.btnMusteriK.Name = "btnMusteriK";
			this.btnMusteriK.Size = new System.Drawing.Size(80, 50);
			this.btnMusteriK.TabIndex = 0;
			this.btnMusteriK.Text = "Müþteri";
			this.btnMusteriK.Click += new System.EventHandler(this.btnMusteriK_Click);
			// 
			// btnCrm
			// 
			this.btnCrm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(162)));
			this.btnCrm.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
			this.btnCrm.Location = new System.Drawing.Point(48, 232);
			this.btnCrm.Name = "btnCrm";
			this.btnCrm.Size = new System.Drawing.Size(80, 50);
			this.btnCrm.TabIndex = 1;
			this.btnCrm.Text = "CRM";
			this.btnCrm.Click += new System.EventHandler(this.btnCrm_Click);
			// 
			// btnTeklifH
			// 
			this.btnTeklifH.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(162)));
			this.btnTeklifH.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
			this.btnTeklifH.Location = new System.Drawing.Point(48, 288);
			this.btnTeklifH.Name = "btnTeklifH";
			this.btnTeklifH.Size = new System.Drawing.Size(80, 50);
			this.btnTeklifH.TabIndex = 2;
			this.btnTeklifH.Text = "Teklif";
			this.btnTeklifH.Click += new System.EventHandler(this.btnTeklifH_Click);
			// 
			// btnSiparisG
			// 
			this.btnSiparisG.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(162)));
			this.btnSiparisG.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
			this.btnSiparisG.Location = new System.Drawing.Point(48, 344);
			this.btnSiparisG.Name = "btnSiparisG";
			this.btnSiparisG.Size = new System.Drawing.Size(80, 50);
			this.btnSiparisG.TabIndex = 3;
			this.btnSiparisG.Text = "Sipariþ";
			this.btnSiparisG.Click += new System.EventHandler(this.btnSiparisG_Click);
			// 
			// btnProjeler
			// 
			this.btnProjeler.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(162)));
			this.btnProjeler.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
			this.btnProjeler.Location = new System.Drawing.Point(48, 400);
			this.btnProjeler.Name = "btnProjeler";
			this.btnProjeler.Size = new System.Drawing.Size(80, 50);
			this.btnProjeler.TabIndex = 4;
			this.btnProjeler.Text = "Proje";
			this.btnProjeler.Click += new System.EventHandler(this.btnProjeler_Click);
			// 
			// btnBilgiB
			// 
			this.btnBilgiB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(162)));
			this.btnBilgiB.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
			this.btnBilgiB.Location = new System.Drawing.Point(48, 456);
			this.btnBilgiB.Name = "btnBilgiB";
			this.btnBilgiB.Size = new System.Drawing.Size(80, 50);
			this.btnBilgiB.TabIndex = 5;
			this.btnBilgiB.Text = "Bilgi Bank";
			this.btnBilgiB.Click += new System.EventHandler(this.btnBilgiB_Click);
			// 
			// btnList
			// 
			this.btnList.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(162)));
			this.btnList.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
			this.btnList.Location = new System.Drawing.Point(216, 32);
			this.btnList.Name = "btnList";
			this.btnList.Size = new System.Drawing.Size(75, 30);
			this.btnList.TabIndex = 6;
			this.btnList.Text = "Listeler";
			this.btnList.Click += new System.EventHandler(this.btnList_Click);
			// 
			// btnKart
			// 
			this.btnKart.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnKart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(162)));
			this.btnKart.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
			this.btnKart.Location = new System.Drawing.Point(304, 32);
			this.btnKart.Name = "btnKart";
			this.btnKart.Size = new System.Drawing.Size(75, 30);
			this.btnKart.TabIndex = 7;
			this.btnKart.Text = "Kartlar";
			this.btnKart.Click += new System.EventHandler(this.btnKart_Click);
			// 
			// btnAltCrm
			// 
			this.btnAltCrm.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnAltCrm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(162)));
			this.btnAltCrm.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
			this.btnAltCrm.Location = new System.Drawing.Point(392, 32);
			this.btnAltCrm.Name = "btnAltCrm";
			this.btnAltCrm.Size = new System.Drawing.Size(75, 30);
			this.btnAltCrm.TabIndex = 8;
			this.btnAltCrm.Text = "CRM";
			this.btnAltCrm.Click += new System.EventHandler(this.btnAltCrm_Click);
			// 
			// btnTeklif
			// 
			this.btnTeklif.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnTeklif.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(162)));
			this.btnTeklif.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
			this.btnTeklif.Location = new System.Drawing.Point(480, 32);
			this.btnTeklif.Name = "btnTeklif";
			this.btnTeklif.Size = new System.Drawing.Size(75, 30);
			this.btnTeklif.TabIndex = 9;
			this.btnTeklif.Text = "Teklif";
			this.btnTeklif.Click += new System.EventHandler(this.btnTeklif_Click);
			// 
			// btnSiparis
			// 
			this.btnSiparis.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnSiparis.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(162)));
			this.btnSiparis.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
			this.btnSiparis.Location = new System.Drawing.Point(568, 32);
			this.btnSiparis.Name = "btnSiparis";
			this.btnSiparis.Size = new System.Drawing.Size(75, 30);
			this.btnSiparis.TabIndex = 10;
			this.btnSiparis.Text = "Sipariþ";
			this.btnSiparis.Click += new System.EventHandler(this.btnSiparis_Click);
			// 
			// btnAltProjeler
			// 
			this.btnAltProjeler.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnAltProjeler.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(162)));
			this.btnAltProjeler.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
			this.btnAltProjeler.Location = new System.Drawing.Point(656, 32);
			this.btnAltProjeler.Name = "btnAltProjeler";
			this.btnAltProjeler.Size = new System.Drawing.Size(75, 30);
			this.btnAltProjeler.TabIndex = 11;
			this.btnAltProjeler.Text = "Projeler";
			this.btnAltProjeler.Click += new System.EventHandler(this.btnAltProjeler_Click);
			// 
			// gbFirma
			// 
			this.gbFirma.Controls.Add(this.cbSehir);
			this.gbFirma.Controls.Add(this.txtSemt);
			this.gbFirma.Controls.Add(this.txtFMail);
			this.gbFirma.Controls.Add(this.txtWeb);
			this.gbFirma.Controls.Add(this.txtVerNo);
			this.gbFirma.Controls.Add(this.txtVerDai);
			this.gbFirma.Controls.Add(this.txtAdres);
			this.gbFirma.Controls.Add(this.txtFax);
			this.gbFirma.Controls.Add(this.txtTel2);
			this.gbFirma.Controls.Add(this.txtTel1);
			this.gbFirma.Controls.Add(this.lblFMail);
			this.gbFirma.Controls.Add(this.lblWeb);
			this.gbFirma.Controls.Add(this.lblVerNo);
			this.gbFirma.Controls.Add(this.lblVerDai);
			this.gbFirma.Controls.Add(this.lblAdres);
			this.gbFirma.Controls.Add(this.lblFax);
			this.gbFirma.Controls.Add(this.lblTel2);
			this.gbFirma.Controls.Add(this.lblTel1);
			this.gbFirma.Controls.Add(this.txtFIsim);
			this.gbFirma.Controls.Add(this.lblFIsim);
			this.gbFirma.Controls.Add(this.lblSemt);
			this.gbFirma.Controls.Add(this.lblSehir);
			this.gbFirma.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(162)));
			this.gbFirma.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
			this.gbFirma.Location = new System.Drawing.Point(176, 192);
			this.gbFirma.Name = "gbFirma";
			this.gbFirma.Size = new System.Drawing.Size(400, 408);
			this.gbFirma.TabIndex = 12;
			this.gbFirma.TabStop = false;
			this.gbFirma.Text = "Firma Bilgileri";
			// 
			// cbSehir
			// 
			this.cbSehir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(162)));
			this.cbSehir.Location = new System.Drawing.Point(120, 192);
			this.cbSehir.Name = "cbSehir";
			this.cbSehir.Size = new System.Drawing.Size(152, 24);
			this.cbSehir.TabIndex = 22;
			// 
			// txtSemt
			// 
			this.txtSemt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(162)));
			this.txtSemt.Location = new System.Drawing.Point(120, 160);
			this.txtSemt.Name = "txtSemt";
			this.txtSemt.Size = new System.Drawing.Size(136, 22);
			this.txtSemt.TabIndex = 21;
			this.txtSemt.Text = "";
			// 
			// txtFMail
			// 
			this.txtFMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(162)));
			this.txtFMail.Location = new System.Drawing.Point(120, 360);
			this.txtFMail.Name = "txtFMail";
			this.txtFMail.Size = new System.Drawing.Size(264, 22);
			this.txtFMail.TabIndex = 17;
			this.txtFMail.Text = "";
			// 
			// txtWeb
			// 
			this.txtWeb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(162)));
			this.txtWeb.Location = new System.Drawing.Point(120, 328);
			this.txtWeb.Name = "txtWeb";
			this.txtWeb.Size = new System.Drawing.Size(264, 22);
			this.txtWeb.TabIndex = 16;
			this.txtWeb.Text = "";
			// 
			// txtVerNo
			// 
			this.txtVerNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(162)));
			this.txtVerNo.Location = new System.Drawing.Point(120, 296);
			this.txtVerNo.Name = "txtVerNo";
			this.txtVerNo.Size = new System.Drawing.Size(216, 22);
			this.txtVerNo.TabIndex = 15;
			this.txtVerNo.Text = "";
			// 
			// txtVerDai
			// 
			this.txtVerDai.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(162)));
			this.txtVerDai.Location = new System.Drawing.Point(120, 256);
			this.txtVerDai.Name = "txtVerDai";
			this.txtVerDai.Size = new System.Drawing.Size(216, 22);
			this.txtVerDai.TabIndex = 14;
			this.txtVerDai.Text = "";
			// 
			// txtAdres
			// 
			this.txtAdres.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(162)));
			this.txtAdres.Location = new System.Drawing.Point(120, 224);
			this.txtAdres.Name = "txtAdres";
			this.txtAdres.Size = new System.Drawing.Size(264, 22);
			this.txtAdres.TabIndex = 13;
			this.txtAdres.Text = "";
			// 
			// txtFax
			// 
			this.txtFax.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(162)));
			this.txtFax.Location = new System.Drawing.Point(120, 128);
			this.txtFax.Name = "txtFax";
			this.txtFax.Size = new System.Drawing.Size(168, 22);
			this.txtFax.TabIndex = 12;
			this.txtFax.Text = "";
			// 
			// txtTel2
			// 
			this.txtTel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(162)));
			this.txtTel2.Location = new System.Drawing.Point(120, 96);
			this.txtTel2.Name = "txtTel2";
			this.txtTel2.Size = new System.Drawing.Size(168, 22);
			this.txtTel2.TabIndex = 11;
			this.txtTel2.Text = "";
			// 
			// txtTel1
			// 
			this.txtTel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(162)));
			this.txtTel1.Location = new System.Drawing.Point(120, 64);
			this.txtTel1.Name = "txtTel1";
			this.txtTel1.Size = new System.Drawing.Size(168, 22);
			this.txtTel1.TabIndex = 10;
			this.txtTel1.Text = "";
			// 
			// lblFMail
			// 
			this.lblFMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(162)));
			this.lblFMail.Location = new System.Drawing.Point(16, 360);
			this.lblFMail.Name = "lblFMail";
			this.lblFMail.TabIndex = 9;
			this.lblFMail.Text = "E-Mail Adresi :";
			this.lblFMail.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lblWeb
			// 
			this.lblWeb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(162)));
			this.lblWeb.Location = new System.Drawing.Point(16, 328);
			this.lblWeb.Name = "lblWeb";
			this.lblWeb.TabIndex = 8;
			this.lblWeb.Text = "Web Adresi :";
			this.lblWeb.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lblVerNo
			// 
			this.lblVerNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(162)));
			this.lblVerNo.Location = new System.Drawing.Point(16, 288);
			this.lblVerNo.Name = "lblVerNo";
			this.lblVerNo.Size = new System.Drawing.Size(100, 32);
			this.lblVerNo.TabIndex = 7;
			this.lblVerNo.Text = "Vergi Numarasý :";
			this.lblVerNo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lblVerDai
			// 
			this.lblVerDai.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(162)));
			this.lblVerDai.Location = new System.Drawing.Point(16, 256);
			this.lblVerDai.Name = "lblVerDai";
			this.lblVerDai.TabIndex = 6;
			this.lblVerDai.Text = "Vergi Dairesi :";
			this.lblVerDai.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lblAdres
			// 
			this.lblAdres.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(162)));
			this.lblAdres.Location = new System.Drawing.Point(16, 224);
			this.lblAdres.Name = "lblAdres";
			this.lblAdres.TabIndex = 5;
			this.lblAdres.Text = "Adres :";
			this.lblAdres.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lblFax
			// 
			this.lblFax.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(162)));
			this.lblFax.Location = new System.Drawing.Point(16, 128);
			this.lblFax.Name = "lblFax";
			this.lblFax.TabIndex = 4;
			this.lblFax.Text = "Fax :";
			this.lblFax.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lblTel2
			// 
			this.lblTel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(162)));
			this.lblTel2.Location = new System.Drawing.Point(16, 96);
			this.lblTel2.Name = "lblTel2";
			this.lblTel2.TabIndex = 3;
			this.lblTel2.Text = "Telefon :";
			this.lblTel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lblTel1
			// 
			this.lblTel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(162)));
			this.lblTel1.Location = new System.Drawing.Point(16, 64);
			this.lblTel1.Name = "lblTel1";
			this.lblTel1.TabIndex = 2;
			this.lblTel1.Text = "Telefon :";
			this.lblTel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txtFIsim
			// 
			this.txtFIsim.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(162)));
			this.txtFIsim.Location = new System.Drawing.Point(120, 32);
			this.txtFIsim.Name = "txtFIsim";
			this.txtFIsim.Size = new System.Drawing.Size(264, 22);
			this.txtFIsim.TabIndex = 1;
			this.txtFIsim.Text = "";
			// 
			// lblFIsim
			// 
			this.lblFIsim.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(162)));
			this.lblFIsim.Location = new System.Drawing.Point(16, 32);
			this.lblFIsim.Name = "lblFIsim";
			this.lblFIsim.TabIndex = 0;
			this.lblFIsim.Text = "Ýsim :";
			this.lblFIsim.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lblSemt
			// 
			this.lblSemt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(162)));
			this.lblSemt.Location = new System.Drawing.Point(16, 160);
			this.lblSemt.Name = "lblSemt";
			this.lblSemt.TabIndex = 19;
			this.lblSemt.Text = "Semt :";
			this.lblSemt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lblSehir
			// 
			this.lblSehir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(162)));
			this.lblSehir.Location = new System.Drawing.Point(16, 192);
			this.lblSehir.Name = "lblSehir";
			this.lblSehir.TabIndex = 20;
			this.lblSehir.Text = "Þehir :";
			this.lblSehir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// gbKisi
			// 
			this.gbKisi.Controls.Add(this.txtDep);
			this.gbKisi.Controls.Add(this.txtKMail);
			this.gbKisi.Controls.Add(this.txtCepTel);
			this.gbKisi.Controls.Add(this.txtDahili);
			this.gbKisi.Controls.Add(this.txtUnvan);
			this.gbKisi.Controls.Add(this.txtSoyad);
			this.gbKisi.Controls.Add(this.txtAd);
			this.gbKisi.Controls.Add(this.lblKMail);
			this.gbKisi.Controls.Add(this.lblCepTel);
			this.gbKisi.Controls.Add(this.lblDahili);
			this.gbKisi.Controls.Add(this.lblUnvan);
			this.gbKisi.Controls.Add(this.lblSoyad);
			this.gbKisi.Controls.Add(this.lblAd);
			this.gbKisi.Controls.Add(this.lblDep);
			this.gbKisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(162)));
			this.gbKisi.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
			this.gbKisi.Location = new System.Drawing.Point(592, 328);
			this.gbKisi.Name = "gbKisi";
			this.gbKisi.Size = new System.Drawing.Size(400, 272);
			this.gbKisi.TabIndex = 13;
			this.gbKisi.TabStop = false;
			this.gbKisi.Text = "Kiþi Bilgileri";
			// 
			// txtDep
			// 
			this.txtDep.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(162)));
			this.txtDep.Location = new System.Drawing.Point(120, 32);
			this.txtDep.Name = "txtDep";
			this.txtDep.Size = new System.Drawing.Size(168, 22);
			this.txtDep.TabIndex = 23;
			this.txtDep.Text = "";
			// 
			// txtKMail
			// 
			this.txtKMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(162)));
			this.txtKMail.Location = new System.Drawing.Point(120, 224);
			this.txtKMail.Name = "txtKMail";
			this.txtKMail.Size = new System.Drawing.Size(264, 22);
			this.txtKMail.TabIndex = 11;
			this.txtKMail.Text = "";
			// 
			// txtCepTel
			// 
			this.txtCepTel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(162)));
			this.txtCepTel.Location = new System.Drawing.Point(120, 192);
			this.txtCepTel.Name = "txtCepTel";
			this.txtCepTel.Size = new System.Drawing.Size(168, 22);
			this.txtCepTel.TabIndex = 10;
			this.txtCepTel.Text = "";
			// 
			// txtDahili
			// 
			this.txtDahili.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(162)));
			this.txtDahili.Location = new System.Drawing.Point(120, 160);
			this.txtDahili.Name = "txtDahili";
			this.txtDahili.Size = new System.Drawing.Size(48, 22);
			this.txtDahili.TabIndex = 9;
			this.txtDahili.Text = "";
			// 
			// txtUnvan
			// 
			this.txtUnvan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(162)));
			this.txtUnvan.Location = new System.Drawing.Point(120, 128);
			this.txtUnvan.Name = "txtUnvan";
			this.txtUnvan.Size = new System.Drawing.Size(168, 22);
			this.txtUnvan.TabIndex = 8;
			this.txtUnvan.Text = "";
			// 
			// txtSoyad
			// 
			this.txtSoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(162)));
			this.txtSoyad.Location = new System.Drawing.Point(120, 96);
			this.txtSoyad.Name = "txtSoyad";
			this.txtSoyad.Size = new System.Drawing.Size(208, 22);
			this.txtSoyad.TabIndex = 7;
			this.txtSoyad.Text = "";
			// 
			// txtAd
			// 
			this.txtAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(162)));
			this.txtAd.Location = new System.Drawing.Point(120, 64);
			this.txtAd.Name = "txtAd";
			this.txtAd.Size = new System.Drawing.Size(208, 22);
			this.txtAd.TabIndex = 6;
			this.txtAd.Text = "";
			// 
			// lblKMail
			// 
			this.lblKMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(162)));
			this.lblKMail.Location = new System.Drawing.Point(24, 224);
			this.lblKMail.Name = "lblKMail";
			this.lblKMail.TabIndex = 5;
			this.lblKMail.Text = "E-Mail";
			this.lblKMail.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lblCepTel
			// 
			this.lblCepTel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(162)));
			this.lblCepTel.Location = new System.Drawing.Point(24, 192);
			this.lblCepTel.Name = "lblCepTel";
			this.lblCepTel.TabIndex = 4;
			this.lblCepTel.Text = "Cep Telefon :";
			this.lblCepTel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lblDahili
			// 
			this.lblDahili.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(162)));
			this.lblDahili.Location = new System.Drawing.Point(24, 160);
			this.lblDahili.Name = "lblDahili";
			this.lblDahili.TabIndex = 3;
			this.lblDahili.Text = "Dahili :";
			this.lblDahili.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lblUnvan
			// 
			this.lblUnvan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(162)));
			this.lblUnvan.Location = new System.Drawing.Point(24, 128);
			this.lblUnvan.Name = "lblUnvan";
			this.lblUnvan.TabIndex = 2;
			this.lblUnvan.Text = "Ünvan :";
			this.lblUnvan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lblSoyad
			// 
			this.lblSoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(162)));
			this.lblSoyad.Location = new System.Drawing.Point(24, 96);
			this.lblSoyad.Name = "lblSoyad";
			this.lblSoyad.TabIndex = 1;
			this.lblSoyad.Text = "Soyad :";
			this.lblSoyad.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lblAd
			// 
			this.lblAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(162)));
			this.lblAd.Location = new System.Drawing.Point(24, 64);
			this.lblAd.Name = "lblAd";
			this.lblAd.TabIndex = 0;
			this.lblAd.Text = "Ad :";
			this.lblAd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lblDep
			// 
			this.lblDep.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(162)));
			this.lblDep.Location = new System.Drawing.Point(24, 32);
			this.lblDep.Name = "lblDep";
			this.lblDep.TabIndex = 22;
			this.lblDep.Text = "Departman :";
			this.lblDep.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lblLevel
			// 
			this.lblLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(162)));
			this.lblLevel.Location = new System.Drawing.Point(16, 64);
			this.lblLevel.Name = "lblLevel";
			this.lblLevel.TabIndex = 18;
			this.lblLevel.Text = "Level :";
			this.lblLevel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lblSektor
			// 
			this.lblSektor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(162)));
			this.lblSektor.Location = new System.Drawing.Point(16, 32);
			this.lblSektor.Name = "lblSektor";
			this.lblSektor.TabIndex = 21;
			this.lblSektor.Text = "Sektör :";
			this.lblSektor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// gbAlan
			// 
			this.gbAlan.Controls.Add(this.cbLevel);
			this.gbAlan.Controls.Add(this.cbSektor);
			this.gbAlan.Controls.Add(this.lblSektor);
			this.gbAlan.Controls.Add(this.lblLevel);
			this.gbAlan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(162)));
			this.gbAlan.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
			this.gbAlan.Location = new System.Drawing.Point(592, 192);
			this.gbAlan.Name = "gbAlan";
			this.gbAlan.Size = new System.Drawing.Size(400, 112);
			this.gbAlan.TabIndex = 22;
			this.gbAlan.TabStop = false;
			this.gbAlan.Text = "Alan Bilgileri";
			// 
			// cbLevel
			// 
			this.cbLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(162)));
			this.cbLevel.Location = new System.Drawing.Point(120, 64);
			this.cbLevel.Name = "cbLevel";
			this.cbLevel.Size = new System.Drawing.Size(150, 24);
			this.cbLevel.TabIndex = 23;
			// 
			// cbSektor
			// 
			this.cbSektor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(162)));
			this.cbSektor.Location = new System.Drawing.Point(120, 32);
			this.cbSektor.Name = "cbSektor";
			this.cbSektor.Size = new System.Drawing.Size(150, 24);
			this.cbSektor.TabIndex = 22;
			// 
			// btnYeni
			// 
			this.btnYeni.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnYeni.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(162)));
			this.btnYeni.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
			this.btnYeni.Location = new System.Drawing.Point(16, 8);
			this.btnYeni.Name = "btnYeni";
			this.btnYeni.Size = new System.Drawing.Size(75, 30);
			this.btnYeni.TabIndex = 23;
			this.btnYeni.Text = "Yeni";
			this.btnYeni.Click += new System.EventHandler(this.btnYeni_Click);
			// 
			// btnDuzenle
			// 
			this.btnDuzenle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnDuzenle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(162)));
			this.btnDuzenle.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
			this.btnDuzenle.Location = new System.Drawing.Point(104, 8);
			this.btnDuzenle.Name = "btnDuzenle";
			this.btnDuzenle.Size = new System.Drawing.Size(75, 30);
			this.btnDuzenle.TabIndex = 24;
			this.btnDuzenle.Text = "Düzenle";
			this.btnDuzenle.Click += new System.EventHandler(this.btnDuzenle_Click);
			// 
			// btnSil
			// 
			this.btnSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(162)));
			this.btnSil.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
			this.btnSil.Location = new System.Drawing.Point(192, 8);
			this.btnSil.Name = "btnSil";
			this.btnSil.Size = new System.Drawing.Size(75, 30);
			this.btnSil.TabIndex = 25;
			this.btnSil.Text = "Sil";
			this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
			// 
			// btnKAra
			// 
			this.btnKAra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnKAra.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(162)));
			this.btnKAra.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
			this.btnKAra.Location = new System.Drawing.Point(280, 8);
			this.btnKAra.Name = "btnKAra";
			this.btnKAra.Size = new System.Drawing.Size(75, 30);
			this.btnKAra.TabIndex = 26;
			this.btnKAra.Text = "Ara";
			this.btnKAra.Click += new System.EventHandler(this.btnKAra_Click);
			// 
			// btnGuncelle
			// 
			this.btnGuncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(162)));
			this.btnGuncelle.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
			this.btnGuncelle.Location = new System.Drawing.Point(904, 616);
			this.btnGuncelle.Name = "btnGuncelle";
			this.btnGuncelle.Size = new System.Drawing.Size(75, 30);
			this.btnGuncelle.TabIndex = 27;
			this.btnGuncelle.Text = "Güncelle";
			this.btnGuncelle.Click += new System.EventHandler(this.btnKaydet_Click);
			// 
			// btnRapor
			// 
			this.btnRapor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(162)));
			this.btnRapor.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
			this.btnRapor.Location = new System.Drawing.Point(48, 512);
			this.btnRapor.Name = "btnRapor";
			this.btnRapor.Size = new System.Drawing.Size(80, 50);
			this.btnRapor.TabIndex = 29;
			this.btnRapor.Text = "Rapor";
			this.btnRapor.Click += new System.EventHandler(this.btnRapor_Click);
			// 
			// pnlKartlar
			// 
			this.pnlKartlar.Controls.Add(this.btnSil);
			this.pnlKartlar.Controls.Add(this.btnYeni);
			this.pnlKartlar.Controls.Add(this.btnKAra);
			this.pnlKartlar.Controls.Add(this.btnDuzenle);
			this.pnlKartlar.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
			this.pnlKartlar.Location = new System.Drawing.Point(288, 72);
			this.pnlKartlar.Name = "pnlKartlar";
			this.pnlKartlar.Size = new System.Drawing.Size(368, 48);
			this.pnlKartlar.TabIndex = 30;
			// 
			// pnlList
			// 
			this.pnlList.Controls.Add(this.btnLAra);
			this.pnlList.Controls.Add(this.btnServis);
			this.pnlList.Controls.Add(this.btnYazýlým);
			this.pnlList.Controls.Add(this.btnOEM);
			this.pnlList.Controls.Add(this.btnCCTV);
			this.pnlList.Controls.Add(this.btnPSG);
			this.pnlList.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
			this.pnlList.Location = new System.Drawing.Point(200, 72);
			this.pnlList.Name = "pnlList";
			this.pnlList.Size = new System.Drawing.Size(544, 48);
			this.pnlList.TabIndex = 31;
			this.pnlList.Visible = false;
			// 
			// btnLAra
			// 
			this.btnLAra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnLAra.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(162)));
			this.btnLAra.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
			this.btnLAra.Location = new System.Drawing.Point(456, 9);
			this.btnLAra.Name = "btnLAra";
			this.btnLAra.Size = new System.Drawing.Size(75, 30);
			this.btnLAra.TabIndex = 5;
			this.btnLAra.Text = "Ara";
			this.btnLAra.Click += new System.EventHandler(this.btnLAra_Click);
			// 
			// btnServis
			// 
			this.btnServis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnServis.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(162)));
			this.btnServis.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
			this.btnServis.Location = new System.Drawing.Point(368, 9);
			this.btnServis.Name = "btnServis";
			this.btnServis.Size = new System.Drawing.Size(75, 30);
			this.btnServis.TabIndex = 4;
			this.btnServis.Text = "Servis";
			this.btnServis.Click += new System.EventHandler(this.btnServis_Click);
			// 
			// btnYazýlým
			// 
			this.btnYazýlým.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnYazýlým.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(162)));
			this.btnYazýlým.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
			this.btnYazýlým.Location = new System.Drawing.Point(280, 9);
			this.btnYazýlým.Name = "btnYazýlým";
			this.btnYazýlým.Size = new System.Drawing.Size(75, 30);
			this.btnYazýlým.TabIndex = 3;
			this.btnYazýlým.Text = "Yazýlým";
			this.btnYazýlým.Click += new System.EventHandler(this.btnYazýlým_Click);
			// 
			// btnOEM
			// 
			this.btnOEM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnOEM.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(162)));
			this.btnOEM.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
			this.btnOEM.Location = new System.Drawing.Point(192, 9);
			this.btnOEM.Name = "btnOEM";
			this.btnOEM.Size = new System.Drawing.Size(75, 30);
			this.btnOEM.TabIndex = 2;
			this.btnOEM.Text = "OEM";
			this.btnOEM.Click += new System.EventHandler(this.btnOEM_Click);
			// 
			// btnCCTV
			// 
			this.btnCCTV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnCCTV.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(162)));
			this.btnCCTV.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
			this.btnCCTV.Location = new System.Drawing.Point(104, 9);
			this.btnCCTV.Name = "btnCCTV";
			this.btnCCTV.Size = new System.Drawing.Size(75, 30);
			this.btnCCTV.TabIndex = 1;
			this.btnCCTV.Text = "CCTV";
			this.btnCCTV.Click += new System.EventHandler(this.btnCCTV_Click);
			// 
			// btnPSG
			// 
			this.btnPSG.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnPSG.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(162)));
			this.btnPSG.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
			this.btnPSG.Location = new System.Drawing.Point(16, 8);
			this.btnPSG.Name = "btnPSG";
			this.btnPSG.Size = new System.Drawing.Size(75, 30);
			this.btnPSG.TabIndex = 0;
			this.btnPSG.Text = "PSG";
			this.btnPSG.Click += new System.EventHandler(this.btnPSG_Click);
			// 
			// sqlDataAdapter1
			// 
			this.sqlDataAdapter1.DeleteCommand = this.sqlDeleteCommand1;
			this.sqlDataAdapter1.InsertCommand = this.sqlInsertCommand1;
			this.sqlDataAdapter1.SelectCommand = this.sqlSelectCommand1;
			this.sqlDataAdapter1.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
																									  new System.Data.Common.DataTableMapping("Table", "tbl_mk", new System.Data.Common.DataColumnMapping[] {
																																																				new System.Data.Common.DataColumnMapping("KartID", "KartID"),
																																																				new System.Data.Common.DataColumnMapping("Isim", "Isim"),
																																																				new System.Data.Common.DataColumnMapping("Tel1", "Tel1"),
																																																				new System.Data.Common.DataColumnMapping("Tel2", "Tel2"),
																																																				new System.Data.Common.DataColumnMapping("Semt", "Semt"),
																																																				new System.Data.Common.DataColumnMapping("Sehir", "Sehir"),
																																																				new System.Data.Common.DataColumnMapping("Fax", "Fax"),
																																																				new System.Data.Common.DataColumnMapping("Adres", "Adres"),
																																																				new System.Data.Common.DataColumnMapping("Vergi", "Vergi"),
																																																				new System.Data.Common.DataColumnMapping("VergiNo", "VergiNo"),
																																																				new System.Data.Common.DataColumnMapping("Web", "Web"),
																																																				new System.Data.Common.DataColumnMapping("FirmaMail", "FirmaMail"),
																																																				new System.Data.Common.DataColumnMapping("Sektor", "Sektor"),
																																																				new System.Data.Common.DataColumnMapping("Lvel", "Lvel"),
																																																				new System.Data.Common.DataColumnMapping("Departman", "Departman"),
																																																				new System.Data.Common.DataColumnMapping("Ad", "Ad"),
																																																				new System.Data.Common.DataColumnMapping("Soyad", "Soyad"),
																																																				new System.Data.Common.DataColumnMapping("Unvan", "Unvan"),
																																																				new System.Data.Common.DataColumnMapping("Dahili", "Dahili"),
																																																				new System.Data.Common.DataColumnMapping("CepTel", "CepTel"),
																																																				new System.Data.Common.DataColumnMapping("KisiMail", "KisiMail"),
																																																				new System.Data.Common.DataColumnMapping("Sil", "Sil"),
																																																				new System.Data.Common.DataColumnMapping("Tarih", "Tarih"),
																																																				new System.Data.Common.DataColumnMapping("Saat", "Saat")})});
			this.sqlDataAdapter1.UpdateCommand = this.sqlUpdateCommand1;
			// 
			// sqlDeleteCommand1
			// 
			this.sqlDeleteCommand1.CommandText = @"DELETE FROM tbl_mk WHERE (KartID = @Original_KartID) AND (Ad = @Original_Ad) AND (Adres = @Original_Adres) AND (CepTel = @Original_CepTel) AND (Dahili = @Original_Dahili) AND (Departman = @Original_Departman) AND (Fax = @Original_Fax) AND (FirmaMail = @Original_FirmaMail) AND (Isim = @Original_Isim) AND (KisiMail = @Original_KisiMail) AND (Lvel = @Original_Lvel) AND (Saat = @Original_Saat) AND (Sehir = @Original_Sehir) AND (Sektor = @Original_Sektor) AND (Semt = @Original_Semt) AND (Sil = @Original_Sil) AND (Soyad = @Original_Soyad) AND (Tarih = @Original_Tarih) AND (Tel1 = @Original_Tel1) AND (Tel2 = @Original_Tel2) AND (Unvan = @Original_Unvan) AND (Vergi = @Original_Vergi) AND (VergiNo = @Original_VergiNo) AND (Web = @Original_Web)";
			this.sqlDeleteCommand1.Connection = this.sqlConnection1;
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_KartID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "KartID", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_Ad", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Ad", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_Adres", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Adres", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_CepTel", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "CepTel", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_Dahili", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Dahili", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_Departman", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Departman", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_Fax", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Fax", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_FirmaMail", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "FirmaMail", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_Isim", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Isim", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_KisiMail", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "KisiMail", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_Lvel", System.Data.SqlDbType.VarChar, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Lvel", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_Saat", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Saat", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_Sehir", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Sehir", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_Sektor", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Sektor", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_Semt", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Semt", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_Sil", System.Data.SqlDbType.TinyInt, 1, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Sil", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_Soyad", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Soyad", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_Tarih", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Tarih", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_Tel1", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Tel1", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_Tel2", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Tel2", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_Unvan", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Unvan", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_Vergi", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Vergi", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_VergiNo", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "VergiNo", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_Web", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Web", System.Data.DataRowVersion.Original, null));
			// 
			// sqlConnection1
			// 
			this.sqlConnection1.ConnectionString = "workstation id=MCY;packet size=4096;integrated security=SSPI;data source=MCY;pers" +
				"ist security info=False;initial catalog=crm";
			// 
			// sqlInsertCommand1
			// 
			this.sqlInsertCommand1.CommandText = @"INSERT INTO tbl_mk(Isim, Tel1, Tel2, Semt, Sehir, Fax, Adres, Vergi, VergiNo, Web, FirmaMail, Sektor, Lvel, Departman, Ad, Soyad, Unvan, Dahili, CepTel, KisiMail, Sil, Tarih, Saat) VALUES (@Isim, @Tel1, @Tel2, @Semt, @Sehir, @Fax, @Adres, @Vergi, @VergiNo, @Web, @FirmaMail, @Sektor, @Lvel, @Departman, @Ad, @Soyad, @Unvan, @Dahili, @CepTel, @KisiMail, @Sil, @Tarih, @Saat); SELECT KartID, Isim, Tel1, Tel2, Semt, Sehir, Fax, Adres, Vergi, VergiNo, Web, FirmaMail, Sektor, Lvel, Departman, Ad, Soyad, Unvan, Dahili, CepTel, KisiMail, Sil, Tarih, Saat FROM tbl_mk WHERE (KartID = @@IDENTITY)";
			this.sqlInsertCommand1.Connection = this.sqlConnection1;
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Isim", System.Data.SqlDbType.VarChar, 50, "Isim"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Tel1", System.Data.SqlDbType.VarChar, 50, "Tel1"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Tel2", System.Data.SqlDbType.VarChar, 50, "Tel2"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Semt", System.Data.SqlDbType.VarChar, 50, "Semt"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Sehir", System.Data.SqlDbType.VarChar, 50, "Sehir"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Fax", System.Data.SqlDbType.VarChar, 50, "Fax"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Adres", System.Data.SqlDbType.VarChar, 50, "Adres"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Vergi", System.Data.SqlDbType.VarChar, 50, "Vergi"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@VergiNo", System.Data.SqlDbType.VarChar, 50, "VergiNo"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Web", System.Data.SqlDbType.VarChar, 50, "Web"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@FirmaMail", System.Data.SqlDbType.VarChar, 50, "FirmaMail"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Sektor", System.Data.SqlDbType.VarChar, 50, "Sektor"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Lvel", System.Data.SqlDbType.VarChar, 4, "Lvel"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Departman", System.Data.SqlDbType.VarChar, 50, "Departman"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Ad", System.Data.SqlDbType.VarChar, 50, "Ad"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Soyad", System.Data.SqlDbType.VarChar, 50, "Soyad"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Unvan", System.Data.SqlDbType.VarChar, 50, "Unvan"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Dahili", System.Data.SqlDbType.VarChar, 50, "Dahili"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@CepTel", System.Data.SqlDbType.VarChar, 50, "CepTel"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@KisiMail", System.Data.SqlDbType.VarChar, 50, "KisiMail"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Sil", System.Data.SqlDbType.TinyInt, 1, "Sil"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Tarih", System.Data.SqlDbType.DateTime, 8, "Tarih"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Saat", System.Data.SqlDbType.DateTime, 8, "Saat"));
			// 
			// sqlSelectCommand1
			// 
			this.sqlSelectCommand1.CommandText = "SELECT KartID, Isim, Tel1, Tel2, Semt, Sehir, Fax, Adres, Vergi, VergiNo, Web, Fi" +
				"rmaMail, Sektor, Lvel, Departman, Ad, Soyad, Unvan, Dahili, CepTel, KisiMail, Si" +
				"l, Tarih, Saat FROM tbl_mk";
			this.sqlSelectCommand1.Connection = this.sqlConnection1;
			// 
			// sqlUpdateCommand1
			// 
			this.sqlUpdateCommand1.CommandText = @"UPDATE tbl_mk SET Isim = @Isim, Tel1 = @Tel1, Tel2 = @Tel2, Semt = @Semt, Sehir = @Sehir, Fax = @Fax, Adres = @Adres, Vergi = @Vergi, VergiNo = @VergiNo, Web = @Web, FirmaMail = @FirmaMail, Sektor = @Sektor, Lvel = @Lvel, Departman = @Departman, Ad = @Ad, Soyad = @Soyad, Unvan = @Unvan, Dahili = @Dahili, CepTel = @CepTel, KisiMail = @KisiMail, Sil = @Sil, Tarih = @Tarih, Saat = @Saat WHERE (KartID = @Original_KartID) AND (Ad = @Original_Ad) AND (Adres = @Original_Adres) AND (CepTel = @Original_CepTel) AND (Dahili = @Original_Dahili) AND (Departman = @Original_Departman) AND (Fax = @Original_Fax) AND (FirmaMail = @Original_FirmaMail) AND (Isim = @Original_Isim) AND (KisiMail = @Original_KisiMail) AND (Lvel = @Original_Lvel) AND (Saat = @Original_Saat) AND (Sehir = @Original_Sehir) AND (Sektor = @Original_Sektor) AND (Semt = @Original_Semt) AND (Sil = @Original_Sil) AND (Soyad = @Original_Soyad) AND (Tarih = @Original_Tarih) AND (Tel1 = @Original_Tel1) AND (Tel2 = @Original_Tel2) AND (Unvan = @Original_Unvan) AND (Vergi = @Original_Vergi) AND (VergiNo = @Original_VergiNo) AND (Web = @Original_Web); SELECT KartID, Isim, Tel1, Tel2, Semt, Sehir, Fax, Adres, Vergi, VergiNo, Web, FirmaMail, Sektor, Lvel, Departman, Ad, Soyad, Unvan, Dahili, CepTel, KisiMail, Sil, Tarih, Saat FROM tbl_mk WHERE (KartID = @KartID)";
			this.sqlUpdateCommand1.Connection = this.sqlConnection1;
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Isim", System.Data.SqlDbType.VarChar, 50, "Isim"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Tel1", System.Data.SqlDbType.VarChar, 50, "Tel1"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Tel2", System.Data.SqlDbType.VarChar, 50, "Tel2"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Semt", System.Data.SqlDbType.VarChar, 50, "Semt"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Sehir", System.Data.SqlDbType.VarChar, 50, "Sehir"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Fax", System.Data.SqlDbType.VarChar, 50, "Fax"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Adres", System.Data.SqlDbType.VarChar, 50, "Adres"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Vergi", System.Data.SqlDbType.VarChar, 50, "Vergi"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@VergiNo", System.Data.SqlDbType.VarChar, 50, "VergiNo"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Web", System.Data.SqlDbType.VarChar, 50, "Web"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@FirmaMail", System.Data.SqlDbType.VarChar, 50, "FirmaMail"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Sektor", System.Data.SqlDbType.VarChar, 50, "Sektor"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Lvel", System.Data.SqlDbType.VarChar, 4, "Lvel"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Departman", System.Data.SqlDbType.VarChar, 50, "Departman"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Ad", System.Data.SqlDbType.VarChar, 50, "Ad"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Soyad", System.Data.SqlDbType.VarChar, 50, "Soyad"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Unvan", System.Data.SqlDbType.VarChar, 50, "Unvan"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Dahili", System.Data.SqlDbType.VarChar, 50, "Dahili"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@CepTel", System.Data.SqlDbType.VarChar, 50, "CepTel"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@KisiMail", System.Data.SqlDbType.VarChar, 50, "KisiMail"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Sil", System.Data.SqlDbType.TinyInt, 1, "Sil"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Tarih", System.Data.SqlDbType.DateTime, 8, "Tarih"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Saat", System.Data.SqlDbType.DateTime, 8, "Saat"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_KartID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "KartID", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_Ad", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Ad", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_Adres", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Adres", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_CepTel", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "CepTel", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_Dahili", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Dahili", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_Departman", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Departman", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_Fax", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Fax", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_FirmaMail", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "FirmaMail", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_Isim", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Isim", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_KisiMail", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "KisiMail", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_Lvel", System.Data.SqlDbType.VarChar, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Lvel", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_Saat", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Saat", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_Sehir", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Sehir", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_Sektor", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Sektor", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_Semt", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Semt", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_Sil", System.Data.SqlDbType.TinyInt, 1, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Sil", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_Soyad", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Soyad", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_Tarih", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Tarih", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_Tel1", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Tel1", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_Tel2", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Tel2", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_Unvan", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Unvan", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_Vergi", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Vergi", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_VergiNo", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "VergiNo", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_Web", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Web", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@KartID", System.Data.SqlDbType.Int, 4, "KartID"));
			// 
			// ds_musteri1
			// 
			this.ds_musteri1.DataSetName = "ds_musteri";
			this.ds_musteri1.Locale = new System.Globalization.CultureInfo("tr-TR");
			// 
			// btnAltAdmin
			// 
			this.btnAltAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnAltAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(162)));
			this.btnAltAdmin.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
			this.btnAltAdmin.Location = new System.Drawing.Point(744, 32);
			this.btnAltAdmin.Name = "btnAltAdmin";
			this.btnAltAdmin.Size = new System.Drawing.Size(75, 30);
			this.btnAltAdmin.TabIndex = 87;
			this.btnAltAdmin.Text = "Admin";
			this.btnAltAdmin.Click += new System.EventHandler(this.btnAltAdmin_Click);
			// 
			// pnlAdmin
			// 
			this.pnlAdmin.Controls.Add(this.button7);
			this.pnlAdmin.Controls.Add(this.button8);
			this.pnlAdmin.Controls.Add(this.button9);
			this.pnlAdmin.Location = new System.Drawing.Point(728, 72);
			this.pnlAdmin.Name = "pnlAdmin";
			this.pnlAdmin.Size = new System.Drawing.Size(280, 48);
			this.pnlAdmin.TabIndex = 86;
			this.pnlAdmin.Visible = false;
			// 
			// button7
			// 
			this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(162)));
			this.button7.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
			this.button7.Location = new System.Drawing.Point(16, 8);
			this.button7.Name = "button7";
			this.button7.Size = new System.Drawing.Size(75, 30);
			this.button7.TabIndex = 37;
			this.button7.Text = "Yeni";
			this.button7.Click += new System.EventHandler(this.button7_Click);
			// 
			// button8
			// 
			this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(162)));
			this.button8.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
			this.button8.Location = new System.Drawing.Point(192, 8);
			this.button8.Name = "button8";
			this.button8.Size = new System.Drawing.Size(75, 30);
			this.button8.TabIndex = 39;
			this.button8.Text = "Sil";
			this.button8.Click += new System.EventHandler(this.button8_Click);
			// 
			// button9
			// 
			this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(162)));
			this.button9.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
			this.button9.Location = new System.Drawing.Point(104, 8);
			this.button9.Name = "button9";
			this.button9.Size = new System.Drawing.Size(75, 30);
			this.button9.TabIndex = 38;
			this.button9.Text = "Düzenle";
			this.button9.Click += new System.EventHandler(this.button9_Click);
			// 
			// button1
			// 
			this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(162)));
			this.button1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
			this.button1.Location = new System.Drawing.Point(48, 568);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(80, 50);
			this.button1.TabIndex = 88;
			this.button1.Text = "Admin";
			this.button1.Click += new System.EventHandler(this.button1_Click_1);
			// 
			// pnlTeklif
			// 
			this.pnlTeklif.Controls.Add(this.btnTeklifGoruntule);
			this.pnlTeklif.Controls.Add(this.btnTeklifYeni);
			this.pnlTeklif.Controls.Add(this.btnTeklifPrint);
			this.pnlTeklif.Location = new System.Drawing.Point(472, 72);
			this.pnlTeklif.Name = "pnlTeklif";
			this.pnlTeklif.Size = new System.Drawing.Size(272, 48);
			this.pnlTeklif.TabIndex = 98;
			this.pnlTeklif.Visible = false;
			// 
			// btnTeklifGoruntule
			// 
			this.btnTeklifGoruntule.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnTeklifGoruntule.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(162)));
			this.btnTeklifGoruntule.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
			this.btnTeklifGoruntule.Location = new System.Drawing.Point(8, 8);
			this.btnTeklifGoruntule.Name = "btnTeklifGoruntule";
			this.btnTeklifGoruntule.Size = new System.Drawing.Size(75, 30);
			this.btnTeklifGoruntule.TabIndex = 34;
			this.btnTeklifGoruntule.Text = "Görüntüle";
			// 
			// btnTeklifYeni
			// 
			this.btnTeklifYeni.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnTeklifYeni.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(162)));
			this.btnTeklifYeni.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
			this.btnTeklifYeni.Location = new System.Drawing.Point(96, 8);
			this.btnTeklifYeni.Name = "btnTeklifYeni";
			this.btnTeklifYeni.Size = new System.Drawing.Size(75, 30);
			this.btnTeklifYeni.TabIndex = 35;
			this.btnTeklifYeni.Text = "Yeni";
			// 
			// btnTeklifPrint
			// 
			this.btnTeklifPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnTeklifPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(162)));
			this.btnTeklifPrint.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
			this.btnTeklifPrint.Location = new System.Drawing.Point(184, 8);
			this.btnTeklifPrint.Name = "btnTeklifPrint";
			this.btnTeklifPrint.Size = new System.Drawing.Size(75, 30);
			this.btnTeklifPrint.TabIndex = 36;
			this.btnTeklifPrint.Text = "Print";
			// 
			// pnlCrm
			// 
			this.pnlCrm.Controls.Add(this.button10);
			this.pnlCrm.Controls.Add(this.button11);
			this.pnlCrm.Location = new System.Drawing.Point(384, 72);
			this.pnlCrm.Name = "pnlCrm";
			this.pnlCrm.Size = new System.Drawing.Size(176, 48);
			this.pnlCrm.TabIndex = 119;
			this.pnlCrm.Visible = false;
			// 
			// button10
			// 
			this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(162)));
			this.button10.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
			this.button10.Location = new System.Drawing.Point(8, 8);
			this.button10.Name = "button10";
			this.button10.Size = new System.Drawing.Size(75, 30);
			this.button10.TabIndex = 105;
			this.button10.Text = "Hareketler";
			this.button10.Click += new System.EventHandler(this.button10_Click);
			// 
			// button11
			// 
			this.button11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(162)));
			this.button11.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
			this.button11.Location = new System.Drawing.Point(96, 8);
			this.button11.Name = "button11";
			this.button11.Size = new System.Drawing.Size(75, 30);
			this.button11.TabIndex = 106;
			this.button11.Text = "Ara";
			this.button11.Click += new System.EventHandler(this.button11_Click);
			// 
			// KartlarGuncelle
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.BackColor = System.Drawing.Color.PaleGoldenrod;
			this.ClientSize = new System.Drawing.Size(1016, 741);
			this.Controls.Add(this.pnlCrm);
			this.Controls.Add(this.pnlTeklif);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.btnAltAdmin);
			this.Controls.Add(this.pnlAdmin);
			this.Controls.Add(this.pnlList);
			this.Controls.Add(this.pnlKartlar);
			this.Controls.Add(this.btnRapor);
			this.Controls.Add(this.btnGuncelle);
			this.Controls.Add(this.gbAlan);
			this.Controls.Add(this.gbKisi);
			this.Controls.Add(this.gbFirma);
			this.Controls.Add(this.btnAltProjeler);
			this.Controls.Add(this.btnSiparis);
			this.Controls.Add(this.btnTeklif);
			this.Controls.Add(this.btnAltCrm);
			this.Controls.Add(this.btnKart);
			this.Controls.Add(this.btnList);
			this.Controls.Add(this.btnBilgiB);
			this.Controls.Add(this.btnProjeler);
			this.Controls.Add(this.btnSiparisG);
			this.Controls.Add(this.btnTeklifH);
			this.Controls.Add(this.btnCrm);
			this.Controls.Add(this.btnMusteriK);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "KartlarGuncelle";
			this.Text = "Novateknik CRM";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.KartlarYeni_Load);
			this.Closed += new System.EventHandler(this.KartlarGuncelle_Closed);
			this.gbFirma.ResumeLayout(false);
			this.gbKisi.ResumeLayout(false);
			this.gbAlan.ResumeLayout(false);
			this.pnlKartlar.ResumeLayout(false);
			this.pnlList.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.ds_musteri1)).EndInit();
			this.pnlAdmin.ResumeLayout(false);
			this.pnlTeklif.ResumeLayout(false);
			this.pnlCrm.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion
		
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		
		private void btnKart_Click(object sender, System.EventArgs e)
		{
			
			pnlList.Visible=false;
			pnlTeklif.Visible=false;
			pnlAdmin.Visible=false;
			pnlCrm.Visible=false;
			pnlKartlar.Visible=true;
		}

		private void btnList_Click(object sender, System.EventArgs e)
		{
			pnlKartlar.Visible=false;
			pnlTeklif.Visible=false;
			pnlAdmin.Visible=false;
			pnlCrm.Visible=false;
			pnlList.Visible=true;
		}

		private void btnAltCrm_Click(object sender, System.EventArgs e)
		{
			pnlKartlar.Visible=false;
			pnlList.Visible=false;
			pnlTeklif.Visible=false;
			pnlAdmin.Visible=false;
			pnlCrm.Visible=true;
		}

		private void btnTeklif_Click(object sender, System.EventArgs e)
		{
			pnlKartlar.Visible=false;
			pnlList.Visible=false;
			pnlAdmin.Visible=false;
			pnlCrm.Visible=false;
			pnlTeklif.Visible=true;
		}

		private void btnSiparis_Click(object sender, System.EventArgs e)
		{
			pnlKartlar.Visible=false;
			pnlList.Visible=false;
			pnlTeklif.Visible=false;
			pnlAdmin.Visible=false;
			pnlCrm.Visible=false;
		}

		private void btnAltProjeler_Click(object sender, System.EventArgs e)
		{
			pnlKartlar.Visible=false;
			pnlList.Visible=false;
			pnlTeklif.Visible=false;
			pnlAdmin.Visible=false;
			pnlCrm.Visible=false;
		}


		private void btnKaydet_Click(object sender, System.EventArgs e)
		{
			
			DataRow ekle=ds_musteri1.Tables["tbl_mk"].NewRow();
			if (cbLevel.Text=="Seçiniz")
			{
				ekle["Lvel"]=0;
			}
			else if (cbLevel.Text=="")
			{
				ekle["Lvel"]=0;
			}
			else 
			{
				ekle["Lvel"]=cbLevel.Text;
			}
			cbLevel.Items.Add("1");
			cbLevel.Items.Add("2");
			cbLevel.Items.Add("3");
			cbLevel.Items.Add("4");
			cbLevel.Items.Add("5");

			SqlConnection baglantim = new SqlConnection();
			baglantim.ConnectionString = "Data Source=MCY;Integrated Security=SSPI;Initial Catalog=crm";
			SqlCommand komut = new SqlCommand();
			komut.Connection= baglantim;

			DialogResult dugmesec;
			dugmesec=MessageBox.Show(this,"Kartý güncellemek istediðinizden eminmisiniz?","DÝKKAT",MessageBoxButtons.YesNo);
			if(dugmesec==DialogResult.Yes)
			{
				komut.CommandText="UPDATE tbl_mk SET Isim ='" + txtFIsim.Text + "', Tel1 ='" + txtTel1.Text + "', Tel2 ='" + txtTel2.Text + "', Fax ='" + txtFax.Text + "', Semt ='" + txtSemt.Text + "', Sehir ='" + cbSehir.Text + "', Adres ='" + txtAdres.Text + "', Vergi ='" + txtVerDai.Text + "', VergiNo ='" + txtVerNo.Text + "', Web ='" + txtWeb.Text + "', FirmaMail ='" + txtFMail.Text + "', Sektor ='" + cbSektor.Text + "', Lvel ='" + cbLevel.Text + "', Departman ='" + txtDep.Text + "', Ad ='" + txtAd.Text + "', Soyad ='" + txtSoyad.Text + "', Unvan ='" + txtUnvan.Text + "', Dahili ='" + txtDahili.Text + "', CepTel ='" + txtCepTel.Text + "', KisiMail ='" + txtKMail.Text + "'where KartID ='" + KartlarDuzenle.txtTasi + "'";
				MessageBox.Show(this,"Güncelleme iþlemi baþarý ile tamamlanmýþtýr","DÝKKAT");
			}
			else if(dugmesec==DialogResult.No)
			{	
				MessageBox.Show(this,"Güncelleme iþlemini iptal ettiniz.","DÝKKAT");
			}
			try
			{
				baglantim.Open();
				komut.ExecuteNonQuery();
				baglantim.Close();
			}
			catch
			{}		
		}

		private void btnKAra_Click(object sender, System.EventArgs e)
		{
			
			Ara yeni=new Ara();
			yeni.Show();
			this.Hide();

		}
		
		private void KartlarYeni_Load(object sender, System.EventArgs e)
		{
			if(Giris.yetki=="1")
			{
				button1.Visible=false;
				btnAltAdmin.Visible=false;
			}


			cbSektor.Items.Add("Seçiniz");
			cbSektor.Text="Seçiniz";
			cbSehir.Text="istanbul";
			cbLevel.Items.Add("Seçiniz");
			cbLevel.Text="Seçiniz";
			//
			//Sehirler
			//
			cbSehir.Items.Add("istanbul");
			cbSehir.Items.Add("adana");
			cbSehir.Items.Add("adýyaman");
			cbSehir.Items.Add("afyon");
			cbSehir.Items.Add("aðrý");
			cbSehir.Items.Add("amasya");
			cbSehir.Items.Add("antalya");
			cbSehir.Items.Add("artvin");
			cbSehir.Items.Add("ardahan");
			cbSehir.Items.Add("aksaray");
			cbSehir.Items.Add("balikesir");
			cbSehir.Items.Add("bartýn");
			cbSehir.Items.Add("bayburt");
			cbSehir.Items.Add("bilecik");
			cbSehir.Items.Add("bitlis");
			cbSehir.Items.Add("bolu");
			cbSehir.Items.Add("burdur");
			cbSehir.Items.Add("bursa");
			cbSehir.Items.Add("çanakkale");
			cbSehir.Items.Add("çankýrý");
			cbSehir.Items.Add("denizli");
			cbSehir.Items.Add("diyarbakýr");
			cbSehir.Items.Add("düzce");
			cbSehir.Items.Add("edirne");
			cbSehir.Items.Add("elaðzý");
			cbSehir.Items.Add("erzurum");
			cbSehir.Items.Add("eskiþehir");
			cbSehir.Items.Add("giresun");
			cbSehir.Items.Add("gümüþhane");
			cbSehir.Items.Add("hatay");
			cbSehir.Items.Add("ýsparta");
			cbSehir.Items.Add("ýðdýr");
			cbSehir.Items.Add("içel");
			cbSehir.Items.Add("izmir");
			cbSehir.Items.Add("kars");
			cbSehir.Items.Add("kastamonu");
			cbSehir.Items.Add("karaman");
			cbSehir.Items.Add("kayseri");
			cbSehir.Items.Add("karabük");
			cbSehir.Items.Add("kýrklareli");
			cbSehir.Items.Add("kocaeli");
			cbSehir.Items.Add("konya");
			cbSehir.Items.Add("kütahya");
			cbSehir.Items.Add("malatya");
			cbSehir.Items.Add("manisa");
			cbSehir.Items.Add("kahramanmaraþ");
			cbSehir.Items.Add("mardin");
			cbSehir.Items.Add("muðla");
			cbSehir.Items.Add("muþ");
			cbSehir.Items.Add("nevþehir");
			cbSehir.Items.Add("niðde");
			cbSehir.Items.Add("osmaniye");
			cbSehir.Items.Add("rize");
			cbSehir.Items.Add("sakarya");
			cbSehir.Items.Add("samsun");
			cbSehir.Items.Add("siirt");
			cbSehir.Items.Add("sinop");
			cbSehir.Items.Add("sivas");
			cbSehir.Items.Add("trabzon");
			cbSehir.Items.Add("þanlýurfa");
			cbSehir.Items.Add("þýrnak");
			cbSehir.Items.Add("van");
			cbSehir.Items.Add("yozgat");
			cbSehir.Items.Add("yalova");
			cbSehir.Items.Add("zonguldak");

			cbLevel.Items.Add("1");
			cbLevel.Items.Add("2");
			cbLevel.Items.Add("3");
			cbLevel.Items.Add("4");
			cbLevel.Items.Add("5");
			
			SqlConnection yeni = new SqlConnection();
			yeni.ConnectionString = "Data Source=MCY;Integrated Security=SSPI;Initial Catalog=crm";
			SqlDataAdapter verial = new SqlDataAdapter("SELECT Sektor FROM tbl_mk Group By Sektor",yeni);
			DataSet al=new DataSet();
			verial.Fill(al, "tbl_mk");
			DataTable myDataTable = al.Tables["tbl_mk"];
			foreach (DataRow myDataRow  in myDataTable.Rows)
				{
				cbSektor.Items.Add(myDataRow["Sektor"]);
				}
				
			SqlConnection yeni2 = new SqlConnection();
			yeni2.ConnectionString = "Data Source=MCY;Integrated Security=SSPI;Initial Catalog=crm";
			SqlDataAdapter verial2 = new SqlDataAdapter("SELECT * FROM tbl_mk where KartID ='" + KartlarDuzenle.txtTasi + "'",yeni2);
			DataSet al2=new DataSet();
			verial2.Fill(al2,"tbl_mk");
			DataTable myDataTable2 = al2.Tables["tbl_mk"];
			foreach (DataRow myDataRow2  in myDataTable2.Rows)
			{
				txtFIsim.Text=myDataRow2["Isim"].ToString();
				txtTel1.Text=myDataRow2["Tel1"].ToString();
				txtTel2.Text=myDataRow2["Tel2"].ToString();
				txtFax.Text=myDataRow2["Fax"].ToString();
				txtSemt.Text=myDataRow2["Semt"].ToString();
				cbSehir.Text=myDataRow2["Sehir"].ToString();
				txtAdres.Text=myDataRow2["Adres"].ToString();
				txtVerDai.Text=myDataRow2["Vergi"].ToString();
				txtVerNo.Text=myDataRow2["VergiNo"].ToString();
				txtWeb.Text=myDataRow2["Web"].ToString();
				txtFMail.Text=myDataRow2["FirmaMail"].ToString();
				cbSektor.Text=myDataRow2["Sektor"].ToString();
				cbLevel.Text=myDataRow2["Lvel"].ToString();
				txtDep.Text=myDataRow2["Departman"].ToString();
				txtAd.Text=myDataRow2["Ad"].ToString();
				txtSoyad.Text=myDataRow2["Soyad"].ToString();
				txtUnvan.Text=myDataRow2["Unvan"].ToString();
				txtDahili.Text=myDataRow2["Dahili"].ToString();
				txtCepTel.Text=myDataRow2["CepTel"].ToString();
				txtKMail.Text=myDataRow2["KisiMail"].ToString();

			}
		}
			


		private void btnDuzenle_Click(object sender, System.EventArgs e)
		{
			KartlarDuzenle yeni=new KartlarDuzenle();
			yeni.Show();
			this.Hide();

		}

		private void btnSil_Click(object sender, System.EventArgs e)
		{
			KartlarSil yeni=new KartlarSil();
			yeni.Show();
			this.Hide();

		}

		private void btnYeni_Click(object sender, System.EventArgs e)
		{
			KartlarYeni yeni=new KartlarYeni();
			yeni.Show();
			pnlKartlar.Visible=false;
			this.Hide();
		}

		private void button1_Click(object sender, System.EventArgs e)
		{
			cbSektor.SelectedIndex=0;
			cbLevel.SelectedIndex=0;
			cbSehir.SelectedIndex=0;

			DataRow ekle=ds_musteri1.Tables["tbl_mk"].NewRow();
			ekle["Isim"]=txtFIsim.Text;
			ekle["Tel1"]=txtTel1.Text;
			ekle["Tel2"]=txtTel2.Text;
			ekle["Fax"]=txtFax.Text;
			ekle["Semt"]=txtSemt.Text;
			ekle["Sehir"]=cbSehir.Text;
			ekle["Adres"]=txtAdres.Text;
			ekle["Vergi"]=txtVerDai.Text;
			ekle["VergiNo"]=txtVerNo.Text;
			ekle["Web"]=txtWeb.Text;
			ekle["FirmaMail"]=txtFMail.Text;
			ekle["Sektor"]=cbSektor.Text;
			ekle["Lvel"]=cbLevel.Text;
			ekle["Departman"]=txtDep.Text;
			ekle["Ad"]=txtAd.Text;
			ekle["Soyad"]=txtSoyad.Text;
			ekle["Unvan"]=txtUnvan.Text;
			ekle["Dahili"]=txtDahili.Text;
			ekle["CepTel"]=txtCepTel.Text;
			ekle["KisiMail"]=txtKMail.Text;
			ds_musteri1.Tables["tbl_mk"].Rows.Add(ekle);
			sqlDataAdapter1.Update(ds_musteri1,"tbl_mk");

			txtFIsim.Clear();
			txtTel1.Clear();
			txtTel2.Clear();
			txtFax.Clear();
			txtSemt.Clear();
			txtAdres.Clear();
			txtVerDai.Clear();
			txtVerNo.Clear();
			txtWeb.Clear();
			txtFMail.Clear();
			txtDep.Clear();
			txtAd.Clear();
			txtSoyad.Clear();
			txtUnvan.Clear();
			txtDahili.Clear();
			txtCepTel.Clear();
			txtKMail.Clear();
		}

		private void btnCrm_Click(object sender, System.EventArgs e)
		{

			HareketlerYeni yeni=new HareketlerYeni();
			yeni.Show();
			this.Hide();
		}

		private void btnMusteriK_Click(object sender, System.EventArgs e)
		{

			MusteriKayit yeni=new MusteriKayit();
			yeni.Show();
			this.Hide();

		}

		private void button1_Click_1(object sender, System.EventArgs e)
		{
			AdminAnaSayfa yeni=new AdminAnaSayfa();
			yeni.Show();
			this.Hide();
		}

		private void button7_Click(object sender, System.EventArgs e)
		{
			Admin yeni=new Admin();
			yeni.Show();
			this.Hide();
		}

		private void button9_Click(object sender, System.EventArgs e)
		{
			AdminDuzenle yeni=new AdminDuzenle();
			yeni.Show();
			this.Hide();
		}

		private void button8_Click(object sender, System.EventArgs e)
		{
			AdminSil yeni=new AdminSil();
			yeni.Show();
			this.Hide();
		}

		private void btnAltAdmin_Click(object sender, System.EventArgs e)
		{
			pnlKartlar.Visible=false;
			pnlList.Visible=false;
			pnlTeklif.Visible=false;
			pnlCrm.Visible=false;
			pnlAdmin.Visible=true;
		}

		private void KartlarGuncelle_Closed(object sender, System.EventArgs e)
		{
			Application.Exit();
		}

		private void button10_Click(object sender, System.EventArgs e)
		{
			HareketlerYeni yeni=new HareketlerYeni();
			yeni.Show();
			this.Hide();
		}

		private void button11_Click(object sender, System.EventArgs e)
		{
			HareketlerAra yeni=new HareketlerAra();
			yeni.Show();
			this.Hide();
		}

		private void btnTeklifH_Click(object sender, System.EventArgs e)
		{
			TeklifGoruntule yeni=new TeklifGoruntule();
			yeni.Show();
			this.Hide();
		}

		private void btnSiparisG_Click(object sender, System.EventArgs e)
		{
		
		}

		private void btnProjeler_Click(object sender, System.EventArgs e)
		{
		
		}

		private void btnBilgiB_Click(object sender, System.EventArgs e)
		{
		
		}

		private void btnRapor_Click(object sender, System.EventArgs e)
		{
		
		}

		private void btnPSG_Click(object sender, System.EventArgs e)
		{
			PsgAra yeni=new PsgAra();
			yeni.Show();
			this.Hide();

		}

		private void btnCCTV_Click(object sender, System.EventArgs e)
		{
			CctvAra yeni=new CctvAra();
			yeni.Show();
			this.Hide();

		}

		private void btnOEM_Click(object sender, System.EventArgs e)
		{
			OemAra yeni=new OemAra();
			yeni.Show();
			this.Hide();

		}

		private void btnYazýlým_Click(object sender, System.EventArgs e)
		{
			YazilimAra yeni=new YazilimAra();
			yeni.Show();
			this.Hide();

		}

		private void btnServis_Click(object sender, System.EventArgs e)
		{
			ServisAra yeni=new ServisAra();
			yeni.Show();
			this.Hide();

		}

		private void btnLAra_Click(object sender, System.EventArgs e)
		{
			HareketlerAra yeni=new HareketlerAra();
			yeni.Show();
			this.Hide();

		}
		
	}
}
