using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using test_asp.net_mvc_4._8.Models;

namespace test_asp.net_mvc_4._8.ViewModel
{
    public class UtentiViewModel
    {
        public List<Utenti> Utenti { get; set; }
        public bool MostraNonAttivi { get; set; }

    }
}