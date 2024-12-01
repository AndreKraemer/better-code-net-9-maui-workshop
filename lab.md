# Übung 11: CollectionView

- Öffnen Sie die App `DontLetMeExpire` in Visual Studio.
- Legen Sie eine neue .NET MAUI ContentPage (XAML) mit dem Namen `ItemsPage.xaml` im Ordner `Views` an
- Legen Sie im Ordner `ViewModels` ein `ViewModel` mit dem Namen `ItemsViewModel` an.
- Lassen Sie die Klasse `ItemsViewModel`von `ViewModelBase` erben.
- Legen Sie im ItemsViewModel die  Eigenschaft `ObservableCollection<Item> Items` an.
- Injizieren Sie den `StorageLocationService` und den `ItemService` in Ihr ViewModel
- Erstellen Sie eine Methode `InitzializeAsync` und laden Sie dort alle Einträge über den `ItemService`
- Verbinden Sie `ItemsPage` und `ItemsViewModel` miteinander
- Stellen Sie die Einträge in der Datei `ItemsPage.xaml` über einen CollectionView gemäß des Screenshots dar.
- Registrieren Sie `ItemsPage` und `ItemsViewModel` in der Klasse `MauiProgram`
- Registrieren Sie eine Route zur `ItemsPage` in der Datei `AppShell.xaml.cs`
- Navigieren Sie von der Kachel **"Mein Vorrat"** der `MainPage` über einen `TapGestureRecognizer` zur Seite `ItemsPage`
- Bonus 1: Datumsanzeige optimieren
  - Kopieren Sie den Ordner `Converters` aus den Beispieldateien inklusive Inhalt in Ihr Projekt
  - Nutzen Sie den `DateToRelativeStringConverter` um statt eines konkreten Datums eine relative Zeiteingabe anzuzuzeigen, also zum Beispiel **letze Woche** statt **12.09.2024**
- Bonus 2: Navigieren Sie von den anderen Kacheln der `MainPage` (Läuft bald ab, Läuft heute ab, Abgelaufen) zur `ItemsPage` und laden Sie die entsprechenden Daten
- Bonus 3: Navigieren Sie von den Lagerorten der Seite `MainPage` zur `ItemsPage` und laden Sie nur die zum Lagerort passenden Daten.

![Liste der Vorräte](Images/lab_b.jpg)
