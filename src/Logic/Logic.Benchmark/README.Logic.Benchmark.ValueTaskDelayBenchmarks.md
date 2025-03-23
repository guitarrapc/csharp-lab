```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.2 LTS (Noble Numbat)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.202
  [Host]            : .NET 9.0.3 (9.0.325.11113), X64 RyuJIT AVX2
  ShortRun-.NET 8.0 : .NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
  ShortRun-.NET 9.0 : .NET 9.0.3 (9.0.325.11113), X64 RyuJIT AVX2

IterationCount=3  LaunchCount=1  WarmupCount=3  

```
| Method         | Runtime  | Number | Mean     | Error    | StdDev   | Min      | Max      | Allocated |
|--------------- |--------- |------- |---------:|---------:|---------:|---------:|---------:|----------:|
| TaskDelay      | .NET 8.0 | 1      | 10.16 ms | 0.414 ms | 0.023 ms | 10.14 ms | 10.19 ms |     352 B |
| ValueTaskDelay | .NET 8.0 | 1      | 10.14 ms | 0.147 ms | 0.008 ms | 10.13 ms | 10.14 ms |     128 B |
| TaskDelay      | .NET 9.0 | 1      | 10.17 ms | 0.393 ms | 0.022 ms | 10.15 ms | 10.19 ms |     352 B |
| ValueTaskDelay | .NET 9.0 | 1      | 10.12 ms | 0.115 ms | 0.006 ms | 10.12 ms | 10.13 ms |     128 B |
