```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.401
  [Host]   : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2

Job=ShortRun  InvocationCount=1  IterationCount=3  
LaunchCount=1  UnrollFactor=1  WarmupCount=3  

```
| Method                 | Length | Number | Mean      | Error     | StdDev    | Median     | Min        | Max       | Allocated |
|----------------------- |------- |------- |----------:|----------:|----------:|-----------:|-----------:|----------:|----------:|
| **ArrayReverse**           | **10**     | **100**    |  **17.68 μs** | **224.38 μs** | **12.299 μs** |  **10.761 μs** |  **10.399 μs** |  **31.88 μs** |  **10.09 KB** |
| EnumerableReverse      | 10     | 100    |  75.23 μs | 238.91 μs | 13.095 μs |  69.830 μs |  65.692 μs |  90.16 μs |  25.72 KB |
| RecursiveReverse       | 10     | 100    |  36.34 μs | 314.05 μs | 17.214 μs |  26.509 μs |  26.289 μs |  56.21 μs |  33.53 KB |
| ReverseXor             | 10     | 100    |  16.88 μs | 139.82 μs |  7.664 μs |  14.707 μs |  10.539 μs |  25.40 μs |  10.09 KB |
| StackReverse           | 10     | 100    |  54.32 μs | 199.88 μs | 10.956 μs |  54.292 μs |  43.371 μs |  65.28 μs |  31.19 KB |
| StringSpan             | 10     | 100    |  15.66 μs | 187.54 μs | 10.280 μs |   9.843 μs |   9.602 μs |  27.53 μs |   5.41 KB |
| StringExtensionReverse | 10     | 100    |  35.38 μs | 255.05 μs | 13.980 μs |  27.551 μs |  27.059 μs |  51.52 μs |  28.84 KB |
| **ArrayReverse**           | **64**     | **100**    |  **23.13 μs** | **332.69 μs** | **18.236 μs** |  **12.758 μs** |  **12.448 μs** |  **44.19 μs** |  **30.41 KB** |
| EnumerableReverse      | 64     | 100    | 325.09 μs | 425.99 μs | 23.350 μs | 332.309 μs | 298.978 μs | 343.97 μs |  59.31 KB |
| RecursiveReverse       | 64     | 100    | 151.76 μs |  32.74 μs |  1.795 μs | 151.072 μs | 150.411 μs | 153.80 μs | 560.88 KB |
| ReverseXor             | 64     | 100    |  65.19 μs | 307.04 μs | 16.830 μs |  60.854 μs |  50.955 μs |  83.77 μs |  30.41 KB |
| StackReverse           | 64     | 100    | 251.90 μs | 727.02 μs | 39.851 μs | 260.497 μs | 208.448 μs | 286.75 μs |  88.22 KB |
| StringSpan             | 64     | 100    |  15.61 μs | 182.22 μs |  9.988 μs |  10.874 μs |   8.871 μs |  27.09 μs |  15.56 KB |
| StringExtensionReverse | 64     | 100    |  86.05 μs | 587.88 μs | 32.224 μs |  68.036 μs |  66.854 μs | 123.25 μs |  68.69 KB |
