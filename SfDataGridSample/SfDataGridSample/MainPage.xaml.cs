using Syncfusion.Maui.DataGrid.DataPager;

namespace SfDataGridSample
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            dataPager.PageCount = 8;
            dataPager.PageSize = 12;
            dataPager.UseOnDemandPaging = true;
            dataPager.OnDemandLoading += DataPager_OnDemandLoading;
        }

        private void DataPager_OnDemandLoading(object? sender, OnDemandLoadingEventArgs e)
        {
            var pageData = viewModel.ArchivedMatches.Skip(e.StartIndex).Take(e.PageSize).ToList();
            matchesCollectionView.ItemsSource = pageData.AsEnumerable();
        }
    }
}
