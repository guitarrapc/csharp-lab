```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.2 LTS (Noble Numbat)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.200
  [Host]            : .NET 9.0.2 (9.0.225.6610), X64 RyuJIT AVX2
  ShortRun-.NET 8.0 : .NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
  ShortRun-.NET 9.0 : .NET 9.0.2 (9.0.225.6610), X64 RyuJIT AVX2

IterationCount=3  LaunchCount=1  WarmupCount=3  

```
| Method             | Runtime  | Number | Mean       | Error     | StdDev   | Min        | Max        | Gen0   | Gen1   | Allocated |
|------------------- |--------- |------- |-----------:|----------:|---------:|-----------:|-----------:|-------:|-------:|----------:|
| StringSplitNoAlloc | .NET 8.0 | 1      |   846.2 ns | 217.23 ns | 11.91 ns |   837.8 ns |   859.9 ns |      - |      - |         - |
| StringSplit        | .NET 8.0 | 1      | 1,405.7 ns | 237.35 ns | 13.01 ns | 1,391.4 ns | 1,416.9 ns | 0.1907 | 0.0019 |    3208 B |
| StringSplitNoAlloc | .NET 9.0 | 1      |   892.9 ns |  90.02 ns |  4.93 ns |   889.3 ns |   898.5 ns |      - |      - |         - |
| StringSplit        | .NET 9.0 | 1      | 1,442.3 ns | 342.08 ns | 18.75 ns | 1,423.3 ns | 1,460.7 ns | 0.1907 | 0.0019 |    3208 B |
