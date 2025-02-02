```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.1 LTS (Noble Numbat)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.102
  [Host]   : .NET 9.0.1 (9.0.124.61010), X64 RyuJIT AVX2
  ShortRun : .NET 9.0.1 (9.0.124.61010), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                  | data                 | Mean      | Error    | StdDev   | Min       | Max       | Gen0   | Allocated |
|------------------------ |--------------------- |----------:|---------:|---------:|----------:|----------:|-------:|----------:|
| SystemTextJson          | Seria(...)Class [26] | 404.57 ns | 14.76 ns | 0.809 ns | 403.76 ns | 405.38 ns | 0.0196 |     328 B |
| SystemTextJsonSourceGen | Seria(...)Class [26] | 328.00 ns | 17.22 ns | 0.944 ns | 327.26 ns | 329.06 ns | 0.0219 |     368 B |
| MemoryPack              | Seria(...)Class [26] |  87.03 ns | 29.33 ns | 1.607 ns |  85.35 ns |  88.55 ns | 0.0076 |     128 B |
