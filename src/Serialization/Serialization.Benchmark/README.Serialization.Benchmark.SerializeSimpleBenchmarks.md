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
| SystemTextJson          | Seria(...)Class [26] | 444.2 ns |  6.37 ns | 0.35 ns | 443.9 ns | 444.6 ns | 0.0038 |     328 B |
| SystemTextJsonSourceGen | Seria(...)Class [26] | 338.0 ns | 11.64 ns | 0.64 ns | 337.5 ns | 338.7 ns | 0.0043 |     368 B |
| MemoryPack              | Seria(...)Class [26] | 100.4 ns |  2.20 ns | 0.12 ns | 100.3 ns | 100.5 ns | 0.0014 |     128 B |
