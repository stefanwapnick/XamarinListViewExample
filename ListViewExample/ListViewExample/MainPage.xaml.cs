using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace ListViewExample
{
    public partial class MainPage : ContentPage
    {
        private readonly TeamsViewModel _teamsViewModel;

        public MainPage()
        {
            _teamsViewModel = new TeamsViewModel(new List<Team>()
            {
                new Team("Team Griffins", 999, 0),
                new Team("Team Kraken", 6, 2),
                new Team("Team Panthers", 4, 1),
                new Team("Team Kthulu", 2, 0),
            });
            
            _teamsViewModel.SelectedTeamChanged += SelectedTeamChanged;

            BindingContext = _teamsViewModel;
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            _teamsViewModel.SelectedTeam = null;
        }

        private async void SelectedTeamChanged(object sender, Team selectedTeam)
        {
            if (selectedTeam == null)
                return;

            // Navigate to next screen
            await Navigation.PushAsync(new DetailsPage(selectedTeam));
        }

        private async void OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var selectedItem = e.SelectedItem as Team;
            if (selectedItem == null)
                return;

            await Navigation.PushAsync(new DetailsPage(selectedItem));
        }
    }
}
