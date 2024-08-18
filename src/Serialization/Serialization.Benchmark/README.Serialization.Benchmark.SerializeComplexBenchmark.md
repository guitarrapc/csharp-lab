```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.401
  [Host]   : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                  | data                 | Mean      | Error     | StdDev   | Min       | Max       | Gen0   | Allocated |
|------------------------ |--------------------- |----------:|----------:|---------:|----------:|----------:|-------:|----------:|
| SystemTextJson          | Seria(...)Class [29] | 660.90 ns | 32.809 ns | 1.798 ns | 659.53 ns | 662.94 ns | 0.0038 |     392 B |
| SystemTextJsonSourceGen | Seria(...)Class [29] | 706.82 ns |  9.669 ns | 0.530 ns | 706.26 ns | 707.32 ns | 0.0048 |     464 B |
| MemoryPack              | Seria(...)Class [29] |  60.98 ns |  3.969 ns | 0.218 ns |  60.73 ns |  61.11 ns | 0.0014 |     120 B |
