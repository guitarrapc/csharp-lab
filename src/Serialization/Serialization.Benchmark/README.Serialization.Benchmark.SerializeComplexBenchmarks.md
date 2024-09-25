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
| SystemTextJson          | Seria(...)Class [29] | 663.87 ns | 89.212 ns | 4.890 ns | 660.08 ns | 669.39 ns | 0.0038 |     392 B |
| SystemTextJsonSourceGen | Seria(...)Class [29] | 702.13 ns | 19.763 ns | 1.083 ns | 701.30 ns | 703.35 ns | 0.0048 |     464 B |
| MemoryPack              | Seria(...)Class [29] |  60.12 ns |  2.140 ns | 0.117 ns |  60.00 ns |  60.23 ns | 0.0014 |     120 B |
