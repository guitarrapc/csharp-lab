```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.2 LTS (Noble Numbat)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.202
  [Host]            : .NET 9.0.3 (9.0.325.11113), X64 RyuJIT AVX2
  ShortRun-.NET 8.0 : .NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
  ShortRun-.NET 9.0 : .NET 9.0.3 (9.0.325.11113), X64 RyuJIT AVX2

IterationCount=3  LaunchCount=1  WarmupCount=3  

```
| Method             | Runtime  | Number | Mean       | Error       | StdDev   | Min        | Max        | Gen0   | Gen1   | Allocated |
|------------------- |--------- |------- |-----------:|------------:|---------:|-----------:|-----------:|-------:|-------:|----------:|
| StringSplitNoAlloc | .NET 8.0 | 1      |   825.7 ns |    40.83 ns |  2.24 ns |   824.3 ns |   828.3 ns |      - |      - |         - |
| StringSplit        | .NET 8.0 | 1      | 1,315.4 ns |   189.99 ns | 10.41 ns | 1,303.9 ns | 1,324.2 ns | 0.1907 | 0.0019 |    3208 B |
| StringSplitNoAlloc | .NET 9.0 | 1      |   817.1 ns |   153.10 ns |  8.39 ns |   808.6 ns |   825.4 ns |      - |      - |         - |
| StringSplit        | .NET 9.0 | 1      | 1,288.5 ns | 1,710.32 ns | 93.75 ns | 1,200.7 ns | 1,387.2 ns | 0.1907 | 0.0019 |    3208 B |
