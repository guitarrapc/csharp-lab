```

BenchmarkDotNet v0.13.11, Ubuntu 22.04.3 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.101
  [Host]   : .NET 8.0.1 (8.0.123.58001), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.1 (8.0.123.58001), X64 RyuJIT AVX2

Job=ShortRun  InvocationCount=1  IterationCount=3  
LaunchCount=1  UnrollFactor=1  WarmupCount=3  

```
| Method                 | Length | Number | Mean      | Error      | StdDev    | Median     | Min        | Max       | Allocated |
|----------------------- |------- |------- |----------:|-----------:|----------:|-----------:|-----------:|----------:|----------:|
| **ArrayReverse**           | **10**     | **100**    |  **14.06 μs** | **157.499 μs** |  **8.633 μs** |  **11.071 μs** |   **7.324 μs** |  **23.79 μs** |  **10.09 KB** |
| EnumerableReverse      | 10     | 100    |  82.29 μs | 202.445 μs | 11.097 μs |  79.918 μs |  72.565 μs |  94.38 μs |  25.72 KB |
| RecursiveReverse       | 10     | 100    |  49.94 μs | 371.238 μs | 20.349 μs |  38.772 μs |  37.620 μs |  73.43 μs |  56.97 KB |
| ReverseXor             | 10     | 100    |  17.78 μs | 137.561 μs |  7.540 μs |  16.260 μs |  11.120 μs |  25.97 μs |  10.09 KB |
| StackReverse           | 10     | 100    |  52.77 μs | 272.715 μs | 14.948 μs |  44.623 μs |  43.661 μs |  70.02 μs |  31.19 KB |
| StringSpan             | 10     | 100    |  13.66 μs | 195.857 μs | 10.736 μs |   7.494 μs |   7.435 μs |  26.06 μs |   5.41 KB |
| StringExtensionReverse | 10     | 100    |  35.31 μs | 255.598 μs | 14.010 μs |  27.573 μs |  26.881 μs |  51.49 μs |  28.84 KB |
| **ArrayReverse**           | **64**     | **100**    |  **23.52 μs** | **413.601 μs** | **22.671 μs** |  **11.837 μs** |   **9.071 μs** |  **49.65 μs** |  **30.41 KB** |
| EnumerableReverse      | 64     | 100    | 304.67 μs | 273.343 μs | 14.983 μs | 307.625 μs | 288.428 μs | 317.95 μs |  59.31 KB |
| RecursiveReverse       | 64     | 100    | 171.92 μs |   9.281 μs |  0.509 μs | 172.161 μs | 171.340 μs | 172.27 μs | 710.88 KB |
| ReverseXor             | 64     | 100    |  63.19 μs | 236.330 μs | 12.954 μs |  61.114 μs |  51.395 μs |  77.05 μs |  30.41 KB |
| StackReverse           | 64     | 100    | 238.97 μs | 592.210 μs | 32.461 μs | 233.475 μs | 209.611 μs | 273.83 μs |  88.22 KB |
| StringSpan             | 64     | 100    |  14.56 μs | 201.242 μs | 11.031 μs |   8.426 μs |   7.955 μs |  27.29 μs |  15.56 KB |
| StringExtensionReverse | 64     | 100    |  99.85 μs | 586.002 μs | 32.121 μs |  83.126 μs |  79.549 μs | 136.89 μs |  68.69 KB |
