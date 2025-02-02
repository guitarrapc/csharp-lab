```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.1 LTS (Noble Numbat)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.102
  [Host]   : .NET 9.0.1 (9.0.124.61010), X64 RyuJIT AVX2
  ShortRun : .NET 9.0.1 (9.0.124.61010), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method          | data                | Mean           | Error        | StdDev      | Min            | Max            | Gen0   | Allocated |
|---------------- |-------------------- |---------------:|-------------:|------------:|---------------:|---------------:|-------:|----------:|
| **MD5String**       | **KLVJ(...)0t2z [160]** |     **1,252.5 ns** |    **115.04 ns** |     **6.31 ns** |     **1,245.3 ns** |     **1,257.0 ns** | **0.0668** |    **1128 B** |
| SHA1String      | KLVJ(...)0t2z [160] |     1,453.7 ns |    300.48 ns |    16.47 ns |     1,437.8 ns |     1,470.7 ns | 0.0839 |    1416 B |
| SHA256String    | KLVJ(...)0t2z [160] |     1,675.1 ns |    192.01 ns |    10.52 ns |     1,669.0 ns |     1,687.2 ns | 0.1106 |    1856 B |
| SHA512String    | KLVJ(...)0t2z [160] |     2,637.2 ns |    173.91 ns |     9.53 ns |     2,630.5 ns |     2,648.1 ns | 0.1907 |    3240 B |
| XxHash32String  | KLVJ(...)0t2z [160] |       182.2 ns |     48.28 ns |     2.65 ns |       179.1 ns |       183.8 ns | 0.0348 |     584 B |
| XxHash64String  | KLVJ(...)0t2z [160] |       263.0 ns |     79.67 ns |     4.37 ns |       257.9 ns |       265.8 ns | 0.0434 |     728 B |
| XxHash128String | KLVJ(...)0t2z [160] |       482.6 ns |     27.08 ns |     1.48 ns |       481.5 ns |       484.3 ns | 0.0668 |    1128 B |
| **MD5Binary**       | **Byte[1048576]**       | **1,553,822.7 ns** |  **3,395.39 ns** |   **186.11 ns** | **1,553,666.2 ns** | **1,554,028.5 ns** |      **-** |      **41 B** |
| SHA1Binary      | Byte[1048576]       |   617,528.7 ns |    678.66 ns |    37.20 ns |   617,501.6 ns |   617,571.1 ns |      - |      49 B |
| SHA256Binary    | Byte[1048576]       |   659,664.0 ns | 20,319.69 ns | 1,113.79 ns |   658,461.4 ns |   660,660.1 ns |      - |      57 B |
| SHA512Binary    | Byte[1048576]       | 1,383,319.9 ns | 76,946.18 ns | 4,217.68 ns | 1,379,519.8 ns | 1,387,857.8 ns |      - |      89 B |
| XxHash32Binary  | Byte[1048576]       |   163,279.7 ns |  4,159.69 ns |   228.01 ns |   163,016.5 ns |   163,416.0 ns |      - |      32 B |
| XxHash64Binary  | Byte[1048576]       |    93,091.2 ns | 21,421.87 ns | 1,174.21 ns |    92,000.8 ns |    94,334.3 ns |      - |      32 B |
| XxHash128Binary | Byte[1048576]       |    32,939.5 ns |  3,533.77 ns |   193.70 ns |    32,821.0 ns |    33,163.0 ns |      - |      40 B |
