using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Text;

namespace Exercicio_Proposto.Entities
{
    class IndividualPayer : Payer
    {
        public double HealthExpenditures { get; set; }

        public IndividualPayer(string name, double anualIncome, double healthExpenditures) : base(name, anualIncome)
        {
            HealthExpenditures = healthExpenditures;
        }

        public override double TaxesPaid()
        {
            if (AnualIncome < 20000.0)
            {
                return AnualIncome * 0.15 - HealthExpenditures * 0.5;
            }
            else
            {
                return AnualIncome * 0.25 - HealthExpenditures * 0.5;
            }
        }
    }
}
