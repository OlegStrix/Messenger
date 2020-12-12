using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace DotChatWF
{
  public partial class AuthentificationForm : Form
  {
        public class AuthData
        {
            public string login { get; set; }
            public string password { get; set; }
        }

        public MainForm MForm;
        public AuthentificationForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            string password = textBox2.Text;
            string text = File.ReadAllText("data_sessions.json");
            bool result_name = Regex.IsMatch(text, name);
            bool result_password = Regex.IsMatch(text, password);

            if(result_name)
            {
                if (result_password)
                {
                    WebRequest req = WebRequest.Create("http://localhost:5000/api/auth");
                    AuthData auth_data = new AuthData();
                    req.ContentType = "application/json";
                    auth_data.login = name;
                    auth_data.password = password;
                    string postData = JsonConvert.SerializeObject(auth_data);
                    MForm.TextBox_username.Text = name;
                    MForm.Show();
                    this.Visible = false;
                    MForm.int_token = -1;
                }
                else
                {
                    MessageBox.Show("Неверный пароль");
                }
            }
            else
            {
                MessageBox.Show("Пользователь не найден");
            }   
        }


        private void AuthentificationForm_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
