```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.1 LTS (Noble Numbat)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.200
  [Host]            : .NET 9.0.2 (9.0.225.6610), X64 RyuJIT AVX2
  ShortRun-.NET 8.0 : .NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
  ShortRun-.NET 9.0 : .NET 9.0.2 (9.0.225.6610), X64 RyuJIT AVX2

IterationCount=3  LaunchCount=1  WarmupCount=3  

```
| Method                  | Runtime  | data     | json                | Mean        | Error     | StdDev   | Min         | Max         | Gen0   | Allocated |
|------------------------ |--------- |--------- |-------------------- |------------:|----------:|---------:|------------:|------------:|-------:|----------:|
| **MemoryPack**              | **.NET 8.0** | **Byte[91]** | **?**                   |    **79.50 ns** |  **17.20 ns** | **0.943 ns** |    **78.50 ns** |    **80.37 ns** | **0.0100** |     **168 B** |
| MemoryPack              | .NET 9.0 | Byte[91] | ?                   |    66.54 ns |  10.09 ns | 0.553 ns |    65.96 ns |    67.06 ns | 0.0100 |     168 B |
| **SystemTextJson**          | **.NET 8.0** | **?**        | **{&quot;Sh(...)22&quot;} [220]** | **1,186.22 ns** |  **78.84 ns** | **4.321 ns** | **1,183.15 ns** | **1,191.16 ns** | **0.0095** |     **168 B** |
| SystemTextJsonSourceGen | .NET 8.0 | ?        | {&quot;Sh(...)22&quot;} [220] | 1,145.77 ns | 119.07 ns | 6.527 ns | 1,141.42 ns | 1,153.27 ns | 0.0095 |     168 B |
| SystemTextJson          | .NET 9.0 | ?        | {&quot;Sh(...)22&quot;} [220] | 1,142.18 ns |  57.90 ns | 3.174 ns | 1,139.51 ns | 1,145.69 ns | 0.0095 |     168 B |
| SystemTextJsonSourceGen | .NET 9.0 | ?        | {&quot;Sh(...)22&quot;} [220] | 1,120.98 ns |  58.60 ns | 3.212 ns | 1,117.37 ns | 1,123.51 ns | 0.0095 |     168 B |
