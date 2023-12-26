```

BenchmarkDotNet v0.13.11, Ubuntu 22.04.3 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.100
  [Host]   : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                       | Number | Mean         | Error        | StdDev     | Min          | Max          | Gen0   | Allocated |
|----------------------------- |------- |-------------:|-------------:|-----------:|-------------:|-------------:|-------:|----------:|
| **ToBinaryArrayInt**             | **1**      |     **18.09 ns** |     **3.651 ns** |   **0.200 ns** |     **17.87 ns** |     **18.26 ns** | **0.0004** |      **32 B** |
| ToBinaryArrayConvertToString | 1      |     65.33 ns |    17.427 ns |   0.955 ns |     64.62 ns |     66.42 ns | 0.0011 |      96 B |
| ToBinaryArrayIntMod          | 1      |     20.47 ns |     1.820 ns |   0.100 ns |     20.36 ns |     20.55 ns | 0.0004 |      32 B |
| ToBinaryArrayIntModNumber    | 1      |     10.85 ns |     0.944 ns |   0.052 ns |     10.79 ns |     10.89 ns | 0.0004 |      32 B |
| **ToBinaryArrayInt**             | **10**     |    **186.62 ns** |   **189.088 ns** |  **10.365 ns** |    **179.30 ns** |    **198.48 ns** | **0.0038** |     **320 B** |
| ToBinaryArrayConvertToString | 10     |    710.28 ns |   247.199 ns |  13.550 ns |    694.77 ns |    719.82 ns | 0.0114 |    1024 B |
| ToBinaryArrayIntMod          | 10     |    229.14 ns |    52.624 ns |   2.884 ns |    226.00 ns |    231.67 ns | 0.0038 |     320 B |
| ToBinaryArrayIntModNumber    | 10     |    152.40 ns |    60.036 ns |   3.291 ns |    148.84 ns |    155.33 ns | 0.0038 |     320 B |
| **ToBinaryArrayInt**             | **100**    |  **1,747.54 ns** |   **391.447 ns** |  **21.457 ns** |  **1,723.39 ns** |  **1,764.42 ns** | **0.0381** |    **3200 B** |
| ToBinaryArrayConvertToString | 100    |  7,248.84 ns |   277.927 ns |  15.234 ns |  7,232.53 ns |  7,262.70 ns | 0.1297 |   10928 B |
| ToBinaryArrayIntMod          | 100    |  2,158.16 ns |   953.626 ns |  52.271 ns |  2,119.99 ns |  2,217.73 ns | 0.0381 |    3200 B |
| ToBinaryArrayIntModNumber    | 100    |  2,059.90 ns |    72.344 ns |   3.965 ns |  2,055.64 ns |  2,063.49 ns | 0.0381 |    3200 B |
| **ToBinaryArrayInt**             | **255**    |  **4,420.95 ns** |   **346.832 ns** |  **19.011 ns** |  **4,405.58 ns** |  **4,442.20 ns** | **0.0916** |    **8160 B** |
| ToBinaryArrayConvertToString | 255    | 17,146.84 ns | 4,244.370 ns | 232.648 ns | 16,968.88 ns | 17,410.10 ns | 0.2747 |   23208 B |
| ToBinaryArrayIntMod          | 255    |  5,397.77 ns |   450.030 ns |  24.668 ns |  5,369.29 ns |  5,412.05 ns | 0.0916 |    8160 B |
| ToBinaryArrayIntModNumber    | 255    |  5,556.93 ns |   252.195 ns |  13.824 ns |  5,544.22 ns |  5,571.65 ns | 0.0916 |    8160 B |
