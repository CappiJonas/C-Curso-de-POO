using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio_Proposto.Entities
{
    class CompanyPayer : Payer
    {
        public int NumberOfEmployees { get; set; }

        public CompanyPayer(string name, double anualIncome, int numberOfEmployees) : base(name, anualIncome)
        {
            NumberOfEmployees = numberOfEmployees;
        }

        public override double TaxesPaid()
        {
            if (NumberOfEmployees < 11)
            {
                return AnualIncome * 0.16;
            }
            else
            {
                return AnualIncome * 0.14;
            }
        }
    }
}
