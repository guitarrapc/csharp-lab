```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.203
  [Host]   : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                  | data                 | Mean     | Error    | StdDev  | Min      | Max      | Gen0   | Allocated |
|------------------------ |--------------------- |---------:|---------:|--------:|---------:|---------:|-------:|----------:|
| SystemTextJson          | Seria(...)Class [26] | 453.6 ns |  9.60 ns | 0.53 ns | 453.0 ns | 453.9 ns | 0.0038 |     328 B |
| SystemTextJsonSourceGen | Seria(...)Class [26] | 379.2 ns | 60.36 ns | 3.31 ns | 377.1 ns | 383.0 ns | 0.0043 |     368 B |
| MemoryPack              | Seria(...)Class [26] | 111.1 ns |  8.84 ns | 0.48 ns | 110.5 ns | 111.4 ns | 0.0014 |     128 B |
