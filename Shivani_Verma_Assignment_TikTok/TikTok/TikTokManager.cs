using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Shivani_Verma_Assignment_TikTok.TikTok.TikTokManager
{
     static class TikTokManager
     {
         private static string fileName;

        private static List<TikTok> tikToks;


         static TikTokManager()
        {
            //Initializing the list
            tikToks = new List<TikTok>();
            
            StreamReader streamReader = File.OpenText(fileName);
            while (streamReader != null)
            {
                string singleLine = streamReader.ReadLine();
                TikTok tikTok = TikTok.parse(singleLine);
                tikToks.Add(tikTok);
            }

        }

        public static void Initialize()
        {
            tikToks = new List<TikTok>();
            try
            {
                foreach (TikTok tikTok in tikToks)
                {
                    string originator = tikTok.originator;
                    string hashTag = tikTok.hashTag;
                    int length = tikTok.length;
                    TikTok.Audience audience = tikTok.audience;

                    TikTok tikTok1 = new TikTok(originator, length, hashTag, audience);
                    TikTok tikTok2 = new TikTok(originator, length, hashTag, audience);
                    TikTok tikTok3 = new TikTok(originator, length, hashTag, audience);
                    TikTok tikTok4 = new TikTok(originator, length, hashTag, audience);
                    TikTok tikTok5 = new TikTok(originator, length, hashTag, audience);

                    tikToks.Add(tikTok1);
                    tikToks.Add(tikTok2);
                    tikToks.Add(tikTok3);
                    tikToks.Add(tikTok4);
                    tikToks.Add(tikTok5);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("...Error occured while Initializing..." + ex.ToString());
            }
           
        }

        public static void Show()
        {
            for (int i = 0; i < tikToks.Count; i++)
            {
                Console.WriteLine("Printing the TikTok's Name : " + tikToks[i]);
            }
        }

        public static void Show(string tag)
        {
            for (int i = 0; i < tikToks.Count; i++)
            {
                if (tikToks[i].hashTag.Equals(tag))
                {
                    Console.WriteLine("TikTok with it's matching HashTags :: " + tikToks[i]);

                }
            }
        }

        public static void Show(int length)
        {
            //Displaying all the tiktoks with lenght greater than the argument.
            if (tikToks.Count > length)
                foreach (TikTok tikTok in tikToks)
                {
                    Console.WriteLine("TikTok with it's matching HashTags :: " + tikTok);

                }


        }

        public static void Show(TikTok.Audience audience)
        {
            //Displaying the tiktoks with the same audience given in the argument.
            foreach (TikTok tikTok in tikToks)
            {
                if (tikTok.audience.Equals(audience))
                {
                    Console.WriteLine("TikTok with having the sane Audience : " + tikTok.audience);
                }
            }
        }
    }
}
