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
| SystemTextJson          | Seria(...)Class [26] | 446.4 ns | 12.49 ns | 0.68 ns | 446.0 ns | 447.2 ns | 0.0038 |     328 B |
| SystemTextJsonSourceGen | Seria(...)Class [26] | 357.8 ns |  3.34 ns | 0.18 ns | 357.6 ns | 358.0 ns | 0.0043 |     368 B |
| MemoryPack              | Seria(...)Class [26] | 102.3 ns |  7.18 ns | 0.39 ns | 101.9 ns | 102.5 ns | 0.0014 |     128 B |
