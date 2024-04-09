```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.203
  [Host]   : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                  | data                 | Mean     | Error     | StdDev  | Min      | Max      | Gen0   | Allocated |
|------------------------ |--------------------- |---------:|----------:|--------:|---------:|---------:|-------:|----------:|
| SystemTextJson          | Seria(...)Class [26] | 448.9 ns |   2.82 ns | 0.15 ns | 448.8 ns | 449.1 ns | 0.0038 |     328 B |
| SystemTextJsonSourceGen | Seria(...)Class [26] | 335.5 ns | 126.11 ns | 6.91 ns | 331.1 ns | 343.5 ns | 0.0043 |     368 B |
| MemoryPack              | Seria(...)Class [26] | 102.1 ns |   2.83 ns | 0.16 ns | 102.0 ns | 102.3 ns | 0.0014 |     128 B |
