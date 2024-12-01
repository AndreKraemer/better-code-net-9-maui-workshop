# Übung 14: Aufruf von Webservices

- Öffnen Sie die App `DontLetMeExpire` in Visual Studio.
- Kopieren Sie aus den den **Beispieldateien** dieses Workshops den Ordner `OpenFoodFacts` inklusive Inhalt in Ihr Projekt
- Registrieren Sie die Klasse `OpenFoodFactsApiClient` für die Schnittstelle `IOpenFoodFactsApiClient` in der Klasse `MauiProgram`
- Injizieren Sie den `OpenFoodFactsApiClient` in den Konstruktor der Klasse `ItemViewModel` und speichern Sie das Objekt in einer Member-Variable der Klasse.
- Legen Sie eine neue Eigenschaft `public string SearchText` in der Klasse `ItemViewModel`an
- Legen Sie ein neues Command  `public Command SearchBarcodeCommand` in der Klasse `ItemViewModel`an
- Legen Sie eine neue Methode `private async Task SearchBarcode()` an und verbinden Sie sie mit dem Command `SearchBarcodeCommand`
- Suchen Sie innerhalb der Methode über den `OpenFoodFactsApiClient` nach dem in `SearchText` enthaltenen Barcode. Wurde ein Produkt gefunden, dann
  - Zeigen Sie den Produktnamen in der Bildschirmmaske an
  - Prüfen Sie, ob ein Bild vorhanden ist
  - Falls ja, dann laden Sie das Bild herunter und zeigen Sie es an
- Fügen Sie der View `ItemPage.xaml` eine `SearchBar` hinzu, die Sie an die Eigenschaft `SearchText` binden
- Fügen Sie der View `ItemPage.xaml` einen `Button` hinzu, den Sie an das Command `SearchBarcodeCommand` binden
