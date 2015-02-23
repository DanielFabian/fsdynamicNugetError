
#r @"..\packages\FSharp.InteropServices.Dynamic.0.0.2-alpha\lib\net45\FSharp.InteropServices.Dynamic.dll"

open FSharp.InteropServices.Dynamic

let cudnn = Library(@"L:\cudnn\cudnn64_65.dll")

printfn "%s" (cudnn?cudnnGetVersion())