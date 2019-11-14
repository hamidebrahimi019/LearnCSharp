//راه حلت درسته اما مرتبه زمانیش بالاس
// آیا می تونی راه حلی بدی که مرتبه زمانی بهتری داشته باشه؟
//

//با روش زیر هر بار یک مورد که توی سرچ پیدا میشه از متن اصلی حذف میشه


using System;
using System.Linq;

class test
{
    static bool isSubSequence(string subString, string mainString, int subStringLenght, int mainStringLenght)
    {
        if (subStringLenght == 0)
            return true;
        if (mainStringLenght == 0)
            return false;

        var str1Char = subString[subStringLenght - 1];
        var str2Char = mainString[mainStringLenght - 1];
        if (str1Char == str2Char)
        {
            var tempList = mainString.Split(str1Char).ToList();
            mainString = String.Join("", tempList);
            mainStringLenght = mainString.Length;
            subStringLenght = subStringLenght - 1;
            return isSubSequence(subString, mainString, subStringLenght, mainStringLenght);
        }

        return isSubSequence(subString, mainString, subStringLenght, mainStringLenght - 1);
    }

    // Driver program 
    public static void Main()
    {
        //string subString = "gksrek2";
        string subString = "okua";
        //string mainString = "geeksfo2rgeeks";
        string mainString = "akcoeutgfd";

        int sLenght = subString.Length;
        int mLenght = mainString.Length;

        bool result = isSubSequence(subString, mainString, sLenght, mLenght);

        if (result)
            Console.Write("Yes");
        else
            Console.Write("No");
    }
}
