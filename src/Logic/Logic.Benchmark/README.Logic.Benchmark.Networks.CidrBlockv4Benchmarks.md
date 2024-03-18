```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.203
  [Host]   : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method             | Number | Mean        | Error      | StdDev    | Min         | Max         | Allocated |
|------------------- |------- |------------:|-----------:|----------:|------------:|------------:|----------:|
| **NewFromCidrString**  | **1**      |  **68.4726 ns** |  **0.6310 ns** | **0.0346 ns** |  **68.4426 ns** |  **68.5105 ns** |         **-** |
| NewFromCirBytes    | 1      |   0.0000 ns |  0.0000 ns | 0.0000 ns |   0.0000 ns |   0.0000 ns |         - |
| TryParseCidrString | 1      |  73.5110 ns |  1.4130 ns | 0.0775 ns |  73.4224 ns |  73.5660 ns |         - |
| TryParseCidrBytes  | 1      |   3.0408 ns |  0.2485 ns | 0.0136 ns |   3.0318 ns |   3.0564 ns |         - |
| **NewFromCidrString**  | **3**      | **197.0669 ns** |  **8.3787 ns** | **0.4593 ns** | **196.5373 ns** | **197.3559 ns** |         **-** |
| NewFromCirBytes    | 3      |   0.6010 ns |  0.0351 ns | 0.0019 ns |   0.5995 ns |   0.6031 ns |         - |
| TryParseCidrString | 3      | 214.2043 ns | 42.6945 ns | 2.3402 ns | 212.5423 ns | 216.8805 ns |         - |
| TryParseCidrBytes  | 3      |   9.2605 ns |  1.0668 ns | 0.0585 ns |   9.2047 ns |   9.3214 ns |         - |
