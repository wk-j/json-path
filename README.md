## Json Path

Extract data from json with json path

[![Actions](https://github.com/wk-j/json-path/workflows/NuGet/badge.svg)](https://github.com/wk-j/json-path/actions)
[![NuGet](https://img.shields.io/nuget/v/wk.JsonPath.svg)](https://www.nuget.org/packages/wk.JsonPath)
[![NuGet Downloads](https://img.shields.io/nuget/dt/wk.JsonPath.svg)](https://www.nuget.org/packages/wk.JsonPath)

## Installation

```bash
dotnet tool install -g wk.JsonPath
```

## Extract data from file

```bash
cat resource/input.json | wk-json-path '$.data[*].content[*].id'
719114
719118

cat resource/input.json | wk-json-path '$.data[0].content[0].id'
719114
```

## Extract data from API

```
http -b 'https://reqres.in/api/users?page=2' \
    | wk-json-path "\$.data[?(@.last_name == 'Lawson')].email"
michael.lawson@reqres.in

http -b 'https://reqres.in/api/users?page=2' \
    | wk-json-path "\$.data[*].email"
michael.lawson@reqres.in
lindsay.ferguson@reqres.in
tobias.funke@reqres.in
byron.fields@reqres.in
george.edwards@reqres.in
rachel.howell@reqres.in
```