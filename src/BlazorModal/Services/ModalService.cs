using Microsoft.AspNetCore.Blazor;
using System;

namespace BlazorModal.Services
{
    public class ModalService
    {
        public event Action<RenderFragment> OnShow;
        public event Action OnClose;

        public void Show(Type contentType)
        {
            var content = new RenderFragment(x => { x.OpenComponent(1, contentType); x.CloseComponent(); });

            OnShow?.Invoke(content);
        }

        public void Close()
        {
            OnClose?.Invoke();
        }
    }
}
