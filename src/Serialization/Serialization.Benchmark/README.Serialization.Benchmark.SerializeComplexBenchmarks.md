```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.2 LTS (Noble Numbat)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.201
  [Host]            : .NET 9.0.3 (9.0.325.11113), X64 RyuJIT AVX2
  ShortRun-.NET 8.0 : .NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
  ShortRun-.NET 9.0 : .NET 9.0.3 (9.0.325.11113), X64 RyuJIT AVX2

IterationCount=3  LaunchCount=1  WarmupCount=3  

```
| Method                  | Runtime  | data                 | Mean      | Error      | StdDev    | Min       | Max       | Gen0   | Allocated |
|------------------------ |--------- |--------------------- |----------:|-----------:|----------:|----------:|----------:|-------:|----------:|
| SystemTextJson          | .NET 8.0 | Seria(...)Class [29] | 610.12 ns |  62.955 ns |  3.451 ns | 607.54 ns | 614.04 ns | 0.0229 |     392 B |
| SystemTextJsonSourceGen | .NET 8.0 | Seria(...)Class [29] | 695.86 ns | 254.731 ns | 13.963 ns | 683.67 ns | 711.09 ns | 0.0277 |     464 B |
| MemoryPack              | .NET 8.0 | Seria(...)Class [29] |  57.99 ns |  10.266 ns |  0.563 ns |  57.41 ns |  58.54 ns | 0.0072 |     120 B |
| SystemTextJson          | .NET 9.0 | Seria(...)Class [29] | 620.41 ns |  18.312 ns |  1.004 ns | 619.69 ns | 621.55 ns | 0.0229 |     392 B |
| SystemTextJsonSourceGen | .NET 9.0 | Seria(...)Class [29] | 646.61 ns | 105.628 ns |  5.790 ns | 641.93 ns | 653.08 ns | 0.0277 |     464 B |
| MemoryPack              | .NET 9.0 | Seria(...)Class [29] |  43.48 ns |   1.811 ns |  0.099 ns |  43.37 ns |  43.54 ns | 0.0072 |     120 B |
