using System;
using System.Collections.Generic;
using System.Text;

namespace Odev5GameProject
{
    class GamerMenegar : IGamerService
    {
        IUserValirationService _userValirationService;

        public GamerMenegar(IUserValirationService userValirationService)
        {
            _userValirationService = userValirationService;
        }

        public void Add(Gamer gamer)
        {
            if (_userValirationService.Validate(gamer)==true)
            {
                Console.WriteLine("Kayıt Yapıldı!");
            }
            else
            {
                Console.WriteLine("Kayıt Başarısız!");
            }
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine("Kayıt Silindi!");
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("Kayıt Güncellendi!");
        }
    }
}
