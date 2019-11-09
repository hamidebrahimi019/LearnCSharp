using CustomCollection.Classes;
using System;
using ExtensionMethods;

namespace CustomCollection
{
    class Program
    {
        static void Main()
        {
            var strToFind = "abc";
            var strPrimary = "ckbda";
            var isContain = strPrimary.ContainsSubString(strToFind);
        }
    }
}

namespace ExtensionMethods
{
    public static class MyExtensions
    {
        public static bool ContainsSubString(this string strPrimary, string strToFind)
        {
            var found = false;
            var strToFindCharArray = strToFind.ToCharArray();
            foreach (var item in strToFindCharArray)
            {
                found = strPrimary.Contains(item);
                if (!found)
                    break;
            }
            return found;
        }
    }
}