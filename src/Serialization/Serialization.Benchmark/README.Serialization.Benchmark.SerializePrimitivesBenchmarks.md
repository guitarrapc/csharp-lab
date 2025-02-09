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
| SystemTextJson          | Seria(...)tives [29] | 960.86 ns | 91.871 ns | 5.036 ns | 957.14 ns | 966.59 ns | 0.0267 |     464 B |
| SystemTextJsonSourceGen | Seria(...)tives [29] | 873.57 ns | 47.255 ns | 2.590 ns | 871.88 ns | 876.55 ns | 0.0334 |     568 B |
| MemoryPack              | Seria(...)tives [29] |  77.31 ns |  8.098 ns | 0.444 ns |  76.91 ns |  77.79 ns | 0.0072 |     120 B |
