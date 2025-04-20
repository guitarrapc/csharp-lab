```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.2 LTS (Noble Numbat)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.203
  [Host]            : .NET 9.0.4 (9.0.425.16305), X64 RyuJIT AVX2
  ShortRun-.NET 8.0 : .NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
  ShortRun-.NET 9.0 : .NET 9.0.4 (9.0.425.16305), X64 RyuJIT AVX2

IterationCount=3  LaunchCount=1  WarmupCount=3  

```
| Method             | Runtime  | Number | Mean        | Error     | StdDev    | Min         | Max         | Allocated |
|------------------- |--------- |------- |------------:|----------:|----------:|------------:|------------:|----------:|
| **NewFromCidrString**  | **.NET 8.0** | **1**      |  **65.8658 ns** | **8.6573 ns** | **0.4745 ns** |  **65.4177 ns** |  **66.3630 ns** |         **-** |
| NewFromCirBytes    | .NET 8.0 | 1      |   0.0181 ns | 0.0272 ns | 0.0015 ns |   0.0164 ns |   0.0190 ns |         - |
| TryParseCidrString | .NET 8.0 | 1      |  72.6840 ns | 4.9292 ns | 0.2702 ns |  72.4553 ns |  72.9821 ns |         - |
| TryParseCidrBytes  | .NET 8.0 | 1      |   2.7942 ns | 1.0464 ns | 0.0574 ns |   2.7607 ns |   2.8604 ns |         - |
| NewFromCidrString  | .NET 9.0 | 1      |  50.2852 ns | 0.4553 ns | 0.0250 ns |  50.2564 ns |  50.3005 ns |         - |
| NewFromCirBytes    | .NET 9.0 | 1      |   0.6254 ns | 0.1200 ns | 0.0066 ns |   0.6212 ns |   0.6330 ns |         - |
| TryParseCidrString | .NET 9.0 | 1      |  52.6444 ns | 2.5073 ns | 0.1374 ns |  52.5322 ns |  52.7977 ns |         - |
| TryParseCidrBytes  | .NET 9.0 | 1      |   3.1098 ns | 0.3295 ns | 0.0181 ns |   3.0891 ns |   3.1225 ns |         - |
| **NewFromCidrString**  | **.NET 8.0** | **3**      | **197.0324 ns** | **5.6983 ns** | **0.3123 ns** | **196.8131 ns** | **197.3901 ns** |         **-** |
| NewFromCirBytes    | .NET 8.0 | 3      |   0.6810 ns | 0.9065 ns | 0.0497 ns |   0.6482 ns |   0.7381 ns |         - |
| TryParseCidrString | .NET 8.0 | 3      | 212.1742 ns | 3.7238 ns | 0.2041 ns | 211.9915 ns | 212.3945 ns |         - |
| TryParseCidrBytes  | .NET 8.0 | 3      |   9.3222 ns | 1.0339 ns | 0.0567 ns |   9.2803 ns |   9.3867 ns |         - |
| NewFromCidrString  | .NET 9.0 | 3      | 147.9964 ns | 1.3176 ns | 0.0722 ns | 147.9130 ns | 148.0390 ns |         - |
| NewFromCirBytes    | .NET 9.0 | 3      |   0.6288 ns | 0.1379 ns | 0.0076 ns |   0.6204 ns |   0.6351 ns |         - |
| TryParseCidrString | .NET 9.0 | 3      | 155.7971 ns | 5.5022 ns | 0.3016 ns | 155.4505 ns | 155.9990 ns |         - |
| TryParseCidrBytes  | .NET 9.0 | 3      |   9.3687 ns | 0.5076 ns | 0.0278 ns |   9.3369 ns |   9.3882 ns |         - |
