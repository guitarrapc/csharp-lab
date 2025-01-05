```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.1 LTS (Noble Numbat)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.101
  [Host]   : .NET 9.0.0 (9.0.24.52809), X64 RyuJIT AVX2
  ShortRun : .NET 9.0.0 (9.0.24.52809), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                  | data                 | Mean      | Error     | StdDev   | Min       | Max       | Gen0   | Allocated |
|------------------------ |--------------------- |----------:|----------:|---------:|----------:|----------:|-------:|----------:|
| SystemTextJson          | Seria(...)Class [29] | 581.94 ns | 46.846 ns | 2.568 ns | 580.27 ns | 584.90 ns | 0.0229 |     392 B |
| SystemTextJsonSourceGen | Seria(...)Class [29] | 632.24 ns | 90.813 ns | 4.978 ns | 627.02 ns | 636.94 ns | 0.0277 |     464 B |
| MemoryPack              | Seria(...)Class [29] |  44.49 ns |  0.940 ns | 0.052 ns |  44.43 ns |  44.53 ns | 0.0072 |     120 B |
