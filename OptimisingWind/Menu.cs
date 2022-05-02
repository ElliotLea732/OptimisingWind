using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OptimisingWind
{
    public partial class Menu : Form
    {
        setupNewFile newFileForm;
        public Menu()
        {
            InitializeComponent();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnNewFile_Click(object sender, EventArgs e)
        {
            if (newFileForm == null)
            {
                newFileForm = new setupNewFile();   //Create form if not created
                newFileForm.FormClosed += newFileForm_FormClosed;  //Add eventhandler to cleanup after form closes
            }

            newFileForm.Show(this);  //Show Form assigning this form as the forms owner
            Hide();
        }

        void newFileForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            newFileForm = null;  //If form is closed make sure reference is set to null
            Show();
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLoadFile_Click(object sender, EventArgs e)
        {
            
        }
    }
}
