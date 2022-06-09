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
namespace LoginForm
{
    public partial class Candidates : Form
    {
        public Candidates()
        {
            InitializeComponent();
            DisplayMembers();
        }
        private void Reset()
        {
            MbNameTb.Text = "";
            MbAgeTb.Text = "";
            MbPhoneTb.Text = "";
            MbAddressTb.Text = "";
            MbPasswordTb.Text = "";

        }
        SqlConnection Con = new SqlConnection(@"Data Source=DESKTOP-455C16V\SQLEXPRESS;Initial Catalog=Quizdb;Integrated Security=True");
       

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Candidates_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void DisplayMembers ()
        {
            Con.Open();
            string Query = "select * from Memberstbl";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            MbDGV.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void SaveBtn_Click(object sender, EventArgs e)
        {
            if (MbNameTb.Text == "" || MbAgeTb.Text == "" || MbPasswordTb.Text == "" || MbAddressTb.Text == "" || MbPhoneTb.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    int score = 0;
                    Con.Open();
                    SqlCommand cmd  = new SqlCommand("insert into Memberstbl (MName,MAge,MPass,MScore,MPhone,Madd) values (@Mn,@Ma,@Mp,@Ms,@Mph,@Mad)", Con) ;
                    cmd.Parameters.AddWithValue("@Mn", MbNameTb.Text);
                    cmd.Parameters.AddWithValue("@Ma", MbAgeTb.Text);
                    cmd.Parameters.AddWithValue("@Mp", MbPasswordTb.Text);
                    cmd.Parameters.AddWithValue("@Ms", score);
                    cmd.Parameters.AddWithValue("@Mph", MbPhoneTb.Text);
                    cmd.Parameters.AddWithValue("@Mad", MbAddressTb.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Member saved");
                    Con.Close();
                    Reset();
                    DisplayMembers();
                }
                catch(Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void ResetBtn_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            if (MbNameTb.Text == "" || MbAgeTb.Text == "" || MbPasswordTb.Text == "" || MbAddressTb.Text == "" || MbPhoneTb.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("Update Memberstbl set MName=@Mn,MAge=@Ma,MPass=@Mp,MAdd=@Mad,MPhone=@Mph where MemId=@MKey", Con);
                    cmd.Parameters.AddWithValue("@Mn", MbNameTb.Text);
                    cmd.Parameters.AddWithValue("@Ma", MbAgeTb.Text);
                    cmd.Parameters.AddWithValue("@Mp", MbPasswordTb.Text);
                    cmd.Parameters.AddWithValue("@Mph", MbPhoneTb.Text);
                    cmd.Parameters.AddWithValue("@Mad", MbAddressTb.Text);
                    cmd.Parameters.AddWithValue("@MKey", key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Member updated");
                    Con.Close();
                    Reset();
                    DisplayMembers();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }
        int key = 0;
        private void MbDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            MbNameTb.Text = MbDGV.SelectedRows[0].Cells[1].Value.ToString();
            MbAgeTb.Text = MbDGV.SelectedRows[0].Cells[2].Value.ToString();
            MbPasswordTb.Text = MbDGV.SelectedRows[0].Cells[3].Value.ToString();
            MbPhoneTb.Text = MbDGV.SelectedRows[0].Cells[5].Value.ToString();
            MbAddressTb.Text = MbDGV.SelectedRows[0].Cells[6].Value.ToString();
            if(MbNameTb.Text == "")
            {
                key = 0;
            }else
            {
                key = Convert.ToInt32(MbDGV.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Subject obj = new Subject();
            obj.Show();
            this.Hide();

        }

        private void guna2PictureBox2_Click(object sender, EventArgs e)
        {
            Subject obj = new Subject();
            obj.Show();
            this.Hide();
        }
    }
}
