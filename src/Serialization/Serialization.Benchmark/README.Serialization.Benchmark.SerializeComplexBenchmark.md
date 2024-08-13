```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.303
  [Host]   : .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                  | data                 | Mean      | Error     | StdDev   | Min       | Max       | Gen0   | Allocated |
|------------------------ |--------------------- |----------:|----------:|---------:|----------:|----------:|-------:|----------:|
| SystemTextJson          | Seria(...)Class [29] | 667.90 ns | 27.850 ns | 1.527 ns | 666.67 ns | 669.61 ns | 0.0038 |     392 B |
| SystemTextJsonSourceGen | Seria(...)Class [29] | 689.84 ns |  6.607 ns | 0.362 ns | 689.46 ns | 690.19 ns | 0.0048 |     464 B |
| MemoryPack              | Seria(...)Class [29] |  58.38 ns |  3.063 ns | 0.168 ns |  58.25 ns |  58.57 ns | 0.0014 |     120 B |
