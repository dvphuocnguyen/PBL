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
    public partial class Exam : Form
    {
        public Exam()
        {
            InitializeComponent();
            multiRandom();
            FetchQuestion();
            timer1.Start();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=DESKTOP-455C16V\SQLEXPRESS;Initial Catalog=Quizdb;Integrated Security=True");
        string a1, a2, a3, a4, a5, a6;
        private int GererateRandom()
        {
            Random rd = new Random();
            int x = rd.Next(1, 4);
            int y = rd.Next(1, 4);
            int z = rd.Next(1, 4);
            //MessageBox.Show("" + x + "and" + y + "and" + z);
            return x;
        }
        int[] Keys = new int[10];
        private void multiRandom()
        {
            HashSet<int> numbers = new HashSet<int>();
            var rnd = new Random();
            while (numbers.Count<6)
            {
                numbers.Add(rnd.Next(1,10));
                
            }
            for(int i = 0; i<6; i++)
            {
                Keys[i] = numbers.ElementAt(i);
            }
        }
        private void FetchQuestion()
        {
            try
            {
                //int QNum = GererateRandom();
                multiRandom();
                Con.Open();
                string Query = "select * from Questiontbl where QId=" + Keys[0] +"";
                SqlCommand cmd = new SqlCommand(Query, Con);
                DataTable dt = new DataTable();
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                sda.Fill(dt);
                for(int i = 0; i<= 4; i++)
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        Q1.Text = dr["QDesc"].ToString();
                        Q1O1.Text = dr["Q1"].ToString();
                        Q1O2.Text = dr["Q2"].ToString();
                        Q1O3.Text = dr["Q3"].ToString();
                        Q1O4.Text = dr["Q4"].ToString();
                        a1 = dr["QA"].ToString();
                }
                }
                string Query1 = "select * from Questiontbl where QId=" + Keys[1] + "";
                cmd = new SqlCommand(Query1, Con);
                dt = new DataTable();
                sda = new SqlDataAdapter(cmd);
                sda.Fill(dt);
                for (int i = 0; i <= 4; i++)
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        Q2.Text = dr["QDesc"].ToString();
                        Q2O1.Text = dr["Q1"].ToString();
                        Q2O2.Text = dr["Q2"].ToString();
                        Q2O3.Text = dr["Q3"].ToString();
                        Q2O4.Text = dr["Q4"].ToString();
                        a2 = dr["QA"].ToString();
                    }
                }
                string Query2 = "select * from Questiontbl where QId=" + Keys[2] + "";
                cmd = new SqlCommand(Query2, Con);
                dt = new DataTable();
                sda = new SqlDataAdapter(cmd);
                sda.Fill(dt);
                for (int i = 0; i <= 4; i++)
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        Q3.Text = dr["QDesc"].ToString();
                        Q3O1.Text = dr["Q1"].ToString();
                        Q3O2.Text = dr["Q2"].ToString();
                        Q3O3.Text = dr["Q3"].ToString();
                        Q3O4.Text = dr["Q4"].ToString();
                        a3 = dr["QA"].ToString();
                    }
                }
                string Query3 = "select * from Questiontbl where QId=" + Keys[3] + "";
                cmd = new SqlCommand(Query3, Con);
                dt = new DataTable();
                sda = new SqlDataAdapter(cmd);
                sda.Fill(dt);
                for (int i = 0; i <= 4; i++)
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        Q4.Text = dr["QDesc"].ToString();
                        Q4O1.Text = dr["Q1"].ToString();
                        Q4O2.Text = dr["Q2"].ToString();
                        Q4O3.Text = dr["Q3"].ToString();
                        Q4O4.Text = dr["Q4"].ToString();
                        a4 = dr["QA"].ToString();
                    }
                }
                string Query4 = "select * from Questiontbl where QId=" + Keys[4] + "";
                cmd = new SqlCommand(Query4, Con);
                dt = new DataTable();
                sda = new SqlDataAdapter(cmd);
                sda.Fill(dt);
                for (int i = 0; i <= 4; i++)
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        Q5.Text = dr["QDesc"].ToString();
                        Q5O1.Text = dr["Q1"].ToString();
                        Q5O2.Text = dr["Q2"].ToString();
                        Q5O3.Text = dr["Q3"].ToString();
                        Q5O4.Text = dr["Q4"].ToString();
                        a5 = dr["QA"].ToString();
                    }
                }
                string Query5 = "select * from Questiontbl where QId=" + Keys[5] + "";
                cmd = new SqlCommand(Query5, Con);
                dt = new DataTable();
                sda = new SqlDataAdapter(cmd);
                sda.Fill(dt);
                for (int i = 0; i <= 4; i++)
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        Q6.Text = dr["QDesc"].ToString();
                        Q6O1.Text = dr["Q1"].ToString();
                        Q6O2.Text = dr["Q2"].ToString();
                        Q6O3.Text = dr["Q3"].ToString();
                        Q6O4.Text = dr["Q4"].ToString();
                        a6 = dr["QA"].ToString();
                    }
                }
                Con.Close();
            }
            catch(Exception Ex)
            {
                MessageBox.Show("");
            }
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Quiz_Click(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton9_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton10_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton11_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton12_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton13_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton14_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton15_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton16_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton17_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton18_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton19_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton20_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
        int chrono = 100;
        int Count = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            chrono-=1;
            Count+=1;
            TimingBar.Value =  Count;
            TimeLbl.Text = "" + chrono;
            if (TimingBar.Value == 100)
            {
                TimingBar.Value = 0;
                timer1.Stop();
                MessageBox.Show("Time over!!");
                Form1 log = new Form1();
                this.Hide();
            }
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }
        int score = 0;
        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void guna2CirclePictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
