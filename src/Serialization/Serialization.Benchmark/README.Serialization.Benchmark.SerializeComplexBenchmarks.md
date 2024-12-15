```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.404
  [Host]   : .NET 8.0.11 (8.0.1124.51707), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.11 (8.0.1124.51707), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                  | data                 | Mean      | Error     | StdDev   | Min       | Max       | Gen0   | Allocated |
|------------------------ |--------------------- |----------:|----------:|---------:|----------:|----------:|-------:|----------:|
| SystemTextJson          | Seria(...)Class [29] | 633.04 ns | 15.873 ns | 0.870 ns | 632.29 ns | 634.00 ns | 0.0038 |     392 B |
| SystemTextJsonSourceGen | Seria(...)Class [29] | 727.95 ns | 13.774 ns | 0.755 ns | 727.08 ns | 728.40 ns | 0.0048 |     464 B |
| MemoryPack              | Seria(...)Class [29] |  57.77 ns |  2.137 ns | 0.117 ns |  57.70 ns |  57.90 ns | 0.0014 |     120 B |
