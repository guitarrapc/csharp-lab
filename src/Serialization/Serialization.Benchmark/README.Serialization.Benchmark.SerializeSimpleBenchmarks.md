```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.401
  [Host]   : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                  | data                 | Mean     | Error    | StdDev  | Min      | Max      | Gen0   | Allocated |
|------------------------ |--------------------- |---------:|---------:|--------:|---------:|---------:|-------:|----------:|
| SystemTextJson          | Seria(...)Class [26] | 448.4 ns | 26.04 ns | 1.43 ns | 447.0 ns | 449.9 ns | 0.0038 |     328 B |
| SystemTextJsonSourceGen | Seria(...)Class [26] | 343.7 ns | 16.99 ns | 0.93 ns | 342.6 ns | 344.3 ns | 0.0043 |     368 B |
| MemoryPack              | Seria(...)Class [26] | 105.5 ns |  3.95 ns | 0.22 ns | 105.4 ns | 105.8 ns | 0.0014 |     128 B |
