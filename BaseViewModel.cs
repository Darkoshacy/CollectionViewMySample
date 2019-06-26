using CollectionViewMySample.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace CollectionViewMySample.ViewModel
{

    public class BaseViewModel : INotifyPropertyChanged
    {
        private string _firstName;
        private string _lastName;
        private int _userIndex = 0;
        private User _activeUser;
        private List<User> _userList = new List<User>();

        public ICommand SelectionChangedCommand => new Command(Swipe);

        public BaseViewModel()
        {
            UserList = new List<User>()
            {
             new User{Id=1, UserFirstName="Darko", UserLastName="Darkic", Color="Blue" } ,
             new User{Id=2, UserFirstName="Marko", UserLastName="Markic", Color="Red"  },
             new User{Id=3, UserFirstName="Alexander", UserLastName="Peric", Color="Yellow" },
             new User{Id=4, UserFirstName="John", UserLastName="Stark", Color="White" }
            };

            ActiveUser = UserList[3]; // TODO: ScrollTo ActiveUser
        }

        public void Swipe ()
        {
            //Set ActiveUser to SelectedItem
        }
        public int Id { get; set; }

        public string Color { get; private set; }

        public string UserFirstName {get;set;}

        public string UserLastName {get;set;}

        public List<User> UserList
        {
            get
            {
                return _userList;
            }
            set
            {
                _userList = value;
                OnPropertyChanged();
            }
        }

        public User ActiveUser
        {
            get
            {
                return _activeUser;
            }
            set
            {
                _activeUser = value;
                UserFirstName = value.UserFirstName;
                UserLastName = value.UserLastName;
                Id = value.Id;
                Color = value.Color;
                OnPropertyChanged();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string name = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
