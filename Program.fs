// Learn more about F# at http://fsharp.org

open System

type LanguageCode = Languagecode of string
type IsoLanguageCode = ISO_639_3 of string

type Subtitles = Language of LanguageCode
[<EntryPoint>]
let main argv =
    printfn "%A" (ISO_639_3 "norsk")
    0 // return an integer exit code
