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
	public class AdminDuzenle: System.Windows.Forms.Form
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
		private System.Windows.Forms.Button btnAltAdmin;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Panel pnlAdmin;
		private System.Data.SqlClient.SqlDataAdapter sqlDataAdapter1;
		private System.Data.SqlClient.SqlCommand sqlSelectCommand1;
		private System.Data.SqlClient.SqlCommand sqlInsertCommand1;
		private System.Data.SqlClient.SqlCommand sqlUpdateCommand1;
		private System.Data.SqlClient.SqlCommand sqlDeleteCommand1;
		private System.Data.SqlClient.SqlConnection sqlConnection1;
		private deneme.ds_users ds_users1;
		private System.Windows.Forms.DataGrid dataGrid1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.RadioButton radioButton2;
		private System.Windows.Forms.RadioButton radioButton1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtSifre;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnKayit;
		private System.Windows.Forms.TextBox txtKullanici;
		private System.Windows.Forms.Button btnDuzenle;
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

		public AdminDuzenle()
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


public static string duzen;


		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(AdminDuzenle));
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
			this.btnAltAdmin = new System.Windows.Forms.Button();
			this.pnlAdmin = new System.Windows.Forms.Panel();
			this.button2 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.sqlDataAdapter1 = new System.Data.SqlClient.SqlDataAdapter();
			this.sqlDeleteCommand1 = new System.Data.SqlClient.SqlCommand();
			this.sqlConnection1 = new System.Data.SqlClient.SqlConnection();
			this.sqlInsertCommand1 = new System.Data.SqlClient.SqlCommand();
			this.sqlSelectCommand1 = new System.Data.SqlClient.SqlCommand();
			this.sqlUpdateCommand1 = new System.Data.SqlClient.SqlCommand();
			this.ds_users1 = new deneme.ds_users();
			this.dataGrid1 = new System.Windows.Forms.DataGrid();
			this.panel2 = new System.Windows.Forms.Panel();
			this.label2 = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.radioButton2 = new System.Windows.Forms.RadioButton();
			this.radioButton1 = new System.Windows.Forms.RadioButton();
			this.label3 = new System.Windows.Forms.Label();
			this.txtSifre = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.btnKayit = new System.Windows.Forms.Button();
			this.txtKullanici = new System.Windows.Forms.TextBox();
			this.btnDuzenle = new System.Windows.Forms.Button();
			this.pnlTeklif = new System.Windows.Forms.Panel();
			this.btnTeklifGoruntule = new System.Windows.Forms.Button();
			this.btnTeklifYeni = new System.Windows.Forms.Button();
			this.btnTeklifPrint = new System.Windows.Forms.Button();
			this.pnlCrm = new System.Windows.Forms.Panel();
			this.button10 = new System.Windows.Forms.Button();
			this.button11 = new System.Windows.Forms.Button();
			this.pnlKartlar.SuspendLayout();
			this.pnlList.SuspendLayout();
			this.pnlAdmin.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.ds_users1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).BeginInit();
			this.panel2.SuspendLayout();
			this.panel1.SuspendLayout();
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
			// btnAltAdmin
			// 
			this.btnAltAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnAltAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(162)));
			this.btnAltAdmin.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
			this.btnAltAdmin.Location = new System.Drawing.Point(744, 32);
			this.btnAltAdmin.Name = "btnAltAdmin";
			this.btnAltAdmin.Size = new System.Drawing.Size(75, 30);
			this.btnAltAdmin.TabIndex = 35;
			this.btnAltAdmin.Text = "Admin";
			this.btnAltAdmin.Click += new System.EventHandler(this.btnAltAdmin_Click);
			// 
			// pnlAdmin
			// 
			this.pnlAdmin.Controls.Add(this.button2);
			this.pnlAdmin.Controls.Add(this.button4);
			this.pnlAdmin.Controls.Add(this.button3);
			this.pnlAdmin.Location = new System.Drawing.Point(728, 72);
			this.pnlAdmin.Name = "pnlAdmin";
			this.pnlAdmin.Size = new System.Drawing.Size(280, 48);
			this.pnlAdmin.TabIndex = 36;
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
			this.button2.Click += new System.EventHandler(this.button2_Click);
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
			this.button4.Click += new System.EventHandler(this.button4_Click);
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
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// sqlDataAdapter1
			// 
			this.sqlDataAdapter1.DeleteCommand = this.sqlDeleteCommand1;
			this.sqlDataAdapter1.InsertCommand = this.sqlInsertCommand1;
			this.sqlDataAdapter1.SelectCommand = this.sqlSelectCommand1;
			this.sqlDataAdapter1.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
																									  new System.Data.Common.DataTableMapping("Table", "tbl_users", new System.Data.Common.DataColumnMapping[] {
																																																				   new System.Data.Common.DataColumnMapping("UserID", "UserID"),
																																																				   new System.Data.Common.DataColumnMapping("Name", "Name"),
																																																				   new System.Data.Common.DataColumnMapping("Password", "Password"),
																																																				   new System.Data.Common.DataColumnMapping("Yetki", "Yetki")})});
			this.sqlDataAdapter1.UpdateCommand = this.sqlUpdateCommand1;
			// 
			// sqlDeleteCommand1
			// 
			this.sqlDeleteCommand1.CommandText = "DELETE FROM tbl_users WHERE (UserID = @Original_UserID) AND (Name = @Original_Nam" +
				"e) AND (Password = @Original_Password) AND (Yetki = @Original_Yetki)";
			this.sqlDeleteCommand1.Connection = this.sqlConnection1;
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_UserID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "UserID", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_Name", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Name", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_Password", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Password", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_Yetki", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Yetki", System.Data.DataRowVersion.Original, null));
			// 
			// sqlConnection1
			// 
			this.sqlConnection1.ConnectionString = "workstation id=MCY;packet size=4096;integrated security=SSPI;data source=MCY;pers" +
				"ist security info=False;initial catalog=crm";
			// 
			// sqlInsertCommand1
			// 
			this.sqlInsertCommand1.CommandText = "INSERT INTO tbl_users(Name, Password, Yetki) VALUES (@Name, @Password, @Yetki); S" +
				"ELECT UserID, Name, Password, Yetki FROM tbl_users WHERE (UserID = @@IDENTITY)";
			this.sqlInsertCommand1.Connection = this.sqlConnection1;
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Name", System.Data.SqlDbType.VarChar, 50, "Name"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Password", System.Data.SqlDbType.VarChar, 50, "Password"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Yetki", System.Data.SqlDbType.Int, 4, "Yetki"));
			// 
			// sqlSelectCommand1
			// 
			this.sqlSelectCommand1.CommandText = "SELECT UserID, Name, Password, Yetki FROM tbl_users";
			this.sqlSelectCommand1.Connection = this.sqlConnection1;
			// 
			// sqlUpdateCommand1
			// 
			this.sqlUpdateCommand1.CommandText = @"UPDATE tbl_users SET Name = @Name, Password = @Password, Yetki = @Yetki WHERE (UserID = @Original_UserID) AND (Name = @Original_Name) AND (Password = @Original_Password) AND (Yetki = @Original_Yetki); SELECT UserID, Name, Password, Yetki FROM tbl_users WHERE (UserID = @UserID)";
			this.sqlUpdateCommand1.Connection = this.sqlConnection1;
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Name", System.Data.SqlDbType.VarChar, 50, "Name"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Password", System.Data.SqlDbType.VarChar, 50, "Password"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Yetki", System.Data.SqlDbType.Int, 4, "Yetki"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_UserID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "UserID", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_Name", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Name", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_Password", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Password", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_Yetki", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Yetki", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@UserID", System.Data.SqlDbType.Int, 4, "UserID"));
			// 
			// ds_users1
			// 
			this.ds_users1.DataSetName = "ds_users";
			this.ds_users1.Locale = new System.Globalization.CultureInfo("tr-TR");
			// 
			// dataGrid1
			// 
			this.dataGrid1.CaptionText = "Kullanýcý Hesaplarý";
			this.dataGrid1.DataMember = "";
			this.dataGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.dataGrid1.Location = new System.Drawing.Point(216, 144);
			this.dataGrid1.Name = "dataGrid1";
			this.dataGrid1.Size = new System.Drawing.Size(600, 160);
			this.dataGrid1.TabIndex = 37;
			this.dataGrid1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.myDataGrid_MouseDown);
			// 
			// panel2
			// 
			this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel2.Controls.Add(this.label2);
			this.panel2.Controls.Add(this.panel1);
			this.panel2.Controls.Add(this.label3);
			this.panel2.Controls.Add(this.txtSifre);
			this.panel2.Controls.Add(this.label1);
			this.panel2.Controls.Add(this.btnKayit);
			this.panel2.Controls.Add(this.txtKullanici);
			this.panel2.Location = new System.Drawing.Point(216, 384);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(304, 192);
			this.panel2.TabIndex = 47;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(16, 56);
			this.label2.Name = "label2";
			this.label2.TabIndex = 40;
			this.label2.Text = "Þifresi :";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.radioButton2);
			this.panel1.Controls.Add(this.radioButton1);
			this.panel1.Location = new System.Drawing.Point(128, 88);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(176, 40);
			this.panel1.TabIndex = 45;
			// 
			// radioButton2
			// 
			this.radioButton2.Location = new System.Drawing.Point(88, 8);
			this.radioButton2.Name = "radioButton2";
			this.radioButton2.Size = new System.Drawing.Size(64, 24);
			this.radioButton2.TabIndex = 44;
			this.radioButton2.Text = "User";
			// 
			// radioButton1
			// 
			this.radioButton1.Location = new System.Drawing.Point(8, 8);
			this.radioButton1.Name = "radioButton1";
			this.radioButton1.Size = new System.Drawing.Size(72, 24);
			this.radioButton1.TabIndex = 43;
			this.radioButton1.Text = "Admin";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(16, 96);
			this.label3.Name = "label3";
			this.label3.TabIndex = 42;
			this.label3.Text = "Yetki Durumu :";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txtSifre
			// 
			this.txtSifre.Location = new System.Drawing.Point(128, 56);
			this.txtSifre.Name = "txtSifre";
			this.txtSifre.Size = new System.Drawing.Size(152, 20);
			this.txtSifre.TabIndex = 38;
			this.txtSifre.Text = "";
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(16, 16);
			this.label1.Name = "label1";
			this.label1.TabIndex = 39;
			this.label1.Text = "Kullanýcý Adý :";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// btnKayit
			// 
			this.btnKayit.Location = new System.Drawing.Point(128, 144);
			this.btnKayit.Name = "btnKayit";
			this.btnKayit.Size = new System.Drawing.Size(75, 32);
			this.btnKayit.TabIndex = 41;
			this.btnKayit.Text = "Güncelle";
			this.btnKayit.Click += new System.EventHandler(this.btnKayit_Click);
			// 
			// txtKullanici
			// 
			this.txtKullanici.Location = new System.Drawing.Point(128, 16);
			this.txtKullanici.Name = "txtKullanici";
			this.txtKullanici.Size = new System.Drawing.Size(152, 20);
			this.txtKullanici.TabIndex = 37;
			this.txtKullanici.Text = "";
			// 
			// btnDuzenle
			// 
			this.btnDuzenle.Location = new System.Drawing.Point(232, 328);
			this.btnDuzenle.Name = "btnDuzenle";
			this.btnDuzenle.TabIndex = 48;
			this.btnDuzenle.Text = "Duzenle";
			this.btnDuzenle.Click += new System.EventHandler(this.btnDuzenle_Click);
			// 
			// pnlTeklif
			// 
			this.pnlTeklif.Controls.Add(this.btnTeklifGoruntule);
			this.pnlTeklif.Controls.Add(this.btnTeklifYeni);
			this.pnlTeklif.Controls.Add(this.btnTeklifPrint);
			this.pnlTeklif.Location = new System.Drawing.Point(472, 72);
			this.pnlTeklif.Name = "pnlTeklif";
			this.pnlTeklif.Size = new System.Drawing.Size(272, 48);
			this.pnlTeklif.TabIndex = 105;
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
			this.btnTeklifGoruntule.Click += new System.EventHandler(this.btnTeklifGoruntule_Click);
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
			this.pnlCrm.TabIndex = 113;
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
			// AdminDuzenle
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.BackColor = System.Drawing.Color.PaleGoldenrod;
			this.ClientSize = new System.Drawing.Size(1016, 741);
			this.Controls.Add(this.pnlCrm);
			this.Controls.Add(this.pnlTeklif);
			this.Controls.Add(this.btnDuzenle);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.dataGrid1);
			this.Controls.Add(this.pnlAdmin);
			this.Controls.Add(this.btnAltAdmin);
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
			this.Name = "AdminDuzenle";
			this.Text = "Novateknik CRM";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.Admin_Load);
			this.Closed += new System.EventHandler(this.AdminDuzenle_Closed);
			this.pnlKartlar.ResumeLayout(false);
			this.pnlList.ResumeLayout(false);
			this.pnlAdmin.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.ds_users1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).EndInit();
			this.panel2.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
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
			pnlAdmin.Visible=false;
			pnlTeklif.Visible=false;
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
			pnlKartlar.Visible=false;
			pnlList.Visible=false;
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


		private void myDataGrid_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
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

				duzen =dataGrid1[hti.Row,0].ToString();
			
			}
			Console.WriteLine(message);

		}




		private void Admin_Load(object sender, System.EventArgs e)
		{
			
			SqlConnection yeni = new SqlConnection();
			yeni.ConnectionString = "Data Source=MCY;Integrated Security=SSPI;Initial Catalog=crm";
			SqlDataAdapter verial =new SqlDataAdapter("SELECT * FROM tbl_users ORDER BY tbl_users.UserID DESC", yeni);
			DataSet al=new DataSet();
			verial.Fill(al,"tbl_users");
			dataGrid1.DataSource=al.Tables[0];
	
		}

		private void btnAltAdmin_Click(object sender, System.EventArgs e)
		{	
			pnlTeklif.Visible=false;
			pnlList.Visible=false;
			pnlKartlar.Visible=false;
			pnlAdmin.Visible=true;
			pnlCrm.Visible=false;
		}

		private void button2_Click(object sender, System.EventArgs e)
		{
			Admin yeni=new Admin();
			yeni.Show();
			this.Hide();
		}

		private void button3_Click(object sender, System.EventArgs e)
		{
			AdminDuzenle yeni=new AdminDuzenle();
			yeni.Show();
			this.Hide();

		}

		private void button4_Click(object sender, System.EventArgs e)
		{
			AdminSil yeni=new AdminSil();
			yeni.Show();
			this.Hide();

		}

		private void btnDuzenle_Click(object sender, System.EventArgs e)
		{
			string yetki;

			SqlConnection yeni = new SqlConnection();
			yeni.ConnectionString = "Data Source=MCY;Integrated Security=SSPI;Initial Catalog=crm";
			SqlDataAdapter verial = new SqlDataAdapter("SELECT * FROM tbl_users where UserID ='" + AdminDuzenle.duzen + "'",yeni);
			DataSet al=new DataSet();
			verial.Fill(al,"tbl_users");
			DataTable myDataTable = al.Tables["tbl_users"];
			foreach (DataRow myDataRow in myDataTable.Rows)
			{
				txtKullanici.Text =myDataRow["Name"].ToString();
				txtSifre.Text =myDataRow["Password"].ToString();
				yetki =myDataRow["Yetki"].ToString();
				if(yetki=="2")
				{
					radioButton1.Checked=true;
				}
				if (yetki=="1")
				{
					radioButton2.Checked=true;
				}
			}
		}

		private void btnKayit_Click(object sender, System.EventArgs e)
		{
			DataRow ekle=ds_users1.Tables["tbl_users"].NewRow();
			SqlConnection baglantim = new SqlConnection();
			baglantim.ConnectionString = "Data Source=MCY;Integrated Security=SSPI;Initial Catalog=crm";
			SqlCommand komut = new SqlCommand();
			komut.Connection= baglantim;
			DialogResult dugmesec;
			dugmesec=MessageBox.Show(this,"Kullanýcý bilgilerini güncellemek istediðinizden eminmisiniz?","DÝKKAT",MessageBoxButtons.YesNo);
			if(dugmesec==DialogResult.Yes)
			{
				int hata=0;
				int yetki=0;
				if(txtKullanici.Text.Trim()==""||txtSifre.Text.Trim()=="")
				{
					MessageBox.Show(this,"Eksik alan býraktýnýz.","HATA");
					hata=1;
				}

				if(radioButton1.Checked==true)
				{
					yetki=2;
				}
				if(radioButton2.Checked==true)
				{
					yetki=1;
				}

				if(hata==0)
				{

					komut.CommandText="UPDATE tbl_users SET Name ='" + txtKullanici.Text + "', Password ='" + txtSifre.Text + "', Yetki ='" + yetki + "'where UserID ='" + AdminDuzenle.duzen + "'";
					MessageBox.Show(this,"Yeni kullanýcý kayýt edilmiþtir.","DÝKKAT");

					txtKullanici.ResetText();
					txtSifre.ResetText();
					radioButton1.Checked=false;
					radioButton2.Checked=false;
					txtKullanici.Focus();
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
				{
				}
				SqlConnection yeni = new SqlConnection();
				yeni.ConnectionString = "Data Source=MCY;Integrated Security=SSPI;Initial Catalog=crm";
				SqlDataAdapter verial =new SqlDataAdapter("SELECT * FROM tbl_users ORDER BY tbl_users.UserID DESC", yeni);
				DataSet al=new DataSet();
				verial.Fill(al,"tbl_users");
				dataGrid1.DataSource=al.Tables[0];
	
			}
		}

		private void btnTeklifGoruntule_Click(object sender, System.EventArgs e)
		{
		
		}

		private void AdminDuzenle_Closed(object sender, System.EventArgs e)
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

		private void button1_Click(object sender, System.EventArgs e)
		{
			AdminAnaSayfa yeni=new AdminAnaSayfa();
			yeni.Show();
			this.Hide();

		}
	}
}
