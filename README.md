# CollectionViewTest1
Multiselection for a CollectionView, the bound property for SelectedItems is always null

Buils and run CollectionViewTest1 as a Windows app. I see the same problem in Android.
You will see a collection view with a list of fruits
Select 1 or more fruits and the output console will show (eg)

Count of selected fruits in parameter = 1
bound property SelectedFruits is NULL

or set a breakpoint in FruitViewModel FruitSelectionChanged to see where these messages come from.
The problem is that SelectedFruits is null

I have seen this in windows and Android but have not tried other platforms.
