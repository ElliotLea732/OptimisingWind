using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace OptimisingWind
{
    public partial class programForm : Form
    {
        public string programName;
        public int areaLen;
        public int areaWidth;
        public int noTurbines;

        public programForm()
        {
            InitializeComponent();
        }

        private void programForm_Load(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Owner.Show();  //Show the previous form
            Hide();
        }
    }
}
