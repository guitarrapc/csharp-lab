```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.204
  [Host]   : .NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                  | data                 | Mean        | Error    | StdDev   | Min         | Max         | Gen0   | Allocated |
|------------------------ |--------------------- |------------:|---------:|---------:|------------:|------------:|-------:|----------:|
| SystemTextJson          | Seria(...)tives [29] | 1,006.12 ns | 29.21 ns | 1.601 ns | 1,005.12 ns | 1,007.97 ns | 0.0038 |     464 B |
| SystemTextJsonSourceGen | Seria(...)tives [29] |   898.76 ns | 12.04 ns | 0.660 ns |   898.14 ns |   899.45 ns | 0.0067 |     568 B |
| MemoryPack              | Seria(...)tives [29] |    95.72 ns | 38.71 ns | 2.122 ns |    94.22 ns |    98.15 ns | 0.0014 |     120 B |
