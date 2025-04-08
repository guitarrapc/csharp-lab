```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.2 LTS (Noble Numbat)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.202
  [Host]            : .NET 9.0.3 (9.0.325.11113), X64 RyuJIT AVX2
  ShortRun-.NET 8.0 : .NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
  ShortRun-.NET 9.0 : .NET 9.0.3 (9.0.325.11113), X64 RyuJIT AVX2

InvocationCount=1  IterationCount=3  LaunchCount=1  
UnrollFactor=1  WarmupCount=3  

```
| Method                 | Runtime  | Length | Number | Mean      | Error       | StdDev    | Median     | Min        | Max       | Allocated |
|----------------------- |--------- |------- |------- |----------:|------------:|----------:|-----------:|-----------:|----------:|----------:|
| **ArrayReverse**           | **.NET 8.0** | **10**     | **100**    |  **16.69 μs** |   **195.89 μs** | **10.738 μs** |  **10.701 μs** |  **10.280 μs** |  **29.09 μs** |  **10.09 KB** |
| EnumerableReverse      | .NET 8.0 | 10     | 100    |  76.98 μs |   221.01 μs | 12.114 μs |  72.644 μs |  67.636 μs |  90.67 μs |  25.72 KB |
| RecursiveReverse       | .NET 8.0 | 10     | 100    |  50.95 μs |   454.57 μs | 24.916 μs |  42.198 μs |  31.598 μs |  79.07 μs |  33.53 KB |
| ReverseXor             | .NET 8.0 | 10     | 100    |  16.27 μs |   136.39 μs |  7.476 μs |  14.177 μs |  10.059 μs |  24.57 μs |  10.09 KB |
| StackReverse           | .NET 8.0 | 10     | 100    |  53.51 μs |   208.74 μs | 11.442 μs |  49.102 μs |  44.934 μs |  66.50 μs |  31.19 KB |
| StringSpan             | .NET 8.0 | 10     | 100    |  12.56 μs |   150.88 μs |  8.270 μs |   9.228 μs |   6.482 μs |  21.98 μs |   5.41 KB |
| StringExtensionReverse | .NET 8.0 | 10     | 100    |  35.66 μs |   285.25 μs | 15.635 μs |  26.684 μs |  26.584 μs |  53.72 μs |  28.84 KB |
| TextElementEnumerator  | .NET 8.0 | 10     | 100    |  60.99 μs |   212.81 μs | 11.665 μs |  56.384 μs |  52.337 μs |  74.26 μs |  10.09 KB |
| ArrayReverse           | .NET 9.0 | 10     | 100    |  12.57 μs |   135.83 μs |  7.445 μs |  10.490 μs |   6.393 μs |  20.84 μs |  10.09 KB |
| EnumerableReverse      | .NET 9.0 | 10     | 100    |  55.68 μs |    36.36 μs |  1.993 μs |  56.286 μs |  53.460 μs |  57.31 μs |  17.91 KB |
| RecursiveReverse       | .NET 9.0 | 10     | 100    |  30.15 μs |   244.40 μs | 13.396 μs |  24.876 μs |  20.198 μs |  45.38 μs |  33.53 KB |
| ReverseXor             | .NET 9.0 | 10     | 100    |  16.63 μs |   140.97 μs |  7.727 μs |  14.698 μs |  10.049 μs |  25.14 μs |  10.09 KB |
| StackReverse           | .NET 9.0 | 10     | 100    |  58.36 μs |   393.83 μs | 21.587 μs |  51.265 μs |  41.216 μs |  82.60 μs |  31.19 KB |
| StringSpan             | .NET 9.0 | 10     | 100    |  11.34 μs |   153.07 μs |  8.390 μs |   6.508 μs |   6.476 μs |  21.02 μs |   5.41 KB |
| StringExtensionReverse | .NET 9.0 | 10     | 100    |  35.68 μs |   146.80 μs |  8.047 μs |  33.222 μs |  29.154 μs |  44.67 μs |  17.63 KB |
| TextElementEnumerator  | .NET 9.0 | 10     | 100    |  56.80 μs |    64.82 μs |  3.553 μs |  57.588 μs |  52.919 μs |  59.89 μs |  10.09 KB |
| **ArrayReverse**           | **.NET 8.0** | **64**     | **100**    |  **17.00 μs** |   **265.28 μs** | **14.541 μs** |   **9.248 μs** |   **7.975 μs** |  **33.77 μs** |  **30.41 KB** |
| EnumerableReverse      | .NET 8.0 | 64     | 100    | 351.50 μs |   720.22 μs | 39.478 μs | 349.092 μs | 313.275 μs | 392.12 μs |  59.31 KB |
| RecursiveReverse       | .NET 8.0 | 64     | 100    | 163.66 μs |   243.52 μs | 13.348 μs | 160.359 μs | 152.265 μs | 178.34 μs | 560.88 KB |
| ReverseXor             | .NET 8.0 | 64     | 100    |  61.69 μs |   205.21 μs | 11.248 μs |  58.981 μs |  52.047 μs |  74.05 μs |  30.41 KB |
| StackReverse           | .NET 8.0 | 64     | 100    | 260.03 μs |   553.60 μs | 30.345 μs | 260.517 μs | 229.447 μs | 290.13 μs |  88.22 KB |
| StringSpan             | .NET 8.0 | 64     | 100    |  19.12 μs |   326.04 μs | 17.871 μs |  10.419 μs |   7.263 μs |  39.67 μs |  15.56 KB |
| StringExtensionReverse | .NET 8.0 | 64     | 100    | 111.18 μs |   649.88 μs | 35.622 μs | 126.345 μs |  70.481 μs | 136.70 μs |  68.69 KB |
| TextElementEnumerator  | .NET 8.0 | 64     | 100    | 360.17 μs | 1,560.51 μs | 85.537 μs | 315.819 μs | 305.921 μs | 458.78 μs |  20.25 KB |
| ArrayReverse           | .NET 9.0 | 64     | 100    |  26.46 μs |   503.42 μs | 27.594 μs |  10.669 μs |  10.379 μs |  58.32 μs |  30.41 KB |
| EnumerableReverse      | .NET 9.0 | 64     | 100    | 120.51 μs |   218.24 μs | 11.962 μs | 114.213 μs | 113.020 μs | 134.31 μs |  37.94 KB |
| RecursiveReverse       | .NET 9.0 | 64     | 100    | 187.48 μs |   456.11 μs | 25.001 μs | 199.161 μs | 158.776 μs | 204.50 μs | 560.88 KB |
| ReverseXor             | .NET 9.0 | 64     | 100    |  66.58 μs |   277.28 μs | 15.199 μs |  67.376 μs |  50.996 μs |  81.36 μs |  30.13 KB |
| StackReverse           | .NET 9.0 | 64     | 100    | 237.05 μs |   566.92 μs | 31.075 μs | 250.357 μs | 201.537 μs | 259.25 μs |  88.22 KB |
| StringSpan             | .NET 9.0 | 64     | 100    |  16.60 μs |   242.39 μs | 13.286 μs |   9.407 μs |   8.455 μs |  31.93 μs |  15.56 KB |
| StringExtensionReverse | .NET 9.0 | 64     | 100    |  75.68 μs |   237.98 μs | 13.044 μs |  69.454 μs |  66.919 μs |  90.67 μs |  38.22 KB |
| TextElementEnumerator  | .NET 9.0 | 64     | 100    | 311.07 μs |   236.05 μs | 12.939 μs | 311.782 μs | 297.786 μs | 323.63 μs |  20.25 KB |
