﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.DTO
{
    public class PersonDto
    {
        public int Id { get; set; }
        public string First_name { get; set; }
        public string Last_name { get; set; }
        public String Phone { get; set; }
        public string Email { get; set; }
        public string Adress { get; set; }
        public bool State { get; set; }
    }
}
