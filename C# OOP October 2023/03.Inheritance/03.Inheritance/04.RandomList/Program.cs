﻿namespace CustomRandomList
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            RandomList randomList = new RandomList();
            randomList.Add("1");
            randomList.Add("2");
            randomList.Add("3");
            randomList.Add("4");
            Console.WriteLine(randomList.RandomString());
            Console.WriteLine(randomList.RandomString());

            randomList.Add("8");
            Console.WriteLine(randomList.RandomString());
        }
    }
}