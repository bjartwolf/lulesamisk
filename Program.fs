// Learn more about F# at http://fsharp.org

open System

type LanguageCode = LanguageCode of string

type Subtitles = Language of LanguageCode
[<EntryPoint>]
let main argv =
    printfn "%A" (LanguageCode "norsk")
    0 // return an integer exit code
