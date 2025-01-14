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
| SystemTextJson          | Seria(...)Class [29] | 626.93 ns | 22.251 ns | 1.220 ns | 625.74 ns | 628.18 ns | 0.0229 |     392 B |
| SystemTextJsonSourceGen | Seria(...)Class [29] | 641.45 ns | 16.677 ns | 0.914 ns | 640.67 ns | 642.45 ns | 0.0277 |     464 B |
| MemoryPack              | Seria(...)Class [29] |  45.27 ns |  5.567 ns | 0.305 ns |  44.96 ns |  45.56 ns | 0.0072 |     120 B |
