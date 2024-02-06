using System.Runtime.Serialization;

namespace Reflections
{
    
    public class Company 
    {
        public string id { get; set; }

        public string shortName { get; set; }

        public string inn { get; set; }

        public string kpp { get; set; }

        public string fullCompanyName { get; set; }

        public string regNum { get; set; }

        public string okato { get; set; }

        public string okopf { get; set; }

        public string okpo { get; set; }

        public string oktmo { get; set; }
        

        public Company Get() => new Company
        {
            id = "1",
            inn = "9701087101",
            kpp = "770101001",
            shortName = "RADUGACompany",
            fullCompanyName = "OOO RADUGA",
            regNum = "1177746937015",
            okato = "45293598000",
            okopf = "12300",
            okpo = "05056301",
            oktmo = "45910000000"
        };
      
    }
}
