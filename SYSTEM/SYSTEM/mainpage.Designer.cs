namespace SYSTEM
{
    partial class mainpage
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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            label7 = new Label();
            textBox7 = new TextBox();
            studentsearch = new Button();
            studentclear = new Button();
            studentdelete = new Button();
            studentupdate = new Button();
            studentadd = new Button();
            label6 = new Label();
            label5 = new Label();
            emailadd = new TextBox();
            studenttype = new TextBox();
            middleinitial = new TextBox();
            lastname = new TextBox();
            firstname = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            studid = new TextBox();
            label1 = new Label();
            studentgrid = new DataGridView();
            tabPage2 = new TabPage();
            courseclear = new Button();
            coursedelete = new Button();
            courseupdate = new Button();
            courseadd = new Button();
            label8 = new Label();
            textBox1 = new TextBox();
            coursesearch = new Button();
            label9 = new Label();
            label10 = new Label();
            coursedesc = new TextBox();
            units = new TextBox();
            label13 = new Label();
            courseid = new TextBox();
            label14 = new Label();
            coursegrid = new DataGridView();
            tabPage3 = new TabPage();
            enrollmentclear = new Button();
            enrollmentdelete = new Button();
            enrollmentupdate = new Button();
            enrollmentadd = new Button();
            label15 = new Label();
            textBox9 = new TextBox();
            enrollmentsearch = new Button();
            label16 = new Label();
            label17 = new Label();
            studidd = new TextBox();
            courseidd = new TextBox();
            enrollmentdate = new TextBox();
            label20 = new Label();
            enrollmentid = new TextBox();
            label21 = new Label();
            enrollmentgrid = new DataGridView();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox8 = new TextBox();
            textBox10 = new TextBox();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)studentgrid).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)coursegrid).BeginInit();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)enrollmentgrid).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Location = new Point(-7, 1);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1000, 788);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.CadetBlue;
            tabPage1.Controls.Add(label7);
            tabPage1.Controls.Add(textBox7);
            tabPage1.Controls.Add(studentsearch);
            tabPage1.Controls.Add(studentclear);
            tabPage1.Controls.Add(studentdelete);
            tabPage1.Controls.Add(studentupdate);
            tabPage1.Controls.Add(studentadd);
            tabPage1.Controls.Add(label6);
            tabPage1.Controls.Add(label5);
            tabPage1.Controls.Add(emailadd);
            tabPage1.Controls.Add(studenttype);
            tabPage1.Controls.Add(middleinitial);
            tabPage1.Controls.Add(lastname);
            tabPage1.Controls.Add(firstname);
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(studid);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(studentgrid);
            tabPage1.Enabled = true;
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(992, 760);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "STUDENT TABLE";
            tabPage1.Visible = true;
            tabPage1.Click += tabPage1_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.White;
            label7.Location = new Point(425, 29);
            label7.Name = "label7";
            label7.Size = new Size(224, 37);
            label7.TabIndex = 19;
            label7.Text = "STUDENT TABLE";
            // 
            // textBox7
            // 
            textBox7.Location = new Point(94, 30);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(169, 23);
            textBox7.TabIndex = 18;
            // 
            // studentsearch
            // 
            studentsearch.Location = new Point(6, 29);
            studentsearch.Name = "studentsearch";
            studentsearch.TabIndex = 17;
            studentsearch.Text = "SEARCH";
            studentsearch.UseVisualStyleBackColor = true;
            studentsearch.Click += studentsearch_Click;
            // 
            // studentclear
            // 
            studentclear.Location = new Point(775, 627);
            studentclear.Name = "studentclear";
            studentclear.TabIndex = 16;
            studentclear.Text = "CLEAR";
            studentclear.UseVisualStyleBackColor = true;
            studentclear.Click += studentclear_Click;
            // 
            // studentdelete
            // 
            studentdelete.Location = new Point(775, 539);
            studentdelete.Name = "studentdelete";
            studentdelete.TabIndex = 15;
            studentdelete.Text = "DELETE";
            studentdelete.UseVisualStyleBackColor = true;
            studentdelete.Click += studentdelete_Click;
            // 
            // studentupdate
            // 
            studentupdate.Location = new Point(775, 448);
            studentupdate.Name = "studentupdate";
            studentupdate.TabIndex = 14;
            studentupdate.Text = "UPDATE";
            studentupdate.UseVisualStyleBackColor = true;
            studentupdate.Click += studentupdate_Click;
            // 
            // studentadd
            // 
            studentadd.Location = new Point(775, 359);
            studentadd.Name = "studentadd";
            studentadd.TabIndex = 13;
            studentadd.Text = "ADD";
            studentadd.UseVisualStyleBackColor = true;
            studentadd.Click += studentadd_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(547, 126);
            label6.Name = "label6";
            label6.Size = new Size(109, 17);
            label6.TabIndex = 12;
            label6.Text = "EMAIL ADDRESS";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(547, 193);
            label5.Name = "label5";
            label5.Size = new Size(102, 17);
            label5.TabIndex = 11;
            label5.Text = "STUDENT TYPE";
            // 
            // emailadd
            // 
            emailadd.Location = new Point(681, 120);
            emailadd.Name = "emailadd";
            emailadd.Size = new Size(169, 23);
            emailadd.TabIndex = 10;
            // 
            // studenttype
            // 
            studenttype.Location = new Point(681, 187);
            studenttype.Name = "studenttype";
            studenttype.Size = new Size(169, 23);
            studenttype.TabIndex = 9;
            // 
            // middleinitial
            // 
            middleinitial.Location = new Point(313, 248);
            middleinitial.Name = "middleinitial";
            middleinitial.Size = new Size(169, 23);
            middleinitial.TabIndex = 8;
            // 
            // lastname
            // 
            lastname.Location = new Point(313, 309);
            lastname.Name = "lastname";
            lastname.Size = new Size(169, 23);
            lastname.TabIndex = 7;
            // 
            // firstname
            // 
            firstname.Location = new Point(313, 186);
            firstname.Name = "firstname";
            firstname.Size = new Size(169, 23);
            firstname.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(178, 315);
            label4.Name = "label4";
            label4.Size = new Size(81, 17);
            label4.TabIndex = 5;
            label4.Text = "LAST NAME\r\n";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(178, 254);
            label3.Name = "label3";
            label3.Size = new Size(108, 17);
            label3.TabIndex = 4;
            label3.Text = "MIDDLE INITIAL";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(178, 193);
            label2.Name = "label2";
            label2.Size = new Size(84, 17);
            label2.TabIndex = 3;
            label2.Text = "FIRST NAME";
            // 
            // studid
            // 
            studid.Location = new Point(313, 120);
            studid.Name = "studid";
            studid.Size = new Size(169, 23);
            studid.TabIndex = 2;
            studid.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(178, 126);
            label1.Name = "label1";
            label1.Size = new Size(85, 17);
            label1.TabIndex = 1;
            label1.Text = "STUDENT ID";
            label1.Click += label1_Click;
            // 
            // studentgrid
            // 
            studentgrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            studentgrid.Location = new Point(250, 350);
            studentgrid.Name = "studentgrid";
            studentgrid.Size = new Size(500, 300);
            studentgrid.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.BackColor = Color.CadetBlue;
            tabPage2.Controls.Add(courseclear);
            tabPage2.Controls.Add(coursedelete);
            tabPage2.Controls.Add(courseupdate);
            tabPage2.Controls.Add(courseadd);
            tabPage2.Controls.Add(label8);
            tabPage2.Controls.Add(textBox1);
            tabPage2.Controls.Add(coursesearch);
            tabPage2.Controls.Add(label9);
            tabPage2.Controls.Add(label10);
            tabPage2.Controls.Add(coursedesc);
            tabPage2.Controls.Add(units);
            tabPage2.Controls.Add(label13);
            tabPage2.Controls.Add(courseid);
            tabPage2.Controls.Add(label14);
            tabPage2.Controls.Add(coursegrid);
            tabPage2.Enabled = true;
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(992, 760);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "COURSE TABLE";
            tabPage2.Visible = false;
            // 
            // courseclear
            // 
            courseclear.Location = new Point(779, 617);
            courseclear.Name = "courseclear";
            courseclear.TabIndex = 39;
            courseclear.Text = "CLEAR";
            courseclear.UseVisualStyleBackColor = true;
            // 
            // coursedelete
            // 
            coursedelete.Location = new Point(779, 521);
            coursedelete.Name = "coursedelete";
            coursedelete.TabIndex = 38;
            coursedelete.Text = "DELETE";
            coursedelete.UseVisualStyleBackColor = true;
            // 
            // courseupdate
            // 
            courseupdate.Location = new Point(779, 429);
            courseupdate.Name = "courseupdate";
            courseupdate.TabIndex = 37;
            courseupdate.Text = "UPDATE";
            courseupdate.UseVisualStyleBackColor = true;
            // 
            // courseadd
            // 
            courseadd.Location = new Point(779, 340);
            courseadd.Name = "courseadd";
            courseadd.TabIndex = 36;
            courseadd.Text = "ADD";
            courseadd.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.White;
            label8.Location = new Point(429, 19);
            label8.Name = "label8";
            label8.Size = new Size(206, 37);
            label8.TabIndex = 35;
            label8.Text = "COURSE TABLE";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(98, 20);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(169, 23);
            textBox1.TabIndex = 34;
            // 
            // coursesearch
            // 
            coursesearch.Location = new Point(10, 19);
            coursesearch.Name = "coursesearch";
            coursesearch.TabIndex = 33;
            coursesearch.Text = "SEARCH";
            coursesearch.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.White;
            label9.Location = new Point(551, 116);
            label9.Name = "label9";
            label9.Size = new Size(145, 17);
            label9.TabIndex = 32;
            label9.Text = "COURSE DESCRIPTION";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.White;
            label10.Location = new Point(551, 183);
            label10.Name = "label10";
            label10.Size = new Size(46, 17);
            label10.TabIndex = 31;
            label10.Text = "UNITS";
            // 
            // coursedesc
            // 
            coursedesc.Location = new Point(717, 110);
            coursedesc.Name = "coursedesc";
            coursedesc.Size = new Size(169, 23);
            coursedesc.TabIndex = 30;
            coursedesc.TextChanged += textBox2_TextChanged;
            // 
            // units
            // 
            units.Location = new Point(685, 177);
            units.Name = "units";
            units.Size = new Size(169, 23);
            units.TabIndex = 29;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.ForeColor = Color.White;
            label13.Location = new Point(166, 182);
            label13.Name = "label13";
            label13.Size = new Size(96, 17);
            label13.TabIndex = 23;
            label13.Text = "COURSE CODE";
            // 
            // courseid
            // 
            courseid.Location = new Point(317, 110);
            courseid.Name = "courseid";
            courseid.Size = new Size(169, 23);
            courseid.TabIndex = 22;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.ForeColor = Color.White;
            label14.Location = new Point(166, 116);
            label14.Name = "label14";
            label14.Size = new Size(75, 17);
            label14.TabIndex = 21;
            label14.Text = "COURSE ID";
            // 
            // coursegrid
            // 
            coursegrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            coursegrid.Location = new Point(254, 340);
            coursegrid.Name = "coursegrid";
            coursegrid.Size = new Size(500, 300);
            coursegrid.TabIndex = 20;
            // 
            // tabPage3
            // 
            tabPage3.BackColor = Color.CadetBlue;
            tabPage3.Controls.Add(enrollmentclear);
            tabPage3.Controls.Add(enrollmentdelete);
            tabPage3.Controls.Add(enrollmentupdate);
            tabPage3.Controls.Add(enrollmentadd);
            tabPage3.Controls.Add(label15);
            tabPage3.Controls.Add(textBox9);
            tabPage3.Controls.Add(enrollmentsearch);
            tabPage3.Controls.Add(label16);
            tabPage3.Controls.Add(label17);
            tabPage3.Controls.Add(studidd);
            tabPage3.Controls.Add(courseidd);
            tabPage3.Controls.Add(enrollmentdate);
            tabPage3.Controls.Add(label20);
            tabPage3.Controls.Add(enrollmentid);
            tabPage3.Controls.Add(label21);
            tabPage3.Controls.Add(enrollmentgrid);
            tabPage3.Enabled = true;
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(992, 760);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "ENROLLMENT TABLE";
            tabPage3.Visible = false;
            // 
            // enrollmentclear
            // 
            enrollmentclear.Location = new Point(784, 619);
            enrollmentclear.Name = "enrollmentclear";
            enrollmentclear.TabIndex = 55;
            enrollmentclear.Text = "CLEAR";
            enrollmentclear.UseVisualStyleBackColor = true;
            // 
            // enrollmentdelete
            // 
            enrollmentdelete.Location = new Point(784, 519);
            enrollmentdelete.Name = "enrollmentdelete";
            enrollmentdelete.TabIndex = 54;
            enrollmentdelete.Text = "DELETE";
            enrollmentdelete.UseVisualStyleBackColor = true;
            // 
            // enrollmentupdate
            // 
            enrollmentupdate.Location = new Point(784, 430);
            enrollmentupdate.Name = "enrollmentupdate";
            enrollmentupdate.TabIndex = 53;
            enrollmentupdate.Text = "UPDATE";
            enrollmentupdate.UseVisualStyleBackColor = true;
            // 
            // enrollmentadd
            // 
            enrollmentadd.Location = new Point(784, 342);
            enrollmentadd.Name = "enrollmentadd";
            enrollmentadd.TabIndex = 52;
            enrollmentadd.Text = "ADD";
            enrollmentadd.UseVisualStyleBackColor = true;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label15.ForeColor = Color.White;
            label15.Location = new Point(434, 21);
            label15.Name = "label15";
            label15.Size = new Size(280, 37);
            label15.TabIndex = 51;
            label15.Text = "ENROLLMENT TABLE\r\n";
            // 
            // textBox9
            // 
            textBox9.Location = new Point(103, 22);
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(169, 23);
            textBox9.TabIndex = 50;
            // 
            // enrollmentsearch
            // 
            enrollmentsearch.Location = new Point(15, 21);
            enrollmentsearch.Name = "enrollmentsearch";
            enrollmentsearch.TabIndex = 49;
            enrollmentsearch.Text = "SEARCH";
            enrollmentsearch.UseVisualStyleBackColor = true;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label16.ForeColor = Color.White;
            label16.Location = new Point(556, 118);
            label16.Name = "label16";
            label16.Size = new Size(85, 17);
            label16.TabIndex = 48;
            label16.Text = "STUDENT ID";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label17.ForeColor = Color.White;
            label17.Location = new Point(556, 185);
            label17.Name = "label17";
            label17.Size = new Size(75, 17);
            label17.TabIndex = 47;
            label17.Text = "COURSE ID";
            // 
            // studidd
            // 
            studidd.Location = new Point(690, 112);
            studidd.Name = "studidd";
            studidd.Size = new Size(169, 23);
            studidd.TabIndex = 46;
            // 
            // courseidd
            // 
            courseidd.Location = new Point(690, 179);
            courseidd.Name = "courseidd";
            courseidd.Size = new Size(169, 23);
            courseidd.TabIndex = 45;
            // 
            // enrollmentdate
            // 
            enrollmentdate.Location = new Point(322, 178);
            enrollmentdate.Name = "enrollmentdate";
            enrollmentdate.Size = new Size(169, 23);
            enrollmentdate.TabIndex = 42;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label20.ForeColor = Color.White;
            label20.Location = new Point(187, 185);
            label20.Name = "label20";
            label20.Size = new Size(131, 17);
            label20.TabIndex = 39;
            label20.Text = "ENROLLMENT DATE";
            // 
            // enrollmentid
            // 
            enrollmentid.Location = new Point(322, 112);
            enrollmentid.Name = "enrollmentid";
            enrollmentid.Size = new Size(169, 23);
            enrollmentid.TabIndex = 38;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label21.ForeColor = Color.White;
            label21.Location = new Point(187, 118);
            label21.Name = "label21";
            label21.RightToLeft = RightToLeft.Yes;
            label21.Size = new Size(112, 17);
            label21.TabIndex = 37;
            label21.Text = "ENROLLMENT ID";
            // 
            // enrollmentgrid
            // 
            enrollmentgrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            enrollmentgrid.Location = new Point(259, 342);
            enrollmentgrid.Name = "enrollmentgrid";
            enrollmentgrid.Size = new Size(500, 300);
            enrollmentgrid.TabIndex = 36;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(317, 110);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(169, 23);
            textBox2.TabIndex = 22;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(317, 110);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(169, 23);
            textBox3.TabIndex = 22;
            // 
            // textBox8
            // 
            textBox8.Location = new Point(317, 110);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(169, 23);
            textBox8.TabIndex = 22;
            // 
            // textBox10
            // 
            textBox10.Location = new Point(0, 0);
            textBox10.Name = "textBox10";
            textBox10.TabIndex = 0;
            textBox10.Text = "textBox10";
            // 
            // mainpage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(984, 749);
            Controls.Add(tabControl1);
            Name = "mainpage";
            Text = "mainpage";
            Load += mainpage_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)studentgrid).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)coursegrid).EndInit();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)enrollmentgrid).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private DataGridView studentgrid;
        private Label label1;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox emailadd;
        private TextBox studenttype;
        private TextBox middleinitial;
        private TextBox lastname;
        private TextBox firstname;
        private Label label7;
        private TextBox textBox7;
        private Button studentsearch;
        private Button studentclear;
        private Button studentdelete;
        private Button studentupdate;
        private Button studentadd;
        private Label label6;
        private Label label5;
        private Button courseclear;
        private Button coursedelete;
        private Button courseupdate;
        private Button courseadd;
        private Label label8;
        private TextBox textBox1;
        private Button coursesearch;
        private Label label9;
        private Label label10;
        private TextBox coursedesc;
        private TextBox units;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private Label label11;
        private Label label12;
        private Label label13;
        private TextBox courseid;
        private Label label14;
        private DataGridView coursegrid;
        private Button enrollmentclear;
        private Button enrollmentdelete;
        private Button enrollmentupdate;
        private Button enrollmentadd;
        private Label label15;
        private TextBox textBox9;
        private Button enrollmentsearch;
        private Label label16;
        private Label label17;
        private TextBox studidd;
        private TextBox courseidd;
        private TextBox enrollmentdate;
        private Label label20;
        private TextBox enrollmentid;
        private Label label21;
        private DataGridView enrollmentgrid;
        private TextBox studid;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox8;
        private TextBox textBox10;
    }
}