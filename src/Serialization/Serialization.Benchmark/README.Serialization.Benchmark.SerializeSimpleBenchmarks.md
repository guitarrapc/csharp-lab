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
| SystemTextJson          | Seria(...)Class [26] | 412.45 ns | 14.937 ns | 0.819 ns | 411.69 ns | 413.32 ns | 0.0196 |     328 B |
| SystemTextJsonSourceGen | Seria(...)Class [26] | 317.92 ns | 36.570 ns | 2.005 ns | 315.68 ns | 319.54 ns | 0.0219 |     368 B |
| MemoryPack              | Seria(...)Class [26] |  84.26 ns |  5.383 ns | 0.295 ns |  84.07 ns |  84.60 ns | 0.0076 |     128 B |
