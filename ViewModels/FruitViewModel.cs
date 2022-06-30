using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections;
using System.Diagnostics;

namespace CollectionViewTest1.ViewModels
{
    [QueryProperty(nameof(SelectedFruits), nameof(SelectedFruits))]

    public partial class FruitViewModel : ObservableObject
    {
        [ObservableProperty]
        public List<string> selectedFruits;

        public FruitViewModel()
        {
        }

        [RelayCommand]
        void FruitSelectionChanged(object fruitParams)
        {

            List<string> selectedFruitsFromParam = ((IEnumerable) fruitParams).Cast<string>().ToList();

            Debug.WriteLine("Count of selected fruits in parameter = " + selectedFruitsFromParam.Count.ToString());

            if (SelectedFruits is null)
            {
                Debug.WriteLine("bound property SelectedFruits is NULL");
            } else
            {
                Debug.WriteLine("Count of selected fruits in bound property = " + SelectedFruits.Count.ToString());
            }
        }

    }

}
