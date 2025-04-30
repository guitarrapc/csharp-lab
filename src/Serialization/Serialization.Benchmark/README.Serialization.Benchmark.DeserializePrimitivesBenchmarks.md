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
| **MemoryPack**              | **.NET 8.0** | **Byte[91]** | **?**                   |    **72.20 ns** |   **8.072 ns** |  **0.442 ns** |    **71.80 ns** |    **72.68 ns** | **0.0100** |     **168 B** |
| MemoryPack              | .NET 9.0 | Byte[91] | ?                   |    63.93 ns |  10.418 ns |  0.571 ns |    63.27 ns |    64.28 ns | 0.0100 |     168 B |
| **SystemTextJson**          | **.NET 8.0** | **?**        | **{&quot;Sh(...)22&quot;} [220]** | **1,191.23 ns** |  **59.637 ns** |  **3.269 ns** | **1,189.07 ns** | **1,194.99 ns** | **0.0095** |     **168 B** |
| SystemTextJsonSourceGen | .NET 8.0 | ?        | {&quot;Sh(...)22&quot;} [220] | 1,162.22 ns |  96.110 ns |  5.268 ns | 1,158.39 ns | 1,168.23 ns | 0.0095 |     168 B |
| SystemTextJson          | .NET 9.0 | ?        | {&quot;Sh(...)22&quot;} [220] | 1,190.84 ns | 804.318 ns | 44.087 ns | 1,161.62 ns | 1,241.55 ns | 0.0095 |     168 B |
| SystemTextJsonSourceGen | .NET 9.0 | ?        | {&quot;Sh(...)22&quot;} [220] | 1,108.69 ns | 118.350 ns |  6.487 ns | 1,104.90 ns | 1,116.18 ns | 0.0095 |     168 B |
