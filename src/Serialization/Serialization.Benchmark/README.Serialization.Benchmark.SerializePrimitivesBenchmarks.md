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
| SystemTextJson          | Seria(...)tives [29] | 988.97 ns | 34.815 ns | 1.908 ns | 987.71 ns | 991.16 ns | 0.0267 |     464 B |
| SystemTextJsonSourceGen | Seria(...)tives [29] | 900.89 ns | 34.755 ns | 1.905 ns | 899.65 ns | 903.08 ns | 0.0334 |     568 B |
| MemoryPack              | Seria(...)tives [29] |  77.81 ns |  8.157 ns | 0.447 ns |  77.38 ns |  78.27 ns | 0.0072 |     120 B |
