#load "ASS2.fs"
open ASS2

let zero = fun f -> (fun x -> x)

let one = fun f -> (fun x -> (f x))

let two = fun f -> (fun x -> (f (f x)))

let showcn cn = (cn (fun n -> n + 1)) 0

let r1 = showcn one

let r2 = showcn two

let succ cn =  (fun f -> (fun x -> f ((cn f) x)))

let r3 = showcn (succ two)

let add n m = fun f -> (fun x -> ((n f) ((m f) x)))

let times n m = fun f -> (fun x -> (n (m f) x))

let exp n m = fun f -> (fun x -> (m n) f x)



fun x -> x + 1
fun a b c -> printfn "%A %A %A" a b c
fun (a: int) (b: int) (c: int) -> a + b * c
fun x y -> let swap (a, b) = (b, a) in swap (x, y)

