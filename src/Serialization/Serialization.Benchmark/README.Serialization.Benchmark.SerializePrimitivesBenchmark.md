```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.303
  [Host]   : .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                  | data                 | Mean       | Error     | StdDev  | Min        | Max        | Gen0   | Allocated |
|------------------------ |--------------------- |-----------:|----------:|--------:|-----------:|-----------:|-------:|----------:|
| SystemTextJson          | Seria(...)tives [29] | 1,123.6 ns |  22.99 ns | 1.26 ns | 1,122.7 ns | 1,125.0 ns | 0.0038 |     464 B |
| SystemTextJsonSourceGen | Seria(...)tives [29] | 1,039.8 ns | 104.10 ns | 5.71 ns | 1,033.8 ns | 1,045.1 ns | 0.0057 |     568 B |
| MemoryPack              | Seria(...)tives [29] |   108.7 ns |  14.43 ns | 0.79 ns |   107.8 ns |   109.3 ns | 0.0014 |     120 B |
