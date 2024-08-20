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
| SystemTextJson          | Seria(...)Class [26] | 442.5 ns | 40.47 ns | 2.22 ns | 440.4 ns | 444.8 ns | 0.0038 |     328 B |
| SystemTextJsonSourceGen | Seria(...)Class [26] | 346.9 ns |  9.27 ns | 0.51 ns | 346.5 ns | 347.4 ns | 0.0043 |     368 B |
| MemoryPack              | Seria(...)Class [26] | 104.8 ns |  5.42 ns | 0.30 ns | 104.4 ns | 105.0 ns | 0.0014 |     128 B |
