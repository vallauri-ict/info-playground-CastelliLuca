using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace TriggerTestAssieme
{
    public partial class Form1 : Form
    {
        public static readonly string workingDirectory = Environment.CurrentDirectory;
        public static readonly string projectDirectory = Directory.GetParent(workingDirectory).Parent.Parent.FullName;
        public static readonly string CONNECTION_STRING = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + projectDirectory + @"\DriverDB.mdf;Integrated Security=True;Connect Timeout=30";

        private BindingSource bsDriver = new BindingSource();
        private BindingSource bsDriverCountry = new BindingSource();
        private DataTable dtDriver, dtDriverCountry;
        private SqlDataAdapter daDriver, daDriverCountry;

        private void OnRowsDeletedDriver(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            daDriver.Update(dtDriver);
            //MessageBox.Show("Riga cancellata su DB");
        }

        private void btnAggDB_Click(object sender, EventArgs e)
        {
            PopulateDgv(1);
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Query(string selectCommand, out SqlDataAdapter da)
        {
            da = null;
            try
            {
                // Crea un nuovo data adapter basato su selectCommand
                da = new SqlDataAdapter(selectCommand, CONNECTION_STRING);

                // Creo un command builder per generare un comando SQL update, insert, delete
                SqlCommandBuilder commandBuilder = new SqlCommandBuilder(da);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnFunction2_Click(object sender, EventArgs e)
        {
            int podiumsNumber = Convert.ToInt32(Interaction.InputBox("Inserisci podi"));
            SqlConnection sqlConnection = new SqlConnection(CONNECTION_STRING);
            string sql = "SELECT dbo.F2(" + podiumsNumber + ")";
            SqlCommand cmd = new SqlCommand(sql, sqlConnection);
            sqlConnection.Open();
            SqlDataReader ra = cmd.ExecuteReader();
            while (ra.Read())
            {
                MessageBox.Show("Num: "+ra.GetInt32(0).ToString());
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PopulateDgv(0);
        }

        private void PopulateDgv(int tables)
        {
            switch (tables)
            {
                case 0:
                    dgvDriver.DataSource = bsDriver;
                    Query("SELECT * FROM Driver", out daDriver);
                    if (daDriver != null)
                    {
                        dtDriver = new DataTable();
                        daDriver.Fill(dtDriver);
                        bsDriver.DataSource = dtDriver;
                    }
                    dgvDriver.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader);
                    break;
                case 1:
                    DataTable retval = new DataTable();
                    char country =Convert.ToChar(Interaction.InputBox("Inserisci country"));
                    SqlConnection sqlConnection = new SqlConnection(CONNECTION_STRING);
                    string sql = "SELECT dbo.F1(" + country + ")";
                    SqlCommand cmd = new SqlCommand(sql, sqlConnection);
                    sqlConnection.Open();
                    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);
                    sqlDataAdapter.Fill(retval);
                    sqlDataAdapter.Dispose();
                    dgvDriverCountry.DataSource = retval;
                    dgvDriverCountry.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader);
                    break;
            }
        }
    }
}
