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
| SystemTextJson          | Seria(...)Class [26] | 422.9 ns | 14.95 ns | 0.82 ns | 422.2 ns | 423.8 ns | 0.0038 |     328 B |
| SystemTextJsonSourceGen | Seria(...)Class [26] | 330.6 ns | 16.00 ns | 0.88 ns | 329.6 ns | 331.2 ns | 0.0043 |     368 B |
| MemoryPack              | Seria(...)Class [26] | 102.5 ns |  8.36 ns | 0.46 ns | 102.0 ns | 102.9 ns | 0.0014 |     128 B |
