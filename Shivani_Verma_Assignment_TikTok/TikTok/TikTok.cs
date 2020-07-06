using System;
using System.Collections.Generic;
using System.Text;

namespace Shivani_Verma_Assignment_TikTok.TikTok
{
    class TikTok
    {
        public  int _ID { get; }
        public string originator { get; }
        public int length { get;  }
        public string hashTag { get; }
        public Audience audience { get; }
        public string id { get; set; }



        public TikTok(string originator, int length, string hashTag, Audience audience)
        {
            this.id =  _ID.ToString();
            _ID++;
            this.originator = originator;
            this.length = length;
            this.hashTag = hashTag;
            this.audience = audience;
        }

        public TikTok(string id, string originator, string length, string hashTag, string audience)
        {
            this.id = id;
            this.originator = originator;
            this.length = int.Parse(length);
            this.hashTag = hashTag;
            //Enum.TryParse(TikTok.Audience, audience, false, null);
            //this.audience = Enum.Parse(typeof(Audience),audience);

        }

        public override string ToString()
        {
            return "Originator : " + originator + ", Hash Tag : " + hashTag + " : Id" + id;
        }

        public static TikTok parse(string line)
        {
            TikTok tikTok = null;
            try
            {
                string[] inputStrings = line.Split('\t');
                tikTok = new TikTok(inputStrings[0], inputStrings[1], inputStrings[2], inputStrings[3], inputStrings[4]);
                
            }
            catch (Exception ex)
            {
                Console.WriteLine("...Error in Parsing the file...");
            }
            return tikTok;

        }

        public enum Audience
        {
            World,
            Group,
            Special
        }
    }
}
