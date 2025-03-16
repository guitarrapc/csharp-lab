```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.2 LTS (Noble Numbat)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.201
  [Host]            : .NET 9.0.3 (9.0.325.11113), X64 RyuJIT AVX2
  ShortRun-.NET 8.0 : .NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
  ShortRun-.NET 9.0 : .NET 9.0.3 (9.0.325.11113), X64 RyuJIT AVX2

IterationCount=3  LaunchCount=1  WarmupCount=3  

```
| Method             | Runtime  | Number | Mean       | Error     | StdDev   | Min        | Max        | Gen0   | Gen1   | Allocated |
|------------------- |--------- |------- |-----------:|----------:|---------:|-----------:|-----------:|-------:|-------:|----------:|
| StringSplitNoAlloc | .NET 8.0 | 1      |   846.7 ns |  57.34 ns |  3.14 ns |   844.7 ns |   850.3 ns |      - |      - |         - |
| StringSplit        | .NET 8.0 | 1      | 1,461.8 ns | 207.55 ns | 11.38 ns | 1,448.9 ns | 1,470.5 ns | 0.1907 | 0.0019 |    3208 B |
| StringSplitNoAlloc | .NET 9.0 | 1      |   859.2 ns |  31.65 ns |  1.73 ns |   857.3 ns |   860.6 ns |      - |      - |         - |
| StringSplit        | .NET 9.0 | 1      | 1,409.5 ns | 144.38 ns |  7.91 ns | 1,400.9 ns | 1,416.5 ns | 0.1907 | 0.0019 |    3208 B |
