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
| SystemTextJson          | Seria(...)Class [26] | 447.6 ns |  1.36 ns | 0.07 ns | 447.6 ns | 447.7 ns | 0.0038 |     328 B |
| SystemTextJsonSourceGen | Seria(...)Class [26] | 346.4 ns | 16.42 ns | 0.90 ns | 345.6 ns | 347.4 ns | 0.0043 |     368 B |
| MemoryPack              | Seria(...)Class [26] | 102.2 ns |  1.53 ns | 0.08 ns | 102.1 ns | 102.2 ns | 0.0014 |     128 B |
