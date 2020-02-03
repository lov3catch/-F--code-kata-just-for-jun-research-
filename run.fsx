// #load "/Users/ihor.kpl/Code/my-fsharp/.paket/load/netcoreapp3.0/Hopac.fsx" 
// #r "/Users/ihor.kpl/.nuget/packages/http.fs/5.3.0/lib/netstandard2.0/HttpFs.dll" 
#r "/Users/ihor.kpl/.nuget/packages/fsharp.data/3.3.2/lib/netstandard2.0/FSharp.Data.dll"

open FSharp.Data
// open Hopac
// open HttpFs.Client

// let results = HtmlDocument.Load("http://zaycev.net")
// let links = 
  // resul
let results = HtmlDocument.Load("https://zaycev.net/search.html?query_search=hardkiss")
let links = results.Descendants  ["a"] |> Seq.choose (fun x -> x.TryGetAttribute("href") |> Option.map (fun a -> "aaa", x.InnerText(), a.Value))
printfn "%A" (Seq.toList links |> List.map (fun x -> x));

let chars = ["a"; "b"; "c"]

chars
  |> List.map (fun x->printf "%A" x)
  // |> printf "%A"


let liters = [1 ..90]
liters
  |> List.map (fun x->printf "%A" x)
  // |> printf "%A"

let myMin = List.min [1 .. 100]
let myMax = List.max [1 .. 100]

let myStr = "as"

printf "%A %A" myMin myMax

List.tail [1 .. 100]

type Group (id:int) = 
  member x.id = id  

let group = new Group(11)

let add (x:int) (y:int) = x + y
let square x:int = x * x

let result = (add 2 4) |> square
  // |> square

let songer = "hardkiss1";

let isOk =
  match songer with
    | "hardkiss" -> "ok"
    | "leningrad" -> "not ok"
    | _ -> "fail"

printf "%A" isOk

let padd x y = x + y
let myPadd = padd 1
myPadd 2

printf "%A" myPadd




