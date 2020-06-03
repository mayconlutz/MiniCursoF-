//Maycon Lutz e William Simionatto
//F#

open System

[<EntryPoint>]
let main argv =
    
    let function1 x y =               //A função function1 tem o argumento 1 x do tipo int, e o argumento 2 y do tipo int e retorna uma string
      if x = y then "igual"           //Comparação se x é igual a y se sim retorna a string "igual"
      elif x < y then "é menor que"   //Comparação se x é menor que y, se for menor retorna a string "é menor que", se não retorna "é maior que"
      else "é maior que"

    let function2 x y =                     //A função function2 tem o argumento 1 x do tipo int, e o argumento 2 y do tipo int e retorna uma string
      if x <= y then "é menor ou igual que" //Comparação se x é menor ou igual a y se sim retorna a string "é menor ou igual que" se não retorna "é maior que"
      else "é maior que"

    let function3 x y =                     //A função function3 tem o argumento 1 x do tipo int, e o argumento 2 y do tipo int e retorna uma string
      if x >= y then "é maior ou igual que" //Comparação se x é maior ou igual a y se sim retorna a string "é maior ou igual que" se não retorna "é menor que"
      else "é menor que"

    //Acima testamos as expressões condicionais if...then...elif...else utilizando as comparações =...<...>...<=...>=

    //Abaixo utilizando o printfn para output chamamos as funções e enviamos os argumentos

    printfn "%d %s %d." 10 (function1 10 20) 20 

    printfn "%d %s %d." 10 (function2 10 20) 20 

    printfn "%d %s %d." 10 (function3 10 20) 20 

    0 // return an integer exit code


//referência de base para código: https://docs.microsoft.com/pt-br/dotnet/fsharp/language-reference/conditional-expressions-if-then-else


