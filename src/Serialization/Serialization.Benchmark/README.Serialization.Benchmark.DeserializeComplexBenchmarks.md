```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.1 LTS (Noble Numbat)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.200
  [Host]            : .NET 9.0.2 (9.0.225.6610), X64 RyuJIT AVX2
  ShortRun-.NET 8.0 : .NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
  ShortRun-.NET 9.0 : .NET 9.0.2 (9.0.225.6610), X64 RyuJIT AVX2

IterationCount=3  LaunchCount=1  WarmupCount=3  

```
| Method                  | Runtime  | data     | json                | Mean      | Error     | StdDev   | Min       | Max       | Gen0   | Allocated |
|------------------------ |--------- |--------- |-------------------- |----------:|----------:|---------:|----------:|----------:|-------:|----------:|
| **MemoryPack**              | **.NET 8.0** | **Byte[89]** | **?**                   |  **50.74 ns** |  **1.883 ns** | **0.103 ns** |  **50.63 ns** |  **50.84 ns** | **0.0062** |     **104 B** |
| MemoryPack              | .NET 9.0 | Byte[89] | ?                   |  40.87 ns |  2.940 ns | 0.161 ns |  40.70 ns |  41.03 ns | 0.0062 |     104 B |
| **SystemTextJson**          | **.NET 8.0** | **?**        | **{&quot;Gn(...)&quot;:0} [182]** | **974.54 ns** | **28.283 ns** | **1.550 ns** | **973.01 ns** | **976.11 ns** | **0.0057** |     **104 B** |
| SystemTextJsonSourceGen | .NET 8.0 | ?        | {&quot;Gn(...)&quot;:0} [182] | 929.47 ns | 53.829 ns | 2.951 ns | 927.53 ns | 932.86 ns | 0.0057 |     104 B |
| SystemTextJson          | .NET 9.0 | ?        | {&quot;Gn(...)&quot;:0} [182] | 934.55 ns | 16.394 ns | 0.899 ns | 933.85 ns | 935.56 ns | 0.0057 |     104 B |
| SystemTextJsonSourceGen | .NET 9.0 | ?        | {&quot;Gn(...)&quot;:0} [182] | 912.34 ns | 36.043 ns | 1.976 ns | 910.87 ns | 914.58 ns | 0.0057 |     104 B |
