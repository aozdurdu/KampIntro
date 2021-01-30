using System;
using System.Collections.Generic;
using System.Text;
using MernisServiceReference;


namespace GameCompany
{
    public class MernisServiceAdapter : IPlayerCheckManager
    {
        public bool CheckIfRealPerson(Player player)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient();
            return client.TCKimlikNoDogrulaAsync(customer.NationalID, customer.FirstName.ToUpper(), customer.LastName.ToUpper(), customer.BirthDate.Year);
        }
    }
}
