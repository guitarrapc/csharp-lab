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
| **MemoryPack**              | **.NET 8.0** | **Byte[89]** | **?**                   |  **51.56 ns** |  **1.796 ns** | **0.098 ns** |  **51.46 ns** |  **51.66 ns** | **0.0062** |     **104 B** |
| MemoryPack              | .NET 9.0 | Byte[89] | ?                   |  42.36 ns |  5.380 ns | 0.295 ns |  42.06 ns |  42.65 ns | 0.0062 |     104 B |
| **SystemTextJson**          | **.NET 8.0** | **?**        | **{&quot;Gn(...)&quot;:0} [182]** | **994.80 ns** | **14.124 ns** | **0.774 ns** | **994.25 ns** | **995.69 ns** | **0.0057** |     **104 B** |
| SystemTextJsonSourceGen | .NET 8.0 | ?        | {&quot;Gn(...)&quot;:0} [182] | 982.83 ns | 51.456 ns | 2.820 ns | 980.00 ns | 985.64 ns | 0.0057 |     104 B |
| SystemTextJson          | .NET 9.0 | ?        | {&quot;Gn(...)&quot;:0} [182] | 962.85 ns | 13.821 ns | 0.758 ns | 962.13 ns | 963.64 ns | 0.0057 |     104 B |
| SystemTextJsonSourceGen | .NET 9.0 | ?        | {&quot;Gn(...)&quot;:0} [182] | 952.73 ns | 31.416 ns | 1.722 ns | 950.77 ns | 953.98 ns | 0.0057 |     104 B |
