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
| SystemTextJson          | Seria(...)tives [29] | 971.88 ns | 18.03 ns | 0.988 ns | 970.87 ns | 972.84 ns | 0.0038 |     464 B |
| SystemTextJsonSourceGen | Seria(...)tives [29] | 902.20 ns | 51.41 ns | 2.818 ns | 898.96 ns | 904.12 ns | 0.0067 |     568 B |
| MemoryPack              | Seria(...)tives [29] |  96.75 ns | 48.50 ns | 2.659 ns |  94.94 ns |  99.81 ns | 0.0014 |     120 B |
