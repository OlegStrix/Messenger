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
            public int token { get; set; }
        }

        public MainForm MForm;
        public AuthentificationForm()
        {
            InitializeComponent();
        }
        private void AuthentificationForm_Load(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
                string name = textBox1.Text;
                string password = textBox2.Text;
                string text;
                string file = @"C:\Users\olego\source\repos\OlegStrix\Messenger\DotChatWF\data_sessions.json"; 
                int k = 0;
                using(StreamReader sr = new StreamReader(file))
                {
                    text = sr.ReadToEnd();
                }
                var m = JsonExtensions.ToObject<Temperatures>(text);
                for(int i=0; i!= m.ListTokens.Count(); i++)
                {
                    if(name==m.ListTokens[i].Login)
                    {
                        if(password == m.ListTokens[i].Password)
                        {
                        var token = m.ListTokens[i].Token;
                        WebRequest req = WebRequest.Create("http://localhost:5000/api/auth");
                        req.Method = "POST";
                        AuthData auth_data = new AuthData();
                        auth_data.login = name;
                        auth_data.password = password;
                        int token1 = Convert.ToInt32(token);
                        auth_data.token = token1;
                        string postData = JsonConvert.SerializeObject(auth_data);
                        req.ContentType = "application/json";
                        StreamWriter reqStream = new StreamWriter(req.GetRequestStream());
                        reqStream.Write(postData);
                        reqStream.Close();
                        HttpWebResponse resp = (HttpWebResponse)req.GetResponse();
                        StreamReader sr = new StreamReader(resp.GetResponseStream(), Encoding.GetEncoding("utf-8"));
                        string content = sr.ReadToEnd();
                        sr.Close();
                        int int_token = Convert.ToInt32(content, 10);
                        k = 1;
                            MForm.TextBox_username.Text = name;
                            MForm.Show();
                            this.Visible = false;
                            MForm.int_token = -1;
                            MForm.CheckStatusOnline();
                        }
                        else 
                        {
                            k = 1;
                            MessageBox.Show("Incorrect password");
                        }
                    }
                }
                if(k==0)
                {
                    MessageBox.Show("User not found");
                }
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

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

        private void AuthentificationForm_Closed(object sender, FormClosedEventArgs e)
        {
            MForm.Show();
        }
    }

    public static class JsonExtensions
    {
        public static T ToObject<T>(this string jsonText)
        {
            return JsonConvert.DeserializeObject<T>(jsonText);
        }
    }
}
