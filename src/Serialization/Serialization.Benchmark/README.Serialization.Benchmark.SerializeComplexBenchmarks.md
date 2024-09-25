```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.402
  [Host]   : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                  | data                 | Mean      | Error     | StdDev   | Min       | Max       | Gen0   | Allocated |
|------------------------ |--------------------- |----------:|----------:|---------:|----------:|----------:|-------:|----------:|
| SystemTextJson          | Seria(...)Class [29] | 647.92 ns | 21.641 ns | 1.186 ns | 646.64 ns | 648.99 ns | 0.0038 |     392 B |
| SystemTextJsonSourceGen | Seria(...)Class [29] | 703.23 ns | 15.701 ns | 0.861 ns | 702.40 ns | 704.12 ns | 0.0048 |     464 B |
| MemoryPack              | Seria(...)Class [29] |  59.44 ns |  3.299 ns | 0.181 ns |  59.24 ns |  59.60 ns | 0.0014 |     120 B |
