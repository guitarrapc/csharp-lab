```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.303
  [Host]   : .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                  | data                 | Mean      | Error      | StdDev    | Min       | Max       | Gen0   | Allocated |
|------------------------ |--------------------- |----------:|-----------:|----------:|----------:|----------:|-------:|----------:|
| SystemTextJson          | Seria(...)Class [29] | 653.75 ns | 147.349 ns |  8.077 ns | 644.47 ns | 659.19 ns | 0.0038 |     392 B |
| SystemTextJsonSourceGen | Seria(...)Class [29] | 708.18 ns | 187.882 ns | 10.298 ns | 700.10 ns | 719.78 ns | 0.0048 |     464 B |
| MemoryPack              | Seria(...)Class [29] |  58.82 ns |   7.242 ns |  0.397 ns |  58.49 ns |  59.26 ns | 0.0014 |     120 B |
