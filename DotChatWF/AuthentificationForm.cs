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
    public AuthentificationForm()
    {
      InitializeComponent();
      
    }

    private void button1_Click(object sender, EventArgs e)
    {
            string name = textBox1.Text;
            string password = textBox2.Text;
            WebRequest req = WebRequest.Create("http://localhost:5000/api/log");
            //req.ContentType = "application/json";
            /*
            HttpWebResponse resp = (HttpWebResponse)req.GetResponse();
            StreamReader sr = new StreamReader(resp.GetResponseStream(), Encoding.GetEncoding("utf-8"));
            string content = sr.ReadToEnd();
            int int_token = Convert.ToInt32(content, 10);
            */
            if (int_token == -1)
            {
                MessageBox.Show("Он верный!");

            }
            if (int_token == 0)
            {
                MessageBox.Show("Вы ввели неверный пароль");
            }
            if (int_token == -2)
            {
                MessageBox.Show("Такого пользователя не существует");
            }
            
            btnLogin.Show();
            this.Visible = false;
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
