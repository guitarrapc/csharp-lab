```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.401
  [Host]   : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                  | data                 | Mean        | Error     | StdDev   | Min         | Max         | Gen0   | Allocated |
|------------------------ |--------------------- |------------:|----------:|---------:|------------:|------------:|-------:|----------:|
| SystemTextJson          | Seria(...)tives [29] | 1,048.17 ns |  5.603 ns | 0.307 ns | 1,047.83 ns | 1,048.43 ns | 0.0038 |     464 B |
| SystemTextJsonSourceGen | Seria(...)tives [29] |   925.40 ns | 27.876 ns | 1.528 ns |   924.32 ns |   927.15 ns | 0.0067 |     568 B |
| MemoryPack              | Seria(...)tives [29] |    96.45 ns |  1.202 ns | 0.066 ns |    96.38 ns |    96.51 ns | 0.0014 |     120 B |
