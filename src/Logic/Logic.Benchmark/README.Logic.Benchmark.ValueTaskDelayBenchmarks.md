```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.1 LTS (Noble Numbat)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.200
  [Host]            : .NET 9.0.2 (9.0.225.6610), X64 RyuJIT AVX2
  ShortRun-.NET 8.0 : .NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
  ShortRun-.NET 9.0 : .NET 9.0.2 (9.0.225.6610), X64 RyuJIT AVX2

IterationCount=3  LaunchCount=1  WarmupCount=3  

```
| Method         | Runtime  | Number | Mean     | Error    | StdDev   | Min      | Max      | Allocated |
|--------------- |--------- |------- |---------:|---------:|---------:|---------:|---------:|----------:|
| TaskDelay      | .NET 8.0 | 1      | 10.21 ms | 0.729 ms | 0.040 ms | 10.16 ms | 10.24 ms |     352 B |
| ValueTaskDelay | .NET 8.0 | 1      | 10.16 ms | 0.186 ms | 0.010 ms | 10.15 ms | 10.17 ms |     128 B |
| TaskDelay      | .NET 9.0 | 1      | 10.19 ms | 0.148 ms | 0.008 ms | 10.18 ms | 10.20 ms |     352 B |
| ValueTaskDelay | .NET 9.0 | 1      | 10.14 ms | 0.193 ms | 0.011 ms | 10.14 ms | 10.15 ms |     128 B |
