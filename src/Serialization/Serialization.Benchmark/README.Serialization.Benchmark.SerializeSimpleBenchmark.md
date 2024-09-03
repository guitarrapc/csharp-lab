```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.401
  [Host]   : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                  | data                 | Mean     | Error     | StdDev  | Min      | Max      | Gen0   | Allocated |
|------------------------ |--------------------- |---------:|----------:|--------:|---------:|---------:|-------:|----------:|
| SystemTextJson          | Seria(...)Class [26] | 465.3 ns |  61.45 ns | 3.37 ns | 462.7 ns | 469.1 ns | 0.0038 |     328 B |
| SystemTextJsonSourceGen | Seria(...)Class [26] | 384.8 ns | 102.85 ns | 5.64 ns | 378.7 ns | 389.8 ns | 0.0043 |     368 B |
| MemoryPack              | Seria(...)Class [26] | 110.1 ns |  10.09 ns | 0.55 ns | 109.5 ns | 110.5 ns | 0.0014 |     128 B |
