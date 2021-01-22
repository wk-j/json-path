open System

open Newtonsoft.Json
open Newtonsoft.Json.Linq
open System.Text

let printUsage() =
    let usage =
        """
Usage
$ cat input.json | wk-json-path "$.object.property"
        """
    printfn "%s" usage

[<EntryPoint>]
let main argv =
    if argv.Length = 0 then
        printUsage()
        0
    else
        let jsonPath = argv.[0]
        let b = StringBuilder()
        let mutable line = Console.ReadLine()

        while isNull line |> not do
            b.AppendLine(line) |> ignore
            line <- Console.ReadLine()

        let json = b.ToString()
        let obj = JObject.Parse(json)
        let token = obj.SelectTokens(jsonPath)

        for item in token do
            printfn "%s" (item.ToString())
        0