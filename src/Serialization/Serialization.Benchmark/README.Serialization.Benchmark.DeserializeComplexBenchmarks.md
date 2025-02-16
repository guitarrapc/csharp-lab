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
| **MemoryPack**              | **.NET 8.0** | **Byte[89]** | **?**                   |  **51.16 ns** | **12.072 ns** | **0.662 ns** |  **50.58 ns** |  **51.88 ns** | **0.0062** |     **104 B** |
| MemoryPack              | .NET 9.0 | Byte[89] | ?                   |  43.61 ns |  0.579 ns | 0.032 ns |  43.58 ns |  43.64 ns | 0.0062 |     104 B |
| **SystemTextJson**          | **.NET 8.0** | **?**        | **{&quot;Gn(...)&quot;:0} [182]** | **981.28 ns** | **12.099 ns** | **0.663 ns** | **980.52 ns** | **981.67 ns** | **0.0057** |     **104 B** |
| SystemTextJsonSourceGen | .NET 8.0 | ?        | {&quot;Gn(...)&quot;:0} [182] | 961.57 ns |  1.659 ns | 0.091 ns | 961.47 ns | 961.64 ns | 0.0057 |     104 B |
| SystemTextJson          | .NET 9.0 | ?        | {&quot;Gn(...)&quot;:0} [182] | 930.53 ns |  1.999 ns | 0.110 ns | 930.41 ns | 930.62 ns | 0.0057 |     104 B |
| SystemTextJsonSourceGen | .NET 9.0 | ?        | {&quot;Gn(...)&quot;:0} [182] | 910.39 ns | 38.402 ns | 2.105 ns | 908.54 ns | 912.68 ns | 0.0057 |     104 B |
