using System;
using System.Collections.Generic;

namespace StringCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> testList = new List<string>();
            Stack<string> testStack = new Stack<string>();
            Queue<string> testQueue = new Queue<string>();
            HashSet<string> testHash = new HashSet<string>();

            string[] testStrings = new string[] 
            {
                "ola", "mundo", "adeus", "mundo", "!"
            };

            for (int i = 0; i < testStrings.Length; i++)
            {
                testList.Add(testStrings[i]);
                testStack.Push(testStrings[i]);
                testQueue.Enqueue(testStrings[i]);
                testHash.Add(testStrings[i]);
            }
        }
    }
}
