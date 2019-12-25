using BlazorTraining.Services;
using Microsoft.AspNetCore.Components;

namespace BlazorTraining.Shared
{
    public class ChildComponentBase : ComponentBase
    {
        protected bool DarkThemeOn;
        protected string AlertTheme => DarkThemeOn ? "dark" : "light";
        [Inject]
        protected RandomService RandomService { get; set; }

        [Parameter]
        public RenderFragment ChildContent { get; set; }

        protected override void OnInitialized()
        {
            DarkThemeOn = true;
        }
    }
}
