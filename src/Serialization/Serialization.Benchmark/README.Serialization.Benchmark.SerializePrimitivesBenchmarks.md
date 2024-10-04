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
| SystemTextJson          | Seria(...)tives [29] | 1,031.82 ns | 24.126 ns | 1.322 ns | 1,030.60 ns | 1,033.22 ns | 0.0038 |     464 B |
| SystemTextJsonSourceGen | Seria(...)tives [29] |   922.76 ns | 12.386 ns | 0.679 ns |   921.98 ns |   923.23 ns | 0.0067 |     568 B |
| MemoryPack              | Seria(...)tives [29] |    94.06 ns |  3.060 ns | 0.168 ns |    93.95 ns |    94.25 ns | 0.0014 |     120 B |
