```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.2 LTS (Noble Numbat)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.202
  [Host]            : .NET 9.0.3 (9.0.325.11113), X64 RyuJIT AVX2
  ShortRun-.NET 8.0 : .NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
  ShortRun-.NET 9.0 : .NET 9.0.3 (9.0.325.11113), X64 RyuJIT AVX2

IterationCount=3  LaunchCount=1  WarmupCount=3  

```
| Method             | Runtime  | Number | Mean        | Error     | StdDev    | Min         | Max         | Allocated |
|------------------- |--------- |------- |------------:|----------:|----------:|------------:|------------:|----------:|
| **NewFromCidrString**  | **.NET 8.0** | **1**      |  **65.8929 ns** | **0.3492 ns** | **0.0191 ns** |  **65.8738 ns** |  **65.9121 ns** |         **-** |
| NewFromCirBytes    | .NET 8.0 | 1      |   0.0264 ns | 0.0470 ns | 0.0026 ns |   0.0235 ns |   0.0281 ns |         - |
| TryParseCidrString | .NET 8.0 | 1      |  73.5049 ns | 0.1456 ns | 0.0080 ns |  73.4978 ns |  73.5136 ns |         - |
| TryParseCidrBytes  | .NET 8.0 | 1      |   2.7569 ns | 0.0105 ns | 0.0006 ns |   2.7562 ns |   2.7574 ns |         - |
| NewFromCidrString  | .NET 9.0 | 1      |  50.1978 ns | 0.2912 ns | 0.0160 ns |  50.1804 ns |  50.2116 ns |         - |
| NewFromCirBytes    | .NET 9.0 | 1      |   0.6247 ns | 0.0606 ns | 0.0033 ns |   0.6212 ns |   0.6278 ns |         - |
| TryParseCidrString | .NET 9.0 | 1      |  52.7284 ns | 1.8373 ns | 0.1007 ns |  52.6124 ns |  52.7933 ns |         - |
| TryParseCidrBytes  | .NET 9.0 | 1      |   3.0898 ns | 0.0451 ns | 0.0025 ns |   3.0880 ns |   3.0926 ns |         - |
| **NewFromCidrString**  | **.NET 8.0** | **3**      | **195.2006 ns** | **5.4824 ns** | **0.3005 ns** | **194.8546 ns** | **195.3965 ns** |         **-** |
| NewFromCirBytes    | .NET 8.0 | 3      |   0.6440 ns | 0.1139 ns | 0.0062 ns |   0.6400 ns |   0.6512 ns |         - |
| TryParseCidrString | .NET 8.0 | 3      | 212.2409 ns | 2.4393 ns | 0.1337 ns | 212.1357 ns | 212.3914 ns |         - |
| TryParseCidrBytes  | .NET 8.0 | 3      |   9.3623 ns | 1.0474 ns | 0.0574 ns |   9.3200 ns |   9.4277 ns |         - |
| NewFromCidrString  | .NET 9.0 | 3      | 148.1540 ns | 7.2781 ns | 0.3989 ns | 147.8990 ns | 148.6138 ns |         - |
| NewFromCirBytes    | .NET 9.0 | 3      |   0.6233 ns | 0.0219 ns | 0.0012 ns |   0.6224 ns |   0.6247 ns |         - |
| TryParseCidrString | .NET 9.0 | 3      | 155.3008 ns | 1.8460 ns | 0.1012 ns | 155.2037 ns | 155.4056 ns |         - |
| TryParseCidrBytes  | .NET 9.0 | 3      |   9.3841 ns | 1.1919 ns | 0.0653 ns |   9.3403 ns |   9.4592 ns |         - |
