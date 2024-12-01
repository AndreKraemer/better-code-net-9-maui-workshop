namespace DontLetMeExpire.Services;

public interface INavigationService
{
    Task GoToAsync(string location);
    Task GoToAsync(string location, bool animate);
    Task GoToAsync(string location, bool animate, IDictionary<string, object> parameters);
    Task GoToAsync(string location, IDictionary<string, object> parameters);
}
