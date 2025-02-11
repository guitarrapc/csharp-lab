```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.1 LTS (Noble Numbat)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.102
  [Host]            : .NET 9.0.1 (9.0.124.61010), X64 RyuJIT AVX2
  ShortRun-.NET 8.0 : .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
  ShortRun-.NET 9.0 : .NET 9.0.1 (9.0.124.61010), X64 RyuJIT AVX2

IterationCount=3  LaunchCount=1  WarmupCount=3  

```
| Method             | Runtime  | Number | Mean        | Error      | StdDev    | Min         | Max         | Allocated |
|------------------- |--------- |------- |------------:|-----------:|----------:|------------:|------------:|----------:|
| **NewFromCidrString**  | **.NET 8.0** | **1**      |  **68.2748 ns** | **35.3531 ns** | **1.9378 ns** |  **67.1327 ns** |  **70.5122 ns** |         **-** |
| NewFromCirBytes    | .NET 8.0 | 1      |   0.0213 ns |  0.0284 ns | 0.0016 ns |   0.0203 ns |   0.0231 ns |         - |
| TryParseCidrString | .NET 8.0 | 1      |  72.3349 ns |  0.3319 ns | 0.0182 ns |  72.3177 ns |  72.3539 ns |         - |
| TryParseCidrBytes  | .NET 8.0 | 1      |   2.7616 ns |  0.0457 ns | 0.0025 ns |   2.7587 ns |   2.7631 ns |         - |
| NewFromCidrString  | .NET 9.0 | 1      |  50.6593 ns |  0.8800 ns | 0.0482 ns |  50.6195 ns |  50.7130 ns |         - |
| NewFromCirBytes    | .NET 9.0 | 1      |   0.6236 ns |  0.1191 ns | 0.0065 ns |   0.6191 ns |   0.6311 ns |         - |
| TryParseCidrString | .NET 9.0 | 1      |  52.3906 ns |  0.3418 ns | 0.0187 ns |  52.3749 ns |  52.4113 ns |         - |
| TryParseCidrBytes  | .NET 9.0 | 1      |   3.0932 ns |  0.0976 ns | 0.0054 ns |   3.0894 ns |   3.0994 ns |         - |
| **NewFromCidrString**  | **.NET 8.0** | **3**      | **198.4697 ns** |  **1.2387 ns** | **0.0679 ns** | **198.3947 ns** | **198.5269 ns** |         **-** |
| NewFromCirBytes    | .NET 8.0 | 3      |   0.6464 ns |  0.1555 ns | 0.0085 ns |   0.6404 ns |   0.6562 ns |         - |
| TryParseCidrString | .NET 8.0 | 3      | 212.7792 ns | 23.2490 ns | 1.2744 ns | 211.9545 ns | 214.2469 ns |         - |
| TryParseCidrBytes  | .NET 8.0 | 3      |   9.3800 ns |  0.3314 ns | 0.0182 ns |   9.3590 ns |   9.3916 ns |         - |
| NewFromCidrString  | .NET 9.0 | 3      | 152.5393 ns |  0.8918 ns | 0.0489 ns | 152.4915 ns | 152.5892 ns |         - |
| NewFromCirBytes    | .NET 9.0 | 3      |   0.6208 ns |  0.0250 ns | 0.0014 ns |   0.6199 ns |   0.6224 ns |         - |
| TryParseCidrString | .NET 9.0 | 3      | 156.1927 ns |  9.8410 ns | 0.5394 ns | 155.8554 ns | 156.8148 ns |         - |
| TryParseCidrBytes  | .NET 9.0 | 3      |   9.3140 ns |  0.4129 ns | 0.0226 ns |   9.2879 ns |   9.3274 ns |         - |
