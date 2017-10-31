using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Diagnostics;

namespace WindowsFormsApplication1
{
    public partial class Login : Form
    {
        private PoliceForm policeForm;

        public Login()
        {
            InitializeComponent();

            Rank Owner = new Rank(4, "Owner");
            Rank Lieutenant = new Rank(3, "Lieutenant");
            Rank DispatchAdministator = new Rank(2, "Administrator");
            Rank Dispatcher = new Rank(1, "Dispatcher");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Submit_Click(object sender, EventArgs e)
        {


            User user = new User();
            User userReturned;
            Debug.WriteLine("Push test");

            userReturned = user.Login(UsernameTextBox.Text, PasswordTextBox.Text);
            policeForm = new PoliceForm(userReturned);

            if (policeForm.Visible == false && userReturned != null)
            {
                // policeForm.
                policeForm.Show();
                this.Hide();
            }
            else
                Application.Exit();

        }

    }
}
