using System;
using Shivani_Verma_Assignment_TikTok.TikTok.TikTokManager;

namespace Shivani_Verma_Assignment_TikTok
{
    class Program
    {
        //Test method of rtesting all the methods of tiktok manager
        public static void Main(string[] args)
        {
            TikTokManager.Initialize();
            TikTokManager.Show();
            TikTokManager.Show("fashion");
            TikTokManager.Show(5);
            TikTokManager.Show("World");
        }

    }
}