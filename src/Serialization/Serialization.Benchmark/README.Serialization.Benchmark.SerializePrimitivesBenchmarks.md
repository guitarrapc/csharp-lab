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
| SystemTextJson          | Seria(...)tives [29] | 981.66 ns | 122.713 ns | 6.726 ns | 974.53 ns | 987.90 ns | 0.0267 |     464 B |
| SystemTextJsonSourceGen | Seria(...)tives [29] | 909.19 ns |  45.176 ns | 2.476 ns | 907.70 ns | 912.05 ns | 0.0334 |     568 B |
| MemoryPack              | Seria(...)tives [29] |  78.48 ns |   1.729 ns | 0.095 ns |  78.41 ns |  78.59 ns | 0.0072 |     120 B |
