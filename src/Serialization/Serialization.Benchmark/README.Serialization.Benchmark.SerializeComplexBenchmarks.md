```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.1 LTS (Noble Numbat)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.101
  [Host]   : .NET 9.0.0 (9.0.24.52809), X64 RyuJIT AVX2
  ShortRun : .NET 9.0.0 (9.0.24.52809), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                  | data                 | Mean      | Error    | StdDev   | Min       | Max       | Gen0   | Allocated |
|------------------------ |--------------------- |----------:|---------:|---------:|----------:|----------:|-------:|----------:|
| SystemTextJson          | Seria(...)Class [29] | 587.50 ns | 26.12 ns | 1.432 ns | 585.96 ns | 588.79 ns | 0.0229 |     392 B |
| SystemTextJsonSourceGen | Seria(...)Class [29] | 644.62 ns | 56.23 ns | 3.082 ns | 641.23 ns | 647.26 ns | 0.0277 |     464 B |
| MemoryPack              | Seria(...)Class [29] |  48.18 ns | 20.49 ns | 1.123 ns |  47.44 ns |  49.47 ns | 0.0072 |     120 B |
