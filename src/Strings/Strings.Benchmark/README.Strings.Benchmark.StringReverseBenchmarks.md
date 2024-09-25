```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.402
  [Host]   : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2

Job=ShortRun  InvocationCount=1  IterationCount=3  
LaunchCount=1  UnrollFactor=1  WarmupCount=3  

```
| Method                 | Length | Number | Mean      | Error     | StdDev   | Median     | Min        | Max       | Allocated |
|----------------------- |------- |------- |----------:|----------:|---------:|-----------:|-----------:|----------:|----------:|
| **ArrayReverse**           | **10**     | **100**    |  **25.28 μs** | **375.29 μs** | **20.57 μs** |  **16.231 μs** |  **10.780 μs** |  **48.82 μs** |  **10.09 KB** |
| EnumerableReverse      | 10     | 100    | 109.27 μs | 218.15 μs | 11.96 μs | 107.492 μs |  98.303 μs | 122.02 μs |  25.72 KB |
| RecursiveReverse       | 10     | 100    |  40.21 μs | 291.36 μs | 15.97 μs |  45.485 μs |  22.272 μs |  52.88 μs |  33.53 KB |
| ReverseXor             | 10     | 100    |  22.14 μs | 188.69 μs | 10.34 μs |  16.265 μs |  16.066 μs |  34.08 μs |  10.09 KB |
| StackReverse           | 10     | 100    |  57.00 μs | 392.30 μs | 21.50 μs |  45.114 μs |  44.062 μs |  81.82 μs |  31.19 KB |
| StringSpan             | 10     | 100    |  16.20 μs | 197.47 μs | 10.82 μs |  10.108 μs |   9.789 μs |  28.69 μs |   5.41 KB |
| StringExtensionReverse | 10     | 100    |  37.84 μs | 331.18 μs | 18.15 μs |  27.611 μs |  27.110 μs |  58.80 μs |  28.84 KB |
| **ArrayReverse**           | **64**     | **100**    |  **17.30 μs** | **262.87 μs** | **14.41 μs** |   **9.036 μs** |   **8.916 μs** |  **33.93 μs** |  **30.41 KB** |
| EnumerableReverse      | 64     | 100    | 300.38 μs | 287.45 μs | 15.76 μs | 298.324 μs | 285.760 μs | 317.07 μs |  59.31 KB |
| RecursiveReverse       | 64     | 100    | 164.39 μs | 244.10 μs | 13.38 μs | 164.538 μs | 150.934 μs | 177.69 μs | 560.88 KB |
| ReverseXor             | 64     | 100    |  78.27 μs | 304.38 μs | 16.68 μs |  79.008 μs |  61.224 μs |  94.57 μs |  30.41 KB |
| StackReverse           | 64     | 100    | 236.37 μs | 542.00 μs | 29.71 μs | 233.312 μs | 208.315 μs | 267.50 μs |  88.22 KB |
| StringSpan             | 64     | 100    |  16.74 μs | 222.18 μs | 12.18 μs |  11.070 μs |   8.426 μs |  30.72 μs |  15.56 KB |
| StringExtensionReverse | 64     | 100    | 103.09 μs | 709.08 μs | 38.87 μs |  96.321 μs |  68.058 μs | 144.90 μs |  68.69 KB |
