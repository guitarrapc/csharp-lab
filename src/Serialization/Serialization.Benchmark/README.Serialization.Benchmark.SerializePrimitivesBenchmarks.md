```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.1 LTS (Noble Numbat)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.200
  [Host]            : .NET 9.0.2 (9.0.225.6610), X64 RyuJIT AVX2
  ShortRun-.NET 8.0 : .NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
  ShortRun-.NET 9.0 : .NET 9.0.2 (9.0.225.6610), X64 RyuJIT AVX2

IterationCount=3  LaunchCount=1  WarmupCount=3  

```
| Method                  | Runtime  | data                 | Mean        | Error     | StdDev   | Min         | Max         | Gen0   | Allocated |
|------------------------ |--------- |--------------------- |------------:|----------:|---------:|------------:|------------:|-------:|----------:|
| SystemTextJson          | .NET 8.0 | Seria(...)tives [29] | 1,032.72 ns | 36.386 ns | 1.994 ns | 1,030.45 ns | 1,034.18 ns | 0.0267 |     464 B |
| SystemTextJsonSourceGen | .NET 8.0 | Seria(...)tives [29] |   967.32 ns | 79.938 ns | 4.382 ns |   963.00 ns |   971.76 ns | 0.0324 |     568 B |
| MemoryPack              | .NET 8.0 | Seria(...)tives [29] |    95.56 ns |  6.607 ns | 0.362 ns |    95.27 ns |    95.97 ns | 0.0072 |     120 B |
| SystemTextJson          | .NET 9.0 | Seria(...)tives [29] |   961.56 ns | 85.438 ns | 4.683 ns |   956.59 ns |   965.89 ns | 0.0267 |     464 B |
| SystemTextJsonSourceGen | .NET 9.0 | Seria(...)tives [29] |   884.82 ns | 57.763 ns | 3.166 ns |   881.20 ns |   887.06 ns | 0.0334 |     568 B |
| MemoryPack              | .NET 9.0 | Seria(...)tives [29] |    82.06 ns | 16.930 ns | 0.928 ns |    81.24 ns |    83.07 ns | 0.0072 |     120 B |
