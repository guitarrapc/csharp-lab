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
| SystemTextJson          | Seria(...)Class [26] | 446.5 ns | 21.13 ns | 1.16 ns | 445.4 ns | 447.7 ns | 0.0038 |     328 B |
| SystemTextJsonSourceGen | Seria(...)Class [26] | 342.4 ns | 11.74 ns | 0.64 ns | 341.8 ns | 343.1 ns | 0.0043 |     368 B |
| MemoryPack              | Seria(...)Class [26] | 102.2 ns |  5.64 ns | 0.31 ns | 102.0 ns | 102.6 ns | 0.0014 |     128 B |
