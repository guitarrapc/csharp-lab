```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.402
  [Host]   : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2

Job=ShortRun  InvocationCount=1  IterationCount=3  
LaunchCount=1  UnrollFactor=1  WarmupCount=3  

```
| Method                 | Length | Number | Mean      | Error     | StdDev    | Median     | Min        | Max       | Allocated |
|----------------------- |------- |------- |----------:|----------:|----------:|-----------:|-----------:|----------:|----------:|
| **ArrayReverse**           | **10**     | **100**    |  **13.82 μs** | **143.83 μs** |  **7.884 μs** |  **11.441 μs** |   **7.403 μs** |  **22.62 μs** |  **10.09 KB** |
| EnumerableReverse      | 10     | 100    |  88.79 μs | 254.78 μs | 13.966 μs |  94.055 μs |  72.957 μs |  99.36 μs |  25.72 KB |
| RecursiveReverse       | 10     | 100    |  32.17 μs | 246.69 μs | 13.522 μs |  26.741 μs |  22.202 μs |  47.56 μs |  33.53 KB |
| ReverseXor             | 10     | 100    |  23.41 μs | 259.25 μs | 14.211 μs |  15.559 μs |  14.859 μs |  39.81 μs |  10.09 KB |
| StackReverse           | 10     | 100    |  61.86 μs | 514.72 μs | 28.214 μs |  45.726 μs |  45.415 μs |  94.44 μs |  31.19 KB |
| StringSpan             | 10     | 100    |  17.34 μs | 239.62 μs | 13.134 μs |   9.938 μs |   9.568 μs |  32.50 μs |   5.41 KB |
| StringExtensionReverse | 10     | 100    |  39.95 μs | 408.53 μs | 22.393 μs |  27.472 μs |  26.580 μs |  65.80 μs |  28.84 KB |
| **ArrayReverse**           | **64**     | **100**    |  **18.93 μs** | **312.18 μs** | **17.112 μs** |   **9.438 μs** |   **8.667 μs** |  **38.68 μs** |  **30.41 KB** |
| EnumerableReverse      | 64     | 100    | 309.73 μs | 465.30 μs | 25.505 μs | 310.402 μs | 283.902 μs | 334.90 μs |  59.31 KB |
| RecursiveReverse       | 64     | 100    | 166.08 μs | 195.64 μs | 10.723 μs | 161.503 μs | 158.407 μs | 178.33 μs | 560.88 KB |
| ReverseXor             | 64     | 100    |  64.32 μs | 294.45 μs | 16.140 μs |  59.392 μs |  51.226 μs |  82.36 μs |  30.41 KB |
| StackReverse           | 64     | 100    | 235.65 μs | 570.18 μs | 31.254 μs | 230.260 μs | 207.448 μs | 269.25 μs |  88.22 KB |
| StringSpan             | 64     | 100    |  16.67 μs | 251.83 μs | 13.804 μs |   8.936 μs |   8.475 μs |  32.61 μs |  15.56 KB |
| StringExtensionReverse | 64     | 100    |  98.10 μs | 615.17 μs | 33.720 μs |  79.629 μs |  77.645 μs | 137.02 μs |  68.69 KB |
