namespace Lab3.GUI
{
    partial class CourseRegistration
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblStudInfo = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnGetStud = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtStudId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblCourseInfo = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.getCourseCode = new System.Windows.Forms.Button();
            this.txtCourseCode = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.dtpRegiDate = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnRegister = new System.Windows.Forms.Button();
            this.btnModify = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnUptData = new System.Windows.Forms.Button();
            this.lstStudDB = new System.Windows.Forms.Button();
            this.lstStudCourse = new System.Windows.Forms.Button();
            this.dgvStud = new System.Windows.Forms.DataGridView();
            this.dgvStudCourse = new System.Windows.Forms.DataGridView();
            this.btnClose = new System.Windows.Forms.Button();
            this.colCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRegDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStartDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEndDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStudId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStud)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudCourse)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblStudInfo);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btnGetStud);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtStudId);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(121, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(271, 204);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Student Information :";
            // 
            // lblStudInfo
            // 
            this.lblStudInfo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblStudInfo.Location = new System.Drawing.Point(24, 120);
            this.lblStudInfo.Name = "lblStudInfo";
            this.lblStudInfo.Size = new System.Drawing.Size(182, 75);
            this.lblStudInfo.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(76, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Student Info";
            // 
            // btnGetStud
            // 
            this.btnGetStud.Location = new System.Drawing.Point(131, 48);
            this.btnGetStud.Name = "btnGetStud";
            this.btnGetStud.Size = new System.Drawing.Size(75, 23);
            this.btnGetStud.TabIndex = 3;
            this.btnGetStud.Text = "Get";
            this.btnGetStud.UseVisualStyleBackColor = true;
            this.btnGetStud.Click += new System.EventHandler(this.txtGetStud_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "(7 digits)";
            // 
            // txtStudId
            // 
            this.txtStudId.Location = new System.Drawing.Point(9, 49);
            this.txtStudId.Name = "txtStudId";
            this.txtStudId.Size = new System.Drawing.Size(100, 22);
            this.txtStudId.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Student ID:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblCourseInfo);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.getCourseCode);
            this.groupBox2.Controls.Add(this.txtCourseCode);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Location = new System.Drawing.Point(429, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(306, 204);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Course Information:";
            // 
            // lblCourseInfo
            // 
            this.lblCourseInfo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCourseInfo.Location = new System.Drawing.Point(62, 120);
            this.lblCourseInfo.Name = "lblCourseInfo";
            this.lblCourseInfo.Size = new System.Drawing.Size(182, 75);
            this.lblCourseInfo.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(100, 91);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "Course Info";
            // 
            // getCourseCode
            // 
            this.getCourseCode.Location = new System.Drawing.Point(169, 47);
            this.getCourseCode.Name = "getCourseCode";
            this.getCourseCode.Size = new System.Drawing.Size(75, 23);
            this.getCourseCode.TabIndex = 9;
            this.getCourseCode.Text = "Get";
            this.getCourseCode.UseVisualStyleBackColor = true;
            this.getCourseCode.Click += new System.EventHandler(this.getCourseCode_Click);
            // 
            // txtCourseCode
            // 
            this.txtCourseCode.Location = new System.Drawing.Point(45, 48);
            this.txtCourseCode.Name = "txtCourseCode";
            this.txtCourseCode.Size = new System.Drawing.Size(100, 22);
            this.txtCourseCode.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(45, 28);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 17);
            this.label8.TabIndex = 6;
            this.label8.Text = "Course Code:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dtpEndDate);
            this.groupBox3.Controls.Add(this.dtpStartDate);
            this.groupBox3.Controls.Add(this.dtpRegiDate);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Location = new System.Drawing.Point(776, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(258, 204);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Course Registration:";
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.Location = new System.Drawing.Point(43, 163);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(189, 22);
            this.dtpEndDate.TabIndex = 16;
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Location = new System.Drawing.Point(43, 96);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(189, 22);
            this.dtpStartDate.TabIndex = 15;
            // 
            // dtpRegiDate
            // 
            this.dtpRegiDate.Location = new System.Drawing.Point(43, 39);
            this.dtpRegiDate.Name = "dtpRegiDate";
            this.dtpRegiDate.Size = new System.Drawing.Size(189, 22);
            this.dtpRegiDate.TabIndex = 14;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(58, 18);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(118, 17);
            this.label9.TabIndex = 13;
            this.label9.Text = "Registration Date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(58, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "Starting Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(58, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Ending Date:";
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(66, 231);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(88, 35);
            this.btnRegister.TabIndex = 2;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // btnModify
            // 
            this.btnModify.Location = new System.Drawing.Point(197, 231);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(89, 35);
            this.btnModify.TabIndex = 3;
            this.btnModify.Text = "Modify";
            this.btnModify.UseVisualStyleBackColor = true;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(318, 231);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(89, 35);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnUptData
            // 
            this.btnUptData.Location = new System.Drawing.Point(591, 243);
            this.btnUptData.Name = "btnUptData";
            this.btnUptData.Size = new System.Drawing.Size(144, 23);
            this.btnUptData.TabIndex = 5;
            this.btnUptData.Text = "Update Database";
            this.btnUptData.UseVisualStyleBackColor = true;
            this.btnUptData.Click += new System.EventHandler(this.btnUptData_Click);
            // 
            // lstStudDB
            // 
            this.lstStudDB.Location = new System.Drawing.Point(95, 293);
            this.lstStudDB.Name = "lstStudDB";
            this.lstStudDB.Size = new System.Drawing.Size(241, 23);
            this.lstStudDB.TabIndex = 6;
            this.lstStudDB.Text = "List Course By Student From DB";
            this.lstStudDB.UseVisualStyleBackColor = true;
            this.lstStudDB.Click += new System.EventHandler(this.lstStudDB_Click);
            // 
            // lstStudCourse
            // 
            this.lstStudCourse.Location = new System.Drawing.Point(638, 293);
            this.lstStudCourse.Name = "lstStudCourse";
            this.lstStudCourse.Size = new System.Drawing.Size(279, 23);
            this.lstStudCourse.TabIndex = 7;
            this.lstStudCourse.Text = "List Students By Course From DB";
            this.lstStudCourse.UseVisualStyleBackColor = true;
            this.lstStudCourse.Click += new System.EventHandler(this.lstStudCourse_Click);
            // 
            // dgvStud
            // 
            this.dgvStud.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStud.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCode,
            this.colTitle,
            this.colRegDate,
            this.colStartDate,
            this.colEndDate});
            this.dgvStud.Location = new System.Drawing.Point(19, 322);
            this.dgvStud.Name = "dgvStud";
            this.dgvStud.RowHeadersWidth = 51;
            this.dgvStud.RowTemplate.Height = 24;
            this.dgvStud.Size = new System.Drawing.Size(500, 158);
            this.dgvStud.TabIndex = 8;
            // 
            // dgvStudCourse
            // 
            this.dgvStudCourse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudCourse.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colStudId,
            this.StudName});
            this.dgvStudCourse.Location = new System.Drawing.Point(525, 322);
            this.dgvStudCourse.Name = "dgvStudCourse";
            this.dgvStudCourse.RowHeadersWidth = 51;
            this.dgvStudCourse.RowTemplate.Height = 24;
            this.dgvStudCourse.Size = new System.Drawing.Size(540, 158);
            this.dgvStudCourse.TabIndex = 9;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(979, 499);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 10;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // colCode
            // 
            this.colCode.HeaderText = "Course Code";
            this.colCode.MinimumWidth = 6;
            this.colCode.Name = "colCode";
            this.colCode.Width = 125;
            // 
            // colTitle
            // 
            this.colTitle.HeaderText = "Course Title";
            this.colTitle.MinimumWidth = 6;
            this.colTitle.Name = "colTitle";
            this.colTitle.Width = 125;
            // 
            // colRegDate
            // 
            this.colRegDate.HeaderText = "Registeration Date";
            this.colRegDate.MinimumWidth = 6;
            this.colRegDate.Name = "colRegDate";
            this.colRegDate.Width = 125;
            // 
            // colStartDate
            // 
            this.colStartDate.HeaderText = "Starting Date";
            this.colStartDate.MinimumWidth = 6;
            this.colStartDate.Name = "colStartDate";
            this.colStartDate.Width = 125;
            // 
            // colEndDate
            // 
            this.colEndDate.HeaderText = "Ending Date";
            this.colEndDate.MinimumWidth = 6;
            this.colEndDate.Name = "colEndDate";
            this.colEndDate.Width = 125;
            // 
            // colStudId
            // 
            this.colStudId.HeaderText = "Student ID";
            this.colStudId.MinimumWidth = 6;
            this.colStudId.Name = "colStudId";
            this.colStudId.Width = 125;
            // 
            // StudName
            // 
            this.StudName.HeaderText = "Student Name";
            this.StudName.MinimumWidth = 6;
            this.StudName.Name = "StudName";
            this.StudName.Width = 125;
            // 
            // CourseRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1077, 534);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.dgvStudCourse);
            this.Controls.Add(this.dgvStud);
            this.Controls.Add(this.lstStudCourse);
            this.Controls.Add(this.lstStudDB);
            this.Controls.Add(this.btnUptData);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnModify);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "CourseRegistration";
            this.Text = "CourseRegistration";
            this.Load += new System.EventHandler(this.CourseRegistration_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStud)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudCourse)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnUptData;
        private System.Windows.Forms.Button lstStudDB;
        private System.Windows.Forms.Button lstStudCourse;
        private System.Windows.Forms.Label lblStudInfo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnGetStud;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtStudId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCourseInfo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button getCourseCode;
        private System.Windows.Forms.TextBox txtCourseCode;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dgvStud;
        private System.Windows.Forms.DataGridView dgvStudCourse;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.DateTimePicker dtpRegiDate;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRegDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStartDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEndDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStudId;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudName;
    }
}