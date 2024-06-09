```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.301
  [Host]   : .NET 8.0.6 (8.0.624.26715), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.6 (8.0.624.26715), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                  | data                 | Mean      | Error     | StdDev   | Min       | Max       | Gen0   | Allocated |
|------------------------ |--------------------- |----------:|----------:|---------:|----------:|----------:|-------:|----------:|
| SystemTextJson          | Seria(...)tives [29] | 991.84 ns | 69.330 ns | 3.800 ns | 987.48 ns | 994.44 ns | 0.0038 |     464 B |
| SystemTextJsonSourceGen | Seria(...)tives [29] | 901.09 ns | 35.316 ns | 1.936 ns | 898.86 ns | 902.31 ns | 0.0067 |     568 B |
| MemoryPack              | Seria(...)tives [29] |  92.08 ns |  5.555 ns | 0.305 ns |  91.87 ns |  92.43 ns | 0.0014 |     120 B |
