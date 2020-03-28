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
	/// Summary description for Ileti.
	/// </summary>
	public class IletiOku : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Button button1;
		private System.Data.SqlClient.SqlDataAdapter sqlDataAdapter1;
		private System.Data.SqlClient.SqlCommand sqlSelectCommand1;
		private System.Data.SqlClient.SqlCommand sqlInsertCommand1;
		private System.Data.SqlClient.SqlCommand sqlUpdateCommand1;
		private System.Data.SqlClient.SqlCommand sqlDeleteCommand1;
		private System.Data.SqlClient.SqlConnection sqlConnection1;
		private deneme.ds_ilet ds_ilet1;
		private System.Windows.Forms.RichTextBox rtbIleti;
		private System.Windows.Forms.DataGrid dataGrid1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
		private deneme.ds_users ds_users1;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public IletiOku()
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
				if(components != null)
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
			this.ds_ilet1 = new deneme.ds_ilet();
			this.button1 = new System.Windows.Forms.Button();
			this.sqlDataAdapter1 = new System.Data.SqlClient.SqlDataAdapter();
			this.sqlDeleteCommand1 = new System.Data.SqlClient.SqlCommand();
			this.sqlConnection1 = new System.Data.SqlClient.SqlConnection();
			this.sqlInsertCommand1 = new System.Data.SqlClient.SqlCommand();
			this.sqlSelectCommand1 = new System.Data.SqlClient.SqlCommand();
			this.sqlUpdateCommand1 = new System.Data.SqlClient.SqlCommand();
			this.rtbIleti = new System.Windows.Forms.RichTextBox();
			this.dataGrid1 = new System.Windows.Forms.DataGrid();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.ds_users1 = new deneme.ds_users();
			((System.ComponentModel.ISupportInitialize)(this.ds_ilet1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ds_users1)).BeginInit();
			this.SuspendLayout();
			// 
			// ds_ilet1
			// 
			this.ds_ilet1.DataSetName = "ds_ilet";
			this.ds_ilet1.Locale = new System.Globalization.CultureInfo("tr-TR");
			// 
			// button1
			// 
			this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(162)));
			this.button1.Location = new System.Drawing.Point(296, 336);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 28);
			this.button1.TabIndex = 1;
			this.button1.Text = "Kapat";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// sqlDataAdapter1
			// 
			this.sqlDataAdapter1.DeleteCommand = this.sqlDeleteCommand1;
			this.sqlDataAdapter1.InsertCommand = this.sqlInsertCommand1;
			this.sqlDataAdapter1.SelectCommand = this.sqlSelectCommand1;
			this.sqlDataAdapter1.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
																									  new System.Data.Common.DataTableMapping("Table", "tbl_ilet", new System.Data.Common.DataColumnMapping[] {
																																																				  new System.Data.Common.DataColumnMapping("UserID", "UserID"),
																																																				  new System.Data.Common.DataColumnMapping("HareketID", "HareketID"),
																																																				  new System.Data.Common.DataColumnMapping("IletiID", "IletiID"),
																																																				  new System.Data.Common.DataColumnMapping("Metin", "Metin")})});
			this.sqlDataAdapter1.UpdateCommand = this.sqlUpdateCommand1;
			// 
			// sqlDeleteCommand1
			// 
			this.sqlDeleteCommand1.CommandText = "DELETE FROM tbl_ilet WHERE (IletiID = @Original_IletiID) AND (HareketID = @Origin" +
				"al_HareketID) AND (Metin = @Original_Metin) AND (UserID = @Original_UserID)";
			this.sqlDeleteCommand1.Connection = this.sqlConnection1;
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_IletiID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "IletiID", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_HareketID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "HareketID", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_Metin", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Metin", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_UserID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "UserID", System.Data.DataRowVersion.Original, null));
			// 
			// sqlConnection1
			// 
			this.sqlConnection1.ConnectionString = "workstation id=MCY;packet size=4096;integrated security=SSPI;data source=MCY;pers" +
				"ist security info=False;initial catalog=crm";
			// 
			// sqlInsertCommand1
			// 
			this.sqlInsertCommand1.CommandText = "INSERT INTO tbl_ilet(UserID, HareketID, Metin) VALUES (@UserID, @HareketID, @Meti" +
				"n); SELECT UserID, HareketID, IletiID, Metin FROM tbl_ilet WHERE (IletiID = @@ID" +
				"ENTITY)";
			this.sqlInsertCommand1.Connection = this.sqlConnection1;
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@UserID", System.Data.SqlDbType.Int, 4, "UserID"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@HareketID", System.Data.SqlDbType.Int, 4, "HareketID"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Metin", System.Data.SqlDbType.VarChar, 255, "Metin"));
			// 
			// sqlSelectCommand1
			// 
			this.sqlSelectCommand1.CommandText = "SELECT UserID, HareketID, IletiID, Metin FROM tbl_ilet";
			this.sqlSelectCommand1.Connection = this.sqlConnection1;
			// 
			// sqlUpdateCommand1
			// 
			this.sqlUpdateCommand1.CommandText = @"UPDATE tbl_ilet SET UserID = @UserID, HareketID = @HareketID, Metin = @Metin WHERE (IletiID = @Original_IletiID) AND (HareketID = @Original_HareketID) AND (Metin = @Original_Metin) AND (UserID = @Original_UserID); SELECT UserID, HareketID, IletiID, Metin FROM tbl_ilet WHERE (IletiID = @IletiID)";
			this.sqlUpdateCommand1.Connection = this.sqlConnection1;
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@UserID", System.Data.SqlDbType.Int, 4, "UserID"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@HareketID", System.Data.SqlDbType.Int, 4, "HareketID"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Metin", System.Data.SqlDbType.VarChar, 255, "Metin"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_IletiID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "IletiID", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_HareketID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "HareketID", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_Metin", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Metin", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_UserID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "UserID", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@IletiID", System.Data.SqlDbType.Int, 4, "IletiID"));
			// 
			// rtbIleti
			// 
			this.rtbIleti.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ds_ilet1, "tbl_ilet.Metin"));
			this.rtbIleti.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.rtbIleti.Location = new System.Drawing.Point(8, 208);
			this.rtbIleti.Name = "rtbIleti";
			this.rtbIleti.ReadOnly = true;
			this.rtbIleti.Size = new System.Drawing.Size(376, 120);
			this.rtbIleti.TabIndex = 0;
			this.rtbIleti.Text = "";
			// 
			// dataGrid1
			// 
			this.dataGrid1.DataMember = "";
			this.dataGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.dataGrid1.Location = new System.Drawing.Point(8, 8);
			this.dataGrid1.Name = "dataGrid1";
			this.dataGrid1.ReadOnly = true;
			this.dataGrid1.Size = new System.Drawing.Size(376, 152);
			this.dataGrid1.TabIndex = 2;
			this.dataGrid1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.myDataGrid_MouseDown);
			// 
			// button2
			// 
			this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(162)));
			this.button2.Location = new System.Drawing.Point(208, 336);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(75, 28);
			this.button2.TabIndex = 3;
			this.button2.Text = "Sil";
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// button3
			// 
			this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(162)));
			this.button3.Location = new System.Drawing.Point(296, 168);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(75, 28);
			this.button3.TabIndex = 4;
			this.button3.Text = "Ýletiyi Oku";
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// ds_users1
			// 
			this.ds_users1.DataSetName = "ds_users";
			this.ds_users1.Locale = new System.Globalization.CultureInfo("tr-TR");
			// 
			// IletiOku
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.BackColor = System.Drawing.Color.PaleGoldenrod;
			this.ClientSize = new System.Drawing.Size(392, 373);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.dataGrid1);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.rtbIleti);
			this.MaximizeBox = false;
			this.Name = "IletiOku";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Ileti Oku";
			this.Load += new System.EventHandler(this.IletiOku_Load);
			((System.ComponentModel.ISupportInitialize)(this.ds_ilet1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ds_users1)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		private void button1_Click(object sender, System.EventArgs e)
		{
			/*
			SqlConnection baglantim = new SqlConnection();
			baglantim.ConnectionString = "Data Source=MCY;Integrated Security=SSPI;Initial Catalog=crm";
			SqlCommand komut = new SqlCommand();
			komut.Connection= baglantim;
			komut.CommandText ="UPDATE tbl_ilet SET Eski ='2' where IletiID ='" + IletiOku.iletigoster + "'";			
			try
			{
				baglantim.Open();
				komut.ExecuteNonQuery();
				baglantim.Close();
			}
			catch
			{}
			*/
			this.Close();
		}


		public static string iletigoster;
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

				iletigoster =dataGrid1[hti.Row,0].ToString();
		
			
			}
			Console.WriteLine(message);

		}


		private void IletiOku_Load(object sender, System.EventArgs e)
		{
			this.ControlBox=false;
			this.FormBorderStyle = FormBorderStyle.FixedSingle;
			SqlConnection yeni2 = new SqlConnection();
			yeni2.ConnectionString = "Data Source=MCY;Integrated Security=SSPI;Initial Catalog=crm";
			SqlDataAdapter verial2 =new SqlDataAdapter("SELECT tbl_ilet.IletiID,tbl_ilet.UserID,tbl_ilet.UserName[Kimden],tbl_ilet.Metin[Ýleti Metini],tbl_ilet.KartID,tbl_mk.Isim[Firma Adý],tbl_ilet.Konu[Hareketin Konusu] FROM tbl_ilet,tbl_mk where tbl_mk.KartID=tbl_ilet.KartID and UserID='"+Giris.userid.ToString()+"' and tbl_ilet.Eski='1' ORDER BY tbl_ilet.IletiID DESC", yeni2);
			DataSet al2=new DataSet();
			verial2.Fill(al2,"tbl_ilet");
			dataGrid1.DataSource=al2.Tables[0];

			DataGridTableStyle stil = new DataGridTableStyle();
			stil.MappingName = al2.Tables[0].TableName;
			stil.AlternatingBackColor =Color.LightGray;
			dataGrid1.TableStyles.Add(stil);
			GridColumnStylesCollection kolonStil = stil.GridColumnStyles;
			kolonStil["UserID"].Width=0;
			kolonStil["IletiID"].Width=0;
			kolonStil["Kimden"].Width=80;
			kolonStil["Ýleti Metini"].Width=200;
			kolonStil["Firma Adý"].Width=100;
			kolonStil["Hareketin Konusu"].Width=150;
			kolonStil["KartID"].Width=0;
			
			
			
		}

		private void button3_Click(object sender, System.EventArgs e)
		{
			SqlConnection yeni = new SqlConnection();
			yeni.ConnectionString = "Data Source=MCY;Integrated Security=SSPI;Initial Catalog=crm";
			SqlDataAdapter verial = new SqlDataAdapter("SELECT * FROM tbl_ilet where IletiID ='" + IletiOku.iletigoster + "'",yeni);
			DataSet al=new DataSet();
			verial.Fill(al,"tbl_ilet");
			DataTable myDataTable = al.Tables["tbl_ilet"];
			foreach (DataRow myDataRow  in myDataTable.Rows)
			{			
				rtbIleti.Text=myDataRow["Metin"].ToString();
			}
		}

		private void button2_Click(object sender, System.EventArgs e)
		{
			SqlConnection baglantim = new SqlConnection();
			baglantim.ConnectionString = "Data Source=MCY;Integrated Security=SSPI;Initial Catalog=crm";
			SqlCommand komut = new SqlCommand();
			komut.Connection= baglantim;
			komut.CommandText ="UPDATE tbl_ilet SET Eski ='0' where IletiID ='" + IletiOku.iletigoster + "'";			
			try
			{
				baglantim.Open();
				komut.ExecuteNonQuery();
				baglantim.Close();
			}
			catch
			{}
			SqlConnection yeni2 = new SqlConnection();
			yeni2.ConnectionString = "Data Source=MCY;Integrated Security=SSPI;Initial Catalog=crm";
			SqlDataAdapter verial2 =new SqlDataAdapter("SELECT tbl_ilet.IletiID,tbl_ilet.UserID,tbl_ilet.UserName[Kimden],tbl_ilet.Metin[Ýleti Metini],tbl_ilet.KartID,tbl_mk.Isim[Firma Adý],tbl_ilet.Konu[Hareketin Konusu] FROM tbl_ilet,tbl_mk where tbl_mk.KartID=tbl_ilet.KartID and UserID='"+Giris.userid.ToString()+"' and tbl_ilet.Eski='1' ORDER BY tbl_ilet.IletiID DESC", yeni2);
			DataSet al2=new DataSet();
			verial2.Fill(al2,"tbl_ilet");
			dataGrid1.DataSource=al2.Tables[0];

		}
	}
}
