# Übung 3: Implementieren Sie das Grundlayout

- Öffnen Sie ihr Projekt `DontLetMeExpire`
- Löschen Sie den Inhalt der Datei `MainPage.xaml`, so dass nur noch foglender Code vorhanden ist
```xml
<?xml version="1.0" encoding="utf-8" ?>
<ContentPage xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
             xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
             x:Class="DontLetMeExpire.MainPage">

</ContentPage>
```
- Löschen Sie im CodeBehind die Variable `count` und die Methode `OnCounterClicked`, so dass nur noch folgender Code vorhanden ist:
```csharp
namespace DontLetMeExpire
{
  public partial class MainPage : ContentPage
  {
    public MainPage()
    {
      InitializeComponent();
    }
  }
}
```
- Legen Sie das gezeigte Layout in der MainPage an. Nutzen Sie nur LayoutContainer, `BoxView`-Elemente, `Labels` und `Buttons`

![Skizze des gewünschten Layouts](Images/lab_b.jpg)
