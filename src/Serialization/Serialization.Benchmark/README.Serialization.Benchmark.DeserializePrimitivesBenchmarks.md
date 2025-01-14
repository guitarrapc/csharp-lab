```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.1 LTS (Noble Numbat)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.101
  [Host]   : .NET 9.0.0 (9.0.24.52809), X64 RyuJIT AVX2
  ShortRun : .NET 9.0.0 (9.0.24.52809), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                  | data     | json                | Mean        | Error    | StdDev   | Min         | Max         | Gen0   | Allocated |
|------------------------ |--------- |-------------------- |------------:|---------:|---------:|------------:|------------:|-------:|----------:|
| **MemoryPack**              | **Byte[91]** | **?**                   |    **66.59 ns** | **14.14 ns** | **0.775 ns** |    **65.95 ns** |    **67.46 ns** | **0.0100** |     **168 B** |
| **SystemTextJson**          | **?**        | **{&quot;Sh(...)22&quot;} [220]** | **1,129.90 ns** | **10.91 ns** | **0.598 ns** | **1,129.26 ns** | **1,130.44 ns** | **0.0095** |     **168 B** |
| SystemTextJsonSourceGen | ?        | {&quot;Sh(...)22&quot;} [220] | 1,139.17 ns | 66.99 ns | 3.672 ns | 1,135.74 ns | 1,143.04 ns | 0.0095 |     168 B |
