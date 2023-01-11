open System.IO
open AdventOfCode2022Fs.Day1

[<EntryPoint>]
let main argv =
    let contents = File.ReadAllText argv[0]
    let r = solveDay1 contents
    printfn "%d" r
    0