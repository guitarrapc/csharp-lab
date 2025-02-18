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
| **MemoryPack**              | **.NET 8.0** | **Byte[103]** | **?**                    |  **89.73 ns** |  **1.327 ns** | **0.073 ns** |  **89.69 ns** |  **89.82 ns** | **0.0148** |     **248 B** |
| MemoryPack              | .NET 9.0 | Byte[103] | ?                    |  82.79 ns | 18.913 ns | 1.037 ns |  81.93 ns |  83.94 ns | 0.0148 |     248 B |
| **SystemTextJson**          | **.NET 8.0** | **?**         | **{&quot;X&quot;(...)\\n&quot;} [150]** | **664.12 ns** |  **3.007 ns** | **0.165 ns** | **663.93 ns** | **664.24 ns** | **0.0143** |     **248 B** |
| SystemTextJsonSourceGen | .NET 8.0 | ?         | {&quot;X&quot;(...)\\n&quot;} [150] | 612.06 ns | 39.106 ns | 2.144 ns | 609.94 ns | 614.23 ns | 0.0143 |     248 B |
| SystemTextJson          | .NET 9.0 | ?         | {&quot;X&quot;(...)\\n&quot;} [150] | 590.88 ns |  5.041 ns | 0.276 ns | 590.57 ns | 591.06 ns | 0.0143 |     248 B |
| SystemTextJsonSourceGen | .NET 9.0 | ?         | {&quot;X&quot;(...)\\n&quot;} [150] | 575.35 ns | 61.478 ns | 3.370 ns | 572.54 ns | 579.09 ns | 0.0143 |     248 B |
