using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookforMicron.Model
{
    public class Book
    {
        public int ID { get; set; }
        public string title { get; set; }
        public int author { get; set; }
        public int description { get; set; }
    }
}
