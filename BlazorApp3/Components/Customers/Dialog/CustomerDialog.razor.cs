using BlazorApp3.Data;
using Microsoft.AspNetCore.Components;
using MudBlazor;

namespace BlazorApp3.Components.Customers.Dialog
{
    public partial class CustomerDialog
    {
        [Inject] private ICustomerService _customerService { get; set; }
        [CascadingParameter] public IMudDialogInstance MudDialog { get; set; }
        [Inject] private ISnackbar Snackbar { get; set; }
        private Customer Customer { get; set; } = new();

        private async Task ActionButtonAsync(Customer customer)
        {
            await _customerService.AddCustomer(customer);
            Snackbar.Add("avelacvav", Severity.Success);
            MudDialog.Close(DialogResult.Ok(true));
        }
    }
}
