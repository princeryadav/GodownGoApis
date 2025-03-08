using DataAccessLayer.Entities;
using DataAccessLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer
{
    public class GoDownService : IGoDownService
    {
        private readonly IGoDownRepository _goDownRepository;

        public GoDownService(IGoDownRepository goDownRepository)
        {
            _goDownRepository = goDownRepository;
        }
        public async Task<IEnumerable<GoDown>> GetGoDownsAsync()
        {
            return await _goDownRepository.GetGoDownsAsync();
        }
    }
}
