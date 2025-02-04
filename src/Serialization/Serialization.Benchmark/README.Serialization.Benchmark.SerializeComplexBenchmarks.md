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
| SystemTextJson          | Seria(...)Class [29] | 610.61 ns | 67.196 ns | 3.683 ns | 606.98 ns | 614.35 ns | 0.0229 |     392 B |
| SystemTextJsonSourceGen | Seria(...)Class [29] | 669.79 ns |  7.270 ns | 0.398 ns | 669.37 ns | 670.16 ns | 0.0277 |     464 B |
| MemoryPack              | Seria(...)Class [29] |  47.08 ns |  7.303 ns | 0.400 ns |  46.78 ns |  47.53 ns | 0.0072 |     120 B |
