using GameBackEnd.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameBackEnd.Abstracts
{
    interface IVerificationService
    {
        bool CheckIfRealPerson(Gamer gamer);
    }
}
