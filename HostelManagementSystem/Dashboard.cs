using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HostelManagementSystem
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void newStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StudentForm student = new StudentForm();
            student.Show();

        }

        private void blockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BlockForm block = new BlockForm();
            block.Show();
        }

        private void staffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StaffForm staffForm = new StaffForm();
            staffForm.Show();
        }

        private void roomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RoomForm room = new RoomForm();
            room.Show();
        }

        private void courseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CourseForm course = new CourseForm();
            course.Show();

        }

        private void feeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FeeForm fee = new FeeForm();
            fee.Show();
        }
    }
}
