# OrchardCore with blazor components sample

This is a sample Orchard Core CMS project to demonstrate Orchard Core modules using server-side Blazor components. The idea is to be able to build a modularized CMS website using server-side Blazor components mixed in the MVC architecture. If you are planning to build a decoupled CMS websites or a Blazor-only SPA then another approach might be required.
This repository is based on an sample in this repository: https://github.com/barthamark/Orchard-Core-Blazor-Sample

Please note, that implementing a workaround was required to make Blazor static contents (e.g. blazor.server.js) accessible. See: OrchardCMS/OrchardCore#2966 (comment)

## How to use this sample
1. Clone the repository, restore and build. Please note that the solution uses the .NET 6 version of Orchard Core (1.6.0) build
2. Set up the Orchard Core website using the `Blazor Sample` recipe. You can use any recipe but make sure to enable the `MyTheme.OrchardBlazor` theme and the `BlazorEnabledModule module`.
3. You can test Blazor components under the `/home/index URL`, (this should also be the landing page served in the root of the site).
4. Explanations are in the comments. Please make sure you go through the source code, more specifically go to:
* `OrchardBlazor/Program.cs` (static files workaround)
* `BlazorEnabledModule/Startup.cs`
* `BlazorEnabledModule/Views` (see all files)
* `MyTheme.OrchardBlazor/Views/Layout.cshtml`
