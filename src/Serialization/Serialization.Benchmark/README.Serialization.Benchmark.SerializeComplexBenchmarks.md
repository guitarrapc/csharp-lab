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
| SystemTextJson          | Seria(...)Class [29] | 627.80 ns | 35.119 ns | 1.925 ns | 625.60 ns | 629.20 ns | 0.0229 |     392 B |
| SystemTextJsonSourceGen | Seria(...)Class [29] | 656.17 ns | 32.121 ns | 1.761 ns | 654.73 ns | 658.13 ns | 0.0277 |     464 B |
| MemoryPack              | Seria(...)Class [29] |  48.60 ns |  8.433 ns | 0.462 ns |  48.14 ns |  49.06 ns | 0.0072 |     120 B |
