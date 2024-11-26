```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.404
  [Host]   : .NET 8.0.11 (8.0.1124.51707), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.11 (8.0.1124.51707), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                  | data                 | Mean        | Error      | StdDev   | Min         | Max         | Gen0   | Allocated |
|------------------------ |--------------------- |------------:|-----------:|---------:|------------:|------------:|-------:|----------:|
| SystemTextJson          | Seria(...)tives [29] | 1,005.79 ns |  10.144 ns | 0.556 ns | 1,005.16 ns | 1,006.22 ns | 0.0038 |     464 B |
| SystemTextJsonSourceGen | Seria(...)tives [29] |   927.01 ns | 163.748 ns | 8.976 ns |   921.82 ns |   937.38 ns | 0.0067 |     568 B |
| MemoryPack              | Seria(...)tives [29] |    95.78 ns |   0.884 ns | 0.048 ns |    95.75 ns |    95.84 ns | 0.0014 |     120 B |
