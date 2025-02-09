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
| SystemTextJson          | Seria(...)Class [29] | 591.66 ns | 30.702 ns | 1.683 ns | 590.53 ns | 593.59 ns | 0.0229 |     392 B |
| SystemTextJsonSourceGen | Seria(...)Class [29] | 632.73 ns | 20.584 ns | 1.128 ns | 631.97 ns | 634.02 ns | 0.0277 |     464 B |
| MemoryPack              | Seria(...)Class [29] |  43.90 ns |  7.218 ns | 0.396 ns |  43.58 ns |  44.34 ns | 0.0072 |     120 B |
