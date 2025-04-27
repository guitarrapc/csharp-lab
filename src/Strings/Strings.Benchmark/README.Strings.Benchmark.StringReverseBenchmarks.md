```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.2 LTS (Noble Numbat)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.203
  [Host]            : .NET 9.0.4 (9.0.425.16305), X64 RyuJIT AVX2
  ShortRun-.NET 8.0 : .NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
  ShortRun-.NET 9.0 : .NET 9.0.4 (9.0.425.16305), X64 RyuJIT AVX2

InvocationCount=1  IterationCount=3  LaunchCount=1  
UnrollFactor=1  WarmupCount=3  

```
| Method                 | Runtime  | Length | Number | Mean      | Error      | StdDev    | Median     | Min        | Max       | Allocated |
|----------------------- |--------- |------- |------- |----------:|-----------:|----------:|-----------:|-----------:|----------:|----------:|
| **ArrayReverse**           | **.NET 8.0** | **10**     | **100**    |  **11.75 μs** | **154.751 μs** |  **8.482 μs** |   **7.063 μs** |   **6.642 μs** |  **21.54 μs** |  **10.09 KB** |
| EnumerableReverse      | .NET 8.0 | 10     | 100    |  83.52 μs | 248.088 μs | 13.599 μs |  77.086 μs |  74.340 μs |  99.15 μs |  25.72 KB |
| RecursiveReverse       | .NET 8.0 | 10     | 100    |  42.33 μs | 252.119 μs | 13.820 μs |  37.299 μs |  31.729 μs |  57.96 μs |  33.53 KB |
| ReverseXor             | .NET 8.0 | 10     | 100    |  16.27 μs | 134.506 μs |  7.373 μs |  14.352 μs |  10.043 μs |  24.41 μs |  10.09 KB |
| StackReverse           | .NET 8.0 | 10     | 100    |  52.17 μs | 252.148 μs | 13.821 μs |  44.565 μs |  43.812 μs |  68.12 μs |  31.19 KB |
| StringSpan             | .NET 8.0 | 10     | 100    |  11.97 μs | 150.305 μs |  8.239 μs |   8.135 μs |   6.351 μs |  21.43 μs |   5.41 KB |
| StringExtensionReverse | .NET 8.0 | 10     | 100    |  46.54 μs | 427.726 μs | 23.445 μs |  40.547 μs |  26.681 μs |  72.41 μs |  28.84 KB |
| TextElementEnumerator  | .NET 8.0 | 10     | 100    |  65.96 μs | 106.641 μs |  5.845 μs |  65.592 μs |  60.312 μs |  71.98 μs |  10.09 KB |
| ArrayReverse           | .NET 9.0 | 10     | 100    |  14.78 μs | 188.552 μs | 10.335 μs |  11.672 μs |   6.352 μs |  26.31 μs |   9.81 KB |
| EnumerableReverse      | .NET 9.0 | 10     | 100    |  53.45 μs | 230.905 μs | 12.657 μs |  50.660 μs |  42.425 μs |  67.27 μs |  17.91 KB |
| RecursiveReverse       | .NET 9.0 | 10     | 100    |  48.02 μs | 583.890 μs | 32.005 μs |  34.425 μs |  25.058 μs |  84.58 μs |  33.53 KB |
| ReverseXor             | .NET 9.0 | 10     | 100    |  16.26 μs | 142.069 μs |  7.787 μs |  14.247 μs |   9.678 μs |  24.86 μs |  10.09 KB |
| StackReverse           | .NET 9.0 | 10     | 100    |  50.08 μs | 256.588 μs | 14.064 μs |  43.797 μs |  40.251 μs |  66.19 μs |  31.19 KB |
| StringSpan             | .NET 9.0 | 10     | 100    |  14.34 μs | 178.165 μs |  9.766 μs |   9.378 μs |   8.045 μs |  25.59 μs |   5.41 KB |
| StringExtensionReverse | .NET 9.0 | 10     | 100    |  51.24 μs | 246.403 μs | 13.506 μs |  47.198 μs |  40.214 μs |  66.30 μs |  17.91 KB |
| TextElementEnumerator  | .NET 9.0 | 10     | 100    |  58.62 μs | 119.654 μs |  6.559 μs |  58.951 μs |  51.908 μs |  65.01 μs |  10.09 KB |
| **ArrayReverse**           | **.NET 8.0** | **64**     | **100**    |  **17.73 μs** | **309.894 μs** | **16.986 μs** |   **7.979 μs** |   **7.870 μs** |  **37.35 μs** |  **30.41 KB** |
| EnumerableReverse      | .NET 8.0 | 64     | 100    | 346.07 μs | 373.042 μs | 20.448 μs | 354.735 μs | 322.715 μs | 360.76 μs |  59.31 KB |
| RecursiveReverse       | .NET 8.0 | 64     | 100    | 156.28 μs | 258.030 μs | 14.144 μs | 148.288 μs | 147.947 μs | 172.61 μs | 560.88 KB |
| ReverseXor             | .NET 8.0 | 64     | 100    |  71.94 μs | 274.940 μs | 15.070 μs |  68.073 μs |  59.185 μs |  88.57 μs |  30.41 KB |
| StackReverse           | .NET 8.0 | 64     | 100    | 236.72 μs | 527.825 μs | 28.932 μs | 233.292 μs | 209.659 μs | 267.22 μs |  88.22 KB |
| StringSpan             | .NET 8.0 | 64     | 100    |  13.46 μs | 193.430 μs | 10.603 μs |   7.564 μs |   7.112 μs |  25.70 μs |  15.56 KB |
| StringExtensionReverse | .NET 8.0 | 64     | 100    |  86.64 μs | 567.433 μs | 31.103 μs |  69.145 μs |  68.234 μs | 122.56 μs |  68.69 KB |
| TextElementEnumerator  | .NET 8.0 | 64     | 100    | 293.50 μs | 139.522 μs |  7.648 μs | 296.316 μs | 284.844 μs | 299.34 μs |  20.25 KB |
| ArrayReverse           | .NET 9.0 | 64     | 100    |  18.95 μs | 340.320 μs | 18.654 μs |   8.486 μs |   7.875 μs |  40.49 μs |  30.41 KB |
| EnumerableReverse      | .NET 9.0 | 64     | 100    | 141.25 μs | 650.539 μs | 35.658 μs | 125.517 μs | 116.169 μs | 182.07 μs |  38.22 KB |
| RecursiveReverse       | .NET 9.0 | 64     | 100    | 145.14 μs |   5.286 μs |  0.290 μs | 145.083 μs | 144.883 μs | 145.45 μs | 560.88 KB |
| ReverseXor             | .NET 9.0 | 64     | 100    |  64.08 μs | 283.859 μs | 15.559 μs |  59.983 μs |  50.986 μs |  81.28 μs |  30.41 KB |
| StackReverse           | .NET 9.0 | 64     | 100    | 235.20 μs | 395.431 μs | 21.675 μs | 227.608 μs | 218.340 μs | 259.65 μs |  88.22 KB |
| StringSpan             | .NET 9.0 | 64     | 100    |  12.99 μs | 190.601 μs | 10.447 μs |   7.043 μs |   6.883 μs |  25.06 μs |  15.56 KB |
| StringExtensionReverse | .NET 9.0 | 64     | 100    |  87.77 μs | 185.461 μs | 10.166 μs |  81.925 μs |  81.874 μs |  99.51 μs |  38.22 KB |
| TextElementEnumerator  | .NET 9.0 | 64     | 100    | 292.76 μs | 148.516 μs |  8.141 μs | 296.435 μs | 283.432 μs | 298.42 μs |  20.25 KB |
