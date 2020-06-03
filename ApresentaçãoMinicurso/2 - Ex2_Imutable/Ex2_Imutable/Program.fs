// Learn more about F# at http://fsharp.org

open System

[<EntryPoint>]
let main argv =

    //POR QUE IMUTÁVEL?

    //Valores imutáveis são valores que não podem ser alterados ao longo da
    //execução de um programa. Se você está acostumado a linguagens como C ++
    //Visual Basic ou C #, pode surpreender que o F # primaria por valores 
    //imutáveis, em vez de variáveis que podem receber novos valores durante 
    //a execução de um programa. Dados imutáveis são um elemento importante
    //da programação funcional. Em um ambiente multithread, é difícil gerenciar
    //variáveis mutáveis compartilhadas que podem ser alteradas por vários 
    //threads diferentes. Além disso, com variáveis mutáveis, às vezes pode ser
    //difícil dizer se uma variável pode ser alterada quando é passada para 
    //outra função.

    //VARIÁVEIS MUTÁVEIS

    //Você pode usar a palavra mutable- chave para especificar uma variável 
    //que pode ser alterada. Variáveis mutáveis em F # geralmente devem ter
    //um escopo limitado, como um campo de um tipo ou como um valor local. 
    //Variáveis mutáveis com um escopo limitado são mais fáceis de controlar 
    //e têm menor probabilidade de serem modificadas de maneira incorreta.

    //Utilizamos a key word mutable pós fixada para sinalizar que é mutável
    let mutable x = 10 //observe o sintax highlighting que mudou para laranja
    let y = 20
    let mutable z = x + y
    
    printfn "Valores Originais:"
    printfn "x: %i" x
    printfn "y: %i" y
    printfn "z: %i" z

    printfn "Mudando o valor de x"
    printfn "O valor de z irá mudar também"

    //Aqui utilizamos a seta <- para atribuir um novo valor subsequente a ele
    x <- 15
    z <- x + y

    printfn "Novos Valores:"
    printfn "x: %i" x
    printfn "y: %i" y
    printfn "z: %i" z

    0 // return an integer exit code
