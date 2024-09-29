```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.402
  [Host]   : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                  | data                 | Mean        | Error     | StdDev   | Min         | Max         | Gen0   | Allocated |
|------------------------ |--------------------- |------------:|----------:|---------:|------------:|------------:|-------:|----------:|
| SystemTextJson          | Seria(...)tives [29] | 1,044.89 ns | 80.971 ns | 4.438 ns | 1,039.77 ns | 1,047.69 ns | 0.0038 |     464 B |
| SystemTextJsonSourceGen | Seria(...)tives [29] |   922.11 ns | 50.244 ns | 2.754 ns |   920.12 ns |   925.26 ns | 0.0067 |     568 B |
| MemoryPack              | Seria(...)tives [29] |    94.51 ns |  1.770 ns | 0.097 ns |    94.43 ns |    94.62 ns | 0.0014 |     120 B |
