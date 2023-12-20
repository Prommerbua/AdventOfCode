open System

let fileName = "../../../example.txt"

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
    let toNumber (line) = (line
        |> Seq.filter (fun c -> Char.IsNumber(c)) 
        |> (fun s -> [|Seq.head s; Seq.last s|]) 
        |> String.Concat 
        |> int) 

    let sum = lines |> Seq.map toNumber |> Seq.sum
    printfn "%d" sum

task1()