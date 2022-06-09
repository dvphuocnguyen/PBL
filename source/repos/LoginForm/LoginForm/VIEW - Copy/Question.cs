using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace LoginForm
{
    public partial class Question : Form
    {
        public Question()
        {
            InitializeComponent();
            GetLevels();
            DisplayQuestion();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=DESKTOP-455C16V\SQLEXPRESS;Initial Catalog=Quizdb;Integrated Security=True");
        private void GetLevels()
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("Select LvName from Levelsstbl", Con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("LvName", typeof(string));
            dt.Load(rdr);
            LvCb.ValueMember = "LvName";
            LvCb.DataSource = dt;

            Con.Close();
        }
        private void Reset()
        {
            QuestTb.Text = "";
            Op1Tb.Text = "";
            Op2Tb.Text = "";
            Op3Tb.Text = "";
            Op4Tb.Text = "";
            AnswerTb.Text = "";
            LvCb.SelectedIndex = 0;
        }
        private void DisplayQuestion()
        {
            Con.Open();
            string Query = "select * from Questiontbl";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            QuestionDGV.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, System.EventArgs e)
        {
            Candidates obj = new Candidates();
            obj.Show();
            this.Hide();
        }
      

        private void guna2CirclePictureBox1_Click(object sender, System.EventArgs e)
        {

        }

        private void Form5_Load(object sender, System.EventArgs e)
        {

        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            QuestTb.Text = QuestionDGV.SelectedRows[0].Cells[1].Value.ToString();
            Op1Tb.Text = QuestionDGV.SelectedRows[0].Cells[2].Value.ToString();
            Op2Tb.Text = QuestionDGV.SelectedRows[0].Cells[3].Value.ToString();
            Op3Tb.Text = QuestionDGV.SelectedRows[0].Cells[5].Value.ToString();
            Op4Tb.Text = QuestionDGV.SelectedRows[0].Cells[6].Value.ToString();
            AnswerTb.Text = QuestionDGV.SelectedRows[0].Cells[6].Value.ToString();
            LvCb.SelectedValue = QuestionDGV.SelectedRows[0].Cells[7].Value.ToString();
            if (QuestTb.Text == "")
            {
                Key = 0;
            }
            else
            {
                Key = Convert.ToInt32(QuestionDGV.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, System.EventArgs e)
        {

        }

        private void guna2TextBox3_TextChanged(object sender, System.EventArgs e)
        {

        }

        private void guna2TextBox6_TextChanged(object sender, System.EventArgs e)
        {

        }

        private void guna2TextBox5_TextChanged(object sender, System.EventArgs e)
        {

        }

        private void guna2TextBox4_TextChanged(object sender, System.EventArgs e)
        {

        }

        private void guna2TextBox2_TextChanged(object sender, System.EventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged(object sender, System.EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuThinButton23_Click(object sender, System.EventArgs e)
        {
            Reset();
        }
        int Key = 0;
        private void bunifuThinButton22_Click(object sender, System.EventArgs e)
        {
            if (QuestTb.Text == "" || Op1Tb.Text == "" || Op2Tb.Text == "" || Op3Tb.Text == "" || Op4Tb.Text == "" || AnswerTb.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("Update Questiontbl set QDesc=@Qd,Q1=@Q1,Q2=@Q2,Q3=@Q3,Q4=@Q4,QA=@QA,QS=@QS  where QId=@QKey", Con);
                    cmd.Parameters.AddWithValue("@Qd", QuestTb.Text);
                    cmd.Parameters.AddWithValue("@Q1", Op1Tb.Text);
                    cmd.Parameters.AddWithValue("@Q2", Op2Tb.Text);
                    cmd.Parameters.AddWithValue("@Q3", Op3Tb.Text);
                    cmd.Parameters.AddWithValue("@Q4", Op4Tb.Text);
                    cmd.Parameters.AddWithValue("@QA", AnswerTb.Text);
                    cmd.Parameters.AddWithValue("@QS", LvCb.SelectedValue.ToString());
                    cmd.Parameters.AddWithValue("@QKey", Key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Member Updated ");
                    Con.Close();
                    Reset();
                    DisplayQuestion();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void BunifuThinButton21_Click(object sender, System.EventArgs e)
        {
            if (QuestTb.Text == "" || Op1Tb.Text == "" || Op2Tb.Text == "" || Op3Tb.Text == "" || Op4Tb.Text == "" || AnswerTb.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("insert into Questiontbl (QDesc,Q1,Q2,Q3,Q4,QA,QS) values (@Qd,@Q1,@Q2,@Q3,@Q4,@QA,@QS)", Con);
                    cmd.Parameters.AddWithValue("@Qd", QuestTb.Text);
                    cmd.Parameters.AddWithValue("@Q1", Op1Tb.Text);
                    cmd.Parameters.AddWithValue("@Q2", Op2Tb.Text);
                    cmd.Parameters.AddWithValue("@Q3", Op3Tb.Text);
                    cmd.Parameters.AddWithValue("@Q4", Op4Tb.Text);
                    cmd.Parameters.AddWithValue("@QA", AnswerTb.Text);
                    cmd.Parameters.AddWithValue("@QS", LvCb.SelectedValue.ToString());
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Member Added ");
                    Con.Close();
                    Reset();
                    DisplayQuestion();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void guna2PictureBox2_Click(object sender, System.EventArgs e)
        {
            Subject obj = new Subject();
            obj.Show();
            this.Hide();
        }

        private void guna2PictureBox1_Click(object sender, System.EventArgs e)
        {

        }

        private void guna2CirclePictureBox2_Click(object sender, System.EventArgs e)
        {
            Candidates obj = new Candidates();
            obj.Show();
            this.Hide();

        }

        private void LvCb_SelectedIndexChanged(object sender, System.EventArgs e)
        {

        }
    }
}
