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
| SystemTextJson          | Seria(...)Class [29] | 643.94 ns | 43.066 ns | 2.361 ns | 641.94 ns | 646.54 ns | 0.0038 |     392 B |
| SystemTextJsonSourceGen | Seria(...)Class [29] | 712.04 ns | 58.040 ns | 3.181 ns | 710.19 ns | 715.72 ns | 0.0048 |     464 B |
| MemoryPack              | Seria(...)Class [29] |  58.42 ns |  3.323 ns | 0.182 ns |  58.27 ns |  58.62 ns | 0.0014 |     120 B |
