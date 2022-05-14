using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Block1_exe4_attemprt1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int totalPictures = 52;
            int picturesInOneRow = 3;
            int namberOfRows = totalPictures / picturesInOneRow;
            Console.WriteLine(namberOfRows);

            int usedPictures = namberOfRows * picturesInOneRow;
            Console.WriteLine(usedPictures);

            int extraPictures = totalPictures - usedPictures;
            Console.WriteLine(extraPictures);
        }

    }
}
