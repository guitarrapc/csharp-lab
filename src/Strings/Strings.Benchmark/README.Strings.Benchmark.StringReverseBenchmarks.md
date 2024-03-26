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
| **ArrayReverse**           | **10**     | **100**    |  **14.57 μs** | **168.46 μs** |  **9.234 μs** |  **10.911 μs** |   **7.735 μs** |  **25.08 μs** |  **10.09 KB** |
| EnumerableReverse      | 10     | 100    |  76.47 μs | 263.42 μs | 14.439 μs |  70.662 μs |  65.833 μs |  92.90 μs |  25.72 KB |
| RecursiveReverse       | 10     | 100    |  37.13 μs | 356.46 μs | 19.539 μs |  26.309 μs |  25.387 μs |  59.68 μs |  56.97 KB |
| ReverseXor             | 10     | 100    |  18.29 μs | 161.31 μs |  8.842 μs |  15.438 μs |  11.221 μs |  28.20 μs |  10.09 KB |
| StackReverse           | 10     | 100    |  59.33 μs | 368.13 μs | 20.178 μs |  50.533 μs |  45.043 μs |  82.41 μs |  31.19 KB |
| StringSpan             | 10     | 100    |  12.52 μs | 159.99 μs |  8.769 μs |   7.473 μs |   7.434 μs |  22.64 μs |   5.41 KB |
| StringExtensionReverse | 10     | 100    |  48.19 μs | 246.78 μs | 13.527 μs |  41.497 μs |  39.313 μs |  63.76 μs |  28.84 KB |
| **ArrayReverse**           | **64**     | **100**    |  **18.18 μs** | **293.90 μs** | **16.110 μs** |   **8.958 μs** |   **8.797 μs** |  **36.78 μs** |  **30.41 KB** |
| EnumerableReverse      | 64     | 100    | 301.89 μs | 246.73 μs | 13.524 μs | 301.321 μs | 288.657 μs | 315.69 μs |  59.31 KB |
| RecursiveReverse       | 64     | 100    | 178.24 μs | 167.84 μs |  9.200 μs | 174.676 μs | 171.360 μs | 188.69 μs | 710.88 KB |
| ReverseXor             | 64     | 100    |  61.40 μs | 221.86 μs | 12.161 μs |  59.661 μs |  50.203 μs |  74.34 μs |  30.41 KB |
| StackReverse           | 64     | 100    | 238.36 μs | 501.57 μs | 27.493 μs | 235.990 μs | 212.136 μs | 266.97 μs |  88.22 KB |
| StringSpan             | 64     | 100    |  15.78 μs | 193.65 μs | 10.615 μs |  11.521 μs |   7.954 μs |  27.86 μs |  15.56 KB |
| StringExtensionReverse | 64     | 100    |  88.72 μs | 680.36 μs | 37.293 μs |  68.057 μs |  66.324 μs | 131.77 μs |  68.69 KB |
