```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.201
  [Host]   : .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                  | data                 | Mean     | Error    | StdDev  | Min      | Max      | Gen0   | Allocated |
|------------------------ |--------------------- |---------:|---------:|--------:|---------:|---------:|-------:|----------:|
| SystemTextJson          | Seria(...)Class [29] | 617.2 ns | 32.29 ns | 1.77 ns | 616.0 ns | 619.2 ns | 0.0038 |     392 B |
| SystemTextJsonSourceGen | Seria(...)Class [29] | 697.1 ns | 27.17 ns | 1.49 ns | 696.0 ns | 698.8 ns | 0.0048 |     464 B |
