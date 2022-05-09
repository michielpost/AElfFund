using AelfFund.Web.Models;
using Microsoft.JSInterop;

namespace AelfFund.Web.Services
{
    public class ChainService
    {
        private readonly IJSRuntime JS;

        public ChainService(IJSRuntime js)
        {
            this.JS = js;
        }

        public async Task TestAsync()
        {
            await JS.InvokeVoidAsync("Test");
        }

        public Task<List<ProjectModel>> GetProjects()
        {
            var result = new List<ProjectModel>()
            {
                new ProjectModel()
                {
                    Id = Guid.NewGuid().ToString(),
                    Name = "Test",
                    Description = "Test desc",
                    FundGoal = 1000
                },
                new ProjectModel()
                {
                    Id = Guid.NewGuid().ToString(),
                    Name = "Test 2",
                    Description = "Test desc 2",
                    FundGoal = 1000
                }
            };

            return Task.FromResult(result);
        }

        internal Task AddProject(CreateProjectModel model)
        {
            throw new NotImplementedException();
        }

        internal Task FundProject(string id, decimal fund)
        {
            throw new NotImplementedException();
        }

        internal Task CancelFunding(string project, decimal amount)
        {
            throw new NotImplementedException();
        }

        internal Task<List<Funder>> GetFunders()
        {
            var result = new List<Funder>()
            {
                new Funder
                {
                     Address = "0xTODO",
                      Amount = 13m,
                       Project = "project name global list",
                        TxId = "000xx0x"
                }
            };

            return Task.FromResult<List<Funder>>(result);
        }

        internal Task<List<Funder>?> GetFundersForProject(string id)
        {
            var result = new List<Funder>()
            {
                new Funder
                {
                     Address = "0xTODO",
                      Amount = 13m,
                       Project = "project name",
                        TxId = "000xx0x"
                }
            };

            return Task.FromResult<List<Funder>?>(result);
        }

        public Task<ProjectModel?> GetProject(string id)
        {
            ProjectModel? result = new ProjectModel()
            {
                Id = Guid.NewGuid().ToString(),
                Name = "Test from service",
                Description = "Test desc 123",
                FundGoal = 1023m,
                FundCurrent = 150m
            };

            return Task.FromResult<ProjectModel?>(result);
        }
    }
}
