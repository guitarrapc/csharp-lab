```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.2 LTS (Noble Numbat)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.203
  [Host]            : .NET 9.0.4 (9.0.425.16305), X64 RyuJIT AVX2
  ShortRun-.NET 8.0 : .NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
  ShortRun-.NET 9.0 : .NET 9.0.4 (9.0.425.16305), X64 RyuJIT AVX2

IterationCount=3  LaunchCount=1  WarmupCount=3  

```
| Method             | Runtime  | Number | Mean        | Error      | StdDev    | Min         | Max         | Allocated |
|------------------- |--------- |------- |------------:|-----------:|----------:|------------:|------------:|----------:|
| **NewFromCidrString**  | **.NET 8.0** | **1**      |  **67.6266 ns** |  **6.1373 ns** | **0.3364 ns** |  **67.4254 ns** |  **68.0149 ns** |         **-** |
| NewFromCirBytes    | .NET 8.0 | 1      |   0.0192 ns |  0.0094 ns | 0.0005 ns |   0.0187 ns |   0.0197 ns |         - |
| TryParseCidrString | .NET 8.0 | 1      |  71.9618 ns |  2.2202 ns | 0.1217 ns |  71.8611 ns |  72.0970 ns |         - |
| TryParseCidrBytes  | .NET 8.0 | 1      |   2.7885 ns |  0.3349 ns | 0.0184 ns |   2.7710 ns |   2.8076 ns |         - |
| NewFromCidrString  | .NET 9.0 | 1      |  50.2213 ns |  3.5685 ns | 0.1956 ns |  50.0478 ns |  50.4333 ns |         - |
| NewFromCirBytes    | .NET 9.0 | 1      |   0.6213 ns |  0.0174 ns | 0.0010 ns |   0.6203 ns |   0.6222 ns |         - |
| TryParseCidrString | .NET 9.0 | 1      |  52.6147 ns |  0.6552 ns | 0.0359 ns |  52.5843 ns |  52.6543 ns |         - |
| TryParseCidrBytes  | .NET 9.0 | 1      |   3.0320 ns |  0.0476 ns | 0.0026 ns |   3.0300 ns |   3.0349 ns |         - |
| **NewFromCidrString**  | **.NET 8.0** | **3**      | **196.2280 ns** |  **8.4819 ns** | **0.4649 ns** | **195.8106 ns** | **196.7291 ns** |         **-** |
| NewFromCirBytes    | .NET 8.0 | 3      |   0.6386 ns |  0.1141 ns | 0.0063 ns |   0.6328 ns |   0.6452 ns |         - |
| TryParseCidrString | .NET 8.0 | 3      | 212.3546 ns | 73.8060 ns | 4.0456 ns | 208.3957 ns | 216.4816 ns |         - |
| TryParseCidrBytes  | .NET 8.0 | 3      |   9.3293 ns |  0.3111 ns | 0.0171 ns |   9.3099 ns |   9.3419 ns |         - |
| NewFromCidrString  | .NET 9.0 | 3      | 149.0675 ns |  0.1731 ns | 0.0095 ns | 149.0594 ns | 149.0779 ns |         - |
| NewFromCirBytes    | .NET 9.0 | 3      |   0.6283 ns |  0.1235 ns | 0.0068 ns |   0.6238 ns |   0.6361 ns |         - |
| TryParseCidrString | .NET 9.0 | 3      | 154.8136 ns |  1.1789 ns | 0.0646 ns | 154.7669 ns | 154.8873 ns |         - |
| TryParseCidrBytes  | .NET 9.0 | 3      |   9.2559 ns |  1.4985 ns | 0.0821 ns |   9.1781 ns |   9.3418 ns |         - |
