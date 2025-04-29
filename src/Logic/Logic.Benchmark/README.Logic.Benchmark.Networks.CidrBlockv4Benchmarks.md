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
| **NewFromCidrString**  | **.NET 8.0** | **1**      |  **66.6962 ns** |  **4.1376 ns** | **0.2268 ns** |  **66.4364 ns** |  **66.8549 ns** |         **-** |
| NewFromCirBytes    | .NET 8.0 | 1      |   0.0269 ns |  0.0370 ns | 0.0020 ns |   0.0254 ns |   0.0292 ns |         - |
| TryParseCidrString | .NET 8.0 | 1      |  74.4815 ns |  3.9512 ns | 0.2166 ns |  74.3307 ns |  74.7297 ns |         - |
| TryParseCidrBytes  | .NET 8.0 | 1      |   2.7710 ns |  0.3487 ns | 0.0191 ns |   2.7592 ns |   2.7931 ns |         - |
| NewFromCidrString  | .NET 9.0 | 1      |  50.3777 ns |  8.5100 ns | 0.4665 ns |  50.0630 ns |  50.9137 ns |         - |
| NewFromCirBytes    | .NET 9.0 | 1      |   0.6356 ns |  0.2752 ns | 0.0151 ns |   0.6214 ns |   0.6514 ns |         - |
| TryParseCidrString | .NET 9.0 | 1      |  52.8756 ns |  3.9729 ns | 0.2178 ns |  52.6954 ns |  53.1176 ns |         - |
| TryParseCidrBytes  | .NET 9.0 | 1      |   3.0312 ns |  0.0109 ns | 0.0006 ns |   3.0305 ns |   3.0316 ns |         - |
| **NewFromCidrString**  | **.NET 8.0** | **3**      | **203.1713 ns** |  **6.5246 ns** | **0.3576 ns** | **202.8274 ns** | **203.5412 ns** |         **-** |
| NewFromCirBytes    | .NET 8.0 | 3      |   0.6447 ns |  0.0306 ns | 0.0017 ns |   0.6428 ns |   0.6459 ns |         - |
| TryParseCidrString | .NET 8.0 | 3      | 211.1326 ns |  7.8591 ns | 0.4308 ns | 210.7796 ns | 211.6126 ns |         - |
| TryParseCidrBytes  | .NET 8.0 | 3      |   9.3590 ns |  0.5911 ns | 0.0324 ns |   9.3304 ns |   9.3942 ns |         - |
| NewFromCidrString  | .NET 9.0 | 3      | 150.6900 ns | 17.9333 ns | 0.9830 ns | 150.0291 ns | 151.8196 ns |         - |
| NewFromCirBytes    | .NET 9.0 | 3      |   0.6252 ns |  0.0976 ns | 0.0053 ns |   0.6211 ns |   0.6312 ns |         - |
| TryParseCidrString | .NET 9.0 | 3      | 155.9536 ns |  8.2320 ns | 0.4512 ns | 155.6845 ns | 156.4746 ns |         - |
| TryParseCidrBytes  | .NET 9.0 | 3      |   9.2769 ns |  0.2684 ns | 0.0147 ns |   9.2672 ns |   9.2939 ns |         - |
