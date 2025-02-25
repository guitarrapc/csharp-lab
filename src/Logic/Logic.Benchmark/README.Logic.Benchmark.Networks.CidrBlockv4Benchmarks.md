```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.1 LTS (Noble Numbat)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.200
  [Host]            : .NET 9.0.2 (9.0.225.6610), X64 RyuJIT AVX2
  ShortRun-.NET 8.0 : .NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
  ShortRun-.NET 9.0 : .NET 9.0.2 (9.0.225.6610), X64 RyuJIT AVX2

IterationCount=3  LaunchCount=1  WarmupCount=3  

```
| Method             | Runtime  | Number | Mean        | Error      | StdDev    | Min         | Max         | Allocated |
|------------------- |--------- |------- |------------:|-----------:|----------:|------------:|------------:|----------:|
| **NewFromCidrString**  | **.NET 8.0** | **1**      |  **65.9759 ns** |  **0.8280 ns** | **0.0454 ns** |  **65.9345 ns** |  **66.0244 ns** |         **-** |
| NewFromCirBytes    | .NET 8.0 | 1      |   0.0234 ns |  0.0656 ns | 0.0036 ns |   0.0193 ns |   0.0258 ns |         - |
| TryParseCidrString | .NET 8.0 | 1      |  74.4665 ns |  6.9360 ns | 0.3802 ns |  74.1063 ns |  74.8639 ns |         - |
| TryParseCidrBytes  | .NET 8.0 | 1      |   2.7756 ns |  0.5311 ns | 0.0291 ns |   2.7581 ns |   2.8092 ns |         - |
| NewFromCidrString  | .NET 9.0 | 1      |  52.3218 ns |  2.1266 ns | 0.1166 ns |  52.2393 ns |  52.4552 ns |         - |
| NewFromCirBytes    | .NET 9.0 | 1      |   0.6224 ns |  0.0814 ns | 0.0045 ns |   0.6192 ns |   0.6275 ns |         - |
| TryParseCidrString | .NET 9.0 | 1      |  52.7100 ns |  2.0028 ns | 0.1098 ns |  52.6262 ns |  52.8343 ns |         - |
| TryParseCidrBytes  | .NET 9.0 | 1      |   3.0903 ns |  0.0202 ns | 0.0011 ns |   3.0894 ns |   3.0915 ns |         - |
| **NewFromCidrString**  | **.NET 8.0** | **3**      | **200.6430 ns** | **62.9182 ns** | **3.4488 ns** | **196.6645 ns** | **202.7830 ns** |         **-** |
| NewFromCirBytes    | .NET 8.0 | 3      |   0.6476 ns |  0.1168 ns | 0.0064 ns |   0.6405 ns |   0.6529 ns |         - |
| TryParseCidrString | .NET 8.0 | 3      | 216.4309 ns | 11.5486 ns | 0.6330 ns | 215.8322 ns | 217.0934 ns |         - |
| TryParseCidrBytes  | .NET 8.0 | 3      |   9.4861 ns |  0.7160 ns | 0.0392 ns |   9.4447 ns |   9.5228 ns |         - |
| NewFromCidrString  | .NET 9.0 | 3      | 148.3918 ns |  3.9467 ns | 0.2163 ns | 148.2014 ns | 148.6270 ns |         - |
| NewFromCirBytes    | .NET 9.0 | 3      |   0.6288 ns |  0.1213 ns | 0.0067 ns |   0.6246 ns |   0.6365 ns |         - |
| TryParseCidrString | .NET 9.0 | 3      | 155.4717 ns |  1.8509 ns | 0.1015 ns | 155.3986 ns | 155.5875 ns |         - |
| TryParseCidrBytes  | .NET 9.0 | 3      |   9.4029 ns |  1.9031 ns | 0.1043 ns |   9.3266 ns |   9.5218 ns |         - |
