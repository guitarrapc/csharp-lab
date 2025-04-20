```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.2 LTS (Noble Numbat)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.203
  [Host]            : .NET 9.0.4 (9.0.425.16305), X64 RyuJIT AVX2
  ShortRun-.NET 8.0 : .NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
  ShortRun-.NET 9.0 : .NET 9.0.4 (9.0.425.16305), X64 RyuJIT AVX2

IterationCount=3  LaunchCount=1  WarmupCount=3  

```
| Method                  | Runtime  | data     | json                | Mean      | Error     | StdDev   | Min       | Max       | Gen0   | Allocated |
|------------------------ |--------- |--------- |-------------------- |----------:|----------:|---------:|----------:|----------:|-------:|----------:|
| **MemoryPack**              | **.NET 8.0** | **Byte[89]** | **?**                   |  **50.69 ns** |  **1.860 ns** | **0.102 ns** |  **50.59 ns** |  **50.79 ns** | **0.0062** |     **104 B** |
| MemoryPack              | .NET 9.0 | Byte[89] | ?                   |  42.60 ns | 10.730 ns | 0.588 ns |  41.95 ns |  43.08 ns | 0.0062 |     104 B |
| **SystemTextJson**          | **.NET 8.0** | **?**        | **{&quot;Gn(...)&quot;:0} [182]** | **969.38 ns** | **45.035 ns** | **2.469 ns** | **966.53 ns** | **970.98 ns** | **0.0057** |     **104 B** |
| SystemTextJsonSourceGen | .NET 8.0 | ?        | {&quot;Gn(...)&quot;:0} [182] | 949.09 ns |  3.608 ns | 0.198 ns | 948.86 ns | 949.21 ns | 0.0057 |     104 B |
| SystemTextJson          | .NET 9.0 | ?        | {&quot;Gn(...)&quot;:0} [182] | 947.20 ns | 40.726 ns | 2.232 ns | 945.09 ns | 949.54 ns | 0.0057 |     104 B |
| SystemTextJsonSourceGen | .NET 9.0 | ?        | {&quot;Gn(...)&quot;:0} [182] | 930.67 ns |  9.033 ns | 0.495 ns | 930.11 ns | 931.05 ns | 0.0057 |     104 B |
