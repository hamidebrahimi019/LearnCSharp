//using CustomCollection.Classes;
//using System;
//using static CustomCollection.Classes.MyProjectEnums;
//using ExtensionMethods;
//using System.Text.RegularExpressions;

//namespace CustomCollection
//{
//    class Program
//    {
//        static void Main()
//        {
//            try
//            {
//                var a = "a";
//                var b = "ceba";

//                var ccccc = b.IndexOf(a);


//                var isContain = b.ContainsSubString(a);
//                var xvb = 0;
//                #region MyRegion
//                int i = 42;
//                System.Type type = i.GetType();
//                System.Console.WriteLine(type);

//                //test
//                // استک و صف همزمان
//                Console.WriteLine("queue: ");
//                FifoLifoList<string> fl = new FifoLifoList<string>((int)CollectionNames.Queue);
//                fl.Add("a");
//                fl.Add("b");
//                fl.Add("c");

//                Console.WriteLine(fl.Remove().GetData());
//                Console.WriteLine(fl.Remove().GetData());

//                Console.WriteLine("stack: ");

//                // استک و صف همزمان
//                FifoLifoList<string> fl2 = new FifoLifoList<string>((int)CollectionNames.Stack);
//                fl2.Add("a");
//                fl2.Add("b");
//                fl2.Add("c");

//                Console.WriteLine(fl2.Remove().GetData());
//                Console.WriteLine(fl2.Remove().GetData());

//                // (استک با پایه آرایه برای سرعت بیشتر (چون ولیو تایپ است
//                Console.WriteLine("ArrayBasedStack: ");
//                ArrayBasedStack<int> arbStack = new ArrayBasedStack<int>();
//                arbStack.Push(1);
//                arbStack.Push(2);
//                arbStack.Push(3);
//                Console.WriteLine(arbStack.Pop());
//                Console.WriteLine(arbStack.Pop());

//                //---------------------------
//                Console.WriteLine("CustomQueue: ");
//                CustomQueue<string> cq = new CustomQueue<string>();
//                cq.EnQueue("a");
//                cq.EnQueue("b");
//                cq.EnQueue("c");

//                Console.WriteLine(cq.DeQueue().GetData());
//                Console.WriteLine(cq.DeQueue().GetData());
//                cq.Clear();
//                //Console.WriteLine(cq.DeQueue().Data);


//                Console.WriteLine("CustomStack: ");
//                CustomStack<int> numbers = new CustomStack<int>();
//                numbers.Push(1);
//                numbers.Push(2);
//                numbers.Push(3);
//                numbers.Push(4);
//                numbers.Push(5);
//                numbers.PrintAll();

//                Console.WriteLine("Count of stack is: {0}", numbers.Count());

//                Console.WriteLine("Popping {0}", numbers.PopData());
//                Console.WriteLine("Popping {0}", numbers.PopData());
//                numbers.Clear();
//                //Console.WriteLine("Popping '{0}'", numbers.Pop2());

//                //-------------------
//                CustomStack<string> stack = new CustomStack<string>();
//                stack.Push("first");
//                stack.Push("second");
//                stack.Push("third");
//                Console.WriteLine("\nall data");
//                stack.PrintAll();
//                Console.WriteLine("\nPeek");
//                Console.WriteLine(stack.PeekFromStack().GetData());
//                Console.WriteLine("\nPrintAll again");
//                stack.PrintAll();
//                Console.WriteLine("\nnow try to pop");
//                Console.WriteLine(stack.Pop().GetData());
//                Console.WriteLine("\nPrintAll again");
//                stack.PrintAll();
//                Console.WriteLine("\nnow try to popping two items ");
//                Console.WriteLine("Popping {0}", stack.Pop().GetData());
//                Console.WriteLine("Popping {0}", stack.Pop().GetData());

//                Console.WriteLine("\nPrintAll again");
//                stack.PrintAll();
//                Console.WriteLine("\nPush three item");
//                stack.Push("first");
//                stack.Push("second");
//                stack.Push("third");
//                stack.PrintAll();
//                #endregion
//            }
//            catch (Exception e)
//            {
//                Console.WriteLine(e.Message);
//            }
//        }
//    }
//}

//namespace ExtensionMethods
//{
//    public static class MyExtensions
//    {
//        public static bool ContainsSubString(this string strPrimary, string strToFind)
//        {
//            var found = false;
//            var strToFindCharArray = strToFind.ToCharArray();
//            foreach (var item in strToFindCharArray)
//            {
//                found = strPrimary.Contains(item);
//                if (!found)
//                    break;
//            }
//            return found;
//        }
//    }
//}



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