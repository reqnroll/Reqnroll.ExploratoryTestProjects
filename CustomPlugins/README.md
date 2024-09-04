# Custom Reqnroll Plugins

The generator plugin test `CustomPlugins.TagDecoratorGeneratorPlugin.Test` needs to load the plugin from NuGet package. But the package is not published, so we have a `nuget.config` file to add the `bin\Debug` folder of the plugin to the NuGet package sources.

*Important: In order to load the latest version of the plugin, you need to remove the plugin from your local NuGet package cache, `C:\Users\<your-user-name>\.nuget\packages\customplugins.tagdecoratorgeneratorplugin`, otherwise the old version will be loaded.*
