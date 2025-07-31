using Microsoft.AspNetCore.Components;

public class BlazorPage : ComponentBase {
    [Parameter]
    public string Html { get; set; }

    public RenderFragment RenderContent() => (builder) => {
        // ruleid: blazor-xss-raw-html
        builder.AddContent(0, (MarkupString)Html);
    };
}
