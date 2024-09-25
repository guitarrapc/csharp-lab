```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.402
  [Host]   : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                  | data                 | Mean     | Error    | StdDev  | Min      | Max      | Gen0   | Allocated |
|------------------------ |--------------------- |---------:|---------:|--------:|---------:|---------:|-------:|----------:|
| SystemTextJson          | Seria(...)Class [26] | 394.3 ns | 17.16 ns | 0.94 ns | 393.4 ns | 395.3 ns | 0.0038 |     328 B |
| SystemTextJsonSourceGen | Seria(...)Class [26] | 345.0 ns |  2.33 ns | 0.13 ns | 344.9 ns | 345.1 ns | 0.0043 |     368 B |
| MemoryPack              | Seria(...)Class [26] | 107.1 ns |  4.10 ns | 0.22 ns | 107.0 ns | 107.4 ns | 0.0014 |     128 B |
