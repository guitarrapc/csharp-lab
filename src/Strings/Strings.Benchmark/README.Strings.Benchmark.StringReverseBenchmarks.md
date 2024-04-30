```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.204
  [Host]   : .NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2

Job=ShortRun  InvocationCount=1  IterationCount=3  
LaunchCount=1  UnrollFactor=1  WarmupCount=3  

```
| Method                 | Length | Number | Mean      | Error     | StdDev    | Median     | Min        | Max       | Allocated |
|----------------------- |------- |------- |----------:|----------:|----------:|-----------:|-----------:|----------:|----------:|
| **ArrayReverse**           | **10**     | **100**    |  **16.27 μs** | **190.90 μs** | **10.464 μs** |  **10.559 μs** |   **9.898 μs** |  **28.34 μs** |  **10.09 KB** |
| EnumerableReverse      | 10     | 100    | 104.18 μs | 165.92 μs |  9.095 μs | 103.744 μs |  95.308 μs | 113.48 μs |  25.72 KB |
| RecursiveReverse       | 10     | 100    |  36.85 μs | 366.94 μs | 20.113 μs |  25.627 μs |  24.856 μs |  60.07 μs |  56.97 KB |
| ReverseXor             | 10     | 100    |  17.94 μs | 163.30 μs |  8.951 μs |  14.738 μs |  11.031 μs |  28.05 μs |  10.09 KB |
| StackReverse           | 10     | 100    |  54.32 μs | 339.03 μs | 18.583 μs |  43.972 μs |  43.211 μs |  75.77 μs |  31.19 KB |
| StringSpan             | 10     | 100    |  12.38 μs | 153.54 μs |  8.416 μs |   7.564 μs |   7.484 μs |  22.10 μs |   5.41 KB |
| StringExtensionReverse | 10     | 100    |  36.53 μs | 251.56 μs | 13.789 μs |  28.924 μs |  28.223 μs |  52.45 μs |  28.84 KB |
| **ArrayReverse**           | **64**     | **100**    |  **18.94 μs** | **309.17 μs** | **16.947 μs** |   **9.408 μs** |   **8.896 μs** |  **38.50 μs** |  **30.41 KB** |
| EnumerableReverse      | 64     | 100    | 442.78 μs | 344.19 μs | 18.866 μs | 432.257 μs | 431.514 μs | 464.56 μs |  59.31 KB |
| RecursiveReverse       | 64     | 100    | 174.74 μs |  23.16 μs |  1.270 μs | 175.176 μs | 173.312 μs | 175.74 μs | 710.88 KB |
| ReverseXor             | 64     | 100    |  68.36 μs | 295.43 μs | 16.194 μs |  61.304 μs |  56.886 μs |  86.88 μs |  30.41 KB |
| StackReverse           | 64     | 100    | 250.22 μs | 497.64 μs | 27.277 μs | 246.689 μs | 224.879 μs | 279.09 μs |  88.22 KB |
| StringSpan             | 64     | 100    |  14.48 μs | 201.86 μs | 11.065 μs |   8.337 μs |   7.845 μs |  27.25 μs |  15.56 KB |
| StringExtensionReverse | 64     | 100    |  85.21 μs | 544.38 μs | 29.839 μs |  68.228 μs |  67.737 μs | 119.66 μs |  68.69 KB |
