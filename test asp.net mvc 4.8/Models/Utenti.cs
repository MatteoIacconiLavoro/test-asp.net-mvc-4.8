using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace test_asp.net_mvc_4._8.Models
{
    public class Utenti
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public bool isActiveUser { get; set; }
        public int Matricola { get; set; }
    }
}