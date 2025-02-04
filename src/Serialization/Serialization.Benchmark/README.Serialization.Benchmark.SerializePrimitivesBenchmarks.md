```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.1 LTS (Noble Numbat)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.102
  [Host]   : .NET 9.0.1 (9.0.124.61010), X64 RyuJIT AVX2
  ShortRun : .NET 9.0.1 (9.0.124.61010), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                  | data                 | Mean        | Error     | StdDev   | Min         | Max         | Gen0   | Allocated |
|------------------------ |--------------------- |------------:|----------:|---------:|------------:|------------:|-------:|----------:|
| SystemTextJson          | Seria(...)tives [29] | 1,008.73 ns | 49.508 ns | 2.714 ns | 1,006.44 ns | 1,011.72 ns | 0.0267 |     464 B |
| SystemTextJsonSourceGen | Seria(...)tives [29] |   921.39 ns |  6.422 ns | 0.352 ns |   921.10 ns |   921.78 ns | 0.0334 |     568 B |
| MemoryPack              | Seria(...)tives [29] |    88.32 ns | 13.041 ns | 0.715 ns |    87.64 ns |    89.06 ns | 0.0072 |     120 B |
