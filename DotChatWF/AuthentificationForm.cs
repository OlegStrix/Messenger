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
using Newtonsoft.Json.Converters;


namespace DotChatWF
{
    public static class JsonExtensions
    {
        public static T ToObject<T>(this string jsonText)
        {
            return JsonConvert.DeserializeObject<T>(jsonText);
        }

        public static string ToJson<T>(this T obj)
        {
            return JsonConvert.SerializeObject(obj);
        }
    }
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

        public partial class Temperatures
        {
            [JsonProperty("list_tokens")]
            public ListToken[] ListTokens { get; set; }
        }

        public partial class ListToken
        {
            [JsonProperty("token")]
            public long Token { get; set; }

            [JsonProperty("login")]
            public string Login { get; set; }

            [JsonProperty("password")]
            public string Password { get; set; }
        }
        


        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            string password = textBox2.Text;
            string file = @"C:\Users\olego\source\repos\OlegStrix\Messenger\Server\data_sessions.json";
            string text;
            int k = 0;
            using (StreamReader sr = new StreamReader(file))
            {
                text = sr.ReadToEnd();
            }

                var m = JsonExtensions.ToObject<Temperatures>(text);
                WebRequest req = WebRequest.Create("http://localhost:/api/auth");
                
                for (int i = 0; i != m.ListTokens.Count(); i++)
                {
                    if (name == m.ListTokens[i].Login)
                    {
                        if (password == m.ListTokens[i].Password)
                        {
                            k = 1;
                            MForm.TextBox_username.Text = name;
                            MForm.Show();
                            this.Visible = false;
                            MForm.int_token = -1;
                            
                        }
                        else
                        {
                            k = 1;
                            MessageBox.Show("Incorrect password");
                        }

                    }
                }

                if (k == 0)
                {
                    MessageBox.Show("User not found");
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
