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
| SystemTextJson          | Seria(...)tives [29] | 966.60 ns |  55.966 ns |  3.068 ns | 964.68 ns | 970.14 ns | 0.0038 |     464 B |
| SystemTextJsonSourceGen | Seria(...)tives [29] | 881.94 ns | 295.253 ns | 16.184 ns | 871.02 ns | 900.53 ns | 0.0067 |     568 B |
| MemoryPack              | Seria(...)tives [29] |  80.33 ns |   0.297 ns |  0.016 ns |  80.31 ns |  80.34 ns | 0.0014 |     120 B |
