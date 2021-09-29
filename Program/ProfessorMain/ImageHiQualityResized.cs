using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProfessorMain
{
    static class ImageHiQualityResized //이미지 화질 조정
    {
        public static Image GetImageHiQualityResized(this Image image, int width, int height)
        {
            var thumb = new Bitmap(width, height);
            using (var g = Graphics.FromImage(thumb))
            {
                g.SmoothingMode = SmoothingMode.HighQuality;
                g.CompositingQuality = CompositingQuality.HighQuality;
                g.InterpolationMode = InterpolationMode.High;
                g.DrawImage(image, new Rectangle(0, 0, thumb.Width, thumb.Height));
                return thumb;
            }
        }
    }
}
