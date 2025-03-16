```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.2 LTS (Noble Numbat)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.201
  [Host]            : .NET 9.0.3 (9.0.325.11113), X64 RyuJIT AVX2
  ShortRun-.NET 8.0 : .NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
  ShortRun-.NET 9.0 : .NET 9.0.3 (9.0.325.11113), X64 RyuJIT AVX2

IterationCount=3  LaunchCount=1  WarmupCount=3  

```
| Method             | Runtime  | Number | Mean        | Error      | StdDev    | Min         | Max         | Allocated |
|------------------- |--------- |------- |------------:|-----------:|----------:|------------:|------------:|----------:|
| **NewFromCidrString**  | **.NET 8.0** | **1**      |  **65.7941 ns** |  **0.6091 ns** | **0.0334 ns** |  **65.7574 ns** |  **65.8228 ns** |         **-** |
| NewFromCirBytes    | .NET 8.0 | 1      |   0.0305 ns |  0.1590 ns | 0.0087 ns |   0.0223 ns |   0.0396 ns |         - |
| TryParseCidrString | .NET 8.0 | 1      |  73.3311 ns |  5.9046 ns | 0.3237 ns |  73.0863 ns |  73.6981 ns |         - |
| TryParseCidrBytes  | .NET 8.0 | 1      |   2.7701 ns |  0.3303 ns | 0.0181 ns |   2.7587 ns |   2.7910 ns |         - |
| NewFromCidrString  | .NET 9.0 | 1      |  50.3387 ns |  3.8135 ns | 0.2090 ns |  50.2067 ns |  50.5797 ns |         - |
| NewFromCirBytes    | .NET 9.0 | 1      |   0.6420 ns |  0.4559 ns | 0.0250 ns |   0.6203 ns |   0.6693 ns |         - |
| TryParseCidrString | .NET 9.0 | 1      |  52.7675 ns |  3.4512 ns | 0.1892 ns |  52.6437 ns |  52.9852 ns |         - |
| TryParseCidrBytes  | .NET 9.0 | 1      |   3.0978 ns |  0.2221 ns | 0.0122 ns |   3.0875 ns |   3.1112 ns |         - |
| **NewFromCidrString**  | **.NET 8.0** | **3**      | **197.0230 ns** |  **4.8450 ns** | **0.2656 ns** | **196.8117 ns** | **197.3211 ns** |         **-** |
| NewFromCirBytes    | .NET 8.0 | 3      |   0.6456 ns |  0.1120 ns | 0.0061 ns |   0.6404 ns |   0.6524 ns |         - |
| TryParseCidrString | .NET 8.0 | 3      | 213.3472 ns | 22.4553 ns | 1.2309 ns | 212.2299 ns | 214.6666 ns |         - |
| TryParseCidrBytes  | .NET 8.0 | 3      |   9.2681 ns |  0.7071 ns | 0.0388 ns |   9.2405 ns |   9.3124 ns |         - |
| NewFromCidrString  | .NET 9.0 | 3      | 148.8240 ns |  1.6829 ns | 0.0922 ns | 148.7175 ns | 148.8785 ns |         - |
| NewFromCirBytes    | .NET 9.0 | 3      |   0.6267 ns |  0.0864 ns | 0.0047 ns |   0.6216 ns |   0.6310 ns |         - |
| TryParseCidrString | .NET 9.0 | 3      | 155.4124 ns | 14.6058 ns | 0.8006 ns | 154.8953 ns | 156.3346 ns |         - |
| TryParseCidrBytes  | .NET 9.0 | 3      |   9.2839 ns |  0.6564 ns | 0.0360 ns |   9.2564 ns |   9.3246 ns |         - |
