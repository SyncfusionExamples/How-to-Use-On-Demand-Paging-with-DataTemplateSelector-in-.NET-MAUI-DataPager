using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace SfDataGridSample
{
    public class MainPageViewModel
    {
        public ObservableCollection<BaseViewMatch> ArchivedMatches { get; set; }

        public MainPageViewModel()
        {
            ArchivedMatches = new ObservableCollection<BaseViewMatch>();

            for (int i = 1; i <= 100; i++)
            {
                ArchivedMatches.Add(new NineBallViewMatch
                {
                    Name = $"Nine Ball Match {i}",
                    BreakShots = i % 7 + 1
                });

                ArchivedMatches.Add(new OnePocketViewMatch
                {
                    Name = $"One Pocket Match {i}",
                    Venue = $"Table {i % 4 + 1}"
                });
            }
        }
    }
}
