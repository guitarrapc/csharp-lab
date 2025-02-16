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
| SystemTextJson          | .NET 8.0 | Seria(...)tives [29] | 1,012.85 ns |  90.74 ns | 4.974 ns | 1,007.11 ns | 1,015.72 ns | 0.0267 |     464 B |
| SystemTextJsonSourceGen | .NET 8.0 | Seria(...)tives [29] |   919.81 ns |  65.77 ns | 3.605 ns |   916.72 ns |   923.77 ns | 0.0334 |     568 B |
| MemoryPack              | .NET 8.0 | Seria(...)tives [29] |    90.03 ns |  18.05 ns | 0.990 ns |    89.28 ns |    91.15 ns | 0.0072 |     120 B |
| SystemTextJson          | .NET 9.0 | Seria(...)tives [29] |   989.74 ns | 115.80 ns | 6.347 ns |   984.59 ns |   996.83 ns | 0.0267 |     464 B |
| SystemTextJsonSourceGen | .NET 9.0 | Seria(...)tives [29] |   858.80 ns | 110.05 ns | 6.032 ns |   852.92 ns |   864.98 ns | 0.0334 |     568 B |
| MemoryPack              | .NET 9.0 | Seria(...)tives [29] |    77.41 ns |  22.41 ns | 1.228 ns |    76.05 ns |    78.44 ns | 0.0072 |     120 B |
