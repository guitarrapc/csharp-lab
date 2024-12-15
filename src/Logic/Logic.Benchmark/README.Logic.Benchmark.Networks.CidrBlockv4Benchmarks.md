```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.101
  [Host]   : .NET 9.0.0 (9.0.24.52809), X64 RyuJIT AVX2
  ShortRun : .NET 9.0.0 (9.0.24.52809), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method             | Number | Mean        | Error     | StdDev    | Min         | Max         | Allocated |
|------------------- |------- |------------:|----------:|----------:|------------:|------------:|----------:|
| **NewFromCidrString**  | **1**      |  **50.2296 ns** | **1.1162 ns** | **0.0612 ns** |  **50.1882 ns** |  **50.2999 ns** |         **-** |
| NewFromCirBytes    | 1      |   0.6216 ns | 0.0777 ns | 0.0043 ns |   0.6181 ns |   0.6263 ns |         - |
| TryParseCidrString | 1      |  52.4266 ns | 0.9978 ns | 0.0547 ns |  52.3636 ns |  52.4618 ns |         - |
| TryParseCidrBytes  | 1      |   3.0187 ns | 0.1409 ns | 0.0077 ns |   3.0130 ns |   3.0275 ns |         - |
| **NewFromCidrString**  | **3**      | **148.1157 ns** | **4.4127 ns** | **0.2419 ns** | **147.8761 ns** | **148.3598 ns** |         **-** |
| NewFromCirBytes    | 3      |   0.6230 ns | 0.0960 ns | 0.0053 ns |   0.6171 ns |   0.6271 ns |         - |
| TryParseCidrString | 3      | 154.4534 ns | 3.2820 ns | 0.1799 ns | 154.2706 ns | 154.6302 ns |         - |
| TryParseCidrBytes  | 3      |   8.9225 ns | 1.2625 ns | 0.0692 ns |   8.8426 ns |   8.9627 ns |         - |
