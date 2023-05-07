using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ListViewExample
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListViewPage : ContentPage
    {
        public ObservableCollection<PhoneGroup> PhonesList { get; set; } = new ObservableCollection<PhoneGroup>();
        public ListViewPage()
        {
            InitializeComponent();

            PhonesList.Add(new PhoneGroup("Apple", new[]{ new Phone
                {
                    Title = "iPhone 6s",
                },
                new Phone
                {
                    Title = "iPhone 7",
                }}));

            PhonesList.Add(new PhoneGroup("Huawei", new[]{ new Phone
                {
                    Title = "Huawei P10",
                },
                new Phone
                {
                    Title = "Huawei Mate 8",
                }}));

            PhonesList.Add(new PhoneGroup("Samsung", new[]{ new Phone
                {
                    Title = "Galaxy S8",
                },
                new Phone
                {
                    Title = "Galaxy S7 Edge",
                }}));

            BindingContext = this;
        }
    }
}