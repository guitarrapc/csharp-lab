```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.301
  [Host]   : .NET 8.0.6 (8.0.624.26715), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.6 (8.0.624.26715), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                  | data                 | Mean      | Error     | StdDev   | Min       | Max       | Gen0   | Allocated |
|------------------------ |--------------------- |----------:|----------:|---------:|----------:|----------:|-------:|----------:|
| SystemTextJson          | Seria(...)Class [29] | 641.95 ns | 39.819 ns | 2.183 ns | 640.13 ns | 644.37 ns | 0.0038 |     392 B |
| SystemTextJsonSourceGen | Seria(...)Class [29] | 705.00 ns | 16.451 ns | 0.902 ns | 704.35 ns | 706.03 ns | 0.0048 |     464 B |
| MemoryPack              | Seria(...)Class [29] |  58.79 ns |  1.621 ns | 0.089 ns |  58.70 ns |  58.88 ns | 0.0014 |     120 B |
