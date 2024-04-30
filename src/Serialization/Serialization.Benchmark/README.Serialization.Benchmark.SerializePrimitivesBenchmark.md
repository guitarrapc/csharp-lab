```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.204
  [Host]   : .NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                  | data                 | Mean      | Error    | StdDev   | Min       | Max       | Gen0   | Allocated |
|------------------------ |--------------------- |----------:|---------:|---------:|----------:|----------:|-------:|----------:|
| SystemTextJson          | Seria(...)tives [29] | 975.58 ns | 25.97 ns | 1.424 ns | 974.72 ns | 977.23 ns | 0.0038 |     464 B |
| SystemTextJsonSourceGen | Seria(...)tives [29] | 911.29 ns | 12.35 ns | 0.677 ns | 910.76 ns | 912.05 ns | 0.0067 |     568 B |
| MemoryPack              | Seria(...)tives [29] |  93.48 ns | 12.22 ns | 0.670 ns |  93.09 ns |  94.25 ns | 0.0014 |     120 B |
