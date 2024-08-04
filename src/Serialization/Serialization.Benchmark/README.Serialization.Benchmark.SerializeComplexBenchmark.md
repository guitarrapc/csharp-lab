```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.303
  [Host]   : .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                  | data                 | Mean      | Error     | StdDev   | Min       | Max       | Gen0   | Allocated |
|------------------------ |--------------------- |----------:|----------:|---------:|----------:|----------:|-------:|----------:|
| SystemTextJson          | Seria(...)Class [29] | 685.01 ns |  7.669 ns | 0.420 ns | 684.55 ns | 685.38 ns | 0.0038 |     392 B |
| SystemTextJsonSourceGen | Seria(...)Class [29] | 731.33 ns | 53.078 ns | 2.909 ns | 729.30 ns | 734.66 ns | 0.0048 |     464 B |
| MemoryPack              | Seria(...)Class [29] |  60.25 ns |  1.599 ns | 0.088 ns |  60.19 ns |  60.35 ns | 0.0014 |     120 B |
