# Übung 12: Bilder, Icons und Schriftarten

- Öffnen Sie die App `DontLetMeExpire` in Visual Studio.
- Kopieren Sie alle Ordner im Ordner `Beispieldateien\Resources` in den Ordner `Resources` Ihres Projekts. Überschreiben Sie die bestehenden Dateien.
- Registrieren Sie die neue Schriftart `MaterialSymbols-Rounded.ttf` in der Datei MauiProgram.cs
  - `fonts.AddFont("MaterialSymbols-Rounded.ttf", "MaterialSymbolsRounded");`
- Registrieren Sie das `ResourceDictionary` `MaterialSymbolsRounded.xaml` in der Datei `App.xaml`
- Fügen die Symbole in die Kacheln der `MainPage.xaml` ein, in dem Sie die `Image`-Elemente durch `Labels` mit der Icon-Schriftart `MaterialSymbolsRounded` und folgenden `Icons` ersetzen.
  - `IconHome_storage`
  - `IconUpdate`
  - `IconCalendar_today`
  - `IconError`
- Ersetzen Sie in der Datei `MainPage.xaml` das statische Bild in der Liste der Lagerorte durch ein `Icon`-Label, dessen Text an die Eigenschaft `Icon` gebunden wird.
- Ersetzen Sie in der Datei `ItemsPage.xaml` das statische Bild durch ein Bild, dass an die Eigenschaft `Image` gebunden ist. Ist der Wert von `Image` `null`, dann soll das Bild `no_image.png` angezeigt werden.
- Öffnen Sie die Projektdatei `DontLetMeExpire.csproj` im Texteditor. Ergänzen Sie bei den Einträgen `MauiIcon` und `MauiSplashScreen` die Eigenschaft `Color` mit folgendem Wert: `Color="#3d6dcc"`