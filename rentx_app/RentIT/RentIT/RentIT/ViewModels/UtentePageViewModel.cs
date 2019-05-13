﻿using RentIT.Models.User;
using RentIT.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace RentIT.ViewModels
{
    /**
     * Classe segnaposto, ancora da definire meglio
     */
    public class UtentePageViewModel : BaseViewModel<Utente>
    {
        Utente _utente;
        public Utente Utente
        {
            get { return _utente; }
            set
            {
                _utente = value;
                OnPropertyChanged();
            }
        }

        public UtentePageViewModel(INavService navService) : base(navService)
        {
        }

        public async override Task Init(Utente utente)
        {
            Utente = utente;
        }
    }
}