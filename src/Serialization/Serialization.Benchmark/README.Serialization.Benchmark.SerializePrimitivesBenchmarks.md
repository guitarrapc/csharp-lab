```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.401
  [Host]   : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                  | data                 | Mean        | Error     | StdDev   | Min         | Max         | Gen0   | Allocated |
|------------------------ |--------------------- |------------:|----------:|---------:|------------:|------------:|-------:|----------:|
| SystemTextJson          | Seria(...)tives [29] | 1,030.82 ns | 43.991 ns | 2.411 ns | 1,028.90 ns | 1,033.52 ns | 0.0038 |     464 B |
| SystemTextJsonSourceGen | Seria(...)tives [29] |   926.47 ns | 23.303 ns | 1.277 ns |   925.05 ns |   927.53 ns | 0.0067 |     568 B |
| MemoryPack              | Seria(...)tives [29] |    92.78 ns |  3.598 ns | 0.197 ns |    92.61 ns |    93.00 ns | 0.0014 |     120 B |
