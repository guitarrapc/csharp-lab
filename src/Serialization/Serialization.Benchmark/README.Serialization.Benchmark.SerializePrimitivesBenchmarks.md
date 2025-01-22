```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.1 LTS (Noble Numbat)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.102
  [Host]   : .NET 9.0.1 (9.0.124.61010), X64 RyuJIT AVX2
  ShortRun : .NET 9.0.1 (9.0.124.61010), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                  | data                 | Mean      | Error      | StdDev   | Min       | Max       | Gen0   | Allocated |
|------------------------ |--------------------- |----------:|-----------:|---------:|----------:|----------:|-------:|----------:|
| SystemTextJson          | Seria(...)tives [29] | 982.45 ns | 100.780 ns | 5.524 ns | 978.80 ns | 988.80 ns | 0.0267 |     464 B |
| SystemTextJsonSourceGen | Seria(...)tives [29] | 870.12 ns | 122.611 ns | 6.721 ns | 863.42 ns | 876.86 ns | 0.0334 |     568 B |
| MemoryPack              | Seria(...)tives [29] |  77.36 ns |   4.145 ns | 0.227 ns |  77.11 ns |  77.56 ns | 0.0072 |     120 B |
