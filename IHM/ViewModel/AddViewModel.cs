
using System.Windows.Input;

namespace IHM.ViewModel
{
    public class AddViewModel : ObservableObject, IPageViewModel
    {
        #region Fields

        private int _filmId;
        private IHM.Model.FilmModel _currentFilm;
      //  private ICommand _getAllFilm;

        #endregion

        #region Properties/Commands

        public string Name
        {
            get { return "Films"; }
        }

        public int FilmtId
        {
            get { return _filmId; }
            set
            {
                if (value != _filmId)
                {
                    _filmId = value;
                    OnPropertyChanged("FilmId");
                }
            }
        }

        public IHM.Model.FilmModel CurrentProduct
        {
            get { return _currentFilm; }
            set
            {
                if (value != _currentFilm)
                {
                    _currentFilm = value;
                    OnPropertyChanged("CurrentFilm");
                }
            }
        }

        //public ICommand GetFilm
        //{
        //  
        //}

        //public ICommand SaveFilm
        //{
           
        //}

        #endregion
    }
}