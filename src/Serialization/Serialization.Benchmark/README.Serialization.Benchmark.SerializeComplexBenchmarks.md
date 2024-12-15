```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.101
  [Host]   : .NET 9.0.0 (9.0.24.52809), X64 RyuJIT AVX2
  ShortRun : .NET 9.0.0 (9.0.24.52809), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                  | data                 | Mean      | Error      | StdDev   | Min       | Max       | Gen0   | Allocated |
|------------------------ |--------------------- |----------:|-----------:|---------:|----------:|----------:|-------:|----------:|
| SystemTextJson          | Seria(...)Class [29] | 593.83 ns |   4.472 ns | 0.245 ns | 593.62 ns | 594.10 ns | 0.0038 |     392 B |
| SystemTextJsonSourceGen | Seria(...)Class [29] | 642.32 ns | 162.627 ns | 8.914 ns | 636.98 ns | 652.61 ns | 0.0048 |     464 B |
| MemoryPack              | Seria(...)Class [29] |  46.74 ns |   3.516 ns | 0.193 ns |  46.52 ns |  46.87 ns | 0.0014 |     120 B |
