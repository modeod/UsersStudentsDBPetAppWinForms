using DataAccess.DBAccess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UsersStudentsDBForm.Components;

namespace UsersStudentsDBForm
{
    public partial class Password : Form
    {
        private string _connectionString { get; set; }
        private Form1 _mainForm { get; set; }
        public bool Entered { get; set; }

        public Password(Form1 mainForm)
        {
            InitializeComponent();
            _mainForm = mainForm;
            _connectionString = ConfigHelper.GetConnectionString();
            Entered = false;
        }

        private void Password_Load(object sender, EventArgs e)
        {}

        private void buttonConnect_Click(object sender, EventArgs e)
        {
            string connectionString = ConfigHelper.GetConnectionString();
            if(SqlAccess.CheckConnection(connectionString, textBoxPassword.Text))
            {
                _mainForm.password = textBoxPassword.Text;
                Entered = true;
                this.Close();
                return;
            }

            MessageBox.Show("Неправильный пароль");
        }

        private void Password_FormClosed(object sender, FormClosedEventArgs e)
        {
        }
    }
}
