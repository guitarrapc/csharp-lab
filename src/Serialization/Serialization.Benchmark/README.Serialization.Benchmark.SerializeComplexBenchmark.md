```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.303
  [Host]   : .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                  | data                 | Mean      | Error     | StdDev   | Min       | Max       | Gen0   | Allocated |
|------------------------ |--------------------- |----------:|----------:|---------:|----------:|----------:|-------:|----------:|
| SystemTextJson          | Seria(...)Class [29] | 664.26 ns | 51.461 ns | 2.821 ns | 661.47 ns | 667.11 ns | 0.0038 |     392 B |
| SystemTextJsonSourceGen | Seria(...)Class [29] | 692.42 ns | 27.573 ns | 1.511 ns | 691.43 ns | 694.16 ns | 0.0048 |     464 B |
| MemoryPack              | Seria(...)Class [29] |  57.60 ns |  0.140 ns | 0.008 ns |  57.59 ns |  57.61 ns | 0.0014 |     120 B |
