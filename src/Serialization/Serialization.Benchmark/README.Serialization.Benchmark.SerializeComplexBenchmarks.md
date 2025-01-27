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
| SystemTextJson          | Seria(...)Class [29] | 625.85 ns | 107.02 ns | 5.866 ns | 619.18 ns | 630.23 ns | 0.0229 |     392 B |
| SystemTextJsonSourceGen | Seria(...)Class [29] | 640.20 ns |  23.43 ns | 1.284 ns | 638.75 ns | 641.19 ns | 0.0277 |     464 B |
| MemoryPack              | Seria(...)Class [29] |  46.15 ns |  12.69 ns | 0.696 ns |  45.40 ns |  46.77 ns | 0.0072 |     120 B |
