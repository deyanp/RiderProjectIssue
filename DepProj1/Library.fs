namespace DepProj1

open BaseProj1

module Say =
    let hello name =
        BaseProj1.Say.hello "aaa"
        printfn "Hello %s" name
