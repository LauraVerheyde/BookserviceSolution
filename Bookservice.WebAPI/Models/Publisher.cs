using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bookservice.WebAPI.Models
{
    public class Publisher
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Country { get; set; }

        public Publisher()
        {
            //leeg omdat als het niet leeg is, dan zou entity telkens verwachten dat er data moet inzitten
            //zeker parameterloze ctor in het leven roepen
        }
        

        //met deze constructor is het eenvoudiger om data in te voeren, niet telkens typen:
        // Id = 2, Name = "xxx", Country ="xxx"
        public Publisher(int id, string name, string country)
        {
            Id = id;
            Name = name;
            Country = country;
        }
        

    }
}
