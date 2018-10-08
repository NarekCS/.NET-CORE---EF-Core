using AutoLotDAL_Core2.Models.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace AutoLotDAL_Core2.Models
{
    public partial class Order : EntityBase
    {
        public int CustomerId { get; set; }

        public int CarId { get; set; }

        [ForeignKey(nameof(CustomerId))]
        public Customer Customer { get; set; }

        [ForeignKey(nameof(CarId))]
        public Inventory Car { get; set; }
    }
}
