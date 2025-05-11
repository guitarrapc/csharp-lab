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
| **NewFromCidrString**  | **.NET 8.0** | **1**      |  **66.5253 ns** | **3.0304 ns** | **0.1661 ns** |  **66.3748 ns** |  **66.7035 ns** |         **-** |
| NewFromCirBytes    | .NET 8.0 | 1      |   0.0264 ns | 0.0242 ns | 0.0013 ns |   0.0249 ns |   0.0274 ns |         - |
| TryParseCidrString | .NET 8.0 | 1      |  73.4179 ns | 4.9454 ns | 0.2711 ns |  73.2363 ns |  73.7295 ns |         - |
| TryParseCidrBytes  | .NET 8.0 | 1      |   2.7607 ns | 0.0302 ns | 0.0017 ns |   2.7588 ns |   2.7617 ns |         - |
| NewFromCidrString  | .NET 9.0 | 1      |  49.7137 ns | 0.7790 ns | 0.0427 ns |  49.6843 ns |  49.7627 ns |         - |
| NewFromCirBytes    | .NET 9.0 | 1      |   0.6641 ns | 1.3268 ns | 0.0727 ns |   0.6214 ns |   0.7480 ns |         - |
| TryParseCidrString | .NET 9.0 | 1      |  54.1910 ns | 0.4619 ns | 0.0253 ns |  54.1655 ns |  54.2161 ns |         - |
| TryParseCidrBytes  | .NET 9.0 | 1      |   3.0347 ns | 0.0549 ns | 0.0030 ns |   3.0316 ns |   3.0377 ns |         - |
| **NewFromCidrString**  | **.NET 8.0** | **3**      | **196.9155 ns** | **0.5150 ns** | **0.0282 ns** | **196.8860 ns** | **196.9422 ns** |         **-** |
| NewFromCirBytes    | .NET 8.0 | 3      |   0.6424 ns | 0.0192 ns | 0.0011 ns |   0.6413 ns |   0.6432 ns |         - |
| TryParseCidrString | .NET 8.0 | 3      | 209.4681 ns | 9.8943 ns | 0.5423 ns | 209.0481 ns | 210.0804 ns |         - |
| TryParseCidrBytes  | .NET 8.0 | 3      |   9.4858 ns | 0.9621 ns | 0.0527 ns |   9.4251 ns |   9.5207 ns |         - |
| NewFromCidrString  | .NET 9.0 | 3      | 149.5826 ns | 1.1908 ns | 0.0653 ns | 149.5113 ns | 149.6394 ns |         - |
| NewFromCirBytes    | .NET 9.0 | 3      |   0.6246 ns | 0.0688 ns | 0.0038 ns |   0.6213 ns |   0.6287 ns |         - |
| TryParseCidrString | .NET 9.0 | 3      | 154.8128 ns | 2.1324 ns | 0.1169 ns | 154.6796 ns | 154.8981 ns |         - |
| TryParseCidrBytes  | .NET 9.0 | 3      |   9.0827 ns | 0.8340 ns | 0.0457 ns |   9.0522 ns |   9.1352 ns |         - |
