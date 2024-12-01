# Übung 9: Navigation

- Öffnen Sie die App `DontLetMeExpire` in Visual Studio.
- Registrieren Sie eine Route für die `ItemPage` in der Datei `AppShell.xaml.cs`.
- Bearbeiten Sie die Methode `private async Task NavigateToAddItem` in der Klasse `MainViewModel` und navigieren Sie in der Methode über die `Shell` zur `ItemPage`.
- Rufen Sie das Command über den Button **Neuen Eintrag hinzufügen** per *Command-Binding* auf.
- Entfernen Sie in der Datei `AppShell.xaml` das Markup für den Menüeintrag `ItemPage`
- **Bonus:** Erstellen Sie ein Interface `INavigationService` und eine Klasse `NavigationService`, über die Sie die Navigation von der `Shell` abstrahieren. Die Klasse `NavigationService` wrapped dabei die `Shell`-Navigation
- **Bonus:** Registrieren Sie den `INavigationService` in der Klasse `MauiProgram` und injizieren sie ihn in die Klasse `MainViewModel`
