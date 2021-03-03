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
        public const string PATH = @"C:\data\formulaoneBelly\";
        public const string CONNECTION_STRING = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + PATH + "formulaone.mdf;Integrated Security=True";

        private void btnAggDB_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(CONNECTION_STRING);
            con.Open();
            string sql = "Procedure";

            SqlCommand cmd = new SqlCommand(sql, con);
            SqlParameter data = new SqlParameter();
            data.ParameterName = "data";
            data.Direction = ParameterDirection.Input;
            data.DbType = DbType.DateTime;
            data.Value = "04/10/2002";
            cmd.Parameters.Add(data);

            cmd.CommandText = "Procedure";

            SqlDataReader reader = cmd.ExecuteReader();
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }
    }
}
