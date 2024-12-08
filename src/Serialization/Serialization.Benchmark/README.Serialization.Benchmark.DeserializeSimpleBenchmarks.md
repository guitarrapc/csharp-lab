```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.404
  [Host]   : .NET 8.0.11 (8.0.1124.51707), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.11 (8.0.1124.51707), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                  | data      | json                 | Mean     | Error    | StdDev  | Min      | Max      | Gen0   | Allocated |
|------------------------ |---------- |--------------------- |---------:|---------:|--------:|---------:|---------:|-------:|----------:|
| **MemoryPack**              | **Byte[103]** | **?**                    | **102.3 ns** | **12.36 ns** | **0.68 ns** | **101.7 ns** | **103.1 ns** | **0.0029** |     **248 B** |
| **SystemTextJson**          | **?**         | **{&quot;X&quot;(...)\\n&quot;} [150]** | **616.0 ns** | **27.31 ns** | **1.50 ns** | **614.8 ns** | **617.7 ns** | **0.0029** |     **248 B** |
| SystemTextJsonSourceGen | ?         | {&quot;X&quot;(...)\\n&quot;} [150] | 592.1 ns | 31.82 ns | 1.74 ns | 591.0 ns | 594.1 ns | 0.0029 |     248 B |
