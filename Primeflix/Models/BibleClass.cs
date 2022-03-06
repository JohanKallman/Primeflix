using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace Primeflix.Models
{
    public class BibleClass
    {
        public string Trosa { get; set; }
        public int siffra { get; set; }
        public int Id { get; set; }

        public BibleClass(int id)
        {
            Id = id;
        }
    }
}
