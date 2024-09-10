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
| SystemTextJson          | Seria(...)tives [29] | 1,042.14 ns | 15.082 ns | 0.827 ns | 1,041.21 ns | 1,042.79 ns | 0.0038 |     464 B |
| SystemTextJsonSourceGen | Seria(...)tives [29] |   917.12 ns | 18.572 ns | 1.018 ns |   916.20 ns |   918.21 ns | 0.0067 |     568 B |
| MemoryPack              | Seria(...)tives [29] |    96.58 ns |  0.373 ns | 0.020 ns |    96.57 ns |    96.61 ns | 0.0014 |     120 B |
