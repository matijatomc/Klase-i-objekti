using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tomcMatijaKlaseIObjekti1
{
    class Stablo : Biljka
    {
        bool opadajuListovi;
        public bool OpadajuListovi { get => opadajuListovi; set => opadajuListovi = value; }

        Stablo(bool OpadajuLostovi)
        {
            this.opadajuListovi = OpadajuLostovi;
        }
    }
}
