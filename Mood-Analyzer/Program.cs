﻿using System;

namespace Mood_Analyzer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Mood Analyzer Problem!");
            MoodAnalyzer mood = new MoodAnalyzer("I am in happy mood");
            Console.WriteLine(mood.AnalyzeMood());
        }
    }
}