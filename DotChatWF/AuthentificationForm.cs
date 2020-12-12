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
        
        public partial class Info
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
        /*
        public class Meta
        {
            public int count { get; set; }
        }


        public class Item
        {
            public int tank_id { get; set; }
        }

        public class RootObject
        {
            public string status { get; set; }
            public Meta meta { get; set; }
            public Dictionary<int, Item> data { get; set; }
        }
        */
        private void button1_Click(object sender, EventArgs e)
        {
            string json = "{\"token\":\"12345\",\"password\":323,\"login\":'flex'}";

            var obj = JsonConvert.DeserializeObject<ListToken>(json);
            var m = obj.Password[1];
            var x = m.ToString();
            MessageBox.Show(x);
            /*
            string json = @"{
                'list_tokens' : [ 
                    {
                        'token':43053,
                        'login':'Krippa',
                        'password':'1'},
                    {
                        'token':84930,
                        'login':'Silvestr',
                        'password':'1'}]}";
            
            string jsonData1 = @"[{""name"":""0"",""price"":""40"",""count"":""1"",""productId"":""4"",""catid"":""4"",""productTotal"":""40"",""orderstatus"":""0"",""orderkey"":""123456789""}]";

            


            string jsonData = jsonData1.Replace("\"", "");

            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            JArray array = JArray.Parse(jsonData);
            foreach(var u in array)
            {
                if(array.)
            }


            //var fileHashPairs = j.SelectToken("$.objects").Children().OfType<JProperty>;
            */
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
