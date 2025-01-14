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
| SystemTextJson          | Seria(...)tives [29] | 972.04 ns | 52.406 ns | 2.873 ns | 970.32 ns | 975.35 ns | 0.0267 |     464 B |
| SystemTextJsonSourceGen | Seria(...)tives [29] | 876.51 ns | 42.879 ns | 2.350 ns | 874.73 ns | 879.18 ns | 0.0334 |     568 B |
| MemoryPack              | Seria(...)tives [29] |  78.80 ns |  1.787 ns | 0.098 ns |  78.69 ns |  78.87 ns | 0.0072 |     120 B |
