```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.203
  [Host]   : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                  | data                 | Mean     | Error     | StdDev   | Min      | Max      | Gen0   | Allocated |
|------------------------ |--------------------- |---------:|----------:|---------:|---------:|---------:|-------:|----------:|
| SystemTextJson          | Seria(...)Class [26] | 453.4 ns | 392.32 ns | 21.50 ns | 440.4 ns | 478.2 ns | 0.0038 |     328 B |
| SystemTextJsonSourceGen | Seria(...)Class [26] | 351.4 ns |   7.54 ns |  0.41 ns | 351.0 ns | 351.7 ns | 0.0043 |     368 B |
| MemoryPack              | Seria(...)Class [26] | 107.3 ns |  55.46 ns |  3.04 ns | 105.5 ns | 110.9 ns | 0.0014 |     128 B |
