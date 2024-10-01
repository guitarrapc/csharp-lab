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
| **ArrayReverse**           | **10**     | **100**    |  **19.64 μs** | **200.35 μs** | **10.982 μs** |  **16.101 μs** |  **10.871 μs** |  **31.96 μs** |  **10.09 KB** |
| EnumerableReverse      | 10     | 100    |  76.03 μs | 260.92 μs | 14.302 μs |  69.971 μs |  65.752 μs |  92.36 μs |  25.72 KB |
| RecursiveReverse       | 10     | 100    |  49.12 μs | 256.50 μs | 14.060 μs |  55.569 μs |  32.996 μs |  58.80 μs |  33.53 KB |
| ReverseXor             | 10     | 100    |  21.13 μs | 208.99 μs | 11.456 μs |  14.774 μs |  14.271 μs |  34.36 μs |  10.09 KB |
| StackReverse           | 10     | 100    |  63.66 μs | 455.75 μs | 24.981 μs |  54.031 μs |  44.924 μs |  92.02 μs |  31.19 KB |
| StringSpan             | 10     | 100    |  13.42 μs | 148.95 μs |  8.164 μs |  10.400 μs |   7.194 μs |  22.66 μs |   5.41 KB |
| StringExtensionReverse | 10     | 100    |  36.17 μs | 258.92 μs | 14.192 μs |  27.992 μs |  27.961 μs |  52.56 μs |  28.84 KB |
| **ArrayReverse**           | **64**     | **100**    |  **17.23 μs** | **266.99 μs** | **14.635 μs** |   **8.886 μs** |   **8.666 μs** |  **34.12 μs** |  **30.41 KB** |
| EnumerableReverse      | 64     | 100    | 315.66 μs | 502.47 μs | 27.542 μs | 318.014 μs | 287.015 μs | 341.95 μs |  59.31 KB |
| RecursiveReverse       | 64     | 100    | 171.57 μs |  24.14 μs |  1.323 μs | 171.521 μs | 170.278 μs | 172.92 μs | 560.88 KB |
| ReverseXor             | 64     | 100    |  61.93 μs | 198.50 μs | 10.881 μs |  60.102 μs |  52.077 μs |  73.61 μs |  30.41 KB |
| StackReverse           | 64     | 100    | 260.68 μs | 812.57 μs | 44.540 μs | 280.565 μs | 209.662 μs | 291.82 μs |  88.22 KB |
| StringSpan             | 64     | 100    |  16.52 μs | 244.88 μs | 13.423 μs |   8.776 μs |   8.767 μs |  32.02 μs |  15.56 KB |
| StringExtensionReverse | 64     | 100    |  89.45 μs | 513.82 μs | 28.164 μs |  73.356 μs |  73.016 μs | 121.97 μs |  68.69 KB |
