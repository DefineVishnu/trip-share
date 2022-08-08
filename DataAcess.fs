module Trip.Share.DataAcess
open Microsoft.EntityFrameworkCore
open Models

type  TripShareDbContext() =
    inherit DbContext()

    [<DefaultValue>]
    val mutable Trip:DbSet<TripEntity>
    member x.Labels 
        with get() = x.Trip 
        and set v = x.Trip <- v

     override __.OnConfiguring(optionsBuilder : DbContextOptionsBuilder) =
        optionsBuilder.UseSqlite()
        |> ignore
