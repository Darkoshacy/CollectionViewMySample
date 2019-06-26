using CollectionViewMySample.ViewModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CollectionViewMySample.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class UserPage : ContentPage
    {
        BaseViewModel baseViewModel = new BaseViewModel();
        public UserPage()
        {
            InitializeComponent();
            BindingContext = baseViewModel;
        }
    }
}