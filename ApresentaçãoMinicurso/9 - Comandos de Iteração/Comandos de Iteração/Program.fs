//Maycon Lutz e William Simionatto
//F#

open System

[<EntryPoint>]
let main argv =
    
    //Não encontrei algo para organizar o código F#, semelhante a #regions no c#, mas abaixo temos separação dos loops

    //-------------------------------------------------------------------------------------------------
    //Loop For
    //-------------------------------------------------------------------------------------------------

    //Um simples loop for...to.
    let function1() =       //A função function1 contém um loop for..to e alguns prints
        for i = 1 to 10 do  //Loop for de 1 até 10
            printf "%d" i   //Print os valores de i
            if i < 10 then  //Condição para que somente print a vírgula quando menor que o valor máximo do loop for...to
                printf ", "
    
    //Um loop for...to que conta reversamente.
    let function2() =          //A função function1 contém um loop for..downto e alguns prints
        for i = 10 downto 1 do //Loop for de 10 até 1
            printf "%d" i      //Print os valores de i
            if i > 1 then      //Condição para que somente print a vírgula quando menor que o valor máximo do loop for...to
                printf ", "
    
    printfn "Loop for...to:" 
    function1()                 //Chama função do loop for...to
    printfn "\n"
    printfn "Loop for...downto:"
    function2()                 //Chama função do loop for...downto
    printfn "\n"

    //Um loop for...to loop que usa as funções para inicio e fim.
    let beginning x y = x - 2*y  //A função beginning tem o argumento 1 x do tipo int, e o argumento 2 y do tipo int e retorna um int
    let ending x y = x + 2*y     //A função ending tem o argumento 1 x do tipo int, e o argumento 2 y do tipo int e retorna um int
    
    let function3 x y =                             //A função function1 tem o argumento 1 x do tipo int, e o argumento 2 y do tipo int
        for i = (beginning x y) to (ending x y) do  //Loop for...to de incio chamando a função beginning enviando o argumento x e y da function3 e 
            printf "%d " i                          //de fim chamando a função ending enviando o argumento x e y da function3 e 
        printfn ""

    printfn "Loop for...to com funções:"
    function3 10 4  //Chama função do loop for...to com funções
    printfn ""

    //-------------------------------------------------------------------------------------------------
    //Loop While Do
    //-------------------------------------------------------------------------------------------------
    let lookForValue value maxValue =                       //A função lookForValue tem o argumento 1 x do tipo int, e o argumento 2 y do tipo int
      let mutable continueLooping = true                    //Flag de condição do while
      let randomNumberGenerator = new Random()              //cria e instância randomNumberGenerator para objeto de número aleatório
      while continueLooping do                              //Início do loop
        // Generate a random number between 1 and maxValue. //
        let rand = randomNumberGenerator.Next(maxValue)     //A cada iteração do loop while a variável "rand" recebe um número aleatótio com valor mínimo 1 e máximo da variável maxValue
        printf "%d " rand
        if rand = value then                                //Verifica se o valor gerado aleatóriamente é igual o número recebido em value
           printfn "\nEncontrou o %d!" value                    //Entra aqui quando encontrou um valor
           continueLooping <- false                         //Termina o loop while...do

    printfn "Loop while...do procura número"
    lookForValue 10 20 //Chama função lookForValue que contém um loop while...do que procura um número fixo por meio de um objeto que gera número aleatório.

    0 // retorna um int com valor do código de encerrar programa.


//referências de base para código:
    //https://docs.microsoft.com/pt-br/dotnet/fsharp/language-reference/loops-for-to-expression
    //https://docs.microsoft.com/pt-br/dotnet/fsharp/language-reference/loops-while-do-expression