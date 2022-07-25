using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace NestedUserControlTest
{
    public class MainViewModel : INotifyPropertyChanged
    {

        private string title = "Field text: ";
        private string fieldText = string.Empty;



        public string Title
        {
            get => title;
            set
            {
                title = value;
                OnPropertyChanged(nameof(Title));
            }
        }


        public string FieldText
        {
            get => fieldText;
            set
            {
                fieldText = value;
                OnPropertyChanged(nameof(FieldText));
            }
        }


        public ICommand ClearCommand { get; }


        public event PropertyChangedEventHandler? PropertyChanged;



        public MainViewModel()
        {
            ClearCommand = new RelayCommand(new Action<object>(ClearFields));
        }



        private void ClearFields(object obj)
        {
            //FieldText = string.Empty;
            FieldText = "test";
        }


        private void OnPropertyChanged(string name)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
