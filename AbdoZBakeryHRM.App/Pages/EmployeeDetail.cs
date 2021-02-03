using AbdoZBakeryHRM.App.Services;
using AbdoZBakeryHRM.Shared;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbdoZBakeryHRM.App.Pages
{
    public partial class EmployeeDetail
    {
        [Parameter]
        public string EmployeeId { get; set; }
        public Employee Employee { get; set; } = new Employee();

        [Inject]
        public IEmployeeDataService service { get; set; }

        protected async override Task OnInitializedAsync()
        {
            Employee = await service.GetEmployeeDetails(int.Parse(EmployeeId));
        }

        public IEnumerable<Employee> Employees { get; set; }

        private List<Country> Countries { get; set; }

        private List<JobCategory> JobCategories { get; set; }
    }
}