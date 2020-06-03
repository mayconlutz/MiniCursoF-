// Learn more about F# at http://fsharp.org

open System

[<EntryPoint>]
let main argv =
    
    //Expressões Lambda
    //Uma expressão lambda é uma função sem nome.

    //Aqui está uma função F # normal que adiciona três números:
    let addThreeNumbers x y z = x + y + z

    let result = addThreeNumbers 10 10 10 

    //Veja como reescrever a função acima em uma função lambda:
    let someOfThree = (fun x y z -> x + y + z) 10 20 30

    let result = addThreeNumbers 10 20 30

    printfn "teste 1: %A " result

    //A palavra-chave divertida é seguida pelos parâmetros de entrada x, y e z. 
    //Depois vem o delimitador de seta -> seguido pelo corpo curto da função,
    //que é apenas uma declaração de retorno. Finalmente temos os argumentos para
    //a função lambda. Obviamente, isso não é diferente de uma chamada de função normal:

    //Expressões lambda em F# são funções anônimas em linha, ou seja, funções sem nome. 
    //Geralmente, são funções curtas e concisas que não devem ser reutilizadas.

    //Também podemos declarar os tipos de entrada:

    let someOfThree = (fun (x:int) (y:int) (z:int) -> x + y + z) 10 20 30

    //Aqui está outro exemplo para encontrar o valor absoluto da diferença entre dois números:

    let absoluteValue = (fun (x:int) (y:int) -> x - y |> abs) 30 50

    printfn "teste: %A" someOfThree
    printfn "teste: %A" someOfThree
    printfn "teste: %A" absoluteValue


    0 // return an integer exit code
