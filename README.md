WebStrings
==========

- Headers, Methods, and Media Types are scattered all over the .NET Framework and Microsoft NuGet packages.
- These implementations often differ on platform, making it difficult to know which settings are located where.
- This small project is meant to polyfill the main classes, `HeaderNames`, `MediaTypeNames`, and `HttpMethods` into a single location.