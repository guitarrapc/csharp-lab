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
| **MemoryPack**              | **.NET 8.0** | **Byte[91]** | **?**                   |    **70.97 ns** |  **6.307 ns** | **0.346 ns** |    **70.58 ns** |    **71.23 ns** | **0.0100** |     **168 B** |
| MemoryPack              | .NET 9.0 | Byte[91] | ?                   |    64.31 ns | 13.632 ns | 0.747 ns |    63.67 ns |    65.13 ns | 0.0100 |     168 B |
| **SystemTextJson**          | **.NET 8.0** | **?**        | **{&quot;Sh(...)22&quot;} [220]** | **1,195.35 ns** | **16.147 ns** | **0.885 ns** | **1,194.55 ns** | **1,196.30 ns** | **0.0095** |     **168 B** |
| SystemTextJsonSourceGen | .NET 8.0 | ?        | {&quot;Sh(...)22&quot;} [220] | 1,138.89 ns | 69.312 ns | 3.799 ns | 1,134.82 ns | 1,142.34 ns | 0.0095 |     168 B |
| SystemTextJson          | .NET 9.0 | ?        | {&quot;Sh(...)22&quot;} [220] | 1,142.91 ns | 33.575 ns | 1.840 ns | 1,141.68 ns | 1,145.03 ns | 0.0095 |     168 B |
| SystemTextJsonSourceGen | .NET 9.0 | ?        | {&quot;Sh(...)22&quot;} [220] | 1,102.07 ns | 28.498 ns | 1.562 ns | 1,100.27 ns | 1,103.04 ns | 0.0095 |     168 B |
