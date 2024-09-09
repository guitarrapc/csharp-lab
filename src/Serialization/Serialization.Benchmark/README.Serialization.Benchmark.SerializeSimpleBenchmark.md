```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.401
  [Host]   : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                  | data                 | Mean     | Error    | StdDev  | Min      | Max      | Gen0   | Allocated |
|------------------------ |--------------------- |---------:|---------:|--------:|---------:|---------:|-------:|----------:|
| SystemTextJson          | Seria(...)Class [26] | 425.4 ns | 21.91 ns | 1.20 ns | 424.1 ns | 426.3 ns | 0.0038 |     328 B |
| SystemTextJsonSourceGen | Seria(...)Class [26] | 327.9 ns | 35.44 ns | 1.94 ns | 326.6 ns | 330.1 ns | 0.0043 |     368 B |
| MemoryPack              | Seria(...)Class [26] | 107.2 ns |  6.73 ns | 0.37 ns | 106.9 ns | 107.6 ns | 0.0014 |     128 B |
