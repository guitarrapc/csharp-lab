```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.402
  [Host]   : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                  | data                 | Mean        | Error    | StdDev   | Min         | Max         | Gen0   | Allocated |
|------------------------ |--------------------- |------------:|---------:|---------:|------------:|------------:|-------:|----------:|
| SystemTextJson          | Seria(...)tives [29] | 1,029.02 ns | 10.46 ns | 0.573 ns | 1,028.62 ns | 1,029.67 ns | 0.0038 |     464 B |
| SystemTextJsonSourceGen | Seria(...)tives [29] |   944.11 ns | 47.52 ns | 2.605 ns |   942.48 ns |   947.12 ns | 0.0057 |     568 B |
| MemoryPack              | Seria(...)tives [29] |    96.51 ns | 29.17 ns | 1.599 ns |    95.51 ns |    98.36 ns | 0.0014 |     120 B |
