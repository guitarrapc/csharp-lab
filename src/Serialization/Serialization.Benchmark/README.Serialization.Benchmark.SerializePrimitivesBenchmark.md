```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.303
  [Host]   : .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                  | data                 | Mean        | Error      | StdDev    | Min         | Max         | Gen0   | Allocated |
|------------------------ |--------------------- |------------:|-----------:|----------:|------------:|------------:|-------:|----------:|
| SystemTextJson          | Seria(...)tives [29] | 1,045.69 ns | 535.299 ns | 29.342 ns | 1,027.93 ns | 1,079.55 ns | 0.0038 |     464 B |
| SystemTextJsonSourceGen | Seria(...)tives [29] |   919.31 ns |  50.199 ns |  2.752 ns |   916.16 ns |   921.22 ns | 0.0067 |     568 B |
| MemoryPack              | Seria(...)tives [29] |    96.44 ns |   5.747 ns |  0.315 ns |    96.08 ns |    96.66 ns | 0.0014 |     120 B |
