using System.Collections.Generic;
using AbdoZBakeryHRM.Shared;

namespace AbdoZBakeryHRM.Api.Models
{
    public interface IJobCategoryRepository
    {
        IEnumerable<JobCategory> GetAllJobCategories();
        JobCategory GetJobCategoryById(int jobCategoryId);
    }
}
