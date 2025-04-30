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
| **MemoryPack**              | **.NET 8.0** | **Byte[89]** | **?**                   |  **51.72 ns** |  **5.558 ns** | **0.305 ns** |  **51.41 ns** |  **52.02 ns** | **0.0062** |     **104 B** |
| MemoryPack              | .NET 9.0 | Byte[89] | ?                   |  40.73 ns |  7.884 ns | 0.432 ns |  40.44 ns |  41.23 ns | 0.0062 |     104 B |
| **SystemTextJson**          | **.NET 8.0** | **?**        | **{&quot;Gn(...)&quot;:0} [182]** | **999.25 ns** | **10.912 ns** | **0.598 ns** | **998.58 ns** | **999.74 ns** | **0.0057** |     **104 B** |
| SystemTextJsonSourceGen | .NET 8.0 | ?        | {&quot;Gn(...)&quot;:0} [182] | 937.69 ns | 43.938 ns | 2.408 ns | 935.97 ns | 940.44 ns | 0.0057 |     104 B |
| SystemTextJson          | .NET 9.0 | ?        | {&quot;Gn(...)&quot;:0} [182] | 935.72 ns | 27.131 ns | 1.487 ns | 934.31 ns | 937.27 ns | 0.0057 |     104 B |
| SystemTextJsonSourceGen | .NET 9.0 | ?        | {&quot;Gn(...)&quot;:0} [182] | 906.67 ns | 44.856 ns | 2.459 ns | 904.41 ns | 909.29 ns | 0.0057 |     104 B |
