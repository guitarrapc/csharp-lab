```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.401
  [Host]   : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                  | data                 | Mean      | Error    | StdDev   | Min       | Max       | Gen0   | Allocated |
|------------------------ |--------------------- |----------:|---------:|---------:|----------:|----------:|-------:|----------:|
| SystemTextJson          | Seria(...)tives [29] | 998.61 ns | 4.643 ns | 0.254 ns | 998.32 ns | 998.79 ns | 0.0038 |     464 B |
| SystemTextJsonSourceGen | Seria(...)tives [29] | 910.12 ns | 5.766 ns | 0.316 ns | 909.75 ns | 910.31 ns | 0.0067 |     568 B |
| MemoryPack              | Seria(...)tives [29] |  91.86 ns | 2.863 ns | 0.157 ns |  91.68 ns |  91.98 ns | 0.0014 |     120 B |
