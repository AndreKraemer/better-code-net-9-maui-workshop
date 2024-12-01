# Übung 10: BindableLayouts

- Öffnen Sie die App `DontLetMeExpire` in Visual Studio.
- Legen Sie in Ihrem `MainViewModel` ein Feld vom Typ `IStorageLocationService` an und initialisieren Sie es im Konstruktor
- Legen Sie in Ihrem `MainViewModel` eine Eigenschaft vom Typ `IEnumerable<StorageLocationWithItemCount>` mit dem Namen `StorageLocations` an.
- Initialisieren Sie diese Liste über die Methode `GetWithItemCount` des `StorageLocationSerivce` in der Methode `InitializeAsync`
- Bearbeiten Sie die Datei `MainPage.xaml` und ersetzen Sie die statische Liste der Lagerorte durch ein `BindableLayout`, welches Sie an die Eigenschaft `StorageLocations` binden
- Initialisieren Sie in der Klasse `DummyStorageLocationService` im Konstruktor das Feld `_storageLocations` wie folgt: `_storageLocations = [.. DummyData.Locations];`
