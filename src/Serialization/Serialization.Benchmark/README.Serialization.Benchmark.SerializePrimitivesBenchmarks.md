```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.404
  [Host]   : .NET 8.0.11 (8.0.1124.51707), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.11 (8.0.1124.51707), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                  | data                 | Mean        | Error     | StdDev   | Min         | Max         | Gen0   | Allocated |
|------------------------ |--------------------- |------------:|----------:|---------:|------------:|------------:|-------:|----------:|
| SystemTextJson          | Seria(...)tives [29] | 1,021.15 ns |  4.789 ns | 0.262 ns | 1,020.90 ns | 1,021.42 ns | 0.0038 |     464 B |
| SystemTextJsonSourceGen | Seria(...)tives [29] |   913.95 ns | 50.545 ns | 2.771 ns |   911.39 ns |   916.89 ns | 0.0067 |     568 B |
| MemoryPack              | Seria(...)tives [29] |    94.04 ns |  1.534 ns | 0.084 ns |    93.94 ns |    94.09 ns | 0.0014 |     120 B |
