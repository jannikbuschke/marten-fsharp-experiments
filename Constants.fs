namespace Test

module Constants =
    let pgsqlConnectionString (db: string)=
//        Replace only the password with a real one:
        $"User ID=postgres;Password=xxx;Host=localhost;Port=5432;Database={db};Pooling=true;Connection Lifetime=0"
