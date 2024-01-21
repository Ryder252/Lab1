using System;
using System.Security.Cryptography.X509Certificates;
namespace Lab1
{
    public class VideoGame : IComparable<VideoGame>
    {
        public string name { get; set; }
        public string platform { get; set; }
        public string year { get; set; }
        public string genre { get; set; }
        public string publisher { get; set; }
        public string na_Sales { get; set; }
        public string eu_Sales { get; set; }
        public string jp_Sales { get; set; }
        public string other_Sales { get; set; }
        public string global_Sales { get; set; }

        public VideoGame(string Name, string Platform, string Year, string Genre, string Publisher, string NA_Sales, string EU_Sales, string JP_Sales, string Other_Sales, string Global_Sales)
        {
            name = Name;
            platform = Platform;
            year = Year;
            genre = Genre;
            publisher = Publisher;
            na_Sales = NA_Sales;
            eu_Sales = EU_Sales;
            jp_Sales = JP_Sales;
            other_Sales = Other_Sales;
            global_Sales = Global_Sales;
        }

        public int CompareTo(VideoGame other)
        {
            return string.Compare(this.name, other.name, StringComparison.OrdinalIgnoreCase);
        }
        public override string ToString()
        {
            return name;
        }
    }   
}
