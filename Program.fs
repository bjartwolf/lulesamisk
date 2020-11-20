// Learn more about F# at http://fsharp.org

open System

type LanguageCode = Languagecode of string

module IsoLanguageCodes = 
    type IsoLanguageCode = private ISO_639_3 of string
    let create str = 
        if String.IsNullOrEmpty(str) then
            None
        elif String.length str = 3 then
            Some (ISO_639_3 str)
        else
            None 

    let value (ISO_639_3 str) = str




type Subtitles = Language of LanguageCode
[<EntryPoint>]
let main argv =
    let languageCode = IsoLanguageCodes.create "norsk"
    match languageCode with
        | Some lang -> printfn "%s" (IsoLanguageCodes.value lang)
        | None -> failwith "No valid language code" 
    0 // return an integer exit code
