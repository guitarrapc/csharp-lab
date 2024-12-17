```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.101
  [Host]   : .NET 9.0.0 (9.0.24.52809), X64 RyuJIT AVX2
  ShortRun : .NET 9.0.0 (9.0.24.52809), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                  | data                 | Mean      | Error      | StdDev    | Min       | Max       | Gen0   | Allocated |
|------------------------ |--------------------- |----------:|-----------:|----------:|----------:|----------:|-------:|----------:|
| SystemTextJson          | Seria(...)tives [29] | 954.84 ns |  40.850 ns |  2.239 ns | 953.14 ns | 957.37 ns | 0.0038 |     464 B |
| SystemTextJsonSourceGen | Seria(...)tives [29] | 899.27 ns | 296.488 ns | 16.252 ns | 884.26 ns | 916.53 ns | 0.0067 |     568 B |
| MemoryPack              | Seria(...)tives [29] |  80.91 ns |   1.989 ns |  0.109 ns |  80.83 ns |  81.03 ns | 0.0014 |     120 B |
