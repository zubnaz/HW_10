using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace _06_02_EntityFramework.Entities
{
    public class Flight
    {
        public int Number { get; set; }
        public DateTime ArrivelTime { get; set; }
        public DateTime DepartureTime { get; set; }
        public string ArrivelCity { get; set; }
        public string DepartureCity { get; set; }
        // ForeignKey namig: RelatedEntityName + RelatedEntityPrimaryKeyName
        public int AirplaneId { get; set; }//foreign key
        public int? CityId { get; set; }
        public City Cities { get; set; }

        //Navigation property
        public Airplane Airplane { get; set; }
        public ICollection<Client> Clients { get; set; }

    }
}
