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

namespace ProjectV28
{
    public partial class Form1 : Form
    {
        string connectionString = @"Data Source=1U12PC;Initial Catalog=Students;Integrated Security=True;";

        DataSet ds;
        string spetsialnosti = "SELECT * FROM spetsialnosti";

        DataSet ds2;
        string gruppa = "SELECT * FROM gruppa";

        DataSet ds3;
        string Students = "SELECT * FROM Students";

        SqlDataAdapter adapter;
        SqlCommandBuilder commandBuilder;
        
        
        

        public Form1()
        {
            InitializeComponent();

            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.AllowUserToAddRows = false;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                adapter = new SqlDataAdapter(spetsialnosti, connection);
                ds = new DataSet();
                adapter.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];                


                adapter = new SqlDataAdapter(gruppa, connection);
                ds2 = new DataSet();
                adapter.Fill(ds2);
                dataGridView2.DataSource = ds2.Tables[0];
                dataGridView2.Columns["id_grupp"].Visible = false;


                adapter = new SqlDataAdapter(Students, connection);
                ds3 = new DataSet();
                adapter.Fill(ds3);
                dataGridView3.DataSource = ds3.Tables[0];
                dataGridView3.Columns["id_grupp"].Visible = false;
                dataGridView3.Columns["id_students"].Visible = false;
            }
        }

        private void AddButon_Click(object sender, EventArgs e)
        {
            DataRow row = ds.Tables[0].NewRow();
            ds.Tables[0].Rows.Add(row);

        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                dataGridView1.Rows.Remove(row);
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                adapter = new SqlDataAdapter(spetsialnosti, connection);
                commandBuilder = new SqlCommandBuilder(adapter);
                adapter.Update(ds);
                dataGridView1.Update();
            }
        }

        private void DataGridView1_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            string a = dataGridView1.CurrentRow.Cells["name"].Value.ToString();
            label1.Text = a;
            string specialtyFilter = "SELECT * FROM gruppa WHERE name_spetsialnosti =  '" + a + "';";
            adapter = new SqlDataAdapter(specialtyFilter, connectionString);
            ds2 = new DataSet();

            adapter.Fill(ds2);
            dataGridView2.DataSource = ds2.Tables[0];
        }

        private void DataGridView2_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            SqlDataAdapter adapter2;
            string a = dataGridView2.CurrentRow.Cells["id_grupp"].Value.ToString();
            label2.Text = a;
            string StudentsFilter = "SELECT * FROM Students WHERE id_grupp =  '" + a + "';";
            adapter2 = new SqlDataAdapter(StudentsFilter, connectionString);
            ds3 = new DataSet();

            adapter2.Fill(ds3);
            dataGridView3.DataSource = ds3.Tables[0];
        }
    }
}
