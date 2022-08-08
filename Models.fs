module Trip.Share.Models

        open System
        [<CLIMutable>]
        type TripEntity=
            {
                Id:Guid
                Name:string
            }