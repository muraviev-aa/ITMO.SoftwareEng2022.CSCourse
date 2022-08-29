namespace Utils
{
    using System;

    class Utils
    {
        public static void Revers(ref string s)
        {
            string sRev = "";

            for (int k = s.Length - 1; k >= 0; k--)
            {
                sRev = sRev + s[k];
            }
            s = sRev;
        }
    }
}
