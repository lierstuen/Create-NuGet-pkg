# How to create a NuGet package
One of the ways to create a NuGet package is through a .nuspec file. A .nuspec file defines the metadata of the NuGet package, as version, name, dependencies etc. 
After we have created a .nuspec file, we can run this command in the terminal
```
nuget pack <NAME>.nuspec
```
This will create a NuGet package, but a .nuspec file contains a lot more features that we can use to specify the NuGet package to our need, which this "article" aims to explain.

## Our application
In this repository, i have created a simple MathHelper application, which contains 4 simple mathematical operations, add, subtract, multiply and divide. The purpose of this application is not realy the implementation, but the MathHelper.nuspec file located in the root of the repository. Which looks like this:
```xml
<?xml version="1.0"?>
<package>
  <metadata>
    <id>MathHelper</id>
    <version>$version$</version>
    <authors>NAME</authors>
    <owners>OWNER's NAME</owners>
    <description>Application for performing simple mathematical operations</description>
    <dependencies>
     
    </dependencies>
  </metadata>
  <files>
    <file src="MathHelper\MathHelper\bin\Debug\net6.0\MathHelper.dll" target="lib\net6.0\MathHelper.dll" />
  </files>
</package>
```
The Metadata-tag describes the general information about the application, along with dependencies. The dependencies-tag describes dependencies the user have to install in order to use this application, e.g 
```xml 
<dependencies>
     <dependency id="Newtonsoft.Json" version="13.0.3" />
</dependencies>
```
Along the metadata, we have the files-tag, which indicate the files to create the NuGet package of, one of the files you include should/must be the .dll file of your application. If you have multiple projects you want to include, you should add them as well. e.g:
```xml
<files>
  <file src="path/from/.nuspec/to/.dll" target="path/to/where/dll/is/downloaded.dll">
</files>
```
The src is the path to the .dll file relative to the .nuspec file, while the target specifies where the file/dll should be placed when the NuGet package is installed.

## Replacement tokens
Some of the information we add to the .nuspec file, is information that might vary from each time we generate the nuget package. E.g, we have a CI/CD pipeline that during deployment will create an updated version of this NuGet package. At this scenerio, we would like to specify the version number in the pipeline. This is possible through replacement tokens. With a .nuspec file we can assign a tag a value starting and ending with a $-delimited. Then, when packing the application we can specify these values through the -properties attribute. E.g
```xml
<?xml version="1.0"?>
<package>
  <metadata>
      ...
    <version>$version$</version>
      ...
  </metadata>
</package>
```
Followed by runnnig:
```
nuget pack <NAME>.nuspec -properties version=2.1.3
```
Would result in creating a package with version 2.1.3. 
The replacement values must be within the metadata-tag.

## Publish NuGet package to GitHub-organization
After we have generated the NuGet package, we can publish it to our GitHub organization using this command:
```
nuget push path/to/your/package.nupkg -ApiKey <TOKEN> -Source https://nuget.pkg.github.com/<ORAGNIZATION_NAME>/index.json
```
Where TOKEN is a github token with write:package access to your organization.

