```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.203
  [Host]   : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                  | data                 | Mean      | Error     | StdDev   | Min       | Max         | Gen0   | Allocated |
|------------------------ |--------------------- |----------:|----------:|---------:|----------:|------------:|-------:|----------:|
| SystemTextJson          | Seria(...)tives [29] | 998.48 ns | 48.649 ns | 2.667 ns | 996.83 ns | 1,001.56 ns | 0.0038 |     464 B |
| SystemTextJsonSourceGen | Seria(...)tives [29] | 915.13 ns | 23.279 ns | 1.276 ns | 913.67 ns |   916.00 ns | 0.0067 |     568 B |
| MemoryPack              | Seria(...)tives [29] |  94.79 ns |  7.394 ns | 0.405 ns |  94.47 ns |    95.25 ns | 0.0014 |     120 B |
