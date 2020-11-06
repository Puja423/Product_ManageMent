using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Linq;
using System.Text.RegularExpressions;
using NPOI.SS.Formula.Functions;

namespace Product_Management
{
    public class Management
    {
        public readonly DataTable dataTable = new DataTable();
        public void Toprecords(List<ProductReview> listProductReview)
        {
            var recordData = (from productReviews in listProductReview
                              orderby productReviews.Rating descending
                              select productReviews).Take(3);

        }
        //UC3
        public void SelectRecords(List<ProductReview> ListProductReview)
        {
            var SelectRecords = from productReviews in ListProductReview
                                where (productReviews.ProductId == 1 || productReviews.ProductId == 4 || productReviews.ProductId == 9)
                                && productReviews.Rating > 3
                                select productReviews;
            foreach (var list in SelectRecords)
            {
                Console.WriteLine("ProductID:-" + list.ProductId + " " + "UserID:-" + list.UserId + " " + "Rating:-" + " " + list.Rating + " " + "Review:-" + list.Review + " " + "islike:-" + list.islike);
            }




            //                             (from productReviews in ListProductReview 
            //                             where productReviews.ProductId == 1 && productReviews.Rating > 3) ||
            //                             (productReviews.ProductId == 4 && productReviews.Rating>3) ||
            //                             (productReviews.ProductId ==9 && productReviews.Rating > 3)
            //                             select productReviews
        }

        public void RetriveCount(List<ProductReview> ListProductReview)
        {
            var RetriveCount = ListProductReview.GroupBy(x => x.ProductId).Select(x => new { ProductId = x.Key, Count = x.Count() });
            foreach (var list in RetriveCount)
            {
                Console.WriteLine(list.ProductId + " -----" + list.Count);
            }
        }
        
    }
}
