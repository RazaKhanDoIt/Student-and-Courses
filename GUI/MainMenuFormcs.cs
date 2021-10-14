using Lab3.BLL;
using Lab3.GUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3
{
    public partial class MainMenuFormcs : Form
    {
        public MainMenuFormcs()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure you want to Exit?","Exit?", MessageBoxButtons.YesNo);
            switch (dr)
            {
                case DialogResult.Yes:
                    Application.Exit();
                    break;

                case DialogResult.No:
                    break;
            }
        }

        private void studenFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StudentForm stuForm = new StudentForm();
            this.Hide();
            stuForm.ShowDialog();

        }

        private void courseFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CourseForm courForm = new CourseForm();
            this.Hide();
            courForm.ShowDialog();
        }

        private void courseRegistrationFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CourseRegistration courRegForm = new CourseRegistration();
            this.Hide();
            courRegForm.ShowDialog();
        }
    }
}
