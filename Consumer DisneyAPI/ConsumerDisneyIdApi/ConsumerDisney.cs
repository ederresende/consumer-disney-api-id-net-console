using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsumerDisneyIdApi
{
    public class ConsumerDisney
    {
         public Character? data { get; set; }
    }
    public class Character
    {
        public string? name { get; set; }

        public string? imageUrl { get; set; }
    }
}