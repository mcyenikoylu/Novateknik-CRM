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
	public class AnaSayfa : System.Windows.Forms.Form
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
		private System.Windows.Forms.DataGrid dgAnaSayfa;
		private System.Windows.Forms.Button btnKDuzenle;
		private System.Windows.Forms.Button btnKSil;
		private System.Data.SqlClient.SqlDataAdapter sqlDataAdapter1;
		private System.Data.SqlClient.SqlCommand sqlSelectCommand1;
		private System.Data.SqlClient.SqlConnection sqlConnection1;
		private deneme.ds_Hareket ds_Hareket1;
		private deneme.ds_musteri ds_musteri1;
		private System.Windows.Forms.Button btnAdmin;
		private System.Windows.Forms.Panel pnlAdmin;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button btnAltAdmin;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Panel pnlTeklif;
		private System.Windows.Forms.Button btnTeklifGoruntule;
		private System.Windows.Forms.Button btnTeklifYeni;
		private System.Windows.Forms.Button btnTeklifPrint;
		private System.Windows.Forms.Label label1;
		private deneme.ds_ilet ds_ilet1;
		private System.Windows.Forms.Panel pnlCrm;
		private System.Windows.Forms.Button button10;
		private System.Windows.Forms.Button button11;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public AnaSayfa()
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(AnaSayfa));
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
			this.dgAnaSayfa = new System.Windows.Forms.DataGrid();
			this.btnAdmin = new System.Windows.Forms.Button();
			this.sqlDataAdapter1 = new System.Data.SqlClient.SqlDataAdapter();
			this.sqlSelectCommand1 = new System.Data.SqlClient.SqlCommand();
			this.sqlConnection1 = new System.Data.SqlClient.SqlConnection();
			this.ds_Hareket1 = new deneme.ds_Hareket();
			this.ds_musteri1 = new deneme.ds_musteri();
			this.pnlAdmin = new System.Windows.Forms.Panel();
			this.button2 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.btnAltAdmin = new System.Windows.Forms.Button();
			this.panel1 = new System.Windows.Forms.Panel();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.pnlTeklif = new System.Windows.Forms.Panel();
			this.btnTeklifGoruntule = new System.Windows.Forms.Button();
			this.btnTeklifYeni = new System.Windows.Forms.Button();
			this.btnTeklifPrint = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.ds_ilet1 = new deneme.ds_ilet();
			this.pnlCrm = new System.Windows.Forms.Panel();
			this.button10 = new System.Windows.Forms.Button();
			this.button11 = new System.Windows.Forms.Button();
			this.pnlKartlar.SuspendLayout();
			this.pnlList.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgAnaSayfa)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ds_Hareket1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ds_musteri1)).BeginInit();
			this.pnlAdmin.SuspendLayout();
			this.panel1.SuspendLayout();
			this.pnlTeklif.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.ds_ilet1)).BeginInit();
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
			this.btnList.Location = new System.Drawing.Point(16, 8);
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
			this.btnKart.Location = new System.Drawing.Point(104, 8);
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
			this.btnAltCrm.Location = new System.Drawing.Point(192, 8);
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
			this.btnTeklif.Location = new System.Drawing.Point(280, 8);
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
			this.btnSiparis.Location = new System.Drawing.Point(368, 8);
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
			this.btnAltProjeler.Location = new System.Drawing.Point(456, 8);
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
			// dgAnaSayfa
			// 
			this.dgAnaSayfa.DataMember = "";
			this.dgAnaSayfa.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.dgAnaSayfa.Location = new System.Drawing.Point(216, 176);
			this.dgAnaSayfa.Name = "dgAnaSayfa";
			this.dgAnaSayfa.ReadOnly = true;
			this.dgAnaSayfa.Size = new System.Drawing.Size(712, 440);
			this.dgAnaSayfa.TabIndex = 32;
			// 
			// btnAdmin
			// 
			this.btnAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(162)));
			this.btnAdmin.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
			this.btnAdmin.Location = new System.Drawing.Point(48, 568);
			this.btnAdmin.Name = "btnAdmin";
			this.btnAdmin.Size = new System.Drawing.Size(80, 50);
			this.btnAdmin.TabIndex = 33;
			this.btnAdmin.Text = "Admin";
			this.btnAdmin.Click += new System.EventHandler(this.btnAdmin_Click);
			// 
			// sqlDataAdapter1
			// 
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
																																																					 new System.Data.Common.DataColumnMapping("Expr1", "Expr1"),
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
																																																					 new System.Data.Common.DataColumnMapping("KisiMail", "KisiMail"),
																																																					 new System.Data.Common.DataColumnMapping("Expr2", "Expr2"),
																																																					 new System.Data.Common.DataColumnMapping("Expr3", "Expr3"),
																																																					 new System.Data.Common.DataColumnMapping("Expr4", "Expr4")})});
			// 
			// sqlSelectCommand1
			// 
			this.sqlSelectCommand1.CommandText = @"SELECT tbl_hareket.HareketID, tbl_hareket.Tarih, tbl_hareket.Saat, tbl_hareket.Sil, tbl_hareket.KartID, tbl_hareket.HarTur, tbl_hareket.HarYonu, tbl_hareket.Iletisim, tbl_hareket.AraSonuc, tbl_hareket.Konu, tbl_hareket.Gorusme, tbl_hareket.GorTarih, tbl_hareket.GorZaman, tbl_hareket.GorDurum, tbl_hareket.GorSonuc, tbl_hareket.GorNot, tbl_hareket.Admin, tbl_hareket.HarDurum, tbl_hareket.SonYonu, tbl_hareket.Users, tbl_mk.KartID AS Expr1, tbl_mk.Isim, tbl_mk.Tel1, tbl_mk.Tel2, tbl_mk.Fax, tbl_mk.Semt, tbl_mk.Sehir, tbl_mk.Adres, tbl_mk.Vergi, tbl_mk.VergiNo, tbl_mk.Web, tbl_mk.FirmaMail, tbl_mk.Sektor, tbl_mk.Lvel, tbl_mk.Departman, tbl_mk.Ad, tbl_mk.Soyad, tbl_mk.Unvan, tbl_mk.Dahili, tbl_mk.CepTel, tbl_mk.KisiMail, tbl_mk.Sil AS Expr2, tbl_mk.Tarih AS Expr3, tbl_mk.Saat AS Expr4 FROM tbl_hareket INNER JOIN tbl_mk ON tbl_hareket.KartID = tbl_mk.KartID";
			this.sqlSelectCommand1.Connection = this.sqlConnection1;
			// 
			// sqlConnection1
			// 
			this.sqlConnection1.ConnectionString = "workstation id=MCY;packet size=4096;integrated security=SSPI;data source=MCY;pers" +
				"ist security info=False;initial catalog=crm";
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
			// pnlAdmin
			// 
			this.pnlAdmin.Controls.Add(this.button2);
			this.pnlAdmin.Controls.Add(this.button4);
			this.pnlAdmin.Controls.Add(this.button3);
			this.pnlAdmin.Location = new System.Drawing.Point(728, 72);
			this.pnlAdmin.Name = "pnlAdmin";
			this.pnlAdmin.Size = new System.Drawing.Size(280, 48);
			this.pnlAdmin.TabIndex = 38;
			this.pnlAdmin.Visible = false;
			// 
			// button2
			// 
			this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(162)));
			this.button2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
			this.button2.Location = new System.Drawing.Point(16, 8);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(75, 30);
			this.button2.TabIndex = 37;
			this.button2.Text = "Yeni";
			this.button2.Click += new System.EventHandler(this.button2_Click_1);
			// 
			// button4
			// 
			this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(162)));
			this.button4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
			this.button4.Location = new System.Drawing.Point(192, 8);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(75, 30);
			this.button4.TabIndex = 39;
			this.button4.Text = "Sil";
			// 
			// button3
			// 
			this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(162)));
			this.button3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
			this.button3.Location = new System.Drawing.Point(104, 8);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(75, 30);
			this.button3.TabIndex = 38;
			this.button3.Text = "Düzenle";
			// 
			// btnAltAdmin
			// 
			this.btnAltAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnAltAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(162)));
			this.btnAltAdmin.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
			this.btnAltAdmin.Location = new System.Drawing.Point(544, 8);
			this.btnAltAdmin.Name = "btnAltAdmin";
			this.btnAltAdmin.Size = new System.Drawing.Size(75, 30);
			this.btnAltAdmin.TabIndex = 37;
			this.btnAltAdmin.Text = "Admin";
			this.btnAltAdmin.Click += new System.EventHandler(this.btnAltAdmin_Click);
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.btnKart);
			this.panel1.Controls.Add(this.btnList);
			this.panel1.Controls.Add(this.btnAltAdmin);
			this.panel1.Controls.Add(this.btnAltCrm);
			this.panel1.Controls.Add(this.btnTeklif);
			this.panel1.Controls.Add(this.btnSiparis);
			this.panel1.Controls.Add(this.btnAltProjeler);
			this.panel1.Location = new System.Drawing.Point(200, 24);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(640, 48);
			this.panel1.TabIndex = 39;
			this.panel1.Visible = false;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(24, 40);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(296, 88);
			this.pictureBox1.TabIndex = 40;
			this.pictureBox1.TabStop = false;
			// 
			// pnlTeklif
			// 
			this.pnlTeklif.Controls.Add(this.btnTeklifGoruntule);
			this.pnlTeklif.Controls.Add(this.btnTeklifYeni);
			this.pnlTeklif.Controls.Add(this.btnTeklifPrint);
			this.pnlTeklif.Location = new System.Drawing.Point(472, 72);
			this.pnlTeklif.Name = "pnlTeklif";
			this.pnlTeklif.Size = new System.Drawing.Size(272, 48);
			this.pnlTeklif.TabIndex = 103;
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
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(162)));
			this.label1.Location = new System.Drawing.Point(224, 152);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(144, 23);
			this.label1.TabIndex = 106;
			this.label1.Text = "Güncel 30 konu baþlýðý:";
			this.label1.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
			// 
			// ds_ilet1
			// 
			this.ds_ilet1.DataSetName = "ds_ilet";
			this.ds_ilet1.Locale = new System.Globalization.CultureInfo("tr-TR");
			// 
			// pnlCrm
			// 
			this.pnlCrm.Controls.Add(this.button10);
			this.pnlCrm.Controls.Add(this.button11);
			this.pnlCrm.Location = new System.Drawing.Point(384, 72);
			this.pnlCrm.Name = "pnlCrm";
			this.pnlCrm.Size = new System.Drawing.Size(176, 48);
			this.pnlCrm.TabIndex = 115;
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
			// AnaSayfa
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.BackColor = System.Drawing.Color.PaleGoldenrod;
			this.ClientSize = new System.Drawing.Size(1016, 741);
			this.Controls.Add(this.pnlCrm);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.pnlTeklif);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.pnlAdmin);
			this.Controls.Add(this.btnAdmin);
			this.Controls.Add(this.dgAnaSayfa);
			this.Controls.Add(this.pnlList);
			this.Controls.Add(this.pnlKartlar);
			this.Controls.Add(this.btnRapor);
			this.Controls.Add(this.btnBilgiB);
			this.Controls.Add(this.btnProjeler);
			this.Controls.Add(this.btnSiparisG);
			this.Controls.Add(this.btnTeklifH);
			this.Controls.Add(this.btnCrm);
			this.Controls.Add(this.btnMusteriK);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "AnaSayfa";
			this.Text = "Novateknik CRM";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.AnaSayfa_Load);
			this.Closed += new System.EventHandler(this.AnaSayfa_Closed);
			this.pnlKartlar.ResumeLayout(false);
			this.pnlList.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgAnaSayfa)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ds_Hareket1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ds_musteri1)).EndInit();
			this.pnlAdmin.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.pnlTeklif.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.ds_ilet1)).EndInit();
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


		public static string eski;
		private void AnaSayfa_Load(object sender, System.EventArgs e)
		{	
			if(Giris.yetki=="1")
			{
				btnAdmin.Visible=false;
				btnAltAdmin.Visible=false;
			}

			SqlConnection yeni = new SqlConnection();
			yeni.ConnectionString = "Data Source=MCY;Integrated Security=SSPI;Initial Catalog=crm";
			//yeni.ConnectionString = "Data Source=GATEWAY;uid=sa;pwd=;Initial Catalog=crm";
			SqlDataAdapter verial =new SqlDataAdapter("SELECT TOP 30 tbl_hareket.HareketID[Hareket ID],tbl_hareket.KartID[Kart ID],tbl_hareket.HarTur[Hareketin Türü],tbl_mk.Isim[Firma Ýsmi],tbl_.hareket.Konu[Hareketin Konusu],Convert(varchar,datepart(day,tbl_hareket.Tarih))+':'+Convert(varchar,datepart(month,tbl_hareket.Tarih))+':'+Convert(varchar,datepart(year,tbl_hareket.Tarih))[Hareket Tarihi],Convert(varchar,datepart(hour,tbl_hareket.Saat))+':'+Convert(varchar,datepart(minute,tbl_hareket.Saat))[Hareket Saati] FROM tbl_mk,tbl_hareket Where tbl_mk.KartID=tbl_hareket.KartID and tbl_hareket.Sil='1' ORDER BY tbl_hareket.HareketID DESC", yeni);
			DataSet al=new DataSet();
			verial.Fill(al,"tbl_hareket");
			dgAnaSayfa.DataSource=al.Tables[0];

			DataGridTableStyle stil = new DataGridTableStyle();
			stil.MappingName = al.Tables[0].TableName;
			stil.AlternatingBackColor =Color.LightGray;
			dgAnaSayfa.TableStyles.Add(stil);
			GridColumnStylesCollection kolonStil = stil.GridColumnStyles;
			kolonStil["Hareket ID"].Width=0;
			kolonStil["Kart ID"].Width=0;
			kolonStil["Hareketin Türü"].Width=100;
			kolonStil["Firma Ýsmi"].Width=150;
			kolonStil["Hareketin Konusu"].Width=245;
			kolonStil["Hareket Tarihi"].Width=80;
			kolonStil["Hareket Saati"].Width=80;
			
			string mesaj;
			mesaj=Giris.userid;

			SqlConnection yeni2 = new SqlConnection();
			yeni2.ConnectionString = "Data Source=MCY;Integrated Security=SSPI;Initial Catalog=crm";
			//yeni2.ConnectionString = "Data Source=GATEWAY;uid=sa;pwd=;Initial Catalog=crm";
			SqlDataAdapter verial2 =new SqlDataAdapter("SELECT * FROM tbl_ilet where UserID='"+Giris.userid.ToString()+"'", yeni2);
			DataSet al2=new DataSet();
			verial2.Fill(al2,"tbl_ilet");
			DataTable myDataTable = al2.Tables["tbl_ilet"];
			foreach (DataRow myDataRow in myDataTable.Rows)
			{
				eski=myDataRow["Eski"].ToString();
			}
			if(eski=="1")
			{
				IletiOku yeni5=new IletiOku();
				yeni5.ShowDialog();
			}

		}


		private void btnAdmin_Click(object sender, System.EventArgs e)
		{

			AdminAnaSayfa yeni=new AdminAnaSayfa();
			yeni.Show();
			this.Hide();

		}


		private void button2_Click_1(object sender, System.EventArgs e)
		{
			Admin yeni=new Admin();
			yeni.Show();
			this.Hide();
		}

		private void btnAltAdmin_Click(object sender, System.EventArgs e)
		{
			pnlTeklif.Visible=false;
			pnlList.Visible=false;
			pnlKartlar.Visible=false;
			pnlCrm.Visible=false;
			pnlAdmin.Visible=true;

		}

		private void button1_Click(object sender, System.EventArgs e)
		{
		
		}


		private void AnaSayfa_Closed(object sender, System.EventArgs e)
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
