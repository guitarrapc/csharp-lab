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
| **ArrayReverse**           | **10**     | **100**    |  **14.82 μs** | **181.88 μs** |  **9.970 μs** |  **11.231 μs** |   **7.143 μs** |  **26.09 μs** |  **10.09 KB** |
| EnumerableReverse      | 10     | 100    |  82.48 μs | 197.02 μs | 10.799 μs |  78.977 μs |  73.867 μs |  94.60 μs |  25.72 KB |
| RecursiveReverse       | 10     | 100    |  43.16 μs | 371.49 μs | 20.363 μs |  31.855 μs |  30.963 μs |  66.67 μs |  56.97 KB |
| ReverseXor             | 10     | 100    |  18.37 μs | 183.94 μs | 10.083 μs |  14.697 μs |  10.640 μs |  29.77 μs |  10.09 KB |
| StackReverse           | 10     | 100    |  52.42 μs | 224.87 μs | 12.326 μs |  45.335 μs |  45.275 μs |  66.65 μs |  31.19 KB |
| StringSpan             | 10     | 100    |  13.86 μs | 202.59 μs | 11.105 μs |   7.664 μs |   7.233 μs |  26.68 μs |   5.41 KB |
| StringExtensionReverse | 10     | 100    |  35.83 μs | 275.08 μs | 15.078 μs |  27.671 μs |  26.589 μs |  53.23 μs |  28.84 KB |
| **ArrayReverse**           | **64**     | **100**    |  **18.64 μs** | **314.72 μs** | **17.251 μs** |   **8.906 μs** |   **8.465 μs** |  **38.56 μs** |  **30.41 KB** |
| EnumerableReverse      | 64     | 100    | 301.25 μs | 263.95 μs | 14.468 μs | 301.914 μs | 286.455 μs | 315.37 μs |  59.31 KB |
| RecursiveReverse       | 64     | 100    | 177.94 μs |  94.26 μs |  5.166 μs | 176.949 μs | 173.343 μs | 183.53 μs | 710.88 KB |
| ReverseXor             | 64     | 100    |  62.67 μs | 201.18 μs | 11.027 μs |  61.264 μs |  52.408 μs |  74.33 μs |  30.41 KB |
| StackReverse           | 64     | 100    | 258.99 μs | 514.74 μs | 28.215 μs | 255.837 μs | 232.483 μs | 288.65 μs |  88.22 KB |
| StringSpan             | 64     | 100    |  14.44 μs | 194.60 μs | 10.667 μs |   8.796 μs |   7.774 μs |  26.74 μs |  15.56 KB |
| StringExtensionReverse | 64     | 100    |  86.64 μs | 580.78 μs | 31.834 μs |  68.418 μs |  68.108 μs | 123.40 μs |  68.69 KB |
