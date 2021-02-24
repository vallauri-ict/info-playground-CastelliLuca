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

        private void btnAggDB_Click(object sender, EventArgs e)
        {
            PopulateDgv(0);
            PopulateDgv(1);
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void PopulateDgv(int tables)
        {
            switch (tables)
            {
                case 0:
                    SqlConnection con = new SqlConnection(CONNECTION_STRING);
                    con.Open();
                    string sql = "CercaAggiornamentiData";

                    SqlCommand cmd = new SqlCommand(sql, con); 
                    SqlParameter data = new SqlParameter();
                    data.ParameterName = "data";
                    data.Direction = ParameterDirection.Input;
                    data.DbType = DbType.DateTime;
                    data.Value = "04/10/2002";
                    cmd.Parameters.Add(data);

                    cmd.CommandText = "CercaAggiornamentiData";
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        for (int i = 0; i < reader.FieldCount; i++)
                        {
                            dgvAggiornamenti.Rows.Add(reader.GetValue(0));
                        }
                    }
                    break;
                case 1:
                    con = new SqlConnection(CONNECTION_STRING);
                    con.Open();
                    string sqla = "CercaCancellazioniData";
                    con.Open();

                    cmd = new SqlCommand(sqla, con);
                    data = new SqlParameter();
                    data.ParameterName = "data";
                    data.Direction = ParameterDirection.Input;
                    data.DbType = DbType.DateTime;
                    data.Value = "04/10/2002";
                    cmd.Parameters.Add(data);

                    cmd.CommandText = "CercaAggiornamentiData";
                    reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        for (int i = 0; i < reader.FieldCount; i++)
                        {
                            dgvAggiornamenti.Rows.Add(reader.GetValue(0));
                        }
                    }
                    break;
            }
        }
    }
}
