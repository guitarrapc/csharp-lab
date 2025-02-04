```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.1 LTS (Noble Numbat)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.102
  [Host]   : .NET 9.0.1 (9.0.124.61010), X64 RyuJIT AVX2
  ShortRun : .NET 9.0.1 (9.0.124.61010), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                  | data     | json                | Mean        | Error     | StdDev    | Min         | Max         | Gen0   | Allocated |
|------------------------ |--------- |-------------------- |------------:|----------:|----------:|------------:|------------:|-------:|----------:|
| **MemoryPack**              | **Byte[91]** | **?**                   |    **66.30 ns** |  **10.84 ns** |  **0.594 ns** |    **65.72 ns** |    **66.91 ns** | **0.0100** |     **168 B** |
| **SystemTextJson**          | **?**        | **{&quot;Sh(...)22&quot;} [220]** | **1,144.74 ns** | **185.58 ns** | **10.172 ns** | **1,138.54 ns** | **1,156.48 ns** | **0.0095** |     **168 B** |
| SystemTextJsonSourceGen | ?        | {&quot;Sh(...)22&quot;} [220] | 1,097.69 ns |  63.41 ns |  3.476 ns | 1,095.54 ns | 1,101.70 ns | 0.0095 |     168 B |
