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
| SystemTextJson          | Seria(...)tives [29] | 1,014.27 ns |  14.67 ns | 0.804 ns | 1,013.47 ns | 1,015.08 ns | 0.0038 |     464 B |
| SystemTextJsonSourceGen | Seria(...)tives [29] |   943.22 ns | 122.41 ns | 6.709 ns |   938.05 ns |   950.80 ns | 0.0067 |     568 B |
| MemoryPack              | Seria(...)tives [29] |    95.20 ns |  38.69 ns | 2.121 ns |    93.88 ns |    97.65 ns | 0.0014 |     120 B |
