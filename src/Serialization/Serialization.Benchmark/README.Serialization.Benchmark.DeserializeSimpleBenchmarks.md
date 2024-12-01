```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.404
  [Host]   : .NET 8.0.11 (8.0.1124.51707), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.11 (8.0.1124.51707), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                  | data      | json                 | Mean      | Error      | StdDev    | Min       | Max       | Gen0   | Allocated |
|------------------------ |---------- |--------------------- |----------:|-----------:|----------:|----------:|----------:|-------:|----------:|
| **MemoryPack**              | **Byte[103]** | **?**                    |  **93.82 ns** |   **6.144 ns** |  **0.337 ns** |  **93.43 ns** |  **94.02 ns** | **0.0029** |     **248 B** |
| **SystemTextJson**          | **?**         | **{&quot;X&quot;(...)\\n&quot;} [150]** | **596.28 ns** |  **50.263 ns** |  **2.755 ns** | **593.12 ns** | **598.17 ns** | **0.0029** |     **248 B** |
| SystemTextJsonSourceGen | ?         | {&quot;X&quot;(...)\\n&quot;} [150] | 595.56 ns | 268.114 ns | 14.696 ns | 586.35 ns | 612.51 ns | 0.0029 |     248 B |
