using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stand_tag_icon_renderer
{
    internal class Program
    {
        static string[] tags = new string[]
        {
            "BEHEERDER",
            "JE AANGEVALLEN",
            "BEMANNING",
            "DOOD",
            "DOOD",
            "GASTHEER",
            "BINNEN",
            "MISSCHIEN MODDER",
            "MODDER / BEHEERDER",
            "MODDER",
            "VOLGENDE HOST",
            "OTR",
            "RC",
            "SCRIPT GASTHEER",
            "SPECTEREN",
            "GOD",
            "JIJ",
            "TIME-OUT",
            "TYPEN",
            "VOERTUIG GOD"
        };

        static void Main(string[] args)
        {
            string imagesFolder = "./images";

            if (!Directory.Exists(imagesFolder))
                Directory.CreateDirectory(imagesFolder);

            Font font = new Font("Whitney", 7.5f);

            Color back = Color.FromArgb(255,255,255);
            Color fore = Color.FromArgb(35, 35, 35);

            for (int i = 0; i < tags.Length; i++)
            {
                string tag = tags[i];

                var bmp = RenderTag(tag, font, back, fore, (3, 3), 4);

                string name = i.ToString("X2") + ".png";
                string file = Path.Combine(imagesFolder, name);
                bmp.Save(file);

                Console.WriteLine("Rendered {0} ({1})", name, tag);
            }
        }

        static Size MeasureString(string text, Font font)
        {
            using (Graphics g = Graphics.FromImage(new Bitmap(1, 1)))
                return g.MeasureString(text, font).ToSize();
        }

        static GraphicsPath RoundedRect(Rectangle bounds, int radius)
        {
            int diameter = radius * 2;
            Size size = new Size(diameter, diameter);
            Rectangle arc = new Rectangle(bounds.Location, size);
            GraphicsPath path = new GraphicsPath();

            if (radius == 0)
            {
                path.AddRectangle(bounds);
                return path;
            }

            path.AddArc(arc, 180, 90);

            arc.X = bounds.Right - diameter;
            path.AddArc(arc, 270, 90);

            arc.Y = bounds.Bottom - diameter;
            path.AddArc(arc, 0, 90);

            arc.X = bounds.Left;
            path.AddArc(arc, 90, 90);

            path.CloseFigure();
            return path;
        }

        static Bitmap RenderTag(string text, Font font, Color back, Color fore, (int, int) spacing, int cornerRadius)
        {
            (int spacingX, int spacingY) = spacing;

            Size size = MeasureString(text, font);

            Bitmap bmp = new Bitmap(size.Width + (spacingX * 2), size.Height + (spacingY * 2));

            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.SmoothingMode = SmoothingMode.AntiAlias;
                g.TextRenderingHint = TextRenderingHint.AntiAlias;

                var path = RoundedRect(new Rectangle(0, 0, bmp.Width - 1, bmp.Height - 1), cornerRadius);
                g.FillPath(new SolidBrush(back), path);
                g.DrawPath(new Pen(back), path);

                g.DrawString(text, font, new SolidBrush(fore), spacingX, spacingY);
            }

            return bmp;
        }
    }
}
