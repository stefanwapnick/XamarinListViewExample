using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListViewExample
{
    class TeamsViewModel : ViewModel
    {
        public ObservableCollection<Team> TeamList { get; private set; }

        private Team _selectedTeam;

        public EventHandler<Team> SelectedTeamChanged;
        
        public Team SelectedTeam
        {
            get { return _selectedTeam; }
            set
            {
                if (_selectedTeam == value)
                    return;

                _selectedTeam = value;
                OnPropertyChanged();
                OnSelectedTeamChanged(_selectedTeam);
            }
        }

        public TeamsViewModel(IEnumerable<Team> teamList)
        {
            TeamList = new ObservableCollection<Team>(teamList);
        }

        private void OnSelectedTeamChanged(Team selectedTeam)
        {
            var handler = SelectedTeamChanged;
            SelectedTeamChanged?.Invoke(this, selectedTeam);
        }

    }
}
