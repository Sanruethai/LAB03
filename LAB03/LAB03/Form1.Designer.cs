namespace LAB03
{
    partial class Student
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.id_student = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birthday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.heigth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.branch = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtBirth = new System.Windows.Forms.TextBox();
            this.txtStature = new System.Windows.Forms.TextBox();
            this.txtGrade = new System.Windows.Forms.TextBox();
            this.txtBranch = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.delBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_student,
            this.name,
            this.birthday,
            this.heigth,
            this.grade,
            this.branch});
            this.dataGridView1.Location = new System.Drawing.Point(14, 79);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(804, 494);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.AllowUserToAddRowsChanged += new System.EventHandler(this.dataGridView1_AllowUserToAddRowsChanged);
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // id_student
            // 
            this.id_student.HeaderText = "ID";
            this.id_student.MinimumWidth = 6;
            this.id_student.Name = "id_student";
            this.id_student.Width = 125;
            // 
            // name
            // 
            this.name.HeaderText = "ชื่อ";
            this.name.MinimumWidth = 6;
            this.name.Name = "name";
            this.name.Width = 125;
            // 
            // birthday
            // 
            this.birthday.HeaderText = "ปีเกิด";
            this.birthday.MinimumWidth = 6;
            this.birthday.Name = "birthday";
            this.birthday.Width = 125;
            // 
            // heigth
            // 
            this.heigth.HeaderText = "ส่วนสูง";
            this.heigth.MinimumWidth = 6;
            this.heigth.Name = "heigth";
            this.heigth.Width = 125;
            // 
            // grade
            // 
            this.grade.HeaderText = "เกรด";
            this.grade.MinimumWidth = 6;
            this.grade.Name = "grade";
            this.grade.Width = 125;
            // 
            // branch
            // 
            this.branch.HeaderText = "สาขา";
            this.branch.MinimumWidth = 6;
            this.branch.Name = "branch";
            this.branch.Width = 125;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(824, 212);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "ชื่อ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(824, 179);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 33);
            this.label2.TabIndex = 2;
            this.label2.Text = "รหัสนักศึกษา";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(825, 245);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 33);
            this.label3.TabIndex = 3;
            this.label3.Text = "ปีเกิด";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(824, 278);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 33);
            this.label4.TabIndex = 4;
            this.label4.Text = "ส่วนสูง";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(824, 311);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 33);
            this.label5.TabIndex = 5;
            this.label5.Text = "เกรด";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(824, 344);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 33);
            this.label6.TabIndex = 6;
            this.label6.Text = "สาขา";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(971, 185);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(125, 27);
            this.txtID.TabIndex = 7;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(971, 218);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(125, 27);
            this.txtName.TabIndex = 8;
            // 
            // txtBirth
            // 
            this.txtBirth.Location = new System.Drawing.Point(971, 251);
            this.txtBirth.Name = "txtBirth";
            this.txtBirth.Size = new System.Drawing.Size(125, 27);
            this.txtBirth.TabIndex = 9;
            // 
            // txtStature
            // 
            this.txtStature.Location = new System.Drawing.Point(971, 284);
            this.txtStature.Name = "txtStature";
            this.txtStature.Size = new System.Drawing.Size(125, 27);
            this.txtStature.TabIndex = 10;
            // 
            // txtGrade
            // 
            this.txtGrade.Location = new System.Drawing.Point(971, 317);
            this.txtGrade.Name = "txtGrade";
            this.txtGrade.Size = new System.Drawing.Size(125, 27);
            this.txtGrade.TabIndex = 11;
            // 
            // txtBranch
            // 
            this.txtBranch.Location = new System.Drawing.Point(971, 350);
            this.txtBranch.Name = "txtBranch";
            this.txtBranch.Size = new System.Drawing.Size(125, 27);
            this.txtBranch.TabIndex = 12;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(824, 488);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(141, 85);
            this.button1.TabIndex = 13;
            this.button1.Text = "เพิ่ม";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // delBtn
            // 
            this.delBtn.Location = new System.Drawing.Point(973, 488);
            this.delBtn.Name = "delBtn";
            this.delBtn.Size = new System.Drawing.Size(141, 85);
            this.delBtn.TabIndex = 14;
            this.delBtn.Text = "ลบ";
            this.delBtn.UseVisualStyleBackColor = true;
            this.delBtn.Click += new System.EventHandler(this.delBtn_Click);
            // 
            // Student
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(1126, 585);
            this.Controls.Add(this.delBtn);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtBranch);
            this.Controls.Add(this.txtGrade);
            this.Controls.Add(this.txtStature);
            this.Controls.Add(this.txtBirth);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Student";
            this.Text = "DataStudent";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dataGridView1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private DataGridViewTextBoxColumn id_student;
        private DataGridViewTextBoxColumn name;
        private DataGridViewTextBoxColumn birthday;
        private DataGridViewTextBoxColumn heigth;
        private DataGridViewTextBoxColumn grade;
        private DataGridViewTextBoxColumn branch;
        private TextBox txtID;
        private TextBox txtName;
        private TextBox txtBirth;
        private TextBox txtStature;
        private TextBox txtGrade;
        private TextBox txtBranch;
        private Button button1;
        private Button delBtn;
    }
}