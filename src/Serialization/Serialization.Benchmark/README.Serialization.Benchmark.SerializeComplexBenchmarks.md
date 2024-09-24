```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.401
  [Host]   : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                  | data                 | Mean      | Error     | StdDev   | Min       | Max       | Gen0   | Allocated |
|------------------------ |--------------------- |----------:|----------:|---------:|----------:|----------:|-------:|----------:|
| SystemTextJson          | Seria(...)Class [29] | 658.41 ns |  8.989 ns | 0.493 ns | 657.95 ns | 658.93 ns | 0.0038 |     392 B |
| SystemTextJsonSourceGen | Seria(...)Class [29] | 690.40 ns | 21.200 ns | 1.162 ns | 689.32 ns | 691.63 ns | 0.0048 |     464 B |
| MemoryPack              | Seria(...)Class [29] |  57.47 ns |  8.544 ns | 0.468 ns |  56.93 ns |  57.75 ns | 0.0014 |     120 B |
