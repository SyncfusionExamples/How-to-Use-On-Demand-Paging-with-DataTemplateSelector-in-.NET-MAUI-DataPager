# How to Use On Demand Paging with DataTemplateSelector in .NET MAUI DataPager?
This demo shows how to implement on-demand paging with a DataTemplateSelector in [.NET MAUI DataPager](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataPager.SfDataPager.html).

By combining the SfDataPager's on-demand loading functionality with a DataTemplateSelector, you can efficiently load paged data and dynamically apply different templates based on the underlying data type or condition.

## Xaml
```
  <ContentPage.Resources>
      <DataTemplate x:Key="NineBallTemplate">
          <Border Margin="5" 
                  HeightRequest="80"
                  BackgroundColor="MistyRose">
              <VerticalStackLayout>How to Use On-Demand Paging with DataTemplateSelector in .NET MAUI DataPager
                  <Label FontAttributes="Bold"
                       Text="{Binding Name}" />
                  <Label Text="{Binding BreakShots, StringFormat='Break shots: {0}'}" />
              </VerticalStackLayout>
          </Border>
      </DataTemplate>

      <DataTemplate x:Key="OnePocketTemplate">
          <Border Margin="5"
                  HeightRequest="80"
                  BackgroundColor="LavenderBlush">
              <VerticalStackLayout>
                  <Label FontAttributes="Bold"
                       Text="{Binding Name}" />
                  <Label Text="{Binding Venue}" />
              </VerticalStackLayout>
          </Border>
      </DataTemplate>
  </ContentPage.Resources>

  <Grid RowDefinitions="*,Auto">
      <CollectionView x:Name="matchesCollectionView"
                      Grid.Row="0">
          <CollectionView.ItemTemplate>
              <selectors:MatchTemplateSelector NineBallTemplate="{StaticResource NineBallTemplate}"
                                               OnePocketTemplate="{StaticResource OnePocketTemplate}" />
          </CollectionView.ItemTemplate>
      </CollectionView>
      <syncPager:SfDataPager x:Name="dataPager"
                             Grid.Row="1"
                             Margin="7.5,17.5,7.5,8.5"
                             HorizontalOptions="Fill"
                             VerticalOptions="Center"
                             HeightRequest="36"
                             ButtonSize="36"
                             ButtonSpacing="8"
                             ButtonFontSize="14"
                             NumericButtonCount="8"/>
  </Grid>
```
## Xaml.cs
```
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

```
## Requirements to run the demo

To run the demo, refer to [System Requirements for .NET MAUI](https://help.syncfusion.com/maui/system-requirements)

## Troubleshooting:
### Path too long exception

If you are facing path too long exception when building this example project, close Visual Studio and rename the repository to short and build the project.

## License

Syncfusion has no liability for any damage or consequence that may arise from using or viewing the samples. The samples are for demonstrative purposes. If you choose to use or access the samples, you agree to not hold Syncfusion liable, in any form, for any damage related to use, for accessing, or viewing the samples. By accessing, viewing, or seeing the samples, you acknowledge and agree Syncfusion's samples will not allow you seek injunctive relief in any form for any claim related to the sample. If you do not agree to this, do not view, access, utilize, or otherwise do anything with Syncfusion's samples.