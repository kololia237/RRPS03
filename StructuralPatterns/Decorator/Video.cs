﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineCafe.StructuralPatterns.Decorator
{
    public class Video : LibraryItem
    {
        private string director;
        private string title;
        private int playTime;

        // Constructor

        public Video(string director, string title, int numCopies, int playTime)
        {
            this.director = director;
            this.title = title;
            this.NumCopies = numCopies;
            this.playTime = playTime;
        }

        public override string Display()
        {
            //Console.WriteLine("\nVideo ----- ");
            //Console.WriteLine(" Director: {0}", director);
            //Console.WriteLine(" Title: {0}", title);
            //Console.WriteLine(" # Copies: {0}", NumCopies);
            //Console.WriteLine(" Playtime: {0}\n", playTime);
            return $"Назва: {title}, Режисер: {director}, Кількість копій: {NumCopies}, Час: {playTime}";
        }
    }
}