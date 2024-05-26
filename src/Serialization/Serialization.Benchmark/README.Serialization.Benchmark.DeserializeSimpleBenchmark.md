```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.300
  [Host]   : .NET 8.0.5 (8.0.524.21615), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.5 (8.0.524.21615), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                  | data      | json                 | Mean      | Error     | StdDev   | Min       | Max       | Gen0   | Allocated |
|------------------------ |---------- |--------------------- |----------:|----------:|---------:|----------:|----------:|-------:|----------:|
| **MemoryPack**              | **Byte[103]** | **?**                    |  **95.38 ns** |  **3.330 ns** | **0.183 ns** |  **95.21 ns** |  **95.57 ns** | **0.0029** |     **248 B** |
| **SystemTextJson**          | **?**         | **{&quot;X&quot;(...)\\n&quot;} [150]** | **609.36 ns** | **10.835 ns** | **0.594 ns** | **608.82 ns** | **609.99 ns** | **0.0029** |     **248 B** |
| SystemTextJsonSourceGen | ?         | {&quot;X&quot;(...)\\n&quot;} [150] | 592.03 ns | 25.152 ns | 1.379 ns | 590.52 ns | 593.21 ns | 0.0029 |     248 B |
