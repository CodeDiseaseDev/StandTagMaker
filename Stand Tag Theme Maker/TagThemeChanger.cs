using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace Stand_Tag_Theme_Maker
{
    public partial class TagThemeChanger : UserControl
    {
        public TagThemeChanger()
        {
            InitializeComponent();

            UpdateValues();
        }

        public TagTheme theme = new TagTheme();
        public Action OnChanged;

        private void blinkSlider1_OnValueChanged(object sender, EventArgs args)
        {
            
        }

        private void blinkSlider1_OnDragFinish(object sender, EventArgs args)
        {
            theme.Padding = new Padding(blinkSlider1.Value, blinkSlider1.Value - 1, 0, 0);
            OnChanged?.Invoke();
        }

        private void blinkSlider2_OnDragFinish(object sender, EventArgs args)
        {
            theme.CornerRadius = blinkSlider2.Value;
            OnChanged?.Invoke();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            dialog.Color = pictureBox1.BackColor;
            dialog.ShowDialog();
            pictureBox1.BackColor = dialog.Color;

            theme.Background = dialog.Color;

            OnChanged?.Invoke();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            dialog.Color = pictureBox2.BackColor;
            dialog.ShowDialog();
            pictureBox2.BackColor = dialog.Color;

            theme.Foreground = dialog.Color;

            OnChanged?.Invoke();
        }

        private static float map(float value, float fromLow, float fromHigh, float toLow, float toHigh)
        {
            return (value - fromLow) * (toHigh - toLow) / (fromHigh - fromLow) + toLow;
        }

        private void blinkSlider3_OnDragFinish(object sender, EventArgs args)
        {
            theme.Font = new Font(theme.Font.FontFamily, map(blinkSlider3.Value, 0, 100, 7, 15), theme.Font.Style);
            OnChanged?.Invoke();

            UpdateValues();
        }

        private void TagThemeChanger_Load(object sender, EventArgs e)
        {
            theme.Foreground = pictureBox2.BackColor;
            theme.Background = pictureBox1.BackColor;
            theme.Font = new Font(theme.Font.FontFamily, map(blinkSlider3.Value, 0, 100, 7, 15), theme.Font.Style);
            theme.Padding = new Padding(blinkSlider1.Value, blinkSlider1.Value - 1, 0, 0);
            theme.CornerRadius = blinkSlider2.Value;

            Form1.StaticOnThemeChanged();
            UpdateValues();
        }

        public void UpdateValues()
        {
            pictureBox2.BackColor = theme.Foreground;
            pictureBox1.BackColor = theme.Background;
            blinkSlider3.Value = (int)map(theme.Font.Size, 7, 15, 0, 100);
            blinkSlider1.Value = theme.Padding.Left;
            blinkSlider2.Value = theme.CornerRadius;
            blinkCheckbox2.Checked = theme.RGB;

            label8.Text = $"Font ({theme.Font.Name}, {theme.Font.SizeInPoints} pt)";
        }

        private void blinkCheckbox1_Load(object sender, EventArgs e)
        {
            
        }

        private void blinkCheckbox1_Click(object sender, EventArgs e)
        {
            
        }

        private void blinkCheckbox1_MouseUp(object sender, MouseEventArgs e)
        {
            theme.Font = new Font(theme.Font.FontFamily, map(blinkSlider3.Value, 0, 100, 7, 15), theme.Font.Style);
            OnChanged?.Invoke();
            UpdateValues();
        }

        private void blinkCheckbox2_MouseUp(object sender, MouseEventArgs e)
        {
            theme.RGB = blinkCheckbox2.Checked;
            OnChanged?.Invoke();
        }

        private void blinkButton1_Click(object sender, EventArgs e)
        {
            FontDialog dialog = new FontDialog();
            dialog.Font = theme.Font;
            dialog.ShowDialog();

            theme.Font = dialog.Font;
            OnChanged?.Invoke();
            UpdateValues();
        }
    }
}
