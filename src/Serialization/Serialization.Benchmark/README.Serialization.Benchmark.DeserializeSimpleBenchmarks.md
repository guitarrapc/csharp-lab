```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.1 LTS (Noble Numbat)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.101
  [Host]   : .NET 9.0.0 (9.0.24.52809), X64 RyuJIT AVX2
  ShortRun : .NET 9.0.0 (9.0.24.52809), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                  | data      | json                 | Mean     | Error    | StdDev  | Min      | Max      | Gen0   | Allocated |
|------------------------ |---------- |--------------------- |---------:|---------:|--------:|---------:|---------:|-------:|----------:|
| **MemoryPack**              | **Byte[103]** | **?**                    | **113.4 ns** | **21.90 ns** | **1.20 ns** | **112.0 ns** | **114.3 ns** | **0.0148** |     **248 B** |
| **SystemTextJson**          | **?**         | **{&quot;X&quot;(...)\\n&quot;} [150]** | **580.4 ns** | **21.70 ns** | **1.19 ns** | **579.1 ns** | **581.5 ns** | **0.0143** |     **248 B** |
| SystemTextJsonSourceGen | ?         | {&quot;X&quot;(...)\\n&quot;} [150] | 573.0 ns | 42.79 ns | 2.35 ns | 571.5 ns | 575.7 ns | 0.0143 |     248 B |
