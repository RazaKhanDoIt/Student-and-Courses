namespace Lab3.GUI
{
    partial class CourseForm
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
            this.dgvStud = new System.Windows.Forms.DataGridView();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnModify = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnListCourse = new System.Windows.Forms.Button();
            this.txtTotalHour = new System.Windows.Forms.TextBox();
            this.txtCourseTitle = new System.Windows.Forms.TextBox();
            this.sd = new System.Windows.Forms.Label();
            this.txtCourse = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grbStud = new System.Windows.Forms.GroupBox();
            this.io = new System.Windows.Forms.Label();
            this.btnCourseClose = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStud)).BeginInit();
            this.grbStud.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvStud
            // 
            this.dgvStud.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStud.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvStud.Location = new System.Drawing.Point(167, 345);
            this.dgvStud.Name = "dgvStud";
            this.dgvStud.RowHeadersWidth = 51;
            this.dgvStud.RowTemplate.Height = 24;
            this.dgvStud.Size = new System.Drawing.Size(496, 150);
            this.dgvStud.TabIndex = 20;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(571, 107);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(138, 43);
            this.btnUpdate.TabIndex = 12;
            this.btnUpdate.Text = "&Update Database";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(436, 107);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 43);
            this.btnDelete.TabIndex = 11;
            this.btnDelete.Text = "&Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnModify
            // 
            this.btnModify.Location = new System.Drawing.Point(299, 107);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(75, 43);
            this.btnModify.TabIndex = 10;
            this.btnModify.Text = "&Modify";
            this.btnModify.UseVisualStyleBackColor = true;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(162, 107);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 43);
            this.btnSearch.TabIndex = 9;
            this.btnSearch.Text = "&Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(25, 107);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 43);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "&Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnListCourse
            // 
            this.btnListCourse.Location = new System.Drawing.Point(337, 257);
            this.btnListCourse.Name = "btnListCourse";
            this.btnListCourse.Size = new System.Drawing.Size(139, 43);
            this.btnListCourse.TabIndex = 19;
            this.btnListCourse.Text = "&List Course From DB";
            this.btnListCourse.UseVisualStyleBackColor = true;
            this.btnListCourse.Click += new System.EventHandler(this.btnListCourse_Click);
            // 
            // txtTotalHour
            // 
            this.txtTotalHour.Location = new System.Drawing.Point(560, 67);
            this.txtTotalHour.Name = "txtTotalHour";
            this.txtTotalHour.Size = new System.Drawing.Size(100, 22);
            this.txtTotalHour.TabIndex = 5;
            // 
            // txtCourseTitle
            // 
            this.txtCourseTitle.Location = new System.Drawing.Point(266, 67);
            this.txtCourseTitle.Name = "txtCourseTitle";
            this.txtCourseTitle.Size = new System.Drawing.Size(182, 22);
            this.txtCourseTitle.TabIndex = 3;
            // 
            // sd
            // 
            this.sd.AutoSize = true;
            this.sd.Location = new System.Drawing.Point(306, 47);
            this.sd.Name = "sd";
            this.sd.Size = new System.Drawing.Size(83, 17);
            this.sd.TabIndex = 2;
            this.sd.Text = "CouseTitle :";
            // 
            // txtCourse
            // 
            this.txtCourse.Location = new System.Drawing.Point(72, 67);
            this.txtCourse.Name = "txtCourse";
            this.txtCourse.Size = new System.Drawing.Size(122, 22);
            this.txtCourse.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(90, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Couse Code :";
            // 
            // grbStud
            // 
            this.grbStud.Controls.Add(this.btnUpdate);
            this.grbStud.Controls.Add(this.btnDelete);
            this.grbStud.Controls.Add(this.btnModify);
            this.grbStud.Controls.Add(this.btnSearch);
            this.grbStud.Controls.Add(this.btnAdd);
            this.grbStud.Controls.Add(this.txtTotalHour);
            this.grbStud.Controls.Add(this.io);
            this.grbStud.Controls.Add(this.txtCourseTitle);
            this.grbStud.Controls.Add(this.sd);
            this.grbStud.Controls.Add(this.txtCourse);
            this.grbStud.Controls.Add(this.label1);
            this.grbStud.Location = new System.Drawing.Point(71, 24);
            this.grbStud.Name = "grbStud";
            this.grbStud.Size = new System.Drawing.Size(737, 213);
            this.grbStud.TabIndex = 18;
            this.grbStud.TabStop = false;
            this.grbStud.Text = "Course Information";
            // 
            // io
            // 
            this.io.AutoSize = true;
            this.io.Location = new System.Drawing.Point(568, 47);
            this.io.Name = "io";
            this.io.Size = new System.Drawing.Size(75, 17);
            this.io.TabIndex = 4;
            this.io.Text = "Total Hour";
            // 
            // btnCourseClose
            // 
            this.btnCourseClose.Location = new System.Drawing.Point(675, 509);
            this.btnCourseClose.Name = "btnCourseClose";
            this.btnCourseClose.Size = new System.Drawing.Size(75, 48);
            this.btnCourseClose.TabIndex = 21;
            this.btnCourseClose.Text = "&Close";
            this.btnCourseClose.UseVisualStyleBackColor = true;
            this.btnCourseClose.Click += new System.EventHandler(this.btnCourseClose_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(366, 315);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 17);
            this.label2.TabIndex = 22;
            this.label2.Text = "Course List";
            // 
            // CourseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(929, 631);
            this.ControlBox = false;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCourseClose);
            this.Controls.Add(this.dgvStud);
            this.Controls.Add(this.btnListCourse);
            this.Controls.Add(this.grbStud);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "CourseForm";
            this.Text = "Course Maintenance";
            this.Load += new System.EventHandler(this.CourseForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStud)).EndInit();
            this.grbStud.ResumeLayout(false);
            this.grbStud.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvStud;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnListCourse;
        private System.Windows.Forms.TextBox txtTotalHour;
        private System.Windows.Forms.TextBox txtCourseTitle;
        private System.Windows.Forms.Label sd;
        private System.Windows.Forms.TextBox txtCourse;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grbStud;
        private System.Windows.Forms.Label io;
        private System.Windows.Forms.Button btnCourseClose;
        private System.Windows.Forms.Label label2;
    }
}