using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HomeLibrary.Models;
using static System.Net.Mime.MediaTypeNames;

namespace HomeLibrary
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            string username = txtNewUsername.Text;
            string password = txtNewPassword.Text;

            if (UserStorage.UserExists(username))
            {
                MessageBox.Show("User already exists!");
                return;
            }

            User newUser = new User() { Username = username, Password = password };
            UserStorage.SaveUser(newUser);
            MessageBox.Show("Account created successfully!");
            Close();
        }
    }
}
