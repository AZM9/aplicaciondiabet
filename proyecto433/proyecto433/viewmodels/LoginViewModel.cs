


namespace proyecto433.viewModels
{
    using System.Windows.Input;
    public class LoginViewModel
    {
        private bool isRemembered;
        #region properties
        public string Email
        {
            get;
            set;
        }
        public string Password
        {
            get;
            set;
        }
        public bool IsRunning
        {
            get;
            set;
        }
        #endregion
        #region Constructors
        public LoginViewModel()
        {
            this.isRemembered = true;
        }
    }
}
        #endregion
        