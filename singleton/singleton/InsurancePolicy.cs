using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace singleton
{
    public class InsurancePolicy
    {
        private int Id { get; set; } = 123;
        private string Insured { get; set; } = "elliotrodriguez";

        public string GetInsuredName() => Insured;

        public static InsurancePolicy Instance { get; } = new InsurancePolicy();
    }
}
