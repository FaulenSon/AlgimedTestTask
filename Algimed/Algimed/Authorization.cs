using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Algimed
{
    public partial class Authorization : Form
    {
        public SqlConnection sqlConnection = null;
        public Authorization()
        {
            InitializeComponent();
        }

        private async void Login_Click(object sender, EventArgs e)
        {
            string userName = textBoxName.Text;
            string userPassword = textBoxPassword.Text;
            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter();
            using (SqlCommand textBoxData = new SqlCommand("SELECT * FROM [AUTHORIZATION] WHERE Name = @userName AND Password = @userPassword", sqlConnection))
            {
                try
                {
                    if (sqlConnection.State != ConnectionState.Open)
                    {
                        await sqlConnection.OpenAsync();
                    }
                    textBoxData.Parameters.Add("@userName", SqlDbType.VarChar).Value = userName;
                    textBoxData.Parameters.Add("@userPassword", SqlDbType.VarChar).Value = userPassword;
                    adapter.SelectCommand = textBoxData;
                    adapter.Fill(table);
                    if (table.Rows.Count > 0)
                    {
                        MessageBox.Show("User found");
                        this.Hide();
                        var menu = new Menu();
                        menu.Closed += (s, args) => this.Close();
                        menu.Show();
                    }
                    else
                        MessageBox.Show("This user was not found");
                }
                catch (Exception)
                {
                    throw;
                }
                finally
                {
                    if (sqlConnection.State != ConnectionState.Closed)
                    {
                        sqlConnection.Close();
                    }
                }
            }
        }

        private void Authorization_Load(object sender, EventArgs e)
        {
            sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["Algimed.Properties.Settings.DatabaseConnectionString"].ConnectionString);
        }
    }
}
