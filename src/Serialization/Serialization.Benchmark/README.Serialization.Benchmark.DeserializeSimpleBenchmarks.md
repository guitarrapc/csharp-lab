```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.1 LTS (Noble Numbat)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.200
  [Host]            : .NET 9.0.2 (9.0.225.6610), X64 RyuJIT AVX2
  ShortRun-.NET 8.0 : .NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
  ShortRun-.NET 9.0 : .NET 9.0.2 (9.0.225.6610), X64 RyuJIT AVX2

IterationCount=3  LaunchCount=1  WarmupCount=3  

```
| Method                  | Runtime  | data      | json                 | Mean      | Error     | StdDev   | Min       | Max       | Gen0   | Allocated |
|------------------------ |--------- |---------- |--------------------- |----------:|----------:|---------:|----------:|----------:|-------:|----------:|
| **MemoryPack**              | **.NET 8.0** | **Byte[103]** | **?**                    |  **94.20 ns** |  **27.18 ns** | **1.490 ns** |  **92.50 ns** |  **95.24 ns** | **0.0148** |     **248 B** |
| MemoryPack              | .NET 9.0 | Byte[103] | ?                    |  87.86 ns |  25.51 ns | 1.398 ns |  86.63 ns |  89.38 ns | 0.0148 |     248 B |
| **SystemTextJson**          | **.NET 8.0** | **?**         | **{&quot;X&quot;(...)\\n&quot;} [150]** | **623.80 ns** | **147.57 ns** | **8.089 ns** | **617.38 ns** | **632.89 ns** | **0.0143** |     **248 B** |
| SystemTextJsonSourceGen | .NET 8.0 | ?         | {&quot;X&quot;(...)\\n&quot;} [150] | 589.53 ns |  29.24 ns | 1.603 ns | 587.71 ns | 590.73 ns | 0.0143 |     248 B |
| SystemTextJson          | .NET 9.0 | ?         | {&quot;X&quot;(...)\\n&quot;} [150] | 587.52 ns |  39.82 ns | 2.183 ns | 586.07 ns | 590.03 ns | 0.0143 |     248 B |
| SystemTextJsonSourceGen | .NET 9.0 | ?         | {&quot;X&quot;(...)\\n&quot;} [150] | 603.64 ns |  41.18 ns | 2.257 ns | 601.04 ns | 605.09 ns | 0.0143 |     248 B |
