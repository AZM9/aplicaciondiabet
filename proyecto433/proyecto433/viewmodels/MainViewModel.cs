namespace proyecto433.viewmodels
{
    public class MainViewModel
    {
        #region ViewModels
        public LoginViewModel login
        {
            get;
            set;
        }
        #endregion
        #region Constructors
        public MainViewModel()
        {

            this.login = new LoginViewModel();
        }
        #endregion
    }
}