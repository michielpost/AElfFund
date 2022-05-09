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

        public Task<ProjectModel?> GetProject(string id)
        {
            ProjectModel? result = new ProjectModel()
            {
                Id = Guid.NewGuid().ToString(),
                Name = "Test from service",
                Description = "Test desc 123",
                FundGoal = 1000123
            };

            return Task.FromResult<ProjectModel?>(result);
        }
    }
}
