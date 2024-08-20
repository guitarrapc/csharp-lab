```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.401
  [Host]   : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                  | data                 | Mean        | Error      | StdDev   | Min       | Max         | Gen0   | Allocated |
|------------------------ |--------------------- |------------:|-----------:|---------:|----------:|------------:|-------:|----------:|
| SystemTextJson          | Seria(...)tives [29] | 1,001.86 ns | 173.400 ns | 9.505 ns | 990.90 ns | 1,007.76 ns | 0.0038 |     464 B |
| SystemTextJsonSourceGen | Seria(...)tives [29] |   916.19 ns |   4.555 ns | 0.250 ns | 915.93 ns |   916.42 ns | 0.0067 |     568 B |
| MemoryPack              | Seria(...)tives [29] |    93.45 ns |   4.023 ns | 0.221 ns |  93.20 ns |    93.59 ns | 0.0014 |     120 B |
