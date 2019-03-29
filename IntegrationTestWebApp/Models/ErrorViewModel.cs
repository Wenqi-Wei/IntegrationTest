using System;

namespace IntegrationTestWebApp.Models
{
    public class ErrorViewModel
    {
        public string RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);

        //empty comment line
        //so that i can commit something
        //another comment to test a new build
        //29/03/2019 changed some settings in NuGet Manager
        //29/03/2019 did a dotnet restore
    }
}