﻿using System;
using System.Collections.Generic;
using System.Text;

namespace RentIT.Models.User
{
    public class Utente
    {
        // tutti i campi effettivi di una classe Utente , da decidere bene quali sono 
        public string Name { get; set; }
        private string Surname { get; set; }
        private string Email { get; set; }
        private string Password { get; set; }
        private string NumeroTel;
        private string Address;
        public string Img { get; set; }
        

        /*public Boolean isBlankfield()
        {
            return this.name == null || 
                this.surname == null || 
                this.email == null || 
                this.password == null;
        }*/
     }
}