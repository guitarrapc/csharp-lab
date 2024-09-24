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
| SystemTextJson          | Seria(...)Class [29] | 666.33 ns | 28.779 ns | 1.577 ns | 665.36 ns | 668.15 ns | 0.0038 |     392 B |
| SystemTextJsonSourceGen | Seria(...)Class [29] | 702.40 ns |  2.392 ns | 0.131 ns | 702.28 ns | 702.54 ns | 0.0048 |     464 B |
| MemoryPack              | Seria(...)Class [29] |  60.10 ns |  8.447 ns | 0.463 ns |  59.80 ns |  60.64 ns | 0.0014 |     120 B |
