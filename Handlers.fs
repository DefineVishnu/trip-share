module Trip.Share.Api.Handlers
open Microsoft.AspNetCore.Http
open Giraffe

    let GetAllTripsTaskHandler (next :HttpFunc) (ctx : HttpContext) = 
        task {
            return!json [|0;1;2;|] next ctx
        }