```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.2 LTS (Noble Numbat)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.203
  [Host]            : .NET 9.0.4 (9.0.425.16305), X64 RyuJIT AVX2
  ShortRun-.NET 8.0 : .NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
  ShortRun-.NET 9.0 : .NET 9.0.4 (9.0.425.16305), X64 RyuJIT AVX2

IterationCount=3  LaunchCount=1  WarmupCount=3  

```
| Method                  | Runtime  | data     | json                | Mean        | Error     | StdDev   | Min         | Max         | Gen0   | Allocated |
|------------------------ |--------- |--------- |-------------------- |------------:|----------:|---------:|------------:|------------:|-------:|----------:|
| **MemoryPack**              | **.NET 8.0** | **Byte[91]** | **?**                   |    **73.17 ns** |  **23.45 ns** | **1.285 ns** |    **71.80 ns** |    **74.36 ns** | **0.0100** |     **168 B** |
| MemoryPack              | .NET 9.0 | Byte[91] | ?                   |    65.27 ns |  14.53 ns | 0.796 ns |    64.39 ns |    65.93 ns | 0.0100 |     168 B |
| **SystemTextJson**          | **.NET 8.0** | **?**        | **{&quot;Sh(...)22&quot;} [220]** | **1,164.73 ns** | **128.91 ns** | **7.066 ns** | **1,160.43 ns** | **1,172.88 ns** | **0.0095** |     **168 B** |
| SystemTextJsonSourceGen | .NET 8.0 | ?        | {&quot;Sh(...)22&quot;} [220] | 1,144.01 ns | 104.75 ns | 5.742 ns | 1,138.39 ns | 1,149.86 ns | 0.0095 |     168 B |
| SystemTextJson          | .NET 9.0 | ?        | {&quot;Sh(...)22&quot;} [220] | 1,140.83 ns | 101.20 ns | 5.547 ns | 1,135.91 ns | 1,146.84 ns | 0.0095 |     168 B |
| SystemTextJsonSourceGen | .NET 9.0 | ?        | {&quot;Sh(...)22&quot;} [220] | 1,117.74 ns |  64.62 ns | 3.542 ns | 1,115.17 ns | 1,121.78 ns | 0.0095 |     168 B |
