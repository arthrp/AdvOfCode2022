namespace AdventOfCode2022Fs.Test

open NUnit.Framework

[<TestFixture>]
type Day1Tests () =

    [<Test>]
    member this.Day1SolvedCorrectly() =
        let input = "1000\n2000\n3000\n\n4000\n\n5000\n6000\n\n"
        let result = AdventOfCode2022Fs.Day1.solveDay1 input
        Assert.AreEqual(11000, result)