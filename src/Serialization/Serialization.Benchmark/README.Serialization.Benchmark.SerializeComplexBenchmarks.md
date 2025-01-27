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
| SystemTextJson          | Seria(...)Class [29] | 623.46 ns | 36.273 ns | 1.988 ns | 621.67 ns | 625.60 ns | 0.0229 |     392 B |
| SystemTextJsonSourceGen | Seria(...)Class [29] | 638.67 ns | 80.574 ns | 4.417 ns | 633.62 ns | 641.80 ns | 0.0277 |     464 B |
| MemoryPack              | Seria(...)Class [29] |  44.01 ns |  2.610 ns | 0.143 ns |  43.85 ns |  44.11 ns | 0.0072 |     120 B |
