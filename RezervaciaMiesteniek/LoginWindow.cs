﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RezervaciaMiesteniek
{
    public partial class LoginWindow : Form
    {
        public LoginWindow()
        {
            InitializeComponent();
            textBox2.PasswordChar = '\u2022'; //nastavenie simbolu hesla
        }

        private void button1_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
            Database database = new Database();

            database.openConnection();
            database.closeConnection();
=======
>>>>>>> c1b2bf49bf8b69f930b8881c4e5ffa2ee17510b2
            MainForm mainform = new MainForm();
            this.Hide();
            mainform.ShowDialog();
            this.Show();
            textBox2.Text = "";
        }

        private void button2_Click(object sender, EventArgs e) //za
        {
            AddUserWindow addUser = new AddUserWindow();
            this.Hide();
            addUser.ShowDialog();
            this.Show();
        }

<<<<<<< HEAD
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
=======
       

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

>>>>>>> c1b2bf49bf8b69f930b8881c4e5ffa2ee17510b2
        }
    }
}
