```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.302
  [Host]   : .NET 8.0.7 (8.0.724.27014), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.7 (8.0.724.27014), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                  | data                 | Mean      | Error     | StdDev   | Min       | Max       | Gen0   | Allocated |
|------------------------ |--------------------- |----------:|----------:|---------:|----------:|----------:|-------:|----------:|
| SystemTextJson          | Seria(...)Class [29] | 629.39 ns |  5.064 ns | 0.278 ns | 629.18 ns | 629.71 ns | 0.0038 |     392 B |
| SystemTextJsonSourceGen | Seria(...)Class [29] | 701.12 ns | 25.825 ns | 1.416 ns | 699.81 ns | 702.62 ns | 0.0048 |     464 B |
| MemoryPack              | Seria(...)Class [29] |  57.54 ns |  5.678 ns | 0.311 ns |  57.19 ns |  57.78 ns | 0.0014 |     120 B |
