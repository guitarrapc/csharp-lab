```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.204
  [Host]   : .NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method             | Number | Mean        | Error      | StdDev    | Min         | Max         | Allocated |
|------------------- |------- |------------:|-----------:|----------:|------------:|------------:|----------:|
| **NewFromCidrString**  | **1**      |  **65.7302 ns** |  **1.6227 ns** | **0.0889 ns** |  **65.6274 ns** |  **65.7818 ns** |         **-** |
| NewFromCirBytes    | 1      |   0.0000 ns |  0.0000 ns | 0.0000 ns |   0.0000 ns |   0.0000 ns |         - |
| TryParseCidrString | 1      |  73.9475 ns |  0.2937 ns | 0.0161 ns |  73.9289 ns |  73.9575 ns |         - |
| TryParseCidrBytes  | 1      |   3.0474 ns |  0.3364 ns | 0.0184 ns |   3.0326 ns |   3.0681 ns |         - |
| **NewFromCidrString**  | **3**      | **196.7387 ns** | **31.3050 ns** | **1.7159 ns** | **195.5492 ns** | **198.7058 ns** |         **-** |
| NewFromCirBytes    | 3      |   0.6084 ns |  0.0168 ns | 0.0009 ns |   0.6073 ns |   0.6091 ns |         - |
| TryParseCidrString | 3      | 212.1539 ns | 17.2798 ns | 0.9472 ns | 211.5101 ns | 213.2415 ns |         - |
| TryParseCidrBytes  | 3      |   9.1771 ns |  3.2895 ns | 0.1803 ns |   8.9762 ns |   9.3247 ns |         - |
