```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.2 LTS (Noble Numbat)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.203
  [Host]            : .NET 9.0.4 (9.0.425.16305), X64 RyuJIT AVX2
  ShortRun-.NET 8.0 : .NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
  ShortRun-.NET 9.0 : .NET 9.0.4 (9.0.425.16305), X64 RyuJIT AVX2

IterationCount=3  LaunchCount=1  WarmupCount=3  

```
| Method                  | Runtime  | data      | json                 | Mean      | Error     | StdDev   | Min       | Max       | Gen0   | Allocated |
|------------------------ |--------- |---------- |--------------------- |----------:|----------:|---------:|----------:|----------:|-------:|----------:|
| **MemoryPack**              | **.NET 8.0** | **Byte[103]** | **?**                    |  **88.11 ns** |  **0.933 ns** | **0.051 ns** |  **88.06 ns** |  **88.15 ns** | **0.0148** |     **248 B** |
| MemoryPack              | .NET 9.0 | Byte[103] | ?                    |  83.59 ns |  6.870 ns | 0.377 ns |  83.16 ns |  83.84 ns | 0.0148 |     248 B |
| **SystemTextJson**          | **.NET 8.0** | **?**         | **{&quot;X&quot;(...)\\n&quot;} [150]** | **604.64 ns** | **43.365 ns** | **2.377 ns** | **602.73 ns** | **607.30 ns** | **0.0143** |     **248 B** |
| SystemTextJsonSourceGen | .NET 8.0 | ?         | {&quot;X&quot;(...)\\n&quot;} [150] | 606.30 ns | 37.778 ns | 2.071 ns | 603.95 ns | 607.86 ns | 0.0143 |     248 B |
| SystemTextJson          | .NET 9.0 | ?         | {&quot;X&quot;(...)\\n&quot;} [150] | 570.37 ns | 48.220 ns | 2.643 ns | 568.28 ns | 573.34 ns | 0.0143 |     248 B |
| SystemTextJsonSourceGen | .NET 9.0 | ?         | {&quot;X&quot;(...)\\n&quot;} [150] | 588.28 ns | 59.760 ns | 3.276 ns | 584.61 ns | 590.92 ns | 0.0143 |     248 B |
