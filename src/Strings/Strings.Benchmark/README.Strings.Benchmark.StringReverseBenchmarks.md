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
| **ArrayReverse**           | **10**     | **100**    |  **13.56 μs** | **162.62 μs** |  **8.914 μs** |   **8.656 μs** |   **8.184 μs** |  **23.85 μs** |  **10.09 KB** |
| EnumerableReverse      | 10     | 100    |  78.35 μs | 274.26 μs | 15.033 μs |  73.367 μs |  66.435 μs |  95.24 μs |  25.72 KB |
| RecursiveReverse       | 10     | 100    |  34.44 μs | 276.33 μs | 15.147 μs |  28.764 μs |  22.953 μs |  51.61 μs |  33.53 KB |
| ReverseXor             | 10     | 100    |  17.38 μs | 140.80 μs |  7.718 μs |  14.963 μs |  11.155 μs |  26.01 μs |  10.09 KB |
| StackReverse           | 10     | 100    |  62.53 μs | 301.07 μs | 16.503 μs |  53.423 μs |  52.583 μs |  81.58 μs |  31.19 KB |
| StringSpan             | 10     | 100    |  14.60 μs | 204.00 μs | 11.182 μs |   8.437 μs |   7.865 μs |  27.51 μs |   5.41 KB |
| StringExtensionReverse | 10     | 100    |  36.17 μs | 244.38 μs | 13.395 μs |  28.653 μs |  28.222 μs |  51.64 μs |  28.84 KB |
| **ArrayReverse**           | **64**     | **100**    |  **17.59 μs** | **274.80 μs** | **15.063 μs** |   **8.961 μs** |   **8.822 μs** |  **34.98 μs** |  **30.41 KB** |
| EnumerableReverse      | 64     | 100    | 318.77 μs | 264.14 μs | 14.479 μs | 317.430 μs | 305.007 μs | 333.87 μs |  59.31 KB |
| RecursiveReverse       | 64     | 100    | 166.94 μs | 142.69 μs |  7.822 μs | 166.355 μs | 159.431 μs | 175.04 μs | 560.88 KB |
| ReverseXor             | 64     | 100    |  62.13 μs | 213.13 μs | 11.682 μs |  60.272 μs |  51.486 μs |  74.63 μs |  30.41 KB |
| StackReverse           | 64     | 100    | 261.76 μs | 594.39 μs | 32.581 μs | 243.604 μs | 242.312 μs | 299.38 μs |  88.22 KB |
| StringSpan             | 64     | 100    |  15.03 μs | 202.09 μs | 11.077 μs |   8.902 μs |   8.370 μs |  27.82 μs |  15.56 KB |
| StringExtensionReverse | 64     | 100    |  97.13 μs | 851.65 μs | 46.682 μs |  70.362 μs |  69.990 μs | 151.03 μs |  68.69 KB |
