```

BenchmarkDotNet v0.13.11, Ubuntu 22.04.3 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.100
  [Host]   : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX2

Job=ShortRun  InvocationCount=1  IterationCount=3  
LaunchCount=1  UnrollFactor=1  WarmupCount=3  

```
| Method                 | Length | Number | Mean      | Error     | StdDev    | Median     | Min        | Max       | Allocated |
|----------------------- |------- |------- |----------:|----------:|----------:|-----------:|-----------:|----------:|----------:|
| **ArrayReverse**           | **10**     | **100**    |  **15.11 μs** | **169.17 μs** |  **9.273 μs** |  **12.092 μs** |   **7.724 μs** |  **25.52 μs** |  **10.09 KB** |
| EnumerableReverse      | 10     | 100    |  80.49 μs | 149.79 μs |  8.210 μs |  78.074 μs |  73.757 μs |  89.64 μs |  25.72 KB |
| RecursiveReverse       | 10     | 100    |  48.32 μs | 388.71 μs | 21.306 μs |  37.660 μs |  34.454 μs |  72.86 μs |  56.97 KB |
| ReverseXor             | 10     | 100    |  18.81 μs | 189.22 μs | 10.372 μs |  14.798 μs |  11.040 μs |  30.59 μs |  10.09 KB |
| StackReverse           | 10     | 100    |  55.20 μs | 212.71 μs | 11.659 μs |  53.098 μs |  44.733 μs |  67.77 μs |  31.19 KB |
| StringSpan             | 10     | 100    |  18.79 μs | 272.63 μs | 14.944 μs |  10.249 μs |  10.079 μs |  36.05 μs |   5.41 KB |
| StringExtensionReverse | 10     | 100    |  37.22 μs | 256.81 μs | 14.076 μs |  29.385 μs |  28.805 μs |  53.47 μs |  28.84 KB |
| **ArrayReverse**           | **64**     | **100**    |  **18.32 μs** | **297.09 μs** | **16.284 μs** |   **9.111 μs** |   **8.730 μs** |  **37.12 μs** |  **30.41 KB** |
| EnumerableReverse      | 64     | 100    | 325.45 μs | 331.55 μs | 18.173 μs | 322.626 μs | 308.849 μs | 344.87 μs |  59.31 KB |
| RecursiveReverse       | 64     | 100    | 181.57 μs |  26.52 μs |  1.454 μs | 181.778 μs | 180.025 μs | 182.91 μs | 710.88 KB |
| ReverseXor             | 64     | 100    |  64.85 μs | 151.51 μs |  8.305 μs |  61.154 μs |  59.029 μs |  74.36 μs |  30.41 KB |
| StackReverse           | 64     | 100    | 236.37 μs | 524.52 μs | 28.751 μs | 232.893 μs | 209.510 μs | 266.70 μs |  88.22 KB |
| StringSpan             | 64     | 100    |  15.33 μs | 210.67 μs | 11.547 μs |   8.977 μs |   8.345 μs |  28.65 μs |  15.56 KB |
| StringExtensionReverse | 64     | 100    |  97.64 μs | 538.59 μs | 29.522 μs |  82.194 μs |  79.038 μs | 131.68 μs |  68.69 KB |
