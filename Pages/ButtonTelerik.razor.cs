using Microsoft.AspNetCore.Components;
using System;

namespace BlazorApp.Pages
{
    public partial class ButtonTelerik : ComponentBase
    {
        string thankYouString;

        protected void MyClickHandler()
        {
            thankYouString = string.Format("Thank you for clicking me at {0:HH:mm:ss} on {0:dd MMM yy}. Now you can write front-end with C#, yay!", DateTime.Now);
            StateHasChanged();
        }
    }
}
