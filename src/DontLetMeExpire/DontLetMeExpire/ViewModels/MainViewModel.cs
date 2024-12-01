using DontLetMeExpire.Models;
using DontLetMeExpire.Services;
using DontLetMeExpire.Views;
using System.Windows.Input;

namespace DontLetMeExpire.ViewModels;

public class MainViewModel : ViewModelBase
{
    private INavigationService _navigationService;
    private IStorageLocationService _storageLocationService;
    private IItemService _itemService;

    private int _stockCount;

    public int StockCount
    {
        get => _stockCount;
        set => SetProperty(ref _stockCount, value);
    }

    private int _expiresSoonCount;

    public int ExpiresSoonCount
    {
        get => _expiresSoonCount;
        set => SetProperty(ref _expiresSoonCount, value);
    }

    private int _expiresTodayCount;
    public int ExpiresTodayCount
    {
        get => _expiresTodayCount;
        set => SetProperty(ref _expiresTodayCount, value);
    }

    private int _expiredCount;


    public int ExpiredCount
    {
        get => _expiredCount;
        set => SetProperty(ref _expiredCount, value);
    }

    private IEnumerable<StorageLocationWithItemCount> _storageLocations;
    public IEnumerable<StorageLocationWithItemCount> StorageLocations 
    {
        get => _storageLocations; 
        private set => SetProperty(ref _storageLocations, value); 
    }

    public ICommand NavigateToAddItemCommand { get; }

    private async Task NavigateToAddItem()
    {
        await _navigationService.GoToAsync(nameof(ItemPage));
    }

    public MainViewModel(INavigationService navigationService, IItemService itemService, IStorageLocationService storageLocationService)
    {
        _navigationService = navigationService;
        _itemService = itemService;
        _storageLocationService = storageLocationService;
        NavigateToAddItemCommand = new Command(async () => await NavigateToAddItem());
    }

    public async Task InitializeAsync()
    {
        StockCount = (await _itemService.GetAsync()).Count();
        ExpiresSoonCount = (await _itemService.GetExpiresSoonAsync()).Count();
        ExpiresTodayCount = (await _itemService.GetExpiresTodayAsync()).Count();
        ExpiredCount = (await _itemService.GetExpiredAsync()).Count();
        StorageLocations = await _storageLocationService.GetWithItemCountAsync();
    }


}
