```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.2 LTS (Noble Numbat)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.200
  [Host]            : .NET 9.0.2 (9.0.225.6610), X64 RyuJIT AVX2
  ShortRun-.NET 8.0 : .NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
  ShortRun-.NET 9.0 : .NET 9.0.2 (9.0.225.6610), X64 RyuJIT AVX2

IterationCount=3  LaunchCount=1  WarmupCount=3  

```
| Method                  | Runtime  | data                 | Mean      | Error     | StdDev   | Min       | Max         | Gen0   | Allocated |
|------------------------ |--------- |--------------------- |----------:|----------:|---------:|----------:|------------:|-------:|----------:|
| SystemTextJson          | .NET 8.0 | Seria(...)tives [29] | 994.21 ns | 98.049 ns | 5.374 ns | 989.57 ns | 1,000.10 ns | 0.0267 |     464 B |
| SystemTextJsonSourceGen | .NET 8.0 | Seria(...)tives [29] | 920.19 ns | 29.587 ns | 1.622 ns | 919.02 ns |   922.04 ns | 0.0334 |     568 B |
| MemoryPack              | .NET 8.0 | Seria(...)tives [29] |  91.98 ns |  5.634 ns | 0.309 ns |  91.74 ns |    92.33 ns | 0.0072 |     120 B |
| SystemTextJson          | .NET 9.0 | Seria(...)tives [29] | 955.45 ns | 90.269 ns | 4.948 ns | 949.76 ns |   958.75 ns | 0.0277 |     464 B |
| SystemTextJsonSourceGen | .NET 9.0 | Seria(...)tives [29] | 867.34 ns | 52.476 ns | 2.876 ns | 864.18 ns |   869.80 ns | 0.0334 |     568 B |
| MemoryPack              | .NET 9.0 | Seria(...)tives [29] |  76.79 ns | 16.267 ns | 0.892 ns |  76.28 ns |    77.82 ns | 0.0072 |     120 B |
