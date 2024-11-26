using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using test_asp.net_mvc_4._8.Models;
using test_asp.net_mvc_4._8.ViewModel;

namespace test_asp.net_mvc_4._8.Controllers
{
    public class UtentiController : Controller
    {
        // GET: Utenti
        public ActionResult Index(bool? mostraNonAttivi)
        {
            var utenti = new List<Utenti>
            {
                new Utenti { Name = "Mario Rossi", Description = "Admin", isActiveUser = true, Matricola = 12345 },
                new Utenti { Name = "Luca Bianchi", Description = "Utente", isActiveUser = false, Matricola = 67890 },
                new Utenti { Name = "Giulia Verdi", Description = "Moderatore", isActiveUser = true, Matricola = 11223 },
            };

            // Filtra utenti se la checkbox non è selezionata
            if (mostraNonAttivi != true)
            {
                utenti = utenti.Where(u => u.isActiveUser).ToList();
            }

            var viewModel = new UtentiViewModel
            {
                Utenti = utenti,
                MostraNonAttivi = mostraNonAttivi ?? false
            };

            return View(viewModel);
        }
    }
}