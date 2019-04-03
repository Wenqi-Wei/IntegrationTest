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
        //29/03/2019
        //changed some settings in NuGet Manager
        //did a dotnet restore
        //removed the empty json file
        //rebuilt sln solution
        //unchecked MS local NuGet source
        //added another NuGet.org source
        //did a dotnet build
        //02/04/2019
        //linked up VS -> TeamCity -> Octo Tentacle -> Octo Server, try pushing an update to TC
        //TeamCity is generating Artifacts now
        //push new update to refresh TC builds
        //uninstalled & re-installed OctoPack VS plugin
        //03/04/2019
        //test the whole VS -> TC -> Octo Tentacle -> Octo Server communication
        //demo to Craig
    }
}