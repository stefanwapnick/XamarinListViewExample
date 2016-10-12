using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace ListViewExample
{
    public partial class DetailsPage : ContentPage
    {
        public DetailsPage(Team selectedTeam)
        {
            BindingContext = selectedTeam;
            InitializeComponent();
        }
    }
}
