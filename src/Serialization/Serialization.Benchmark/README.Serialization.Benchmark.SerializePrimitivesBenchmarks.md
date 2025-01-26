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
| SystemTextJson          | Seria(...)tives [29] | 986.04 ns | 66.043 ns | 3.620 ns | 983.45 ns | 990.18 ns | 0.0267 |     464 B |
| SystemTextJsonSourceGen | Seria(...)tives [29] | 909.83 ns | 27.766 ns | 1.522 ns | 908.62 ns | 911.54 ns | 0.0334 |     568 B |
| MemoryPack              | Seria(...)tives [29] |  80.04 ns |  9.226 ns | 0.506 ns |  79.69 ns |  80.62 ns | 0.0072 |     120 B |
