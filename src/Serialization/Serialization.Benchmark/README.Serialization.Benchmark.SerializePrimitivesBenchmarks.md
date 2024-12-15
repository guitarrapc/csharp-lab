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
| SystemTextJson          | Seria(...)tives [29] | 1,027.10 ns | 100.159 ns | 5.490 ns | 1,023.42 ns | 1,033.41 ns | 0.0038 |     464 B |
| SystemTextJsonSourceGen | Seria(...)tives [29] |   891.46 ns |  52.547 ns | 2.880 ns |   889.10 ns |   894.67 ns | 0.0067 |     568 B |
| MemoryPack              | Seria(...)tives [29] |    92.27 ns |   6.058 ns | 0.332 ns |    91.89 ns |    92.50 ns | 0.0014 |     120 B |
