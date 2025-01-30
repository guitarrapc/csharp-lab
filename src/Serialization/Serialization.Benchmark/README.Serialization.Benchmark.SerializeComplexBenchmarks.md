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
| SystemTextJson          | Seria(...)Class [29] | 607.46 ns |  9.795 ns | 0.537 ns | 606.94 ns | 608.01 ns | 0.0229 |     392 B |
| SystemTextJsonSourceGen | Seria(...)Class [29] | 654.64 ns |  4.309 ns | 0.236 ns | 654.39 ns | 654.85 ns | 0.0277 |     464 B |
| MemoryPack              | Seria(...)Class [29] |  43.68 ns | 15.048 ns | 0.825 ns |  42.85 ns |  44.50 ns | 0.0072 |     120 B |
