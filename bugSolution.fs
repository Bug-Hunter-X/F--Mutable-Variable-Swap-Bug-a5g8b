let mutable x = 10
let mutable y = 20

let swap x y = 
    let temp = x
    x <- y
    y <- temp

printf "%d %d" x y

swap &x &y
printf "%d %d" x y