using Microsoft.AspNetCore.Components;

namespace WSProjectClient.Data
{
    public class UserInfo
    {
        //[CascadingParameter]
        public int UserId { get; set; }

        public string? Username { get; set; }

        public string? Email{ get; set; }
    }
}
