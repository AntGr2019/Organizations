using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Organizations.Models
{
    public class CompanyDbInitializer : CreateDatabaseIfNotExists<CompaniesContext>//DropCreateDatabaseAlways<CompaniesContext>
    {
        protected override void Seed(CompaniesContext context)
        {
            Founder s1 = new Founder { Id = 1, Name = "УчредительN1" };
            Founder s2 = new Founder { Id = 2, Name = "УчредительN2" };
            Founder s3 = new Founder { Id = 3, Name = "УчредительN3" };
            Founder s4 = new Founder { Id = 4, Name = "УчредительN4" };

            context.Founders.Add(s1);
            context.Founders.Add(s2);
            context.Founders.Add(s3);
            context.Founders.Add(s4);

            Company c1 = new Company
            {
                Id = 1,
                Name = "Российский алюминий",
                INN = "7709329253",
                Founders = new List<Founder>() { s1,s4}
            };
            Company c2 = new Company
            {
                Id = 2,
                Name = "УГМК",
                INN = "006606015817",
                Founders = new List<Founder>() { s2}
            };
            Company c3 = new Company
            {
                Id = 3,
                Name = "Интеко",
                INN = "7703010975",
                Founders = new List<Founder>() { s3}
            };

            context.Companies.Add(c1);
            context.Companies.Add(c2);
            context.Companies.Add(c3);
            base.Seed(context);
        }
    }
}