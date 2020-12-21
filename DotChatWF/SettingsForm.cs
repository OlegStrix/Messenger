using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DotChatWF
{

    public partial class SettingsForm : Form
    {
        public MainForm KForm;
        public ListBox ListBox_listMessages;
        public SettingsForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string s = Convert.ToString(KForm.ListBox_listMessages.Items.Count);
            MessageBox.Show(s);
        }
    }
}
