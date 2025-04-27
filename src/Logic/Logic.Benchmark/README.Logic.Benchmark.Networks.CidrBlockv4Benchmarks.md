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
| **NewFromCidrString**  | **.NET 8.0** | **1**      |  **69.1014 ns** |  **6.4245 ns** | **0.3521 ns** |  **68.8962 ns** |  **69.5081 ns** |         **-** |
| NewFromCirBytes    | .NET 8.0 | 1      |   0.0227 ns |  0.0323 ns | 0.0018 ns |   0.0209 ns |   0.0244 ns |         - |
| TryParseCidrString | .NET 8.0 | 1      |  72.9081 ns |  5.2966 ns | 0.2903 ns |  72.7353 ns |  73.2433 ns |         - |
| TryParseCidrBytes  | .NET 8.0 | 1      |   2.7611 ns |  0.1317 ns | 0.0072 ns |   2.7565 ns |   2.7694 ns |         - |
| NewFromCidrString  | .NET 9.0 | 1      |  50.2413 ns |  4.4581 ns | 0.2444 ns |  50.0110 ns |  50.4977 ns |         - |
| NewFromCirBytes    | .NET 9.0 | 1      |   0.6264 ns |  0.0837 ns | 0.0046 ns |   0.6219 ns |   0.6311 ns |         - |
| TryParseCidrString | .NET 9.0 | 1      |  52.5629 ns |  4.6251 ns | 0.2535 ns |  52.3853 ns |  52.8532 ns |         - |
| TryParseCidrBytes  | .NET 9.0 | 1      |   3.0357 ns |  0.0378 ns | 0.0021 ns |   3.0339 ns |   3.0380 ns |         - |
| **NewFromCidrString**  | **.NET 8.0** | **3**      | **195.4954 ns** |  **3.3174 ns** | **0.1818 ns** | **195.3617 ns** | **195.7025 ns** |         **-** |
| NewFromCirBytes    | .NET 8.0 | 3      |   0.6480 ns |  0.0908 ns | 0.0050 ns |   0.6432 ns |   0.6531 ns |         - |
| TryParseCidrString | .NET 8.0 | 3      | 208.7375 ns |  2.9283 ns | 0.1605 ns | 208.5522 ns | 208.8324 ns |         - |
| TryParseCidrBytes  | .NET 8.0 | 3      |   9.2900 ns |  0.5893 ns | 0.0323 ns |   9.2579 ns |   9.3225 ns |         - |
| NewFromCidrString  | .NET 9.0 | 3      | 156.8849 ns | 32.4804 ns | 1.7804 ns | 155.2290 ns | 158.7679 ns |         - |
| NewFromCirBytes    | .NET 9.0 | 3      |   0.4906 ns |  0.0452 ns | 0.0025 ns |   0.4890 ns |   0.4934 ns |         - |
| TryParseCidrString | .NET 9.0 | 3      | 155.2466 ns |  2.2412 ns | 0.1228 ns | 155.1584 ns | 155.3869 ns |         - |
| TryParseCidrBytes  | .NET 9.0 | 3      |   9.2239 ns |  1.8239 ns | 0.1000 ns |   9.1298 ns |   9.3289 ns |         - |
