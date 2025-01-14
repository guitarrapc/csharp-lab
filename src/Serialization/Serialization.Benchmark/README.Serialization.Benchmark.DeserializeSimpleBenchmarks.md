```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.1 LTS (Noble Numbat)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.101
  [Host]   : .NET 9.0.0 (9.0.24.52809), X64 RyuJIT AVX2
  ShortRun : .NET 9.0.0 (9.0.24.52809), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                  | data      | json                 | Mean      | Error     | StdDev   | Min       | Max       | Gen0   | Allocated |
|------------------------ |---------- |--------------------- |----------:|----------:|---------:|----------:|----------:|-------:|----------:|
| **MemoryPack**              | **Byte[103]** | **?**                    |  **88.19 ns** |  **2.492 ns** | **0.137 ns** |  **88.09 ns** |  **88.34 ns** | **0.0148** |     **248 B** |
| **SystemTextJson**          | **?**         | **{&quot;X&quot;(...)\\n&quot;} [150]** | **591.54 ns** | **31.125 ns** | **1.706 ns** | **589.59 ns** | **592.78 ns** | **0.0143** |     **248 B** |
| SystemTextJsonSourceGen | ?         | {&quot;X&quot;(...)\\n&quot;} [150] | 592.93 ns | 11.932 ns | 0.654 ns | 592.47 ns | 593.68 ns | 0.0143 |     248 B |
