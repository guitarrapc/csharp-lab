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
| SystemTextJson          | Seria(...)Class [26] | 434.96 ns | 110.52 ns | 6.058 ns | 429.15 ns | 441.24 ns | 0.0196 |     328 B |
| SystemTextJsonSourceGen | Seria(...)Class [26] | 328.31 ns |  22.67 ns | 1.242 ns | 326.94 ns | 329.36 ns | 0.0219 |     368 B |
| MemoryPack              | Seria(...)Class [26] |  86.19 ns |  10.97 ns | 0.602 ns |  85.71 ns |  86.86 ns | 0.0076 |     128 B |
