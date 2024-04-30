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
| **ArrayReverse**           | **10**     | **100**    |  **12.51 μs** | **157.85 μs** |  **8.652 μs** |   **7.694 μs** |   **7.344 μs** |  **22.50 μs** |  **10.09 KB** |
| EnumerableReverse      | 10     | 100    |  80.05 μs | 149.49 μs |  8.194 μs |  81.904 μs |  71.085 μs |  87.15 μs |  25.72 KB |
| RecursiveReverse       | 10     | 100    |  47.53 μs | 372.98 μs | 20.444 μs |  36.919 μs |  34.565 μs |  71.09 μs |  56.97 KB |
| ReverseXor             | 10     | 100    |  17.31 μs | 145.52 μs |  7.977 μs |  14.798 μs |  10.890 μs |  26.24 μs |  10.09 KB |
| StackReverse           | 10     | 100    |  61.28 μs | 390.14 μs | 21.385 μs |  53.000 μs |  45.265 μs |  85.56 μs |  31.19 KB |
| StringSpan             | 10     | 100    |  12.75 μs | 166.94 μs |  9.150 μs |   7.484 μs |   7.444 μs |  23.31 μs |   5.41 KB |
| StringExtensionReverse | 10     | 100    |  48.45 μs | 322.27 μs | 17.665 μs |  39.094 μs |  37.441 μs |  68.83 μs |  28.84 KB |
| **ArrayReverse**           | **64**     | **100**    |  **23.60 μs** | **462.90 μs** | **25.373 μs** |   **8.998 μs** |   **8.908 μs** |  **52.90 μs** |  **30.41 KB** |
| EnumerableReverse      | 64     | 100    | 315.58 μs | 323.73 μs | 17.745 μs | 312.039 μs | 299.876 μs | 334.83 μs |  59.31 KB |
| RecursiveReverse       | 64     | 100    | 180.18 μs | 161.51 μs |  8.853 μs | 176.674 μs | 173.618 μs | 190.25 μs | 710.88 KB |
| ReverseXor             | 64     | 100    |  60.96 μs | 210.66 μs | 11.547 μs |  60.013 μs |  49.923 μs |  72.96 μs |  30.41 KB |
| StackReverse           | 64     | 100    | 242.12 μs | 528.13 μs | 28.949 μs | 248.428 μs | 210.537 μs | 267.39 μs |  88.22 KB |
| StringSpan             | 64     | 100    |  16.68 μs | 269.99 μs | 14.799 μs |   8.415 μs |   7.855 μs |  33.76 μs |  15.56 KB |
| StringExtensionReverse | 64     | 100    |  86.60 μs | 571.01 μs | 31.299 μs |  68.939 μs |  68.129 μs | 122.74 μs |  68.69 KB |
