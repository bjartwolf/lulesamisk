// Learn more about F# at http://fsharp.org

open System

type LanguageCode = Languagecode of string

module IsoLanguageCodes = 
    type IsoLanguageCode = private ISO_639_3 of string
    let create str = 
        if String.IsNullOrEmpty(str) || String.length(str) <> 3 then
            failwith "Not a valid lang code" 
        else 
            ISO_639_3 str

    let value (ISO_639_3 str) = str




type Subtitles = Language of LanguageCode
[<EntryPoint>]
let main argv =
    let languageCode = IsoLanguageCodes.create "norsk"
    printfn "%s" (IsoLanguageCodes.value languageCode)
    0 // return an integer exit code
