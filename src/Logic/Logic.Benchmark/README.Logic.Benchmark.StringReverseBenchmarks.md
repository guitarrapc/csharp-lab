```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.3 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.101
  [Host]   : .NET 8.0.1 (8.0.123.58001), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.1 (8.0.123.58001), X64 RyuJIT AVX2

Job=ShortRun  InvocationCount=1  IterationCount=3  
LaunchCount=1  UnrollFactor=1  WarmupCount=3  

```
| Method                 | Length | Number | Mean      | Error     | StdDev    | Median     | Min        | Max       | Allocated |
|----------------------- |------- |------- |----------:|----------:|----------:|-----------:|-----------:|----------:|----------:|
| **ArrayReverse**           | **10**     | **100**    |  **15.05 μs** | **166.05 μs** |  **9.102 μs** |  **11.857 μs** |   **7.979 μs** |  **25.32 μs** |  **10.09 KB** |
| EnumerableReverse      | 10     | 100    |  88.67 μs | 205.62 μs | 11.271 μs |  85.003 μs |  79.683 μs | 101.31 μs |  25.72 KB |
| RecursiveReverse       | 10     | 100    |  49.51 μs | 376.21 μs | 20.621 μs |  39.488 μs |  35.821 μs |  73.23 μs |  56.97 KB |
| ReverseXor             | 10     | 100    |  18.14 μs | 161.18 μs |  8.835 μs |  15.002 μs |  11.306 μs |  28.12 μs |  10.09 KB |
| StackReverse           | 10     | 100    |  55.05 μs | 276.85 μs | 15.175 μs |  46.797 μs |  45.795 μs |  72.57 μs |  31.19 KB |
| StringSpan             | 10     | 100    |  12.62 μs | 159.49 μs |  8.742 μs |   7.760 μs |   7.380 μs |  22.71 μs |   5.41 KB |
| StringExtensionReverse | 10     | 100    |  35.27 μs | 260.43 μs | 14.275 μs |  27.270 μs |  26.799 μs |  51.76 μs |  28.84 KB |
| **ArrayReverse**           | **64**     | **100**    |  **17.56 μs** | **263.35 μs** | **14.435 μs** |   **9.357 μs** |   **9.087 μs** |  **34.22 μs** |  **30.41 KB** |
| EnumerableReverse      | 64     | 100    | 333.19 μs | 624.06 μs | 34.207 μs | 320.306 μs | 307.302 μs | 371.97 μs |  59.31 KB |
| RecursiveReverse       | 64     | 100    | 200.97 μs | 742.50 μs | 40.699 μs | 182.218 μs | 173.021 μs | 247.66 μs | 710.88 KB |
| ReverseXor             | 64     | 100    |  64.97 μs | 280.39 μs | 15.369 μs |  60.894 μs |  52.058 μs |  81.97 μs |  30.41 KB |
| StackReverse           | 64     | 100    | 250.44 μs | 591.77 μs | 32.437 μs | 267.438 μs | 213.037 μs | 270.85 μs |  88.22 KB |
| StringSpan             | 64     | 100    |  14.61 μs | 202.07 μs | 11.076 μs |   8.425 μs |   8.014 μs |  27.40 μs |  15.56 KB |
| StringExtensionReverse | 64     | 100    |  91.91 μs | 466.73 μs | 25.583 μs |  85.389 μs |  70.221 μs | 120.12 μs |  68.69 KB |
