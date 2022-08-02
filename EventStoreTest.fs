namespace Test

module EventStore =

    type User = {
        Id: System.Guid
        Name: string
    }
    type Group = {
        Id: System.Guid
        Name: string
    }
    type Principal = User of User | Group of Group

    type Status =
        | Draft
        | Scheduled
        | Archived

    type MeetingId = MeetingId of System.Guid

    type MeetingCreated = { Id: System.Guid; Owner: Principal }

    type Meeting() =
        member val Id = Unchecked.defaultof<System.Guid> with get, set
        member val Stauts = Status.Draft with get, set
        member val Owner = Unchecked.defaultof<Principal> with get,set

        member this.Apply(e: MeetingCreated) =
            this.Id <- e.Id
            this.Owner <- e.Owner
