```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.402
  [Host]   : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                  | data                 | Mean      | Error      | StdDev    | Min       | Max       | Gen0   | Allocated |
|------------------------ |--------------------- |----------:|-----------:|----------:|----------:|----------:|-------:|----------:|
| SystemTextJson          | Seria(...)tives [29] | 958.43 ns | 242.907 ns | 13.315 ns | 945.99 ns | 972.47 ns | 0.0038 |     464 B |
| SystemTextJsonSourceGen | Seria(...)tives [29] | 878.16 ns | 114.954 ns |  6.301 ns | 870.89 ns | 881.92 ns | 0.0067 |     568 B |
| MemoryPack              | Seria(...)tives [29] |  87.90 ns |   9.322 ns |  0.511 ns |  87.32 ns |  88.28 ns | 0.0014 |     120 B |
