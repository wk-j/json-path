## CMD

```
dotnet new tool-manifest

dotnet pack src/JsonPath -o __publish__

dotnet tool install wk.JsonPath --add-source __publish__
dotnet tool uninstall wk.JsonPath

cat resource/input.json | dotnet run --project src/JsonPath '$.data[*].content[*].id'
cat resource/input.json | dotnet run --project src/JsonPath '$.data[0].content[0].id'
```