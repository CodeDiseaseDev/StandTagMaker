using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stand_Tag_Theme_Maker
{
    public partial class Prompt : Form
    {
        public Prompt()
        {
            InitializeComponent();
        }

        public string TextResult
        {
            get => textBox1.Text;
            set => textBox1.Text = value;
        }

        public string label
        {
            set => label1.Text = value;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        public static string ShowPrompt(string text, string @default = "")
        {
            Prompt p = new Prompt();
            p.label = text;
            p.TextResult = @default;

            if (p.ShowDialog() == DialogResult.OK)
                return p.TextResult;

            return null;
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                DialogResult = DialogResult.OK;
                Close();
            }
        }
    }
}
