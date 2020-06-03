// Learn more about F# at http://fsharp.org

open System

[<EntryPoint>]
let main argv =
    
    //Os operadores Pipe são usados ​​para passar parâmetros 
    //para uma função de maneira simples e elegante. 
    //Permite eliminar valores intermediários e facilitar a leitura 
    //das chamadas de funções.

    //No F# existem dois operadores pipe

    //Pipe Forward e Pipe Backward

    //Forward - Passando parâmetros da esquerda para a direita
    let print message =
        printf "%s" message
    // "Hello World" will be passed as a parameter to the print function
    "Hello World" |> print


    //Backward - Passando parâmetros da direita para a esquerda
    let print message =
        printf "%s" message
    // "Hello World" will be passed as a parameter to the print function
    print <| "Hello World"

    //Abaixo um exemplo sem operador pipe e após com operador pipe


    //SEM OPERADOR PIPE
    // We want to create a sequence from 0 to 10 then:
    // 1 Keep only even numbers
    // 2 Multiply them by 2
    // 3 Print the number
    
    let mySeq = seq { 0..10 }
    let filteredSeq = Seq.filter (fun c -> (c % 2) = 0) mySeq
    let mappedSeq = Seq.map ((*) 2) filteredSeq
    let finalSeq = Seq.map (sprintf "The value is %i.") mappedSeq
    
    printfn "%A" finalSeq

    //COM OPERADOR PIPE

    // Using forward pipe, we can eliminate intermediate let binding
    let finalSeq = 
        seq { 0..10 }
        |> Seq.filter (fun c -> (c % 2) = 0) 
        |> Seq.map ((*) 2) 
        |> Seq.map (sprintf "The value is %i.")
    
    printfn "%A" finalSeq

    //Outro exemplo de operador pipe


    [1..50] |> List.filter (fun n -> n % 2 = 0)
    //nessa linha vai dar um aviso que não
    //esta passado o resultado da lista de inteiros para lugar nenhum
    //acima teria que colocar um let foo = 

    ([1..50] |> List.filter (fun n -> n % 2 = 0)) |> printf "%A"

    //Cada resultado da função é passado como um parâmetro para a 
    //próxima função.
    
    //Se você deseja passar vários parâmetros para o operador de 
    //PIPE, adicione um |para cada parâmetro adicional e crie uma 
    //Tupla com os parâmetros. O operador de canal F # nativo 
    //suporta até três parâmetros (|||> ou <|||).
    

    //let printPerson name age =
    //    printf "My name is %s, I'm %i years old" name age
    
    //("Foo", 20) ||> printPerson


    0 // return an integer exit code
