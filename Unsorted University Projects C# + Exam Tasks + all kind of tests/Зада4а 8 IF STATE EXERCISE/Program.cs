﻿using System;

namespace Зада4а_8_ИФ_СТАТЕ_ЕЬЕРЦИСЕ
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int nights = int.Parse(Console.ReadLine());
            double studioPrice = 0;
            double apartmentPrice = 0;

            //if (nights > 14)
            //{
            //    apartmentPrice *= 0.90;
            //}
            //else
            //{
            //    apartmentPrice = apartmentPrice * apartmentPrice;
            //}

            if (month == "May" || month == "October")
            {
                studioPrice = nights * 50;
                apartmentPrice = nights * 65;

                if (nights > 7 && nights < 14)
                {
                    studioPrice *= 0.95;
                }
                else if (nights > 14)
                {
                    studioPrice *= 0.70;
                }
                else
                {
                    studioPrice = studioPrice * 1;
                }
            }
            else if (month == "June" || month == "September")
            {
                studioPrice = nights * 75.20;
                apartmentPrice = nights * 68.70;
                if (nights > 14)
                {
                    studioPrice *= 0.80;
                }
                else
                {
                    studioPrice = studioPrice * 1;
                }
            }
            else if (month == "July" || month == "August")
            {
                studioPrice = nights * 76;
                apartmentPrice = nights * 77;
            }
            if (nights > 14)
            {
                apartmentPrice *= 0.90;
            }
            else
            {
                apartmentPrice = apartmentPrice * 1;
            }
            Console.WriteLine($"Apartment: {apartmentPrice:f2} lv.");
            Console.WriteLine($"Studio: {studioPrice:f2} lv.");
        }
    }
}
