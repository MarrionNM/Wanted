using System.Collections.ObjectModel;
using System.Threading.Tasks;

namespace Wanted.Services
{
    public interface SDataStore<T>
    {
        Task<bool> AddSuspectAsync(T suspect);
        Task<T> GetSuspectAsync(string id);
        Task<ObservableCollection<T>> GetSuspectsAsync(bool forceRefresh = false);
        Task<bool> UpdateSuspectAsync(T suspect);
        Task<bool> DeletesuspectAsync(string id);
    }
}
