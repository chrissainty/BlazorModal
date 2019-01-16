using BlazorModal.Services;
using Microsoft.AspNetCore.Blazor.Components;

namespace BlazorModal
{
    public class ModalContentBase : BlazorComponent
    {
        [Inject] private ModalService ModalService { get; set; }

        protected void CloseModal()
        {
            ModalService.Close();
        }
    }
}
