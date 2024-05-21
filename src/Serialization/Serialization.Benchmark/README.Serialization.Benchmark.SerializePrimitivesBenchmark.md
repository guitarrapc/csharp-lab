```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.300
  [Host]   : .NET 8.0.5 (8.0.524.21615), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.5 (8.0.524.21615), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                  | data                 | Mean      | Error      | StdDev    | Min       | Max       | Gen0   | Allocated |
|------------------------ |--------------------- |----------:|-----------:|----------:|----------:|----------:|-------:|----------:|
| SystemTextJson          | Seria(...)tives [29] | 971.36 ns | 106.358 ns |  5.830 ns | 966.65 ns | 977.88 ns | 0.0038 |     464 B |
| SystemTextJsonSourceGen | Seria(...)tives [29] | 927.18 ns | 245.812 ns | 13.474 ns | 915.72 ns | 942.02 ns | 0.0067 |     568 B |
| MemoryPack              | Seria(...)tives [29] |  96.00 ns |   5.773 ns |  0.316 ns |  95.63 ns |  96.20 ns | 0.0014 |     120 B |
