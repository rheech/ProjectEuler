// Learn more about F# at http://fsharp.net
// See the 'F# Tutorial' project for more help.

let foo n =
    n * n + n + 41

[<EntryPoint>]
let main argv = 
    for i in 1 .. 50 do
        let x = foo(i)
        printfn "x: %d" x

    0 // return an integer exit code
