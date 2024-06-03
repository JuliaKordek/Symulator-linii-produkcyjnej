using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projekt3
{
    public partial class Form1 : Form
    {
        private List<User> registeredUsers = new List<User>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string password = textBox2.Text;

            
            var user = registeredUsers.FirstOrDefault(u => u.Username == username && u.Password == password);

            if (user != null)
            {
                MessageBox.Show("Logowanie udane.", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Form2 form2 = new Form2();
                form2.Show();
                this.Hide();
                
            }
            else
            {
                MessageBox.Show("Brak użytkownika w systemie. Logowanie nieudane.", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string newUsername = textBox3.Text;
            string newPassword = textBox4.Text;

            if (!string.IsNullOrWhiteSpace(newUsername) && !string.IsNullOrWhiteSpace(newPassword))
            {
                registeredUsers.Add(new User { Username = newUsername, Password = newPassword });
                MessageBox.Show("Zarejestrowano nowego użytkownika.", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Wprowadź dane rejestracji.", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }

    public class User
    {
        public string Username { get; set; }
        public string Password { get; set; }
    }
}