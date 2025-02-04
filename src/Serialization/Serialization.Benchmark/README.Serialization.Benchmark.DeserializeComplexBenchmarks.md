```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.1 LTS (Noble Numbat)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.102
  [Host]   : .NET 9.0.1 (9.0.124.61010), X64 RyuJIT AVX2
  ShortRun : .NET 9.0.1 (9.0.124.61010), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                  | data     | json                | Mean      | Error     | StdDev    | Min       | Max       | Gen0   | Allocated |
|------------------------ |--------- |-------------------- |----------:|----------:|----------:|----------:|----------:|-------:|----------:|
| **MemoryPack**              | **Byte[89]** | **?**                   |  **43.59 ns** |  **19.78 ns** |  **1.084 ns** |  **42.42 ns** |  **44.55 ns** | **0.0062** |     **104 B** |
| **SystemTextJson**          | **?**        | **{&quot;Gn(...)&quot;:0} [182]** | **947.73 ns** | **246.48 ns** | **13.510 ns** | **936.95 ns** | **962.88 ns** | **0.0057** |     **104 B** |
| SystemTextJsonSourceGen | ?        | {&quot;Gn(...)&quot;:0} [182] | 926.58 ns |  72.28 ns |  3.962 ns | 923.64 ns | 931.09 ns | 0.0057 |     104 B |
