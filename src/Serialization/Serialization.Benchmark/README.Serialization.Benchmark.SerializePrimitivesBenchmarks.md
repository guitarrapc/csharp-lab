```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.2 LTS (Noble Numbat)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.201
  [Host]            : .NET 9.0.3 (9.0.325.11113), X64 RyuJIT AVX2
  ShortRun-.NET 8.0 : .NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
  ShortRun-.NET 9.0 : .NET 9.0.3 (9.0.325.11113), X64 RyuJIT AVX2

IterationCount=3  LaunchCount=1  WarmupCount=3  

```
| Method                  | Runtime  | data                 | Mean        | Error     | StdDev   | Min         | Max         | Gen0   | Allocated |
|------------------------ |--------- |--------------------- |------------:|----------:|---------:|------------:|------------:|-------:|----------:|
| SystemTextJson          | .NET 8.0 | Seria(...)tives [29] | 1,039.37 ns | 13.267 ns | 0.727 ns | 1,038.54 ns | 1,039.92 ns | 0.0267 |     464 B |
| SystemTextJsonSourceGen | .NET 8.0 | Seria(...)tives [29] |   950.77 ns | 38.418 ns | 2.106 ns |   948.36 ns |   952.22 ns | 0.0324 |     568 B |
| MemoryPack              | .NET 8.0 | Seria(...)tives [29] |    89.37 ns | 11.813 ns | 0.648 ns |    88.82 ns |    90.08 ns | 0.0072 |     120 B |
| SystemTextJson          | .NET 9.0 | Seria(...)tives [29] |   969.97 ns | 88.267 ns | 4.838 ns |   966.30 ns |   975.45 ns | 0.0267 |     464 B |
| SystemTextJsonSourceGen | .NET 9.0 | Seria(...)tives [29] |   894.81 ns | 69.779 ns | 3.825 ns |   892.36 ns |   899.22 ns | 0.0334 |     568 B |
| MemoryPack              | .NET 9.0 | Seria(...)tives [29] |    77.57 ns |  4.210 ns | 0.231 ns |    77.39 ns |    77.83 ns | 0.0072 |     120 B |
