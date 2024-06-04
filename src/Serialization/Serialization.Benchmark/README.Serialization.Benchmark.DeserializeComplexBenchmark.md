```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.301
  [Host]   : .NET 8.0.6 (8.0.624.26715), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.6 (8.0.624.26715), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                  | data     | json                | Mean        | Error        | StdDev    | Min       | Max         | Gen0   | Allocated |
|------------------------ |--------- |-------------------- |------------:|-------------:|----------:|----------:|------------:|-------:|----------:|
| **MemoryPack**              | **Byte[89]** | **?**                   |    **52.41 ns** |     **1.926 ns** |  **0.106 ns** |  **52.31 ns** |    **52.52 ns** | **0.0012** |     **104 B** |
| **SystemTextJson**          | **?**        | **{&quot;Gn(...)&quot;:0} [182]** | **1,039.67 ns** | **1,238.845 ns** | **67.905 ns** | **996.31 ns** | **1,117.93 ns** |      **-** |     **104 B** |
| SystemTextJsonSourceGen | ?        | {&quot;Gn(...)&quot;:0} [182] |   937.71 ns |     4.566 ns |  0.250 ns | 937.53 ns |   937.99 ns |      - |     104 B |
