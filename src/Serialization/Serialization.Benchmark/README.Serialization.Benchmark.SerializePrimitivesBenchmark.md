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
| SystemTextJson          | Seria(...)tives [29] | 1,007.32 ns | 46.509 ns | 2.549 ns | 1,005.70 ns | 1,010.25 ns | 0.0038 |     464 B |
| SystemTextJsonSourceGen | Seria(...)tives [29] |   912.32 ns | 26.398 ns | 1.447 ns |   911.09 ns |   913.91 ns | 0.0067 |     568 B |
| MemoryPack              | Seria(...)tives [29] |    94.85 ns |  2.130 ns | 0.117 ns |    94.75 ns |    94.98 ns | 0.0014 |     120 B |
