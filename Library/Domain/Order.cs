using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Order : BaseModel
    {
        public DateTime Date { get; }
        public List<BookOrdered> BooksOrderList { get; }

        public Order()
        {
            Date = DateTime.Now;
            BooksOrderList = new List<BookOrdered>();
        }
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine($"Order: {this.Date.ToLocalTime()}");
            foreach (var item in BooksOrderList)
            {
                sb.AppendLine($"Book: {item.BookId} Count: {item.NumberOrdered}");
            }
            return sb.ToString();
        }
    }
}
