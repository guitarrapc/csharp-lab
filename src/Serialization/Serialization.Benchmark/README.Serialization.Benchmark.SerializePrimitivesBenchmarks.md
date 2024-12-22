```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.101
  [Host]   : .NET 9.0.0 (9.0.24.52809), X64 RyuJIT AVX2
  ShortRun : .NET 9.0.0 (9.0.24.52809), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                  | data                 | Mean      | Error     | StdDev   | Min       | Max       | Gen0   | Allocated |
|------------------------ |--------------------- |----------:|----------:|---------:|----------:|----------:|-------:|----------:|
| SystemTextJson          | Seria(...)tives [29] | 958.03 ns | 11.994 ns | 0.657 ns | 957.29 ns | 958.56 ns | 0.0038 |     464 B |
| SystemTextJsonSourceGen | Seria(...)tives [29] | 872.87 ns | 45.803 ns | 2.511 ns | 870.25 ns | 875.25 ns | 0.0067 |     568 B |
| MemoryPack              | Seria(...)tives [29] |  80.94 ns |  3.455 ns | 0.189 ns |  80.73 ns |  81.09 ns | 0.0014 |     120 B |
