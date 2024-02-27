using System;
using System.Collections.Generic;
using System.Linq;

namespace MVC_07.AppData
{
    public class Timeline
    {
        public long ID { get; set; }
        public string URL { get; set; }
        public string SITE_URL { get; set; }
        public string LiveURL { get; set; }
        public string Tags { get; set; }
        public string Slug { get; set; }
        public string DataGroup { get; set; }
        public string Heading { get; set; }
        public string Title { get; set; }
        public string SubTitle { get; set; }
        public string IMG { get; set; }
        public string VIDEO { get; set; }
        public string Desription { get; set; }
        public string Type { get; set; }
        public string Category { get; set; }
        public string CreatedOn { get; set; }

        public string Facebook { get; set; }
        public string Instagram { get; set; }
        public string YouTube { get; set; }
        public string OpenSea { get; set; }
        public string Twitter { get; set; }
        public string TikTok { get; set; }
        public string LinkedIn { get; set; }
        public string Pinterest { get; set; }
        public string Snapchat { get; set; }

        public long PreviousWorkID { get; set; }
        public long NextWorkID { get; set; }

        // PENDINGS
        public long ModuleID { get; set; }
    }

    public class MyTimelines
    {
        public static string BASEPATH = "http://localhost:5064";

        private List<Timeline> MyAllTimelines = new List<Timeline>()
    {
        new Timeline()
        {
            ID = 1,
            URL = BASEPATH +"/My-Wordplay/1/How-Blockchain-Works",
            SITE_URL ="/My-Wordplay/1/How-Blockchain-Works",
            Tags = "[\"Timeline\",\"InfoGraphic\", \"Blockchain\"]",
            Slug = "How-Blockchain-Works",
            DataGroup = "[\"all\",\"technology\"]",
            Heading = "How Blockchain Works - Blockchain - Timeline",
            Title = "How Blockchain Works",
            SubTitle = "Blockchain - Timeline",
            IMG = "/images/MyWordplays/Blockchain/How-Blockchain-Works.jpg",
            VIDEO = "",
            Desription = "",
            Type = "Timeline",
            Category = "Technologies",
            CreatedOn = "30th JUL 2023",

            Facebook = "",
            Instagram = "",
            LinkedIn = "",
            YouTube = "",
            OpenSea = "",
            Twitter = "",
            TikTok = "",
            Pinterest = "",
            Snapchat = "",

            PreviousWorkID = 0,
            NextWorkID = 2
        },
    };

        public List<Timeline> GetMyTimelines(int Count)
        {
            List<Timeline> Data = new List<Timeline>();
            Data = MyAllTimelines.Take(Count).ToList();
            return Data;
        }

        public Timeline GetMyTimeline(long ID)
        {
            Timeline Data = new Timeline();
            Data = MyAllTimelines.FirstOrDefault(A => A.ID == ID);
            return Data;
        }

        public Timeline GetMyTimeline(string Slug)
        {
            Timeline Data = new Timeline();
            Data = MyAllTimelines.FirstOrDefault(A => A.Slug == Slug);
            return Data;
        }

        public Timeline GetMyTimeline(long ID, string Slug)
        {
            Timeline Data = new Timeline();
            Data = MyAllTimelines.FirstOrDefault(A => A.ID == ID && A.Slug == Slug);
            return Data;
        }

    }
}

