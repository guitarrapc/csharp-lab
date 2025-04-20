```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.2 LTS (Noble Numbat)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.203
  [Host]            : .NET 9.0.4 (9.0.425.16305), X64 RyuJIT AVX2
  ShortRun-.NET 8.0 : .NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
  ShortRun-.NET 9.0 : .NET 9.0.4 (9.0.425.16305), X64 RyuJIT AVX2

IterationCount=3  LaunchCount=1  WarmupCount=3  

```
| Method                  | Runtime  | data     | json                | Mean        | Error      | StdDev    | Min         | Max         | Gen0   | Allocated |
|------------------------ |--------- |--------- |-------------------- |------------:|-----------:|----------:|------------:|------------:|-------:|----------:|
| **MemoryPack**              | **.NET 8.0** | **Byte[91]** | **?**                   |    **73.63 ns** |   **7.752 ns** |  **0.425 ns** |    **73.14 ns** |    **73.88 ns** | **0.0100** |     **168 B** |
| MemoryPack              | .NET 9.0 | Byte[91] | ?                   |    64.30 ns |  10.355 ns |  0.568 ns |    63.84 ns |    64.94 ns | 0.0100 |     168 B |
| **SystemTextJson**          | **.NET 8.0** | **?**        | **{&quot;Sh(...)22&quot;} [220]** | **1,195.46 ns** | **251.020 ns** | **13.759 ns** | **1,186.24 ns** | **1,211.28 ns** | **0.0095** |     **168 B** |
| SystemTextJsonSourceGen | .NET 8.0 | ?        | {&quot;Sh(...)22&quot;} [220] | 1,153.38 ns | 211.247 ns | 11.579 ns | 1,141.72 ns | 1,164.88 ns | 0.0095 |     168 B |
| SystemTextJson          | .NET 9.0 | ?        | {&quot;Sh(...)22&quot;} [220] | 1,136.00 ns |  78.791 ns |  4.319 ns | 1,131.33 ns | 1,139.84 ns | 0.0095 |     168 B |
| SystemTextJsonSourceGen | .NET 9.0 | ?        | {&quot;Sh(...)22&quot;} [220] | 1,104.79 ns |  63.039 ns |  3.455 ns | 1,101.40 ns | 1,108.31 ns | 0.0095 |     168 B |
