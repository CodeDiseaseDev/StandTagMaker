using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Stand_Tag_Theme_Maker
{
    public partial class StandTagPreview : UserControl
    {
        public StandTagPreview()
        {
            InitializeComponent();
        }

        public int TagStringIndex = -1;

        public TagTheme theme = new TagTheme
        {
            Font = new Font("Segoe UI", 7.5f),
            Background = Color.White,
            Foreground = Color.Black,
            CornerRadius = 5,
            Padding = new Padding(5, 4, 0, 0)
        };

        public string TagText
        {
            set
            {
                label1.Text = value;
                pictureBox1.Image = TagRenderer.RenderTag(value, theme, TagStringIndex);
            }
            get => label1.Text;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            string newText = Prompt.ShowPrompt($"Enter new name for '{Form1.tagStrings[TagStringIndex]}'", Form1.tagStrings[TagStringIndex]);
            if (newText == null)
                return;

            Form1.tagStrings[TagStringIndex] = newText;
            Form1.StaticOnThemeChanged();
        }
    }
}
