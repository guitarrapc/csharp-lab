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
| SystemTextJson          | Seria(...)Class [26] | 428.05 ns | 71.541 ns | 3.921 ns | 423.65 ns | 431.18 ns | 0.0196 |     328 B |
| SystemTextJsonSourceGen | Seria(...)Class [26] | 315.98 ns | 26.036 ns | 1.427 ns | 314.44 ns | 317.26 ns | 0.0219 |     368 B |
| MemoryPack              | Seria(...)Class [26] |  85.14 ns |  5.765 ns | 0.316 ns |  84.88 ns |  85.49 ns | 0.0076 |     128 B |
