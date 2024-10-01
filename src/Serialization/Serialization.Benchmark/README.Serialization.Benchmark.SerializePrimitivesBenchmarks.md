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
| SystemTextJson          | Seria(...)tives [29] | 1,040.11 ns | 37.625 ns | 2.062 ns | 1,038.20 ns | 1,042.30 ns | 0.0038 |     464 B |
| SystemTextJsonSourceGen | Seria(...)tives [29] |   921.58 ns |  2.471 ns | 0.135 ns |   921.45 ns |   921.72 ns | 0.0067 |     568 B |
| MemoryPack              | Seria(...)tives [29] |    92.63 ns |  6.872 ns | 0.377 ns |    92.35 ns |    93.06 ns | 0.0014 |     120 B |
