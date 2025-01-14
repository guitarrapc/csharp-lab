```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.1 LTS (Noble Numbat)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.101
  [Host]   : .NET 9.0.0 (9.0.24.52809), X64 RyuJIT AVX2
  ShortRun : .NET 9.0.0 (9.0.24.52809), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                  | data     | json                | Mean      | Error     | StdDev    | Min       | Max       | Gen0   | Allocated |
|------------------------ |--------- |-------------------- |----------:|----------:|----------:|----------:|----------:|-------:|----------:|
| **MemoryPack**              | **Byte[89]** | **?**                   |  **42.45 ns** |  **12.06 ns** |  **0.661 ns** |  **41.96 ns** |  **43.20 ns** | **0.0062** |     **104 B** |
| **SystemTextJson**          | **?**        | **{&quot;Gn(...)&quot;:0} [182]** | **953.94 ns** | **311.65 ns** | **17.083 ns** | **937.23 ns** | **971.37 ns** | **0.0057** |     **104 B** |
| SystemTextJsonSourceGen | ?        | {&quot;Gn(...)&quot;:0} [182] | 918.45 ns |  10.61 ns |  0.582 ns | 918.09 ns | 919.12 ns | 0.0057 |     104 B |
