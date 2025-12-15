dotnet new webapi -lang c# -n AutoLot.Api -au none -o .\AutoLot.Api --use-controllers -f net10.0
dotnet sln AutoLot.sln add AutoLot.Api
dotnet add AutoLot.Api reference AutoLot.Models
dotnet add AutoLot.Api reference AutoLot.Dal
dotnet add AutoLot.Api reference AutoLot.Services

dotnet add AutoLot.Api package Asp.Versioning.Mvc -v '[8.*,10.0)' 
dotnet add AutoLot.Api package Asp.Versioning.Mvc.ApiExplorer -v '[8.*,10.0)'
dotnet add AutoLot.Api package Microsoft.AspNetCore.OpenApi -v '[10.*,11.0)'
dotnet add AutoLot.Api package Microsoft.EntityFrameworkCore.SqlServer -v '[10.*,11.0)' 
dotnet add AutoLot.Api package Microsoft.EntityFrameworkCore.Design -v '[10.*,11.0)'  
dotnet add AutoLot.Api package Microsoft.VisualStudio.Threading.Analyzers -v '[17.*,19.0)'
dotnet add AutoLot.Api package Swashbuckle.AspNetCore.SwaggerUI -v '[10.*,11.0)'
dotnet add AutoLot.Api package Scalar.AspNetCore -v '[2.*,3)'
dotnet add AutoLot.Mvc package Microsoft.Build

pause
