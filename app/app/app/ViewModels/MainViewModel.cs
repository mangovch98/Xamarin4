using System;
using System.Collections.Generic;
using System.Text;

namespace Paises.ViewModels
{
    using app.ViewModels;
    using app.Models;

    class MainViewModel
    {
        #region Properties
        public TokenResponse Token
        {
            get; set;
        }

        #endregion

        #region ViewModels
        public PaisViewModel Login
        {
            get; set;
        }
        public PaisViewModel Lands
        {
            get; set;
        }
        #endregion

        #region Constructors
        public MainViewModel()
        {
            instance = this;
            this.Login = new PaisViewModel();

        }
        #endregion

        #region Singleton
        private static MainViewModel instance;
        public static MainViewModel GetInstance()
        {
            if (instance == null)
            {
                return new MainViewModel();

            }
            return instance;
        }

        #endregion
    }
}