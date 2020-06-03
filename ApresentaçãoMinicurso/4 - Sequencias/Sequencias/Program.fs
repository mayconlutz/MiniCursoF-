// Learn more about F# at http://fsharp.org

open System

[<EntryPoint>]
let main argv =
    
    //Sequências, como listas, também representam uma coleção ordenada de valores.
    //No entanto, os elementos em uma sequência ou expressão de sequência 
    //são calculados quando necessário. Eles não são calculados de uma só vez e,
    //por esse motivo, são usados ​​para representar estruturas de dados infinitas.


    (* Sequences *)
    let seq1 = seq { 1 .. 10 }
    
    (* ascending order and increment*)
    printfn "The Sequence: %A" seq1
    let seq2 = seq { 1 .. 5 .. 50 }
    
    (* descending order and decrement*)
    printfn "The Sequence: %A" seq2
    
    let seq3 = seq {50 .. -5 .. 0}
    printfn "The Sequence: %A" seq3
    
    (* using yield *)
    let seq4 = seq { for a in 1 .. 10 do yield a, a*a, a*a*a }
    printfn "The Sequence: %A" seq4

    // Repeats '1 2 3 4 5' ten times
    let seq5 = 
        seq {
            for _ in 1..10 do
                yield! seq { 1; 2; 3; 4; 5}
            }

    for x in seq5 do
        printfn "%d" x

    printfn "The Sequence: %A" seq5

    0 // return an integer exit code
