using ConsoleApp1.StudentService;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            TakeScreenShot_PrimaryScreen();
            TakeScreenShot_SecondScreen();

        }

        static void TakeScreenShot_PrimaryScreen()
        {
            var primaryScreen = Screen.PrimaryScreen;

            Bitmap bmp = new Bitmap(primaryScreen.Bounds.Width, primaryScreen.Bounds.Height);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.CopyFromScreen(0, 0, 0, 0, primaryScreen.Bounds.Size);
                bmp.Save(DateTime.Now.ToString("yyyyMMdd_HHmmss") + "_primary_screenshot.png", ImageFormat.Png);  // saves the image
            }
        }

        static void TakeScreenShot_SecondScreen()
        {
            var screen = Screen.AllScreens[1];
            var primaryScreen = Screen.PrimaryScreen;

            Bitmap bmp = new Bitmap(screen.Bounds.Width, screen.Bounds.Height);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.CopyFromScreen(primaryScreen.Bounds.Width, 0, 0, 0, screen.Bounds.Size);
                bmp.Save(DateTime.Now.ToString("yyyyMMdd_HHmmss") + "_secondary_screenshot.png", ImageFormat.Png);  // saves the image
            }
        }
    }
}
