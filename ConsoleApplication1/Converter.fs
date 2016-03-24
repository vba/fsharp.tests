

[<AutoOpen>]
module DistanceUnits

[<Measure>] type m
[<Measure>] type cm
[<Measure>] type inch
[<Measure>] type ft


let mPerCm : float<m/cm> = 0.01<m/cm>
let cmPerInch : float<cm/inch> = 2.54<cm/inch>
let inchPerFeet: float<inch/ft> = 12.0<inch/ft>

let metersToCentimeters (x: float<m>) = x / mPerCm
let centimetersToInches (x: float<cm>) = x / cmPerInch
let inchesToFeets (x:float<inch>) = x / inchPerFeet

let centimetersToMeters: float<cm> -> float<m> = (*) mPerCm
let inchesToCentimeters: float<inch> -> float<cm> = (*) cmPerInch
let metersToInches: float<m> -> float<inch> = metersToCentimeters >> centimetersToInches
let metersToFeets: float<m> -> float<ft> =  metersToInches >> inchesToFeets
let feetsToInches: float<ft> -> float<inch> = (*) inchPerFeet
