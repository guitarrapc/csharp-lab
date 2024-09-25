```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.402
  [Host]   : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                  | data                 | Mean        | Error     | StdDev   | Min         | Max         | Gen0   | Allocated |
|------------------------ |--------------------- |------------:|----------:|---------:|------------:|------------:|-------:|----------:|
| SystemTextJson          | Seria(...)tives [29] | 1,029.52 ns | 66.349 ns | 3.637 ns | 1,026.98 ns | 1,033.69 ns | 0.0038 |     464 B |
| SystemTextJsonSourceGen | Seria(...)tives [29] |   923.94 ns | 58.612 ns | 3.213 ns |   921.89 ns |   927.64 ns | 0.0067 |     568 B |
| MemoryPack              | Seria(...)tives [29] |    93.57 ns |  1.993 ns | 0.109 ns |    93.46 ns |    93.68 ns | 0.0014 |     120 B |
