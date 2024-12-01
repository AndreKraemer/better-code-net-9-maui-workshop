using DontLetMeExpire.Models;
using DontLetMeExpire.OpenFoodFacts;
using DontLetMeExpire.Services;
using System.Collections.ObjectModel;

namespace DontLetMeExpire.ViewModels;

public class ItemViewModel : ViewModelBase
{
    private string _name;
    private DateTime _expirationDate;
    private StorageLocation _location;
    private decimal _amount;
    private string _id;
    private string _image;
    private string _title;
    private readonly IItemService _itemService;
    private readonly IOpenFoodFactsApiClient _openFoodFactsApiClient;
    private readonly INavigationService _navigationService;
    private readonly IStorageLocationService _storageLocationService;


    public ItemViewModel(INavigationService navigationService,
                          IStorageLocationService storageLocationService,
                          IItemService itemService,
                          IOpenFoodFactsApiClient openFoodFactsApi)
    {
        SaveCommand = new Command(async () => await SaveAsync());
        DeletePhotoCommand = new Command(DeletePhoto);
        TakePhotoCommand = new Command(async () => await TakePhoto());
        SearchBarcodeCommand = new Command(async () => await SearchBarcode());
        _navigationService = navigationService;
        _storageLocationService = storageLocationService;
        _itemService = itemService;
        _openFoodFactsApiClient = openFoodFactsApi;
    }

    public ObservableCollection<StorageLocation> StorageLocations { get; set; } = [];

    public Command SaveCommand { get; private set; }

    public Command TakePhotoCommand { get; private set; }
    public Command DeletePhotoCommand { get; private set; }


    private void DeletePhoto()
    {
        Image = string.Empty;
    }
    private async Task TakePhoto()
    {
        if (MediaPicker.Default.IsCaptureSupported)
        {
            var photo = await MediaPicker.Default.CapturePhotoAsync();
            if (photo != null)
            {
                var localFilePath = Path.Combine(FileSystem.CacheDirectory, photo.FileName);
                await using var sourceStream = await photo.OpenReadAsync();
                await using var destinationStream = File.OpenWrite(localFilePath);
                await sourceStream.CopyToAsync(destinationStream);
                Image = localFilePath;
            }
        }
    }

    public Command SearchBarcodeCommand { get; private set; }
    private string _searchText;
    public string SearchText
    {
        get => _searchText;
        set => SetProperty(ref _searchText, value);
    }


    private async Task SearchBarcode()
    {
        var response = await _openFoodFactsApiClient.GetProductByCodeAsync(SearchText);
        if (response is { Status: 1, Product: not null })
        {
            Name = response.Product.ProductName!;
            if (!string.IsNullOrEmpty(response.Product.ImageUrl))
            {
                var fileName = $"{response.Code}.jpg";
                var localFilePath = Path.Combine(FileSystem.CacheDirectory, fileName);
                // Prüfen , ob das Bild bereits heruntergeladen wurde
                if (!File.Exists(localFilePath))
                {
                    // Bild herunterladen
                    var imageStream = await _openFoodFactsApiClient.DownloadImage(response.Product.ImageUrl);
                    await File.WriteAllBytesAsync(localFilePath, imageStream);
                }
                Image = localFilePath;
            }
        }
    }

    public string Title
    {
        get => _title;
        set => SetProperty(ref _title, value);
    }

    public string Id
    {
        get => _id;
        set => SetProperty(ref _id, value);
    }

    public string Name
    {
        get => _name;
        set => SetProperty(ref _name, value, SaveCommand.ChangeCanExecute);
    }

    public DateTime ExpirationDate
    {
        get => _expirationDate;
        set => SetProperty(ref _expirationDate, value);
    }

    public StorageLocation SelectedLocation
    {
        get => _location;
        set => SetProperty(ref _location, value);
    }

    public decimal Amount
    {
        get => _amount;
        set => SetProperty(ref _amount, value, SaveCommand.ChangeCanExecute);
    }

    public string Image
    {
        get => _image;
        set => SetProperty(ref _image, value);
    }

    public async Task InitializeAsync(string? itemId = null)
    {
        // Speicherorte laden
        var locations = await _storageLocationService.GetAsync();

        // Die Liste der Speicherorte aktualisieren
        StorageLocations.Clear();
        foreach (var location in locations)
        {
            StorageLocations.Add(location);
        }
        if (!string.IsNullOrEmpty(itemId))
        {
            var item = await _itemService.GetByIdAsync(itemId);
            if (item != null)
            {
                Id = item.Id;
                Name = item.Name;
                ExpirationDate = item.ExpirationDate;
                SelectedLocation = StorageLocations.FirstOrDefault(x => x.Id == item.StorageLocationId);
                Image = item.Image;
                Amount = item.Amount;
                Title = item.Name;
            }

        }
        else
        {
            Id = string.Empty;
            Name = string.Empty;
            ExpirationDate = DateTime.Today;
            SelectedLocation = StorageLocations.First();
            Image = string.Empty;
            Amount = 1;
            Title = "Neuer Eintrag";
        }
    }

    private async Task SaveAsync()
    {

        // Neues Element mit den
        // Daten des ViewModels erstellen
        var item = new Item
        {
            Id = Id,
            Name = Name,
            ExpirationDate = ExpirationDate,
            StorageLocationId = SelectedLocation.Id,
            Amount = Amount,
            Image = Image
        };

        // Element speichern
        await _itemService.SaveAsync(item);

        // Daten für die Anzeige zurücksetzen
        Name = string.Empty;
        ExpirationDate = DateTime.Today;
        Amount = 0;
        SelectedLocation = StorageLocations.First();

        await _navigationService.GoToAsync("..");
    }

    private bool CanSave()
    {
        return !string.IsNullOrEmpty(Name)
          && Amount > 0;
    }
}
