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
| SystemTextJson          | Seria(...)tives [29] | 1,004.86 ns | 46.438 ns | 2.545 ns | 1,002.02 ns | 1,006.95 ns | 0.0038 |     464 B |
| SystemTextJsonSourceGen | Seria(...)tives [29] |   934.45 ns |  4.972 ns | 0.273 ns |   934.27 ns |   934.77 ns | 0.0067 |     568 B |
| MemoryPack              | Seria(...)tives [29] |    94.67 ns |  7.531 ns | 0.413 ns |    94.37 ns |    95.14 ns | 0.0014 |     120 B |
