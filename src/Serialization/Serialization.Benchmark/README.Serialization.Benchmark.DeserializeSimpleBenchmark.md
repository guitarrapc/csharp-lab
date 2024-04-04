```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.203
  [Host]   : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                  | data      | json                 | Mean     | Error   | StdDev  | Min      | Max      | Gen0   | Allocated |
|------------------------ |---------- |--------------------- |---------:|--------:|--------:|---------:|---------:|-------:|----------:|
| **MemoryPack**              | **Byte[103]** | **?**                    | **111.7 ns** | **5.99 ns** | **0.33 ns** | **111.6 ns** | **112.1 ns** | **0.0029** |     **248 B** |
| **SystemTextJson**          | **?**         | **{&quot;X&quot;(...)\\n&quot;} [150]** | **614.5 ns** | **2.67 ns** | **0.15 ns** | **614.4 ns** | **614.7 ns** | **0.0029** |     **248 B** |
| SystemTextJsonSourceGen | ?         | {&quot;X&quot;(...)\\n&quot;} [150] | 592.8 ns | 4.87 ns | 0.27 ns | 592.5 ns | 593.1 ns | 0.0029 |     248 B |
