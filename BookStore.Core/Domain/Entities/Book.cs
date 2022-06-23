using System;
using System.Collections.Generic;
using System.Text;

namespace BookStore.Core.Domain.Entities
{
    public class Book
    {
        public string Id { get; set; } = Guid.NewGuid().ToString();
        public string ISBN { get; set; }
        public string Title { get; set; }
        public string Publisher { get; set; }
        public DateTime OriginallyPurchasedOn { get; set; }
        public double OriginalPrice { get; set; }
        public double AskingPrice { get; set; }
        public int Edition { get; set; }
        public string PaperType { get; set; }
        public string Authors { get; set; }
        public string Genres { get; set; }
        public string OtherDetails { get; set; }
        //sellarid
    }
}
