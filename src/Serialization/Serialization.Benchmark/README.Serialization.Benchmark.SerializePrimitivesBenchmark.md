```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.201
  [Host]   : .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                  | data                 | Mean     | Error     | StdDev  | Min      | Max      | Gen0   | Allocated |
|------------------------ |--------------------- |---------:|----------:|--------:|---------:|---------:|-------:|----------:|
| SystemTextJson          | Seria(...)tives [29] | 973.9 ns | 162.28 ns | 8.90 ns | 968.6 ns | 984.2 ns | 0.0038 |     440 B |
| SystemTextJsonSourceGen | Seria(...)tives [29] | 925.7 ns |  54.09 ns | 2.97 ns | 923.7 ns | 929.1 ns | 0.0057 |     544 B |
