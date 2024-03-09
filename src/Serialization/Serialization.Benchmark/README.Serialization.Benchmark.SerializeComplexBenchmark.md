```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.201
  [Host]   : .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                  | data                 | Mean      | Error      | StdDev   | Min       | Max       | Gen0   | Allocated |
|------------------------ |--------------------- |----------:|-----------:|---------:|----------:|----------:|-------:|----------:|
| SystemTextJson          | Seria(...)Class [29] | 644.74 ns |   5.008 ns | 0.275 ns | 644.43 ns | 644.94 ns | 0.0038 |     392 B |
| SystemTextJsonSourceGen | Seria(...)Class [29] | 701.76 ns | 144.991 ns | 7.947 ns | 693.77 ns | 709.67 ns | 0.0048 |     464 B |
| MemoryPack              | Seria(...)Class [29] |  58.34 ns |   6.296 ns | 0.345 ns |  58.12 ns |  58.73 ns | 0.0014 |     120 B |
