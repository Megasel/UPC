using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.OleDb;
using Excel = Microsoft.Office.Interop.Excel;
namespace MAINPROJECT
{
    public partial class Form1 : Form
    {
        private SqlConnection sqlConnection = null;
        private List<string[]> rows =null;
        private List<string[]> filteredList = null;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            string[] row = null;
            sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["Database1"].ConnectionString);
            sqlConnection.Open();
            SqlDataReader dataReader = null;
            rows = new List<string[]>();
            
            try
            {
                SqlCommand sqlCommand = new SqlCommand("SELECT Name, Surname, StringBirthday, StringTrainingOver FROM Students", sqlConnection);
                dataReader = sqlCommand.ExecuteReader();

                while (dataReader.Read())
                {
                    row = new string[]
                    {
                    Convert.ToString(dataReader["Name"]),
                    Convert.ToString(dataReader["Surname"]),
                    Convert.ToString(dataReader["StringBirthday"]),
                    Convert.ToString(dataReader["StringTrainingOver"])
                    };
                    rows.Add(row);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            finally
            {
                if (dataReader != null && !dataReader.IsClosed)
                {
                    dataReader.Close();

                }
            }
            filteredList = rows.Where((x) => DateTime.Parse(x[3]) < DateTime.Today).ToList();
            RefreshListTrainingOver(filteredList);
            RefreshList(rows);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string[] row = null;
            SqlCommand command = new SqlCommand($"INSERT INTO [Students] (Name,Surname,Birthday,StringBirthday,TrainingOver,StringTrainingOver) VALUES(@Name, @Surname, @Birthday, @StringBirthday, @TrainingOver,@StringTrainingOver)",sqlConnection);
            command.Parameters.AddWithValue("Name", textBox1.Text);
            command.Parameters.AddWithValue("Surname", textBox2.Text);
            command.Parameters.AddWithValue("Birthday", dateTimePicker1.Value);
            command.Parameters.AddWithValue("StringBirthday", dateTimePicker1.Value.Date.ToString("dd/MM/yyyy"));
            command.Parameters.AddWithValue("TrainingOver", dateTimePicker2.Value);
            command.Parameters.AddWithValue("StringTrainingOver", dateTimePicker2.Value.Date.ToString("dd/MM/yyyy"));
            MessageBox.Show(command.ExecuteNonQuery().ToString("Занесено в таблицу"));
            SqlDataReader dataReader = null;
            rows = new List<string[]>();
            try
            {
                SqlCommand sqlCommand = new SqlCommand("SELECT Name, Surname, StringBirthday, StringTrainingOver FROM Students", sqlConnection);
                dataReader = sqlCommand.ExecuteReader();

                while (dataReader.Read())
                {
                    row = new string[]
                    {
                    Convert.ToString(dataReader["Name"]),
                    Convert.ToString(dataReader["Surname"]),
                    Convert.ToString(dataReader["StringBirthday"]),
                    Convert.ToString(dataReader["StringTrainingOver"])
                    };
                    rows.Add(row);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            finally
            {
                if (dataReader != null && !dataReader.IsClosed)
                {
                    dataReader.Close();

                }
            }
            RefreshList(rows);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT Name, Surname, StringBirthday, StringTrainingOver FROM Students", sqlConnection);  
            DataSet dataSet = new DataSet(); 
            dataAdapter.Fill(dataSet);
            dataGridView1.DataSource = dataSet.Tables[0];
        }
        private void RefreshList(List<string[]> list)
        {
            listView2.Items.Clear();
            foreach (string[] s in list)
            {
                listView2.Items.Add(new ListViewItem(s));
            }
            
        }

        private void RefreshListTrainingOver(List<string[]> list)
        {
            listView1.Items.Clear();
            foreach (string[] s in list)
            {
                listView1.Items.Add(new ListViewItem(s));
            }

        }
        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            filteredList = rows.Where((x) => x[1].ToLower().Contains(textBox3.Text.ToLower())).ToList();
            RefreshList(filteredList);
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox2.SelectedIndex)
            {
                case 0:
                    filteredList = rows.Where((x) => DateTime.Parse(x[3]) < DateTime.Today).ToList();
                    RefreshList(filteredList);
                    break;
                case 1:
                    filteredList = rows.Where((x) => DateTime.Parse(x[3]) > DateTime.Today).ToList();
                    RefreshList(filteredList);
                    break;
                case 2:
                    RefreshList(rows);
                    break;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Excel.Application exApp = new Excel.Application();
            exApp.Workbooks.Add();
            Excel.Worksheet wsh = (Excel.Worksheet)exApp.ActiveSheet;
            int i, j;
            for(i = 0; i < dataGridView1.RowCount - 1; i++)
            {
                for (j = 0; j < dataGridView1.ColumnCount; j++)
                {
                    wsh.Cells[i + 1, j + 1] = dataGridView1[j, i].Value.ToString();
                }
            }
            exApp.Visible = true;
        }
    }
}
