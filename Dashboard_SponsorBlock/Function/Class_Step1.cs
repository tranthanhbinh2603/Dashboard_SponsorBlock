﻿using System.Collections.Generic;
using System.Net;
using System.Text.RegularExpressions;

namespace Dashboard_SponsorBlock.Function
{
    class Class_Step1
    {
        public static void Get_Link_Video(string pageSource, ref List<string> res)
        {
            Regex reg = new Regex(@"<a id=""video-title"" class=""yt-simple-endpoint style-scope ytd-grid-video-renderer"" aria-label="".*?"" title=""(?<Name_Video>.*?)"" href=""(?<Link>.*?)"">.*?</a>");
            foreach (Match item in reg.Matches(pageSource))
            {
                foreach (Capture cap in item.Groups["Link"].Captures)
                {
                    res.Add(cap.ToString().Substring(cap.ToString().IndexOf('=') + 1, cap.ToString().Length - cap.ToString().IndexOf('=') - 1));
                }
            }
        }

        public static void Get_Page_Video(string pageSource, ref List<string> res)
        {
            Regex reg = new Regex(@"<a id=""video-title"" class=""yt-simple-endpoint style-scope ytd-grid-video-renderer"" aria-label="".*?"" title=""(?<Name_Video>.*?)"" href=""(?<Link>.*?)"">.*?</a>");
            foreach (Match item in reg.Matches(pageSource))
            {
                foreach (Capture cap1 in item.Groups["Name_Video"].Captures)
                {
                    res.Add(WebUtility.HtmlDecode(cap1.ToString()));
                }
            }
        }

        public static void Get_Time_Video(string pageSource, ref List<string> res)
        {
            Regex reg1 = new Regex(@"<span id=""text"" class=""style-scope ytd-thumbnail-overlay-time-status-renderer"" aria-label=""(?<Time>.*?)"">", RegexOptions.IgnoreCase | RegexOptions.CultureInvariant | RegexOptions.Multiline | RegexOptions.Singleline);
            foreach (Match item in reg1.Matches(pageSource))
            {
                foreach (Capture cap1 in item.Groups["Time"].Captures)
                {
                    string time = GetTime(WebUtility.HtmlDecode(cap1.ToString()));
                    res.Add(time);
                }
            }
        }

        public static string Get_Channel_Name(string pageSource)
        {
            Regex reg2 = new Regex(@"<yt-formatted-string id=""text"" title="""" class=""style-scope ytd-channel-name"">(?<NameChannel>.*?)</yt-formatted-string>");
            return reg2.Matches(pageSource.ToString())[0].Groups["NameChannel"].Captures[0].ToString();
        }

        public static string GetTime(string strinput)
        {
            string timeres = "";
            int hour = 0;
            int minute = 0;
            int second = 0;
            string[] word = strinput.ToString().Split(' ');
            for (int a = 0; a < word.Length; a++)
            {
                if ((word[a] == "hours,") || (word[a] == "hours") || (word[a] == "hour") || (word[a] == "hour,"))
                {
                    hour = int.Parse(word[a - 1]);
                }
                if ((word[a] == "minutes,") || (word[a] == "minutes") || (word[a] == "minute") || (word[a] == "minute,"))
                {
                    minute = int.Parse(word[a - 1]);
                }
                if (word[a] == "seconds" || (word[a] == "second"))
                {
                    second = int.Parse(word[a - 1]);
                }
            }
            if (hour != 0)
            {
                timeres = hour + ":" + minute + ":" + second;
            }
            else
            {
                timeres = minute + ":" + second;
            }
            return timeres;
        }
    }
}