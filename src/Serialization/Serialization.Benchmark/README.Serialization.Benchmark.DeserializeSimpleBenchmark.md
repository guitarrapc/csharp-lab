```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.303
  [Host]   : .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                  | data      | json                 | Mean      | Error     | StdDev   | Min       | Max       | Gen0   | Allocated |
|------------------------ |---------- |--------------------- |----------:|----------:|---------:|----------:|----------:|-------:|----------:|
| **MemoryPack**              | **Byte[103]** | **?**                    |  **95.03 ns** |  **9.867 ns** | **0.541 ns** |  **94.61 ns** |  **95.64 ns** | **0.0029** |     **248 B** |
| **SystemTextJson**          | **?**         | **{&quot;X&quot;(...)\\n&quot;} [150]** | **606.74 ns** | **28.243 ns** | **1.548 ns** | **605.69 ns** | **608.52 ns** | **0.0029** |     **248 B** |
| SystemTextJsonSourceGen | ?         | {&quot;X&quot;(...)\\n&quot;} [150] | 599.32 ns |  2.882 ns | 0.158 ns | 599.20 ns | 599.50 ns | 0.0029 |     248 B |
