# Übung 7: MVVM

- Öffnen Sie die App `DontLetMeExpire` in Visual Studio.
- Kopieren Sie aus den Beispieldateien den Ordner `Models` inklusive Inhalt in Ihr Projekt.
- Kopieren Sie aus den Beispieldateien den Ordner `ViewModels` inklusive Inhalt in Ihr Projekt.
- Kopieren Sie aus den Beispieldateien den Ordner `Services` inklusive Inhalt in Ihr Projekt.
- Legen Sie im Ordner `ViewModels` eine neue Klasse mit dem Namen `MainViewModel`an.
- Lassen Sie die Klasse `MainViewModel` von der Klasse `ViewModelBase`erben.
- Legen Sie in In der Klasse `MainViewModel` die folgenden vier Eigenschaften inklusive der zugehörigen privaten Felder an. Die Eigenschaften sollen bindbar sein und bei Änderung des Werts das Ereignis `PropertyChanged` auslösen. Nutzen Sie dazu die Methode `SetProperty` der Basisklasse `ViewModelBase`:
  - `StockCount`
  - `ExpiringSoonCount`
  - `ExpiresTodayCount`
  - `ExpiredCount`
- Erzeugen Sie das folgende Command (vorerst mit leerem Code): `NavigateToAddItemCommand`
- Erstellen Sie eine Methode `public async Task InitializeAsync()`. Laden Sie in dieser Methoden über den `DummyItemService` die Daten für die Eigenschaften
- Verbinden Sie `MainPage` und `MainViewModel`.
- Binden Sie in der Datei `MainPage.xaml` die neuen Eigenschaften des ViewModels an die Kacheln.
- Überschreiben Sie die Methode `OnNavigatedTo` der `MainPage` und rufen Sie in ihr die Methode `InitializeAsync` auf
