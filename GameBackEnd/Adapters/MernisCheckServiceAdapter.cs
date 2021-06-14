using GameBackEnd.Abstracts;
using GameBackEnd.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using MernisServiceReference;

namespace GameBackEnd.Adapters
{
    class MernisCheckServiceAdapter : IVerificationService
    {
        public bool CheckIfRealPerson(Gamer gamer)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);
            return client.TCKimlikNoDogrulaAsync(new TCKimlikNoDogrulaRequest(new TCKimlikNoDogrulaRequestBody(Convert.ToInt64(gamer.NationalityId), gamer.FirstName.ToUpper(), gamer.LastName.ToUpper(), gamer.DateOfBirth.Year))).Result.Body.TCKimlikNoDogrulaResult;

        }
    }
}
