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
	public class YazilimAra : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Button btnKart;
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
		private System.Windows.Forms.GroupBox gb_Ara;
		private System.Windows.Forms.TextBox txt_DuzAraFIsim;
		private System.Windows.Forms.Button btnDuzKartBul;
		private System.Windows.Forms.DataGrid dg_KartlarAra;
		private System.Windows.Forms.DataGridTableStyle dataGridTableStyle1;
		private System.Windows.Forms.DataGridTextBoxColumn Sektor;
		private System.Windows.Forms.DataGridTextBoxColumn FirmaIsmi;
		private System.Windows.Forms.DataGridTextBoxColumn tel1;
		private System.Windows.Forms.DataGridTextBoxColumn tel2;
		private System.Windows.Forms.DataGridTextBoxColumn fax;
		private System.Windows.Forms.DataGridTextBoxColumn semt;
		private System.Windows.Forms.DataGridTextBoxColumn sehir;
		private System.Windows.Forms.DataGridTextBoxColumn adres;
		private System.Windows.Forms.DataGridTextBoxColumn verdai;
		private System.Windows.Forms.DataGridTextBoxColumn verno;
		private System.Windows.Forms.DataGridTextBoxColumn web;
		private System.Windows.Forms.DataGridTextBoxColumn fmail;
		private System.Windows.Forms.DataGridTextBoxColumn level;
		private System.Windows.Forms.DataGridTextBoxColumn ad;
		private System.Windows.Forms.DataGridTextBoxColumn soyad;
		private System.Windows.Forms.DataGridTextBoxColumn dep;
		private System.Windows.Forms.DataGridTextBoxColumn unvan;
		private System.Windows.Forms.DataGridTextBoxColumn dahili;
		private System.Windows.Forms.DataGridTextBoxColumn cep;
		private System.Windows.Forms.DataGridTextBoxColumn kmail;
		private System.Windows.Forms.DataGridTextBoxColumn tarih;
		private System.Windows.Forms.DataGridTextBoxColumn saat;
		private System.Windows.Forms.DataGridTextBoxColumn id;
		private System.Windows.Forms.Button btnAdmin;
		private System.Windows.Forms.Button btnAltAdmin;
		private System.Windows.Forms.Panel pnlAdmin;
		private System.Windows.Forms.Button button7;
		private System.Windows.Forms.Button button8;
		private System.Windows.Forms.Button button9;
		private System.Windows.Forms.Panel pnlTeklif;
		private System.Windows.Forms.Button btnTeklifGoruntule;
		private System.Windows.Forms.Button btnTeklifYeni;
		private System.Windows.Forms.Button btnTeklifPrint;
		private System.Data.SqlClient.SqlDataAdapter sqlDataAdapter1;
		private System.Data.SqlClient.SqlCommand sqlSelectCommand1;
		private System.Data.SqlClient.SqlCommand sqlInsertCommand1;
		private System.Data.SqlClient.SqlCommand sqlUpdateCommand1;
		private System.Data.SqlClient.SqlCommand sqlDeleteCommand1;
		private System.Data.SqlClient.SqlConnection sqlConnection1;
		private deneme.ds_Hareket ds_Hareket1;
		private deneme.ds_musteri ds_musteri1;
		private deneme.ds_users ds_users1;
		private System.Windows.Forms.Panel pnlCrm;
		private System.Windows.Forms.Button button10;
		private System.Windows.Forms.Button button11;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public YazilimAra()
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
		/// 


		public static string ayrinti;



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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(YazilimAra));
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
			this.btnYeni = new System.Windows.Forms.Button();
			this.btnDuzenle = new System.Windows.Forms.Button();
			this.btnSil = new System.Windows.Forms.Button();
			this.btnKAra = new System.Windows.Forms.Button();
			this.btnRapor = new System.Windows.Forms.Button();
			this.pnlKartlar = new System.Windows.Forms.Panel();
			this.pnlList = new System.Windows.Forms.Panel();
			this.btnLAra = new System.Windows.Forms.Button();
			this.btnServis = new System.Windows.Forms.Button();
			this.btnYazýlým = new System.Windows.Forms.Button();
			this.btnOEM = new System.Windows.Forms.Button();
			this.btnCCTV = new System.Windows.Forms.Button();
			this.btnPSG = new System.Windows.Forms.Button();
			this.gb_Ara = new System.Windows.Forms.GroupBox();
			this.txt_DuzAraFIsim = new System.Windows.Forms.TextBox();
			this.btnDuzKartBul = new System.Windows.Forms.Button();
			this.dg_KartlarAra = new System.Windows.Forms.DataGrid();
			this.dataGridTableStyle1 = new System.Windows.Forms.DataGridTableStyle();
			this.id = new System.Windows.Forms.DataGridTextBoxColumn();
			this.Sektor = new System.Windows.Forms.DataGridTextBoxColumn();
			this.level = new System.Windows.Forms.DataGridTextBoxColumn();
			this.FirmaIsmi = new System.Windows.Forms.DataGridTextBoxColumn();
			this.tel1 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.tel2 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.fax = new System.Windows.Forms.DataGridTextBoxColumn();
			this.adres = new System.Windows.Forms.DataGridTextBoxColumn();
			this.semt = new System.Windows.Forms.DataGridTextBoxColumn();
			this.sehir = new System.Windows.Forms.DataGridTextBoxColumn();
			this.verdai = new System.Windows.Forms.DataGridTextBoxColumn();
			this.verno = new System.Windows.Forms.DataGridTextBoxColumn();
			this.web = new System.Windows.Forms.DataGridTextBoxColumn();
			this.fmail = new System.Windows.Forms.DataGridTextBoxColumn();
			this.ad = new System.Windows.Forms.DataGridTextBoxColumn();
			this.soyad = new System.Windows.Forms.DataGridTextBoxColumn();
			this.unvan = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dep = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dahili = new System.Windows.Forms.DataGridTextBoxColumn();
			this.cep = new System.Windows.Forms.DataGridTextBoxColumn();
			this.kmail = new System.Windows.Forms.DataGridTextBoxColumn();
			this.tarih = new System.Windows.Forms.DataGridTextBoxColumn();
			this.saat = new System.Windows.Forms.DataGridTextBoxColumn();
			this.btnAdmin = new System.Windows.Forms.Button();
			this.btnAltAdmin = new System.Windows.Forms.Button();
			this.pnlAdmin = new System.Windows.Forms.Panel();
			this.button7 = new System.Windows.Forms.Button();
			this.button8 = new System.Windows.Forms.Button();
			this.button9 = new System.Windows.Forms.Button();
			this.pnlTeklif = new System.Windows.Forms.Panel();
			this.btnTeklifGoruntule = new System.Windows.Forms.Button();
			this.btnTeklifYeni = new System.Windows.Forms.Button();
			this.btnTeklifPrint = new System.Windows.Forms.Button();
			this.sqlDataAdapter1 = new System.Data.SqlClient.SqlDataAdapter();
			this.sqlDeleteCommand1 = new System.Data.SqlClient.SqlCommand();
			this.sqlConnection1 = new System.Data.SqlClient.SqlConnection();
			this.sqlInsertCommand1 = new System.Data.SqlClient.SqlCommand();
			this.sqlSelectCommand1 = new System.Data.SqlClient.SqlCommand();
			this.sqlUpdateCommand1 = new System.Data.SqlClient.SqlCommand();
			this.ds_Hareket1 = new deneme.ds_Hareket();
			this.ds_musteri1 = new deneme.ds_musteri();
			this.ds_users1 = new deneme.ds_users();
			this.pnlCrm = new System.Windows.Forms.Panel();
			this.button10 = new System.Windows.Forms.Button();
			this.button11 = new System.Windows.Forms.Button();
			this.pnlKartlar.SuspendLayout();
			this.pnlList.SuspendLayout();
			this.gb_Ara.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dg_KartlarAra)).BeginInit();
			this.pnlAdmin.SuspendLayout();
			this.pnlTeklif.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.ds_Hareket1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ds_musteri1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ds_users1)).BeginInit();
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
			this.pnlKartlar.Visible = false;
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
			// gb_Ara
			// 
			this.gb_Ara.Controls.Add(this.txt_DuzAraFIsim);
			this.gb_Ara.Controls.Add(this.btnDuzKartBul);
			this.gb_Ara.Location = new System.Drawing.Point(216, 152);
			this.gb_Ara.Name = "gb_Ara";
			this.gb_Ara.Size = new System.Drawing.Size(536, 96);
			this.gb_Ara.TabIndex = 51;
			this.gb_Ara.TabStop = false;
			this.gb_Ara.Text = "Düzenle";
			// 
			// txt_DuzAraFIsim
			// 
			this.txt_DuzAraFIsim.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(162)));
			this.txt_DuzAraFIsim.Location = new System.Drawing.Point(32, 40);
			this.txt_DuzAraFIsim.Name = "txt_DuzAraFIsim";
			this.txt_DuzAraFIsim.Size = new System.Drawing.Size(352, 22);
			this.txt_DuzAraFIsim.TabIndex = 33;
			this.txt_DuzAraFIsim.Text = "";
			// 
			// btnDuzKartBul
			// 
			this.btnDuzKartBul.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(162)));
			this.btnDuzKartBul.ForeColor = System.Drawing.SystemColors.ControlText;
			this.btnDuzKartBul.Location = new System.Drawing.Point(400, 40);
			this.btnDuzKartBul.Name = "btnDuzKartBul";
			this.btnDuzKartBul.Size = new System.Drawing.Size(104, 24);
			this.btnDuzKartBul.TabIndex = 46;
			this.btnDuzKartBul.Text = "Hareketler  Bul";
			this.btnDuzKartBul.Click += new System.EventHandler(this.btnDuzKartBul_Click);
			// 
			// dg_KartlarAra
			// 
			this.dg_KartlarAra.CaptionText = "HAREKETLER";
			this.dg_KartlarAra.DataMember = "";
			this.dg_KartlarAra.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.dg_KartlarAra.Location = new System.Drawing.Point(168, 272);
			this.dg_KartlarAra.Name = "dg_KartlarAra";
			this.dg_KartlarAra.ReadOnly = true;
			this.dg_KartlarAra.Size = new System.Drawing.Size(808, 384);
			this.dg_KartlarAra.TabIndex = 52;
			this.dg_KartlarAra.TableStyles.AddRange(new System.Windows.Forms.DataGridTableStyle[] {
																									  this.dataGridTableStyle1});
			this.dg_KartlarAra.MouseDown += new System.Windows.Forms.MouseEventHandler(this.myDataGrid_MouseDown);
			// 
			// dataGridTableStyle1
			// 
			this.dataGridTableStyle1.AlternatingBackColor = System.Drawing.Color.LightGray;
			this.dataGridTableStyle1.DataGrid = this.dg_KartlarAra;
			this.dataGridTableStyle1.GridColumnStyles.AddRange(new System.Windows.Forms.DataGridColumnStyle[] {
																												  this.id,
																												  this.Sektor,
																												  this.level,
																												  this.FirmaIsmi,
																												  this.tel1,
																												  this.tel2,
																												  this.fax,
																												  this.adres,
																												  this.semt,
																												  this.sehir,
																												  this.verdai,
																												  this.verno,
																												  this.web,
																												  this.fmail,
																												  this.ad,
																												  this.soyad,
																												  this.unvan,
																												  this.dep,
																												  this.dahili,
																												  this.cep,
																												  this.kmail,
																												  this.tarih,
																												  this.saat});
			this.dataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.dataGridTableStyle1.MappingName = "tbl_mk";
			// 
			// id
			// 
			this.id.Format = "";
			this.id.FormatInfo = null;
			this.id.HeaderText = "ID";
			this.id.MappingName = "KartID";
			this.id.Width = 0;
			// 
			// Sektor
			// 
			this.Sektor.Format = "";
			this.Sektor.FormatInfo = null;
			this.Sektor.HeaderText = "Sektor";
			this.Sektor.MappingName = "Sektor";
			this.Sektor.Width = 50;
			// 
			// level
			// 
			this.level.Format = "";
			this.level.FormatInfo = null;
			this.level.HeaderText = "Level";
			this.level.MappingName = "Lvel";
			this.level.Width = 35;
			// 
			// FirmaIsmi
			// 
			this.FirmaIsmi.Format = "";
			this.FirmaIsmi.FormatInfo = null;
			this.FirmaIsmi.HeaderText = "Firma Ýsmi";
			this.FirmaIsmi.MappingName = "Isim";
			this.FirmaIsmi.Width = 150;
			// 
			// tel1
			// 
			this.tel1.Format = "";
			this.tel1.FormatInfo = null;
			this.tel1.HeaderText = "Firma Tel 1";
			this.tel1.MappingName = "Tel1";
			this.tel1.Width = 75;
			// 
			// tel2
			// 
			this.tel2.Format = "";
			this.tel2.FormatInfo = null;
			this.tel2.HeaderText = "Firma Tel 2";
			this.tel2.MappingName = "Tel2";
			this.tel2.Width = 75;
			// 
			// fax
			// 
			this.fax.Format = "";
			this.fax.FormatInfo = null;
			this.fax.HeaderText = "Firma Fax";
			this.fax.MappingName = "Fax";
			this.fax.Width = 75;
			// 
			// adres
			// 
			this.adres.Format = "";
			this.adres.FormatInfo = null;
			this.adres.HeaderText = "Adres";
			this.adres.MappingName = "Adres";
			this.adres.Width = 200;
			// 
			// semt
			// 
			this.semt.Format = "";
			this.semt.FormatInfo = null;
			this.semt.HeaderText = "Semt";
			this.semt.MappingName = "Semt";
			this.semt.Width = 75;
			// 
			// sehir
			// 
			this.sehir.Format = "";
			this.sehir.FormatInfo = null;
			this.sehir.HeaderText = "Sehir";
			this.sehir.MappingName = "Sehir";
			this.sehir.Width = 75;
			// 
			// verdai
			// 
			this.verdai.Format = "";
			this.verdai.FormatInfo = null;
			this.verdai.HeaderText = "Vergi Dairesi";
			this.verdai.MappingName = "Vergi";
			this.verdai.Width = 120;
			// 
			// verno
			// 
			this.verno.Format = "";
			this.verno.FormatInfo = null;
			this.verno.HeaderText = "Vergi Numarasý";
			this.verno.MappingName = "VergiNo";
			this.verno.Width = 75;
			// 
			// web
			// 
			this.web.Format = "";
			this.web.FormatInfo = null;
			this.web.HeaderText = "Web Adresi";
			this.web.MappingName = "Web";
			this.web.Width = 200;
			// 
			// fmail
			// 
			this.fmail.Format = "";
			this.fmail.FormatInfo = null;
			this.fmail.HeaderText = "Firma E-mail";
			this.fmail.MappingName = "FirmaMail";
			this.fmail.Width = 200;
			// 
			// ad
			// 
			this.ad.Format = "";
			this.ad.FormatInfo = null;
			this.ad.HeaderText = "Kiþi Adý";
			this.ad.MappingName = "Ad";
			this.ad.Width = 75;
			// 
			// soyad
			// 
			this.soyad.Format = "";
			this.soyad.FormatInfo = null;
			this.soyad.HeaderText = "Kiþi Soyadý";
			this.soyad.MappingName = "Soyad";
			this.soyad.Width = 90;
			// 
			// unvan
			// 
			this.unvan.Format = "";
			this.unvan.FormatInfo = null;
			this.unvan.HeaderText = "Ünvaný";
			this.unvan.MappingName = "Unvan";
			this.unvan.Width = 75;
			// 
			// dep
			// 
			this.dep.Format = "";
			this.dep.FormatInfo = null;
			this.dep.HeaderText = "Departman";
			this.dep.MappingName = "Departman";
			this.dep.Width = 75;
			// 
			// dahili
			// 
			this.dahili.Format = "";
			this.dahili.FormatInfo = null;
			this.dahili.HeaderText = "Dahilisi";
			this.dahili.MappingName = "Dahili";
			this.dahili.Width = 45;
			// 
			// cep
			// 
			this.cep.Format = "";
			this.cep.FormatInfo = null;
			this.cep.HeaderText = "Cep Telefonu";
			this.cep.MappingName = "CepTel";
			this.cep.Width = 75;
			// 
			// kmail
			// 
			this.kmail.Format = "";
			this.kmail.FormatInfo = null;
			this.kmail.HeaderText = "Kiþi E-Mail";
			this.kmail.MappingName = "KisiMail";
			this.kmail.Width = 200;
			// 
			// tarih
			// 
			this.tarih.Format = "";
			this.tarih.FormatInfo = null;
			this.tarih.HeaderText = "Tarih";
			this.tarih.MappingName = "Tarih";
			this.tarih.Width = 75;
			// 
			// saat
			// 
			this.saat.Format = "HH:mm:ss";
			this.saat.FormatInfo = null;
			this.saat.HeaderText = "Saat";
			this.saat.MappingName = "Saat";
			this.saat.Width = 75;
			// 
			// btnAdmin
			// 
			this.btnAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(162)));
			this.btnAdmin.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
			this.btnAdmin.Location = new System.Drawing.Point(48, 568);
			this.btnAdmin.Name = "btnAdmin";
			this.btnAdmin.Size = new System.Drawing.Size(80, 50);
			this.btnAdmin.TabIndex = 78;
			this.btnAdmin.Text = "Admin";
			this.btnAdmin.Click += new System.EventHandler(this.btnAdmin_Click);
			// 
			// btnAltAdmin
			// 
			this.btnAltAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnAltAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(162)));
			this.btnAltAdmin.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
			this.btnAltAdmin.Location = new System.Drawing.Point(744, 32);
			this.btnAltAdmin.Name = "btnAltAdmin";
			this.btnAltAdmin.Size = new System.Drawing.Size(75, 30);
			this.btnAltAdmin.TabIndex = 80;
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
			this.pnlAdmin.TabIndex = 81;
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
			// pnlTeklif
			// 
			this.pnlTeklif.Controls.Add(this.btnTeklifGoruntule);
			this.pnlTeklif.Controls.Add(this.btnTeklifYeni);
			this.pnlTeklif.Controls.Add(this.btnTeklifPrint);
			this.pnlTeklif.Location = new System.Drawing.Point(472, 72);
			this.pnlTeklif.Name = "pnlTeklif";
			this.pnlTeklif.Size = new System.Drawing.Size(272, 48);
			this.pnlTeklif.TabIndex = 101;
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
			// sqlDataAdapter1
			// 
			this.sqlDataAdapter1.DeleteCommand = this.sqlDeleteCommand1;
			this.sqlDataAdapter1.InsertCommand = this.sqlInsertCommand1;
			this.sqlDataAdapter1.SelectCommand = this.sqlSelectCommand1;
			this.sqlDataAdapter1.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
																									  new System.Data.Common.DataTableMapping("Table", "tbl_hareket", new System.Data.Common.DataColumnMapping[] {
																																																					 new System.Data.Common.DataColumnMapping("HareketID", "HareketID"),
																																																					 new System.Data.Common.DataColumnMapping("Tarih", "Tarih"),
																																																					 new System.Data.Common.DataColumnMapping("Saat", "Saat"),
																																																					 new System.Data.Common.DataColumnMapping("Sil", "Sil"),
																																																					 new System.Data.Common.DataColumnMapping("KartID", "KartID"),
																																																					 new System.Data.Common.DataColumnMapping("HarTur", "HarTur"),
																																																					 new System.Data.Common.DataColumnMapping("HarYonu", "HarYonu"),
																																																					 new System.Data.Common.DataColumnMapping("Iletisim", "Iletisim"),
																																																					 new System.Data.Common.DataColumnMapping("AraSonuc", "AraSonuc"),
																																																					 new System.Data.Common.DataColumnMapping("Konu", "Konu"),
																																																					 new System.Data.Common.DataColumnMapping("Gorusme", "Gorusme"),
																																																					 new System.Data.Common.DataColumnMapping("GorTarih", "GorTarih"),
																																																					 new System.Data.Common.DataColumnMapping("GorZaman", "GorZaman"),
																																																					 new System.Data.Common.DataColumnMapping("GorDurum", "GorDurum"),
																																																					 new System.Data.Common.DataColumnMapping("GorSonuc", "GorSonuc"),
																																																					 new System.Data.Common.DataColumnMapping("GorNot", "GorNot"),
																																																					 new System.Data.Common.DataColumnMapping("Admin", "Admin"),
																																																					 new System.Data.Common.DataColumnMapping("HarDurum", "HarDurum"),
																																																					 new System.Data.Common.DataColumnMapping("SonYonu", "SonYonu"),
																																																					 new System.Data.Common.DataColumnMapping("Users", "Users"),
																																																					 new System.Data.Common.DataColumnMapping("UserName", "UserName")})});
			this.sqlDataAdapter1.UpdateCommand = this.sqlUpdateCommand1;
			// 
			// sqlDeleteCommand1
			// 
			this.sqlDeleteCommand1.CommandText = @"DELETE FROM tbl_hareket WHERE (HareketID = @Original_HareketID) AND (Admin = @Original_Admin) AND (AraSonuc = @Original_AraSonuc) AND (GorDurum = @Original_GorDurum) AND (GorNot = @Original_GorNot) AND (GorSonuc = @Original_GorSonuc) AND (GorTarih = @Original_GorTarih OR @Original_GorTarih IS NULL AND GorTarih IS NULL) AND (GorZaman = @Original_GorZaman OR @Original_GorZaman IS NULL AND GorZaman IS NULL) AND (Gorusme = @Original_Gorusme) AND (HarDurum = @Original_HarDurum) AND (HarTur = @Original_HarTur) AND (HarYonu = @Original_HarYonu) AND (Iletisim = @Original_Iletisim) AND (KartID = @Original_KartID) AND (Konu = @Original_Konu) AND (Saat = @Original_Saat OR @Original_Saat IS NULL AND Saat IS NULL) AND (Sil = @Original_Sil) AND (SonYonu = @Original_SonYonu) AND (Tarih = @Original_Tarih OR @Original_Tarih IS NULL AND Tarih IS NULL) AND (UserName = @Original_UserName) AND (Users = @Original_Users)";
			this.sqlDeleteCommand1.Connection = this.sqlConnection1;
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_HareketID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "HareketID", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_Admin", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Admin", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_AraSonuc", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "AraSonuc", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_GorDurum", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "GorDurum", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_GorNot", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "GorNot", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_GorSonuc", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "GorSonuc", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_GorTarih", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "GorTarih", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_GorZaman", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "GorZaman", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_Gorusme", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Gorusme", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_HarDurum", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "HarDurum", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_HarTur", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "HarTur", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_HarYonu", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "HarYonu", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_Iletisim", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Iletisim", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_KartID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "KartID", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_Konu", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Konu", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_Saat", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Saat", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_Sil", System.Data.SqlDbType.TinyInt, 1, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Sil", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_SonYonu", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "SonYonu", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_Tarih", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Tarih", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_UserName", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "UserName", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_Users", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Users", System.Data.DataRowVersion.Original, null));
			// 
			// sqlConnection1
			// 
			this.sqlConnection1.ConnectionString = "workstation id=MCY;packet size=4096;integrated security=SSPI;data source=MCY;pers" +
				"ist security info=False;initial catalog=crm";
			// 
			// sqlInsertCommand1
			// 
			this.sqlInsertCommand1.CommandText = @"INSERT INTO tbl_hareket(Tarih, Saat, Sil, KartID, HarTur, HarYonu, Iletisim, AraSonuc, Konu, Gorusme, GorTarih, GorZaman, GorDurum, GorSonuc, GorNot, Admin, HarDurum, SonYonu, Users, UserName) VALUES (@Tarih, @Saat, @Sil, @KartID, @HarTur, @HarYonu, @Iletisim, @AraSonuc, @Konu, @Gorusme, @GorTarih, @GorZaman, @GorDurum, @GorSonuc, @GorNot, @Admin, @HarDurum, @SonYonu, @Users, @UserName); SELECT HareketID, Tarih, Saat, Sil, KartID, HarTur, HarYonu, Iletisim, AraSonuc, Konu, Gorusme, GorTarih, GorZaman, GorDurum, GorSonuc, GorNot, Admin, HarDurum, SonYonu, Users, UserName FROM tbl_hareket WHERE (HareketID = @@IDENTITY)";
			this.sqlInsertCommand1.Connection = this.sqlConnection1;
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Tarih", System.Data.SqlDbType.DateTime, 8, "Tarih"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Saat", System.Data.SqlDbType.DateTime, 8, "Saat"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Sil", System.Data.SqlDbType.TinyInt, 1, "Sil"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@KartID", System.Data.SqlDbType.Int, 4, "KartID"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@HarTur", System.Data.SqlDbType.VarChar, 50, "HarTur"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@HarYonu", System.Data.SqlDbType.Int, 4, "HarYonu"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Iletisim", System.Data.SqlDbType.VarChar, 50, "Iletisim"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@AraSonuc", System.Data.SqlDbType.VarChar, 255, "AraSonuc"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Konu", System.Data.SqlDbType.VarChar, 255, "Konu"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Gorusme", System.Data.SqlDbType.Int, 4, "Gorusme"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@GorTarih", System.Data.SqlDbType.DateTime, 8, "GorTarih"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@GorZaman", System.Data.SqlDbType.DateTime, 8, "GorZaman"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@GorDurum", System.Data.SqlDbType.VarChar, 255, "GorDurum"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@GorSonuc", System.Data.SqlDbType.VarChar, 255, "GorSonuc"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@GorNot", System.Data.SqlDbType.VarChar, 255, "GorNot"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Admin", System.Data.SqlDbType.VarChar, 255, "Admin"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@HarDurum", System.Data.SqlDbType.VarChar, 255, "HarDurum"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@SonYonu", System.Data.SqlDbType.Int, 4, "SonYonu"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Users", System.Data.SqlDbType.Int, 4, "Users"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@UserName", System.Data.SqlDbType.VarChar, 50, "UserName"));
			// 
			// sqlSelectCommand1
			// 
			this.sqlSelectCommand1.CommandText = "SELECT HareketID, Tarih, Saat, Sil, KartID, HarTur, HarYonu, Iletisim, AraSonuc, " +
				"Konu, Gorusme, GorTarih, GorZaman, GorDurum, GorSonuc, GorNot, Admin, HarDurum, " +
				"SonYonu, Users, UserName FROM tbl_hareket";
			this.sqlSelectCommand1.Connection = this.sqlConnection1;
			// 
			// sqlUpdateCommand1
			// 
			this.sqlUpdateCommand1.CommandText = "UPDATE tbl_hareket SET Tarih = @Tarih, Saat = @Saat, Sil = @Sil, KartID = @KartID" +
				", HarTur = @HarTur, HarYonu = @HarYonu, Iletisim = @Iletisim, AraSonuc = @AraSon" +
				"uc, Konu = @Konu, Gorusme = @Gorusme, GorTarih = @GorTarih, GorZaman = @GorZaman" +
				", GorDurum = @GorDurum, GorSonuc = @GorSonuc, GorNot = @GorNot, Admin = @Admin, " +
				"HarDurum = @HarDurum, SonYonu = @SonYonu, Users = @Users, UserName = @UserName W" +
				"HERE (HareketID = @Original_HareketID) AND (Admin = @Original_Admin) AND (AraSon" +
				"uc = @Original_AraSonuc) AND (GorDurum = @Original_GorDurum) AND (GorNot = @Orig" +
				"inal_GorNot) AND (GorSonuc = @Original_GorSonuc) AND (GorTarih = @Original_GorTa" +
				"rih OR @Original_GorTarih IS NULL AND GorTarih IS NULL) AND (GorZaman = @Origina" +
				"l_GorZaman OR @Original_GorZaman IS NULL AND GorZaman IS NULL) AND (Gorusme = @O" +
				"riginal_Gorusme) AND (HarDurum = @Original_HarDurum) AND (HarTur = @Original_Har" +
				"Tur) AND (HarYonu = @Original_HarYonu) AND (Iletisim = @Original_Iletisim) AND (" +
				"KartID = @Original_KartID) AND (Konu = @Original_Konu) AND (Saat = @Original_Saa" +
				"t OR @Original_Saat IS NULL AND Saat IS NULL) AND (Sil = @Original_Sil) AND (Son" +
				"Yonu = @Original_SonYonu) AND (Tarih = @Original_Tarih OR @Original_Tarih IS NUL" +
				"L AND Tarih IS NULL) AND (UserName = @Original_UserName) AND (Users = @Original_" +
				"Users); SELECT HareketID, Tarih, Saat, Sil, KartID, HarTur, HarYonu, Iletisim, A" +
				"raSonuc, Konu, Gorusme, GorTarih, GorZaman, GorDurum, GorSonuc, GorNot, Admin, H" +
				"arDurum, SonYonu, Users, UserName FROM tbl_hareket WHERE (HareketID = @HareketID" +
				")";
			this.sqlUpdateCommand1.Connection = this.sqlConnection1;
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Tarih", System.Data.SqlDbType.DateTime, 8, "Tarih"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Saat", System.Data.SqlDbType.DateTime, 8, "Saat"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Sil", System.Data.SqlDbType.TinyInt, 1, "Sil"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@KartID", System.Data.SqlDbType.Int, 4, "KartID"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@HarTur", System.Data.SqlDbType.VarChar, 50, "HarTur"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@HarYonu", System.Data.SqlDbType.Int, 4, "HarYonu"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Iletisim", System.Data.SqlDbType.VarChar, 50, "Iletisim"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@AraSonuc", System.Data.SqlDbType.VarChar, 255, "AraSonuc"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Konu", System.Data.SqlDbType.VarChar, 255, "Konu"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Gorusme", System.Data.SqlDbType.Int, 4, "Gorusme"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@GorTarih", System.Data.SqlDbType.DateTime, 8, "GorTarih"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@GorZaman", System.Data.SqlDbType.DateTime, 8, "GorZaman"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@GorDurum", System.Data.SqlDbType.VarChar, 255, "GorDurum"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@GorSonuc", System.Data.SqlDbType.VarChar, 255, "GorSonuc"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@GorNot", System.Data.SqlDbType.VarChar, 255, "GorNot"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Admin", System.Data.SqlDbType.VarChar, 255, "Admin"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@HarDurum", System.Data.SqlDbType.VarChar, 255, "HarDurum"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@SonYonu", System.Data.SqlDbType.Int, 4, "SonYonu"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Users", System.Data.SqlDbType.Int, 4, "Users"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@UserName", System.Data.SqlDbType.VarChar, 50, "UserName"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_HareketID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "HareketID", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_Admin", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Admin", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_AraSonuc", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "AraSonuc", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_GorDurum", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "GorDurum", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_GorNot", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "GorNot", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_GorSonuc", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "GorSonuc", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_GorTarih", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "GorTarih", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_GorZaman", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "GorZaman", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_Gorusme", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Gorusme", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_HarDurum", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "HarDurum", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_HarTur", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "HarTur", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_HarYonu", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "HarYonu", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_Iletisim", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Iletisim", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_KartID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "KartID", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_Konu", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Konu", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_Saat", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Saat", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_Sil", System.Data.SqlDbType.TinyInt, 1, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Sil", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_SonYonu", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "SonYonu", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_Tarih", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Tarih", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_UserName", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "UserName", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_Users", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Users", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@HareketID", System.Data.SqlDbType.Int, 4, "HareketID"));
			// 
			// ds_Hareket1
			// 
			this.ds_Hareket1.DataSetName = "ds_Hareket";
			this.ds_Hareket1.Locale = new System.Globalization.CultureInfo("tr-TR");
			// 
			// ds_musteri1
			// 
			this.ds_musteri1.DataSetName = "ds_musteri";
			this.ds_musteri1.Locale = new System.Globalization.CultureInfo("tr-TR");
			// 
			// ds_users1
			// 
			this.ds_users1.DataSetName = "ds_users";
			this.ds_users1.Locale = new System.Globalization.CultureInfo("tr-TR");
			// 
			// pnlCrm
			// 
			this.pnlCrm.Controls.Add(this.button10);
			this.pnlCrm.Controls.Add(this.button11);
			this.pnlCrm.Location = new System.Drawing.Point(384, 72);
			this.pnlCrm.Name = "pnlCrm";
			this.pnlCrm.Size = new System.Drawing.Size(176, 48);
			this.pnlCrm.TabIndex = 105;
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
			// YazilimAra
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.BackColor = System.Drawing.Color.PaleGoldenrod;
			this.ClientSize = new System.Drawing.Size(1016, 741);
			this.Controls.Add(this.pnlCrm);
			this.Controls.Add(this.pnlTeklif);
			this.Controls.Add(this.pnlAdmin);
			this.Controls.Add(this.btnAltAdmin);
			this.Controls.Add(this.btnAdmin);
			this.Controls.Add(this.dg_KartlarAra);
			this.Controls.Add(this.gb_Ara);
			this.Controls.Add(this.pnlList);
			this.Controls.Add(this.pnlKartlar);
			this.Controls.Add(this.btnRapor);
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
			this.Name = "YazilimAra";
			this.Text = "Novateknik CRM";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.Ara_Load);
			this.Closed += new System.EventHandler(this.Ara_Closed);
			this.pnlKartlar.ResumeLayout(false);
			this.pnlList.ResumeLayout(false);
			this.gb_Ara.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dg_KartlarAra)).EndInit();
			this.pnlAdmin.ResumeLayout(false);
			this.pnlTeklif.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.ds_Hareket1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ds_musteri1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ds_users1)).EndInit();
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
			pnlAdmin.Visible=false;
			pnlTeklif.Visible=false;
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
			pnlCrm.Visible=false;
			pnlList.Visible=false;
			pnlTeklif.Visible=false;
			pnlAdmin.Visible=false;
		}

		private void btnYeni_Click(object sender, System.EventArgs e)
		{
			KartlarYeni yeni=new KartlarYeni();
			yeni.Show();
			pnlKartlar.Visible=false;
			this.Hide();

		}

		private void btnMusteriK_Click(object sender, System.EventArgs e)
		{
			pnlKartlar.Visible=false;
			pnlList.Visible=false;
			MusteriKayit yeni=new MusteriKayit();
			yeni.Show();
			this.Hide();

		}

		private void btnCrm_Click(object sender, System.EventArgs e)
		{

			HareketlerAna yeni=new HareketlerAna();
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
			pnlKartlar.Visible=false;
			pnlList.Visible=false;
		}

		private void btnProjeler_Click(object sender, System.EventArgs e)
		{
			pnlKartlar.Visible=false;
			pnlList.Visible=false;
		}

		private void btnBilgiB_Click(object sender, System.EventArgs e)
		{
			pnlKartlar.Visible=false;
			pnlList.Visible=false;
		}

		private void btnRapor_Click(object sender, System.EventArgs e)
		{
			pnlKartlar.Visible=false;
			pnlList.Visible=false;
		}

		private void btnDuzenle_Click(object sender, System.EventArgs e)
		{
			KartlarDuzenle yeni =new KartlarDuzenle();
			yeni.Show();
			this.Hide();

		}

		private void btnSil_Click(object sender, System.EventArgs e)
		{
			KartlarSil yeni=new KartlarSil();
			yeni.Show();
			this.Hide();
		}

		private void btnKAra_Click(object sender, System.EventArgs e)
		{
			MessageBox.Show(this,"Zaten kart arama Sayfasýndasýnýz.","Hata Yaptýnýz");
		}

		private void btnDuzKartBul_Click(object sender, System.EventArgs e)
		{

			SqlConnection yeni = new SqlConnection();
			yeni.ConnectionString = "Data Source=MCY;Integrated Security=SSPI;Initial Catalog=crm";
			SqlDataAdapter verial =new SqlDataAdapter("SELECT tbl_hareket.HareketID[Hareket ID],tbl_hareket.KartID[Kart ID],tbl_hareket.HarTur[Hareketin Türü],tbl_mk.Isim[Firma Ýsmi],tbl_.hareket.Konu[Hareketin Konusu],Convert(varchar,datepart(day,tbl_hareket.Tarih))+':'+Convert(varchar,datepart(month,tbl_hareket.Tarih))+':'+Convert(varchar,datepart(year,tbl_hareket.Tarih))[Hareket Tarihi],Convert(varchar,datepart(hour,tbl_hareket.Saat))+':'+Convert(varchar,datepart(minute,tbl_hareket.Saat))[Hareket Saati],tbl_hareket.UserName FROM tbl_mk,tbl_hareket WHERE tbl_mk.KartID=tbl_hareket.KartID AND tbl_hareket.Sil='1' AND (tbl_hareket.UserName like '%" + txt_DuzAraFIsim.Text + "%' or tbl_mk.Isim like '%" + txt_DuzAraFIsim.Text + "%' or tbl_hareket.Konu like '%" + txt_DuzAraFIsim.Text + "%' or tbl_hareket.Konu like '%" + txt_DuzAraFIsim.Text + "%') and HarTur='Yazýlým' ORDER BY tbl_hareket.HareketID DESC",yeni);
			DataSet al=new DataSet();
			verial.Fill(al,"tbl_hareket");
			dg_KartlarAra.DataSource=al.Tables[0];
			

		}

		private void Ara_Load(object sender, System.EventArgs e)
		{
			
			if(Giris.yetki=="1")
			{
				btnAdmin.Visible=false;
				btnAltAdmin.Visible=false;
			}
			
			SqlConnection yeni = new SqlConnection();
			yeni.ConnectionString = "Data Source=MCY;Integrated Security=SSPI;Initial Catalog=crm";
			SqlDataAdapter verial =new SqlDataAdapter("SELECT tbl_hareket.HareketID[Hareket ID],tbl_hareket.KartID[Kart ID],tbl_hareket.HarTur[Hareketin Türü],tbl_mk.Isim[Firma Ýsmi],tbl_.hareket.Konu[Hareketin Konusu],Convert(varchar,datepart(day,tbl_hareket.Tarih))+':'+Convert(varchar,datepart(month,tbl_hareket.Tarih))+':'+Convert(varchar,datepart(year,tbl_hareket.Tarih))[Hareket Tarihi],Convert(varchar,datepart(hour,tbl_hareket.Saat))+':'+Convert(varchar,datepart(minute,tbl_hareket.Saat))[Hareket Saati],tbl_hareket.UserName FROM tbl_mk,tbl_hareket Where tbl_mk.KartID=tbl_hareket.KartID and tbl_hareket.Sil='1' and HarTur='Yazýlým' ORDER BY tbl_hareket.HareketID DESC",yeni);
			DataSet al=new DataSet();
			verial.Fill(al,"tbl_hareket");
			dg_KartlarAra.DataSource=al.Tables[0];
			DataGridTableStyle stil = new DataGridTableStyle();
			stil.MappingName = al.Tables[0].TableName;
			stil.AlternatingBackColor =Color.LightGray;
			dg_KartlarAra.TableStyles.Add(stil);
			GridColumnStylesCollection kolonStil = stil.GridColumnStyles;
			kolonStil["Hareket ID"].Width=0;
			kolonStil["Kart ID"].Width=0;
			kolonStil["Hareketin Türü"].Width=80;
			kolonStil["Firma Ýsmi"].Width=175;
			kolonStil["Hareketin Konusu"].Width=250;
			kolonStil["Hareket Tarihi"].Width=80;
			kolonStil["Hareket Saati"].Width=80;
			kolonStil["UserName"].Width=80;
			
		}

		
		private void myDataGrid_MouseDown(object sender, 
			System.Windows.Forms.MouseEventArgs e)
		{
			/*
			DataGrid myGrid = (DataGrid) sender;
			System.Windows.Forms.DataGrid.HitTestInfo hti;
			hti = myGrid.HitTest(e.X, e.Y);
			string message = "You clicked ";

			switch (hti.Type) 
			{
				case System.Windows.Forms.DataGrid.HitTestType.None :
					message += "the background.";
					break;
				case System.Windows.Forms.DataGrid.HitTestType.Cell :
					message += "cell at row " + hti.Row + ", col " + hti.Column;
					break;
				case System.Windows.Forms.DataGrid.HitTestType.ColumnHeader :
					message += "the column header for column " + hti.Column;
					break;
				case System.Windows.Forms.DataGrid.HitTestType.RowHeader :
					message += "the row header for row " + hti.Row;
					break;
				case System.Windows.Forms.DataGrid.HitTestType.ColumnResize :
					message += "the column resizer for column " + hti.Column;
					break;
				case System.Windows.Forms.DataGrid.HitTestType.RowResize :
					message += "the row resizer for row " + hti.Row;
					break;
				case System.Windows.Forms.DataGrid.HitTestType.Caption :
					message += "the caption";
					break;
				case System.Windows.Forms.DataGrid.HitTestType.ParentRows :
					message += "the parent row";
					break;
			}
			if(hti.Row>-1)
			{
				ayrinti = dg_KartlarAra[hti.Row,0].ToString();

				Console.WriteLine(message);
			}
			*/
		}

		private void btnAyrinti_Click(object sender, System.EventArgs e)
		{
			KartlarAyrinti yeni=new KartlarAyrinti();
			yeni.Show();
			this.Hide();


		}

		private void btnAdmin_Click(object sender, System.EventArgs e)
		{
			AdminAnaSayfa yeni=new AdminAnaSayfa();
			yeni.Show();
			this.Hide();

		}

		private void btnAltAdmin_Click(object sender, System.EventArgs e)
		{
			pnlList.Visible=false;
			pnlCrm.Visible=false;
			pnlKartlar.Visible=false;
			pnlTeklif.Visible=false;
			pnlAdmin.Visible=true;
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

		private void Ara_Closed(object sender, System.EventArgs e)
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
			MessageBox.Show(this,"Zaten Hareket Arama Sayfasýndasýnýz.","HATA");
		}

		private void btnYazýlým_Click(object sender, System.EventArgs e)
		{
			MessageBox.Show(this,"Zaten Yazilim Listeleme Sayfasýndasýnýz.","HATA");
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
