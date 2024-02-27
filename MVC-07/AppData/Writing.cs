using System;
using System.Collections.Generic;
using System.Linq;

namespace MVC_07.AppData
{
	
    public class Writing
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

    public class MyWritings
    {
        public static string BASEPATH = "http://localhost:5064";

        private List<Writing> MyAllWritings = new List<Writing>()
    {
        new Writing()
        {
            ID = 1,
            URL = BASEPATH +"/My-Wordplay/1/How-Blockchain-Works",
            SITE_URL ="/My-Wordplay/1/How-Blockchain-Works",
            Tags = "[\"Writing\",\"InfoGraphic\", \"Blockchain\"]",
            Slug = "How-Blockchain-Works",
            DataGroup = "[\"all\",\"technology\"]",
            Heading = "How Blockchain Works - Blockchain - Writing",
            Title = "How Blockchain Works",
            SubTitle = "Blockchain - Writing",
            IMG = "/images/MyWordplays/Blockchain/How-Blockchain-Works.jpg",
            VIDEO = "",
            Desription = "",
            Type = "Writing",
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

        public List<Writing> GetMyWritings(int Count)
        {
            List<Writing> Data = new List<Writing>();
            Data = MyAllWritings.Take(Count).ToList();
            return Data;
        }

        public Writing GetMyWriting(long ID)
        {
            Writing Data = new Writing();
            Data = MyAllWritings.FirstOrDefault(A => A.ID == ID);
            return Data;
        }

        public Writing GetMyWriting(string Slug)
        {
            Writing Data = new Writing();
            Data = MyAllWritings.FirstOrDefault(A => A.Slug == Slug);
            return Data;
        }

        public Writing GetMyWriting(long ID, string Slug)
        {
            Writing Data = new Writing();
            Data = MyAllWritings.FirstOrDefault(A => A.ID == ID && A.Slug == Slug);
            return Data;
        }

    }

}