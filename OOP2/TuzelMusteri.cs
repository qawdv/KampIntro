using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2
{
    //Coorporate
    //miras İnheritance
    class TuzelMusteri:Musteri  //özellik classı (varlıktır/entiti dir)
    { //müsteride olan herşey artık tüzel müşteridir 
        //müsteri=ebeveyn
        public string SirketAdi { get; set; }
        public string VergiNo { get; set; }


    }
}
