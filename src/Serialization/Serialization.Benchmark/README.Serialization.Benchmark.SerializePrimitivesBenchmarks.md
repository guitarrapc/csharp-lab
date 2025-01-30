```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.1 LTS (Noble Numbat)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.102
  [Host]   : .NET 9.0.1 (9.0.124.61010), X64 RyuJIT AVX2
  ShortRun : .NET 9.0.1 (9.0.124.61010), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                  | data                 | Mean      | Error     | StdDev   | Min       | Max       | Gen0   | Allocated |
|------------------------ |--------------------- |----------:|----------:|---------:|----------:|----------:|-------:|----------:|
| SystemTextJson          | Seria(...)tives [29] | 967.20 ns | 19.918 ns | 1.092 ns | 966.44 ns | 968.45 ns | 0.0267 |     464 B |
| SystemTextJsonSourceGen | Seria(...)tives [29] | 865.79 ns | 16.976 ns | 0.931 ns | 865.09 ns | 866.84 ns | 0.0334 |     568 B |
| MemoryPack              | Seria(...)tives [29] |  76.49 ns |  7.106 ns | 0.390 ns |  76.24 ns |  76.94 ns | 0.0072 |     120 B |
