```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.401
  [Host]   : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                  | data      | json                 | Mean     | Error     | StdDev  | Min      | Max      | Gen0   | Allocated |
|------------------------ |---------- |--------------------- |---------:|----------:|--------:|---------:|---------:|-------:|----------:|
| **MemoryPack**              | **Byte[103]** | **?**                    | **100.4 ns** |   **5.18 ns** | **0.28 ns** | **100.1 ns** | **100.7 ns** | **0.0029** |     **248 B** |
| **SystemTextJson**          | **?**         | **{&quot;X&quot;(...)\\n&quot;} [150]** | **626.8 ns** | **181.25 ns** | **9.93 ns** | **621.0 ns** | **638.3 ns** | **0.0029** |     **248 B** |
| SystemTextJsonSourceGen | ?         | {&quot;X&quot;(...)\\n&quot;} [150] | 615.6 ns |  47.54 ns | 2.61 ns | 613.4 ns | 618.5 ns | 0.0029 |     248 B |
