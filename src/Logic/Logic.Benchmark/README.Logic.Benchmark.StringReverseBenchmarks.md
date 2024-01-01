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
| **ArrayReverse**           | **10**     | **100**    |  **14.12 μs** | **162.78 μs** |  **8.923 μs** |  **11.065 μs** |   **7.128 μs** |  **24.17 μs** |  **10.09 KB** |
| EnumerableReverse      | 10     | 100    |  77.18 μs | 154.96 μs |  8.494 μs |  75.182 μs |  69.861 μs |  86.49 μs |  25.72 KB |
| RecursiveReverse       | 10     | 100    |  37.41 μs | 345.67 μs | 18.947 μs |  26.821 μs |  26.119 μs |  59.28 μs |  56.97 KB |
| ReverseXor             | 10     | 100    |  20.97 μs | 189.84 μs | 10.406 μs |  15.179 μs |  14.747 μs |  32.98 μs |  10.09 KB |
| StackReverse           | 10     | 100    |  53.60 μs | 235.36 μs | 12.901 μs |  47.220 μs |  45.135 μs |  68.45 μs |  31.19 KB |
| StringSpan             | 10     | 100    |  13.38 μs | 154.10 μs |  8.447 μs |   9.634 μs |   7.450 μs |  23.05 μs |   5.41 KB |
| StringExtensionReverse | 10     | 100    |  37.67 μs | 295.82 μs | 16.215 μs |  28.538 μs |  28.078 μs |  56.39 μs |  28.84 KB |
| **ArrayReverse**           | **64**     | **100**    |  **17.19 μs** | **268.94 μs** | **14.742 μs** |   **8.722 μs** |   **8.632 μs** |  **34.21 μs** |  **30.41 KB** |
| EnumerableReverse      | 64     | 100    | 300.94 μs | 276.91 μs | 15.179 μs | 299.843 μs | 286.347 μs | 316.64 μs |  59.31 KB |
| RecursiveReverse       | 64     | 100    | 186.93 μs |  41.79 μs |  2.291 μs | 187.120 μs | 184.545 μs | 189.11 μs | 710.88 KB |
| ReverseXor             | 64     | 100    |  74.37 μs | 279.27 μs | 15.308 μs |  71.424 μs |  60.755 μs |  90.94 μs |  30.41 KB |
| StackReverse           | 64     | 100    | 242.77 μs | 390.20 μs | 21.388 μs | 235.752 μs | 225.763 μs | 266.78 μs |  88.22 KB |
| StringSpan             | 64     | 100    |  17.00 μs | 276.50 μs | 15.156 μs |   8.386 μs |   8.124 μs |  34.50 μs |  15.56 KB |
| StringExtensionReverse | 64     | 100    |  98.94 μs | 606.88 μs | 33.265 μs |  81.263 μs |  78.237 μs | 137.31 μs |  68.69 KB |
