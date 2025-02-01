using BlazorApp3.Components.Customers.Dialog;
using BlazorApp3.Data;
using Microsoft.AspNetCore.Components;
using MudBlazor;

namespace BlazorApp3.Components.Customers
{
    public partial class Customers
    {
        [Inject] public ICustomerService _customerService { get; set; }
        [Inject] public IDialogService _dialogService { get; set; }  // ??????
        private List<Customer> CustomerList { get; set; } = new();
        private Customer Customer { get; set; } = new();

        protected override async Task OnInitializedAsync()
        {
            CustomerList = await _customerService.GetCustomers();
            StateHasChanged();   ///////?????
        }

        private async Task ButtonAddClickAsync()
        {
            var parameters = new DialogParameters<CustomerDialog>
            {
                //{"typeDialog",1},
            };

            var z = await _dialogService.ShowAsync<CustomerDialog>(
                "customeri avelacum",
                parameters: parameters,
                new DialogOptions()
                {
                    CloseButton = true,
                    MaxWidth = MaxWidth.Small,
                    FullWidth = true,
                });

            var res = await z.Result;

            if (res.Canceled)
            {
                return;
            }

            //await GetAllCustomer();
            await OnInitializedAsync();
        }
    }
}
