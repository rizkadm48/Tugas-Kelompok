﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Authentication
{
    public class Data
    {
        public string NamaDepan { get; set; }
        public string NamaBelakang { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }

        
        public Data(string namaDepan, string namaBelakang, string userName, string password)
        {
            
            this.NamaDepan = namaDepan;
            this.NamaBelakang = namaBelakang;
            this.UserName = userName;
            this.Password = password;
        }

        public void TampilkanData(List<Data> data)
        {

            Console.WriteLine();
            Console.WriteLine($"NAME : {this.NamaDepan} {this.NamaBelakang}");
            Console.WriteLine($"USERNAME : {this.UserName}");

            this.Password = BCrypt.Net.BCrypt.HashPassword(this.Password);
            Console.WriteLine($"PASSWORD : {this.Password}");

        }

    }
}
