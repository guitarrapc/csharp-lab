```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.203
  [Host]   : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                  | data      | json                 | Mean     | Error    | StdDev  | Min       | Max      | Gen0   | Allocated |
|------------------------ |---------- |--------------------- |---------:|---------:|--------:|----------:|---------:|-------:|----------:|
| **MemoryPack**              | **Byte[103]** | **?**                    | **102.3 ns** | **85.26 ns** | **4.67 ns** |  **96.92 ns** | **105.1 ns** | **0.0029** |     **248 B** |
| **SystemTextJson**          | **?**         | **{&quot;X&quot;(...)\\n&quot;} [150]** | **608.1 ns** | **34.43 ns** | **1.89 ns** | **606.67 ns** | **610.2 ns** | **0.0029** |     **248 B** |
| SystemTextJsonSourceGen | ?         | {&quot;X&quot;(...)\\n&quot;} [150] | 591.9 ns | 19.43 ns | 1.06 ns | 590.95 ns | 593.1 ns | 0.0029 |     248 B |
