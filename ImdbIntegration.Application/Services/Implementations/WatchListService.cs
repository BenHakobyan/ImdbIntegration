using ImdbClient;
using ImdbIntegration.Application.Dtos;
using ImdbIntegration.Domain.Interfaces;
using ImdbIntegration.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImdbIntegration.Application.Services
{
    internal class WatchListService : IWatchListService
    {
        private readonly IImdbClient imdbClient;
        private readonly IUnitOfWork unitOfWork;
        private readonly IRepository<WatchListItem> repo;

        public WatchListService(IImdbClient imdbClient, IUnitOfWork unitOfWork)
        {
            this.imdbClient = imdbClient;
            this.unitOfWork = unitOfWork;

            repo = unitOfWork.GetRepository<WatchListItem>();
        }

        public async Task<IEnumerable<FilmDto>> GetByExpressionAsync(string expression)
        {
            var response = await imdbClient.SearchAsync(expression);
            
            return response.Results.Select(x => new FilmDto()
            {
                FilmId = x.Id,
                Name = x.Title
            });
        }

        public Task<IEnumerable<UserFilmDto>> GetUserWatchListByIdAsync(int userId)
        {
            throw new NotImplementedException();
        }

        public Task SetStatusAsync(WatchListItemDto watchListItem)
        {
            throw new NotImplementedException();
        }

        public Task AddToWatchListAsync(WatchListItemDto watchListItem)
        {
            throw new NotImplementedException();
        }
    }
}
