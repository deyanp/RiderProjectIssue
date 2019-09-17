namespace DepProj2

open BaseProj1

module Say =
    let hello name =
        BaseProj1.Say.hello "aaa"
        DepProj1.Say.hello "bbb"
        printfn "Hello %s" name
