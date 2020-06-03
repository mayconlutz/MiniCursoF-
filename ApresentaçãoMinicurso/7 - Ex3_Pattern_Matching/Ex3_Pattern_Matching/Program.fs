// Learn more about F# at http://fsharp.org

open System

[<EntryPoint>]
let main argv =
    

    //A correspondência de padrões permite "comparar dados com uma estrutura ou 
    //estruturas lógicas, decompor dados em partes constituintes ou extrair informações 
    //de dados de várias maneiras".
    
    //Em outros termos, fornece uma maneira mais flexível e poderosa de testar dados
    //em relação a uma série de condições e executar alguns cálculos com base na 
    //condição atendida.
       
    //Conceitualmente, é como uma série de declarações if… then.


    //Você também pode encadear várias condições, que retornam o mesmo valor.

    let printSeason month =
       match month with
       | "December" | "January" | "February" -> printfn "Winter"
       | "March" | "April" -> printfn "Spring"
       | "May" | "June" -> printfn "Summer"
       | "July" | "August" -> printfn "Rainy"
       | "September" | "October" | "November" -> printfn "Autumn"
       | _ -> printfn "Season depends on month!"

    printSeason "February"
    printSeason "April"
    printSeason "November"
    printSeason "July"
    
    0 // return an integer exit code
