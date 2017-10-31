using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class FireEmsForm : Form
    {

        private ChooseDeptForm formAccess7;

        public FireEmsForm()
        {
            InitializeComponent();
        }

        private void Form8_Load(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

            formAccess7 = new ChooseDeptForm();
            if (formAccess7.Visible == false)
            {
                formAccess7.Show();
            }
            else
                return;
            this.Hide();

        }
    }
}
