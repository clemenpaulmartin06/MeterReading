using MRS.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace MRS.ViewModels
{
    class ReadingListViewModel
    {
        public ObservableCollection<ReadingList> ReadingList { get; set; }

        private ReadingList _selectedReading { get; set; }
        public ReadingList SelectedReading
        {
            get { return _selectedReading; }
            set
            {
                if (_selectedReading != value)
                {
                    _selectedReading = value;

                }
            }
        }

        public ReadingListViewModel()
        {
            ReadingList = new ObservableCollection<ReadingList>
            {
                new ReadingList {  AccountId = "010101", Address="Sta. Rosa", Id=1, MeterId="A.R. 5000121", Name="Jeandee Mae V. Santos", Route="1", BackgroundColor = "#0288D1" },
                new ReadingList {  AccountId = "010102", Address="Sta. Rosa", Id=1, MeterId="A.R. 5000122", Name="Keu Llin", Route="2", BackgroundColor = "#E65100" },
                new ReadingList {  AccountId = "010103", Address="Sta. Rosa", Id=1, MeterId="A.R. 5000123", Name="Testing Only", Route="3", BackgroundColor = "#0288D1" }
            };
        }
    }
}
