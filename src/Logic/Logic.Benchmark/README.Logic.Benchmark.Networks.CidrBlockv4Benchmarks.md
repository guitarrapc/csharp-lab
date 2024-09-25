```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.402
  [Host]   : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method             | Number | Mean        | Error      | StdDev    | Median      | Min         | Max         | Allocated |
|------------------- |------- |------------:|-----------:|----------:|------------:|------------:|------------:|----------:|
| **NewFromCidrString**  | **1**      |  **67.7911 ns** |  **4.3430 ns** | **0.2381 ns** |  **67.6924 ns** |  **67.6183 ns** |  **68.0627 ns** |         **-** |
| NewFromCirBytes    | 1      |   0.1217 ns |  3.0766 ns | 0.1686 ns |   0.0253 ns |   0.0234 ns |   0.3164 ns |         - |
| TryParseCidrString | 1      |  72.9098 ns |  2.5044 ns | 0.1373 ns |  72.9853 ns |  72.7514 ns |  72.9928 ns |         - |
| TryParseCidrBytes  | 1      |   2.7684 ns |  0.2452 ns | 0.0134 ns |   2.7630 ns |   2.7586 ns |   2.7837 ns |         - |
| **NewFromCidrString**  | **3**      | **197.4225 ns** | **13.4227 ns** | **0.7357 ns** | **197.0298 ns** | **196.9664 ns** | **198.2713 ns** |         **-** |
| NewFromCirBytes    | 3      |   0.6505 ns |  0.1179 ns | 0.0065 ns |   0.6533 ns |   0.6431 ns |   0.6551 ns |         - |
| TryParseCidrString | 3      | 208.8752 ns |  3.2716 ns | 0.1793 ns | 208.7958 ns | 208.7493 ns | 209.0806 ns |         - |
| TryParseCidrBytes  | 3      |   9.3905 ns |  0.6139 ns | 0.0337 ns |   9.3741 ns |   9.3683 ns |   9.4292 ns |         - |
