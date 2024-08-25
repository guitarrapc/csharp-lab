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
| SystemTextJson          | Seria(...)Class [29] | 656.07 ns | 78.716 ns | 4.315 ns | 653.33 ns | 661.05 ns | 0.0038 |     392 B |
| SystemTextJsonSourceGen | Seria(...)Class [29] | 683.83 ns | 29.748 ns | 1.631 ns | 682.02 ns | 685.18 ns | 0.0048 |     464 B |
| MemoryPack              | Seria(...)Class [29] |  57.35 ns |  1.881 ns | 0.103 ns |  57.27 ns |  57.46 ns | 0.0014 |     120 B |
