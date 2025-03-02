```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.2 LTS (Noble Numbat)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.200
  [Host]            : .NET 9.0.2 (9.0.225.6610), X64 RyuJIT AVX2
  ShortRun-.NET 8.0 : .NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
  ShortRun-.NET 9.0 : .NET 9.0.2 (9.0.225.6610), X64 RyuJIT AVX2

IterationCount=3  LaunchCount=1  WarmupCount=3  

```
| Method          | Runtime  | data                | Mean           | Error         | StdDev      | Min            | Max            | Gen0   | Allocated |
|---------------- |--------- |-------------------- |---------------:|--------------:|------------:|---------------:|---------------:|-------:|----------:|
| **MD5String**       | **.NET 8.0** | **KLVJ(...)0t2z [160]** |     **1,235.1 ns** |     **114.19 ns** |     **6.26 ns** |     **1,229.7 ns** |     **1,242.0 ns** | **0.0668** |    **1128 B** |
| SHA1String      | .NET 8.0 | KLVJ(...)0t2z [160] |     1,447.8 ns |      70.25 ns |     3.85 ns |     1,444.7 ns |     1,452.1 ns | 0.0839 |    1416 B |
| SHA256String    | .NET 8.0 | KLVJ(...)0t2z [160] |     1,652.0 ns |      64.48 ns |     3.53 ns |     1,649.2 ns |     1,656.0 ns | 0.1106 |    1856 B |
| SHA512String    | .NET 8.0 | KLVJ(...)0t2z [160] |     2,544.4 ns |     345.43 ns |    18.93 ns |     2,530.2 ns |     2,565.9 ns | 0.1907 |    3240 B |
| XxHash32String  | .NET 8.0 | KLVJ(...)0t2z [160] |       197.7 ns |      22.32 ns |     1.22 ns |       196.7 ns |       199.1 ns | 0.0348 |     584 B |
| XxHash64String  | .NET 8.0 | KLVJ(...)0t2z [160] |       302.4 ns |      11.53 ns |     0.63 ns |       301.8 ns |       303.1 ns | 0.0434 |     728 B |
| XxHash128String | .NET 8.0 | KLVJ(...)0t2z [160] |       447.0 ns |      37.57 ns |     2.06 ns |       445.6 ns |       449.4 ns | 0.0672 |    1128 B |
| MD5String       | .NET 9.0 | KLVJ(...)0t2z [160] |     1,229.4 ns |      96.18 ns |     5.27 ns |     1,223.5 ns |     1,233.5 ns | 0.0668 |    1128 B |
| SHA1String      | .NET 9.0 | KLVJ(...)0t2z [160] |     1,393.6 ns |     184.68 ns |    10.12 ns |     1,381.9 ns |     1,399.6 ns | 0.0839 |    1416 B |
| SHA256String    | .NET 9.0 | KLVJ(...)0t2z [160] |     1,621.6 ns |     143.55 ns |     7.87 ns |     1,612.6 ns |     1,626.8 ns | 0.1106 |    1856 B |
| SHA512String    | .NET 9.0 | KLVJ(...)0t2z [160] |     2,560.9 ns |     165.54 ns |     9.07 ns |     2,551.9 ns |     2,570.0 ns | 0.1907 |    3240 B |
| XxHash32String  | .NET 9.0 | KLVJ(...)0t2z [160] |       174.8 ns |      24.61 ns |     1.35 ns |       173.4 ns |       176.1 ns | 0.0348 |     584 B |
| XxHash64String  | .NET 9.0 | KLVJ(...)0t2z [160] |       254.5 ns |      48.96 ns |     2.68 ns |       252.7 ns |       257.6 ns | 0.0434 |     728 B |
| XxHash128String | .NET 9.0 | KLVJ(...)0t2z [160] |       457.5 ns |      17.41 ns |     0.95 ns |       456.9 ns |       458.6 ns | 0.0672 |    1128 B |
| **MD5Binary**       | **.NET 8.0** | **Byte[1048576]**       | **1,554,424.9 ns** |  **11,790.91 ns** |   **646.30 ns** | **1,553,845.9 ns** | **1,555,122.1 ns** |      **-** |      **41 B** |
| SHA1Binary      | .NET 8.0 | Byte[1048576]       |   617,578.2 ns |   1,383.21 ns |    75.82 ns |   617,513.0 ns |   617,661.4 ns |      - |      49 B |
| SHA256Binary    | .NET 8.0 | Byte[1048576]       |   659,171.3 ns |  12,722.30 ns |   697.35 ns |   658,367.4 ns |   659,614.3 ns |      - |      57 B |
| SHA512Binary    | .NET 8.0 | Byte[1048576]       | 1,385,508.9 ns | 181,635.43 ns | 9,956.05 ns | 1,379,663.1 ns | 1,397,004.6 ns |      - |      89 B |
| XxHash32Binary  | .NET 8.0 | Byte[1048576]       |   163,217.8 ns |   2,066.77 ns |   113.29 ns |   163,125.3 ns |   163,344.1 ns |      - |      32 B |
| XxHash64Binary  | .NET 8.0 | Byte[1048576]       |    92,107.7 ns |   3,926.94 ns |   215.25 ns |    91,963.1 ns |    92,355.0 ns |      - |      32 B |
| XxHash128Binary | .NET 8.0 | Byte[1048576]       |    65,825.1 ns |   9,654.43 ns |   529.19 ns |    65,509.1 ns |    66,436.0 ns |      - |      40 B |
| MD5Binary       | .NET 9.0 | Byte[1048576]       | 1,553,651.0 ns |   2,109.58 ns |   115.63 ns | 1,553,531.3 ns | 1,553,762.1 ns |      - |      41 B |
| SHA1Binary      | .NET 9.0 | Byte[1048576]       |   617,508.3 ns |   4,367.33 ns |   239.39 ns |   617,287.1 ns |   617,762.5 ns |      - |      49 B |
| SHA256Binary    | .NET 9.0 | Byte[1048576]       |   660,470.4 ns |  13,295.31 ns |   728.76 ns |   659,941.6 ns |   661,301.7 ns |      - |      57 B |
| SHA512Binary    | .NET 9.0 | Byte[1048576]       | 1,384,778.3 ns | 133,898.92 ns | 7,339.45 ns | 1,380,040.3 ns | 1,393,232.6 ns |      - |      89 B |
| XxHash32Binary  | .NET 9.0 | Byte[1048576]       |   163,283.1 ns |   6,261.90 ns |   343.24 ns |   163,044.2 ns |   163,676.5 ns |      - |      32 B |
| XxHash64Binary  | .NET 9.0 | Byte[1048576]       |    92,045.8 ns |   4,556.50 ns |   249.76 ns |    91,892.2 ns |    92,333.9 ns |      - |      32 B |
| XxHash128Binary | .NET 9.0 | Byte[1048576]       |    33,991.3 ns |   9,298.99 ns |   509.71 ns |    33,666.9 ns |    34,578.8 ns |      - |      40 B |
