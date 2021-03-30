using BlazorApp.Data;
using Microsoft.AspNetCore.Components;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace BlazorApp.Shared
{
    public partial class CreateUser : ComponentBase
    {
        string keyListUsers = "keyListUsers";

        [Parameter]
        public List<CRUDUser> FnNewUser { get; set; }

        [Parameter]
        public EventCallback<List<CRUDUser>> FnNewUserChanged { get; set; }

        List<CRUDUser> CRUDUsers = new List<CRUDUser>();

        CRUDUser crudUser = new CRUDUser();

        private async Task CreateNewUser()
        {
            string apiName = "api/users";
            var postData = System.Text.Json.JsonSerializer.Serialize(crudUser);
            var client = httpClientFactory.CreateClient("ClientBlazor");
            var response = await client.PostAsync(apiName, new StringContent(postData));

            if (response.IsSuccessStatusCode)
            {
                //var options = new System.Text.Json.JsonSerializerOptions
                //{
                //    NumberHandling = System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString
                //};

                var content = await response.Content.ReadAsStringAsync();
                CRUDUser user = System.Text.Json.JsonSerializer.Deserialize<CRUDUser>(content);
                if (user != null)
                {
                    user.Name = crudUser.Name;
                    user.Job = crudUser.Job;
                    FnNewUser.Add(user);
                    await localStorage.SetItemAsync(keyListUsers, FnNewUser);
                    //await js.InvokeVoidAsync("setLocalStorage", keyListUsers, FnNewUser);
                    await FnNewUserChanged.InvokeAsync(FnNewUser);
                    crudUser = new CRUDUser();
                }
            }
        }
    }
}
