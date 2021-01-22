## Json Path

[![Actions](https://github.com/wk-j/json-path/workflows/NuGet/badge.svg)](https://github.com/wk-j/json-path/actions)
[![NuGet](https://img.shields.io/nuget/v/wk.JsonPath.svg)](https://www.nuget.org/packages/wk.JsonPath)
[![NuGet Downloads](https://img.shields.io/nuget/dt/wk.JsonPath.svg)](https://www.nuget.org/packages/wk.JsonPath)

## Installation

```bash
dotnet tool install -g wk.JsonPath
```

## Usage

```bash
cat resource/input.json | wk-json-path '$.data[*].content[*].id'
cat resource/input.json | wk-json-path '$.data[0].content[0].id'
```