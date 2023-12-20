open System

let fileName = "../../../example2.txt"

let readLines fileName: seq<string> = System.IO.File.ReadLines(fileName)

let lines = readLines(fileName);

let printSeq seq1 = Seq.iter (printf "%A ") seq1; printfn ""


let task1 () = 
    let toNumber (line) = (line
        |> Seq.filter (fun c -> Char.IsNumber(c)) 
        |> (fun s -> [|Seq.head s; Seq.last s|]) 
        |> String.Concat 
        |> int) 

    let sum = lines |> Seq.map toNumber |> Seq.sum
    printfn "%d" sum

let task2 () = 
    let numbers = [|"1"; "2"; "3"; "4"; "5"; "6"; "7"; "8"; "9"; "one"; "two"; "three"; "four"; "five"; "six"; "seven"; "eight"; "nine"|]

    let first (line: string) = (numbers
        |> Seq.map (fun n -> (n,line.StartsWith(n)))
        |> Seq.filter (fun n -> snd n <> false)
        |> (fun s -> Seq.head s))

    let splitString (line) = (line
        |> (fun l -> l.ToString())
        |> (fun s -> first s)
        //|> (fun s -> s.IndexOf("two"))
        )

    lines |> Seq.map splitString |> printSeq

task2()