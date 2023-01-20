using System;
namespace BlazorCrud.Client.Pages
{
	public partial class Products
	{
        protected override async Task OnInitializedAsync()
        {
            await ProductService.GetProducts();
        }

        void ShowProduct(int id)
        {
            NavigationManager.NavigateTo($"product/{id}");
        }

        void CreateNewProduct()
        {
            NavigationManager.NavigateTo("/product");
        }
    }
}

