﻿// Learn more about F# at http://fsharp.org

open System

type LanguageCode = Languagecode of string

module IsoLanguageCodes = 
    type IsoLanguageCode = private ISO_639_3 of string
    let create str = 
        if String.IsNullOrEmpty(str) then
            None
        elif String.length str = 3 then
            None
        else
            Some (ISO_639_3 str)

    let value (ISO_639_3 str) = str




type Subtitles = Language of LanguageCode
[<EntryPoint>]
let main argv =
    printfn "%A" (IsoLanguageCodes.create "norsk")
    0 // return an integer exit code
