```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.401
  [Host]   : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                  | data                 | Mean     | Error   | StdDev  | Min      | Max      | Gen0   | Allocated |
|------------------------ |--------------------- |---------:|--------:|--------:|---------:|---------:|-------:|----------:|
| SystemTextJson          | Seria(...)Class [26] | 415.7 ns | 7.84 ns | 0.43 ns | 415.2 ns | 416.1 ns | 0.0038 |     328 B |
| SystemTextJsonSourceGen | Seria(...)Class [26] | 343.9 ns | 4.66 ns | 0.26 ns | 343.7 ns | 344.2 ns | 0.0043 |     368 B |
| MemoryPack              | Seria(...)Class [26] | 107.3 ns | 3.41 ns | 0.19 ns | 107.1 ns | 107.5 ns | 0.0014 |     128 B |
