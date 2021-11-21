using ImdbIntegration.Application.Dtos;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ImdbIntegration.Application.Services
{
    public interface IWatchListService
    {
        Task<IEnumerable<FilmDto>> GetByExpressionAsync(string expression);
        Task<IEnumerable<UserFilmDto>> GetUserWatchListByIdAsync(int userId);
        Task SetStatusAsync(WatchListItemDto watchListItem);
        Task AddToWatchListAsync(WatchListItemDto watchListItem);
    }
}
