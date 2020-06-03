// Learn more about F# at http://fsharp.org

open System

[<EntryPoint>]
let main argv =

    //Funções recursivas são funções que se chamam.
    //Você define uma recursiva usando a combinação de palavras-chave let rec .

    //O programa a seguir retorna Fibonacci 1 a 10 usando IF
    let rec fib n = if n <= 1 then 1 else fib (n - 1) + fib (n - 2)

    for i = 0 to 9 do
       printfn "Fibonacci %d: %d" i (fib i)
    
    //O programa a seguir retorna Fibonacci 1 a 10 usando Pattern Matching

    let rec fib n =
       match n with
       | 0 -> 1
       | 1 -> 1
       | _ -> fib (n - 1) + fib (n - 2)

    for i = 0 to 9 do
       printfn "Fibonacci %d: %d" i (fib i)

    //O programa a seguir retorna o fatorial 8 usando IF
    let rec fact x =
        if x < 1 then 1
        else x * fact (x - 1)
    Console.WriteLine(fact 8)

    0 // return an integer exit code
