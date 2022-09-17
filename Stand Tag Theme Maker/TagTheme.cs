using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stand_Tag_Theme_Maker
{
    public class TagTheme
    {
        public Font Font = new Font("Segoe UI", 7.5f);
        public Color Background = Color.White;
        public Color Foreground = Color.Black;
        public Padding Padding = new Padding(3, 2, 0, 0);
        public int CornerRadius = 3;
        public bool RGB = false;

        // for presets
        public string Name = "default";
    }
}
