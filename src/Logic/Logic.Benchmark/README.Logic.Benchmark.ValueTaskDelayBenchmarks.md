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
| TaskDelay      | .NET 8.0 | 1      | 10.20 ms | 0.599 ms | 0.033 ms | 10.17 ms | 10.23 ms |     352 B |
| ValueTaskDelay | .NET 8.0 | 1      | 10.12 ms | 0.237 ms | 0.013 ms | 10.11 ms | 10.13 ms |     128 B |
| TaskDelay      | .NET 9.0 | 1      | 10.22 ms | 0.354 ms | 0.019 ms | 10.20 ms | 10.24 ms |     352 B |
| ValueTaskDelay | .NET 9.0 | 1      | 10.12 ms | 0.180 ms | 0.010 ms | 10.11 ms | 10.13 ms |     128 B |
