Create 4 pgsql databases:
- marten.json.default
- marten.json.stj
- marten.json.fsstj
- marten.json.fsstj-custom

Put your pgsql credentials in Constants.fs

run `dotnet test`


Note: some tests will fail, as one json serializer cannot handle certain fsharp types.
