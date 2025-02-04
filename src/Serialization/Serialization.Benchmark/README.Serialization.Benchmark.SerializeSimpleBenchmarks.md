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
| SystemTextJson          | Seria(...)Class [26] | 400.04 ns |  2.420 ns | 0.133 ns | 399.92 ns | 400.18 ns | 0.0196 |     328 B |
| SystemTextJsonSourceGen | Seria(...)Class [26] | 321.78 ns | 28.829 ns | 1.580 ns | 320.39 ns | 323.50 ns | 0.0219 |     368 B |
| MemoryPack              | Seria(...)Class [26] |  88.03 ns | 22.138 ns | 1.213 ns |  87.30 ns |  89.43 ns | 0.0076 |     128 B |
