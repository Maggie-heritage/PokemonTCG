using System;
using System.ComponentModel.DataAnnotations;

namespace Trade.Models
{
    public class Offer
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string member { get; set; }

        public string type { get; set; }

        [DataType(DataType.Date)]
        public DateTime PostDate { get; set; }
        public string Type { get; set; }
    }
}





