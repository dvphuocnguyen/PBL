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

namespace LoginForm
{
    public partial class Subject : Form
    {
        public Subject()
        {
            InitializeComponent();
            DisplayLevels();
        }
        int Key = 0;
        private void Reset()
        {
            LvNameTb.Text = "";
            Key = 0;
        }
        SqlConnection Con = new SqlConnection(@"Data Source=DESKTOP-455C16V\SQLEXPRESS;Initial Catalog=Quizdb;Integrated Security=True");
        private void DisplayLevels()
        {
            Con.Open();
            string Query = "select * from Levelsstbl";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            LvDGV.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void LvReserbtn_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void LvSavebtn_Click(object sender, EventArgs e)
        {
            if (LvNameTb.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("insert into Levelsstbl (LvName) values (@LvN)", Con);
                    cmd.Parameters.AddWithValue("@LvN", LvNameTb.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Level saved");
                    Con.Close();
                    Reset();
                    DisplayLevels();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void LvDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            LvNameTb.Text = LvDGV.SelectedRows[0].Cells[1].Value.ToString();
            if (LvNameTb.Text == "")
            {
                Key = 0;
            }
            else
            {
                Key = Convert.ToInt32(LvDGV.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        private void LvEditbtn_Click(object sender, EventArgs e)
        {
            if (LvNameTb.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("Update Levelsstbl set LvName=@Lvn where LvId=@LvKey", Con);
                    cmd.Parameters.AddWithValue("@Lvn", LvNameTb.Text);
                    cmd.Parameters.AddWithValue("@LvKey", Key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Level updated");
                    Con.Close();
                    Reset();
                    DisplayLevels();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Candidates obj = new Candidates();
            obj.Show();
            this.Hide();
        }

        private void guna2CirclePictureBox2_Click(object sender, EventArgs e)
        {
            Candidates obj = new Candidates();
            obj.Show();
            this.Hide();
        }

        private void Subject_Load(object sender, EventArgs e)
        {

        }
    }
}
