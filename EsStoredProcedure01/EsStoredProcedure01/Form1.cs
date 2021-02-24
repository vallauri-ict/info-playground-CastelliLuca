using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace EsStoredProcedure01
{
    
    public partial class Form1 : Form
    {
        public static readonly string workingDirectory = Environment.CurrentDirectory;
        public static readonly string projectDirectory = Directory.GetParent(workingDirectory).Parent.Parent.FullName;
        public static readonly string CONNECTION_STRING = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + projectDirectory + @"\DBBanche.mdf;Integrated Security=True;Connect Timeout=30";
        public Form1()
        {
            InitializeComponent();
            using (SqlConnection con = new SqlConnection(CONNECTION_STRING))
            {
                string sql = "CercaFiliali";
                con.Open();

                SqlCommand cmd = new SqlCommand(sql, con);
                SqlParameter nomeBanca = new SqlParameter();
                nomeBanca.ParameterName = "nomeBanca";
                nomeBanca.Direction = ParameterDirection.Input;
                nomeBanca.DbType = DbType.String;
                nomeBanca.Size = 50;
                nomeBanca.Value = "CRF";
                cmd.Parameters.Add(nomeBanca);

                SqlParameter comune = new SqlParameter();
                comune.ParameterName = "comune";
                comune.Direction = ParameterDirection.Input;
                comune.DbType = DbType.String;
                comune.Size = 50;
                comune.Value = "Genola";
                cmd.Parameters.Add(comune);


                cmd.CommandText = "CercaFiliali";

                int ris=cmd.ExecuteNonQuery();

                MessageBox.Show("Ris: "+ris);


                cmd.CommandText = "cercaFiliali2";
                SqlDataReader reader= cmd.ExecuteReader();

                while(reader.Read())
                {
                    string s = "";
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        s += reader.GetValue(0);
                    }
                    MessageBox.Show(s);
                }




            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
