# Übung 6: Eingabeformular

- Öffnen Sie die App `DontLetMeExpire` in Visual Studio.
- Erstellen Sie einen neuen Ordner `Views` im Projekt
- Erstellen Sie im Ordner `Views` eine neue **.NET MAUI ContentPage (XAML)** mit dem Namen `ItemPage.xaml` und registrieren Sie sie wie folgt in der der Datei `AppShell.xaml`: `<ShellContent Title="Item" ContentTemplate="{DataTemplate views:ItemPage}" Route="ItemPage" />`
- Registrieren Sie den XAML-Namespace views analog zum Namespace local in der Shell wie folgt: `xmlns:views="clr-namespace:DontLetMeExpire.Views"`
- Bauen Sie die Maske `ItemPage.xaml` analog zum Screenshot auf


![Skizze des gewünschten Layouts](Images/lab_b.jpg)