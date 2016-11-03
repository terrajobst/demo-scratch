# Demo for Hunter

## .NET Standard 2.0 is much bigger!


## .NET Standard 2.0 Allows referencing existing binaries

* Download PowerCollections
    - https://powercollections.codeplex.com/releases/view/6863
    - Point out that it's from 2005 -- 11 years ago
* Add reference
* Use the following code:

## Modify xxx.json

Find the file

`src\NetCore_ConsoleApp\bin\Debug\netcoreapp1.0\NetCore_ConsoleApp.deps.json"`

and make the following changes to it:

```diff
 {
   "runtimeTarget": {
     "name": ".NETCoreApp,Version=v1.0",
     "signature": "7f332d461d5e81564beabe484a7340288cef44c0"
   },
   "compilationOptions": {},
   "targets": {
     ".NETCoreApp,Version=v1.0": {
       "netcore_consoleapp/1.0.0": {
         "dependencies": {
           "Microsoft.NET.Sdk": "1.0.0-alpha-20161102-4",
           "NetStandard_ClassLibrary": "1.0.0"
         },
         "runtime": {
           "NetCore_ConsoleApp.dll": {},
+           "netstandard.dll": {},
+           "PowerCollections.dll": {}
         }
       },
```

Hit F5!