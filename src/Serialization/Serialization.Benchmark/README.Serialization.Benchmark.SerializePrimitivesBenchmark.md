```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.401
  [Host]   : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                  | data                 | Mean        | Error     | StdDev   | Min         | Max         | Gen0   | Allocated |
|------------------------ |--------------------- |------------:|----------:|---------:|------------:|------------:|-------:|----------:|
| SystemTextJson          | Seria(...)tives [29] | 1,030.55 ns | 52.148 ns | 2.858 ns | 1,028.77 ns | 1,033.84 ns | 0.0038 |     464 B |
| SystemTextJsonSourceGen | Seria(...)tives [29] |   916.29 ns | 44.390 ns | 2.433 ns |   914.58 ns |   919.07 ns | 0.0067 |     568 B |
| MemoryPack              | Seria(...)tives [29] |    91.80 ns |  5.211 ns | 0.286 ns |    91.58 ns |    92.13 ns | 0.0014 |     120 B |
