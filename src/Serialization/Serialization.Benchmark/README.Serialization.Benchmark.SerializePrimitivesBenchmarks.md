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
| SystemTextJson          | Seria(...)tives [29] | 1,007.81 ns | 43.652 ns | 2.393 ns | 1,005.73 ns | 1,010.43 ns | 0.0038 |     464 B |
| SystemTextJsonSourceGen | Seria(...)tives [29] |   940.34 ns |  5.138 ns | 0.282 ns |   940.05 ns |   940.61 ns | 0.0067 |     568 B |
| MemoryPack              | Seria(...)tives [29] |    95.77 ns |  2.637 ns | 0.145 ns |    95.60 ns |    95.87 ns | 0.0014 |     120 B |
