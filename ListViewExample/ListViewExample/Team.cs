using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListViewExample
{
    public class Team : ViewModel
    {
        private string _name;
        private int _upVotes;
        private int _downVotes;

        public string Name
        {
            get { return _name; }
            set
            {
                _name = value;
                OnPropertyChanged();
            }
        }

        public int UpVotes
        {
            get { return _upVotes; }
            set
            {
                _upVotes = value;
                OnPropertyChanged();
            }
        }

        public int DownVotes
        {
            get { return _downVotes; }
            set
            {
                _downVotes = value;
                OnPropertyChanged();
            }
        }

        public Team(string name, int upVotes, int downVotes)
        {
            _name = name;
            _upVotes = upVotes;
            _downVotes = downVotes;
        }

        public Team()
        { }

    }
}
