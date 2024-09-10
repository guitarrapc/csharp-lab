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
| SystemTextJson          | Seria(...)tives [29] | 1,026.53 ns | 44.676 ns | 2.449 ns | 1,024.84 ns | 1,029.34 ns | 0.0038 |     464 B |
| SystemTextJsonSourceGen | Seria(...)tives [29] |   923.95 ns | 37.336 ns | 2.047 ns |   922.63 ns |   926.30 ns | 0.0067 |     568 B |
| MemoryPack              | Seria(...)tives [29] |    99.13 ns |  6.359 ns | 0.349 ns |    98.85 ns |    99.52 ns | 0.0014 |     120 B |
