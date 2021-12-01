using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramMain
{
    static class Tool
    {

        static public Image resizeImage(Image image, int width,  int height)
        {
            var destinationRect = new Rectangle(0, 0, width, height);
            var destinationImage = new Bitmap(width, height);

            destinationImage.SetResolution(image.HorizontalResolution, image.VerticalResolution);

            using (var graphics = Graphics.FromImage(destinationImage))
            {
                graphics.CompositingMode = CompositingMode.SourceCopy;
                graphics.CompositingQuality = CompositingQuality.HighQuality;

                using (var wrapMode = new ImageAttributes())
                {
                    wrapMode.SetWrapMode(WrapMode.TileFlipXY);
                    graphics.DrawImage(image, destinationRect, 0, 0, image.Width, image.Height, GraphicsUnit.Pixel, wrapMode);
                }
            }

            return (Image)destinationImage;
        }

        static public string getDay()//요일 변환 메서드
        {
            DateTime now = DateTime.Now;
            string day;

            switch (now.DayOfWeek)
            {
                case DayOfWeek.Monday:
                    day = "월";
                    break;
                case DayOfWeek.Tuesday:
                    day = "화";
                    break;
                case DayOfWeek.Wednesday:
                    day = "수";
                    break;
                case DayOfWeek.Thursday:
                    day = "목";
                    break;
                case DayOfWeek.Friday:
                    day = "금";
                    break;
                case DayOfWeek.Saturday:
                    day = "토";
                    break;
                case DayOfWeek.Sunday:
                    day = "일";
                    break;
                default:
                    day = "일";
                    break;
            }

            return day;
        }


        /// <summary>
        /// 특정일자의 주차 구하기
        /// <summary>
        /// <param name="year"></param>
        /// <param name="month"></param>
        /// <param name="day"></param>
        /// <param name="dayOfWeek"></param>
        ///  <returns></returns>
        public static int GetWeekNumber(int year, int month, int day, DayOfWeek dayOfWeek)
        {
            DateTime calculationDate = new DateTime(year, month, day); //주차를 구할 일자
            DateTime standardDate = new DateTime(year, 9, 5);   //기준일
            Calendar calendarCalc = CultureInfo.CurrentCulture.Calendar;
            int weekNumber = calendarCalc.GetWeekOfYear(calculationDate, CalendarWeekRule.FirstDay, dayOfWeek)

                 - calendarCalc.GetWeekOfYear(standardDate, CalendarWeekRule.FirstDay, dayOfWeek) + 1;
            return weekNumber;
        }

    }




}

