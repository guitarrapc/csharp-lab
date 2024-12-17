```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.101
  [Host]   : .NET 9.0.0 (9.0.24.52809), X64 RyuJIT AVX2
  ShortRun : .NET 9.0.0 (9.0.24.52809), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                  | data      | json                 | Mean      | Error    | StdDev   | Min       | Max       | Gen0   | Allocated |
|------------------------ |---------- |--------------------- |----------:|---------:|---------:|----------:|----------:|-------:|----------:|
| **MemoryPack**              | **Byte[103]** | **?**                    |  **91.60 ns** | **12.11 ns** | **0.664 ns** |  **90.92 ns** |  **92.24 ns** | **0.0029** |     **248 B** |
| **SystemTextJson**          | **?**         | **{&quot;X&quot;(...)\\n&quot;} [150]** | **578.22 ns** | **21.96 ns** | **1.204 ns** | **577.48 ns** | **579.61 ns** | **0.0029** |     **248 B** |
| SystemTextJsonSourceGen | ?         | {&quot;X&quot;(...)\\n&quot;} [150] | 571.16 ns | 34.02 ns | 1.864 ns | 569.93 ns | 573.31 ns | 0.0029 |     248 B |
