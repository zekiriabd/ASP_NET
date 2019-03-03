using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace YTEncyclopedia
{
    public class Video
    {
        public int IDvideo      { get; set; }
        public string Name      { get; set; }
        public int LikedCount   { get; set; }
        public DateTime Date    { get; set; }
        public int IDteacher    { get; set; }
        public int IDcourse     { get; set; }
        public string Image     { get; set; }
        public string Url       { get; set; }
        public bool Isdeleted   { get; set; }
    }
}