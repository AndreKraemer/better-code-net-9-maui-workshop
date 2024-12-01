# Übung 8: Dependency Injection

- Öffnen Sie die App `DontLetMeExpire` in Visual Studio.
- Ändern Sie den Datentyp des Feldes `_itemService` in der Klasse `MainViewModel` von `DummyItemService` auf die Schnittstelle `IItemService`
- Löschen Sie die Initialisierung des Feldes `_itemService`und erstellen Sie stattdessen einen Konstruktorparameter `IItemService itemService` in der Klasse `MainViewModel`.
- Initialisieren Sie das Feld `_itemService` im Konstruktor der Klasse `MainViewModel` mit dem Parameter `itemService`
- Löschen Sie die Initialisierung des Feldes `_viewModel` in der Klasse `MainPage` und erstellen Sie stattdessen einen Konstruktorparameter `MainViewModel viewModel`.
- Initialisieren Sie das Feld `_viewModel` im Konstruktor der Klasse `MainPage` mit dem Parameter `viewModel`
- Registrieren Sie `MainViewModel`, `MainPage`, `IItemService` und `IStorageLocationService` in der Klasse `MauiProgram`

