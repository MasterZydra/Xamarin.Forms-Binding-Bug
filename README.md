# Xamarin.Forms Binding Bug
Sample project to detect the cause of the binding problem on iOS.

When using a navigation page to encapsulate a content page, the last button is not working on iOS.  
On Android everything is running as expected.

When you click on an item in the list e.g. "third item". Click on "Button 2" no dialog will be shown even though a command is given.

Without the navigation page everything works fine. But for the actual app this navigation page is necessary so the navigation service is working.

[Navigation.PushAsync(...)](/BindingBug/BindingBug/Views/ItemsPage.xaml.cs)
