﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace Blazor_01.AppData
{


    public class Infographic
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
        public string List_IMG_URL { get; internal set; }
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
        public string PunchLine { get; internal set; }
    }

    public class MyInfographics
    {
        public static string BASEPATH = "http://localhost:5064";

        private List<Infographic> MyAllInfographics = new List<Infographic>()
    {
        new Infographic()
        {
            ID = 1,
            URL = BASEPATH +"/My-Infographic/1/How-Blockchain-Works",
            SITE_URL ="/My-Infographic/1/How-Blockchain-Works",
            Tags = "[\"Infographic\", \"Blockchain\"]",
            Slug = "How-Blockchain-Works",
            DataGroup = "[\"all\",\"blockchain\",\"how\"]",
            Heading = "How Blockchain Works - Blockchain - Infographic",
            Title = "How Blockchain Works?",
            SubTitle = "Blockchain - Infographic",
            PunchLine = "Unlocking the Power of Blockchain: A Journey through Transparency, Security, and Innovation",
            IMG = "/images/MyInfographics/Blockchain/How-Blockchain-Works.jpg",
            List_IMG_URL = "/images/MyInfographics/Blockchain/How-Blockchain-Works-Infogrphics.jpg",
            VIDEO = "",
            Desription = "<p class='Art-Detail-Text'>In a rapidly evolving digital landscape, where trust and security are paramount, there emerges a technology that's rewriting the rules of data management, introducing transparency and reshaping industries. Welcome to the world of blockchain, where every transaction becomes an unchangeable part of an open, decentralized ledger.</p> <p class='Art-Detail-Text'>A revolutionary force that's empowering individuals, businesses, and even governments to redefine trust in the digital age.</p><p class='Art-Detail-Text'>Let's break it down:</p><h3 class='L-C'>What is Blockchain?</h3><p class='Art-Detail-Text'><strong class='T-C'>Definition:</strong> Blockchain is a digital ledger technology that stores data in a chain of blocks, ensuring transparency, security, and immutability.</p><p class='Art-Detail-Text'><strong class='T-C'>Example:</strong> Think of a blockchain as a digital notepad where you write down transactions. Each page (block) can only hold a certain number of transactions, and when it's full, you move to the next page, linking them together like a chain.</p><h3 class='L-C'>Key Concepts</h3><h4 class='G-C'>a) Blocks</h4>\n<p class='Art-Detail-Text'><strong class='T-C'>Definition:</strong> Blocks are containers that hold groups of transactions in a blockchain.</p>\n<p class='Art-Detail-Text'><strong class='T-C'>Example:</strong> Imagine a block as a box that can hold multiple items (transactions). When the box is full, it's sealed and added to the chain.</p><h4 class='G-C'>b) Chain</h4>\n<p class='Art-Detail-Text'><strong class='T-C'>Definition:</strong> The chain represents the sequential order of blocks in a blockchain.</p>\n<p class='Art-Detail-Text'><strong class='T-C'>Example:</strong> Think of the chain as a necklace made of connected blocks. Each block is like a bead, and they're all strung together in a specific order.</p><h3 class='L-C'>The Process</h3><h4 class='G-C'>a) Transaction</h4>\n<p class='Art-Detail-Text'><strong class='T-C'>Definition:</strong> A transaction is an action that changes the state of data on the blockchain.</p>\n<p class='Art-Detail-Text'><strong class='T-C'>Example:</strong> Sending digital money from one person to another is a transaction. It's like transferring money between two bank accounts.</p><h4 class='G-C'>b) Mining and Proof of Work</h4>\n<p class='Art-Detail-Text'><strong class='T-C'>Definition:</strong> Mining is the process of adding new blocks to the blockchain, and Proof of Work is the way miners compete to do it.</p>\n<p class='Art-Detail-Text'><strong class='T-C'>Example:</strong> Mining is like solving a complex puzzle. The first one to solve it gets to add a new page (block) to the notepad (blockchain) and earns a reward.</p><h4 class='G-C'>c) Verification</h4>\n<p class='Art-Detail-Text'><strong class='T-C'>Definition:</strong> Transactions are checked by network participants to ensure they are valid and follow the rules.</p>\n<p class='Art-Detail-Text'><strong class='T-C'>Example:</strong> Imagine a group of people checking that all the entries in the notepad are correct before allowing a new page to be added.</p><h4 class='G-C'>d) Execution</h4>\n<p class='Art-Detail-Text'><strong class='T-C'>Definition:</strong> Smart contracts automatically execute actions when predefined conditions are met.</p>\n<p class='Art-Detail-Text'><strong class='T-C'>Example:</strong> Think of a vending machine as a smart contract. It gives you a snack when you insert money.</p><h4 class='G-C'>e) Hashing</h4>\n<p class='Art-Detail-Text'><strong class='T-C'>Definition:</strong> Hashing is a process that turns data into a unique code (hash) to secure it.</p>\n<p class='Art-Detail-Text'><strong class='T-C'>Example:</strong> It's like turning a secret message into a special code so that only you and your friend can read it.</p><h4 class='G-C'>f) Completion</h4>\n<p class='Art-Detail-Text'><strong class='T-C'>Definition:</strong> When a block is full and verified, it's added to the blockchain, and the process continues.</p>\n<p class='Art-Detail-Text'><strong class='T-C'>Example:</strong> When the notepad page is full, you seal it and add it to the necklace (chain), then start writing on a new page.</p><hr /><p class='Art-Detail-Text'>Visit [<a class='L-C' href='/My-Infographics'>MORE</a>] Infographics for promoting visual learning. Which is a dynamic and effective approach to education and communication. Visuals, such as diagrams, charts, and infographics, play a crucial role in simplifying complex ideas and making them more accessible. They engage learners by appealing to their sense of sight, aiding in information retention and comprehension. Visual learning not only enhances understanding but also encourages creativity and critical thinking. In an increasingly visual world, harnessing the power of visuals can transform the learning experience, making it more engaging, memorable, and impactful for students and audiences of all ages.</p><p class='Art-Detail-Text'>Visit [<a class='L-C' href='/My-Art-Fulness'>MORE</a>] to step into a world where creativity dances with imagination. Where colors come alive. Art whispers its secrets.</p><p class='Art-Detail-Text'>Visit [<a class='L-C' href='https://opensea.io/KhizoOo_'>MORE</a>] to visit my OpenSea account.</p>",
            Type = "Infographic",
            Category = "Technologies",
            CreatedOn = "1st AUG 2023",

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
        new Infographic()
        {
            ID = 2,
            URL = BASEPATH +"/My-Infographic/2/Evolution-Of-Computer-Hardware",
            SITE_URL ="/My-Infographic/2/Evolution-Of-Computer-Hardware",
            Tags = "[\"Infographic\", \"General\"]",
            Slug = "Evolution-Of-Computer-Hardware",
            DataGroup = "[\"all\",\"general\",\"how\"]",
            Heading = "Evolution Of Computer Hardware - General - Infographic",
            Title = "Evolution Of Computer Hardware",
            SubTitle = "General - Infographic",
            PunchLine = "From Abacus to Quantum Computing: A Journey Through Computer Hardware",
            IMG = "/images/MyInfographics/General/Evolution-Of-Computer-Hardware.jpg",
            List_IMG_URL = "/images/MyInfographics/General/Evolution-Of-Computer-Hardware-Infogrphics.jpg",
            VIDEO = "",
            Desription = "<h3 class='L-C'>1. Abacus (3000 BC)</h3><p class='Art-Detail-Text'><strong class='T-C'>Definition:</strong> The humble abacus, with its rows of beads, was humanity's first computing device.</p>\n<p class='Art-Detail-Text'><strong class='T-C'>Example:</strong> Think of it as an ancient calculator, helping traders with arithmetic.</p><h3 class='L-C'>2. Mechanical Calculators (17th Century)</h3>\n<p class='Art-Detail-Text'><strong class='T-C'>Definition:</strong> Ingenious mechanical devices designed for arithmetic calculations.</p>\n<p class='Art-Detail-Text'><strong class='T-C'>Example:</strong> The Pascaline, invented by Blaise Pascal, could add and subtract numbers.</p><h3 class='L-C'>3. The Birth of Computers (1940s)</h3>\n<p class='Art-Detail-Text'><strong class='T-C'>Definition:</strong> The first electronic computers, like ENIAC and Colossus, emerged during World War II.</p>\n<p class='Art-Detail-Text'><strong class='T-C'>Example:</strong> ENIAC filled an entire room and could perform complex calculations at incredible speeds.</p><h3 class='L-C'>4. Transistors (1950s)</h3>\n<p class='Art-Detail-Text'><strong class='T-C'>Definition:</strong> The invention of transistors revolutionized computing, making computers smaller and more reliable.</p>\nExample: Imagine transistors as tiny switches controlling the flow of electrical current.</p><h3 class='L-C'>5. Integrated Circuits (1960s)</h3>\n<p class='Art-Detail-Text'><strong class='T-C'>Definition:</strong> Multiple transistors were integrated into a single chip, leading to miniaturization.</p>\n<p class='Art-Detail-Text'><strong class='T-C'>Example:</strong> Microchips made calculators, early PCs, and space exploration possible.</p><h3 class='L-C'>6. Microprocessors (1970s)</h3>\n<p class='Art-Detail-Text'><strong class='T-C'>Definition:</strong> The birth of microprocessors like the Intel 4004 paved the way for personal computers.</p>\nExample: The 4004 powered early handheld calculators.</p><h3 class='L-C'>7. Personal Computers (1980s)</h3>\n<p class='Art-Detail-Text'><strong class='T-C'>Definition:</strong> The era of personal computing dawned with machines like the IBM PC.</p>\n<p class='Art-Detail-Text'><strong class='T-C'>Example:</strong> IBM PC allowed individuals to perform tasks like word processing and gaming.</p><h3 class='L-C'>8. Graphical User Interface (1980s-1990s)</h3>\nDescription: GUIs, like Windows and Mac OS, made computers user-friendly.</p>\n<p class='Art-Detail-Text'><strong class='T-C'>Example:</strong> Icons and windows replaced text-based commands.</p><h3 class='L-C'>9. Mobile Devices (2000s)</h3>\n<p class='Art-Detail-Text'><strong class='T-C'>Definition:</strong> Computers became pocket-sized with the advent of smartphones and tablets.</p>\n<p class='Art-Detail-Text'><strong class='T-C'>Example:</strong> The iPhone made computing truly mobile.</p><h3 class='L-C'>10. Quantum Computing (Present and Future)</h3>\n<p class='Art-Detail-Text'><strong class='T-C'>Definition:</strong> Quantum computers use the strange properties of quantum mechanics for incredibly fast calculations.</p>\n<p class='Art-Detail-Text'><strong class='T-C'>Example:</strong> They have the potential to revolutionize cryptography and drug discovery.</p><p class='Art-Detail-Text'>As technology continues to evolve, who knows what the future holds for computer hardware? From the abacus to quantum computing, each step has shaped the way we live and work in the digital age.</p><hr /><p class='Art-Detail-Text'>Visit [<a class='L-C' href='/My-Infographics'>MORE</a>] Infographics for promoting visual learning. Which is a dynamic and effective approach to education and communication. Visuals, such as diagrams, charts, and infographics, play a crucial role in simplifying complex ideas and making them more accessible. They engage learners by appealing to their sense of sight, aiding in information retention and comprehension. Visual learning not only enhances understanding but also encourages creativity and critical thinking. In an increasingly visual world, harnessing the power of visuals can transform the learning experience, making it more engaging, memorable, and impactful for students and audiences of all ages.</p><p class='Art-Detail-Text'>Visit [<a class='L-C' href='/My-Art-Fulness'>MORE</a>] to step into a world where creativity dances with imagination. Where colors come alive. Art whispers its secrets.</p><p class='Art-Detail-Text'>Visit [<a class='L-C' href='https://opensea.io/KhizoOo_'>MORE</a>] to visit my OpenSea account.</p>",
            Type = "Infographic",
            Category = "General",
            CreatedOn = "2nd AUG 2023",

            Facebook = "",
            Instagram = "",
            LinkedIn = "",
            YouTube = "",
            OpenSea = "",
            Twitter = "",
            TikTok = "",
            Pinterest = "",
            Snapchat = "",

            PreviousWorkID = 1,
            NextWorkID = 3
        }
    };

        public List<Infographic> GetMyInfographics(int Count)
        {
            List<Infographic> Data = new List<Infographic>();
            Data = MyAllInfographics.Take(Count).ToList();
            return Data;
        }

        public Infographic GetMyInfographic(long ID)
        {
            Infographic Data = new Infographic();
            Data = MyAllInfographics.FirstOrDefault(A => A.ID == ID);
            return Data;
        }

        public Infographic GetMyInfographic(string Slug)
        {
            Infographic Data = new Infographic();
            Data = MyAllInfographics.FirstOrDefault(A => A.Slug == Slug);
            return Data;
        }

        public Infographic GetMyInfographic(long ID, string Slug)
        {
            Infographic Data = new Infographic();
            Data = MyAllInfographics.FirstOrDefault(A => A.ID == ID && A.Slug == Slug);
            return Data;
        }

    }

}

