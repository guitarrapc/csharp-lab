```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.1 LTS (Noble Numbat)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.101
  [Host]   : .NET 9.0.0 (9.0.24.52809), X64 RyuJIT AVX2
  ShortRun : .NET 9.0.0 (9.0.24.52809), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                  | data                 | Mean      | Error      | StdDev   | Min       | Max       | Gen0   | Allocated |
|------------------------ |--------------------- |----------:|-----------:|---------:|----------:|----------:|-------:|----------:|
| SystemTextJson          | Seria(...)tives [29] | 948.30 ns |  42.730 ns | 2.342 ns | 946.65 ns | 950.98 ns | 0.0277 |     464 B |
| SystemTextJsonSourceGen | Seria(...)tives [29] | 886.54 ns | 110.632 ns | 6.064 ns | 882.99 ns | 893.54 ns | 0.0334 |     568 B |
| MemoryPack              | Seria(...)tives [29] |  75.90 ns |   1.002 ns | 0.055 ns |  75.85 ns |  75.96 ns | 0.0072 |     120 B |
