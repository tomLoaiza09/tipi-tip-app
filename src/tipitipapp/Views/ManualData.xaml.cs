using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tipitipapp.ViewModels;

namespace tipitipapp.Views
{
    public partial class ManualData : ContentPage
    {
        private readonly ManualDataViewModel manualDataViewModel;

        public ManualData(ManualDataViewModel manualDataViewModel)
        {
            InitializeComponent();
            BindingContext = this.manualDataViewModel = manualDataViewModel;
        }
    }
}
