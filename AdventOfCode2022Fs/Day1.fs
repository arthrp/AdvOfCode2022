module AdventOfCode2022Fs.Day1

open System
open System.Collections.Generic
open System.Linq

let solveDay1 (input: string) : int =
    let lines = input.Split '\n'
    let mutable acc = 0
    let mutable sums = new List<int>()
    
    for line in lines do
        if line = "" then do
            sums.Add acc
            acc <- 0
        else do acc <- acc + Int32.Parse(line)
         
    sums.Max()
