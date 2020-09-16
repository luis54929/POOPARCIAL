using System;
namespace UsuariosC.usuarios{
    public class Usuarios
    {
        
        #region Properties

        
        protected string userName;
        protected string password;

        #endregion Properties

        #region Methods
        public string GetuserName()
        {
            return userName;
        }
        public void SetuserName(string value)
        {
            userName = value;
        }

        public string Getpassword()
        {
            return password;
        }

        public void Setpassword(string value)
        {
            password = value;
        }
        #endregion Methods
    }

}