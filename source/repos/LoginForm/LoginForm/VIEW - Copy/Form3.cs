﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginForm
{
    public partial class Form3 : Form
    {
        public string id { get =>id ; set => textBox2.Text= value  ; }
        public string firstName { get =>firstName ; set =>textBox3.Text=value; }
        public string lastName { get =>lastName ; set => textBox4.Text=value; }
        public string gender { get => gender;  set { 
                if (gender == "male")
                     radioButton1.Checked=true;
                else radioButton2.Checked=true;

            } }
        public string email { get =>email; set =>textBox5.Text=value ; }
        public DateTime sinhnhat { get =>sinhnhat ; set => dateTimePicker1.Value=value; }
        public string roleUser { get =>roleUser ; set =>comboBox1.Items.Add(value) ; }
        public string SearchValue { get =>SearchValue ; set =>textBox1.Text=value ; }
        public bool IsEdit { get =>IsEdit ; set =>IsEdit=value ; }
        public bool IsSuccessful { get =>IsSuccessful ; set =>IsSuccessful=value ; }
        public bool Message { get =>Message; set =>Message=value ; }

        public Form3()
        {
            InitializeComponent();
        }

       

     

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

    
    }
}