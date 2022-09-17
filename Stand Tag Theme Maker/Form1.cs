using Blink_UI_lib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MessageBox = System.Windows.Forms.MessageBox;

namespace Stand_Tag_Theme_Maker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            tagThemeChanger1.OnChanged = OnThemeChanged;
            StaticOnThemeChanged = OnThemeChanged;

            tagThemeChanger1.theme = ThemePresets[1];
            tagThemeChanger1.UpdateValues();
            OnThemeChanged();

            foreach (TagTheme preset in ThemePresets)
            {
                var btn = new BlinkButton
                {
                    Text = preset.Name,
                    ForeColor = Color.White,
                    Animated = false,
                    Height = 25,
                    FillColor = Color.FromArgb(25, 25, 25),
                    HoverColor = Color.FromArgb(35, 35, 35)
                };
                btn.Click += (a, b) =>
                {
                    tagThemeChanger1.theme = preset;
                    tagThemeChanger1.UpdateValues();
                    OnThemeChanged();
                };
                flowLayoutPanel2.Controls.Add(btn);
            }
        }

        public static Action StaticOnThemeChanged;

        public static Color ColorFromHex(string hex)
        {
            Color color = ColorTranslator.FromHtml(hex);
            return color;
        }

        public static TagTheme[] ThemePresets =
        {
            new TagTheme()
            {
                Background = Color.FromArgb(25, 25, 30),
                Foreground = Color.FromArgb(185, 185, 200),
                Font = new Font("Yu Gothic UI", 8.7f),
                CornerRadius = 4,
                Padding = new Padding(4, 3, 0, 0),

                Name = "Moonlight"
            },
            new TagTheme()
            {
                Foreground = ColorFromHex("#FFFFFF"),
                Font = new Font("Corbel", 8.7f, FontStyle.Bold),
                CornerRadius = 4,
                Padding = new Padding(5, 4, 0, 0),
                RGB = true,

                Name = "Rainbow"
            },
            new TagTheme()
            {
                Background = ColorFromHex("#FFFFFF"),
                Foreground = ColorFromHex("#000000"),
                CornerRadius = 4,
                Padding = new Padding(4, 3, 0, 0),
                Font = new Font("Verdana", 8.7f),

                Name = "Basic Light"
            },
            new TagTheme()
            {
                Background = ColorFromHex("#000000"),
                Foreground = ColorFromHex("#FFFFFF"),
                CornerRadius = 4,
                Padding = new Padding(4, 3, 0, 0),
                Font = new Font("Verdana", 8.7f),

                Name = "Basic Dark"
            }
        };

        private void OnThemeChanged()
        {
            flowLayoutPanel1.Controls.Clear();
            
            for (int i = 0; i < tagStrings.Length; i++)
            {
                StandTagPreview preview = new StandTagPreview();
                preview.TagStringIndex = i;
                preview.theme = tagThemeChanger1.theme;
                preview.TagText = tagStrings[i];
                flowLayoutPanel1.Controls.Add(preview);
            }
        }

        public static string[] tagStrings =
        {
            "INTERIOR",
            "LIKELY MODDER",
            "YOU",
            "MODDER / ADMIN",
            "MODDER",
            "NEXT HOST",
            "OTR",
            "RC",
            "ADMIN",
            "CREW",
            "DEAD",
            "FRIEND",
            "GOD",
            "HOST",
            "SCRIPT HOST",
            "SPECTATING",
            "TIMEOUT",
            "TYPING",
            "VEHICLE GOD",
            "ATTACKED YOU",
            "VPN"
        };

        public static string[] originalTagStrings =
        {
            "INTERIOR",
            "LIKELY MODDER",
            "YOU",
            "MODDER / ADMIN",
            "MODDER",
            "NEXT HOST",
            "OTR",
            "RC",
            "ADMIN",
            "CREW",
            "DEAD",
            "FRIEND",
            "GOD",
            "HOST",
            "SCRIPT HOST",
            "SPECTATING",
            "TIMEOUT",
            "TYPING",
            "VEHICLE GOD",
            "ATTACKED YOU",
            "VPN"
        };

        private void Form1_Load(object sender, EventArgs e)
        {
            OnThemeChanged();
        }

        private void blinkButton1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Please choose an output folder :D");

            FolderBrowserDialog diag = new FolderBrowserDialog();
            diag.SelectedPath = "./";
            diag.ShowNewFolderButton = true;

            if (diag.ShowDialog() != DialogResult.OK)
                return;

            for (int i = 0; i < tagStrings.Length; i++)
            {
                Bitmap bmp = TagRenderer.RenderTag(tagStrings[i], tagThemeChanger1.theme, i);
                bmp.Save(Path.Combine(diag.SelectedPath, i.ToString("X2") + ".png"));
            }
        }
    }
}
