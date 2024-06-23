```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.302
  [Host]   : .NET 8.0.6 (8.0.624.26715), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.6 (8.0.624.26715), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                  | data                 | Mean      | Error     | StdDev   | Min       | Max       | Gen0   | Allocated |
|------------------------ |--------------------- |----------:|----------:|---------:|----------:|----------:|-------:|----------:|
| SystemTextJson          | Seria(...)Class [29] | 647.49 ns | 53.237 ns | 2.918 ns | 645.36 ns | 650.81 ns | 0.0038 |     392 B |
| SystemTextJsonSourceGen | Seria(...)Class [29] | 689.39 ns | 28.434 ns | 1.559 ns | 688.22 ns | 691.16 ns | 0.0048 |     464 B |
| MemoryPack              | Seria(...)Class [29] |  60.25 ns |  5.338 ns | 0.293 ns |  59.92 ns |  60.44 ns | 0.0014 |     120 B |
