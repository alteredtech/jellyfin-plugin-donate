<h1 align="center">Jellyfin Donate Plugin</h1>
<h2 align="center">Still alpha</h2>
This is a back burner project as I have not found a way to add an icon to the landing page on jellyfin. If you know how please create an issue with a link on how to do that and I will do my best to get it integrated. Thanks!
<!-- <h3 align="center">Part of the <a href="https://jellyfin.media">Jellyfin Project</a></h3> -->

<p align="center">
This plugin is built with .NET Core to download metadata for donate.
</p>

## Build Process

1. Clone or download this repository

2. Ensure you have .NET Core SDK setup and installed

3. Build plugin with following command.

```sh
dotnet publish --configuration Release --output bin
```
4. Create a folder for your plugin on jellyfin. Open the bin folder in the project and move the Jellyfin.Plugin.Donate.dll file to the folder you created.
