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
| SystemTextJson          | Seria(...)Class [26] | 352.64 ns | 13.571 ns | 0.744 ns | 351.99 ns | 353.45 ns | 0.0196 |     328 B |
| SystemTextJsonSourceGen | Seria(...)Class [26] | 318.44 ns | 27.222 ns | 1.492 ns | 317.57 ns | 320.16 ns | 0.0219 |     368 B |
| MemoryPack              | Seria(...)Class [26] |  83.77 ns |  5.094 ns | 0.279 ns |  83.53 ns |  84.07 ns | 0.0076 |     128 B |
