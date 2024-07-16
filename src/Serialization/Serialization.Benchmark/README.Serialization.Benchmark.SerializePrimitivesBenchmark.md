```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.303
  [Host]   : .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                  | data                 | Mean      | Error    | StdDev   | Min       | Max       | Gen0   | Allocated |
|------------------------ |--------------------- |----------:|---------:|---------:|----------:|----------:|-------:|----------:|
| SystemTextJson          | Seria(...)tives [29] | 994.40 ns | 30.83 ns | 1.690 ns | 992.67 ns | 996.05 ns | 0.0038 |     464 B |
| SystemTextJsonSourceGen | Seria(...)tives [29] | 899.33 ns | 14.38 ns | 0.788 ns | 898.43 ns | 899.90 ns | 0.0067 |     568 B |
| MemoryPack              | Seria(...)tives [29] |  93.04 ns | 28.81 ns | 1.579 ns |  92.04 ns |  94.86 ns | 0.0014 |     120 B |
