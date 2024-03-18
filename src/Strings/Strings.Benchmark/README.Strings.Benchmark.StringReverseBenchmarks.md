```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.203
  [Host]   : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2

Job=ShortRun  InvocationCount=1  IterationCount=3  
LaunchCount=1  UnrollFactor=1  WarmupCount=3  

```
| Method                 | Length | Number | Mean      | Error     | StdDev    | Median     | Min        | Max       | Allocated |
|----------------------- |------- |------- |----------:|----------:|----------:|-----------:|-----------:|----------:|----------:|
| **ArrayReverse**           | **10**     | **100**    |  **17.02 μs** | **139.21 μs** |  **7.631 μs** |  **15.479 μs** |  **10.269 μs** |  **25.30 μs** |  **10.09 KB** |
| EnumerableReverse      | 10     | 100    |  78.70 μs | 129.77 μs |  7.113 μs |  80.792 μs |  70.773 μs |  84.53 μs |  25.72 KB |
| RecursiveReverse       | 10     | 100    |  47.57 μs | 360.05 μs | 19.736 μs |  37.010 μs |  35.367 μs |  70.34 μs |  56.97 KB |
| ReverseXor             | 10     | 100    |  21.96 μs | 127.29 μs |  6.977 μs |  20.539 μs |  15.800 μs |  29.54 μs |  10.09 KB |
| StackReverse           | 10     | 100    |  53.04 μs | 243.42 μs | 13.343 μs |  45.666 μs |  45.003 μs |  68.44 μs |  31.19 KB |
| StringSpan             | 10     | 100    |  12.31 μs | 150.59 μs |  8.254 μs |   7.554 μs |   7.533 μs |  21.84 μs |   5.41 KB |
| StringExtensionReverse | 10     | 100    |  35.98 μs | 273.54 μs | 14.993 μs |  27.326 μs |  27.326 μs |  53.30 μs |  28.84 KB |
| **ArrayReverse**           | **64**     | **100**    |  **18.17 μs** | **295.07 μs** | **16.174 μs** |   **8.986 μs** |   **8.686 μs** |  **36.85 μs** |  **30.41 KB** |
| EnumerableReverse      | 64     | 100    | 305.23 μs | 265.52 μs | 14.554 μs | 302.298 μs | 292.359 μs | 321.02 μs |  59.31 KB |
| RecursiveReverse       | 64     | 100    | 178.89 μs | 229.96 μs | 12.605 μs | 172.694 μs | 170.579 μs | 193.39 μs | 710.88 KB |
| ReverseXor             | 64     | 100    |  62.27 μs | 242.70 μs | 13.303 μs |  59.531 μs |  50.554 μs |  76.73 μs |  30.41 KB |
| StackReverse           | 64     | 100    | 245.54 μs | 522.34 μs | 28.631 μs | 256.681 μs | 213.009 μs | 266.92 μs |  88.22 KB |
| StringSpan             | 64     | 100    |  15.45 μs | 190.74 μs | 10.455 μs |  11.030 μs |   7.934 μs |  27.39 μs |  15.56 KB |
| StringExtensionReverse | 64     | 100    |  85.95 μs | 553.10 μs | 30.317 μs |  69.620 μs |  67.306 μs | 120.94 μs |  68.69 KB |
