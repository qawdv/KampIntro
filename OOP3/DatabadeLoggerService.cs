﻿using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class DatabadeLoggerService : ILoggerService
    {
        public void Log()
        {
            Console.WriteLine("Veritabanına Loglandı");
        }
    }
}
