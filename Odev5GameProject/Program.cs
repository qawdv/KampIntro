using System;

namespace Odev5GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            GamerMenegar gamerMenegar = new GamerMenegar(new UserValidationManager());
            gamerMenegar.Add(new Gamer
            {
                Id = 1,
                BirthYear = 1994,
                LastName = "SULAR",
                FirstName = "ERSİN",
                TcNo = 123145
            });
        }

               

    }
}
