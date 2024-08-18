```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.401
  [Host]   : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2

Job=ShortRun  InvocationCount=1  IterationCount=3  
LaunchCount=1  UnrollFactor=1  WarmupCount=3  

```
| Method                 | Length | Number | Mean      | Error     | StdDev    | Median     | Min        | Max       | Allocated |
|----------------------- |------- |------- |----------:|----------:|----------:|-----------:|-----------:|----------:|----------:|
| **ArrayReverse**           | **10**     | **100**    |  **14.28 μs** | **149.00 μs** |  **8.167 μs** |  **11.691 μs** |   **7.714 μs** |  **23.42 μs** |  **10.09 KB** |
| EnumerableReverse      | 10     | 100    |  79.08 μs | 242.09 μs | 13.270 μs |  79.247 μs |  65.732 μs |  92.27 μs |  25.72 KB |
| RecursiveReverse       | 10     | 100    |  32.97 μs | 267.44 μs | 14.659 μs |  26.614 μs |  22.566 μs |  49.74 μs |  33.53 KB |
| ReverseXor             | 10     | 100    |  18.02 μs | 159.33 μs |  8.734 μs |  15.540 μs |  10.790 μs |  27.72 μs |  10.09 KB |
| StackReverse           | 10     | 100    |  52.24 μs | 292.27 μs | 16.020 μs |  43.210 μs |  42.779 μs |  70.74 μs |  31.19 KB |
| StringSpan             | 10     | 100    |  13.34 μs | 176.35 μs |  9.666 μs |   8.191 μs |   7.339 μs |  24.49 μs |   5.41 KB |
| StringExtensionReverse | 10     | 100    |  36.02 μs | 256.64 μs | 14.067 μs |  28.293 μs |  27.511 μs |  52.26 μs |  28.84 KB |
| **ArrayReverse**           | **64**     | **100**    |  **18.53 μs** | **300.12 μs** | **16.450 μs** |   **9.127 μs** |   **8.946 μs** |  **37.53 μs** |  **30.41 KB** |
| EnumerableReverse      | 64     | 100    | 308.74 μs | 395.87 μs | 21.699 μs | 316.718 μs | 284.177 μs | 325.31 μs |  59.31 KB |
| RecursiveReverse       | 64     | 100    | 163.87 μs | 374.40 μs | 20.522 μs | 153.108 μs | 150.964 μs | 187.53 μs | 560.88 KB |
| ReverseXor             | 64     | 100    |  73.05 μs | 310.32 μs | 17.010 μs |  67.495 μs |  59.510 μs |  92.14 μs |  30.41 KB |
| StackReverse           | 64     | 100    | 238.63 μs | 519.61 μs | 28.482 μs | 235.386 μs | 211.912 μs | 268.60 μs |  88.22 KB |
| StringSpan             | 64     | 100    |  14.88 μs | 212.66 μs | 11.657 μs |   8.355 μs |   7.955 μs |  28.34 μs |  15.56 KB |
| StringExtensionReverse | 64     | 100    |  87.48 μs | 568.13 μs | 31.141 μs |  69.855 μs |  69.144 μs | 123.43 μs |  68.69 KB |
