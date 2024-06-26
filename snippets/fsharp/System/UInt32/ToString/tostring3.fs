﻿module tostring3

// <Snippet3>
let value = 2179608u
let specifiers = 
    [| "G"; "C"; "D3"; "E2"; "e3"; "F" 
       "N"; "P"; "X"; "000000.0"; "#.0" 
       "00000000(0)**Zero**" |]

for specifier in specifiers do
    printfn $"{specifier}: {value.ToString specifier}"
// The example displays the following output:
//       G: 2179608
//       C: $2,179,608.00
//       D3: 2179608
//       E2: 2.18E+006
//       e3: 2.180e+006
//       F: 2179608.00
//       N: 2,179,608.00
//       P: 217,960,800.00 %
//       X: 214218
//       000000.0: 2179608.0
//       #.0: 2179608.0
//       00000000(0)**Zero**: 02179608
// </Snippet3>