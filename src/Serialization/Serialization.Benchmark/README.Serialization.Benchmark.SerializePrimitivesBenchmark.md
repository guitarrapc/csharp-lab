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
| SystemTextJson          | Seria(...)tives [29] | 1,013.26 ns | 86.79 ns | 4.757 ns | 1,010.00 ns | 1,018.72 ns | 0.0038 |     464 B |
| SystemTextJsonSourceGen | Seria(...)tives [29] |   916.20 ns | 43.04 ns | 2.359 ns |   913.66 ns |   918.32 ns | 0.0067 |     568 B |
| MemoryPack              | Seria(...)tives [29] |    96.52 ns | 12.22 ns | 0.670 ns |    95.92 ns |    97.24 ns | 0.0014 |     120 B |
