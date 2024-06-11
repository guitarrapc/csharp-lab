```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.301
  [Host]   : .NET 8.0.6 (8.0.624.26715), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.6 (8.0.624.26715), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                  | data                 | Mean        | Error     | StdDev   | Min         | Max         | Gen0   | Allocated |
|------------------------ |--------------------- |------------:|----------:|---------:|------------:|------------:|-------:|----------:|
| SystemTextJson          | Seria(...)tives [29] | 1,005.61 ns | 50.916 ns | 2.791 ns | 1,002.50 ns | 1,007.88 ns | 0.0038 |     464 B |
| SystemTextJsonSourceGen | Seria(...)tives [29] |   914.69 ns | 15.466 ns | 0.848 ns |   914.04 ns |   915.65 ns | 0.0067 |     568 B |
| MemoryPack              | Seria(...)tives [29] |    95.52 ns |  2.527 ns | 0.139 ns |    95.40 ns |    95.67 ns | 0.0014 |     120 B |
