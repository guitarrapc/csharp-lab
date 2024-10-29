```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.403
  [Host]   : .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                  | data                 | Mean     | Error     | StdDev  | Min      | Max      | Gen0   | Allocated |
|------------------------ |--------------------- |---------:|----------:|--------:|---------:|---------:|-------:|----------:|
| SystemTextJson          | Seria(...)Class [26] | 435.6 ns | 112.79 ns | 6.18 ns | 431.9 ns | 442.8 ns | 0.0038 |     328 B |
| SystemTextJsonSourceGen | Seria(...)Class [26] | 342.1 ns |  19.28 ns | 1.06 ns | 341.1 ns | 343.2 ns | 0.0043 |     368 B |
| MemoryPack              | Seria(...)Class [26] | 110.6 ns |   1.98 ns | 0.11 ns | 110.4 ns | 110.6 ns | 0.0014 |     128 B |
