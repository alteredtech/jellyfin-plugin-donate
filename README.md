<h1 align="center">Jellyfin Donate Plugin</h1>
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