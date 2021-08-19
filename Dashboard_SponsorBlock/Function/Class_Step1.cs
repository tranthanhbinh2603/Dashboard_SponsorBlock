namespace Dashboard_SponsorBlock.Function
{
    class Class_Step1
    {
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
