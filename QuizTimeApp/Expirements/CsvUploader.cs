using Microsoft.AspNetCore.Antiforgery;
using QuizTimeApp.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Threading.Tasks;

namespace QuizTimeApp.Expirements
{
    public class CsvUploader
    {
        public void Data()
        {
            var data = File.ReadLines(@"~/../Data/MOCK_DATA.csv")
                .Select(line => line.Split(','))
                .Select(tokens => 
                new csvModelData {Id = tokens[0], 
                                       First_name = tokens[1], 
                                       Last_name = tokens[2], 
                                       Email = tokens[3], 
                                       Gender = tokens[4], 
                                       Country = tokens[5]}).ToList();
        }
    }
}

