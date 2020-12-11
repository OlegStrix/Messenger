using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
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
        public MainForm mForm;
    public AuthentificationForm()
    {
      InitializeComponent();
    }
    public void LoadJson()
        {
            using(StreamReader r = new StreamReader("data_sessions.json"))
            {
                string json = r.ReadToEnd();
                List<Items> items = JsonConvert.DeserializeObject<List<Items>>(json);
            }
        }
    public class Items
        {
            public int token;
            public string login;
            public string password;
        }

    private void button1_Click(object sender, EventArgs e)
    {
            string name = textBox1.Text;
            string password = textBox2.Text;
            WebRequest req = WebRequest.Create("http://localhost:5000/api/log");
            AuthData auth_data = new AuthData();
            auth_data.login = textBox1.Text;
            auth_data.password = textBox2.Text;
            //auth_data.login = fieldUserName.Text;
            Items auth = new Items();
            if (name == auth.login)
            {
                if (password == auth.password)
                {
                    mForm.TextBox_username.Text = auth_data.login;
                    mForm.Show();
                    this.Visible = false;
                }
                else
                {
                    MessageBox.Show("Invalid password");
                }
            }
            else
            {
                MessageBox.Show("User is not found");
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
