using System;
using System.Collections.Generic;
using System.Text;

namespace Odev5GameProject
{
    class UserValidationManager : IUserValirationService
    {
        
        public bool Validate(Gamer gamer)
        {
            if (gamer.BirthYear == 1994 && gamer.FirstName == "ERSİN"
                && gamer.LastName == "SULAR" && gamer.TcNo == 123145)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
