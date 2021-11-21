using ImdbClient.Models;
using System.Threading;
using System.Threading.Tasks;

namespace ImdbClient
{
    public interface IImdbClient
    {
        Task<SearchData> SearchAsync(string expression, CancellationToken cancellationToken = default);

        Task<TitleData> TitleAsync(string id, CancellationToken cancellationToken = default);

        Task<PosterData> PostersAsync(string id, CancellationToken cancellationToken = default);

        Task<WikipediaData> WikipediaAsync(string id, CancellationToken cancellationToken = default);
    }
}
