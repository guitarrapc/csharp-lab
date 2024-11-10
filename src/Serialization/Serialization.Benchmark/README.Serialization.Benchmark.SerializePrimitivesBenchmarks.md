```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.403
  [Host]   : .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                  | data                 | Mean        | Error     | StdDev   | Min         | Max         | Gen0   | Allocated |
|------------------------ |--------------------- |------------:|----------:|---------:|------------:|------------:|-------:|----------:|
| SystemTextJson          | Seria(...)tives [29] | 1,003.38 ns | 52.536 ns | 2.880 ns | 1,001.64 ns | 1,006.70 ns | 0.0038 |     464 B |
| SystemTextJsonSourceGen | Seria(...)tives [29] |   915.40 ns |  5.510 ns | 0.302 ns |   915.23 ns |   915.75 ns | 0.0067 |     568 B |
| MemoryPack              | Seria(...)tives [29] |    92.32 ns |  2.386 ns | 0.131 ns |    92.20 ns |    92.46 ns | 0.0014 |     120 B |
