```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.203
  [Host]   : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                  | data                 | Mean      | Error    | StdDev   | Min       | Max       | Gen0   | Allocated |
|------------------------ |--------------------- |----------:|---------:|---------:|----------:|----------:|-------:|----------:|
| SystemTextJson          | Seria(...)tives [29] | 981.02 ns | 14.69 ns | 0.805 ns | 980.16 ns | 981.76 ns | 0.0038 |     464 B |
| SystemTextJsonSourceGen | Seria(...)tives [29] | 931.37 ns | 59.07 ns | 3.238 ns | 928.68 ns | 934.97 ns | 0.0067 |     568 B |
| MemoryPack              | Seria(...)tives [29] |  92.48 ns | 15.26 ns | 0.836 ns |  91.91 ns |  93.44 ns | 0.0014 |     120 B |
