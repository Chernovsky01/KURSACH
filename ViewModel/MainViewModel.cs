namespace ViewModels
{
    public class MainViewModel : BaseViewModel
    {
        #region WindowTitle

        private string _windowTitle = "KURSACH";
		public string WindowTitle
		{
			get => _windowTitle;
			set => Set(ref _windowTitle, value);
		}

        #endregion


    }
}
