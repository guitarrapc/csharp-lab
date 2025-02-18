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
| SystemTextJson          | .NET 8.0 | Seria(...)tives [29] | 1,007.67 ns | 38.356 ns | 2.102 ns | 1,006.03 ns | 1,010.04 ns | 0.0267 |     464 B |
| SystemTextJsonSourceGen | .NET 8.0 | Seria(...)tives [29] |   907.07 ns | 13.774 ns | 0.755 ns |   906.20 ns |   907.55 ns | 0.0334 |     568 B |
| MemoryPack              | .NET 8.0 | Seria(...)tives [29] |    91.03 ns |  6.680 ns | 0.366 ns |    90.70 ns |    91.43 ns | 0.0072 |     120 B |
| SystemTextJson          | .NET 9.0 | Seria(...)tives [29] |   976.67 ns | 31.841 ns | 1.745 ns |   975.46 ns |   978.67 ns | 0.0267 |     464 B |
| SystemTextJsonSourceGen | .NET 9.0 | Seria(...)tives [29] |   870.94 ns | 48.608 ns | 2.664 ns |   868.91 ns |   873.96 ns | 0.0334 |     568 B |
| MemoryPack              | .NET 9.0 | Seria(...)tives [29] |    76.65 ns |  7.486 ns | 0.410 ns |    76.27 ns |    77.09 ns | 0.0072 |     120 B |
