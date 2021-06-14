using GameBackEnd.Abstracts;
using GameBackEnd.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameBackEnd.Concretes
{
    class GamerManager : IGamerService
    {
        IVerificationService _verificationService;
        public GamerManager(IVerificationService verificationService) 
        {
            this._verificationService = verificationService;
        }
        public void Add(Gamer gamer)
        {
            if (_verificationService.CheckIfRealPerson(gamer))
            {
                Console.WriteLine(gamer.FirstName+" "+gamer.LastName+ " isim-soyisimli oyuncu sisteme eklendi");
            }
            else
            {
                Console.WriteLine("Oyuncu ekleneMedi! Bilgileri kontrol ediniz.");
            }
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine(gamer.FirstName+" "+gamer.LastName+" Oyuncu silindi");
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine(gamer.FirstName + " " + gamer.LastName + " Oyuncu güncellendi");
        }
    }
}
