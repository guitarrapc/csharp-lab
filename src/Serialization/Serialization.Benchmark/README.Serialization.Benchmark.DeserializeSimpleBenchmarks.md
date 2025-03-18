```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.2 LTS (Noble Numbat)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.201
  [Host]            : .NET 9.0.3 (9.0.325.11113), X64 RyuJIT AVX2
  ShortRun-.NET 8.0 : .NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
  ShortRun-.NET 9.0 : .NET 9.0.3 (9.0.325.11113), X64 RyuJIT AVX2

IterationCount=3  LaunchCount=1  WarmupCount=3  

```
| Method                  | Runtime  | data      | json                 | Mean      | Error     | StdDev   | Min       | Max       | Gen0   | Allocated |
|------------------------ |--------- |---------- |--------------------- |----------:|----------:|---------:|----------:|----------:|-------:|----------:|
| **MemoryPack**              | **.NET 8.0** | **Byte[103]** | **?**                    |  **87.72 ns** |  **1.419 ns** | **0.078 ns** |  **87.64 ns** |  **87.80 ns** | **0.0148** |     **248 B** |
| MemoryPack              | .NET 9.0 | Byte[103] | ?                    |  82.72 ns |  1.080 ns | 0.059 ns |  82.65 ns |  82.76 ns | 0.0148 |     248 B |
| **SystemTextJson**          | **.NET 8.0** | **?**         | **{&quot;X&quot;(...)\\n&quot;} [150]** | **599.43 ns** | **49.774 ns** | **2.728 ns** | **597.24 ns** | **602.48 ns** | **0.0143** |     **248 B** |
| SystemTextJsonSourceGen | .NET 8.0 | ?         | {&quot;X&quot;(...)\\n&quot;} [150] | 607.93 ns | 40.493 ns | 2.220 ns | 606.13 ns | 610.41 ns | 0.0143 |     248 B |
| SystemTextJson          | .NET 9.0 | ?         | {&quot;X&quot;(...)\\n&quot;} [150] | 578.91 ns | 18.946 ns | 1.038 ns | 577.87 ns | 579.94 ns | 0.0143 |     248 B |
| SystemTextJsonSourceGen | .NET 9.0 | ?         | {&quot;X&quot;(...)\\n&quot;} [150] | 565.75 ns | 22.429 ns | 1.229 ns | 564.46 ns | 566.91 ns | 0.0143 |     248 B |
