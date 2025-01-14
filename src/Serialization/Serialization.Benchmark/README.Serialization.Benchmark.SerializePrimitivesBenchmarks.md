```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.1 LTS (Noble Numbat)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.101
  [Host]   : .NET 9.0.0 (9.0.24.52809), X64 RyuJIT AVX2
  ShortRun : .NET 9.0.0 (9.0.24.52809), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                  | data                 | Mean      | Error     | StdDev   | Min       | Max       | Gen0   | Allocated |
|------------------------ |--------------------- |----------:|----------:|---------:|----------:|----------:|-------:|----------:|
| SystemTextJson          | Seria(...)tives [29] | 984.42 ns | 45.021 ns | 2.468 ns | 982.10 ns | 987.02 ns | 0.0267 |     464 B |
| SystemTextJsonSourceGen | Seria(...)tives [29] | 870.97 ns | 31.702 ns | 1.738 ns | 869.30 ns | 872.77 ns | 0.0334 |     568 B |
| MemoryPack              | Seria(...)tives [29] |  77.88 ns |  5.346 ns | 0.293 ns |  77.57 ns |  78.16 ns | 0.0072 |     120 B |
