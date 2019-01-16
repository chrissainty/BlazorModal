using BlazorModal.Services;
using Microsoft.AspNetCore.Blazor;
using Microsoft.AspNetCore.Blazor.Components;
using System;

namespace BlazorModal
{
    public class ModalBase : BlazorComponent, IDisposable 
    {
        [Inject] ModalService ModalService { get; set; }

        protected bool IsVisible { get; set; }
        protected RenderFragment Content { get; set; }

        protected override void OnInit()
        {
            ModalService.OnShow += ShowModal;
            ModalService.OnClose += CloseModal;
        }

        public void ShowModal(RenderFragment content)
        {
            Content = content;
            IsVisible = true;
            StateHasChanged();
        }

        public void CloseModal()
        {
            IsVisible = false;
            Content = null;
            StateHasChanged();
        }

        public void Dispose()
        {
            ModalService.OnShow -= ShowModal;
            ModalService.OnClose -= CloseModal;
        }
    }
}
