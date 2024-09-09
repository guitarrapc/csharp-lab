```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.401
  [Host]   : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                  | data                 | Mean      | Error     | StdDev   | Min       | Max       | Gen0   | Allocated |
|------------------------ |--------------------- |----------:|----------:|---------:|----------:|----------:|-------:|----------:|
| SystemTextJson          | Seria(...)Class [29] | 686.57 ns | 34.273 ns | 1.879 ns | 684.73 ns | 688.49 ns | 0.0038 |     392 B |
| SystemTextJsonSourceGen | Seria(...)Class [29] | 691.96 ns |  7.294 ns | 0.400 ns | 691.50 ns | 692.26 ns | 0.0048 |     464 B |
| MemoryPack              | Seria(...)Class [29] |  57.44 ns |  2.105 ns | 0.115 ns |  57.35 ns |  57.57 ns | 0.0014 |     120 B |
