using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace WindowsFormsApplication1
{
    public partial class PoliceForm : Form
    {
        private PlateCheckForm formAccess2;
        private PriorsForm formAccess3;
        private ActiveBoloForm formAccess4;
        private NotepadForm formAccess5;
        private DLCheckForm formAccess6;
        private ChooseDeptForm formAccess7;
        private User userAccount;

      
        public PoliceForm()
        {
            InitializeComponent();
            this.FormClosing += PoliceForm_FormClosing;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Debug.WriteLine(sender);
        }

        public static string FirstCharToUpper(string input)
        {
            switch (input)
            {
                case null: throw new ArgumentNullException(nameof(input));
                case "": throw new ArgumentException($"{nameof(input)} cannot be empty", nameof(input));
                default: return input.First().ToString().ToUpper() + input.Substring(1);
            }
        }

        public PoliceForm(User user)
        {
            InitializeComponent();
            this.userAccount = user;
            this.FormClosing += PoliceForm_FormClosing;
            Debug.WriteLine(user.userName);
            string stringUpper = FirstCharToUpper(user.userName);
            WelcomeLabel.Text = "Welcome, " + stringUpper;
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            formAccess2 = new PlateCheckForm();
            if (formAccess2.Visible == false)
            {
                formAccess2.Show();
            }
            else
                return;
  
        }

        private void button2_Click(object sender, EventArgs e)
        {
            formAccess3 = new PriorsForm();
            if (formAccess3.Visible == false)
            {
                formAccess3.Show();
            }
            else
                return;

        }

        private void button3_Click(object sender, EventArgs e)
        {

            formAccess6 = new DLCheckForm();
            if (formAccess6.Visible == false)
            {
                formAccess6.Show();
            }
            else
                return;

        }

        private void button4_Click(object sender, EventArgs e)
        {

            formAccess4 = new ActiveBoloForm();
            if (formAccess4.Visible == false)
            {
                formAccess4.Show();
            }
            else
                return;

        }

        private void button5_Click(object sender, EventArgs e)
        {

            formAccess5 = new NotepadForm();
            if (formAccess5.Visible == false)
            {
                formAccess5.Show();
            }
            else
                return;

        }

        private void button6_Click(object sender, EventArgs e)
        {

            formAccess7 = new ChooseDeptForm();
            formAccess7.Show();
            /*if (formAccess7.Visible == false)
            {
                formAccess7.Show();
            }
            else
                return;*/
            this.Hide();
        }

        private void PoliceForm_FormClosing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Application.Exit();
        }
        
    }
}
