```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.101
  [Host]   : .NET 9.0.0 (9.0.24.52809), X64 RyuJIT AVX2
  ShortRun : .NET 9.0.0 (9.0.24.52809), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                  | data      | json                 | Mean     | Error    | StdDev  | Min      | Max      | Gen0   | Allocated |
|------------------------ |---------- |--------------------- |---------:|---------:|--------:|---------:|---------:|-------:|----------:|
| **MemoryPack**              | **Byte[103]** | **?**                    | **107.9 ns** | **12.30 ns** | **0.67 ns** | **107.4 ns** | **108.7 ns** | **0.0029** |     **248 B** |
| **SystemTextJson**          | **?**         | **{&quot;X&quot;(...)\\n&quot;} [150]** | **567.8 ns** | **11.40 ns** | **0.62 ns** | **567.1 ns** | **568.3 ns** | **0.0029** |     **248 B** |
| SystemTextJsonSourceGen | ?         | {&quot;X&quot;(...)\\n&quot;} [150] | 575.9 ns |  6.49 ns | 0.36 ns | 575.5 ns | 576.2 ns | 0.0029 |     248 B |
