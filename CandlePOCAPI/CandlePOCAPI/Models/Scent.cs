using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CandlePOCAPI.Models
{
    public class Scent : BaseResource
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string PrimaryNote { get; set; }

        public string SecondaryNote { get; set; }

        public string BaseNote { get; set; }
    }
}
