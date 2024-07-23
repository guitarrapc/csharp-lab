```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.303
  [Host]   : .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                  | data      | json                 | Mean      | Error    | StdDev   | Min       | Max      | Gen0   | Allocated |
|------------------------ |---------- |--------------------- |----------:|---------:|---------:|----------:|---------:|-------:|----------:|
| **MemoryPack**              | **Byte[103]** | **?**                    |  **99.66 ns** | **27.00 ns** | **1.480 ns** |  **98.74 ns** | **101.4 ns** | **0.0029** |     **248 B** |
| **SystemTextJson**          | **?**         | **{&quot;X&quot;(...)\\n&quot;} [150]** | **625.59 ns** | **31.26 ns** | **1.714 ns** | **623.61 ns** | **626.6 ns** | **0.0029** |     **248 B** |
| SystemTextJsonSourceGen | ?         | {&quot;X&quot;(...)\\n&quot;} [150] | 586.72 ns | 20.45 ns | 1.121 ns | 585.74 ns | 587.9 ns | 0.0029 |     248 B |
