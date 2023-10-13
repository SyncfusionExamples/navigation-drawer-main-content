# Xamarin Navigation Drawer (SfNavigationDrawer)

Essential NavigationDrawer for Xamarin.Forms is a simpler component to create navigation pane in application. It has a content area and a sliding pane that slides out from the edge of the page. The pane can be opened by swiping the edges of the screen or programmatically.

For know more details about NavigationDrawer: https://www.syncfusion.com/xamarin-ui-controls/xamarin-navigation-drawer

NavigationDrawer user guide documentation: https://help.syncfusion.com/xamarin/navigation-drawer/getting-started
# Adding SfNavigationDrawer reference
You can add SfNavigationDrawer reference using one of the following methods:

## Method 1: Adding SfNavigationDrawer reference from nuget.org

Syncfusion Xamarin components are available in nuget.org. To add SfNavigationDrawer to your project, open the NuGet package manager in Visual Studio, search for Syncfusion.Xamarin.SfNavigationDrawer, and then install it.

## Method 2: Adding SfNavigationDrawer reference from toolbox

Syncfusion also provides Xamarin Toolbox. Using this toolbox, you can drag the SfNavigationDrawer control to the XAML page. It will automatically install the required NuGet packages and add the namespace to the page. To install Syncfusion Xamarin Toolbox, refer to Toolbox.

## Method 3: Adding SfNavigationDrawer assemblies manually from the installed location

If you prefer to manually reference the assemblies instead referencing from NuGet, add the following assemblies in respective projects.

Location: {Installed location}/{version}/Xamarin/lib

# Initialize SfNavigationDrawer
Import the SfNavigationDrawer namespace in respective Page as shown below:

**[XAML]**

```
<xmlns:navigationdrawer="clr-namespace:Syncfusion.SfNavigationDrawer.XForms;assembly=Syncfusion.SfNavigationDrawer.XForms"/>
```

**[C#]**

```
using Syncfusion.SfNavigationDrawer.XForms;
```

Then initialize an empty navigation drawer as shown below,

**[XAML]**

```
 <navigationdrawer:SfNavigationDrawer x:Name="navigationDrawer">
        <navigationdrawer:SfNavigationDrawer.ContentView>
            <Grid/>
        </navigationdrawer:SfNavigationDrawer.ContentView>
 </navigationdrawer:SfNavigationDrawer>
```

**[C#]**

```
public MainPage()
{
    InitializeComponent();
    SfNavigationDrawer navigationDrawer = new SfNavigationDrawer();
    Grid grid = new Grid();
    navigationDrawer.ContentView = grid;
    this.Content = navigationDrawer
}
```
# Setting Main Content in Xamarin Navigation Drawer 

Main content of NavigationDrawer is always visible and it can be set using ContentView property. In the following code example, ContentView is switched when selection changes in ListView.

**[XAML]**

```
<navigationdrawer:SfNavigationDrawer x:Name="navigationDrawer" DrawerHeaderHeight="160">
        <navigationdrawer:SfNavigationDrawer.ContentView>
            <Grid x:Name="mainContentView" BackgroundColor="White">
                <Grid.RowDefinitions>
                    <RowDefinition Height="auto"/>
                    <RowDefinition/>
                </Grid.RowDefinitions>
                <StackLayout BackgroundColor="#1aa1d6" Orientation="Horizontal">
                    <Button x:Name="hamburgerButton" HeightRequest="50" WidthRequest="50" HorizontalOptions="Start" FontSize="20" BackgroundColor="#1aa1d6" Clicked="hamburgerButton_Clicked"/>
                    <Label x:Name="headerLabel" HeightRequest="50" HorizontalTextAlignment="Center" VerticalTextAlignment="Center" Text="Home" FontSize="16" TextColor="White" BackgroundColor="#1aa1d6"/>
                </StackLayout>
                <Label Grid.Row="1" x:Name="contentLabel" VerticalOptions="Center" HorizontalOptions="Center" Text="The folder is empty" FontSize="14" TextColor="Black"/>
            </Grid>
        </navigationdrawer:SfNavigationDrawer.ContentView>
        <navigationdrawer:SfNavigationDrawer.DrawerHeaderView>
            <Grid BackgroundColor="#1aa1d6">
                <Grid.RowDefinitions>
                    <RowDefinition Height="120"/>
                    <RowDefinition Height="40"/>
                </Grid.RowDefinitions>
                <Image Source="tab_feed.png" HeightRequest="110" Margin="0,10,0,0" BackgroundColor="#1aa1d6" VerticalOptions="Center" HorizontalOptions="Center"/>
                <Label Text="James Pollock" Grid.Row="1" HorizontalTextAlignment="Center" HorizontalOptions="Center" FontSize="20" TextColor="White"/>
            </Grid>
        </navigationdrawer:SfNavigationDrawer.DrawerHeaderView>
        <navigationdrawer:SfNavigationDrawer.DrawerContentView>
            <ListView x:Name="listView" ItemSelected="listView_ItemSelected">
                <ListView.ItemTemplate>
                    <DataTemplate>
                        <ViewCell>
                            <StackLayout HeightRequest="40">
                                <Label Margin="10,7,0,0" Text="{Binding}" FontSize="16"/>
                            </StackLayout>
                        </ViewCell>
                    </DataTemplate>
                </ListView.ItemTemplate>
            </ListView>
        </navigationdrawer:SfNavigationDrawer.DrawerContentView>
    </navigationdrawer:SfNavigationDrawer>
```
## How to run this application?

To run this application, you need to first clone the navigation-drawer-main-content repository and then open it in Visual Studio 2022. Now, simply build and run your project to view the output.

## <a name="troubleshooting"></a>Troubleshooting ##
### Path too long exception
If you are facing path too long exception when building this example project, close Visual Studio and rename the repository to short and build the project.

## License

Syncfusion has no liability for any damage or consequence that may arise by using or viewing the samples. The samples are for demonstrative purposes, and if you choose to use or access the samples, you agree to not hold Syncfusion liable, in any form, for any damage that is related to use, for accessing, or viewing the samples. By accessing, viewing, or seeing the samples, you acknowledge and agree Syncfusion’s samples will not allow you seek injunctive relief in any form for any claim related to the sample. If you do not agree to this, do not view, access, utilize, or otherwise do anything with Syncfusion’s samples.