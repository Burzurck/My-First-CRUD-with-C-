using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSProj.Helpers
{
    public class ConversionHelper
    {
        public static string ConvertGenreToName(int genre)
        {
            string genreName = string.Empty;
            switch (genre)
            {
                case 1:
                    genreName = "Animation";
                    break;
                case 2:
                    genreName = "Action";
                    break;
                case 3:
                    genreName = "Comedy";
                    break;
                case 4:
                    genreName = "Drama";
                    break;
                case 5:
                    genreName = "Horror";
                    break;
                case 6:
                    genreName = "Mystery";
                    break;
                case 7:
                    genreName = "Romance";
                    break;
                case 8:
                    genreName = "Science Fiction";
                    break;
                case 9:
                    genreName = "Western";
                    break;
                default:
                    genreName = "Not Found";
                    break;
            }
            return genreName;
        }
        public static int ConvertGenreToNumber(int genreIndex)
        {
            return genreIndex - 1;
        }
    }

}
