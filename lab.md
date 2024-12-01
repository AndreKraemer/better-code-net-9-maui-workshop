# Übung 13: Zugriff auf die Kamera

## Vorbereitende Arbeiten

- Öffnen Sie die App `DontLetMeExpire` in Visual Studio.
- Installieren Sie das Paket `CommunityToolkit.Maui` in Ihr Projet
- Kopieren Sie aus den **Beispieldaten (dieses Kapitels!)** aus dem Ordner `Beispieldateien\Views` die Dateien `ItemPage.xaml` und `ItemPage.xaml.cs` in den Ordner `Views` Ihres Projekts. **Überschreiben Sie die bestehenden Dateien!**
- Kopieren Sie aus den **Beispieldaten (dieses Kapitels!)** aus dem Ordner `Beispieldateien\ViewModels` die Datei `ItemViewModel` Ordner `ViewModels` Ihres Projekts.
- Registrieren Sie `ItemPage` und `ItemViewModel` in der Klasse `MauiProgram`
- Injizieren Sie den NavigationService in die bestehende Klasse `ItemsViewModel`
- Legen Sie in der Klasse `ItemsViewModel` eine neue Eigenschaft  `public Command<Item> NavigateToDetailsCommand { get; set; }` an
- Legen Sie die private Methode `private async Task NavigateToDetails(Item? item)` in der Klasse `ItemsViewModel` an und navigieren Sie darin zur `ItemPage`
- Legen Sie in der Datei `ItemsPage.xaml` einen `TapGestureRecognizer` an, in dem Sie das `Command` `NavigateToDetailsCommand aufrufen`
- Starten Sie die Anwendung und prüfen Sie, ob Sie aus der Liste der Einträge zu einem Eintrag navigieren können.

## Zugriff auf die Kamera
- Öffnen Sie die Datei Platforms\Android\AnrdoidManifest.xml und fügen Sie folgenden Code hinzu
```xml
	<uses-permission android:name="android.permission.CAMERA" />
	<queries>
		<intent>
			<action android:name="android.media.action.IMAGE_CAPTURE" />
		</intent>
	</queries>
```
- Öffnen Sie die Dateien Platforms\iOS\Info.plist und Platforms\MacCatalyst\info.plist und fügen Sie folgenden Code hinzu
```xml
	<key>NSCameraUsageDescription</key>
	<string>This app needs access to the camera to take photos and scan barcodes.</string>
	<key>NSPhotoLibraryAddUsageDescription</key>
	<string>This app needs access to the photo gallery for picking photos and videos.</string>
	<key>NSPhotoLibraryUsageDescription</key>
	<string>This app needs access to photos gallery for picking photos and videos.</string>
```
- Öffnen Sie die Klasse `ItemViewModel` und fügen Sie folgende beiden Commands hinzu
  - `public Command TakePhotoCommand { get; }`
  - `public Command DeletePhotoCommand { get; }`
- Fügen Sie für beide Commands jeweils eine private Methode hinzu (`async Task TakePhoto` und `void DeletePhoto`)
- Verbinden Sie die Commands mit den privaten Methoden
- Setzen Sie die Eigenschaft `Image` in der Methode `DeletePhoto` auf einen leeren String.
- Namen Sie in der Methode `TakePhoto` ein Foto über `MediaPicker.Default.CapturePhotoAsync()` auf.
- Speichern Sie das Foto im Cache-Verzeichnis und sezten Sie die Eigenschaft `Image` auf den Pfad des `Bildes`
- Verbinden Sie die beiden Commands per Databinding mit der View