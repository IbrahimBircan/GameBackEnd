﻿using System;
using System.Collections.Generic;
using System.Text;

namespace GameBackEnd.Entities
{
    class Gamer
    {
        public int GamerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string NationalityId { get; set; }
        public DateTime DateOfBirth { get; set; }
    }
}
