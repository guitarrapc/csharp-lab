```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.201
  [Host]   : .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                  | data                 | Mean        | Error     | StdDev   | Min         | Max         | Gen0   | Allocated |
|------------------------ |--------------------- |------------:|----------:|---------:|------------:|------------:|-------:|----------:|
| SystemTextJson          | Seria(...)tives [29] | 1,028.73 ns | 18.201 ns | 0.998 ns | 1,027.75 ns | 1,029.75 ns | 0.0038 |     464 B |
| SystemTextJsonSourceGen | Seria(...)tives [29] |   900.39 ns | 25.649 ns | 1.406 ns |   899.07 ns |   901.87 ns | 0.0067 |     568 B |
| MemoryPack              | Seria(...)tives [29] |    95.70 ns |  3.032 ns | 0.166 ns |    95.57 ns |    95.89 ns | 0.0014 |     120 B |
