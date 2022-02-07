using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BirthdayApp.Models
{
    public static class Veritabani
    {
        private static Dictionary<string, Davetiye> _liste = new Dictionary<string, Davetiye>();

        static Veritabani()
        {
            _liste.Add("Emre", new Davetiye
            {
                Ad = "Emre",
                Eposta = "etomruk39@gmail.com",
                KatilmaDurumu = true
            });
            _liste.Add("Ahmet", new Davetiye
            {
                Ad = "Ahmet",
                Eposta = "Ahmet@gmail.com",
                KatilmaDurumu = false,
            }); _liste.Add("Ayşe", new Davetiye
            {
                Ad = "Ayşe",
                Eposta = "Ayşe@gmail.com",
                KatilmaDurumu = true
            });
        }
        public static void Add(Davetiye model)
        {
            string key = model.Ad.ToLower();

            if (_liste.ContainsKey(key))
                _liste[key] = model;
            else
                _liste.Add(key, model);
        }

        public static IEnumerable<Davetiye> Liste
        {
            get { return _liste.Values; }
        }
    }
}