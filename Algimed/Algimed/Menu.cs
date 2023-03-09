using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace Algimed
{
    public partial class Menu : Form
    {
        private SqlConnection sqlConnection = null;
        List<Data> data = new List<Data>();
        bool boolLoadData;
        bool boolCreateMatrix;
        bool boolLogin;
        public Menu()
        {
            InitializeComponent();
        }

        private void BoolLoadData_Click()
        {
            OpenFileDialog OFD = new OpenFileDialog();
            OFD.Filter = "csv files (*.csv)|*.csv";
            OFD.ShowDialog();
            string fileName = OFD.FileName;
            if (fileName == "")
            {
                boolLoadData = false;
                MessageBox.Show("Please, select a file");
            }
            else
            {
                boolLoadData = true;
                this.data = Data.LoadFile(fileName);
                dataGridViewListData.DataSource = this.data;
            } 
        }
        private void LoadData_Click(object sender, EventArgs e)
        {
            BoolLoadData_Click();
        }

        private void BoolCreateMatrix_Click()
        {
            if (boolLoadData == true)
            {
                boolCreateMatrix = true;
                dataGridViewMatrix.DefaultCellStyle.Format = "n2";
                dataGridViewMatrix.ColumnCount = 3;
                dataGridViewMatrix.RowCount = 3;
                //создание наименования у столбцов матрицы
                for (var i = 0; i < dataGridViewMatrix.ColumnCount; i++)
                {
                    dataGridViewMatrix.Columns[i].Name = data[i].CellA;
                }
                //создание наименования у строк матрицы
                for (var i = 0; i < dataGridViewMatrix.RowCount; i++)
                {
                    dataGridViewMatrix.Rows[i].HeaderCell.Value = data[i + 3].CellA;
                }
                // заполнение значений ячеек по результатам арифметической операции
                for (var i = 0; i < dataGridViewMatrix.RowCount; i++)
                {
                    for (var j = 0; j < dataGridViewMatrix.ColumnCount; j++)
                    {
                        dataGridViewMatrix.Rows[i].Cells[j].Value = Math.Pow((data[j].CellF - data[i + 3].CellF), 2);
                    }
                }
            }
            else
            {
                boolCreateMatrix = false;
                MessageBox.Show("Please upload the data");
            }
        }
        private void CreateMatrix_Click(object sender, EventArgs e)
        {
            BoolCreateMatrix_Click();
        }

        private void SaveDataBase_Click(object sender, EventArgs e)
        {
            if (boolCreateMatrix == true)
            {
                panelLogin.Visible = true;
            }
            else
                MessageBox.Show("Create a matrix");
        }

        private async void Login()
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
                        boolLogin = true;
                    }
                    else
                    {
                        boolLogin = false;
                    }
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
        private async void Login_Click(object sender, EventArgs e)
        {
            Login();
            if (boolLogin == true)
            {
                MessageBox.Show("User found");
                panelLogin.Visible = false;
                try
                {
                    if (sqlConnection.State != ConnectionState.Open)
                    {
                        await sqlConnection.OpenAsync();
                    }
                    using (var transaction = sqlConnection.BeginTransaction())
                        try
                        {
                            using (SqlCommand command = new SqlCommand("INSERT INTO [CellsValue] (Cells, Value) VALUES (@Cells, @Value)", sqlConnection, transaction))
                            {
                                for (var i = 0; i < dataGridViewMatrix.RowCount; i++)
                                {
                                    for (var j = 0; j < dataGridViewMatrix.ColumnCount; j++)
                                    {
                                        command.Parameters.Clear();
                                        var cells = GetCells(data[j].CellA.ToString(), data[i + 3].CellA.ToString());
                                        command.Parameters.AddWithValue("Cells", cells);
                                        var value = GetValue(data[j].CellF, data[i + 3].CellF);
                                        command.Parameters.AddWithValue("Value", value);
                                        command.ExecuteNonQuery();
                                    }
                                }

                                transaction.Commit();
                            }
                        }
                        catch
                        {
                            transaction.Rollback();
                            throw;
                        }
                }
                catch
                {
                    throw;
                }
                finally
                {
                    if (sqlConnection.State != ConnectionState.Closed)
                    {
                        sqlConnection.Close();
                    }
                    ShowDataFromDb();
                }
            }
            else
                MessageBox.Show("This user was not found");
        }
        private async void ShowDataFromDb()
        {
            using (SqlCommand tableData = new SqlCommand(
                $"SELECT TOP({dataGridViewMatrix.RowCount * dataGridViewMatrix.ColumnCount}) * FROM [CellsValue] ORDER BY [id] DESC", sqlConnection))
            {
                try
                {
                    if (sqlConnection.State != ConnectionState.Open)
                    {
                        await sqlConnection.OpenAsync();
                    }
                    using (SqlDataReader reader = tableData.ExecuteReader())
                    {
                        List<string[]> tableDataGrid = new List<string[]>();
                        while (reader.Read())
                        {
                            tableDataGrid.Add(new string[3]);
                            tableDataGrid[tableDataGrid.Count - 1][0] = reader[0].ToString();
                            tableDataGrid[tableDataGrid.Count - 1][1] = reader[1].ToString();
                            tableDataGrid[tableDataGrid.Count - 1][2] = reader[2].ToString();
                        }

                        foreach (string[] s in tableDataGrid)
                        {
                            dataGridViewDataBase.Rows.Add(s);
                        }
                    }

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
        private string GetCells(string cell_1, string cell_2)
        {
            return cell_1 + "_" + cell_2;
        }

        private double GetValue(double value_1, double value_2)
        {
            return Math.Round(Math.Pow((value_1 - value_2), 2), 2);
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            panelLogin.Visible = false;
            sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["Algimed.Properties.Settings.DatabaseConnectionString"].ConnectionString );
        }

        private void buttonClosePanel_Click(object sender, EventArgs e)
        {
            panelLogin.Visible = false;
        }
    }
}
