// Learn more about F# at http://fsharp.org

open System

[<EntryPoint>]
let main argv =
    
    //comando let mais utilizado no F#
    //Let associa um identificador a um valor ou função
    //Declarando uma função 
    let square x = x * x


    //Se você separar a expressão do identificador usando uma nova linha, 
    //deverá recuar cada linha da expressão, como no código a seguir.
    let square1 x =
        x * x

    //Em vez de apenas um nome, um padrão que contém nomes pode ser especificado, 
    //por exemplo, uma tupla, conforme mostrado no código a seguir. 
    //i é uma lista que contem valores de 1 a 10,
    //j recebe valor 2
    //k receve valor 3
    let i, j, k = ([1..10],2,3)

    //https://docs.microsoft.com/pt-br/dotnet/fsharp/language-reference/lists
    //Definindo uma lista, tem várias maneiras
    let numbers = [1..10]
    let numbers1 = [1;2;3] 
    let numbers2 = [
        1
        2
        3
        4]
    //lista vazia
    let empty = []


    //List.map, permite aplicar uma função a cada elemento de uma lista 
    //e colocar todos os resultados em uma nova lista
    let squares = List.map square numbers

    //printf suportam tipos F# nativos usando o %A
    printfn "N^2 = %A"squares
    printfn "%A" i
    printfn "%A" j
    printfn "%A" k
    0 // return an integer exit code

    //podemos observar como é simples usar o f# para trabalhar com funções matemáticas






    

    



