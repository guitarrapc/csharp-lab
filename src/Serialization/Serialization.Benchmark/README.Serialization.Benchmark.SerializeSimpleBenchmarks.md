```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.403
  [Host]   : .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                  | data                 | Mean     | Error    | StdDev  | Min      | Max      | Gen0   | Allocated |
|------------------------ |--------------------- |---------:|---------:|--------:|---------:|---------:|-------:|----------:|
| SystemTextJson          | Seria(...)Class [26] | 428.0 ns | 16.66 ns | 0.91 ns | 427.1 ns | 428.9 ns | 0.0038 |     328 B |
| SystemTextJsonSourceGen | Seria(...)Class [26] | 336.5 ns | 16.78 ns | 0.92 ns | 336.0 ns | 337.6 ns | 0.0043 |     368 B |
| MemoryPack              | Seria(...)Class [26] | 103.6 ns |  3.76 ns | 0.21 ns | 103.4 ns | 103.8 ns | 0.0014 |     128 B |
