using GameBackEnd.Abstracts;
using GameBackEnd.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameBackEnd.Concretes
{
    class VerificationFakeManager : IVerificationService
    {
        public bool CheckIfRealPerson(Gamer gamer)
        {
            if (gamer.NationalityId.Length == 11)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
