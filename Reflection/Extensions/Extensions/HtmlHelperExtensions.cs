using Extensions.Models;
using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc.Rendering;


namespace Extensions.Extensions;

public static class HtmlHelperExtensions
{
    public static IHtmlContent DisplayResult(this IHtmlHelper html, double? result)
    {
        if (result.HasValue)
        {
            return new HtmlString($"<p>Результат: {result}</p>");
        }
        return HtmlString.Empty;
    }
}