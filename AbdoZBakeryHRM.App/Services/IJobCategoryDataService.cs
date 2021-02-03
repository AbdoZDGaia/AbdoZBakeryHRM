using AbdoZBakeryHRM.Shared;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AbdoZBakeryHRM.App.Services
{
    public interface IJobCategoryDataService
    {
        Task<JobCategory> AddJobCategory(JobCategory employee);
        Task DeleteJobCategory(int employeeId);
        Task<IEnumerable<JobCategory>> GetAllJobCategories();
        Task<JobCategory> GetJobCategoryDetails(int employeeId);
        Task UpdateJobCategory(JobCategory employee);
    }
}