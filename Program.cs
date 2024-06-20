using System.Threading.Tasks;
using Microsoft.Identity.Client;

Console.WriteLine("Inicia Aplicacion..");

string clientId = "<<Application ID>>";
string tenantId = "<<Tenant ID>>";

var app = PublicClientApplicationBuilder
    .Create(clientId)
    .WithAuthority(AzureCloudInstance.AzurePublic, tenantId)
    .WithRedirectUri("http://localhost")
    .Build();

string[] scopes = { "user.read" };

AuthenticationResult authResult = await app.AcquireTokenInteractive(scopes).ExecuteAsync();
Console.WriteLine($"Token recibido:\t{authResult.AccessToken}");
