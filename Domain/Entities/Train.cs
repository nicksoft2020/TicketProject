﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Domain.Entities
{
    public class Train
    {
        [Key]
        [ForeignKey("Route")]
        public int Id { get; set; }
        public int Number { get; set; }
        public decimal Price { get; set; }

        public virtual Route Route { get; set; }
        public virtual ICollection<Vagon> Vagons { get; set; }

        public Train()
        {
            if(Vagons == null)
                Vagons = new List<Vagon>();
        }
    }
}
