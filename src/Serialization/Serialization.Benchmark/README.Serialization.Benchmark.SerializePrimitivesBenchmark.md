```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.301
  [Host]   : .NET 8.0.6 (8.0.624.26715), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.6 (8.0.624.26715), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                  | data                 | Mean      | Error      | StdDev   | Min       | Max       | Gen0   | Allocated |
|------------------------ |--------------------- |----------:|-----------:|---------:|----------:|----------:|-------:|----------:|
| SystemTextJson          | Seria(...)tives [29] | 976.48 ns | 116.133 ns | 6.366 ns | 970.29 ns | 983.00 ns | 0.0038 |     464 B |
| SystemTextJsonSourceGen | Seria(...)tives [29] | 924.14 ns |  58.260 ns | 3.193 ns | 920.67 ns | 926.96 ns | 0.0067 |     568 B |
| MemoryPack              | Seria(...)tives [29] |  93.37 ns |   6.856 ns | 0.376 ns |  92.95 ns |  93.67 ns | 0.0014 |     120 B |
