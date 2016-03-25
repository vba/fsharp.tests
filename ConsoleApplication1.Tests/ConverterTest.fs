
namespace Tests

open Xunit
open Swensen.Unquote

type ConverterTest1() =
    
    [<Fact>]
    member me.``It should convert meters to centimeters as expected``() =
        
        let actual = 1100.0<cm> |> centimetersToMeters

        test <@ actual = 11.0<m> @>

module ConverterTest2 =
    [<Fact>]
    let ``It should convert meters to feets as expected`` () =
        let actual =  32.0<m> |> metersToFeets

        test <@ actual = 104.9868766<ft> @>