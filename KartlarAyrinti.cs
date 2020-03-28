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
	public class KartlarAyrinti : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Button btnKart;
		private System.Windows.Forms.Button btnYeni;
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
		private System.Windows.Forms.Button btnKDuzenle;
		private System.Windows.Forms.Button btnKSil;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label23;
		private System.Windows.Forms.Label label24;
		private System.Windows.Forms.Label label26;
		private System.Windows.Forms.Label label27;
		private System.Windows.Forms.Label label28;
		private System.Windows.Forms.Label label29;
		private System.Windows.Forms.Label label31;
		private System.Windows.Forms.Label label32;
		private System.Windows.Forms.Label label33;
		private System.Windows.Forms.Label lblFIsim;
		private System.Windows.Forms.Label lblTel1;
		private System.Windows.Forms.Label lblTel2;
		private System.Windows.Forms.Label lblFax;
		private System.Windows.Forms.Label lblSemt;
		private System.Windows.Forms.Label lblSehir;
		private System.Windows.Forms.Label lblAdres;
		private System.Windows.Forms.Label lblVerDai;
		private System.Windows.Forms.Label lblVerNo;
		private System.Windows.Forms.Label lblWeb;
		private System.Windows.Forms.Label lblFmail;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.Label lblCepTel;
		private System.Windows.Forms.Label lblKmail;
		private System.Windows.Forms.Label lblAd;
		private System.Windows.Forms.Label lblSoyad;
		private System.Windows.Forms.Label lblUnvan;
		private System.Windows.Forms.Label lblDahili;
		private System.Windows.Forms.Label lblDep;
		private System.Windows.Forms.Label lblLevel;
		private System.Windows.Forms.Label lblSektor;
		private System.Data.SqlClient.SqlDataAdapter sqlDataAdapter1;
		private System.Data.SqlClient.SqlCommand sqlSelectCommand1;
		private System.Data.SqlClient.SqlCommand sqlInsertCommand1;
		private System.Data.SqlClient.SqlCommand sqlUpdateCommand1;
		private System.Data.SqlClient.SqlCommand sqlDeleteCommand1;
		private System.Data.SqlClient.SqlConnection sqlConnection1;
		private deneme.ds_musteri ds_musteri1;
		private System.Windows.Forms.Label lblSaat;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Panel pnlAdmin;
		private System.Windows.Forms.Button button7;
		private System.Windows.Forms.Button button8;
		private System.Windows.Forms.Button button9;
		private System.Windows.Forms.Button btnAltAdmin;
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

		public KartlarAyrinti()
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(KartlarAyrinti));
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
			this.btnKDuzenle = new System.Windows.Forms.Button();
			this.btnKSil = new System.Windows.Forms.Button();
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
			this.button1 = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.lblFIsim = new System.Windows.Forms.Label();
			this.ds_musteri1 = new deneme.ds_musteri();
			this.lblTel1 = new System.Windows.Forms.Label();
			this.lblTel2 = new System.Windows.Forms.Label();
			this.lblFax = new System.Windows.Forms.Label();
			this.lblSemt = new System.Windows.Forms.Label();
			this.lblSehir = new System.Windows.Forms.Label();
			this.lblAdres = new System.Windows.Forms.Label();
			this.lblVerDai = new System.Windows.Forms.Label();
			this.lblVerNo = new System.Windows.Forms.Label();
			this.lblWeb = new System.Windows.Forms.Label();
			this.lblFmail = new System.Windows.Forms.Label();
			this.label23 = new System.Windows.Forms.Label();
			this.label24 = new System.Windows.Forms.Label();
			this.label26 = new System.Windows.Forms.Label();
			this.label27 = new System.Windows.Forms.Label();
			this.label28 = new System.Windows.Forms.Label();
			this.label29 = new System.Windows.Forms.Label();
			this.label31 = new System.Windows.Forms.Label();
			this.label32 = new System.Windows.Forms.Label();
			this.label33 = new System.Windows.Forms.Label();
			this.lblCepTel = new System.Windows.Forms.Label();
			this.lblKmail = new System.Windows.Forms.Label();
			this.lblAd = new System.Windows.Forms.Label();
			this.lblSoyad = new System.Windows.Forms.Label();
			this.lblUnvan = new System.Windows.Forms.Label();
			this.lblDahili = new System.Windows.Forms.Label();
			this.lblDep = new System.Windows.Forms.Label();
			this.lblLevel = new System.Windows.Forms.Label();
			this.lblSektor = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.label12 = new System.Windows.Forms.Label();
			this.lblSaat = new System.Windows.Forms.Label();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.sqlDataAdapter1 = new System.Data.SqlClient.SqlDataAdapter();
			this.sqlDeleteCommand1 = new System.Data.SqlClient.SqlCommand();
			this.sqlConnection1 = new System.Data.SqlClient.SqlConnection();
			this.sqlInsertCommand1 = new System.Data.SqlClient.SqlCommand();
			this.sqlSelectCommand1 = new System.Data.SqlClient.SqlCommand();
			this.sqlUpdateCommand1 = new System.Data.SqlClient.SqlCommand();
			this.pnlAdmin = new System.Windows.Forms.Panel();
			this.button7 = new System.Windows.Forms.Button();
			this.button8 = new System.Windows.Forms.Button();
			this.button9 = new System.Windows.Forms.Button();
			this.btnAltAdmin = new System.Windows.Forms.Button();
			this.pnlTeklif = new System.Windows.Forms.Panel();
			this.btnTeklifGoruntule = new System.Windows.Forms.Button();
			this.btnTeklifYeni = new System.Windows.Forms.Button();
			this.btnTeklifPrint = new System.Windows.Forms.Button();
			this.pnlCrm = new System.Windows.Forms.Panel();
			this.button10 = new System.Windows.Forms.Button();
			this.button11 = new System.Windows.Forms.Button();
			this.pnlKartlar.SuspendLayout();
			this.pnlList.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.ds_musteri1)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox3.SuspendLayout();
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
			// btnKDuzenle
			// 
			this.btnKDuzenle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnKDuzenle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(162)));
			this.btnKDuzenle.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
			this.btnKDuzenle.Location = new System.Drawing.Point(104, 8);
			this.btnKDuzenle.Name = "btnKDuzenle";
			this.btnKDuzenle.Size = new System.Drawing.Size(75, 30);
			this.btnKDuzenle.TabIndex = 24;
			this.btnKDuzenle.Text = "Düzenle";
			this.btnKDuzenle.Click += new System.EventHandler(this.btnKDuzenle_Click);
			// 
			// btnKSil
			// 
			this.btnKSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnKSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(162)));
			this.btnKSil.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
			this.btnKSil.Location = new System.Drawing.Point(192, 8);
			this.btnKSil.Name = "btnKSil";
			this.btnKSil.Size = new System.Drawing.Size(75, 30);
			this.btnKSil.TabIndex = 25;
			this.btnKSil.Text = "Sil";
			this.btnKSil.Click += new System.EventHandler(this.btnKSil_Click);
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
			this.pnlKartlar.Controls.Add(this.btnKSil);
			this.pnlKartlar.Controls.Add(this.btnYeni);
			this.pnlKartlar.Controls.Add(this.btnKAra);
			this.pnlKartlar.Controls.Add(this.btnKDuzenle);
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
			// button1
			// 
			this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(162)));
			this.button1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
			this.button1.Location = new System.Drawing.Point(48, 568);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(80, 50);
			this.button1.TabIndex = 33;
			this.button1.Text = "Admin";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(162)));
			this.label1.Location = new System.Drawing.Point(16, 40);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(112, 23);
			this.label1.TabIndex = 34;
			this.label1.Text = "Firma Adý :";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(162)));
			this.label2.Location = new System.Drawing.Point(16, 72);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(112, 23);
			this.label2.TabIndex = 35;
			this.label2.Text = "Telefon 1 :";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(162)));
			this.label3.Location = new System.Drawing.Point(16, 104);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(112, 23);
			this.label3.TabIndex = 36;
			this.label3.Text = "Telefon 2 :";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(162)));
			this.label4.Location = new System.Drawing.Point(16, 136);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(112, 23);
			this.label4.TabIndex = 37;
			this.label4.Text = "Fax :";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label5
			// 
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(162)));
			this.label5.Location = new System.Drawing.Point(16, 168);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(112, 23);
			this.label5.TabIndex = 38;
			this.label5.Text = "Semt :";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label6
			// 
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(162)));
			this.label6.Location = new System.Drawing.Point(16, 200);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(112, 23);
			this.label6.TabIndex = 39;
			this.label6.Text = "Sehir :";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label7
			// 
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(162)));
			this.label7.Location = new System.Drawing.Point(16, 232);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(112, 23);
			this.label7.TabIndex = 40;
			this.label7.Text = "Adres :";
			this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label8
			// 
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(162)));
			this.label8.Location = new System.Drawing.Point(16, 264);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(112, 23);
			this.label8.TabIndex = 41;
			this.label8.Text = "Vergi Dairesi :";
			this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label9
			// 
			this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(162)));
			this.label9.Location = new System.Drawing.Point(16, 296);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(112, 23);
			this.label9.TabIndex = 42;
			this.label9.Text = "Vergi Numarasý :";
			this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label10
			// 
			this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(162)));
			this.label10.Location = new System.Drawing.Point(16, 328);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(112, 23);
			this.label10.TabIndex = 43;
			this.label10.Text = "Web Adresi :";
			this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label11
			// 
			this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(162)));
			this.label11.Location = new System.Drawing.Point(16, 360);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(112, 23);
			this.label11.TabIndex = 44;
			this.label11.Text = "E-Mail Adresi :";
			this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lblFIsim
			// 
			this.lblFIsim.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ds_musteri1, "tbl_mk.Isim"));
			this.lblFIsim.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(162)));
			this.lblFIsim.Location = new System.Drawing.Point(136, 40);
			this.lblFIsim.Name = "lblFIsim";
			this.lblFIsim.Size = new System.Drawing.Size(248, 23);
			this.lblFIsim.TabIndex = 45;
			this.lblFIsim.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// ds_musteri1
			// 
			this.ds_musteri1.DataSetName = "ds_musteri";
			this.ds_musteri1.Locale = new System.Globalization.CultureInfo("tr-TR");
			// 
			// lblTel1
			// 
			this.lblTel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ds_musteri1, "tbl_mk.Tel1"));
			this.lblTel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(162)));
			this.lblTel1.Location = new System.Drawing.Point(136, 72);
			this.lblTel1.Name = "lblTel1";
			this.lblTel1.Size = new System.Drawing.Size(248, 23);
			this.lblTel1.TabIndex = 46;
			this.lblTel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lblTel2
			// 
			this.lblTel2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ds_musteri1, "tbl_mk.Tel2"));
			this.lblTel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(162)));
			this.lblTel2.Location = new System.Drawing.Point(136, 104);
			this.lblTel2.Name = "lblTel2";
			this.lblTel2.Size = new System.Drawing.Size(248, 23);
			this.lblTel2.TabIndex = 48;
			this.lblTel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lblFax
			// 
			this.lblFax.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ds_musteri1, "tbl_mk.Fax"));
			this.lblFax.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(162)));
			this.lblFax.Location = new System.Drawing.Point(136, 136);
			this.lblFax.Name = "lblFax";
			this.lblFax.Size = new System.Drawing.Size(248, 23);
			this.lblFax.TabIndex = 47;
			this.lblFax.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lblSemt
			// 
			this.lblSemt.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ds_musteri1, "tbl_mk.Semt"));
			this.lblSemt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(162)));
			this.lblSemt.Location = new System.Drawing.Point(136, 168);
			this.lblSemt.Name = "lblSemt";
			this.lblSemt.Size = new System.Drawing.Size(248, 23);
			this.lblSemt.TabIndex = 52;
			this.lblSemt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lblSehir
			// 
			this.lblSehir.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ds_musteri1, "tbl_mk.Sehir"));
			this.lblSehir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(162)));
			this.lblSehir.Location = new System.Drawing.Point(136, 200);
			this.lblSehir.Name = "lblSehir";
			this.lblSehir.Size = new System.Drawing.Size(248, 23);
			this.lblSehir.TabIndex = 51;
			this.lblSehir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lblAdres
			// 
			this.lblAdres.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ds_musteri1, "tbl_mk.Adres"));
			this.lblAdres.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(162)));
			this.lblAdres.Location = new System.Drawing.Point(136, 232);
			this.lblAdres.Name = "lblAdres";
			this.lblAdres.Size = new System.Drawing.Size(248, 23);
			this.lblAdres.TabIndex = 50;
			this.lblAdres.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lblVerDai
			// 
			this.lblVerDai.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ds_musteri1, "tbl_mk.Vergi"));
			this.lblVerDai.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(162)));
			this.lblVerDai.Location = new System.Drawing.Point(136, 264);
			this.lblVerDai.Name = "lblVerDai";
			this.lblVerDai.Size = new System.Drawing.Size(248, 23);
			this.lblVerDai.TabIndex = 49;
			this.lblVerDai.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lblVerNo
			// 
			this.lblVerNo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ds_musteri1, "tbl_mk.VergiNo"));
			this.lblVerNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(162)));
			this.lblVerNo.Location = new System.Drawing.Point(136, 296);
			this.lblVerNo.Name = "lblVerNo";
			this.lblVerNo.Size = new System.Drawing.Size(248, 23);
			this.lblVerNo.TabIndex = 55;
			this.lblVerNo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lblWeb
			// 
			this.lblWeb.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ds_musteri1, "tbl_mk.Web"));
			this.lblWeb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(162)));
			this.lblWeb.Location = new System.Drawing.Point(136, 328);
			this.lblWeb.Name = "lblWeb";
			this.lblWeb.Size = new System.Drawing.Size(248, 23);
			this.lblWeb.TabIndex = 54;
			this.lblWeb.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lblFmail
			// 
			this.lblFmail.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ds_musteri1, "tbl_mk.FirmaMail"));
			this.lblFmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(162)));
			this.lblFmail.Location = new System.Drawing.Point(136, 360);
			this.lblFmail.Name = "lblFmail";
			this.lblFmail.Size = new System.Drawing.Size(248, 23);
			this.lblFmail.TabIndex = 53;
			this.lblFmail.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label23
			// 
			this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(162)));
			this.label23.Location = new System.Drawing.Point(24, 192);
			this.label23.Name = "label23";
			this.label23.Size = new System.Drawing.Size(104, 23);
			this.label23.TabIndex = 66;
			this.label23.Text = "Cep Telefon :";
			this.label23.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label24
			// 
			this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(162)));
			this.label24.Location = new System.Drawing.Point(24, 224);
			this.label24.Name = "label24";
			this.label24.Size = new System.Drawing.Size(104, 23);
			this.label24.TabIndex = 65;
			this.label24.Text = "E-Mail Adresi :";
			this.label24.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label26
			// 
			this.label26.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(162)));
			this.label26.Location = new System.Drawing.Point(24, 64);
			this.label26.Name = "label26";
			this.label26.Size = new System.Drawing.Size(104, 23);
			this.label26.TabIndex = 63;
			this.label26.Text = "Ad :";
			this.label26.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label27
			// 
			this.label27.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(162)));
			this.label27.Location = new System.Drawing.Point(24, 96);
			this.label27.Name = "label27";
			this.label27.Size = new System.Drawing.Size(104, 23);
			this.label27.TabIndex = 62;
			this.label27.Text = "Soyad :";
			this.label27.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label28
			// 
			this.label28.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(162)));
			this.label28.Location = new System.Drawing.Point(24, 128);
			this.label28.Name = "label28";
			this.label28.Size = new System.Drawing.Size(104, 23);
			this.label28.TabIndex = 61;
			this.label28.Text = "Ünvan :";
			this.label28.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label29
			// 
			this.label29.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(162)));
			this.label29.Location = new System.Drawing.Point(24, 160);
			this.label29.Name = "label29";
			this.label29.Size = new System.Drawing.Size(104, 23);
			this.label29.TabIndex = 60;
			this.label29.Text = "Dahili :";
			this.label29.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label31
			// 
			this.label31.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(162)));
			this.label31.Location = new System.Drawing.Point(24, 32);
			this.label31.Name = "label31";
			this.label31.Size = new System.Drawing.Size(104, 23);
			this.label31.TabIndex = 58;
			this.label31.Text = "Departman :";
			this.label31.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label32
			// 
			this.label32.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(162)));
			this.label32.Location = new System.Drawing.Point(24, 64);
			this.label32.Name = "label32";
			this.label32.Size = new System.Drawing.Size(104, 23);
			this.label32.TabIndex = 57;
			this.label32.Text = "Level :";
			this.label32.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label33
			// 
			this.label33.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(162)));
			this.label33.Location = new System.Drawing.Point(24, 32);
			this.label33.Name = "label33";
			this.label33.Size = new System.Drawing.Size(104, 23);
			this.label33.TabIndex = 56;
			this.label33.Text = "Sektor :";
			this.label33.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lblCepTel
			// 
			this.lblCepTel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ds_musteri1, "tbl_mk.CepTel"));
			this.lblCepTel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(162)));
			this.lblCepTel.ForeColor = System.Drawing.SystemColors.ControlText;
			this.lblCepTel.Location = new System.Drawing.Point(136, 192);
			this.lblCepTel.Name = "lblCepTel";
			this.lblCepTel.Size = new System.Drawing.Size(200, 23);
			this.lblCepTel.TabIndex = 77;
			this.lblCepTel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lblKmail
			// 
			this.lblKmail.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ds_musteri1, "tbl_mk.KisiMail"));
			this.lblKmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(162)));
			this.lblKmail.ForeColor = System.Drawing.SystemColors.ControlText;
			this.lblKmail.Location = new System.Drawing.Point(136, 224);
			this.lblKmail.Name = "lblKmail";
			this.lblKmail.Size = new System.Drawing.Size(200, 23);
			this.lblKmail.TabIndex = 76;
			this.lblKmail.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lblAd
			// 
			this.lblAd.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ds_musteri1, "tbl_mk.Ad"));
			this.lblAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(162)));
			this.lblAd.ForeColor = System.Drawing.SystemColors.ControlText;
			this.lblAd.Location = new System.Drawing.Point(136, 64);
			this.lblAd.Name = "lblAd";
			this.lblAd.Size = new System.Drawing.Size(200, 23);
			this.lblAd.TabIndex = 74;
			this.lblAd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lblSoyad
			// 
			this.lblSoyad.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ds_musteri1, "tbl_mk.Soyad"));
			this.lblSoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(162)));
			this.lblSoyad.ForeColor = System.Drawing.SystemColors.ControlText;
			this.lblSoyad.Location = new System.Drawing.Point(136, 96);
			this.lblSoyad.Name = "lblSoyad";
			this.lblSoyad.Size = new System.Drawing.Size(200, 23);
			this.lblSoyad.TabIndex = 73;
			this.lblSoyad.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lblUnvan
			// 
			this.lblUnvan.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ds_musteri1, "tbl_mk.Unvan"));
			this.lblUnvan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(162)));
			this.lblUnvan.ForeColor = System.Drawing.SystemColors.ControlText;
			this.lblUnvan.Location = new System.Drawing.Point(136, 128);
			this.lblUnvan.Name = "lblUnvan";
			this.lblUnvan.Size = new System.Drawing.Size(200, 23);
			this.lblUnvan.TabIndex = 72;
			this.lblUnvan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lblDahili
			// 
			this.lblDahili.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ds_musteri1, "tbl_mk.Dahili"));
			this.lblDahili.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(162)));
			this.lblDahili.ForeColor = System.Drawing.SystemColors.ControlText;
			this.lblDahili.Location = new System.Drawing.Point(136, 160);
			this.lblDahili.Name = "lblDahili";
			this.lblDahili.Size = new System.Drawing.Size(200, 23);
			this.lblDahili.TabIndex = 71;
			this.lblDahili.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lblDep
			// 
			this.lblDep.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ds_musteri1, "tbl_mk.Departman"));
			this.lblDep.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(162)));
			this.lblDep.ForeColor = System.Drawing.SystemColors.ControlText;
			this.lblDep.Location = new System.Drawing.Point(136, 32);
			this.lblDep.Name = "lblDep";
			this.lblDep.Size = new System.Drawing.Size(200, 23);
			this.lblDep.TabIndex = 69;
			this.lblDep.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lblLevel
			// 
			this.lblLevel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ds_musteri1, "tbl_mk.Lvel"));
			this.lblLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(162)));
			this.lblLevel.Location = new System.Drawing.Point(136, 64);
			this.lblLevel.Name = "lblLevel";
			this.lblLevel.Size = new System.Drawing.Size(200, 23);
			this.lblLevel.TabIndex = 68;
			this.lblLevel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lblSektor
			// 
			this.lblSektor.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ds_musteri1, "tbl_mk.Sektor"));
			this.lblSektor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(162)));
			this.lblSektor.Location = new System.Drawing.Point(136, 32);
			this.lblSektor.Name = "lblSektor";
			this.lblSektor.Size = new System.Drawing.Size(200, 23);
			this.lblSektor.TabIndex = 67;
			this.lblSektor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.label12);
			this.groupBox1.Controls.Add(this.lblSektor);
			this.groupBox1.Controls.Add(this.lblLevel);
			this.groupBox1.Controls.Add(this.label33);
			this.groupBox1.Controls.Add(this.label32);
			this.groupBox1.Controls.Add(this.lblSaat);
			this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(162)));
			this.groupBox1.Location = new System.Drawing.Point(616, 152);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(352, 144);
			this.groupBox1.TabIndex = 78;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Alan Bilgileri";
			// 
			// label12
			// 
			this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(162)));
			this.label12.Location = new System.Drawing.Point(24, 96);
			this.label12.Name = "label12";
			this.label12.TabIndex = 82;
			this.label12.Text = "Kayýt Zamaný :";
			this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lblSaat
			// 
			this.lblSaat.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ds_musteri1, "tbl_mk.Saat"));
			this.lblSaat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(162)));
			this.lblSaat.Location = new System.Drawing.Point(136, 96);
			this.lblSaat.Name = "lblSaat";
			this.lblSaat.Size = new System.Drawing.Size(200, 23);
			this.lblSaat.TabIndex = 81;
			this.lblSaat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.lblCepTel);
			this.groupBox2.Controls.Add(this.label26);
			this.groupBox2.Controls.Add(this.label27);
			this.groupBox2.Controls.Add(this.label28);
			this.groupBox2.Controls.Add(this.label29);
			this.groupBox2.Controls.Add(this.label31);
			this.groupBox2.Controls.Add(this.label23);
			this.groupBox2.Controls.Add(this.lblDep);
			this.groupBox2.Controls.Add(this.label24);
			this.groupBox2.Controls.Add(this.lblDahili);
			this.groupBox2.Controls.Add(this.lblUnvan);
			this.groupBox2.Controls.Add(this.lblSoyad);
			this.groupBox2.Controls.Add(this.lblAd);
			this.groupBox2.Controls.Add(this.lblKmail);
			this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(162)));
			this.groupBox2.Location = new System.Drawing.Point(616, 296);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(352, 256);
			this.groupBox2.TabIndex = 79;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Kiþi Bilgileri";
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.lblTel1);
			this.groupBox3.Controls.Add(this.label7);
			this.groupBox3.Controls.Add(this.lblTel2);
			this.groupBox3.Controls.Add(this.lblFax);
			this.groupBox3.Controls.Add(this.label1);
			this.groupBox3.Controls.Add(this.label3);
			this.groupBox3.Controls.Add(this.label5);
			this.groupBox3.Controls.Add(this.lblSemt);
			this.groupBox3.Controls.Add(this.lblSehir);
			this.groupBox3.Controls.Add(this.lblAdres);
			this.groupBox3.Controls.Add(this.lblVerDai);
			this.groupBox3.Controls.Add(this.label6);
			this.groupBox3.Controls.Add(this.label10);
			this.groupBox3.Controls.Add(this.lblFIsim);
			this.groupBox3.Controls.Add(this.label4);
			this.groupBox3.Controls.Add(this.label2);
			this.groupBox3.Controls.Add(this.lblFmail);
			this.groupBox3.Controls.Add(this.label8);
			this.groupBox3.Controls.Add(this.lblWeb);
			this.groupBox3.Controls.Add(this.lblVerNo);
			this.groupBox3.Controls.Add(this.label9);
			this.groupBox3.Controls.Add(this.label11);
			this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(162)));
			this.groupBox3.Location = new System.Drawing.Point(216, 152);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(392, 400);
			this.groupBox3.TabIndex = 80;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Firma Bilgileri";
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
																																																				new System.Data.Common.DataColumnMapping("Fax", "Fax"),
																																																				new System.Data.Common.DataColumnMapping("Semt", "Semt"),
																																																				new System.Data.Common.DataColumnMapping("Sehir", "Sehir"),
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
																																																				new System.Data.Common.DataColumnMapping("Tarih", "Tarih"),
																																																				new System.Data.Common.DataColumnMapping("Saat", "Saat"),
																																																				new System.Data.Common.DataColumnMapping("KisiMail", "KisiMail"),
																																																				new System.Data.Common.DataColumnMapping("Sil", "Sil")})});
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
			this.sqlInsertCommand1.CommandText = @"INSERT INTO tbl_mk(Isim, Tel1, Tel2, Fax, Semt, Sehir, Adres, Vergi, VergiNo, Web, FirmaMail, Sektor, Lvel, Departman, Ad, Soyad, Unvan, Dahili, CepTel, Tarih, Saat, KisiMail, Sil) VALUES (@Isim, @Tel1, @Tel2, @Fax, @Semt, @Sehir, @Adres, @Vergi, @VergiNo, @Web, @FirmaMail, @Sektor, @Lvel, @Departman, @Ad, @Soyad, @Unvan, @Dahili, @CepTel, @Tarih, @Saat, @KisiMail, @Sil); SELECT KartID, Isim, Tel1, Tel2, Fax, Semt, Sehir, Adres, Vergi, VergiNo, Web, FirmaMail, Sektor, Lvel, Departman, Ad, Soyad, Unvan, Dahili, CepTel, Tarih, Saat, KisiMail, Sil FROM tbl_mk WHERE (KartID = @@IDENTITY)";
			this.sqlInsertCommand1.Connection = this.sqlConnection1;
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Isim", System.Data.SqlDbType.VarChar, 50, "Isim"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Tel1", System.Data.SqlDbType.VarChar, 50, "Tel1"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Tel2", System.Data.SqlDbType.VarChar, 50, "Tel2"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Fax", System.Data.SqlDbType.VarChar, 50, "Fax"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Semt", System.Data.SqlDbType.VarChar, 50, "Semt"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Sehir", System.Data.SqlDbType.VarChar, 50, "Sehir"));
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
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Tarih", System.Data.SqlDbType.DateTime, 8, "Tarih"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Saat", System.Data.SqlDbType.DateTime, 8, "Saat"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@KisiMail", System.Data.SqlDbType.VarChar, 50, "KisiMail"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Sil", System.Data.SqlDbType.TinyInt, 1, "Sil"));
			// 
			// sqlSelectCommand1
			// 
			this.sqlSelectCommand1.CommandText = "SELECT KartID, Isim, Tel1, Tel2, Fax, Semt, Sehir, Adres, Vergi, VergiNo, Web, Fi" +
				"rmaMail, Sektor, Lvel, Departman, Ad, Soyad, Unvan, Dahili, CepTel, Tarih, Saat," +
				" KisiMail, Sil FROM tbl_mk";
			this.sqlSelectCommand1.Connection = this.sqlConnection1;
			// 
			// sqlUpdateCommand1
			// 
			this.sqlUpdateCommand1.CommandText = @"UPDATE tbl_mk SET Isim = @Isim, Tel1 = @Tel1, Tel2 = @Tel2, Fax = @Fax, Semt = @Semt, Sehir = @Sehir, Adres = @Adres, Vergi = @Vergi, VergiNo = @VergiNo, Web = @Web, FirmaMail = @FirmaMail, Sektor = @Sektor, Lvel = @Lvel, Departman = @Departman, Ad = @Ad, Soyad = @Soyad, Unvan = @Unvan, Dahili = @Dahili, CepTel = @CepTel, Tarih = @Tarih, Saat = @Saat, KisiMail = @KisiMail, Sil = @Sil WHERE (KartID = @Original_KartID) AND (Ad = @Original_Ad) AND (Adres = @Original_Adres) AND (CepTel = @Original_CepTel) AND (Dahili = @Original_Dahili) AND (Departman = @Original_Departman) AND (Fax = @Original_Fax) AND (FirmaMail = @Original_FirmaMail) AND (Isim = @Original_Isim) AND (KisiMail = @Original_KisiMail) AND (Lvel = @Original_Lvel) AND (Saat = @Original_Saat) AND (Sehir = @Original_Sehir) AND (Sektor = @Original_Sektor) AND (Semt = @Original_Semt) AND (Sil = @Original_Sil) AND (Soyad = @Original_Soyad) AND (Tarih = @Original_Tarih) AND (Tel1 = @Original_Tel1) AND (Tel2 = @Original_Tel2) AND (Unvan = @Original_Unvan) AND (Vergi = @Original_Vergi) AND (VergiNo = @Original_VergiNo) AND (Web = @Original_Web); SELECT KartID, Isim, Tel1, Tel2, Fax, Semt, Sehir, Adres, Vergi, VergiNo, Web, FirmaMail, Sektor, Lvel, Departman, Ad, Soyad, Unvan, Dahili, CepTel, Tarih, Saat, KisiMail, Sil FROM tbl_mk WHERE (KartID = @KartID)";
			this.sqlUpdateCommand1.Connection = this.sqlConnection1;
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Isim", System.Data.SqlDbType.VarChar, 50, "Isim"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Tel1", System.Data.SqlDbType.VarChar, 50, "Tel1"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Tel2", System.Data.SqlDbType.VarChar, 50, "Tel2"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Fax", System.Data.SqlDbType.VarChar, 50, "Fax"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Semt", System.Data.SqlDbType.VarChar, 50, "Semt"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Sehir", System.Data.SqlDbType.VarChar, 50, "Sehir"));
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
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Tarih", System.Data.SqlDbType.DateTime, 8, "Tarih"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Saat", System.Data.SqlDbType.DateTime, 8, "Saat"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@KisiMail", System.Data.SqlDbType.VarChar, 50, "KisiMail"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Sil", System.Data.SqlDbType.TinyInt, 1, "Sil"));
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
			// pnlAdmin
			// 
			this.pnlAdmin.Controls.Add(this.button7);
			this.pnlAdmin.Controls.Add(this.button8);
			this.pnlAdmin.Controls.Add(this.button9);
			this.pnlAdmin.Location = new System.Drawing.Point(728, 72);
			this.pnlAdmin.Name = "pnlAdmin";
			this.pnlAdmin.Size = new System.Drawing.Size(280, 48);
			this.pnlAdmin.TabIndex = 82;
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
			// btnAltAdmin
			// 
			this.btnAltAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnAltAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(162)));
			this.btnAltAdmin.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
			this.btnAltAdmin.Location = new System.Drawing.Point(744, 32);
			this.btnAltAdmin.Name = "btnAltAdmin";
			this.btnAltAdmin.Size = new System.Drawing.Size(75, 30);
			this.btnAltAdmin.TabIndex = 83;
			this.btnAltAdmin.Text = "Admin";
			this.btnAltAdmin.Click += new System.EventHandler(this.btnAltAdmin_Click);
			// 
			// pnlTeklif
			// 
			this.pnlTeklif.Controls.Add(this.btnTeklifGoruntule);
			this.pnlTeklif.Controls.Add(this.btnTeklifYeni);
			this.pnlTeklif.Controls.Add(this.btnTeklifPrint);
			this.pnlTeklif.Location = new System.Drawing.Point(472, 72);
			this.pnlTeklif.Name = "pnlTeklif";
			this.pnlTeklif.Size = new System.Drawing.Size(272, 48);
			this.pnlTeklif.TabIndex = 100;
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
			this.pnlCrm.TabIndex = 117;
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
			// KartlarAyrinti
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.BackColor = System.Drawing.Color.PaleGoldenrod;
			this.ClientSize = new System.Drawing.Size(1016, 741);
			this.Controls.Add(this.pnlCrm);
			this.Controls.Add(this.pnlTeklif);
			this.Controls.Add(this.btnAltAdmin);
			this.Controls.Add(this.pnlAdmin);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.button1);
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
			this.Name = "KartlarAyrinti";
			this.Text = "Novateknik CRM";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.AnaSayfa_Load);
			this.Closed += new System.EventHandler(this.KartlarAyrinti_Closed);
			this.pnlKartlar.ResumeLayout(false);
			this.pnlList.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.ds_musteri1)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.groupBox3.ResumeLayout(false);
			this.pnlAdmin.ResumeLayout(false);
			this.pnlTeklif.ResumeLayout(false);
			this.pnlCrm.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		/// 		

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

		private void btnYeni_Click(object sender, System.EventArgs e)
		{
			KartlarYeni yeni=new KartlarYeni();
			yeni.Show();
			pnlKartlar.Visible=false;
			this.Hide();
		}

		private void btnMusteriK_Click(object sender, System.EventArgs e)
		{
			MusteriKayit yeni=new MusteriKayit();
			yeni.Show();
			this.Hide();

		}

		private void btnCrm_Click(object sender, System.EventArgs e)
		{
			pnlKartlar.Visible=false;
			pnlList.Visible=false;
			HareketlerYeni yeni=new HareketlerYeni();
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

		private void btnLAra_Click(object sender, System.EventArgs e)
		{
			HareketlerAra yeni=new HareketlerAra();
			yeni.Show();
			this.Hide();


		}

		private void btnKAra_Click(object sender, System.EventArgs e)
		{
			pnlKartlar.Visible=false;
			Ara yeni=new Ara();
			yeni.Show();
			this.Hide();

		}

		private void btnKDuzenle_Click(object sender, System.EventArgs e)
		{
			KartlarDuzenle yeni=new KartlarDuzenle();
			yeni.Show();
			this.Hide();
		}

		private void btnKSil_Click(object sender, System.EventArgs e)
		{
			KartlarSil yeni=new KartlarSil();
			yeni.Show();
			this.Hide();
		}

		private void AnaSayfa_Load(object sender, System.EventArgs e)
		{
			if(Giris.yetki=="1")
			{
				button1.Visible=false;
				btnAltAdmin.Visible=false;
			}
			
			SqlConnection yeni = new SqlConnection();
			yeni.ConnectionString = "Data Source=MCY;Integrated Security=SSPI;Initial Catalog=crm";
			SqlDataAdapter verial = new SqlDataAdapter("SELECT * FROM tbl_mk where KartID ='" + Ara.ayrinti + "'",yeni);
			DataSet al=new DataSet();
			verial.Fill(al,"tbl_mk");
			DataTable myDataTable = al.Tables["tbl_mk"];
			foreach (DataRow myDataRow in myDataTable.Rows)
			{
				lblFIsim.Text=myDataRow["Isim"].ToString();
				lblTel1.Text=myDataRow["Tel1"].ToString();
				lblTel2.Text=myDataRow["Tel2"].ToString();
				lblFax.Text=myDataRow["Fax"].ToString();
				lblSemt.Text=myDataRow["Semt"].ToString();
				lblSehir.Text=myDataRow["Sehir"].ToString();
				lblAdres.Text=myDataRow["Adres"].ToString();
				lblVerDai.Text=myDataRow["Vergi"].ToString();
				lblVerNo.Text=myDataRow["VergiNo"].ToString();
				lblWeb.Text=myDataRow["Web"].ToString();
				lblFmail.Text=myDataRow["FirmaMail"].ToString();
				lblSektor.Text=myDataRow["Sektor"].ToString();
				lblLevel.Text=myDataRow["Lvel"].ToString();
				lblDep.Text=myDataRow["Departman"].ToString();
				lblAd.Text=myDataRow["Ad"].ToString();
				lblSoyad.Text=myDataRow["Soyad"].ToString();
				lblUnvan.Text=myDataRow["Unvan"].ToString();
				lblDahili.Text=myDataRow["Dahili"].ToString();
				lblCepTel.Text=myDataRow["CepTel"].ToString();
				lblKmail.Text=myDataRow["KisiMail"].ToString();
				//lblTarih.Text=myDataRow["Tarih"].ToString(); tarih we saati bir arada veriyorum.
				lblSaat.Text=myDataRow["Saat"].ToString();


			}
		}

		private void button1_Click(object sender, System.EventArgs e)
		{
			pnlKartlar.Visible=false;
			pnlList.Visible=false;
			AdminAnaSayfa yeni=new AdminAnaSayfa();
			yeni.Show();
			this.Hide();
		}

		private void button2_Click(object sender, System.EventArgs e)
		{

		}

		private void btnAltAdmin_Click(object sender, System.EventArgs e)
		{
			pnlList.Visible=false;
			pnlKartlar.Visible=false;
			pnlTeklif.Visible=false;
			pnlCrm.Visible=false;
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

		private void KartlarAyrinti_Closed(object sender, System.EventArgs e)
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
	}
}
