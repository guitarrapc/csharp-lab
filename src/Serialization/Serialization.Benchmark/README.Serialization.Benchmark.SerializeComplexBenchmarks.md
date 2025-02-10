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
| SystemTextJson          | Seria(...)Class [29] | 611.08 ns | 54.294 ns | 2.976 ns | 609.35 ns | 614.51 ns | 0.0229 |     392 B |
| SystemTextJsonSourceGen | Seria(...)Class [29] | 640.23 ns | 39.447 ns | 2.162 ns | 637.83 ns | 642.03 ns | 0.0277 |     464 B |
| MemoryPack              | Seria(...)Class [29] |  47.68 ns |  8.255 ns | 0.453 ns |  47.27 ns |  48.17 ns | 0.0072 |     120 B |
