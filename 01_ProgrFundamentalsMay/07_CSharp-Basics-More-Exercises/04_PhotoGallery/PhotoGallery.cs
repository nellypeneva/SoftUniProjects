using System; 

namespace _04_PhotoGallery
{
    class PhotoGallery
    {
        static void Main()
        {
            int photoNumber = int.Parse(Console.ReadLine());
            int day = int.Parse(Console.ReadLine());
            int month = int.Parse(Console.ReadLine());
            int year = int.Parse(Console.ReadLine());
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());
            ulong photoSize = ulong.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());

            DateTime date = new DateTime(year, month, day, hours, minutes, 0);
            string sizeType = String.Empty;
            double size = (double)photoSize;

            if (photoSize < 1000)
            {
                sizeType = "B";
            }
            else if (photoSize < 1000 * 1000)
            {
                size = photoSize / 1000.0;
                sizeType = "KB";
            }
            else if (photoSize < 1000 * 1000 * 1000) 
            {
                size = photoSize / 1000000.0;
                sizeType = "MB";
            }
            else
            {
                size = photoSize / 1000000000.0;
                sizeType = "GB";
            }

            string orientation = String.Empty;

            if (width == height)
            {
                orientation = "square"; 
            }
            else if (width > height)
            {
                orientation = "landscape"; 
            }
            else
            {
                orientation = "portrait"; 
            }

            Console.WriteLine("Name: DSC_{0}.jpg", photoNumber.ToString("D4"));
            Console.WriteLine("Date Taken: {0}", date.ToString("dd/MM/yyyy HH:mm", System.Globalization.CultureInfo.InvariantCulture));
            Console.WriteLine("Size: {0}{1}", size, sizeType);
            Console.WriteLine("Resolution: {0}x{1} ({2})", width, height, orientation);
        }
    }
}
