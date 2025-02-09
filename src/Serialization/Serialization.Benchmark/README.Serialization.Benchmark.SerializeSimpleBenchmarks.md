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
| SystemTextJson          | Seria(...)Class [26] | 398.55 ns | 33.856 ns | 1.856 ns | 397.36 ns | 400.69 ns | 0.0196 |     328 B |
| SystemTextJsonSourceGen | Seria(...)Class [26] | 325.47 ns | 23.272 ns | 1.276 ns | 324.46 ns | 326.90 ns | 0.0219 |     368 B |
| MemoryPack              | Seria(...)Class [26] |  90.00 ns |  4.137 ns | 0.227 ns |  89.75 ns |  90.19 ns | 0.0076 |     128 B |
