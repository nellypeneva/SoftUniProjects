using System;
class TheaThePhotographer
{
    static void Main()
    {
        long n = long.Parse(Console.ReadLine());
        long filterTimeSeconds = long.Parse(Console.ReadLine());
        long filterFactorPecentage = long.Parse(Console.ReadLine());
        long uploadTimeSeconds = long.Parse(Console.ReadLine());

        long filterTime = filterTimeSeconds * n;
        long filteredPictures = (long)Math.Ceiling(n * (filterFactorPecentage / 100.00));

        long totalTimeSeconds = filterTime + filteredPictures * uploadTimeSeconds;
        //var time = new TimeSpan(0, 0, totalTimeSeconds);
        TimeSpan time = TimeSpan.FromSeconds(totalTimeSeconds);
        string str = time.ToString(@"d\:hh\:mm\:ss");
        Console.WriteLine(str);
    }
}
