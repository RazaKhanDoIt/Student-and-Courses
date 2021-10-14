namespace Lab3.GUI
{
    partial class StudentForm
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
            this.btnCourseClose = new System.Windows.Forms.Button();
            this.grbStud = new System.Windows.Forms.GroupBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnModify = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtFName = new System.Windows.Forms.Label();
            this.txtStudent = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnListStud = new System.Windows.Forms.Button();
            this.dgvStud = new System.Windows.Forms.DataGridView();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnListDataSet = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.grbStud.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStud)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCourseClose
            // 
            this.btnCourseClose.Location = new System.Drawing.Point(818, 500);
            this.btnCourseClose.Name = "btnCourseClose";
            this.btnCourseClose.Size = new System.Drawing.Size(75, 48);
            this.btnCourseClose.TabIndex = 0;
            this.btnCourseClose.Text = "&Close";
            this.btnCourseClose.UseVisualStyleBackColor = true;
            this.btnCourseClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // grbStud
            // 
            this.grbStud.Controls.Add(this.btnUpdate);
            this.grbStud.Controls.Add(this.btnDelete);
            this.grbStud.Controls.Add(this.btnModify);
            this.grbStud.Controls.Add(this.btnSearch);
            this.grbStud.Controls.Add(this.btnAdd);
            this.grbStud.Controls.Add(this.txtMail);
            this.grbStud.Controls.Add(this.txtEmail);
            this.grbStud.Controls.Add(this.textBox2);
            this.grbStud.Controls.Add(this.txtLastName);
            this.grbStud.Controls.Add(this.textBox1);
            this.grbStud.Controls.Add(this.txtFName);
            this.grbStud.Controls.Add(this.txtStudent);
            this.grbStud.Controls.Add(this.label1);
            this.grbStud.Location = new System.Drawing.Point(12, 12);
            this.grbStud.Name = "grbStud";
            this.grbStud.Size = new System.Drawing.Size(737, 213);
            this.grbStud.TabIndex = 1;
            this.grbStud.TabStop = false;
            this.grbStud.Text = "Student Information";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(572, 91);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(138, 43);
            this.btnUpdate.TabIndex = 12;
            this.btnUpdate.Text = "&Update Database";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click_1);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(435, 91);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 43);
            this.btnDelete.TabIndex = 11;
            this.btnDelete.Text = "&Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnModify
            // 
            this.btnModify.Location = new System.Drawing.Point(298, 91);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(75, 43);
            this.btnModify.TabIndex = 10;
            this.btnModify.Text = "&Modify";
            this.btnModify.UseVisualStyleBackColor = true;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(161, 91);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 43);
            this.btnSearch.TabIndex = 9;
            this.btnSearch.Text = "&Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(24, 91);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 43);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "&Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(464, 43);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(185, 22);
            this.txtMail.TabIndex = 7;
            // 
            // txtEmail
            // 
            this.txtEmail.AutoSize = true;
            this.txtEmail.Location = new System.Drawing.Point(461, 22);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(50, 17);
            this.txtEmail.TabIndex = 6;
            this.txtEmail.Text = "Email :";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(320, 43);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 5;
            // 
            // txtLastName
            // 
            this.txtLastName.AutoSize = true;
            this.txtLastName.Location = new System.Drawing.Point(317, 18);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(84, 17);
            this.txtLastName.TabIndex = 4;
            this.txtLastName.Text = "Last Name :";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(165, 43);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 3;
            // 
            // txtFName
            // 
            this.txtFName.AutoSize = true;
            this.txtFName.Location = new System.Drawing.Point(162, 22);
            this.txtFName.Name = "txtFName";
            this.txtFName.Size = new System.Drawing.Size(84, 17);
            this.txtFName.TabIndex = 2;
            this.txtFName.Text = "First Name :";
            // 
            // txtStudent
            // 
            this.txtStudent.Location = new System.Drawing.Point(24, 43);
            this.txtStudent.Name = "txtStudent";
            this.txtStudent.Size = new System.Drawing.Size(100, 22);
            this.txtStudent.TabIndex = 1;
            this.txtStudent.TextChanged += new System.EventHandler(this.txtStudent_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Student ID :";
            // 
            // btnListStud
            // 
            this.btnListStud.Location = new System.Drawing.Point(109, 231);
            this.btnListStud.Name = "btnListStud";
            this.btnListStud.Size = new System.Drawing.Size(139, 43);
            this.btnListStud.TabIndex = 13;
            this.btnListStud.Text = "&List Students From Database";
            this.btnListStud.UseVisualStyleBackColor = true;
            this.btnListStud.Click += new System.EventHandler(this.btnListStud_Click);
            // 
            // dgvStud
            // 
            this.dgvStud.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStud.Location = new System.Drawing.Point(21, 288);
            this.dgvStud.Name = "dgvStud";
            this.dgvStud.RowHeadersWidth = 51;
            this.dgvStud.RowTemplate.Height = 24;
            this.dgvStud.Size = new System.Drawing.Size(332, 150);
            this.dgvStud.TabIndex = 14;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(460, 288);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(332, 150);
            this.dataGridView1.TabIndex = 16;
            // 
            // btnListDataSet
            // 
            this.btnListDataSet.Location = new System.Drawing.Point(554, 231);
            this.btnListDataSet.Name = "btnListDataSet";
            this.btnListDataSet.Size = new System.Drawing.Size(139, 43);
            this.btnListDataSet.TabIndex = 15;
            this.btnListDataSet.Text = "&List Students From DS";
            this.btnListDataSet.UseVisualStyleBackColor = true;
            this.btnListDataSet.Click += new System.EventHandler(this.btnListDataSet_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(360, 244);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 17);
            this.label2.TabIndex = 17;
            this.label2.Text = "Student List";
            // 
            // StudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(922, 560);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnListDataSet);
            this.Controls.Add(this.dgvStud);
            this.Controls.Add(this.btnListStud);
            this.Controls.Add(this.grbStud);
            this.Controls.Add(this.btnCourseClose);
            this.Name = "StudentForm";
            this.Text = "Student Maintenance";
            this.Load += new System.EventHandler(this.StudentForm_Load);
            this.grbStud.ResumeLayout(false);
            this.grbStud.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStud)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCourseClose;
        private System.Windows.Forms.GroupBox grbStud;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.Label txtEmail;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label txtLastName;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label txtFName;
        private System.Windows.Forms.TextBox txtStudent;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnListStud;
        private System.Windows.Forms.DataGridView dgvStud;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnListDataSet;
        private System.Windows.Forms.Label label2;
    }
}