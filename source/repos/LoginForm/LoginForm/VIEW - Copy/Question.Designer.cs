namespace LoginForm
{
    partial class Question
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Question));
            this.panel1 = new System.Windows.Forms.Panel();
            this.LvCb = new System.Windows.Forms.ComboBox();
            this.QuestionDGV = new Guna.UI2.WinForms.Guna2DataGridView();
            this.QuestResetBtn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.QuestEditBtn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.QuestSaveBtn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.Op2Tb = new Guna.UI2.WinForms.Guna2TextBox();
            this.AnswerTb = new Guna.UI2.WinForms.Guna2TextBox();
            this.Op4Tb = new Guna.UI2.WinForms.Guna2TextBox();
            this.Op3Tb = new Guna.UI2.WinForms.Guna2TextBox();
            this.Op1Tb = new Guna.UI2.WinForms.Guna2TextBox();
            this.QuestTb = new Guna.UI2.WinForms.Guna2TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.QuestText = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Quiz = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.guna2PictureBox2 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2CirclePictureBox2 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.QuestionDGV)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel1.Controls.Add(this.LvCb);
            this.panel1.Controls.Add(this.QuestionDGV);
            this.panel1.Controls.Add(this.QuestResetBtn);
            this.panel1.Controls.Add(this.QuestEditBtn);
            this.panel1.Controls.Add(this.QuestSaveBtn);
            this.panel1.Controls.Add(this.Op2Tb);
            this.panel1.Controls.Add(this.AnswerTb);
            this.panel1.Controls.Add(this.Op4Tb);
            this.panel1.Controls.Add(this.Op3Tb);
            this.panel1.Controls.Add(this.Op1Tb);
            this.panel1.Controls.Add(this.QuestTb);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.QuestText);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.Quiz);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 20, 3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1417, 675);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // LvCb
            // 
            this.LvCb.FormattingEnabled = true;
            this.LvCb.Location = new System.Drawing.Point(1017, 50);
            this.LvCb.Name = "LvCb";
            this.LvCb.Size = new System.Drawing.Size(114, 28);
            this.LvCb.TabIndex = 7;
            this.LvCb.Text = "Levels";
            this.LvCb.SelectedIndexChanged += new System.EventHandler(this.LvCb_SelectedIndexChanged);
            // 
            // QuestionDGV
            // 
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            this.QuestionDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.QuestionDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.QuestionDGV.BackgroundColor = System.Drawing.Color.White;
            this.QuestionDGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.QuestionDGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.QuestionDGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.QuestionDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.QuestionDGV.ColumnHeadersHeight = 4;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.QuestionDGV.DefaultCellStyle = dataGridViewCellStyle9;
            this.QuestionDGV.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.QuestionDGV.EnableHeadersVisualStyles = false;
            this.QuestionDGV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.QuestionDGV.Location = new System.Drawing.Point(0, 412);
            this.QuestionDGV.Margin = new System.Windows.Forms.Padding(30);
            this.QuestionDGV.Name = "QuestionDGV";
            this.QuestionDGV.RowHeadersVisible = false;
            this.QuestionDGV.RowHeadersWidth = 62;
            this.QuestionDGV.RowTemplate.Height = 28;
            this.QuestionDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.QuestionDGV.Size = new System.Drawing.Size(1291, 263);
            this.QuestionDGV.TabIndex = 6;
            this.QuestionDGV.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.QuestionDGV.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.QuestionDGV.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.QuestionDGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.QuestionDGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.QuestionDGV.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.QuestionDGV.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.QuestionDGV.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.QuestionDGV.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.QuestionDGV.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.QuestionDGV.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.QuestionDGV.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.QuestionDGV.ThemeStyle.HeaderStyle.Height = 4;
            this.QuestionDGV.ThemeStyle.ReadOnly = false;
            this.QuestionDGV.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.QuestionDGV.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.QuestionDGV.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.QuestionDGV.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.QuestionDGV.ThemeStyle.RowsStyle.Height = 28;
            this.QuestionDGV.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.QuestionDGV.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.QuestionDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.guna2DataGridView1_CellContentClick);
            // 
            // QuestResetBtn
            // 
            this.QuestResetBtn.ActiveBorderThickness = 1;
            this.QuestResetBtn.ActiveCornerRadius = 20;
            this.QuestResetBtn.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.QuestResetBtn.ActiveForecolor = System.Drawing.Color.White;
            this.QuestResetBtn.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.QuestResetBtn.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.QuestResetBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("QuestResetBtn.BackgroundImage")));
            this.QuestResetBtn.ButtonText = "Reset";
            this.QuestResetBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.QuestResetBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuestResetBtn.ForeColor = System.Drawing.Color.SeaGreen;
            this.QuestResetBtn.IdleBorderThickness = 1;
            this.QuestResetBtn.IdleCornerRadius = 20;
            this.QuestResetBtn.IdleFillColor = System.Drawing.Color.White;
            this.QuestResetBtn.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.QuestResetBtn.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.QuestResetBtn.Location = new System.Drawing.Point(840, 287);
            this.QuestResetBtn.Margin = new System.Windows.Forms.Padding(5);
            this.QuestResetBtn.Name = "QuestResetBtn";
            this.QuestResetBtn.Size = new System.Drawing.Size(130, 43);
            this.QuestResetBtn.TabIndex = 5;
            this.QuestResetBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.QuestResetBtn.Click += new System.EventHandler(this.bunifuThinButton23_Click);
            // 
            // QuestEditBtn
            // 
            this.QuestEditBtn.ActiveBorderThickness = 1;
            this.QuestEditBtn.ActiveCornerRadius = 20;
            this.QuestEditBtn.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.QuestEditBtn.ActiveForecolor = System.Drawing.Color.White;
            this.QuestEditBtn.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.QuestEditBtn.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.QuestEditBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("QuestEditBtn.BackgroundImage")));
            this.QuestEditBtn.ButtonText = "Edit";
            this.QuestEditBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.QuestEditBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuestEditBtn.ForeColor = System.Drawing.Color.SeaGreen;
            this.QuestEditBtn.IdleBorderThickness = 1;
            this.QuestEditBtn.IdleCornerRadius = 20;
            this.QuestEditBtn.IdleFillColor = System.Drawing.Color.White;
            this.QuestEditBtn.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.QuestEditBtn.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.QuestEditBtn.Location = new System.Drawing.Point(562, 287);
            this.QuestEditBtn.Margin = new System.Windows.Forms.Padding(5);
            this.QuestEditBtn.Name = "QuestEditBtn";
            this.QuestEditBtn.Size = new System.Drawing.Size(130, 43);
            this.QuestEditBtn.TabIndex = 5;
            this.QuestEditBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.QuestEditBtn.Click += new System.EventHandler(this.bunifuThinButton22_Click);
            // 
            // QuestSaveBtn
            // 
            this.QuestSaveBtn.ActiveBorderThickness = 1;
            this.QuestSaveBtn.ActiveCornerRadius = 20;
            this.QuestSaveBtn.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.QuestSaveBtn.ActiveForecolor = System.Drawing.Color.White;
            this.QuestSaveBtn.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.QuestSaveBtn.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.QuestSaveBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("QuestSaveBtn.BackgroundImage")));
            this.QuestSaveBtn.ButtonText = "Save";
            this.QuestSaveBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.QuestSaveBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuestSaveBtn.ForeColor = System.Drawing.Color.SeaGreen;
            this.QuestSaveBtn.IdleBorderThickness = 1;
            this.QuestSaveBtn.IdleCornerRadius = 20;
            this.QuestSaveBtn.IdleFillColor = System.Drawing.Color.White;
            this.QuestSaveBtn.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.QuestSaveBtn.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.QuestSaveBtn.Location = new System.Drawing.Point(227, 287);
            this.QuestSaveBtn.Margin = new System.Windows.Forms.Padding(5);
            this.QuestSaveBtn.Name = "QuestSaveBtn";
            this.QuestSaveBtn.Size = new System.Drawing.Size(130, 43);
            this.QuestSaveBtn.TabIndex = 5;
            this.QuestSaveBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.QuestSaveBtn.Click += new System.EventHandler(this.BunifuThinButton21_Click);
            // 
            // Op2Tb
            // 
            this.Op2Tb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Op2Tb.DefaultText = "Option 2";
            this.Op2Tb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Op2Tb.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Op2Tb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Op2Tb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Op2Tb.FillColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Op2Tb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Op2Tb.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Op2Tb.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Op2Tb.Location = new System.Drawing.Point(840, 116);
            this.Op2Tb.Name = "Op2Tb";
            this.Op2Tb.PasswordChar = '\0';
            this.Op2Tb.PlaceholderForeColor = System.Drawing.Color.Blue;
            this.Op2Tb.PlaceholderText = "";
            this.Op2Tb.SelectedText = "";
            this.Op2Tb.Size = new System.Drawing.Size(130, 33);
            this.Op2Tb.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.Op2Tb.TabIndex = 4;
            this.Op2Tb.TextChanged += new System.EventHandler(this.guna2TextBox3_TextChanged);
            // 
            // AnswerTb
            // 
            this.AnswerTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.AnswerTb.DefaultText = "Answer";
            this.AnswerTb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.AnswerTb.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.AnswerTb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.AnswerTb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.AnswerTb.FillColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.AnswerTb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.AnswerTb.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.AnswerTb.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.AnswerTb.Location = new System.Drawing.Point(840, 198);
            this.AnswerTb.Name = "AnswerTb";
            this.AnswerTb.PasswordChar = '\0';
            this.AnswerTb.PlaceholderForeColor = System.Drawing.Color.Blue;
            this.AnswerTb.PlaceholderText = "";
            this.AnswerTb.SelectedText = "";
            this.AnswerTb.Size = new System.Drawing.Size(130, 33);
            this.AnswerTb.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.AnswerTb.TabIndex = 4;
            this.AnswerTb.TextChanged += new System.EventHandler(this.guna2TextBox6_TextChanged);
            // 
            // Op4Tb
            // 
            this.Op4Tb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Op4Tb.DefaultText = "Option 4";
            this.Op4Tb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Op4Tb.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Op4Tb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Op4Tb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Op4Tb.FillColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Op4Tb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Op4Tb.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Op4Tb.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Op4Tb.Location = new System.Drawing.Point(562, 198);
            this.Op4Tb.Name = "Op4Tb";
            this.Op4Tb.PasswordChar = '\0';
            this.Op4Tb.PlaceholderForeColor = System.Drawing.Color.Blue;
            this.Op4Tb.PlaceholderText = "";
            this.Op4Tb.SelectedText = "";
            this.Op4Tb.Size = new System.Drawing.Size(130, 33);
            this.Op4Tb.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.Op4Tb.TabIndex = 4;
            this.Op4Tb.TextChanged += new System.EventHandler(this.guna2TextBox5_TextChanged);
            // 
            // Op3Tb
            // 
            this.Op3Tb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Op3Tb.DefaultText = "Option 3";
            this.Op3Tb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Op3Tb.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Op3Tb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Op3Tb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Op3Tb.FillColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Op3Tb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Op3Tb.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Op3Tb.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Op3Tb.Location = new System.Drawing.Point(227, 198);
            this.Op3Tb.Name = "Op3Tb";
            this.Op3Tb.PasswordChar = '\0';
            this.Op3Tb.PlaceholderForeColor = System.Drawing.Color.Blue;
            this.Op3Tb.PlaceholderText = "";
            this.Op3Tb.SelectedText = "";
            this.Op3Tb.Size = new System.Drawing.Size(130, 33);
            this.Op3Tb.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.Op3Tb.TabIndex = 4;
            this.Op3Tb.TextChanged += new System.EventHandler(this.guna2TextBox4_TextChanged);
            // 
            // Op1Tb
            // 
            this.Op1Tb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Op1Tb.DefaultText = "Option 1";
            this.Op1Tb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Op1Tb.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Op1Tb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Op1Tb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Op1Tb.FillColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Op1Tb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Op1Tb.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Op1Tb.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Op1Tb.Location = new System.Drawing.Point(562, 116);
            this.Op1Tb.Name = "Op1Tb";
            this.Op1Tb.PasswordChar = '\0';
            this.Op1Tb.PlaceholderForeColor = System.Drawing.Color.Blue;
            this.Op1Tb.PlaceholderText = "";
            this.Op1Tb.SelectedText = "";
            this.Op1Tb.Size = new System.Drawing.Size(130, 33);
            this.Op1Tb.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.Op1Tb.TabIndex = 4;
            this.Op1Tb.TextChanged += new System.EventHandler(this.guna2TextBox2_TextChanged);
            // 
            // QuestTb
            // 
            this.QuestTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.QuestTb.DefaultText = "Question";
            this.QuestTb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.QuestTb.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.QuestTb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.QuestTb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.QuestTb.FillColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.QuestTb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.QuestTb.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.QuestTb.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.QuestTb.Location = new System.Drawing.Point(227, 116);
            this.QuestTb.Name = "QuestTb";
            this.QuestTb.PasswordChar = '\0';
            this.QuestTb.PlaceholderForeColor = System.Drawing.Color.Blue;
            this.QuestTb.PlaceholderText = "";
            this.QuestTb.SelectedText = "";
            this.QuestTb.Size = new System.Drawing.Size(130, 33);
            this.QuestTb.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.QuestTb.TabIndex = 4;
            this.QuestTb.TextChanged += new System.EventHandler(this.guna2TextBox1_TextChanged);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel3.Location = new System.Drawing.Point(246, 84);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(114, 3);
            this.panel3.TabIndex = 3;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(557, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 31);
            this.label4.TabIndex = 2;
            this.label4.Text = "Levels";
            this.label4.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(835, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 31);
            this.label3.TabIndex = 2;
            this.label3.Text = "Members";
            this.label3.Click += new System.EventHandler(this.label1_Click);
            // 
            // QuestText
            // 
            this.QuestText.AutoSize = true;
            this.QuestText.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuestText.Location = new System.Drawing.Point(557, 366);
            this.QuestText.Name = "QuestText";
            this.QuestText.Size = new System.Drawing.Size(150, 26);
            this.QuestText.TabIndex = 2;
            this.QuestText.Text = "Question Bank";
            this.QuestText.Click += new System.EventHandler(this.label1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(240, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "Questions";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Quiz
            // 
            this.Quiz.AutoSize = true;
            this.Quiz.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Quiz.Location = new System.Drawing.Point(15, 9);
            this.Quiz.Name = "Quiz";
            this.Quiz.Size = new System.Drawing.Size(87, 26);
            this.Quiz.TabIndex = 2;
            this.Quiz.Text = "QuizPro";
            this.Quiz.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightSkyBlue;
            this.panel2.Controls.Add(this.guna2PictureBox2);
            this.panel2.Controls.Add(this.guna2PictureBox1);
            this.panel2.Controls.Add(this.guna2CirclePictureBox2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(1291, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(126, 675);
            this.panel2.TabIndex = 0;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // guna2PictureBox2
            // 
            this.guna2PictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox2.Image")));
            this.guna2PictureBox2.ImageRotate = 0F;
            this.guna2PictureBox2.Location = new System.Drawing.Point(29, 211);
            this.guna2PictureBox2.Name = "guna2PictureBox2";
            this.guna2PictureBox2.Size = new System.Drawing.Size(52, 52);
            this.guna2PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.guna2PictureBox2.TabIndex = 10;
            this.guna2PictureBox2.TabStop = false;
            this.guna2PictureBox2.Click += new System.EventHandler(this.guna2PictureBox2_Click);
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox1.Image")));
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(29, 23);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(52, 52);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.guna2PictureBox1.TabIndex = 10;
            this.guna2PictureBox1.TabStop = false;
            this.guna2PictureBox1.Click += new System.EventHandler(this.guna2PictureBox1_Click);
            // 
            // guna2CirclePictureBox2
            // 
            this.guna2CirclePictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("guna2CirclePictureBox2.Image")));
            this.guna2CirclePictureBox2.ImageRotate = 0F;
            this.guna2CirclePictureBox2.Location = new System.Drawing.Point(29, 116);
            this.guna2CirclePictureBox2.Name = "guna2CirclePictureBox2";
            this.guna2CirclePictureBox2.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox2.Size = new System.Drawing.Size(52, 52);
            this.guna2CirclePictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.guna2CirclePictureBox2.TabIndex = 9;
            this.guna2CirclePictureBox2.TabStop = false;
            this.guna2CirclePictureBox2.Click += new System.EventHandler(this.guna2CirclePictureBox2_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(369, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(8, 8);
            this.flowLayoutPanel1.TabIndex = 1;
            this.flowLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // Question
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1417, 675);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Question";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form5";
            this.Load += new System.EventHandler(this.Form5_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.QuestionDGV)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label Quiz;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label QuestText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private Guna.UI2.WinForms.Guna2TextBox QuestTb;
        private Guna.UI2.WinForms.Guna2TextBox Op2Tb;
        private Guna.UI2.WinForms.Guna2TextBox Op1Tb;
        private Guna.UI2.WinForms.Guna2DataGridView QuestionDGV;
        private Bunifu.Framework.UI.BunifuThinButton2 QuestResetBtn;
        private Bunifu.Framework.UI.BunifuThinButton2 QuestEditBtn;
        private Bunifu.Framework.UI.BunifuThinButton2 QuestSaveBtn;
        private Guna.UI2.WinForms.Guna2TextBox AnswerTb;
        private Guna.UI2.WinForms.Guna2TextBox Op4Tb;
        private Guna.UI2.WinForms.Guna2TextBox Op3Tb;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox2;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox2;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private System.Windows.Forms.ComboBox LvCb;
    }
}