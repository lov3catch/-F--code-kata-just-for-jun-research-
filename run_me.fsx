let data = "One for Alice, one for me.".Split " "

let x = match data.[2] with
    | "Alice," -> "ok"
    | _ -> "not ok"

printf "%A" data.[2]
printf "%A" x

// let myfunc (a:int) = "AA"

// printf "%A" (myfunc 11)

let example = [yield 5; yield 10]
