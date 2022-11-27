﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Logic.Models
{
    public class UserModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<int> Watchlist { get; set; }
    }
}
