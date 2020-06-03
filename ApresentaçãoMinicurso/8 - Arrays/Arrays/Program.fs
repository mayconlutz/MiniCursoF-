// Learn more about F# at http://fsharp.org

open System

[<EntryPoint>]
let main argv =

    //Você pode criar matrizes usando várias sintaxes e maneiras
    //ou usando as funções do módulo Matriz. Nesta seção, discutiremos
    //a criação de matrizes sem usar as funções do módulo.

    //Existem 3 maneiras sintáticas de criar matrizes sem funções
    //mas inumeras possibilidades
    
    // 1 - Listando valores consecutivos entre [| e |] e separados por ponto e vírgula.
    // 2 - Ao colocar cada elemento em uma linha separada, nesse caso, o separador de ponto e vírgula é opcional.
    // 3 - sem expressões
    // 4 - Usando expressões de sequência.
    // 5 - usando steps

    //1
    let array1 = [| 1; 2; 3; 4; 5; 6 |]
    for i in 0 .. array1.Length - 1 do
       printf "%d " array1.[i]
    printfn" "


    //2
    let array2 =
       [|
          1
          2
          3
          4
          5
       |]
    for i in 0 .. array2.Length - 1 do
       printf "%d " array2.[i]
    printfn" "

    //3
    let array3 = [|1..10|]
    for i in 0 .. array3.Length - 1 do
       printf "%d " array3.[i]
    printfn" "

    //4
    let array4 = [| for i in 1 .. 10 -> i * i |]
    for i in 0 .. array4.Length - 1 do
       printf "%d " array4.[i]
    printfn" "

    //5
    let array5 = [|1..2..10|]
    for i in 0 .. array5.Length - 1 do
       printf "%d " array5.[i]
    printfn" "

    0 // return an integer exit code
