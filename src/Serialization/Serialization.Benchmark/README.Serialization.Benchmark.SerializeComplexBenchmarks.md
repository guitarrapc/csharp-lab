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
| SystemTextJson          | Seria(...)Class [29] | 614.53 ns | 43.730 ns | 2.397 ns | 612.58 ns | 617.20 ns | 0.0229 |     392 B |
| SystemTextJsonSourceGen | Seria(...)Class [29] | 638.63 ns | 30.343 ns | 1.663 ns | 636.82 ns | 640.10 ns | 0.0277 |     464 B |
| MemoryPack              | Seria(...)Class [29] |  44.75 ns |  2.528 ns | 0.139 ns |  44.60 ns |  44.86 ns | 0.0072 |     120 B |
