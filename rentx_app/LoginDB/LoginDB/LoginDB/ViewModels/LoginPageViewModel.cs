﻿using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace LoginDB.Views
{
    // TODO: Notare come gli aspetti quali colore, e qualunque cosa sia di tipologia
    // visuale andrebbero spostati in un dizionario della view, riferirsi a Carlo
    public class LoginPageViewModel : INotifyPropertyChanged
    {
        /* Vars */
        private string _password;
        private string _email;
        // Should be in the view
        private string _title = "Rent[IT]";
        // Should be in the view
        private string _mailPlaceholder = "Mail";
        // Should be in the view
        private string _pwdPlaceholder = "Password";
        // Should be in the view
        private string _textColor = "White";
        private string _errorMessageColor = "Red";
        private bool _isPwdTextPassword = true;
        // Should be in the view
        private string _loginButtonText = "LOG IN";
        private string _userMessage;
        private bool _isUsrMsgVisible = false;
        // Should be in the view
        private string _loginButtonBackgroundColor = "#CDDC39";

        /* Constructor */
        public LoginPageViewModel()
        {
        }

        /* (Get/Set)ters */
        public string Title { get { return _title; } }

        public string MailPlaceholder { get { return _mailPlaceholder; } }

        public string PwdPlaceholder { get { return _pwdPlaceholder; } }

        public string TextColor { get { return _textColor; } }

        public string ErrorMessageColor { get { return _errorMessageColor; } }

        public bool IsPwdTextPassword
        {
            get { return _isPwdTextPassword; }
            // TODO: Feature che mostra la password momentaneamente (isPassword = false)
            // per questo c'è il setter
            set { _isPwdTextPassword = value; }
        }

        // TODO: Questo è un messaggio che viene usato solo in caso di errore, con 
        // testo presentato in base alla situazione, progettarlo meglio
        public string UserMessage
        {
            get { return _userMessage; }
            set
            {
                _userMessage = value;
            }
        }

        // TODO: Questo valore deve diventare true nel caso si verifichino degli
        // errori, progettare l'interfaccia di segnalazione errori
        public bool IsUsrMsgVisible
        {
            get { return IsUsrMsgVisible; }
            set
            {
                _isUsrMsgVisible = value;
            }
        }

        public string LoginButtonText { get { return _loginButtonText; } }

        public string LoginButtonBackgroundColor { get { return _loginButtonText; } }

        /* MISCELLANEOUS */
        //TODO: Implement propertyChange methods 
        //NB: This isn't really needed since we can use 
        // ***'RaisePropertyChanged(() => Value)'***
        public event PropertyChangedEventHandler PropertyChanged;

        
        void OnPropertyChanged([CallerMemberName] string name = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}