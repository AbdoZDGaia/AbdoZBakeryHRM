using AbdoZBakeryHRM.App.Components;
using AbdoZBakeryHRM.App.Services;
using AbdoZBakeryHRM.Shared;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace AbdoZBakeryHRM.App.Pages
{
    public partial class EmployeeOverview
    {
        private readonly EmployeeDataService _service;

        public IEnumerable<Employee> Employees { get; set; }

        //[Inject]
        //public HttpClient HttpClient { get; set; }

        //public EmployeeOverview(EmployeeDataService service)
        //{
        //    _service = service;
        //}
        protected AddEmployeeDialog AddEmployeeDialog { get; set; }

        [Inject]
        public IEmployeeDataService service { get; set; }

        protected async override Task OnInitializedAsync()
        {
            //var data = await HttpClient.GetFromJsonAsync<List<Employee>>("https://localhost:44340/api/Employee");
            Employees = (await service.GetAllEmployees()).ToList();
        }

        protected void QuickAddEmployee()
        {
            AddEmployeeDialog.Show();
        }

        protected async void AddEmployeeDialog_onDialogClose()
        {
            Employees = (await service.GetAllEmployees()).ToList();
            StateHasChanged();
        }
    }
}
