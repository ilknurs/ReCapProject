﻿using Core.Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOs
{
    public class RentalDetailDto: IDto 
    {
        public int RentalId { get; set; }
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public string FirstName { get; set; }
        public DateTime RentDate { get; set; }
        public DateTime? ReturnDate{ get; set; }
    }
}
