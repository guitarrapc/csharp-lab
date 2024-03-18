```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.203
  [Host]   : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                  | data                 | Mean      | Error      | StdDev    | Min       | Max       | Gen0   | Allocated |
|------------------------ |--------------------- |----------:|-----------:|----------:|----------:|----------:|-------:|----------:|
| SystemTextJson          | Seria(...)tives [29] | 985.66 ns |   7.703 ns |  0.422 ns | 985.36 ns | 986.15 ns | 0.0038 |     464 B |
| SystemTextJsonSourceGen | Seria(...)tives [29] | 923.63 ns | 436.684 ns | 23.936 ns | 907.09 ns | 951.08 ns | 0.0067 |     568 B |
| MemoryPack              | Seria(...)tives [29] |  91.60 ns |   3.082 ns |  0.169 ns |  91.50 ns |  91.79 ns | 0.0014 |     120 B |
