﻿using System;
using System.Collections.Generic;

namespace Product_Management
{
    class Program
    {
        static void Main(string[] args)
        {
            //UC1
            Console.WriteLine("Hello World!");
            List<ProductReview> productReviewList = new List<ProductReview>()
            {

                new ProductReview() { ProductId = 1, UserId = 1, Rating = 9, Review = "Good", islike = true },
                new ProductReview() { ProductId = 4, UserId = 1, Rating = 3, Review = "Good", islike = true },
                 new ProductReview() { ProductId = 5, UserId = 1, Rating = 6, Review = "bad", islike = true },
                 new ProductReview() { ProductId = 6, UserId = 1, Rating = 4, Review = "Good", islike = true },
                 new ProductReview() { ProductId = 7, UserId = 1, Rating = 1, Review = "bad", islike = true },
                 new ProductReview() { ProductId = 8, UserId = 1, Rating = 4, Review = "Good", islike = true },
                 new ProductReview() { ProductId = 9, UserId = 1, Rating = 6, Review = "worst", islike = true },
                 new ProductReview() { ProductId = 3, UserId = 1, Rating = 6, Review = "Good", islike = true },
                 new ProductReview() { ProductId = 4, UserId = 1, Rating = 9, Review = "Good", islike = true },
                 new ProductReview() { ProductId = 5, UserId = 1, Rating = 10, Review = "bad", islike = true },
                 new ProductReview() { ProductId = 6, UserId = 1, Rating = 6, Review = "Good", islike = true },
                 new ProductReview() { ProductId = 7, UserId = 1, Rating = 5, Review = "Good", islike = true },
                 new ProductReview() { ProductId = 6, UserId = 1, Rating = 5, Review = "Good", islike = true },
                 new ProductReview() { ProductId = 4, UserId = 1, Rating = 8, Review = "bad", islike = true },
                 new ProductReview() { ProductId = 4, UserId = 1, Rating = 3, Review = "Good", islike = true },
                 new ProductReview() { ProductId = 5, UserId = 1, Rating = 2, Review = "Good", islike = true },
            };
            //foreach (var list in productReviewList)
            //{
            //    Console.WriteLine("ProductID:-" + list.ProductId + " " + "UserID:-" + list.UserId + " " + "Rating:-" + " " + list.Rating + " " + "Review:-" + list.Review + " " + "islike:-" + list.islike);
            //}

            Management management = new Management();
            //UC2
            management.Toprecords(productReviewList);
            //UC3
            //management.SelectRecords(productReviewList);
            //UC4
            management.RetriveCount(productReviewList);
            //UC5
            management.RetrieveProductAndReview(productReviewList);
            //UC6
            management.SkipRecord(productReviewList);
        }
    }
}
