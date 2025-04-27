```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.2 LTS (Noble Numbat)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.203
  [Host]            : .NET 9.0.4 (9.0.425.16305), X64 RyuJIT AVX2
  ShortRun-.NET 8.0 : .NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
  ShortRun-.NET 9.0 : .NET 9.0.4 (9.0.425.16305), X64 RyuJIT AVX2

IterationCount=3  LaunchCount=1  WarmupCount=3  

```
| Method                  | Runtime  | data      | json                 | Mean      | Error    | StdDev   | Min       | Max       | Gen0   | Allocated |
|------------------------ |--------- |---------- |--------------------- |----------:|---------:|---------:|----------:|----------:|-------:|----------:|
| **MemoryPack**              | **.NET 8.0** | **Byte[103]** | **?**                    |  **93.86 ns** | **32.74 ns** | **1.794 ns** |  **91.80 ns** |  **95.14 ns** | **0.0148** |     **248 B** |
| MemoryPack              | .NET 9.0 | Byte[103] | ?                    |  86.19 ns | 11.70 ns | 0.641 ns |  85.75 ns |  86.93 ns | 0.0148 |     248 B |
| **SystemTextJson**          | **.NET 8.0** | **?**         | **{&quot;X&quot;(...)\\n&quot;} [150]** | **610.12 ns** | **29.75 ns** | **1.631 ns** | **608.43 ns** | **611.69 ns** | **0.0143** |     **248 B** |
| SystemTextJsonSourceGen | .NET 8.0 | ?         | {&quot;X&quot;(...)\\n&quot;} [150] | 611.69 ns | 30.16 ns | 1.653 ns | 609.83 ns | 612.98 ns | 0.0143 |     248 B |
| SystemTextJson          | .NET 9.0 | ?         | {&quot;X&quot;(...)\\n&quot;} [150] | 580.56 ns | 55.56 ns | 3.046 ns | 577.93 ns | 583.89 ns | 0.0143 |     248 B |
| SystemTextJsonSourceGen | .NET 9.0 | ?         | {&quot;X&quot;(...)\\n&quot;} [150] | 563.41 ns | 27.80 ns | 1.524 ns | 561.67 ns | 564.50 ns | 0.0143 |     248 B |
