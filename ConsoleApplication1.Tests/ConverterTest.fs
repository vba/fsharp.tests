
namespace Tests

open Xunit
open Swensen.Unquote

type ConverterTest1() =
    
    [<Fact>]
    member me.``It should convert meters to centimeters as expected``() =
        
        let actual = 1100.0<cm> |> centimetersToMeters

        test <@ actual = 11.0<m> @>

    [<Fact>]
    member me.``It should convert centimeters to meters as expected``() =
        let actual = 20.0<m> |> metersToCentimeters

        test <@ actual = 2000.00<cm> @>

module ConverterTest2 =
    open System
    [<Fact>]
    let ``It should convert meters to feets as expected`` () =
        let actual =  32.0<m> |> metersToFeets

        test <@ actual = 104.98687664041995<ft> @>

    [<Fact>]
    let ``It should fail when rubbish conversion is attempted`` () =
        raises<InvalidOperationException> <@ metersToHours 2.0<m> @>