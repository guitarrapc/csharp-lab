```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.204
  [Host]   : .NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                  | data                 | Mean      | Error     | StdDev   | Min       | Max       | Gen0   | Allocated |
|------------------------ |--------------------- |----------:|----------:|---------:|----------:|----------:|-------:|----------:|
| SystemTextJson          | Seria(...)Class [29] | 639.78 ns | 36.050 ns | 1.976 ns | 638.59 ns | 642.07 ns | 0.0038 |     392 B |
| SystemTextJsonSourceGen | Seria(...)Class [29] | 690.39 ns | 26.701 ns | 1.464 ns | 688.89 ns | 691.81 ns | 0.0048 |     464 B |
| MemoryPack              | Seria(...)Class [29] |  60.31 ns |  4.281 ns | 0.235 ns |  60.12 ns |  60.57 ns | 0.0014 |     120 B |
