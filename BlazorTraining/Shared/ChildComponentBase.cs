using Microsoft.AspNetCore.Components;

namespace BlazorTraining.Shared
{
    public class ChildComponentBase : ComponentBase
    {
        protected bool DarkThemeOn;
        protected string AlertTheme => DarkThemeOn ? "dark" : "light";

        [Parameter]
        public RenderFragment ChildContent { get; set; }

        protected override void OnInitialized()
        {
            DarkThemeOn = true;
        }
    }
}
