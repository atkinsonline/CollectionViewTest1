using CollectionViewTest1.ViewModels;

namespace CollectionViewTest1;

public partial class MainPage : ContentPage
{
	public MainPage(FruitViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}

}

