using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Personal_Helper_WF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int workingTime, breakTime, longBreakTime;

        private void WorkingButton_Click(object sender, EventArgs e)
        {
            try
            {
                workingTime = Int32.Parse(setWorkInput.Text);
                breakTime = Int32.Parse(setBreakInput.Text);
                longBreakTime = Int32.Parse(setLongBreakInput.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Enter correct time in minutes \n \n {ex}", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

    }
}
